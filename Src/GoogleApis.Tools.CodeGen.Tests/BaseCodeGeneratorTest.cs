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
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Google.Apis.Discovery;

using log4net;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests
{
	/// <summary>
	/// Is a base class for testing of code generators
	/// </summary>
	public abstract class BaseCodeGeneratorTest
	{
		public enum TestMethodNames{
			getTest,
			postTest,
			noParameterTest,
			oneOptionalParameterTest,
			oneRequiredParameterTest
		}
		
		protected const string ServiceClassName = "Google.Apis.Tools.CodeGen.Tests.TestServiceClass";
		protected const string ResourceClassName = "Google.Apis.Tools.CodeGen.Tests.TestResourceClass";
		protected const string ResourceName = "TestResource";
		protected const string ResourceAsJson = @"
		{
			""methods"":{
				""getTest"":{
					""pathUrl"":""activities/count"",
					""rpcName"":""chili.activities.count"",
					""httpMethod"":""GET"",
					""methodType"":""rest"",
					""parameters"":{
						""req_a"":{""parameterType"":""query"",""required"":true},
						""req_b"":{""parameterType"":""query"",""required"":true},
						""opt_a"":{""parameterType"":""query"",""required"":false},
						""opt_b"":{""parameterType"":""query"",""required"":false}
					}
				},
				""postTest"":{
					""pathUrl"":""activities/{userId}/{scope}/{postId}"",
					""rpcName"":""chili.activities.delete"",
					""httpMethod"":""POST"",
					""methodType"":""rest"",
					""parameters"":{
						""opt_a"":{""parameterType"":""query"",""required"":false},
						""opt_b"":{""parameterType"":""query"",""required"":false},
						""req_a"":{""parameterType"":""path"",""pattern"":"".*"",""required"":true},
						""req_b"":{""parameterType"":""path"",""pattern"":""@.*"",""required"":true},
						""req_c"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}
					}
				},
				""noParameterTest"":{
					""pathUrl"":""activities/count"",
					""rpcName"":""chili.activities.count"",
					""httpMethod"":""GET"",
					""methodType"":""rest"",
					""parameters"":null
				},
				""oneOptionalParameterTest"":{
					""pathUrl"":""activities/count"",
					""rpcName"":""chili.activities.count"",
					""httpMethod"":""GET"",
					""methodType"":""rest"",
					""parameters"":{""opt_a"":{""parameterType"":""query"",""required"":false}}
				},
				""oneRequiredParameterTest"":{
					""pathUrl"":""activities/count"",
					""rpcName"":""chili.activities.count"",
					""httpMethod"":""GET"",
					""methodType"":""rest"",
					""parameters"":{""opt_a"":{""parameterType"":""query"",""required"":true}}
				}
			}
		}
		";
		
		protected const string SimpleResource = @"
		{
			""methods"":{
				""simpleMethod"":{
					""pathUrl"":""activities/count"",
					""rpcName"":""chili.activities.count"",
					""httpMethod"":""GET"",
					""methodType"":""rest"",
					""parameters"":null
				}
			}
		}
		";
		
		protected KeyValuePair<string, object> CreateJsonResourceDefinition(string resourceName, string jsonString){
			JSON.JSONDictionary json = (JSON.JSONDictionary)JSON.JSONReader.Parse(jsonString);
			
			return new KeyValuePair<string, object>(resourceName, json);
		}
		
		protected Resource CreateResource(string resourceName, string json){
			return new Resource(CreateJsonResourceDefinition(resourceName, json));
		}
		
		/// <summary>
		/// Test our assumptions about the string ResourceAsJson are correct.
		/// </summary>
		[Test()]
		public void TestCreateResource(){
			var resource = CreateResource(ResourceName, ResourceAsJson);
			Assert.AreEqual(ResourceName, resource.Name);
			Assert.AreEqual(Enum.GetValues(typeof(TestMethodNames)).Length, resource.Methods.Count);
			// Test one
			Assert.IsNotNull(resource.Methods["postTest"]);
			
			// Then test all
			foreach(TestMethodNames name in Enum.GetValues(typeof(TestMethodNames)))
			{
				Assert.IsNotNull(resource.Methods[name.ToString()]);
			}
			
		}
		
		protected void AddRefereenceToDelararingAssembly(Type target, CompilerParameters cp)
		{
			cp.ReferencedAssemblies.Add(target.Assembly.CodeBase);
		}
		
		protected void CheckCompile(CodeTypeDeclaration codeType, bool warnAsError,  string errorMessage)
		{
			CodeCompileUnit compileUnit = new CodeCompileUnit();
			var client = new CodeNamespace ("Google.Apis.Tools.CodeGen.Tests");
			compileUnit.Namespaces.Add (client);
			client.Types.Add(codeType);
			
			CheckCompile(compileUnit, warnAsError, errorMessage);
		}
		
		protected void CheckCompile(CodeCompileUnit codeCompileUnit, bool warnAsError, string errorMessage)
		{
			var language = "CSharp";
			var provider = CodeDomProvider.CreateProvider(language);
			CompilerParameters cp = new CompilerParameters();
			// Add an assembly reference.
			   cp.ReferencedAssemblies.Add( "System.dll" );
			AddRefereenceToDelararingAssembly(typeof(DiscoveryService), cp);
			AddRefereenceToDelararingAssembly(typeof(ILog), cp);
			
			cp.GenerateExecutable = false;		
			cp.GenerateInMemory = true;
			cp.TreatWarningsAsErrors = warnAsError; // Warnings are errors.
			
			CompilerResults compilerResults = provider.CompileAssemblyFromDom (cp, codeCompileUnit);
			bool hasError = false;
			if ( compilerResults.Errors.Count > 0 )
			{
				var sb = new StringBuilder(errorMessage).AppendLine();
				foreach(CompilerError error in compilerResults.Errors)
				{
					sb.AppendLine(error.ToString());
					if(error.IsWarning == false || warnAsError)
					{
						hasError = true;	
					}
				}
				sb.AppendLine();
				sb.AppendLine("Generated Code Follows");
				
				using(StringWriter sw = new StringWriter(sb))
				{
					IndentedTextWriter tw = new IndentedTextWriter(sw);
					provider.GenerateCodeFromCompileUnit(codeCompileUnit, tw, new CodeGeneratorOptions());
				}
				Console.Out.WriteLine(sb.ToString());
				
				if(hasError)
				{
					Assert.Fail(sb.ToString());
				}
			}
		}
	}
}

