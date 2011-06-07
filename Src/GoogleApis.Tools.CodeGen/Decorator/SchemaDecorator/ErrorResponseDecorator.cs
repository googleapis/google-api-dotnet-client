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


using System.CodeDom;
using Google.Apis.Discovery.Schema;
using Google.Apis.Requests;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Util;
using log4net;

namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    /// <summary>
    /// Adds inheritance from IRequest and an Error property to schemas referenced by methods
    /// </summary>
    public class ErrorResponseDecorator : ISchemaDecorator
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(ArraySchemaDecorator));

        public void DecorateClass(CodeTypeDeclaration typeDeclaration,
                                  ISchema schema,
                                  SchemaImplementationDetails implDetails,
                                  INestedClassProvider internalClassProvider)
        {
            typeDeclaration.ThrowIfNull("typeDeclaration");
            schema.ThrowIfNull("schema");
            
            if (implDetails == null)
            {
                return; // Nothing to do for this schema
            }

            // If this method is refered as a result directly, add an inheritance to IResponse and implement
            // the interface
            if (implDetails.IsMethodResult)
            {
                typeDeclaration.BaseTypes.Add(GetIResponseBaseType());
                typeDeclaration.Members.AddRange(CreateErrorProperty(typeDeclaration));
            }
        }

        private CodeTypeReference GetIResponseBaseType()
        {
            return new CodeTypeReference(typeof(IResponse));
        }

        private CodeTypeMemberCollection CreateErrorProperty(CodeTypeDeclaration typeDeclaration)
        {
            return DecoratorUtil.CreateAutoProperty<RequestError>(typeDeclaration, "Error", null);
        }
    }
}