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

using System;
using System.Collections.Generic;
using System.CodeDom;
using System.ComponentModel;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Tests.Apis.Util
{
    /// <summary>
    /// Tests for the "Utilities"-class.
    /// </summary>
    [TestFixture]
    public class UtilitiesTest
    {
        /// <summary>
        /// Tests that the GetValueAsNull method works
        /// </summary>
        [Test]
        public void GetValueAsNullObjectTest()
        {
            var dict = new Dictionary<int, string>();
            dict[0] = "0";
            dict[1] = "1";
            dict[2] = "2";
            Assert.AreEqual("0", dict.GetValueAsNull(0));
            Assert.AreEqual("1", dict.GetValueAsNull(1));
            Assert.AreEqual("2", dict.GetValueAsNull(2));

            Assert.IsNull(dict.GetValueAsNull(-1));
            Assert.IsNull(dict.GetValueAsNull(3));
        }

        /// <summary>
        /// Tests the GetvalueAsNull method with primitive types.
        /// </summary>
        [Test]
        public void GetValueAsNullPrimitiveTest()
        {
            var dict = new Dictionary<int, int>();
            dict[0] = 0;
            dict[1] = 1;
            dict[2] = 2;
            Assert.AreEqual(0, dict.GetValueAsNull(0));
            Assert.AreEqual(1, dict.GetValueAsNull(1));
            Assert.AreEqual(2, dict.GetValueAsNull(2));

            Assert.AreEqual(0, dict.GetValueAsNull(-1));
            Assert.AreEqual(0, dict.GetValueAsNull(3));
        }

        /// <summary>
        /// Tests the GetValueAsStringListOrEmpty method.
        /// </summary>
        [Test]
        public void GetValueAsStringListOrEmpty()
        {
            IDictionary<string, object> dict = null;

            dict = new Dictionary<string, object>();
            var result = dict.GetValueAsStringListOrEmpty("Fish");
            Assert.IsNotNull(result);
            MoreAsserts.IsEmpty(result);

            dict.Add("Number", 1);
            dict.Add("String", "abc");
            dict.Add("Anon", new { A = "A", B = "B" });

            var list = new List<object>();
            list.Add("string");
            list.Add(123);
            list.Add(null);
            list.Add(new StringBuilder("StringBuilder"));
            dict.Add("List", list);

            result = dict.GetValueAsStringListOrEmpty("Number");
            Assert.IsNotNull(result);
            MoreAsserts.IsEmpty(result);

            result = dict.GetValueAsStringListOrEmpty("String");
            Assert.IsNotNull(result);

            result = dict.GetValueAsStringListOrEmpty("Number");
            Assert.IsNotNull(result);
            MoreAsserts.IsEmpty(result);

            result = dict.GetValueAsStringListOrEmpty("Anon");
            Assert.IsNotNull(result);
            MoreAsserts.IsEmpty(result);

            List<string> resultAsList = dict.GetValueAsStringListOrEmpty("List").ToList();
            Assert.IsNotNull(resultAsList);
            MoreAsserts.ContentsEqualAndInOrder(
                new List<string> { "string", "123", null, "StringBuilder" }, resultAsList);
        }

        /// <summary>
        /// Tests that the AsReadOnly method will fail when provided invalid arguments.
        /// </summary>
        [Test]
        public void IDictionaryAsReadOnlyNullTest()
        {
            IDictionary<string, int> dict = null;
            Assert.Throws(typeof(ArgumentNullException), () => dict.AsReadOnly());
        }

        /// <summary>
        /// Tests whether the AsReadonly method returns a readonly copy of the dictionary.
        /// </summary>
        [Test]
        public void IDictionaryAsReadOnlyReadTest()
        {
            var dict = new Dictionary<int, string>();

            foreach (int i in Enumerable.Range(0, 10))
            {
                dict.Add(i, "" + i);
            }
            var readOnly = dict.AsReadOnly();

            foreach (int i in Enumerable.Range(0, 10))
            {
                Assert.AreEqual(i.ToString(), readOnly[i]);
            }

            foreach (int i in dict.Keys)
            {
                Assert.AreEqual(dict[i], readOnly[i]);
            }
        }

        /// <summary>
        /// Tests that a readonly dictionary is actually readonly.
        /// </summary>
        [Test]
        public void IDictionaryAsReadOnlyWriteTest()
        {
            var dict = new Dictionary<int, string>();

            foreach (int i in Enumerable.Range(0, 10))
            {
                dict.Add(i, "" + i);
            }
            var readOnly = dict.AsReadOnly();

            Assert.Throws(typeof(NotSupportedException), () => readOnly[0] = "fish");
            Assert.Throws(typeof(NotSupportedException), () => readOnly[0] = "0");
            Assert.Throws(typeof(NotSupportedException), () => readOnly[1] = "1");
            Assert.Throws(typeof(NotSupportedException), () => readOnly[500] = "NintySeven");
            Assert.Throws(typeof(NotSupportedException), () => readOnly.Clear());
            Assert.Throws(typeof(NotSupportedException), () => readOnly.Keys.Clear());
            Assert.Throws(typeof(NotSupportedException), () => readOnly.Values.Clear());
            Assert.Throws(typeof(NotSupportedException), () => readOnly.Add(15, "House"));
            Assert.Throws(typeof(NotSupportedException), () => readOnly.Remove(5));
        }

        /// <summary>
        /// Tests the "ThrowIfNull" method.
        /// </summary>
        [Test]
        public void ThrowIfNullTest()
        {
            string str = null;
            Assert.Throws(typeof(ArgumentNullException), () => str.ThrowIfNull("str"));
            str = "123";
            str.ThrowIfNull("Not throwen");
        }

        /// <summary>
        /// Tests the "FormatString" method.
        /// </summary>
        [Test]
        public void FormatStringTest()
        {
            // Test that a null string won't throw an exception.
            Assert.IsNull(((string)null).FormatString());
            Assert.IsNull(((string)null).FormatString("123"));

            // Test that a normal (non-argument) call to the Format method will not format the string.
            Assert.AreEqual("{0}", "{0}".FormatString());

            // Test that the string is formatted when arguments are passed.
            Assert.AreEqual("123", "{0}".FormatString("123"));
        }

        /// <summary>
        /// Tests the "Replace" string extension method.
        /// </summary>
        [Test]
        public void ReplaceTest()
        {
            Assert.That("test".Replace("_", '"', '!', '$'), Is.EqualTo("test"));
            Assert.That("/te/st/".Replace("", '/', '!', '$'), Is.EqualTo("test"));
            Assert.That("/te/st/".Replace("_", '/', '!', '$'), Is.EqualTo("_te_st_"));
            Assert.That("/te/st/".Replace("//", '/', '!', '$'), Is.EqualTo("//te//st//"));
            Assert.That("123!@#".Replace("", '!', '@', '#'), Is.EqualTo("123"));
            Assert.Throws<ArgumentException>(() => "test".Replace("_"));
        }

        [TypeConverter(typeof(EnumStringValueTypeConverter))]
        private enum MockEnum
        {
            [StringValue("Test")]
            EntryWithStringValue,
            [StringValue("AnotherTest")]
            EntryWithSecondStringValue,
            EntryWithoutStringValue
        }

        /// <summary>
        /// Tests the "GetStringValue" extension method of enums.
        /// </summary>
        [Test]
        public void StringValueTest()
        {
            Assert.That(MockEnum.EntryWithStringValue.GetStringValue(), Is.EqualTo("Test"));
            Assert.That(MockEnum.EntryWithSecondStringValue.GetStringValue(), Is.EqualTo("AnotherTest"));
            Assert.Throws<ArgumentException>(() => MockEnum.EntryWithoutStringValue.GetStringValue());
            Assert.Throws<ArgumentNullException>(() => ((MockEnum)123456).GetStringValue());
        }

        /// <summary>
        /// Tests the "GetNonNullableType" method.
        /// </summary>
        [Test]
        public void GetNonNullableTypeTest()
        {
            Assert.AreEqual(typeof(string), Google.Apis.Util.Utilities.GetNonNullableType(typeof(string)));
            Assert.AreEqual(typeof(int), Google.Apis.Util.Utilities.GetNonNullableType(typeof(int)));

            Assert.AreEqual(typeof(int), Google.Apis.Util.Utilities.GetNonNullableType(typeof(int?)));
            Assert.AreEqual(typeof(MockEnum), Google.Apis.Util.Utilities.GetNonNullableType(typeof(MockEnum?)));
        }

        /// <summary>
        /// Tests the "ConvertToString" method.
        /// </summary>
        [Test]
        public void ConvertToStringTest()
        {
            Assert.AreEqual("FooBar", Google.Apis.Util.Utilities.ConvertToString("FooBar"));
            Assert.AreEqual("123", Google.Apis.Util.Utilities.ConvertToString(123));
            Assert.AreEqual("Test", Google.Apis.Util.Utilities.ConvertToString(MockEnum.EntryWithStringValue));
            Assert.AreEqual(null, Google.Apis.Util.Utilities.ConvertToString(null));

            // Test nullable types.
            int? nullable = 123;
            Assert.AreEqual("123", Google.Apis.Util.Utilities.ConvertToString(nullable));
            nullable = null;
            Assert.AreEqual(null, Google.Apis.Util.Utilities.ConvertToString(nullable));
            MockEnum? nullEnum = null;
            Assert.AreEqual(null, Google.Apis.Util.Utilities.ConvertToString(nullEnum));
        }

        /// <summary>
        /// Tests the ICollection implementation of IsNullOrEmpty
        /// </summary>
        [Test]
        public void IsNullOrEmptyCollectionTest()
        {
            ICollection<int> col = null;
            Assert.IsTrue(col.IsNullOrEmpty());

            col = new List<int>();
            Assert.IsTrue(col.IsNullOrEmpty());

            col = new List<int>() { 42 };
            Assert.IsFalse(col.IsNullOrEmpty());
        }

        /// <summary>
        /// Test the Concat extension method.
        /// </summary>
        [Test]
        public void ConcatTest()
        {
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3 }.Concat(4));
            CollectionAssert.AreEqual(new[] { 1, 4 }, new[] { 1 }.Concat(4));
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4 }, new[] { 1 }.Concat(2).Concat(3).Concat(4));
            CollectionAssert.AreEqual(new[] { 1 }, new int[0].Concat(1));
        }

#if SILVERLIGHT
        /// <summary>
        /// Tests the String.Split extension method.
        /// </summary>
        [Test]
        public void SplitTest()
        {
            char[] seperators = new[] { '.' };
            const string testString = "one.two..three";
            Func<char[], int, string[]> split = (seps, segs) => Utilities.Split(testString, seps, segs);

            Assert.Throws<NotImplementedException>(() => split(new[] { 'a', 'b' }, 2));
            Assert.Throws<ArgumentException>(() => split(seperators, 0));
            CollectionAssert.AreEqual(new[] { testString }, split(new char[0], 3));
            CollectionAssert.AreEqual(new[] {"one", "two", "", "three"}, split(seperators, 4));
            CollectionAssert.AreEqual(new[] { "one", "two", ".three" }, split(seperators, 3));
            CollectionAssert.AreEqual(new[] { "one", "two..three" }, split(seperators, 2));
            CollectionAssert.AreEqual(new[] { testString }, split(seperators, 1));
        }
#endif        
    }
}