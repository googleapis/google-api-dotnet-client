using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegrationTests.Utils
{
    internal static class Extensions
    {
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> en) =>
            en == null ? Enumerable.Empty<T>() : en;
    }
}
