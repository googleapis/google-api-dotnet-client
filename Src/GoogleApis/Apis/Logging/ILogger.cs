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

namespace Google.Apis.Logging
{
    /// <summary>
    /// Describes a logging interface used for outputing errors/messages/debug info.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Defines whether debug output is logged or not.
        /// </summary>
        bool IsDebugEnabled { get; }

        /// <summary>
        /// Returns a logger which will be associated with the specified type.
        /// </summary>
        /// <param name="type">Type to which this logger belongs.</param>
        /// <returns>A type-associated logger.</returns>
        ILogger ForType(Type type);

        /// <summary>
        /// Returns a logger which will be associated with the specified type.
        /// </summary>
        /// <returns>A type-associated logger.</returns>
        ILogger ForType<T>();

        /// <summary>
        /// Logs an info message.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="formatArgs">String.Format arguments (if applicable).</param>
        void Info(string message, params object[] formatArgs);

        /// <summary>
        /// Logs a warning.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="formatArgs">String.Format arguments (if applicable).</param>
        void Warning(string message, params object[] formatArgs);

        /// <summary>
        /// Logs a debug message.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="formatArgs">String.Format arguments (if applicable).</param>
        void Debug(string message, params object[] formatArgs);

        /// <summary>
        /// Logs an error message resulting from an exception.
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="message">The message to log.</param>
        /// <param name="formatArgs">String.Format arguments (if applicable).</param>
        void Error(Exception exception, string message, params object[] formatArgs);

        /// <summary>
        /// Logs an error message
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="formatArgs">String.Format arguments (if applicable).</param>
        void Error(string message, params object[] formatArgs);
    }
}
