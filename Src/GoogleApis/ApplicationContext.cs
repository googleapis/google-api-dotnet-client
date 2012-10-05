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
using Google.Apis.Logging;

namespace Google
{
    /// <summary>
    /// Class defining the context in which this library is run.
    /// Allows to set up custom loggers and other bindings.
    /// </summary>
    public static class ApplicationContext
    {
        private static ILogger logger;

        /// <summary>
        /// Returns the logger used within this ApplicationContext.
        /// </summary>
        /// <remarks>Will create a Log4NetLogger if no logger was registered previously</remarks>
        public static ILogger Logger
        {
            get
            {
                // Register the default null-logger if no other one was set.
                return logger ?? (logger = new NullLogger());
            }
        }

        /// <summary>
        /// Registers a logger with this ApplicationContext.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown if a logger was already registered.</exception>
        public static void RegisterLogger(ILogger loggerToRegister)
        {
            if (logger != null && !(logger is NullLogger))
            {
                throw new InvalidOperationException("A logger was already registered with this context.");
            }
            logger = loggerToRegister;
        }
    }
}
