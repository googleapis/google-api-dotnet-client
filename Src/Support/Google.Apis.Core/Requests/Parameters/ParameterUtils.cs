/*
Copyright 2013 Google Inc

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
using System.Net.Http;
using System.Linq;
using System.Reflection;

using Google.Apis.Logging;
using Google.Apis.Util;

namespace Google.Apis.Requests.Parameters
{
    /// <summary>
    /// Utility class for iterating on <see cref="RequestParameterAttribute"/> properties in a request object.
    /// </summary>
    public static class ParameterUtils
    {
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType(typeof(ParameterUtils));

        /// <summary>
        /// Creates a <see cref="System.Net.Http.FormUrlEncodedContent"/> with all the specified parameters in 
        /// the input request. It uses reflection to iterate over all properties with
        /// <see cref="Google.Apis.Util.RequestParameterAttribute"/> attribute.
        /// </summary>
        /// <param name="request">
        /// A request object which contains properties with
        /// <see cref="Google.Apis.Util.RequestParameterAttribute"/> attribute. Those properties will be serialized
        /// to the returned <see cref="System.Net.Http.FormUrlEncodedContent"/>.
        /// </param>
        /// <returns>
        /// A <see cref="System.Net.Http.FormUrlEncodedContent"/> which contains the all the given object required 
        /// values.
        /// </returns>
        public static FormUrlEncodedContent CreateFormUrlEncodedContent(object request)
        {
            IList<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            IterateParameters(request, (type, name, value) =>
                {
                    list.Add(new KeyValuePair<string, string>(name, value.ToString()));
                });
            return new FormUrlEncodedContent(list);
        }

        /// <summary>
        /// Creates a parameter dictionary by using reflection to iterate over all properties with
        /// <see cref="Google.Apis.Util.RequestParameterAttribute"/> attribute.
        /// </summary>
        /// <param name="request">
        /// A request object which contains properties with
        /// <see cref="Google.Apis.Util.RequestParameterAttribute"/> attribute. Those properties will be set
        /// in the output dictionary.
        /// </param>
        public static IDictionary<string, object> CreateParameterDictionary(object request)
        {
            // Use the typed implementation, then drop type information to preserve the legacy return type.
            return CreateParameterDictionaryWithTypes(request)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Value);
        }

        /// <summary>
        /// Creates a parameter dictionary with type information by using reflection to iterate over all properties with
        /// <see cref="Google.Apis.Util.RequestParameterAttribute"/> attribute.
        /// </summary>
        /// <param name="request">
        /// A request object which contains properties with
        /// <see cref="Google.Apis.Util.RequestParameterAttribute"/> attribute. Those properties will be set
        /// in the output dictionary along with their parameter type.
        /// </param>
        /// <exception cref="InvalidOperationException">
        /// Thrown when multiple properties set the same parameter name to non-null values.
        /// </exception>
        /// <returns>
        /// A dictionary where the key is the parameter name and the value is a ParameterValue containing type and value.
        /// </returns>
        private static IDictionary<string, ParameterValue> CreateParameterDictionaryWithTypes(object request)
        {
            var dict = new Dictionary<string, ParameterValue>();
            IterateParameters(request, (type, name, value) =>
            {
                if (dict.TryGetValue(name, out var existingEntry))
                {
                    var existingValue = existingEntry.Value;
                    // Repeated enum query parameters end up with two properties: a single
                    // one, and a Repeatable<T> (where the T is always non-nullable, whether or not the parameter
                    // is optional). If both properties are set, we fail. Note that this delegate is called
                    // for nullable enum properties with a null value, annoyingly... if that happens and we then
                    // see a non-null value, we'll overwrite it. If that happens when we've already got a non-null
                    // value, we'll ignore it.
                    if (existingValue is null && value is object)
                    {
                        // Overwrite null value with non-null value
                        dict[name] = new ParameterValue(type, value);
                    }
                    else if (value is null)
                    {
                        // Ignore new null value
                    }
                    else
                    {
                        // Throw if we see a second non-null value
                        throw new InvalidOperationException(
                            $"The query parameter '{name}' is set by multiple properties. For repeated enum query parameters, ensure that only one property is set to a non-null value.");
                    }
                }
                else
                {
                    dict.Add(name, new ParameterValue(type, value));
                }
            });
            return dict;
        }

        /// <summary>
        /// Sets query parameters in the given builder with all all properties with the
        /// <see cref="Google.Apis.Util.RequestParameterAttribute"/> attribute.
        /// </summary>
        /// <param name="builder">The request builder</param>
        /// <param name="request">
        /// A request object which contains properties with
        /// <see cref="Google.Apis.Util.RequestParameterAttribute"/> attribute. Those properties will be set in the
        /// given request builder object
        /// </param>
        public static void InitParameters(RequestBuilder builder, object request)
        {
            IterateParameters(request, (type, name, value) =>
                {
                    builder.AddParameter(type, name, value.ToString());
                });
        }

        /// <summary>
        /// Sets request parameters in the given builder with all properties with the
        /// <see cref="Google.Apis.Util.RequestParameterAttribute"/> attribute
        /// by expanding <see cref="IEnumerable"/> values into multiple parameters.
        /// </summary>
        /// <param name="builder">The request builder</param>
        /// <param name="request">
        /// A request object which contains properties with
        /// <see cref="Google.Apis.Util.RequestParameterAttribute"/> attribute. Those properties will be set in the
        /// given request builder object
        /// </param>
        public static void InitParametersWithExpansion(RequestBuilder builder, object request)
        {
            // Use typed methods to preserve RequestParameterType information
            var parametersWithTypes = CreateParameterDictionaryWithTypes(request);

            // Expand and add all parameters to the builder with their correct types
            foreach (var param in ExpandParametersWithTypes(parametersWithTypes))
            {
                builder.AddParameter(param.Type, param.Name, param.Value);
            }
        }

        /// <summary>
        /// Expands a dictionary of typed parameters into a sequence of <see cref="TypedParameter"/> instances.
        /// </summary>
        /// <remarks>
        /// If a parameter value implements <see cref="System.Collections.IEnumerable"/> (and is not a <see cref="string"/>), it is expanded into
        /// multiple <see cref="TypedParameter"/> instances with the same name and <see cref="RequestParameterType"/>.
        /// This supports repeatable parameters represented as <see cref="Google.Apis.Util.Repeatable{T}"/> (which is <see cref="System.Collections.IEnumerable"/>) and other
        /// enumerable values.
        /// </remarks>
        /// <param name="dictionary">
        /// A dictionary where the key is the parameter name and the value is a <see cref="ParameterValue"/> containing both
        /// the parameter type and raw value.
        /// </param>
        /// <returns>
        /// An enumerable of <see cref="TypedParameter"/> instances, with enumerable values expanded into repeated parameters.
        /// </returns>
        internal static IEnumerable<TypedParameter> ExpandParametersWithTypes(IDictionary<string, ParameterValue> dictionary)
        {
            foreach (var pair in dictionary)
            {
                var paramType = pair.Value.Type;
                var value = pair.Value.Value;
                var name = pair.Key;

                // Try parsing the value as an enumerable.
                var valueAsEnumerable = value as IEnumerable;
                if (!(value is string) && valueAsEnumerable != null)
                {
                    foreach (var elem in valueAsEnumerable)
                    {
                        yield return new TypedParameter(paramType, name, Utilities.ConvertToString(elem));
                    }
                }
                else
                {
                    // Otherwise just convert it to a string.
                    yield return new TypedParameter(paramType, name, Utilities.ConvertToString(value));
                }
            }
        }

        /// <summary>
        /// Iterates over all <see cref="Google.Apis.Util.RequestParameterAttribute"/> properties in the request
        /// object and invokes the specified action for each of them.
        /// </summary>
        /// <param name="request">A request object</param>
        /// <param name="action">An action to invoke which gets the parameter type, name and its value</param>
        private static void IterateParameters(object request, Action<RequestParameterType, string, object> action)
        {
            // Use ReflectionCache to avoid repeated reflection + attribute lookup on every call.
            foreach (var propertyWithAttribute in ReflectionCache.GetRequestParameterProperties(request.GetType()))
            {
                var property = propertyWithAttribute.Property;
                var attribute = propertyWithAttribute.Attribute;

                // Get the name of this parameter from the attribute, if it doesn't exist take a lower-case variant of
                // property name.
                string name = attribute.Name ?? property.Name.ToLowerInvariant();

                var propertyType = property.PropertyType;
                var value = property.GetValue(request, null);

                // Call action with the type name and value.
                if (propertyType.GetTypeInfo().IsValueType || value != null)
                {
                    if (attribute.Type == RequestParameterType.UserDefinedQueries)
                    {
                        if (typeof(IEnumerable<KeyValuePair<string, string>>).IsAssignableFrom(value.GetType()))
                        {
                            foreach (var pair in (IEnumerable<KeyValuePair<string, string>>)value)
                            {
                                action(RequestParameterType.Query, pair.Key, pair.Value);
                            }
                        }
                        else
                        {
                            Logger.Warning("Parameter marked with RequestParameterType.UserDefinedQueries attribute " +
                                "was not of type IEnumerable<KeyValuePair<string, string>> and will be skipped.");
                        }
                    }
                    else
                    {
                        action(attribute.Type, name, value);
                    }
                }
            }
        }
    }
}
