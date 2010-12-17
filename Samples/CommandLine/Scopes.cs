
/*
Copyright 2010 Google Inc

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
using System.Collections.Generic;

namespace Google.Apis.Samples.CommandLine
{
	public static class Scopes
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
				Name = "http://translate.google.com/toolkit/feeds", 
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

