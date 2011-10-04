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
namespace Google.Apis.Json
{
    /// <summary>
    /// Represents a token within the json document
    /// </summary>
    public class JsonToken
    {
        #region TokenType enum

        /// <summary>
        /// The type this token describes
        /// </summary>
        public enum TokenType
        {
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

        #endregion

        /// <summary>
        /// The numeric value of the token (if applicable)
        /// </summary>
        public decimal Number;

        /// <summary>
        /// The type this token represents
        /// </summary>
        public TokenType Type;

        /// <summary>
        /// The value of this token (if applicable)
        /// </summary>
        public string Value;

        public override string ToString()
        {
            return string.Format("[JsonToken {0} {1} {2}]", Type, Value, Number);
        }
    }
}