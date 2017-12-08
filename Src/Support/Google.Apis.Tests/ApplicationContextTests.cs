/*
Copyright 2017 Google Inc

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
using Google.Apis.Logging;
using Xunit;

namespace Google.Apis.Tests
{
    /// <summary>Tests for <see cref="Google.ApplicationContext"/>.</summary>
    public class ApplicationContextTests
    {
        private class MockLogger : ILogger
        {
            public bool IsDebugEnabled => false;

            public ILogger ForType(Type type) => this;

            public ILogger ForType<T>() => this;

            public void Info(string message, params object[] formatArgs)
            {
                throw new NotImplementedException();
            }

            public void Warning(string message, params object[] formatArgs)
            {
                throw new NotImplementedException();
            }

            public void Debug(string message, params object[] formatArgs)
            {
                throw new NotImplementedException();
            }

            public void Error(Exception exception, string message, params object[] formatArgs)
            {
                throw new NotImplementedException();
            }

            public void Error(string message, params object[] formatArgs)
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Checks the registered default logger.
        /// </summary>
        [Fact]
        public void GetLoggerDefaultTest()
        {
            ApplicationContext.Reset();
            Assert.IsType<NullLogger>(ApplicationContext.Logger);
        }

        /// <summary>
        /// Confirms that the RegisterLogger method will not fail when no logger was previously registered.
        /// </summary>
        [Fact]
        public void RegisterLoggerTest()
        {
            ApplicationContext.Reset();
            try
            {
                // Initialize with a NullLogger: check default logger
                Assert.IsType<NullLogger>(ApplicationContext.Logger);

                // Register a new logger: should not throw
                ApplicationContext.RegisterLogger(new MockLogger());

                // Fail test: should now throw, only allowed to register one logger
                Assert.Throws<InvalidOperationException>(() => ApplicationContext.RegisterLogger(new MockLogger()));
            }
            finally
            {
                ApplicationContext.Reset();
            }
        }
    }
}
