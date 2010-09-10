using Google.Apis.JSON;
using Google.Apis.Tests;
using NUnit.Framework;

namespace Google.Apis.Tests
{
    
    
    /// <summary>
    ///This is a test class for JSONTokenTest and is intended
    ///to contain all JSONTokenTest Unit Tests
    ///</summary>
  [TestFixture()]
  public class JSONTokenTest {


    /// <summary>
    ///A test for JSONToken Constructor
    ///</summary>
    [Test()]
    public void JSONTokenConstructorTest() {
      JSONToken target = new JSONToken();
      Assert.IsNotNull(target);
    }
  }
}
