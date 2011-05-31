using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Google.Apis.Samples.Helper;
using Google.Apis.Tools.CodeGen;

namespace ServiceGenerator
{
    class Program
    {
        [Description("service")]
        public class ServiceDescription
        {
            [Description("service name")] 
            public string ServiceName = "discovery";
            [Description("service version")]
            public string ServiceVersion = "v1";
        }

        static void Main(string[] args)
        {
            CommandLine.DisplayGoogleSampleHeader("Service Generator");

            // Parse parameters
            var description = args.Length >= 2
                                  ? new ServiceDescription { ServiceName = args[0], ServiceVersion = args[1] }
                                  : CommandLine.CreateClassFromUserinput<ServiceDescription>();


            string fileName = string.Format("{0}.{1}.cs", description.ServiceName,
                                            description.ServiceVersion);

            // Generate Service
            CommandLine.WriteLine("^9 Generating service ...");
            GoogleServiceGenerator.GenerateService(description.ServiceName,
                                                   description.ServiceVersion, "Google.Apis",
                                                   "CSharp",
                                                   fileName);


            CommandLine.WriteLine("^9 Service generated in " + fileName + "!");

            CommandLine.PressAnyKeyToExit();

        }
    }
}
