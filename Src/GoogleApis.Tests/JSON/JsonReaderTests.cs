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
using Google.Apis.Json;

using NUnit.Framework;
using System.Collections.Generic;
using System.Collections;

namespace Google.Apis.Tests.Json
{
    
    
    /// <summary>
    ///This is a test class for TokenStream_JSONReaderTest and is intended
    ///to contain all TokenStream_JSONReaderTest Unit Tests
    ///</summary>
  [TestFixture()]
  public class JsonReaderTest {




    /// <summary>
    ///A test for Parse
    ///</summary>
    [Test()]
    public void ParseTest() {
      string jsonAsText = "[ true, \"Value2\", false, null ]";
      object o = JsonReader.Parse(jsonAsText);
      Assert.IsTrue(o is ArrayList);
      ArrayList a = o as ArrayList;
      Assert.AreEqual(4, a.Count);
      Assert.AreEqual(false, a[2]);

      jsonAsText = "{ \"Name\" : true }";
      o = JsonReader.Parse(jsonAsText);
      Assert.IsTrue(o is JsonDictionary);

      jsonAsText = "{ \"name\" : [ true, \"Value2\", false ], \"sub\" : { \"subname\" : 1234 } }";
      o = JsonReader.Parse(jsonAsText);
      Assert.IsTrue(o is JsonDictionary);
      JsonDictionary j = o as JsonDictionary;
      a = j["name"] as ArrayList;
      Assert.IsNotNull(a);
  

    }

   

   
  }
}
