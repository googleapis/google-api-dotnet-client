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

using System.Collections.Generic;
using System.Linq;
using Google.Apis.Discovery;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Generator
{
    /// <summary>
    /// Utility class for Method-generators
    /// </summary>
    public static class MethodGeneratorUtils
    {
        /// <summary>
        /// Return all required IParemters from the given method.
        /// Sorted alphabeticly by name 
        /// </summary>
        public static IEnumerable<IParameter> GetRequiredParameters(this IMethod method)
        {
            if (method == null || method.Parameters.IsNullOrEmpty())
            {
                return Enumerable.Empty<IParameter>();
            }
            return from p in method.Parameters where p.Value.Required orderby p.Value.Name select p.Value;
        }


        /// <summary>
        /// Return all optional IParemters from the given method.
        /// Sorted alphabeticly by name 
        /// </summary>
        public static IEnumerable<IParameter> GetOptionalParameters(this IMethod method)
        {
            if (method == null || method.Parameters.IsNullOrEmpty())
            {
                return Enumerable.Empty<IParameter>();
            }
            return from p in method.Parameters where p.Value.Required == false orderby p.Value.Name select p.Value;
        }

        /// <summary>
        /// Return all IParemters from the given method.
        /// sorted by required then optional, alphabeticly within those groupings 
        /// </summary>
        public static IEnumerable<IParameter> GetAllParametersSorted(this IMethod method)
        {
            return method.GetRequiredParameters().Concat(method.GetOptionalParameters());
        }

        /// <summary>
        /// True if any of the parameters are required
        /// </summary>
        public static bool HasRequiredParameters(this IMethod method)
        {
            return GetRequiredParameters(method).Any();
        }

        /// <summary>
        /// True if any of the parameters are optional
        /// </summary>
        public static bool HasOptionalParameters(this IMethod method)
        {
            return GetOptionalParameters(method).Any();
        }
    }
}