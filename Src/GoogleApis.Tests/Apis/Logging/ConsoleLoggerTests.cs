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
using System.Reflection;
using Google.Apis.Logging;
using Google.Apis.Util;
using Moq;
using NUnit.Framework;

namespace Google.Apis.Tests.Apis.Logging
{
    /// <summary>
    /// Tests for the ConsoleLogger class.
    /// </summary>
    [TestFixture]
    public class ConsoleLoggerTests
    {
        /// <summary>
        /// Confirms that the constructor will not throw any exception.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new ConsoleLogger());
        }

        /// <summary>
        /// Confirms that a type-bound logger can be created.
        /// </summary>
        [Test]
        public void GetTypeTest()
        {
            var logger = new ConsoleLogger();
            Assert.IsNotNull(logger.ForType<ConsoleLoggerTests>());
        }

        /// <summary>
        /// Confirms that calling methods on the logger will not throw any exceptions.
        /// </summary>
        [Test]
        public void SimpleLogTest()
        {
            var myLogger = new ConsoleLogger();
            myLogger.Debug("FooBar");
            myLogger.Warning("FooBar");
            myLogger.Error("FooBar");
            myLogger.Error(new Exception(), "FooBar");
            myLogger.Info("FooBar");
            myLogger.Info("FooBar", "Bar");
            Assert.AreEqual(myLogger.IsDebugEnabled, myLogger.IsDebugEnabled); // We don't care about the actual value.
        }

        /// <summary>
        /// Confirms that the logger sends it output to the console stream.
        /// </summary>
        [Test]
        public void ConfirmLoggingTest()
        {
            var myLogger = new ConsoleLogger();

            // Create mock TextWriters which confirm the output
            var stringOutput = new Mock<TextWriter>();
            stringOutput.Setup(w => w.WriteLine(It.IsRegex("\\([^)]+\\) \\.NET Client API \\[(\\w+)\\]: FooBar")));
            
            var nullOutput = new Mock<TextWriter>();
            nullOutput
                .Setup(w => w.WriteLine(It.IsAny<string>()))
                .Callback<string>(str => Assert.Fail("Unexpected WriteLine(): " + str));
            
            // Test non-error methods:
            Console.SetOut(stringOutput.Object);
            Console.SetError(nullOutput.Object);

            myLogger.Info("FooBar");
            myLogger.Debug("FooBar");
            myLogger.Warning("FooBar");
            
            stringOutput.Verify();
            nullOutput.Verify();

            //  Test error-methods:
            Console.SetOut(nullOutput.Object);
            Console.SetError(stringOutput.Object);
            
            myLogger.Error("FooBar");

            stringOutput.Verify();
            nullOutput.Verify();
        }

        /// <summary>
        /// Cleans up all test-residue.
        /// </summary>
        [TearDown]
        public void CleanUp()
        {
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            Console.SetError(new StreamWriter(Console.OpenStandardError()));
        }
    }
}
