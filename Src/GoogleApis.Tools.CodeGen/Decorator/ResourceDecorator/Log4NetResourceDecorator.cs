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
using Google.Apis.Logging;
using Google.Apis.Tools.CodeGen.Generator;

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator
{
    /// <summary>
    /// An optional decorator that adds logging to the Resoruces as they are called.
    /// This uses log4Net as the logging framework.
    /// </summary>
    [Obsolete("Logging is now done within the core library.")]
    public class Log4NetResourceDecorator : IResourceDecorator
    {
        public const string LoggerName = "logger";
        private static readonly ILogger logger = ApplicationContext.Logger.ForType<Log4NetResourceDecorator>();

        #region IResourceDecorator Members

        public void DecorateClass(IResource resource,
                                  string className,
                                  CodeTypeDeclaration resourceClass,
                                  ResourceClassGenerator generator,
                                  string serviceClassName,
                                  IEnumerable<IResourceDecorator> allDecorators)
        {
            //public static log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(<className>));
            logger.Debug("Adding logger to ResourceClass.");
            var loggerField = new CodeMemberField("log4net.ILog", LoggerName);
            var initialiser = new CodeMethodInvokeExpression();
            initialiser.Method = new CodeMethodReferenceExpression(
                new CodeTypeReferenceExpression("log4net.LogManager"), "GetLogger");
            initialiser.Parameters.Add(new CodeTypeOfExpression(className));
            loggerField.InitExpression = initialiser;

            resourceClass.Members.Add(loggerField);
        }

        public void DecorateMethodBeforeExecute(IResource resource, IMethod method, CodeMemberMethod codeMember)
        {
            var logCall = new CodeMethodInvokeExpression();
            logCall.Method = new CodeMethodReferenceExpression(new CodeVariableReferenceExpression(LoggerName), "Debug");
            logCall.Parameters.Add(
                new CodePrimitiveExpression(String.Format("Executing {0}.{1}", resource.Name, method.Name)));
            codeMember.Statements.Add(logCall);
        }

        public void DecorateMethodAfterExecute(IResource resource, IMethod method, CodeMemberMethod codeMember)
        {
            var logCall = new CodeMethodInvokeExpression();
            logCall.Method = new CodeMethodReferenceExpression(new CodeVariableReferenceExpression(LoggerName), "Debug");
            logCall.Parameters.Add(
                new CodePrimitiveExpression(String.Format("Done Executing {0}.{1}", resource.Name, method.Name)));
            codeMember.Statements.Add(logCall);
        }

        #endregion
    }
}