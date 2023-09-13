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

using Google.Apis.Auth.OAuth2;
using Google.Apis.IAMCredentials.v1;
using Google.Apis.IAMCredentials.v1.Data;
using Google.Apis.Services;
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using IntegrationTests.Utils;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;

namespace IntegrationTests
{
    public class ExternalAccountCredentialTests
    {
        [Fact(Skip = "Googlers see go/wif-integration-settings")]
        public async Task AwsCredentials()
        {
            string gcpProjectNumber = "";
            string gcpPoolId = "pool-abc123d4";

            string awsAccountId = "";
            string awsProviderId = "aws-abc123d4";
            string awsRoleName = "";
            string awsAudience = $"//iam.googleapis.com/projects/{gcpProjectNumber}/locations/global/workloadIdentityPools/{gcpPoolId}/providers/{awsProviderId}";
            string awsArn = $"arn:aws:iam::{awsAccountId}:role/{awsRoleName}";

            // This really won't be running in AWS, so we need to obtain AWS credentials by using the AssumeRoleWithWebIdentity
            // operation of AWS STS server.
            // For this, we need an identity token to identify ourselves to AWS STS.
            GoogleCredential gcpCredential = Helper.GetServiceCredential().CreateScoped("https://www.googleapis.com/auth/cloud-platform");
            string saEmail = (gcpCredential.UnderlyingCredential as ServiceAccountCredential).Id;
            string saResourceName = $"projects/-/serviceAccounts/{saEmail}";
            IAMCredentialsService iamService = new IAMCredentialsService(new BaseClientService.Initializer
            {
                HttpClientInitializer = gcpCredential,
            });
            var idToken = await iamService.Projects.ServiceAccounts.GenerateIdToken(
                new GenerateIdTokenRequest
                {
                    Audience = awsAudience,
                    IncludeEmail = true
                },
                saResourceName).ExecuteAsync();

            // Using the id token, we can now obtain AWS credentials.
            string assumeRoleUrl = $"https://sts.amazonaws.com/?" +
                $"Action=AssumeRoleWithWebIdentity" +
                $"&Version=2011-06-15" +
                $"&DurationSeconds=3600" +
                $"&RoleSessionName={awsRoleName}" +
                $"&RoleArn={awsArn}" +
                $"&WebIdentityToken={idToken.Token}";

            string content;
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(assumeRoleUrl);
                content = await response.Content.ReadAsStringAsync();
            }
            XElement awsCredentialXml = XElement.Parse(content);

            // We store AWS credentials in environment variables to mimic an AWS environment.
            Environment.SetEnvironmentVariable("AWS_ACCESS_KEY_ID", AwsCredentialValue("AccessKeyId"));
            Environment.SetEnvironmentVariable("AWS_SECRET_ACCESS_KEY", AwsCredentialValue("SecretAccessKey"));
            Environment.SetEnvironmentVariable("AWS_SESSION_TOKEN", AwsCredentialValue("SessionToken"));
            // We store the AWS region in an environment variable to mimic an AWS environment.
            Environment.SetEnvironmentVariable("AWS_REGION", "us-east-2");

            // Now we can create an AWS creential which will pick the relevant values from the environment variables.
            AwsExternalAccountCredential awsToGcpCredential = new AwsExternalAccountCredential(new AwsExternalAccountCredential.Initializer(
                tokenUrl: "https://sts.googleapis.com/v1/token",
                audience: awsAudience,
                subjectTokenType: "urn:ietf:params:aws:token-type:aws4_request",
                regionalCredentialVerificationUrl: "https://sts.{region}.amazonaws.com?Action=GetCallerIdentity&Version=2011-06-15")
            {
                ServiceAccountImpersonationUrl = $"https://iamcredentials.googleapis.com/v1/projects/-/serviceAccounts/{saEmail}:generateAccessToken",
                Scopes = new string[] { StorageService.Scope.DevstorageFullControl }
            });

            // And we make a request to Storage to confirm that our AWS credential is indeed valid.
            StorageService client = new StorageService(new BaseClientService.Initializer
            {
                HttpClientInitializer = awsToGcpCredential
            });

            // Following line will throw if authentication fails.
            Buckets buckets = client.Buckets.List(Helper.GetProjectId()).Execute();

            // A final sanity-check.
            Assert.NotNull(buckets.Items);

            string AwsCredentialValue(string tagName) =>
                awsCredentialXml.Descendants().Single(element => element.Name.LocalName == tagName).Value;
        }
    }
}
