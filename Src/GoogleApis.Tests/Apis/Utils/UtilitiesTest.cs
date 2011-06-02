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
using System.Collections;
using System.Collections.Generic;
using System.CodeDom;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Tests.Apis.Util
{
    /// <summary>
    /// Tests for the "Utilities"-class
    /// </summary>
    [TestFixture]
    public class UtilitiesTest
    {
        private CodeMemberProperty CreateMemberProperty(string name)
        {
            var member = new CodeMemberProperty();
            member.Name = name;
            return member;
        }

        /// <summary>
        /// Tests the FindPropertyByName method
        /// </summary>
        [Test]
        public void FindPropertyByNameTest()
        {
            CodeTypeMemberCollection collection = null;

            Assert.Throws(typeof(ArgumentNullException), () => collection.FindPropertyByName(null));
            Assert.Throws(typeof(ArgumentNullException), () => collection.FindPropertyByName("name"));

            collection = new CodeTypeMemberCollection(new[] { new CodeTypeMember(), });

            Assert.Throws(typeof(ArgumentNullException), () => collection.FindPropertyByName(null));
            Assert.Throws(typeof(ArgumentException), () => collection.FindPropertyByName(""));

            Assert.IsNull(collection.FindPropertyByName("AnyString"));

            collection.Add(CreateMemberProperty("Fish"));
            collection.Add(CreateMemberProperty("Cat"));
            collection.Add(CreateMemberProperty("Tree"));
            collection.Add(CreateMemberProperty("House"));

            CodeTypeMember willNotFind = new CodeMemberMethod();
            willNotFind.Name = "WillNotFindMethod";
            collection.Add(willNotFind);

            willNotFind = new CodeMemberField();
            willNotFind.Name = "WillNotFindField";
            collection.Add(willNotFind);

            willNotFind = new CodeMemberEvent();
            willNotFind.Name = "WillNotFindEvent";
            collection.Add(willNotFind);

            Assert.IsNull(collection.FindPropertyByName("AnyString"));
            Assert.IsNull(collection.FindPropertyByName("WillNotFindMethod"));
            Assert.IsNull(collection.FindPropertyByName("WillNotFindField"));
            Assert.IsNull(collection.FindPropertyByName("WillNotFindEvent"));
            Assert.IsNotNull(collection.FindPropertyByName("Fish"));
            Assert.IsNotNull(collection.FindPropertyByName("Cat"));
            Assert.IsNotNull(collection.FindPropertyByName("Tree"));
            Assert.IsNotNull(collection.FindPropertyByName("House"));

            Assert.AreEqual("Fish", collection.FindPropertyByName("Fish").Name);
            Assert.AreEqual("Cat", collection.FindPropertyByName("Cat").Name);
            Assert.AreEqual("Tree", collection.FindPropertyByName("Tree").Name);
            Assert.AreEqual("House", collection.FindPropertyByName("House").Name);
        }

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
        /// Tests the GetvalueAsNull method with primitive types
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
        /// Tests the GetValueAsStringListOrEmpty method
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

            var list = new ArrayList();
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
        /// Tests that the AsReadOnly method will fail when provided invalid arguments
        /// </summary>
        [Test]
        public void IDictionaryAsReadOnlyNullTest()
        {
            IDictionary<string, int> dict = null;
            Assert.Throws(typeof(ArgumentNullException), () => dict.AsReadOnly());
        }

        /// <summary>
        /// Tests whether the AsReadonly method returns a readonly copy of the dictionary
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
        /// Tests that a readonly dictionary is actually readonly
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
        /// Tests the "ThrowIfNull" method
        /// </summary>
        [Test]
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
            EntryWithoutStringValue
        }

        /// <summary>
        /// Tests the "GetStringValue" extension method of enums
        /// </summary>
        [Test]
        public void StringValueTest()
        {
            Assert.That(MockEnum.EntryWithStringValue.GetStringValue(), Is.EqualTo("Test"));
            Assert.Throws<ArgumentException>(() => MockEnum.EntryWithoutStringValue.GetStringValue());
            Assert.Throws<ArgumentNullException>(() => ((MockEnum)123456).GetStringValue());
        }
    }
}