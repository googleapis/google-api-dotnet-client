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

using System.ComponentModel;
using System.Reflection;

namespace GoogleApis.Samples.SampleHelper
{
    /// <summary>
    /// Reflection Helper
    /// </summary>
    public class Reflection
    {
        /// <summary>
        /// Tries to return a descriptive name for the specified member info. 
        /// Uses the DescriptionAttribute if available.
        /// </summary>
        /// <returns>Description from DescriptionAttriute or name of the MemberInfo</returns>
        public static string GetDescriptiveName(MemberInfo info)
        {
            // If available: Return the description set in the DescriptionAttribute
            foreach (DescriptionAttribute attribute in info.GetCustomAttributes(typeof(DescriptionAttribute), true))
                return attribute.Description;

            // Otherwise: Return the name of the member
            return info.Name;
        }
    }
}
