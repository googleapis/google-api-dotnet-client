using Google.Apis.JSON;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

namespace TestJSonReader
{
    
    
    /// <summary>
    ///This is a test class for TokenStream_JSONReaderTest and is intended
    ///to contain all TokenStream_JSONReaderTest Unit Tests
    ///</summary>
  [TestClass()]
  public class JSONReaderTest {


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
    ///A test for Parse
    ///</summary>
    [TestMethod()]
    public void ParseTest() {
      string jsonAsText = "[ true, \"Value2\", false, null ]";
      object o = JSONReader.Parse(jsonAsText);
      Assert.IsTrue(o is ArrayList);
      ArrayList a = o as ArrayList;
      Assert.AreEqual(4, a.Count);
      Assert.AreEqual(false, a[2]);

      jsonAsText = "{ \"Name\" : true }";
      o = JSONReader.Parse(jsonAsText);
      Assert.IsTrue(o is JSONDictionary);

      jsonAsText = "{ \"name\" : [ true, \"Value2\", false ], \"sub\" : { \"subname\" : 1234 } }";
      o = JSONReader.Parse(jsonAsText);
      Assert.IsTrue(o is JSONDictionary);
      JSONDictionary j = o as JSONDictionary;
      a = j["name"] as ArrayList;
      Assert.IsNotNull(a);
  

    }

   

   
  }
}
