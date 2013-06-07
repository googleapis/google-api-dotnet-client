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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Google.Apis.Discovery;

namespace Google.Apis.Util
{
    /// <summary>
    /// A class containing utility methods.
    /// </summary>
    public static class Utilities
    {
        /// <summary>
        /// Fetches an element from a dictionary in a safe way, returning <c>default(value)</c> if there is no value 
        /// present.
        /// </summary>
        public static TValue GetValueAsNull<TKey, TValue>(this IDictionary<TKey, TValue> data, TKey key)
        {
            return GetValue(data, key, () => default(TValue));
        }

        /// <summary>
        /// Fetches an element from a dictionary in a safe way, 
        /// returning a value specified by the input func if there is no value present.
        /// </summary>
        public static TReturnValue GetValue<TKey, TValue, TReturnValue>(this IDictionary<TKey, TValue> data, TKey key,
            Func<TReturnValue> defaultFunc) where TReturnValue : TValue
        {
            key.ThrowIfNull("key");
            defaultFunc.ThrowIfNull("defaultFunc");
            TValue result;
            if (!data.TryGetValue(key, out result) || !(result is TReturnValue))
            {
                return defaultFunc();
            }
            return (TReturnValue)result;
        }


        private static readonly IEnumerable EmptyList = new List<object>().AsReadOnly();
        /// <summary>
        /// If the enumerable is <code>null</code>, returns empty list. Otherwise returns the input list.
        /// </summary>
        public static IEnumerable<T> NullToEmpty<T>(this IEnumerable<T> data)
        {
            // casting the enumerable to T is ok, because it's an empty list
            return data ?? EmptyList.Cast<T>();
        }

        private static readonly IDictionary<object, object> EmptyDictionary =
            new Dictionary<object, object>().AsReadOnly();
        /// <summary>
        /// If the dictionary is <code>null</code>, returns empty dictionary. Otherwise returns the input dictionary.
        /// </summary>
        public static IDictionary<TKey, TValue> NullToEmpty<TKey, TValue>(
            this IDictionary<TKey, TValue> data)
        {
            // casting is ok here, because it's an empty dictionary
            return data ?? EmptyDictionary.ToDictionary(k => (TKey)k.Key, k => (TValue)k.Value);
        }

        /// <summary>
        /// If key exists in data and is an IEnumerable will return each element converted to a string 
        /// with ToString, or null. If key does not exist in data, is null or not an IEnumerable we will 
        /// return the empty list.
        /// </summary>
        public static IEnumerable<string> GetValueAsStringListOrEmpty<TKey, TValue>(
            this IDictionary<TKey, TValue> data, TKey key)
        {
            data.ThrowIfNull("data");
            IEnumerable value = GetValueAsNull(data, key) as IEnumerable;
            if (value == null)
            {
                yield break;
            }
            foreach (object obj in value)
            {
                yield return obj != null ? obj.ToString() : null;
            }
        }

        /// <summary>Extension method on object, which throws a ArgumentNullException if obj is null</summary>
        public static void ThrowIfNull(this object obj, string paramName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        /// <summary>
        /// Throws an exception if the string is null or empty
        /// </summary>
        public static void ThrowIfNullOrEmpty(this string str, string paramName)
        {
            str.ThrowIfNull(paramName);
            if (str.Length == 0)
            {
                throw new ArgumentException("Parameter was empty", paramName);
            }
        }

        /// <summary>
        /// Throws the collection is null or empty
        /// </summary>
        public static void ThrowIfNullOrEmpty<T>(this ICollection<T> coll, string paramName)
        {
            coll.ThrowIfNull(paramName);
            if (coll.Count == 0)
            {
                throw new ArgumentException("Parameter was empty", paramName);
            }
        }

        /// <summary>
        /// Formats the specified string if format arguments are specified, or returns the unmodified string otherwise.
        /// </summary>
        public static string FormatString(this string message, params object[] formatArgs)
        {
            if (message == null)
            {
                return null;
            }
            return formatArgs.Length > 0 ? string.Format(message, formatArgs) : message;
        }

        /// <summary> Returns a readonly variant of the given dictionary. </summary>
        public static IDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(this IDictionary<TKey, TValue> dict)
        {
            dict.ThrowIfNull("dict");
            return new ReadOnlyDictionary<TKey, TValue>(dict);
        }

        /// <summary> Returns a readonly variant of the given list. </summary>
        public static ReadOnlyCollection<T> AsReadOnly<T>(this IList<T> list)
        {
            list.ThrowIfNull("list");
            return new ReadOnlyCollection<T>(list);
        }

        /// <summary>
        /// Returns true when the string is null or empty
        /// </summary>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// Returns true when the string is NOT null or empty
        /// </summary>
        public static bool IsNotNullOrEmpty(this string str)
        {
            return !string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// Returns true when the collection is NOT null or empty
        /// </summary>
        public static bool IsNotNullOrEmpty<T>(this ICollection<T> coll)
        {
            return coll != null && coll.Count > 0;
        }

        /// <summary>
        /// Returns true when the enumerable is null or empty.
        /// </summary>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> coll)
        {
            return coll == null || coll.Count() == 0;
        }

        /// <summary>
        /// Returns true when the collection is null or empty
        /// </summary>
        public static bool IsNullOrEmpty<T>(this ICollection<T> coll)
        {
            return coll == null || coll.Count == 0;
        }

        /// <summary>
        /// Returns the first matching custom attribute (or null) of the specified member
        /// </summary>
        public static T GetCustomAttribute<T>(this MemberInfo info) where T : Attribute
        {
            object[] results = info.GetCustomAttributes(typeof(T), false);
            return results.Length == 0 ? null : (T)results[0];
        }

        /// <summary>
        /// Returns the defined string value of an enum value
        /// </summary>
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
        /// Retrieves the underlying type if the specified type is a Nullable, or the type itself otherwise.
        /// </summary>
        public static Type GetNonNullableType(Type type)
        {
            if (!type.IsGenericType || !typeof(Nullable<>).IsAssignableFrom(type.GetGenericTypeDefinition()))
            {
                return type; // Not a Nullable.
            }

            // First: Find the Nullable type.
            while (!(type.IsGenericType && type.GetGenericTypeDefinition().Equals(typeof(Nullable<>))))
            {
                type = type.BaseType;

                if (type == null)
                {
                    return null;
                }
            }

            // Return the type which is encapsulated by the Nullable.
            return type.GetGenericArguments()[0];
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

        /// <summary>
        /// Parses the specified array as an ascii string.
        /// </summary>
        public static string GetAsciiString(IEnumerable<byte> bytes)
        {
            return bytes.Aggregate("", (str, b) => str + (char)b);
        }

        /// <summary>
        /// Please don't use this unless absolutely nessasery.
        /// Returns if the current runtime is Mono, this is used to work around different behavior in the runtime.
        /// </summary>
        public static bool IsMonoRuntime()
        {
            return Type.GetType("Mono.Runtime") != null;
        }

        /// <summary>
        /// Creates a new <code>IParameter</code> by the specified values.
        /// </summary>
        public static IParameter CreateRuntimeParameter(string name, bool isRequired, string parameterType,
            string defaultValue, string pattern, IEnumerable<string> enumValues)
        {
            return new RuntimeParameter
            {
                Name = name,
                IsRequired = isRequired,
                ParameterType = parameterType,
                DefaultValue = defaultValue,
                Pattern = pattern,
                EnumValues = enumValues
            };
        }
    }
}