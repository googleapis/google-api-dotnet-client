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
        /// Sorted by proposed order, and alphabeticly for the remaining parameters.
        /// </summary>
        public static IEnumerable<IParameter> GetRequiredParameters(this IMethod method)
        {
            return (from p in method.GetAllParametersSorted() where p.IsRequired select p);
        }


        /// <summary>
        /// Return all optional IParameters from the given method.
        /// Sorted by proposed order, and alphabeticly for the remaining parameters.
        /// </summary>
        public static IEnumerable<IParameter> GetOptionalParameters(this IMethod method)
        {
            return (from p in method.GetAllParametersSorted() where !p.IsRequired select p);
        }

        /// <summary>
        /// Return all IParameters from the given method.
        /// Sorted by proposed order, then required, then optional, alphabeticly within those groupings.
        /// </summary>
        public static IEnumerable<IParameter> GetAllParametersSorted(this IMethod method)
        {
            if (method.Parameters == null)
            {
                yield break;
            }

            var remainingParameters = new List<IParameter>(method.Parameters.Values);

            // First add all parameters in the suggested order.
            if (method.ParameterOrder != null)
            {
                foreach (string parameterName in method.ParameterOrder)
                {
                    if (method.Parameters.ContainsKey(parameterName))
                    {
                        // Return the parameter, and remove it from the lit of remaining parameters.
                        IParameter parameter = method.Parameters[parameterName];
                        remainingParameters.Remove(parameter);
                        yield return parameter;
                    }
                }
            }

            // Get a ordered list of all the parameters of this method. 
            // First required, then optional ones. In each category the set is then sorted alphabetically.
            var sortedParameters =
                (from parameter in remainingParameters
                 orderby parameter.IsRequired descending, parameter.Name
                 select parameter);

            foreach (IParameter parameter in sortedParameters)
            {
                yield return parameter;
            }
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