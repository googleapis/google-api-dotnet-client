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

namespace Google.Apis.Logging
{
    /// <summary>
    /// The supported logging levels.
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// A value lower than all logging levels.
        /// </summary>
        All = 0,

        /// <summary>
        /// Debug logging.
        /// </summary>
        Debug = 100,

        /// <summary>
        /// Info logging.
        /// </summary>
        Info = 200,

        /// <summary>
        /// Warning logging.
        /// </summary>
        Warning = 300,

        /// <summary>
        /// Error logging.
        /// </summary>
        Error = 400,

        /// <summary>
        /// A value higher than all logging levels.
        /// </summary>
        None = 1000,
    }
}
