/*
Copyright 2017 Google Inc

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

using Google.Apis.Json;
using Google.Apis.Services;
using Google.Apis.Tests.Mocks;
using Google.Apis.Upload;
using Google.Apis.Util;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Google.Apis.Tests.Apis.Upload
{
    /// <summary>
    /// Tests of resumable upload, that uses a real HTTP server.
    /// </summary>
    public partial class ResumableUploadTest : IDisposable
    {
        /// <summary>
        /// Mock string to upload to the media server. It contains 454 bytes, and in most cases we will use a chunk 
        /// size of 100. There are 3 spaces on the end of each line because the original carriage return line endings
        /// caused differences between Windows and Linux test results.
        /// </summary>
        private static readonly string UploadTestData =
            "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod   " +
            "tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris   " +
            "nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore   " +
            "eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit   " +
            "anim id est laborum.";
        private static readonly byte[] UploadTestBytes = Encoding.UTF8.GetBytes(UploadTestData);
        private static readonly int UploadLength = UploadTestBytes.Length;

        /// <summary>
        /// URL used for the resumable upload.
        /// </summary>
        private const string UploadPath = "resume";

        private readonly TestServer _server;
        private readonly TestLogger _logger;

        public ResumableUploadTest(ITestOutputHelper outputHelper)
        {
            _logger = new TestLogger(outputHelper);
            _logger.WriteLine("Start of test");
            _server = new TestServer(_logger);
        }

        public void Dispose()
        {
            _server.Dispose();
            _logger.WriteLine("Test disposed");
        }

        /// <summary>
        /// Client validates chunk-size correctly.
        /// </summary>
        [Fact]
        public void TestChunkSize()
        {
            using (var service = new MockClientService(new BaseClientService.Initializer()))
            {
                var stream = new MemoryStream(Encoding.UTF8.GetBytes(UploadTestData));
                var upload = new TestResumableUpload(service, "whatever", "POST", stream, "text/plain", 100);

                // Negative chunk size.
                Assert.Throws<ArgumentOutOfRangeException>(() => upload.ChunkSize = -1);
                // Less than the minimum.
                Assert.Throws<ArgumentOutOfRangeException>(() => upload.ChunkSize = ResumableUpload.MinimumChunkSize - 1);
                // Valid chunk size.
                upload.ChunkSize = ResumableUpload.MinimumChunkSize;
                upload.ChunkSize = ResumableUpload.MinimumChunkSize * 2;
            }
        }
    }
}
