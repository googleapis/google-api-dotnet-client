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
using System.Configuration;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

using Google.Apis;
using Google.Apis.Discovery;
using Google.Apis.Samples.CommandLine.Views;
using Google.Apis.Samples.CommandLine.Controllers;

namespace Google.Apis.Samples.CommandLine
{
	class MainClass
	{
		
		public static log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MainClass));
		
		public static bool CheckValidationResult (object sender, X509Certificate cert, X509Chain X509Chain, SslPolicyErrors errors)
		{
			return true;
		}
				
		public static void Main (string[] args)
		{
			//System.Configuration.
			
			Logger.Info("Sample starting...");

			
			var serviceName = "buzz";
			var version = "v1";
			
			if(args.Length > 0)
			{
				serviceName = args[0];
				
				if(args.Length == 2) 
					version = args[1];
			}
				
			
			ServicePointManager.ServerCertificateValidationCallback += CheckValidationResult;
			
			
			// Set up how discovery works.
			var webfetcher = new WebDiscoveryDevice { DiscoveryUri = new Uri("http://www.googleapis.com/discovery/0.1/describe?api=" + serviceName)};
			
			var discovery = new DiscoveryService(webfetcher);
			// Build the service based on discovery information.
			var service = discovery.GetService(version, DiscoveryVersion.Version_0_1, null);
			
			// Output sevice information
			var serviceView = new ServiceView();
			var controller = new ServiceController(service, serviceView);
			controller.Run();
		}
	}
}

