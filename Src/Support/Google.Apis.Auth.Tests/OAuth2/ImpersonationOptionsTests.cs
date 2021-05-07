/*
Copyright 2021 Google LLC

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using Xunit;

namespace Google.Apis.Auth.Tests.OAuth2
{
    public class ImpersonationOptionsTests
    {
        private const string DefaultTargetPrincipal = "principal";

        private string[] DefaultDelegateAccounts = new[] {"delegate"};

        private string[] DefaultScopes = new[] {"scopes"};

        private static readonly TimeSpan _defaultLifetime = new TimeSpan(1, 0, 0);

        private ImpersonationOptions CreateDefaultOptions() => new ImpersonationOptions(DefaultTargetPrincipal, _defaultLifetime, DefaultDelegateAccounts, DefaultScopes);
       
        private void AssertOptionsFields(ImpersonationOptions options, string targetPrincipal, TimeSpan lifetime, IEnumerable<string> delegateAccounts, IEnumerable<string> scopes)
        {
            Assert.Equal(targetPrincipal, options.TargetPrincipal);
            Assert.Equal(delegateAccounts, options.DelegateAccounts);
            Assert.Equal(scopes, options.Scopes);
            Assert.Equal(lifetime, options.Lifetime);
        }

        [Fact]
        public void Constructor_MissingTargetPrincipal()
        {
            Assert.Throws<ArgumentException>(() => new ImpersonationOptions("", null, null, null));
            Assert.Throws<ArgumentException>(() => new ImpersonationOptions(null, null, null, null));
        }

        [Fact]
        public void Constructor_InvalidLifetime()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new ImpersonationOptions("principal", new TimeSpan(20, 0, 0), null, null));
            Assert.StartsWith("Lifetime must be less than or equal to", ex.Message);
        }

        [Fact]
        public void Constructor()
        {
            var options = CreateDefaultOptions();
            AssertOptionsFields(options, DefaultTargetPrincipal, _defaultLifetime, DefaultDelegateAccounts, DefaultScopes);
        }

        [Fact]
        public void CreateForTargetPrincipal()
        {
            var options = ImpersonationOptions.CreateForTargetPrincipal(DefaultTargetPrincipal);
            AssertOptionsFields(options, DefaultTargetPrincipal, _defaultLifetime, null, null);
        }

        [Fact]
        public void WithTargetPrincipal()
        {
            var options = CreateDefaultOptions();
            var newTargetPrincipal = "newPrincipal";
            var newOptions = options.WithTargetPrincipal(newTargetPrincipal);
            AssertOptionsFields(newOptions, newTargetPrincipal, _defaultLifetime, DefaultDelegateAccounts, DefaultScopes);
        }

        [Fact]
        public void WithDelegateAccounts()
        {
            var options = CreateDefaultOptions();
            var newDelegateAccounts = new[] { "newDelegate" };
            var newOptions = options.WithDelegateAccounts(newDelegateAccounts);
            AssertOptionsFields(newOptions, DefaultTargetPrincipal, _defaultLifetime, newDelegateAccounts, DefaultScopes);
        }

        [Fact]
        public void WithLifetime()
        {
            var options = CreateDefaultOptions();
            var newLifetime = new TimeSpan(2, 0, 0);
            var newOptions = options.WithLifetime(newLifetime);
            AssertOptionsFields(newOptions, DefaultTargetPrincipal, newLifetime, DefaultDelegateAccounts, DefaultScopes);
        }

        [Fact]
        public void WithScopes()
        {
            var options = CreateDefaultOptions();
            var newScopes = new[] { "newScope" };
            var newOptions = options.WithScopes(newScopes);
            AssertOptionsFields(newOptions, DefaultTargetPrincipal, _defaultLifetime, DefaultDelegateAccounts, newScopes);
        }
    }
}
