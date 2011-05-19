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
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Google.Apis.Json
{
    /// <summary>
    /// basic JsonReader that can parse either strings or streams into some
    /// dictionary form.
    /// </summary>
    public class JsonReader
    {
        public static log4net.ILog logger = log4net.LogManager.GetLogger (typeof(JsonReader));
        private static JsonReader theInstance;

        private JsonReader ()
        {
        }

        public static JsonReader GetInstance ()
        {
            if (JsonReader.theInstance == null) {
                JsonReader.theInstance = new JsonReader ();
            }
            return JsonReader.theInstance;
        }

        public static object Parse (string jsonAsText)
        {
            TokenStream ts = new TokenStream (jsonAsText);
            return ParseExpression (null, ts);
        }

        public static object Parse (Stream jsonAsStream)
        {
            TokenStream ts = new TokenStream (jsonAsStream);
            return ParseExpression (null, ts);
        }

        private static object ParseExpression (JsonToken token, TokenStream ts)
        {
            if (token == null)
            {
                token = ts.GetNextToken ();
            }

            if (token == null)
            {
                throw new InvalidDataException("Found end of discovery document when expecting a expression.");
            }

            switch (token.type) 
            {
            case JsonToken.Type.String:
                logger.Debug("Found String " + token.value);
                return token.value;
            case JsonToken.Type.Number:
                logger.Debug("Found Number " + token.number);
                return token.number;
            case JsonToken.Type.False:
                logger.Debug("Found False");
                return false;
            case JsonToken.Type.True:
                logger.Debug("Found True");
                return true;
            case JsonToken.Type.Null:
                logger.Debug("Found Null");
                return null;
            case JsonToken.Type.ObjectStart:
                logger.Debug("Found ObjectStart");
                return ParseObject (ts);
            case JsonToken.Type.ArrayStart:
                logger.Debug("Found ArrayStart");
                return ParseArray (ts);
            case JsonToken.Type.Undefined:
            default:
                throw new ArgumentException ("parse error");
            }
        }

        private static JsonDictionary ParseObject (TokenStream ts)
        {
            // to parse an object, you get the object name, and then parse the value
            JsonToken token = ts.GetNextToken ();

            if (token == null || token.type != JsonToken.Type.String && token.type != JsonToken.Type.ObjectEnd)
            {
                throw new InvalidDataException("The tokenstream is not pointing at an object, found object "
                    + (token != null ? token.ToString() : "NULL" ) + " looking for a string or close object");
            }
            
            JsonDictionary dict = new JsonDictionary ();
            
            for (JsonToken cur = ts.GetNextToken (); cur != null; cur = ts.GetNextToken ()) {
                switch(cur.type)
                {
                    case JsonToken.Type.ObjectEnd:
                        logger.Debug("Found object end");
                        return dict; 
                    case JsonToken.Type.MemberSeperator:
                        token = ts.GetNextToken ();
                        break;
                    case JsonToken.Type.NameSeperator:
                        object value = ParseExpression (null, ts);
                        if (dict.ContainsKey(token.value))
                        {
                            throw new ArgumentException("JsonObject contains duplicate definition for ["+token.value+"]");
                        }
                        dict.Add (token.value, value);
                        break;
                    default: 
                        throw new InvalidDataException("Found invalid Json was expecting } or , or : found " + cur.ToString());
                }                
            }
            return dict;
        }

        private static ArrayList ParseArray (TokenStream ts)
        {
            ArrayList list = new ArrayList ();
            for (JsonToken cur = ts.GetNextToken (); cur != null; cur = ts.GetNextToken ()) {
                if (cur.type == JsonToken.Type.ArrayEnd)
                    return list; else if (cur.type != JsonToken.Type.MemberSeperator) {
                    object value = ParseExpression (cur, ts);
                    list.Add (value);
                }
            }
            return list;
        }
    }
}