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
using Google.Apis.Requests;
using Google.Apis.Testing;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Supplies ObjectToJson method in generated services. Uses Newtonsoft.Json.JsonSerializer
    /// </summary>
    public class JsonSerializationMethods : IServiceDecorator
    {
        /// <summary>
        /// Method name of the "RegisterSerializer" method.
        /// </summary>
        public const string RegisterSerializerMethodName = "RegisterSerializer";

        /// <summary>
        /// Method name of the serialization method.
        /// </summary>
        public const string SerializationMethodName = "SerializeObject";

        /// <summary>
        /// Method name of the deserialization method.
        /// </summary>
        public const string DeserializationMethodName = "DeserializeResponse";

        #region IServiceDecorator Members

        public void DecorateClass(IService service, CodeTypeDeclaration serviceClass)
        {
            serviceClass.ThrowIfNull("serviceClass");
            serviceClass.Members.Add(CreateRegisterSerializer());
            serviceClass.Members.Add(CreateObjectToJson());
            serviceClass.Members.Add(CreateResponseToObject());
        }

        #endregion

        /// <summary>
        ///  Creates the RegisterSerializer method
        ///  <code>
        ///     public void RegisterSerializer(ISerializer serializer)
        ///     {
        ///         genericService.Serializer = serializer;
        ///     }
        ///  </code>
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberMethod CreateRegisterSerializer()
        {
            const string VAR_NAME = "serializer";
            var genericService = new CodeTypeReferenceExpression(ServiceClassGenerator.GenericServiceName);

            // public void RegisterSerializer(ISerializer serializer)
            var method = new CodeMemberMethod();
            method.Name = RegisterSerializerMethodName;
            method.Attributes = MemberAttributes.Public;
            method.Parameters.Add(
                new CodeParameterDeclarationExpression(new CodeTypeReference(typeof(ISerializer)), VAR_NAME));
            method.ReturnType = new CodeTypeReference(typeof(void));

            // genericService.Serializer = serializer;
            var propertySet = new CodeAssignStatement();
            propertySet.Left = new CodePropertyReferenceExpression(genericService, BaseService.SerializerPropertyName);
            propertySet.Right = new CodeVariableReferenceExpression(VAR_NAME);

            // Add the statement to the method
            method.Statements.Add(propertySet);

            return method;
        }

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
            method.ImplementationTypes.Add(typeof(IRequestProvider));
            method.Attributes = MemberAttributes.Public;
            method.Parameters.Add(
                new CodeParameterDeclarationExpression(new CodeTypeReference(typeof(object)), "obj"));
            method.ReturnType = new CodeTypeReference(typeof(string));

            // return genericService.Serialize(obj);
            var serializationCall = new CodeMethodInvokeExpression();
            serializationCall.Method =
                new CodeMethodReferenceExpression(
                    new CodeTypeReferenceExpression(ServiceClassGenerator.GenericServiceName),
                    BaseService.SerializationMethodName);
            serializationCall.Parameters.Add(new CodeVariableReferenceExpression("obj"));

            // Add the return
            method.Statements.Add(new CodeMethodReturnStatement(serializationCall));

            return method;
        }

        /// <summary>
        ///     <code>
        ///        public TOutput ResponseToObject<TOutput>(IResponse response){
        ///            return genericService.Deserialize<TOutput>(response);
        ///        } 
        ///     </code> 
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberMethod CreateResponseToObject()
        {
            // public TOutput JsonToObject<TOutput>(Stream stream)
            var method = new CodeMemberMethod();
            var typeParameter = new CodeTypeParameter("T");
            method.Name = DeserializationMethodName;
            method.ImplementationTypes.Add(typeof(IRequestProvider));
            method.Parameters.Add(new CodeParameterDeclarationExpression(typeof(IResponse), "response"));
            method.TypeParameters.Add(typeParameter);
            method.ReturnType = new CodeTypeReference(typeParameter);
            method.Attributes = MemberAttributes.Public;

            // return genericService.Deserialize<TOutput>(stream);
            var deserializationCall = new CodeMethodInvokeExpression();
            deserializationCall.Method =
                new CodeMethodReferenceExpression(
                    new CodeTypeReferenceExpression(ServiceClassGenerator.GenericServiceName),
                    BaseService.DeserializationMethodName, new CodeTypeReference("T"));
            deserializationCall.Parameters.Add(new CodeVariableReferenceExpression("response"));

            // Add the return
            method.Statements.Add(new CodeMethodReturnStatement(deserializationCall));

            return method;
        }
    }
}