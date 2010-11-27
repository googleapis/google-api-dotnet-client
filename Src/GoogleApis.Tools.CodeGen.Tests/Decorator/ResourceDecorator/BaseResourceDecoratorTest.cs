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
using System.Collections.Generic;

using NUnit.Framework;

using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen.Tests
{
	public abstract class BaseResourceDecoratorTest
	{
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
						""opt_b"":{""parameterType"":""query"",""required"":false},
					}
				},
				""postTest"":{
					""pathUrl"":""activities/{userId}/{scope}/{postId}"",
					""rpcName"":""chili.activities.delete"",
					""httpMethod"":""POST"",
					""methodType"":""rest"",
					""parameters"":{
						""alt"":{""parameterType"":""query"",""required"":false},
						""hl"":{""parameterType"":""query"",""required"":false},
						""postId"":{""parameterType"":""path"",""pattern"":"".*"",""required"":true},
						""scope"":{""parameterType"":""path"",""pattern"":""@.*"",""required"":true},
						""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}
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