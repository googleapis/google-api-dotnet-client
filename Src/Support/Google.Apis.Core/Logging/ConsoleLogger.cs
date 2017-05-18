/*
Copyright 2017 Google Inc

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

namespace Google.Apis.Logging
{
    /// <summary>
    /// A logger than logs to StdError or StdOut.
    /// </summary>
    public sealed class ConsoleLogger : BaseLogger, ILogger
    {
        /// <summary>
        /// Construct a <see cref="ConsoleLogger"/>. 
        /// </summary>
        /// <param name="minimumLogLevel">Logging will be enabled at this level and all higher levels.</param>
        /// <param name="logToStdOut"><c>true</c> to log to StdOut, defaults to logging to StdError.</param>
        /// <param name="clock">Optional <see cref="IClock"/>; will use the system clock if <c>null</c>.</param>
        public ConsoleLogger(LogLevel minimumLogLevel, bool logToStdOut = false, IClock clock = null) : this(minimumLogLevel, logToStdOut, clock, null) { }

        private ConsoleLogger(LogLevel minimumLogLevel, bool logToStdOut, IClock clock, Type forType) : base(minimumLogLevel, clock, forType)
        {
            LogToStdOut = logToStdOut;
        }

        /// <summary>
        /// <c>false</c> to log to StdError; <c>true</c> to log to StdOut.
        /// </summary>
        public bool LogToStdOut { get; }

        /// <inheritdoc/>
        protected override ILogger BuildNewLogger(Type type) => new ConsoleLogger(MinimumLogLevel, LogToStdOut, Clock, type);

        /// <inheritdoc/>
        protected override void Log(LogLevel logLevel, string formattedMessage)
        {
            (LogToStdOut ? Console.Out : Console.Error).WriteLine(formattedMessage);
        }
    }
}
