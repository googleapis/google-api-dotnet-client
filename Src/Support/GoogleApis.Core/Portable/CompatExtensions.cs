using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Google
{
    internal static class CompatExtensions
    {
        public static Type GetTypeInfo(this Type type) => type;

        /// <summary>
        /// A utility method for returning the first matching custom attribute (or <c>null</c>) of the specified member.
        /// </summary>
        public static T GetCustomAttribute<T>(this MemberInfo info) where T : Attribute
        {
            var results = info.GetCustomAttributes(typeof(T), false).ToArray();
            return results.Length == 0 ? null : (T)results[0];
        }
    }
}
