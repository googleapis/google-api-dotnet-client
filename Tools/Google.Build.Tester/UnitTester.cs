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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Core;
using NUnit.Core.Filters;

namespace Google.Build.Tester
{
    /// <summary>
    /// A simple unit tester class.
    /// </summary>
    [Serializable]
    public class UnitTester : EventListener, IDisposable
    {
        static UnitTester()
        {
            CoreExtensions.Host.InitializeService();
        }

        private readonly RemoteTestRunner runner;
        private readonly AppDomain domain;
        private Results resultsSandbox;
        private List<Results.Message> messagesSandbox;
        
        [Serializable]
        public class Results
        {
            /// <summary>
            /// The total numbers of tests run.
            /// </summary>
            public int Total { get { return Passed + Failed; } }

            /// <summary>
            /// Passed unit tests.
            /// </summary>
            public int Passed { get; set; }

            /// <summary>
            ///  Failed unit tests.
            /// </summary>
            public int Failed { get; set; }

            [Serializable]
            public struct Message
            {
                public bool IsError;
                public string Text;
            }

            /// <summary>
            /// Messages
            /// </summary>
            public Message[] Messages { get; set; }
        }

        /// <summary>
        /// Creates a unit tester for the specified assembly.
        /// </summary>
        /// <returns>Number of failed unit tests.</returns>
        public static int Run(string testAssembly)
        {
            string tempFolder = Path.Combine(Path.GetTempPath(), "UnitTest" + testAssembly.GetHashCode());
            while (Directory.Exists(tempFolder))
            {
                tempFolder += "_";
            }

            Directory.CreateDirectory(tempFolder);
            try
            {
                // Copy over all assemblies.
                Utils.CopyFiles(Path.GetDirectoryName(testAssembly), tempFolder);

                // Copy over the nunit dlls.
                foreach (string dll in (from a in AppDomain.CurrentDomain.GetAssemblies() 
                                        where a.GetName().Name.StartsWith("nunit.") || a == typeof(UnitTester).Assembly
                                        select new Uri(a.CodeBase).LocalPath))
                {
                    File.Copy(dll, Path.Combine(tempFolder, Path.GetFileName(dll)));
                }

                // Create and run the unit tester
                using (UnitTester tester = new UnitTester(Path.Combine(tempFolder, Path.GetFileName(testAssembly))))
                {
                    Results results = tester.Run();
                    foreach (var msg in results.Messages)
                    {
                        (msg.IsError ? Console.Error : Console.Out).WriteLine(msg.Text);
                    }
                    if (results.Total > 0)
                    {
                        Console.WriteLine("PASSED: " + results.Passed);

                        if (results.Failed > 0)
                        {
                            Console.Error.WriteLine("FAILED: " + results.Failed);
                        }
                    }
                    return results.Failed;
                }
            }
            finally
            {
                Directory.Delete(tempFolder, true);
            }
        }
        
        private UnitTester(string testAssembly)
        {
            var testPackage = new TestPackage(Path.GetFileNameWithoutExtension(testAssembly));
            testPackage.Assemblies.Add(testAssembly);

            // Create a new appdomain with the appropriate working directory.
            // This is required so that we don't accidentially load the wrong dependencies.
            var setup = new AppDomainSetup();
            setup.ApplicationBase = Path.GetDirectoryName(testAssembly);
            domain = AppDomain.CreateDomain("TestDomain", null, setup);
            
            runner = RemoteTestRunner.CreateInstance(domain, 0);
            runner.Load(testPackage);
        }

        /// <summary>
        /// Runs all unit tests on this assembly.
        /// </summary>
        /// <returns>Number of failed tests.</returns>
        public Results Run()
        {
            runner.Run(this);
            return domain.GetData("Results") as Results;
        }

        private void Log(bool error, string msg, params object[] args)
        {
            messagesSandbox.Add(new Results.Message() { IsError = error, Text = string.Format(msg, args) });
        }

        public void RunStarted(string name, int testCount)
        {
            resultsSandbox = new Results();
            resultsSandbox.Passed = 0;
            resultsSandbox.Failed = 0;
            messagesSandbox = new List<Results.Message>();

            if (testCount == 0)
            {
                Log(false, "Assembly does not contain any unit tests.");
            }
            else
            {
                Log(false, "Running {0} tests for [{1}] ...", testCount, name);
            }
            Console.Out.Flush();
        }

        public void RunFinished(TestResult result)
        {
            resultsSandbox.Messages = messagesSandbox.ToArray();
            AppDomain.CurrentDomain.SetData("Results", resultsSandbox);
        }

        public void RunFinished(Exception exception)
        {
            Console.Error.WriteLine(exception.ToString());
            Console.Out.Flush();
        }

        public void TestStarted(TestName testName)
        {
            Log(false, "  Testing '{0}'", testName.FullName);
            Console.Out.Flush();
        }

        public void TestFinished(TestResult result)
        {
            if (!result.IsSuccess)
            {
                Log(true, "    [{0}]: FAILED!", result.Name);
                foreach (string line in result.Message.Split(new[]{Environment.NewLine}, 0))
                {
                    Log(true,"      {0}", line);
                }
                resultsSandbox.Failed++;
            }
            else
            {
                resultsSandbox.Passed++;
            }
        }

        public void SuiteStarted(TestName testName) {}

        public void SuiteFinished(TestResult result) {}

        public void UnhandledException(Exception exception)
        {
             Log(true, "  Exception: "+exception.Message);
        }

        public void TestOutput(TestOutput testOutput) { }

        public void Dispose()
        {
            runner.Dispose();
            AppDomain.Unload(domain);
        }
    }
}
