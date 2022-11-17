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

using Google.Apis.Json;
using Google.Apis.Tests.Mocks;
using System;
using Xunit;
using static Google.Apis.Auth.OAuth2.AwsExternalAccountCredential;

namespace Google.Apis.Auth.Tests.OAuth2
{
    public class AwsSignedSubjectTokenTests
    {
        private const string AwsSecretAcessKeyId = "BSIARD4OQDT6ATWAVS5C";
        private const string AwsSecretAccessKey = "CDNMV7GOT4h+PHxB/03/Zh4X7XZFOZRydtoMwsRS";
        private const string AwsToken = "GwoGZXIvYXdzEDQaDAVwVIzhCkoSIt9J6yLeAeVnJt7alj0kfoGSAYzy2uYkeOmLHgz8BxpbiFR1NwKd6QXDo09ZRVSoP1eUI286GXEX5PuY/kX3lctI6L" +
            "YWhAxLl7d3xMNqcT+4Pw+aRvLNX6rCs71/gwZzOs7dkktam8j7zy5TWrWDy8JVU61P+iuAg+0gCW6dHzis/rj0ProFQ9SSGD2CpO8CWoF144i+pAUMWLD+2s02YTRFASZX8wVokTv81cMiraH3" +
            "FwPzdlXQ6+cYhz4/mvfVRp5RL2BHjMACOo860fmKRpyIi8maaDL8jcVJhWiPkZZkAXVMvSiipNibBjJYih+X9LcsNFAjkSjlhiSBYms4Z9Mrbf5PAaMIIokO7B5/1VsaQjNfKY41DfitS3+VUz" +
            "u2iCayn6mysrSsAaWeXZarieae+cWG3ihKq71AhOsDQkWoh8a+zw==";
        private const string AwsRegion = "us-east-2";
        private const string AwsVerificationUrl = "https://sts.us-east-2.amazonaws.com/?Action=GetCallerIdentity&Version=2011-06-15";
        private const string Audience = "//iam.googleapis.com/projects/123456789012/locations/global/workloadIdentityPools/pool-abc123d4/providers/aws-abc123d4";
        private static readonly DateTime SigningTimestampUtc = new DateTime(1987, 5, 4, 6, 36, 45, DateTimeKind.Utc);

        private const string SerializedSubjectToken = "%7B%22url%22%3A%22https%3A%2F%2Fsts.us-east-2.amazonaws.com%2F%3FAction%3DGetCallerIdentity%26Version%3D" +
            "2011-06-15%22%2C%22method%22%3A%22POST%22%2C%22body%22%3A%22%22%2C%22headers%22%3A%5B%7B%22key%22%3A%22host%22%2C%22value%22%3A%22sts.us-east-2.am" +
            "azonaws.com%22%7D%2C%7B%22key%22%3A%22x-amz-date%22%2C%22value%22%3A%2219870504T063645Z%22%7D%2C%7B%22key%22%3A%22x-goog-cloud-target-resource%22%" +
            "2C%22value%22%3A%22%2F%2Fiam.googleapis.com%2Fprojects%2F123456789012%2Flocations%2Fglobal%2FworkloadIdentityPools%2Fpool-abc123d4%2Fproviders%2Fa" +
            "ws-abc123d4%22%7D%2C%7B%22key%22%3A%22x-amz-security-token%22%2C%22value%22%3A%22GwoGZXIvYXdzEDQaDAVwVIzhCkoSIt9J6yLeAeVnJt7alj0kfoGSAYzy2uYkeOmLH" +
            "gz8BxpbiFR1NwKd6QXDo09ZRVSoP1eUI286GXEX5PuY%2FkX3lctI6LYWhAxLl7d3xMNqcT%2B4Pw%2BaRvLNX6rCs71%2FgwZzOs7dkktam8j7zy5TWrWDy8JVU61P%2BiuAg%2B0gCW6dHzi" +
            "s%2Frj0ProFQ9SSGD2CpO8CWoF144i%2BpAUMWLD%2B2s02YTRFASZX8wVokTv81cMiraH3FwPzdlXQ6%2BcYhz4%2FmvfVRp5RL2BHjMACOo860fmKRpyIi8maaDL8jcVJhWiPkZZkAXVMvSi" +
            "ipNibBjJYih%2BX9LcsNFAjkSjlhiSBYms4Z9Mrbf5PAaMIIokO7B5%2F1VsaQjNfKY41DfitS3%2BVUzu2iCayn6mysrSsAaWeXZarieae%2BcWG3ihKq71AhOsDQkWoh8a%2Bzw%3D%3D%22" +
            "%7D%2C%7B%22key%22%3A%22Authorization%22%2C%22value%22%3A%22AWS4-HMAC-SHA256%20Credential%3DBSIARD4OQDT6ATWAVS5C%2F19870504%2Fus-east-2%2Fsts%2Faw" +
            "s4_request%2C%20SignedHeaders%3Dhost%3Bx-amz-date%3Bx-amz-security-token%3Bx-goog-cloud-target-resource%2C%20Signature%3D2e65b3fdfa86ba68f721bd458" +
            "4f2fcbf8df9fad14ce3c7ea389c58af17bdc5a0%22%7D%5D%7D";

        [Fact]
        public void Create()
        {
            // This is the reverse of what we do in production code, but it's harder to open all the implementation up
            // for proper testing than to just repeat this step here. This is by far the simplest step of subject
            // token generation as compared to building and signing the canonical request, etc. for which we are
            // testing production code.
            AwsSignedSubjectToken expected = NewtonsoftJsonSerializer.Instance.Deserialize<AwsSignedSubjectToken>(Uri.UnescapeDataString(SerializedSubjectToken));

            AwsSignedSubjectToken subjectToken = AwsSignedSubjectToken.Create(
                new AwsSecurityCredentials(AwsSecretAcessKeyId, AwsSecretAccessKey, AwsToken),
                new AwsRegion(AwsRegion),
                new Uri(AwsVerificationUrl),
                Audience,
                new MockClock(SigningTimestampUtc));

            Assert.Equal(expected.Url, subjectToken.Url);
            Assert.Equal(expected.HttpMethod, subjectToken.HttpMethod);
            Assert.Equal(expected.Body, subjectToken.Body);

            Assert.Equal(expected.Headers.Length, subjectToken.Headers.Length);

            foreach(var expectedHeader in expected.Headers)
            {
                var actual = Assert.Single(subjectToken.Headers, header => header.Key == expectedHeader.Key);
                Assert.Equal(expectedHeader.Value, actual.Value);
            }
        }
    }
}
