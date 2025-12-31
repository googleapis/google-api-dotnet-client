using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Google.Apis.Requests
{
    class JsonStreamContent : HttpContent
    {
        readonly object data;
        readonly ISerializer serializer;
        readonly bool isGzipEnabled;

        public JsonStreamContent(object data, ISerializer serializer, bool isGzipEnabled)
        {
            this.data = data;
            this.serializer = serializer;
            this.isGzipEnabled = isGzipEnabled;

            Headers.ContentType = new MediaTypeHeaderValue("application/" + serializer.Format)
            {
                CharSet = Encoding.UTF8.WebName
            };
            if (isGzipEnabled)
            {
                Headers.ContentEncoding.Add("gzip");
            }
        }

        protected override async Task SerializeToStreamAsync(Stream stream, TransportContext context)
        {
            // We do not want to dispose the passed in stream, it's lifetime is controlled by the HttpClient that
            // created it. We only want to dispose any streams we create ourselves here.
            if (isGzipEnabled)
            {
                using var gzipStream = new GZipStream(stream, CompressionMode.Compress, true);
                serializer.Serialize(data, gzipStream, true);
                await gzipStream.FlushAsync().ConfigureAwait(false);
            }
            else
            {
                serializer.Serialize(data, stream, true);
            }
        }

        protected override bool TryComputeLength(out long length)
        {
            // We do not know the length
            length = -1;
            return false;
        }
    }
}