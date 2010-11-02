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
	public abstract class OAuthAuthenticator : Authenticator
	{
		private string consumerKey;
		private string consumerSecret;

		public OAuthAuthenticator (string applicationName, string consumerKey, string consumerSecret) : base(applicationName)
		{
			this.consumerKey = consumerKey;
			this.consumerSecret = consumerSecret;
		}

		/// <summary>
		/// returns the ConsumerKey
		/// </summary>
		/// <returns></returns>
		public string ConsumerKey {
			get { return this.consumerKey; }
		}

		/// <summary>
		/// returns the ConsumerSecret
		/// </summary>
		/// <returns></returns>
		public string ConsumerSecret {
			get { return this.consumerSecret; }
		}
		
		
		
	}
}
