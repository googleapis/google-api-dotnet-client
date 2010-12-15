using System;
using System.IO;
using System.Text;
using System.Linq;


using NUnit.Framework;

using Google.Apis.Discovery;

namespace Google.Apis.Tests.Apis.Discovery
{


    [TestFixture()]
    public class ServiceFactoryTest
    {
        private const string V02_SAMPLE_DISCOVERY = @"

{
 ""name"": ""adsense-mgmt"",
 ""version"": ""v1beta1"",
 ""description"": ""AdSense Management API"",
 ""restBasePath"": ""/adsense-mgmt/v1beta1/"",
 ""rpcPath"": ""/rpc"",
 ""resources"": {
  ""mgmt"": {
   ""resources"": {
    ""adunits"": {
     ""methods"": {
      ""list"": {
       ""restPath"": ""web_properties/{property_code}/ad_units"",
       ""rpcMethod"": ""adsense.mgmt.adunits.list"",
       ""httpMethod"": ""GET"",
       ""parameters"": {
        ""property_code"": {
         ""restParameterType"": ""path"",
         ""pattern"": ""[^/]+"",
         ""required"": true
        }
       }
      }
     }
    },
    ""customchannels"": {
     ""methods"": {
      ""list"": {
       ""restPath"": ""web_properties/{property_code}/custom_channels"",
       ""rpcMethod"": ""adsense.mgmt.customchannels.list"",
       ""httpMethod"": ""GET"",
       ""parameters"": {
        ""property_code"": {
         ""restParameterType"": ""path"",
         ""pattern"": ""[^/]+"",
         ""required"": true
        }
       }
      }
     }
    },
    ""reports"": {
     ""methods"": {
      ""generate"": {
       ""restPath"": ""reports/generate"",
       ""rpcMethod"": ""adsense.mgmt.reports.generate"",
       ""httpMethod"": ""GET""
      }
     }
    },
    ""urlchannels"": {
     ""methods"": {
      ""list"": {
       ""restPath"": ""web_properties/{property_code}/url_channels"",
       ""rpcMethod"": ""adsense.mgmt.urlchannels.list"",
       ""httpMethod"": ""GET"",
       ""parameters"": {
        ""property_code"": {
         ""restParameterType"": ""path"",
         ""pattern"": ""[^/]+"",
         ""required"": true
        }
       }
      }
     }
    },
    ""webproperties"": {
     ""methods"": {
      ""list"": {
       ""restPath"": ""web_properties"",
       ""rpcMethod"": ""adsense.mgmt.webproperties.list"",
       ""httpMethod"": ""GET""
      }
     }
    }
   }
  }
 }
}
";
        [Test()]
        public void TestV02GetService ()
        {
            UTF8Encoding.UTF8.GetBytes(V02_SAMPLE_DISCOVERY);
            MemoryStream ms = new MemoryStream(UTF8Encoding.UTF8.GetBytes(V02_SAMPLE_DISCOVERY));
            var param = new ServiceFactory.FactoryV_0_2Parameter();
            param.ServerUrl = "http://elephant.lon:9996/";
            IServiceFactory factory = ServiceFactory.CreateServiceFactory (ms, DiscoveryVersion.Version_0_2, param);
            IService service = factory.GetService ("v1beta1");
            
            Assert.NotNull(service);
            Assert.AreEqual(1, service.Resources.Count);
            Assert.AreEqual("mgmt", service.Resources.Keys.First());
            Assert.AreEqual(5, service.Resources["mgmt"].Resources.Count);
            
        }
    }
}
