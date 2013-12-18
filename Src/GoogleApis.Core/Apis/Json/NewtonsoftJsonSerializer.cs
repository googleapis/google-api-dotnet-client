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

using System;
using System.Globalization;
using System.IO;

using Newtonsoft.Json;

using Google.Apis.Util;

namespace Google.Apis.Json
{
    /// <summary>
    /// A JSON converter which honers RFC 3339 and the serialized date is accepted by Google services.
    /// </summary>
    public class RFC3339DateTimeConverter : JsonConverter
    {
        public override bool CanRead
        {
            get { return false; }
        }

        public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            throw new NotImplementedException("Unnecessary because CanRead is false.");
        }

        public override bool CanConvert(Type objectType)
        {
            // Convert DateTime only.
            return objectType == typeof(DateTime) || objectType == typeof(Nullable<DateTime>);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null)
            {
                DateTime date = (DateTime)value;
                serializer.Serialize(writer, Utilities.ConvertToRFC3339(date));
            }
        }
    }

    /// <summary>Class for serialization and deserialization of JSON documents using the Newtonsoft Library.</summary>
    public class NewtonsoftJsonSerializer : IJsonSerializer
    {
        private static readonly JsonSerializer newtonsoftSerializer;

        private static NewtonsoftJsonSerializer instance;

        /// <summary>A singleton instance of the Newtonsoft JSON Serializer.</summary>
        public static NewtonsoftJsonSerializer Instance
        {
            get
            {
                return (instance = instance ?? new NewtonsoftJsonSerializer());
            }
        }

        static NewtonsoftJsonSerializer()
        {
            // Initialize the Newtonsoft serializer.
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.Converters.Add(new RFC3339DateTimeConverter());
            newtonsoftSerializer = JsonSerializer.Create(settings);
        }

        public string Format
        {
            get { return "json"; }
        }

        public void Serialize(object obj, Stream target)
        {
            using (var writer = new StreamWriter(target))
            {
                if (obj == null)
                {
                    obj = string.Empty;
                }
                newtonsoftSerializer.Serialize(writer, obj);
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
                newtonsoftSerializer.Serialize(tw, obj);
                return tw.ToString();
            }
        }

        public T Deserialize<T>(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return default(T);
            }
            return JsonConvert.DeserializeObject<T>(input);
        }

        public object Deserialize(string input, Type type)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }
            return JsonConvert.DeserializeObject(input, type);
        }

        public T Deserialize<T>(Stream input)
        {
            // Convert the JSON document into an object.
            using (StreamReader streamReader = new StreamReader(input))
            {
                return (T)newtonsoftSerializer.Deserialize(streamReader, typeof(T));
            }
        }
    }
}
