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

using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Generates InitParameters method which intializes <code>ServiceParamters</code> 
    /// by the service (IService) common parameters.
    /// </summary>
    public class InitServiceParametersDecorator : IServiceDecorator
    {
        internal const string InitParametersName = "InitParameters";

        public void DecorateClass(IService service, CodeTypeDeclaration serviceClass)
        {
            var method = new CodeMemberMethod();

            // Generate: private void InitParameters()
            method.Name = InitParametersName;
            method.ReturnType = new CodeTypeReference(typeof(void));
            method.Attributes = MemberAttributes.Private;

            // Add request parameters initialization
            DecoratorUtil.AddInitializeParameters(method, "_serviceParameters", service.Parameters);

            serviceClass.Members.Add(method);
        }
    }
}
