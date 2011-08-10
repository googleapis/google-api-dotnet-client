/*
Copyright 2011 Google Inc

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
using System.Runtime.InteropServices;
using Google.Apis.Samples.Helper;
using Google.Build.Utils;
using Google.Build.Utils.Build;

namespace Google.Build.Tester
{
    /// <summary>
    /// A simple unit tester.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Runs the unit tester on the specified assembly.
        /// </summary>
        /// <remarks>Called from extern assemblies.</remarks>
        public static void Run(string assembly)
        {
            // Retrieve the path to the unit tester.
            Uri testerUri = new Uri(typeof(Program).Assembly.CodeBase);
            string nativePath = testerUri.LocalPath;

            // Run the unit tester
            try
            {
                new Runner(nativePath, assembly).Run();
            } catch (ExternalException ex)
            {
                CommandLine.WriteError("{0} tests failed.", ex.ErrorCode);
                if (!CommandLine.RequestUserChoice("Do you want to continue anyway?"))
                {
                    throw;
                }
            }
        }

        internal static void Main(string[] args)
        {
            int exitCode;
            using (var tester = new UnitTester(String.Join(" ", args)))
            {
                exitCode = tester.Run();
            }
            Environment.ExitCode = exitCode;
        }
    }
}
