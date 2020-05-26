/*
Copyright 2020 Google Inc

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

using Google.Apis.Tests.Mocks;
using Google.Apis.Util;
using System;
using Xunit;

namespace Google.Apis.Auth.Tests
{
    public class SignedTokenVerificationOptionsTests
    {
        [Fact]
        public void Default()
        {
            var options = new SignedTokenVerificationOptions();

            Assert.Null(options.CertificatesUrl);
            Assert.Null(options.CertificateCache);
            Assert.Empty(options.TrustedAudiences);
            Assert.Empty(options.TrustedIssuers);
            Assert.False(options.ForceCertificateRefresh);
            Assert.Equal(TimeSpan.Zero, options.IssuedAtClockTolerance);
            Assert.Equal(TimeSpan.Zero, options.ExpiryClockTolerance);
            Assert.Same(SystemClock.Default, options.Clock);
        }

        [Fact]
        public void ClockCannotBeNull() =>
            Assert.Throws<ArgumentNullException>(() => new SignedTokenVerificationOptions { Clock = null });

        [Fact]
        public void FromAnother_EqualValuesAfterCreation()
        {
            var options1 = new SignedTokenVerificationOptions
            {
                CertificatesUrl = "http://dummy.url",
                ForceCertificateRefresh = true,
                IssuedAtClockTolerance = TimeSpan.FromSeconds(5),
                ExpiryClockTolerance = TimeSpan.FromSeconds(10),
                CertificateCache = new FakeCertificateCache(),
                Clock = new MockClock(DateTime.UtcNow),
                TrustedAudiences = { "audience" },
                TrustedIssuers = { "issuers" }
            };

            var options2 = new SignedTokenVerificationOptions(options1);

            Assert.Equal("http://dummy.url", options2.CertificatesUrl);
            Assert.Single(options2.TrustedAudiences, "audience");
            Assert.Single(options2.TrustedIssuers, "issuers");
            Assert.True(options2.ForceCertificateRefresh);
            Assert.Equal(TimeSpan.FromSeconds(5), options2.IssuedAtClockTolerance);
            Assert.Equal(TimeSpan.FromSeconds(10), options2.ExpiryClockTolerance);
            Assert.IsType<FakeCertificateCache>(options2.CertificateCache);
            Assert.IsType<MockClock>(options2.Clock);
        }

        [Fact]
        public void FromAnother_DifferentValueAfterModification()
        {
            var options1 = new SignedTokenVerificationOptions
            {
                CertificatesUrl = "http://dummy.url",
                ForceCertificateRefresh = true,
                IssuedAtClockTolerance = TimeSpan.FromSeconds(5),
                ExpiryClockTolerance = TimeSpan.FromSeconds(10),
                CertificateCache = new FakeCertificateCache(),
                Clock = new MockClock(DateTime.UtcNow),
                TrustedAudiences = { "audience" },
                TrustedIssuers = { "issuers" }
            };

            var options2 = new SignedTokenVerificationOptions(options1);

            options1.CertificatesUrl = "";
            options1.ForceCertificateRefresh = false;
            options1.IssuedAtClockTolerance = TimeSpan.Zero;
            options1.ExpiryClockTolerance = TimeSpan.Zero;
            options1.CertificateCache = new FakeCertificateCache();
            options1.Clock = new MockClock(DateTime.UtcNow);
            options1.TrustedAudiences.Add("another");
            options1.TrustedIssuers.Add("another");

            Assert.Equal("http://dummy.url", options2.CertificatesUrl);
            Assert.Single(options2.TrustedAudiences, "audience");
            Assert.Single(options2.TrustedIssuers, "issuers");
            Assert.True(options2.ForceCertificateRefresh);
            Assert.Equal(TimeSpan.FromSeconds(5), options2.IssuedAtClockTolerance);
            Assert.Equal(TimeSpan.FromSeconds(10), options2.ExpiryClockTolerance);
            Assert.NotSame(options1.CertificateCache, options2.CertificateCache);
            Assert.NotSame(options1.Clock, options2.Clock);
        }
    }
}
