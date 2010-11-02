using Google.Apis.JSON;

using NUnit.Framework;
using System.Collections.Generic;
using System.Collections;

namespace Google.Apis.Tests
{
    
    
    /// <summary>
    ///This is a test class for TokenStream_JSONReaderTest and is intended
    ///to contain all TokenStream_JSONReaderTest Unit Tests
    ///</summary>
  [TestFixture()]
  public class JSONReaderTest {




    /// <summary>
    ///A test for Parse
    ///</summary>
    [Test()]
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
