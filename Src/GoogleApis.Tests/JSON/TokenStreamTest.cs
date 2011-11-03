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
using Google.Apis.Json;
using NUnit.Framework;

namespace Google.Apis.Tests.Json
{
    /// <summary>
    /// This is a test class for TokenStreamTest and is intended
    /// to contain all TokenStreamTest Unit Tests
    ///</summary>
    [TestFixture]
    public class TokenStreamTest
    {
        /// <summary>
        /// Tests if numbers with exponents are supported as values
        /// </summary>
        [Test]
        public void GetNextTokenExponent()
        {
            TokenStream target = new TokenStream("-1234.5678e1");
            JsonToken actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.Number, actual.Type);
            Assert.AreEqual(-12345.678, actual.Number);
            Assert.AreEqual("-1234.5678e1", actual.Value);
        }

        /// <summary>
        /// Tests if negative exponent numbers are supported as token values
        /// </summary>
        [Test]
        public void GetNextTokenExponentNegative()
        {
            TokenStream target = new TokenStream("-1234.5678e-1");
            JsonToken actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.Number, actual.Type);
            Assert.AreEqual(-123.45678, actual.Number);
            Assert.AreEqual("-1234.5678e-1", actual.Value);
        }

        /// <summary>
        /// Tests if positive exponent values are supported for tokens
        /// </summary>
        [Test]
        public void GetNextTokenExponentPositive()
        {
            TokenStream target = new TokenStream("-1234.5678e+1");
            JsonToken actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.Number, actual.Type);
            Assert.AreEqual(-12345.678, actual.Number);
            Assert.AreEqual("-1234.5678e+1", actual.Value);
        }

        /// <summary>
        /// Tests if negative numbers are supported as token values
        /// </summary>
        [Test]
        public void GetNextTokenNegativeNumber()
        {
            TokenStream target = new TokenStream("\"utc_offset\":-18000");
            JsonToken actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.String, actual.Type);
            Assert.AreEqual("utc_offset", actual.Value);

            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.NameSeperator, actual.Type);

            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.Number, actual.Type);
            Assert.AreEqual("-18000", actual.Value);
            Assert.AreEqual(-18000, actual.Number);
        }

        /// <summary>
        /// Tests if negative numbers without decimal are supported as values
        /// </summary>
        [Test]
        public void GetNextTokenNegativeNumberWithDecimals()
        {
            TokenStream target = new TokenStream("-1234.5678");
            JsonToken actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.Number, actual.Type);
            Assert.AreEqual(-1234.5678, actual.Number);
            Assert.AreEqual("-1234.5678", actual.Value);
        }

        /// <summary>
        /// Tests if strings with backslashes are supported as tokens
        /// </summary>
        [Test]
        public void GetNextTokenStringsWithBackSlash()
        {
            TokenStream target =
                new TokenStream(
                    "{ \"source\":\"\\u003Ca href=\\\"http:\\/\\/blackberry.com\\/twitter\\\" rel=\\\"nofollow\\\"\\u003ETwitter for BlackBerry\\u00ae\\u003C\\/a\\u003E\" }");
            JsonToken actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.ObjectStart, actual.Type);

            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.String, actual.Type);
            Assert.AreEqual("source", actual.Value);

            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.NameSeperator, actual.Type);

            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.String, actual.Type);
            Assert.AreEqual(
                "\u003Ca href=\"http://blackberry.com/twitter\" rel=\"nofollow\"\u003ETwitter for BlackBerry\u00ae\u003C/a\u003E",
                actual.Value);

            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.ObjectEnd, actual.Type);
        }

        /// <summary>
        /// Tests if single quote escaped strings work
        /// </summary>
        [Test]
        public void GetNextTokenTestEscapeSingleQuoteFull()
        {
            TokenStream target =
                new TokenStream(
                    "'{\\'id\\':\\'Activitiylist\\',\\'properties\\':{\\'id\\':{\\'type\\':\\'any\\'},\\'title\\':{\\'type\\':\\'any\\'},\\'items\\':{\\'items\\':{\\'$ref\\':\\'ChiliActivitiesResourceJson\\'},\\'type\\':\\'array\\'},\\'updated\\':{\\'type\\':\\'string\\'},\\'links\\':{\\'additionalProperties\\':{\\'items\\':{\\'properties\\':{\\'title\\':{\\'type\\':\\'any\\'},\\'height\\':{\\'type\\':\\'any\\'},\\'count\\':{\\'type\\':\\'any\\'},\\'updated\\':{\\'type\\':\\'string\\'},\\'width\\':{\\'type\\':\\'any\\'},\\'type\\':{\\'type\\':\\'any\\'},\\'href\\':{\\'type\\':\\'any\\'}},\\'type\\':\\'object\\'},\\'type\\':\\'array\\'},\\'type\\':\\'object\\'},\\'kind\\':{\\'default\\':\\'buzz#activityFeed\\',\\'type\\':\\'string\\'}},\\'type\\':\\'object\\'}'");
            var actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.String, actual.Type);
            Assert.AreEqual(
                "{\'id\':\'Activitiylist\',\'properties\':{\'id\':{\'type\':\'any\'},\'title\':{\'type\':\'any\'},\'items\':{\'items\':{\'$ref\':\'ChiliActivitiesResourceJson\'},\'type\':\'array\'},\'updated\':{\'type\':\'string\'},\'links\':{\'additionalProperties\':{\'items\':{\'properties\':{\'title\':{\'type\':\'any\'},\'height\':{\'type\':\'any\'},\'count\':{\'type\':\'any\'},\'updated\':{\'type\':\'string\'},\'width\':{\'type\':\'any\'},\'type\':{\'type\':\'any\'},\'href\':{\'type\':\'any\'}},\'type\':\'object\'},\'type\':\'array\'},\'type\':\'object\'},\'kind\':{\'default\':\'buzz#activityFeed\',\'type\':\'string\'}},\'type\':\'object\'}",
                actual.Value);
        }

        /// <summary>
        /// Tests for single escaped quote strings
        /// </summary>
        [Test]
        public void GetNextTokenTestEscapeSingleQuoteSimple()
        {
            TokenStream target = new TokenStream("'{\\'id\\':\\'Activitiylist\\'}'");
            var actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.String, actual.Type);
            Assert.AreEqual("{'id':'Activitiylist'}", actual.Value);
        }

        /// <summary>
        /// Tests if tabs are supported as tokens
        /// </summary>
        [Test]
        public void GetNextTokenTestEscapeTab()
        {
            TokenStream target = new TokenStream("'\\t'");
            var actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.String, actual.Type);
            Assert.AreEqual("\t", actual.Value);
        }

        /// <summary>
        /// Tests if unicode escape characters are supported as tokens
        /// </summary>
        [Test]
        public void GetNextTokenTestEscapeUniCode()
        {
            TokenStream target = new TokenStream("'\\uABCD'");
            var actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.String, actual.Type);
            Assert.AreEqual("\uABCD", actual.Value);

            target = new TokenStream("'\\u0000'");
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.String, actual.Type);
            Assert.AreEqual("\u0000", actual.Value);

            target = new TokenStream("'\\uFFFF'");
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.String, actual.Type);
            Assert.AreEqual("\uFFFF", actual.Value);
        }

        /// <summary>
        /// A test for GetNextToken
        ///</summary>
        [Test]
        public void GetNextTokenTestNestedObjects()
        {
            TokenStream target =
                new TokenStream("{ \"name\" : [ true, \"Value2\", false ], \"sub\" : { \"subname\" : 1234 } }");
            JsonToken actual;
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.ObjectStart, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.String, actual.Type);
            Assert.AreEqual("name", actual.Value);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.NameSeperator, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.ArrayStart, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.True, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.MemberSeperator, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.String, actual.Type);
            Assert.AreEqual("Value2", actual.Value);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.MemberSeperator, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.False, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.ArrayEnd, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.MemberSeperator, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.String, actual.Type);
            Assert.AreEqual("sub", actual.Value);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.NameSeperator, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.ObjectStart, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.String, actual.Type);
            Assert.AreEqual("subname", actual.Value);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.NameSeperator, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.Number, actual.Type);
            Assert.AreEqual("1234", actual.Value);
            Assert.AreEqual(1234, actual.Number);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.ObjectEnd, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.ObjectEnd, actual.Type);


            actual = target.GetNextToken();
            Assert.AreEqual(null, actual);
        }

        /// <summary>
        /// A test for GetNextToken
        ///</summary>
        [Test]
        public void GetNextTokenTestSimpleArray()
        {
            TokenStream target = new TokenStream("[ \"Value1\", \"Value2\" ]");
            JsonToken actual;
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.ArrayStart, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.String, actual.Type);
            Assert.AreEqual("Value1", actual.Value);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.MemberSeperator, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.String, actual.Type);
            Assert.AreEqual("Value2", actual.Value);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.ArrayEnd, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(null, actual);
        }

        /// <summary>
        /// A test for GetNextToken
        ///</summary>
        [Test]
        public void GetNextTokenTestSimpleObject()
        {
            TokenStream target = new TokenStream("{ \"Member\": \"Value\" }");
            JsonToken actual;
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.ObjectStart, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.String, actual.Type);
            Assert.AreEqual("Member", actual.Value);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.NameSeperator, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.String, actual.Type);
            Assert.AreEqual("Value", actual.Value);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.ObjectEnd, actual.Type);
        }

        /// <summary>
        /// A test for GetNextToken
        ///</summary>
        [Test]
        public void GetNextTokenTestSpecialValues()
        {
            TokenStream target = new TokenStream("[ true, \"Value2\", false, null ]");
            JsonToken actual;
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.ArrayStart, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.True, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.MemberSeperator, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.String, actual.Type);
            Assert.AreEqual("Value2", actual.Value);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.MemberSeperator, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.False, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.MemberSeperator, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.Null, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(JsonToken.TokenType.ArrayEnd, actual.Type);
            actual = target.GetNextToken();
            Assert.AreEqual(null, actual);
        }
    }
}