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
using System.IO;
using System.Collections.Generic;
using NUnit.Framework;

using Google.Apis.Discovery;
using Google.Apis.Json;

namespace Google.Apis.Tests.Requests
{
	[TestFixture()]
	public class MethodValidatorTests
	{
		[Test()]
		public void ConstructorTest ()
		{
			Method m = new Method();
			m.Name = "Test";
			
            Assert.IsInstanceOf<MethodValidator>(new MethodValidator(m, new Dictionary<string, string>()));
		}
		
		[Test()]
		public void ValidateRegexTest ()
		{
			Method m = new Method();
			var dict = new JsonDictionary { 
				{ "name" , "test" },
				{ "pattern", ".+" }
			};
			
			var jsonObj = new KeyValuePair<string, object>("test", dict );
			
			
			var p = new Parameter(jsonObj);
			var inputData =  new Dictionary<string, string>();
			var validator = new MethodValidator(m, inputData );
			Assert.IsTrue(validator.ValidateRegex(p, "Test"));
		}
		
		[Test()]
		public void ValidateRegexEmptyNeedsDataTest ()
		{
			Method m = new Method();
			var dict = new JsonDictionary { 
				{ "name" , "test" },
				{ "pattern", ".+" }
			};
			
			var jsonObj = new KeyValuePair<string, object>("test", dict );
			
			
			var p = new Parameter(jsonObj);
			var inputData =  new Dictionary<string, string>();
			var validator = new MethodValidator(m, inputData );
			
			Assert.IsFalse(validator.ValidateRegex(p, ""));
		}
	}
}

