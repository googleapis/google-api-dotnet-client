/*
Copyright 2010 Google Inc

Licensed under the Apache License, Version 2.0 (the ""License"");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an ""AS IS"" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Google.Apis.Discovery;
using Google.Apis.Tests.Apis.Requests;
using Google.Apis.Tools.CodeGen.Generator;

using NUnit.Framework;
namespace Google.Apis.Tools.CodeGen.Tests
{
	/// <summary>
	/// Test the class ResourceBaseGenerator
	/// </summary>
	[TestFixture()]
	public class ResourceBaseGeneratorTest: BaseCodeGeneratorTest
	{
		[Test()]
		public void TestResourceCallAddBodyDeclaration(){
			var method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.getTest);
			var tester = new ForTestOnly();
			var member = new CodeMemberMethod();
			
			tester.ResourceCallAddBodyDeclaration(method, member, new CodeTypeReference(typeof(string)));
			Assert.AreEqual(0, member.Parameters.Count);
			
			method = GetMethod(BaseCodeGeneratorTest.TestMethodNames.postTest);
			member = new CodeMemberMethod();
			tester.ResourceCallAddBodyDeclaration(method, member, new CodeTypeReference(typeof(string)));
			Assert.AreEqual(1, member.Parameters.Count);
			
		}
        
        [Test()]
        public void TestGetParameterType()
        {
            Assert.Throws(typeof(ArgumentNullException), () => ResourceBaseGenerator.GetParameterType(null));
            
            MockParameter param = new MockParameter();

            // Null => string
            param.ValueType = null;
            Assert.AreEqual(typeof(string), ResourceBaseGenerator.GetParameterType(param));
            
            // "" => string
            param.ValueType = "";
            Assert.AreEqual(typeof(string), ResourceBaseGenerator.GetParameterType(param));
            
            // "string" => string
            param.ValueType = "string";
            Assert.AreEqual(typeof(string), ResourceBaseGenerator.GetParameterType(param));
            
            // "integer" => long
            param.ValueType = "integer";
            Assert.AreEqual(typeof(long), ResourceBaseGenerator.GetParameterType(param));
                        
            // "boolean" => bool
            param.ValueType = "boolean";
            Assert.AreEqual(typeof(bool), ResourceBaseGenerator.GetParameterType(param));
            
            // "AnyOldRubbish" => string
            param.ValueType = "AGreatBigFish";
            Assert.AreEqual(typeof(string), ResourceBaseGenerator.GetParameterType(param));
            
        }
		
		#region Helper methods
		
		public IMethod GetMethod(BaseCodeGeneratorTest.TestMethodNames testMethod){
			var resource = BaseCodeGeneratorTest.CreateResourceDivcoveryV_0_1 (ResourceName, ResourceAsJson);
			return resource.Methods[testMethod.ToString()];
		}
		
		#endregion
		
		#region ForTestOnly : ResourceBaseGenerator
		/// <summary>
		///     For testing of ResourceBaseGenerator, extend and make public all methods and fields
		/// </summary>
		private class ForTestOnly: ResourceBaseGenerator{
			new public const string ResourceNameConst = ResourceBaseGenerator.ResourceNameConst;		
			
			new public void ResourceCallAddBodyDeclaration(
                    IMethod method, CodeMemberMethod member, CodeTypeReference codeType) {
				base.ResourceCallAddBodyDeclaration(method, member, codeType);
			}
			
			new public CodeParameterDeclarationExpression DeclareInputParameter(
					IParameter param, int parameterCount, IMethod method){
				return  base.DeclareInputParameter(param, parameterCount, method);
			}
			
			new public CodeAssignStatement AssignParameterToDictionary(
					IParameter param, int parameterCount, IMethod method){
				return base.AssignParameterToDictionary(param, parameterCount, method);
			}
			
			new public CodeStatement CreateExecuteRequest(IMethod method){
				return base.CreateExecuteRequest(method);
			}
			
			override protected string GetClassName(){
				return "TestClassName";
			}
		}
		#endregion
	}
}

