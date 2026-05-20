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
using Google.Apis.Tests.Apis.Utils;
using Google.Apis.Util;
using Xunit;

namespace Google.Apis.Tests
{
    /// <summary>Tests for <see cref="Google.ApplicationContext"/>.</summary>
    public class ApplicationContextTests
    {
        // A mock logger that is identical to the NullLogger,
        // but is required for tests as an ILogger is required
        // that is not an instance of NullLogger.
        // This MockLogger must not throw exceptions as other tests
        // may be running at the same time as the tests below,
        // and settings logger is a global operation.
        private class MockLogger : ILogger
        {
            public bool IsDebugEnabled => false;

            public ILogger ForType(Type type) => this;

            public ILogger ForType<T>() => this;

            public void Info(string message, params object[] formatArgs) { }

            public void Warning(string message, params object[] formatArgs) { }

            public void Debug(string message, params object[] formatArgs) { }

            public void Error(Exception exception, string message, params object[] formatArgs) { }

            public void Error(string message, params object[] formatArgs) { }
        }

        /// <summary>
        /// Checks the registered default logger.
        /// </summary>
        [Fact]
        public void Default()
        {
            ApplicationContext.Reset();
            Assert.IsType<NullLogger>(ApplicationContext.Logger);
            Assert.False(ApplicationContext.EnableRequestParameterCache);
            Assert.Equal(RequestParameterDescriptorProvider.GetUncachedRequestParameterProperties, ApplicationContext.RequestParameterProvider);
        }

        /// <summary>
        /// Confirms that the RegisterLogger method will not fail when no logger was previously registered.
        /// </summary>
        [Fact]
        public void RegisterLogger()
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

        [Fact]
        public void EnableRequestParameterCache()
        {
            ApplicationContext.Reset();
            try
            {
                ApplicationContext.EnableRequestParameterCache = true;

                Assert.True(ApplicationContext.EnableRequestParameterCache);
                Assert.Equal(RequestParameterDescriptorProvider.GetCachedRequestParameterProperties, ApplicationContext.RequestParameterProvider);
            }
            finally
            {
                ApplicationContext.Reset();
            }
        }

        [Fact]
        public void DisableRequestParameterCache()
        {
            ApplicationContext.Reset();
            try
            {
                ApplicationContext.EnableRequestParameterCache = true;
                ApplicationContext.EnableRequestParameterCache = false;

                Assert.False(ApplicationContext.EnableRequestParameterCache);
                Assert.Equal(RequestParameterDescriptorProvider.GetUncachedRequestParameterProperties, ApplicationContext.RequestParameterProvider);
            }
            finally
            {
                ApplicationContext.Reset();
            }
        }

        [Fact]
        public void DisableRequestParameterCache_CacheCleared()
        {
            ApplicationContext.Reset();
            try
            {
                ApplicationContext.EnableRequestParameterCache = true;
                var result1 = ApplicationContext.RequestParameterProvider(typeof(RequestParameterDescriptorProviderTest.TestClass));

                // This should clear the cache, even if we enable cache right after.
                ApplicationContext.EnableRequestParameterCache = false;
                ApplicationContext.EnableRequestParameterCache = true;
                var result2 = ApplicationContext.RequestParameterProvider(typeof(RequestParameterDescriptorProviderTest.TestClass));

                Assert.NotSame(result1, result2);
            }
            finally
            {
                ApplicationContext.Reset();
            }
        }
    }
}
