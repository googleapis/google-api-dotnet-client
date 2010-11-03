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
using System.IO;

using Google.Apis;
using Google.Apis.Authentication;
using Google.Apis.Discovery;
using Google.Apis.Requests;

using Google.Apis.Samples.CommandLine;
using Google.Apis.Samples.CommandLine.Views;
using Google.Apis.Samples.CommandLine.Controllers;

using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OAuth;
using DotNetOpenAuth.OAuth.ChannelElements;

using DotNetOpenAuth.OAuth.Messages;

namespace Google.Apis.Samples.CommandLine.Controllers
{
	/// <summary>
	/// The Controller for the Method View and Model.
	/// </summary>
	public class MethodController {
		
		private IService _service {get;set;}
		private MethodView _view {get;set;}
		
		private Method _method {get;set;}
		private Resource _resource {get;set;}
		
		private const string _consumerKey = "anonymous";
		private const string _consumerSecret = "anonymous";
		
		private DesktopConsumer consumer;
		
		
		private class TokenManager : IConsumerTokenManager {
			
			private Dictionary<string, string> secrets;
			
			public TokenManager() {
				secrets = new Dictionary<string, string>();	
			}
			
			public string ConsumerKey {get;set;}
			public string ConsumerSecret {get;set;}
			
			public string GetTokenSecret(string token) {return secrets[token];}
			public void StoreNewRequestToken (UnauthorizedTokenRequest request, ITokenSecretContainingMessage response) {
				secrets.Add(response.Token, response.TokenSecret);
				
			}
			public void ExpireRequestTokenAndStoreNewAccessToken (string consumerKey, string requestToken, string accessToken, string accessTokenSecret) {
				secrets.Remove(requestToken);
				secrets.Add(accessToken, accessTokenSecret);
			}

			public TokenType GetTokenType (string token) {return new TokenType();}
			
			
		}
		
		public MethodController(IService service, Resource resource, Method method, MethodView view) {
			_service = service;
			_view = view;
			_resource = resource;
			_method = method;
			var scope = Scopes.scopes[_service.Name];
			var serviceProvider = new ServiceProviderDescription {
				ProtocolVersion = ProtocolVersion.V10a,
				AccessTokenEndpoint = new MessageReceivingEndpoint(scope.AccessTokenUrl, HttpDeliveryMethods.GetRequest),
				UserAuthorizationEndpoint = new MessageReceivingEndpoint(scope.UserAuthorizationUrl, HttpDeliveryMethods.GetRequest),
				RequestTokenEndpoint = new MessageReceivingEndpoint(scope.RequestTokenUrl, HttpDeliveryMethods.GetRequest),
				TamperProtectionElements = new ITamperProtectionChannelBindingElement[] { new HmacSha1SigningBindingElement() }
			};
			
			var tokenManager = new TokenManager { ConsumerKey = _consumerKey, ConsumerSecret = _consumerSecret };
			
			consumer = new DesktopConsumer(serviceProvider, tokenManager);
		}
		
		public void Run() {
			while(GetSelection()) {}	
		}
		
		public bool GetSelection() {
			Console.Out.Write("{0}\\{1} > ", _resource.Name ,_method.Name);
			string command = Console.In.ReadLine();
			
			if(command.StartsWith("cd ")) 
			{
				// Get the service.
				var parameterName = command.Substring(command.IndexOf(" ") + 1);
				
				if(parameterName == "..") {
					return false;
				}
			}
			else if (command == "exec ") {
				// Ask the user to visit a url for authentication.
				var requestParameters = new Dictionary<string, string>();
				string requestToken;
				
				requestParameters.Add("scope", Scopes.scopes[_service.Name].Name);
				requestParameters.Add("domain", "example.com");
				
				// The Google OAuth API will do OOB automatically
				var authUri = consumer.RequestUserAuthorization(requestParameters, null, out requestToken);
				
				_view.AskForCredentials(authUri, requestParameters);
				var pin = Console.ReadLine().Trim();
				
				// Read the response.
				
				// Upgrade the token.
				var authToken = consumer.ProcessUserAuthorization(requestToken, pin);
				var tokenSecret = consumer.TokenManager.GetTokenSecret(authToken.AccessToken);
				
				
				var parameterDictionary = new Dictionary<string, string>();
				// Get the parameters from the user
				foreach(var p in _method.Parameters) {
					_view.AskForParameter(p.Value);
					var paramData = Console.ReadLine();
					if(String.IsNullOrEmpty(paramData) == false) 
						parameterDictionary.Add(p.Key, paramData);
				}
				
				// Execute a request, not that we are not using the same oAuth library.
				var request = Request.CreateRequest(_service, _method);
				
				var authentication = new OAuth3LeggedAuthenticator("", _consumerKey, _consumerSecret, authToken.AccessToken, tokenSecret);
				
				string bodyString = null;
				// Ask for the Body (If a Post or PUT)
				if(_method.HttpMethod == "POST" || _method.HttpMethod == "PUT") {
					
					_view.AskForBody();
					
					bodyString = Console.ReadLine();
				}
				
				using(var stream = request
					.WithAuthentication(authentication)
				    .WithParameters(parameterDictionary)
					.WithBody(bodyString)
					.ExecuteRequest()) {
					
					// Render the output stream.
					using(var reader = new StreamReader(stream)) {
						Console.Out.Write(reader.ReadToEnd());
					}
				}
			}
			else if (command == "help") {
				// Execute a request
			}
			else if (command == "ls") {
				_view.Render(_method);
			}
			else {
				Console.Out.WriteLine();
			}
			
			return true;
		}
	}
}
