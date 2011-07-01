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
using Google.Apis.Json;
using Google.Apis.Util;
using Google.Apis.Testing;

namespace Google.Apis.Discovery
{
    /// <summary>
    /// Abstract parameter factory.
    /// </summary>
    internal abstract class ParameterFactory
    {
        /// <summary>
        /// Returns a parameter with the given values.
        /// </summary>
        internal static IParameter GetParameter(DiscoveryVersion version, KeyValuePair<string, object> kvp)
        {
            switch (version)
            {
                case DiscoveryVersion.Version_0_3:
                    return new ParameterV0_3(kvp);
                case DiscoveryVersion.Version_1_0:
                    return new ParameterV1_0(kvp);
                default:
                    throw new NotSupportedException("Unsupported version of Discovery " + version);
            }
        }

        #region Nested type: BaseParameter

        /// <summary>
        /// Abstract implementation of a parameter.
        /// </summary>
        [VisibleForTestOnly]
        internal class BaseParameter : IParameter
        {
            protected readonly JsonDictionary information;

            /// <summary>
            /// Creates a new parameter with the specified name and value.
            /// </summary>
            public BaseParameter(KeyValuePair<string, object> kvp)
            {
                Name = kvp.Key;
                information = kvp.Value as JsonDictionary;
                if (information == null)
                {
                    throw new ArgumentException("got no valid dictionary");
                }
            }

            /// <summary>
            /// Returns a set of enum value descriptions.
            /// </summary>
            public IEnumerable<string> EnumValueDescriptions
            {
                get
                {
                    IEnumerable list = information.GetValueAsNull("enumDescriptions") as IEnumerable;
                    if (list == null)
                    {
                        yield break;
                    }

                    foreach (string s in list)
                    {
                        yield return s;
                    }
                }
            }

            #region IParameter Members

            public string Name { get; private set; }

            public virtual string ParameterType
            {
                get { return information.GetValueAsNull(ServiceFactory.ParameterType) as string; }
            }

            public string Pattern
            {
                get { return information.GetValueAsNull(ServiceFactory.Pattern) as string; }
            }

            public bool IsRequired
            {
                get { return (bool) (information.GetValueAsNull(ServiceFactory.Required) ?? false); }
            }

            public bool IsRepeatable
            {
                get { return (bool)(information.GetValueAsNull("repeated") ?? false); }
            }

            public virtual string DefaultValue
            {
                get { return information.GetValueAsNull(ServiceFactory.DefaultValue) as string; }
            }

            public string ValueType
            {
                get { return information.GetValueAsNull(ServiceFactory.ValueType) as string; }
            }

            public string Description
            {
                get { return information.GetValueAsNull(ServiceFactory.Description) as string; }
            }

            public string Maximum
            {
                get { return information.GetValueAsNull(ServiceFactory.Maximum) as string; }
            }

            public string Minimum
            {
                get { return information.GetValueAsNull(ServiceFactory.Minimum) as string; }
            }

            public IEnumerable<string> EnumValues
            {
                get
                {
                    IEnumerable list = information.GetValueAsNull("enum") as IEnumerable;
                    if (list == null)
                    {
                        yield break;
                    }

                    foreach (string s in list)
                    {
                        yield return s;
                    }
                }
            }

            #endregion
        }

        #endregion

        #region Nested type: ParameterV0_3

        /// <summary>
        /// A discovery v0.3 implementation of a parameter.
        /// </summary>
        [VisibleForTestOnly]
        internal class ParameterV0_3 : BaseParameter
        {
            public ParameterV0_3(KeyValuePair<string, object> kvp) : base(kvp) {}

            public override string ParameterType
            {
                get { return information.GetValueAsNull("restParameterType") as string; }
            }

            public override string DefaultValue
            {
                get { return information.GetValueAsNull("defaultValue") as string; }
            }
        }

        #endregion

        #region Nested type: ParameterV1_0

        /// <summary>
        /// A discovery v1.0 implementation of a parameter.
        /// </summary>
        [VisibleForTestOnly]
        internal class ParameterV1_0 : BaseParameter
        {
            public ParameterV1_0(KeyValuePair<string, object> kvp) : base(kvp) {}
        }

        #endregion
    }
}