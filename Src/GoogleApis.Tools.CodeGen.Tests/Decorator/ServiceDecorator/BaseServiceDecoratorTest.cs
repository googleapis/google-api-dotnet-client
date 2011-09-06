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

using System;
using Google.Apis.Discovery;
using Google.Apis.Tests.Apis.Requests;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator.ServiceDecorator
{
    /// <summary>
    /// Abstract test class for ServiceDecorator tests
    /// </summary>
    public abstract class BaseServiceDecoratorTest : BaseCodeGeneratorTest
    {
        protected const string Name = "TestName";
        protected const string Version = "TestVersion1";
        protected readonly Uri BaseUri = new Uri("http://www.test.example.google.com/");

        /// <summary>
        /// Creates a MokeService with Name,Version and BaseUri set to the constants in this class.
        /// </summary>
        protected IService CreateService()
        {
            return new MockService { Name = Name, Version = Version, BaseUri = BaseUri };
        }
    }
}