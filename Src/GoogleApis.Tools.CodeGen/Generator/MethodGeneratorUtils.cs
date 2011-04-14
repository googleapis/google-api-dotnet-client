using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Google.Apis.Discovery;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Generator
{
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
                return new List<IParameter>(0);
            }
            return from p in method.Parameters
                   where p.Value.Required
                   orderby p.Value.Name
                   select p.Value;
        }


        /// <summary>
        /// Return all optional IParemters from the given method.
        /// Sorted alphabeticly by name 
        /// </summary>
        public static IEnumerable<IParameter> GetOptionalParameters(this IMethod method)
        {
            if (method == null || method.Parameters.IsNullOrEmpty())
            {
                return new List<IParameter>(0);
            }
            return from p in method.Parameters
                   where p.Value.Required == false
                   orderby p.Value.Name
                   select p.Value;
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
