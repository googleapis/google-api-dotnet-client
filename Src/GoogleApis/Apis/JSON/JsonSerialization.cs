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

using System.IO;
using Newtonsoft.Json;

namespace Google.Apis.JSON
{
    /// <summary>
    /// Class for serialization and deserialization of Json documents
    /// </summary>
    public static class JsonSerialization
    {
        private static readonly JsonSerializer newtonsoftSerializer;

        static JsonSerialization()
        {
            // Initialize the Newtonsoft serializer
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            newtonsoftSerializer = JsonSerializer.Create(settings);
        }

        /// <summary>
        /// Serializes an object into a json representation
        /// </summary>
        public static string Serialize(object obj)
        {
            using (TextWriter tw = new StringWriter())
            {
                newtonsoftSerializer.Serialize(tw, obj);
                return tw.ToString();
            }
        }

        /// <summary>
        /// Deserializes the stream into a .NET object
        /// </summary>
        public static T Deserialize<T>(string input)
        {
            // Convert the json document into an objct
            return JsonConvert.DeserializeObject<T>(input);
        }

        /// <summary>
        /// Deserializes the stream into a .NET object
        /// </summary>
        public static T Deserialize<T>(Stream input)
        {
            // Convert the json document into an objct
            using (StreamReader streamReader = new StreamReader(input))
                return (T) newtonsoftSerializer.Deserialize(streamReader, typeof(T));
        }
    }
}
