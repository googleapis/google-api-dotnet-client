using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Google.Apis.Testing;

using System.Net;

namespace Google.Apis.Requests.RequestDecorators
{
    /// <summary>
    /// An IRequestDecorator implementation that decorates the UserAgent.
    /// </summary>
    /// <remarks>
    /// Sets the user agent to:
    /// {ApplicationName} google-api-dotnet-client/{ApiVersion} {Platform}/{PlatformVersion}
    /// Also appends the (gzip) string if appropriate.
    /// </remarks>
    class UserAgentRequestDecorator : IRequestDecorator
    {
        /// <summary>
        /// Create a new instance of the UserAgentRequestDecorator.
        /// </summary>
        /// <param name="applicationName">The application name to use in building the UserAgent.</param>
        /// <param name="gzipEnabled">Include GZip information in the UserAgent.</param>
        public UserAgentRequestDecorator(string applicationName, bool gzipEnabled)
        {
            ApplicationName = applicationName;
            GZipEnabled = gzipEnabled;
        }

        /// <summary>
        /// Application name to use in the UserAgent
        /// </summary>
        public string ApplicationName { get; private set; }

        /// <summary>
        /// Include GZip compatiblity in the UserAgent.
        /// </summary>
        public bool GZipEnabled { get; private set; }

        #region IRequestDecorator Members

        private const string UserAgent = "{0} google-api-dotnet-client/{1} {2}/{3}";
        private static readonly String ApiVersion = Utilities.GetLibraryVersion();
        private const string GZipUserAgentSuffix = " (gzip)";

        /// <summary>
        /// Sets the UserAgent of the request.
        /// </summary>
        /// <param name="webRequest">A <see cref="HttpWebRequest"/> to be decorated.</param>
        public void DecorateRequest(HttpWebRequest webRequest)
        {
            webRequest.UserAgent = GetUserAgent();
        }

        #endregion

        /// <summary>
        /// Builds the UserAgent string from:
        /// <list>
        ///   <item>ApplicationName</item>
        ///   <item>google-api-dotnet-client/ApiVersion</item>
        ///   <item>Platform/PlatformVersion</item>
        ///   <item>gzip</item>
        /// </list>
        /// </summary>
        /// <returns></returns>
        private string GetUserAgent()
        {
            string appName = FormatForUserAgent(ApplicationName);
            string apiVersion = FormatForUserAgent(ApiVersion);
            string platform = FormatForUserAgent(Environment.OSVersion.Platform.ToString());
            string platformVer = FormatForUserAgent(Environment.OSVersion.Version.ToString());

            // The UserAgent header can only be set on a non-Silverlight platform.
            // Silverlight uses the user agent of the browser instead.
            string userAgent = String.Format(UserAgent, appName, apiVersion, platform, platformVer);

            if (GZipEnabled)
            {
                userAgent += GZipUserAgentSuffix;
            }

            return userAgent;
        }

        /// <summary>
        /// Converts tokens for use in the User Agent string.
        /// </summary>
        /// <param name="fragment">The string to be converted.</param>
        /// <returns>A string compatible with the user-agent string.</returns>
        /// <remarks>
        /// Converts spaces to underscores.
        /// </remarks>
        private string FormatForUserAgent(string fragment)
        {
            return fragment.Replace(' ', '_');
        }
    }
}
