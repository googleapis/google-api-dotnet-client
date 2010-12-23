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
    /// basic JsonReader that can parse eitehr strings or streams into some
    /// dictionary form.
    /// </summary>
    public class JsonReader
    {
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
            
            switch (token.type) 
            {
            case JsonToken.Type.String:
                return token.value;
            case JsonToken.Type.Number:
                return token.number;
            case JsonToken.Type.False:
                return false;
            case JsonToken.Type.True:
                return true;
            case JsonToken.Type.Null:
                return null;
            case JsonToken.Type.ObjectStart:
                return ParseObject (ts);
            case JsonToken.Type.ArrayStart:
                return ParseArray (ts);
            case JsonToken.Type.Undefined:
                throw new ArgumentException ("parse error");
			default:
				throw new ArgumentException ("parse error");
            }
        }

        private static JsonDictionary ParseObject (TokenStream ts)
        {
            // to parse an object, you get the object name, and then parse the value
            JsonToken token = ts.GetNextToken ();
            
            if (token.type != JsonToken.Type.String)
                throw new System.ArgumentException ("The tokenstream is not pointing at an object");
            
            JsonDictionary dict = new JsonDictionary ();
            
            for (JsonToken cur = ts.GetNextToken (); cur != null; cur = ts.GetNextToken ()) {
                if (cur.type == JsonToken.Type.ObjectEnd)
                    return dict; else if (cur.type == JsonToken.Type.MemberSeperator) {
                    token = ts.GetNextToken ();
                } else if (cur.type == JsonToken.Type.NameSeperator) {
                    object value = ParseExpression (null, ts);
                    
                    dict.Add (token.value, value);
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