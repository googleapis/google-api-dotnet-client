// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.TrafficDirectorService.v2
{
    /// <summary>The TrafficDirectorService Service.</summary>
    public class TrafficDirectorServiceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public TrafficDirectorServiceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public TrafficDirectorServiceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Discovery = new DiscoveryResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "trafficdirector";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://trafficdirector.googleapis.com/";
        #else
            "https://trafficdirector.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://trafficdirector.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Traffic Director API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Traffic Director API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Discovery resource.</summary>
        public virtual DiscoveryResource Discovery { get; }
    }

    /// <summary>A base abstract class for TrafficDirectorService requests.</summary>
    public abstract class TrafficDirectorServiceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new TrafficDirectorServiceBaseServiceRequest instance.</summary>
        protected TrafficDirectorServiceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1 = 0,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2 = 1,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json = 0,

            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media = 1,

            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto = 2,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>
        /// API key. Your API key identifies your project and provides you with API access, quota, and reports. Required
        /// unless you provide an OAuth 2.0 token.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>
        /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a
        /// user, but should not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes TrafficDirectorService parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "discovery" collection of methods.</summary>
    public class DiscoveryResource
    {
        private const string Resource = "discovery";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DiscoveryResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary></summary>
        /// <param name="body">The body of the request.</param>
        public virtual ClientStatusRequest ClientStatus(Google.Apis.TrafficDirectorService.v2.Data.ClientStatusRequest body)
        {
            return new ClientStatusRequest(service, body);
        }

        /// <summary></summary>
        public class ClientStatusRequest : TrafficDirectorServiceBaseServiceRequest<Google.Apis.TrafficDirectorService.v2.Data.ClientStatusResponse>
        {
            /// <summary>Constructs a new ClientStatus request.</summary>
            public ClientStatusRequest(Google.Apis.Services.IClientService service, Google.Apis.TrafficDirectorService.v2.Data.ClientStatusRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.TrafficDirectorService.v2.Data.ClientStatusRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "client_status";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/discovery:client_status";

            /// <summary>Initializes ClientStatus parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.TrafficDirectorService.v2.Data
{
    /// <summary>
    /// Addresses specify either a logical or physical address and port, which are used to tell Envoy where to
    /// bind/listen, connect to upstream and find management servers.
    /// </summary>
    public class Address : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("pipe")]
        public virtual Pipe Pipe { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("socketAddress")]
        public virtual SocketAddress SocketAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// BuildVersion combines SemVer version of extension with free-form build information (i.e. 'alpha',
    /// 'private-build') as a set of strings.
    /// </summary>
    public class BuildVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Free-form build information. Envoy defines several well known keys in the source/common/version/version.h
        /// file
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>SemVer version of extension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual SemanticVersion Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>All xds configs for a particular client.</summary>
    public class ClientConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Node for a particular client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("node")]
        public virtual Node Node { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("xdsConfig")]
        public virtual System.Collections.Generic.IList<PerXdsConfig> XdsConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for client status of clients identified by a list of NodeMatchers.</summary>
    public class ClientStatusRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Management server can use these match criteria to identify clients. The match follows OR semantics.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeMatchers")]
        public virtual System.Collections.Generic.IList<NodeMatcher> NodeMatchers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ClientStatusResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Client configs for the clients specified in the ClientStatusRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual System.Collections.Generic.IList<ClientConfig> Config { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Envoy's cluster manager fills this message with all currently known clusters. Cluster configuration information
    /// can be used to recreate an Envoy configuration by populating all clusters as static clusters or by returning
    /// them in a CDS response.
    /// </summary>
    public class ClustersConfigDump : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The dynamically loaded active clusters. These are clusters that are available to service data plane traffic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicActiveClusters")]
        public virtual System.Collections.Generic.IList<DynamicCluster> DynamicActiveClusters { get; set; }

        /// <summary>
        /// The dynamically loaded warming clusters. These are clusters that are currently undergoing warming in
        /// preparation to service data plane traffic. Note that if attempting to recreate an Envoy configuration from a
        /// configuration dump, the warming clusters should generally be discarded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicWarmingClusters")]
        public virtual System.Collections.Generic.IList<DynamicCluster> DynamicWarmingClusters { get; set; }

        /// <summary>The statically loaded cluster configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staticClusters")]
        public virtual System.Collections.Generic.IList<StaticCluster> StaticClusters { get; set; }

        /// <summary>
        /// This is the :ref:`version_info ` in the last processed CDS discovery response. If there are only static
        /// bootstrap clusters, this field will be "".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionInfo")]
        public virtual string VersionInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the way to match a double value.</summary>
    public class DoubleMatcher : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If specified, the input double value must be equal to the value specified here.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exact")]
        public virtual System.Nullable<double> Exact { get; set; }

        /// <summary>
        /// If specified, the input double value must be in the range specified here. Note: The range is using half-open
        /// interval semantics [start, end).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual DoubleRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the double start and end of the range using half-open interval semantics [start, end).
    /// </summary>
    public class DoubleRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>end of the range (exclusive)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual System.Nullable<double> End { get; set; }

        /// <summary>start of the range (inclusive)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual System.Nullable<double> Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a dynamically loaded cluster via the CDS API.</summary>
    public class DynamicCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cluster config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual System.Collections.Generic.IDictionary<string, object> Cluster { get; set; }

        /// <summary>The timestamp when the Cluster was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdated")]
        public virtual object LastUpdated { get; set; }

        /// <summary>
        /// This is the per-resource version information. This version is currently taken from the :ref:`version_info `
        /// field at the time that the cluster was loaded. In the future, discrete per-cluster versions may be supported
        /// by the API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionInfo")]
        public virtual string VersionInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a dynamically loaded listener via the LDS API. [#next-free-field: 6]</summary>
    public class DynamicListener : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The listener state for any active listener by this name. These are listeners that are available to service
        /// data plane traffic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeState")]
        public virtual DynamicListenerState ActiveState { get; set; }

        /// <summary>
        /// The listener state for any draining listener by this name. These are listeners that are currently undergoing
        /// draining in preparation to stop servicing data plane traffic. Note that if attempting to recreate an Envoy
        /// configuration from a configuration dump, the draining listeners should generally be discarded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("drainingState")]
        public virtual DynamicListenerState DrainingState { get; set; }

        /// <summary>Set if the last update failed, cleared after the next successful update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorState")]
        public virtual UpdateFailureState ErrorState { get; set; }

        /// <summary>The name or unique id of this listener, pulled from the DynamicListenerState config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The listener state for any warming listener by this name. These are listeners that are currently undergoing
        /// warming in preparation to service data plane traffic. Note that if attempting to recreate an Envoy
        /// configuration from a configuration dump, the warming listeners should generally be discarded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warmingState")]
        public virtual DynamicListenerState WarmingState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DynamicListenerState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The timestamp when the Listener was last successfully updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdated")]
        public virtual object LastUpdated { get; set; }

        /// <summary>The listener config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listener")]
        public virtual System.Collections.Generic.IDictionary<string, object> Listener { get; set; }

        /// <summary>
        /// This is the per-resource version information. This version is currently taken from the :ref:`version_info `
        /// field at the time that the listener was loaded. In the future, discrete per-listener versions may be
        /// supported by the API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionInfo")]
        public virtual string VersionInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DynamicRouteConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The timestamp when the Route was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdated")]
        public virtual object LastUpdated { get; set; }

        /// <summary>The route config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeConfig")]
        public virtual System.Collections.Generic.IDictionary<string, object> RouteConfig { get; set; }

        /// <summary>
        /// This is the per-resource version information. This version is currently taken from the :ref:`version_info `
        /// field at the time that the route configuration was loaded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionInfo")]
        public virtual string VersionInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DynamicScopedRouteConfigs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The timestamp when the scoped route config set was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdated")]
        public virtual object LastUpdated { get; set; }

        /// <summary>The name assigned to the scoped route configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The scoped route configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopedRouteConfigs")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> ScopedRouteConfigs { get; set; }

        /// <summary>
        /// This is the per-resource version information. This version is currently taken from the :ref:`version_info `
        /// field at the time that the scoped routes configuration was loaded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionInfo")]
        public virtual string VersionInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Version and identification for an Envoy extension. [#next-free-field: 6]</summary>
    public class Extension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Category of the extension. Extension category names use reverse DNS notation. For instance
        /// "envoy.filters.listener" for Envoy's built-in listener filters or "com.acme.filters.http" for HTTP filters
        /// from acme.com vendor. [#comment:
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>Indicates that the extension is present but was disabled via dynamic configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; }

        /// <summary>
        /// This is the name of the Envoy filter as specified in the Envoy configuration, e.g.
        /// envoy.filters.http.router, com.acme.widget.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>[#not-implemented-hide:] Type descriptor of extension configuration proto. [#comment:</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("typeDescriptor")]
        public virtual string TypeDescriptor { get; set; }

        /// <summary>
        /// The version is a property of the extension and maintained independently of other extensions and the Envoy
        /// API. This field is not set when extension did not provide version information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual BuildVersion Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Google's `RE2 `_ regex engine. The regex string must adhere to the documented `syntax `_. The engine is designed
    /// to complete execution in linear time as well as limit the amount of memory used. Envoy supports program size
    /// checking via runtime. The runtime keys `re2.max_program_size.error_level` and `re2.max_program_size.warn_level`
    /// can be set to integers as the maximum program size or complexity that a compiled regex can have before an
    /// exception is thrown or a warning is logged, respectively. `re2.max_program_size.error_level` defaults to 100,
    /// and `re2.max_program_size.warn_level` has no default if unset (will not check/log a warning). Envoy emits two
    /// stats for tracking the program size of regexes: the histogram `re2.program_size`, which records the program
    /// size, and the counter `re2.exceeded_warn_level`, which is incremented each time the program size exceeds the
    /// warn level threshold.
    /// </summary>
    public class GoogleRE2 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This field controls the RE2 "program size" which is a rough estimate of how complex a compiled regex is to
        /// evaluate. A regex that has a program size greater than the configured value will fail to compile. In this
        /// case, the configured max program size can be increased or the regex can be simplified. If not specified, the
        /// default is 100. This field is deprecated; regexp validation should be performed on the management server
        /// instead of being done by each individual client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxProgramSize")]
        public virtual System.Nullable<long> MaxProgramSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class InlineScopedRouteConfigs : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The timestamp when the scoped route config set was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdated")]
        public virtual object LastUpdated { get; set; }

        /// <summary>The name assigned to the scoped route configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The scoped route configurations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopedRouteConfigs")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> ScopedRouteConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the way to match a list value.</summary>
    public class ListMatcher : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If specified, at least one of the values in the list must match the value specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneOf")]
        public virtual ValueMatcher OneOf { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Envoy's listener manager fills this message with all currently known listeners. Listener configuration
    /// information can be used to recreate an Envoy configuration by populating all listeners as static listeners or by
    /// returning them in a LDS response.
    /// </summary>
    public class ListenersConfigDump : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>State for any warming, active, or draining listeners.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicListeners")]
        public virtual System.Collections.Generic.IList<DynamicListener> DynamicListeners { get; set; }

        /// <summary>The statically loaded listener configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staticListeners")]
        public virtual System.Collections.Generic.IList<StaticListener> StaticListeners { get; set; }

        /// <summary>
        /// This is the :ref:`version_info ` in the last processed LDS discovery response. If there are only static
        /// bootstrap listeners, this field will be "".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionInfo")]
        public virtual string VersionInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifies location of where either Envoy runs or where upstream hosts run.</summary>
    public class Locality : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Region this :ref:`zone ` belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; }

        /// <summary>
        /// When used for locality of upstream hosts, this field further splits zone into smaller chunks of sub-zones so
        /// they can be load balanced independently.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subZone")]
        public virtual string SubZone { get; set; }

        /// <summary>
        /// Defines the local service zone where Envoy is running. Though optional, it should be set if discovery
        /// service routing is used and the discovery service exposes :ref:`zone data `, either in this message or via
        /// :option:`--service-zone`. The meaning of zone is context dependent, e.g. `Availability Zone (AZ) `_ on AWS,
        /// `Zone `_ on GCP, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Identifies a specific Envoy instance. The node identifier is presented to the management server, which may use
    /// this identifier to distinguish per Envoy configuration for serving. [#next-free-field: 12]
    /// </summary>
    public class Node : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This is motivated by informing a management server during canary which version of Envoy is being tested in a
        /// heterogeneous fleet. This will be set by Envoy in management server RPCs. This field is deprecated in favor
        /// of the user_agent_name and user_agent_version values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildVersion")]
        public virtual string BuildVersion { get; set; }

        /// <summary>
        /// Client feature support list. These are well known features described in the Envoy API repository for a given
        /// major version of an API. Client features use reverse DNS naming scheme, for example `com.acme.feature`. See
        /// :ref:`the list of features ` that xDS client may support.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientFeatures")]
        public virtual System.Collections.Generic.IList<string> ClientFeatures { get; set; }

        /// <summary>
        /// Defines the local service cluster name where Envoy is running. Though optional, it should be set if any of
        /// the following features are used: :ref:`statsd `, :ref:`health check cluster verification `, :ref:`runtime
        /// override directory `, :ref:`user agent addition `, :ref:`HTTP global rate limiting `, :ref:`CDS `, and
        /// :ref:`HTTP tracing `, either in this message or via :option:`--service-cluster`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual string Cluster { get; set; }

        /// <summary>List of extensions and their versions supported by the node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensions")]
        public virtual System.Collections.Generic.IList<Extension> Extensions { get; set; }

        /// <summary>
        /// An opaque node identifier for the Envoy node. This also provides the local service node name. It should be
        /// set if any of the following features are used: :ref:`statsd `, :ref:`CDS `, and :ref:`HTTP tracing `, either
        /// in this message or via :option:`--service-node`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Known listening ports on the node as a generic hint to the management server for filtering :ref:`listeners `
        /// to be returned. For example, if there is a listener bound to port 80, the list can optionally contain the
        /// SocketAddress `(0.0.0.0,80)`. The field is optional and just a hint.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listeningAddresses")]
        public virtual System.Collections.Generic.IList<Address> ListeningAddresses { get; set; }

        /// <summary>Locality specifying where the Envoy instance is running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual Locality Locality { get; set; }

        /// <summary>
        /// Opaque metadata extending the node identifier. Envoy will pass this directly to the management server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>Structured version of the entity requesting config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgentBuildVersion")]
        public virtual BuildVersion UserAgentBuildVersion { get; set; }

        /// <summary>Free-form string that identifies the entity requesting config. E.g. "envoy" or "grpc"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgentName")]
        public virtual string UserAgentName { get; set; }

        /// <summary>
        /// Free-form string that identifies the version of the entity requesting config. E.g. "1.12.2" or "abcd1234",
        /// or "SpecialEnvoyBuild"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgentVersion")]
        public virtual string UserAgentVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the way to match a Node. The match follows AND semantics.</summary>
    public class NodeMatcher : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies match criteria on the node id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeId")]
        public virtual StringMatcher NodeId { get; set; }

        /// <summary>Specifies match criteria on the node metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeMetadatas")]
        public virtual System.Collections.Generic.IList<StructMatcher> NodeMetadatas { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>NullMatch is an empty message to specify a null value.</summary>
    public class NullMatch : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the segment in a path to retrieve value from Struct.</summary>
    public class PathSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If specified, use the key to retrieve the value in a Struct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Detailed config (per xDS) with status. [#next-free-field: 6]</summary>
    public class PerXdsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("clusterConfig")]
        public virtual ClustersConfigDump ClusterConfig { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("listenerConfig")]
        public virtual ListenersConfigDump ListenerConfig { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("routeConfig")]
        public virtual RoutesConfigDump RouteConfig { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("scopedRouteConfig")]
        public virtual ScopedRoutesConfigDump ScopedRouteConfig { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Pipe : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The mode for the Pipe. Not applicable for abstract sockets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mode")]
        public virtual System.Nullable<long> Mode { get; set; }

        /// <summary>
        /// Unix Domain Socket path. On Linux, paths starting with '@' will use the abstract namespace. The starting '@'
        /// is replaced by a null byte by Envoy. Paths starting with '@' will result in an error in environments other
        /// than Linux.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A regex matcher designed for safety when used with untrusted input.</summary>
    public class RegexMatcher : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google's RE2 regex engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleRe2")]
        public virtual GoogleRE2 GoogleRe2 { get; set; }

        /// <summary>The regex match string. The string must be supported by the configured engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regex")]
        public virtual string Regex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Envoy's RDS implementation fills this message with all currently loaded routes, as described by their
    /// RouteConfiguration objects. Static routes that are either defined in the bootstrap configuration or defined
    /// inline while configuring listeners are separated from those configured dynamically via RDS. Route configuration
    /// information can be used to recreate an Envoy configuration by populating all routes as static routes or by
    /// returning them in RDS responses.
    /// </summary>
    public class RoutesConfigDump : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dynamically loaded route configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicRouteConfigs")]
        public virtual System.Collections.Generic.IList<DynamicRouteConfig> DynamicRouteConfigs { get; set; }

        /// <summary>The statically loaded route configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("staticRouteConfigs")]
        public virtual System.Collections.Generic.IList<StaticRouteConfig> StaticRouteConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Envoy's scoped RDS implementation fills this message with all currently loaded route configuration scopes
    /// (defined via ScopedRouteConfigurationsSet protos). This message lists both the scopes defined inline with the
    /// higher order object (i.e., the HttpConnectionManager) and the dynamically obtained scopes via the SRDS API.
    /// </summary>
    public class ScopedRoutesConfigDump : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dynamically loaded scoped route configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dynamicScopedRouteConfigs")]
        public virtual System.Collections.Generic.IList<DynamicScopedRouteConfigs> DynamicScopedRouteConfigs { get; set; }

        /// <summary>The statically loaded scoped route configs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inlineScopedRouteConfigs")]
        public virtual System.Collections.Generic.IList<InlineScopedRouteConfigs> InlineScopedRouteConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Envoy uses SemVer (https://semver.org/). Major/minor versions indicate expected behaviors and APIs, the patch
    /// version field is used only for security fixes and can be generally ignored.
    /// </summary>
    public class SemanticVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("majorNumber")]
        public virtual System.Nullable<long> MajorNumber { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("minorNumber")]
        public virtual System.Nullable<long> MinorNumber { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("patch")]
        public virtual System.Nullable<long> Patch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>[#next-free-field: 7]</summary>
    public class SocketAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The address for this socket. :ref:`Listeners ` will bind to the address. An empty address is not allowed.
        /// Specify ``0.0.0.0`` or ``::`` to bind to any address. [#comment:TODO(zuercher) reinstate when implemented:
        /// It is possible to distinguish a Listener address via the prefix/suffix matching in :ref:`FilterChainMatch
        /// `.] When used within an upstream :ref:`BindConfig `, the address controls the source address of outbound
        /// connections. For :ref:`clusters `, the cluster type determines whether the address must be an IP (*STATIC*
        /// or *EDS* clusters) or a hostname resolved by DNS (*STRICT_DNS* or *LOGICAL_DNS* clusters). Address
        /// resolution can be customized via :ref:`resolver_name `.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>
        /// When binding to an IPv6 address above, this enables `IPv4 compatibility `_. Binding to ``::`` will allow
        /// both IPv4 and IPv6 connections, with peer IPv4 addresses mapped into IPv6 space as ``::FFFF:``.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipv4Compat")]
        public virtual System.Nullable<bool> Ipv4Compat { get; set; }

        /// <summary>
        /// This is only valid if :ref:`resolver_name ` is specified below and the named resolver is capable of named
        /// port resolution.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedPort")]
        public virtual string NamedPort { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("portValue")]
        public virtual System.Nullable<long> PortValue { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>
        /// The name of the custom resolver. This must have been registered with Envoy. If this is empty, a context
        /// dependent default applies. If the address is a concrete IP address, no resolution will occur. If address is
        /// a hostname this should be set for resolution other than DNS. Specifying a custom resolver with *STRICT_DNS*
        /// or *LOGICAL_DNS* will generate an error at runtime.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolverName")]
        public virtual string ResolverName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a statically loaded cluster.</summary>
    public class StaticCluster : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cluster config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cluster")]
        public virtual System.Collections.Generic.IDictionary<string, object> Cluster { get; set; }

        /// <summary>The timestamp when the Cluster was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdated")]
        public virtual object LastUpdated { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a statically loaded listener.</summary>
    public class StaticListener : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The timestamp when the Listener was last successfully updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdated")]
        public virtual object LastUpdated { get; set; }

        /// <summary>The listener config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listener")]
        public virtual System.Collections.Generic.IDictionary<string, object> Listener { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class StaticRouteConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The timestamp when the Route was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdated")]
        public virtual object LastUpdated { get; set; }

        /// <summary>The route config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routeConfig")]
        public virtual System.Collections.Generic.IDictionary<string, object> RouteConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the way to match a string. [#next-free-field: 7]</summary>
    public class StringMatcher : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The input string must match exactly the string specified here. Examples: * *abc* only matches the value
        /// *abc*.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exact")]
        public virtual string Exact { get; set; }

        /// <summary>
        /// If true, indicates the exact/prefix/suffix matching should be case insensitive. This has no effect for the
        /// safe_regex match. For example, the matcher *data* will match both input string *Data* and *data* if set to
        /// true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreCase")]
        public virtual System.Nullable<bool> IgnoreCase { get; set; }

        /// <summary>
        /// The input string must have the prefix specified here. Note: empty prefix is not allowed, please use regex
        /// instead. Examples: * *abc* matches the value *abc.xyz*
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefix")]
        public virtual string Prefix { get; set; }

        /// <summary>
        /// The input string must match the regular expression specified here. The regex grammar is defined `here `_.
        /// Examples: * The regex ``\d{3}`` matches the value *123* * The regex ``\d{3}`` does not match the value
        /// *1234* * The regex ``\d{3}`` does not match the value *123.456* .. attention:: This field has been
        /// deprecated in favor of `safe_regex` as it is not safe for use with untrusted input in all cases.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regex")]
        public virtual string Regex { get; set; }

        /// <summary>The input string must match the regular expression specified here.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safeRegex")]
        public virtual RegexMatcher SafeRegex { get; set; }

        /// <summary>
        /// The input string must have the suffix specified here. Note: empty prefix is not allowed, please use regex
        /// instead. Examples: * *abc* matches the value *xyz.abc*
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suffix")]
        public virtual string Suffix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// StructMatcher provides a general interface to check if a given value is matched in google.protobuf.Struct. It
    /// uses `path` to retrieve the value from the struct and then check if it's matched to the specified value. For
    /// example, for the following Struct: .. code-block:: yaml fields: a: struct_value: fields: b: struct_value:
    /// fields: c: string_value: pro t: list_value: values: - string_value: m - string_value: n The following
    /// MetadataMatcher is matched as the path [a, b, c] will retrieve a string value "pro" from the Metadata which is
    /// matched to the specified prefix match. .. code-block:: yaml path: - key: a - key: b - key: c value:
    /// string_match: prefix: pr The following StructMatcher is matched as the code will match one of the string values
    /// in the list at the path [a, t]. .. code-block:: yaml path: - key: a - key: t value: list_match: one_of:
    /// string_match: exact: m An example use of StructMatcher is to match metadata in envoy.v*.core.Node.
    /// </summary>
    public class StructMatcher : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The path to retrieve the Value from the Struct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual System.Collections.Generic.IList<PathSegment> Path { get; set; }

        /// <summary>The StructMatcher is matched if the value retrieved by path is matched to this value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual ValueMatcher Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UpdateFailureState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details about the last failed update attempt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; }

        /// <summary>What the component configuration would have been if the update had succeeded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failedConfiguration")]
        public virtual System.Collections.Generic.IDictionary<string, object> FailedConfiguration { get; set; }

        /// <summary>Time of the latest failed update attempt.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateAttempt")]
        public virtual object LastUpdateAttempt { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the way to match a ProtobufWkt::Value. Primitive values and ListValue are supported. StructValue is
    /// not supported and is always not matched. [#next-free-field: 7]
    /// </summary>
    public class ValueMatcher : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If specified, a match occurs if and only if the target value is a bool value and is equal to this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolMatch")]
        public virtual System.Nullable<bool> BoolMatch { get; set; }

        /// <summary>
        /// If specified, a match occurs if and only if the target value is a double value and is matched to this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleMatch")]
        public virtual DoubleMatcher DoubleMatch { get; set; }

        /// <summary>
        /// If specified, a match occurs if and only if the target value is a list value and is matched to this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listMatch")]
        public virtual ListMatcher ListMatch { get; set; }

        /// <summary>If specified, a match occurs if and only if the target value is a NullValue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nullMatch")]
        public virtual NullMatch NullMatch { get; set; }

        /// <summary>
        /// If specified, value match will be performed based on whether the path is referring to a valid primitive
        /// value in the metadata. If the path is referring to a non-primitive value, the result is always not matched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("presentMatch")]
        public virtual System.Nullable<bool> PresentMatch { get; set; }

        /// <summary>
        /// If specified, a match occurs if and only if the target value is a string value and is matched to this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringMatch")]
        public virtual StringMatcher StringMatch { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
