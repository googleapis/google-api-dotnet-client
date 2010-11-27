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

using System;
using System.Collections.Generic;

namespace Google.Apis.Tools.CodeGen.Tests
{
	public abstract class BaseResourceDecoratorTest
	{
		protected const string SERVICE_CLASS_NAME = "Google.Apis.Tools.CodeGen.Tests.TestServiceClass";
		protected const string RESOURCE_CLASS_NAME = "Google.Apis.Tools.CodeGen.Tests.TestResourceClass";
		protected const string RESOURCE_NAME = "TestResource";
		
		protected KeyValuePair<string, object> CreateJsonResourceDefinition(){
			JSON.JSONDictionary json = new JSON.JSONDictionary();
			
			return new KeyValuePair<string, object>(RESOURCE_NAME,json);
		}
	}
}