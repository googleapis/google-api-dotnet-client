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
using Google.Apis.Logging;
using Moq;
using NUnit.Framework;

namespace Google.Apis.Tests.Apis.Logging
{
    /// <summary>
    /// Tests for the NullLogger class.
    /// </summary>
    [TestFixture]
    public class NullLoggerTests
    {
        /// <summary>
        /// Confirms that the constructor will not throw any exception.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new NullLogger());
        }

        /// <summary>
        /// Confirms that a type-bound logger can be created.
        /// </summary>
        [Test]
        public void GetTypeTest()
        {
            var logger = new NullLogger();
            Assert.IsNotNull(logger.ForType<ConsoleLoggerTests>());
        }

        /// <summary>
        /// Confirms that calling methods on the logger will not throw any exceptions.
        /// </summary>
        [Test]
        public void SimpleLogTest()
        {
            var myLogger = new NullLogger();
            myLogger.Debug("FooBar");
            myLogger.Warning("FooBar");
            myLogger.Error("FooBar");
            myLogger.Error(new Exception(), "FooBar");
            myLogger.Info("FooBar");
            myLogger.Info("FooBar", "Bar");
            Assert.AreEqual(myLogger.IsDebugEnabled, myLogger.IsDebugEnabled); // We don't care about the actual value.
        }
    }
}
