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
using System.Collections.Generic;

using Google.Apis.Discovery;
using Google.Apis.Authentication;
using Google.Apis.Samples.CommandLineGeneratedService.Buzz; 
using Google.Apis.Samples.GeneratedService.AdSense;

namespace Google.Apis.Samples.CommandLineGeneratedService {
	class MainClass {

		public readonly static log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MainClass));
		public const string bodyJason = @"
{
  ""scope"": {
    ""property_codes"": [""ca-pub-0556581589806023""]
  },
  ""dimensions"": [""DATE""],
  ""metrics"": [""PAGE_VIEWS_ALL"", ""QUERIES_PUBLISHER"", ""QUERIES_COVERAGE"", ""CLICKS_PUBLISHER"", ""QUERIES_CTR"", ""COST_PER_CLICK"", ""QUERIES_RPM"", ""PUBLISHER_EARNINGS""],
  ""period"": {
  ""start_date"": ""200000101"",
  ""end_date"": ""20101231""
  }
}
";
		// , ""WEB_PROPERTY_CODE""
		//,""PUBLISHER_EARNINGS"", ""PAGE_VIEWS_NONSPAM""
		
		public static bool CheckValidationResult(object sender, X509Certificate cert, X509Chain X509Chain, SslPolicyErrors errors) {
			return true;
		}


		public static void Main(string[] args) {
			ServicePointManager.ServerCertificateValidationCallback += CheckValidationResult;
			try{
				//BuzzTest();
				AdSenseTest ();
				Console.WriteLine("All Done.");
				Console.ReadLine();
			}catch(Exception ex)
			{
				Logger.Error("Failed",ex);
			}
		}
		
		private static void BuzzTest()
		{			
			AuthenticatorFactory.GetInstance().RegisterAuthenticator(() => new ConsoleAuthenticator("https://www.googleapis.com/auth/buzz", "buzz"));			
			BuzzService buzzService = new BuzzService();
			Stream result = buzzService.People.Search("b", "c", "d", "5", "David Waters");
			 
			StreamReader sr = new StreamReader(result);
			String strResult = sr.ReadToEnd();
			Logger.Info(strResult);
			
			Console.ReadLine();
			
			IDictionary<string,string> parameters = new Dictionary<string, string>();
			parameters.Add("q", "Fred");
			result = buzzService.People.Search(parameters);
			 
			sr = new StreamReader(result);
			strResult = sr.ReadToEnd();
			Logger.Info(strResult);
		}
		
		private static void AdSenseTest ()
		{
			Console.Write("Please enter adSenseUser:");
			var userName = Console.ReadLine().Trim();
			Console.Write("Please enter password:");
			var password = Console.ReadLine().Trim();
			var passwordSupplier = new PrefetchedUserNamePasswordSupplier(userName,password);					
			AuthenticatorFactory.GetInstance().RegisterAuthenticator(
				() => new ClientAuth(passwordSupplier, "adsense", "adsense"));
			var version = "v1beta1";
			string cacheDirectory = Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.ApplicationData), "GoogleApis.Tools.CodeGenCache");
            if (Directory.Exists (cacheDirectory) == false) {
                Directory.CreateDirectory (cacheDirectory);
            }
            var webfetcher = new CachedWebDiscoveryDevice (
                                new Uri ("http://elephant.lon:9996/discovery/v0.2beta1/describe/adsense-mgmt/v1beta1"), 
                                new DirectoryInfo (cacheDirectory));
            var discovery = new DiscoveryService (webfetcher);
            // Build the service based on discovery information.
			var param = new ServiceFactory.FactoryV_0_2Parameter("http://elephant.lon:9996",null);
            var service = discovery.GetService (version, DiscoveryVersion.Version_0_2, param);
			
			AdsensemgmtService adSense = new AdsensemgmtService(service , AuthenticatorFactory.GetInstance().GetRegisteredAuthenticator());
			
			var result = adSense.Reports.Generate(bodyJason);
			
			var sr = new StreamReader(result);
			String strResult = sr.ReadToEnd();
			Console.Write(strResult);
			Logger.Info(strResult);
			
		}
	}
}