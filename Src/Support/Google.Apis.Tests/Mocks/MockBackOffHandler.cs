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

using Google.Apis.Http;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Apis.Tests.Mocks
{
    /// <summary>Base mock back-off handler which contains a list of all waited time spans.</summary>
    public class MockBackOffHandler : BackOffHandler
    {
        /// <summary>A list of all the waited time spans.</summary>
        public List<TimeSpan> Waits { get; set; }

        /// <summary>Constructs a new back-off handler by the given back-off.</summary>
        public MockBackOffHandler(IBackOff backOff)
            : base(backOff)
        {
            Waits = new List<TimeSpan>();
        }

        /// <summary>Constructs a new back-off handler by the given initializer.</summary>
        public MockBackOffHandler(BackOffHandler.Initializer initializer)
            : base(initializer)
        {
            Waits = new List<TimeSpan>();
        }

        protected override Task Wait(TimeSpan ts, CancellationToken cancellationToken)
        {
            Waits.Add(ts);
            return Task.Delay(0);
        }
    }
}
