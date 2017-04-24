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

namespace Google.Apis.Requests
{
    /// <summary>
    /// A single server error
    /// </summary>
    public class SingleError
    {
        /// <summary>
        /// The domain in which the error occured
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// The reason the error was thrown
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// The error message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Type of the location
        /// </summary>
        public string LocationType { get; set; }

        /// <summary>
        /// Location where the error was thrown
        /// </summary>
        public string Location { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Message[{0}] Location[{1} - {2}] Reason[{3}] Domain[{4}]", Message, Location, LocationType, Reason,
                Domain);
        }
    }
}
