/*
Copyright 2016 Google Inc

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
    /// <summary>Tests for <see cref="Google.Apis.Requests.Parameters.ParameterUtils"/>.</summary>
    [TestFixture]
    public class ParameterUtilsTest
    {
        private class TestRequestUrl
        {
            [Google.Apis.Util.RequestParameterAttribute("first_query_param", Google.Apis.Util.RequestParameterType.Query)]
            public string FirstParam { get; set; }

            [Google.Apis.Util.RequestParameterAttribute(Google.Apis.Util.RequestParameterType.Query)]
            public string SecondParam { get; set; }

            [Google.Apis.Util.RequestParameterAttribute(Google.Apis.Util.RequestParameterType.UserDefinedQueries)]
            public List<KeyValuePair<string, string>> ParamsCollection { get; set; }

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
                ParamsCollection = new List<KeyValuePair<string, string>>{
                    new KeyValuePair<string,string>("customParam1","customVal1"),
                    new KeyValuePair<string,string>("customParam2","customVal2")
                }
            };

            var result = request.Build().AbsoluteUri;

            //parameter was given a name and a value, so both appear in the uri
            Assert.That(result, Contains.Substring("first_query_param=firstOne"));
            
            //parameter was given value only, so the name is the name of the property in lower case
            Assert.That(result, Contains.Substring("secondparam=secondOne"));

            //custom parameters are key value pairs representing parameter names and values respectively
            Assert.That(result, Contains.Substring("customParam1=customVal1"));
            Assert.That(result, Contains.Substring("customParam2=customVal2"));
        }
    }
}