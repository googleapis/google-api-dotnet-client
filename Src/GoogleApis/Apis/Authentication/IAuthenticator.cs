
using System;
using System.Net;

namespace Google.Apis.Authentication {
	public interface IAuthenticator {
		HttpWebRequest CreateHttpWebRequest (string httpMethod, Uri targetUri);		
	}
}
