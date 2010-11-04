
using System;
using System.Net;

namespace Google.Apis {
	public interface IAuthenticator {
		HttpWebRequest CreateHttpWebRequest (string httpMethod, Uri targetUri);		
	}
}
