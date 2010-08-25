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

namespace Google.Apis.Tests
{
	public class StubDiscoveryDevice: IDiscoveryDevice {
		public Stream Fetch() {
			return Stream.Null;	
		}
		#region IDisposable implementation
		public void Dispose ()
		{
			throw new System.NotImplementedException();
		}
		
		#endregion
	}
	
	[TestFixture()]
	public class DiscoveryTests
	{
		[Test()]
		public void Construct () {
			Assert.IsInstanceOfType(typeof(DiscoveryService), new DiscoveryService(null));
		}
		
		[Test()]
		public void ConstructWithDiscoveryDevice() {
			var d = new DiscoveryService(new StubDiscoveryDevice());
			Assert.IsInstanceOfType(typeof(StubDiscoveryDevice), d.DiscoveryDevice);
		}
		
		[Test()]
		public void Create() {
			var d = new DiscoveryService(new StubDiscoveryDevice());
			
		}
			
	}
}

