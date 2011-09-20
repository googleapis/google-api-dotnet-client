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
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Policy;

namespace Google.Build.Tester
{
    /// <summary>
    /// A simple unit tester.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Path to the Unit tester binary.
        /// </summary>
        public static string BinPath
        {
            get { return new Uri(typeof(Program).Assembly.CodeBase).LocalPath; }
        }

        internal static void Main(string[] args)
        {
            // Check the parameter.
            string assembly = String.Join(" ", args);
            if (!File.Exists(assembly))
            {
                Console.Error.WriteLine("Assembly not found: "+assembly);
                Environment.Exit(-1);
            }

            // Run the unit tester.
            try
            {
                Environment.ExitCode = UnitTester.Run(assembly);
            }
            catch (ReflectionTypeLoadException ex)
            {
                Console.Error.WriteLine("Failed to load types:");
                foreach (Exception e in ex.LoaderExceptions)
                {
                    Console.Error.WriteLine();
                    Console.Error.WriteLine("  " + e.Message);
                }
                Environment.Exit(-2);
            }
        }
    }
}
