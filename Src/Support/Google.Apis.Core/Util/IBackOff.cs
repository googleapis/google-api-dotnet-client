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

namespace Google.Apis.Util
{
    /// <summary>Strategy interface to control back-off between retry attempts.</summary>
    public interface IBackOff
    {
        /// <summary>
        /// Gets the a time span to wait before next retry. If the current retry reached the maximum number of retries,
        /// the returned value is <see cref="TimeSpan.MinValue"/>.
        /// </summary>
        TimeSpan GetNextBackOff(int currentRetry);

        /// <summary>Gets the maximum number of retries.</summary>
        int MaxNumOfRetries { get; }
    }
}
