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

namespace Google.Apis.Json
{
    /// <summary>
    /// Class for serialization and deserialization of Json documents using the Newtonsoft Library
    /// </summary>
    public class NewtonsoftJsonSerializer : IJsonSerializer
    {
        private static readonly JsonSerializer newtonsoftSerializer;

        private static NewtonsoftJsonSerializer instance;

        /// <summary>
        /// A singleton instance of the Newtonsoft Json Serializer
        /// </summary>
        public static NewtonsoftJsonSerializer Instance
        {
            get
            {
                return (instance = instance ?? new NewtonsoftJsonSerializer());
            }
        }

        static NewtonsoftJsonSerializer()
        {
            // Initialize the Newtonsoft serializer
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            newtonsoftSerializer = JsonSerializer.Create(settings);
        }

        public void Serialize(object obj, Stream target)
        {
            using (var writer = new StreamWriter(target))
            {
                newtonsoftSerializer.Serialize(writer, obj);
            }
        }

        public string Serialize(object obj)
        {
            using (TextWriter tw = new StringWriter())
            {
                newtonsoftSerializer.Serialize(tw, obj);
                return tw.ToString();
            }
        }

        public T Deserialize<T>(string input)
        {
            return JsonConvert.DeserializeObject<T>(input);
        }

        public T Deserialize<T>(Stream input)
        {
            // Convert the json document into an objct
            using (StreamReader streamReader = new StreamReader(input))
            {
                return (T)newtonsoftSerializer.Deserialize(streamReader, typeof(T));
            }
        }
    }
}
