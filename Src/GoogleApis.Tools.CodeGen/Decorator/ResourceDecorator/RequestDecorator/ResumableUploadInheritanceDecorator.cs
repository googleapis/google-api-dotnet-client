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
    /// A decorator which adds the ResumableUpload inheritance to the class
    /// Adds : <see cref="ResumableUpload{RequestType}"/> for types with no response body.
    /// Adds : <see cref="ResumableUpload{RequestType, ResponseType}"/> for types with response body.
    /// </summary>
    public class ResumableUploadInheritanceDecorator : IRequestDecorator
    {
        private readonly IObjectTypeProvider objectTypeProvider;

        /// <summary>
        /// Creates a new ResumableUploadInheritanceDecorator, which uses the specified type provider.
        /// </summary>
        public ResumableUploadInheritanceDecorator(IObjectTypeProvider objectTypeProvider)
        {
            this.objectTypeProvider = objectTypeProvider;
        }

        #region IRequestDecorator Members

        /// <summary>
        /// Adds code to the class "requestClass" based on the specified "request" method.
        /// </summary>
        public void DecorateClass(IResource resource,
                                  IMethod request,
                                  CodeTypeDeclaration requestClass,
                                  CodeTypeDeclaration resourceClass)
        {
            // Retrieve the response type.
            var requestType = string.IsNullOrEmpty(request.RequestType)
                                   ? new CodeTypeReference(typeof(string))
                                   : objectTypeProvider.GetBodyType(request);

            if (string.IsNullOrEmpty(request.ResponseType))
            {
                var baseRef = new CodeTypeReference(typeof(ResumableUpload<>));
                baseRef.TypeArguments.Add(requestType);
                requestClass.BaseTypes.Add(baseRef);
            }
            else
            {
                var baseRef = new CodeTypeReference(typeof(ResumableUpload<,>));
                baseRef.TypeArguments.Add(requestType);
                baseRef.TypeArguments.Add(objectTypeProvider.GetReturnType(request));
                requestClass.BaseTypes.Add(baseRef);
            }
        }

        #endregion
    }
}