
using System;
using System.Collections.Generic;
using NUnit.Framework;
using Google.Apis.Discovery;
using Google.Apis.Json;

namespace Google.Apis.Tests.Apis.Discovery
{


    [TestFixture()]
    public class BaseMethodTest
    {
        private const string SimpleCountMethod =  @"{
                 'restPath': 'activities/count',
                 'rpcMethod': 'chili.activities.count',
                 'httpMethod': 'GET',
                 'description': 'Get a count of link shares',
                 'parameters': {
                  'hl': {
                   'restParameterType': 'query',
                   'description': 'Language code to limit language results.',
                   'type': 'string'
                  },
                  'url': {
                   'restParameterType': 'query',
                   'repeated': true,
                   'description': 'URLs for which to get share counts.',
                   'type': 'string'
                  }
                 },
                 'response': {
                  '$ref': 'ResponseTypeTestString'
                 }
                 'request': {
                  '$ref': 'RequestTypeTestString'
                 }";

        [Test()]
        public void TestSimpleProperties ()
        {
            var method = new BaseMethodTestImpl("count",SimpleCountMethod);
            Assert.AreEqual("ResponseTypeTestString", method.ResponseType);
            Assert.AreEqual("RequestTypeTestString", method.RequestType);
            Assert.AreEqual("count", method.Name);
            Assert.AreEqual("GET", method.HttpMethod);
            Assert.AreEqual(2, method.Parameters.Count);
        }
        
        
        private class BaseMethodTestImpl : BaseMethod
        {
            public BaseMethodTestImpl(string name, string json) : 
                    base(new KeyValuePair<string, object>(name, JsonReader.Parse(json)))
            {
            }
            
            public override string RestPath {
                get {
                    throw new System.NotImplementedException ();
                }
            }

        }
    }
}
