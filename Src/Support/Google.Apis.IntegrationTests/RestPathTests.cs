using Google;
using Google.Apis.CloudMachineLearningEngine.v1;
using Google.Apis.CloudMachineLearningEngine.v1.Data;
using Google.Apis.Services;
using IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xunit;

namespace IntegrationTests
{
    public class RestPathTests
    {
        [Fact]
        public void ColonCorrectness()
        {
            // Test uses dummy (non-existent) project, which will cause an error.
            // This is fine, as the test is checking that the request URI is correctly formed,
            // not that the call itself works.
            // The check on the returned error ensures that the URI is correct.
            // The "predict" method contains a ':' in the request path, which is what this test is testing.
            var client = new CloudMachineLearningEngineService(new BaseClientService.Initializer
            {
                HttpClientInitializer = Helper.GetServiceCredential()
                    .CreateScoped(CloudMachineLearningEngineService.Scope.CloudPlatform),
                ApplicationName = "IntegrationTest"
            });
            var emptyBody = new GoogleCloudMlV1PredictRequest { HttpBody = new GoogleApiHttpBody() };
            var request = client.Projects.Predict(emptyBody, "projects/dummyProject");
            request.ModifyRequest = httpRequestMessage =>
            {
                httpRequestMessage.Content = new StringContent("dummyRequest", Encoding.UTF8, "application/json");
            };
            var ex = Assert.Throws<GoogleApiException>(() => request.Execute());
            Assert.Contains("Permission denied on resource project dummyProject", ex.Message);
        }
    }
}
