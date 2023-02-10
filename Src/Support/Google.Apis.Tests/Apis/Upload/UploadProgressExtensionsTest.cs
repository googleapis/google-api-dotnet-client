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

using Google.Apis.Upload;
using System;
using Xunit;

namespace Google.Apis.Tests.Apis.Upload;

public class DownloadProgressExtensionsTest
{
    [Fact]
    public void ThrowOnFailure_NonFailure()
    {
        var progress = new ResumableUpload.ResumableUploadProgress(UploadStatus.Uploading, 200L);
        progress.ThrowOnFailure();
    }

    [Fact]
    public void ThrowOnFailure_NonResumableUploadProgress()
    {
        IUploadProgress progress = CreateFailedProgress(ex => new OtherUploadProgress(ex));
        var ex = Assert.Throws<Exception>(progress.ThrowOnFailure);
        Assert.DoesNotContain("InnerMethod", ex.StackTrace);
    }

    [Fact]
    public void ThrowOnFailure_ResumableUploadProgress()
    {
        IUploadProgress progress = CreateFailedProgress(ex => new ResumableUpload.ResumableUploadProgress(ex, 0L));
        var ex = Assert.Throws<Exception>(progress.ThrowOnFailure);
        Assert.Contains("InnerMethod", ex.StackTrace);
    }

    private static IUploadProgress CreateFailedProgress(Func<Exception, IUploadProgress> factory)
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

    private class OtherUploadProgress : IUploadProgress
    {
        public UploadStatus Status => UploadStatus.Failed;
        public long BytesSent => 0L;
        public Exception Exception { get; }

        public OtherUploadProgress(Exception ex) => Exception = ex;
    }
}
