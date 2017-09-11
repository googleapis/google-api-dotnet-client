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
                    if (method.ReturnType == typeof(Task))
                    {
                        ((Task)ret).Wait();
                    }
                    else if (method.ReturnType != typeof(void))
                    {
                        throw new InvalidOperationException($"Unexpected return type {method.ReturnType} in test method {method}");
                    }
                }
                catch (Exception e)
                {
                    e = (e as TargetInvocationException)?.InnerException ?? e;
                    throw new XunitException(method, e);
                }
            }
            // Confirm that the correct number of tests has actually run.
            Assert.AreEqual(224, facts.Count);
        }
    }
}
