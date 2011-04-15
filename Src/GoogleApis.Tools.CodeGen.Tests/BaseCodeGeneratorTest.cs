/*
Copyright 2010 Google Inc

Licensed under the Apache License, Version 2.0 (the ""License"");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an ""AS IS"" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Google.Apis.Discovery;
using Google.Apis.Json;

using log4net;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests
{
	/// <summary>
	/// Is a base class for testing of code generators
	/// </summary>
	public abstract class BaseCodeGeneratorTest
	{
		public enum TestMethodNames
		{
			getTest,
			postTest,
			noParameterTest,
			oneOptionalParameterTest,
			oneRequiredParameterTest
		}

		public const string ServiceClassName = "Google.Apis.Tools.CodeGen.Tests.TestServiceClass";
		public const string ResourceClassName = "Google.Apis.Tools.CodeGen.Tests.TestResourceClass";
		public const string ResourceName = "TestResource";
		public const string ResourceAsJson = @"
		{
			""methods"":{
				""getTest"":{
					""pathUrl"":""activities/count"",
					""rpcName"":""chili.activities.count"",
					""httpMethod"":""GET"",
					""methodType"":""rest"",
					""parameters"":{
						""req_b"":{""parameterType"":""query"",""required"":true},
                        ""req_a"":{""parameterType"":""query"",""required"":true},
						""opt_b"":{""parameterType"":""query"",""required"":false},
						""opt_a"":{""parameterType"":""query"",""required"":false}
					}
				},
				""postTest"":{
					""pathUrl"":""activities/{userId}/{scope}/{postId}"",
					""rpcName"":""chili.activities.delete"",
					""httpMethod"":""POST"",
					""methodType"":""rest"",
					""parameters"":{
						""req_a"":{""parameterType"":""path"",""pattern"":"".*"",""required"":true},
						""req_c"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true},
						""opt_b"":{""parameterType"":""query"",""required"":false},
						""req_b"":{""parameterType"":""path"",""pattern"":""@.*"",""required"":true},
						""opt_a"":{""parameterType"":""query"",""required"":false}
					}
				},
				""noParameterTest"":{
					""pathUrl"":""activities/count"",
					""rpcName"":""chili.activities.count"",
					""httpMethod"":""GET"",
					""methodType"":""rest"",
					""parameters"":null
				},
				""oneOptionalParameterTest"":{
					""pathUrl"":""activities/count"",
					""rpcName"":""chili.activities.count"",
					""httpMethod"":""GET"",
					""methodType"":""rest"",
					""parameters"":{""opt_a"":{""parameterType"":""query"",""required"":false}}
				},
				""oneRequiredParameterTest"":{
					""pathUrl"":""activities/count"",
					""rpcName"":""chili.activities.count"",
					""httpMethod"":""GET"",
					""methodType"":""rest"",
					""parameters"":{""opt_a"":{""parameterType"":""query"",""required"":true}}
				}
			}
		}
		";
        
        private const string AdSenseV02AsJson = @"
{
 ""name"": ""adsense-mgmt"",
 ""version"": ""v1beta1"",
 ""description"": ""AdSense Management API"",
 ""restBasePath"": ""/adsense-mgmt/v1beta1/"",
 ""rpcPath"": ""/rpc"",
 ""resources"": {
  ""adunits"": {
   ""methods"": {
    ""list"": {
     ""restPath"": ""web_properties/{property_code}/ad_units"",
     ""rpcMethod"": ""adsensemgmt.adunits.list"",
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
     ""rpcMethod"": ""adsensemgmt.customchannels.list"",
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
     ""rpcMethod"": ""adsensemgmt.reports.generate"",
     ""httpMethod"": ""GET""
    }
   }
  },
  ""urlchannels"": {
   ""methods"": {
    ""list"": {
     ""restPath"": ""web_properties/{property_code}/url_channels"",
     ""rpcMethod"": ""adsensemgmt.urlchannels.list"",
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
     ""rpcMethod"": ""adsensemgmt.webproperties.list"",
     ""httpMethod"": ""GET""
    }
   }
  }
 }
}";
            
        
        private const string AdSenseV02WithMultiLevelAsJson = @"
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

		public const string SimpleResource = @"
		{
			""methods"":{
				""simpleMethod"":{
					""pathUrl"":""activities/count"",
					""rpcName"":""chili.activities.count"",
					""httpMethod"":""GET"",
					""methodType"":""rest"",
					""parameters"":null
				}
			}
		}
		";

		public const string BuzzServiceAsJson = @"{
			""data"":{
				""buzz"":{
					""v1"":{""baseUrl"":""https://www.googleapis.com/buzz/v1/"",
						""resources"":{
							""activities"":{""methods"":{""count"":{""pathUrl"":""activities/count"",""rpcName"":""chili.activities.count"",""httpMethod"":""GET"",""methodType"":""rest"",""parameters"":{""hl"":{""parameterType"":""query"",""required"":false},""url"":{""parameterType"":""query"",""required"":false}}},""delete"":{""pathUrl"":""activities/{userId}/{scope}/{postId}"",""rpcName"":""chili.activities.delete"",""httpMethod"":""DELETE"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""hl"":{""parameterType"":""query"",""required"":false},""postId"":{""parameterType"":""path"",""pattern"":"".*"",""required"":true},""scope"":{""parameterType"":""path"",""pattern"":""@.*"",""required"":true},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}},""extractPeopleFromSearch"":{""pathUrl"":""activities/search/@people"",""rpcName"":""chili.activities.extractPeopleFromSearch"",""httpMethod"":""GET"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""bbox"":{""parameterType"":""query"",""required"":false},""c"":{""parameterType"":""query"",""required"":false},""hl"":{""parameterType"":""query"",""required"":false},""lat"":{""parameterType"":""query"",""required"":false},""lon"":{""parameterType"":""query"",""required"":false},""max-results"":{""parameterType"":""query"",""required"":false},""pid"":{""parameterType"":""query"",""required"":false},""q"":{""parameterType"":""query"",""required"":false},""radius"":{""parameterType"":""query"",""required"":false}}},""get"":{""pathUrl"":""activities/{userId}/@self/{postId}"",""rpcName"":""chili.activities.get"",""httpMethod"":""GET"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""hl"":{""parameterType"":""query"",""required"":false},""postId"":{""parameterType"":""path"",""pattern"":"".*"",""required"":true},""targetLang"":{""parameterType"":""query"",""required"":false},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}},""insert"":{""pathUrl"":""activities/{userId}/@self"",""rpcName"":""chili.activities.insert"",""httpMethod"":""POST"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""hl"":{""parameterType"":""query"",""required"":false},""media"":{""parameterType"":""query"",""required"":false},""preview"":{""parameterType"":""query"",""required"":false},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}},""list"":{""pathUrl"":""activities/{userId}/{scope}"",""rpcName"":""chili.activities.list"",""httpMethod"":""GET"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""c"":{""parameterType"":""query"",""required"":false},""hl"":{""parameterType"":""query"",""required"":false},""max-comments"":{""parameterType"":""query"",""required"":false},""max-liked"":{""parameterType"":""query"",""required"":false},""max-results"":{""parameterType"":""query"",""required"":false},""scope"":{""parameterType"":""path"",""pattern"":""@(self|public|consumption|liked|comments)*"",""required"":true},""targetLang"":{""parameterType"":""query"",""required"":false},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}},""search"":{""pathUrl"":""activities/search"",""rpcName"":""chili.activities.search"",""httpMethod"":""GET"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""bbox"":{""parameterType"":""query"",""required"":false},""c"":{""parameterType"":""query"",""required"":false},""hl"":{""parameterType"":""query"",""required"":false},""lat"":{""parameterType"":""query"",""required"":false},""lon"":{""parameterType"":""query"",""required"":false},""max-results"":{""parameterType"":""query"",""required"":false},""pid"":{""parameterType"":""query"",""required"":false},""q"":{""parameterType"":""query"",""required"":false},""radius"":{""parameterType"":""query"",""required"":false},""targetLang"":{""parameterType"":""query"",""required"":false}}},""track"":{""pathUrl"":""activities/track"",""rpcName"":""chili.activities.track"",""httpMethod"":""GET"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""bbox"":{""parameterType"":""query"",""required"":false},""c"":{""parameterType"":""query"",""required"":false},""hl"":{""parameterType"":""query"",""required"":false},""lat"":{""parameterType"":""query"",""required"":false},""lon"":{""parameterType"":""query"",""required"":false},""max-results"":{""parameterType"":""query"",""required"":false},""pid"":{""parameterType"":""query"",""required"":false},""q"":{""parameterType"":""query"",""required"":false},""radius"":{""parameterType"":""query"",""required"":false}}},""update"":{""pathUrl"":""activities/{userId}/{scope}/{postId}"",""rpcName"":""chili.activities.update"",""httpMethod"":""PUT"",""methodType"":""rest"",""parameters"":{""abuseType"":{""parameterType"":""query"",""required"":false},""alt"":{""parameterType"":""query"",""required"":false},""hl"":{""parameterType"":""query"",""required"":false},""postId"":{""parameterType"":""path"",""pattern"":"".*"",""required"":true},""scope"":{""parameterType"":""path"",""pattern"":""@.*"",""required"":true},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}}}},
							""comments"":{""methods"":{""delete"":{""pathUrl"":""activities/{userId}/@self/{postId}/@comments/{commentId}"",""rpcName"":""chili.comments.delete"",""httpMethod"":""DELETE"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""commentId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true},""hl"":{""parameterType"":""query"",""required"":false},""postId"":{""parameterType"":""path"",""pattern"":"".*"",""required"":true},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}},""get"":{""pathUrl"":""activities/{userId}/@self/{postId}/@comments/{commentId}"",""rpcName"":""chili.comments.get"",""httpMethod"":""GET"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""commentId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true},""hl"":{""parameterType"":""query"",""required"":false},""postId"":{""parameterType"":""path"",""pattern"":"".*"",""required"":true},""targetLang"":{""parameterType"":""query"",""required"":false},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}},""insert"":{""pathUrl"":""activities/{userId}/@self/{postId}/@comments"",""rpcName"":""chili.comments.insert"",""httpMethod"":""POST"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""hl"":{""parameterType"":""query"",""required"":false},""postId"":{""parameterType"":""path"",""pattern"":"".*"",""required"":true},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}},""list"":{""pathUrl"":""activities/{userId}/{scope}/{postId}/@comments"",""rpcName"":""chili.comments.list"",""httpMethod"":""GET"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""c"":{""parameterType"":""query"",""required"":false},""hl"":{""parameterType"":""query"",""required"":false},""max-results"":{""parameterType"":""query"",""required"":false},""postId"":{""parameterType"":""path"",""pattern"":"".*"",""required"":true},""scope"":{""parameterType"":""path"",""pattern"":""@.*"",""required"":true},""targetLang"":{""parameterType"":""query"",""required"":false},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}},""update"":{""pathUrl"":""activities/{userId}/{scope}/{postId}/@comments/{commentId}"",""rpcName"":""chili.comments.update"",""httpMethod"":""PUT"",""methodType"":""rest"",""parameters"":{""abuseType"":{""parameterType"":""query"",""required"":false},""alt"":{""parameterType"":""query"",""required"":false},""commentId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true},""hl"":{""parameterType"":""query"",""required"":false},""postId"":{""parameterType"":""path"",""pattern"":"".*"",""required"":true},""scope"":{""parameterType"":""path"",""pattern"":""@.*"",""required"":true},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}}}},
							""groups"":{""methods"":{""delete"":{""pathUrl"":""people/{userId}/@groups/{groupId}"",""rpcName"":""chili.groups.delete"",""httpMethod"":""DELETE"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""groupId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true},""hl"":{""parameterType"":""query"",""required"":false},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}},""get"":{""pathUrl"":""people/{userId}/@groups/{groupId}/@self"",""rpcName"":""chili.groups.get"",""httpMethod"":""GET"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""groupId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true},""hl"":{""parameterType"":""query"",""required"":false},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}},""insert"":{""pathUrl"":""people/{userId}/@groups"",""rpcName"":""chili.groups.insert"",""httpMethod"":""POST"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""hl"":{""parameterType"":""query"",""required"":false},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}},""list"":{""pathUrl"":""people/{userId}/@groups"",""rpcName"":""chili.groups.list"",""httpMethod"":""GET"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""c"":{""parameterType"":""query"",""required"":false},""hl"":{""parameterType"":""query"",""required"":false},""max-results"":{""parameterType"":""query"",""required"":false},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}},""update"":{""pathUrl"":""people/{userId}/@groups/{groupId}/@self"",""rpcName"":""chili.groups.update"",""httpMethod"":""PUT"",""methodType"":""rest"",""parameters"":{""groupId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true},""hl"":{""parameterType"":""query"",""required"":false},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}}}},
							""people"":{""methods"":{""delete"":{""pathUrl"":""people/{userId}/@groups/{groupId}/{personId}"",""rpcName"":""chili.people.delete"",""httpMethod"":""DELETE"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""groupId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true},""hl"":{""parameterType"":""query"",""required"":false},""personId"":{""parameterType"":""path"",""pattern"":""(?!@self).*"",""required"":true},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}},""get"":{""pathUrl"":""people/{userId}/@self"",""rpcName"":""chili.people.get"",""httpMethod"":""GET"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""hl"":{""parameterType"":""query"",""required"":false},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}},""liked"":{""pathUrl"":""activities/{userId}/{scope}/{postId}/{groupId}"",""rpcName"":""chili.people.liked"",""httpMethod"":""GET"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""c"":{""parameterType"":""query"",""required"":false},""groupId"":{""parameterType"":""path"",""pattern"":""@liked"",""required"":true},""hl"":{""parameterType"":""query"",""required"":false},""max-results"":{""parameterType"":""query"",""required"":false},""postId"":{""parameterType"":""path"",""pattern"":"".*"",""required"":true},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}},""list"":{""pathUrl"":""people/{userId}/@groups/{groupId}"",""rpcName"":""chili.people.list"",""httpMethod"":""GET"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""c"":{""parameterType"":""query"",""required"":false},""groupId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true},""hl"":{""parameterType"":""query"",""required"":false},""max-results"":{""parameterType"":""query"",""required"":false},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}},""relatedToUri"":{""pathUrl"":""people/{userId}/@related"",""rpcName"":""chili.people.relatedToUri"",""httpMethod"":""GET"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""hl"":{""parameterType"":""query"",""required"":false},""uri"":{""parameterType"":""query"",""required"":false}}},""reshared"":{""pathUrl"":""activities/{userId}/{scope}/{postId}/{groupId}"",""rpcName"":""chili.people.reshared"",""httpMethod"":""GET"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""c"":{""parameterType"":""query"",""required"":false},""groupId"":{""parameterType"":""path"",""pattern"":""@reshared"",""required"":true},""hl"":{""parameterType"":""query"",""required"":false},""max-results"":{""parameterType"":""query"",""required"":false},""postId"":{""parameterType"":""path"",""pattern"":"".*"",""required"":true},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}},""search"":{""pathUrl"":""people/search"",""rpcName"":""chili.people.search"",""httpMethod"":""GET"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""c"":{""parameterType"":""query"",""required"":false},""hl"":{""parameterType"":""query"",""required"":false},""max-results"":{""parameterType"":""query"",""required"":false},""q"":{""parameterType"":""query"",""required"":false}}},""update"":{""pathUrl"":""people/{userId}/@groups/{groupId}/{personId}"",""rpcName"":""chili.people.update"",""httpMethod"":""PUT"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""groupId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true},""hl"":{""parameterType"":""query"",""required"":false},""personId"":{""parameterType"":""path"",""pattern"":""(?!@self).*"",""required"":true},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}}}},
							""photos"":{""methods"":{""insert"":{""pathUrl"":""photos/{userId}/{albumId}"",""rpcName"":""chili.photos.insert"",""httpMethod"":""POST"",""methodType"":""rest"",""parameters"":{""albumId"":{""parameterType"":""path"",""pattern"":""(@new|[^@].*)"",""required"":true},""hl"":{""parameterType"":""query"",""required"":false},""media"":{""parameterType"":""query"",""required"":false},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}}}},
							""related"":{""methods"":{""list"":{""pathUrl"":""activities/{userId}/{scope}/{postId}/@related"",""rpcName"":""chili.related.list"",""httpMethod"":""GET"",""methodType"":""rest"",""parameters"":{""alt"":{""parameterType"":""query"",""required"":false},""c"":{""parameterType"":""query"",""required"":false},""hl"":{""parameterType"":""query"",""required"":false},""max-results"":{""parameterType"":""query"",""required"":false},""postId"":{""parameterType"":""path"",""pattern"":"".*"",""required"":true},""scope"":{""parameterType"":""path"",""pattern"":""@.*"",""required"":true},""userId"":{""parameterType"":""path"",""pattern"":""[^/]+"",""required"":true}}}}}}},""v1partners"":{""baseUrl"":""https://www.googleapis.com/""}}}}";

		public static KeyValuePair<string, object> CreateJsonResourceDefinition (string resourceName, string jsonString)
		{
			JsonDictionary json = (JsonDictionary)JsonReader.Parse (jsonString);
			
			return new KeyValuePair<string, object> (resourceName, json);
		}

		public static IResource CreateResourceDivcoveryV_0_1 (string resourceName, string json)
		{
			return new ResourceV0_1 (CreateJsonResourceDefinition (resourceName, json));
		}

		protected void AddRefereenceToDelararingAssembly (Type target, CompilerParameters cp)
		{
			cp.ReferencedAssemblies.Add (target.Assembly.CodeBase);
		}

		protected void CheckCompile (CodeTypeDeclaration codeType, bool warnAsError, string errorMessage)
		{
			CodeCompileUnit compileUnit = new CodeCompileUnit ();
			var client = new CodeNamespace ("Google.Apis.Tools.CodeGen.Tests");
			compileUnit.Namespaces.Add (client);
			client.Types.Add (codeType);
			
			CheckCompile (compileUnit, warnAsError, errorMessage);
		}

		protected void CheckCompile (CodeCompileUnit codeCompileUnit, bool warnAsError, string errorMessage)
		{
			var language = "CSharp";
			var provider = CodeDomProvider.CreateProvider (language);
			CompilerParameters cp = new CompilerParameters ();
			// Add an assembly reference.
			cp.ReferencedAssemblies.Add ("System.dll");
			AddRefereenceToDelararingAssembly (typeof(DiscoveryService), cp);
			AddRefereenceToDelararingAssembly (typeof(ILog), cp);
            AddRefereenceToDelararingAssembly (typeof(Newtonsoft.Json.JsonSerializer), cp);
			
			cp.GenerateExecutable = false;
			cp.GenerateInMemory = true;
			cp.TreatWarningsAsErrors = warnAsError;
			// Warnings are errors.
			CompilerResults compilerResults = provider.CompileAssemblyFromDom (cp, codeCompileUnit);
			bool hasError = false;
			if (compilerResults.Errors.Count > 0) {
				var sb = new StringBuilder (errorMessage).AppendLine ();
				foreach (CompilerError error in compilerResults.Errors) {
					sb.AppendLine (error.ToString ());
					if (error.IsWarning == false || warnAsError) {
						hasError = true;
					}
				}
				sb.AppendLine ();
				sb.AppendLine ("Generated Code Follows");
				
				using (StringWriter sw = new StringWriter (sb)) {
					IndentedTextWriter tw = new IndentedTextWriter (sw);
					provider.GenerateCodeFromCompileUnit (codeCompileUnit, tw, new CodeGeneratorOptions ());
				}
				Console.Out.WriteLine (sb.ToString ());
				
				if (hasError) {
					Assert.Fail (sb.ToString ());
				}
			}
		}
		
		protected IService CreateBuzzService()
		{
			var version = "v1";
			var buzzTestFetcher = new StringDiscoveryDevice(){Document = BuzzServiceAsJson};
			var discovery = new DiscoveryService(buzzTestFetcher);
			// Build the service based on discovery information.
			return discovery.GetService(version, DiscoveryVersion.Version_0_1, null);
		}
        
        protected IService CreateAdSenseV02Service()
        {
            var version = "v1beta1";
            var buzzTestFetcher = new StringDiscoveryDevice(){Document = AdSenseV02AsJson};
            var discovery = new DiscoveryService(buzzTestFetcher);
            var param = new FactoryParameterV0_2();
            param.ServerUrl = "http://elephant.lon:9996/";

            // Build the service based on discovery information.
            return discovery.GetService(version, DiscoveryVersion.Version_0_2, param);
        }
	}
}
