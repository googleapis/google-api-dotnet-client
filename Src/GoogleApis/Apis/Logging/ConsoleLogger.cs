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

#if !SILVERLIGHT

using System;
using System.Diagnostics;
using System.IO;
using Google.Apis.Util;

namespace Google.Apis.Logging
{
    /// <summary>
    /// Defines a logger which sends the output to the default console output.
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        private static readonly Stopwatch ElapsedTime = new Stopwatch();

        static ConsoleLogger()
        {
            // Time is shared between all created ConsoleLoggers.
            ElapsedTime.Start();
        }

        /// <summary>
        /// Creates a new logger with the specified name.
        /// </summary>
        public ConsoleLogger(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Creates a new default ConsoleLogger.
        /// </summary>
        public ConsoleLogger() : this(".NET Client API") {}

        private ConsoleLogger(Type boundType) : this(boundType.Name) {}

        /// <summary>
        /// The name of this logger.
        /// </summary>
        public string Name { get; private set; }

        #region ILogger Members

        public bool IsDebugEnabled { get; set; }

        public ILogger ForType(Type type)
        {
            return new ConsoleLogger(type);
        }

        public ILogger ForType<T>()
        {
            return ForType(typeof(T));
        }

        public void Info(string message, params object[] formatArgs)
        {
            Log(Console.Out, "Info", ConsoleColor.White, message, formatArgs);
        }

        public void Warning(string message, params object[] formatArgs)
        {
            Log(Console.Out, "Warn", ConsoleColor.Yellow, message, formatArgs);
        }

        public void Debug(string message, params object[] formatArgs)
        {
            Log(Console.Out, "Debug", ConsoleColor.Gray, message, formatArgs);
        }

        public void Error(Exception exception, string message, params object[] formatArgs)
        {
            string msg = message + Environment.NewLine + exception;
            Log(Console.Error, "Error", ConsoleColor.DarkRed, msg, formatArgs);
        }

        public void Error(string message, params object[] formatArgs)
        {
            Log(Console.Error, "Error", ConsoleColor.Red, message, formatArgs);
        }

        #endregion

        private void Log(TextWriter destination,
                         string category,
                         ConsoleColor color,
                         string message,
                         params object[] formatArgs)
        {
            Console.ForegroundColor = color;
            string msg = message.FormatString(formatArgs);
            destination.WriteLine("({0}) {1} [{2}]: {3}".FormatString(ElapsedTime.Elapsed, Name, category, msg));
        }
    }
}

#endif