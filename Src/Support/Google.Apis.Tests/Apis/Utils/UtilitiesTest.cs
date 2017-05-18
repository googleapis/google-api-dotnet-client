/*
Copyright 2010 Google Inc

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
using Xunit;

namespace Google.Apis.Tests.Apis.Util
{
    /// <summary>Tests for <seealso cref="Google.Apis.Util.Utilities"/> class.</summary>
    public class UtilitiesTest
    {
        /// <summary>Tests the "ThrowIfNull" method.</summary>
        [Fact]
        public void ThrowIfNullTest()
        {
            string str = null;
            Assert.Throws(typeof(ArgumentNullException), () => str.ThrowIfNull("str"));
            str = "123";
            str.ThrowIfNull("Not throwen");
        }

        private enum MockEnum
        {
            [StringValue("Test")]
            EntryWithStringValue,
            [StringValue("3.14159265358979323846")]
            EntryWithSecondStringValue,
            EntryWithoutStringValue
        }

        /// <summary>Tests the "GetStringValue" extension method of Enums.</summary>
        [Fact]
        public void StringValueTest()
        {
            Assert.Equal("Test", Utilities.GetEnumStringValue(MockEnum.EntryWithStringValue));
            Assert.Equal("3.14159265358979323846", Utilities.GetEnumStringValue(MockEnum.EntryWithSecondStringValue));
            Assert.Throws<ArgumentException>(() => Utilities.GetEnumStringValue(MockEnum.EntryWithoutStringValue));
            Assert.Throws<ArgumentNullException>(() => Utilities.GetEnumStringValue((MockEnum)123456));
        }

        /// <summary>Tests the "ConvertToString" method.</summary>
        [Fact]
        public void ConvertToStringTest()
        {
            Assert.Equal("FooBar", Google.Apis.Util.Utilities.ConvertToString("FooBar"));
            Assert.Equal("123", Google.Apis.Util.Utilities.ConvertToString(123));
            Assert.Equal("false", Google.Apis.Util.Utilities.ConvertToString(false));
            Assert.Equal("true", Google.Apis.Util.Utilities.ConvertToString(true));

            // Check Enums work with and without StringValueAttribute.
            Assert.Equal("Test", Google.Apis.Util.Utilities.ConvertToString(MockEnum.EntryWithStringValue));
            Assert.Equal("3.14159265358979323846",
                Google.Apis.Util.Utilities.ConvertToString(MockEnum.EntryWithSecondStringValue));
            Assert.Equal("EntryWithoutStringValue",
                Google.Apis.Util.Utilities.ConvertToString(MockEnum.EntryWithoutStringValue));
            Assert.Null(Google.Apis.Util.Utilities.ConvertToString(null));

            // Test nullable types.
            int? nullable = 123;
            Assert.Equal("123", Google.Apis.Util.Utilities.ConvertToString(nullable));
            nullable = null;
            Assert.Null(Google.Apis.Util.Utilities.ConvertToString(nullable));
            MockEnum? nullEnum = null;
            Assert.Null(Google.Apis.Util.Utilities.ConvertToString(nullEnum));
        }
    }
}