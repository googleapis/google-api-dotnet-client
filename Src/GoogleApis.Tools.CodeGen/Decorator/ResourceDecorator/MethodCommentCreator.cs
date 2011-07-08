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
using System.Linq;
using System.Security;
using System.Text;
using Google.Apis.Discovery;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator
{
    /// <summary> 
    ///   Abstract out the process for creating comments on methods.
    /// </summary>
    public interface IMethodCommentCreator
    {
        CodeCommentStatementCollection CreateParameterComment(IParameter parameter, string programaticName);
        CodeCommentStatementCollection CreateMethodComment(IMethod method);
    }

    /// <summary>
    /// The default implementation for IMethodCommentCreator. Creates comments based on meta data and description 
    /// </summary>
    public class DefaultEnglishCommentCreator : IMethodCommentCreator
    {
        #region IMethodCommentCreator Members

        public CodeCommentStatementCollection CreateParameterComment(IParameter parameter, string programaticName)
        {
            parameter.ThrowIfNull("parameter");
            programaticName.ThrowIfNullOrEmpty("programaticName");

            var commentText = string.Format(
                "<param name=\"{0}\">{1}</param>", programaticName,
                XmlEscapeComment(GetParameterMetaData(parameter, programaticName)));

            var ret = new CodeCommentStatementCollection();
            ret.Add(new CodeCommentStatement(new CodeComment(commentText, true)));
            return ret;
        }

        public CodeCommentStatementCollection CreateMethodComment(IMethod method)
        {
            method.ThrowIfNull("method");
            var ret = new CodeCommentStatementCollection();

            if (method.Description.IsNotNullOrEmpty())
            {
                string commentText = string.Format("<summary>{0}</summary>", XmlEscapeComment(method.Description));
                ret.Add(new CodeCommentStatement(new CodeComment(commentText, true)));
            }
            return ret;
        }

        #endregion

        [VisibleForTestOnly]
        internal string GetParameterMetaData(IParameter param, string programaticName)
        {
            var strings = new List<string>();
            if (param.Name != programaticName && param.Name.IsNotNullOrEmpty())
            {
                strings.Add(param.Name);
            }

            if (param.IsRequired)
            {
                strings.Add("Required");
            }
            else
            {
                strings.Add("Optional");
            }

            if (param.Pattern.IsNotNullOrEmpty())
            {
                strings.Add("Must match pattern " + param.Pattern);
            }

            if (param.Minimum.IsNotNullOrEmpty())
            {
                strings.Add("Minimum value of " + param.Minimum);
            }

            if (param.Maximum.IsNotNullOrEmpty())
            {
                strings.Add("Maximum value of " + param.Maximum);
            }

            IList<string> enumValues = param.EnumValues != null ? param.EnumValues.ToList() : null;
            if (enumValues.IsNotNullOrEmpty())
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Must be one of the following values [");
                sb.Append(string.Join(", ", enumValues.ToArray()));
                sb.Append("]");
                strings.Add(sb.ToString());
            }

            if (param.Description.IsNotNullOrEmpty())
            {
                strings.Add(param.Description);
            }

            return string.Join(" - ", strings.ToArray());
        }

        private string XmlEscapeComment(string description)
        {
            return SecurityElement.Escape(description);
        }
    }
}