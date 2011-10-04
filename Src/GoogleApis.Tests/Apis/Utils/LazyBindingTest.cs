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
using Google.Apis.Util;
using NUnit.Framework;

namespace Google.Apis.Tests.Apis.Utils
{
    /// <summary>
    /// Tests for the static "LazyBinding"-class
    /// </summary>
    [TestFixture]
    public class LazyBindingTest
    {
        /// <summary>
        /// Tests the "GetAssembly" method with a already loaded assembly.
        /// </summary>
        [Test]
        public void GetAssemblyCachedTest()
        {
            // Check that the same Assembly object is returned.
            Assembly thisAssembly = Assembly.GetExecutingAssembly();
            Assert.AreEqual(thisAssembly, LazyBinding.GetAssembly(thisAssembly.GetName().Name));
        }

        /// <summary>
        /// Tests the "GetAssembly" method with a non-existent assembly.
        /// </summary>
        [Test]
        public void GetAssemblyNonExistentTest()
        {
            // Ensure that an exception is thrown.
            Assert.Throws<FileNotFoundException>(() => LazyBinding.GetAssembly("non_existing_example_dll"));
        }

        /// <summary>
        /// Tests the "GetAssembly" method with an unloaded assembly.
        /// </summary>
        [Test]
        public void GetAssemblyUncachedTest()
        {
            // Check that the same Assembly object is returned.
            Assert.IsNotNull(LazyBinding.GetAssembly("log4net"));
        }

        /// <summary>
        /// Class for testing the Create[..]Delegate methods.
        /// </summary>
        private class MockClass
        {
            public int TimesCalled = 0;

            public string MockProperty { get; set; }

            public void MockMethod()
            {
                TimesCalled++; 
            }
        }

        /// <summary>
        /// Confirms that the CreateMethodDelegate will create a valid delegate when passing a MethodInfo.
        /// </summary>
        [Test]
        public void CreateMethodDelegateTest()
        {
            var testClass = new MockClass();
            LazyBinding.CreateMethodDelegate<Action>(testClass, testClass.GetType().GetMethod("MockMethod"))();
            Assert.AreEqual(1, testClass.TimesCalled);
        }

        /// <summary>
        /// Confirms that the CreateMethodDelegate will create a valid delegate when passing a method name.
        /// </summary>
        [Test]
        public void CreateMethodDelegateByNameTest()
        {
            var testClass = new MockClass();
            LazyBinding.CreateMethodDelegate<Action>(testClass, "MockMethod")();
            Assert.AreEqual(1, testClass.TimesCalled);
        }

        /// <summary>
        /// Confirms that the CreateMethodDelegate will create a valid delegate when passing a property name.
        /// </summary>
        [Test]
        public void CreatePropertyGetDelegateByNameTest()
        {
            var testClass = new MockClass() { MockProperty = "FooBar" };
            string result = LazyBinding.CreatePropertyGetDelegate<string>(testClass, "MockProperty")();
            Assert.AreEqual("FooBar", result);
        }

        /// <summary>
        /// Confirms that the CreateMethodDelegate will create a valid delegate when passing a property.
        /// </summary>
        [Test]
        public void CreatePropertyGetDelegateTest()
        {
            var testClass = new MockClass() { MockProperty = "FooBar" };
            PropertyInfo property = testClass.GetType().GetProperty("MockProperty");
            string result = LazyBinding.CreatePropertyGetDelegate<string>(testClass, property)();
            Assert.AreEqual("FooBar", result);
        }
    }
}
