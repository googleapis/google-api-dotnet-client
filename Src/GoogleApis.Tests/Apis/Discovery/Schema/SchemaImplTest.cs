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
using System;
using NUnit.Framework;
using Newtonsoft.Json.Schema;
using Google.Apis.Discovery.Schema;

namespace Google.Apis.Tests.Apis.Discovery.Schema
{
    /// <summary>
    /// Tests for the "SchemaImpl" class
    /// </summary>
    [TestFixture]
    public class SchemaImplTest
    {
        private const string JsonSchemaElement =
            "{'id':'Activitiylist'," + "'properties':{" + "'id':{'type':'any'}," + "'title':{'type':'any'}," +
            "'items':{'items':{'$ref':'ChiliActivitiesResourceJson'},'type':'array'}," + "'updated':{'type':'string'}," +
            "'links':{'additionalProperties':" + "{'items':" + "{'properties':" + "{'title':{'type':'any'}," +
            "'height':{'type':'any'}," + "'count':{'type':'any'}," + "'updated':{'type':'string'}," +
            "'width':{'type':'any'}," + "'type':{'type':'any'}," + "'href':{'type':'any'}}," + "'type':'object'}," +
            "'type':'array'}," + "'type':'object'}," + "'kind':{'default':'buzz#activityFeed','type':'string'}" + "}," +
            "'type':'object'}";

        /// <summary>
        /// Tests that the class throws exception when constructed with invalid arguments
        /// </summary>
        [Test]
        public void ArgumentValidationTest()
        {
            FutureJsonSchemaResolver resolver = new FutureJsonSchemaResolver();

            Assert.Throws(typeof(ArgumentNullException), () => new SchemaImpl(null, JsonSchemaElement, resolver));
            Assert.Throws(typeof(ArgumentNullException), () => new SchemaImpl("Activitiylist", null, resolver));
            Assert.Throws(typeof(ArgumentNullException), () => new SchemaImpl("Activitiylist", JsonSchemaElement, null));
        }

        /// <summary>
        /// Tests that the class can be created, and that the appropriate values are saved
        /// </summary>
        [Test]
        public void SimpleCreateTest()
        {
            FutureJsonSchemaResolver resolver = new FutureJsonSchemaResolver();
            SchemaImpl impl = new SchemaImpl("Activitiylist", JsonSchemaElement, resolver);
            Assert.AreEqual("Activitiylist", impl.Id);
            Assert.AreEqual("Activitiylist", impl.Name);
            Assert.IsNotNull(impl.SchemaDetails);
            Assert.AreEqual(JsonSchemaType.Object, impl.SchemaDetails.Type);
            Assert.AreEqual(6, impl.SchemaDetails.Properties.Count);
            Assert.IsNotNull(impl.SchemaDetails.Properties["id"]);
            Assert.IsNotNull(impl.SchemaDetails.Properties["title"]);
            Assert.IsNotNull(impl.SchemaDetails.Properties["items"]);
            Assert.IsNotNull(impl.SchemaDetails.Properties["updated"]);
            Assert.IsNotNull(impl.SchemaDetails.Properties["links"]);
            Assert.IsNotNull(impl.SchemaDetails.Properties["kind"]);
        }
    }
}