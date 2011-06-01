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
using System.IO;
using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Supplies ObjectToJson method in generated services. Using Newtonsoft.Json.JsonSerilizer
    /// </summary>
    public class NewtonsoftJsonSerializer : IServiceDecorator
    {
        private const string SerializationMethodName = "ObjectToJson";
        private const string DeserializationMethodName = "JsonToObject";
        private const string InternalSerializationMethod = "Serialize";
        private const string InternalDeserializationMethod = "Deserialize";

        #region IServiceDecorator Members

        public void DecorateClass(IService service, CodeTypeDeclaration serviceClass)
        {
            serviceClass.ThrowIfNull("serviceClass");
            serviceClass.Members.Add(CreateObjectToJson());
            serviceClass.Members.Add(CreateJsonToObject());
        }

        #endregion

        /// <summary>
        ///  Creates ObjectToJson method
        ///  <code>
        ///     public string ObjectToJson(object obj)
        ///     {
        ///         return genericService.Serialize(obj);
        ///     }
        ///  </code>
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberMethod CreateObjectToJson()
        {
            // public string ObjectToJson(object obj)
            var method = new CodeMemberMethod();
            method.Name = SerializationMethodName;
            method.Attributes = MemberAttributes.Public;
            method.Parameters.Add(
                new CodeParameterDeclarationExpression(new CodeTypeReference(typeof(object)), "obj"));
            method.ReturnType = new CodeTypeReference(typeof(string));

            // return genericService.Serialize(obj);
            var serializationCall = new CodeMethodInvokeExpression();
            serializationCall.Method =
                new CodeMethodReferenceExpression(
                    new CodeTypeReferenceExpression(ServiceClassGenerator.GenericServiceName),
                    InternalSerializationMethod);
            serializationCall.Parameters.Add(new CodeVariableReferenceExpression("obj"));

            // Add the return
            method.Statements.Add(new CodeMethodReturnStatement(serializationCall));

            return method;
        }

        /// <summary>
        ///     <code>
        ///        public TOutput JsonToObject<TOutput>(Stream stream){
        ///            return genericService.Deserialize<TOutput>(stream);
        ///        } 
        ///     </code> 
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberMethod CreateJsonToObject()
        {
            //public TOutput JsonToObject<TOutput>(Stream stream)
            var method = new CodeMemberMethod();
            var typeParameter = new CodeTypeParameter("T");
            method.Name = DeserializationMethodName;
            method.Parameters.Add(new CodeParameterDeclarationExpression(typeof(Stream), "stream"));
            method.TypeParameters.Add(typeParameter);
            method.ReturnType = new CodeTypeReference(typeParameter);
            method.Attributes = MemberAttributes.Public;

            // return genericService.Deserialize<TOutput>(stream);
            var deserializationCall = new CodeMethodInvokeExpression();
            deserializationCall.Method =
                new CodeMethodReferenceExpression(
                    new CodeTypeReferenceExpression(ServiceClassGenerator.GenericServiceName),
                    InternalDeserializationMethod, new CodeTypeReference("T"));
            deserializationCall.Parameters.Add(new CodeVariableReferenceExpression("stream"));

            // Add the return
            method.Statements.Add(new CodeMethodReturnStatement(deserializationCall));

            return method;
        }
    }
}