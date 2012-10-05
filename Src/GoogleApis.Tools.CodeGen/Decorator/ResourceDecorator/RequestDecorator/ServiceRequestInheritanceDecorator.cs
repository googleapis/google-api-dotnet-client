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
using Google.Apis.Discovery;
using Google.Apis.Requests;
using Google.Apis.Upload;

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator.RequestDecorator
{
    /// <summary>
    /// A decorator which adds the ServiceRequest inheritance to the class
    /// </summary>
    public class ServiceRequestInheritanceDecorator : IRequestDecorator
    {
        private readonly IObjectTypeProvider objectTypeProvider;

        /// <summary>
        /// Creates a new ServiceRequestInheritanceDecorator, which uses the specified type provider.
        /// </summary>
        public ServiceRequestInheritanceDecorator(IObjectTypeProvider objectTypeProvider)
        {
            this.objectTypeProvider = objectTypeProvider;
        }

        #region IRequestDecorator Members

        public void DecorateClass(IResource resource,
                                  IMethod request,
                                  CodeTypeDeclaration requestClass,
                                  CodeTypeDeclaration resourceClass)
        {
            // Retrieve the response type.
            var responseType = string.IsNullOrEmpty(request.ResponseType)
                                   ? new CodeTypeReference(typeof(string))
                                   : objectTypeProvider.GetReturnType(request);

            var baseRef = new CodeTypeReference(typeof(ServiceRequest<>));
            baseRef.TypeArguments.Add(responseType);
            requestClass.BaseTypes.Add(baseRef);
        }

        #endregion
    }
}