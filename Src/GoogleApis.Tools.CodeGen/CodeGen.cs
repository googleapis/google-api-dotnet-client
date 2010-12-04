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
using System.Collections.Generic;

using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;

namespace Google.Apis.Tools.CodeGen
{
    public class CodeGen : BaseGenerator
    {

        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger (typeof(CodeGen));

        private readonly CodeCompileUnit compileUnit;
        private readonly IService service;
        private readonly string codeClientNamespace;

        private readonly IEnumerable<IResourceDecorator> resourceDecorators;
        private readonly IEnumerable<IServiceDecorator> serviceDecorators;

        private CodeNamespace client;

        public CodeGen (IService service, string clientNamespace, IEnumerable<IResourceDecorator> resourceDecorators, IEnumerable<IServiceDecorator> serviceDecorators)
        {
            compileUnit = new CodeCompileUnit ();
            this.codeClientNamespace = clientNamespace;
            this.service = service;
            
            // Defensive copy and readonly
            this.resourceDecorators = new List<IResourceDecorator> (resourceDecorators).AsReadOnly ();
            this.serviceDecorators = new List<IServiceDecorator> (serviceDecorators).AsReadOnly ();
        }

        public CodeGen (IService service, string clientNamespace) : this(service, clientNamespace, new IResourceDecorator[] { new StandardConstructorResourceDecorator (), new StandardMethodResourceDecorator (), new Log4NetResourceDecorator (), new DictonaryOptionalParameterResourceDecorator () }, new IServiceDecorator[] { new StandardConstructServiceDecorator (), new EasyConstructServiceDecorator (), new VersionInformationServiceDecorator (), new StandardExecuteMethodServiceDecorator () })
        {
            
        }

        public CodeCompileUnit GenerateCode ()
        {
            logger.Debug ("Starting Code Generation...");
            LogDecorators ();
            
            
            CreateClient (codeClientNamespace);
            AddUsings (false);
            
            var serviceClass = new ServiceClassGenerator (service, serviceDecorators).CreateServiceClass ();
            string serviceClassName = serviceClass.Name;
            
            client.Types.Add (serviceClass);
            
            int resourceNumber = 1;
            foreach (var res in service.Resources.Values) {
                // Create a class for the resource
                logger.DebugFormat ("Adding Resource {0}", res.Name);
                var resourceGenerator = new ResourceClassGenerator (res, serviceClassName, resourceNumber, resourceDecorators);
                client.Types.Add (resourceGenerator.CreateClass ());
                resourceNumber++;
            }
            
            logger.Debug ("Generation Complete.");
            return compileUnit;
        }

        private void LogDecorators ()
        {
            if (logger.IsDebugEnabled) {
                logger.Debug ("With Service Decorators:");
                foreach (IServiceDecorator dec in serviceDecorators) {
                    logger.Debug (">>>>" + dec.ToString ());
                }
                logger.Debug ("With Resource Decorators:");
                foreach (IResourceDecorator dec in resourceDecorators) {
                    logger.Debug (">>>>" + dec.ToString ());
                }
            }
        }


        private void CreateClient (string nameSpace)
        {
            client = new CodeNamespace (nameSpace);
            compileUnit.Namespaces.Add (client);
        }

        private void AddUsings (bool forTest)
        {
            client.Imports.Add (new CodeNamespaceImport ("System"));
            client.Imports.Add (new CodeNamespaceImport ("System.IO"));
            client.Imports.Add (new CodeNamespaceImport ("System.Collections.Generic"));
            client.Imports.Add (new CodeNamespaceImport ("Google.Apis"));
            client.Imports.Add (new CodeNamespaceImport ("Google.Apis.Discovery"));
            
            if (forTest) {
                client.Imports.Add (new CodeNamespaceImport ("NUnit.Framework"));
                client.Imports.Add (new CodeNamespaceImport (codeClientNamespace));
            }
        }
    }
}

