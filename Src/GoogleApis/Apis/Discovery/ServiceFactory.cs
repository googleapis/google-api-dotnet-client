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
        /// Creates and returns the service this factory can create.
        /// </summary>
        IService GetService();
    }

    /// <summary>
    /// A marker interface, different versions of discovery use different 
    /// IFactoryParameters, you will need to pass in one that matches the
    /// version of discovery you use.
    /// </summary>
    /// <seealso cref="FactoryParmeterV0_3"/>
    public interface IFactoryParameter {}

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

        internal const string ParameterType = "location";
        internal const string Pattern = "pattern";
        internal const string Required = "required";
        internal const string DefaultValue = "default";
        internal const string ValueType = "type";
        internal const string Description = "description";
        internal const string Maximum = "maximum";
        internal const string Minimum = "minimum";

        /// <summary>
        /// Creates a service factory for the discovery version requested, with the given parameters
        /// </summary>
        /// <param name="discovery">A stream which contains information about the service to construct</param>
        /// <param name="version">The discovery version to use</param>
        /// <param name="parameters">
        /// A set of (optional) factory parameters used to construct the service. 
        /// If this parameter is null, then a default set of FactoryParameters is created
        /// </param>
        public static IServiceFactory CreateServiceFactory(Stream discovery,
                                                           DiscoveryVersion version,
                                                           IFactoryParameter parameters)
        {
            discovery.ThrowIfNull("discovery");
            version.ThrowIfNull("version");

            JsonDictionary information = JsonReader.Parse(discovery) as JsonDictionary;

            switch (version)
            {
                case DiscoveryVersion.Version_0_3:
                    return new ServiceFactoryDiscoveryV0_3(
                        information, (FactoryParameterV0_3) (parameters ?? new FactoryParameterV0_3()));
                case DiscoveryVersion.Version_1_0:
                    return new ServiceFactoryDiscoveryV1_0(
                        information, (FactoryParameterV1_0) (parameters ?? new FactoryParameterV1_0()));
                default:
                    throw new NotSupportedException("The Version " + version + " is not supported");
            }
        }

        /// <summary>
        /// Creates a service factory for the discovery version requested
        /// </summary>
        /// <param name="discovery">A stream which contains information about the service to construct</param>
        /// <param name="version">The discovery version to use</param>
        public static IServiceFactory CreateServiceFactory(Stream discovery, DiscoveryVersion version)
        {
            return CreateServiceFactory(discovery, version, null);
        }
    }
}