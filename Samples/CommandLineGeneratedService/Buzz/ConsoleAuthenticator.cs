using System;
using Google.Apis.Authentication;

namespace Google.Apis.Samples.CommandLineGeneratedService.Buzz
{
	public class ConsoleAuthenticator:IAuthenticator
	{
		public System.Net.HttpWebRequest CreateHttpWebRequest (string httpMethod, Uri targetUri)
		{
			throw new System.NotImplementedException();
		}
		
		public ConsoleAuthenticator ()
		{
		}
	}
}

