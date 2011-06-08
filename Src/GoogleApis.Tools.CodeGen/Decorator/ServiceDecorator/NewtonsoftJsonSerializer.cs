using System;
using System.CodeDom;
using System.IO;
using Google.Apis.Discovery;
using Newtonsoft.Json;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Supplies ObjectToJson method in generated services. Using Newtonsoft.Json.JsonSerilizer
    /// </summary>
    public class NewtonsoftJsonSerializer : IServiceDecorator
    {
        private const string FieldName = "newtonJsonSerilizer";
        private const string PropertyName = "NewtonJsonSerilizer";
        private const string MethodName = "ObjectToJson";
        private const string settingsVarName = "settings";

        #region IServiceDecorator Members

        public void DecorateClass(IService service, CodeTypeDeclaration serviceClass)
        {
            serviceClass.ThrowIfNull("serviceClass");
            serviceClass.Members.Add(CreateJsonSerializerField());
            serviceClass.Members.Add(CreateJsonSerializerGetter());
            serviceClass.Members.Add(CreateObjectToJson());
            serviceClass.Members.Add(CreateJsonToObject());
        }

        #endregion

        /// <summary>
        /// Creates a JsonSerializer field.
        /// <code>private JsonSerializer newtonJsonSerilizer = null;</code>
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberField CreateJsonSerializerField()
        {
            var field = new CodeMemberField(typeof(JsonSerializer), FieldName);
            field.InitExpression = new CodePrimitiveExpression(null);
            field.Attributes = MemberAttributes.Private;
            return field;
        }

        [VisibleForTestOnly]
        /// <summary>
        /// Creates a property to configure and create JsonSerilizer 
        /// <code>
        ///     private JsonSerializer NewtonJsonSerilizer
        ///     {
        ///         get
        ///         {
        ///             if( this.newtonwJsonSerilizer == null )
        ///             {
        ///                 JsonSerializerSettings settings = new JsonSerializerSettings();
        ///                 settings.NullValueHandling = NullValueHandling.Ignore;
        ///                 this.newtonwJsonSerilizer = JsonSerializer.Create(settings);            
        ///             }
        ///             return this.newtonwJsonSerilizer;
        ///         }
        ///     }
        /// </code>
        /// </summary>
        /// <returns>
        /// A <see cref="CodeMemberProperty"/>
        /// </returns>
        internal CodeMemberProperty CreateJsonSerializerGetter()
        {
            var property = new CodeMemberProperty();

            //private JsonSerializer NewtonJsonSerilizer
            property.Name = PropertyName;
            property.Attributes = MemberAttributes.Private;
            property.Type = new CodeTypeReference(typeof(JsonSerializer));
            property.HasSet = false;
            property.HasGet = true;

            var creationBlock = CreateSerilizerCreationBlock();

            // if( this.newtonwJsonSerilizer == null )
            //      ... // creationBlock
            var condition = new CodeBinaryOperatorExpression();
            condition.Operator = CodeBinaryOperatorType.IdentityEquality;
            condition.Left = new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), FieldName);
            condition.Right = new CodePrimitiveExpression(null);

            var ifStatement = new CodeConditionStatement();
            ifStatement.Condition = condition;
            ifStatement.TrueStatements.AddRange(creationBlock);

            // return this.newtonwJsonSerilizer;
            var returnStatment = new CodeMethodReturnStatement();
            returnStatment.Expression = new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), FieldName);

            property.GetStatements.Add(ifStatement);
            property.GetStatements.Add(returnStatment);
            return property;
        }

        /// <summary>
        /// Creates the following block of code
        ///  <code>
        ///     JsonSerializerSettings settings = new JsonSerializerSettings();
        ///     settings.NullValueHandling = NullValueHandling.Ignore;
        ///     this.newtonwJsonSerilizer = JsonSerializer.Create(settings);
        ///  </code>
        /// </summary>
        /// <returns>
        /// A <see cref="CodeStatementCollection"/>
        /// </returns>
        private CodeStatementCollection CreateSerilizerCreationBlock()
        {
            // JsonSerializerSettings settings = new JsonSerializerSettings()
            var settingsDeclarAndConstruct = new CodeVariableDeclarationStatement(
                typeof(JsonSerializerSettings), settingsVarName,
                new CodeObjectCreateExpression(typeof(JsonSerializerSettings)));

            // settings.NullValueHandling = NullValueHandling.Ignore;
            var assignNullValueHandling =
                new CodeAssignStatement(
                    new CodePropertyReferenceExpression(
                        new CodeVariableReferenceExpression(settingsVarName), "NullValueHandling"),
                    new CodeFieldReferenceExpression(
                        new CodeTypeReferenceExpression(typeof(NullValueHandling)), "Ignore"));

            // this.newtonwJsonSerilizer = JsonSerializer.Create(settings);
            var createSerilizerFromSettings =
                new CodeAssignStatement(
                    new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), FieldName),
                    new CodeMethodInvokeExpression(
                        new CodeTypeReferenceExpression(typeof(JsonSerializer)), "Create",
                        new CodeVariableReferenceExpression(settingsVarName)));

            var creationBlock = new CodeStatementCollection();
            creationBlock.Add(settingsDeclarAndConstruct);
            creationBlock.Add(assignNullValueHandling);
            creationBlock.Add(createSerilizerFromSettings);
            return creationBlock;
        }

        /// <summary>
        ///  Creates ObjectToJson method
        ///  <code>
        ///     public string ObjectToJson(object obj)
        ///     {
        ///         TextWriter tw = new StringWriter();
        ///         NewtonJsonSerilizer.Serialize(tw, obj);
        ///         return tw.ToString()
        ///     }
        ///  </code>
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberMethod CreateObjectToJson()
        {
            // public string ObjectToJson(object obj)
            var method = new CodeMemberMethod();
            method.Name = MethodName;
            method.Attributes = MemberAttributes.Public;
            method.Parameters.Add(new CodeParameterDeclarationExpression(new CodeTypeReference(typeof(object)), "obj"));
            method.ReturnType = new CodeTypeReference(typeof(string));

            // TextWriter tw = new StringWriter();
            var textWriterDeclaration = new CodeVariableDeclarationStatement();
            textWriterDeclaration.Name = "tw";
            textWriterDeclaration.Type = new CodeTypeReference(typeof(TextWriter));
            textWriterDeclaration.InitExpression = new CodeObjectCreateExpression(typeof(StringWriter));

            // this.NewtonJsonSerilizer.Serialize(tw, obj);
            var serializeCall = new CodeMethodInvokeExpression();
            serializeCall.Parameters.Add(new CodeVariableReferenceExpression("tw"));
            serializeCall.Parameters.Add(new CodeVariableReferenceExpression("obj"));
            serializeCall.Method =
                new CodeMethodReferenceExpression(
                    new CodePropertyReferenceExpression(new CodeThisReferenceExpression(), PropertyName), "Serialize");

            //return tw.ToString()
            var returnStatment = new CodeMethodReturnStatement();
            returnStatment.Expression = new CodeMethodInvokeExpression(
                new CodeVariableReferenceExpression("tw"), "ToString");

            method.Statements.Add(textWriterDeclaration);
            method.Statements.Add(serializeCall);
            method.Statements.Add(returnStatment);

            return method;
        }

        /// <summary>
        ///     <code>
        ///        public TOutput JsonToObject<TOutput>(Stream stream){
        ///            StreamReader streamReader = new StreamReader(stream);
        ///            string str = streamReader.ReadToEnd();
        ///            try{
        ///                 StandardResponse<TOutput> response = Newtonsoft.Json.JsonConvert.DeserializeObject<StandardResponse<TOutput>>(str);
        ///                 if (response.Data == null)
        ///                 {
        ///                     throw new ApplicationException(string.Format("Failed to get response from stream, error was [{0}]",response.Error));
        ///                 }
        ///                 return response.Data;
        ///            } catch(Exception ex) {
        ///                 throw new ApplicationExcetpion(
        ///                     string.Format("Failed to generate object of type [{0}] from Json[{1}]",
        ///                         typeof(TOutput).Name, str));
        ///            }
        ///        } 
        ///     </code> 
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberMethod CreateJsonToObject()
        {
            //public TOutput JsonToObject<TOutput>(Stream stream)
            var method = new CodeMemberMethod();
            var typeParameter = new CodeTypeParameter("TOutput");
            method.Name = "JsonToObject";
            method.Parameters.Add(new CodeParameterDeclarationExpression(typeof(Stream), "stream"));
            method.TypeParameters.Add(typeParameter);
            method.ReturnType = new CodeTypeReference(typeParameter);
            method.Attributes = MemberAttributes.Public;

            // StreamReader sr = new StreamReader(stream);
            var streamReaderDeclaration = new CodeVariableDeclarationStatement(
                typeof(StreamReader), "streamReader",
                new CodeObjectCreateExpression(typeof(StreamReader), new CodeVariableReferenceExpression("stream")));

            // string str = sr.ReadToEnd();
            var stringDeclaration = new CodeVariableDeclarationStatement(
                typeof(string), "str",
                new CodeMethodInvokeExpression(new CodeVariableReferenceExpression("streamReader"), "ReadToEnd"));

            var rethrow = CreateRethrowStatment();
            var returnStatment = CreateReturnStatment();

            var tryCatchReturn = new CodeTryCatchFinallyStatement();
            tryCatchReturn.TryStatements.AddRange(returnStatment);
            tryCatchReturn.CatchClauses.Add(
                new CodeCatchClause("ex", new CodeTypeReference(typeof(Exception)), rethrow));

            method.Statements.Add(streamReaderDeclaration);
            method.Statements.Add(stringDeclaration);
            method.Statements.Add(tryCatchReturn);

            return method;
        }


        /// <summary>
        /// <code>throw new ApplicationException(
        ///    string.Format("Failed to generate object of type[{0}] from Json[{1}]",typeof(TOutput).Name,str),ex);
        /// </code> 
        /// </summary>
        private CodeStatement CreateRethrowStatment()
        {
            var rethrow = new CodeThrowExceptionStatement();

            //string.Format
            var errorMessage = new CodeMethodInvokeExpression(new CodeTypeReferenceExpression(typeof(string)), "Format");
            // "Failed to generate object of type[{0}] from Json[{1}]"
            errorMessage.Parameters.Add(
                new CodePrimitiveExpression("Failed to generate object of type[{0}] from Json[{1}]"));
            //,typeof(TOutput).Name
            errorMessage.Parameters.Add(
                new CodePropertyReferenceExpression(new CodeTypeOfExpression("TOutput"), "Name"));
            //, str
            errorMessage.Parameters.Add(new CodeVariableReferenceExpression("str"));
            var localException = new CodeVariableReferenceExpression("ex");
            rethrow.ToThrow = new CodeObjectCreateExpression(typeof(ApplicationException), errorMessage, localException);
            return rethrow;
        }

        /// <summary>
        ///  create the following code
        ///  <code>
        ///    StandardResponse&lt;TOutput&gt; response = 
        ///        Newtonsoft.Json.JsonConvert.DeserializeObject&lt;StandardResponse&lt;TOutput&gt;&gt;(str);
        ///    if (response.Data == null)
        ///    {
        ///          throw new ApplicationException(string.Format("Failed to get response from stream, error was [{0}]",response.Error));
        ///    }
        ///    return response.Data;
        ///  </code>
        /// </summary>
        private static CodeStatementCollection CreateReturnStatment()
        {
            //StandardResponse<TOutput> response = 
            //        Newtonsoft.Json.JsonConvert.DeserializeObject<StandardResponse<TOutput>>;(str);
            var declareAndAssign =
                new CodeVariableDeclarationStatement(
                    new CodeTypeReference("Google.Apis.Util.StandardResponse", new CodeTypeReference("TOutput")),
                    "response");
            var initResponse = new CodeMethodInvokeExpression(
                new CodeTypeReferenceExpression(typeof(JsonConvert)), "DeserializeObject",
                new CodeVariableReferenceExpression("str"));
            var typeArgument = new CodeTypeReference(
                "Google.Apis.Util.StandardResponse", new CodeTypeReference("TOutput"));
            initResponse.Method.TypeArguments.Add(typeArgument);
            declareAndAssign.InitExpression = initResponse;

            //if (response.Data == null)
            //{
            //  throw new ApplicationException(string.Format("Failed to get response from stream, error was [{0}]",response.Error));
            //}
            var dataIsNull =
                new CodeBinaryOperatorExpression(
                    new CodePropertyReferenceExpression(new CodeVariableReferenceExpression("response"), "Data"),
                    CodeBinaryOperatorType.ValueEquality, new CodePrimitiveExpression(null));
            var createException = new CodeObjectCreateExpression(
                typeof(ApplicationException),
                new CodeMethodInvokeExpression(
                    new CodeTypeReferenceExpression(typeof(string)), "Format",
                    new CodePrimitiveExpression("Failed to get response from stream, error was [{0}]"),
                    new CodePropertyReferenceExpression(new CodeVariableReferenceExpression("response"), "Error")));
            var throwBecauseNoData = new CodeThrowExceptionStatement(createException);
            var throwIfDataNull = new CodeConditionStatement(dataIsNull, throwBecauseNoData);

            var returnResponseData =
                new CodeMethodReturnStatement(
                    new CodePropertyReferenceExpression(new CodeVariableReferenceExpression("response"), "Data"));

            var statments = new CodeStatementCollection();
            statments.Add(declareAndAssign);
            statments.Add(throwIfDataNull);
            statments.Add(returnResponseData);
            return statments;
        }
    }
}