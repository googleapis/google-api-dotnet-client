/*
Copyright 2011 Google Inc

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

using Google.Apis.Util;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;
using System.Linq;
#if !(NET45 || NETSTANDARD)
using Google.Compatibility;
#endif


namespace Google.Apis.Json
{
    /// <summary>
    /// A JSON converter which honers RFC 3339 and the serialized date is accepted by Google services.
    /// </summary>
    public class RFC3339DateTimeConverter : JsonConverter
    {
        public override bool CanRead => false;

        public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            throw new NotImplementedException("Unnecessary because CanRead is false.");
        }

        public override bool CanConvert(Type objectType) =>
            // Convert DateTime only.
            objectType == typeof(DateTime) || objectType == typeof(Nullable<DateTime>);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null)
            {
                DateTime date = (DateTime)value;
                serializer.Serialize(writer, Utilities.ConvertToRFC3339(date));
            }
        }
    }

    /// <summary>
    /// A JSON converter to write <c>null</c> literals into JSON when explicitly requested.
    /// </summary>
    public class ExplicitNullConverter : JsonConverter
    {
        /// <inheritdoc />
        public override bool CanRead => false;

        /// <inheritdoc />
        public override bool CanConvert(Type objectType) => objectType.GetTypeInfo().GetCustomAttributes(typeof(JsonExplicitNullAttribute), false).Any();

        /// <inheritdoc />
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException("Unnecessary because CanRead is false.");
        }

        /// <inheritdoc />
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => writer.WriteNull();
    }

    /// <summary>Class for serialization and deserialization of JSON documents using the Newtonsoft Library.</summary>
    public class NewtonsoftJsonSerializer : IJsonSerializer
    {
        private readonly JsonSerializerSettings settings;
        private readonly JsonSerializer serializer;

        /// <summary>The default instance of the Newtonsoft JSON Serializer, with default settings.</summary>
        public static NewtonsoftJsonSerializer Instance { get; } = new NewtonsoftJsonSerializer();

        /// <summary>
        /// Constructs a new instance with the default serialization settings, equivalent to <see cref="Instance"/>.
        /// </summary>
        public NewtonsoftJsonSerializer() : this(CreateDefaultSettings())
        {
        }

        /// <summary>
        /// Constructs a new instance with the given settings.
        /// </summary>
        /// <param name="settings">The settings to apply when serializing and deserializing. Must not be null.</param>
        public NewtonsoftJsonSerializer(JsonSerializerSettings settings)
        {
            Utilities.ThrowIfNull(settings, nameof(settings));
            this.settings = settings;
            serializer = JsonSerializer.Create(settings);
        }

        /// <summary>
        /// Creates a new instance of <see cref="JsonSerializerSettings"/> with the same behavior
        /// as the ones used in <see cref="Instance"/>. This method is expected to be used to construct
        /// settings which are then passed to <see cref="NewtonsoftJsonSerializer.NewtonsoftJsonSerializer(JsonSerializerSettings)"/>.
        /// </summary>
        /// <returns>A new set of default settings.</returns>
        public static JsonSerializerSettings CreateDefaultSettings() =>
            new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Converters = { new RFC3339DateTimeConverter(), new ExplicitNullConverter() }
            };

        public string Format => "json";

        public void Serialize(object obj, Stream target)
        {
            using (var writer = new StreamWriter(target))
            {
                if (obj == null)
                {
                    obj = string.Empty;
                }
                serializer.Serialize(writer, obj);
            }
        }

        public string Serialize(object obj)
        {
            using (TextWriter tw = new StringWriter())
            {
                if (obj == null)
                {
                    obj = string.Empty;
                }
                serializer.Serialize(tw, obj);
                return tw.ToString();
            }
        }

        public T Deserialize<T>(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return default(T);
            }
            return JsonConvert.DeserializeObject<T>(input, settings);
        }

        public object Deserialize(string input, Type type)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }
            return JsonConvert.DeserializeObject(input, type, settings);
        }

        public T Deserialize<T>(Stream input)
        {
            // Convert the JSON document into an object.
            using (StreamReader streamReader = new StreamReader(input))
            {
                return (T)serializer.Deserialize(streamReader, typeof(T));
            }
        }
    }
}
