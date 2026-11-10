/*
Copyright 2026 Google LLC

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Net.Http;

namespace Google.Apis.Http;

/// <summary>
/// Strategy interface to extract and calculate a retry delay from an HTTP response.
/// </summary>
internal interface IRetryAfterBackOff
{
    /// <summary>
    /// Gets the retry delay indicated by the HTTP response, if present and valid.
    /// Returns <c>null</c> if no valid retry hint is present or parsing fails.
    /// </summary>
    TimeSpan? GetRetryAfterDelay(HttpResponseMessage response);
}
