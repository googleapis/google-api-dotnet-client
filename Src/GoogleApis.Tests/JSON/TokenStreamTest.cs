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

namespace Google.Apis.Tests.Json
{
    
    
    /// <summary>
    ///This is a test class for TokenStreamTest and is intended
    ///to contain all TokenStreamTest Unit Tests
    ///</summary>
  [TestFixture()]
  public class TokenStreamTest {
        
    [Test()]
    public void GetNextTokenTestEscapeUniCode()
    {
      TokenStream target = new TokenStream("'\\uABCD'");
      var actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.String, actual.type);
      Assert.AreEqual("\uABCD", actual.value);
      
      target = new TokenStream("'\\u0000'");
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.String, actual.type);
      Assert.AreEqual("\u0000", actual.value);
            
      target = new TokenStream("'\\uFFFF'");
      actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.String, actual.type);
      Assert.AreEqual("\uFFFF", actual.value);
    }
  
    [Test()]
    public void GetNextTokenTestEscapeTab()
    {
      TokenStream target = new TokenStream("'\\t'");
      var actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.String, actual.type);
      Assert.AreEqual("\t", actual.value);
    }
    
    [Test()]
    public void GetNextTokenTestEscapeSingleQuoteSimple()
    {
      TokenStream target = new TokenStream("'{\\'id\\':\\'Activitiylist\\'}'");
      var actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.String, actual.type);
      Assert.AreEqual("{'id':'Activitiylist'}", actual.value);            
    }
        
    [Test()]
    public void GetNextTokenTestEscapeSingleQuoteFull()
    {
      TokenStream target = new TokenStream("'{\\'id\\':\\'Activitiylist\\',\\'properties\\':{\\'id\\':{\\'type\\':\\'any\\'},\\'title\\':{\\'type\\':\\'any\\'},\\'items\\':{\\'items\\':{\\'$ref\\':\\'ChiliActivitiesResourceJson\\'},\\'type\\':\\'array\\'},\\'updated\\':{\\'type\\':\\'string\\'},\\'links\\':{\\'additionalProperties\\':{\\'items\\':{\\'properties\\':{\\'title\\':{\\'type\\':\\'any\\'},\\'height\\':{\\'type\\':\\'any\\'},\\'count\\':{\\'type\\':\\'any\\'},\\'updated\\':{\\'type\\':\\'string\\'},\\'width\\':{\\'type\\':\\'any\\'},\\'type\\':{\\'type\\':\\'any\\'},\\'href\\':{\\'type\\':\\'any\\'}},\\'type\\':\\'object\\'},\\'type\\':\\'array\\'},\\'type\\':\\'object\\'},\\'kind\\':{\\'default\\':\\'buzz#activityFeed\\',\\'type\\':\\'string\\'}},\\'type\\':\\'object\\'}'");
      var actual = target.GetNextToken();
      Assert.AreEqual(JsonToken.Type.String, actual.type);
      Assert.AreEqual("{\'id\':\'Activitiylist\',\'properties\':{\'id\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'},\'items\':{\'items\':{\'$ref\':\'ChiliActivitiesResourceJson\'},\'type\':\'array\'},\'updated\':{\'type\':\'string\'},\'links\':{\'additionalProperties\':{\'items\':{\'properties\':{\'title\':{\'type\':\'any\'},\'height\':{\'type\':\'any\'},\'count\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'type\':\'object\'},\'kind\':{\'default\':\'buzz#activityFeed\',\'type\':\'string\'}},\'type\':\'object\'}", actual.value);
    }

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
