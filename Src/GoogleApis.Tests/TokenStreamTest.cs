using Google.Apis.JSON;
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
      JSONToken actual;
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.ObjectStart, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.String, actual.type);
      Assert.AreEqual("Member", actual.value);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.NameSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.String, actual.type);
      Assert.AreEqual("Value", actual.value);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.ObjectEnd, actual.type);
     }

    /// <summary>
    ///A test for GetNextToken
    ///</summary>
    [Test()]
    public void GetNextTokenTestSimpleArray() {
      TokenStream target = new TokenStream("[ \"Value1\", \"Value2\" ]");
      JSONToken actual;
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.ArrayStart, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.String, actual.type);
      Assert.AreEqual("Value1", actual.value);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.MemberSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.String, actual.type);
      Assert.AreEqual("Value2", actual.value);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.ArrayEnd, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(null, actual);
    }

    /// <summary>
    ///A test for GetNextToken
    ///</summary>
    [Test()]
    public void GetNextTokenTestSpecialValues() {
      TokenStream target = new TokenStream("[ true, \"Value2\", false, null ]");
      JSONToken actual;
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.ArrayStart, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.True, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.MemberSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.String, actual.type);
      Assert.AreEqual("Value2", actual.value);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.MemberSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.False, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.MemberSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.Null, actual.type);
      actual = target.GetNextToken(); 
      Assert.AreEqual(JSONToken.Type.ArrayEnd, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(null, actual);
    }

    /// <summary>
    ///A test for GetNextToken
    ///</summary>
    [Test()]
    public void GetNextTokenTestNestedObjects() {
      TokenStream target = new TokenStream("{ \"name\" : [ true, \"Value2\", false ], \"sub\" : { \"subname\" : 1234 } }");
      JSONToken actual;
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.ObjectStart, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.String, actual.type);
      Assert.AreEqual("name", actual.value);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.NameSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.ArrayStart, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.True, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.MemberSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.String, actual.type);
      Assert.AreEqual("Value2", actual.value);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.MemberSeperator, actual.type);
      actual = target.GetNextToken();   
      Assert.AreEqual(JSONToken.Type.False, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.ArrayEnd, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.MemberSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.String, actual.type);
      Assert.AreEqual("sub", actual.value);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.NameSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.ObjectStart, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.String, actual.type);
      Assert.AreEqual("subname", actual.value);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.NameSeperator, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.Number, actual.type);
      Assert.AreEqual("1234", actual.value);
      Assert.AreEqual(1234, actual.number);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.ObjectEnd, actual.type);
      actual = target.GetNextToken();
      Assert.AreEqual(JSONToken.Type.ObjectEnd, actual.type);
      
      
      
      actual = target.GetNextToken();
      Assert.AreEqual(null, actual);
    }
  }
}
