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
using System.Globalization;
using Google.Apis.Logging;

namespace Google.Apis.Json
{
    /// <summary>
    /// The TokenStream class allows you to read through a Stream containing a json document token by token
    /// </summary>
    public class TokenStream
    {
        private const int BuilderBufferSize = 24;
        private static readonly ILogger logger = ApplicationContext.Logger.ForType<TokenStream>();
        private readonly TextReader reader;

        public TokenStream(string inputText)
        {
            reader = new StringReader(inputText);
        }

        public TokenStream(Stream inputStream)
        {
            reader = new StreamReader(inputStream);
        }

        /// <summary>
        /// Parses a Json String as per http://www.json.org/ acknowledging escaped chars
        /// </summary>
        private void ParseString(JsonToken token, char cur)
        {
            char seperator = cur;
            token.Type = JsonToken.TokenType.String;

            // let's read in the string
            var sb = new StringBuilder(BuilderBufferSize);
            char next;
            while ((next = (char) reader.Read()) != seperator)
            {
                if (next == '\\')
                {
                    next = (char) reader.Read();
                    switch (next)
                    {
                        case 'n':
                            next = '\n';
                            break;
                        case 'r':
                            next = '\r';
                            break;
                        case 't':
                            next = '\t';
                            break;
                        case '\'':
                            next = '\'';
                            break;
                        case '/':
                            next = '/';
                            break;
                        case '"':
                            next = '\"';
                            break;
                        case '\\':
                            next = '\\';
                            break;
                        case 'b':
                            // backspace
                            next = '\b';
                            break;
                        case 'u':
                            // 4 digit hexadecimal unicode escape
                            char[] escapedCharAry = new char[4];
                            for (int i = 0; i < 4; i++)
                            {
                                escapedCharAry[i] = (char) reader.Read();
                            }

                            String escapedCharStr = new String(escapedCharAry);
                            int escapedCharInt = int.Parse(
                                escapedCharStr, NumberStyles.HexNumber, NumberFormatInfo.InvariantInfo);
                            next = Convert.ToChar(escapedCharInt);
                            break;
                        default:
                            break;
                    }
                }
                sb.Append(next);
            }
            token.Value = sb.ToString();
        }

        /// <summary>
        /// From the current position, extract the next token
        /// </summary>
        /// <returns>The next token, or null if the stream is at the EOF</returns>
        public JsonToken GetNextToken()
        {
            var token = new JsonToken();
            try
            {
                // Read char (and first skip over all whitespaces)
                // We use .Read() instead of .Peek() here, as Read() is blocking.
                // .Peek() would suggest an EOF even if there is none when used in combination a WebRequest
                char cur;
                do
                {
                    int read = reader.Read();

                    // Check for EOF
                    if (read == -1)
                    {
                        return null;
                    }

                    cur = (char) read;
                } while (Char.IsWhiteSpace(cur));

                // Check for Json tokens
                switch (cur)
                {
                    case '{':
                        token.Type = JsonToken.TokenType.ObjectStart;
                        break;
                    case '}':
                        token.Type = JsonToken.TokenType.ObjectEnd;
                        break;
                    case '[':
                        token.Type = JsonToken.TokenType.ArrayStart;
                        break;
                    case ']':
                        token.Type = JsonToken.TokenType.ArrayEnd;
                        break;
                    case ':':
                        token.Type = JsonToken.TokenType.NameSeperator;
                        break;
                    case ',':
                        token.Type = JsonToken.TokenType.MemberSeperator;
                        break;
                    case '"':
                    case '\'':
                        ParseString(token, cur);
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
                        token.Type = JsonToken.TokenType.Undefined;
                        if (Char.IsNumber(cur) || cur == '-')
                        {
                            var sb = new StringBuilder(BuilderBufferSize);
                            sb.Append(cur);
                            while (IsTokenSeperator((char) reader.Peek()) == false || ((char) reader.Peek() == '.') ||
                                   ((char) reader.Peek() == '+') || ((char) reader.Peek() == '-'))
                            {
                                sb.Append((char) reader.Read());
                            }
                            token.Value = sb.ToString();
                            decimal decNumber;
                            if (Decimal.TryParse(
                                token.Value, NumberStyles.Number | NumberStyles.AllowExponent,
                                CultureInfo.InvariantCulture, out decNumber))
                            {
                                token.Number = decNumber;
                                token.Type = JsonToken.TokenType.Number;
                            }
                        }
                        break;
                }
            }
            catch (IOException ex)
            {
                throw new IOException("Unable to retrieve the next token", ex);
            }
            return token;
        }

        // starts at the a of the false
        private void GetFalseToken(JsonToken token)
        {
            token.Type = JsonToken.TokenType.Undefined;
            // this might be the false token
            if (LookupToken("alse"))
            {
                token.Type = JsonToken.TokenType.False;
            }
            return;
        }

        // starts at the a of the false
        private void GetTrueToken(JsonToken token)
        {
            token.Type = JsonToken.TokenType.Undefined;
            // this might be the false token
            if (LookupToken("rue"))
            {
                token.Type = JsonToken.TokenType.True;
            }
            return;
        }

        // starts at the a of the false
        private void GetNullToken(JsonToken token)
        {
            token.Type = JsonToken.TokenType.Undefined;
            // this might be the false token
            if (LookupToken("ull"))
            {
                token.Type = JsonToken.TokenType.Null;
            }
            return;
        }

        private bool LookupToken(string tokenString)
        {
            char cur;
            foreach (char c in tokenString)
            {
                cur = (char) reader.Read();
                if (c != cur)
                {
                    return false;
                }
            }
            cur = (char) reader.Peek();

            return IsTokenSeperator(cur);
        }

        private bool IsTokenSeperator(char c)
        {
            return Char.IsLetterOrDigit(c) == false;
        }
    }
}