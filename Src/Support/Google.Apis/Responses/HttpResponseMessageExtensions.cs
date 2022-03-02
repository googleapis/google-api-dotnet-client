// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Requests;
using Google.Apis.Util;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Google.Apis.Responses
{
    internal static class HttpResponseMessageExtensions
    {
        /// <summary>
        /// Attempts to deserialize a <see cref="RequestError"/> from the <paramref name="response"/>.
        /// </summary>
        /// <remarks>
        /// This method will throw a <see cref="GoogleApiException"/> if:
        /// <list type="bullet">
        /// <item>The <paramref name="response"/> or its <see cref="HttpResponseMessage.Content"/> are null.</item>
        /// <item>Or the deserialization attempt throws a <see cref="JsonException"/>.</item>
        /// <item>Or the deserilization attempt returns null.</item>
        /// </list>
        /// Any exception thrown while reading the <paramref name="response"/> <see cref="HttpResponseMessage.Content"/>
        /// will be bubbled up.
        /// Otherwie this method will returned the deserialized <see cref="RequestError"/>.
        /// </remarks>
        internal static async Task<RequestError> DeserializeErrorAsync(this HttpResponseMessage response, string name, ISerializer serializer)
        {
            if (response?.Content is null)
            {
                // We throw GoogleApiException (instead of NullArgumentException)
                // as a more friendly way to signal users that something went wrong,
                // which in this case is very unlikely to have been because of a bug
                // in calling code.
                throw new GoogleApiException(name)
                {
                    HttpStatusCode = response?.StatusCode ?? default
                };
            }
            // If we can't even read the response, let that exception bubble up.
            // Note that very likely this will never happen here, as we are usually reading from a buffer.
            // If there were actual problems reading the content, HttpClient has already thrown when
            // filling the buffer in.
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            RequestError error;
            try
            {
                error = serializer.Deserialize<StandardResponse<object>>(responseText)?.Error;
            }
            catch (JsonException ex)
            {
                throw new GoogleApiException(name, message: null, ex)
                {
                    HttpStatusCode = response.StatusCode,
                    Error = new RequestError { ErrorResponseContent = responseText }
                };
            }
            if (error is null)
            {
                throw new GoogleApiException(name)
                {
                    HttpStatusCode = response.StatusCode,
                    Error = new RequestError { ErrorResponseContent = responseText }
                };
            }
            error.ErrorResponseContent = responseText;
            return error;
        }
    }
}
