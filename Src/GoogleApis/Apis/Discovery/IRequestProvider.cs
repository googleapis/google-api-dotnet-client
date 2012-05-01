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

using Google.Apis.Requests;

namespace Google.Apis.Discovery
{
    /// <summary>
    /// Implementors of this interface are able to create arbitory requests against a service
    /// resource name and method, as well as to create and retrieve information related to a request.
    /// </summary>
    public interface IRequestProvider
    {
        /// <summary>
        /// Creates a request with the specified settings.
        /// </summary>
        IRequest CreateRequest(string resource, string method);

        /// <summary>
        /// Serializes an object into a string representation.
        /// </summary>
        string SerializeObject(object data);

        /// <summary>
        /// Deserializes a response into the specified object.
        /// </summary>
        T DeserializeResponse<T>(IResponse response);

        /// <summary>
        /// The BaseUri of the service. All request paths should be relative to this URI.
        /// </summary>
        string BaseUri { get; }

        /// <summary>
        /// The Authenticator for this service.
        /// </summary>
        Google.Apis.Authentication.IAuthenticator Authenticator { get; }
    }
}