/*
Copyright 2011 Google Inc

Licensed under the Apache License, Version 2.0 (the ""License"");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an ""AS IS"" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Collections.Generic;
using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;
using Google.Apis.Tools.CodeGen.Tests.Generator;
using Newtonsoft.Json.Schema;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.SchemaDecorator
{
    /// <summary>
    /// Tests for the Standard Title Modificator
    /// </summary>
    [TestFixture]
    public class StandardTitleModificatorTest
    {
        /// <summary>
        /// Tests the constructor
        /// </summary>
        [Test]
        public void ConstructTest()
        {
            Assert.DoesNotThrow(() => new StandardTitleModificatorTest());
        }

        /// <summary>
        /// Tests the constructor
        /// </summary>
        [Test]
        public void DecorateEdgeCasesTest()
        {
            // Only the 'schema' parameter is relevant for this class
            var modificator = new StandardTitleModificator();
            Assert.Throws<ArgumentNullException>(() => modificator.DecorateClass(null, null, null, null));
            Assert.DoesNotThrow(() => modificator.DecorateClass(null, new MockSchema(), null, null));
        }

        /// <summary>
        /// Tests the property modification when a title is set
        /// </summary>
        [Test]
        public void DecoratePropertyWithTitleTest()
        {
            var modificator = new StandardTitleModificator();
            var schema = new JsonSchema();

            // Add a test property
            var property = new JsonSchema() { Title = "bar" };
            schema.Properties.Add("foo", property);
            modificator.DecorateInternalClass(null, null, schema, null, null);
            Assert.That(schema.Title, Is.EqualTo("bar"));
        }

        /// <summary>
        /// Tests the property modification when no title is set
        /// </summary>
        [Test]
        public void DecoratePropertyWithoutTitleTest()
        {
            var modificator = new StandardTitleModificator();
            var schema = new JsonSchema();

            // Add a test property
            var property = new JsonSchema();
            schema.Properties.Add("foo", property);
            modificator.DecorateInternalClass(null, null, schema, null, null);
            Assert.That(schema.Title, Is.EqualTo("foo"));
        }

        /// <summary>
        /// Tests the item modification with a title set
        /// </summary>
        [Test]
        public void DecorateItemWithTitleTest()
        {
            var modificator = new StandardTitleModificator();
            var schema = new JsonSchema();

            // Add a test property
            var item = new JsonSchema() { Title = "bar"};
            schema.Items = new List<JsonSchema>();
            schema.Items.Add(item);
            modificator.DecorateInternalClass(null, null, schema, null, null);
            Assert.That(schema.Title, Is.EqualTo("bar"));
        }

        /// <summary>
        /// Tests the item modification without a title set
        /// </summary>
        [Test]
        public void DecorateItemWithoutTitleTest()
        {
            var modificator = new StandardTitleModificator();
            var schema = new JsonSchema();
            schema.Title = "bar";

            // Add a test property
            var item = new JsonSchema();
            schema.Items = new List<JsonSchema>();
            schema.Items.Add(item);
            modificator.DecorateInternalClass(null, null, schema, null, null);
            Assert.That(schema.Title, Is.EqualTo("bar"));
        }

        /// <summary>
        /// Tests that the decorator can handle cyclic references, and will terminate
        /// </summary>
        [Test]
        public void DecorateCyclicReferenceTest()
        {
            var modificator = new StandardTitleModificator();
            var schema = new JsonSchema();
    
            // Add a test property
            schema.Items = new List<JsonSchema>();
            schema.Properties = new Dictionary<string, JsonSchema>();
            schema.Items.Add(schema);
            schema.Properties.Add("foo", schema);
            modificator.DecorateInternalClass(null, null, schema, null, null);

            Assert.Pass();
        }
    }
}
