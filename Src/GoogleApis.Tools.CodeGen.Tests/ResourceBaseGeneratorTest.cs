using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Google.Apis.Discovery;

using NUnit.Framework;
namespace Google.Apis.Tools.CodeGen.Tests
{
	[TestFixture()]
	public class ResourceBaseGeneratorTest: BaseCodeGeneratorTest
	{
		[Test()]
		public void TestGetRequiredParameters(){
			var resource = this.CreateResource ();
			var method = resource.Methods[BaseCodeGeneratorTest.TestMethodNames.getTest.ToString()];
			var tester = new ForTestOnly();
			List<Parameter> parameters = tester.GetRequiredParameters(method).ToList();
			Assert.AreEqual(2, parameters.Count);
			Assert.AreEqual("req_a", parameters[0].Name);
			Assert.AreEqual("req_b", parameters[1].Name);
		}
		
		[Test()]
		public void TestGetOptionalParameters(){
			var resource = this.CreateResource ();
			var method = resource.Methods[BaseCodeGeneratorTest.TestMethodNames.getTest.ToString()];
			var tester = new ForTestOnly();
			List<Parameter> parameters = tester.GetOptionalParameters(method).ToList();
			Assert.AreEqual(2, parameters.Count);
			Assert.AreEqual("opt_a", parameters[0].Name);
			Assert.AreEqual("opt_b", parameters[1].Name);
		}
		
		#region ForTestOnly : ResourceBaseGenerator
		/// <summary>
		/// For testing of ResourceBaseGenerator, extend and make public all methods and fields
		/// </summary>
		private class ForTestOnly: ResourceBaseGenerator{
			new public const string ResourceNameConst = ResourceBaseGenerator.ResourceNameConst;		
			new public const string ParameterDictionaryName = ResourceBaseGenerator.ParameterDictionaryName;
			new public const string ReturnVariableName = ResourceBaseGenerator.ReturnVariableName;
	
			new	public IEnumerable<Parameter> GetRequiredParameters(Method method){
					return base.GetRequiredParameters(method);
			}
	
			
			new public IEnumerable<Parameter> GetOptionalParameters(Method method){
				return base.GetOptionalParameters(method);
			}
			
			new public bool HasOptionalParameters(Method method){
				return base.HasOptionalParameters(method);
			}
			
			new public void ResourceCallAddBodyDeclaration(Method method, CodeMemberMethod member) {
				base.ResourceCallAddBodyDeclaration(method, member);
			}
			
			new public CodeParameterDeclarationExpression DeclareInputParameter(
					Parameter param, 
				    int parameterCount){
				return  base.DeclareInputParameter(param, parameterCount);
			}
			
			new public CodeAssignStatement AssignParameterToDictionary(
					Parameter param, 
				    int parameterCount){
				return base.AssignParameterToDictionary(param, parameterCount);
			}
			
			new public CodeStatement CreateExecuteRequest(Method method){
				return base.CreateExecuteRequest(method);
			}
			
			override protected string GetClassName(){
				return "TestClassName";
			}
		}
		#endregion
	}
}

