/*
Copyright 2020 Google Inc

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

namespace Google.Apis.Util
{
    /// <summary>A wrapper class for environment variable.</summary>
    public class EnvironmentVariableProvider
    {
        /// <summary>Return the environment variable value.</summary>
        public virtual string GetEnvironmentVariable(string variableName) {
            return Environment.GetEnvironmentVariable(variableName);
        }

        /// <summary>Set the environment variable value.</summary>
        public virtual void SetEnvironmentVariable(string variableName, string value) {
            Environment.SetEnvironmentVariable(variableName, value);
        }
    }
}
