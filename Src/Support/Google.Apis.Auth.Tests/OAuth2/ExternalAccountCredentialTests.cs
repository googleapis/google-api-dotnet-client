/*
Copyright 2022 Google LLC

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

using System;
using System.Threading.Tasks;
using System.Threading;
using Xunit;
using Google.Apis.Auth.OAuth2;

namespace Google.Apis.Auth.Tests.OAuth2
{
    public class ExternalAccountCredentialTests : ExternalAccountCredentialTestsBase
    {
        [Theory]
        [InlineData("https://sts.googleapis.com")]
        [InlineData("https://us-east-1.sts.googleapis.com")]
        [InlineData("https://US-EAST-1.sts.googleapis.com")]
        [InlineData("https://sts.us-east-1.googleapis.com")]
        [InlineData("https://sts.US-WEST-1.googleapis.com")]
        [InlineData("https://us-east-1-sts.googleapis.com")]
        [InlineData("https://US-WEST-1-sts.googleapis.com")]
        [InlineData("https://us-west-1-sts.googleapis.com/path?query")]
        [InlineData("https://sts-xyz123.p.googleapis.com/path?query")]
        [InlineData("https://sts-xyz123.p.googleapis.com")]
        [InlineData("https://sts-xyz-123.p.googleapis.com")]
        public void ValidateTokenUrl_ValidUrls(string tokenUrl) =>
            new DummyExternalCredential(new DummyExternalCredential.Initializer(tokenUrl, Audience, SubjectTokenType));

        [Theory]
        [InlineData("https://iamcredentials.googleapis.com")]
        [InlineData("http://sts.googleapis.com")]
        [InlineData("https://st.s.googleapis.com")]
        [InlineData("https://US-WE/ST-1-sts.googleapis.com")]
        [InlineData("https://sts-us-east-1.googleapis.com")]
        [InlineData("https://sts-US-WEST-1.googleapis.com")]
        [InlineData("testhttps://us-east-1.sts.googleapis.com")]
        [InlineData("https://us-east-1.sts.googleapis.comevil.com")]
        [InlineData("https://us-east-1.us-east-1.sts.googleapis.com")]
        [InlineData("https://us-ea.s.t.sts.googleapis.com")]
        [InlineData("https://sts.googleapis.comevil.com")]
        [InlineData("hhttps://us-east-1.sts.googleapis.com")]
        [InlineData("https://-sts.googleapis.com")]
        [InlineData("https://us-east-1.sts.googleapis.com.evil.com")]
        [InlineData("https://sts.pgoogleapis.com")]
        [InlineData("https://p.googleapis.com")]
        [InlineData("https://sts.p.com")]
        [InlineData("http://sts.p.googleapis.com")]
        [InlineData("https://xyz-sts.p.googleapis.com")]
        [InlineData("https://sts-xyz.123.p.googleapis.com")]
        [InlineData("https://sts-xyz.p1.googleapis.com")]
        [InlineData("https://sts-xyz.p.foo.com")]
        [InlineData("https://sts-xyz.p.foo.googleapis.com")]
        public void ValidateTokenUrl_InvalidUrls(string tokenUrl) =>
            Assert.Throws<InvalidOperationException>(() => new DummyExternalCredential(new DummyExternalCredential.Initializer(tokenUrl, Audience, SubjectTokenType)));

        [Theory]
        [InlineData("https://")]
        [InlineData("https://us- -1.sts.googleapis.com")]
        [InlineData("https://us-eas\\t-1.sts.googleapis.com")]
        [InlineData("https:/us-east-1.sts.googleapis.com")]
        [InlineData("sts.googleapis.com")]
        public void ValidateTokenUrl_InvalidFormatUrls(string tokenUrl) =>
            Assert.Throws<UriFormatException>(() => new DummyExternalCredential(new DummyExternalCredential.Initializer(tokenUrl, Audience, SubjectTokenType)));

        [Theory]
        [InlineData("https://iamcredentials.googleapis.com")]
        [InlineData("https://us-east-1.iamcredentials.googleapis.com")]
        [InlineData("https://US-EAST-1.iamcredentials.googleapis.com")]
        [InlineData("https://iamcredentials.us-east-1.googleapis.com")]
        [InlineData("https://iamcredentials.US-WEST-1.googleapis.com")]
        [InlineData("https://us-east-1-iamcredentials.googleapis.com")]
        [InlineData("https://US-WEST-1-iamcredentials.googleapis.com")]
        [InlineData("https://us-west-1-iamcredentials.googleapis.com/path?query")]
        [InlineData("https://iamcredentials-xyz123.p.googleapis.com/path?query")]
        [InlineData("https://iamcredentials-xyz123.p.googleapis.com")]
        [InlineData("https://iamcredentials-xyz-123.p.googleapis.com")]
        public void ValidateImpersonationUrl_ValidUrl(string impersonationUrl) =>
            new DummyExternalCredential(new DummyExternalCredential.Initializer(TokenUrl, Audience, SubjectTokenType)
            {
                ServiceAccountImpersonationUrl = impersonationUrl
            });

        [Theory]
        [InlineData("https://sts.googleapis.com")]
        [InlineData("http://iamcredentials.googleapis.com")]
        [InlineData("https://iamcre.dentials.googleapis.com")]
        [InlineData("https://US-WE/ST-1-iamcredentials.googleapis.com")]
        [InlineData("https://iamcredentials-us-east-1.googleapis.com")]
        [InlineData("https://iamcredentials-US-WEST-1.googleapis.com")]
        [InlineData("testhttps://us-east-1.iamcredentials.googleapis.com")]
        [InlineData("https://us-east-1.iamcredentials.googleapis.comevil.com")]
        [InlineData("https://us-east-1.us-east-1.iamcredentials.googleapis.com")]
        [InlineData("https://us-ea.s.t.iamcredentials.googleapis.com")]
        [InlineData("https://iamcredentials.googleapis.comevil.com")]
        [InlineData("hhttps://us-east-1.iamcredentials.googleapis.com")]
        [InlineData("https://-iamcredentials.googleapis.com")]
        [InlineData("https://us-east-1.iamcredentials.googleapis.com.evil.com")]
        [InlineData("https://iamcredentials.pgoogleapis.com")]
        [InlineData("https://p.googleapis.com")]
        [InlineData("https://iamcredentials.p.com")]
        [InlineData("http://iamcredentials.p.googleapis.com")]
        [InlineData("https://xyz-iamcredentials.p.googleapis.com")]
        [InlineData("https://iamcredentials-xyz.123.p.googleapis.com")]
        [InlineData("https://iamcredentials-xyz.p1.googleapis.com")]
        [InlineData("https://iamcredentials-xyz.p.foo.com")]
        [InlineData("https://iamcredentials-xyz.p.foo.googleapis.com")]
        public void ValidateImpersonationUrl_InvalidUrl(string impersonationUrl) =>
            Assert.Throws<InvalidOperationException>(() => new DummyExternalCredential(new DummyExternalCredential.Initializer(TokenUrl, Audience, SubjectTokenType)
            {
                ServiceAccountImpersonationUrl = impersonationUrl
            }));

        [Theory]
        [InlineData("iamcredentials.googleapis.com")]
        [InlineData("https://")]
        [InlineData("https://us-eas\\t-1.iamcredentials.googleapis.com")]
        [InlineData("https:/us-east-1.iamcredentials.googleapis.com")]
        [InlineData("https://us- -1.iamcredentials.googleapis.com")]
        public void ValidateImpersonationUrl_InvalidFormatUrl(string impersonationUrl) =>
            Assert.Throws<UriFormatException>(() => new DummyExternalCredential(new DummyExternalCredential.Initializer(TokenUrl, Audience, SubjectTokenType)
            {
                ServiceAccountImpersonationUrl = impersonationUrl
            }));

        private class DummyExternalCredential : ExternalAccountCredential
        {
            new internal class Initializer : ExternalAccountCredential.Initializer
            {
                internal Initializer(string tokenUrl, string audience, string subjectTokenType)
                    : base(tokenUrl, audience, subjectTokenType)
                { }
            }

            internal DummyExternalCredential(Initializer initializer) : base(initializer)
            { }

            protected override Task<string> GetSubjectTokenAsyncImpl(CancellationToken taskCancellationToken)
            {
                throw new NotImplementedException();
            }

            private protected override GoogleCredential WithoutImpersonationConfigurationImpl()
            {
                throw new NotImplementedException();
            }
        }
    }
}
