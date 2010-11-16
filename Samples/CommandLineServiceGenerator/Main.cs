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
			var clientNameSpace ="Google.Apis.Samples.CommandLineGeneratedService.Buzz";
			var lang = "CSharp";
			var output = "../../../CommandLineGeneratedService/Buzz/BuzzService.cs";
			
			Google.Apis.Tools.CodeGen.MainClass.GenerateClass(serviceName, version, clientNameSpace, lang, output); 
			Logger.Debug("All Done");
		}
	}
}

