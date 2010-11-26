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
using Google.Apis.Discovery;
using Google.Apis.Requests;
using System.Collections.Generic;

namespace Google.Apis.Testing {
	public class MockService : IService {
		public MockRequest Request { get; set; }

		public IRequest CreateRequest(string resource, string methodName) {
			Request = new MockRequest();
			return Request;
		}

		public string Name {
			get {
				throw new System.NotImplementedException();
			}
		}

		public string Version {
			get {
				throw new System.NotImplementedException();
			}
		}

		public Uri BaseUri {
			get {
				throw new System.NotImplementedException();
			}
		}

		public Uri RpcUri {
			get {
				throw new System.NotImplementedException();
			}
		}

		public IDictionary<string, Resource> Resources {
			get {
				throw new System.NotImplementedException();
			}
		}

		public MockService() {
		}
	}
}

