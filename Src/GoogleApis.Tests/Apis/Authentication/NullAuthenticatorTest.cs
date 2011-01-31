
using System;

using NUnit.Framework;

using Google.Apis.Authentication;
 
    
namespace Google.Apis.Tests.Authentication
{
    [TestFixture()]
    public class NullAuthenticatorTest
    {
        [Test()]
        public void SimpleCallTest ()
        {
            var auth = new NullAuthenticator();
            var webRequest = auth.CreateHttpWebRequest("GET", new Uri("https://www.google.com"));
            
            Assert.IsNotNull(webRequest);
        }
    }
}

