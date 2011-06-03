using Google.Apis.JSON;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace TestJSonReader
{
    
    
    /// <summary>
    ///This is a test class for TokenStreamTest and is intended
    ///to contain all TokenStreamTest Unit Tests
    ///</summary>
  [TestClass()]
  public class TokenStreamTest {


    private TestContext testContextInstance;

    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext {
      get {
        return testContextInstance;
      }
      set {
        testContextInstance = value;
      }
    }

    #region Additional test attributes
    // 
    //You can use the following additional attributes as you write your tests:
    //
    //Use ClassInitialize to run code before running the first test in the class
    //[ClassInitialize()]
    //public static void MyClassInitialize(TestContext testContext)
    //{
    //}
    //
    //Use ClassCleanup to run code after all tests in a class have run
    //[ClassCleanup()]
    //public static void MyClassCleanup()
    //{
    //}
    //
    //Use TestInitialize to run code before running each test
    //[TestInitialize()]
    //public void MyTestInitialize()
    //{
    //}
    //
    //Use TestCleanup to run code after each test has run
    //[TestCleanup()]
    //public void MyTestCleanup()
    //{
    //}
    //
    #endregion


    /// <summary>
    ///A test for GetNextToken
    ///</summary>
    [TestMethod()]
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
    [TestMethod()]
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
    [TestMethod()]
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
    [TestMethod()]
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
