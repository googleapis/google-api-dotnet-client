/*
Copyright 2013 Google Inc

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
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Google.Apis.Utils
{
    /// <summary>Extension methods to <seealso cref="System.Diagnostics.TraceSource"/>.</summary>
    public static class TraceExtensions
    {
        /// <summary>Traces the event using the current thread id.</summary>
        internal static void TraceEvent(this TraceSource trace, TraceEventType type, string msg, params object[] args)
        {
            trace.TraceEvent(type, Thread.CurrentThread.ManagedThreadId, msg, args);
        }
    }
}
