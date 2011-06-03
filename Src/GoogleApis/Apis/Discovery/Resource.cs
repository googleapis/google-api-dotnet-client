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
using Google.Apis.Util;
using log4net;

namespace Google.Apis.Discovery
{
    /// <summary>
    /// IResource represents one resource as difined in a Google Api Discovery Document.
    /// It can contain more resources and/or methods
    /// </summary>
    /// <seealso cref="IResourceContainer"/>
    /// <seealso cref="IMethod"/>
    public interface IResource : IResourceContainer
    {
        Dictionary<string, IMethod> Methods { get; }
    }

    #region Base Resource

    /// <summary>
    /// Abstract implementation of a resource
    /// </summary>
    internal abstract class BaseResource : IResource
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(IResource));
        private readonly JsonDictionary information;
        private Dictionary<string, IMethod> methods;
        private Dictionary<string, IResource> resources;

        /// <summary>
        /// Creates a new resource for the specified discovery version with the specified name and json dictionary
        /// </summary>
        internal BaseResource(DiscoveryVersion version, KeyValuePair<string, object> kvp)
        {
            kvp.ThrowIfNull("kvp");

            DiscoveryVersion = version;
            logger.DebugFormat("Constructing Resource [{0}]", kvp.Key);
            Name = kvp.Key;
            information = kvp.Value as JsonDictionary;
            if (information == null)
            {
                throw new ArgumentException("got no valid dictionary");
            }
        }

        /// <summary>
        /// The discovery version used for creating this resource
        /// </summary>
        internal DiscoveryVersion DiscoveryVersion { get; private set; }

        #region IResource Members

        public string Name { get; set; }

        public Dictionary<string, IMethod> Methods
        {
            get
            {
                if (methods == null)
                {
                    methods = FetchMethods();
                }
                return methods;
            }
        }


        public IDictionary<string, IResource> Resources
        {
            get
            {
                if (resources == null)
                {
                    resources = FetchResources();
                }
                return resources;
            }
        }

        #endregion

        private Dictionary<string, IMethod> FetchMethods()
        {
            if (information.ContainsKey(ServiceFactory.Methods) == false)
            {
                return new Dictionary<string, IMethod>(0); // return empty, not null.
            }

            JsonDictionary js = information[ServiceFactory.Methods] as JsonDictionary;
            if (js == null)
            {
                return new Dictionary<string, IMethod>(0); // return empty, not null.
            }

            var methods = new Dictionary<string, IMethod>();
            foreach (KeyValuePair<string, object> kvp in js)
            {
                IMethod m = CreateMethod(kvp);
                methods.Add(kvp.Key, m);
            }
            return methods;
        }


        private Dictionary<string, IResource> FetchResources()
        {
            if (information.ContainsKey(ServiceFactory.Resources) == false)
            {
                return new Dictionary<string, IResource>(0); // return empty, not null.
            }

            JsonDictionary js = information[ServiceFactory.Resources] as JsonDictionary;
            if (js == null)
            {
                return new Dictionary<string, IResource>(0); // return empty, not null.
            }

            var resources = new Dictionary<string, IResource>();
            foreach (KeyValuePair<string, object> kvp in js)
            {
                IResource r = CreateResource(kvp);
                resources.Add(kvp.Key, r);
            }
            return resources;
        }

        protected abstract IResource CreateResource(KeyValuePair<string, object> kvp);
        protected abstract IMethod CreateMethod(KeyValuePair<string, object> kvp);
    }

    #endregion

    #region ResourceV1_0

    internal class ResourceV1_0 : BaseResource
    {
        internal ResourceV1_0(KeyValuePair<string, object> kvp) : base(DiscoveryVersion.Version_1_0, kvp) {}

        protected override IMethod CreateMethod(KeyValuePair<string, object> kvp)
        {
            return new MethodV1_0(DiscoveryVersion, kvp);
        }

        protected override IResource CreateResource(KeyValuePair<string, object> kvp)
        {
            return new ResourceV1_0(kvp);
        }
    }

    #endregion

    #region ResourceV0_3

    /// <summary>
    /// Represents a Resource as defined by Discovery V0.3
    /// </summary>
    internal class ResourceV0_3 : BaseResource
    {
        internal ResourceV0_3(KeyValuePair<string, object> kvp) : base(DiscoveryVersion.Version_1_0, kvp) { }

        protected override IMethod CreateMethod(KeyValuePair<string, object> kvp)
        {
            return new MethodV0_3(DiscoveryVersion, kvp);
        }

        protected override IResource CreateResource(KeyValuePair<string, object> kvp)
        {
            return new ResourceV0_3(kvp);
        }
    }

    #endregion
}