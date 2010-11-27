using System;
using System.CodeDom;
using System.Collections.Generic;

using Google.Apis.Discovery;

using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests
{
	public abstract class BaseCodeGeneratorTest
	{
		public enum TestMethodNames{
			getTest,
			postTest
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
				}
			}
		}
		";
		
		protected KeyValuePair<string, object> CreateJsonResourceDefinition(){
			JSON.JSONDictionary json = (JSON.JSONDictionary)JSON.JSONReader.Parse(ResourceAsJson);
			
			return new KeyValuePair<string, object>(ResourceName,json);
		}
		
		protected Resource CreateResource(){
			return new Resource(CreateJsonResourceDefinition());
		}
		
		/// <summary>
		/// Test our assumptions about the string ResourceAsJson are correct.
		/// </summary>
		[Test()]
		public void TestCreateResource(){
			var resource = CreateResource();
			Assert.AreEqual(ResourceName, resource.Name);
			Assert.AreEqual(2, resource.Methods.Count);
			Assert.IsNotNull(resource.Methods["getTest"]);
			Assert.IsNotNull(resource.Methods["postTest"]);
		}
	}
}

