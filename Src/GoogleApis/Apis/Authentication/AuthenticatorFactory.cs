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
namespace Google.Apis.Authentication
{
	/// <summary>
	/// A simple factory class for producing <code>IAuthenticator</code>
	/// This can be used as with a signlton pattern with GetInstance.
	/// Or can be constructed and passed around. Either way you must
	/// RegisterAuthenticator before you can GetRegisterdAuthenticator
	/// </summary>
	/// <seealso cref="IAuthenticator"/> 
	public class AuthenticatorFactory
	{
		public delegate IAuthenticator CreateAuthenticator();
		
		private static readonly AuthenticatorFactory instance = new AuthenticatorFactory();
		
		private CreateAuthenticator authenticatorCreator = null;
		
		public AuthenticatorFactory ()
		{
		}
		
		public static AuthenticatorFactory GetInstance()
		{
			return instance;
		}
		
		/// <summary>
		/// The delegate passed in will be used to construct IAuthenticators in multiple contexts. If
		/// you do not consturct a new IAuthenticator on each call please ensure you are fetching old ones from 
		/// the correct location.
		/// </summary>
		/// <example>
		/// 	<code>
		/// 		AuthenticatorFactory.GetInstance().RegisterAuthenticator(() => new YourAuthenticator());
		/// 		AuthenticatorFactory.GetInstance().RegisterAuthenticator(delegate(){return new YourAuthenticator()});
		/// 	</code>
		/// </example>
		public void RegisterAuthenticator(CreateAuthenticator authenticatorCreator)
		{
			if ( authenticatorCreator == null )
			{
				throw new ArgumentNullException("authenticatorCreator");
			}
			this.authenticatorCreator = authenticatorCreator;
		}
		
		public IAuthenticator GetRegisteredAuthenticator()
		{
			if ( instance.authenticatorCreator == null )
			{
				throw new ApplicationException("No Authenticator registered");
			}
			
			return authenticatorCreator();
		}
	}
}

