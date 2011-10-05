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
using System.Reflection;
using Google.Apis.Logging;
using Google.Apis.Util;
using NUnit.Framework;

namespace Google.Apis.Tests.Apis.Logging
{
    /// <summary>
    /// Tests for the Log4NetLogger class.
    /// </summary>
    [TestFixture]
    public class Log4NetLoggerTests
    {
        /// <summary>
        /// Confirms that the constructor will not throw any exception during reflection.
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new Log4NetLogger());
            Assert.DoesNotThrow(() => new Log4NetLogger(typeof(Log4NetLogger)));
        }

        /// <summary>
        /// Confirms that the CreateILogInstance() method will return an ILog instance.
        /// </summary>
        [Test]
        public void CreateILogInstanceTest()
        {
            Assembly log4net = LazyBinding.GetAssembly("log4net");
            object logger = Log4NetLogger.CreateILogInstance(log4net, "MyLoggerName");
            Assert.IsNotNull(logger);
            Assert.IsTrue(log4net.GetType("log4net.ILog", true).IsAssignableFrom(logger.GetType()));
        }

        /// <summary>
        /// Confirms that calling methods on the logger will not throw any exceptions.
        /// </summary>
        [Test]
        public void SimpleLogTest()
        {
            var myLogger = new Log4NetLogger(typeof(Log4NetLogger));
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
