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
    /// <summary>Represents an exception thrown by an API Service.</summary>
    public class GoogleApiException : Exception
    {
        private readonly bool _hasMessage;

        /// <summary>Gets the service name which related to this exception.</summary>
        public string ServiceName { get; }

        /// <summary>Creates an API Service exception.</summary>
        public GoogleApiException(string serviceName, string message, Exception inner)
            : base(message, inner)
        {
            ServiceName = serviceName.ThrowIfNull(nameof(serviceName));
            _hasMessage = message is object;
        }

        /// <summary>Creates an API Service exception.</summary>
        public GoogleApiException(string serviceName, string message) : this(serviceName, message, null)
        { }

        /// <summary>
        /// Creates an API Service exception with no message.
        /// </summary>
        /// <remarks>
        /// <see cref="Message"/> may still contain useful information if the
        /// <see cref="Error"/> and/or <see cref="HttpStatusCode"/> properties are set.
        /// </remarks>
        public GoogleApiException(string serviceName) : this(serviceName, null, null)
        { }

        /// <summary>The Error which was returned from the server, or <c>null</c> if unavailable.</summary>
        public RequestError Error { get; set; }

        private string ErrorMessage =>
            Error?.Message ?? "No error message was specified.";

        private string ContentMessage =>
            Error is null
            ? "No error details were specified."
            : (Error.IsOnlyRawContent
                ? $"No JSON error details were specified.{Environment.NewLine}" +
                    (string.IsNullOrWhiteSpace(Error.ErrorResponseContent)
                    ? "Raw error details are empty or white spaces only."
                    : $"Raw error details are: {Error.ErrorResponseContent}")
                : $"{Error}");

        /// <summary>The HTTP status code which was returned along with this error, or 0 if unavailable.</summary>
        public HttpStatusCode HttpStatusCode { get; set; }

        private string HttpStatusCodeMessage =>
            HttpStatusCode > 0
            ? $"HttpStatusCode is {HttpStatusCode}."
            : "No HttpStatusCode was specified.";

        private string ServiceNameMessage => $"The service {ServiceName} has thrown an exception.";

        private string CombinedMessage => $"{ServiceNameMessage} {HttpStatusCodeMessage} {ErrorMessage}";

        /// <inheritdoc/>
        public override string Message =>
            // We just override the default message which is very generic in Exception
            _hasMessage ? base.Message : CombinedMessage;

        /// <summary>
        /// Returns a summary of this exception.
        /// </summary>
        /// <returns>A summary of this exception.</returns>
        public override string ToString() =>
            // base.ToString() prints Message, and if we have overwritten Message with DefaultMessage
            // then ToString() will contain some duplicate information. But that's OK.
            $"{ServiceNameMessage}{Environment.NewLine}" +
            $"{HttpStatusCodeMessage}{Environment.NewLine}" +
            $"{ContentMessage}{Environment.NewLine}" +
            $"{base.ToString()}";
    }
}