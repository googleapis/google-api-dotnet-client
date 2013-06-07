/*
Copyright 2011 Google Inc

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

using System.Collections.Generic;
using System.Text;
using Google.Apis.Util;

namespace Google.Apis.Requests
{
    /// <summary>
    /// Collection of server errors
    /// </summary>
    public class RequestError
    {
        /// <summary>
        /// Enumeration of known error codes which may occur during a request.
        /// </summary>
        public enum ErrorCodes
        {
            /// <summary>
            /// The ETag condition specified caused the ETag verification to fail. 
            /// Depending on the ETagAction of the request this either means that a change to the object has been
            /// made on the server, or that the object in question is still the same and has not been changed.
            /// </summary>
            ETagConditionFailed = 412
        }

        /// <summary>
        /// Contains a list of all errors
        /// </summary>
        public IList<SingleError> Errors { get; set; }

        /// <summary>
        /// The error code returned
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// The error message returned
        /// </summary>
        public string Message { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(GetType().FullName).Append(Message).AppendFormat(" [{0}]", Code).AppendLine();
            if (Errors.IsNullOrEmpty())
            {
                sb.AppendLine("No individual errors");
            }
            else
            {
                sb.AppendLine("Errors [");
                foreach (SingleError err in Errors)
                {
                    sb.Append('\t').AppendLine(err.ToString());
                }
                sb.AppendLine("]");
            }

            return sb.ToString();
        }
    }
}
