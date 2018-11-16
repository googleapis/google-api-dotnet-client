using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Apis.Auth.AspNetCore
{
    internal static class Consts
    {
        public static char[] ScopeSplitter { get; } = { ' ' };
        public const string ScopeName = "scope";
        public const string HttpContextAdditionalScopeName = "ScopeIncremental";
    }
}
