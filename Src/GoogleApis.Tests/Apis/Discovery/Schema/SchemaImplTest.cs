using System;

using NUnit.Framework;
using Newtonsoft.Json.Schema;

using Google.Apis.Json;

namespace Google.Apis.Tests.Apis.Discovery.Schema
{
    [TestFixture()]
    public class SchemaImplTest
    {
        private const string JsonSchemaElement = 
         "{'id':'Activitiylist'," +
         "'properties':{" +
            "'id':{'type':'any'}," +
            "'title':{'type':'any'}," +
            "'items':{'items':{'$ref':'ChiliActivitiesResourceJson'},'type':'array'}," +
            "'updated':{'type':'string'}," +
            "'links':{'additionalProperties':{'items':" +
                    "{'properties':" +
                    "{'title':{'type':'any'}," +
                    "'height':{'type':'any'}," +
                    "'count':{'type':'any'}," +
                    "'updated':{'type':'string'}," +
                    "'width':{'type':'any'}," +
                    "'type':{'type':'any'}," +
                    "'href':{'type':'any'}},'type':'object'}," +
                    "'type':'array'}," +
            "'type':'object'}," +
        "'kind':{'default':'buzz#activityFeed','type':'string'}}," +
        "'type':'object'}";

        [Test()]
        public void TestCase ()
        {
            Assert.Fail("No Test Yet");
            
        }
    }
}

