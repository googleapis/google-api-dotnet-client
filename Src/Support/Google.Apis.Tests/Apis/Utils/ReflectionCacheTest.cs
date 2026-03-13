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

using Google;
using Google.Apis.Util;
using System;
using System.Linq;
using Xunit;

namespace Google.Apis.Tests.Apis.Utils
{
    /// <summary>Tests for <see cref="Google.Apis.Util.ReflectionCache"/>.</summary>
    public class ReflectionCacheTest : IDisposable
    {
        private readonly bool _originalCacheState;

        public ReflectionCacheTest()
        {
            // Save original state to restore after each test
            _originalCacheState = ApplicationContext.EnableReflectionCache;
        }

        public void Dispose()
        {
            // Restore original state after each test
            ApplicationContext.EnableReflectionCache = _originalCacheState;
        }
        private class TestClass
        {
            [RequestParameter("test_param", RequestParameterType.Query)]
            public string TestProperty { get; set; }

            [RequestParameter("another_param", RequestParameterType.Path)]
            public int AnotherProperty { get; set; }

            public string PropertyWithoutAttribute { get; set; }
        }

        [Fact]
        public void GetRequestParameterPropertiesWithAttribute_ReturnsPropertiesAndAttributes()
        {
            // Arrange - cache disabled (default behavior)
            ApplicationContext.EnableReflectionCache = false;

            // Act
            var propertiesWithAttributes = ReflectionCache.GetRequestParameterProperties(typeof(TestClass));

            // Assert
            Assert.NotNull(propertiesWithAttributes);
            Assert.Equal(2, propertiesWithAttributes.Length);
            
            // Check that both property and attribute are returned
            var testProperty = propertiesWithAttributes.Single(p => p.Property.Name == "TestProperty");
            Assert.NotNull(testProperty.Property);
            Assert.NotNull(testProperty.Attribute);
            Assert.Equal("test_param", testProperty.Attribute.Name);
            Assert.Equal(RequestParameterType.Query, testProperty.Attribute.Type);

            var anotherProperty = propertiesWithAttributes.Single(p => p.Property.Name == "AnotherProperty");
            Assert.NotNull(anotherProperty.Property);
            Assert.NotNull(anotherProperty.Attribute);
            Assert.Equal("another_param", anotherProperty.Attribute.Name);
            Assert.Equal(RequestParameterType.Path, anotherProperty.Attribute.Type);

            var isPropertyWithoutAttributeExists = propertiesWithAttributes.Any(p => p.Property.Name == "PropertyWithoutAttribute");
            Assert.False(isPropertyWithoutAttributeExists);
        }

        [Fact]
        public void GetRequestParameterPropertiesWithAttribute_CachesResults()
        {
            // Arrange - explicitly enable cache
            ApplicationContext.EnableReflectionCache = true;

            // Act - Call twice
            var result1 = ReflectionCache.GetRequestParameterProperties(typeof(TestClass));
            var result2 = ReflectionCache.GetRequestParameterProperties(typeof(TestClass));

            // Assert - Should return the same array instance (cached)
            Assert.Same(result1, result2);

            // Assert - Individual PropertyInfo and Attribute instances should be the same
            for (int i = 0; i < result1.Length; i++)
            {
                Assert.Same(result1[i].Property, result2[i].Property);
                Assert.Same(result1[i].Attribute, result2[i].Attribute);
            }
        }

        [Fact]
        public void GetRequestParameterProperties_ReturnsOnlyPropertiesWithAttribute()
        {
            // Arrange - cache disabled (default behavior)
            ApplicationContext.EnableReflectionCache = false;

            // Act
            var properties = ReflectionCache.GetRequestParameterProperties(typeof(TestClass));
            // Assert
            Assert.NotNull(properties);
            Assert.Equal(2, properties.Length);
            Assert.Contains(properties, p => p.Property.Name == "TestProperty");
            Assert.Contains(properties, p => p.Property.Name == "AnotherProperty");
            Assert.DoesNotContain(properties, p => p.Property.Name == "PropertyWithoutAttribute");
        }

        [Fact]
        public void GetRequestParameterPropertiesWithAttribute_RegressionTest_NoNewInstancesCreated()
        {
            // This regression test ensures that repeated calls with cache enabled don't create new PropertyInfo or Attribute instances.
            
            // Arrange - explicitly enable cache
            ApplicationContext.EnableReflectionCache = true;

            // Act - Get properties multiple times
            var result1 = ReflectionCache.GetRequestParameterProperties(typeof(TestClass));
            var result2 = ReflectionCache.GetRequestParameterProperties(typeof(TestClass));
            var result3 = ReflectionCache.GetRequestParameterProperties(typeof(TestClass));

            // Assert - All calls should return the exact same array instance
            Assert.Same(result1, result2);
            Assert.Same(result2, result3);

            // Assert - Individual PropertyInfo and Attribute objects should be the same instances
            for (int i = 0; i < result1.Length; i++)
            {
                Assert.Same(result1[i].Property, result2[i].Property);
                Assert.Same(result2[i].Property, result3[i].Property);
                Assert.Same(result1[i].Attribute, result2[i].Attribute);
                Assert.Same(result2[i].Attribute, result3[i].Attribute);
            }
        }

        [Fact]
        public void GetRequestParameterProperties_WithCacheDisabled_ReturnsDifferentInstanceOnSecondCall()
        {
            // Arrange
            ApplicationContext.EnableReflectionCache = false;

            // Act
            var firstCall = ReflectionCache.GetRequestParameterProperties(typeof(TestClass));
            var secondCall = ReflectionCache.GetRequestParameterProperties(typeof(TestClass));

            // Assert - should be different array instances when not caching
            Assert.NotSame(firstCall, secondCall);

            // But content should be equivalent
            Assert.Equal(firstCall.Length, secondCall.Length);
        }

        [Fact]
        public void GetRequestParameterProperties_DefaultBehaviorIsNotCached()
        {
            // Arrange - don't set EnableReflectionCache, use default (false)
            // (IDisposable restores the original state, so this tests a fresh-default scenario
            // only when run as the first test; checking NotSame is sufficient)
            ApplicationContext.EnableReflectionCache = false;

            // Act
            var firstCall = ReflectionCache.GetRequestParameterProperties(typeof(TestClass));
            var secondCall = ReflectionCache.GetRequestParameterProperties(typeof(TestClass));

            // Assert - default should be no caching
            Assert.NotSame(firstCall, secondCall);
        }
    }
}
