using System;
using System.CodeDom;
using System.Collections.Generic;
using NUnit.Framework;
using Google.Apis.Tests.Apis.Requests;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ResourceDecorator
{
    /// <summary>
    /// Test class for the "DefaultEnglishCommentCreator"
    /// </summary>
    [TestFixture]
    public class DefaultEnglishCommentCreatorTest
    {
        /// <summary>
        /// Tests if a comment is generated correctly
        /// </summary>
        [Test]
        public void CreateMethodComment()
        {
            var method = new MockMethod();
            var instance = new DefaultEnglishCommentCreator();
            method.Description = "A Test description";

            CodeCommentStatementCollection result = instance.CreateMethodComment(method);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.IsNotNull(result[0].Comment);
            Assert.AreEqual("<summary>A Test description</summary>", result[0].Comment.Text);

            method.Description = "A <nasty> \"description\"";
            result = instance.CreateMethodComment(method);
            Assert.AreEqual("<summary>A &lt;nasty&gt; &quot;description&quot;</summary>", result[0].Comment.Text);
        }

        /// <summary>
        /// Tests if the creator validates input parameters
        /// </summary>
        [Test]
        public void CreateMethodCommentValidateParams()
        {
            var instance = new DefaultEnglishCommentCreator();
            Assert.Throws(typeof(ArgumentNullException), () => instance.CreateMethodComment(null));
        }

        /// <summary>
        /// Tests comments for parameters
        /// </summary>
        [Test]
        public void CreateParameterComment()
        {
            var instance = new DefaultEnglishCommentCreator();
            var parameter = new MockParameter();
            var progamaticName = "testParameter";

            CodeCommentStatementCollection result = instance.CreateParameterComment(parameter, progamaticName);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.IsNotNull(result[0].Comment);
            Assert.AreEqual("<param name=\"testParameter\">Optional</param>", result[0].Comment.Text);
        }

        /// <summary>
        /// Tests if the creator validates inputs for parameter comments
        /// </summary>
        [Test]
        public void CreateParameterCommentValidateParams()
        {
            var instance = new DefaultEnglishCommentCreator();
            var parameter = new MockParameter();
            string progamaticName = null;

            Assert.Throws(
                typeof(ArgumentNullException), () => instance.CreateParameterComment(parameter, progamaticName));

            progamaticName = "";
            Assert.Throws(typeof(ArgumentException), () => instance.CreateParameterComment(parameter, progamaticName));

            progamaticName = "testParameter";
            parameter = null;
            Assert.Throws(
                typeof(ArgumentNullException), () => instance.CreateParameterComment(parameter, progamaticName));
        }

        /// <summary>
        /// Tests if meta data is generated correctly
        /// </summary>
        [Test]
        public void GetParameterMetaData()
        {
            var instance = new DefaultEnglishCommentCreator();
            var parameter = new MockParameter();
            var progamaticName = "testParameter";
            parameter.Name = progamaticName;
            parameter.IsRequired = false;

            string result = instance.GetParameterMetaData(parameter, progamaticName);
            Assert.AreEqual("Optional", result);

            parameter.IsRequired = true;
            result = instance.GetParameterMetaData(parameter, progamaticName);
            Assert.AreEqual("Required", result);

            parameter.Name = "test-parameters";
            result = instance.GetParameterMetaData(parameter, progamaticName);
            Assert.AreEqual("test-parameters - Required", result);

            parameter.Name = progamaticName;
            parameter.Minimum = "53";
            result = instance.GetParameterMetaData(parameter, progamaticName);
            Assert.AreEqual("Required - Minimum value of 53", result);

            parameter.Minimum = null;
            parameter.Maximum = "105";
            result = instance.GetParameterMetaData(parameter, progamaticName);
            Assert.AreEqual("Required - Maximum value of 105", result);

            parameter.Maximum = null;
            parameter.Pattern = ".*\\.java";
            result = instance.GetParameterMetaData(parameter, progamaticName);
            Assert.AreEqual("Required - Must match pattern .*\\.java", result);

            parameter.Pattern = null;
            parameter.EnumValues = new List<string> { "a", "b", "c", "d" };
            result = instance.GetParameterMetaData(parameter, progamaticName);
            Assert.AreEqual("Required - Must be one of the following values [a, b, c, d]", result);

            parameter.EnumValues = null;
            parameter.Description = "A Test Description";
            result = instance.GetParameterMetaData(parameter, progamaticName);
            Assert.AreEqual("Required - A Test Description", result);
        }
    }
}