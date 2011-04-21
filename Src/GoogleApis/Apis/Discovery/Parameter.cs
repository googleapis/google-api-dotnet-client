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
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Google.Apis.Json;
using Google.Apis.Requests;
using Google.Apis.Util;
using Google.Apis.Testing;

namespace Google.Apis.Discovery
{
    internal abstract class ParameterFactory
    {
        internal static IParameter GetParameter(DiscoveryVersion version, KeyValuePair<string, object> kvp)
        {
            switch (version)
            {
            case DiscoveryVersion.Version_0_1:
            case DiscoveryVersion.Version_0_2:
                return new BaseParameter(kvp);
            case DiscoveryVersion.Version_0_3:
                return new ParameterV0_3(kvp);
            default:
                throw new NotSupportedException("Unsuppored version of Discovery " + version.ToString());
            }
        }

        [VisibleForTestOnly]
        internal class ParameterV0_3 : BaseParameter
        {
            public ParameterV0_3(KeyValuePair<string, object> kvp)
                : base(kvp)
            { }

            public override string ParameterType
            {
                get { return this.information.GetValueAsNull("restParameterType") as string; }
            }
        }

        [VisibleForTestOnly]
        internal class BaseParameter : IParameter
        {
            protected readonly JsonDictionary information;

            public BaseParameter(KeyValuePair<string, object> kvp)
            {
                this.Name = kvp.Key;
                this.information = kvp.Value as JsonDictionary;
                if (this.information == null)
                    throw new ArgumentException("got no valid dictionary");
            }

            public string Name { get; private set; }

            public virtual string ParameterType
            {
                get { return this.information.GetValueAsNull(ServiceFactory.ParameterType) as string; }
            }

            public string Pattern
            {
                get { return this.information.GetValueAsNull(ServiceFactory.Pattern) as string; }
            }

            public bool Required
            {
                get { return (bool)(this.information.GetValueAsNull(ServiceFactory.Required) ?? (object)false); }
            }

            public string DefaultValue
            {
                get { return this.information.GetValueAsNull(ServiceFactory.DefaultValue) as string; }
            }

            public string ValueType
            {
                get { return this.information.GetValueAsNull(ServiceFactory.ValueType) as string; }
            }
            
            public string Description
            {
                get { return this.information.GetValueAsNull(ServiceFactory.Description) as string;}
            }
            
            public string Maximum 
            {
                get { return this.information.GetValueAsNull(ServiceFactory.Maximum) as string; }
            }

            public string Minimum 
            {
                get { return this.information.GetValueAsNull(ServiceFactory.Minimum) as string; }
            }

            public IEnumerable<string> Enum 
            {
                get 
                {
                    ArrayList list = this.information.GetValueAsNull("enum") as ArrayList;
                    if (list == null)
                    {
                        yield break;
                    }
                    
                    foreach(string s in list)
                    {
                        yield return s;
                    }
                    
                }
            }
            
        }
    }
}