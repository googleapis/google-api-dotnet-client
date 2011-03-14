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
            ServiceProviderDescription serviceDescription = this.GetServiceProviderDescription();
            TokenManager tokenManager = this.GetTokenManager();
            WebConsumer consumer = new WebConsumer(serviceDescription, tokenManager);
            AuthorizedTokenResponse accessTokenResponse = consumer.ProcessUserAuthorization();
            if (accessTokenResponse != null)
            {
                this.AccessToken = accessTokenResponse.AccessToken;
            }
            else if (this.AccessToken == null)
            {
                this.RequestAuthorization(consumer);
            }

            Response.Write("Authorized");
        }

        private void RequestAuthorization(WebConsumer consumer)
        {
            Dictionary<string, string> extraParameters = new Dictionary<string, string> { { "scope", "https://www.googleapis.com/auth/buzz" } };
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

        private string AccessToken
        {
            get
            {
                return Session["AccessToken"] as string;
            }
            set
            {
                Session["AccessToken"] = value;
            }
        }

    }
}
