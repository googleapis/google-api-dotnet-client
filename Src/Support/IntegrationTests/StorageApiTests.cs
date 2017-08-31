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

using Google;
using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Services;
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using Google.Apis.Tests.Mocks;
using IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using Xunit;

namespace IntegrationTests
{
    public class StorageApiTests
    {
        [Fact]
        public void PrettyPrinting()
        {
            StorageService client = new StorageService(new BaseClientService.Initializer
            {
                HttpClientInitializer = Helper.GetServiceCredential().CreateScoped(StorageService.Scope.DevstorageFullControl),
                ApplicationName = "IntegrationTest"
            });
            var memLog = new MemoryLogger(LogLevel.All, clock: new MockClock());
            client.HttpClient.MessageHandler.InstanceLogger = memLog;
            client.HttpClient.MessageHandler.LogEvents = ConfigurableMessageHandler.LogEventType.ResponseBody;
            var req = client.Buckets.List(Helper.GetProjectId());

            req.PrettyPrint = true;
            var resp = req.Execute();
            Assert.Equal(1, memLog.LogEntries.Count);
            var entry = memLog.LogEntries[0];
            // The JSON is pretty-printed, so contains many space characters
            Assert.Contains("  ", entry.Split(new[] { "Body: " }, StringSplitOptions.None)[1]);

            req.PrettyPrint = null;
            resp = req.Execute();
            Assert.Equal(2, memLog.LogEntries.Count);
            entry = memLog.LogEntries[1];
            // The JSON is pretty-printed by default (PrettyPrint set to null), so contains many space characters
            Assert.Contains("  ", entry.Split(new[] { "Body: " }, StringSplitOptions.None)[1]);

            req.PrettyPrint = false;
            resp = req.Execute();
            Assert.Equal(3, memLog.LogEntries.Count);
            entry = memLog.LogEntries[2];
            // The JSON is not pretty-printed, so contains no space characters
            Assert.DoesNotContain("  ", entry.Split(new[] { "Body: " }, StringSplitOptions.None)[1]);
        }

        private const string TestBucketPrefix = "testbucket";

        private Bucket CreateTestBucket(StorageService client)
        {
            var name = $"{TestBucketPrefix}-{Guid.NewGuid()}";
            return client.Buckets.Insert(new Bucket { Name = name }, Helper.GetProjectId()).Execute();
        }

        private void DeleteTestBuckets(StorageService client)
        {
            try
            {
                foreach (var bucket in client.Buckets.List(Helper.GetProjectId()).Execute().Items)
                {
                    if (bucket.Name.StartsWith(TestBucketPrefix))
                    {
                        client.Buckets.Delete(bucket.Name).Execute();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"DeleteTestBuckets exception: {e}");
            }
        }

        [Fact]
        public void ETags()
        {
            StorageService client = new StorageService(new BaseClientService.Initializer
            {
                HttpClientInitializer = Helper.GetServiceCredential().CreateScoped(StorageService.Scope.DevstorageFullControl),
                ApplicationName = "IntegrationTest",
            });
            var bucket = CreateTestBucket(client);
            try
            {
                // Set a label with If-None-Match header. This should not change any labels
                bucket.Labels = new Dictionary<string, string> { ["label"] = "1" };
                var req1 = client.Buckets.Patch(bucket, bucket.Name);
                req1.ETagAction = Google.Apis.ETagAction.IfNoneMatch;
                var ex1 = Assert.Throws<GoogleApiException>(() => req1.Execute());
                Assert.Contains("[Precondition Failed", ex1.Message);
                // Check that labels have not been added, and etag is the same
                var bucket1 = client.Buckets.Get(bucket.Name).Execute();
                Assert.Empty(bucket1.Labels.EmptyIfNull());
                Assert.Equal(bucket.ETag, bucket1.ETag);
                // Set a label with If-Match header. This should change labels
                var req2 = client.Buckets.Patch(bucket, bucket.Name);
                req2.ETagAction = Google.Apis.ETagAction.IfMatch;
                var bucket2 = req2.Execute();
                // Check that labels have been added, and etag is different
                Assert.NotEmpty(bucket2.Labels.EmptyIfNull());
                Assert.NotEqual(bucket.ETag, bucket2.ETag);
                // Set a label with If-Match header, with an out of date etag. This should not change any labels
                var req3 = client.Buckets.Patch(bucket, bucket.Name);
                req3.ETagAction = Google.Apis.ETagAction.IfMatch;
                var ex3 = Assert.Throws<GoogleApiException>(() => req3.Execute());
                Assert.Contains("[Precondition Failed", ex3.Message);
            }
            finally
            {
                DeleteTestBuckets(client);
            }
        }
    }
}
