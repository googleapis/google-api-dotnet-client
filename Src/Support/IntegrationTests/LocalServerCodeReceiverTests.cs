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
using Xunit;

namespace IntegrationTests
{
    public class LocalServerCodeReceiverTests
    {
        private const string CallbackUriTemplateLocalhost = "http://localhost:{0}/authorize/";
        private const string CallbackUriTemplate127001 = "http://127.0.0.1:{0}/authorize/";

        [Fact]
        public void CallbackUri()
        {
            string uri = LocalServerCodeReceiver.CallbackUriChooser.Default.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);

            // We don't know on which platform we are running, but let's check we get one of the
            // valid templates. This is more of a sanity check test.
            Assert.Contains(uri, new string[] { CallbackUriTemplate127001, CallbackUriTemplateLocalhost });
        }

        [Fact]
        public void CallbackUri_SecondRequest_SuccessReported()
        {
            string firstUri = LocalServerCodeReceiver.CallbackUriChooser.Default.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);

            // Report success, which means the template above worked, so it will be used for all
            // subsequent requests.
            LocalServerCodeReceiver.CallbackUriChooser.Default.ReportSuccess(firstUri);
            string uriAfterSuccess = LocalServerCodeReceiver.CallbackUriChooser.Default.GetUriTemplate(LocalServerCodeReceiver.CallbackUriChooserStrategy.Default);

            Assert.Equal(firstUri, uriAfterSuccess);
        }
    }
}
