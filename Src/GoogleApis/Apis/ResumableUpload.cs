using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Google.Apis.Authentication;
using Google.Apis.Discovery;


namespace Google.Apis.Upload
{
    /// <summary>
    /// Enum to communicate the status of an upload for progress reporting.
    /// </summary>
    public enum UploadStatus
    {
        NotStarted,
        Starting,
        Uploading,
        Completed,
        Failed
    };

    public interface IUploadProgress
    {
        UploadStatus Status { get; }
        long BytesSent { get; }
    }

    public abstract class ResumableUpload<T>
    {
        // Chunks (except the last chunk) must be a multiple of 256KB to be compatible with
        // Google upload servers.
        private const int MinimumChunkSize = 262144; // 256 KB

        // Buffer size is used to read chunks from the input stream and write to the output stream.
        // TODO: Improve the read/write scheme to remove the buffer altogether and simply pipe the
        //       input to the request.
        private const int BufferSize = 16384; // 16 KB

        protected IAuthenticator Authenticator { get; private set; }
        protected HttpRequestFactory HttpRequestFactory { get; private set; }

        protected ResumableUpload(Google.Apis.Authentication.IAuthenticator authenticator, 
            Stream stream, string contentType)
        {
            this.HttpRequestFactory = new HttpRequestFactory();
            this.Authenticator = authenticator;
            this.ChunkSize = MinimumChunkSize;
            this.Stream = stream;
            this.ContentType = contentType;
        }

        private Stream Stream { get; set; }
        public string ContentType { get; private set; }

        #region Progress Monitoring

        private class ResumableUploadProgress : IUploadProgress
        {
            public ResumableUploadProgress(UploadStatus status, long bytesSent)
            {
                this.Status = status;
                this.BytesSent = bytesSent;
            }

            public UploadStatus Status { get; private set; }
            public long BytesSent { get; private set; }
        }

        private ResumableUploadProgress Progress { get; set; }

        public event Action<IUploadProgress> ProgressChanged;

        public void UpdateProgress(UploadStatus status, long byteCount)
        {
            var p = new ResumableUploadProgress(status, byteCount);
            this.Progress = p;
            if(ProgressChanged != null)
                ProgressChanged(p);
        }

        public IUploadProgress GetProgress()
        {
            return this.Progress;
        }

        #endregion

        public void Upload(Stream payload)
        {
            long bytesSent = 0;
            try
            {
                UpdateProgress(UploadStatus.Starting, 0);
                string url = InitializeUpload(payload);
                UpdateProgress(UploadStatus.Uploading, 0);
                while (bytesSent < payload.Length)
                {
                    long chunkSize = Math.Min(payload.Length - bytesSent, ChunkSize);
                    SendChunk(url, payload, bytesSent, chunkSize);
                    bytesSent += chunkSize;
                    UpdateProgress(UploadStatus.Uploading, bytesSent);
                }
                UpdateProgress(UploadStatus.Completed, bytesSent);
            }
            catch (WebException we)
            {
                var responseStream = we.Response.GetResponseStream();
                if (responseStream == null)
                    throw;
                string r = (new StreamReader(responseStream)).ReadToEnd();
                var x = Json.JsonReader.Parse(r) as Json.JsonDictionary;
                if (x.ContainsKey("error"))
                {
                    var y = x["error"] as Json.JsonDictionary;
                    if (y.ContainsKey("message"))
                    {
                        throw new Exception(y["message"] as string);
                    }
                }
            }
            catch (Exception ex)
            {
                try
                {
                    UpdateProgress(UploadStatus.Failed, bytesSent);
                }
                catch (Exception) { }
                throw;
            }
        }

        /// <summary>
        /// Initializes the resumable upload by calling the resumable rest interface to get
        /// a unique upload Location
        /// </summary>
        /// <returns>
        /// The unique upload location for this upload, returned in the Location header
        /// </returns>
        private string InitializeUpload(Stream payload)
        {
            var request = BuildInitRequest();
            request.ServicePoint.Expect100Continue = false;
            request.Headers.Add("X-Upload-Content-Type", "image/jpeg");
            request.Headers.Add("X-Upload-Content-Length", payload.Length.ToString());
            Authenticator.ApplyAuthenticationToRequest(request);

            var j = new Json.NewtonsoftJsonSerializer();
            var o = j.Serialize(this.GetRequestBody());
            byte[] body = Encoding.UTF8.GetBytes(o);
            request.ContentType = "application/json";
            request.ContentLength = body.Length;

            var s = request.GetRequestStream();
            s.Write(body, 0, body.Length);

            WebResponse response = request.GetResponse();
            return response.Headers["Location"];
        }

        /// <summary>
        /// The size of each chunk sent to the servers.
        /// </summary>
        /// <remarks>
        /// This property is currently private, though it might be made public in the future if needed.
        /// Currently, google's resumable upload.
        /// </remarks>
        private int ChunkSize { get; set; }

        protected virtual void SendChunk(string url, Stream payload, long position, long chunkSize)
        {
            byte[] buffer = new byte[BufferSize]; // 8KB buffer
            var req = CreateChunkRequest(url);
            req.ContentLength = chunkSize;
            req.Headers.Add("Content-Range", String.Format("bytes {0}-{1}/{2}", position, position + chunkSize - 1, payload.Length));

            try
            {
                Stream requestStream = req.GetRequestStream();

                int dataWritten = 0;
                while (dataWritten < chunkSize)
                {
                    int len = payload.Read(buffer, 0, buffer.Length);
                    requestStream.Write(buffer, 0, len);
                    dataWritten += len;
                }

                var response = req.GetResponse();
            }
            catch (WebException we)
            {
                var response = we.Response as HttpWebResponse;
                if(response == null || response.StatusCode != (HttpStatusCode)308)
                    throw;
            }
        }

        protected virtual HttpWebRequest CreateChunkRequest(string url)
        {
            var request = HttpWebRequest.Create(url) as HttpWebRequest;
            request.Method = "PUT";
            return request;
        }

        protected abstract HttpWebRequest BuildInitRequest();

        protected abstract string MethodName { get; }

        protected abstract object GetRequestBody();
    }
}
