/*
Copyright 2011 Google Inc

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
using System.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OAuth2;
using DotNetOpenAuth.OAuth2.ChannelElements;
using DotNetOpenAuth.OAuth2.Messages;

using Google.Apis.Authentication;
using Google.Apis.Authentication.OAuth2;
using Google.Apis.Discovery;
using GoogleRequests = Google.Apis.Requests;

namespace Google.Apis.Samples.ApiExplorer.Web
{
    public partial class Result : System.Web.UI.Page
    {
        private ApiUtility Api
        {
            get
            {
                ApiUtility ret = Application["ApiUtility"] as ApiUtility;
                if (ret == null)
                {
                    ret = new ApiUtility();
                    Application["ApiUtility"] = ret;
                }
                return ret;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.ExecuteMethod();
        }

        /// <summary>
        /// Execute selected API method
        /// </summary>
        private void ExecuteMethod()
        {
            string clientId = ConfigurationManager.AppSettings["clientId"];
            string clientSecret = ConfigurationManager.AppSettings["clientSecret"];
            string apiKey = ConfigurationManager.AppSettings["apiKey"];

            MethodCallContext callContext = Session["callContext"] as MethodCallContext;
            AuthorizationServerDescription serviceDescription = this.GetAuthorizationServerDescription();
            WebServerClient client = new WebServerClient(serviceDescription, clientId, clientSecret);
            IAuthorizationState authState = client.ProcessUserAuthorization(new HttpRequestInfo(Request));

            if (authState != null && authState.AccessToken != null)
            {
                Dictionary<string, IAuthorizationState> states = this.AuthorizationStates;
                if (!states.ContainsKey(callContext.Service))
                {
                    states.Add(callContext.Service, authState);
                }
                else
                {
                    states[callContext.Service] = authState;
                }
                this.AuthorizationStates = states;
            }
            else if (!this.AuthorizationStates.ContainsKey(callContext.Service))
            {
                this.RequestAuthorization(client, callContext.Service);
            }

            IAuthorizationState storedState = this.AuthorizationStates[callContext.Service];
            if (storedState.AccessTokenExpirationUtc.HasValue &&
                (storedState.AccessTokenExpirationUtc.Value - DateTime.UtcNow).CompareTo(TimeSpan.FromSeconds(30)) <= 0)
            {
                client.RefreshToken(storedState);
                Dictionary<string, IAuthorizationState> states = this.AuthorizationStates;
                states[callContext.Service] = storedState;
                this.AuthorizationStates = states;
            }

            IAuthenticator authenticator = new OAuth2Authenticator<WebServerClient>(client, (clt) => new AuthorizationState());
            IService service = Api.GetService(callContext.Service, callContext.Version);
            IMethod method = Api.GetMethod(callContext.Service, callContext.Resource, callContext.Method, callContext.Version);
            GoogleRequests.IRequest request = GoogleRequests.Request.CreateRequest(service, method)
                .WithAuthentication(authenticator)
                .WithParameters(callContext.Parameters)
                .WithDeveloperKey(apiKey);

			using(Stream stream = request.ExecuteRequest()) {
				using(StreamReader reader = new StreamReader(stream)) {
                    Response.Write(reader.ReadToEnd());
				}
			}
        }

        private void RequestAuthorization(WebServerClient client, string serviceName)
        {
            string scope = Scopes.GetScope(serviceName);
            Dictionary<string, string> extraParameters = new Dictionary<string, string> { { "scope", scope } };
            Uri callback = MessagingUtilities.GetRequestUrlFromContext().StripQueryArgumentsWithPrefix("oauth_");
            OutgoingWebResponse response = client.PrepareRequestUserAuthorization(new string[] { scope }, null);
            response.Send();
        }

        private AuthorizationServerDescription GetAuthorizationServerDescription()
        {
            AuthorizationServerDescription serviceDescription = new AuthorizationServerDescription
            {
                AuthorizationEndpoint = new Uri(ConfigurationManager.AppSettings["authorizationEndPoint"]),
                ProtocolVersion = ProtocolVersion.V20,
                TokenEndpoint = new Uri(ConfigurationManager.AppSettings["tokenEndPoint"]),
            };

            return serviceDescription;
        }

        /// <summary>
        /// Map between service name and access states
        /// </summary>
        private Dictionary<string, IAuthorizationState> AuthorizationStates
        {
            get
            {
                Dictionary<string, IAuthorizationState> states = Session["AuthorizationStates"] as Dictionary<string, IAuthorizationState>;
                if (states == null)
                {
                    states = new Dictionary<string, IAuthorizationState>();
                }
                return states;
            }
            set
            {
                Session["AuthorizationStates"] = value;
            }
        }
    }
}
