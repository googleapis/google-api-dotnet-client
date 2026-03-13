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

using Google.Apis.Logging;
using System;

namespace Google
{
    /// <summary>Defines the context in which this library runs. It allows setting up custom loggers and performance options.</summary>
    public static class ApplicationContext
    {
        private static ILogger logger;

        // For testing
        internal static void Reset()
        {
            logger = null;
            EnableReflectionCache = false;
        }

        /// <summary>
        /// Gets or sets whether to enable reflection result caching for request parameter properties.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When enabled, <see cref="System.Reflection.PropertyInfo"/> lookups for request parameter
        /// properties are cached per request type, eliminating repeated reflection overhead.
        /// </para>
        /// <para>
        /// Default is <c>false</c>. Set to <c>true</c> early in application startup before making
        /// any API requests. This setting is intended for applications that make many requests and
        /// where reflection overhead has been identified as a bottleneck.
        /// </para>
        /// </remarks>
        public static bool EnableReflectionCache { get; set; }

        /// <summary>Returns the logger used within this application context.</summary>
        /// <remarks>It creates a <see cref="NullLogger"/> if no logger was registered previously</remarks>
        public static ILogger Logger
        {
            get
            {
                // Register the default null-logger if no other one was set.
                return logger ?? (logger = new NullLogger());
            }
        }

        /// <summary>Registers a logger with this application context.</summary>
        /// <exception cref="InvalidOperationException">Thrown if a logger was already registered.</exception>
        public static void RegisterLogger(ILogger loggerToRegister)
        {
            // TODO(peleyal): Reconsider why the library should contain only one logger. Also consider using Tracing!
            if (logger != null && !(logger is NullLogger))
            {
                throw new InvalidOperationException("A logger was already registered with this context.");
            }
            logger = loggerToRegister;
        }
    }
}
