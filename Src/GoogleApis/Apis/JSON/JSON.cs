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

namespace Google.Apis.JSON {

  internal class JSONToken {
    internal enum Type {
      ObjectStart,
      ArrayStart,
      ObjectEnd,
      ArrayEnd,
      NameSeperator,
      MemberSeperator,
      String,
      Number,
      False,
      True,
      Null,
      Undefined
    }
	
    public Type type;
    public string value;
    public decimal number;
  }


  internal class TokenStream {
    private const int BuilderBufferSize = 24;
    private TextReader reader = null;
    JSONToken.Type lastType = JSONToken.Type.Undefined;

    public TokenStream(string inputText) {
      reader = new StringReader(inputText);
    }

    public TokenStream(Stream inputStream) {
      reader = new StreamReader(inputStream);
    }

    /// <summary>
    /// From the current position, extract the next token
    /// </summary>
    /// <returns></returns>
    public JSONToken GetNextToken() {
      JSONToken token = new JSONToken();
      StringBuilder sb;
      try {
        // first skip over all whitespace.
        while (Char.IsWhiteSpace((char)reader.Peek())) {
          reader.Read();
        }

        if (reader.Peek() == -1)
          return null;

        char cur = (char)reader.Read();
        switch (cur) {
          case '{':
            token.type = JSONToken.Type.ObjectStart;
            break;
          case '}':
            token.type = JSONToken.Type.ObjectEnd;
            break;
          case '[':
            token.type = JSONToken.Type.ArrayStart;
            break;
          case ']':
            token.type = JSONToken.Type.ArrayEnd;
            break;
          case ':':
            token.type = JSONToken.Type.NameSeperator;
            break;
          case ',':
            token.type = JSONToken.Type.MemberSeperator;
            break;
          case '"':
            token.type = JSONToken.Type.String;
            // let's read in the string
            sb = new StringBuilder(BuilderBufferSize);
            char next;
            while ((next = (char)reader.Read()) != '"') {
              sb.Append(next);
            }
            token.value = sb.ToString();
            break;
          case 'f':
            GetFalseToken(token);
            break;
          case 't':
            // this might be the true token
            GetTrueToken(token);
            break;
          case 'n':
            // this might be nul
            GetNullToken(token);
            break;
          default:
            token.type = JSONToken.Type.Undefined;
            if (Char.IsNumber(cur)) {
              sb = new StringBuilder(BuilderBufferSize);
              sb.Append(cur);
              while (IsTokenSeperator((char)reader.Peek()) == false) {
                sb.Append((char)reader.Read());
              }
              token.value = sb.ToString();
			  decimal decNumber;
			  if(Decimal.TryParse(token.value, out decNumber)){
				token.number = decNumber;
				token.type = JSONToken.Type.Number;
			  }
            }
            break;
          

        }
      }
      catch (IOException) {
        return null;
      }
      this.lastType = token.type;
      Trace.TraceInformation("Got token: " + token.type + " - " + token.value);
      return token;
    }

    // starts at the a of the false
    private void GetFalseToken(JSONToken token) {
      token.type = JSONToken.Type.Undefined;
      // this might be the false token
      if (LookupToken("alse") == true)
         token.type = JSONToken.Type.False;
      return;
    }
    // starts at the a of the false
    private void GetTrueToken(JSONToken token) {
      token.type = JSONToken.Type.Undefined;
      // this might be the false token
      if (LookupToken("rue") == true)
        token.type = JSONToken.Type.True;
      return;
    }
    // starts at the a of the false
    private void GetNullToken(JSONToken token) {
      token.type = JSONToken.Type.Undefined;
      // this might be the false token
      if (LookupToken("ull") == true)
        token.type = JSONToken.Type.Null;
      return;
    }
  
    private bool LookupToken(string tokenString) {
      char cur;
      foreach (char c in tokenString) {
        cur = (char) reader.Read();
        if (c != cur)
          return false;
      }
      cur = (char) reader.Peek();
      if (IsTokenSeperator(cur))
        return true;

      return false;
    }

    private bool IsTokenSeperator(char c) {
      if (Char.IsLetterOrDigit(c) == true)
        return false;
      return true;
    }
  }
	
  internal class JSONDictionary : Dictionary<string, object>
  {
		
	}

  /// <summary>
  /// basic JSONReader that can parse eitehr strings or streams into some
  /// dictionary form.
  /// </summary>
  internal class JSONReader {
    private static JSONReader theInstance;

    private JSONReader() { }

    public static JSONReader GetInstance() {
      if (JSONReader.theInstance == null) {
        JSONReader.theInstance = new JSONReader();
      }
      return JSONReader.theInstance;
    }

    public static object Parse(string jsonAsText) {
      TokenStream ts = new TokenStream(jsonAsText);
      return ParseExpression(null, ts);
    }

    public static object Parse(Stream jsonAsStream) {
      TokenStream ts = new TokenStream(jsonAsStream);
      return ParseExpression(null, ts);
    }

    private static object ParseExpression(JSONToken token, TokenStream ts) {
      if (token == null)
        token = ts.GetNextToken();
			
		
      object value = null;
      switch (token.type) {
        case JSONToken.Type.String:
          value = token.value;
          break;
        case JSONToken.Type.Number:
          value = token.number;
          break;
        case JSONToken.Type.False:
          value = false;
          break;
        case JSONToken.Type.True:
          value = true;
          break;
        case JSONToken.Type.Null:
          value = null;
          break;
        case JSONToken.Type.ObjectStart:
          value = ParseObject(ts);
          break;
        case JSONToken.Type.ArrayStart:
          value = ParseArray(ts);
          break;
        case JSONToken.Type.Undefined:
          throw new ArgumentException("parse error");
      }

      return value;
    }

    private static object ParseObject(TokenStream ts) {
      // to parse an object, you get the object name, and then parse the value
      JSONToken token = ts.GetNextToken();
			
      if (token.type != JSONToken.Type.String)
        throw new System.ArgumentException("The tokenstream is not pointing at an object");

      JSONDictionary dict = new JSONDictionary();

      for (JSONToken cur = ts.GetNextToken(); cur != null; cur = ts.GetNextToken()) {
        if (cur.type == JSONToken.Type.ObjectEnd)
          return dict;
        else if (cur.type == JSONToken.Type.MemberSeperator) {
          token = ts.GetNextToken();
        }
        else if (cur.type == JSONToken.Type.NameSeperator) {
          object value = ParseExpression(null, ts);
		  
          dict.Add(token.value, value);
        } 
      
      } 
      return dict;
    }

    private static ArrayList ParseArray(TokenStream ts) {

      ArrayList list = new ArrayList();
      
      for (JSONToken cur = ts.GetNextToken(); cur != null; cur = ts.GetNextToken()) {
        if (cur.type == JSONToken.Type.ArrayEnd)
          return list;
        else if (cur.type != JSONToken.Type.MemberSeperator) {
          object value = ParseExpression(cur, ts);
          list.Add(value);
        }
      }
      return list;
    }
  }
}
