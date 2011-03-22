using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Google.Apis.Samples.ApiExplorerWeb
{
    public class Scopes
    {
		public static Dictionary<string, Scope> scopes {get;set;}
		
		static Scopes ()
		{
			scopes = new Dictionary<string, Scope>();
			
			scopes.Add("buzz", new Scope { 
				Name = "https://www.googleapis.com/auth/buzz", 
				AccessTokenUrl = "https://www.google.com/accounts/OAuthGetAccessToken" , 
				RequestTokenUrl = "https://www.google.com/accounts/OAuthGetRequestToken", 
				UserAuthorizationUrl = "https://www.google.com/buzz/api/auth/OAuthAuthorizeToken" });
			
			scopes.Add("chromewebstore", new Scope { 
				Name = "https://www.googleapis.com/auth/chromewebstore.readonly", 
				AccessTokenUrl = "https://www.google.com/accounts/OAuthGetAccessToken" , 
				RequestTokenUrl = "https://www.google.com/accounts/OAuthGetRequestToken", 
				UserAuthorizationUrl = "https://www.google.com/accounts/OAuthAuthorizeToken" });
			
			scopes.Add("translate", new Scope { 
				Name = "https://translate.google.com/toolkit/feeds", 
				AccessTokenUrl = "https://www.google.com/accounts/OAuthGetAccessToken" , 
				RequestTokenUrl = "https://www.google.com/accounts/OAuthGetRequestToken", 
				UserAuthorizationUrl = "https://www.google.com/accounts/OAuthAuthorizeToken" });
			
			scopes.Add("moderator", new Scope { 
				Name = "tag:google.com,2010:auth/moderator",
				AccessTokenUrl = "https://www.google.com/accounts/OAuthGetAccessToken" , 
				RequestTokenUrl = "https://www.google.com/accounts/OAuthGetRequestToken", 
				UserAuthorizationUrl = "https://www.google.com/accounts/OAuthAuthorizeToken" });
		}
	}
	
	public class Scope {
		public string Name {get;set;}
		public string AccessTokenUrl {get;set;}
		public string RequestTokenUrl {get;set;}
		public string UserAuthorizationUrl {get;set;}
	}
}
