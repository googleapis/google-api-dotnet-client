/*
Copyright 2010 Google Inc

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
using Google.Apis.Discovery;

namespace Google
{
    /// <summary>
    /// Represents an exception thrown by an API Service
    /// </summary>
    public class GoogleApiException : ApplicationException
    {
        /// <summary>
        /// The service that has thrown the exception
        /// </summary>
        public IService Service { get; protected set; }

        /// <summary>
        /// Creates an API Service exception
        /// </summary>
        public GoogleApiException(IService service, string message, Exception inner) : base(message, inner)
        {
            Service = service;
        }

        /// <summary>
        /// Creates an API Service exception
        /// </summary>
        public GoogleApiException(IService service, string message) : this(service, message, null) { }

        public override string ToString()
        {
            return string.Format("The service {1} has thrown an exception: {0}", base.ToString(), Service.Name);
        }
    }
}
