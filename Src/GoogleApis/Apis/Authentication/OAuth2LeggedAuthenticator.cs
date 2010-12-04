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
using System.IO;
using System.Collections;
using System.Text;
using System.Net;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Google.Apis.Authentication
{
	public class OAuth2LeggedAuthenticator : OAuthAuthenticator
	{
		private string oAuthUser;
		private string oAuthDomain;

		public static string OAuthParameter = "xoauth_requestor_id";

		/// <summary>
		///  a constructor for OpenAuthentication login use cases
		/// </summary>
		/// <param name="applicationName">The name of the application</param>
		/// <param name="consumerKey">the consumerKey to use</param>
		/// <param name="consumerSecret">the consumerSecret to use</param>
		/// <param name="user">the username to use</param>
		/// <param name="domain">the domain to use</param>
		/// <returns></returns>
		public OAuth2LeggedAuthenticator (string applicationName, string consumerKey, string consumerSecret, string user, string domain) : base(applicationName, consumerKey, consumerSecret)
		{
			this.oAuthUser = user;
			this.oAuthDomain = domain;
		}

		/// <summary>
		/// returns the OAuth User
		/// </summary>
		/// <returns></returns>
		public string OAuthUser 
		{
			get { return this.oAuthUser; }
		}

		/// <summary>
		/// returns the OAuth Domain
		/// </summary>
		/// <returns></returns>
		public string OAuthDomain 
		{
			get { return this.oAuthDomain; }
		}


		/// <summary>
		/// Takes an existing httpwebrequest and modifies it's headers according to
		/// the authentication system used.
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		public override void ApplyAuthenticationToRequest (HttpWebRequest request)
		{
			base.ApplyAuthenticationToRequest (request);
			
			string oauthHeader = OAuthUtil.GenerateHeader (request.RequestUri, this.ConsumerKey, this.ConsumerSecret, null, null, request.Method);
			request.Headers.Add (oauthHeader);
		}

		/// <summary>
		/// Takes an existing httpwebrequest and modifies it's uri according to 
		/// the authentication system used. Only overridden in 2leggedoauth case
		/// Here we need to add the xoauthrequestor parameter
		/// </summary>
		/// <param name="source">the original uri</param>
		/// <returns></returns>
		public override Uri ApplyAuthenticationToUri (Uri source)
		{
			UriBuilder builder = new UriBuilder (source);
			string queryToAppend = OAuth2LeggedAuthenticator.OAuthParameter + "=" + this.oAuthUser + "%40" + this.OAuthDomain;
			
			if (builder.Query != null && builder.Query.Length > 1)
				builder.Query = builder.Query + "&" + queryToAppend;
			else
				builder.Query = queryToAppend;
			
			return builder.Uri;
		}
	}
}
