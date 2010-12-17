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
using System.Net;
using System.Web;
using System.IO;
using System.Text.RegularExpressions;

using Google.Apis.Authentication;

namespace Google.Apis.Samples.GeneratedService.AdSense
{
	public class ClientAuth:Authenticator, IAuthenticator
	{
		private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(ClientAuth));
		private readonly static Regex authTokenRegex = new Regex(@"Auth=([0-9a-zA-Z-_]+)", 
		                                                         RegexOptions.Compiled | 
		                                                         RegexOptions.Singleline | 
		                                                         RegexOptions.ECMAScript);
		
		private readonly IUserNamePasswordSupplier supplier;
		private readonly string scope;
		private string authToken = null;
		public ClientAuth (IUserNamePasswordSupplier supplier, string scope, string applicationName):base(applicationName)
		{
			this.supplier = supplier;
			this.scope = scope;
		}
		
		public override void ApplyAuthenticationToRequest (System.Net.HttpWebRequest request)
		{
			CheckAuthentication();
			if(authToken == null)
			{
				throw new ApplicationException("Found no Authentication Token");
			}
			
			logger.DebugFormat("Adding Authorization header to request");
			request.Headers.Add("Authorization", string.Format("GoogleLogin auth={0}", authToken));
			logger.DebugFormat("Request was [{0}]", request.RequestUri);
		}

		private void CheckAuthentication()
		{
			if(authToken != null)
			{
				logger.Debug("Auth Token Already Present");
				return;
			}
			logger.Debug("No AuthenticationToken present.");
			authToken = FetchAuthentication();
		}
		
		private string FetchAuthentication()
		{
			
			Uri uri = new Uri(string.Format(
				"https://www.google.com/accounts/ClientLogin?Email={0}&Passwd={1}&service={2}&accountType={3}",
			    HttpUtility.UrlEncode(supplier.GetUserName()),
			    HttpUtility.UrlEncode(supplier.GetPassword()),
			    HttpUtility.UrlEncode(scope),
			    HttpUtility.UrlEncode("HOSTED_OR_GOOGLE")));
			logger.DebugFormat("Fetching Auth Token from ["+uri.ToString()+"]");
			HttpWebRequest request = RequestFactory.Create (uri);
			
			
			using(var response = request.GetResponse ())
			{
				StreamReader sr = new StreamReader(response.GetResponseStream());
				string result = sr.ReadToEnd();
				Match match = authTokenRegex.Match (result);
				if(match.Success == false)
				{
					throw new ApplicationException("Failed to find auth token in ["+result+"]" );
				}
				Group grp = match.Groups[1];
				string auth = grp.Value;
				logger.DebugFormat("Found auth token [{0}] from result [{1}]", auth, result);
				return auth;
			}			
		}
	}
	
	public interface IUserNamePasswordSupplier
	{
		string GetUserName();
		string GetPassword();
	}
	
	public class PrefetchedUserNamePasswordSupplier: IUserNamePasswordSupplier
	{
		private string UserName{get;set;}
		private string Password{get;set;}
		
		public PrefetchedUserNamePasswordSupplier(string userName, string password)
		{
			this.UserName = userName;
			this.Password = password;
		}
		
		public string GetUserName ()
		{
			return UserName;
		}
		
		public string GetPassword ()
		{
			return Password;
		}
		
	}
}
