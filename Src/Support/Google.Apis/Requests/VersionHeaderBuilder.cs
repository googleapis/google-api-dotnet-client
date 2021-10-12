/*
Copyright 2019 Google Inc

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

using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;

namespace Google.Apis.Requests
{
    // Note: this code is copied from GAX:
    // https://github.com/googleapis/gax-dotnet/blob/main/Google.Api.Gax/VersionHeaderBuilder.cs
    // The duplication is annoying, but hard to avoid due to dependencies.
    // Any changes should be made in both places.

    /// <summary>
    /// Helps build version strings for the x-goog-api-client header.
    /// The value is a space-separated list of name/value pairs, where the value
    /// should be a semantic version string. Names must be unique.
    /// </summary>
    public sealed class VersionHeaderBuilder
    {
        private static readonly Lazy<string> s_environmentVersion = new Lazy<string>(GetEnvironmentVersion);

        /// <summary>
        /// The name of the header to set.
        /// </summary>
        public const string HeaderName = "x-goog-api-client";
        private readonly List<string> _names = new List<string>();
        private readonly List<string> _values = new List<string>();

        /// <summary>
        /// Appends the given name/version string to the list.
        /// </summary>
        /// <param name="name">The name. Must not be null or empty, or contain a space or a slash.</param>
        /// <param name="version">The version. Must not be null, or contain a space or a slash.</param>
        public VersionHeaderBuilder AppendVersion(string name, string version)
        {
            Utilities.ThrowIfNull(name, nameof(name));
            Utilities.ThrowIfNull(version, nameof(version));
            // Names can't be empty, but versions can. (We use the empty string to indicate an unknown version.)

            CheckArgument(name.Length > 0 && !name.Contains(" ") && !name.Contains("/"), nameof(name), $"Invalid name: {name}");
            CheckArgument(!version.Contains(" ") && !version.Contains("/"), nameof(version), $"Invalid version: {version}");
            CheckArgument(!_names.Contains(name), nameof(name), "Names in version headers must be unique");
            _names.Add(name);
            _values.Add(version);
            return this;
        }

        // This is in GaxPreconditions in the original code.
        private static void CheckArgument(bool condition, string paramName, string message)
        {
            if (!condition)
            {
                throw new ArgumentException(message, paramName);
            }
        }

        /// <summary>
        /// Appends a name/version string, taking the version from the version of the assembly
        /// containing the given type.
        /// </summary>
        public VersionHeaderBuilder AppendAssemblyVersion(string name, System.Type type)
            => AppendVersion(name, FormatAssemblyVersion(type));

        /// <summary>
        /// Appends the .NET environment information to the list.
        /// </summary>
        public VersionHeaderBuilder AppendDotNetEnvironment() => AppendVersion("gl-dotnet", s_environmentVersion.Value);

        private static string GetEnvironmentVersion()
        {
            // We can pick between the version reported by System.Environment.Version, or the version in the
            // entry assembly, if any. Neither gives us exactly what we might want, 
            string systemEnvironmentVersion =
#if NETSTANDARD1_3
                null;
#else
                FormatVersion(Environment.Version);
#endif
            string entryAssemblyVersion = GetEntryAssemblyVersionOrNull();

            return entryAssemblyVersion ?? systemEnvironmentVersion ?? "";
        }

        private static string GetEntryAssemblyVersionOrNull()
        {
            try
            {
                // Assembly.GetEntryAssembly() isn't available in netstandard1.3. Attempt to fetch it with reflection, which is ugly but should work.
                // This is a slightly more robust version of the code we previously used in Microsoft.Extensions.PlatformAbstractions.
                var getEntryAssemblyMethod = typeof(Assembly)
                    .GetTypeInfo()
                    .DeclaredMethods
                    .Where(m => m.Name == "GetEntryAssembly" && m.IsStatic && m.GetParameters().Length == 0 && m.ReturnType == typeof(Assembly))
                    .FirstOrDefault();
                if (getEntryAssemblyMethod == null)
                {
                    return null;
                }
                Assembly entryAssembly = (Assembly) getEntryAssemblyMethod.Invoke(null, new object[0]);
                var frameworkName = entryAssembly?.GetCustomAttribute<TargetFrameworkAttribute>()?.FrameworkName;
                return frameworkName == null ? null : FormatVersion(new FrameworkName(frameworkName).Version);
            }
            catch
            {
                // If we simply can't get the version for whatever reason, don't fail.
                return null;
            }
        }


        private static string FormatAssemblyVersion(System.Type type)
        {
            // Prefer AssemblyInformationalVersion, then AssemblyFileVersion,
            // then AssemblyVersion.

            var assembly = type.GetTypeInfo().Assembly;
            var info = assembly.GetCustomAttributes<AssemblyInformationalVersionAttribute>().FirstOrDefault()?.InformationalVersion;
            if (info != null)
            {
                return info;
            }
            var file = assembly.GetCustomAttributes<AssemblyFileVersionAttribute>().FirstOrDefault()?.Version;
            if (file != null)
            {
                return string.Join(".", file.Split('.').Take(3));
            }
            return FormatVersion(assembly.GetName().Version);
        }

        private static string FormatVersion(Version version) =>
            version != null ?
            $"{version.Major}.{version.Minor}.{(version.Build != -1 ? version.Build : 0)}" :
            ""; // Empty string means "unknown"

        /// <inheritdoc />
        public override string ToString() => string.Join(" ", _names.Zip(_values, (name, value) => $"{name}/{value}"));

        /// <summary>
        /// Clones this VersionHeaderBuilder, creating an independent copy with the same names/values.
        /// </summary>
        /// <returns>A clone of this builder.</returns>
        public VersionHeaderBuilder Clone()
        {
            var ret = new VersionHeaderBuilder();
            ret._names.AddRange(_names);
            ret._values.AddRange(_values);
            return ret;
        }
    }
}
