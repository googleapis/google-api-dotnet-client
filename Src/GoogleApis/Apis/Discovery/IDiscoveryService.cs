
using System;

namespace Google.Apis.Discovery {
	
	public interface IDiscoveryService {
		IService GetService(string version);
	}
}
