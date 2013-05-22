/*
Copyright 2013 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Ionic.Zlib;
using Newtonsoft.Json;

using Google.Apis.Authentication;
using Google.Apis.Discovery;
using Google.Apis.Http;
using Google.Apis.Json;
using Google.Apis.Logging;
using Google.Apis.Requests;
using Google.Apis.Util;

namespace Google.Apis.Services
{
    /// <summary>
    /// A thread-safe base class for a client service which provides common mechanism for all services, like 
    /// serialization and GZip support.
    /// This class adds a special <see cref="Google.Apis.Http.IHttpExecuteInterceptor"/> to the 
    /// <see cref="Google.Apis.Http.ConfigurableMessageHandler"/> execute interceptor list, which uses the given 
    /// Authenticator. It calls to its applying authentication method, and injects the "Authorization" header in the 
    /// request.
    /// If the given Authenticator implements <see cref="Google.Apis.Http.IUnsuccessfulReponseHandler"/>, this class
    /// adds the Authenticator to the <see cref="Google.Apis.Http.ConfigurableMessageHandler"/>'s unsuccessful response
    /// handler list.
    /// </summary>
    public abstract class BaseClientService : IClientService
    {
        /// <summary> The class logger. </summary>
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<BaseClientService>();

        #region Initializer

        /// <summary> An initializer class for the client service.
        /// </summary>
        public class Initializer
        {
            /// <summary> 
            /// A factory for creating <see cref="System.Net.Http.HttpClient"/> instance. If this property is not set
            /// the service uses a new <see cref="Google.Apis.Http.HttpClientFactory"/> instance.
            /// </summary>
            public IHttpClientFactory HttpClientFactory { get; set; }

            /// <summary>
            /// An Http client initializer which is able to customize properties on 
            /// <see cref="Google.Apis.Http.ConfigurableHttpClient"/> and 
            /// <see cref="Google.Apis.Http.ConfigurableMessageHandler"/>.
            /// </summary>
            public IConfigurableHttpClientInitializer HttpClientInitializer { get; set; }

            /// <summary> Gets and Sets whether this service supports GZip. Default value is <c>true</c>. </summary>
            public bool GZipEnabled { get; set; }

            /// <summary>
            /// Gets and Sets the Serializer. Default value is <see cref="Google.Apis.Json.NewtonsoftJsonSerializer"/>.
            /// </summary>
            public ISerializer Serializer { get; set; }

            /// <summary> Gets and Sets the API Key. Default value is <c>null</c>. </summary>
            public string ApiKey { get; set; }

            /// <summary> 
            /// Gets and Sets the Authenticator. Default value is 
            /// <see cref="Google.Apis.Authentication.NullAuthenticator.Instance"/>.
            /// </summary>
            public IAuthenticator Authenticator { get; set; }

            /// <summary> 
            /// Gets and sets Application name to be used in the User-Agent header. Default value is <c>null</c>. 
            /// </summary>
            public string ApplicationName { get; set; }

            /// <summary> Constructs a new initializer with default values. </summary>
            public Initializer()
            {
                GZipEnabled = true;
                Serializer = new NewtonsoftJsonSerializer();
                Authenticator = NullAuthenticator.Instance;
            }
        }

        #endregion

        /// <summary>
        /// Constructs a new base client with the specified initializer
        /// </summary>
        protected BaseClientService(Initializer initializer)
        {
            // sets the right properties by the initializer's properties
            GZipEnabled = initializer.GZipEnabled;
            Serializer = initializer.Serializer;
            ApiKey = initializer.ApiKey;
            Authenticator = initializer.Authenticator;
            ApplicationName = initializer.ApplicationName;
            if (ApplicationName == null)
            {
                Logger.Warning("Application name is not set. Please set Initializer.ApplicationName property");
            }
            HttpClientInitializer = initializer.HttpClientInitializer;

            // create an Http client for this service
            HttpClient = CreateHttpClient(initializer);
        }

        /// <summary>
        /// Return true if this service contains the specified feature.
        /// </summary>
        private bool HasFeature(Features feature)
        {
            return Features.Contains(feature.GetStringValue());
        }

        #region IClientService Members

        private ConfigurableHttpClient CreateHttpClient(Initializer initializer)
        {
            // if factory wasn't set use the default Http client factory
            var factory = initializer.HttpClientFactory ?? new HttpClientFactory();
            var args = new CreateHttpClientArgs
                {
                    GZipEnabled = GZipEnabled,
                    ApplicationName = ApplicationName,
                };

            // add initializers
            if (HttpClientInitializer != null)
            {
                args.Initializers.Add(HttpClientInitializer);
            }
            args.Initializers.Add(new AuthenticatorMessageHandlerInitializer(Authenticator));

            return factory.CreateHttpClient(args);
        }

        public ConfigurableHttpClient HttpClient { get; private set; }

        public IConfigurableHttpClientInitializer HttpClientInitializer { get; private set; }

        public bool GZipEnabled { get; private set; }

        public string ApiKey { get; private set; }

        public IAuthenticator Authenticator { get; private set; }

        public string ApplicationName { get; private set; }

        public void SetRequestSerailizedContent(HttpRequestMessage request, object body)
        {
            if (body == null)
            {
                return;
            }

            HttpContent content = null;

            var mediaType = "application/" + Serializer.Format;
            var serializedObject = SerializeObject(body);
            if (GZipEnabled)
            {
                var stream = CreateGZipStream(serializedObject);
                content = new StreamContent(stream);
                content.Headers.ContentEncoding.Add("gzip");
                content.Headers.ContentType = new MediaTypeHeaderValue(mediaType)
                    {
                        CharSet = Encoding.UTF8.WebName
                    };
            }
            else
            {
                content = new StringContent(serializedObject, Encoding.UTF8, mediaType);
            }

            request.Content = content;
        }

        #region Serialization

        public ISerializer Serializer { get; private set; }

        public virtual string SerializeObject(object obj)
        {
            if (HasFeature(Discovery.Features.LegacyDataResponse))
            {
                // Legacy path
                var request = new StandardResponse<object> { Data = obj };
                return Serializer.Serialize(request);
            }

            // New v1.0 path
            return Serializer.Serialize(obj);
        }

        public virtual async Task<T> DeserializeResponse<T>(HttpResponseMessage response)
        {
            var text = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            // If a string is request, don't parse the response.
            if (typeof(T).Equals(typeof(string)))
            {
                return (T)(object)text;
            }

            // Check if there was an error returned. The error node is returned in both paths
            // Deserialize the stream based upon the format of the stream.
            if (HasFeature(Discovery.Features.LegacyDataResponse))
            {
                // Legacy path (deprecated!)
                StandardResponse<T> sr = null;
                try
                {
                    sr = Serializer.Deserialize<StandardResponse<T>>(text);
                }
                catch (JsonReaderException ex)
                {
                    throw new GoogleApiException(Name,
                        "Failed to parse response from server as json [" + text + "]", ex);
                }

                if (sr.Error != null)
                {
                    throw new GoogleApiException(Name, "Server error - " + sr.Error);
                }

                if (sr.Data == null)
                {
                    throw new GoogleApiException(Name, "The response could not be deserialized.");
                }
                return sr.Data;
            }

            // New path: Deserialize the object directly.
            T result = default(T);
            try
            {
                result = Serializer.Deserialize<T>(text);
            }
            catch (JsonReaderException ex)
            {
                throw new GoogleApiException(Name, "Failed to parse response from server as json [" + text + "]", ex);
            }

            // TODO(peleyal): is this the right place to check ETag? it isn't part of deserialization!
            // If this schema/object provides an error container, check it.
            var eTag = response.Headers.ETag != null ? response.Headers.ETag.Tag : null;
            if (result is IDirectResponseSchema && eTag != null)
            {
                (result as IDirectResponseSchema).ETag = eTag;
            }
            return result;
        }

        public virtual async Task<RequestError> DeserializeError(HttpResponseMessage response)
        {
            var str = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var errorResponse = Serializer.Deserialize<StandardResponse<object>>(str);
            if (errorResponse.Error == null)
            {
                throw new GoogleApiException(Name,
                    "An Error occurred, but the error response could not be deserialized");
            }
            return errorResponse.Error;
        }

        #endregion

        #region Abstract Memebrs

        public abstract string Name { get; }
        public abstract string BaseUri { get; }
        public abstract string BasePath { get; }

        public abstract IList<string> Features { get; }
        public abstract IDictionary<string, IParameter> ServiceParameters { get; }

        #endregion

        #endregion

        /// <summary> Creates a GZip stream by the given serialized object. </summary>
        private static Stream CreateGZipStream(string serializedObject)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(serializedObject);
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                using (GZipStream gzip = new GZipStream(ms, CompressionMode.Compress, true))
                {
                    gzip.Write(bytes, 0, bytes.Length);
                }

                // reset the stream to the beginning. It doesn't work otherwise!
                ms.Position = 0;
                byte[] compressed = new byte[ms.Length];
                ms.Read(compressed, 0, compressed.Length);
                return new MemoryStream(compressed);
            }
        }

        public virtual void Dispose()
        {
            if (HttpClient != null)
            {
                HttpClient.Dispose();
            }
        }
    }
}
