using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetOpenAuth.OAuth.ChannelElements;
using DotNetOpenAuth.OAuth.Messages;

namespace Google.Apis.Samples.OAuth2Web
{
    public class TokenManager : IConsumerTokenManager
    {
        private Dictionary<string, string> secrets;

        public TokenManager()
        {
            secrets = new Dictionary<string, string>();
        }

        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }

        public string GetTokenSecret(string token) { return secrets[token]; }
        public void StoreNewRequestToken(UnauthorizedTokenRequest request, ITokenSecretContainingMessage response)
        {
            secrets.Add(response.Token, response.TokenSecret);

        }
        public void ExpireRequestTokenAndStoreNewAccessToken(string consumerKey, string requestToken, string accessToken, string accessTokenSecret)
        {
            secrets.Remove(requestToken);
            secrets.Add(accessToken, accessTokenSecret);
        }

        public TokenType GetTokenType(string token) { return new TokenType(); }
    }
}
