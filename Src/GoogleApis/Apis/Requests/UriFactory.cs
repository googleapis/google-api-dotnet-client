/*
Copyright 2011 Google Inc

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
using System.Reflection;
using Google.Apis.Testing;

namespace Google.Apis.Requests
{
    /// <summary>
    /// Class used to create instances of the Uri class.
    /// </summary>
    internal class UriFactory
    {
        /// <summary>
        /// Describes a class which is used to modify an Uri.
        /// </summary>
        internal interface IUriModifier
        {
            /// <summary>
            /// True if the specified Uri should be modified using this modifier.
            /// </summary>
            bool RequiresModification(Uri uri);

            /// <summary>
            /// Modifies the specified uri.
            /// </summary>
            Uri Modify(Uri uri);
        }

        private static readonly IUriModifier[] Modifiers = new[]
                                                               {
                                                                   new UriSlashUnescapeWorkaround()
                                                               };

        #region Uri-Constructors

        /// <summary>
        /// Creates a new Uri instance.
        /// </summary>
        public static Uri Create(string uri)
        {
            return ModifyUri(new Uri(uri));   
        }

        /// <summary>
        /// Creates a new Uri instance.
        /// </summary>
        public static Uri Create(Uri baseUri, string relativeUri)
        {
            return ModifyUri(new Uri(baseUri, relativeUri));
        }

        /// <summary>
        /// Creates a new Uri instance.
        /// </summary>
        public static Uri Create(Uri baseUri, Uri relativeUri)
        {
            return ModifyUri(new Uri(baseUri, relativeUri));
        }

        #endregion

        private static Uri ModifyUri(Uri uri)
        {
            // Apply all appropriate modifiers.
            foreach (IUriModifier modifier in Modifiers)
            {
                if (modifier.RequiresModification(uri))
                {
                    uri = modifier.Modify(uri);
                }
            }

            return uri;
        }

#if !SILVERLIGHT
        /// <summary>
        /// This is a workaround for the "Uri-Slash-Unescape" bug in the System.Uri class of the Microsoft .NET 
        /// Framework. The bug causes all "%2F" to be unescaped into "/", therefore making it impossible to pass "/" 
        /// as a value in any  parameter. The issue only occures in the Microsoft .NET Framework, not on mono.
        /// 
        /// Microsoft's response: 
        ///  http://connect.microsoft.com/VisualStudio/feedback/details/94109/system-uri-constructor-evaluates-escaped-slashes-and-removes-double-slashes
        /// Stackoverflow solution: 
        ///  http://stackoverflow.com/questions/781205/c-net-getting-a-url-with-an-url-encoded-slash
        /// 
        /// This Workaround will only work as long as the internals of the System.Uri class do not change. If you have
        /// any other option, then prefer it over this one. The code is just provided to make the library usable under
        /// Microsoft .NET
        /// </summary>
        private class UriSlashUnescapeWorkaround : IUriModifier
        {
            private static readonly FieldInfo m_Flags = 
                typeof(Uri).GetField("m_Flags", BindingFlags.Instance | BindingFlags.NonPublic);

            public bool RequiresModification(Uri uri)
            {
                return (!Utilities.IsRunningOnMono &&
                        m_Flags != null &&
                        uri.OriginalString.Contains("%2F") &&
                        !uri.ToString().Contains("%2F"));
            }

            /// <summary>
            /// Uses reflection to modify a private field in the Uri object in order to disable to Unescape-mechanism
            /// for the PathAndQuery field. This will only work as long as the internal implementation of the Uri
            /// class does not drastically change. 
            /// </summary>
            /// <param name="uri">The Uri to modify.</param>
            /// <returns>The uri which has been passed as a parameter (with the Unescape-mechanism disabled)</returns>
            public Uri Modify(Uri uri)
            {
                // Access the .PathAndQuery field to initialize the Uri object.
                string pathAndQuery = uri.PathAndQuery;

                // Retrieve the value of the private "m_Flags" field, and disable the Path- and QueryNotCanonical bits.
                ulong flags = (ulong)m_Flags.GetValue(uri);
                flags &= ~((ulong)0x30); // Disable Flags.PathNotCanonical|Flags.QueryNotCanonical
                m_Flags.SetValue(uri, flags);

                return uri;
            }
        }
#else
        /// <summary>
        /// Empty stub for the Silverlight implementation.
        /// todo(mlinder): Check whether the same bug exists on Silverlight, and find a way to fix it there too.
        /// </summary>
        private class UriSlashUnescapeWorkaround : IUriModifier
        {
            public bool RequiresModification(Uri uri)
            {
                return false;
            }

            public Uri Modify(Uri uri)
            {
                throw new NotImplementedException();
            }
        }
#endif
    }
}
