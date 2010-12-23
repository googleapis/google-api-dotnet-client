using System;
using System.IO;
using System.CodeDom.Compiler;

using Google.Apis;
using Google.Apis.Tools.CodeGen;

using Google.Apis.Discovery;

namespace Google.Apis.Samples.ComandLineServiceGenerator
{
	class MainClass
	{
		public static log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(MainClass));
		
		public static void Main (string[] args)
		{
			Logger.Debug("Logging Started");
			GenerateBuzzService ();
			GenerateAdSenseService();
			Logger.Debug("All Done");
		}
		
		private static void GenerateBuzzService ()
		{
			var serviceName = "buzz";
			var version = "v1";
			var clientNamespace ="Google.Apis.Samples.CommandLineGeneratedService.Buzz";
			var language = "CSharp";
			var output = "../../../CommandLineGeneratedService/Buzz/BuzzService.cs";
			
			GoogleServiceGenerator.GenerateService(serviceName, version, clientNamespace, language, output); 
		}
		
		private static void GenerateAdSenseService()
		{
			//var serviceName = "adsenseapi";
			var version = "v1beta1";
			var clientNamespace ="Google.Apis.Samples.GeneratedService.AdSense";
			var language = "CSharp";
			var outputFile = "../../../CommandLineGeneratedService/AdSense/AdSenseService.cs";
			
			// Set up how discovery works.
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
            
            var generator = new GoogleServiceGenerator (service, clientNamespace);
            
            var provider = CodeDomProvider.CreateProvider (language);
            
            using (StreamWriter sw = new StreamWriter (outputFile, false)) {
                IndentedTextWriter tw = new IndentedTextWriter (sw, "  ");
                
                // Generate source code using the code provider.
                
                provider.GenerateCodeFromCompileUnit (generator.GenerateCode (), tw, new CodeGeneratorOptions ());
                
                // Close the output file.
                tw.Close ();
            }
		}
	}
}

