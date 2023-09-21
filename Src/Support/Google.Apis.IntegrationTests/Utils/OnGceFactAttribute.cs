/*
Copyright 2020 Google Inc

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

using Google.Apis.Auth.OAuth2;
using Xunit;

namespace IntegrationTests.IntegrationTests.Utils
{
    public class OnGceFactAttribute : FactAttribute
    {
        public OnGceFactAttribute()
        {
            // Ugly, but this is for tests.
            if (!ComputeCredential.IsRunningOnComputeEngine().GetAwaiter().GetResult())
            {
                Skip = "Not running on GCE";
            }
        }
    }
}
