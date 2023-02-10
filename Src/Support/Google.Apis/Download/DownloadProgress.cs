// Copyright 2023 Google LLC
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

using Google.Apis.Util;
using System;
using System.Runtime.ExceptionServices;

namespace Google.Apis.Download;

/// <summary>
/// Extension methods for <see cref="IDownloadProgress"/>.
/// </summary>
public static class DownloadProgress
{
    /// <summary>
    /// Throws the exception from <paramref name="progress"/> if it represents a failure with an exception.
    /// The thrown exception will contain a more useful stack trace than just <see cref="IDownloadProgress.Exception"/>
    /// where this is available.
    /// </summary>
    /// <param name="progress">The upload progress to check for failure. Must not be null.</param>
    public static void ThrowOnFailure(this IDownloadProgress progress)
    {
        progress.ThrowIfNull(nameof(progress));
        if (progress.Exception is not Exception ex)
        {
            return;
        }
        // If we've got a good stack trace, use it.
        if (progress is MediaDownloader.DownloadProgress { ExceptionDispatchInfo: ExceptionDispatchInfo edi })
        {
            edi.Throw();
        }
        throw ex;
    }
}
