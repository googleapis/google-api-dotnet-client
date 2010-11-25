using System;
using Google.Apis.Discovery;

namespace Google.Apis.Tools.CodeGen.Testing {
	public class MockService:IService {
		#region IService implementation
		public Google.Apis.Requests.Request CreateRequest (string resource, string methodName)
		{
			throw new System.NotImplementedException();
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
		
		
		public System.Collections.Generic.Dictionary<string, Resource> Resources {
			get {
				throw new System.NotImplementedException();
			}
		}
		
		#endregion
		public MockService() {
		}
	}
}

