// Copyright 2025 Google LLC
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

namespace Google.Apis.Digitalassetlinks.v1
{
    /// <summary>The Digitalassetlinks Service.</summary>
    public class DigitalassetlinksService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DigitalassetlinksService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DigitalassetlinksService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Assetlinks = new AssetlinksResource(this);
            Statements = new StatementsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://digitalassetlinks.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://digitalassetlinks.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "digitalassetlinks";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the Assetlinks resource.</summary>
        public virtual AssetlinksResource Assetlinks { get; }

        /// <summary>Gets the Statements resource.</summary>
        public virtual StatementsResource Statements { get; }
    }

    /// <summary>A base abstract class for Digitalassetlinks requests.</summary>
    public abstract class DigitalassetlinksBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DigitalassetlinksBaseServiceRequest instance.</summary>
        protected DigitalassetlinksBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Digitalassetlinks parameter list.</summary>
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

    /// <summary>The "assetlinks" collection of methods.</summary>
    public class AssetlinksResource
    {
        private const string Resource = "assetlinks";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AssetlinksResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Send a bundle of statement checks in a single RPC to minimize latency and service load. Statements need not
        /// be all for the same source and/or target. We recommend using this method when you need to check more than
        /// one statement in a short period of time.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual BulkCheckRequest BulkCheck(Google.Apis.Digitalassetlinks.v1.Data.BulkCheckRequest body)
        {
            return new BulkCheckRequest(this.service, body);
        }

        /// <summary>
        /// Send a bundle of statement checks in a single RPC to minimize latency and service load. Statements need not
        /// be all for the same source and/or target. We recommend using this method when you need to check more than
        /// one statement in a short period of time.
        /// </summary>
        public class BulkCheckRequest : DigitalassetlinksBaseServiceRequest<Google.Apis.Digitalassetlinks.v1.Data.BulkCheckResponse>
        {
            /// <summary>Constructs a new BulkCheck request.</summary>
            public BulkCheckRequest(Google.Apis.Services.IClientService service, Google.Apis.Digitalassetlinks.v1.Data.BulkCheckRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Digitalassetlinks.v1.Data.BulkCheckRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "bulkCheck";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/assetlinks:bulkCheck";

            /// <summary>Initializes BulkCheck parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Determines whether the specified (directional) relationship exists between the specified source and target
        /// assets. The relation describes the intent of the link between the two assets as claimed by the source asset.
        /// An example for such relationships is the delegation of privileges or permissions. This command is most often
        /// used by infrastructure systems to check preconditions for an action. For example, a client may want to know
        /// if it is OK to send a web URL to a particular mobile app instead. The client can check for the relevant
        /// asset link from the website to the mobile app to decide if the operation should be allowed. A note about
        /// security: if you specify a secure asset as the source, such as an HTTPS website or an Android app, the API
        /// will ensure that any statements used to generate the response have been made in a secure way by the owner of
        /// that asset. Conversely, if the source asset is an insecure HTTP website (that is, the URL starts with
        /// `http://` instead of `https://`), the API cannot verify its statements securely, and it is not possible to
        /// ensure that the website's statements have not been altered by a third party. For more information, see the
        /// [Digital Asset Links technical design
        /// specification](https://github.com/google/digitalassetlinks/blob/master/well-known/details.md).
        /// </summary>
        public virtual CheckRequest Check()
        {
            return new CheckRequest(this.service);
        }

        /// <summary>
        /// Determines whether the specified (directional) relationship exists between the specified source and target
        /// assets. The relation describes the intent of the link between the two assets as claimed by the source asset.
        /// An example for such relationships is the delegation of privileges or permissions. This command is most often
        /// used by infrastructure systems to check preconditions for an action. For example, a client may want to know
        /// if it is OK to send a web URL to a particular mobile app instead. The client can check for the relevant
        /// asset link from the website to the mobile app to decide if the operation should be allowed. A note about
        /// security: if you specify a secure asset as the source, such as an HTTPS website or an Android app, the API
        /// will ensure that any statements used to generate the response have been made in a secure way by the owner of
        /// that asset. Conversely, if the source asset is an insecure HTTP website (that is, the URL starts with
        /// `http://` instead of `https://`), the API cannot verify its statements securely, and it is not possible to
        /// ensure that the website's statements have not been altered by a third party. For more information, see the
        /// [Digital Asset Links technical design
        /// specification](https://github.com/google/digitalassetlinks/blob/master/well-known/details.md).
        /// </summary>
        public class CheckRequest : DigitalassetlinksBaseServiceRequest<Google.Apis.Digitalassetlinks.v1.Data.CheckResponse>
        {
            /// <summary>Constructs a new Check request.</summary>
            public CheckRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Query string for the relation. We identify relations with strings of the format `/`, where `` must be
            /// one of a set of pre-defined purpose categories, and `` is a free-form lowercase alphanumeric string that
            /// describes the specific use case of the statement. Refer to [our API
            /// documentation](/digital-asset-links/v1/relation-strings) for the current list of supported relations.
            /// For a query to match an asset link, both the query's and the asset link's relation strings must match
            /// exactly. Example: A query with relation `delegate_permission/common.handle_all_urls` matches an asset
            /// link with relation `delegate_permission/common.handle_all_urls`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("relation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Relation { get; set; }

            /// <summary>
            /// The uppercase SHA-265 fingerprint of the certificate. From the PEM certificate, it can be acquired like
            /// this: $ keytool -printcert -file $CERTFILE | grep SHA256: SHA256:
            /// 14:6D:E9:83:C5:73:06:50:D8:EE:B9:95:2F:34:FC:64:16:A0:83: \ 42:E6:1D:BE:A8:8A:04:96:B2:3F:CF:44:E5 or
            /// like this: $ openssl x509 -in $CERTFILE -noout -fingerprint -sha256 SHA256
            /// Fingerprint=14:6D:E9:83:C5:73:06:50:D8:EE:B9:95:2F:34:FC:64: \
            /// 16:A0:83:42:E6:1D:BE:A8:8A:04:96:B2:3F:CF:44:E5 In this example, the contents of this field would be
            /// `14:6D:E9:83:C5:73: 06:50:D8:EE:B9:95:2F:34:FC:64:16:A0:83:42:E6:1D:BE:A8:8A:04:96:B2:3F:CF: 44:E5`. If
            /// these tools are not available to you, you can convert the PEM certificate into the DER format, compute
            /// the SHA-256 hash of that string and represent the result as a hexstring (that is, uppercase hexadecimal
            /// representations of each octet, separated by colons).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("source.androidApp.certificate.sha256Fingerprint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SourceAndroidAppCertificateSha256Fingerprint { get; set; }

            /// <summary>
            /// Android App assets are naturally identified by their Java package name. For example, the Google Maps app
            /// uses the package name `com.google.android.apps.maps`. REQUIRED
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("source.androidApp.packageName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SourceAndroidAppPackageName { get; set; }

            /// <summary>
            /// Web assets are identified by a URL that contains only the scheme, hostname and port parts. The format is
            /// http[s]://[:] Hostnames must be fully qualified: they must end in a single period ("`.`"). Only the
            /// schemes "http" and "https" are currently allowed. Port numbers are given as a decimal number, and they
            /// must be omitted if the standard port numbers are used: 80 for http and 443 for https. We call this
            /// limited URL the "site". All URLs that share the same scheme, hostname and port are considered to be a
            /// part of the site and thus belong to the web asset. Example: the asset with the site
            /// `https://www.google.com` contains all these URLs: * `https://www.google.com/` *
            /// `https://www.google.com:443/` * `https://www.google.com/foo` * `https://www.google.com/foo?bar` *
            /// `https://www.google.com/foo#bar` * `https://user@password:www.google.com/` But it does not contain these
            /// URLs: * `http://www.google.com/` (wrong scheme) * `https://google.com/` (hostname does not match) *
            /// `https://www.google.com:444/` (port does not match) REQUIRED
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("source.web.site", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SourceWebSite { get; set; }

            /// <summary>
            /// The uppercase SHA-265 fingerprint of the certificate. From the PEM certificate, it can be acquired like
            /// this: $ keytool -printcert -file $CERTFILE | grep SHA256: SHA256:
            /// 14:6D:E9:83:C5:73:06:50:D8:EE:B9:95:2F:34:FC:64:16:A0:83: \ 42:E6:1D:BE:A8:8A:04:96:B2:3F:CF:44:E5 or
            /// like this: $ openssl x509 -in $CERTFILE -noout -fingerprint -sha256 SHA256
            /// Fingerprint=14:6D:E9:83:C5:73:06:50:D8:EE:B9:95:2F:34:FC:64: \
            /// 16:A0:83:42:E6:1D:BE:A8:8A:04:96:B2:3F:CF:44:E5 In this example, the contents of this field would be
            /// `14:6D:E9:83:C5:73: 06:50:D8:EE:B9:95:2F:34:FC:64:16:A0:83:42:E6:1D:BE:A8:8A:04:96:B2:3F:CF: 44:E5`. If
            /// these tools are not available to you, you can convert the PEM certificate into the DER format, compute
            /// the SHA-256 hash of that string and represent the result as a hexstring (that is, uppercase hexadecimal
            /// representations of each octet, separated by colons).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("target.androidApp.certificate.sha256Fingerprint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TargetAndroidAppCertificateSha256Fingerprint { get; set; }

            /// <summary>
            /// Android App assets are naturally identified by their Java package name. For example, the Google Maps app
            /// uses the package name `com.google.android.apps.maps`. REQUIRED
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("target.androidApp.packageName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TargetAndroidAppPackageName { get; set; }

            /// <summary>
            /// Web assets are identified by a URL that contains only the scheme, hostname and port parts. The format is
            /// http[s]://[:] Hostnames must be fully qualified: they must end in a single period ("`.`"). Only the
            /// schemes "http" and "https" are currently allowed. Port numbers are given as a decimal number, and they
            /// must be omitted if the standard port numbers are used: 80 for http and 443 for https. We call this
            /// limited URL the "site". All URLs that share the same scheme, hostname and port are considered to be a
            /// part of the site and thus belong to the web asset. Example: the asset with the site
            /// `https://www.google.com` contains all these URLs: * `https://www.google.com/` *
            /// `https://www.google.com:443/` * `https://www.google.com/foo` * `https://www.google.com/foo?bar` *
            /// `https://www.google.com/foo#bar` * `https://user@password:www.google.com/` But it does not contain these
            /// URLs: * `http://www.google.com/` (wrong scheme) * `https://google.com/` (hostname does not match) *
            /// `https://www.google.com:444/` (port does not match) REQUIRED
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("target.web.site", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TargetWebSite { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "check";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/assetlinks:check";

            /// <summary>Initializes Check parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("relation", new Google.Apis.Discovery.Parameter
                {
                    Name = "relation",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source.androidApp.certificate.sha256Fingerprint", new Google.Apis.Discovery.Parameter
                {
                    Name = "source.androidApp.certificate.sha256Fingerprint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source.androidApp.packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "source.androidApp.packageName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source.web.site", new Google.Apis.Discovery.Parameter
                {
                    Name = "source.web.site",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("target.androidApp.certificate.sha256Fingerprint", new Google.Apis.Discovery.Parameter
                {
                    Name = "target.androidApp.certificate.sha256Fingerprint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("target.androidApp.packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "target.androidApp.packageName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("target.web.site", new Google.Apis.Discovery.Parameter
                {
                    Name = "target.web.site",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "statements" collection of methods.</summary>
    public class StatementsResource
    {
        private const string Resource = "statements";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public StatementsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Retrieves a list of all statements from a given source that match the specified target and statement string.
        /// The API guarantees that all statements with secure source assets, such as HTTPS websites or Android apps,
        /// have been made in a secure way by the owner of those assets, as described in the [Digital Asset Links
        /// technical design
        /// specification](https://github.com/google/digitalassetlinks/blob/master/well-known/details.md). Specifically,
        /// you should consider that for insecure websites (that is, where the URL starts with `http://` instead of
        /// `https://`), this guarantee cannot be made. The `List` command is most useful in cases where the API client
        /// wants to know all the ways in which two assets are related, or enumerate all the relationships from a
        /// particular source asset. Example: a feature that helps users navigate to related items. When a mobile app is
        /// running on a device, the feature would make it easy to navigate to the corresponding web site or Google+
        /// profile.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Retrieves a list of all statements from a given source that match the specified target and statement string.
        /// The API guarantees that all statements with secure source assets, such as HTTPS websites or Android apps,
        /// have been made in a secure way by the owner of those assets, as described in the [Digital Asset Links
        /// technical design
        /// specification](https://github.com/google/digitalassetlinks/blob/master/well-known/details.md). Specifically,
        /// you should consider that for insecure websites (that is, where the URL starts with `http://` instead of
        /// `https://`), this guarantee cannot be made. The `List` command is most useful in cases where the API client
        /// wants to know all the ways in which two assets are related, or enumerate all the relationships from a
        /// particular source asset. Example: a feature that helps users navigate to related items. When a mobile app is
        /// running on a device, the feature would make it easy to navigate to the corresponding web site or Google+
        /// profile.
        /// </summary>
        public class ListRequest : DigitalassetlinksBaseServiceRequest<Google.Apis.Digitalassetlinks.v1.Data.ListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Use only associations that match the specified relation. See the [`Statement`](#Statement) message for a
            /// detailed definition of relation strings. For a query to match a statement, one of the following must be
            /// true: * both the query's and the statement's relation strings match exactly, or * the query's relation
            /// string is empty or missing. Example: A query with relation `delegate_permission/common.handle_all_urls`
            /// matches an asset link with relation `delegate_permission/common.handle_all_urls`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("relation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Relation { get; set; }

            /// <summary>
            /// The uppercase SHA-265 fingerprint of the certificate. From the PEM certificate, it can be acquired like
            /// this: $ keytool -printcert -file $CERTFILE | grep SHA256: SHA256:
            /// 14:6D:E9:83:C5:73:06:50:D8:EE:B9:95:2F:34:FC:64:16:A0:83: \ 42:E6:1D:BE:A8:8A:04:96:B2:3F:CF:44:E5 or
            /// like this: $ openssl x509 -in $CERTFILE -noout -fingerprint -sha256 SHA256
            /// Fingerprint=14:6D:E9:83:C5:73:06:50:D8:EE:B9:95:2F:34:FC:64: \
            /// 16:A0:83:42:E6:1D:BE:A8:8A:04:96:B2:3F:CF:44:E5 In this example, the contents of this field would be
            /// `14:6D:E9:83:C5:73: 06:50:D8:EE:B9:95:2F:34:FC:64:16:A0:83:42:E6:1D:BE:A8:8A:04:96:B2:3F:CF: 44:E5`. If
            /// these tools are not available to you, you can convert the PEM certificate into the DER format, compute
            /// the SHA-256 hash of that string and represent the result as a hexstring (that is, uppercase hexadecimal
            /// representations of each octet, separated by colons).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("source.androidApp.certificate.sha256Fingerprint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SourceAndroidAppCertificateSha256Fingerprint { get; set; }

            /// <summary>
            /// Android App assets are naturally identified by their Java package name. For example, the Google Maps app
            /// uses the package name `com.google.android.apps.maps`. REQUIRED
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("source.androidApp.packageName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SourceAndroidAppPackageName { get; set; }

            /// <summary>
            /// Web assets are identified by a URL that contains only the scheme, hostname and port parts. The format is
            /// http[s]://[:] Hostnames must be fully qualified: they must end in a single period ("`.`"). Only the
            /// schemes "http" and "https" are currently allowed. Port numbers are given as a decimal number, and they
            /// must be omitted if the standard port numbers are used: 80 for http and 443 for https. We call this
            /// limited URL the "site". All URLs that share the same scheme, hostname and port are considered to be a
            /// part of the site and thus belong to the web asset. Example: the asset with the site
            /// `https://www.google.com` contains all these URLs: * `https://www.google.com/` *
            /// `https://www.google.com:443/` * `https://www.google.com/foo` * `https://www.google.com/foo?bar` *
            /// `https://www.google.com/foo#bar` * `https://user@password:www.google.com/` But it does not contain these
            /// URLs: * `http://www.google.com/` (wrong scheme) * `https://google.com/` (hostname does not match) *
            /// `https://www.google.com:444/` (port does not match) REQUIRED
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("source.web.site", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SourceWebSite { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/statements:list";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("relation", new Google.Apis.Discovery.Parameter
                {
                    Name = "relation",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source.androidApp.certificate.sha256Fingerprint", new Google.Apis.Discovery.Parameter
                {
                    Name = "source.androidApp.certificate.sha256Fingerprint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source.androidApp.packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "source.androidApp.packageName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("source.web.site", new Google.Apis.Discovery.Parameter
                {
                    Name = "source.web.site",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Digitalassetlinks.v1.Data
{
    /// <summary>Describes an android app asset.</summary>
    public class AndroidAppAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Because there is no global enforcement of package name uniqueness, we also require a signing certificate,
        /// which in combination with the package name uniquely identifies an app. Some apps' signing keys are rotated,
        /// so they may be signed by different keys over time. We treat these as distinct assets, since we use (package
        /// name, cert) as the unique ID. This should not normally pose any problems as both versions of the app will
        /// make the same or similar statements. Other assets making statements about the app will have to be updated
        /// when a key is rotated, however. (Note that the syntaxes for publishing and querying for statements contain
        /// syntactic sugar to easily let you specify apps that are known by multiple certificates.) REQUIRED
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificate")]
        public virtual CertificateInfo Certificate { get; set; }

        /// <summary>
        /// Android App assets are naturally identified by their Java package name. For example, the Google Maps app
        /// uses the package name `com.google.android.apps.maps`. REQUIRED
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Uniquely identifies an asset. A digital asset is an identifiable and addressable online entity that typically
    /// provides some service or content. Examples of assets are websites, Android apps, Twitter feeds, and Plus Pages.
    /// </summary>
    public class Asset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set if this is an Android App asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidApp")]
        public virtual AndroidAppAsset AndroidApp { get; set; }

        /// <summary>Set if this is a web asset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("web")]
        public virtual WebAsset Web { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message used to check for the existence of multiple digital asset links within a single RPC.</summary>
    public class BulkCheckRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If specified, will be used in any given template statement that doesn’t specify a relation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultRelation")]
        public virtual string DefaultRelation { get; set; }

        /// <summary>If specified, will be used in any given template statement that doesn’t specify a source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultSource")]
        public virtual Asset DefaultSource { get; set; }

        /// <summary>If specified, will be used in any given template statement that doesn’t specify a target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultTarget")]
        public virtual Asset DefaultTarget { get; set; }

        /// <summary>
        /// List of statements to check. For each statement, you can omit a field if the corresponding default_* field
        /// below was supplied. Minimum 1 statement; maximum 1,000 statements. Any additional statements will be
        /// ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statements")]
        public virtual System.Collections.Generic.IList<StatementTemplate> Statements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response for BulkCheck call. Results are sent in a list in the same order in which they were sent. Individual
    /// check errors are described in the appropriate check_results entry. If the entire call fails, the response will
    /// include a bulk_error_code field describing the error.
    /// </summary>
    public class BulkCheckResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Error code for the entire request. Present only if the entire request failed. Individual check errors will
        /// not trigger the presence of this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bulkErrorCode")]
        public virtual string BulkErrorCode { get; set; }

        /// <summary>
        /// List of results for each check request. Results are returned in the same order in which they were sent in
        /// the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("checkResults")]
        public virtual System.Collections.Generic.IList<CheckResponse> CheckResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes an X509 certificate.</summary>
    public class CertificateInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The uppercase SHA-265 fingerprint of the certificate. From the PEM certificate, it can be acquired like
        /// this: $ keytool -printcert -file $CERTFILE | grep SHA256: SHA256:
        /// 14:6D:E9:83:C5:73:06:50:D8:EE:B9:95:2F:34:FC:64:16:A0:83: \ 42:E6:1D:BE:A8:8A:04:96:B2:3F:CF:44:E5 or like
        /// this: $ openssl x509 -in $CERTFILE -noout -fingerprint -sha256 SHA256
        /// Fingerprint=14:6D:E9:83:C5:73:06:50:D8:EE:B9:95:2F:34:FC:64: \
        /// 16:A0:83:42:E6:1D:BE:A8:8A:04:96:B2:3F:CF:44:E5 In this example, the contents of this field would be
        /// `14:6D:E9:83:C5:73: 06:50:D8:EE:B9:95:2F:34:FC:64:16:A0:83:42:E6:1D:BE:A8:8A:04:96:B2:3F:CF: 44:E5`. If
        /// these tools are not available to you, you can convert the PEM certificate into the DER format, compute the
        /// SHA-256 hash of that string and represent the result as a hexstring (that is, uppercase hexadecimal
        /// representations of each octet, separated by colons).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256Fingerprint")]
        public virtual string Sha256Fingerprint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the CheckAssetLinks call.</summary>
    public class CheckResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Human-readable message containing information intended to help end users understand, reproduce and debug the
        /// result. The message will be in English and we are currently not planning to offer any translations. Please
        /// note that no guarantees are made about the contents or format of this string. Any aspect of it may be
        /// subject to change without notice. You should not attempt to programmatically parse this data. For
        /// programmatic access, use the error_code field below.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugString")]
        public virtual string DebugString { get; set; }

        /// <summary>Error codes that describe the result of the Check operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual System.Collections.Generic.IList<string> ErrorCode { get; set; }

        /// <summary>
        /// Set to true if the assets specified in the request are linked by the relation specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linked")]
        public virtual System.Nullable<bool> Linked { get; set; }

        /// <summary>
        /// From serving time, how much longer the response should be considered valid barring further updates. REQUIRED
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxAge")]
        public virtual object MaxAge { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the List call.</summary>
    public class ListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Human-readable message containing information intended to help end users understand, reproduce and debug the
        /// result. The message will be in English and we are currently not planning to offer any translations. Please
        /// note that no guarantees are made about the contents or format of this string. Any aspect of it may be
        /// subject to change without notice. You should not attempt to programmatically parse this data. For
        /// programmatic access, use the error_code field below.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("debugString")]
        public virtual string DebugString { get; set; }

        /// <summary>Error codes that describe the result of the List operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual System.Collections.Generic.IList<string> ErrorCode { get; set; }

        /// <summary>
        /// From serving time, how much longer the response should be considered valid barring further updates. REQUIRED
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxAge")]
        public virtual object MaxAge { get; set; }

        /// <summary>A list of all the matching statements that have been found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statements")]
        public virtual System.Collections.Generic.IList<Statement> Statements { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Describes a reliable statement that has been made about the relationship between a source asset and a target
    /// asset. Statements are always made by the source asset, either directly or by delegating to a statement list that
    /// is stored elsewhere. For more detailed definitions of statements and assets, please refer to our [API
    /// documentation landing page](/digital-asset-links/v1/getting-started).
    /// </summary>
    public class Statement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The relation identifies the use of the statement as intended by the source asset's owner (that is, the
        /// person or entity who issued the statement). Every complete statement has a relation. We identify relations
        /// with strings of the format `/`, where `` must be one of a set of pre-defined purpose categories, and `` is a
        /// free-form lowercase alphanumeric string that describes the specific use case of the statement. Refer to [our
        /// API documentation](/digital-asset-links/v1/relation-strings) for the current list of supported relations.
        /// Example: `delegate_permission/common.handle_all_urls` REQUIRED
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relation")]
        public virtual string Relation { get; set; }

        /// <summary>Every statement has a source asset. REQUIRED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Asset Source { get; set; }

        /// <summary>Every statement has a target asset. REQUIRED</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual Asset Target { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A single statement to check in a bulk call using BulkCheck. See CheckRequest for details about each field.
    /// </summary>
    public class StatementTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The relationship being asserted between the source and target. If omitted, you must specify a
        /// BulkCheckRequest.default_relation value to use here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relation")]
        public virtual string Relation { get; set; }

        /// <summary>
        /// The source asset that is asserting the statement. If omitted, you must specify a
        /// BulkCheckRequest.default_source value to use here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual Asset Source { get; set; }

        /// <summary>
        /// The target that the source is declaring the relationship with. If omitted, you must specify a
        /// BulkCheckRequest.default_target to use here.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual Asset Target { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a web asset.</summary>
    public class WebAsset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Web assets are identified by a URL that contains only the scheme, hostname and port parts. The format is
        /// http[s]://[:] Hostnames must be fully qualified: they must end in a single period ("`.`"). Only the schemes
        /// "http" and "https" are currently allowed. Port numbers are given as a decimal number, and they must be
        /// omitted if the standard port numbers are used: 80 for http and 443 for https. We call this limited URL the
        /// "site". All URLs that share the same scheme, hostname and port are considered to be a part of the site and
        /// thus belong to the web asset. Example: the asset with the site `https://www.google.com` contains all these
        /// URLs: * `https://www.google.com/` * `https://www.google.com:443/` * `https://www.google.com/foo` *
        /// `https://www.google.com/foo?bar` * `https://www.google.com/foo#bar` *
        /// `https://user@password:www.google.com/` But it does not contain these URLs: * `http://www.google.com/`
        /// (wrong scheme) * `https://google.com/` (hostname does not match) * `https://www.google.com:444/` (port does
        /// not match) REQUIRED
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("site")]
        public virtual string Site { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
