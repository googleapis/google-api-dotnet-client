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
using Google.Apis.Samples.CommandLineGeneratedService.V03.Buzz.Data;
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
				JsonSerilizationTest();
				Console.WriteLine("All Done.");
				Console.ReadLine();
			}catch(Exception ex)
			{
				logger.Error("Failed",ex);
			}
		}
		
		private static void JsonSerilizationTest() {
			Activitiylist activity = new Activitiylist {
				Id = "IdValue",
				Items = new List<ChiliActivitiesResourceJson>(){
					new ChiliActivitiesResourceJson(){
						Actor = new ChiliActivitiesResourceJson.NestedClass3(){
							Id = "NestedClassActorId1",
							Name = "NestedClassActorName1",
							ProfileUrl = "www.example.com"
						},
						Id = "Fish"
					},
					new ChiliActivitiesResourceJson(){
						Actor = new ChiliActivitiesResourceJson.NestedClass3(){
							Id = "NestedClassActorId2",
							Name = "NestedClassActorName2",
							ProfileUrl = "www.example.com"
						},
						Id = "Cat"
					},
					new ChiliActivitiesResourceJson(){
						Actor = new ChiliActivitiesResourceJson.NestedClass3(){
							Id = "NestedClassActorId3",
							Name = "NestedClassActorName3",
							ProfileUrl = "www.example.com"
						},
						Id = "Mouse"
					},
				},
				Kind = "KindValue",
				Title = "TitleValue",
				Updated = "UpdatedValue",				
			};
			JsonSerializerSettings settings = new JsonSerializerSettings();
			settings.NullValueHandling = NullValueHandling.Ignore;
			TextWriter tw = new StringWriter();
			var serilizer = JsonSerializer.Create(settings);
			serilizer.Serialize(tw, activity);
			Console.WriteLine(tw.ToString());
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
		
		private static void AdSenseTest ()			
		{
			Console.Write("Please enter adSenseUser:");
			//var userName = Console.ReadLine().Trim();
			var userName = "new-adsense@google.com";
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
			var param = new FactoryParameterV0_2("http://elephant.lon:9996",null);
            var service = discovery.GetService (version, DiscoveryVersion.Version_0_2, param);
			
			AdsensemgmtService adSense = new AdsensemgmtService(service , AuthenticatorFactory.GetInstance().GetRegisteredAuthenticator());
			
			var result = adSense.Reports.Generate(bodyJason);
			
			var sr = new StreamReader(result);
			String strResult = sr.ReadToEnd();
			logger.Info(strResult);
			var dict = Json.JsonReader.Parse(strResult) as Json.JsonDictionary;
			string csv = dict["csv"] as string;
			logger.Info(csv);
			var csvAsStream = new StreamReader(new MemoryStream(System.Text.UTF8Encoding.UTF8.GetBytes(csv)));
			using( CsvReader reader = new CsvReader(csvAsStream, true) )
			{
				int fieldCount = reader.FieldCount;
				string[] header = reader.GetFieldHeaders();
				foreach(string h in header)
				{
					Console.Write(string.Format("{0}\t\t", h));
				}
				while(reader.ReadNextRecord())
				{
					StringBuilder sb = new StringBuilder();
					for(int i = 0; i < fieldCount; i++)
					{
						sb.Append(reader[i]).Append("\t\t");
					}
					Console.WriteLine(sb.ToString());
				}
			}
			
			RevenueReport rp = new RevenueReport(adSense);
			rp.StartDate = new DateTime(2000, 01, 01);
			rp.EndDate = new DateTime(2010, 12, 31);
			rp.PublicationId = "ca-pub-0556581589806023";
			foreach(RevenueReport.ResultRow rr in rp.ExecuteReport())
			{
				logger.Debug(rr.ToString());
			}
		}
	}
}