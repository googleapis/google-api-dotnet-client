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
using System.Linq;
using Google.Apis.Discovery;
using Google.Apis.Requests;
using Google.Apis.Testing;

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator.RequestDecorator
{
    /// <summary>
    /// A decorator that adds support for a request body to the request class by implementing the "Body"-autoproperty.
    /// </summary>
    public class BodyPropertyDecorator : IRequestDecorator
    {
        /// <summary>
        /// Name of the "Body" property.
        /// </summary>
        public const string BodyPropertyName = "Body";

        /// <summary>
        /// Comment of the "Body" property.
        /// </summary>
        public const string BodyPropertyComment = "Gets/Sets the Body of this Request.";

        private readonly IObjectTypeProvider objectTypeProvider;

        /// <summary>
        /// Creates a new body property decorator, which will use the specified object type provider for the body type.
        /// </summary>
        public BodyPropertyDecorator(IObjectTypeProvider objectTypeProvider)
        {
            this.objectTypeProvider = objectTypeProvider;
        }

        #region IRequestDecorator Members

        public void DecorateClass(IResource resource,
                                  IMethod request,
                                  CodeTypeDeclaration requestClass,
                                  CodeTypeDeclaration resourceClass)
        {
            if (!request.HasBody)
            {
                // Method has no body -> Decorator does not apply.
                return;
            }

            // Add the "Body { get; set; }" property.
            requestClass.Members.AddRange(GenerateBodyProperty(request, objectTypeProvider.GetBodyType(request)));

            // Add the "GetBody()" method override, which returns the body property.
            requestClass.Members.Add(GenerateGetBodyOverride(request));
        }

        #endregion

        /// <summary>
        /// Generates the Body propery with the method's response type.
        /// Does not perform name-checking as it is implementing an abstract property.
        /// </summary>
        [VisibleForTestOnly]
        internal CodeTypeMemberCollection GenerateBodyProperty(IMethod request, CodeTypeReference bodyType)
        {
            return DecoratorUtil.CreateAutoProperty(
                BodyPropertyName, BodyPropertyComment, bodyType, Enumerable.Empty<string>(), false, null);
        }

        /// <summary>
        /// Generates the GetBody override, which will return a reference to the Body property.
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberMethod GenerateGetBodyOverride(IMethod request)
        {
            // protected override object GetBody() {
            var method = new CodeMemberMethod();
            method.Attributes = MemberAttributes.Override | MemberAttributes.Family;
            method.Name = ServiceRequest<object>.GetBodyMethodName;
            method.ReturnType = new CodeTypeReference(typeof(object));

            //   return Body;
            var returnStatement = new CodeMethodReturnStatement();
            var thisRef = new CodeThisReferenceExpression();
            returnStatement.Expression = new CodePropertyReferenceExpression(thisRef, BodyPropertyName);
            method.Statements.Add(returnStatement);

            return method;
        }
    }
}