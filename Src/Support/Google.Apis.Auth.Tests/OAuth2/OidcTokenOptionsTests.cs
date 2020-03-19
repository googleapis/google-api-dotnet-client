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

using Google.Apis.Auth.OAuth2;
using System;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    public class OidcTokenOptionsTests
    {
        [Fact]
        public void FromTargetAudience()
        {
            var options = OidcTokenOptions.FromTargetAudience("dummy_target_audience");

            Assert.Equal("dummy_target_audience", options.TargetAudience);
            Assert.Equal(OidcTokenFormat.Full, options.TokenFormat);
        }

        [Fact]
        public void WithTargetAudience()
        {
            var options = OidcTokenOptions
                .FromTargetAudience("dummy_target_audience")
                .WithTokenFormat(OidcTokenFormat.Standard);

            var newOptions = options.WithTargetAudience("another_target_audience");

            Assert.NotSame(options, newOptions);
            // Original unchanged.
            Assert.Equal("dummy_target_audience", options.TargetAudience);
            Assert.Equal(OidcTokenFormat.Standard, options.TokenFormat);
            // New only changes target audience.
            Assert.Equal("another_target_audience", newOptions.TargetAudience);
            Assert.Equal(OidcTokenFormat.Standard, newOptions.TokenFormat);
        }

        [Fact]
        public void WithTokenFormat()
        {
            var options = OidcTokenOptions
                .FromTargetAudience("dummy_target_audience")
                .WithTokenFormat(OidcTokenFormat.Standard);

            var newOptions = options.WithTokenFormat(OidcTokenFormat.FullWithLicences);

            Assert.NotSame(options, newOptions);
            // Original unchanged.
            Assert.Equal("dummy_target_audience", options.TargetAudience);
            Assert.Equal(OidcTokenFormat.Standard, options.TokenFormat);
            // New only changes token format.
            Assert.Equal("dummy_target_audience", newOptions.TargetAudience);
            Assert.Equal(OidcTokenFormat.FullWithLicences, newOptions.TokenFormat);
        }

        [Fact]
        public void WithInvalidTokenFormat()
        {
            Assert.Throws<ArgumentException>(
                () => OidcTokenOptions
                .FromTargetAudience("dummy_target_audience")
                .WithTokenFormat((OidcTokenFormat) 5));
        }
    }
}
