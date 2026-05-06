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
using System.Linq;
using Xunit;

namespace Google.Apis.Tests.Apis.Utils
{
    /// <summary>Tests for <see cref="Google.Apis.Util.ReflectionCache"/>.</summary>
    public class ReflectionCacheTest
    {
        private class TestClass
        {
            [RequestParameter("test_param", RequestParameterType.Query)]
            public string TestProperty { get; set; }

            [RequestParameter("another_param", RequestParameterType.Path)]
            public int AnotherProperty { get; set; }

            public string PropertyWithoutAttribute { get; set; }
        }

        [Fact]
        public void GetRequestParameterProperties_ReturnsPropertiesAndAttributes()
        {
            var propertiesWithAttributes = ReflectionCache.GetRequestParameterProperties(typeof(TestClass));

            Assert.NotNull(propertiesWithAttributes);
            Assert.Equal(2, propertiesWithAttributes.Length);

            var testProperty = propertiesWithAttributes.Single(p => p.Property.Name == "TestProperty");
            Assert.NotNull(testProperty.Property);
            Assert.Equal("test_param", testProperty.Name);
            Assert.Equal(RequestParameterType.Query, testProperty.Type);

            var anotherProperty = propertiesWithAttributes.Single(p => p.Property.Name == "AnotherProperty");
            Assert.NotNull(anotherProperty.Property);
            Assert.Equal("another_param", anotherProperty.Name);
            Assert.Equal(RequestParameterType.Path, anotherProperty.Type);

            Assert.DoesNotContain(propertiesWithAttributes, p => p.Property.Name == "PropertyWithoutAttribute");
        }

        [Fact]
        public void GetRequestParameterProperties_ReturnsOnlyPropertiesWithAttribute()
        {
            var properties = ReflectionCache.GetRequestParameterProperties(typeof(TestClass));

            Assert.Equal(2, properties.Length);
            Assert.Contains(properties, p => p.Property.Name == "TestProperty");
            Assert.Contains(properties, p => p.Property.Name == "AnotherProperty");
            Assert.DoesNotContain(properties, p => p.Property.Name == "PropertyWithoutAttribute");
        }

        [Fact]
        public void GetRequestParameterProperties_CachesResults()
        {
            var result1 = ReflectionCache.GetRequestParameterProperties(typeof(TestClass));
            var result2 = ReflectionCache.GetRequestParameterProperties(typeof(TestClass));
            var result3 = ReflectionCache.GetRequestParameterProperties(typeof(TestClass));

            // Same array instance on every call.
            Assert.Same(result1, result2);
            Assert.Same(result2, result3);

            // Same RequestParameterDescriptor instances within the array.
            for (int i = 0; i < result1.Length; i++)
            {
                Assert.Same(result1[i], result2[i]);
                Assert.Same(result2[i], result3[i]);
            }
        }
    }
}
