/*
Copyright 2016 Google Inc

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

using System;
using System.Reflection;

namespace Google.Apis.Util
{
    /// <summary>
    /// Workarounds for some unfortunate behaviors in the .NET Framework's
    /// implementation of System.Uri
    /// </summary>
    /// <remarks>
    /// UriPatcher lets us work around some unfortunate behaviors in the .NET Framework's
    /// implementation of System.Uri.
    ///
    /// == Problem 1: Slashes and dots
    ///
    /// Prior to .NET 4.5, System.Uri would always unescape "%2f" ("/") and "%5c" ("\\").
    /// Relative path components were also compressed.
    ///
    /// As a result, this:     "http://www.example.com/.%2f.%5c./"
    /// ... turned into this:  "http://www.example.com/"
    ///
    /// This breaks API requests where slashes or dots appear in path parameters. Such requests
    /// arise, for example, when these characters appear in the name of a GCS object.
    ///
    /// == Problem 2: Fewer unreserved characters
    ///
    /// Unless IDN/IRI parsing is enabled -- which it is not, by default, prior to .NET 4.5 --
    /// Uri.EscapeDataString uses the set of "unreserved" characters from RFC 2396 instead of the
    /// newer, *smaller* list from RFC 3986. We build requests using URI templating as described
    /// by RFC 6570, which specifies that the latter definition (RFC 3986) should be used.
    ///
    /// This breaks API requests with parameters including any of: !*'()
    ///
    /// == Solutions
    ///
    /// Though the default behaviors changed in .NET 4.5, these "quirks" remain for compatibility
    /// unless the application explicitly targets the new runtime.  Usually, that means adding a
    /// TargetFrameworkAttribute to the entry assembly.
    ///
    /// Applications running on .NET 4.0 or later can also set "DontUnescapePathDotsAndSlashes"
    /// and enable IDN/IRI parsing using app.config or web.config.
    ///
    /// As a class library, we can't control app.config or the entry assembly, so we can't take
    /// either approach. Instead, we resort to reflection trickery to try to solve these problems
    /// if we detect they exist. Sorry.
    /// </remarks>
    public static class UriPatcher
    {
        /// <summary>
        /// Patch URI quirks in System.Uri. See class summary for details.
        /// </summary>
        public static void PatchUriQuirks()
        {
            var uriParser = typeof(System.Uri).GetTypeInfo().Assembly.GetType("System.UriParser");
            if (uriParser == null) { return; }

            // Is "%2f" unescaped for http: or https: URIs?
            if (new Uri("http://example.com/%2f").AbsolutePath == "//" ||
                new Uri("https://example.com/%2f").AbsolutePath == "//")
            {
                // Call System.UriParser.Http[s]Uri.SetUpdatableFlags(UriSyntaxFlags.None)
                // https://github.com/Microsoft/referencesource/blob/d925d870f3cb3f6a/System/net/System/_UriSyntax.cs#L87
                // https://github.com/Microsoft/referencesource/blob/d925d870f3cb3f6a/System/net/System/_UriSyntax.cs#L77
                // https://github.com/Microsoft/referencesource/blob/d925d870f3cb3f6a/System/net/System/_UriSyntax.cs#L352

                var setUpdatableFlagsMethod = uriParser.GetMethod("SetUpdatableFlags",
                    BindingFlags.Instance | BindingFlags.NonPublic);
                if (setUpdatableFlagsMethod != null)
                {
                    Action<string> setUriParserUpdatableFlags = (fieldName) =>
                    {
                        var parserField = uriParser.GetField(fieldName,
                            BindingFlags.Static | BindingFlags.NonPublic);
                        if (parserField == null) { return; }
                        var parserInstance = parserField.GetValue(null);
                        if (parserInstance == null) { return; }
                        setUpdatableFlagsMethod.Invoke(parserInstance, new object[] { 0 });
                    };

                    // Make the change for the http: and https: URI parsers.
                    setUriParserUpdatableFlags("HttpUri");
                    setUriParserUpdatableFlags("HttpsUri");
                }
            }

            // Is "*" considered "unreserved"?
            if (Uri.EscapeDataString("*") == "*")
            {
                // Set UriParser.s_QuirksVersion to at least UriQuirksVersion.V3
                // https://github.com/Microsoft/referencesource/blob/d925d870f3cb3f6a/System/net/System/_UriSyntax.cs#L114
                // https://github.com/Microsoft/referencesource/blob/d925d870f3cb3f6a/System/net/System/UriHelper.cs#L701

                var quirksField = uriParser.GetField("s_QuirksVersion",
                    BindingFlags.Static | BindingFlags.NonPublic);
                if (quirksField != null)
                {
                    int quirksVersion = (int)quirksField.GetValue(null);
                    if (quirksVersion <= 2)
                    {
                        quirksField.SetValue(null, 3);
                    }
                }
            }
        }
    }
}
