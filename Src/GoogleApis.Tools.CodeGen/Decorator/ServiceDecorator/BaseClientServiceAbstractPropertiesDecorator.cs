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

using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

using Google.Apis.Authentication;
using Google.Apis.Discovery;
using Google.Apis.Testing;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Declares common properties (IList<string> Features, string BaseUri, etc.).
    /// </summary>
    public class BaseClientServiceAbstractPropertiesDecorator : IServiceDecorator
    {
        internal const string FeaturesName = "Features";
        internal const string ServiceParametersName = "serviceParameters";
        internal const string NameName = "Name";
        internal const string BaseUriName = "BaseUri";
        internal const string BasePathName = "BasePath";

        public void DecorateClass(IService service, CodeTypeDeclaration serviceClass)
        {
            serviceClass.Members.Add(CreateFeaturesProperty(service));
            serviceClass.Members.Add(CreateNameProperty(service));
            serviceClass.Members.Add(CreateUriProperty(service));
            serviceClass.Members.Add(CreateBasePathProperty(service));

            serviceClass.Members.AddRange(CreateServiceParametersProperty());
        }

        /// <summary>
        /// Adds ServiceParameters property with backing field, e.g.
        /// <c>
        /// public override IDictionary<string,IParameter> ServiceParameters { get { return _serviceParameters; } }
        /// </c>
        /// </summary>
        [VisibleForTestOnly]
        internal CodeTypeMemberCollection CreateServiceParametersProperty()
        {
            var property = DecoratorUtil.CreateAutoProperty(
                ServiceParametersName, string.Empty, new CodeTypeReference(typeof(IDictionary<string, IParameter>)),
                Enumerable.Empty<string>(), true, null, MemberAttributes.Override | MemberAttributes.Public);
            return property;
        }

        /// <summary>
        /// Adds Features property which returns the service's supported features (read from Discovery) e.g.
        /// <c>
        /// public override IList<string> Features { get { return new string[n] { ... }; } }
        /// </c>
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberProperty CreateFeaturesProperty(IService service)
        {
            IList<CodeExpression> parameters = new List<CodeExpression>();
            foreach (var feature in service.Features)
            {
                parameters.Add(new CodePrimitiveExpression(feature));
            }
            CodeExpression list = new CodeArrayCreateExpression("System.string", parameters.ToArray());

            return new CodeMemberProperty()
            {
                Name = FeaturesName,
                Type = new CodeTypeReference(typeof(IList<string>)),
                Attributes = MemberAttributes.Public | MemberAttributes.Override,
                GetStatements = { new CodeMethodReturnStatement(list) },
            };
        }

        /// <summary>
        /// Adds a Name property which returns the name of the service, e.g.
        /// <c>
        /// public override string Name { get { return "discovery"; } }
        /// </c>
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberProperty CreateNameProperty(IService service)
        {
            return new CodeMemberProperty()
            {
                Name = NameName,
                Type = new CodeTypeReference(typeof(string)),
                Attributes = MemberAttributes.Public | MemberAttributes.Override,
                GetStatements = { new CodeMethodReturnStatement(
                    new CodePrimitiveExpression(service.Name)) },
            };
        }

        /// <summary>
        /// Adds a BaseUrl property which returns the basic url of the service, e.g.
        /// <c>
        /// public override string BaseUri { get { return "https://www.googleapis.com/discovery/v1/"; } }
        /// </c>
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberProperty CreateUriProperty(IService service)
        {
            return new CodeMemberProperty()
            {
                Name = BaseUriName,
                Type = new CodeTypeReference(typeof(string)),
                Attributes = MemberAttributes.Public | MemberAttributes.Override,
                GetStatements = { new CodeMethodReturnStatement(
                    new CodePrimitiveExpression(service.BaseUri.ToString())) },
            };
        }

        /// <summary>
        /// Adds a BasePath property which returns the base path for this resource, e.g.
        /// <c>
        /// public override string BasePath { get { return "/discovery/v1/"; } }
        /// </c>
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberProperty CreateBasePathProperty(IService service)
        {
            return new CodeMemberProperty()
            {
                Name = BasePathName,
                Type = new CodeTypeReference(typeof(string)),
                Attributes = MemberAttributes.Public | MemberAttributes.Override,
                GetStatements = { new CodeMethodReturnStatement(
                    new CodePrimitiveExpression(service.BasePath)) },
            };
        }
    }
}
