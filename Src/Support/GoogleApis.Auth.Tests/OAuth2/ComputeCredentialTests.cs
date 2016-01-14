/*
Copyright 2015 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using NUnit.Framework;

namespace Google.Apis.Auth.OAuth2
{
    /// <summary>Tests for <see cref="Google.Apis.Auth.OAuth2.ComputeCredential"/>.</summary>
    [TestFixture]
    public class ComputeCredentialTests
    {
        [Test]
        public void IsRunningOnComputeEngine()
        {
            // It should be safe to assume that this test is not running on GCE.
            Assert.IsFalse(ComputeCredential.IsRunningOnComputeEngine().Result);
        }

        [Test]
        public void IsRunningOnComputeEngine_ResultIsCached()
        {
            // Two subsequent invocations should return the same task.
            Assert.AreSame(ComputeCredential.IsRunningOnComputeEngine(),
                ComputeCredential.IsRunningOnComputeEngine());
        }
    }
}
