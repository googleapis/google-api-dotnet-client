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

using Google.Apis.Download;
using System;
using Xunit;

namespace Google.Apis.Tests.Apis.Download;

public class DownloadProgressExtensionsTest
{
    [Fact]
    public void ThrowOnFailure_NonFailure()
    {
        var progress = new MediaDownloader.DownloadProgress(DownloadStatus.Downloading, 200L);
        progress.ThrowOnFailure();
    }

    [Fact]
    public void ThrowOnFailure_NonMediaDownloaderProgress()
    {
        IDownloadProgress progress = CreateFailedProgress(ex => new OtherDownloadProgress(ex));
        var ex = Assert.Throws<Exception>(progress.ThrowOnFailure);
        Assert.DoesNotContain("InnerMethod", ex.StackTrace);
    }

    [Fact]
    public void ThrowOnFailure_MediaDownloaderProgress()
    {
        IDownloadProgress progress = CreateFailedProgress(ex => new MediaDownloader.DownloadProgress(ex, 0L));
        var ex = Assert.Throws<Exception>(progress.ThrowOnFailure);
        Assert.Contains("InnerMethod", ex.StackTrace);
    }

    private static IDownloadProgress CreateFailedProgress(Func<Exception, IDownloadProgress> factory)
    {
        try
        {
            OuterMethod();
        }
        catch (Exception e)
        {
            return factory(e);
        }
        throw new InvalidOperationException("No exception thrown");
    }

    private static void OuterMethod() => InnerMethod();

    private static void InnerMethod() => throw new Exception("Bang");

    private class OtherDownloadProgress : IDownloadProgress
    {
        public DownloadStatus Status => DownloadStatus.Failed;
        public long BytesDownloaded => 0L;
        public Exception Exception { get; }

        public OtherDownloadProgress(Exception ex) => Exception = ex;
    }
}
