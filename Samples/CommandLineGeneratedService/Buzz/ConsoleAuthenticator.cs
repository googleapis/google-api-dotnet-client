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
using Google.Apis.Authentication;
using System.Collections.Generic;
using Google.Apis.Samples.CommandLine;
using Google.Apis.Samples.CommandLine.Controllers;
	
using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OAuth;
using DotNetOpenAuth.OAuth.ChannelElements;

namespace Google.Apis.Samples.CommandLineGeneratedService.Buzz {


	public class ConsoleAuthenticator:IAuthenticator {
		private IAuthenticator internalAuthenticator;
		private const string _consumerKey = "anonymous";
		private const string _consumerSecret = "anonymous";


		public System.Net.HttpWebRequest CreateHttpWebRequest (string httpMethod, Uri targetUri)
		{
			if(internalAuthenticator == null){
				internalAuthenticator = CreateAuthority();
			}
			return internalAuthenticator.CreateHttpWebRequest(httpMethod, targetUri);
		}
		
		private DesktopConsumer CreateConsumer(){
			var scope = Scopes.scopes["buzz"];
			var serviceProvider = new ServiceProviderDescription {
				ProtocolVersion = ProtocolVersion.V10a,
				AccessTokenEndpoint = new MessageReceivingEndpoint(scope.AccessTokenUrl, HttpDeliveryMethods.GetRequest),
				UserAuthorizationEndpoint = new MessageReceivingEndpoint(scope.UserAuthorizationUrl, HttpDeliveryMethods.GetRequest),
				RequestTokenEndpoint = new MessageReceivingEndpoint(scope.RequestTokenUrl, HttpDeliveryMethods.GetRequest),
				TamperProtectionElements = new ITamperProtectionChannelBindingElement[] { new HmacSha1SigningBindingElement() }
			};
			
			var tokenManager = new MethodController.TokenManager { ConsumerKey = _consumerKey, ConsumerSecret = _consumerSecret };
			
			
			var consumer = new DesktopConsumer(serviceProvider, tokenManager);
			
			return consumer;
		}
		
		private IAuthenticator CreateAuthority(){
			var requestParameters = new Dictionary<string, string>();
				string requestToken;
				
				requestParameters.Add("scope", "https://www.googleapis.com/auth/buzz");
				requestParameters.Add("domain", "BuzzGeneratedIntegration");
			
				var consumer = CreateConsumer();
			
				// The Google OAuth API will do OOB automatically
				var authUri = consumer.RequestUserAuthorization(requestParameters, null, out requestToken);
				
				AskForCredentials(authUri, requestParameters);
				var pin = Console.ReadLine().Trim();
				
				// Read the response.
				
				// Upgrade the token.
				var authToken = consumer.ProcessUserAuthorization(requestToken, pin);
				var tokenSecret = consumer.TokenManager.GetTokenSecret(authToken.AccessToken);
											
				return new OAuth3LeggedAuthenticator("", _consumerKey, _consumerSecret, authToken.AccessToken, tokenSecret);
				
		}
		
		public void AskForCredentials(Uri url, Dictionary<string, string> extra) {
			var qs = Google.Apis.Samples.CommandLine.Utilities.DictionaryToQueryString(extra);
			Console.Out.WriteLine("Please visit {0}", url.ToString() + "&" + qs );
			Console.Out.Write("> ", url.ToString());
		}
	}
	
	
}