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

using System.Collections.Generic;

using Google.Apis.Authentication;
using Google.Apis.Requests;

namespace Google.Apis.Discovery
{
    /// <summary>
    /// Implementors of this interface are able to create arbitory requests against a service
    /// resource name and method, as well as to create and retrieve information related to a request.
    /// </summary>
    public interface IClientService
    {
        /// <summary>
        /// The service name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The BaseUri of the service. All request paths should be relative to this URI.
        /// </summary>
        string BaseUri { get; }

        /// <summary>
        /// The Authenticator for this service.
        /// </summary>
        IAuthenticator Authenticator { get; }

        /// <summary>
        /// The supported features by this service.
        /// </summary>
        IList<string> Features { get; }

        /// <summary>
        /// The common parameters information for this service.
        /// </summary>
        IDictionary<string, IParameter> ServiceParameters { get; }

        /// <summary>
        /// True if GZip is supported by this service.
        /// </summary>
        bool GZipEnabled { get; }

        /// <summary>
        /// API-Key (DeveloperKey) which this service uses for all requests.
        /// </summary>
        string ApiKey { get; }

        /// <summary>
        /// Creates a request with the specified settings.
        /// </summary>
        IRequest CreateRequest(IClientServiceRequest request);

        #region Serialization Methods

        /// <summary>
        /// The serializer used by this service.
        /// </summary>
        ISerializer Serializer { get; }

        /// <summary>
        /// Serializes an object into a string representation.
        /// </summary>
        string SerializeObject(object data);

        /// <summary>
        /// Deserializes a response into the specified object.
        /// </summary>
        T DeserializeResponse<T>(IResponse response);

        /// <summary>
        /// Deserializes an error response into a <see cref="RequestError"/> object
        /// </summary>
        /// <exception cref="GoogleApiException">If no error is found in the response.</exception>
        /// <param name="input"><see cref="IResponse"/> containing an error.</param>
        /// <returns>The <see cref="RequestError"/> object deserialized from the stream.</returns>
        RequestError DeserializeError(IResponse input);

        #endregion
    }
}