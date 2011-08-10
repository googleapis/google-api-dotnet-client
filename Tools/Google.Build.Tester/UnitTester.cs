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
using System.IO;
using Google.Apis.Samples.Helper;
using NUnit.Core;

namespace Google.Build.Utils.Build
{
    /// <summary>
    /// A simple unit tester class.
    /// </summary>
    public class UnitTester : EventListener, IDisposable
    {
        static UnitTester()
        {
            CoreExtensions.Host.InitializeService();
        }

        private readonly SimpleTestRunner runner;
        private int failed, passed;
        
        public UnitTester(string testAssembly)
        {
            var testPackage = new TestPackage(Path.GetFileNameWithoutExtension(testAssembly));
            testPackage.Assemblies.Add(testAssembly);

            runner = new SimpleTestRunner();
            runner.Load(testPackage);
        }

        /// <summary>
        /// Runs all unit tests on this assembly.
        /// </summary>
        /// <returns>Number of failed tests.</returns>
        public int Run()
        {
            runner.Run(this);
            return failed;
        }

        private static void Log(string msg, params object[] args)
        {
            CommandLine.WriteLine("{{gray}}  "+msg, args);
            Console.Out.Flush();
        }

        public void RunStarted(string name, int testCount)
        {
            failed = 0;
            passed = 0;

            if (testCount == 0)
            {
                Log("Assembly does not contain any unit tests.");
            }
            else
            {
                Log("Running {0} tests for [{1}] ...", testCount, name);
            }
            Console.Out.Flush();
        }

        public void RunFinished(TestResult result)
        {
            if (failed == 0 && passed == 0)
            {
                return;
            }

            Log("{{green}}Tests passed: {0}", passed);
            Console.Out.Flush();

            if (result.IsError || result.IsFailure || failed > 0)
            {
                Console.Error.WriteLine("  Tests FAILED: {0}", failed);
                Console.Error.Flush();
            }
        }

        public void RunFinished(Exception exception)
        {
            Console.Error.WriteLine(exception.ToString());
            Console.Out.Flush();
        }

        public void TestStarted(TestName testName)
        {
            Log("  {{gray}}Testing '{0}'", testName.FullName);
            Console.Out.Flush();
        }

        public void TestFinished(TestResult result)
        {
            if (!result.IsSuccess)
            {
                Console.Error.WriteLine("    [{0}]: FAILED!", result.Name);
                foreach (string line in result.Message.Split(new[]{Environment.NewLine}, 0))
                {
                    Console.Error.WriteLine("      {0}", line);
                }
                Console.Error.Flush();
                failed++;
            }
            else
            {
                passed++;
            }
        }

        public void SuiteStarted(TestName testName) {}

        public void SuiteFinished(TestResult result) {}

        public void UnhandledException(Exception exception)
        {
             Console.Error.WriteLine("  Exception: "+exception.Message);
        }

        public void TestOutput(TestOutput testOutput) { }

        public void Dispose()
        {
            runner.Dispose();
        }
    }
}
