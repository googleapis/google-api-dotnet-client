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

using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Services;
using Google.Apis.Storage.v1;
using Google.Apis.Tests;
using NUnit.Framework;
using System;

namespace IntegrationTests
{
    [TestFixture]
    class StorageApi
    {
        [Test]
        public void TestPrettyPrinting()
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
            Assert.That(memLog.LogEntries.Count, Is.EqualTo(1));
            var entry = memLog.LogEntries[0];
            // The JSON is pretty-printed, so contains many space characters
            Assert.That(entry.Split(new[] { "Body: " }, StringSplitOptions.None)[1], Does.Contain("  "));

            req.PrettyPrint = null;
            resp = req.Execute();
            Assert.That(memLog.LogEntries.Count, Is.EqualTo(2));
            entry = memLog.LogEntries[1];
            // The JSON is pretty-printed by default (PrettyPrint set to null), so contains many space characters
            Assert.That(entry.Split(new[] { "Body: " }, StringSplitOptions.None)[1], Does.Contain("  "));

            req.PrettyPrint = false;
            resp = req.Execute();
            Assert.That(memLog.LogEntries.Count, Is.EqualTo(3));
            entry = memLog.LogEntries[2];
            // The JSON is not pretty-printed, so contains no space characters
            Assert.That(entry.Split(new[] { "Body: " }, StringSplitOptions.None)[1], Does.Not.Contain("  "));
        }
    }
}
