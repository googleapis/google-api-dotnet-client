/*
Copyright 2010 Google Inc

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
using System.Net.Http;
using System.Threading.Tasks;

using Google.Apis.Discovery;
using Google.Apis.Http;
using Google.Apis.Requests;

namespace Google.Apis.Services
{
    /// <summary>
    /// Client service contains all the necessary information a Google service requires. 
    /// Each concrete <see cref="Google.Apis.Requests.IClientServiceRequest"/> has a reference to a service for 
    /// important properties like API key, application name, base Uri, etc.
    /// This service interface also contains serialization methods to serialize an object to stream and deserialize a 
    /// stream into an object.
    /// </summary>
    public interface IClientService : IDisposable
    {
        /// <summary>Gets the HTTP client which is used to create requests.</summary>
        ConfigurableHttpClient HttpClient { get; }

        /// <summary>
        /// Gets a HTTP client initializer which is able to custom properties on 
        /// <see cref="Google.Apis.Http.ConfigurableHttpClient"/> and 
        /// <see cref="Google.Apis.Http.ConfigurableMessageHandler"/>.
        /// </summary>
        IConfigurableHttpClientInitializer HttpClientInitializer { get; }

        /// <summary>Gets the service name.</summary>
        string Name { get; }

        /// <summary>Gets the BaseUri of the service. All request paths should be relative to this URI.</summary>
        string BaseUri { get; }

        /// <summary>Gets the BasePath of the service.</summary>
        string BasePath { get; }

        /// <summary>Gets the supported features by this service.</summary>
        IList<string> Features { get; }

        /// <summary>Gets or sets whether this service supports GZip.</summary>
        bool GZipEnabled { get; }

        /// <summary>Gets the API-Key (DeveloperKey) which this service uses for all requests.</summary>
        string ApiKey { get; }

        /// <summary>Gets the application name to be used in the User-Agent header.</summary>
        string ApplicationName { get; }

        /// <summary>
        /// Sets the content of the request by the given body and the this service's configuration. 
        /// First the body object is serialized by the Serializer and then, if GZip is enabled, the content will be
        /// wrapped in a GZip stream, otherwise a regular string stream will be used.
        /// </summary>
        void SetRequestSerailizedContent(HttpRequestMessage request, object body);

        #region Serialization Methods

        /// <summary>Gets the Serializer used by this service.</summary>
        ISerializer Serializer { get; }

        /// <summary>Serializes an object into a string representation.</summary>
        string SerializeObject(object data);

        /// <summary>Deserializes a response into the specified object.</summary>
        Task<T> DeserializeResponse<T>(HttpResponseMessage response);

        /// <summary>Deserializes an error response into a <see cref="RequestError"/> object.</summary>
        /// <exception cref="GoogleApiException">If no error is found in the response.</exception>
        Task<RequestError> DeserializeError(HttpResponseMessage response);

        #endregion
    }
}
