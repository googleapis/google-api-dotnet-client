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
using System;
using System.Globalization;

namespace Google.Apis.Logging
{
    /// <summary>
    /// An abstract base logger, upon which real loggers may be built.
    /// </summary>
    public abstract class BaseLogger : ILogger
    {
        // Does not match gRPC datetime log format, which is "MMdd HH:mm:ss.ffffff"
        private const string DateTimeFormatString = "yyyy-MM-dd HH:mm:ss.ffffff";

        /// <summary>
        /// Construct a <see cref="BaseLogger"/>. 
        /// </summary>
        /// <param name="minimumLogLevel">Logging will be enabled at this level and all higher levels.</param>
        /// <param name="clock">The <see cref="IClock"/> to use to timestamp log entries.</param>
        /// <param name="forType">The type from which entries are being logged. May be <c>null</c>.</param>
        protected BaseLogger(LogLevel minimumLogLevel, IClock clock, Type forType)
        {
            MinimumLogLevel = minimumLogLevel;
            IsDebugEnabled = minimumLogLevel <= LogLevel.Debug;
            IsInfoEnabled = minimumLogLevel <= LogLevel.Info;
            IsWarningEnabled = minimumLogLevel <= LogLevel.Warning;
            IsErrorEnabled = minimumLogLevel <= LogLevel.Error;
            Clock = clock ?? SystemClock.Default;
            LoggerForType = forType;
            if (forType != null)
            {
                var namespaceStr = forType.Namespace ?? "";
                if (namespaceStr.Length > 0)
                {
                    namespaceStr += ".";
                }
                _loggerForTypeString = namespaceStr + forType.Name + " ";
            }
            else
            {
                _loggerForTypeString = "";
            }
        }

        private readonly string _loggerForTypeString;

        /// <summary>
        /// The <see cref="IClock"/> being used to timestamp log entries. 
        /// </summary>
        public IClock Clock { get; }

        /// <summary>
        /// The type from which entries are being logged. May be <c>null</c>.
        /// </summary>
        public Type LoggerForType { get; }

        /// <summary>
        /// Logging is enabled at this level and all higher levels.
        /// </summary>
        public LogLevel MinimumLogLevel { get; }

        /// <summary>
        /// Is Debug level logging enabled?
        /// </summary>
        public bool IsDebugEnabled { get; }

        /// <summary>
        /// Is info level logging enabled?
        /// </summary>
        public bool IsInfoEnabled { get; }

        /// <summary>
        /// Is warning level logging enabled?
        /// </summary>
        public bool IsWarningEnabled { get; }

        /// <summary>
        /// Is error level logging enabled?
        /// </summary>
        public bool IsErrorEnabled { get; }

        /// <summary>
        /// Build a new logger of the derived concrete type, for use to log from the specified type.
        /// </summary>
        /// <param name="type">The type from which entries are being logged.</param>
        /// <returns>A new <see cref="ILogger"/> instance, logging from the specified type.</returns>
        protected abstract ILogger BuildNewLogger(Type type);

        /// <inheritdoc/>
        public ILogger ForType<T>() => ForType(typeof(T));

        /// <inheritdoc/>
        public ILogger ForType(Type type) => type == LoggerForType ? this : BuildNewLogger(type);

        /// <summary>
        /// Perform the actual logging.
        /// </summary>
        /// <param name="logLevel">The <see cref="LogLevel"/> of this log entry.</param>
        /// <param name="formattedMessage">The fully formatted log message, ready for logging.</param>
        protected abstract void Log(LogLevel logLevel, string formattedMessage);

        private string FormatLogEntry(string severityString, string message, params object[] formatArgs)
        {
            var msg = string.Format(message, formatArgs);
            var when = Clock.UtcNow.ToString(DateTimeFormatString, CultureInfo.InvariantCulture);
            // Matches gRPC log format
            return $"{severityString}{when} {_loggerForTypeString}{msg}";
        }

        /// <inheritdoc/>
        public void Debug(string message, params object[] formatArgs)
        {
            if (IsDebugEnabled)
            {
                Log(LogLevel.Debug, FormatLogEntry("D", message, formatArgs));
            }
        }

        /// <inheritdoc/>
        public void Info(string message, params object[] formatArgs)
        {
            if (IsInfoEnabled)
            {
                Log(LogLevel.Info, FormatLogEntry("I", message, formatArgs));
            }
        }

        /// <inheritdoc/>
        public void Warning(string message, params object[] formatArgs)
        {
            if (IsWarningEnabled)
            {
                Log(LogLevel.Warning, FormatLogEntry("W", message, formatArgs));
            }
        }

        /// <inheritdoc/>
        public void Error(Exception exception, string message, params object[] formatArgs)
        {
            if (IsErrorEnabled)
            {
                Log(LogLevel.Error, $"{FormatLogEntry("E", message, formatArgs)} {exception}");
            }
        }

        /// <inheritdoc/>
        public void Error(string message, params object[] formatArgs)
        {
            if (IsErrorEnabled)
            {
                Log(LogLevel.Error, FormatLogEntry("E", message, formatArgs));
            }
        }

    }
}
