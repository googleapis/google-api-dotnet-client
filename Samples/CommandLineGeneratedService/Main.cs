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
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Collections.Generic;

using LumenWorks.Framework.IO.Csv;
using Newtonsoft.Json;

using Google.Apis.Discovery;
using Google.Apis.Authentication;
using Google.Apis.Samples.CommandLineGeneratedService.Buzz; 
using Google.Apis.Samples.AdSenseApi;
using Google.Apis.Samples.AdSenseApi.Service;
using Google.Apis.Samples.AdSenseApi.Auth;

namespace Google.Apis.Samples.CommandLineGeneratedService {
	class MainClass {

		public readonly static log4net.ILog logger = log4net.LogManager.GetLogger(typeof(MainClass));
		public const string bodyJason = @"
{
  ""scope"": {
    ""property_codes"": [""ca-pub-0556581589806023""]
  },
  ""dimensions"": [""DATE""],
  ""metrics"": [""PUBLISHER_EARNINGS""],
  ""period"": {
  ""start_date"": ""20000101"",
  ""end_date"": ""20101231""
  }
}
";
		
		public static bool CheckValidationResult(object sender, X509Certificate cert, X509Chain X509Chain, SslPolicyErrors errors) {
			return true;
		}


		public static void Main(string[] args) {
			ServicePointManager.ServerCertificateValidationCallback += CheckValidationResult;
			try{
				//BuzzTest();
				//AdSenseTest ();
				Console.WriteLine("All Done.");
				Console.ReadLine();
			}catch(Exception ex)
			{
				logger.Error("Failed",ex);
			}
		}
		
		private static void BuzzTest()
		{			
			AuthenticatorFactory.GetInstance().RegisterAuthenticator(() => new ConsoleAuthenticator("https://www.googleapis.com/auth/buzz", "buzz"));			
			BuzzService buzzService = new BuzzService();
			Stream result = buzzService.People.Search("b", "c", "d", "5", "David Waters");
			 
			StreamReader sr = new StreamReader(result);
			String strResult = sr.ReadToEnd();
			logger.Info(strResult);
			
			Console.ReadLine();
			
			IDictionary<string,string> parameters = new Dictionary<string, string>();
			parameters.Add("q", "Fred");
			result = buzzService.People.Search(parameters);
			 
			sr = new StreamReader(result);
			strResult = sr.ReadToEnd();
			logger.Info(strResult);
		}
	}
}