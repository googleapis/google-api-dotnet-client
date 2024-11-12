/*
Copyright 2013 Google Inc

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

using Google.Apis.Core;
using Google.Apis.Discovery;
using Google.Apis.Http;
using Google.Apis.Json;
using Google.Apis.Logging;
using Google.Apis.Requests;
using Google.Apis.Responses;
using Google.Apis.Testing;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Google.Apis.Services
{
    /// <summary>
    /// A base class for a client service which provides common mechanism for all services, like 
    /// serialization and GZip support.  It should be safe to use a single service instance to make server requests
    /// concurrently from multiple threads. 
    /// This class adds a special <see cref="IHttpExecuteInterceptor"/> to the 
    /// <see cref="ConfigurableMessageHandler"/> execute interceptor list, which uses the given 
    /// Authenticator. It calls to its applying authentication method, and injects the "Authorization" header in the 
    /// request.
    /// If the given Authenticator implements <see cref="IHttpUnsuccessfulResponseHandler"/>, this 
    /// class adds the Authenticator to the <see cref="ConfigurableMessageHandler"/>'s unsuccessful 
    /// response handler list.
    /// </summary>
    public abstract class BaseClientService : IClientService
    {
        private const string DefaultUniverseDomain = "googleapis.com";

        /// <summary>The class logger.</summary>
        private static readonly ILogger Logger = ApplicationContext.Logger.ForType<BaseClientService>();

        /// <summary>The default maximum allowed length of a URL string for GET requests.</summary>
        [VisibleForTestOnly]
        public const uint DefaultMaxUrlLength = 2048;

        #region Initializer

        /// <summary>An initializer class for the client service.</summary>
        public class Initializer
        {
            /// <summary>
            /// Gets or sets the factory for creating <see cref="System.Net.Http.HttpClient"/> instance. If this 
            /// property is not set the service uses a new <see cref="Http.HttpClientFactory"/> instance.
            /// </summary>
            public IHttpClientFactory HttpClientFactory { get; set; }

            /// <summary>
            /// Gets or sets a HTTP client initializer which is able to customize properties on 
            /// <see cref="ConfigurableHttpClient"/> and 
            /// <see cref="ConfigurableMessageHandler"/>.
            /// </summary>
            public IConfigurableHttpClientInitializer HttpClientInitializer { get; set; }

            /// <summary>
            /// Indicates which of exceptions and / or HTTP status codes are automatically retried using exponential backoff.
            /// The default value is <see cref="ExponentialBackOffPolicy.UnsuccessfulResponse503"/> which means HTTP Status code 503
            /// will be retried with exponential backoff.
            /// If set to <see cref="ExponentialBackOffPolicy.None" /> no automatic retries will happen.
            /// Calling code may still specify custom retries by configuring <see cref="HttpClient"/>.
            /// </summary>
            public ExponentialBackOffPolicy DefaultExponentialBackOffPolicy { get; set; }

            /// <summary>Gets or sets whether this service supports GZip. Default value is <c>true</c>.</summary>
            public bool GZipEnabled { get; set; }

            /// <summary>
            /// Gets or sets the serializer. Default value is <see cref="NewtonsoftJsonSerializer"/>.
            /// </summary>
            public ISerializer Serializer { get; set; }

            /// <summary>Gets or sets the API Key. Default value is <c>null</c>.</summary>
            public string ApiKey { get; set; }

            /// <summary>
            /// Gets or sets Application name to be used in the User-Agent header. Default value is <c>null</c>. 
            /// </summary>
            public string ApplicationName { get; set; }

            /// <summary>
            /// Maximum allowed length of a URL string for GET requests. Default value is <c>2048</c>. If the value is
            /// set to <c>0</c>, requests will never be modified due to URL string length.
            /// </summary>
            public uint MaxUrlLength { get; set; }

            /// <summary>
            /// Gets or sets the base URI to use for the service. If the value is <c>null</c>,
            /// the default base URI for the service is used.
            /// </summary>
            public string BaseUri { get; set; }

            /// <summary>
            /// The universe domain to connect to, or null to use the default universe domain <see cref="DefaultUniverseDomain"/>.
            /// </summary>
            /// <remarks>
            /// <para>
            /// <see cref="UniverseDomain"/> is used to build the endpoint to connect to, unless <see cref="BaseUri"/>
            /// is set, in which case <see cref="BaseUri"/> will be used without further modification.
            /// <see cref="UniverseDomain"/> may also be used by the credential, if any, to validate against its
            /// own universe domain.
            /// </para>
            /// </remarks>
            public string UniverseDomain { get; set; }

            /// <summary>
            /// The timeout to set on <see cref="HttpClient"/> instances used by the service.
            /// May be null, in which case the default timeout values on <see cref="HttpClient"/> instances
            /// used by this service will be left unchanged.
            /// </summary>
            public TimeSpan? HttpClientTimeout { get; set; }

            /// <summary>
            /// Builder for the x-goog-api-client header, collecting version information.
            /// Services automatically add the API library version to this.
            /// Most users will never need to configure this, but higher level abstraction Google libraries
            /// may add their own version here.
            /// </summary>
            public VersionHeaderBuilder VersionHeaderBuilder { get; }

            /// <summary>
            /// Determines whether request parameters are validated (client-side) by default.
            /// Defaults to true. This can be overridden on a per-request basis using <see cref="ClientServiceRequest{TResponse}.ValidateParameters"/>.
            /// </summary>
            public bool ValidateParameters { get; set; } = true;

            /// <summary>Constructs a new initializer with default values.</summary>
            public Initializer()
            {
                GZipEnabled = true;
                Serializer = new NewtonsoftJsonSerializer();
                DefaultExponentialBackOffPolicy = ExponentialBackOffPolicy.UnsuccessfulResponse503;
                MaxUrlLength = DefaultMaxUrlLength;
                VersionHeaderBuilder = new VersionHeaderBuilder()
                    .AppendDotNetEnvironment();
            }

            // HttpRequestMessage.Headers fails if any of these characters are included in a User-Agent header.
            private const string InvalidApplicationNameCharacters = "\"(),:;<=>?@[\\]{}";

            internal void Validate()
            {
                if (ApplicationName != null && ApplicationName.Any(c => InvalidApplicationNameCharacters.Contains(c)))
                {
                    throw new ArgumentException("Invalid Application name", nameof(ApplicationName));
                }
            }
        }

        #endregion

        /// <summary>Constructs a new base client with the specified initializer.</summary>
        protected BaseClientService(Initializer initializer)
        {
            initializer.Validate();
            // Note that GetType() will get the *actual* type, which will be the service type in the API-specific library.
            // That's the version we want to append.
            // It's important that we clone the VersionHeaderBuilder, so we don't modify the initializer - otherwise
            // a single initializer can't be used for multiple services (which can be useful).
            string versionHeader = initializer.VersionHeaderBuilder.Clone()
                .AppendAssemblyVersion("gdcl", GetType())
                .ToString();
            // Set the right properties by the initializer's properties.
            GZipEnabled = initializer.GZipEnabled;
            Serializer = initializer.Serializer;
            ApiKey = initializer.ApiKey;
            ApplicationName = initializer.ApplicationName;
            BaseUriOverride = initializer.BaseUri;
#pragma warning disable CS0618 // We still need to initialize the value on construction but the setter is rightly obsolete.
            UniverseDomain = initializer.UniverseDomain;
#pragma warning restore CS0618 // Type or member is obsolete
            HttpClientTimeout = initializer.HttpClientTimeout;
            ValidateParameters = initializer.ValidateParameters;
            if (ApplicationName == null)
            {
                Logger.Warning("Application name is not set. Please set Initializer.ApplicationName property");
            }
            HttpClientInitializer = initializer.HttpClientInitializer;

            // Create a HTTP client for this service.
            HttpClient = CreateHttpClient(initializer, versionHeader);
        }

        /// <summary>
        /// Determines whether or not request parameters should be validated client-side.
        /// This may be overridden on a per-request basis.
        /// </summary>
        internal bool ValidateParameters { get; }

        /// <summary>
        /// The BaseUri provided in the initializer, which may be null.
        /// </summary>
        protected string BaseUriOverride { get; }

        /// <summary>
        /// The universe domain to connect to, or null to use the default universe domain <see cref="DefaultUniverseDomain"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// <see cref="UniverseDomain"/> is used to build the endpoint to connect to, unless <see cref="BaseUriOverride"/>
        /// is set, in which case <see cref="BaseUriOverride"/> will be used without further modification.
        /// </para>
        /// </remarks>
        public string UniverseDomain
        { 
            get;
            [Obsolete(
                "Using this setter never had any effect, the UniverseDomain value is used on Client construction only. " +
                "Build a new Client specifying a new universe domain value instead.")]
            set; 
        }

        /// <summary>
        /// The timeout to set on <see cref="HttpClient"/> instances used by the service.
        /// May be null, in which case the default timeout values on <see cref="HttpClient"/> instances
        /// used by this service will be left unchanged.
        /// </summary>
        public TimeSpan? HttpClientTimeout { get; }

        /// <summary>Returns <c>true</c> if this service contains the specified feature.</summary>
        private bool HasFeature(Features feature)
        {
            return Features.Contains(Utilities.GetEnumStringValue(feature));
        }

        private ConfigurableHttpClient CreateHttpClient(Initializer initializer, string versionHeader)
        {
            // If factory wasn't set use the default HTTP client factory.
            var factory = initializer.HttpClientFactory ?? new HttpClientFactory();
            var args = new CreateHttpClientArgs
            {
                GZipEnabled = GZipEnabled,
                ApplicationName = ApplicationName,
                GoogleApiClientHeader = versionHeader,
                UniverseDomain = UniverseDomain ?? DefaultUniverseDomain,
            };

            // Add the user's input initializer.
            if (HttpClientInitializer != null)
            {
                args.Initializers.Add(HttpClientInitializer);
            }

            // Add exponential back-off initializer if necessary.
            if (initializer.DefaultExponentialBackOffPolicy != ExponentialBackOffPolicy.None)
            {
                var effectiveRetryPolicy = GetEffectiveRetryPolicy(initializer.DefaultExponentialBackOffPolicy);
                args.Initializers.Add(new ExponentialBackOffInitializer(initializer.DefaultExponentialBackOffPolicy, CreateBackOffHandler));
            }

            // Add HTTP client timeout initializer if necessary.
            if (HttpClientTimeout is not null)
            {
                args.Initializers.Add(new HttpTimeoutInitializer(HttpClientTimeout.Value));
            }

            var httpClient = factory.CreateHttpClient(args);
            if (initializer.MaxUrlLength > 0)
            {
                httpClient.MessageHandler.AddExecuteInterceptor(new MaxUrlLengthInterceptor(initializer.MaxUrlLength));
            }
            return httpClient;

            static ExponentialBackOffPolicy GetEffectiveRetryPolicy(ExponentialBackOffPolicy retryPolicy) =>
                retryPolicy.HasFlag(ExponentialBackOffPolicy.RecommendedOrDefault) ?
                // At this level there's no recommendation, but we know default is retry 503.
                // Remove RecommendedOrDefault and add UnsuccessfulResponse503.
                (retryPolicy & ~ExponentialBackOffPolicy.RecommendedOrDefault) | ExponentialBackOffPolicy.UnsuccessfulResponse503 :
                retryPolicy;
        }

        /// <summary>
        /// Creates the back-off handler with <see cref="ExponentialBackOff"/>. 
        /// Overrides this method to change the default behavior of back-off handler (e.g. you can change the maximum
        /// waited request's time span, or create a back-off handler with you own implementation of 
        /// <see cref="IBackOff"/>).
        /// </summary>
        protected virtual BackOffHandler CreateBackOffHandler()
        {
            // TODO(peleyal): consider return here interface and not the concrete class
            return new BackOffHandler(new ExponentialBackOff());
        }

        /// <summary>
        /// Gets the effective URI taking into account the <see cref="UniverseDomain"/>.
        /// </summary>
        /// <param name="explicitUri">An explicit URI. May be null.</param>
        /// <param name="defaultUri">A default URI. May be null.</param>
        /// <returns>
        /// <list type="bullet">
        /// <item><paramref name="explicitUri"/> if not null.</item>
        /// <item>
        /// Otherwise, if <see cref="UniverseDomain"/> is not null, the result of replacing
        /// <see cref="DefaultUniverseDomain"/> with <see cref="UniverseDomain"/>
        /// in <paramref name="defaultUri"/>.
        /// </item>
        /// Otherwise <paramref name="defaultUri"/>.
        /// </list>
        /// </returns>
        protected internal string GetEffectiveUri(string explicitUri, string defaultUri) =>
            // Note this method needs to receive explicit and default URIs so we can use
            // it for the batch endpoint as well. The batch endpoint does not have an
            // override mechanism, so we pass explicitUri as null in that case.
            explicitUri ??
            (UniverseDomain is null ? defaultUri : defaultUri?.Replace(DefaultUniverseDomain, UniverseDomain));

        #region IClientService Members

        /// <inheritdoc/>
        public ConfigurableHttpClient HttpClient { get; private set; }

        /// <inheritdoc/>
        public IConfigurableHttpClientInitializer HttpClientInitializer { get; private set; }

        /// <inheritdoc/>
        public bool GZipEnabled { get; private set; }

        /// <inheritdoc/>
        public string ApiKey { get; private set; }

        /// <inheritdoc/>
        public string ApplicationName { get; private set; }

        /// <inheritdoc/>
        public void SetRequestSerailizedContent(HttpRequestMessage request, object body)
        {
            request.SetRequestSerailizedContent(this, body, GZipEnabled);
        }

        #region Serialization

        /// <inheritdoc/>
        public ISerializer Serializer { get; private set; }

        /// <inheritdoc/>
        public virtual string SerializeObject(object obj) => Serializer.Serialize(obj);

        /// <inheritdoc/>
        public virtual async Task<T> DeserializeResponse<T>(HttpResponseMessage response)
        {
            var text = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            // If a string is request, don't parse the response.
			if (Type.Equals(typeof(T), typeof(string)))
            {
                return (T)(object)text;
            }

            // Check if there was an error returned. The error node is returned in both paths
            // Deserialize the stream based upon the format of the stream.
            if (HasFeature(Discovery.Features.LegacyDataResponse))
            {
                // Legacy path (deprecated!)
                StandardResponse<T> sr = null;
                try
                {
                    sr = Serializer.Deserialize<StandardResponse<T>>(text);
                }
                catch (Exception ex)
                {
                    throw new GoogleApiException(Name,
                        $"Failed to parse response from server as {Serializer.Format ?? "unknown format"} [" + text + "]", ex);
                }

                if (sr.Error != null)
                {
                    throw new GoogleApiException(Name, "Server error - " + sr.Error)
                    {
                        Error = sr.Error
                    };
                }

                if (sr.Data == null)
                {
                    throw new GoogleApiException(Name, "The response could not be deserialized.");
                }
                return sr.Data;
            }

            // New path: Deserialize the object directly.
            T result = default(T);
            try
            {
                result = Serializer.Deserialize<T>(text);
            }
            catch (Exception ex)
            {
                throw new GoogleApiException(Name, $"Failed to parse response from server as {Serializer.Format ?? "unknown format"} [" + text + "]", ex);
            }

            // TODO(peleyal): is this the right place to check ETag? it isn't part of deserialization!
            // If this schema/object provides an error container, check it.
            var eTag = response.Headers.ETag != null ? response.Headers.ETag.Tag : null;
            if (result is IDirectResponseSchema && eTag != null)
            {
                (result as IDirectResponseSchema).ETag = eTag;
            }
            return result;
        }

        /// <inheritdoc/>
        public virtual Task<RequestError> DeserializeError(HttpResponseMessage response) =>
            response.DeserializeErrorAsync(Name, Serializer);

        #endregion

        #region Abstract Members

        /// <inheritdoc/>
        public abstract string Name { get; }

        /// <inheritdoc/>
        public abstract string BaseUri { get; }

        /// <inheritdoc/>
        public abstract string BasePath { get; }

        /// <summary>The URI used for batch operations.</summary>
        public virtual string BatchUri { get { return null; } }

        /// <summary>The path used for batch operations.</summary>
        public virtual string BatchPath { get { return null; } }

        /// <inheritdoc/>
        public abstract IList<string> Features { get; }

        #endregion

        #endregion

        /// <inheritdoc/>
        public virtual void Dispose()
        {
            if (HttpClient != null)
            {
                HttpClient.Dispose();
            }
        }
    }
}
