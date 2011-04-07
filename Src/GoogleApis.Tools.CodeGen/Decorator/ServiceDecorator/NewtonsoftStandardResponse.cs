using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Apis.Testing;
using System.CodeDom;
using Newtonsoft.Json;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Adds a class to the service which pulls out the data of the response.
    ///   <code>
    ///     private class StandardResponse&lt;InnerType&gt;
    ///     {
    ///         private InnerType data;
    ///         private string error;
    ///
    ///         [Newtonsoft.Json.JsonPropertyAttribute("data")]
    ///         public InnerType Data
    ///         {
    ///             get { return data; }
    ///             set { this.data = value; }
    ///         }
    ///
    ///         [Newtonsoft.Json.JsonPropertyAttribute("error")]
    ///         public string Error
    ///         {
    ///             get { return error; }
    ///             set { this.error = value; }
    ///        }
    ///     }
    ///   </code>
    /// </summary>
    public class NewtonsoftStandardResponse: IServiceDecorator
    {
        [VisibleForTestOnly]
        internal CodeTypeDeclaration CreateStandardResponseClass()
        {
            CodeTypeDeclaration innerClass = new CodeTypeDeclaration("StandardResponse");
            innerClass.Attributes = MemberAttributes.Private;
            innerClass.TypeParameters.Add("InnerType");

            innerClass.Members.Add(CreateStandardResponseFieldData());
            innerClass.Members.Add(CreateStandardResponseFieldError());
            innerClass.Members.Add(CreateStandardResponsePropertyData());
            innerClass.Members.Add(CreateStandardResponsePropertyError());

            return innerClass;
        }

        [VisibleForTestOnly]
        internal CodeMemberField CreateStandardResponseFieldData()
        {
            var field = new CodeMemberField();
            field.Type = new CodeTypeReference("InnerType");
            field.Name = "data";
            field.Attributes = MemberAttributes.Private;
            return field;
        }

        [VisibleForTestOnly]
        internal CodeTypeMember CreateStandardResponseFieldError()
        {
            var field = new CodeMemberField();
            field.Type = new CodeTypeReference(typeof(string));
            field.Name = "error";
            field.Attributes = MemberAttributes.Private;
            return field;
        }

        [VisibleForTestOnly]
        internal CodeTypeMember CreateStandardResponsePropertyData()
        {
            // [Newtonsoft.Json.JsonPropertyAttribute("data")]
            // public InnerType Data{get{...} set{...}}
            var property = new CodeMemberProperty();
            property.Name = "Data";
            property.Type = new CodeTypeReference("InnerType");
            property.HasGet = true;
            property.HasSet = true;
            property.Attributes = MemberAttributes.Public;

            // get { return data; }
            property.GetStatements.Add(
                new CodeMethodReturnStatement(
                    new CodeFieldReferenceExpression(
                        new CodeThisReferenceExpression(), "data")));
            // set { this.data = value; }
            property.SetStatements.Add(
                new CodeAssignStatement(
                    new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "data"),
                    new CodeVariableReferenceExpression("value")));

            //
            property.CustomAttributes.Add(new CodeAttributeDeclaration(
                new CodeTypeReference(typeof(JsonPropertyAttribute)),
                new CodeAttributeArgument(new CodePrimitiveExpression("data"))));

            return property;
        }

        [VisibleForTestOnly]
        internal CodeTypeMember CreateStandardResponsePropertyError()
        {
            // [Newtonsoft.Json.JsonPropertyAttribute("error")]
            // public string Error{get{...} set{...}}
            var property = new CodeMemberProperty();
            property.Name = "Error";
            property.Type = new CodeTypeReference(typeof(string));
            property.HasGet = true;
            property.HasSet = true;
            property.Attributes = MemberAttributes.Public;

            // get { return data; }
            property.GetStatements.Add(
                new CodeMethodReturnStatement(
                    new CodeFieldReferenceExpression(
                        new CodeThisReferenceExpression(), "error")));
            // set { this.data = value; }
            property.SetStatements.Add(
                new CodeAssignStatement(
                    new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "error"),
                    new CodeVariableReferenceExpression("value")));

            //
            property.CustomAttributes.Add(new CodeAttributeDeclaration(
                new CodeTypeReference(typeof(JsonPropertyAttribute)),
                new CodeAttributeArgument(new CodePrimitiveExpression("error"))));

            return property;
        }

        public void DecorateClass(Discovery.IService service, CodeTypeDeclaration serviceClass)
        {
            serviceClass.Members.Add(CreateStandardResponseClass());
        }
    }
}
