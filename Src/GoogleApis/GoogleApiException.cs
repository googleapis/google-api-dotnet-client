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
using System.Net;

using Google.Apis.Requests;
using Google.Apis.Util;

namespace Google
{
    /// <summary>
    /// Represents an exception thrown by an API Service.
    /// </summary>
    public class GoogleApiException : Exception
    {
        private readonly string serivceName;

        /// <summary>
        /// Creates an API Service exception.
        /// </summary>
        public GoogleApiException(string serviceName, string message, Exception inner)
            : base(message, inner)
        {
            serviceName.ThrowIfNull("serviceName");
            this.serivceName = serviceName;
        }

        /// <summary>
        /// Creates an API Service exception
        /// </summary>
        public GoogleApiException(string serviceName, string message) : this(serviceName, message, null) { }

        /// <summary>
        /// The http status code which was returned along with this error,
        /// or 0 if unavailable.
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; set; }

        public override string ToString()
        {
            return string.Format("The service {1} has thrown an exception: {0}", base.ToString(), serivceName);
        }
    }

    /// <summary>
    /// Represents an exception thrown by an api request executed on a service.
    /// </summary>
    public class GoogleApiRequestException : GoogleApiException
    {
        /// <summary>
        /// Creates an API Request Exception.
        /// </summary>
        public GoogleApiRequestException(string serviceName, IRequest request, RequestError error, Exception inner)
            : base(serviceName, PickMessage(error, inner), inner)
        {
            Request = request;
            RequestError = error;
        }

        /// <summary>
        /// Creates an API Request Exception.
        /// </summary>
        public GoogleApiRequestException(string serviceName, IRequest request, RequestError error)
            : base(serviceName, PickMessage(error, null))
        {
            Request = request;
            RequestError = error;
        }

        private static string PickMessage(RequestError error, Exception inner)
        {
            if (error != null)
            {
                return error.ToString();
            }
            if (inner != null)
            {
                return inner.Message;
            }
            return "An error has ocurred, but no message is available.";
        }

        /// <summary>
        /// The request which caused this error.
        /// </summary>
        public IRequest Request { get; private set; }

        /// <summary>
        /// The error message included with this response.
        /// </summary>
        public RequestError RequestError { get; private set; }

        public override string ToString()
        {
            return string.Format(
                "The request '{1}' has failed. {0}", base.ToString(), Request);
        }
    }
}