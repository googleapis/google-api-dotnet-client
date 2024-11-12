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

namespace Google.Apis.Http
{
    /// <summary>
    /// Indicates which of exceptions and / or HTTP status codes are automatically retried using exponential backoff.
    /// </summary>
    [Flags]
    public enum ExponentialBackOffPolicy
    {
        /// <summary>
        /// No automatic retries.
        /// </summary>
        None = 0,
        /// <summary>
        /// Exceptions are retried.
        /// </summary>
        Exception = 1,
        /// <summary>
        /// HTTP Status Code 503 is retried.
        /// </summary>
        UnsuccessfulResponse503 = 2,
        /// <summary>
        /// Retries will be executed as recommended for each service.
        /// For services with no recommendations, a default policy will be applied.
        /// </summary>
        RecommendedOrDefault = 4,
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
        /// If <paramref name="policy"/> has the <see cref="ExponentialBackOffPolicy.RecommendedOrDefault"/> flag set,
        /// the <see cref="BackOffHandler"/> will be set for handling both exceptions and HTTP Status codes.
        /// </summary>
        public ExponentialBackOffInitializer(ExponentialBackOffPolicy policy, Func<BackOffHandler> createBackOff)
        {
            Policy = policy;
            CreateBackOff = createBackOff;
        }

        /// <inheritdoc/>
        public void Initialize(ConfigurableHttpClient httpClient)
        {
            // This also decides which of HTTP status codes/exceptions are retryable.
            BackOffHandler backOff = CreateBackOff();

            // Add exception handler and \ or unsuccessful response handler.
            if ((Policy & ExponentialBackOffPolicy.Exception) == ExponentialBackOffPolicy.Exception ||
                // The recommendation may be to retry some exceptions, BackOffHandler will decide.
                (Policy & ExponentialBackOffPolicy.RecommendedOrDefault) == ExponentialBackOffPolicy.RecommendedOrDefault)
            {
                httpClient.MessageHandler.AddExceptionHandler(backOff);
            }

            if ((Policy & ExponentialBackOffPolicy.UnsuccessfulResponse503) == ExponentialBackOffPolicy.UnsuccessfulResponse503 ||
                // The recommendation may be to retry some HTTP status code, BackOffHandler will decide.
                (Policy & ExponentialBackOffPolicy.RecommendedOrDefault) == ExponentialBackOffPolicy.RecommendedOrDefault)
            {
                httpClient.MessageHandler.AddUnsuccessfulResponseHandler(backOff);
            }
        }
    }

}
