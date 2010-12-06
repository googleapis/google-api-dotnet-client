using System;
using Google.Apis;
using Google.Apis.Tools.CodeGen;

namespace Google.Apis.Samples.ComandLineServiceGenerator
{
	class MainClass
	{
		public static log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MainClass));
		
		public static void Main (string[] args)
		{
			Logger.Debug("Logging Started");
			var serviceName = "buzz";
			var version = "v1";
			var clientNamespace ="Google.Apis.Samples.CommandLineGeneratedService.Buzz";
			var language = "CSharp";
			var output = "../../../CommandLineGeneratedService/Buzz/BuzzService.cs";
			
			GoogleServiceGenerator.GenerateService(serviceName, version, clientNamespace, language, output); 
			Logger.Debug("All Done");
		}
	}
}

