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
using System.Collections.Generic;
using Google.Apis.Json;

namespace Google.Apis.Discovery
{
    /// <summary>
    /// Base class for all objects that are part of the Discovery Service and a
    /// constructed by the IServiceFactory
    /// </summary>
    public abstract class ServiceObject
    {
        /// <summary>
        /// Construct this object with it's Factory.
        /// </summary>
        /// <param name="factory">The factory used to construct objects for this service</param>
        protected ServiceObject(IServiceFactory factory) { this.Factory = factory; }

        /// <summary>
        /// The factory used to construct objects for this service
        /// </summary>
        public IServiceFactory Factory { get; private set; }

        /// <summary>
        /// Helper method which takes a KeyValuePair from a JsonDictionary and
        /// constructs a Method from the data within.
        /// </summary>
        /// <param name="kvp">A KeyValuePair containing the name and data for this 
        /// portion of the service document. The key should be the name of the method,
        /// value should be a JsonDictionary describing the method.</param>
        /// <returns>An IMethod instance as defined by the json description.</returns>
        protected IMethod CreateMethod(KeyValuePair<string, object> kvp)
        {
            return Factory.CreateMethod(kvp.Key, kvp.Value as JsonDictionary);
        }

        /// <summary>
        /// Helper method which takes a KeyValuePair from a JsonDictionary and
        /// constructs a Resource from the data within.
        /// </summary>
        /// <param name="kvp">A KeyValuePair containing the name and data for this 
        /// portion of the service document. The key should be the name of the resource,
        /// value should be a JsonDictionary describing the resource.</param>
        /// <returns>An IResource instance as defined by the json description.</returns>
        protected IResource CreateResource(KeyValuePair<string, object> kvp)
        {
            return Factory.CreateResource(kvp.Key, kvp.Value as JsonDictionary);
        }

        /// <summary>
        /// Helper method which takes a KeyValuePair from a JsonDictionary and
        /// constructs a Parameter from the data within.
        /// </summary>
        /// <param name="kvp">A KeyValuePair containing the name and data for this 
        /// portion of the service document. The key should be the name of the parameter,
        /// value should be a JsonDictionary describing the parameter.</param>
        /// <returns>An IParameter instance as defined by the json description.</returns>
        protected IParameter CreateParameter(KeyValuePair<string, object> kvp)
        {
            return Factory.CreateParameter(kvp.Key, kvp.Value as JsonDictionary);
        }
    }

}
