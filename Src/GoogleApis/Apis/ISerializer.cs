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

namespace Google.Apis
{
    /// <summary>
    /// Interface for serialization and deserialization
    /// </summary>
    public interface ISerializer
    {
        /// <summary>
        /// Serializes the specified object into a Stream
        /// </summary>
        void Serialize(object obj, Stream target);

        /// <summary>
        /// Serializes the specified object into a string
        /// </summary>
        string Serialize(object obj);

        /// <summary>
        /// Deserializes the string into an object
        /// </summary>
        T Deserialize<T>(string input);

        /// <summary>
        /// Deserializes the stream into an object
        /// </summary>
        T Deserialize<T>(Stream input);
    }
}
