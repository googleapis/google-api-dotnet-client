using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DotNetOpenAuth.OAuth;
using DotNetOpenAuth.OAuth.Messages;
using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OAuth.ChannelElements;
using Google.Apis.Discovery;
using Google.Apis.Authentication;
using System.IO;
using GoogleRequests = Google.Apis.Requests;

namespace Google.Apis.Samples.OAuth2Web
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ExecuteMethod();
        }

        /// <summary>
        /// Execute selected API method
        /// </summary>
        private void ExecuteMethod()
        {
            string serviceName = null;
            string resourceName = null;
            string methodName = null;
            Dictionary<string, string> paramDictionary = new Dictionary<string,string>();
            foreach (string k in Request.QueryString.Keys)
            {
                if (k == "service")
                {
                    serviceName = Request.QueryString[k];
                }
                else if (k == "resource")
                {
                    resourceName = Request.QueryString[k];
                }
                else if (k == "method")
                {
                    methodName = Request.QueryString[k];
                }
                else if (k.StartsWith("param_"))
                {
                    string paramName = k.Substring(6);
                    string paramValue = Request.QueryString[k];
                    paramDictionary.Add(paramName, paramValue);
                }
            }

            ServiceProviderDescription serviceDescription = this.GetServiceProviderDescription();
            TokenManager tokenManager = this.GetTokenManager();
            WebConsumer consumer = new WebConsumer(serviceDescription, tokenManager);
            AuthorizedTokenResponse accessTokenResponse = consumer.ProcessUserAuthorization();
            if (accessTokenResponse != null)
            {
                Dictionary<string, string> tokens = this.AccessTokens;
                if (!tokens.ContainsKey(serviceName))
                {
                    tokens.Add(serviceName, accessTokenResponse.AccessToken);
                }
                else
                {
                    tokens[serviceName] = accessTokenResponse.AccessToken;
                }
                this.AccessTokens = tokens;
            }
            else if (!this.AccessTokens.ContainsKey(serviceName))
            {
                this.RequestAuthorization(consumer, serviceName);
            }

            string tokenSecret = consumer.TokenManager.GetTokenSecret(this.AccessTokens[serviceName]);
			IAuthenticator authenticator = new OAuth3LeggedAuthenticator("", "anonymous", "anonymous", this.AccessTokens[serviceName], tokenSecret);

            IService service = ApiUtility.GetService(serviceName);
            IMethod method = ApiUtility.GetMethod(serviceName, resourceName, methodName);
            GoogleRequests.IRequest request = GoogleRequests.Request.CreateRequest(service, method)
                .WithAuthentication(authenticator)
                .WithParameters(paramDictionary);

			using(Stream stream = request.ExecuteRequest()) {
				using(StreamReader reader = new StreamReader(stream)) {
                    Response.Write(reader.ReadToEnd());
				}
			}
        }

        private void RequestAuthorization(WebConsumer consumer, string serviceName)
        {
            Dictionary<string, string> extraParameters = new Dictionary<string, string> { { "scope", Scopes.scopes[serviceName].Name } };
            Uri callback = MessagingUtilities.GetRequestUrlFromContext().StripQueryArgumentsWithPrefix("oauth_");
            UserAuthorizationRequest request = consumer.PrepareRequestUserAuthorization(callback, extraParameters, null);
            consumer.Channel.Send(request);
        }

        private TokenManager GetTokenManager()
        {
            TokenManager tokenManager = Application["TokenManager"] as TokenManager;
            if (tokenManager == null)
            {
                tokenManager = new TokenManager
                {
                    ConsumerKey = "anonymous",
                    ConsumerSecret = "anonymous",
                };
                Application["TokenManager"] = tokenManager;
            }
            return tokenManager;
        }

        private ServiceProviderDescription GetServiceProviderDescription()
        {
            ServiceProviderDescription serviceDescription = new ServiceProviderDescription
            {
                RequestTokenEndpoint = new MessageReceivingEndpoint("https://www.google.com/accounts/OAuthGetRequestToken", HttpDeliveryMethods.AuthorizationHeaderRequest | HttpDeliveryMethods.GetRequest),
                UserAuthorizationEndpoint = new MessageReceivingEndpoint("https://www.google.com/accounts/OAuthAuthorizeToken", HttpDeliveryMethods.AuthorizationHeaderRequest | HttpDeliveryMethods.GetRequest),
                AccessTokenEndpoint = new MessageReceivingEndpoint("https://www.google.com/accounts/OAuthGetAccessToken", HttpDeliveryMethods.AuthorizationHeaderRequest | HttpDeliveryMethods.GetRequest),
                TamperProtectionElements = new ITamperProtectionChannelBindingElement[] { new HmacSha1SigningBindingElement() },
            };
            return serviceDescription;
        }

        /// <summary>
        /// Map between service name and access tokens
        /// </summary>
        private Dictionary<string, string> AccessTokens
        {
            get
            {
                Dictionary<string, string> tokens = Session["AccessToken"] as Dictionary<string, string>;
                if (tokens == null)
                {
                    tokens = new Dictionary<string, string>();
                }
                return tokens;
            }
            set
            {
                Session["AccessToken"] = value;
            }
        }

    }
}
