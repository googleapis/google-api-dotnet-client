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
using System.ComponentModel;
using Google.Apis.Util;
using NUnit.Framework;

namespace Google.Apis.Tests.Apis.Utils
{
    /// <summary>
    /// Tests for the EnumStringValueTypeConverter class.
    /// </summary>
    [TestFixture]
    public class EnumStringValueTypeConverterTest
    {
        [TypeConverter(typeof(EnumStringValueTypeConverter))]
        private enum MockEnum
        {
            [StringValue("FooBar")]
            TestA,
            [StringValue("3.14159265358979323846")]
            TestB,

            TestC,
        }

        /// <summary>
        /// Confirms that the converter will work when accessed directly.
        /// </summary>
        [Test]
        public void DirectOperationTest()
        {
            var converter = new EnumStringValueTypeConverter();

            // Check source type
            Assert.IsTrue(converter.CanConvertFrom(typeof(Enum)));
            Assert.IsTrue(converter.CanConvertFrom(typeof(MockEnum)));
            Assert.IsTrue(converter.CanConvertFrom(typeof(MockEnum?)));
            Assert.IsFalse(converter.CanConvertFrom(typeof(Boolean)));
            Assert.IsFalse(converter.CanConvertFrom(typeof(EnumStringValueTypeConverter)));

            // Check destination type
            Assert.IsTrue(converter.CanConvertTo(typeof(string)));
            Assert.IsFalse(converter.CanConvertTo(typeof(Boolean)));
            Assert.IsFalse(converter.CanConvertTo(typeof(EnumStringValueTypeConverter)));

            // Check conversion
            Assert.AreEqual("FooBar", converter.ConvertTo(MockEnum.TestA, typeof(string)));
            Assert.AreEqual("3.14159265358979323846", converter.ConvertTo(MockEnum.TestB, typeof(string)));
            Assert.AreEqual("TestC", converter.ConvertTo(MockEnum.TestC, typeof(string)));
            MockEnum? nullable = MockEnum.TestB;
            Assert.AreEqual("3.14159265358979323846", converter.ConvertTo(nullable, typeof(string)));
        }

        /// <summary>
        /// Confirms that the converter is returned when using the MockEnum.
        /// </summary>
        [Test]
        public void GetConverterTest()
        {
            Assert.IsInstanceOf<EnumStringValueTypeConverter>(TypeDescriptor.GetConverter(MockEnum.TestA));
            Assert.IsInstanceOf<EnumStringValueTypeConverter>(TypeDescriptor.GetConverter(MockEnum.TestB));
            Assert.IsInstanceOf<EnumStringValueTypeConverter>(TypeDescriptor.GetConverter(MockEnum.TestC));

            MockEnum? nullable = MockEnum.TestA;
            Assert.IsInstanceOf<EnumStringValueTypeConverter>(TypeDescriptor.GetConverter(nullable));

            Assert.IsNotInstanceOf<EnumStringValueTypeConverter>(TypeDescriptor.GetConverter(ConsoleColor.Blue));
            Assert.IsNotInstanceOf<EnumStringValueTypeConverter>(TypeDescriptor.GetConverter(42));
            Assert.IsNotInstanceOf<EnumStringValueTypeConverter>(TypeDescriptor.GetConverter("test"));
        }
    }
}
