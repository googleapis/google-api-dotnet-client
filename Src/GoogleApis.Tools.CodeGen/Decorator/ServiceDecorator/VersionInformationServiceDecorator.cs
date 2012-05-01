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
using System.CodeDom;
using Google.Apis.Discovery;
using Google.Apis.Testing;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Adds private constants Version (VersionName), Name (NameName) and BaseUri (BaseUriName) 
    /// to the ServiceClass.
    /// </summary>
    public class VersionInformationServiceDecorator : IServiceDecorator
    {
        public const string VersionName = "Version";
        public const string NameName = "Name";
        public const string BaseUriName = "BaseUri";
        public const string DiscoveryVersionName = "DiscoveryVersionUsed";

        #region IServiceDecorator Members

        public void DecorateClass(IService service, CodeTypeDeclaration serviceClass)
        {
            serviceClass.Members.Add(CreateVersionField(service));
            serviceClass.Members.Add(CreateNameField(service));
            serviceClass.Members.Add(CreateUriField(service));
            serviceClass.Members.Add(CreateDiscoveryVersionField(service));
        }

        #endregion

        [VisibleForTestOnly]
        internal CodeMemberField CreateVersionField(IService service)
        {
            return new CodeMemberField()
            {
                Name = VersionName,
                Type = new CodeTypeReference(typeof(string)),
                Attributes = MemberAttributes.Public | MemberAttributes.Const,
                InitExpression = new CodePrimitiveExpression(service.Version),
            };
        }

        [VisibleForTestOnly]
        internal CodeMemberProperty CreateNameField(IService service)
        {
            return new CodeMemberProperty()
            {
                Name = NameName,
                Type = new CodeTypeReference(typeof(string)),
                Attributes = MemberAttributes.Public,
                GetStatements = { new CodeMethodReturnStatement(new CodePrimitiveExpression(service.Name)) }
            };
        }

        [VisibleForTestOnly]
        internal CodeMemberProperty CreateUriField(IService service)
        {
            return new CodeMemberProperty()
            {
                Name = BaseUriName,
                Type = new CodeTypeReference(typeof(string)),
                Attributes = MemberAttributes.Public,
                GetStatements = { new CodeMethodReturnStatement(new CodePrimitiveExpression(service.BaseUri.ToString())) },
                ImplementationTypes = { typeof(IRequestProvider) },
            };
        }

        [VisibleForTestOnly]
        internal CodeMemberField CreateDiscoveryVersionField(IService service)
        {
            return new CodeMemberField()
            {
                Name = DiscoveryVersionName,
                Type = new CodeTypeReference(typeof(DiscoveryVersion)),
                Attributes = MemberAttributes.Public | MemberAttributes.Static,
                InitExpression = new CodeFieldReferenceExpression(
                        new CodeTypeReferenceExpression(typeof(DiscoveryVersion)),
                            Enum.GetName(typeof(DiscoveryVersion), service.DiscoveryVersion))
            };
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}