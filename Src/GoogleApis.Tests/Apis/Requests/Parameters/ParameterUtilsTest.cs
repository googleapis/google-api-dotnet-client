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

using System.Collections.Generic;

using NUnit.Framework;

using Google.Apis.Util;
using Google.Apis.Requests;
using Google.Apis.Requests.Parameters;

namespace Google.Apis.Tests.Apis.Requests
{
    [TestFixture]
    public class ParameterUtilsTest
    {
        private class TestRequestUrl
        {
            [Google.Apis.Util.RequestParameterAttribute("first_query_param", Google.Apis.Util.RequestParameterType.Query)]
            public string FirstParam { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("second_query_param", Google.Apis.Util.RequestParameterType.Query)]
            public string SecondParam { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("user_defined_query_parameters",
                Google.Apis.Util.RequestParameterType.UserDefiniedQueries)]
            public System.Collections.Generic.KeyValuePair<string, string>[] ParamsCollecetion { get; set; }

            public System.Uri Build()
            {
                var builder = new RequestBuilder()
                {
                    BaseUri = new System.Uri("//revokeTokenUrl")
                };
                ParameterUtils.InitParameters(builder, this);
                return builder.BuildUri();
            }
        }

        [Test]
        public void IterateParametersTest()
        {
            var request = new TestRequestUrl()
            {
                FirstParam = "firstOne",
                SecondParam = "secondOne",
                ParamsCollecetion = new KeyValuePair<string, string>[]{
                    new KeyValuePair<string,string>("customParam1","customVal1"),
                    new KeyValuePair<string,string>("customParam2","customVal2")
                }
            };

            var result = request.Build().AbsoluteUri;

            Assert.That(result, Contains.Substring("first_query_param=firstOne"));
            Assert.That(result, Contains.Substring("second_query_param=secondOne"));
            Assert.That(result, Contains.Substring("customParam1=customVal1"));
            Assert.That(result, Contains.Substring("customParam2=customVal2"));
        }
    }
}