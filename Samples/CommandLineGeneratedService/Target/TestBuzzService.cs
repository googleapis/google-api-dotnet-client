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

using NUnit.Framework;

using Google.Apis.Discovery;
using Google.Apis.Samples.CommandLineGeneratedService.Buzz;

using Google.Apis.Testing;

namespace Google.Apis.Samples.CommandLineGeneratedService.Target
{

	[TestFixture]
	public class TestBuzzService
	{
		[Test]
		public void TestPersonSearchFullParameters(){
			/*
			var mockService = new MockService();
			BuzzService testService = new BuzzService(mockService, null);
			testService.People.Search("alt","c", "hl", "max-results", "q");
			
			Assert.True(mockService.Request.HasExecuted);
			Assert.AreEqual(mockService.Request.Parameters["alt"], "alt");
			Assert.AreEqual(mockService.Request.Parameters["c"], "c");
			Assert.AreEqual(mockService.Request.Parameters["max-results"], "max-results");
			Assert.AreEqual(mockService.Request.Parameters["q"], "q");
			*/
		}
	}
}
