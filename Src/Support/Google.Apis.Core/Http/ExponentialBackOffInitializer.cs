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
using System.Linq;
using System.Text;

namespace Google.Apis.Http
{
    /// <summary>
    /// Indicates if exponential back-off is used automatically on exceptions in a service requests and \ or when 503 
    /// responses is returned form the server.
    /// </summary>
    [Flags]
    public enum ExponentialBackOffPolicy
    {
        /// <summary>Exponential back-off is disabled.</summary>
        None = 0,
        /// <summary>Exponential back-off is enabled only for exceptions.</summary>
        Exception = 1,
        /// <summary>Exponential back-off is enabled only for 503 HTTP Status code.</summary>
        UnsuccessfulResponse503 = 2
    }

    /// <summary>
    /// An initializer which adds exponential back-off as exception handler and \ or unsuccessful response handler by
    /// the given <see cref="ExponentialBackOffPolicy"/>.
    /// </summary>
    public class ExponentialBackOffInitializer : IConfigurableHttpClientInitializer
    {
        /// <summary>Gets or sets the used back-off policy.</summary>
        private ExponentialBackOffPolicy Policy { get; set; }

        /// <summary>Gets or sets the back-off handler creation function.</summary>
        private Func<BackOffHandler> CreateBackOff { get; set; }

        /// <summary>
        /// Constructs a new back-off initializer with the given policy and back-off handler create function.
        /// </summary>
        public ExponentialBackOffInitializer(ExponentialBackOffPolicy policy, Func<BackOffHandler> createBackOff)
        {
            Policy = policy;
            CreateBackOff = createBackOff;
        }

        public void Initialize(ConfigurableHttpClient httpClient)
        {
            var backOff = CreateBackOff();

            // Add exception handler and \ or unsuccessful response handler.
            if ((Policy & ExponentialBackOffPolicy.Exception) == ExponentialBackOffPolicy.Exception)
            {
                httpClient.MessageHandler.AddExceptionHandler(backOff);
            }

            if ((Policy & ExponentialBackOffPolicy.UnsuccessfulResponse503) ==
                ExponentialBackOffPolicy.UnsuccessfulResponse503)
            {
                httpClient.MessageHandler.AddUnsuccessfulResponseHandler(backOff);
            }
        }
    }

}
