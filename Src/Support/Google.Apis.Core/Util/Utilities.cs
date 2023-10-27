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

using Google.Apis.Json;
using Google.Apis.Testing;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Google.Apis.Util
{
    /// <summary>A utility class which contains helper methods and extension methods.</summary>
    public static class Utilities
    {
        private static readonly JsonSerializerSettings s_serializerSettingsWithoutDateParsing = new JsonSerializerSettings { DateParseHandling = DateParseHandling.None };

        /// <summary>Returns the version of the core library.</summary>
        [VisibleForTestOnly]
        public static string GetLibraryVersion()
        {
            return Regex.Match(typeof(Utilities).GetTypeInfo().Assembly.FullName, "Version=([\\d\\.]+)").Groups[1].ToString();
        }

        /// <summary>
        /// A Google.Apis utility method for throwing an <see cref="System.ArgumentNullException"/> if the object is
        /// <c>null</c>.
        /// </summary>
        public static T ThrowIfNull<T>(this T obj, string paramName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(paramName);
            }

            return obj;
        }

        /// <summary>
        /// A Google.Apis utility method for throwing an <see cref="System.ArgumentNullException"/> if the string is
        /// <c>null</c> or empty.
        /// </summary>
        /// <returns>The original string.</returns>
        public static string ThrowIfNullOrEmpty(this string str, string paramName)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("Parameter was empty", paramName);
            }
            return str;
        }

        /// <summary>Returns <c>true</c> in case the enumerable is <c>null</c> or empty.</summary>
        internal static bool IsNullOrEmpty<T>(this IEnumerable<T> coll)
        {
            return coll == null || coll.Count() == 0;
        }

        /// <summary>
        /// Checks that the given value is in fact defined in the enum used as the type argument of the method.
        /// </summary>
        /// <typeparam name="T">The enum type to check the value within.</typeparam>
        /// <param name="value">The value to check.</param>
        /// <param name="paramName">The name of the parameter whose value is being tested.</param>
        /// <returns><paramref name="value"/> if it was a defined value</returns>
        public static T CheckEnumValue<T>(T value, string paramName) where T : struct
        {
            CheckArgument(
                Enum.IsDefined(typeof(T), value),
                paramName,
                "Value {0} not defined in enum {1}", value, typeof(T).Name);
            return value;
        }

        /// <summary>
        /// Checks that given argument-based condition is met, throwing an <see cref="ArgumentException"/> otherwise.
        /// </summary>
        /// <param name="condition">The (already evaluated) condition to check.</param>
        /// <param name="paramName">The name of the parameter whose value is being tested.</param>
        /// <param name="format">The format string to use to create the exception message if the
        /// condition is not met.</param>
        /// <param name="arg0">The first argument to the format string.</param>
        /// <param name="arg1">The second argument to the format string.</param>
        public static void CheckArgument<T1, T2>(bool condition, string paramName, string format, T1 arg0, T2 arg1)
        {
            if (!condition)
            {
                throw new ArgumentException(string.Format(format, arg0, arg1), paramName);
            }
        }

        /// <summary>
        /// A Google.Apis utility method for returning the first matching custom attribute (or <c>null</c>) of the specified member.
        /// </summary>
        public static T GetCustomAttribute<T>(this MemberInfo info) where T : Attribute
        {
            object[] results = info.GetCustomAttributes(typeof(T), false).ToArray();
            return results.Length == 0 ? null : (T)results[0];
        }

        /// <summary>Returns the defined string value of an Enum.</summary>
        internal static string GetStringValue(this Enum value)
        {
            FieldInfo entry = value.GetType().GetField(value.ToString());
            entry.ThrowIfNull("value");

            // If set, return the value.
            var attribute = entry.GetCustomAttribute<StringValueAttribute>();
            if (attribute != null)
            {
                return attribute.Text;
            }

            // Otherwise, throw an exception.
            throw new ArgumentException(
                string.Format("Enum value '{0}' does not contain a StringValue attribute", entry), "value");
        }

        /// <summary>
        /// Returns the defined string value of an Enum. Use for test purposes or in other Google.Apis projects.
        /// </summary>
        public static string GetEnumStringValue(Enum value)
        {
            return value.GetStringValue();
        }

        /// <summary>
        /// Tries to convert the specified object to a string. Uses custom type converters if available.
        /// Returns null for a null object.
        /// </summary>
        [VisibleForTestOnly]
        public static string ConvertToString(object o)
        {
            if (o == null)
            {
                return null;
            }

            if (o.GetType().GetTypeInfo().IsEnum)
            {
                // Try to convert the Enum value using the StringValue attribute.
                var enumType = o.GetType();
                FieldInfo field = enumType.GetField(o.ToString());
                StringValueAttribute attribute = field.GetCustomAttribute<StringValueAttribute>();
                return attribute != null ? attribute.Text : o.ToString();
            }

            if (o is DateTime)
            {
                // Honor RFC3339.
                return ConvertToRFC3339((DateTime)o);
            }

            if (o is bool)
            {
                return o.ToString().ToLowerInvariant();
            }

            return o.ToString();
        }

        /// <summary>Converts the input date into a RFC3339 string (http://www.ietf.org/rfc/rfc3339.txt).</summary>
        internal static string ConvertToRFC3339(DateTime date)
        {
            if (date.Kind == DateTimeKind.Unspecified)
            {
                date = date.ToUniversalTime();
            }
            // TODO: Handle finer precision than milliseconds?
            return date.ToString("yyyy-MM-dd'T'HH:mm:ss.fffK", DateTimeFormatInfo.InvariantInfo);
        }

        /// <summary>
        /// Parses the input string and returns <see cref="System.DateTime"/> if the input is a valid 
        /// representation of a date. Otherwise it returns <c>null</c>.
        /// </summary>
        public static DateTime? GetDateTimeFromString(string raw)
        {
            DateTime result;
            if (!DateTime.TryParse(raw, out result))
            {
                return null;
            }
            return result;
        }

        /// <summary>Returns a string (by RFC3339) form the input <see cref="DateTime"/> instance.</summary>
        public static string GetStringFromDateTime(DateTime? date)
        {
            if (!date.HasValue)
            {
                return null;
            }
            return ConvertToRFC3339(date.Value);
        }

        /// <summary>
        /// Parses the input string and returns <see cref="System.DateTimeOffset"/> if the input has 0, 3, 6 or 9
        /// subsecond digits. If the input is null, this method returns <c>null</c>. Otherwise, <see cref="FormatException"/> is thrown.
        /// If 9 subsecond digits are present, the result is truncated as if the final two digits are 0 (as the "tick"
        /// precision of DateTimeOffset is 100 nanoseconds).
        /// </summary>
        public static DateTimeOffset? GetDateTimeOffsetFromString(string raw)
        {
            // Date part is 10 characters; time to seconds is 8.
            // We need to take account of the "T" separator, the decimal separator for subseconds, and the trailing 'Z'.
            const int SecondsOnlyLength = 20;
            const int MillisecondsLength = SecondsOnlyLength + 4;
            const int MicrosecondsLength = MillisecondsLength + 3;
            const int NanosecondsLength = MicrosecondsLength + 3;
            const int NanosecondsBeyondTicksIndex = NanosecondsLength - 3;
            if (raw is null)
            {
                return null;
            }
            return raw.Length switch
            {
                SecondsOnlyLength => DateTimeOffset.ParseExact(raw, "yyyy-MM-dd'T'HH:mm:ss'Z'", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal),
                MillisecondsLength => DateTimeOffset.ParseExact(raw, "yyyy-MM-dd'T'HH:mm:ss.fff'Z'", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal),
                MicrosecondsLength => DateTimeOffset.ParseExact(raw, "yyyy-MM-dd'T'HH:mm:ss.ffffff'Z'", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal),
                // Note: deliberately no Z here.
                NanosecondsLength => DateTimeOffset.ParseExact(AdjustForNanoseconds(raw), "yyyy-MM-dd'T'HH:mm:ss.fffffff", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal),
                _ => ThrowFormatException()
            };

            // If we receive "2023-10-2713:45:00.123456789Z" we need to parse it
            // as "2023-10-2713:45:00.1234567Z" (i.e. to tick precision) as .NET doesn't support
            // parsing and automatically truncating nanoseconds.
            static string AdjustForNanoseconds(string raw)
            {
                ValidateDigit(raw[NanosecondsBeyondTicksIndex]);
                ValidateDigit(raw[NanosecondsBeyondTicksIndex + 1]);
                // This avoids us having to concatenate the substring with "Z".
                if (raw[NanosecondsBeyondTicksIndex + 2] != 'Z')
                {
                    ThrowFormatException();
                }
                return raw.Substring(0, NanosecondsBeyondTicksIndex);
            }

            static void ValidateDigit(char c)
            {
                if (c < '0' || c > '9')
                {
                    ThrowFormatException();
                }
            }

            // Note: this returns DateTimeOffset so we can use it in the switch...
            static DateTimeOffset ThrowFormatException() =>
                throw new FormatException("String was not recognized as a valid DateTime");
        }

        /// <summary>
        /// Returns a string from the input <see cref="DateTimeOffset"/> instance, or <c>null</c> if
        /// <paramref name="date"/> is null. The string is always in the format "yyyy-MM-ddTHH:mm:ssZ" or
        /// "yyyy-MM-ddTHH:mm:ss.Z" or
        /// "yyyy-MM-ddTHH:mm:ssZ". It is always UTC, always either second, millisecond, microsecond or nanosecond precision,
        /// and always using the invariant culture. When using nanosecond precision, the last two digits will always be 0
        /// as 
        /// </summary>
        public static string GetStringFromDateTimeOffset(DateTimeOffset? date)
        {
            const int TicksPerMicrosecond = 10;
            if (date is not DateTimeOffset dto)
            {
                return null;
            }
            dto = dto.ToUniversalTime();
            // Note: DateTimeOffset.Ticks is always non-negative, which makes things simpler.
            long tickOfSecond = dto.Ticks % TimeSpan.TicksPerSecond;
            string pattern = tickOfSecond switch
            {
                0 => "yyyy-MM-dd'T'HH:mm:ss'Z'",
                _ when tickOfSecond % TimeSpan.TicksPerMillisecond == 0 => "yyyy-MM-dd'T'HH:mm:ss.fff'Z'",
                _ when tickOfSecond % TicksPerMicrosecond == 0 => "yyyy-MM-dd'T'HH:mm:ss.ffffff'Z'",
                _ => "yyyy-MM-dd'T'HH:mm:ss.fffffff'00Z'"
            };
            return date.Value.ToUniversalTime().ToString(pattern, CultureInfo.InvariantCulture);
        }
        /// <summary>
        /// Deserializes the given raw value to an object using <see cref="NewtonsoftJsonSerializer.Instance"/>,
        /// as if it were a JSON string value.
        /// </summary>
        /// <param name="rawValue">The string value to deserialize. May be null, in which case null is returned.</param>
        /// <returns>The deserialized value.</returns>
        public static object DeserializeForGoogleFormat(string rawValue)
        {
            if (rawValue is null)
            {
                return null;
            }
            // We need to encode the string as JSON - add quotes round it, escape backslashes etc.
            string json = JsonConvert.SerializeObject(rawValue);
            return NewtonsoftJsonSerializer.Instance.Deserialize<object>(json);
        }

        /// <summary>
        /// Serializes the given value using <see cref="NewtonsoftJsonSerializer.Instance"/>.
        /// </summary>
        /// <param name="value">The value to serialize. May be null, in which case null is returned.</param>
        /// <returns>The string representation of the object.</returns>
        /// <exception cref="ArgumentException">The value does not serialize to a JSON string.</exception>
        public static string SerializeForGoogleFormat(object value)
        {
            if (value is null)
            {
                return null;
            }
            var json = NewtonsoftJsonSerializer.Instance.Serialize(value);
            if (json is null ||
                json.Length < 2 ||
                !json.StartsWith("\"", StringComparison.Ordinal) ||
                !json.EndsWith("\"", StringComparison.Ordinal))
            {
                throw new ArgumentException("Value did not serialize to a JSON string.");
            }
            // Okay, so we have a JSON string. Now we need to parse it to retrieve the actual string value,
            // with no conversion to DateTime etc.
            return JsonConvert.DeserializeObject<string>(json, s_serializerSettingsWithoutDateParsing);
        }
    }
}
