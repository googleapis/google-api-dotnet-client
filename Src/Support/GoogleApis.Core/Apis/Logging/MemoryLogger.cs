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
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Google.Apis.Logging
{
    /// <summary>
    /// A logger than logs to an in-memory buffer.
    /// Generally for use during tests.
    /// </summary>
    public sealed class MemoryLogger : BaseLogger, ILogger
    {
        /// <summary>
        /// Construct a <see cref="MemoryLogger"/>. 
        /// </summary>
        /// <param name="minimumLogLevel">Logging will be enabled at this level and all higher levels.</param>
        /// <param name="maximumEntryCount">The maximum number of log entries. Further log entries will be silently discarded.</param>
        /// <param name="clock">Optional <see cref="IClock"/>; will use the system clock if <c>null</c>.</param>
        public MemoryLogger(LogLevel minimumLogLevel, int maximumEntryCount = 1000, IClock clock = null) :
            this(minimumLogLevel, maximumEntryCount, clock, new List<string>(), null) { }

        private MemoryLogger(LogLevel minimumLogLevel, int maximumEntryCount, IClock clock, List<string> logEntries, Type forType) : base(minimumLogLevel, clock, forType)
        {
            _logEntries = logEntries;
            LogEntries = new ReadOnlyCollection<string>(_logEntries);
            _maximumEntryCount = maximumEntryCount;
        }

        private readonly int _maximumEntryCount;

        // This list is shared between all derived MemoryLogger instances
        private readonly List<string> _logEntries;

        /// <summary>
        /// The list of log entries.
        /// </summary>
        public IList<string> LogEntries { get; }

        /// <inheritdoc/>
        protected override ILogger BuildNewLogger(Type type) => new MemoryLogger(MinimumLogLevel, _maximumEntryCount, Clock, _logEntries, type);

        /// <inheritdoc/>
        protected override void Log(LogLevel logLevel, string formattedMessage)
        {
            lock (_logEntries)
            {
                if (_logEntries.Count < _maximumEntryCount)
                {
                    _logEntries.Add(formattedMessage);
                }
            }
        }

    }
}
