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
using System.IO;

namespace Google.Apis.Tests
{
    
    
    /// <summary>
    ///This is a test class for TokenStreamTest and is intended
    ///to contain all TokenStreamTest Unit Tests
    ///</summary>
  [TestFixture()]
  public class TokenStreamTest {


    /// <summary>
    ///A test for GetNextToken
    ///</summary>
    [Test()]
    public void GetNextTokenTestSimpleObject() {
      TokenStream target = new TokenStream("{ \"Member\": \"Value\" }"); 
      JsonToken actual;
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.ObjectStart, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.String, actual.type);
      Assert.AreEqual("Member", actual.value);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.NameSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.String, actual.type);
      Assert.AreEqual("Value", actual.value);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.ObjectEnd, actual.type);
     }

    /// <summary>
    ///A test for GetNextToken
    ///</summary>
    [Test()]
    public void GetNextTokenTestSimpleArray() {
      TokenStream target = new TokenStream("[ \"Value1\", \"Value2\" ]");
      JsonToken actual;
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.ArrayStart, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.String, actual.type);
      Assert.AreEqual("Value1", actual.value);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.MemberSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.String, actual.type);
      Assert.AreEqual("Value2", actual.value);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.ArrayEnd, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(null, actual);
    }

    /// <summary>
    ///A test for GetNextToken
    ///</summary>
    [Test()]
    public void GetNextTokenTestSpecialValues() {
      TokenStream target = new TokenStream("[ true, \"Value2\", false, null ]");
      JsonToken actual;
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.ArrayStart, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.True, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.MemberSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.String, actual.type);
      Assert.AreEqual("Value2", actual.value);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.MemberSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.False, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.MemberSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.Null, actual.type);
      actual = target.GetNextToken(); 
      Assert.AreEqual(JsonToken.Type.ArrayEnd, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(null, actual);
    }

    /// <summary>
    ///A test for GetNextToken
    ///</summary>
    [Test()]
    public void GetNextTokenTestNestedObjects() {
      TokenStream target = new TokenStream("{ \"name\" : [ true, \"Value2\", false ], \"sub\" : { \"subname\" : 1234 } }");
      JsonToken actual;
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.ObjectStart, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.String, actual.type);
      Assert.AreEqual("name", actual.value);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.NameSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.ArrayStart, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.True, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.MemberSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.String, actual.type);
      Assert.AreEqual("Value2", actual.value);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.MemberSeperator, actual.type);
      actual = target.GetNextToken();   
      Assert.AreEqual(JsonToken.Type.False, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.ArrayEnd, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.MemberSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.String, actual.type);
      Assert.AreEqual("sub", actual.value);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.NameSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.ObjectStart, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.String, actual.type);
      Assert.AreEqual("subname", actual.value);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.NameSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.Number, actual.type);
      Assert.AreEqual("1234", actual.value);
      Assert.AreEqual(1234, actual.number);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.ObjectEnd, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.ObjectEnd, actual.type);
      
      
      
      actual = target.GetNextToken();
      Assert.AreEqual(null, actual);
    }
  }
}
