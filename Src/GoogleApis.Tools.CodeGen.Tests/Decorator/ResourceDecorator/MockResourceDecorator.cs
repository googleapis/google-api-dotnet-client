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
using System.Collections.Generic;
using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using Google.Apis.Tools.CodeGen.Generator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
    /// <summary>
    /// Mock class for testing purposes
    /// </summary>
    public class MockResourceDecorator : IResourceDecorator
    {
        public int DecorateClassCalled { get; private set; }
        public int DecorateMethodBeforeExecuteCalled { get; private set; }
        public int DecorateMethodAfterExecuteCalled { get; private set; }

        #region IResourceDecorator implementation

        public void DecorateClass(IResource resource,
                                  string className,
                                  CodeTypeDeclaration resourceClass,
                                  ResourceClassGenerator generator,
                                  string serviceClassName,
                                  IEnumerable<IResourceDecorator> allDecorators)
        {
            DecorateClassCalled += 1;
        }


        public void DecorateMethodBeforeExecute(IResource resource, IMethod method, CodeMemberMethod codeMember)
        {
            DecorateMethodBeforeExecuteCalled += 1;
        }


        public void DecorateMethodAfterExecute(IResource resource, IMethod method, CodeMemberMethod codeMember)
        {
            DecorateMethodAfterExecuteCalled += 1;
        }

        #endregion
    }
}