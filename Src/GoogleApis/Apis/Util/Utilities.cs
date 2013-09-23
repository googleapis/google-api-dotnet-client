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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Google.Apis.Util
{
    /// <summary>
    /// A class containing utility methods.
    /// </summary>
    public static class Utilities
    {
        /// <summary> Returns the version of the Core library.</summary>
        public static string GetLibraryVersion()
        {
            return Regex.Match(typeof(Utilities).Assembly.FullName, "Version=([\\d\\.]+)").Groups[1].ToString();
        }

        /// <summary> Throws an <c>ArgumentNullException</c> if the object is null.</summary>
        public static void ThrowIfNull(this object obj, string paramName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        /// <summary> Throws an <c>ArgumentException</c> if the string is <c>null</c> or empty.</summary>
        public static void ThrowIfNullOrEmpty(this string str, string paramName)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("Parameter was empty", paramName);
            }
        }

        /// <summary> Returns a read-only variant of the given dictionary. </summary>
        public static IDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(this IDictionary<TKey, TValue> dict)
        {
            dict.ThrowIfNull("dict");
            return new ReadOnlyDictionary<TKey, TValue>(dict);
        }

        /// <summary> Returns a read-only variant of the given list. </summary>
        public static ReadOnlyCollection<T> AsReadOnly<T>(this IList<T> list)
        {
            list.ThrowIfNull("list");
            return new ReadOnlyCollection<T>(list);
        }

        /// <summary> Returns <c>true</c> when the enumerable is <c>null</c> or empty. </summary>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> coll)
        {
            return coll == null || coll.Count() == 0;
        }

        /// <summary> Returns the first matching custom attribute (or <c>null</c>) of the specified member. </summary>
        public static T GetCustomAttribute<T>(this MemberInfo info) where T : Attribute
        {
            object[] results = info.GetCustomAttributes(typeof(T), false);
            return results.Length == 0 ? null : (T)results[0];
        }

        /// <summary> Returns the defined string value of an enum value. </summary>
        public static string GetStringValue(this Enum value)
        {
            FieldInfo entry = value.GetType().GetField(value.ToString());
            entry.ThrowIfNull("value");

            // If set, return the value
            var attribute = entry.GetCustomAttribute<StringValueAttribute>();
            if (attribute != null)
            {
                return attribute.Text;
            }

            // Otherwise throw an exception
            throw new ArgumentException(
                string.Format("Enum value '{0}' does not contain a StringValue attribute", entry), "value");
        }

        /// <summary>
        /// Tries to convert the specified object to a string. Uses custom type converters if available.
        /// Returns null for a null object.
        /// </summary>
        public static string ConvertToString(object o)
        {
            if (o == null)
            {
                return null;
            }

            if (o.GetType().IsEnum)
            {
                // try to convert the Enum value using the StringValue attribute
                var enumType = o.GetType();
                FieldInfo field = enumType.GetField(o.ToString());
                StringValueAttribute attribute = field.GetCustomAttribute<StringValueAttribute>();
                return attribute != null ? attribute.Text : o.ToString();
            }

            return o.ToString();
        }
    }
}