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
using System.Reflection;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Logging
{
    /// <summary>
    /// A logger implementation which makes use of the log4net library.
    /// </summary>
    /// <remarks>
    /// Not compatible with the .NET 3.5 Client Profile. Uses reflection to compile with the Client Profile set.
    /// </remarks>
    public sealed class Log4NetLogger : ILogger
    {
        private const string log4netAssemblyName = "log4net";
        private const string log4netLogManager = "log4net.LogManager";
        private const string log4netGetLoggerMethod = "GetLogger";

        private readonly Action<string> logInfo;
        private readonly Action<string> logDebug;
        private readonly Action<string> logWarning;
        private readonly Action<string> logError;
        private readonly Action<string,Exception> logErrorException;
        private readonly Func<bool> logIsDebugEnabled;
        
        private Log4NetLogger(object typeOrName)
        {
            // Create an ILog instance using reflection.
            Assembly log4net = LazyBinding.GetAssembly(log4netAssemblyName);
            object ILog = CreateILogInstance(log4net, typeOrName);
            
            // Get a set of function references.
            logInfo = LazyBinding.CreateMethodDelegate<Action<string>>(ILog, "Info", typeof(string));
            logDebug = LazyBinding.CreateMethodDelegate<Action<string>>(ILog, "Debug", typeof(string));
            logWarning = LazyBinding.CreateMethodDelegate<Action<string>>(ILog, "Warn", typeof(string));
            logError = LazyBinding.CreateMethodDelegate<Action<string>>(ILog, "Error", typeof(string));
            logErrorException = LazyBinding.CreateMethodDelegate<Action<string, Exception>>(
                ILog, "Error", typeof(string), typeof(Exception));
            logIsDebugEnabled = LazyBinding.CreatePropertyGetDelegate<bool>(ILog, "IsDebugEnabled");
        }
        
        /// <summary>
        /// Creates an instance of a ILog instance, created with the specified type or name as a constructor argument.
        /// </summary>
        [VisibleForTestOnly]
        internal static object CreateILogInstance(Assembly log4net, object typeOrName)
        {
            // Grab the LogManager.GetLogger() method.
            Type logManager = log4net.GetType(log4netLogManager);
            MethodInfo getLogger = logManager.GetMethod(log4netGetLoggerMethod, new[] { typeOrName.GetType() });

            // Invoke it and return the logger.
            object loggerInstance = getLogger.Invoke(null, new[] { typeOrName });
            loggerInstance.ThrowIfNull("ILog instance");
            return loggerInstance;
        }

        /// <summary>
        /// Creates a new default log4net logger.
        /// </summary>
        public Log4NetLogger() : this("google-api-dotnet-client") {}

        /// <summary>
        /// Creates a new log4net logger and associates it with the specified type.
        /// </summary>
        public Log4NetLogger(Type t) : this((object)t) { }

        public bool IsDebugEnabled
        {
            get { return logIsDebugEnabled(); }
        }

        public ILogger ForType(Type type)
        {
            return new Log4NetLogger(type);
        }

        public ILogger ForType<T>()
        {
            return new Log4NetLogger(typeof(T));
        }

        public void Info(string message, params object[] formatArgs)
        {
            logInfo(message.FormatString(formatArgs));
        }

        public void Warning(string message, params object[] formatArgs)
        {
            logWarning(message.FormatString(formatArgs));
        }

        public void Debug(string message, params object[] formatArgs)
        {
            logDebug(message.FormatString(formatArgs));
        }

        public void Error(Exception exception, string message, params object[] formatArgs)
        {
            logErrorException(message.FormatString(formatArgs), exception);
        }

        public void Error(string message, params object[] formatArgs)
        {
            logError(message.FormatString(formatArgs));
        }
    }
}
