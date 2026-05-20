/*
Copyright 2026 Google Inc

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

using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Google.Apis.Tests.Apis.Utils
{
    /// <summary>Tests for <see cref="Google.Apis.Util.RequestParameterDescriptorProvider"/>.</summary>
    public class RequestParameterDescriptorProviderTest
    {
        internal class TestClass
        {
            [RequestParameter("test_param", RequestParameterType.Query)]
            public string TestProperty { get; set; }

            [RequestParameter("another_param", RequestParameterType.Path)]
            public int AnotherProperty { get; set; }

            public string PropertyWithoutAttribute { get; set; }

            [RequestParameter("static_param")]
            public static string StaticProperty { get; set; }

            [RequestParameter("private_param")]
            private string PrivateProperty { get; set; }
        }

        public static TheoryData<Func<Type, IEnumerable<PropertyInfo>>> Providers { get; } = new TheoryData<Func<Type, IEnumerable<PropertyInfo>>>
        {
           RequestParameterDescriptorProvider.GetUncachedRequestParameterProperties,
           RequestParameterDescriptorProvider.GetCachedRequestParameterProperties,
        };

        [Theory]
        [MemberData(nameof(Providers))]
        public void GetRequestParameterProperties(Func<Type, IEnumerable<PropertyInfo>> provider)
        {
            var propertiesWithAttributes = provider(typeof(TestClass));

            Assert.NotNull(propertiesWithAttributes);
            Assert.Equal(2, propertiesWithAttributes.Count());

            Assert.Single(propertiesWithAttributes, property => property.Name == nameof(TestClass.TestProperty));
            Assert.Single(propertiesWithAttributes, property => property.Name == nameof(TestClass.AnotherProperty));
        }

        [Fact]
        public void GetCacheRequestParameterProperties()
        {
            var result1 = RequestParameterDescriptorProvider.GetCachedRequestParameterProperties(typeof(TestClass));
            var result2 = RequestParameterDescriptorProvider.GetCachedRequestParameterProperties(typeof(TestClass));
            var result3 = RequestParameterDescriptorProvider.GetCachedRequestParameterProperties(typeof(TestClass));

            // Same instance on every call.
            Assert.Same(result1, result2);
            Assert.Same(result2, result3);
        }

        [Fact]
        public void GetUncachedRequestParameterProperties()
        {
            var result1 = RequestParameterDescriptorProvider.GetUncachedRequestParameterProperties(typeof(TestClass));
            var result2 = RequestParameterDescriptorProvider.GetUncachedRequestParameterProperties(typeof(TestClass));
            var result3 = RequestParameterDescriptorProvider.GetUncachedRequestParameterProperties(typeof(TestClass));

            // Different instance on every call
            Assert.NotSame(result1, result2);
            Assert.NotSame(result1, result3);
            Assert.NotSame(result2, result3);
        }

        [Fact]
        public void ClearCache()
        {
            var result1 = RequestParameterDescriptorProvider.GetCachedRequestParameterProperties(typeof(TestClass));
            RequestParameterDescriptorProvider.ClearCache();
            var result2 = RequestParameterDescriptorProvider.GetCachedRequestParameterProperties(typeof(TestClass));

            Assert.NotSame(result1, result2);
        }
    }
}
