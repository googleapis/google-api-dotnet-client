using Google.Apis.Http;
using Google.Apis.Logging;
using Google.Apis.Services;
using Google.Apis.Storage.v1;
using Google.Apis.Tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
