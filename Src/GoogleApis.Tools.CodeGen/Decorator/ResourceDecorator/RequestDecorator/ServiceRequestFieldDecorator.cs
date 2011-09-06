/*
Copyright 2011 Google Inc

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
using Google.Apis.Discovery;
using Google.Apis.Testing;

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator.RequestDecorator
{
    /// <summary>
    /// A decorator which implements abstract properties of the ServiceRequest class
    /// 
    /// Example:
    /// <c>protected override string ResourceName { get { return ...; } } </c>
    /// <c>protected override string MethodName { get { return ...; } } </c>
    /// </summary>
    public class ServiceRequestFieldDecorator : IRequestDecorator
    {
        #region IRequestDecorator Members

        public void DecorateClass(IResource resource,
                                  IMethod request,
                                  CodeTypeDeclaration requestClass,
                                  CodeTypeDeclaration resourceClass)
        {
            // protected override string ResourceName { get { ... } }
            CodeMemberProperty property = GenerateStringConstantPropertyOverride(
                "ResourcePath", resource.Path);
            requestClass.Members.Add(property);

            // protected override string MethodName { get { ... } }
            property = GenerateStringConstantPropertyOverride("MethodName", request.Name);
            requestClass.Members.Add(property);
        }

        #endregion

        /// <summary>
        /// Generates a property which will return a constant string.
        /// Will not do a used-name check. Assumes the name can be chosen.
        /// Example:
        /// <c>protected override string PropertyName { get { ... } }</c>
        /// </summary>
        [VisibleForTestOnly]
        internal static CodeMemberProperty GenerateStringConstantPropertyOverride(string propertyName,
                                                                                  string returnValue)
        {
            var property = new CodeMemberProperty();
            property.Name = propertyName;
            property.Type = new CodeTypeReference(typeof(string));
            property.Attributes = MemberAttributes.Family | MemberAttributes.Override; // "protected".
            property.HasGet = true;

            // get { return "..."; }
            var returnString = new CodePrimitiveExpression(returnValue);
            property.GetStatements.Add(new CodeMethodReturnStatement(returnString));

            return property;
        }
    }
}