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
using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.SchemaDecorator
{
    /// <summary>
    /// Tests for the StandardSchemaCommentDecorator class
    /// </summary>
    [TestFixture]
    public class StandardSchemaCommentDecoratorTest
    {
        /// <summary>
        /// Tests the creation of a simple comment
        /// </summary>
        [Test]
        public void TestCreateComment()
        {
            string aShortDescription = "A Short description for test";
            var decorator = new StandardSchemaCommentDecorator();
            var schema = new JsonSchema();
            schema.Description = aShortDescription;

            var result = decorator.CreateComment(schema);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.IsNotNull(result[0].Comment);
            Assert.AreEqual(true, result[0].Comment.DocComment);
            Assert.AreEqual("<summary>" + aShortDescription + "</summary>", result[0].Comment.Text);
        }

        /// <summary>
        /// Tests if the CreateComment checks for valid inputs
        /// </summary>
        [Test]
        public void TestCreateCommentArgumentChecking()
        {
            var decorator = new StandardSchemaCommentDecorator();

            // Confirm that the decorator validates parameters
            Assert.Throws(typeof(ArgumentNullException), () => decorator.CreateComment(null));
        }

        /// <summary>
        /// Checks if empty comments can be created
        /// </summary>
        [Test]
        public void TestCreateComment_emptyComment()
        {
            var decorator = new StandardSchemaCommentDecorator();

            var schema = new JsonSchema();
            schema.Description = null;
            var result = decorator.CreateComment(schema);
            // When called with a schmea that has no Description we should return an empty collection.
            Assert.IsNotNull(result);
            Assert.IsEmpty(result);

            schema.Description = "";
            result = decorator.CreateComment(schema);
            // When called with a schmea that has an empty Description we should return an empty collection.
            Assert.IsNotNull(result);
            Assert.IsEmpty(result);
        }

        /// <summary>
        /// Checks if xml escapes are done on non-compilant xml strings
        /// </summary>
        [Test]
        public void TestCreateComment_xmlEscape()
        {
            string aShortDescription = "A 'Short\" <description> <for/> test & fun";
            var decorator = new StandardSchemaCommentDecorator();
            var schema = new JsonSchema();
            schema.Description = aShortDescription;

            var result = decorator.CreateComment(schema);
            string desiredComment =
                "<summary>A &apos;Short&quot; &lt;description&gt; &lt;for/&gt; test &amp; fun</summary>";
            Assert.AreEqual(desiredComment, result[0].Comment.Text);
        }
    }
}