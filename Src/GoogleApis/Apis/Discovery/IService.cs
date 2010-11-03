
using System;
using System.Collections.Generic;

using Google.Apis.Requests;

namespace Google.Apis.Discovery {


	public interface IService {
		string Name {get;}
		string Version {get;}
		Uri BaseUri {get;}
		Uri RpcUri {get;}

		Dictionary<string, Resource> Resources {get;}

		/// <summary>
		/// Creates a Request Object based on the HTTP Method Type.
		/// </summary>
		Request CreateRequest (string resource, string methodName);		
	}
}
