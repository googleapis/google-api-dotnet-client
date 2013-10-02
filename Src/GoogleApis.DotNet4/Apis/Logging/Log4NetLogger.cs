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

using log4net;

using Google.Apis.Util;

namespace Google.Apis.Logging
{
    /// <summary> A logger implementation which makes use of the log4net library. </summary>
    public sealed class Log4NetLogger : ILogger
    {
        private readonly ILog log;

        static Log4NetLogger()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        private Log4NetLogger(string name)
        {
            log = LogManager.GetLogger(name);
        }

        /// <summary> Creates a new default log4net logger. </summary>
        public Log4NetLogger() : this("google-api-dotnet-client") { }

        /// <summary> Creates a new log4net logger and associates it with the specified type. </summary>
        public Log4NetLogger(Type t) : this(t.FullName) { }

        public bool IsDebugEnabled
        {
            get { return log.IsDebugEnabled; }
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
            log.Info(string.Format(message, formatArgs));
        }

        public void Warning(string message, params object[] formatArgs)
        {
            log.Warn(string.Format(message, formatArgs));
        }

        public void Debug(string message, params object[] formatArgs)
        {
            log.Debug(string.Format(message, formatArgs));
        }

        public void Error(Exception exception, string message, params object[] formatArgs)
        {
            log.Error(string.Format(message, formatArgs), exception);
        }

        public void Error(string message, params object[] formatArgs)
        {
            log.Error(string.Format(message, formatArgs));
        }
    }
}
