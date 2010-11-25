using System;
using System.IO;
using System.Collections.Generic;
using Google.Apis.Authentication;

namespace Google.Apis.Requests {
	public interface IRequest {
		IRequest On(string rpcName);
		IRequest Returning(ReturnType returnType);
		IRequest WithParameters(IDictionary<string, string> parameters);
		IRequest WithParameters(string parameters);
		IRequest WithBody(Dictionary<string, string> parameters);
		IRequest WithBody(string body);
		IRequest WithAuthentication(IAuthenticator authenticator); 
		Stream ExecuteRequest();
	}
}

