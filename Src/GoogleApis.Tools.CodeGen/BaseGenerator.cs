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
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen
{

    public abstract class BaseGenerator
    {
        

        public BaseGenerator ()
        {
        }

        protected String GetMethodName (Method method, int methodNumber)
        {
            return GeneratorUtils.UpperFirstLetter (GetSafeMemberName (method.Name, "Method" + methodNumber));
        }

        public static String GetClassName (Resource resource, int resourceNumber)
        {
            return GeneratorUtils.UpperFirstLetter (GetSafeMemberName (resource.Name, "Resource" + resourceNumber));
        }

        protected static String GetFieldName (Resource resource, int resourceNumber)
        {
            return GetSafeMemberName (GeneratorUtils.LowwerFirstLetter(resource.Name), "Field" + resourceNumber);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter">
        /// A <see cref="Parameter"/>
        /// </param>
        /// <param name="paramNumber">The order of this parameter used if the name is not usable</param>
        /// <returns>
        /// A <see cref="String"/>
        /// </returns>
        protected String GetParameterName (Parameter parameter, int paramNumber)
        {
            return GetSafeMemberName (GeneratorUtils.LowwerFirstLetter(parameter.Name), "Param" + paramNumber);
        }

        private static String GetSafeMemberName (string baseName, String uniquieifier)
        {
            return GeneratorUtils.GetSafeMemberName (baseName, uniquieifier, GeneratorUtils.UnsafeWords);
        }

    }
}
