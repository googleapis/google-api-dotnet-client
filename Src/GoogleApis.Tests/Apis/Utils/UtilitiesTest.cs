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
using System.Linq;

using NUnit.Framework;

using Google.Apis.Util;

namespace Google.Apis.Tests.Apis.Util
{
    [TestFixture()]
    public class UtilitiesTest
    {
        [Test()]
        public void GetValueAsNullObjectTest ()
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
        
        [Test()]
        public void GetValueAsNullPrimitiveTest ()
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
        
        [Test]
        public void ThrowIfNullTest()
        {
            string str = null;
            Assert.Throws(typeof(ArgumentNullException), () => str.ThrowIfNull("str"));
            str = "123";
            str.ThrowIfNull("Not throwen");
        }
        
        public void IDictionaryAsReadOnlyNullTest()
        {
            IDictionary<string,int> dict = null;
            Assert.Throws(typeof(ArgumentNullException),() => dict.AsReadOnly());
        }
        
        [Test()]
        public void IDictionaryAsReadOnlyReadTest()
        {
            var dict = new Dictionary<int, string>();
            
            foreach(int i in Enumerable.Range(0,10))
            {
                dict.Add(i, "" + i);
            }
            var readOnly = dict.AsReadOnly();
            
            foreach(int i in Enumerable.Range(0,10))
            {
                Assert.AreEqual(i.ToString(), readOnly[i]);
            }
            
            foreach(int i in dict.Keys)
            {
                Assert.AreEqual(dict[i], readOnly[i]);
            }
        }
        
         [Test()]
        public void IDictionaryAsReadOnlyWriteTest()
        {
            var dict = new Dictionary<int, string>();
            
            foreach(int i in Enumerable.Range(0,10))
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
        
        [Test()]
        public void FindPropertyByNameTest()
        {
            Assert.Fail("No Test Written yet");
        }
    }
}

