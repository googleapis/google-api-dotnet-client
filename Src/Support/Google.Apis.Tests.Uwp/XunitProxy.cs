using Google.Apis.Tests.Apis.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Reflection;

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
            int testCount = 0;
            var googleApiTests = typeof(NullLoggerTests).GetTypeInfo().Assembly.GetTypes();
            foreach (var type in googleApiTests)
            {
                var typeInfo = type.GetTypeInfo();
                // Only public classes
                if (!typeInfo.IsPublic)
                {
                    continue;
                }
                // Only classes that have a parameterless public constructor
                var ctor = typeInfo.DeclaredConstructors.FirstOrDefault(x => x.IsPublic && !x.GetParameters().Any());
                if (ctor == null)
                {
                    continue;
                }
                var methods = type.GetTypeInfo().DeclaredMethods;
                foreach (var method in typeInfo.DeclaredMethods)
                {
                    // TheoryAttribute derives from FactAttribute
                    var isFact = method.GetCustomAttribute<Xunit.FactAttribute>()?.GetType() == typeof(Xunit.FactAttribute);
                    if (isFact)
                    {
                        testCount += 1;
                        var test = ctor.Invoke(new object[0]);
                        // TODO: Collect all test failures, throw at end
                        try
                        {
                            method.Invoke(test, new object[0]);
                        }
                        catch (Exception e)
                        {
                            e = (e as TargetInvocationException)?.InnerException ?? e;
                            throw new XunitException(method, e);
                        }
                    }
                }
            }
            // Confirm that a sensible number of tests has actually run.
            Assert.IsTrue(testCount >= 140, $"testCount = {testCount}");
        }
    }
}
