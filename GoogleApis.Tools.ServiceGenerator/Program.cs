/*
Copyright 2011 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
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
using System.Linq;
using Google.Apis.Util;

namespace GoogleApis.Tools.ServiceGenerator
{
    /// <summary>
    /// The ServiceGenerator can be used to generate strongly typed source code and libraries for any discovery-based
    /// service.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set the default settings.
            string outputDir = "Services";
            var flags = GeneratorFlags.CompileLibrary;

            if (args.Length == 0) // If no argument is specified, display the usage.
            {
                args = new[] { "--help" };
            }

            // Run the application.
            try
            {
                // Parse arguments.
                string type = null;
                string source = null;
                var enumerator = new ArgumentEnumerator(args);
                while (enumerator.MoveNext())
                {
                    string arg = enumerator.Current.ToLower();

                    if (enumerator.IsParameter)
                    {
                        switch (arg)
                        {
                            case "--help":
                            case "-h":
                                Console.WriteLine("SYNTAX:  ServiceGenerator.exe [<arguments>] <Type> <Source>");
                                Console.WriteLine(" Types can be:");
                                Console.WriteLine("   'repository' -- Generate a whole discovery repository");
                                Console.WriteLine("   'url'        -- Generate a service of an uri");
                                Console.WriteLine("   'service'    -- Generate a named google service");
                                Console.WriteLine(" Source is:");
                                Console.WriteLine("   URI (http:// .. or file:/// ..) for 'repository'/'url'");
                                Console.WriteLine("   serviceName:version for 'service'");
                                Console.WriteLine(" Optional arguments:");
                                Console.WriteLine("   --help, -h           Displays this help screen");
                                Console.WriteLine("   --no-compile, -nc    Will not generate a .dll");
                                Console.WriteLine("   --google             Will add a Google prefix to the service");
                                Console.WriteLine("   --output, -o <dir>   Changes the output directory");
                                return;

                            case "--no-compile":
                            case "-nc":
                                flags &= ~GeneratorFlags.CompileLibrary;
                                break;

                            case "--google":
                                flags |= GeneratorFlags.GoogleService;
                                break;

                            case "--output":
                            case "-o":
                                enumerator.MoveNext();
                                outputDir = enumerator.GetParameterValue("--output");
                                break;

                            default:
                                throw new ArgumentException("Unknown argument: " + arg);
                        }
                    }
                    else
                    {
                        if (type == null)
                        {
                            type = enumerator.GetMandatory("type").ToLower();
                        }
                        else if (source == null)
                        {
                            source = enumerator.Current;
                        }
                        else
                        {
                            Console.Error.WriteLine("Unexpected argument: "+enumerator.Current);
                        }
                    }
                }

                type.ThrowIfNullOrEmpty("type");

                // Create the generator, and run it.
                Generator generator = new Generator(flags) { OutputDir = outputDir};
                switch (type)
                {
                    case "repository":
                        var apis = (source == null)
                                       ? DiscoveryRepository.RetrieveGoogleDiscovery()
                                       : DiscoveryRepository.RetrieveDiscovery(new Uri(source));
                        generator.GenerateServices(apis);
                        break;

                    case "url":
                        source.ThrowIfNull("source");
                        generator.GenerateService(new Uri(source));
                        break;

                    case "service":
                        source.ThrowIfNull("source");
                        var api =
                            (from a in DiscoveryRepository.RetrieveGoogleDiscovery()
                             where a.Id == source
                             select a).SingleOrDefault();

                        if (api == null)
                        {
                            throw new ArgumentException("The api '" + source + "' was not found in the repository.");
                        }

                        generator.GenerateService(api);
                        break;

                    default:
                        throw new ArgumentException("Unknown type: " + type);
                }
            }
            catch (Exception exception)
            {
                Console.Error.WriteLine("ERROR: " + exception.Message);
                Console.Error.WriteLine(exception.StackTrace);
                Environment.Exit(1);
            }
        }
    }
}
