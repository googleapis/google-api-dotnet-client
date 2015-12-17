/*
Copyright 2015 Google Inc

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

using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

using Google.Apis.Requests;
using Google.Apis.Services;
using Google.Apis.Util;

namespace Google.Apis.Media
{
    /// <summary>
    /// Common error handling code for the Media API.
    /// </summary>
    internal static class MediaApiErrorHandling
    {
        /// <summary>
        /// Creates a suitable exception for an HTTP response, attempting to parse the body as
        /// JSON but falling back to just using the text as the message.
        /// </summary>
        internal static async Task<GoogleApiException> ExceptionForResponseAsync(
            IClientService service,
            HttpResponseMessage response)
        {
            // If we can't even read the response, let that excpetion bubble up, just as it would have done
            // if the error had been occurred when sending the request.
            string responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            RequestError parsedError = null;
            string message = responseText;
            try
            {
                parsedError = service.Serializer.Deserialize<StandardResponse<object>>(responseText).Error;
                if (parsedError != null)
                {
                    message = parsedError.ToString();
                }
            }
            catch (JsonException)
            {
                // Just make do with a null RequestError, and the response text set to the body of the response.
                // The contents of the caught exception aren't particularly useful - we don't need to include it
                // as a cause, for example. The expectation is that the exception returned by this method (below)
                // will be thrown by the caller.
            }
            return new GoogleApiException(service.Name, message)
            {
                Error = parsedError,
                HttpStatusCode = response.StatusCode
            };
        }
    }
}
