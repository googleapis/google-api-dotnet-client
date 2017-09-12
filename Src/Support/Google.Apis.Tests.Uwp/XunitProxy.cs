/*
Copyright 2017 Google Inc

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

using Google.Apis.Auth.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Google.Apis.Tests.Uwp
{
    [TestClass]
    public class XunitProxy
    {
        class XunitException : Exception
        {
            public XunitException(MethodInfo method, Exception inner)
                : base($"XUnit failure: {method.DeclaringType.Namespace}.{method.DeclaringType.Name}()", inner)
            {
            }
        }

        [TestMethod]
        public void RunAllXunitTests()
        {
            // TODO: Theory tests
            var googleApiTypes = typeof(ApplicationContextTests).GetTypeInfo().Assembly.GetTypes();
            var googleApiAuthTypes = typeof(GoogleJsonWebSignatureTests).GetTypeInfo().Assembly.GetTypes();
            var allTypes = googleApiTypes.Concat(googleApiAuthTypes);
            var facts = allTypes
                .Select(type => type.GetTypeInfo())
                .Where(typeInfo => typeInfo.IsPublic)
                .Select(typeInfo => new
                {
                    typeInfo,
                    ctor = typeInfo.DeclaredConstructors.FirstOrDefault(x => x.IsPublic && !x.GetParameters().Any())
                })
                .Where(x => x.ctor != null)
                .SelectMany(x => x.typeInfo.DeclaredMethods.Select(method => new { x.ctor, method }))
                .Where(x => x.method.GetCustomAttribute<Xunit.FactAttribute>()?.GetType() == typeof(Xunit.FactAttribute))
                .ToList();
            // Execute all xunit Fact tests
            foreach (var fact in facts)
            {
                var test = fact.ctor.Invoke(new object[0]);
                var method = fact.method;
                // TODO: Perhaps collect all test failures, throw at end
                try
                {
                    var ret = method.Invoke(test, new object[0]);
                    (ret as Task)?.Wait();
                }
                catch (Exception e)
                {
                    e = (e as TargetInvocationException)?.InnerException ?? e;
                    throw new XunitException(method, e);
                }
            }
            // Confirm that the correct number of tests have run.
            Assert.AreEqual(221, facts.Count);
        }
    }
}
