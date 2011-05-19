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

using Google.Apis;
using Google.Apis.Discovery;

namespace Google.Apis.Samples.ListServices
{
    internal class Program
    {
        /// <summary>
        /// Lists all the services for a given API.
        /// 
        /// If no service is provided, then the "moderator" service will be used
        /// </summary>
        /// <param name="args">
        /// Syntax: [<service name> [<service version>]]
        /// </param>
        /// <example>
        /// Windows:
        /// 
        /// ListServices.exe buzz
        /// ListServices.exe latitude
        /// ListServices.exe moderator v1
        /// 
        /// Mac / Unix (Mono)
        /// mono ListServices.exe buzz
        /// mono ListServices.exe latitude
        /// mono ListServices.exe moderator v1
        /// </example>
        public static void Main(string[] args)
        {
            // Define our discovery source
            string serviceName = "urlshortener";
            string serviceVersion = "v1";
            
            if (args.Length >= 1) { // Override service name
                serviceName = args[0];
            }
            if (args.Length >= 2) { // Override service version
                serviceVersion = args[1];
            }

            // Highlight output
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            // Display the service info
            var serviceInfo = new ServiceInfo(serviceName, serviceVersion);
            serviceInfo.Display();

            // Prevent instantaneous exit
            Console.ReadKey();
        }
    }
}
