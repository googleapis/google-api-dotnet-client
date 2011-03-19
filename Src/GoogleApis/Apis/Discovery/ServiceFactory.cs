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
using System.Text;

using Google.Apis.Json;
using Google.Apis.Testing;

namespace Google.Apis.Discovery 
{
    public interface IServiceFactory
    {
        IService GetService(string version);

        string[] GetVersions();
    }
    
    public interface IFactoryParameter
    {
    }
    
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
    
        internal const string ParameterType = "parameterType";
        internal const string Pattern = "pattern";
        internal const string Required = "required";
        internal const string DefaultValue = "defaultValue";
        internal const string ValueType = "valueType";

        public static IServiceFactory CreateServiceFactory(Stream discovery, DiscoveryVersion version, IFactoryParameter param)
        {
            JsonDictionary information = JsonReader.Parse(discovery) as JsonDictionary;
            
            switch(version){
                case DiscoveryVersion.Version_0_1:
                    return new ServiceFactoryDiscoveryV0_1(information);
                case DiscoveryVersion.Version_0_2:
                    return new ServiceFactoryDiscoveryV0_2(information, (FactoryParameterV0_2)param);
                case DiscoveryVersion.Version_0_3:
                    return new ServiceFactoryDiscoveryV0_3(information, (FactoryParameterV0_3)param);
                default:
                    throw new NotSupportedException("The Version "+version +" is not supported");
            }
        }
    }
}
