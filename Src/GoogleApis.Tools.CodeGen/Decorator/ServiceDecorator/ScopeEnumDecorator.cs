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

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using Google.Apis.Discovery;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// This decorator adds an enumeration containing all of the service's scopes to the service class.
    /// 
    /// Example:
    /// <code>
    ///  public enum Scopes {
    ///     [Google.Apis.Util.StringValueAttribute("https://www.googleapis.com/auth/tasks")]
    ///     Tasks,
    ///     [Google.Apis.Util.StringValueAttribute("https://www.googleapis.com/auth/tasks.readonly")]
    ///     TasksReadonly,
    ///  }
    /// </code>
    /// </summary>
    public class ScopeEnumDecorator : IServiceDecorator
    {
        /// <summary>
        /// The name of the enumeration.
        /// </summary>
        public const string EnumName = "Scopes";

        /// <summary>
        /// The description of the enumeration.
        /// </summary>
        public const string EnumDescription =
            "A list of all OAuth2.0 scopes. Each of these scopes relates" +
            " to a permission or group of permissions that different methods of this API may need.";

        public void DecorateClass(IService service, CodeTypeDeclaration serviceClass)
        {
            if (service.Scopes.Count == 0)
            {
                return; // We don't need to create an empty scope enum.
            }

            serviceClass.Members.Add(GenerateScopeEnumeration(service.Scopes.Values));
        }

        /// <summary>
        /// Generates an enumeration representing the scopes given.
        /// </summary>
        [VisibleForTestOnly]
        internal static CodeTypeDeclaration GenerateScopeEnumeration(IEnumerable<Scope> scopes)
        {
            CodeTypeDeclaration decl = new CodeTypeDeclaration(EnumName);
            decl.IsEnum = true;
            decl.Comments.AddRange(DecoratorUtil.CreateSummaryComment(EnumDescription));

            // Add the enumeration members.
            List<string> usedWords = new List<string>();
            foreach (Scope scope in scopes)
            {
                // Create a enum name
                string valueName = GetValueName(scope);
                string safeName = GeneratorUtils.GetEnumValueName(valueName, usedWords);

                // Create the value and add the StringValue attribute.
                var newMember = new CodeMemberField(typeof(int), safeName);
                var stringValueRef = new CodeTypeReference(typeof(StringValueAttribute));
                var stringValueAttribute = new CodeAttributeDeclaration(stringValueRef);
                stringValueAttribute.Arguments.Add(new CodeAttributeArgument(new CodePrimitiveExpression(scope.ID)));

                newMember.CustomAttributes.Add(stringValueAttribute);

                // Add the description.
                newMember.Comments.AddRange(DecoratorUtil.CreateSummaryComment(scope.Description));
                
                usedWords.Add(safeName);
                decl.Members.Add(newMember);
            }

            return decl;
        }

        /// <summary>
        /// Generates an enumeration value name for the specified scope.
        /// </summary>
        [VisibleForTestOnly]
        internal static string GetValueName(Scope scope)
        {
            scope.ThrowIfNull("scope");
            scope.ID.ThrowIfNullOrEmpty("scope.ID");

            // Try to parse the scope as an url.
            Uri uri;
            if (!Uri.TryCreate(scope.ID, UriKind.RelativeOrAbsolute, out uri))
            {
                return scope.ID; // Just return the value name.
            }

            // Return the last fragmenet of this uri.
            if (uri.IsAbsoluteUri && uri.Segments.Length > 0)
            {
                string segment = uri.Segments.Last();

                if (segment.Length >= 3)
                { 
                    // Identifier should have three characters at least.
                    return segment;
                }
            }

            // Otherwise return the whole scope id.
            return scope.ID;
        }
    }
}
