/*
Copyright 2013 Google Inc

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

using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Logging;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>OAuth 2.0 verification code receiver that reads the authorization code from the user input.</summary>
    public class PromptCodeReceiver : ICodeReceiver
    {
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<PromptCodeReceiver>();

        public string RedirectUri
        {
            get { return GoogleAuthConsts.InstalledAppRedirectUri; }
        }

        public Task<AuthorizationCodeResponseUrl> ReceiveCodeAsync(AuthorizationCodeRequestUrl url,
            CancellationToken taskCancellationToken)
        {
            var tcs = new TaskCompletionSource<AuthorizationCodeResponseUrl>();

            var authorizationUrl = url.Build().ToString();

            Logger.Debug("Open a browser with \"{0}\" URL", authorizationUrl);
            Process.Start(authorizationUrl);

            string code = string.Empty;
            while (string.IsNullOrEmpty(code))
            {
                Console.WriteLine("Please enter code: ");
                code = Console.ReadLine();
            }

            Logger.Debug("Code is: \"{0}\"", code);

            tcs.SetResult(new AuthorizationCodeResponseUrl
                {
                    Code = code
                });
            return tcs.Task;
        }
    }
}
