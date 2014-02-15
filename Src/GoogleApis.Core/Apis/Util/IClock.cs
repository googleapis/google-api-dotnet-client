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

namespace Google.Apis.Util
{
    /// <summary>Clock wrapper for getting the current time.</summary>
    public interface IClock
    {
        /// <summary>
        /// Gets a <see cref="System.DateTime"/> object that is set to the current date and time on this computer, 
        /// expressed as the local time.
        /// </summary>
        DateTime Now { get; }

        /// <summary>
        /// Gets a <see cref="System.DateTime"/> object that is set to the current date and time on this computer, 
        /// expressed as UTC time.
        /// </summary>
        DateTime UtcNow { get; }
    }

    /// <summary>A default clock implementation that wraps the <see cref="System.DateTime.Now"/> property.</summary>
    public class SystemClock : IClock
    {
        /// <summary>Constructs a new system clock.</summary>
        protected SystemClock() { }

        /// <summary>The default instance.</summary>
        public static readonly IClock Default = new SystemClock();

        public DateTime Now
        {
            get { return DateTime.Now; }
        }

        public DateTime UtcNow
        {
            get { return DateTime.UtcNow; }
        }
    }
}
