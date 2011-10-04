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
using System.Collections.Generic;
using System.IO;
using System.Collections;
using Google.Apis.Logging;

namespace Google.Apis.Json
{
    /// <summary>
    /// basic JsonReader that can parse either strings or streams into some
    /// dictionary form.
    /// </summary>
    public static class JsonReader
    {
        private static readonly ILogger logger = ApplicationContext.Logger.ForType(typeof(JsonReader));


        /// <summary>
        /// Parses the json document into the appropriate expression/dictionary
        /// </summary>
        public static object Parse(string jsonAsText)
        {
            TokenStream ts = new TokenStream(jsonAsText);
            return ParseExpression(null, ts);
        }

        /// <summary>
        /// Parses the json document into the appropriate expression/dictionary
        /// </summary>
        public static object Parse(Stream jsonAsStream)
        {
            TokenStream ts = new TokenStream(jsonAsStream);
            return ParseExpression(null, ts);
        }

        private static object ParseExpression(JsonToken token, TokenStream ts)
        {
            if (token == null)
            {
                token = ts.GetNextToken();
            }

            switch (token.Type)
            {
                case JsonToken.TokenType.String:
                    logger.Debug("Found String " + token.Value);
                    return token.Value;
                case JsonToken.TokenType.Number:
                    logger.Debug("Found Number " + token.Number);
                    return token.Number;
                case JsonToken.TokenType.False:
                    logger.Debug("Found False");
                    return false;
                case JsonToken.TokenType.True:
                    logger.Debug("Found True");
                    return true;
                case JsonToken.TokenType.Null:
                    logger.Debug("Found Null");
                    return null;
                case JsonToken.TokenType.ObjectStart:
                    logger.Debug("Found ObjectStart");
                    return ParseObject(ts);
                case JsonToken.TokenType.ArrayStart:
                    logger.Debug("Found ArrayStart");
                    return ParseArray(ts);
                case JsonToken.TokenType.Undefined:
                default:
                    throw new ArgumentException("parse error");
            }
        }

        private static JsonDictionary ParseObject(TokenStream ts)
        {
            // to parse an object, you get the object name, and then parse the value
            JsonToken token = ts.GetNextToken();

            if (token.Type != JsonToken.TokenType.String && token.Type != JsonToken.TokenType.ObjectEnd)
            {
                throw new ArgumentException(
                    "Unable to parse object. Found object " + token +
                    " while looking for property name or object end.");
            }

            JsonDictionary dict = new JsonDictionary();
            if (token.Type != JsonToken.TokenType.ObjectEnd)
            {
                for (JsonToken cur = ts.GetNextToken(); cur != null; cur = ts.GetNextToken())
                {
                    switch (cur.Type)
                    {
                        case JsonToken.TokenType.ObjectEnd:
                            logger.Debug("Found object end");
                            return dict;
                        case JsonToken.TokenType.MemberSeperator:
                            token = ts.GetNextToken();
                            break;
                        case JsonToken.TokenType.NameSeperator:
                            object value = ParseExpression(null, ts);
                            if (dict.ContainsKey(token.Value))
                            {
                                throw new ArgumentException(
                                    "JsonObject contains duplicate definition for [" + token.Value + "]");
                            }
                            dict.Add(token.Value, value);
                            break;
                        default:
                            throw new ArgumentException(
                                "Found invalid Json was expecting } or , or : found " + cur);
                    }
                }
            }
            return dict;
        }

        private static List<object> ParseArray(TokenStream ts)
        {
            var list = new List<object>();
            for (JsonToken cur = ts.GetNextToken(); cur != null; cur = ts.GetNextToken())
            {
                if (cur.Type == JsonToken.TokenType.ArrayEnd)
                {
                    return list;
                }
                if (cur.Type != JsonToken.TokenType.MemberSeperator)
                {
                    object value = ParseExpression(cur, ts);
                    list.Add(value);
                }
            }
            return list;
        }
    }
}