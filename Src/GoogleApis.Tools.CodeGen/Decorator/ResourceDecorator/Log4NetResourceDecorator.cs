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

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator
{


    public class Log4NetResourceDecorator : IResourceDecorator
    {
        public const string LoggerName = "logger";
        private static log4net.ILog logger = log4net.LogManager.GetLogger (typeof(Log4NetResourceDecorator));

        public void DecorateClass (Resource resource, string className, CodeTypeDeclaration resourceClass, ResourceClassGenerator generator, string serviceClassName, IEnumerable<IResourceDecorator> allDecorators)
        {
            //public static log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(<className>));
            logger.Debug ("Adding logger to ResourceClass.");
            var loggerField = new CodeMemberField ("log4net.ILog", LoggerName);
            var initialiser = new CodeMethodInvokeExpression ();
            initialiser.Method = new CodeMethodReferenceExpression (new CodeTypeReferenceExpression ("log4net.LogManager"), "GetLogger");
            initialiser.Parameters.Add (new CodeTypeOfExpression (className));
            loggerField.InitExpression = initialiser;
            
            resourceClass.Members.Add (loggerField);
        }

        public void DecorateMethodBeforeExecute (Resource resource, Method method, CodeMemberMethod codeMember)
        {
            var logCall = new CodeMethodInvokeExpression ();
            logCall.Method = new CodeMethodReferenceExpression (new CodeVariableReferenceExpression (LoggerName), "Debug");
            logCall.Parameters.Add (new CodePrimitiveExpression (String.Format ("Executing {0}.{1}", resource.Name, method.Name)));
            codeMember.Statements.Add (logCall);
        }

        public void DecorateMethodAfterExecute (Resource resource, Method method, CodeMemberMethod codeMember)
        {
            var logCall = new CodeMethodInvokeExpression ();
            logCall.Method = new CodeMethodReferenceExpression (new CodeVariableReferenceExpression (LoggerName), "Debug");
            logCall.Parameters.Add (new CodePrimitiveExpression (String.Format ("Done Executing {0}.{1}", resource.Name, method.Name)));
            codeMember.Statements.Add (logCall);
        }
    }
}
