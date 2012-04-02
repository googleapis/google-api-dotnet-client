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
using System.IO;
using Google.Apis.Json;
using Google.Apis.Util;

namespace Google.Apis.Discovery
{
    /// <summary>
    /// A IServiceFactory will return the IService for the specified version.
    /// you should use ServiceFactory.CreateServiceFactory to get an
    /// implementation of this interface for the given version of discovery you use.
    /// </summary>
    /// <seealso cref="ServiceFactory"/>
    public interface IServiceFactory
    {
        /// <summary>
        /// Creates the service from a JsonDictionary.
        /// </summary>
        /// <param name="dictionary">A JsonDictionary describing the service.</param>
        /// <param name="param">Parameters to the service construction (if needed).</param>
        /// <returns></returns>
        IService CreateService(JsonDictionary dictionary, FactoryParameters param);

        /// <summary>
        /// Creates an IMethod from a JsonDictionary description.
        /// </summary>
        /// <param name="name">The name of the method.</param>
        /// <param name="dictionary">A JsonDictionary describing the method.</param>
        /// <returns></returns>
        IMethod CreateMethod(string name, JsonDictionary dictionary);

        /// <summary>
        /// Creates an IParameter from a JsonDictionary description.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="dictionary">A JsonDictionary describing the parameter.</param>
        IParameter CreateParameter(string name, JsonDictionary dictionary);
        
        /// <summary>
        /// Creates an IResource from a JsonDictionary description.
        /// </summary>
        /// <param name="name">The name of the resource.</param>
        /// <param name="dictionary">A JsonDictionary describing the resource.</param>
        IResource CreateResource(string name, JsonDictionary dictionary);

        /// <summary>
        /// The version of discovery represented by this factory.
        /// </summary>
        DiscoveryVersion Version { get; }
    }

    /// <summary>
    /// An abstract and static factory which can be used to generate
    /// the individual service factory required for a specific discovery version
    /// </summary>
    public abstract class ServiceFactory
    {
        internal const string VersionInfo = "versionInfo";

        internal const string RpcUrl = "rpcUrl";
        internal const string Resources = "resources";
        internal const string Schemas = "schemas";
        internal const string Methods = "methods";
        internal const string RpcName = "rpcName";
        internal const string HttpMethod = "httpMethod";
        internal const string Parameters = "parameters";
        internal const string ParameterOrder = "parameterOrder";
        internal const string ResponseType = "response";
        internal const string RequestType = "request";
        internal const string MediaUpload = "mediaUpload";

        internal const string ParameterType = "location";
        internal const string Pattern = "pattern";
        internal const string Required = "required";
        internal const string DefaultValue = "default";
        internal const string ValueType = "type";
        internal const string Description = "description";
        internal const string Maximum = "maximum";
        internal const string Minimum = "minimum";

        /// <summary>
        /// The Service Factory for the current default version of discovery (Currently Version 1.0)
        /// </summary>
        public static IServiceFactory Default
        {
            get
            {
                return ServiceFactory.Get(DiscoveryVersion.Version_1_0);
            }
        }

        /// <summary>
        /// Get an IServiceFactory instance for a specific version of the discovery service.
        /// </summary>
        /// <remarks>
        /// Currently supports discovery versions 0.3 and 1.0
        /// </remarks>
        public static IServiceFactory Get(DiscoveryVersion version)
        {
            switch (version)
            {
                case DiscoveryVersion.Version_0_3:
                    return ServiceFactoryDiscoveryV0_3.GetInstance();
                case DiscoveryVersion.Version_1_0:
                    return ServiceFactoryDiscoveryV1_0.GetInstance();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}