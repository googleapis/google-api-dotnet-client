/*
Copyright 2020 Google LLC

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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Tests.Mocks;
using System;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    public class LocalServerCodeReceiverTests
    {
        private const string CallbackUriTemplateLocalhost = "http://localhost:{0}/authorize/";
        private const string CallbackUriTemplate127001 = "http://127.0.0.1:{0}/authorize/";

        [Fact]
        public void CallbackUri_PrefersLoopback()
        {
            MockClock clock = new MockClock(DateTime.UtcNow);
            TimeSpan timeout = TimeSpan.FromMinutes(1);
            // All uris are good.
            Func<string, bool> listenerFails = u => false;

            var chooser = new LocalServerCodeReceiver.CallbackUriChooser(clock, timeout, listenerFails);

            var uri = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);
            Assert.Equal(CallbackUriTemplate127001, uri);
        }

        [Fact]
        public void CallbackUri_PrefersLoopback_SecondRequest()
        {
            MockClock clock = new MockClock(DateTime.UtcNow);
            TimeSpan timeout = TimeSpan.FromMinutes(1);
            // All uris are good.
            Func<string, bool> listenerFails = u => false;

            var chooser = new LocalServerCodeReceiver.CallbackUriChooser(clock, timeout, listenerFails);
            chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);

            var uri2 = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);
            Assert.Equal(CallbackUriTemplate127001, uri2);
        }

        [Fact]
        public void CallbackUri_LoopbackListenerFails()
        {
            MockClock clock = new MockClock(DateTime.UtcNow);
            TimeSpan timeout = TimeSpan.FromMinutes(1);
            Func<string, bool> listenerFails = u => u == CallbackUriTemplate127001;

            var chooser = new LocalServerCodeReceiver.CallbackUriChooser(clock, timeout, listenerFails);

            var uri = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);

            Assert.Equal(CallbackUriTemplateLocalhost, uri);
        }

        [Fact]
        public void CallbackUri_LoopbackTimesOut()
        {
            MockClock clock = new MockClock(DateTime.UtcNow);
            TimeSpan timeout = TimeSpan.FromMinutes(1);
            // All uris are good.
            Func<string, bool> listenerFails = u => false;

            var chooser = new LocalServerCodeReceiver.CallbackUriChooser(clock, timeout, listenerFails);

            // This one should be loopback.
            var uri = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);

            // Move the clock so that loopback times out.
            clock.UtcNow = clock.UtcNow.AddMinutes(2);

            var uri2 = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);

            Assert.Equal(CallbackUriTemplateLocalhost, uri2);
        }

        [Fact]
        public void CallbackUri_LoopbackReportedFailure()
        {
            MockClock clock = new MockClock(DateTime.UtcNow);
            TimeSpan timeout = TimeSpan.FromMinutes(1);
            // All uris are good.
            Func<string, bool> listenerFails = u => false;

            var chooser = new LocalServerCodeReceiver.CallbackUriChooser(clock, timeout, listenerFails);

            // This one should be loopback.
            var uri = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);

            chooser.ReportFailure(CallbackUriTemplate127001);

            var uri2 = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);

            Assert.Equal(CallbackUriTemplateLocalhost, uri2);
        }

        [Fact]
        public void CallbackUri_LoopbackReportedSuccess()
        {
            MockClock clock = new MockClock(DateTime.UtcNow);
            TimeSpan timeout = TimeSpan.FromMinutes(1);
            // All uris are good.
            Func<string, bool> listenerFails = u => false;

            var chooser = new LocalServerCodeReceiver.CallbackUriChooser(clock, timeout, listenerFails);

            var uri = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);

            chooser.ReportSuccess(CallbackUriTemplate127001);

            var uri2 = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);
            Assert.Equal(CallbackUriTemplate127001, uri2);

            // Even after time out
            clock.UtcNow = clock.UtcNow.AddMinutes(2);

            uri2 = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);
            Assert.Equal(CallbackUriTemplate127001, uri2);

            // Even if a failure is reported, it succeeded at least once
            // so the failure is transient.
            chooser.ReportFailure(CallbackUriTemplate127001);

            uri2 = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);
            Assert.Equal(CallbackUriTemplate127001, uri2);
        }

        [Fact]
        public void CallbackUri_BothFail()
        {
            MockClock clock = new MockClock(DateTime.UtcNow);
            TimeSpan timeout = TimeSpan.FromMinutes(1);
            // All uris are good.
            Func<string, bool> listenerFails = u => false;

            var chooser = new LocalServerCodeReceiver.CallbackUriChooser(clock, timeout, listenerFails);

            // They should alternate based on the amount of reuse.
            var uri1 = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);
            chooser.ReportFailure(uri1);
            var uri2 = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);
            chooser.ReportFailure(uri2);
            var uri3 = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);
            chooser.ReportFailure(uri3);
            var uri4 = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);
            chooser.ReportFailure(uri4);

            Assert.Equal(CallbackUriTemplate127001, uri1);
            Assert.Equal(CallbackUriTemplate127001, uri3);

            Assert.Equal(CallbackUriTemplateLocalhost, uri2);
            Assert.Equal(CallbackUriTemplateLocalhost, uri4);
        }

        [Fact]
        public void CallbackUri_BothTimeout()
        {
            MockClock clock = new MockClock(DateTime.UtcNow);
            TimeSpan timeout = TimeSpan.FromMinutes(1);
            // All uris are good.
            Func<string, bool> listenerFails = u => false;

            var chooser = new LocalServerCodeReceiver.CallbackUriChooser(clock, timeout, listenerFails);

            // They should alternate based on the amount of reuse.
            var uri1 = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);
            clock.UtcNow = clock.UtcNow.AddMinutes(2);
            var uri2 = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);
            clock.UtcNow = clock.UtcNow.AddMinutes(2);
            var uri3 = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);
            clock.UtcNow = clock.UtcNow.AddMinutes(2);
            var uri4 = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);
            clock.UtcNow = clock.UtcNow.AddMinutes(2);

            Assert.Equal(CallbackUriTemplate127001, uri1);
            Assert.Equal(CallbackUriTemplate127001, uri3);

            Assert.Equal(CallbackUriTemplateLocalhost, uri2);
            Assert.Equal(CallbackUriTemplateLocalhost, uri4);
        }

        [Fact]
        public void CallbackUri_TimeoutPreferredForRetries()
        {
            MockClock clock = new MockClock(DateTime.UtcNow);
            TimeSpan timeout = TimeSpan.FromMinutes(1);
            Func<string, bool> listenerFails = u => u == CallbackUriTemplate127001;

            var chooser = new LocalServerCodeReceiver.CallbackUriChooser(clock, timeout, listenerFails);

            // Loopback IP failed so this one is localhost.
            var uri1 = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);
            // Make localhost time out.
            clock.UtcNow = clock.UtcNow.AddMinutes(2);
            // This one should still be localhost, which was timed out
            // vs loopback which was failed. And they have the same amount of reuses.
            var uri2 = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);
            // Make it time out again.
            clock.UtcNow = clock.UtcNow.AddMinutes(2);
            // And now this should be loopback, it had less reuse.
            var uri3 = chooser.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);

            Assert.Equal(CallbackUriTemplateLocalhost, uri1);
            Assert.Equal(CallbackUriTemplateLocalhost, uri2);

            Assert.Equal(CallbackUriTemplate127001, uri3);
        }

        [Theory]
        [InlineData(LocalServerCodeReceiver.CallbackUriChooserStrategy.ForceLoopbackIp, CallbackUriTemplate127001)]
        [InlineData(LocalServerCodeReceiver.CallbackUriChooserStrategy.ForceLocalhost, CallbackUriTemplateLocalhost)]
        public void CallbackUri_ForcesStrategy(LocalServerCodeReceiver.CallbackUriChooserStrategy strategy, string expectedTemplate)
        {
            MockClock clock = new MockClock(DateTime.UtcNow);
            TimeSpan timeout = TimeSpan.FromMinutes(1);
            // Make the template that should be forced, fail on the listener check.
            Func<string, bool> listenerFails = u => u == expectedTemplate;

            var chooser = new LocalServerCodeReceiver.CallbackUriChooser(clock, timeout, listenerFails);

            var uri1 = chooser.GetUriTemplate(strategy);

            // Even after time out
            clock.UtcNow = clock.UtcNow.AddMinutes(2);

            var uri2 = chooser.GetUriTemplate(strategy);

            // Even if a failure is reported, it succeeded at least once
            // so the failure is transient.
            chooser.ReportFailure(expectedTemplate);

            var uri3 = chooser.GetUriTemplate(strategy);

            Assert.Equal(expectedTemplate, uri1);
            Assert.Equal(expectedTemplate, uri2);
            Assert.Equal(expectedTemplate, uri3);
        }
    }
}
