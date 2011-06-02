using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Google.Apis
{
    /// <summary>
    /// Interface for serialization and deserialization
    /// </summary>
    public interface ISerializer
    {
        /// <summary>
        /// Serializes an object into a json representation
        /// </summary>
        void Serialize(object obj, Stream target);

        /// <summary>
        /// Serializes an object into a json representation
        /// </summary>
        string Serialize(object obj);

        /// <summary>
        /// Deserializes the stream into a .NET object
        /// </summary>
        T Deserialize<T>(string input);

        /// <summary>
        /// Deserializes the stream into a .NET object
        /// </summary>
        T Deserialize<T>(Stream input);
    }
}
