/*
Copyright 2011 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
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
using System.Collections;
using System.Collections.Generic;
using Google.Apis.Util;

namespace GoogleApis.Tools.ServiceGenerator
{
    /// <summary>
    /// Helper class to read command line arguments.
    /// </summary>
    public class ArgumentEnumerator : IEnumerator<string>
    {
        private readonly IEnumerator internalEnumerator;

        /// <summary>
        /// Returns true if this is a command line parameter.
        /// </summary>
        public bool IsParameter
        {
            get
            {
                if (Current == null)
                {
                    return false;
                }

                return Current.StartsWith("--") || Current.StartsWith("-");
            }
        }

        public ArgumentEnumerator(params string[] arguments)
        {
            internalEnumerator = arguments.GetEnumerator();
        }

        /// <summary>
        /// Returns current value if set, or throws an exception otherwise.
        /// </summary>
        /// <param name="parameterName">The name of the parameter to show to the user (if not set).</param>
        public string GetMandatory(string parameterName)
        {
            string text = Current;
            text.ThrowIfNullOrEmpty(parameterName);
            return text;
        }

        /// <summary>
        /// Returns current value if set, or throws an exception otherwise.
        /// Throws an exception if the current value is not a value of a parameter.
        /// </summary>
        /// <param name="parameterName">The name of the parameter to show to the user (if not set).</param>
        public string GetParameterValue(string parameterName)
        {
            string text = Current;
            text.ThrowIfNullOrEmpty(parameterName);
            
            if (IsParameter)
            {
                throw new ArgumentException("Did not find a value for parameter '"+parameterName+"'.");
            }

            return text;
        }

        #region IEnumerator<T>

        public bool MoveNext()
        {
            return internalEnumerator.MoveNext();
        }

        public void Reset()
        {
            internalEnumerator.Reset();
        }

        public string Current
        {
            get { return internalEnumerator.Current.ToString(); }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }
        
        public void Dispose() { }

        #endregion
    }
}
