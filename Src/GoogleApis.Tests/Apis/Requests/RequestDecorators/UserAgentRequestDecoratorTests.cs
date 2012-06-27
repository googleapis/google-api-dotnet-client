using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

using Google.Apis.Requests.RequestDecorators;

using NUnit.Framework;

namespace Google.Apis.Tests.Apis.Requests.RequestDecorators
{
    [TestFixture]
    public class UserAgentRequestDecoratorTests
    {
        /// <summary>
        /// Tests the UserAgent property
        /// </summary>
        [Test]
        public void FormatForUserAgentTest()
        {
            var decorator = new UserAgentRequestDecorator("Unknown Application", false);
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://www.example.com/");

            decorator.DecorateRequest(request);

            Assert.That(request.UserAgent, Contains.Substring("Unknown_Application"));
            Assert.That(request.UserAgent, Contains.Substring("google-api-dotnet-client"));
            Assert.That(request.UserAgent, Is.Not.ContainsSubstring("gzip"));
        }

        /// <summary>
        /// Tests the UserAgent property
        /// </summary>
        [Test]
        public void FormatForUserAgentTestWithGzip()
        {
            var decorator = new UserAgentRequestDecorator("Unknown Application", true);
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://www.example.com/");

            decorator.DecorateRequest(request);

            Assert.That(request.UserAgent, Contains.Substring("Unknown_Application"));
            Assert.That(request.UserAgent, Contains.Substring("google-api-dotnet-client"));
            Assert.That(request.UserAgent, Contains.Substring("gzip"));
        }
    }
}
