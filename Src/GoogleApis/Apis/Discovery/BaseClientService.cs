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

using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Google.Apis.Authentication;
using Google.Apis.Json;
using Google.Apis.Requests;
using Google.Apis.Util;


namespace Google.Apis.Discovery
{
    /// <summary>
    /// A safe thread base class for a client service which provides common mechanizm for all services, like 
    /// serialization and gzip support.
    /// </summary>
    public abstract class BaseClientService : IClientService
    {
        #region Initializer

        /// <summary> An initializer class for the client service.
        /// </summary>
        public class Initializer
        {
            /// <summary>
            /// Gets and Sets the gzip enabled support.
            /// </summary>
            public bool GZipEnabled { get; set; }

            /// <summary>
            /// Gets and Sets the Serializer.
            /// </summary>
            public ISerializer Serializer { get; set; }

            /// <summary>
            /// Gets and Sets the API Key.
            /// </summary>
            public string ApiKey { get; set; }


            /// <summary>
            /// Gets and Sets the Authenticator.
            /// </summary>
            public IAuthenticator Authenticator { get; set; }

            /// <summary>
            /// Constructs a new initializer with default values.
            /// <code>GZipEnabled</code> is set to <code>true</code>, the <code>Serializer</code> is set to 
            /// <code>NewtonsoftJsonSerializer</code> and <code>NullAuthenticator.Instance</code> is set as the
            /// initializer's <code>Authenticator</code>
            /// </summary>
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
            _gzipEnabled = initializer.GZipEnabled;
            _serializer = initializer.Serializer;
            _apiKey = initializer.ApiKey;
            _authenticator = initializer.Authenticator;
        }

        private readonly string _apiKey;
        private readonly bool _gzipEnabled = true;
        private readonly ISerializer _serializer;
        private readonly IAuthenticator _authenticator;

        /// <summary>
        /// Return true if this service contains the specified feature.
        /// </summary>
        private bool HasFeature(Features feature)
        {
            return Features.Contains(feature.GetStringValue());
        }

        #region IClientService Members

        public bool GZipEnabled
        {
            get
            {
#if SILVERLIGHT
                return false;
#endif
                return _gzipEnabled;
            }
        }

        public string ApiKey
        {
            get { return _apiKey; }
        }

        public IAuthenticator Authenticator
        {
            get { return _authenticator; }
        }

        #region Serialization

        public ISerializer Serializer
        {
            get { return _serializer; }

        }

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

        public virtual T DeserializeResponse<T>(IResponse input)
        {
            input.ThrowIfNull("input");
            input.Stream.ThrowIfNull("input.Stream");
            Serializer.ThrowIfNull("Serializer");

            // Read in the entire content.
            string text = input.ReadToEnd();

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
                StandardResponse<T> response;
                try
                {
                    response = Serializer.Deserialize<StandardResponse<T>>(text);
                }
                catch (JsonReaderException ex)
                {
                    throw new GoogleApiException(Name, "Failed to parse response from server as json [" + text + "]",
                        ex);
                }

                if (response.Error != null)
                {
                    throw new GoogleApiException(Name, "Server error - " + response.Error);
                }

                if (response.Data == null)
                {
                    throw new GoogleApiException(Name, "The response could not be deserialized.");
                }

                return response.Data;
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

            // If this schema/object provides an error container, check it.
            if (result is IDirectResponseSchema)
            {
                var response = (IDirectResponseSchema)result;

                // Set the e-tag.
                response.ETag = input.ETag;
            }

            return result;
        }

        public virtual RequestError DeserializeError(IResponse input)
        {
            Serializer.ThrowIfNull("Serializer");
            input.ThrowIfNull("input");
            input.Stream.ThrowIfNull("input.Stream");

            // Read in the entire content.
            var response = Serializer.Deserialize<StandardResponse<object>>(input.ReadToEnd());
            if (response.Error == null)
            {
                throw new GoogleApiException(Name,
                    "An Error occured, but the error response could not be deserialized.");
            }

            return response.Error;
        }

        #endregion

        #region Abstract Memebrs

        public abstract string Name { get; }
        public abstract string BaseUri { get; }
        public abstract IList<string> Features { get; }
        public abstract IDictionary<string, IParameter> ServiceParameters { get; }

        public abstract IRequest CreateRequest(IClientServiceRequest request);

        #endregion

        #endregion
    }
}
