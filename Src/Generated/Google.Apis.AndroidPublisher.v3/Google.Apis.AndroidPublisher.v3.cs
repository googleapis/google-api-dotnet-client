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

namespace Google.Apis.AndroidPublisher.v3
{
    /// <summary>The AndroidPublisher Service.</summary>
    public class AndroidPublisherService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v3";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AndroidPublisherService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AndroidPublisherService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Applications = new ApplicationsResource(this);
            Apprecovery = new ApprecoveryResource(this);
            Edits = new EditsResource(this);
            Externaltransactions = new ExternaltransactionsResource(this);
            Generatedapks = new GeneratedapksResource(this);
            Grants = new GrantsResource(this);
            Inappproducts = new InappproductsResource(this);
            Internalappsharingartifacts = new InternalappsharingartifactsResource(this);
            Monetization = new MonetizationResource(this);
            Orders = new OrdersResource(this);
            Purchases = new PurchasesResource(this);
            Reviews = new ReviewsResource(this);
            Systemapks = new SystemapksResource(this);
            Users = new UsersResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://androidpublisher.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://androidpublisher.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "androidpublisher";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Play Android Developer API.</summary>
        public class Scope
        {
            /// <summary>View and manage your Google Play Developer account</summary>
            public static string Androidpublisher = "https://www.googleapis.com/auth/androidpublisher";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Play Android Developer API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your Google Play Developer account</summary>
            public const string Androidpublisher = "https://www.googleapis.com/auth/androidpublisher";
        }

        /// <summary>Gets the Applications resource.</summary>
        public virtual ApplicationsResource Applications { get; }

        /// <summary>Gets the Apprecovery resource.</summary>
        public virtual ApprecoveryResource Apprecovery { get; }

        /// <summary>Gets the Edits resource.</summary>
        public virtual EditsResource Edits { get; }

        /// <summary>Gets the Externaltransactions resource.</summary>
        public virtual ExternaltransactionsResource Externaltransactions { get; }

        /// <summary>Gets the Generatedapks resource.</summary>
        public virtual GeneratedapksResource Generatedapks { get; }

        /// <summary>Gets the Grants resource.</summary>
        public virtual GrantsResource Grants { get; }

        /// <summary>Gets the Inappproducts resource.</summary>
        public virtual InappproductsResource Inappproducts { get; }

        /// <summary>Gets the Internalappsharingartifacts resource.</summary>
        public virtual InternalappsharingartifactsResource Internalappsharingartifacts { get; }

        /// <summary>Gets the Monetization resource.</summary>
        public virtual MonetizationResource Monetization { get; }

        /// <summary>Gets the Orders resource.</summary>
        public virtual OrdersResource Orders { get; }

        /// <summary>Gets the Purchases resource.</summary>
        public virtual PurchasesResource Purchases { get; }

        /// <summary>Gets the Reviews resource.</summary>
        public virtual ReviewsResource Reviews { get; }

        /// <summary>Gets the Systemapks resource.</summary>
        public virtual SystemapksResource Systemapks { get; }

        /// <summary>Gets the Users resource.</summary>
        public virtual UsersResource Users { get; }
    }

    /// <summary>A base abstract class for AndroidPublisher requests.</summary>
    public abstract class AndroidPublisherBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AndroidPublisherBaseServiceRequest instance.</summary>
        protected AndroidPublisherBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AndroidPublisher parameter list.</summary>
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

    /// <summary>The "applications" collection of methods.</summary>
    public class ApplicationsResource
    {
        private const string Resource = "applications";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ApplicationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            DeviceTierConfigs = new DeviceTierConfigsResource(service);
        }

        /// <summary>Gets the DeviceTierConfigs resource.</summary>
        public virtual DeviceTierConfigsResource DeviceTierConfigs { get; }

        /// <summary>The "deviceTierConfigs" collection of methods.</summary>
        public class DeviceTierConfigsResource
        {
            private const string Resource = "deviceTierConfigs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DeviceTierConfigsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a new device tier config for an app.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            public virtual CreateRequest Create(Google.Apis.AndroidPublisher.v3.Data.DeviceTierConfig body, string packageName)
            {
                return new CreateRequest(this.service, body, packageName);
            }

            /// <summary>Creates a new device tier config for an app.</summary>
            public class CreateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.DeviceTierConfig>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.DeviceTierConfig body, string packageName) : base(service)
                {
                    PackageName = packageName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>
                /// Whether the service should accept device IDs that are unknown to Play's device catalog.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("allowUnknownDevices", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> AllowUnknownDevices { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.DeviceTierConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/deviceTierConfigs";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("allowUnknownDevices", new Google.Apis.Discovery.Parameter
                    {
                        Name = "allowUnknownDevices",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Returns a particular device tier config.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="deviceTierConfigId">Required. Id of an existing device tier config.</param>
            public virtual GetRequest Get(string packageName, long deviceTierConfigId)
            {
                return new GetRequest(this.service, packageName, deviceTierConfigId);
            }

            /// <summary>Returns a particular device tier config.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.DeviceTierConfig>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, long deviceTierConfigId) : base(service)
                {
                    PackageName = packageName;
                    DeviceTierConfigId = deviceTierConfigId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Required. Id of an existing device tier config.</summary>
                [Google.Apis.Util.RequestParameterAttribute("deviceTierConfigId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long DeviceTierConfigId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/deviceTierConfigs/{deviceTierConfigId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("deviceTierConfigId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "deviceTierConfigId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Returns created device tier configs, ordered by descending creation time.</summary>
            /// <param name="packageName">Package name of the app.</param>
            public virtual ListRequest List(string packageName)
            {
                return new ListRequest(this.service, packageName);
            }

            /// <summary>Returns created device tier configs, ordered by descending creation time.</summary>
            public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ListDeviceTierConfigsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string packageName) : base(service)
                {
                    PackageName = packageName;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>
                /// The maximum number of device tier configs to return. The service may return fewer than this value.
                /// If unspecified, at most 10 device tier configs will be returned. The maximum value for this field is
                /// 100; values above 100 will be coerced to 100. Device tier configs will be ordered by descending
                /// creation time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListDeviceTierConfigs` call. Provide this to retrieve the
                /// subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/deviceTierConfigs";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Writes the Safety Labels declaration of an app.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">Required. Package name of the app.</param>
        public virtual DataSafetyRequest DataSafety(Google.Apis.AndroidPublisher.v3.Data.SafetyLabelsUpdateRequest body, string packageName)
        {
            return new DataSafetyRequest(this.service, body, packageName);
        }

        /// <summary>Writes the Safety Labels declaration of an app.</summary>
        public class DataSafetyRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.SafetyLabelsUpdateResponse>
        {
            /// <summary>Constructs a new DataSafety request.</summary>
            public DataSafetyRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.SafetyLabelsUpdateRequest body, string packageName) : base(service)
            {
                PackageName = packageName;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.SafetyLabelsUpdateRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "dataSafety";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/dataSafety";

            /// <summary>Initializes DataSafety parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "apprecovery" collection of methods.</summary>
    public class ApprecoveryResource
    {
        private const string Resource = "apprecovery";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ApprecoveryResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Incrementally update targeting for a recovery action. Note that only the criteria selected during the
        /// creation of recovery action can be expanded.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">
        /// Required. Package name of the app for which recovery action is to be updated.
        /// </param>
        /// <param name="appRecoveryId">Required. ID corresponding to the app recovery action.</param>
        public virtual AddTargetingRequest AddTargeting(Google.Apis.AndroidPublisher.v3.Data.AddTargetingRequest body, string packageName, long appRecoveryId)
        {
            return new AddTargetingRequest(this.service, body, packageName, appRecoveryId);
        }

        /// <summary>
        /// Incrementally update targeting for a recovery action. Note that only the criteria selected during the
        /// creation of recovery action can be expanded.
        /// </summary>
        public class AddTargetingRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.AddTargetingResponse>
        {
            /// <summary>Constructs a new AddTargeting request.</summary>
            public AddTargetingRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.AddTargetingRequest body, string packageName, long appRecoveryId) : base(service)
            {
                PackageName = packageName;
                AppRecoveryId = appRecoveryId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Package name of the app for which recovery action is to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Required. ID corresponding to the app recovery action.</summary>
            [Google.Apis.Util.RequestParameterAttribute("appRecoveryId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AppRecoveryId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.AddTargetingRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "addTargeting";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/appRecoveries/{appRecoveryId}:addTargeting";

            /// <summary>Initializes AddTargeting parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("appRecoveryId", new Google.Apis.Discovery.Parameter
                {
                    Name = "appRecoveryId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Cancel an already executing app recovery action. Note that this action changes status of the recovery action
        /// to CANCELED.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">
        /// Required. Package name of the app for which recovery action cancellation is requested.
        /// </param>
        /// <param name="appRecoveryId">Required. ID corresponding to the app recovery action.</param>
        public virtual CancelRequest Cancel(Google.Apis.AndroidPublisher.v3.Data.CancelAppRecoveryRequest body, string packageName, long appRecoveryId)
        {
            return new CancelRequest(this.service, body, packageName, appRecoveryId);
        }

        /// <summary>
        /// Cancel an already executing app recovery action. Note that this action changes status of the recovery action
        /// to CANCELED.
        /// </summary>
        public class CancelRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.CancelAppRecoveryResponse>
        {
            /// <summary>Constructs a new Cancel request.</summary>
            public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.CancelAppRecoveryRequest body, string packageName, long appRecoveryId) : base(service)
            {
                PackageName = packageName;
                AppRecoveryId = appRecoveryId;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. Package name of the app for which recovery action cancellation is requested.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Required. ID corresponding to the app recovery action.</summary>
            [Google.Apis.Util.RequestParameterAttribute("appRecoveryId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AppRecoveryId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.CancelAppRecoveryRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "cancel";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/appRecoveries/{appRecoveryId}:cancel";

            /// <summary>Initializes Cancel parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("appRecoveryId", new Google.Apis.Discovery.Parameter
                {
                    Name = "appRecoveryId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Create an app recovery action with recovery status as DRAFT. Note that this action does not execute the
        /// recovery action.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">Required. Package name of the app on which recovery action is performed.</param>
        public virtual CreateRequest Create(Google.Apis.AndroidPublisher.v3.Data.CreateDraftAppRecoveryRequest body, string packageName)
        {
            return new CreateRequest(this.service, body, packageName);
        }

        /// <summary>
        /// Create an app recovery action with recovery status as DRAFT. Note that this action does not execute the
        /// recovery action.
        /// </summary>
        public class CreateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.AppRecoveryAction>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.CreateDraftAppRecoveryRequest body, string packageName) : base(service)
            {
                PackageName = packageName;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Package name of the app on which recovery action is performed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.CreateDraftAppRecoveryRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/appRecoveries";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Deploy an already created app recovery action with recovery status DRAFT. Note that this action activates
        /// the recovery action for all targeted users and changes its status to ACTIVE.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">Required. Package name of the app for which recovery action is deployed.</param>
        /// <param name="appRecoveryId">Required. ID corresponding to the app recovery action to deploy.</param>
        public virtual DeployRequest Deploy(Google.Apis.AndroidPublisher.v3.Data.DeployAppRecoveryRequest body, string packageName, long appRecoveryId)
        {
            return new DeployRequest(this.service, body, packageName, appRecoveryId);
        }

        /// <summary>
        /// Deploy an already created app recovery action with recovery status DRAFT. Note that this action activates
        /// the recovery action for all targeted users and changes its status to ACTIVE.
        /// </summary>
        public class DeployRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.DeployAppRecoveryResponse>
        {
            /// <summary>Constructs a new Deploy request.</summary>
            public DeployRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.DeployAppRecoveryRequest body, string packageName, long appRecoveryId) : base(service)
            {
                PackageName = packageName;
                AppRecoveryId = appRecoveryId;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. Package name of the app for which recovery action is deployed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Required. ID corresponding to the app recovery action to deploy.</summary>
            [Google.Apis.Util.RequestParameterAttribute("appRecoveryId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AppRecoveryId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.DeployAppRecoveryRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "deploy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/appRecoveries/{appRecoveryId}:deploy";

            /// <summary>Initializes Deploy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("appRecoveryId", new Google.Apis.Discovery.Parameter
                {
                    Name = "appRecoveryId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// List all app recovery action resources associated with a particular package name and app version.
        /// </summary>
        /// <param name="packageName">
        /// Required. Package name of the app for which list of recovery actions is requested.
        /// </param>
        public virtual ListRequest List(string packageName)
        {
            return new ListRequest(this.service, packageName);
        }

        /// <summary>
        /// List all app recovery action resources associated with a particular package name and app version.
        /// </summary>
        public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ListAppRecoveriesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string packageName) : base(service)
            {
                PackageName = packageName;
                InitParameters();
            }

            /// <summary>Required. Package name of the app for which list of recovery actions is requested.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Required. Version code targeted by the list of recovery actions.</summary>
            [Google.Apis.Util.RequestParameterAttribute("versionCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> VersionCode { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/appRecoveries";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("versionCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "versionCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "edits" collection of methods.</summary>
    public class EditsResource
    {
        private const string Resource = "edits";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public EditsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Apks = new ApksResource(service);
            Bundles = new BundlesResource(service);
            Countryavailability = new CountryavailabilityResource(service);
            Deobfuscationfiles = new DeobfuscationfilesResource(service);
            Details = new DetailsResource(service);
            Expansionfiles = new ExpansionfilesResource(service);
            Images = new ImagesResource(service);
            Listings = new ListingsResource(service);
            Testers = new TestersResource(service);
            Tracks = new TracksResource(service);
        }

        /// <summary>Gets the Apks resource.</summary>
        public virtual ApksResource Apks { get; }

        /// <summary>The "apks" collection of methods.</summary>
        public class ApksResource
        {
            private const string Resource = "apks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ApksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a new APK without uploading the APK itself to Google Play, instead hosting the APK at a
            /// specified URL. This function is only available to organizations using Managed Play whose application is
            /// configured to restrict distribution to the organizations.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual AddexternallyhostedRequest Addexternallyhosted(Google.Apis.AndroidPublisher.v3.Data.ApksAddExternallyHostedRequest body, string packageName, string editId)
            {
                return new AddexternallyhostedRequest(this.service, body, packageName, editId);
            }

            /// <summary>
            /// Creates a new APK without uploading the APK itself to Google Play, instead hosting the APK at a
            /// specified URL. This function is only available to organizations using Managed Play whose application is
            /// configured to restrict distribution to the organizations.
            /// </summary>
            public class AddexternallyhostedRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ApksAddExternallyHostedResponse>
            {
                /// <summary>Constructs a new Addexternallyhosted request.</summary>
                public AddexternallyhostedRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.ApksAddExternallyHostedRequest body, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.ApksAddExternallyHostedRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "addexternallyhosted";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks/externallyHosted";

                /// <summary>Initializes Addexternallyhosted parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all current APKs of the app and edit.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual ListRequest List(string packageName, string editId)
            {
                return new ListRequest(this.service, packageName, editId);
            }

            /// <summary>Lists all current APKs of the app and edit.</summary>
            public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ApksListResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Uploads an APK and adds to the current edit.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual UploadRequest Upload(string packageName, string editId)
            {
                return new UploadRequest(this.service, packageName, editId);
            }

            /// <summary>Uploads an APK and adds to the current edit.</summary>
            public class UploadRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Apk>
            {
                /// <summary>Constructs a new Upload request.</summary>
                public UploadRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "upload";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks";

                /// <summary>Initializes Upload parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Uploads an APK and adds to the current edit.</summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual UploadMediaUpload Upload(string packageName, string editId, System.IO.Stream stream, string contentType)
            {
                return new UploadMediaUpload(service, packageName, editId, stream, contentType);
            }

            /// <summary>Upload media upload which supports resumable upload.</summary>
            public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.AndroidPublisher.v3.Data.Apk>
            {
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
                /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
                /// Required unless you provide an OAuth 2.0 token.
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
                /// Available to use for quota purposes for server-side applications. Can be any arbitrary string
                /// assigned to a user, but should not exceed 40 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadType { get; set; }

                /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadProtocol { get; set; }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Constructs a new Upload media upload instance.</summary>
                /// <remarks>
                /// Considerations regarding <paramref name="stream"/>:
                /// <list type="bullet">
                /// <item>
                /// <description>
                /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
                /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its
                /// current position
                /// </description>
                /// </item>
                /// <item>
                /// <description>
                /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                /// completed
                /// </description>
                /// </item>
                /// <item>
                /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                /// </item>
                /// </list>
                /// </remarks>
                public UploadMediaUpload(Google.Apis.Services.IClientService service, string packageName, string editId, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks"), "POST", stream, contentType)
                {
                    PackageName = packageName;
                    EditId = editId;
                }
            }
        }

        /// <summary>Gets the Bundles resource.</summary>
        public virtual BundlesResource Bundles { get; }

        /// <summary>The "bundles" collection of methods.</summary>
        public class BundlesResource
        {
            private const string Resource = "bundles";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BundlesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists all current Android App Bundles of the app and edit.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual ListRequest List(string packageName, string editId)
            {
                return new ListRequest(this.service, packageName, editId);
            }

            /// <summary>Lists all current Android App Bundles of the app and edit.</summary>
            public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.BundlesListResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/bundles";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Uploads a new Android App Bundle to this edit. If you are using the Google API client libraries, please
            /// increase the timeout of the http request before calling this endpoint (a timeout of 2 minutes is
            /// recommended). See [Timeouts and
            /// Errors](https://developers.google.com/api-client-library/java/google-api-java-client/errors) for an
            /// example in java.
            /// </summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual UploadRequest Upload(string packageName, string editId)
            {
                return new UploadRequest(this.service, packageName, editId);
            }

            /// <summary>
            /// Uploads a new Android App Bundle to this edit. If you are using the Google API client libraries, please
            /// increase the timeout of the http request before calling this endpoint (a timeout of 2 minutes is
            /// recommended). See [Timeouts and
            /// Errors](https://developers.google.com/api-client-library/java/google-api-java-client/errors) for an
            /// example in java.
            /// </summary>
            public class UploadRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Bundle>
            {
                /// <summary>Constructs a new Upload request.</summary>
                public UploadRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Deprecated. The installation warning has been removed, it's not necessary to set this field anymore.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("ackBundleInstallationWarning", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> AckBundleInstallationWarning { get; set; }

                /// <summary>
                /// Device tier config (DTC) to be used for generating deliverables (APKs). Contains id of the DTC or
                /// "LATEST" for last uploaded DTC.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("deviceTierConfigId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DeviceTierConfigId { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "upload";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/bundles";

                /// <summary>Initializes Upload parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("ackBundleInstallationWarning", new Google.Apis.Discovery.Parameter
                    {
                        Name = "ackBundleInstallationWarning",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("deviceTierConfigId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "deviceTierConfigId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Uploads a new Android App Bundle to this edit. If you are using the Google API client libraries, please
            /// increase the timeout of the http request before calling this endpoint (a timeout of 2 minutes is
            /// recommended). See [Timeouts and
            /// Errors](https://developers.google.com/api-client-library/java/google-api-java-client/errors) for an
            /// example in java.
            /// </summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual UploadMediaUpload Upload(string packageName, string editId, System.IO.Stream stream, string contentType)
            {
                return new UploadMediaUpload(service, packageName, editId, stream, contentType);
            }

            /// <summary>Upload media upload which supports resumable upload.</summary>
            public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.AndroidPublisher.v3.Data.Bundle>
            {
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
                /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
                /// Required unless you provide an OAuth 2.0 token.
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
                /// Available to use for quota purposes for server-side applications. Can be any arbitrary string
                /// assigned to a user, but should not exceed 40 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadType { get; set; }

                /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadProtocol { get; set; }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Deprecated. The installation warning has been removed, it's not necessary to set this field anymore.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("ackBundleInstallationWarning", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> AckBundleInstallationWarning { get; set; }

                /// <summary>
                /// Device tier config (DTC) to be used for generating deliverables (APKs). Contains id of the DTC or
                /// "LATEST" for last uploaded DTC.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("deviceTierConfigId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string DeviceTierConfigId { get; set; }

                /// <summary>Constructs a new Upload media upload instance.</summary>
                /// <remarks>
                /// Considerations regarding <paramref name="stream"/>:
                /// <list type="bullet">
                /// <item>
                /// <description>
                /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
                /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its
                /// current position
                /// </description>
                /// </item>
                /// <item>
                /// <description>
                /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                /// completed
                /// </description>
                /// </item>
                /// <item>
                /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                /// </item>
                /// </list>
                /// </remarks>
                public UploadMediaUpload(Google.Apis.Services.IClientService service, string packageName, string editId, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "androidpublisher/v3/applications/{packageName}/edits/{editId}/bundles"), "POST", stream, contentType)
                {
                    PackageName = packageName;
                    EditId = editId;
                }
            }
        }

        /// <summary>Gets the Countryavailability resource.</summary>
        public virtual CountryavailabilityResource Countryavailability { get; }

        /// <summary>The "countryavailability" collection of methods.</summary>
        public class CountryavailabilityResource
        {
            private const string Resource = "countryavailability";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CountryavailabilityResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets country availability.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="track">The track to read from.</param>
            public virtual GetRequest Get(string packageName, string editId, string track)
            {
                return new GetRequest(this.service, packageName, editId, track);
            }

            /// <summary>Gets country availability.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.TrackCountryAvailability>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, string editId, string track) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Track = track;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>The track to read from.</summary>
                [Google.Apis.Util.RequestParameterAttribute("track", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Track { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/countryAvailability/{track}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("track", new Google.Apis.Discovery.Parameter
                    {
                        Name = "track",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Deobfuscationfiles resource.</summary>
        public virtual DeobfuscationfilesResource Deobfuscationfiles { get; }

        /// <summary>The "deobfuscationfiles" collection of methods.</summary>
        public class DeobfuscationfilesResource
        {
            private const string Resource = "deobfuscationfiles";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DeobfuscationfilesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Uploads a new deobfuscation file and attaches to the specified APK.</summary>
            /// <param name="packageName">Unique identifier for the Android app.</param>
            /// <param name="editId">Unique identifier for this edit.</param>
            /// <param name="apkVersionCode">
            /// The version code of the APK whose Deobfuscation File is being uploaded.
            /// </param>
            /// <param name="deobfuscationFileType">The type of the deobfuscation file.</param>
            public virtual UploadRequest Upload(string packageName, string editId, int apkVersionCode, UploadRequest.DeobfuscationFileTypeEnum deobfuscationFileType)
            {
                return new UploadRequest(this.service, packageName, editId, apkVersionCode, deobfuscationFileType);
            }

            /// <summary>Uploads a new deobfuscation file and attaches to the specified APK.</summary>
            public class UploadRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.DeobfuscationFilesUploadResponse>
            {
                /// <summary>Constructs a new Upload request.</summary>
                public UploadRequest(Google.Apis.Services.IClientService service, string packageName, string editId, int apkVersionCode, DeobfuscationFileTypeEnum deobfuscationFileType) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    ApkVersionCode = apkVersionCode;
                    DeobfuscationFileType = deobfuscationFileType;
                    InitParameters();
                }

                /// <summary>Unique identifier for the Android app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Unique identifier for this edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>The version code of the APK whose Deobfuscation File is being uploaded.</summary>
                [Google.Apis.Util.RequestParameterAttribute("apkVersionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int ApkVersionCode { get; private set; }

                /// <summary>The type of the deobfuscation file.</summary>
                [Google.Apis.Util.RequestParameterAttribute("deobfuscationFileType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual DeobfuscationFileTypeEnum DeobfuscationFileType { get; private set; }

                /// <summary>The type of the deobfuscation file.</summary>
                public enum DeobfuscationFileTypeEnum
                {
                    /// <summary>Unspecified deobfuscation file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("deobfuscationFileTypeUnspecified")]
                    DeobfuscationFileTypeUnspecified = 0,

                    /// <summary>Proguard deobfuscation file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("proguard")]
                    Proguard = 1,

                    /// <summary>Native debugging symbols file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("nativeCode")]
                    NativeCode = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "upload";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks/{apkVersionCode}/deobfuscationFiles/{deobfuscationFileType}";

                /// <summary>Initializes Upload parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("apkVersionCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "apkVersionCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("deobfuscationFileType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "deobfuscationFileType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Uploads a new deobfuscation file and attaches to the specified APK.</summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            /// <param name="packageName">Unique identifier for the Android app.</param>
            /// <param name="editId">Unique identifier for this edit.</param>
            /// <param name="apkVersionCode">
            /// The version code of the APK whose Deobfuscation File is being uploaded.
            /// </param>
            /// <param name="deobfuscationFileType">The type of the deobfuscation file.</param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual UploadMediaUpload Upload(string packageName, string editId, int apkVersionCode, UploadMediaUpload.DeobfuscationFileTypeEnum deobfuscationFileType, System.IO.Stream stream, string contentType)
            {
                return new UploadMediaUpload(service, packageName, editId, apkVersionCode, deobfuscationFileType, stream, contentType);
            }

            /// <summary>Upload media upload which supports resumable upload.</summary>
            public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.AndroidPublisher.v3.Data.DeobfuscationFilesUploadResponse>
            {
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
                /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
                /// Required unless you provide an OAuth 2.0 token.
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
                /// Available to use for quota purposes for server-side applications. Can be any arbitrary string
                /// assigned to a user, but should not exceed 40 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadType { get; set; }

                /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadProtocol { get; set; }

                /// <summary>Unique identifier for the Android app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Unique identifier for this edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>The version code of the APK whose Deobfuscation File is being uploaded.</summary>
                [Google.Apis.Util.RequestParameterAttribute("apkVersionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int ApkVersionCode { get; private set; }

                /// <summary>The type of the deobfuscation file.</summary>
                [Google.Apis.Util.RequestParameterAttribute("deobfuscationFileType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual DeobfuscationFileTypeEnum DeobfuscationFileType { get; private set; }

                /// <summary>The type of the deobfuscation file.</summary>
                public enum DeobfuscationFileTypeEnum
                {
                    /// <summary>Unspecified deobfuscation file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("deobfuscationFileTypeUnspecified")]
                    DeobfuscationFileTypeUnspecified = 0,

                    /// <summary>Proguard deobfuscation file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("proguard")]
                    Proguard = 1,

                    /// <summary>Native debugging symbols file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("nativeCode")]
                    NativeCode = 2,
                }

                /// <summary>Constructs a new Upload media upload instance.</summary>
                /// <remarks>
                /// Considerations regarding <paramref name="stream"/>:
                /// <list type="bullet">
                /// <item>
                /// <description>
                /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
                /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its
                /// current position
                /// </description>
                /// </item>
                /// <item>
                /// <description>
                /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                /// completed
                /// </description>
                /// </item>
                /// <item>
                /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                /// </item>
                /// </list>
                /// </remarks>
                public UploadMediaUpload(Google.Apis.Services.IClientService service, string packageName, string editId, int apkVersionCode, UploadMediaUpload.DeobfuscationFileTypeEnum deobfuscationFileType, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks/{apkVersionCode}/deobfuscationFiles/{deobfuscationFileType}"), "POST", stream, contentType)
                {
                    PackageName = packageName;
                    EditId = editId;
                    ApkVersionCode = apkVersionCode;
                    DeobfuscationFileType = deobfuscationFileType;
                }
            }
        }

        /// <summary>Gets the Details resource.</summary>
        public virtual DetailsResource Details { get; }

        /// <summary>The "details" collection of methods.</summary>
        public class DetailsResource
        {
            private const string Resource = "details";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DetailsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets details of an app.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual GetRequest Get(string packageName, string editId)
            {
                return new GetRequest(this.service, packageName, editId);
            }

            /// <summary>Gets details of an app.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.AppDetails>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/details";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Patches details of an app.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual PatchRequest Patch(Google.Apis.AndroidPublisher.v3.Data.AppDetails body, string packageName, string editId)
            {
                return new PatchRequest(this.service, body, packageName, editId);
            }

            /// <summary>Patches details of an app.</summary>
            public class PatchRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.AppDetails>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.AppDetails body, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.AppDetails Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/details";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates details of an app.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual UpdateRequest Update(Google.Apis.AndroidPublisher.v3.Data.AppDetails body, string packageName, string editId)
            {
                return new UpdateRequest(this.service, body, packageName, editId);
            }

            /// <summary>Updates details of an app.</summary>
            public class UpdateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.AppDetails>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.AppDetails body, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.AppDetails Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/details";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Expansionfiles resource.</summary>
        public virtual ExpansionfilesResource Expansionfiles { get; }

        /// <summary>The "expansionfiles" collection of methods.</summary>
        public class ExpansionfilesResource
        {
            private const string Resource = "expansionfiles";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ExpansionfilesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Fetches the expansion file configuration for the specified APK.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="apkVersionCode">
            /// The version code of the APK whose expansion file configuration is being read or modified.
            /// </param>
            /// <param name="expansionFileType">
            /// The file type of the file configuration which is being read or modified.
            /// </param>
            public virtual GetRequest Get(string packageName, string editId, int apkVersionCode, GetRequest.ExpansionFileTypeEnum expansionFileType)
            {
                return new GetRequest(this.service, packageName, editId, apkVersionCode, expansionFileType);
            }

            /// <summary>Fetches the expansion file configuration for the specified APK.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ExpansionFile>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, string editId, int apkVersionCode, ExpansionFileTypeEnum expansionFileType) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    ApkVersionCode = apkVersionCode;
                    ExpansionFileType = expansionFileType;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// The version code of the APK whose expansion file configuration is being read or modified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("apkVersionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int ApkVersionCode { get; private set; }

                /// <summary>The file type of the file configuration which is being read or modified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("expansionFileType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ExpansionFileTypeEnum ExpansionFileType { get; private set; }

                /// <summary>The file type of the file configuration which is being read or modified.</summary>
                public enum ExpansionFileTypeEnum
                {
                    /// <summary>Unspecified expansion file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("expansionFileTypeUnspecified")]
                    ExpansionFileTypeUnspecified = 0,

                    /// <summary>Main expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("main")]
                    Main = 1,

                    /// <summary>Patch expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("patch")]
                    Patch = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks/{apkVersionCode}/expansionFiles/{expansionFileType}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("apkVersionCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "apkVersionCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("expansionFileType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "expansionFileType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Patches the APK's expansion file configuration to reference another APK's expansion file. To add a new
            /// expansion file use the Upload method.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="apkVersionCode">
            /// The version code of the APK whose expansion file configuration is being read or modified.
            /// </param>
            /// <param name="expansionFileType">
            /// The file type of the expansion file configuration which is being updated.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AndroidPublisher.v3.Data.ExpansionFile body, string packageName, string editId, int apkVersionCode, PatchRequest.ExpansionFileTypeEnum expansionFileType)
            {
                return new PatchRequest(this.service, body, packageName, editId, apkVersionCode, expansionFileType);
            }

            /// <summary>
            /// Patches the APK's expansion file configuration to reference another APK's expansion file. To add a new
            /// expansion file use the Upload method.
            /// </summary>
            public class PatchRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ExpansionFile>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.ExpansionFile body, string packageName, string editId, int apkVersionCode, ExpansionFileTypeEnum expansionFileType) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    ApkVersionCode = apkVersionCode;
                    ExpansionFileType = expansionFileType;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// The version code of the APK whose expansion file configuration is being read or modified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("apkVersionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int ApkVersionCode { get; private set; }

                /// <summary>The file type of the expansion file configuration which is being updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("expansionFileType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ExpansionFileTypeEnum ExpansionFileType { get; private set; }

                /// <summary>The file type of the expansion file configuration which is being updated.</summary>
                public enum ExpansionFileTypeEnum
                {
                    /// <summary>Unspecified expansion file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("expansionFileTypeUnspecified")]
                    ExpansionFileTypeUnspecified = 0,

                    /// <summary>Main expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("main")]
                    Main = 1,

                    /// <summary>Patch expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("patch")]
                    Patch = 2,
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.ExpansionFile Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks/{apkVersionCode}/expansionFiles/{expansionFileType}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("apkVersionCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "apkVersionCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("expansionFileType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "expansionFileType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates the APK's expansion file configuration to reference another APK's expansion file. To add a new
            /// expansion file use the Upload method.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="apkVersionCode">
            /// The version code of the APK whose expansion file configuration is being read or modified.
            /// </param>
            /// <param name="expansionFileType">
            /// The file type of the file configuration which is being read or modified.
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.AndroidPublisher.v3.Data.ExpansionFile body, string packageName, string editId, int apkVersionCode, UpdateRequest.ExpansionFileTypeEnum expansionFileType)
            {
                return new UpdateRequest(this.service, body, packageName, editId, apkVersionCode, expansionFileType);
            }

            /// <summary>
            /// Updates the APK's expansion file configuration to reference another APK's expansion file. To add a new
            /// expansion file use the Upload method.
            /// </summary>
            public class UpdateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ExpansionFile>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.ExpansionFile body, string packageName, string editId, int apkVersionCode, ExpansionFileTypeEnum expansionFileType) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    ApkVersionCode = apkVersionCode;
                    ExpansionFileType = expansionFileType;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// The version code of the APK whose expansion file configuration is being read or modified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("apkVersionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int ApkVersionCode { get; private set; }

                /// <summary>The file type of the file configuration which is being read or modified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("expansionFileType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ExpansionFileTypeEnum ExpansionFileType { get; private set; }

                /// <summary>The file type of the file configuration which is being read or modified.</summary>
                public enum ExpansionFileTypeEnum
                {
                    /// <summary>Unspecified expansion file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("expansionFileTypeUnspecified")]
                    ExpansionFileTypeUnspecified = 0,

                    /// <summary>Main expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("main")]
                    Main = 1,

                    /// <summary>Patch expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("patch")]
                    Patch = 2,
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.ExpansionFile Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks/{apkVersionCode}/expansionFiles/{expansionFileType}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("apkVersionCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "apkVersionCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("expansionFileType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "expansionFileType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Uploads a new expansion file and attaches to the specified APK.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="apkVersionCode">
            /// The version code of the APK whose expansion file configuration is being read or modified.
            /// </param>
            /// <param name="expansionFileType">
            /// The file type of the expansion file configuration which is being updated.
            /// </param>
            public virtual UploadRequest Upload(string packageName, string editId, int apkVersionCode, UploadRequest.ExpansionFileTypeEnum expansionFileType)
            {
                return new UploadRequest(this.service, packageName, editId, apkVersionCode, expansionFileType);
            }

            /// <summary>Uploads a new expansion file and attaches to the specified APK.</summary>
            public class UploadRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ExpansionFilesUploadResponse>
            {
                /// <summary>Constructs a new Upload request.</summary>
                public UploadRequest(Google.Apis.Services.IClientService service, string packageName, string editId, int apkVersionCode, ExpansionFileTypeEnum expansionFileType) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    ApkVersionCode = apkVersionCode;
                    ExpansionFileType = expansionFileType;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// The version code of the APK whose expansion file configuration is being read or modified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("apkVersionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int ApkVersionCode { get; private set; }

                /// <summary>The file type of the expansion file configuration which is being updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("expansionFileType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ExpansionFileTypeEnum ExpansionFileType { get; private set; }

                /// <summary>The file type of the expansion file configuration which is being updated.</summary>
                public enum ExpansionFileTypeEnum
                {
                    /// <summary>Unspecified expansion file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("expansionFileTypeUnspecified")]
                    ExpansionFileTypeUnspecified = 0,

                    /// <summary>Main expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("main")]
                    Main = 1,

                    /// <summary>Patch expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("patch")]
                    Patch = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "upload";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks/{apkVersionCode}/expansionFiles/{expansionFileType}";

                /// <summary>Initializes Upload parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("apkVersionCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "apkVersionCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("expansionFileType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "expansionFileType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Uploads a new expansion file and attaches to the specified APK.</summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="apkVersionCode">
            /// The version code of the APK whose expansion file configuration is being read or modified.
            /// </param>
            /// <param name="expansionFileType">
            /// The file type of the expansion file configuration which is being updated.
            /// </param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual UploadMediaUpload Upload(string packageName, string editId, int apkVersionCode, UploadMediaUpload.ExpansionFileTypeEnum expansionFileType, System.IO.Stream stream, string contentType)
            {
                return new UploadMediaUpload(service, packageName, editId, apkVersionCode, expansionFileType, stream, contentType);
            }

            /// <summary>Upload media upload which supports resumable upload.</summary>
            public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.AndroidPublisher.v3.Data.ExpansionFilesUploadResponse>
            {
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
                /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
                /// Required unless you provide an OAuth 2.0 token.
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
                /// Available to use for quota purposes for server-side applications. Can be any arbitrary string
                /// assigned to a user, but should not exceed 40 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadType { get; set; }

                /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadProtocol { get; set; }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// The version code of the APK whose expansion file configuration is being read or modified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("apkVersionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int ApkVersionCode { get; private set; }

                /// <summary>The file type of the expansion file configuration which is being updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("expansionFileType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ExpansionFileTypeEnum ExpansionFileType { get; private set; }

                /// <summary>The file type of the expansion file configuration which is being updated.</summary>
                public enum ExpansionFileTypeEnum
                {
                    /// <summary>Unspecified expansion file type.</summary>
                    [Google.Apis.Util.StringValueAttribute("expansionFileTypeUnspecified")]
                    ExpansionFileTypeUnspecified = 0,

                    /// <summary>Main expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("main")]
                    Main = 1,

                    /// <summary>Patch expansion file.</summary>
                    [Google.Apis.Util.StringValueAttribute("patch")]
                    Patch = 2,
                }

                /// <summary>Constructs a new Upload media upload instance.</summary>
                /// <remarks>
                /// Considerations regarding <paramref name="stream"/>:
                /// <list type="bullet">
                /// <item>
                /// <description>
                /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
                /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its
                /// current position
                /// </description>
                /// </item>
                /// <item>
                /// <description>
                /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                /// completed
                /// </description>
                /// </item>
                /// <item>
                /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                /// </item>
                /// </list>
                /// </remarks>
                public UploadMediaUpload(Google.Apis.Services.IClientService service, string packageName, string editId, int apkVersionCode, UploadMediaUpload.ExpansionFileTypeEnum expansionFileType, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "androidpublisher/v3/applications/{packageName}/edits/{editId}/apks/{apkVersionCode}/expansionFiles/{expansionFileType}"), "POST", stream, contentType)
                {
                    PackageName = packageName;
                    EditId = editId;
                    ApkVersionCode = apkVersionCode;
                    ExpansionFileType = expansionFileType;
                }
            }
        }

        /// <summary>Gets the Images resource.</summary>
        public virtual ImagesResource Images { get; }

        /// <summary>The "images" collection of methods.</summary>
        public class ImagesResource
        {
            private const string Resource = "images";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ImagesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Deletes the image (specified by id) from the edit.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="language">
            /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
            /// </param>
            /// <param name="imageType">Type of the Image.</param>
            /// <param name="imageId">Unique identifier an image within the set of images attached to this edit.</param>
            public virtual DeleteRequest Delete(string packageName, string editId, string language, DeleteRequest.ImageTypeEnum imageType, string imageId)
            {
                return new DeleteRequest(this.service, packageName, editId, language, imageType, imageId);
            }

            /// <summary>Deletes the image (specified by id) from the edit.</summary>
            public class DeleteRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string packageName, string editId, string language, ImageTypeEnum imageType, string imageId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Language = language;
                    ImageType = imageType;
                    ImageId = imageId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Language { get; private set; }

                /// <summary>Type of the Image.</summary>
                [Google.Apis.Util.RequestParameterAttribute("imageType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ImageTypeEnum ImageType { get; private set; }

                /// <summary>Type of the Image.</summary>
                public enum ImageTypeEnum
                {
                    /// <summary>Unspecified type. Do not use.</summary>
                    [Google.Apis.Util.StringValueAttribute("appImageTypeUnspecified")]
                    AppImageTypeUnspecified = 0,

                    /// <summary>Phone screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("phoneScreenshots")]
                    PhoneScreenshots = 1,

                    /// <summary>Seven inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("sevenInchScreenshots")]
                    SevenInchScreenshots = 2,

                    /// <summary>Ten inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tenInchScreenshots")]
                    TenInchScreenshots = 3,

                    /// <summary>TV screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvScreenshots")]
                    TvScreenshots = 4,

                    /// <summary>Wear screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("wearScreenshots")]
                    WearScreenshots = 5,

                    /// <summary>Icon.</summary>
                    [Google.Apis.Util.StringValueAttribute("icon")]
                    Icon = 6,

                    /// <summary>Feature graphic.</summary>
                    [Google.Apis.Util.StringValueAttribute("featureGraphic")]
                    FeatureGraphic = 7,

                    /// <summary>TV banner.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvBanner")]
                    TvBanner = 8,
                }

                /// <summary>Unique identifier an image within the set of images attached to this edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("imageId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ImageId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings/{language}/{imageType}/{imageId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                    {
                        Name = "language",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("imageType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "imageType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("imageId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "imageId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes all images for the specified language and image type. Returns an empty response if no images are
            /// found.
            /// </summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="language">
            /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German). Providing
            /// a language that is not supported by the App is a no-op.
            /// </param>
            /// <param name="imageType">
            /// Type of the Image. Providing an image type that refers to no images is a no-op.
            /// </param>
            public virtual DeleteallRequest Deleteall(string packageName, string editId, string language, DeleteallRequest.ImageTypeEnum imageType)
            {
                return new DeleteallRequest(this.service, packageName, editId, language, imageType);
            }

            /// <summary>
            /// Deletes all images for the specified language and image type. Returns an empty response if no images are
            /// found.
            /// </summary>
            public class DeleteallRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ImagesDeleteAllResponse>
            {
                /// <summary>Constructs a new Deleteall request.</summary>
                public DeleteallRequest(Google.Apis.Services.IClientService service, string packageName, string editId, string language, ImageTypeEnum imageType) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Language = language;
                    ImageType = imageType;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
                /// Providing a language that is not supported by the App is a no-op.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Language { get; private set; }

                /// <summary>Type of the Image. Providing an image type that refers to no images is a no-op.</summary>
                [Google.Apis.Util.RequestParameterAttribute("imageType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ImageTypeEnum ImageType { get; private set; }

                /// <summary>Type of the Image. Providing an image type that refers to no images is a no-op.</summary>
                public enum ImageTypeEnum
                {
                    /// <summary>Unspecified type. Do not use.</summary>
                    [Google.Apis.Util.StringValueAttribute("appImageTypeUnspecified")]
                    AppImageTypeUnspecified = 0,

                    /// <summary>Phone screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("phoneScreenshots")]
                    PhoneScreenshots = 1,

                    /// <summary>Seven inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("sevenInchScreenshots")]
                    SevenInchScreenshots = 2,

                    /// <summary>Ten inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tenInchScreenshots")]
                    TenInchScreenshots = 3,

                    /// <summary>TV screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvScreenshots")]
                    TvScreenshots = 4,

                    /// <summary>Wear screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("wearScreenshots")]
                    WearScreenshots = 5,

                    /// <summary>Icon.</summary>
                    [Google.Apis.Util.StringValueAttribute("icon")]
                    Icon = 6,

                    /// <summary>Feature graphic.</summary>
                    [Google.Apis.Util.StringValueAttribute("featureGraphic")]
                    FeatureGraphic = 7,

                    /// <summary>TV banner.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvBanner")]
                    TvBanner = 8,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "deleteall";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings/{language}/{imageType}";

                /// <summary>Initializes Deleteall parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                    {
                        Name = "language",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("imageType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "imageType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all images. The response may be empty.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="language">
            /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German). There must
            /// be a store listing for the specified language.
            /// </param>
            /// <param name="imageType">
            /// Type of the Image. Providing an image type that refers to no images will return an empty response.
            /// </param>
            public virtual ListRequest List(string packageName, string editId, string language, ListRequest.ImageTypeEnum imageType)
            {
                return new ListRequest(this.service, packageName, editId, language, imageType);
            }

            /// <summary>Lists all images. The response may be empty.</summary>
            public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ImagesListResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string packageName, string editId, string language, ImageTypeEnum imageType) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Language = language;
                    ImageType = imageType;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German). There
                /// must be a store listing for the specified language.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Language { get; private set; }

                /// <summary>
                /// Type of the Image. Providing an image type that refers to no images will return an empty response.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("imageType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ImageTypeEnum ImageType { get; private set; }

                /// <summary>
                /// Type of the Image. Providing an image type that refers to no images will return an empty response.
                /// </summary>
                public enum ImageTypeEnum
                {
                    /// <summary>Unspecified type. Do not use.</summary>
                    [Google.Apis.Util.StringValueAttribute("appImageTypeUnspecified")]
                    AppImageTypeUnspecified = 0,

                    /// <summary>Phone screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("phoneScreenshots")]
                    PhoneScreenshots = 1,

                    /// <summary>Seven inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("sevenInchScreenshots")]
                    SevenInchScreenshots = 2,

                    /// <summary>Ten inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tenInchScreenshots")]
                    TenInchScreenshots = 3,

                    /// <summary>TV screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvScreenshots")]
                    TvScreenshots = 4,

                    /// <summary>Wear screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("wearScreenshots")]
                    WearScreenshots = 5,

                    /// <summary>Icon.</summary>
                    [Google.Apis.Util.StringValueAttribute("icon")]
                    Icon = 6,

                    /// <summary>Feature graphic.</summary>
                    [Google.Apis.Util.StringValueAttribute("featureGraphic")]
                    FeatureGraphic = 7,

                    /// <summary>TV banner.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvBanner")]
                    TvBanner = 8,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings/{language}/{imageType}";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                    {
                        Name = "language",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("imageType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "imageType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Uploads an image of the specified language and image type, and adds to the edit.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="language">
            /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German). Providing
            /// a language that is not supported by the App is a no-op.
            /// </param>
            /// <param name="imageType">Type of the Image.</param>
            public virtual UploadRequest Upload(string packageName, string editId, string language, UploadRequest.ImageTypeEnum imageType)
            {
                return new UploadRequest(this.service, packageName, editId, language, imageType);
            }

            /// <summary>Uploads an image of the specified language and image type, and adds to the edit.</summary>
            public class UploadRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ImagesUploadResponse>
            {
                /// <summary>Constructs a new Upload request.</summary>
                public UploadRequest(Google.Apis.Services.IClientService service, string packageName, string editId, string language, ImageTypeEnum imageType) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Language = language;
                    ImageType = imageType;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
                /// Providing a language that is not supported by the App is a no-op.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Language { get; private set; }

                /// <summary>Type of the Image.</summary>
                [Google.Apis.Util.RequestParameterAttribute("imageType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ImageTypeEnum ImageType { get; private set; }

                /// <summary>Type of the Image.</summary>
                public enum ImageTypeEnum
                {
                    /// <summary>Unspecified type. Do not use.</summary>
                    [Google.Apis.Util.StringValueAttribute("appImageTypeUnspecified")]
                    AppImageTypeUnspecified = 0,

                    /// <summary>Phone screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("phoneScreenshots")]
                    PhoneScreenshots = 1,

                    /// <summary>Seven inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("sevenInchScreenshots")]
                    SevenInchScreenshots = 2,

                    /// <summary>Ten inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tenInchScreenshots")]
                    TenInchScreenshots = 3,

                    /// <summary>TV screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvScreenshots")]
                    TvScreenshots = 4,

                    /// <summary>Wear screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("wearScreenshots")]
                    WearScreenshots = 5,

                    /// <summary>Icon.</summary>
                    [Google.Apis.Util.StringValueAttribute("icon")]
                    Icon = 6,

                    /// <summary>Feature graphic.</summary>
                    [Google.Apis.Util.StringValueAttribute("featureGraphic")]
                    FeatureGraphic = 7,

                    /// <summary>TV banner.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvBanner")]
                    TvBanner = 8,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "upload";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings/{language}/{imageType}";

                /// <summary>Initializes Upload parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                    {
                        Name = "language",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("imageType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "imageType",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Uploads an image of the specified language and image type, and adds to the edit.</summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="language">
            /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German). Providing
            /// a language that is not supported by the App is a no-op.
            /// </param>
            /// <param name="imageType">Type of the Image.</param>
            /// <param name="stream">The stream to upload. See remarks for further information.</param>
            /// <param name="contentType">The content type of the stream to upload.</param>
            public virtual UploadMediaUpload Upload(string packageName, string editId, string language, UploadMediaUpload.ImageTypeEnum imageType, System.IO.Stream stream, string contentType)
            {
                return new UploadMediaUpload(service, packageName, editId, language, imageType, stream, contentType);
            }

            /// <summary>Upload media upload which supports resumable upload.</summary>
            public class UploadMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.AndroidPublisher.v3.Data.ImagesUploadResponse>
            {
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
                /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
                /// Required unless you provide an OAuth 2.0 token.
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
                /// Available to use for quota purposes for server-side applications. Can be any arbitrary string
                /// assigned to a user, but should not exceed 40 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string QuotaUser { get; set; }

                /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadType { get; set; }

                /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
                [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UploadProtocol { get; set; }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
                /// Providing a language that is not supported by the App is a no-op.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Language { get; private set; }

                /// <summary>Type of the Image.</summary>
                [Google.Apis.Util.RequestParameterAttribute("imageType", Google.Apis.Util.RequestParameterType.Path)]
                public virtual ImageTypeEnum ImageType { get; private set; }

                /// <summary>Type of the Image.</summary>
                public enum ImageTypeEnum
                {
                    /// <summary>Unspecified type. Do not use.</summary>
                    [Google.Apis.Util.StringValueAttribute("appImageTypeUnspecified")]
                    AppImageTypeUnspecified = 0,

                    /// <summary>Phone screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("phoneScreenshots")]
                    PhoneScreenshots = 1,

                    /// <summary>Seven inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("sevenInchScreenshots")]
                    SevenInchScreenshots = 2,

                    /// <summary>Ten inch screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tenInchScreenshots")]
                    TenInchScreenshots = 3,

                    /// <summary>TV screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvScreenshots")]
                    TvScreenshots = 4,

                    /// <summary>Wear screenshot.</summary>
                    [Google.Apis.Util.StringValueAttribute("wearScreenshots")]
                    WearScreenshots = 5,

                    /// <summary>Icon.</summary>
                    [Google.Apis.Util.StringValueAttribute("icon")]
                    Icon = 6,

                    /// <summary>Feature graphic.</summary>
                    [Google.Apis.Util.StringValueAttribute("featureGraphic")]
                    FeatureGraphic = 7,

                    /// <summary>TV banner.</summary>
                    [Google.Apis.Util.StringValueAttribute("tvBanner")]
                    TvBanner = 8,
                }

                /// <summary>Constructs a new Upload media upload instance.</summary>
                /// <remarks>
                /// Considerations regarding <paramref name="stream"/>:
                /// <list type="bullet">
                /// <item>
                /// <description>
                /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
                /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its
                /// current position
                /// </description>
                /// </item>
                /// <item>
                /// <description>
                /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is
                /// completed
                /// </description>
                /// </item>
                /// <item>
                /// <description>Caller is responsible for closing the <paramref name="stream"/></description>
                /// </item>
                /// </list>
                /// </remarks>
                public UploadMediaUpload(Google.Apis.Services.IClientService service, string packageName, string editId, string language, UploadMediaUpload.ImageTypeEnum imageType, System.IO.Stream stream, string contentType)
                    : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings/{language}/{imageType}"), "POST", stream, contentType)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Language = language;
                    ImageType = imageType;
                }
            }
        }

        /// <summary>Gets the Listings resource.</summary>
        public virtual ListingsResource Listings { get; }

        /// <summary>The "listings" collection of methods.</summary>
        public class ListingsResource
        {
            private const string Resource = "listings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ListingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Deletes a localized store listing.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="language">
            /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
            /// </param>
            public virtual DeleteRequest Delete(string packageName, string editId, string language)
            {
                return new DeleteRequest(this.service, packageName, editId, language);
            }

            /// <summary>Deletes a localized store listing.</summary>
            public class DeleteRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string packageName, string editId, string language) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Language = language;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Language { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings/{language}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                    {
                        Name = "language",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes all store listings.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual DeleteallRequest Deleteall(string packageName, string editId)
            {
                return new DeleteallRequest(this.service, packageName, editId);
            }

            /// <summary>Deletes all store listings.</summary>
            public class DeleteallRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Deleteall request.</summary>
                public DeleteallRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "deleteall";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings";

                /// <summary>Initializes Deleteall parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a localized store listing.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="language">
            /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
            /// </param>
            public virtual GetRequest Get(string packageName, string editId, string language)
            {
                return new GetRequest(this.service, packageName, editId, language);
            }

            /// <summary>Gets a localized store listing.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Listing>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, string editId, string language) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Language = language;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Language { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings/{language}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                    {
                        Name = "language",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all localized store listings.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual ListRequest List(string packageName, string editId)
            {
                return new ListRequest(this.service, packageName, editId);
            }

            /// <summary>Lists all localized store listings.</summary>
            public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ListingsListResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Patches a localized store listing.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="language">
            /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AndroidPublisher.v3.Data.Listing body, string packageName, string editId, string language)
            {
                return new PatchRequest(this.service, body, packageName, editId, language);
            }

            /// <summary>Patches a localized store listing.</summary>
            public class PatchRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Listing>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.Listing body, string packageName, string editId, string language) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Language = language;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Language { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.Listing Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings/{language}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                    {
                        Name = "language",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Creates or updates a localized store listing.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="language">
            /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.AndroidPublisher.v3.Data.Listing body, string packageName, string editId, string language)
            {
                return new UpdateRequest(this.service, body, packageName, editId, language);
            }

            /// <summary>Creates or updates a localized store listing.</summary>
            public class UpdateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Listing>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.Listing body, string packageName, string editId, string language) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Language = language;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("language", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Language { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.Listing Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/listings/{language}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("language", new Google.Apis.Discovery.Parameter
                    {
                        Name = "language",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Testers resource.</summary>
        public virtual TestersResource Testers { get; }

        /// <summary>The "testers" collection of methods.</summary>
        public class TestersResource
        {
            private const string Resource = "testers";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TestersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets testers. Note: Testers resource does not support email lists.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="track">The track to read from.</param>
            public virtual GetRequest Get(string packageName, string editId, string track)
            {
                return new GetRequest(this.service, packageName, editId, track);
            }

            /// <summary>Gets testers. Note: Testers resource does not support email lists.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Testers>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, string editId, string track) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Track = track;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>The track to read from.</summary>
                [Google.Apis.Util.RequestParameterAttribute("track", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Track { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/testers/{track}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("track", new Google.Apis.Discovery.Parameter
                    {
                        Name = "track",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Patches testers. Note: Testers resource does not support email lists.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="track">The track to update.</param>
            public virtual PatchRequest Patch(Google.Apis.AndroidPublisher.v3.Data.Testers body, string packageName, string editId, string track)
            {
                return new PatchRequest(this.service, body, packageName, editId, track);
            }

            /// <summary>Patches testers. Note: Testers resource does not support email lists.</summary>
            public class PatchRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Testers>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.Testers body, string packageName, string editId, string track) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Track = track;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>The track to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("track", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Track { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.Testers Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/testers/{track}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("track", new Google.Apis.Discovery.Parameter
                    {
                        Name = "track",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates testers. Note: Testers resource does not support email lists.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="track">The track to update.</param>
            public virtual UpdateRequest Update(Google.Apis.AndroidPublisher.v3.Data.Testers body, string packageName, string editId, string track)
            {
                return new UpdateRequest(this.service, body, packageName, editId, track);
            }

            /// <summary>Updates testers. Note: Testers resource does not support email lists.</summary>
            public class UpdateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Testers>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.Testers body, string packageName, string editId, string track) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Track = track;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>The track to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("track", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Track { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.Testers Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/testers/{track}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("track", new Google.Apis.Discovery.Parameter
                    {
                        Name = "track",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Tracks resource.</summary>
        public virtual TracksResource Tracks { get; }

        /// <summary>The "tracks" collection of methods.</summary>
        public class TracksResource
        {
            private const string Resource = "tracks";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TracksResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a new track.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Required. Package name of the app.</param>
            /// <param name="editId">Required. Identifier of the edit.</param>
            public virtual CreateRequest Create(Google.Apis.AndroidPublisher.v3.Data.TrackConfig body, string packageName, string editId)
            {
                return new CreateRequest(this.service, body, packageName, editId);
            }

            /// <summary>Creates a new track.</summary>
            public class CreateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Track>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.TrackConfig body, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Required. Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.TrackConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/tracks";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Gets a track.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="track">
            /// Identifier of the track. [More on track
            /// name](https://developers.google.com/android-publisher/tracks#ff-track-name)
            /// </param>
            public virtual GetRequest Get(string packageName, string editId, string track)
            {
                return new GetRequest(this.service, packageName, editId, track);
            }

            /// <summary>Gets a track.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Track>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, string editId, string track) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Track = track;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Identifier of the track. [More on track
                /// name](https://developers.google.com/android-publisher/tracks#ff-track-name)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("track", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Track { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/tracks/{track}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("track", new Google.Apis.Discovery.Parameter
                    {
                        Name = "track",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all tracks.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            public virtual ListRequest List(string packageName, string editId)
            {
                return new ListRequest(this.service, packageName, editId);
            }

            /// <summary>Lists all tracks.</summary>
            public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.TracksListResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/tracks";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Patches a track.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="track">
            /// Identifier of the track. [More on track
            /// name](https://developers.google.com/android-publisher/tracks#ff-track-name)
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AndroidPublisher.v3.Data.Track body, string packageName, string editId, string track)
            {
                return new PatchRequest(this.service, body, packageName, editId, track);
            }

            /// <summary>Patches a track.</summary>
            public class PatchRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Track>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.Track body, string packageName, string editId, string track) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Track = track;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Identifier of the track. [More on track
                /// name](https://developers.google.com/android-publisher/tracks#ff-track-name)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("track", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Track { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.Track Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/tracks/{track}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("track", new Google.Apis.Discovery.Parameter
                    {
                        Name = "track",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates a track.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="editId">Identifier of the edit.</param>
            /// <param name="track">
            /// Identifier of the track. [More on track
            /// name](https://developers.google.com/android-publisher/tracks#ff-track-name)
            /// </param>
            public virtual UpdateRequest Update(Google.Apis.AndroidPublisher.v3.Data.Track body, string packageName, string editId, string track)
            {
                return new UpdateRequest(this.service, body, packageName, editId, track);
            }

            /// <summary>Updates a track.</summary>
            public class UpdateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Track>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.Track body, string packageName, string editId, string track) : base(service)
                {
                    PackageName = packageName;
                    EditId = editId;
                    Track = track;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Identifier of the edit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string EditId { get; private set; }

                /// <summary>
                /// Identifier of the track. [More on track
                /// name](https://developers.google.com/android-publisher/tracks#ff-track-name)
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("track", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Track { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.Track Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}/tracks/{track}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "editId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("track", new Google.Apis.Discovery.Parameter
                    {
                        Name = "track",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Commits an app edit.</summary>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="editId">Identifier of the edit.</param>
        public virtual CommitRequest Commit(string packageName, string editId)
        {
            return new CommitRequest(this.service, packageName, editId);
        }

        /// <summary>Commits an app edit.</summary>
        public class CommitRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.AppEdit>
        {
            /// <summary>Constructs a new Commit request.</summary>
            public CommitRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
            {
                PackageName = packageName;
                EditId = editId;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Identifier of the edit.</summary>
            [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EditId { get; private set; }

            /// <summary>
            /// Indicates that the changes in this edit will not be reviewed until they are explicitly sent for review
            /// from the Google Play Console UI. These changes will be added to any other changes that are not yet sent
            /// for review.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("changesNotSentForReview", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> ChangesNotSentForReview { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "commit";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}:commit";

            /// <summary>Initializes Commit parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                {
                    Name = "editId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("changesNotSentForReview", new Google.Apis.Discovery.Parameter
                {
                    Name = "changesNotSentForReview",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Deletes an app edit.</summary>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="editId">Identifier of the edit.</param>
        public virtual DeleteRequest Delete(string packageName, string editId)
        {
            return new DeleteRequest(this.service, packageName, editId);
        }

        /// <summary>Deletes an app edit.</summary>
        public class DeleteRequest : AndroidPublisherBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
            {
                PackageName = packageName;
                EditId = editId;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Identifier of the edit.</summary>
            [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EditId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                {
                    Name = "editId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets an app edit.</summary>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="editId">Identifier of the edit.</param>
        public virtual GetRequest Get(string packageName, string editId)
        {
            return new GetRequest(this.service, packageName, editId);
        }

        /// <summary>Gets an app edit.</summary>
        public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.AppEdit>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
            {
                PackageName = packageName;
                EditId = editId;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Identifier of the edit.</summary>
            [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EditId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                {
                    Name = "editId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a new edit for an app.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">Package name of the app.</param>
        public virtual InsertRequest Insert(Google.Apis.AndroidPublisher.v3.Data.AppEdit body, string packageName)
        {
            return new InsertRequest(this.service, body, packageName);
        }

        /// <summary>Creates a new edit for an app.</summary>
        public class InsertRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.AppEdit>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.AppEdit body, string packageName) : base(service)
            {
                PackageName = packageName;
                Body = body;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.AppEdit Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Validates an app edit.</summary>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="editId">Identifier of the edit.</param>
        public virtual ValidateRequest Validate(string packageName, string editId)
        {
            return new ValidateRequest(this.service, packageName, editId);
        }

        /// <summary>Validates an app edit.</summary>
        public class ValidateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.AppEdit>
        {
            /// <summary>Constructs a new Validate request.</summary>
            public ValidateRequest(Google.Apis.Services.IClientService service, string packageName, string editId) : base(service)
            {
                PackageName = packageName;
                EditId = editId;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Identifier of the edit.</summary>
            [Google.Apis.Util.RequestParameterAttribute("editId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string EditId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "validate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/edits/{editId}:validate";

            /// <summary>Initializes Validate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("editId", new Google.Apis.Discovery.Parameter
                {
                    Name = "editId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "externaltransactions" collection of methods.</summary>
    public class ExternaltransactionsResource
    {
        private const string Resource = "externaltransactions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ExternaltransactionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Creates a new external transaction.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. The parent resource where this external transaction will be created. Format:
        /// applications/{package_name}
        /// </param>
        public virtual CreateexternaltransactionRequest Createexternaltransaction(Google.Apis.AndroidPublisher.v3.Data.ExternalTransaction body, string parent)
        {
            return new CreateexternaltransactionRequest(this.service, body, parent);
        }

        /// <summary>Creates a new external transaction.</summary>
        public class CreateexternaltransactionRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ExternalTransaction>
        {
            /// <summary>Constructs a new Createexternaltransaction request.</summary>
            public CreateexternaltransactionRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.ExternalTransaction body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The parent resource where this external transaction will be created. Format:
            /// applications/{package_name}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// Required. The id to use for the external transaction. Must be unique across all other transactions for
            /// the app. This value should be 1-63 characters and valid characters are /a-zA-Z0-9_-/. Do not use this
            /// field to store any Personally Identifiable Information (PII) such as emails. Attempting to store PII in
            /// this field may result in requests being blocked.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("externalTransactionId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ExternalTransactionId { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.ExternalTransaction Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "createexternaltransaction";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/{+parent}/externalTransactions";

            /// <summary>Initializes Createexternaltransaction parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^applications/[^/]+$",
                });
                RequestParameters.Add("externalTransactionId", new Google.Apis.Discovery.Parameter
                {
                    Name = "externalTransactionId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets an existing external transaction.</summary>
        /// <param name="name">
        /// Required. The name of the external transaction to retrieve. Format:
        /// applications/{package_name}/externalTransactions/{external_transaction}
        /// </param>
        public virtual GetexternaltransactionRequest Getexternaltransaction(string name)
        {
            return new GetexternaltransactionRequest(this.service, name);
        }

        /// <summary>Gets an existing external transaction.</summary>
        public class GetexternaltransactionRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ExternalTransaction>
        {
            /// <summary>Constructs a new Getexternaltransaction request.</summary>
            public GetexternaltransactionRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the external transaction to retrieve. Format:
            /// applications/{package_name}/externalTransactions/{external_transaction}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getexternaltransaction";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/{+name}";

            /// <summary>Initializes Getexternaltransaction parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^applications/[^/]+/externalTransactions/[^/]+$",
                });
            }
        }

        /// <summary>Refunds or partially refunds an existing external transaction.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. The name of the external transaction that will be refunded. Format:
        /// applications/{package_name}/externalTransactions/{external_transaction}
        /// </param>
        public virtual RefundexternaltransactionRequest Refundexternaltransaction(Google.Apis.AndroidPublisher.v3.Data.RefundExternalTransactionRequest body, string name)
        {
            return new RefundexternaltransactionRequest(this.service, body, name);
        }

        /// <summary>Refunds or partially refunds an existing external transaction.</summary>
        public class RefundexternaltransactionRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ExternalTransaction>
        {
            /// <summary>Constructs a new Refundexternaltransaction request.</summary>
            public RefundexternaltransactionRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.RefundExternalTransactionRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the external transaction that will be refunded. Format:
            /// applications/{package_name}/externalTransactions/{external_transaction}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.RefundExternalTransactionRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "refundexternaltransaction";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/{+name}:refund";

            /// <summary>Initializes Refundexternaltransaction parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^applications/[^/]+/externalTransactions/[^/]+$",
                });
            }
        }
    }

    /// <summary>The "generatedapks" collection of methods.</summary>
    public class GeneratedapksResource
    {
        private const string Resource = "generatedapks";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GeneratedapksResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Downloads a single signed APK generated from an app bundle.</summary>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="versionCode">Version code of the app bundle.</param>
        /// <param name="downloadId">
        /// Download ID, which uniquely identifies the APK to download. Can be obtained from the response of
        /// `generatedapks.list` method.
        /// </param>
        public virtual DownloadRequest Download(string packageName, int versionCode, string downloadId)
        {
            return new DownloadRequest(this.service, packageName, versionCode, downloadId);
        }

        /// <summary>Downloads a single signed APK generated from an app bundle.</summary>
        public class DownloadRequest : AndroidPublisherBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Download request.</summary>
            public DownloadRequest(Google.Apis.Services.IClientService service, string packageName, int versionCode, string downloadId) : base(service)
            {
                PackageName = packageName;
                VersionCode = versionCode;
                DownloadId = downloadId;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Version code of the app bundle.</summary>
            [Google.Apis.Util.RequestParameterAttribute("versionCode", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int VersionCode { get; private set; }

            /// <summary>
            /// Download ID, which uniquely identifies the APK to download. Can be obtained from the response of
            /// `generatedapks.list` method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("downloadId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DownloadId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "download";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/generatedApks/{versionCode}/downloads/{downloadId}:download";

            /// <summary>Initializes Download parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("versionCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "versionCode",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("downloadId", new Google.Apis.Discovery.Parameter
                {
                    Name = "downloadId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

            /// <summary>Gets the media downloader.</summary>
            public Google.Apis.Download.IMediaDownloader MediaDownloader { get; private set; }

            /// <summary>
            /// <para>Synchronously download the media into the given stream.</para>
            /// <para>
            /// Warning: This method hides download errors; use <see cref="DownloadWithStatus(System.IO.Stream)"/>
            /// instead.
            /// </para>
            /// </summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual void Download(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Synchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            /// <returns>The final status of the download; including whether the download succeeded or failed.</returns>
            public virtual Google.Apis.Download.IDownloadProgress DownloadWithStatus(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream,
                System.Threading.CancellationToken cancellationToken)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }

            /// <summary>Synchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual Google.Apis.Download.IDownloadProgress DownloadRange(System.IO.Stream stream, System.Net.Http.Headers.RangeHeaderValue range)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadRangeAsync(System.IO.Stream stream,
                System.Net.Http.Headers.RangeHeaderValue range,
                System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }
        }

        /// <summary>Returns download metadata for all APKs that were generated from a given app bundle.</summary>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="versionCode">Version code of the app bundle.</param>
        public virtual ListRequest List(string packageName, int versionCode)
        {
            return new ListRequest(this.service, packageName, versionCode);
        }

        /// <summary>Returns download metadata for all APKs that were generated from a given app bundle.</summary>
        public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.GeneratedApksListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string packageName, int versionCode) : base(service)
            {
                PackageName = packageName;
                VersionCode = versionCode;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Version code of the app bundle.</summary>
            [Google.Apis.Util.RequestParameterAttribute("versionCode", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int VersionCode { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/generatedApks/{versionCode}";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("versionCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "versionCode",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "grants" collection of methods.</summary>
    public class GrantsResource
    {
        private const string Resource = "grants";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GrantsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Grant access for a user to the given package.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. The user which needs permission. Format: developers/{developer}/users/{user}
        /// </param>
        public virtual CreateRequest Create(Google.Apis.AndroidPublisher.v3.Data.Grant body, string parent)
        {
            return new CreateRequest(this.service, body, parent);
        }

        /// <summary>Grant access for a user to the given package.</summary>
        public class CreateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Grant>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.Grant body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. The user which needs permission. Format: developers/{developer}/users/{user}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.Grant Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/{+parent}/grants";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^developers/[^/]+/users/[^/]+$",
                });
            }
        }

        /// <summary>Removes all access for the user to the given package or developer account.</summary>
        /// <param name="name">
        /// Required. The name of the grant to delete. Format:
        /// developers/{developer}/users/{email}/grants/{package_name}
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(this.service, name);
        }

        /// <summary>Removes all access for the user to the given package or developer account.</summary>
        public class DeleteRequest : AndroidPublisherBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the grant to delete. Format:
            /// developers/{developer}/users/{email}/grants/{package_name}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/{+name}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^developers/[^/]+/users/[^/]+/grants/[^/]+$",
                });
            }
        }

        /// <summary>Updates access for the user to the given package.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. Resource name for this grant, following the pattern
        /// "developers/{developer}/users/{email}/grants/{package_name}". If this grant is for a draft app, the app ID
        /// will be used in this resource name instead of the package name.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.AndroidPublisher.v3.Data.Grant body, string name)
        {
            return new PatchRequest(this.service, body, name);
        }

        /// <summary>Updates access for the user to the given package.</summary>
        public class PatchRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Grant>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.Grant body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name for this grant, following the pattern
            /// "developers/{developer}/users/{email}/grants/{package_name}". If this grant is for a draft app, the app
            /// ID will be used in this resource name instead of the package name.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Optional. The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.Grant Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/{+name}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^developers/[^/]+/users/[^/]+/grants/[^/]+$",
                });
                RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "inappproducts" collection of methods.</summary>
    public class InappproductsResource
    {
        private const string Resource = "inappproducts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public InappproductsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Deletes in-app products (managed products or subscriptions). Set the latencyTolerance field on nested
        /// requests to PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT to achieve maximum update throughput. This
        /// method should not be used to delete subscriptions. See [this
        /// article](https://android-developers.googleblog.com/2023/06/changes-to-google-play-developer-api-june-2023.html)
        /// for more information.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">Package name of the app.</param>
        public virtual BatchDeleteRequest BatchDelete(Google.Apis.AndroidPublisher.v3.Data.InappproductsBatchDeleteRequest body, string packageName)
        {
            return new BatchDeleteRequest(this.service, body, packageName);
        }

        /// <summary>
        /// Deletes in-app products (managed products or subscriptions). Set the latencyTolerance field on nested
        /// requests to PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT to achieve maximum update throughput. This
        /// method should not be used to delete subscriptions. See [this
        /// article](https://android-developers.googleblog.com/2023/06/changes-to-google-play-developer-api-june-2023.html)
        /// for more information.
        /// </summary>
        public class BatchDeleteRequest : AndroidPublisherBaseServiceRequest<string>
        {
            /// <summary>Constructs a new BatchDelete request.</summary>
            public BatchDeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.InappproductsBatchDeleteRequest body, string packageName) : base(service)
            {
                PackageName = packageName;
                Body = body;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.InappproductsBatchDeleteRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchDelete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/inappproducts:batchDelete";

            /// <summary>Initializes BatchDelete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Reads multiple in-app products, which can be managed products or subscriptions. This method should not be
        /// used to retrieve subscriptions. See [this
        /// article](https://android-developers.googleblog.com/2023/06/changes-to-google-play-developer-api-june-2023.html)
        /// for more information.
        /// </summary>
        /// <param name="packageName">Package name of the app.</param>
        public virtual BatchGetRequest BatchGet(string packageName)
        {
            return new BatchGetRequest(this.service, packageName);
        }

        /// <summary>
        /// Reads multiple in-app products, which can be managed products or subscriptions. This method should not be
        /// used to retrieve subscriptions. See [this
        /// article](https://android-developers.googleblog.com/2023/06/changes-to-google-play-developer-api-june-2023.html)
        /// for more information.
        /// </summary>
        public class BatchGetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.InappproductsBatchGetResponse>
        {
            /// <summary>Constructs a new BatchGet request.</summary>
            public BatchGetRequest(Google.Apis.Services.IClientService service, string packageName) : base(service)
            {
                PackageName = packageName;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Unique identifier for the in-app products.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sku", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Sku { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchGet";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/inappproducts:batchGet";

            /// <summary>Initializes BatchGet parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sku", new Google.Apis.Discovery.Parameter
                {
                    Name = "sku",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates or inserts one or more in-app products (managed products or subscriptions). Set the latencyTolerance
        /// field on nested requests to PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT to achieve maximum update
        /// throughput. This method should no longer be used to update subscriptions. See [this
        /// article](https://android-developers.googleblog.com/2023/06/changes-to-google-play-developer-api-june-2023.html)
        /// for more information.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">Package name of the app.</param>
        public virtual BatchUpdateRequest BatchUpdate(Google.Apis.AndroidPublisher.v3.Data.InappproductsBatchUpdateRequest body, string packageName)
        {
            return new BatchUpdateRequest(this.service, body, packageName);
        }

        /// <summary>
        /// Updates or inserts one or more in-app products (managed products or subscriptions). Set the latencyTolerance
        /// field on nested requests to PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT to achieve maximum update
        /// throughput. This method should no longer be used to update subscriptions. See [this
        /// article](https://android-developers.googleblog.com/2023/06/changes-to-google-play-developer-api-june-2023.html)
        /// for more information.
        /// </summary>
        public class BatchUpdateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.InappproductsBatchUpdateResponse>
        {
            /// <summary>Constructs a new BatchUpdate request.</summary>
            public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.InappproductsBatchUpdateRequest body, string packageName) : base(service)
            {
                PackageName = packageName;
                Body = body;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.InappproductsBatchUpdateRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchUpdate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/inappproducts:batchUpdate";

            /// <summary>Initializes BatchUpdate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Deletes an in-app product (a managed product or a subscription). This method should no longer be used to
        /// delete subscriptions. See [this
        /// article](https://android-developers.googleblog.com/2023/06/changes-to-google-play-developer-api-june-2023.html)
        /// for more information.
        /// </summary>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="sku">Unique identifier for the in-app product.</param>
        public virtual DeleteRequest Delete(string packageName, string sku)
        {
            return new DeleteRequest(this.service, packageName, sku);
        }

        /// <summary>
        /// Deletes an in-app product (a managed product or a subscription). This method should no longer be used to
        /// delete subscriptions. See [this
        /// article](https://android-developers.googleblog.com/2023/06/changes-to-google-play-developer-api-june-2023.html)
        /// for more information.
        /// </summary>
        public class DeleteRequest : AndroidPublisherBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string packageName, string sku) : base(service)
            {
                PackageName = packageName;
                Sku = sku;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Unique identifier for the in-app product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sku", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Sku { get; private set; }

            /// <summary>
            /// Optional. The latency tolerance for the propagation of this product update. Defaults to
            /// latency-sensitive.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("latencyTolerance", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<LatencyToleranceEnum> LatencyTolerance { get; set; }

            /// <summary>
            /// Optional. The latency tolerance for the propagation of this product update. Defaults to
            /// latency-sensitive.
            /// </summary>
            public enum LatencyToleranceEnum
            {
                /// <summary>Defaults to PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_SENSITIVE.</summary>
                [Google.Apis.Util.StringValueAttribute("PRODUCT_UPDATE_LATENCY_TOLERANCE_UNSPECIFIED")]
                PRODUCTUPDATELATENCYTOLERANCEUNSPECIFIED = 0,

                /// <summary>
                /// The update will propagate to clients within several minutes on average and up to a few hours in rare
                /// cases. Throughput is limited to 7,200 updates per app per hour.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_SENSITIVE")]
                PRODUCTUPDATELATENCYTOLERANCELATENCYSENSITIVE = 1,

                /// <summary>
                /// The update will propagate to clients within 24 hours. Supports high throughput of up to 720,000
                /// updates per app per hour using batch modification methods.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT")]
                PRODUCTUPDATELATENCYTOLERANCELATENCYTOLERANT = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/inappproducts/{sku}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sku", new Google.Apis.Discovery.Parameter
                {
                    Name = "sku",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("latencyTolerance", new Google.Apis.Discovery.Parameter
                {
                    Name = "latencyTolerance",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Gets an in-app product, which can be a managed product or a subscription. This method should no longer be
        /// used to retrieve subscriptions. See [this
        /// article](https://android-developers.googleblog.com/2023/06/changes-to-google-play-developer-api-june-2023.html)
        /// for more information.
        /// </summary>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="sku">Unique identifier for the in-app product.</param>
        public virtual GetRequest Get(string packageName, string sku)
        {
            return new GetRequest(this.service, packageName, sku);
        }

        /// <summary>
        /// Gets an in-app product, which can be a managed product or a subscription. This method should no longer be
        /// used to retrieve subscriptions. See [this
        /// article](https://android-developers.googleblog.com/2023/06/changes-to-google-play-developer-api-june-2023.html)
        /// for more information.
        /// </summary>
        public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.InAppProduct>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string packageName, string sku) : base(service)
            {
                PackageName = packageName;
                Sku = sku;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Unique identifier for the in-app product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sku", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Sku { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/inappproducts/{sku}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sku", new Google.Apis.Discovery.Parameter
                {
                    Name = "sku",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Creates an in-app product (a managed product or a subscription). This method should no longer be used to
        /// create subscriptions. See [this
        /// article](https://android-developers.googleblog.com/2023/06/changes-to-google-play-developer-api-june-2023.html)
        /// for more information.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">Package name of the app.</param>
        public virtual InsertRequest Insert(Google.Apis.AndroidPublisher.v3.Data.InAppProduct body, string packageName)
        {
            return new InsertRequest(this.service, body, packageName);
        }

        /// <summary>
        /// Creates an in-app product (a managed product or a subscription). This method should no longer be used to
        /// create subscriptions. See [this
        /// article](https://android-developers.googleblog.com/2023/06/changes-to-google-play-developer-api-june-2023.html)
        /// for more information.
        /// </summary>
        public class InsertRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.InAppProduct>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.InAppProduct body, string packageName) : base(service)
            {
                PackageName = packageName;
                Body = body;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>
            /// If true the prices for all regions targeted by the parent app that don't have a price specified for this
            /// in-app product will be auto converted to the target currency based on the default price. Defaults to
            /// false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("autoConvertMissingPrices", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AutoConvertMissingPrices { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.InAppProduct Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/inappproducts";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("autoConvertMissingPrices", new Google.Apis.Discovery.Parameter
                {
                    Name = "autoConvertMissingPrices",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Lists all in-app products - both managed products and subscriptions. If an app has a large number of in-app
        /// products, the response may be paginated. In this case the response field `tokenPagination.nextPageToken`
        /// will be set and the caller should provide its value as a `token` request parameter to retrieve the next
        /// page. This method should no longer be used to retrieve subscriptions. See [this
        /// article](https://android-developers.googleblog.com/2023/06/changes-to-google-play-developer-api-june-2023.html)
        /// for more information.
        /// </summary>
        /// <param name="packageName">Package name of the app.</param>
        public virtual ListRequest List(string packageName)
        {
            return new ListRequest(this.service, packageName);
        }

        /// <summary>
        /// Lists all in-app products - both managed products and subscriptions. If an app has a large number of in-app
        /// products, the response may be paginated. In this case the response field `tokenPagination.nextPageToken`
        /// will be set and the caller should provide its value as a `token` request parameter to retrieve the next
        /// page. This method should no longer be used to retrieve subscriptions. See [this
        /// article](https://android-developers.googleblog.com/2023/06/changes-to-google-play-developer-api-june-2023.html)
        /// for more information.
        /// </summary>
        public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.InappproductsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string packageName) : base(service)
            {
                PackageName = packageName;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Deprecated and ignored. The page size is determined by the server.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Deprecated and ignored. Set the `token` parameter to retrieve the next page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> StartIndex { get; set; }

            /// <summary>Pagination token. If empty, list starts at the first product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/inappproducts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startIndex", new Google.Apis.Discovery.Parameter
                {
                    Name = "startIndex",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Patches an in-app product (a managed product or a subscription). This method should no longer be used to
        /// update subscriptions. See [this
        /// article](https://android-developers.googleblog.com/2023/06/changes-to-google-play-developer-api-june-2023.html)
        /// for more information.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="sku">Unique identifier for the in-app product.</param>
        public virtual PatchRequest Patch(Google.Apis.AndroidPublisher.v3.Data.InAppProduct body, string packageName, string sku)
        {
            return new PatchRequest(this.service, body, packageName, sku);
        }

        /// <summary>
        /// Patches an in-app product (a managed product or a subscription). This method should no longer be used to
        /// update subscriptions. See [this
        /// article](https://android-developers.googleblog.com/2023/06/changes-to-google-play-developer-api-june-2023.html)
        /// for more information.
        /// </summary>
        public class PatchRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.InAppProduct>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.InAppProduct body, string packageName, string sku) : base(service)
            {
                PackageName = packageName;
                Sku = sku;
                Body = body;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Unique identifier for the in-app product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sku", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Sku { get; private set; }

            /// <summary>
            /// If true the prices for all regions targeted by the parent app that don't have a price specified for this
            /// in-app product will be auto converted to the target currency based on the default price. Defaults to
            /// false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("autoConvertMissingPrices", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AutoConvertMissingPrices { get; set; }

            /// <summary>
            /// Optional. The latency tolerance for the propagation of this product update. Defaults to
            /// latency-sensitive.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("latencyTolerance", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<LatencyToleranceEnum> LatencyTolerance { get; set; }

            /// <summary>
            /// Optional. The latency tolerance for the propagation of this product update. Defaults to
            /// latency-sensitive.
            /// </summary>
            public enum LatencyToleranceEnum
            {
                /// <summary>Defaults to PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_SENSITIVE.</summary>
                [Google.Apis.Util.StringValueAttribute("PRODUCT_UPDATE_LATENCY_TOLERANCE_UNSPECIFIED")]
                PRODUCTUPDATELATENCYTOLERANCEUNSPECIFIED = 0,

                /// <summary>
                /// The update will propagate to clients within several minutes on average and up to a few hours in rare
                /// cases. Throughput is limited to 7,200 updates per app per hour.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_SENSITIVE")]
                PRODUCTUPDATELATENCYTOLERANCELATENCYSENSITIVE = 1,

                /// <summary>
                /// The update will propagate to clients within 24 hours. Supports high throughput of up to 720,000
                /// updates per app per hour using batch modification methods.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT")]
                PRODUCTUPDATELATENCYTOLERANCELATENCYTOLERANT = 2,
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.InAppProduct Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/inappproducts/{sku}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sku", new Google.Apis.Discovery.Parameter
                {
                    Name = "sku",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("autoConvertMissingPrices", new Google.Apis.Discovery.Parameter
                {
                    Name = "autoConvertMissingPrices",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("latencyTolerance", new Google.Apis.Discovery.Parameter
                {
                    Name = "latencyTolerance",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates an in-app product (a managed product or a subscription). This method should no longer be used to
        /// update subscriptions. See [this
        /// article](https://android-developers.googleblog.com/2023/06/changes-to-google-play-developer-api-june-2023.html)
        /// for more information.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="sku">Unique identifier for the in-app product.</param>
        public virtual UpdateRequest Update(Google.Apis.AndroidPublisher.v3.Data.InAppProduct body, string packageName, string sku)
        {
            return new UpdateRequest(this.service, body, packageName, sku);
        }

        /// <summary>
        /// Updates an in-app product (a managed product or a subscription). This method should no longer be used to
        /// update subscriptions. See [this
        /// article](https://android-developers.googleblog.com/2023/06/changes-to-google-play-developer-api-june-2023.html)
        /// for more information.
        /// </summary>
        public class UpdateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.InAppProduct>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.InAppProduct body, string packageName, string sku) : base(service)
            {
                PackageName = packageName;
                Sku = sku;
                Body = body;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Unique identifier for the in-app product.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sku", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Sku { get; private set; }

            /// <summary>
            /// If set to true, and the in-app product with the given package_name and sku doesn't exist, the in-app
            /// product will be created.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AllowMissing { get; set; }

            /// <summary>
            /// If true the prices for all regions targeted by the parent app that don't have a price specified for this
            /// in-app product will be auto converted to the target currency based on the default price. Defaults to
            /// false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("autoConvertMissingPrices", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AutoConvertMissingPrices { get; set; }

            /// <summary>
            /// Optional. The latency tolerance for the propagation of this product update. Defaults to
            /// latency-sensitive.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("latencyTolerance", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<LatencyToleranceEnum> LatencyTolerance { get; set; }

            /// <summary>
            /// Optional. The latency tolerance for the propagation of this product update. Defaults to
            /// latency-sensitive.
            /// </summary>
            public enum LatencyToleranceEnum
            {
                /// <summary>Defaults to PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_SENSITIVE.</summary>
                [Google.Apis.Util.StringValueAttribute("PRODUCT_UPDATE_LATENCY_TOLERANCE_UNSPECIFIED")]
                PRODUCTUPDATELATENCYTOLERANCEUNSPECIFIED = 0,

                /// <summary>
                /// The update will propagate to clients within several minutes on average and up to a few hours in rare
                /// cases. Throughput is limited to 7,200 updates per app per hour.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_SENSITIVE")]
                PRODUCTUPDATELATENCYTOLERANCELATENCYSENSITIVE = 1,

                /// <summary>
                /// The update will propagate to clients within 24 hours. Supports high throughput of up to 720,000
                /// updates per app per hour using batch modification methods.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT")]
                PRODUCTUPDATELATENCYTOLERANCELATENCYTOLERANT = 2,
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.InAppProduct Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/inappproducts/{sku}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sku", new Google.Apis.Discovery.Parameter
                {
                    Name = "sku",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                {
                    Name = "allowMissing",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("autoConvertMissingPrices", new Google.Apis.Discovery.Parameter
                {
                    Name = "autoConvertMissingPrices",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("latencyTolerance", new Google.Apis.Discovery.Parameter
                {
                    Name = "latencyTolerance",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "internalappsharingartifacts" collection of methods.</summary>
    public class InternalappsharingartifactsResource
    {
        private const string Resource = "internalappsharingartifacts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public InternalappsharingartifactsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Uploads an APK to internal app sharing. If you are using the Google API client libraries, please increase
        /// the timeout of the http request before calling this endpoint (a timeout of 2 minutes is recommended). See
        /// [Timeouts and Errors](https://developers.google.com/api-client-library/java/google-api-java-client/errors)
        /// for an example in java.
        /// </summary>
        /// <param name="packageName">Package name of the app.</param>
        public virtual UploadapkRequest Uploadapk(string packageName)
        {
            return new UploadapkRequest(this.service, packageName);
        }

        /// <summary>
        /// Uploads an APK to internal app sharing. If you are using the Google API client libraries, please increase
        /// the timeout of the http request before calling this endpoint (a timeout of 2 minutes is recommended). See
        /// [Timeouts and Errors](https://developers.google.com/api-client-library/java/google-api-java-client/errors)
        /// for an example in java.
        /// </summary>
        public class UploadapkRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.InternalAppSharingArtifact>
        {
            /// <summary>Constructs a new Uploadapk request.</summary>
            public UploadapkRequest(Google.Apis.Services.IClientService service, string packageName) : base(service)
            {
                PackageName = packageName;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "uploadapk";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/internalappsharing/{packageName}/artifacts/apk";

            /// <summary>Initializes Uploadapk parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Uploads an APK to internal app sharing. If you are using the Google API client libraries, please increase
        /// the timeout of the http request before calling this endpoint (a timeout of 2 minutes is recommended). See
        /// [Timeouts and Errors](https://developers.google.com/api-client-library/java/google-api-java-client/errors)
        /// for an example in java.
        /// </summary>
        /// <remarks>
        /// Considerations regarding <paramref name="stream"/>:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before reading
        /// commences. If <paramref name="stream"/> is not seekable, then it will be read from its current position
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
        /// </description>
        /// </item>
        /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
        /// </list>
        /// </remarks>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UploadapkMediaUpload Uploadapk(string packageName, System.IO.Stream stream, string contentType)
        {
            return new UploadapkMediaUpload(service, packageName, stream, contentType);
        }

        /// <summary>Uploadapk media upload which supports resumable upload.</summary>
        public class UploadapkMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.AndroidPublisher.v3.Data.InternalAppSharingArtifact>
        {
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
            /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
            /// Required unless you provide an OAuth 2.0 token.
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
            /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned
            /// to a user, but should not exceed 40 characters.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser { get; set; }

            /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadType { get; set; }

            /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadProtocol { get; set; }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Constructs a new Uploadapk media upload instance.</summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            public UploadapkMediaUpload(Google.Apis.Services.IClientService service, string packageName, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "androidpublisher/v3/applications/internalappsharing/{packageName}/artifacts/apk"), "POST", stream, contentType)
            {
                PackageName = packageName;
            }
        }

        /// <summary>
        /// Uploads an app bundle to internal app sharing. If you are using the Google API client libraries, please
        /// increase the timeout of the http request before calling this endpoint (a timeout of 2 minutes is
        /// recommended). See [Timeouts and
        /// Errors](https://developers.google.com/api-client-library/java/google-api-java-client/errors) for an example
        /// in java.
        /// </summary>
        /// <param name="packageName">Package name of the app.</param>
        public virtual UploadbundleRequest Uploadbundle(string packageName)
        {
            return new UploadbundleRequest(this.service, packageName);
        }

        /// <summary>
        /// Uploads an app bundle to internal app sharing. If you are using the Google API client libraries, please
        /// increase the timeout of the http request before calling this endpoint (a timeout of 2 minutes is
        /// recommended). See [Timeouts and
        /// Errors](https://developers.google.com/api-client-library/java/google-api-java-client/errors) for an example
        /// in java.
        /// </summary>
        public class UploadbundleRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.InternalAppSharingArtifact>
        {
            /// <summary>Constructs a new Uploadbundle request.</summary>
            public UploadbundleRequest(Google.Apis.Services.IClientService service, string packageName) : base(service)
            {
                PackageName = packageName;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "uploadbundle";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/internalappsharing/{packageName}/artifacts/bundle";

            /// <summary>Initializes Uploadbundle parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Uploads an app bundle to internal app sharing. If you are using the Google API client libraries, please
        /// increase the timeout of the http request before calling this endpoint (a timeout of 2 minutes is
        /// recommended). See [Timeouts and
        /// Errors](https://developers.google.com/api-client-library/java/google-api-java-client/errors) for an example
        /// in java.
        /// </summary>
        /// <remarks>
        /// Considerations regarding <paramref name="stream"/>:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before reading
        /// commences. If <paramref name="stream"/> is not seekable, then it will be read from its current position
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
        /// </description>
        /// </item>
        /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
        /// </list>
        /// </remarks>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual UploadbundleMediaUpload Uploadbundle(string packageName, System.IO.Stream stream, string contentType)
        {
            return new UploadbundleMediaUpload(service, packageName, stream, contentType);
        }

        /// <summary>Uploadbundle media upload which supports resumable upload.</summary>
        public class UploadbundleMediaUpload : Google.Apis.Upload.ResumableUpload<string, Google.Apis.AndroidPublisher.v3.Data.InternalAppSharingArtifact>
        {
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
            /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
            /// Required unless you provide an OAuth 2.0 token.
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
            /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned
            /// to a user, but should not exceed 40 characters.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser { get; set; }

            /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadType { get; set; }

            /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
            [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadProtocol { get; set; }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Constructs a new Uploadbundle media upload instance.</summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            public UploadbundleMediaUpload(Google.Apis.Services.IClientService service, string packageName, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "androidpublisher/v3/applications/internalappsharing/{packageName}/artifacts/bundle"), "POST", stream, contentType)
            {
                PackageName = packageName;
            }
        }
    }

    /// <summary>The "monetization" collection of methods.</summary>
    public class MonetizationResource
    {
        private const string Resource = "monetization";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MonetizationResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Subscriptions = new SubscriptionsResource(service);
        }

        /// <summary>Gets the Subscriptions resource.</summary>
        public virtual SubscriptionsResource Subscriptions { get; }

        /// <summary>The "subscriptions" collection of methods.</summary>
        public class SubscriptionsResource
        {
            private const string Resource = "subscriptions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SubscriptionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                BasePlans = new BasePlansResource(service);
            }

            /// <summary>Gets the BasePlans resource.</summary>
            public virtual BasePlansResource BasePlans { get; }

            /// <summary>The "basePlans" collection of methods.</summary>
            public class BasePlansResource
            {
                private const string Resource = "basePlans";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public BasePlansResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Offers = new OffersResource(service);
                }

                /// <summary>Gets the Offers resource.</summary>
                public virtual OffersResource Offers { get; }

                /// <summary>The "offers" collection of methods.</summary>
                public class OffersResource
                {
                    private const string Resource = "offers";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public OffersResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Activates a subscription offer. Once activated, subscription offers will be available to new
                    /// subscribers.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="packageName">
                    /// Required. The parent app (package name) of the offer to activate.
                    /// </param>
                    /// <param name="productId">Required. The parent subscription (ID) of the offer to activate.</param>
                    /// <param name="basePlanId">Required. The parent base plan (ID) of the offer to activate.</param>
                    /// <param name="offerId">Required. The unique offer ID of the offer to activate.</param>
                    public virtual ActivateRequest Activate(Google.Apis.AndroidPublisher.v3.Data.ActivateSubscriptionOfferRequest body, string packageName, string productId, string basePlanId, string offerId)
                    {
                        return new ActivateRequest(this.service, body, packageName, productId, basePlanId, offerId);
                    }

                    /// <summary>
                    /// Activates a subscription offer. Once activated, subscription offers will be available to new
                    /// subscribers.
                    /// </summary>
                    public class ActivateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.SubscriptionOffer>
                    {
                        /// <summary>Constructs a new Activate request.</summary>
                        public ActivateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.ActivateSubscriptionOfferRequest body, string packageName, string productId, string basePlanId, string offerId) : base(service)
                        {
                            PackageName = packageName;
                            ProductId = productId;
                            BasePlanId = basePlanId;
                            OfferId = offerId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The parent app (package name) of the offer to activate.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string PackageName { get; private set; }

                        /// <summary>Required. The parent subscription (ID) of the offer to activate.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProductId { get; private set; }

                        /// <summary>Required. The parent base plan (ID) of the offer to activate.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("basePlanId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string BasePlanId { get; private set; }

                        /// <summary>Required. The unique offer ID of the offer to activate.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("offerId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string OfferId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.AndroidPublisher.v3.Data.ActivateSubscriptionOfferRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "activate";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}/basePlans/{basePlanId}/offers/{offerId}:activate";

                        /// <summary>Initializes Activate parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "packageName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "productId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("basePlanId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "basePlanId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("offerId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "offerId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Reads one or more subscription offers.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="packageName">
                    /// Required. The parent app (package name) for which the subscriptions should be created or
                    /// updated. Must be equal to the package_name field on all the requests.
                    /// </param>
                    /// <param name="productId">
                    /// Required. The product ID of the parent subscription, if all updated offers belong to the same
                    /// subscription. If this request spans multiple subscriptions, set this field to "-". Must be set.
                    /// </param>
                    /// <param name="basePlanId">
                    /// Required. The parent base plan (ID) for which the offers should be read. May be specified as '-'
                    /// to read offers from multiple base plans.
                    /// </param>
                    public virtual BatchGetRequest BatchGet(Google.Apis.AndroidPublisher.v3.Data.BatchGetSubscriptionOffersRequest body, string packageName, string productId, string basePlanId)
                    {
                        return new BatchGetRequest(this.service, body, packageName, productId, basePlanId);
                    }

                    /// <summary>Reads one or more subscription offers.</summary>
                    public class BatchGetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.BatchGetSubscriptionOffersResponse>
                    {
                        /// <summary>Constructs a new BatchGet request.</summary>
                        public BatchGetRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.BatchGetSubscriptionOffersRequest body, string packageName, string productId, string basePlanId) : base(service)
                        {
                            PackageName = packageName;
                            ProductId = productId;
                            BasePlanId = basePlanId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent app (package name) for which the subscriptions should be created or
                        /// updated. Must be equal to the package_name field on all the requests.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string PackageName { get; private set; }

                        /// <summary>
                        /// Required. The product ID of the parent subscription, if all updated offers belong to the
                        /// same subscription. If this request spans multiple subscriptions, set this field to "-". Must
                        /// be set.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProductId { get; private set; }

                        /// <summary>
                        /// Required. The parent base plan (ID) for which the offers should be read. May be specified as
                        /// '-' to read offers from multiple base plans.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("basePlanId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string BasePlanId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.AndroidPublisher.v3.Data.BatchGetSubscriptionOffersRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "batchGet";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}/basePlans/{basePlanId}/offers:batchGet";

                        /// <summary>Initializes BatchGet parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "packageName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "productId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("basePlanId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "basePlanId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Updates a batch of subscription offers. Set the latencyTolerance field on nested requests to
                    /// PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT to achieve maximum update throughput.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="packageName">
                    /// Required. The parent app (package name) of the updated subscription offers. Must be equal to the
                    /// package_name field on all the updated SubscriptionOffer resources.
                    /// </param>
                    /// <param name="productId">
                    /// Required. The product ID of the parent subscription, if all updated offers belong to the same
                    /// subscription. If this request spans multiple subscriptions, set this field to "-". Must be set.
                    /// </param>
                    /// <param name="basePlanId">
                    /// Required. The parent base plan (ID) for which the offers should be updated. May be specified as
                    /// '-' to update offers from multiple base plans.
                    /// </param>
                    public virtual BatchUpdateRequest BatchUpdate(Google.Apis.AndroidPublisher.v3.Data.BatchUpdateSubscriptionOffersRequest body, string packageName, string productId, string basePlanId)
                    {
                        return new BatchUpdateRequest(this.service, body, packageName, productId, basePlanId);
                    }

                    /// <summary>
                    /// Updates a batch of subscription offers. Set the latencyTolerance field on nested requests to
                    /// PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT to achieve maximum update throughput.
                    /// </summary>
                    public class BatchUpdateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.BatchUpdateSubscriptionOffersResponse>
                    {
                        /// <summary>Constructs a new BatchUpdate request.</summary>
                        public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.BatchUpdateSubscriptionOffersRequest body, string packageName, string productId, string basePlanId) : base(service)
                        {
                            PackageName = packageName;
                            ProductId = productId;
                            BasePlanId = basePlanId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent app (package name) of the updated subscription offers. Must be equal to
                        /// the package_name field on all the updated SubscriptionOffer resources.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string PackageName { get; private set; }

                        /// <summary>
                        /// Required. The product ID of the parent subscription, if all updated offers belong to the
                        /// same subscription. If this request spans multiple subscriptions, set this field to "-". Must
                        /// be set.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProductId { get; private set; }

                        /// <summary>
                        /// Required. The parent base plan (ID) for which the offers should be updated. May be specified
                        /// as '-' to update offers from multiple base plans.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("basePlanId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string BasePlanId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.AndroidPublisher.v3.Data.BatchUpdateSubscriptionOffersRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "batchUpdate";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}/basePlans/{basePlanId}/offers:batchUpdate";

                        /// <summary>Initializes BatchUpdate parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "packageName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "productId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("basePlanId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "basePlanId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Updates a batch of subscription offer states. Set the latencyTolerance field on nested requests
                    /// to PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT to achieve maximum update throughput.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="packageName">
                    /// Required. The parent app (package name) of the updated subscription offers. Must be equal to the
                    /// package_name field on all the updated SubscriptionOffer resources.
                    /// </param>
                    /// <param name="productId">
                    /// Required. The product ID of the parent subscription, if all updated offers belong to the same
                    /// subscription. If this request spans multiple subscriptions, set this field to "-". Must be set.
                    /// </param>
                    /// <param name="basePlanId">
                    /// Required. The parent base plan (ID) for which the offers should be updated. May be specified as
                    /// '-' to update offers from multiple base plans.
                    /// </param>
                    public virtual BatchUpdateStatesRequest BatchUpdateStates(Google.Apis.AndroidPublisher.v3.Data.BatchUpdateSubscriptionOfferStatesRequest body, string packageName, string productId, string basePlanId)
                    {
                        return new BatchUpdateStatesRequest(this.service, body, packageName, productId, basePlanId);
                    }

                    /// <summary>
                    /// Updates a batch of subscription offer states. Set the latencyTolerance field on nested requests
                    /// to PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT to achieve maximum update throughput.
                    /// </summary>
                    public class BatchUpdateStatesRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.BatchUpdateSubscriptionOfferStatesResponse>
                    {
                        /// <summary>Constructs a new BatchUpdateStates request.</summary>
                        public BatchUpdateStatesRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.BatchUpdateSubscriptionOfferStatesRequest body, string packageName, string productId, string basePlanId) : base(service)
                        {
                            PackageName = packageName;
                            ProductId = productId;
                            BasePlanId = basePlanId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent app (package name) of the updated subscription offers. Must be equal to
                        /// the package_name field on all the updated SubscriptionOffer resources.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string PackageName { get; private set; }

                        /// <summary>
                        /// Required. The product ID of the parent subscription, if all updated offers belong to the
                        /// same subscription. If this request spans multiple subscriptions, set this field to "-". Must
                        /// be set.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProductId { get; private set; }

                        /// <summary>
                        /// Required. The parent base plan (ID) for which the offers should be updated. May be specified
                        /// as '-' to update offers from multiple base plans.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("basePlanId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string BasePlanId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.AndroidPublisher.v3.Data.BatchUpdateSubscriptionOfferStatesRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "batchUpdateStates";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}/basePlans/{basePlanId}/offers:batchUpdateStates";

                        /// <summary>Initializes BatchUpdateStates parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "packageName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "productId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("basePlanId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "basePlanId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Creates a new subscription offer. Only auto-renewing base plans can have subscription offers.
                    /// The offer state will be DRAFT until it is activated.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="packageName">
                    /// Required. The parent app (package name) for which the offer should be created. Must be equal to
                    /// the package_name field on the Subscription resource.
                    /// </param>
                    /// <param name="productId">
                    /// Required. The parent subscription (ID) for which the offer should be created. Must be equal to
                    /// the product_id field on the SubscriptionOffer resource.
                    /// </param>
                    /// <param name="basePlanId">
                    /// Required. The parent base plan (ID) for which the offer should be created. Must be equal to the
                    /// base_plan_id field on the SubscriptionOffer resource.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.AndroidPublisher.v3.Data.SubscriptionOffer body, string packageName, string productId, string basePlanId)
                    {
                        return new CreateRequest(this.service, body, packageName, productId, basePlanId);
                    }

                    /// <summary>
                    /// Creates a new subscription offer. Only auto-renewing base plans can have subscription offers.
                    /// The offer state will be DRAFT until it is activated.
                    /// </summary>
                    public class CreateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.SubscriptionOffer>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.SubscriptionOffer body, string packageName, string productId, string basePlanId) : base(service)
                        {
                            PackageName = packageName;
                            ProductId = productId;
                            BasePlanId = basePlanId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent app (package name) for which the offer should be created. Must be equal
                        /// to the package_name field on the Subscription resource.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string PackageName { get; private set; }

                        /// <summary>
                        /// Required. The parent subscription (ID) for which the offer should be created. Must be equal
                        /// to the product_id field on the SubscriptionOffer resource.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProductId { get; private set; }

                        /// <summary>
                        /// Required. The parent base plan (ID) for which the offer should be created. Must be equal to
                        /// the base_plan_id field on the SubscriptionOffer resource.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("basePlanId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string BasePlanId { get; private set; }

                        /// <summary>
                        /// Required. The ID to use for the offer. For the requirements on this format, see the
                        /// documentation of the offer_id field on the SubscriptionOffer resource.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("offerId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string OfferId { get; set; }

                        /// <summary>
                        /// Required. A string representing the version of available regions being used for the
                        /// specified resource. Regional prices for the resource have to be specified according to the
                        /// information published in [this
                        /// article](https://support.google.com/googleplay/android-developer/answer/10532353). Each time
                        /// the supported locations substantially change, the version will be incremented. Using this
                        /// field will ensure that creating and updating the resource with an older region's version and
                        /// set of regional prices and currencies will succeed even though a new version is available.
                        /// The latest version is 2022/02.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("regionsVersion.version", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RegionsVersionVersion { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.AndroidPublisher.v3.Data.SubscriptionOffer Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}/basePlans/{basePlanId}/offers";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "packageName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "productId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("basePlanId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "basePlanId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("offerId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "offerId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("regionsVersion.version", new Google.Apis.Discovery.Parameter
                            {
                                Name = "regionsVersion.version",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Deactivates a subscription offer. Once deactivated, existing subscribers will maintain their
                    /// subscription, but the offer will become unavailable to new subscribers.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="packageName">
                    /// Required. The parent app (package name) of the offer to deactivate.
                    /// </param>
                    /// <param name="productId">
                    /// Required. The parent subscription (ID) of the offer to deactivate.
                    /// </param>
                    /// <param name="basePlanId">Required. The parent base plan (ID) of the offer to deactivate.</param>
                    /// <param name="offerId">Required. The unique offer ID of the offer to deactivate.</param>
                    public virtual DeactivateRequest Deactivate(Google.Apis.AndroidPublisher.v3.Data.DeactivateSubscriptionOfferRequest body, string packageName, string productId, string basePlanId, string offerId)
                    {
                        return new DeactivateRequest(this.service, body, packageName, productId, basePlanId, offerId);
                    }

                    /// <summary>
                    /// Deactivates a subscription offer. Once deactivated, existing subscribers will maintain their
                    /// subscription, but the offer will become unavailable to new subscribers.
                    /// </summary>
                    public class DeactivateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.SubscriptionOffer>
                    {
                        /// <summary>Constructs a new Deactivate request.</summary>
                        public DeactivateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.DeactivateSubscriptionOfferRequest body, string packageName, string productId, string basePlanId, string offerId) : base(service)
                        {
                            PackageName = packageName;
                            ProductId = productId;
                            BasePlanId = basePlanId;
                            OfferId = offerId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The parent app (package name) of the offer to deactivate.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string PackageName { get; private set; }

                        /// <summary>Required. The parent subscription (ID) of the offer to deactivate.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProductId { get; private set; }

                        /// <summary>Required. The parent base plan (ID) of the offer to deactivate.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("basePlanId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string BasePlanId { get; private set; }

                        /// <summary>Required. The unique offer ID of the offer to deactivate.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("offerId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string OfferId { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.AndroidPublisher.v3.Data.DeactivateSubscriptionOfferRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "deactivate";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}/basePlans/{basePlanId}/offers/{offerId}:deactivate";

                        /// <summary>Initializes Deactivate parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "packageName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "productId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("basePlanId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "basePlanId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("offerId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "offerId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes a subscription offer. Can only be done for draft offers. This action is irreversible.
                    /// </summary>
                    /// <param name="packageName">
                    /// Required. The parent app (package name) of the offer to delete.
                    /// </param>
                    /// <param name="productId">Required. The parent subscription (ID) of the offer to delete.</param>
                    /// <param name="basePlanId">Required. The parent base plan (ID) of the offer to delete.</param>
                    /// <param name="offerId">Required. The unique offer ID of the offer to delete.</param>
                    public virtual DeleteRequest Delete(string packageName, string productId, string basePlanId, string offerId)
                    {
                        return new DeleteRequest(this.service, packageName, productId, basePlanId, offerId);
                    }

                    /// <summary>
                    /// Deletes a subscription offer. Can only be done for draft offers. This action is irreversible.
                    /// </summary>
                    public class DeleteRequest : AndroidPublisherBaseServiceRequest<string>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string packageName, string productId, string basePlanId, string offerId) : base(service)
                        {
                            PackageName = packageName;
                            ProductId = productId;
                            BasePlanId = basePlanId;
                            OfferId = offerId;
                            InitParameters();
                        }

                        /// <summary>Required. The parent app (package name) of the offer to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string PackageName { get; private set; }

                        /// <summary>Required. The parent subscription (ID) of the offer to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProductId { get; private set; }

                        /// <summary>Required. The parent base plan (ID) of the offer to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("basePlanId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string BasePlanId { get; private set; }

                        /// <summary>Required. The unique offer ID of the offer to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("offerId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string OfferId { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}/basePlans/{basePlanId}/offers/{offerId}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "packageName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "productId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("basePlanId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "basePlanId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("offerId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "offerId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Reads a single offer</summary>
                    /// <param name="packageName">Required. The parent app (package name) of the offer to get.</param>
                    /// <param name="productId">Required. The parent subscription (ID) of the offer to get.</param>
                    /// <param name="basePlanId">Required. The parent base plan (ID) of the offer to get.</param>
                    /// <param name="offerId">Required. The unique offer ID of the offer to get.</param>
                    public virtual GetRequest Get(string packageName, string productId, string basePlanId, string offerId)
                    {
                        return new GetRequest(this.service, packageName, productId, basePlanId, offerId);
                    }

                    /// <summary>Reads a single offer</summary>
                    public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.SubscriptionOffer>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string packageName, string productId, string basePlanId, string offerId) : base(service)
                        {
                            PackageName = packageName;
                            ProductId = productId;
                            BasePlanId = basePlanId;
                            OfferId = offerId;
                            InitParameters();
                        }

                        /// <summary>Required. The parent app (package name) of the offer to get.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string PackageName { get; private set; }

                        /// <summary>Required. The parent subscription (ID) of the offer to get.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProductId { get; private set; }

                        /// <summary>Required. The parent base plan (ID) of the offer to get.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("basePlanId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string BasePlanId { get; private set; }

                        /// <summary>Required. The unique offer ID of the offer to get.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("offerId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string OfferId { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}/basePlans/{basePlanId}/offers/{offerId}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "packageName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "productId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("basePlanId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "basePlanId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("offerId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "offerId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Lists all offers under a given subscription.</summary>
                    /// <param name="packageName">
                    /// Required. The parent app (package name) for which the subscriptions should be read.
                    /// </param>
                    /// <param name="productId">
                    /// Required. The parent subscription (ID) for which the offers should be read. May be specified as
                    /// '-' to read all offers under an app.
                    /// </param>
                    /// <param name="basePlanId">
                    /// Required. The parent base plan (ID) for which the offers should be read. May be specified as '-'
                    /// to read all offers under a subscription or an app. Must be specified as '-' if product_id is
                    /// specified as '-'.
                    /// </param>
                    public virtual ListRequest List(string packageName, string productId, string basePlanId)
                    {
                        return new ListRequest(this.service, packageName, productId, basePlanId);
                    }

                    /// <summary>Lists all offers under a given subscription.</summary>
                    public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ListSubscriptionOffersResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string packageName, string productId, string basePlanId) : base(service)
                        {
                            PackageName = packageName;
                            ProductId = productId;
                            BasePlanId = basePlanId;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent app (package name) for which the subscriptions should be read.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string PackageName { get; private set; }

                        /// <summary>
                        /// Required. The parent subscription (ID) for which the offers should be read. May be specified
                        /// as '-' to read all offers under an app.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProductId { get; private set; }

                        /// <summary>
                        /// Required. The parent base plan (ID) for which the offers should be read. May be specified as
                        /// '-' to read all offers under a subscription or an app. Must be specified as '-' if
                        /// product_id is specified as '-'.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("basePlanId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string BasePlanId { get; private set; }

                        /// <summary>
                        /// The maximum number of subscriptions to return. The service may return fewer than this value.
                        /// If unspecified, at most 50 subscriptions will be returned. The maximum value is 1000; values
                        /// above 1000 will be coerced to 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// A page token, received from a previous `ListSubscriptionsOffers` call. Provide this to
                        /// retrieve the subsequent page. When paginating, all other parameters provided to
                        /// `ListSubscriptionOffers` must match the call that provided the page token.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}/basePlans/{basePlanId}/offers";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "packageName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "productId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("basePlanId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "basePlanId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageSize",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageToken",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Updates an existing subscription offer.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="packageName">
                    /// Required. Immutable. The package name of the app the parent subscription belongs to.
                    /// </param>
                    /// <param name="productId">
                    /// Required. Immutable. The ID of the parent subscription this offer belongs to.
                    /// </param>
                    /// <param name="basePlanId">
                    /// Required. Immutable. The ID of the base plan to which this offer is an extension.
                    /// </param>
                    /// <param name="offerId">
                    /// Required. Immutable. Unique ID of this subscription offer. Must be unique within the base plan.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.AndroidPublisher.v3.Data.SubscriptionOffer body, string packageName, string productId, string basePlanId, string offerId)
                    {
                        return new PatchRequest(this.service, body, packageName, productId, basePlanId, offerId);
                    }

                    /// <summary>Updates an existing subscription offer.</summary>
                    public class PatchRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.SubscriptionOffer>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.SubscriptionOffer body, string packageName, string productId, string basePlanId, string offerId) : base(service)
                        {
                            PackageName = packageName;
                            ProductId = productId;
                            BasePlanId = basePlanId;
                            OfferId = offerId;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Immutable. The package name of the app the parent subscription belongs to.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string PackageName { get; private set; }

                        /// <summary>
                        /// Required. Immutable. The ID of the parent subscription this offer belongs to.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ProductId { get; private set; }

                        /// <summary>
                        /// Required. Immutable. The ID of the base plan to which this offer is an extension.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("basePlanId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string BasePlanId { get; private set; }

                        /// <summary>
                        /// Required. Immutable. Unique ID of this subscription offer. Must be unique within the base
                        /// plan.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("offerId", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string OfferId { get; private set; }

                        /// <summary>
                        /// Optional. If set to true, and the subscription offer with the given package_name,
                        /// product_id, base_plan_id and offer_id doesn't exist, an offer will be created. If a new
                        /// offer is created, update_mask is ignored.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> AllowMissing { get; set; }

                        /// <summary>
                        /// Optional. The latency tolerance for the propagation of this product update. Defaults to
                        /// latency-sensitive.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("latencyTolerance", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<LatencyToleranceEnum> LatencyTolerance { get; set; }

                        /// <summary>
                        /// Optional. The latency tolerance for the propagation of this product update. Defaults to
                        /// latency-sensitive.
                        /// </summary>
                        public enum LatencyToleranceEnum
                        {
                            /// <summary>Defaults to PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_SENSITIVE.</summary>
                            [Google.Apis.Util.StringValueAttribute("PRODUCT_UPDATE_LATENCY_TOLERANCE_UNSPECIFIED")]
                            PRODUCTUPDATELATENCYTOLERANCEUNSPECIFIED = 0,

                            /// <summary>
                            /// The update will propagate to clients within several minutes on average and up to a few
                            /// hours in rare cases. Throughput is limited to 7,200 updates per app per hour.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_SENSITIVE")]
                            PRODUCTUPDATELATENCYTOLERANCELATENCYSENSITIVE = 1,

                            /// <summary>
                            /// The update will propagate to clients within 24 hours. Supports high throughput of up to
                            /// 720,000 updates per app per hour using batch modification methods.
                            /// </summary>
                            [Google.Apis.Util.StringValueAttribute("PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT")]
                            PRODUCTUPDATELATENCYTOLERANCELATENCYTOLERANT = 2,
                        }

                        /// <summary>
                        /// Required. A string representing the version of available regions being used for the
                        /// specified resource. Regional prices for the resource have to be specified according to the
                        /// information published in [this
                        /// article](https://support.google.com/googleplay/android-developer/answer/10532353). Each time
                        /// the supported locations substantially change, the version will be incremented. Using this
                        /// field will ensure that creating and updating the resource with an older region's version and
                        /// set of regional prices and currencies will succeed even though a new version is available.
                        /// The latest version is 2022/02.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("regionsVersion.version", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string RegionsVersionVersion { get; set; }

                        /// <summary>Required. The list of fields to be updated.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.AndroidPublisher.v3.Data.SubscriptionOffer Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}/basePlans/{basePlanId}/offers/{offerId}";

                        /// <summary>Initializes Patch parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                            {
                                Name = "packageName",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "productId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("basePlanId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "basePlanId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("offerId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "offerId",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                            {
                                Name = "allowMissing",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("latencyTolerance", new Google.Apis.Discovery.Parameter
                            {
                                Name = "latencyTolerance",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("regionsVersion.version", new Google.Apis.Discovery.Parameter
                            {
                                Name = "regionsVersion.version",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "updateMask",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }
                }

                /// <summary>
                /// Activates a base plan. Once activated, base plans will be available to new subscribers.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="packageName">
                /// Required. The parent app (package name) of the base plan to activate.
                /// </param>
                /// <param name="productId">Required. The parent subscription (ID) of the base plan to activate.</param>
                /// <param name="basePlanId">Required. The unique base plan ID of the base plan to activate.</param>
                public virtual ActivateRequest Activate(Google.Apis.AndroidPublisher.v3.Data.ActivateBasePlanRequest body, string packageName, string productId, string basePlanId)
                {
                    return new ActivateRequest(this.service, body, packageName, productId, basePlanId);
                }

                /// <summary>
                /// Activates a base plan. Once activated, base plans will be available to new subscribers.
                /// </summary>
                public class ActivateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Subscription>
                {
                    /// <summary>Constructs a new Activate request.</summary>
                    public ActivateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.ActivateBasePlanRequest body, string packageName, string productId, string basePlanId) : base(service)
                    {
                        PackageName = packageName;
                        ProductId = productId;
                        BasePlanId = basePlanId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent app (package name) of the base plan to activate.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string PackageName { get; private set; }

                    /// <summary>Required. The parent subscription (ID) of the base plan to activate.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProductId { get; private set; }

                    /// <summary>Required. The unique base plan ID of the base plan to activate.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("basePlanId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string BasePlanId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AndroidPublisher.v3.Data.ActivateBasePlanRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "activate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}/basePlans/{basePlanId}:activate";

                    /// <summary>Initializes Activate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "packageName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "productId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("basePlanId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "basePlanId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Batch variant of the MigrateBasePlanPrices endpoint. Set the latencyTolerance field on nested
                /// requests to PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT to achieve maximum update throughput.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="packageName">
                /// Required. The parent app (package name) for which the subscriptions should be created or updated.
                /// Must be equal to the package_name field on all the Subscription resources.
                /// </param>
                /// <param name="productId">
                /// Required. The product ID of the parent subscription, if all updated offers belong to the same
                /// subscription. If this batch update spans multiple subscriptions, set this field to "-". Must be set.
                /// </param>
                public virtual BatchMigratePricesRequest BatchMigratePrices(Google.Apis.AndroidPublisher.v3.Data.BatchMigrateBasePlanPricesRequest body, string packageName, string productId)
                {
                    return new BatchMigratePricesRequest(this.service, body, packageName, productId);
                }

                /// <summary>
                /// Batch variant of the MigrateBasePlanPrices endpoint. Set the latencyTolerance field on nested
                /// requests to PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT to achieve maximum update throughput.
                /// </summary>
                public class BatchMigratePricesRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.BatchMigrateBasePlanPricesResponse>
                {
                    /// <summary>Constructs a new BatchMigratePrices request.</summary>
                    public BatchMigratePricesRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.BatchMigrateBasePlanPricesRequest body, string packageName, string productId) : base(service)
                    {
                        PackageName = packageName;
                        ProductId = productId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent app (package name) for which the subscriptions should be created or
                    /// updated. Must be equal to the package_name field on all the Subscription resources.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string PackageName { get; private set; }

                    /// <summary>
                    /// Required. The product ID of the parent subscription, if all updated offers belong to the same
                    /// subscription. If this batch update spans multiple subscriptions, set this field to "-". Must be
                    /// set.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProductId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AndroidPublisher.v3.Data.BatchMigrateBasePlanPricesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchMigratePrices";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}/basePlans:batchMigratePrices";

                    /// <summary>Initializes BatchMigratePrices parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "packageName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "productId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Activates or deactivates base plans across one or multiple subscriptions. Set the latencyTolerance
                /// field on nested requests to PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT to achieve maximum
                /// update throughput.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="packageName">Required. The parent app (package name) of the updated base plans.</param>
                /// <param name="productId">
                /// Required. The product ID of the parent subscription, if all updated base plans belong to the same
                /// subscription. If this batch update spans multiple subscriptions, set this field to "-". Must be set.
                /// </param>
                public virtual BatchUpdateStatesRequest BatchUpdateStates(Google.Apis.AndroidPublisher.v3.Data.BatchUpdateBasePlanStatesRequest body, string packageName, string productId)
                {
                    return new BatchUpdateStatesRequest(this.service, body, packageName, productId);
                }

                /// <summary>
                /// Activates or deactivates base plans across one or multiple subscriptions. Set the latencyTolerance
                /// field on nested requests to PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT to achieve maximum
                /// update throughput.
                /// </summary>
                public class BatchUpdateStatesRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.BatchUpdateBasePlanStatesResponse>
                {
                    /// <summary>Constructs a new BatchUpdateStates request.</summary>
                    public BatchUpdateStatesRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.BatchUpdateBasePlanStatesRequest body, string packageName, string productId) : base(service)
                    {
                        PackageName = packageName;
                        ProductId = productId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent app (package name) of the updated base plans.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string PackageName { get; private set; }

                    /// <summary>
                    /// Required. The product ID of the parent subscription, if all updated base plans belong to the
                    /// same subscription. If this batch update spans multiple subscriptions, set this field to "-".
                    /// Must be set.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProductId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AndroidPublisher.v3.Data.BatchUpdateBasePlanStatesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchUpdateStates";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}/basePlans:batchUpdateStates";

                    /// <summary>Initializes BatchUpdateStates parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "packageName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "productId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deactivates a base plan. Once deactivated, the base plan will become unavailable to new subscribers,
                /// but existing subscribers will maintain their subscription
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="packageName">
                /// Required. The parent app (package name) of the base plan to deactivate.
                /// </param>
                /// <param name="productId">
                /// Required. The parent subscription (ID) of the base plan to deactivate.
                /// </param>
                /// <param name="basePlanId">Required. The unique base plan ID of the base plan to deactivate.</param>
                public virtual DeactivateRequest Deactivate(Google.Apis.AndroidPublisher.v3.Data.DeactivateBasePlanRequest body, string packageName, string productId, string basePlanId)
                {
                    return new DeactivateRequest(this.service, body, packageName, productId, basePlanId);
                }

                /// <summary>
                /// Deactivates a base plan. Once deactivated, the base plan will become unavailable to new subscribers,
                /// but existing subscribers will maintain their subscription
                /// </summary>
                public class DeactivateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Subscription>
                {
                    /// <summary>Constructs a new Deactivate request.</summary>
                    public DeactivateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.DeactivateBasePlanRequest body, string packageName, string productId, string basePlanId) : base(service)
                    {
                        PackageName = packageName;
                        ProductId = productId;
                        BasePlanId = basePlanId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The parent app (package name) of the base plan to deactivate.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string PackageName { get; private set; }

                    /// <summary>Required. The parent subscription (ID) of the base plan to deactivate.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProductId { get; private set; }

                    /// <summary>Required. The unique base plan ID of the base plan to deactivate.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("basePlanId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string BasePlanId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AndroidPublisher.v3.Data.DeactivateBasePlanRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "deactivate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}/basePlans/{basePlanId}:deactivate";

                    /// <summary>Initializes Deactivate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "packageName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "productId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("basePlanId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "basePlanId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Deletes a base plan. Can only be done for draft base plans. This action is irreversible.
                /// </summary>
                /// <param name="packageName">
                /// Required. The parent app (package name) of the base plan to delete.
                /// </param>
                /// <param name="productId">Required. The parent subscription (ID) of the base plan to delete.</param>
                /// <param name="basePlanId">Required. The unique offer ID of the base plan to delete.</param>
                public virtual DeleteRequest Delete(string packageName, string productId, string basePlanId)
                {
                    return new DeleteRequest(this.service, packageName, productId, basePlanId);
                }

                /// <summary>
                /// Deletes a base plan. Can only be done for draft base plans. This action is irreversible.
                /// </summary>
                public class DeleteRequest : AndroidPublisherBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string packageName, string productId, string basePlanId) : base(service)
                    {
                        PackageName = packageName;
                        ProductId = productId;
                        BasePlanId = basePlanId;
                        InitParameters();
                    }

                    /// <summary>Required. The parent app (package name) of the base plan to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string PackageName { get; private set; }

                    /// <summary>Required. The parent subscription (ID) of the base plan to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProductId { get; private set; }

                    /// <summary>Required. The unique offer ID of the base plan to delete.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("basePlanId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string BasePlanId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}/basePlans/{basePlanId}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "packageName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "productId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("basePlanId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "basePlanId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Migrates subscribers from one or more legacy price cohorts to the current price. Requests result in
                /// Google Play notifying affected subscribers. Only up to 250 simultaneous legacy price cohorts are
                /// supported.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="packageName">
                /// Required. Package name of the parent app. Must be equal to the package_name field on the
                /// Subscription resource.
                /// </param>
                /// <param name="productId">
                /// Required. The ID of the subscription to update. Must be equal to the product_id field on the
                /// Subscription resource.
                /// </param>
                /// <param name="basePlanId">
                /// Required. The unique base plan ID of the base plan to update prices on.
                /// </param>
                public virtual MigratePricesRequest MigratePrices(Google.Apis.AndroidPublisher.v3.Data.MigrateBasePlanPricesRequest body, string packageName, string productId, string basePlanId)
                {
                    return new MigratePricesRequest(this.service, body, packageName, productId, basePlanId);
                }

                /// <summary>
                /// Migrates subscribers from one or more legacy price cohorts to the current price. Requests result in
                /// Google Play notifying affected subscribers. Only up to 250 simultaneous legacy price cohorts are
                /// supported.
                /// </summary>
                public class MigratePricesRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.MigrateBasePlanPricesResponse>
                {
                    /// <summary>Constructs a new MigratePrices request.</summary>
                    public MigratePricesRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.MigrateBasePlanPricesRequest body, string packageName, string productId, string basePlanId) : base(service)
                    {
                        PackageName = packageName;
                        ProductId = productId;
                        BasePlanId = basePlanId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Package name of the parent app. Must be equal to the package_name field on the
                    /// Subscription resource.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string PackageName { get; private set; }

                    /// <summary>
                    /// Required. The ID of the subscription to update. Must be equal to the product_id field on the
                    /// Subscription resource.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string ProductId { get; private set; }

                    /// <summary>Required. The unique base plan ID of the base plan to update prices on.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("basePlanId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string BasePlanId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.AndroidPublisher.v3.Data.MigrateBasePlanPricesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "migratePrices";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}/basePlans/{basePlanId}:migratePrices";

                    /// <summary>Initializes MigratePrices parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "packageName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "productId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("basePlanId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "basePlanId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Deprecated: subscription archiving is not supported.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">
            /// Required. The parent app (package name) of the app of the subscription to delete.
            /// </param>
            /// <param name="productId">Required. The unique product ID of the subscription to delete.</param>
            public virtual ArchiveRequest Archive(Google.Apis.AndroidPublisher.v3.Data.ArchiveSubscriptionRequest body, string packageName, string productId)
            {
                return new ArchiveRequest(this.service, body, packageName, productId);
            }

            /// <summary>Deprecated: subscription archiving is not supported.</summary>
            public class ArchiveRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Subscription>
            {
                /// <summary>Constructs a new Archive request.</summary>
                public ArchiveRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.ArchiveSubscriptionRequest body, string packageName, string productId) : base(service)
                {
                    PackageName = packageName;
                    ProductId = productId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The parent app (package name) of the app of the subscription to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Required. The unique product ID of the subscription to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProductId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.ArchiveSubscriptionRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "archive";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}:archive";

                /// <summary>Initializes Archive parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "productId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Reads one or more subscriptions.</summary>
            /// <param name="packageName">
            /// Required. The parent app (package name) for which the subscriptions should be retrieved. Must be equal
            /// to the package_name field on all the requests.
            /// </param>
            public virtual BatchGetRequest BatchGet(string packageName)
            {
                return new BatchGetRequest(this.service, packageName);
            }

            /// <summary>Reads one or more subscriptions.</summary>
            public class BatchGetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.BatchGetSubscriptionsResponse>
            {
                /// <summary>Constructs a new BatchGet request.</summary>
                public BatchGetRequest(Google.Apis.Services.IClientService service, string packageName) : base(service)
                {
                    PackageName = packageName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent app (package name) for which the subscriptions should be retrieved. Must be
                /// equal to the package_name field on all the requests.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>
                /// Required. A list of up to 100 subscription product IDs to retrieve. All the IDs must be different.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("productIds", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> ProductIds { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchGet";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions:batchGet";

                /// <summary>Initializes BatchGet parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("productIds", new Google.Apis.Discovery.Parameter
                    {
                        Name = "productIds",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates a batch of subscriptions. Set the latencyTolerance field on nested requests to
            /// PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT to achieve maximum update throughput.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">
            /// Required. The parent app (package name) for which the subscriptions should be updated. Must be equal to
            /// the package_name field on all the Subscription resources.
            /// </param>
            public virtual BatchUpdateRequest BatchUpdate(Google.Apis.AndroidPublisher.v3.Data.BatchUpdateSubscriptionsRequest body, string packageName)
            {
                return new BatchUpdateRequest(this.service, body, packageName);
            }

            /// <summary>
            /// Updates a batch of subscriptions. Set the latencyTolerance field on nested requests to
            /// PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT to achieve maximum update throughput.
            /// </summary>
            public class BatchUpdateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.BatchUpdateSubscriptionsResponse>
            {
                /// <summary>Constructs a new BatchUpdate request.</summary>
                public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.BatchUpdateSubscriptionsRequest body, string packageName) : base(service)
                {
                    PackageName = packageName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent app (package name) for which the subscriptions should be updated. Must be equal
                /// to the package_name field on all the Subscription resources.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.BatchUpdateSubscriptionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchUpdate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions:batchUpdate";

                /// <summary>Initializes BatchUpdate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Creates a new subscription. Newly added base plans will remain in draft state until activated.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">
            /// Required. The parent app (package name) for which the subscription should be created. Must be equal to
            /// the package_name field on the Subscription resource.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.AndroidPublisher.v3.Data.Subscription body, string packageName)
            {
                return new CreateRequest(this.service, body, packageName);
            }

            /// <summary>
            /// Creates a new subscription. Newly added base plans will remain in draft state until activated.
            /// </summary>
            public class CreateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Subscription>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.Subscription body, string packageName) : base(service)
                {
                    PackageName = packageName;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent app (package name) for which the subscription should be created. Must be equal
                /// to the package_name field on the Subscription resource.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>
                /// Required. The ID to use for the subscription. For the requirements on this format, see the
                /// documentation of the product_id field on the Subscription resource.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ProductId { get; set; }

                /// <summary>
                /// Required. A string representing the version of available regions being used for the specified
                /// resource. Regional prices for the resource have to be specified according to the information
                /// published in [this
                /// article](https://support.google.com/googleplay/android-developer/answer/10532353). Each time the
                /// supported locations substantially change, the version will be incremented. Using this field will
                /// ensure that creating and updating the resource with an older region's version and set of regional
                /// prices and currencies will succeed even though a new version is available. The latest version is
                /// 2022/02.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("regionsVersion.version", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RegionsVersionVersion { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.Subscription Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "productId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("regionsVersion.version", new Google.Apis.Discovery.Parameter
                    {
                        Name = "regionsVersion.version",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a subscription. A subscription can only be deleted if it has never had a base plan published.
            /// </summary>
            /// <param name="packageName">
            /// Required. The parent app (package name) of the app of the subscription to delete.
            /// </param>
            /// <param name="productId">Required. The unique product ID of the subscription to delete.</param>
            public virtual DeleteRequest Delete(string packageName, string productId)
            {
                return new DeleteRequest(this.service, packageName, productId);
            }

            /// <summary>
            /// Deletes a subscription. A subscription can only be deleted if it has never had a base plan published.
            /// </summary>
            public class DeleteRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string packageName, string productId) : base(service)
                {
                    PackageName = packageName;
                    ProductId = productId;
                    InitParameters();
                }

                /// <summary>Required. The parent app (package name) of the app of the subscription to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Required. The unique product ID of the subscription to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProductId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "productId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Reads a single subscription.</summary>
            /// <param name="packageName">Required. The parent app (package name) of the subscription to get.</param>
            /// <param name="productId">Required. The unique product ID of the subscription to get.</param>
            public virtual GetRequest Get(string packageName, string productId)
            {
                return new GetRequest(this.service, packageName, productId);
            }

            /// <summary>Reads a single subscription.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Subscription>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, string productId) : base(service)
                {
                    PackageName = packageName;
                    ProductId = productId;
                    InitParameters();
                }

                /// <summary>Required. The parent app (package name) of the subscription to get.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>Required. The unique product ID of the subscription to get.</summary>
                [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProductId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "productId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists all subscriptions under a given app.</summary>
            /// <param name="packageName">
            /// Required. The parent app (package name) for which the subscriptions should be read.
            /// </param>
            public virtual ListRequest List(string packageName)
            {
                return new ListRequest(this.service, packageName);
            }

            /// <summary>Lists all subscriptions under a given app.</summary>
            public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ListSubscriptionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string packageName) : base(service)
                {
                    PackageName = packageName;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent app (package name) for which the subscriptions should be read.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>
                /// The maximum number of subscriptions to return. The service may return fewer than this value. If
                /// unspecified, at most 50 subscriptions will be returned. The maximum value is 1000; values above 1000
                /// will be coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListSubscriptions` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListSubscriptions` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Deprecated: subscription archiving is not supported.</summary>
                [Google.Apis.Util.RequestParameterAttribute("showArchived", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowArchived { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("showArchived", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showArchived",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates an existing subscription.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Immutable. Package name of the parent app.</param>
            /// <param name="productId">
            /// Immutable. Unique product ID of the product. Unique within the parent app. Product IDs must be composed
            /// of lower-case letters (a-z), numbers (0-9), underscores (_) and dots (.). It must start with a
            /// lower-case letter or number, and be between 1 and 40 (inclusive) characters in length.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AndroidPublisher.v3.Data.Subscription body, string packageName, string productId)
            {
                return new PatchRequest(this.service, body, packageName, productId);
            }

            /// <summary>Updates an existing subscription.</summary>
            public class PatchRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Subscription>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.Subscription body, string packageName, string productId) : base(service)
                {
                    PackageName = packageName;
                    ProductId = productId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Immutable. Package name of the parent app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>
                /// Immutable. Unique product ID of the product. Unique within the parent app. Product IDs must be
                /// composed of lower-case letters (a-z), numbers (0-9), underscores (_) and dots (.). It must start
                /// with a lower-case letter or number, and be between 1 and 40 (inclusive) characters in length.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProductId { get; private set; }

                /// <summary>
                /// Optional. If set to true, and the subscription with the given package_name and product_id doesn't
                /// exist, the subscription will be created. If a new subscription is created, update_mask is ignored.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("allowMissing", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> AllowMissing { get; set; }

                /// <summary>
                /// Optional. The latency tolerance for the propagation of this product update. Defaults to
                /// latency-sensitive.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("latencyTolerance", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<LatencyToleranceEnum> LatencyTolerance { get; set; }

                /// <summary>
                /// Optional. The latency tolerance for the propagation of this product update. Defaults to
                /// latency-sensitive.
                /// </summary>
                public enum LatencyToleranceEnum
                {
                    /// <summary>Defaults to PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_SENSITIVE.</summary>
                    [Google.Apis.Util.StringValueAttribute("PRODUCT_UPDATE_LATENCY_TOLERANCE_UNSPECIFIED")]
                    PRODUCTUPDATELATENCYTOLERANCEUNSPECIFIED = 0,

                    /// <summary>
                    /// The update will propagate to clients within several minutes on average and up to a few hours in
                    /// rare cases. Throughput is limited to 7,200 updates per app per hour.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_SENSITIVE")]
                    PRODUCTUPDATELATENCYTOLERANCELATENCYSENSITIVE = 1,

                    /// <summary>
                    /// The update will propagate to clients within 24 hours. Supports high throughput of up to 720,000
                    /// updates per app per hour using batch modification methods.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PRODUCT_UPDATE_LATENCY_TOLERANCE_LATENCY_TOLERANT")]
                    PRODUCTUPDATELATENCYTOLERANCELATENCYTOLERANT = 2,
                }

                /// <summary>
                /// Required. A string representing the version of available regions being used for the specified
                /// resource. Regional prices for the resource have to be specified according to the information
                /// published in [this
                /// article](https://support.google.com/googleplay/android-developer/answer/10532353). Each time the
                /// supported locations substantially change, the version will be incremented. Using this field will
                /// ensure that creating and updating the resource with an older region's version and set of regional
                /// prices and currencies will succeed even though a new version is available. The latest version is
                /// 2022/02.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("regionsVersion.version", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string RegionsVersionVersion { get; set; }

                /// <summary>Required. The list of fields to be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.Subscription Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/subscriptions/{productId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "productId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("allowMissing", new Google.Apis.Discovery.Parameter
                    {
                        Name = "allowMissing",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("latencyTolerance", new Google.Apis.Discovery.Parameter
                    {
                        Name = "latencyTolerance",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("regionsVersion.version", new Google.Apis.Discovery.Parameter
                    {
                        Name = "regionsVersion.version",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>
        /// Calculates the region prices, using today's exchange rate and country-specific pricing patterns, based on
        /// the price in the request for a set of regions.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">Required. The app package name.</param>
        public virtual ConvertRegionPricesRequest ConvertRegionPrices(Google.Apis.AndroidPublisher.v3.Data.ConvertRegionPricesRequest body, string packageName)
        {
            return new ConvertRegionPricesRequest(this.service, body, packageName);
        }

        /// <summary>
        /// Calculates the region prices, using today's exchange rate and country-specific pricing patterns, based on
        /// the price in the request for a set of regions.
        /// </summary>
        public class ConvertRegionPricesRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ConvertRegionPricesResponse>
        {
            /// <summary>Constructs a new ConvertRegionPrices request.</summary>
            public ConvertRegionPricesRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.ConvertRegionPricesRequest body, string packageName) : base(service)
            {
                PackageName = packageName;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The app package name.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.ConvertRegionPricesRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "convertRegionPrices";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/pricing:convertRegionPrices";

            /// <summary>Initializes ConvertRegionPrices parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "orders" collection of methods.</summary>
    public class OrdersResource
    {
        private const string Resource = "orders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrdersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Refunds a user's subscription or in-app purchase order. Orders older than 3 years cannot be refunded.
        /// </summary>
        /// <param name="packageName">
        /// The package name of the application for which this subscription or in-app item was purchased (for example,
        /// 'com.some.thing').
        /// </param>
        /// <param name="orderId">
        /// The order ID provided to the user when the subscription or in-app order was purchased.
        /// </param>
        public virtual RefundRequest Refund(string packageName, string orderId)
        {
            return new RefundRequest(this.service, packageName, orderId);
        }

        /// <summary>
        /// Refunds a user's subscription or in-app purchase order. Orders older than 3 years cannot be refunded.
        /// </summary>
        public class RefundRequest : AndroidPublisherBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Refund request.</summary>
            public RefundRequest(Google.Apis.Services.IClientService service, string packageName, string orderId) : base(service)
            {
                PackageName = packageName;
                OrderId = orderId;
                InitParameters();
            }

            /// <summary>
            /// The package name of the application for which this subscription or in-app item was purchased (for
            /// example, 'com.some.thing').
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>
            /// The order ID provided to the user when the subscription or in-app order was purchased.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orderId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrderId { get; private set; }

            /// <summary>
            /// Whether to revoke the purchased item. If set to true, access to the subscription or in-app item will be
            /// terminated immediately. If the item is a recurring subscription, all future payments will also be
            /// terminated. Consumed in-app items need to be handled by developer's app. (optional).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("revoke", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Revoke { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "refund";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/orders/{orderId}:refund";

            /// <summary>Initializes Refund parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("orderId", new Google.Apis.Discovery.Parameter
                {
                    Name = "orderId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("revoke", new Google.Apis.Discovery.Parameter
                {
                    Name = "revoke",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "purchases" collection of methods.</summary>
    public class PurchasesResource
    {
        private const string Resource = "purchases";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PurchasesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Products = new ProductsResource(service);
            Subscriptions = new SubscriptionsResource(service);
            Subscriptionsv2 = new Subscriptionsv2Resource(service);
            Voidedpurchases = new VoidedpurchasesResource(service);
        }

        /// <summary>Gets the Products resource.</summary>
        public virtual ProductsResource Products { get; }

        /// <summary>The "products" collection of methods.</summary>
        public class ProductsResource
        {
            private const string Resource = "products";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ProductsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Acknowledges a purchase of an inapp item.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">
            /// The package name of the application the inapp product was sold in (for example, 'com.some.thing').
            /// </param>
            /// <param name="productId">The inapp product SKU (for example, 'com.some.thing.inapp1').</param>
            /// <param name="token">
            /// The token provided to the user's device when the inapp product was purchased.
            /// </param>
            public virtual AcknowledgeRequest Acknowledge(Google.Apis.AndroidPublisher.v3.Data.ProductPurchasesAcknowledgeRequest body, string packageName, string productId, string token)
            {
                return new AcknowledgeRequest(this.service, body, packageName, productId, token);
            }

            /// <summary>Acknowledges a purchase of an inapp item.</summary>
            public class AcknowledgeRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Acknowledge request.</summary>
                public AcknowledgeRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.ProductPurchasesAcknowledgeRequest body, string packageName, string productId, string token) : base(service)
                {
                    PackageName = packageName;
                    ProductId = productId;
                    Token = token;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application the inapp product was sold in (for example, 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The inapp product SKU (for example, 'com.some.thing.inapp1').</summary>
                [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProductId { get; private set; }

                /// <summary>The token provided to the user's device when the inapp product was purchased.</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.ProductPurchasesAcknowledgeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "acknowledge";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/products/{productId}/tokens/{token}:acknowledge";

                /// <summary>Initializes Acknowledge parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "productId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Consumes a purchase for an inapp item.</summary>
            /// <param name="packageName">
            /// The package name of the application the inapp product was sold in (for example, 'com.some.thing').
            /// </param>
            /// <param name="productId">The inapp product SKU (for example, 'com.some.thing.inapp1').</param>
            /// <param name="token">
            /// The token provided to the user's device when the inapp product was purchased.
            /// </param>
            public virtual ConsumeRequest Consume(string packageName, string productId, string token)
            {
                return new ConsumeRequest(this.service, packageName, productId, token);
            }

            /// <summary>Consumes a purchase for an inapp item.</summary>
            public class ConsumeRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Consume request.</summary>
                public ConsumeRequest(Google.Apis.Services.IClientService service, string packageName, string productId, string token) : base(service)
                {
                    PackageName = packageName;
                    ProductId = productId;
                    Token = token;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application the inapp product was sold in (for example, 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The inapp product SKU (for example, 'com.some.thing.inapp1').</summary>
                [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProductId { get; private set; }

                /// <summary>The token provided to the user's device when the inapp product was purchased.</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "consume";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/products/{productId}/tokens/{token}:consume";

                /// <summary>Initializes Consume parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "productId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Checks the purchase and consumption status of an inapp item.</summary>
            /// <param name="packageName">
            /// The package name of the application the inapp product was sold in (for example, 'com.some.thing').
            /// </param>
            /// <param name="productId">The inapp product SKU (for example, 'com.some.thing.inapp1').</param>
            /// <param name="token">
            /// The token provided to the user's device when the inapp product was purchased.
            /// </param>
            public virtual GetRequest Get(string packageName, string productId, string token)
            {
                return new GetRequest(this.service, packageName, productId, token);
            }

            /// <summary>Checks the purchase and consumption status of an inapp item.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ProductPurchase>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, string productId, string token) : base(service)
                {
                    PackageName = packageName;
                    ProductId = productId;
                    Token = token;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application the inapp product was sold in (for example, 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The inapp product SKU (for example, 'com.some.thing.inapp1').</summary>
                [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProductId { get; private set; }

                /// <summary>The token provided to the user's device when the inapp product was purchased.</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/products/{productId}/tokens/{token}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("productId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "productId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Subscriptions resource.</summary>
        public virtual SubscriptionsResource Subscriptions { get; }

        /// <summary>The "subscriptions" collection of methods.</summary>
        public class SubscriptionsResource
        {
            private const string Resource = "subscriptions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SubscriptionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Acknowledges a subscription purchase.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">
            /// The package name of the application for which this subscription was purchased (for example,
            /// 'com.some.thing').
            /// </param>
            /// <param name="subscriptionId">The purchased subscription ID (for example, 'monthly001').</param>
            /// <param name="token">The token provided to the user's device when the subscription was purchased.</param>
            public virtual AcknowledgeRequest Acknowledge(Google.Apis.AndroidPublisher.v3.Data.SubscriptionPurchasesAcknowledgeRequest body, string packageName, string subscriptionId, string token)
            {
                return new AcknowledgeRequest(this.service, body, packageName, subscriptionId, token);
            }

            /// <summary>Acknowledges a subscription purchase.</summary>
            public class AcknowledgeRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Acknowledge request.</summary>
                public AcknowledgeRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.SubscriptionPurchasesAcknowledgeRequest body, string packageName, string subscriptionId, string token) : base(service)
                {
                    PackageName = packageName;
                    SubscriptionId = subscriptionId;
                    Token = token;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application for which this subscription was purchased (for example,
                /// 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The purchased subscription ID (for example, 'monthly001').</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SubscriptionId { get; private set; }

                /// <summary>The token provided to the user's device when the subscription was purchased.</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.SubscriptionPurchasesAcknowledgeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "acknowledge";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/subscriptions/{subscriptionId}/tokens/{token}:acknowledge";

                /// <summary>Initializes Acknowledge parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscriptionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Cancels a user's subscription purchase. The subscription remains valid until its expiration time.
            /// </summary>
            /// <param name="packageName">
            /// The package name of the application for which this subscription was purchased (for example,
            /// 'com.some.thing').
            /// </param>
            /// <param name="subscriptionId">The purchased subscription ID (for example, 'monthly001').</param>
            /// <param name="token">The token provided to the user's device when the subscription was purchased.</param>
            public virtual CancelRequest Cancel(string packageName, string subscriptionId, string token)
            {
                return new CancelRequest(this.service, packageName, subscriptionId, token);
            }

            /// <summary>
            /// Cancels a user's subscription purchase. The subscription remains valid until its expiration time.
            /// </summary>
            public class CancelRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Cancel request.</summary>
                public CancelRequest(Google.Apis.Services.IClientService service, string packageName, string subscriptionId, string token) : base(service)
                {
                    PackageName = packageName;
                    SubscriptionId = subscriptionId;
                    Token = token;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application for which this subscription was purchased (for example,
                /// 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The purchased subscription ID (for example, 'monthly001').</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SubscriptionId { get; private set; }

                /// <summary>The token provided to the user's device when the subscription was purchased.</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "cancel";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/subscriptions/{subscriptionId}/tokens/{token}:cancel";

                /// <summary>Initializes Cancel parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscriptionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Defers a user's subscription purchase until a specified future expiration time.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">
            /// The package name of the application for which this subscription was purchased (for example,
            /// 'com.some.thing').
            /// </param>
            /// <param name="subscriptionId">The purchased subscription ID (for example, 'monthly001').</param>
            /// <param name="token">The token provided to the user's device when the subscription was purchased.</param>
            public virtual DeferRequest Defer(Google.Apis.AndroidPublisher.v3.Data.SubscriptionPurchasesDeferRequest body, string packageName, string subscriptionId, string token)
            {
                return new DeferRequest(this.service, body, packageName, subscriptionId, token);
            }

            /// <summary>Defers a user's subscription purchase until a specified future expiration time.</summary>
            public class DeferRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.SubscriptionPurchasesDeferResponse>
            {
                /// <summary>Constructs a new Defer request.</summary>
                public DeferRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.SubscriptionPurchasesDeferRequest body, string packageName, string subscriptionId, string token) : base(service)
                {
                    PackageName = packageName;
                    SubscriptionId = subscriptionId;
                    Token = token;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application for which this subscription was purchased (for example,
                /// 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The purchased subscription ID (for example, 'monthly001').</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SubscriptionId { get; private set; }

                /// <summary>The token provided to the user's device when the subscription was purchased.</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.SubscriptionPurchasesDeferRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "defer";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/subscriptions/{subscriptionId}/tokens/{token}:defer";

                /// <summary>Initializes Defer parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscriptionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Checks whether a user's subscription purchase is valid and returns its expiry time.</summary>
            /// <param name="packageName">
            /// The package name of the application for which this subscription was purchased (for example,
            /// 'com.some.thing').
            /// </param>
            /// <param name="subscriptionId">The purchased subscription ID (for example, 'monthly001').</param>
            /// <param name="token">The token provided to the user's device when the subscription was purchased.</param>
            public virtual GetRequest Get(string packageName, string subscriptionId, string token)
            {
                return new GetRequest(this.service, packageName, subscriptionId, token);
            }

            /// <summary>Checks whether a user's subscription purchase is valid and returns its expiry time.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.SubscriptionPurchase>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, string subscriptionId, string token) : base(service)
                {
                    PackageName = packageName;
                    SubscriptionId = subscriptionId;
                    Token = token;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application for which this subscription was purchased (for example,
                /// 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The purchased subscription ID (for example, 'monthly001').</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SubscriptionId { get; private set; }

                /// <summary>The token provided to the user's device when the subscription was purchased.</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/subscriptions/{subscriptionId}/tokens/{token}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscriptionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Refunds a user's subscription purchase, but the subscription remains valid until its expiration time and
            /// it will continue to recur.
            /// </summary>
            /// <param name="packageName">
            /// The package name of the application for which this subscription was purchased (for example,
            /// 'com.some.thing').
            /// </param>
            /// <param name="subscriptionId">"The purchased subscription ID (for example, 'monthly001').</param>
            /// <param name="token">The token provided to the user's device when the subscription was purchased.</param>
            public virtual RefundRequest Refund(string packageName, string subscriptionId, string token)
            {
                return new RefundRequest(this.service, packageName, subscriptionId, token);
            }

            /// <summary>
            /// Refunds a user's subscription purchase, but the subscription remains valid until its expiration time and
            /// it will continue to recur.
            /// </summary>
            public class RefundRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Refund request.</summary>
                public RefundRequest(Google.Apis.Services.IClientService service, string packageName, string subscriptionId, string token) : base(service)
                {
                    PackageName = packageName;
                    SubscriptionId = subscriptionId;
                    Token = token;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application for which this subscription was purchased (for example,
                /// 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>"The purchased subscription ID (for example, 'monthly001').</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SubscriptionId { get; private set; }

                /// <summary>The token provided to the user's device when the subscription was purchased.</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "refund";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/subscriptions/{subscriptionId}/tokens/{token}:refund";

                /// <summary>Initializes Refund parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscriptionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Refunds and immediately revokes a user's subscription purchase. Access to the subscription will be
            /// terminated immediately and it will stop recurring.
            /// </summary>
            /// <param name="packageName">
            /// The package name of the application for which this subscription was purchased (for example,
            /// 'com.some.thing').
            /// </param>
            /// <param name="subscriptionId">The purchased subscription ID (for example, 'monthly001').</param>
            /// <param name="token">The token provided to the user's device when the subscription was purchased.</param>
            public virtual RevokeRequest Revoke(string packageName, string subscriptionId, string token)
            {
                return new RevokeRequest(this.service, packageName, subscriptionId, token);
            }

            /// <summary>
            /// Refunds and immediately revokes a user's subscription purchase. Access to the subscription will be
            /// terminated immediately and it will stop recurring.
            /// </summary>
            public class RevokeRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Revoke request.</summary>
                public RevokeRequest(Google.Apis.Services.IClientService service, string packageName, string subscriptionId, string token) : base(service)
                {
                    PackageName = packageName;
                    SubscriptionId = subscriptionId;
                    Token = token;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application for which this subscription was purchased (for example,
                /// 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The purchased subscription ID (for example, 'monthly001').</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SubscriptionId { get; private set; }

                /// <summary>The token provided to the user's device when the subscription was purchased.</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "revoke";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/subscriptions/{subscriptionId}/tokens/{token}:revoke";

                /// <summary>Initializes Revoke parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("subscriptionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "subscriptionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Subscriptionsv2 resource.</summary>
        public virtual Subscriptionsv2Resource Subscriptionsv2 { get; }

        /// <summary>The "subscriptionsv2" collection of methods.</summary>
        public class Subscriptionsv2Resource
        {
            private const string Resource = "subscriptionsv2";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public Subscriptionsv2Resource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Get metadata about a subscription</summary>
            /// <param name="packageName">
            /// The package of the application for which this subscription was purchased (for example,
            /// 'com.some.thing').
            /// </param>
            /// <param name="token">
            /// Required. The token provided to the user's device when the subscription was purchased.
            /// </param>
            public virtual GetRequest Get(string packageName, string token)
            {
                return new GetRequest(this.service, packageName, token);
            }

            /// <summary>Get metadata about a subscription</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.SubscriptionPurchaseV2>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, string token) : base(service)
                {
                    PackageName = packageName;
                    Token = token;
                    InitParameters();
                }

                /// <summary>
                /// The package of the application for which this subscription was purchased (for example,
                /// 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>
                /// Required. The token provided to the user's device when the subscription was purchased.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/subscriptionsv2/tokens/{token}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Revoke a subscription purchase for the user.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">
            /// Required. The package of the application for which this subscription was purchased (for example,
            /// 'com.some.thing').
            /// </param>
            /// <param name="token">
            /// Required. The token provided to the user's device when the subscription was purchased.
            /// </param>
            public virtual RevokeRequest Revoke(Google.Apis.AndroidPublisher.v3.Data.RevokeSubscriptionPurchaseRequest body, string packageName, string token)
            {
                return new RevokeRequest(this.service, body, packageName, token);
            }

            /// <summary>Revoke a subscription purchase for the user.</summary>
            public class RevokeRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.RevokeSubscriptionPurchaseResponse>
            {
                /// <summary>Constructs a new Revoke request.</summary>
                public RevokeRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.RevokeSubscriptionPurchaseRequest body, string packageName, string token) : base(service)
                {
                    PackageName = packageName;
                    Token = token;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The package of the application for which this subscription was purchased (for example,
                /// 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>
                /// Required. The token provided to the user's device when the subscription was purchased.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.RevokeSubscriptionPurchaseRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "revoke";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/subscriptionsv2/tokens/{token}:revoke";

                /// <summary>Initializes Revoke parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Voidedpurchases resource.</summary>
        public virtual VoidedpurchasesResource Voidedpurchases { get; }

        /// <summary>The "voidedpurchases" collection of methods.</summary>
        public class VoidedpurchasesResource
        {
            private const string Resource = "voidedpurchases";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public VoidedpurchasesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Lists the purchases that were canceled, refunded or charged-back.</summary>
            /// <param name="packageName">
            /// The package name of the application for which voided purchases need to be returned (for example,
            /// 'com.some.thing').
            /// </param>
            public virtual ListRequest List(string packageName)
            {
                return new ListRequest(this.service, packageName);
            }

            /// <summary>Lists the purchases that were canceled, refunded or charged-back.</summary>
            public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.VoidedPurchasesListResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string packageName) : base(service)
                {
                    PackageName = packageName;
                    InitParameters();
                }

                /// <summary>
                /// The package name of the application for which voided purchases need to be returned (for example,
                /// 'com.some.thing').
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>
                /// The time, in milliseconds since the Epoch, of the newest voided purchase that you want to see in the
                /// response. The value of this parameter cannot be greater than the current time and is ignored if a
                /// pagination token is set. Default value is current time. Note: This filter is applied on the time at
                /// which the record is seen as voided by our systems and not the actual voided time returned in the
                /// response.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("endTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> EndTime { get; set; }

                /// <summary>
                /// Optional. Whether to include voided purchases of quantity-based partial refunds, which are
                /// applicable only to multi-quantity purchases. If true, additional voided purchases may be returned
                /// with voidedQuantity that indicates the refund quantity of a quantity-based partial refund. The
                /// default value is false.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("includeQuantityBasedPartialRefund", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeQuantityBasedPartialRefund { get; set; }

                /// <summary>
                /// Defines how many results the list operation should return. The default number depends on the
                /// resource collection.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults { get; set; }

                /// <summary>
                /// Defines the index of the first element to return. This can only be used if indexed paging is
                /// enabled.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> StartIndex { get; set; }

                /// <summary>
                /// The time, in milliseconds since the Epoch, of the oldest voided purchase that you want to see in the
                /// response. The value of this parameter cannot be older than 30 days and is ignored if a pagination
                /// token is set. Default value is current time minus 30 days. Note: This filter is applied on the time
                /// at which the record is seen as voided by our systems and not the actual voided time returned in the
                /// response.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> StartTime { get; set; }

                /// <summary>
                /// Defines the token of the page to return, usually taken from TokenPagination. This can only be used
                /// if token paging is enabled.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Token { get; set; }

                /// <summary>
                /// The type of voided purchases that you want to see in the response. Possible values are: 0. Only
                /// voided in-app product purchases will be returned in the response. This is the default value. 1. Both
                /// voided in-app purchases and voided subscription purchases will be returned in the response. Note:
                /// Before requesting to receive voided subscription purchases, you must switch to use orderId in the
                /// response which uniquely identifies one-time purchases and subscriptions. Otherwise, you will receive
                /// multiple subscription orders with the same PurchaseToken, because subscription renewal orders share
                /// the same PurchaseToken.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Type { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/purchases/voidedpurchases";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("endTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "endTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("includeQuantityBasedPartialRefund", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeQuantityBasedPartialRefund",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("startIndex", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startIndex",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                    {
                        Name = "token",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("type", new Google.Apis.Discovery.Parameter
                    {
                        Name = "type",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }

    /// <summary>The "reviews" collection of methods.</summary>
    public class ReviewsResource
    {
        private const string Resource = "reviews";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ReviewsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets a single review.</summary>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="reviewId">Unique identifier for a review.</param>
        public virtual GetRequest Get(string packageName, string reviewId)
        {
            return new GetRequest(this.service, packageName, reviewId);
        }

        /// <summary>Gets a single review.</summary>
        public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Review>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string packageName, string reviewId) : base(service)
            {
                PackageName = packageName;
                ReviewId = reviewId;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Unique identifier for a review.</summary>
            [Google.Apis.Util.RequestParameterAttribute("reviewId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ReviewId { get; private set; }

            /// <summary>Language localization code.</summary>
            [Google.Apis.Util.RequestParameterAttribute("translationLanguage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TranslationLanguage { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/reviews/{reviewId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("reviewId", new Google.Apis.Discovery.Parameter
                {
                    Name = "reviewId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("translationLanguage", new Google.Apis.Discovery.Parameter
                {
                    Name = "translationLanguage",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists all reviews.</summary>
        /// <param name="packageName">Package name of the app.</param>
        public virtual ListRequest List(string packageName)
        {
            return new ListRequest(this.service, packageName);
        }

        /// <summary>Lists all reviews.</summary>
        public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ReviewsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string packageName) : base(service)
            {
                PackageName = packageName;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>How many results the list operation should return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>The index of the first element to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> StartIndex { get; set; }

            /// <summary>Pagination token. If empty, list starts at the first review.</summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; set; }

            /// <summary>Language localization code.</summary>
            [Google.Apis.Util.RequestParameterAttribute("translationLanguage", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TranslationLanguage { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/reviews";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startIndex", new Google.Apis.Discovery.Parameter
                {
                    Name = "startIndex",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("translationLanguage", new Google.Apis.Discovery.Parameter
                {
                    Name = "translationLanguage",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Replies to a single review, or updates an existing reply.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="packageName">Package name of the app.</param>
        /// <param name="reviewId">Unique identifier for a review.</param>
        public virtual ReplyRequest Reply(Google.Apis.AndroidPublisher.v3.Data.ReviewsReplyRequest body, string packageName, string reviewId)
        {
            return new ReplyRequest(this.service, body, packageName, reviewId);
        }

        /// <summary>Replies to a single review, or updates an existing reply.</summary>
        public class ReplyRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ReviewsReplyResponse>
        {
            /// <summary>Constructs a new Reply request.</summary>
            public ReplyRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.ReviewsReplyRequest body, string packageName, string reviewId) : base(service)
            {
                PackageName = packageName;
                ReviewId = reviewId;
                Body = body;
                InitParameters();
            }

            /// <summary>Package name of the app.</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName { get; private set; }

            /// <summary>Unique identifier for a review.</summary>
            [Google.Apis.Util.RequestParameterAttribute("reviewId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ReviewId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.ReviewsReplyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "reply";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/applications/{packageName}/reviews/{reviewId}:reply";

            /// <summary>Initializes Reply parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                {
                    Name = "packageName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("reviewId", new Google.Apis.Discovery.Parameter
                {
                    Name = "reviewId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "systemapks" collection of methods.</summary>
    public class SystemapksResource
    {
        private const string Resource = "systemapks";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SystemapksResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Variants = new VariantsResource(service);
        }

        /// <summary>Gets the Variants resource.</summary>
        public virtual VariantsResource Variants { get; }

        /// <summary>The "variants" collection of methods.</summary>
        public class VariantsResource
        {
            private const string Resource = "variants";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public VariantsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates an APK which is suitable for inclusion in a system image from an already uploaded Android App
            /// Bundle.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="versionCode">The version code of the App Bundle.</param>
            public virtual CreateRequest Create(Google.Apis.AndroidPublisher.v3.Data.Variant body, string packageName, long versionCode)
            {
                return new CreateRequest(this.service, body, packageName, versionCode);
            }

            /// <summary>
            /// Creates an APK which is suitable for inclusion in a system image from an already uploaded Android App
            /// Bundle.
            /// </summary>
            public class CreateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Variant>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.Variant body, string packageName, long versionCode) : base(service)
                {
                    PackageName = packageName;
                    VersionCode = versionCode;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The version code of the App Bundle.</summary>
                [Google.Apis.Util.RequestParameterAttribute("versionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long VersionCode { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AndroidPublisher.v3.Data.Variant Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/systemApks/{versionCode}/variants";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("versionCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "versionCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Downloads a previously created system APK which is suitable for inclusion in a system image.
            /// </summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="versionCode">The version code of the App Bundle.</param>
            /// <param name="variantId">The ID of a previously created system APK variant.</param>
            public virtual DownloadRequest Download(string packageName, long versionCode, long variantId)
            {
                return new DownloadRequest(this.service, packageName, versionCode, variantId);
            }

            /// <summary>
            /// Downloads a previously created system APK which is suitable for inclusion in a system image.
            /// </summary>
            public class DownloadRequest : AndroidPublisherBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Download request.</summary>
                public DownloadRequest(Google.Apis.Services.IClientService service, string packageName, long versionCode, long variantId) : base(service)
                {
                    PackageName = packageName;
                    VersionCode = versionCode;
                    VariantId = variantId;
                    MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The version code of the App Bundle.</summary>
                [Google.Apis.Util.RequestParameterAttribute("versionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long VersionCode { get; private set; }

                /// <summary>The ID of a previously created system APK variant.</summary>
                [Google.Apis.Util.RequestParameterAttribute("variantId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long VariantId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "download";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/systemApks/{versionCode}/variants/{variantId}:download";

                /// <summary>Initializes Download parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("versionCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "versionCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("variantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "variantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }

                /// <summary>Gets the media downloader.</summary>
                public Google.Apis.Download.IMediaDownloader MediaDownloader { get; private set; }

                /// <summary>
                /// <para>Synchronously download the media into the given stream.</para>
                /// <para>
                /// Warning: This method hides download errors; use <see cref="DownloadWithStatus(System.IO.Stream)"/>
                /// instead.
                /// </para>
                /// </summary>
                /// <remarks>
                /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
                /// handlers and other configuration may be performed using that property prior to calling this method.
                /// </remarks>
                public virtual void Download(System.IO.Stream stream)
                {
                    var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                    mediaDownloader.Range = null;
                    mediaDownloader.Download(this.GenerateRequestUri(), stream);
                }

                /// <summary>Synchronously download the media into the given stream.</summary>
                /// <remarks>
                /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
                /// handlers and other configuration may be performed using that property prior to calling this method.
                /// </remarks>
                /// <returns>
                /// The final status of the download; including whether the download succeeded or failed.
                /// </returns>
                public virtual Google.Apis.Download.IDownloadProgress DownloadWithStatus(System.IO.Stream stream)
                {
                    var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                    mediaDownloader.Range = null;
                    return mediaDownloader.Download(this.GenerateRequestUri(), stream);
                }

                /// <summary>Asynchronously download the media into the given stream.</summary>
                /// <remarks>
                /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
                /// handlers and other configuration may be performed using that property prior to calling this method.
                /// </remarks>
                public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream)
                {
                    var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                    mediaDownloader.Range = null;
                    return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream);
                }

                /// <summary>Asynchronously download the media into the given stream.</summary>
                /// <remarks>
                /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
                /// handlers and other configuration may be performed using that property prior to calling this method.
                /// </remarks>
                public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream,
                    System.Threading.CancellationToken cancellationToken)
                {
                    var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                    mediaDownloader.Range = null;
                    return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
                }

                /// <summary>Synchronously download a range of the media into the given stream.</summary>
                /// <remarks>
                /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
                /// handlers and other configuration may be performed using that property prior to calling this method.
                /// </remarks>
                public virtual Google.Apis.Download.IDownloadProgress DownloadRange(System.IO.Stream stream, System.Net.Http.Headers.RangeHeaderValue range)
                {
                    var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                    mediaDownloader.Range = range;
                    return mediaDownloader.Download(this.GenerateRequestUri(), stream);
                }

                /// <summary>Asynchronously download a range of the media into the given stream.</summary>
                /// <remarks>
                /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
                /// handlers and other configuration may be performed using that property prior to calling this method.
                /// </remarks>
                public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadRangeAsync(System.IO.Stream stream,
                    System.Net.Http.Headers.RangeHeaderValue range,
                    System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
                {
                    var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                    mediaDownloader.Range = range;
                    return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
                }
            }

            /// <summary>Returns a previously created system APK variant.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="versionCode">The version code of the App Bundle.</param>
            /// <param name="variantId">The ID of a previously created system APK variant.</param>
            public virtual GetRequest Get(string packageName, long versionCode, long variantId)
            {
                return new GetRequest(this.service, packageName, versionCode, variantId);
            }

            /// <summary>Returns a previously created system APK variant.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.Variant>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, long versionCode, long variantId) : base(service)
                {
                    PackageName = packageName;
                    VersionCode = versionCode;
                    VariantId = variantId;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The version code of the App Bundle.</summary>
                [Google.Apis.Util.RequestParameterAttribute("versionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long VersionCode { get; private set; }

                /// <summary>The ID of a previously created system APK variant.</summary>
                [Google.Apis.Util.RequestParameterAttribute("variantId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long VariantId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/systemApks/{versionCode}/variants/{variantId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("versionCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "versionCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("variantId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "variantId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Returns the list of previously created system APK variants.</summary>
            /// <param name="packageName">Package name of the app.</param>
            /// <param name="versionCode">The version code of the App Bundle.</param>
            public virtual ListRequest List(string packageName, long versionCode)
            {
                return new ListRequest(this.service, packageName, versionCode);
            }

            /// <summary>Returns the list of previously created system APK variants.</summary>
            public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.SystemApksListResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string packageName, long versionCode) : base(service)
                {
                    PackageName = packageName;
                    VersionCode = versionCode;
                    InitParameters();
                }

                /// <summary>Package name of the app.</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The version code of the App Bundle.</summary>
                [Google.Apis.Util.RequestParameterAttribute("versionCode", Google.Apis.Util.RequestParameterType.Path)]
                public virtual long VersionCode { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "androidpublisher/v3/applications/{packageName}/systemApks/{versionCode}/variants";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("packageName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "packageName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("versionCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "versionCode",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }

    /// <summary>The "users" collection of methods.</summary>
    public class UsersResource
    {
        private const string Resource = "users";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UsersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Grant access for a user to the given developer account.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">
        /// Required. The developer account to add the user to. Format: developers/{developer}
        /// </param>
        public virtual CreateRequest Create(Google.Apis.AndroidPublisher.v3.Data.User body, string parent)
        {
            return new CreateRequest(this.service, body, parent);
        }

        /// <summary>Grant access for a user to the given developer account.</summary>
        public class CreateRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.User>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.User body, string parent) : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }

            /// <summary>Required. The developer account to add the user to. Format: developers/{developer}</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.User Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/{+parent}/users";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^developers/[^/]+$",
                });
            }
        }

        /// <summary>Removes all access for the user to the given developer account.</summary>
        /// <param name="name">
        /// Required. The name of the user to delete. Format: developers/{developer}/users/{email}
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(this.service, name);
        }

        /// <summary>Removes all access for the user to the given developer account.</summary>
        public class DeleteRequest : AndroidPublisherBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the user to delete. Format: developers/{developer}/users/{email}
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/{+name}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^developers/[^/]+/users/[^/]+$",
                });
            }
        }

        /// <summary>Lists all users with access to a developer account.</summary>
        /// <param name="parent">
        /// Required. The developer account to fetch users from. Format: developers/{developer}
        /// </param>
        public virtual ListRequest List(string parent)
        {
            return new ListRequest(this.service, parent);
        }

        /// <summary>Lists all users with access to a developer account.</summary>
        public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.ListUsersResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
            {
                Parent = parent;
                InitParameters();
            }

            /// <summary>Required. The developer account to fetch users from. Format: developers/{developer}</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>
            /// The maximum number of results to return. This must be set to -1 to disable pagination.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A token received from a previous call to this method, in order to retrieve further results.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/{+parent}/users";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^developers/[^/]+$",
                });
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates access for the user to the developer account.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. Resource name for this user, following the pattern "developers/{developer}/users/{email}".
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.AndroidPublisher.v3.Data.User body, string name)
        {
            return new PatchRequest(this.service, body, name);
        }

        /// <summary>Updates access for the user to the developer account.</summary>
        public class PatchRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v3.Data.User>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AndroidPublisher.v3.Data.User body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name for this user, following the pattern "developers/{developer}/users/{email}".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Optional. The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AndroidPublisher.v3.Data.User Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "androidpublisher/v3/{+name}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^developers/[^/]+/users/[^/]+$",
                });
                RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.AndroidPublisher.v3.Data
{
    /// <summary>Represents an Abi.</summary>
    public class Abi : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Alias for an abi.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alias")]
        public virtual string Alias { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Targeting based on Abi.</summary>
    public class AbiTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Targeting of other sibling directories that were in the Bundle. For main splits this is targeting of other
        /// main splits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternatives")]
        public virtual System.Collections.Generic.IList<Abi> Alternatives { get; set; }

        /// <summary>Value of an abi.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IList<Abi> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a targeting rule of the form: User never had {scope} before.</summary>
    public class AcquisitionTargetingRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The scope of subscriptions this rule considers. Only allows "this subscription" and "any
        /// subscription in app".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual TargetingRuleScope Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ActivateBasePlan.</summary>
    public class ActivateBasePlanRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The unique base plan ID of the base plan to activate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basePlanId")]
        public virtual string BasePlanId { get; set; }

        /// <summary>
        /// Optional. The latency tolerance for the propagation of this product update. Defaults to latency-sensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latencyTolerance")]
        public virtual string LatencyTolerance { get; set; }

        /// <summary>Required. The parent app (package name) of the base plan to activate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>Required. The parent subscription (ID) of the base plan to activate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ActivateSubscriptionOffer.</summary>
    public class ActivateSubscriptionOfferRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The parent base plan (ID) of the offer to activate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basePlanId")]
        public virtual string BasePlanId { get; set; }

        /// <summary>
        /// Optional. The latency tolerance for the propagation of this product update. Defaults to latency-sensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latencyTolerance")]
        public virtual string LatencyTolerance { get; set; }

        /// <summary>Required. The unique offer ID of the offer to activate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerId")]
        public virtual string OfferId { get; set; }

        /// <summary>Required. The parent app (package name) of the offer to activate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>Required. The parent subscription (ID) of the offer to activate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for AddTargeting.</summary>
    public class AddTargetingRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies targeting updates such as regions, android sdk versions etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingUpdate")]
        public virtual TargetingUpdate TargetingUpdate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for AddTargeting.</summary>
    public class AddTargetingResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Object representation to describe all set of users.</summary>
    public class AllUsers : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Set to true if all set of users are needed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAllUsersRequested")]
        public virtual System.Nullable<bool> IsAllUsersRequested { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Android api level targeting data for app recovery action targeting.</summary>
    public class AndroidSdks : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Android api levels of devices targeted by recovery action. See
        /// https://developer.android.com/guide/topics/manifest/uses-sdk-element#ApiLevels for different api levels in
        /// android.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkLevels")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> SdkLevels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about an APK. The resource for ApksService.</summary>
    public class Apk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the binary payload of this APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binary")]
        public virtual ApkBinary Binary { get; set; }

        /// <summary>The version code of the APK, as specified in the manifest file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCode")]
        public virtual System.Nullable<int> VersionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the binary payload of an APK.</summary>
    public class ApkBinary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A sha1 hash of the APK payload, encoded as a hex string and matching the output of the sha1sum command.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1")]
        public virtual string Sha1 { get; set; }

        /// <summary>
        /// A sha256 hash of the APK payload, encoded as a hex string and matching the output of the sha256sum command.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Description of the created apks.</summary>
    public class ApkDescription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set only for asset slices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetSliceMetadata")]
        public virtual SplitApkMetadata AssetSliceMetadata { get; set; }

        /// <summary>Set only for Instant split APKs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instantApkMetadata")]
        public virtual SplitApkMetadata InstantApkMetadata { get; set; }

        /// <summary>
        /// Path of the Apk, will be in the following format: .apk where DownloadId is the ID used to download the apk
        /// using GeneratedApks.Download API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>Set only for Split APKs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("splitApkMetadata")]
        public virtual SplitApkMetadata SplitApkMetadata { get; set; }

        /// <summary>Set only for standalone APKs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standaloneApkMetadata")]
        public virtual StandaloneApkMetadata StandaloneApkMetadata { get; set; }

        /// <summary>Apk-level targeting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targeting")]
        public virtual ApkTargeting Targeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of apks representing a module.</summary>
    public class ApkSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the generated apks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apkDescription")]
        public virtual System.Collections.Generic.IList<ApkDescription> ApkDescription { get; set; }

        /// <summary>Metadata about the module represented by this ApkSet</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleMetadata")]
        public virtual ModuleMetadata ModuleMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a set of apk-level targetings.</summary>
    public class ApkTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The abi that the apk targets</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("abiTargeting")]
        public virtual AbiTargeting AbiTargeting { get; set; }

        /// <summary>The language that the apk targets</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageTargeting")]
        public virtual LanguageTargeting LanguageTargeting { get; set; }

        /// <summary>Multi-api-level targeting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiAbiTargeting")]
        public virtual MultiAbiTargeting MultiAbiTargeting { get; set; }

        /// <summary>The screen density that this apk supports.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenDensityTargeting")]
        public virtual ScreenDensityTargeting ScreenDensityTargeting { get; set; }

        /// <summary>The sdk version that the apk targets</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkVersionTargeting")]
        public virtual SdkVersionTargeting SdkVersionTargeting { get; set; }

        /// <summary>Texture-compression-format-level targeting</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textureCompressionFormatTargeting")]
        public virtual TextureCompressionFormatTargeting TextureCompressionFormatTargeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to create a new externally hosted APK.</summary>
    public class ApksAddExternallyHostedRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The definition of the externally-hosted APK and where it is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externallyHostedApk")]
        public virtual ExternallyHostedApk ExternallyHostedApk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for creating a new externally hosted APK.</summary>
    public class ApksAddExternallyHostedResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The definition of the externally-hosted APK and where it is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externallyHostedApk")]
        public virtual ExternallyHostedApk ExternallyHostedApk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response listing all APKs.</summary>
    public class ApksListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All APKs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apks")]
        public virtual System.Collections.Generic.IList<Apk> Apks { get; set; }

        /// <summary>The kind of this response ("androidpublisher#apksListResponse").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The app details. The resource for DetailsService.</summary>
    public class AppDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user-visible support email for this app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactEmail")]
        public virtual string ContactEmail { get; set; }

        /// <summary>The user-visible support telephone number for this app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactPhone")]
        public virtual string ContactPhone { get; set; }

        /// <summary>The user-visible website for this app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactWebsite")]
        public virtual string ContactWebsite { get; set; }

        /// <summary>Default language code, in BCP 47 format (eg "en-US").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLanguage")]
        public virtual string DefaultLanguage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An app edit. The resource for EditsService.</summary>
    public class AppEdit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The time (as seconds since Epoch) at which the edit will expire and will be no longer valid for
        /// use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiryTimeSeconds")]
        public virtual string ExpiryTimeSeconds { get; set; }

        /// <summary>Output only. Identifier of the edit. Can be used in subsequent API calls.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about an app recovery action.</summary>
    public class AppRecoveryAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID corresponding to the app recovery action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appRecoveryId")]
        public virtual System.Nullable<long> AppRecoveryId { get; set; }

        private string _cancelTimeRaw;

        private object _cancelTime;

        /// <summary>
        /// Timestamp of when the app recovery action is canceled by the developer. Only set if the recovery action has
        /// been canceled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelTime")]
        public virtual string CancelTimeRaw
        {
            get => _cancelTimeRaw;
            set
            {
                _cancelTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _cancelTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CancelTimeDateTimeOffset instead.")]
        public virtual object CancelTime
        {
            get => _cancelTime;
            set
            {
                _cancelTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _cancelTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CancelTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CancelTimeRaw);
            set => CancelTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Timestamp of when the app recovery action is created by the developer. It is always set after creation of
        /// the recovery action.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _deployTimeRaw;

        private object _deployTime;

        /// <summary>
        /// Timestamp of when the app recovery action is deployed to the users. Only set if the recovery action has been
        /// deployed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployTime")]
        public virtual string DeployTimeRaw
        {
            get => _deployTimeRaw;
            set
            {
                _deployTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _deployTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="DeployTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use DeployTimeDateTimeOffset instead.")]
        public virtual object DeployTime
        {
            get => _deployTime;
            set
            {
                _deployTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _deployTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="DeployTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? DeployTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(DeployTimeRaw);
            set => DeployTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _lastUpdateTimeRaw;

        private object _lastUpdateTime;

        /// <summary>
        /// Timestamp of when the developer last updated recovery action. In case the action is cancelled, it
        /// corresponds to cancellation time. It is always set after creation of the recovery action.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual string LastUpdateTimeRaw
        {
            get => _lastUpdateTimeRaw;
            set
            {
                _lastUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastUpdateTimeDateTimeOffset instead.")]
        public virtual object LastUpdateTime
        {
            get => _lastUpdateTime;
            set
            {
                _lastUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LastUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastUpdateTimeRaw);
            set => LastUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Data about the remote in-app update action such as such as recovered user base, recoverable user base etc.
        /// Set only if the recovery action type is Remote In-App Update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteInAppUpdateData")]
        public virtual RemoteInAppUpdateData RemoteInAppUpdateData { get; set; }

        /// <summary>The status of the recovery action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Specifies targeting criteria for the recovery action such as regions, android sdk versions, app versions
        /// etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targeting")]
        public virtual Targeting Targeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data format for a list of app versions.</summary>
    public class AppVersionList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of app version codes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCodes")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> VersionCodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data format for a continuous range of app versions.</summary>
    public class AppVersionRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Highest app version in the range, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCodeEnd")]
        public virtual System.Nullable<long> VersionCodeEnd { get; set; }

        /// <summary>Lowest app version in the range, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCodeStart")]
        public virtual System.Nullable<long> VersionCodeStart { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deprecated: subscription archiving is not supported.</summary>
    public class ArchiveSubscriptionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of an asset module.</summary>
    public class AssetModuleMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates the delivery type for persistent install.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryType")]
        public virtual string DeliveryType { get; set; }

        /// <summary>Module name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of asset slices belonging to a single asset module.</summary>
    public class AssetSliceSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Asset slices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apkDescription")]
        public virtual System.Collections.Generic.IList<ApkDescription> ApkDescription { get; set; }

        /// <summary>Module level metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetModuleMetadata")]
        public virtual AssetModuleMetadata AssetModuleMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a base plan that automatically renews at the end of its subscription period.</summary>
    public class AutoRenewingBasePlanType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Account hold period of the subscription, specified in ISO 8601 format. Acceptable values must be
        /// in days and between P0D and P60D. If not specified, the default value is P30D. The sum of
        /// gracePeriodDuration and accountHoldDuration must be between P30D and P60D days, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountHoldDuration")]
        public virtual string AccountHoldDuration { get; set; }

        /// <summary>
        /// Required. Immutable. Subscription period, specified in ISO 8601 format. For a list of acceptable billing
        /// periods, refer to the help center. The duration is immutable after the base plan is created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingPeriodDuration")]
        public virtual string BillingPeriodDuration { get; set; }

        /// <summary>
        /// Grace period of the subscription, specified in ISO 8601 format. Acceptable values must be in days and
        /// between P0D and the lesser of 30D and base plan billing period. If not specified, a default value will be
        /// used based on the billing period. The sum of gracePeriodDuration and accountHoldDuration must be between
        /// P30D and P60D days, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gracePeriodDuration")]
        public virtual string GracePeriodDuration { get; set; }

        /// <summary>
        /// Whether the renewing base plan is backward compatible. The backward compatible base plan is returned by the
        /// Google Play Billing Library deprecated method querySkuDetailsAsync(). Only one renewing base plan can be
        /// marked as legacy compatible for a given subscription.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legacyCompatible")]
        public virtual System.Nullable<bool> LegacyCompatible { get; set; }

        /// <summary>
        /// Subscription offer id which is legacy compatible. The backward compatible subscription offer is returned by
        /// the Google Play Billing Library deprecated method querySkuDetailsAsync(). Only one subscription offer can be
        /// marked as legacy compatible for a given renewing base plan. To have no Subscription offer as legacy
        /// compatible set this field as empty string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legacyCompatibleSubscriptionOfferId")]
        public virtual string LegacyCompatibleSubscriptionOfferId { get; set; }

        /// <summary>
        /// The proration mode for the base plan determines what happens when a user switches to this plan from another
        /// base plan. If unspecified, defaults to CHARGE_ON_NEXT_BILLING_DATE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prorationMode")]
        public virtual string ProrationMode { get; set; }

        /// <summary>
        /// Whether users should be able to resubscribe to this base plan in Google Play surfaces. Defaults to
        /// RESUBSCRIBE_STATE_ACTIVE if not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resubscribeState")]
        public virtual string ResubscribeState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to an auto renewing plan.</summary>
    public class AutoRenewingPlan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the subscription is currently set to auto-renew, e.g. the user has not canceled the subscription
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoRenewEnabled")]
        public virtual System.Nullable<bool> AutoRenewEnabled { get; set; }

        /// <summary>The installment plan commitment and state related info for the auto renewing plan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installmentDetails")]
        public virtual InstallmentPlan InstallmentDetails { get; set; }

        /// <summary>The information of the last price change for the item since subscription signup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceChangeDetails")]
        public virtual SubscriptionItemPriceChangeDetails PriceChangeDetails { get; set; }

        /// <summary>The current recurring price of the auto renewing plan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recurringPrice")]
        public virtual Money RecurringPrice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single base plan for a subscription.</summary>
    public class BasePlan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set when the base plan automatically renews at a regular interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoRenewingBasePlanType")]
        public virtual AutoRenewingBasePlanType AutoRenewingBasePlanType { get; set; }

        /// <summary>
        /// Required. Immutable. The unique identifier of this base plan. Must be unique within the subscription, and
        /// conform with RFC-1034. That is, this ID can only contain lower-case letters (a-z), numbers (0-9), and
        /// hyphens (-), and be at most 63 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basePlanId")]
        public virtual string BasePlanId { get; set; }

        /// <summary>
        /// Set for installments base plans where a user is committed to a specified number of payments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installmentsBasePlanType")]
        public virtual InstallmentsBasePlanType InstallmentsBasePlanType { get; set; }

        /// <summary>
        /// List of up to 20 custom tags specified for this base plan, and returned to the app through the billing
        /// library. Subscription offers for this base plan will also receive these offer tags in the billing library.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerTags")]
        public virtual System.Collections.Generic.IList<OfferTag> OfferTags { get; set; }

        /// <summary>
        /// Pricing information for any new locations Play may launch in the future. If omitted, the BasePlan will not
        /// be automatically available any new locations Play may launch in the future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherRegionsConfig")]
        public virtual OtherRegionsBasePlanConfig OtherRegionsConfig { get; set; }

        /// <summary>Set when the base plan does not automatically renew at the end of the billing period.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prepaidBasePlanType")]
        public virtual PrepaidBasePlanType PrepaidBasePlanType { get; set; }

        /// <summary>Region-specific information for this base plan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionalConfigs")]
        public virtual System.Collections.Generic.IList<RegionalBasePlanConfig> RegionalConfigs { get; set; }

        /// <summary>
        /// Output only. The state of the base plan, i.e. whether it's active. Draft and inactive base plans can be
        /// activated or deleted. Active base plans can be made inactive. Inactive base plans can be canceled. This
        /// field cannot be changed by updating the resource. Use the dedicated endpoints instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BatchGetSubscriptionOffers endpoint.</summary>
    public class BatchGetSubscriptionOffersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A list of update requests of up to 100 elements. All requests must update different subscriptions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<GetSubscriptionOfferRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchGetSubscriptionOffers endpoint.</summary>
    public class BatchGetSubscriptionOffersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionOffers")]
        public virtual System.Collections.Generic.IList<SubscriptionOffer> SubscriptionOffers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchGetSubscriptions endpoint.</summary>
    public class BatchGetSubscriptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of requested subscriptions, in the same order as the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptions")]
        public virtual System.Collections.Generic.IList<Subscription> Subscriptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BatchMigrateBasePlanPrices.</summary>
    public class BatchMigrateBasePlanPricesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Up to 100 price migration requests. All requests must update different base plans.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<MigrateBasePlanPricesRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchMigrateBasePlanPrices.</summary>
    public class BatchMigrateBasePlanPricesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains one response per requested price migration, in the same order as the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<MigrateBasePlanPricesResponse> Responses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BatchUpdateBasePlanStates.</summary>
    public class BatchUpdateBasePlanStatesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The update request list of up to 100 elements. All requests must update different base plans.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<UpdateBasePlanStateRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchUpdateBasePlanStates.</summary>
    public class BatchUpdateBasePlanStatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of updated subscriptions. This list will match the requests one to one, in the same order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptions")]
        public virtual System.Collections.Generic.IList<Subscription> Subscriptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BatchUpdateSubscriptionOfferStates.</summary>
    public class BatchUpdateSubscriptionOfferStatesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The update request list of up to 100 elements. All requests must update different offers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<UpdateSubscriptionOfferStateRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchUpdateSubscriptionOfferStates.</summary>
    public class BatchUpdateSubscriptionOfferStatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated subscription offers list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionOffers")]
        public virtual System.Collections.Generic.IList<SubscriptionOffer> SubscriptionOffers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BatchUpdateSubscriptionOffers.</summary>
    public class BatchUpdateSubscriptionOffersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A list of update requests of up to 100 elements. All requests must update different subscription
        /// offers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<UpdateSubscriptionOfferRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchUpdateSubscriptionOffers.</summary>
    public class BatchUpdateSubscriptionOffersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated subscription offers list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionOffers")]
        public virtual System.Collections.Generic.IList<SubscriptionOffer> SubscriptionOffers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for BatchUpdateSubscription.</summary>
    public class BatchUpdateSubscriptionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A list of update requests of up to 100 elements. All requests must update different subscriptions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<UpdateSubscriptionRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchUpdateSubscription.</summary>
    public class BatchUpdateSubscriptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated subscriptions list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptions")]
        public virtual System.Collections.Generic.IList<Subscription> Subscriptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about an app bundle. The resource for BundlesService.</summary>
    public class Bundle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A sha1 hash of the upload payload, encoded as a hex string and matching the output of the sha1sum command.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1")]
        public virtual string Sha1 { get; set; }

        /// <summary>
        /// A sha256 hash of the upload payload, encoded as a hex string and matching the output of the sha256sum
        /// command.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        /// <summary>
        /// The version code of the Android App Bundle, as specified in the Android App Bundle's base module APK
        /// manifest file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCode")]
        public virtual System.Nullable<int> VersionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response listing all app bundles.</summary>
    public class BundlesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All app bundles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundles")]
        public virtual System.Collections.Generic.IList<Bundle> Bundles { get; set; }

        /// <summary>The kind of this response ("androidpublisher#bundlesListResponse").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CancelAppRecovery.</summary>
    public class CancelAppRecoveryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for CancelAppRecovery.</summary>
    public class CancelAppRecoveryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result of the cancel survey when the subscription was canceled by the user.</summary>
    public class CancelSurveyResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The reason the user selected in the cancel survey.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; }

        /// <summary>
        /// Only set for CANCEL_SURVEY_REASON_OTHERS. This is the user's freeform response to the survey.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reasonUserInput")]
        public virtual string ReasonUserInput { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information specific to a subscription in the SUBSCRIPTION_STATE_CANCELED or SUBSCRIPTION_STATE_EXPIRED state.
    /// </summary>
    public class CanceledStateContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Subscription was canceled by the developer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerInitiatedCancellation")]
        public virtual DeveloperInitiatedCancellation DeveloperInitiatedCancellation { get; set; }

        /// <summary>Subscription was replaced by a new subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replacementCancellation")]
        public virtual ReplacementCancellation ReplacementCancellation { get; set; }

        /// <summary>Subscription was canceled by the system, for example because of a billing problem.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemInitiatedCancellation")]
        public virtual SystemInitiatedCancellation SystemInitiatedCancellation { get; set; }

        /// <summary>Subscription was canceled by user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInitiatedCancellation")]
        public virtual UserInitiatedCancellation UserInitiatedCancellation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An entry of conversation between user and developer.</summary>
    public class Comment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A comment from a developer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerComment")]
        public virtual DeveloperComment DeveloperComment { get; set; }

        /// <summary>A comment from a user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userComment")]
        public virtual UserComment UserComment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ConvertRegionPrices.</summary>
    public class ConvertRegionPricesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The intital price to convert other regions from. Tax exclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Money Price { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ConvertRegionPrices.</summary>
    public class ConvertRegionPricesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Converted other regions prices in USD and EUR, to use for countries where Play doesn't support a country's
        /// local currency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("convertedOtherRegionsPrice")]
        public virtual ConvertedOtherRegionsPrice ConvertedOtherRegionsPrice { get; set; }

        /// <summary>Map from region code to converted region price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("convertedRegionPrices")]
        public virtual System.Collections.Generic.IDictionary<string, ConvertedRegionPrice> ConvertedRegionPrices { get; set; }

        /// <summary>The region version at which the prices were generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionVersion")]
        public virtual RegionsVersion RegionVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Converted other regions prices.</summary>
    public class ConvertedOtherRegionsPrice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Price in EUR to use for the "Other regions" location exclusive of taxes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eurPrice")]
        public virtual Money EurPrice { get; set; }

        /// <summary>Price in USD to use for the "Other regions" location exclusive of taxes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usdPrice")]
        public virtual Money UsdPrice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A converted region price.</summary>
    public class ConvertedRegionPrice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The converted price tax inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Money Price { get; set; }

        /// <summary>The region code of the region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The tax amount of the converted price.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxAmount")]
        public virtual Money TaxAmount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Country targeting specification.</summary>
    public class CountryTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Countries to target, specified as two letter [CLDR
        /// codes](https://unicode.org/cldr/charts/latest/supplemental/territory_containment_un_m_49.html).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countries")]
        public virtual System.Collections.Generic.IList<string> Countries { get; set; }

        /// <summary>Include "rest of world" as well as explicitly targeted countries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeRestOfWorld")]
        public virtual System.Nullable<bool> IncludeRestOfWorld { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CreateDraftAppRecovery.</summary>
    public class CreateDraftAppRecoveryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Action type is remote in-app update. As a consequence of this action, a downloadable recovery module is also
        /// created for testing purposes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteInAppUpdate")]
        public virtual RemoteInAppUpdate RemoteInAppUpdate { get; set; }

        /// <summary>
        /// Specifies targeting criteria for the recovery action such as regions, android sdk versions, app versions
        /// etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targeting")]
        public virtual Targeting Targeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DeactivateBasePlan.</summary>
    public class DeactivateBasePlanRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The unique base plan ID of the base plan to deactivate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basePlanId")]
        public virtual string BasePlanId { get; set; }

        /// <summary>
        /// Optional. The latency tolerance for the propagation of this product update. Defaults to latency-sensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latencyTolerance")]
        public virtual string LatencyTolerance { get; set; }

        /// <summary>Required. The parent app (package name) of the base plan to deactivate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>Required. The parent subscription (ID) of the base plan to deactivate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DeactivateSubscriptionOffer.</summary>
    public class DeactivateSubscriptionOfferRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The parent base plan (ID) of the offer to deactivate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basePlanId")]
        public virtual string BasePlanId { get; set; }

        /// <summary>
        /// Optional. The latency tolerance for the propagation of this product update. Defaults to latency-sensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latencyTolerance")]
        public virtual string LatencyTolerance { get; set; }

        /// <summary>Required. The unique offer ID of the offer to deactivate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerId")]
        public virtual string OfferId { get; set; }

        /// <summary>Required. The parent app (package name) of the offer to deactivate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>Required. The parent subscription (ID) of the offer to deactivate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to deferred item replacement.</summary>
    public class DeferredItemReplacement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The product_id going to replace the existing product_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a deobfuscation file.</summary>
    public class DeobfuscationFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of the deobfuscation file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("symbolType")]
        public virtual string SymbolType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Responses for the upload.</summary>
    public class DeobfuscationFilesUploadResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The uploaded Deobfuscation File configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deobfuscationFile")]
        public virtual DeobfuscationFile DeobfuscationFile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DeployAppRecovery.</summary>
    public class DeployAppRecoveryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for DeployAppRecovery.</summary>
    public class DeployAppRecoveryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Developer entry from conversation between user and developer.</summary>
    public class DeveloperComment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The last time at which this comment was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModified")]
        public virtual Timestamp LastModified { get; set; }

        /// <summary>The content of the comment, i.e. reply body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information specific to cancellations initiated by developers.</summary>
    public class DeveloperInitiatedCancellation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a device feature.</summary>
    public class DeviceFeature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featureName")]
        public virtual string FeatureName { get; set; }

        /// <summary>
        /// The feature version specified by android:glEsVersion or android:version in in the AndroidManifest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featureVersion")]
        public virtual System.Nullable<int> FeatureVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Targeting for a device feature.</summary>
    public class DeviceFeatureTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Feature of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredFeature")]
        public virtual DeviceFeature RequiredFeature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A group of devices. A group is defined by a set of device selectors. A device belongs to the group if it matches
    /// any selector (logical OR).
    /// </summary>
    public class DeviceGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Device selectors for this group. A device matching any of the selectors is included in this group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceSelectors")]
        public virtual System.Collections.Generic.IList<DeviceSelector> DeviceSelectors { get; set; }

        /// <summary>The name of the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identifier of a device.</summary>
    public class DeviceId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Value of Build.BRAND.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildBrand")]
        public virtual string BuildBrand { get; set; }

        /// <summary>Value of Build.DEVICE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildDevice")]
        public virtual string BuildDevice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Characteristics of the user's device.</summary>
    public class DeviceMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Device CPU make, e.g. "Qualcomm"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuMake")]
        public virtual string CpuMake { get; set; }

        /// <summary>Device CPU model, e.g. "MSM8974"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuModel")]
        public virtual string CpuModel { get; set; }

        /// <summary>Device class (e.g. tablet)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceClass")]
        public virtual string DeviceClass { get; set; }

        /// <summary>OpenGL version</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("glEsVersion")]
        public virtual System.Nullable<int> GlEsVersion { get; set; }

        /// <summary>Device manufacturer (e.g. Motorola)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; }

        /// <summary>Comma separated list of native platforms (e.g. "arm", "arm7")</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nativePlatform")]
        public virtual string NativePlatform { get; set; }

        /// <summary>Device model name (e.g. Droid)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productName")]
        public virtual string ProductName { get; set; }

        /// <summary>Device RAM in Megabytes, e.g. "2048"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ramMb")]
        public virtual System.Nullable<int> RamMb { get; set; }

        /// <summary>Screen density in DPI</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenDensityDpi")]
        public virtual System.Nullable<int> ScreenDensityDpi { get; set; }

        /// <summary>Screen height in pixels</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenHeightPx")]
        public virtual System.Nullable<int> ScreenHeightPx { get; set; }

        /// <summary>Screen width in pixels</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenWidthPx")]
        public virtual System.Nullable<int> ScreenWidthPx { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Conditions about a device's RAM capabilities.</summary>
    public class DeviceRam : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maximum RAM in bytes (bound excluded).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxBytes")]
        public virtual System.Nullable<long> MaxBytes { get; set; }

        /// <summary>Minimum RAM in bytes (bound included).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minBytes")]
        public virtual System.Nullable<long> MinBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Selector for a device group. A selector consists of a set of conditions on the device that should all match
    /// (logical AND) to determine a device group eligibility. For instance, if a selector specifies RAM conditions,
    /// device model inclusion and device model exclusion, a device is considered to match if: device matches RAM
    /// conditions AND device matches one of the included device models AND device doesn't match excluded device models
    /// </summary>
    public class DeviceSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Conditions on the device's RAM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceRam")]
        public virtual DeviceRam DeviceRam { get; set; }

        /// <summary>Device models excluded by this selector, even if they match all other conditions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedDeviceIds")]
        public virtual System.Collections.Generic.IList<DeviceId> ExcludedDeviceIds { get; set; }

        /// <summary>
        /// A device that has any of these system features is excluded by this selector, even if it matches all other
        /// conditions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("forbiddenSystemFeatures")]
        public virtual System.Collections.Generic.IList<SystemFeature> ForbiddenSystemFeatures { get; set; }

        /// <summary>Device models included by this selector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedDeviceIds")]
        public virtual System.Collections.Generic.IList<DeviceId> IncludedDeviceIds { get; set; }

        /// <summary>A device needs to have all these system features to be included by the selector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredSystemFeatures")]
        public virtual System.Collections.Generic.IList<SystemFeature> RequiredSystemFeatures { get; set; }

        /// <summary>Optional. The SoCs included by this selector. Only works for Android S+ devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemOnChips")]
        public virtual System.Collections.Generic.IList<SystemOnChip> SystemOnChips { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The device spec used to generate a system APK.</summary>
    public class DeviceSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Screen dpi.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenDensity")]
        public virtual System.Nullable<long> ScreenDensity { get; set; }

        /// <summary>
        /// Supported ABI architectures in the order of preference. The values should be the string as reported by the
        /// platform, e.g. "armeabi-v7a", "x86_64".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedAbis")]
        public virtual System.Collections.Generic.IList<string> SupportedAbis { get; set; }

        /// <summary>All installed locales represented as BCP-47 strings, e.g. "en-US".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedLocales")]
        public virtual System.Collections.Generic.IList<string> SupportedLocales { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A single device tier. Devices matching any of the device groups in device_group_names are considered to match
    /// the tier.
    /// </summary>
    public class DeviceTier : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Groups of devices included in this tier. These groups must be defined explicitly under device_groups in this
        /// configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceGroupNames")]
        public virtual System.Collections.Generic.IList<string> DeviceGroupNames { get; set; }

        /// <summary>
        /// The priority level of the tier. Tiers are evaluated in descending order of level: the highest level tier has
        /// the highest priority. The highest tier matching a given device is selected for that device. You should use a
        /// contiguous range of levels for your tiers in a tier set; tier levels in a tier set must be unique. For
        /// instance, if your tier set has 4 tiers (including the global fallback), you should define tiers 1, 2 and 3
        /// in this configuration. Note: tier 0 is implicitly defined as a global fallback and selected for devices that
        /// don't match any of the tiers explicitly defined here. You mustn't define level 0 explicitly in this
        /// configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("level")]
        public virtual System.Nullable<int> Level { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration describing device targeting criteria for the content of an app.</summary>
    public class DeviceTierConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Definition of device groups for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceGroups")]
        public virtual System.Collections.Generic.IList<DeviceGroup> DeviceGroups { get; set; }

        /// <summary>Output only. The device tier config ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceTierConfigId")]
        public virtual System.Nullable<long> DeviceTierConfigId { get; set; }

        /// <summary>Definition of the set of device tiers for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceTierSet")]
        public virtual DeviceTierSet DeviceTierSet { get; set; }

        /// <summary>Definition of user country sets for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userCountrySets")]
        public virtual System.Collections.Generic.IList<UserCountrySet> UserCountrySets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A set of device tiers. A tier set determines what variation of app content gets served to a specific device, for
    /// device-targeted content. You should assign a priority level to each tier, which determines the ordering by which
    /// they are evaluated by Play. See the documentation of DeviceTier.level for more details.
    /// </summary>
    public class DeviceTierSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Device tiers belonging to the set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceTiers")]
        public virtual System.Collections.Generic.IList<DeviceTier> DeviceTiers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An expansion file. The resource for ExpansionFilesService.</summary>
    public class ExpansionFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set, this field indicates that this APK has an expansion file uploaded to it: this APK does not reference
        /// another APK's expansion file. The field's value is the size of the uploaded expansion file in bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSize")]
        public virtual System.Nullable<long> FileSize { get; set; }

        /// <summary>
        /// If set, this APK's expansion file references another APK's expansion file. The file_size field will not be
        /// set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referencesVersion")]
        public virtual System.Nullable<int> ReferencesVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for uploading an expansion file.</summary>
    public class ExpansionFilesUploadResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The uploaded expansion file configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expansionFile")]
        public virtual ExpansionFile ExpansionFile { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>User account identifier in the third-party service.</summary>
    public class ExternalAccountIdentifiers : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User account identifier in the third-party service. Only present if account linking happened as part of the
        /// subscription purchase flow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalAccountId")]
        public virtual string ExternalAccountId { get; set; }

        /// <summary>
        /// An obfuscated version of the id that is uniquely associated with the user's account in your app. Present for
        /// the following purchases: * If account linking happened as part of the subscription purchase flow. * It was
        /// specified using
        /// https://developer.android.com/reference/com/android/billingclient/api/BillingFlowParams.Builder#setobfuscatedaccountid
        /// when the purchase was made.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obfuscatedExternalAccountId")]
        public virtual string ObfuscatedExternalAccountId { get; set; }

        /// <summary>
        /// An obfuscated version of the id that is uniquely associated with the user's profile in your app. Only
        /// present if specified using
        /// https://developer.android.com/reference/com/android/billingclient/api/BillingFlowParams.Builder#setobfuscatedprofileid
        /// when the purchase was made.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obfuscatedExternalProfileId")]
        public virtual string ObfuscatedExternalProfileId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of an external subscription.</summary>
    public class ExternalSubscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The type of the external subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionType")]
        public virtual string SubscriptionType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details of an external transaction.</summary>
    public class ExternalTransaction : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time when this transaction was created. This is the time when Google was notified of the
        /// transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The current transaction amount before tax. This represents the current pre-tax amount including
        /// any refunds that may have been applied to this transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentPreTaxAmount")]
        public virtual Price CurrentPreTaxAmount { get; set; }

        /// <summary>
        /// Output only. The current tax amount. This represents the current tax amount including any refunds that may
        /// have been applied to this transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentTaxAmount")]
        public virtual Price CurrentTaxAmount { get; set; }

        /// <summary>
        /// Output only. The id of this transaction. All transaction ids under the same package name must be unique. Set
        /// when creating the external transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalTransactionId")]
        public virtual string ExternalTransactionId { get; set; }

        /// <summary>This is a one-time transaction and not part of a subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneTimeTransaction")]
        public virtual OneTimeExternalTransaction OneTimeTransaction { get; set; }

        /// <summary>
        /// Required. The original transaction amount before taxes. This represents the pre-tax amount originally
        /// notified to Google before any refunds were applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalPreTaxAmount")]
        public virtual Price OriginalPreTaxAmount { get; set; }

        /// <summary>
        /// Required. The original tax amount. This represents the tax amount originally notified to Google before any
        /// refunds were applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalTaxAmount")]
        public virtual Price OriginalTaxAmount { get; set; }

        /// <summary>
        /// Output only. The resource name of the external transaction. The package name of the application the inapp
        /// products were sold (for example, 'com.some.app').
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>This transaction is part of a recurring series of transactions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recurringTransaction")]
        public virtual RecurringExternalTransaction RecurringTransaction { get; set; }

        /// <summary>
        /// Output only. If set, this transaction was a test purchase. Google will not charge for a test transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testPurchase")]
        public virtual ExternalTransactionTestPurchase TestPurchase { get; set; }

        /// <summary>
        /// Optional. The transaction program code, used to help determine service fee for eligible apps participating
        /// in partner programs. Developers participating in the Play Media Experience Program
        /// (https://play.google.com/console/about/programs/mediaprogram/) must provide the program code when reporting
        /// alternative billing transactions. If you are an eligible developer, please contact your BDM for more
        /// information on how to set this field. Note: this field can not be used for external offers transactions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionProgramCode")]
        public virtual System.Nullable<int> TransactionProgramCode { get; set; }

        /// <summary>Output only. The current state of the transaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionState")]
        public virtual string TransactionState { get; set; }

        private string _transactionTimeRaw;

        private object _transactionTime;

        /// <summary>Required. The time when the transaction was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transactionTime")]
        public virtual string TransactionTimeRaw
        {
            get => _transactionTimeRaw;
            set
            {
                _transactionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _transactionTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TransactionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TransactionTimeDateTimeOffset instead.")]
        public virtual object TransactionTime
        {
            get => _transactionTime;
            set
            {
                _transactionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _transactionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="TransactionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TransactionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TransactionTimeRaw);
            set => TransactionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Required. User address for tax computation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userTaxAddress")]
        public virtual ExternalTransactionAddress UserTaxAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>User's address for the external transaction.</summary>
    public class ExternalTransactionAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Top-level administrative subdivision of the country/region. Only required for transactions in
        /// India. Valid values are "ANDAMAN AND NICOBAR ISLANDS", "ANDHRA PRADESH", "ARUNACHAL PRADESH", "ASSAM",
        /// "BIHAR", "CHANDIGARH", "CHHATTISGARH", "DADRA AND NAGAR HAVELI", "DADRA AND NAGAR HAVELI AND DAMAN AND DIU",
        /// "DAMAN AND DIU", "DELHI", "GOA", "GUJARAT", "HARYANA", "HIMACHAL PRADESH", "JAMMU AND KASHMIR", "JHARKHAND",
        /// "KARNATAKA", "KERALA", "LADAKH", "LAKSHADWEEP", "MADHYA PRADESH", "MAHARASHTRA", "MANIPUR", "MEGHALAYA",
        /// "MIZORAM", "NAGALAND", "ODISHA", "PUDUCHERRY", "PUNJAB", "RAJASTHAN", "SIKKIM", "TAMIL NADU", "TELANGANA",
        /// "TRIPURA", "UTTAR PRADESH", "UTTARAKHAND", and "WEST BENGAL".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrativeArea")]
        public virtual string AdministrativeArea { get; set; }

        /// <summary>Required. Two letter region code based on ISO-3166-1 Alpha-2 (UN region codes).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a transaction performed using a test account. These transactions will not be charged by Google.
    /// </summary>
    public class ExternalTransactionTestPurchase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines an APK available for this application that is hosted externally and not uploaded to Google Play. This
    /// function is only available to organizations using Managed Play whose application is configured to restrict
    /// distribution to the organizations.
    /// </summary>
    public class ExternallyHostedApk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The application label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applicationLabel")]
        public virtual string ApplicationLabel { get; set; }

        /// <summary>
        /// A certificate (or array of certificates if a certificate-chain is used) used to sign this APK, represented
        /// as a base64 encoded byte array.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateBase64s")]
        public virtual System.Collections.Generic.IList<string> CertificateBase64s { get; set; }

        /// <summary>The URL at which the APK is hosted. This must be an https URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externallyHostedUrl")]
        public virtual string ExternallyHostedUrl { get; set; }

        /// <summary>The sha1 checksum of this APK, represented as a base64 encoded byte array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSha1Base64")]
        public virtual string FileSha1Base64 { get; set; }

        /// <summary>The sha256 checksum of this APK, represented as a base64 encoded byte array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSha256Base64")]
        public virtual string FileSha256Base64 { get; set; }

        /// <summary>The file size in bytes of this APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSize")]
        public virtual System.Nullable<long> FileSize { get; set; }

        /// <summary>The icon image from the APK, as a base64 encoded byte array.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iconBase64")]
        public virtual string IconBase64 { get; set; }

        /// <summary>The maximum SDK supported by this APK (optional).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumSdk")]
        public virtual System.Nullable<int> MaximumSdk { get; set; }

        /// <summary>The minimum SDK targeted by this APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumSdk")]
        public virtual System.Nullable<int> MinimumSdk { get; set; }

        /// <summary>The native code environments supported by this APK (optional).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nativeCodes")]
        public virtual System.Collections.Generic.IList<string> NativeCodes { get; set; }

        /// <summary>The package name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>The features required by this APK (optional).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usesFeatures")]
        public virtual System.Collections.Generic.IList<string> UsesFeatures { get; set; }

        /// <summary>The permissions requested by this APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usesPermissions")]
        public virtual System.Collections.Generic.IList<UsesPermission> UsesPermissions { get; set; }

        /// <summary>The version code of this APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCode")]
        public virtual System.Nullable<int> VersionCode { get; set; }

        /// <summary>The version name of this APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionName")]
        public virtual string VersionName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A full refund of the remaining amount of a transaction.</summary>
    public class FullRefund : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to list generated APKs.</summary>
    public class GeneratedApksListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All generated APKs, grouped by the APK signing key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generatedApks")]
        public virtual System.Collections.Generic.IList<GeneratedApksPerSigningKey> GeneratedApks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Download metadata for split, standalone and universal APKs, as well as asset pack slices, signed with a given
    /// key.
    /// </summary>
    public class GeneratedApksPerSigningKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>SHA256 hash of the APK signing public key certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateSha256Hash")]
        public virtual string CertificateSha256Hash { get; set; }

        /// <summary>
        /// List of asset pack slices which will be served for this app bundle, signed with a key corresponding to
        /// certificate_sha256_hash.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generatedAssetPackSlices")]
        public virtual System.Collections.Generic.IList<GeneratedAssetPackSlice> GeneratedAssetPackSlices { get; set; }

        /// <summary>
        /// Generated recovery apks for recovery actions signed with a key corresponding to certificate_sha256_hash.
        /// This includes all generated recovery APKs, also those in draft or cancelled state. This field is not set if
        /// no recovery actions were created for this signing key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generatedRecoveryModules")]
        public virtual System.Collections.Generic.IList<GeneratedRecoveryApk> GeneratedRecoveryModules { get; set; }

        /// <summary>List of generated split APKs, signed with a key corresponding to certificate_sha256_hash.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generatedSplitApks")]
        public virtual System.Collections.Generic.IList<GeneratedSplitApk> GeneratedSplitApks { get; set; }

        /// <summary>
        /// List of generated standalone APKs, signed with a key corresponding to certificate_sha256_hash.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generatedStandaloneApks")]
        public virtual System.Collections.Generic.IList<GeneratedStandaloneApk> GeneratedStandaloneApks { get; set; }

        /// <summary>
        /// Generated universal APK, signed with a key corresponding to certificate_sha256_hash. This field is not set
        /// if no universal APK was generated for this signing key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generatedUniversalApk")]
        public virtual GeneratedUniversalApk GeneratedUniversalApk { get; set; }

        /// <summary>Contains targeting information about the generated apks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetingInfo")]
        public virtual TargetingInfo TargetingInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Download metadata for an asset pack slice.</summary>
    public class GeneratedAssetPackSlice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Download ID, which uniquely identifies the APK to download. Should be supplied to `generatedapks.download`
        /// method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadId")]
        public virtual string DownloadId { get; set; }

        /// <summary>Name of the module that this asset slice belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleName")]
        public virtual string ModuleName { get; set; }

        /// <summary>Asset slice ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sliceId")]
        public virtual string SliceId { get; set; }

        /// <summary>Asset module version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Download metadata for an app recovery module.</summary>
    public class GeneratedRecoveryApk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Download ID, which uniquely identifies the APK to download. Should be supplied to `generatedapks.download`
        /// method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadId")]
        public virtual string DownloadId { get; set; }

        /// <summary>Name of the module which recovery apk belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleName")]
        public virtual string ModuleName { get; set; }

        /// <summary>ID of the recovery action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recoveryId")]
        public virtual System.Nullable<long> RecoveryId { get; set; }

        /// <summary>The status of the recovery action corresponding to the recovery apk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recoveryStatus")]
        public virtual string RecoveryStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Download metadata for a split APK.</summary>
    public class GeneratedSplitApk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Download ID, which uniquely identifies the APK to download. Should be supplied to `generatedapks.download`
        /// method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadId")]
        public virtual string DownloadId { get; set; }

        /// <summary>Name of the module that this APK belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleName")]
        public virtual string ModuleName { get; set; }

        /// <summary>Split ID. Empty for the main split of the base module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("splitId")]
        public virtual string SplitId { get; set; }

        /// <summary>ID of the generated variant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variantId")]
        public virtual System.Nullable<int> VariantId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Download metadata for a standalone APK.</summary>
    public class GeneratedStandaloneApk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Download ID, which uniquely identifies the APK to download. Should be supplied to `generatedapks.download`
        /// method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadId")]
        public virtual string DownloadId { get; set; }

        /// <summary>ID of the generated variant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variantId")]
        public virtual System.Nullable<int> VariantId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Download metadata for a universal APK.</summary>
    public class GeneratedUniversalApk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Download ID, which uniquely identifies the APK to download. Should be supplied to `generatedapks.download`
        /// method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadId")]
        public virtual string DownloadId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for GetSubscriptionOffer.</summary>
    public class GetSubscriptionOfferRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The parent base plan (ID) of the offer to get.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basePlanId")]
        public virtual string BasePlanId { get; set; }

        /// <summary>Required. The unique offer ID of the offer to get.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerId")]
        public virtual string OfferId { get; set; }

        /// <summary>Required. The parent app (package name) of the offer to get.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>Required. The parent subscription (ID) of the offer to get.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An access grant resource.</summary>
    public class Grant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The permissions granted to the user for this app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appLevelPermissions")]
        public virtual System.Collections.Generic.IList<string> AppLevelPermissions { get; set; }

        /// <summary>
        /// Required. Resource name for this grant, following the pattern
        /// "developers/{developer}/users/{email}/grants/{package_name}". If this grant is for a draft app, the app ID
        /// will be used in this resource name instead of the package name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Immutable. The package name of the app. This will be empty for draft apps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An uploaded image. The resource for ImagesService.</summary>
    public class Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A unique id representing this image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>A sha1 hash of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha1")]
        public virtual string Sha1 { get; set; }

        /// <summary>A sha256 hash of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        /// <summary>A URL that will serve a preview of the image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for deleting all images.</summary>
    public class ImagesDeleteAllResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The deleted images.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleted")]
        public virtual System.Collections.Generic.IList<Image> Deleted { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response listing all images.</summary>
    public class ImagesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All listed Images.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<Image> Images { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for uploading an image.</summary>
    public class ImagesUploadResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The uploaded image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Image Image { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An in-app product. The resource for InappproductsService.</summary>
    public class InAppProduct : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Default language of the localized data, as defined by BCP-47. e.g. "en-US".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLanguage")]
        public virtual string DefaultLanguage { get; set; }

        /// <summary>
        /// Default price. Cannot be zero, as in-app products are never free. Always in the developer's Checkout
        /// merchant currency.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultPrice")]
        public virtual Price DefaultPrice { get; set; }

        /// <summary>
        /// Grace period of the subscription, specified in ISO 8601 format. Allows developers to give their subscribers
        /// a grace period when the payment for the new recurrence period is declined. Acceptable values are P0D (zero
        /// days), P3D (three days), P7D (seven days), P14D (14 days), and P30D (30 days).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gracePeriod")]
        public virtual string GracePeriod { get; set; }

        /// <summary>
        /// List of localized title and description data. Map key is the language of the localized data, as defined by
        /// BCP-47, e.g. "en-US".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listings")]
        public virtual System.Collections.Generic.IDictionary<string, InAppProductListing> Listings { get; set; }

        /// <summary>Details about taxes and legal compliance. Only applicable to managed products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedProductTaxesAndComplianceSettings")]
        public virtual ManagedProductTaxAndComplianceSettings ManagedProductTaxesAndComplianceSettings { get; set; }

        /// <summary>Package name of the parent app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>
        /// Prices per buyer region. None of these can be zero, as in-app products are never free. Map key is region
        /// code, as defined by ISO 3166-2.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prices")]
        public virtual System.Collections.Generic.IDictionary<string, Price> Prices { get; set; }

        /// <summary>The type of the product, e.g. a recurring subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseType")]
        public virtual string PurchaseType { get; set; }

        /// <summary>Stock-keeping-unit (SKU) of the product, unique within an app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sku")]
        public virtual string Sku { get; set; }

        /// <summary>The status of the product, e.g. whether it's active.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Subscription period, specified in ISO 8601 format. Acceptable values are P1W (one week), P1M (one month),
        /// P3M (three months), P6M (six months), and P1Y (one year).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionPeriod")]
        public virtual string SubscriptionPeriod { get; set; }

        /// <summary>Details about taxes and legal compliance. Only applicable to subscription products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionTaxesAndComplianceSettings")]
        public virtual SubscriptionTaxAndComplianceSettings SubscriptionTaxesAndComplianceSettings { get; set; }

        /// <summary>
        /// Trial period, specified in ISO 8601 format. Acceptable values are anything between P7D (seven days) and
        /// P999D (999 days).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trialPeriod")]
        public virtual string TrialPeriod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Store listing of a single in-app product.</summary>
    public class InAppProductListing : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Localized entitlement benefits for a subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("benefits")]
        public virtual System.Collections.Generic.IList<string> Benefits { get; set; }

        /// <summary>Description for the store listing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Title for the store listing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to delete multiple in-app products.</summary>
    public class InappproductsBatchDeleteRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Individual delete requests. At least one request is required. Can contain up to 100 requests. All requests
        /// must correspond to different in-app products.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<InappproductsDeleteRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for BatchGetSubscriptions endpoint.</summary>
    public class InappproductsBatchGetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of requested in-app products, in the same order as the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inappproduct")]
        public virtual System.Collections.Generic.IList<InAppProduct> Inappproduct { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to update or insert one or more in-app products.</summary>
    public class InappproductsBatchUpdateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Individual update requests. At least one request is required. Can contain up to 100 requests. All
        /// requests must correspond to different in-app products.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<InappproductsUpdateRequest> Requests { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for a batch in-app product update.</summary>
    public class InappproductsBatchUpdateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated or inserted in-app products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inappproducts")]
        public virtual System.Collections.Generic.IList<InAppProduct> Inappproducts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to delete an in-app product.</summary>
    public class InappproductsDeleteRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The latency tolerance for the propagation of this product update. Defaults to latency-sensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latencyTolerance")]
        public virtual string LatencyTolerance { get; set; }

        /// <summary>Package name of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>Unique identifier for the in-app product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sku")]
        public virtual string Sku { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response listing all in-app products.</summary>
    public class InappproductsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All in-app products.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inappproduct")]
        public virtual System.Collections.Generic.IList<InAppProduct> Inappproduct { get; set; }

        /// <summary>The kind of this response ("androidpublisher#inappproductsListResponse").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Deprecated and unset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>Pagination token, to handle a number of products that is over one page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to update an in-app product.</summary>
    public class InappproductsUpdateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If set to true, and the in-app product with the given package_name and sku doesn't exist, the in-app product
        /// will be created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMissing")]
        public virtual System.Nullable<bool> AllowMissing { get; set; }

        /// <summary>
        /// If true the prices for all regions targeted by the parent app that don't have a price specified for this
        /// in-app product will be auto converted to the target currency based on the default price. Defaults to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoConvertMissingPrices")]
        public virtual System.Nullable<bool> AutoConvertMissingPrices { get; set; }

        /// <summary>The new in-app product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inappproduct")]
        public virtual InAppProduct Inappproduct { get; set; }

        /// <summary>
        /// Optional. The latency tolerance for the propagation of this product update. Defaults to latency-sensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latencyTolerance")]
        public virtual string LatencyTolerance { get; set; }

        /// <summary>Package name of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>Unique identifier for the in-app product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sku")]
        public virtual string Sku { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information to a installment plan.</summary>
    public class InstallmentPlan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total number of payments the user is initially committed for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialCommittedPaymentsCount")]
        public virtual System.Nullable<int> InitialCommittedPaymentsCount { get; set; }

        /// <summary>
        /// If present, this installment plan is pending to be canceled. The cancellation will happen only after the
        /// user finished all committed payments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingCancellation")]
        public virtual PendingCancellation PendingCancellation { get; set; }

        /// <summary>Total number of committed payments remaining to be paid for in this renewal cycle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remainingCommittedPaymentsCount")]
        public virtual System.Nullable<int> RemainingCommittedPaymentsCount { get; set; }

        /// <summary>
        /// Total number of payments the user will be committed for after each commitment period. Empty means the
        /// installment plan will fall back to a normal auto-renew subscription after initial commitment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subsequentCommittedPaymentsCount")]
        public virtual System.Nullable<int> SubsequentCommittedPaymentsCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an installments base plan where a user commits to a specified number of payments.</summary>
    public class InstallmentsBasePlanType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Account hold period of the subscription, specified in ISO 8601 format. Acceptable values must be
        /// in days and between P0D and P60D. If not specified, the default value is P30D. The sum of
        /// gracePeriodDuration and accountHoldDuration must be between P30D and P60D days, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountHoldDuration")]
        public virtual string AccountHoldDuration { get; set; }

        /// <summary>
        /// Required. Immutable. Subscription period, specified in ISO 8601 format. For a list of acceptable billing
        /// periods, refer to the help center. The duration is immutable after the base plan is created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingPeriodDuration")]
        public virtual string BillingPeriodDuration { get; set; }

        /// <summary>
        /// Required. Immutable. The number of payments the user is committed to. It is immutable after the base plan is
        /// created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("committedPaymentsCount")]
        public virtual System.Nullable<int> CommittedPaymentsCount { get; set; }

        /// <summary>
        /// Grace period of the subscription, specified in ISO 8601 format. Acceptable values must be in days and
        /// between P0D and the lesser of 30D and base plan billing period. If not specified, a default value will be
        /// used based on the billing period. The sum of gracePeriodDuration and accountHoldDuration must be between
        /// P30D and P60D days, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gracePeriodDuration")]
        public virtual string GracePeriodDuration { get; set; }

        /// <summary>
        /// The proration mode for the base plan determines what happens when a user switches to this plan from another
        /// base plan. If unspecified, defaults to CHARGE_ON_NEXT_BILLING_DATE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prorationMode")]
        public virtual string ProrationMode { get; set; }

        /// <summary>
        /// Required. Immutable. Installments base plan renewal type. Determines the behavior at the end of the initial
        /// commitment. The renewal type is immutable after the base plan is created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("renewalType")]
        public virtual string RenewalType { get; set; }

        /// <summary>
        /// Whether users should be able to resubscribe to this base plan in Google Play surfaces. Defaults to
        /// RESUBSCRIBE_STATE_ACTIVE if not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resubscribeState")]
        public virtual string ResubscribeState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An artifact resource which gets created when uploading an APK or Android App Bundle through internal app
    /// sharing.
    /// </summary>
    public class InternalAppSharingArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The sha256 fingerprint of the certificate used to sign the generated artifact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificateFingerprint")]
        public virtual string CertificateFingerprint { get; set; }

        /// <summary>
        /// The download URL generated for the uploaded artifact. Users that are authorized to download can follow the
        /// link to the Play Store app to install it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("downloadUrl")]
        public virtual string DownloadUrl { get; set; }

        /// <summary>
        /// The sha256 hash of the artifact represented as a lowercase hexadecimal number, matching the output of the
        /// sha256sum command.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains the introductory price information for a subscription.</summary>
    public class IntroductoryPriceInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Introductory price of the subscription, not including tax. The currency is the same as price_currency_code.
        /// Price is expressed in micro-units, where 1,000,000 micro-units represents one unit of the currency. For
        /// example, if the subscription price is €1.99, price_amount_micros is 1990000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("introductoryPriceAmountMicros")]
        public virtual System.Nullable<long> IntroductoryPriceAmountMicros { get; set; }

        /// <summary>
        /// ISO 4217 currency code for the introductory subscription price. For example, if the price is specified in
        /// British pounds sterling, price_currency_code is "GBP".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("introductoryPriceCurrencyCode")]
        public virtual string IntroductoryPriceCurrencyCode { get; set; }

        /// <summary>The number of billing period to offer introductory pricing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("introductoryPriceCycles")]
        public virtual System.Nullable<int> IntroductoryPriceCycles { get; set; }

        /// <summary>
        /// Introductory price period, specified in ISO 8601 format. Common values are (but not limited to) "P1W" (one
        /// week), "P1M" (one month), "P3M" (three months), "P6M" (six months), and "P1Y" (one year).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("introductoryPricePeriod")]
        public virtual string IntroductoryPricePeriod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Targeting based on language.</summary>
    public class LanguageTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Alternative languages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternatives")]
        public virtual System.Collections.Generic.IList<string> Alternatives { get; set; }

        /// <summary>ISO-639: 2 or 3 letter language code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IList<string> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for ListAppRecoveries. -- api-linter: core::0158::response-next-page-token-field=disabled
    /// </summary>
    public class ListAppRecoveriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of recovery actions associated with the requested package name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recoveryActions")]
        public virtual System.Collections.Generic.IList<AppRecoveryAction> RecoveryActions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response listing existing device tier configs.</summary>
    public class ListDeviceTierConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Device tier configs created by the developer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceTierConfigs")]
        public virtual System.Collections.Generic.IList<DeviceTierConfig> DeviceTierConfigs { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListSubscriptionOffers.</summary>
    public class ListSubscriptionOffersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The subscription offers from the specified subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionOffers")]
        public virtual System.Collections.Generic.IList<SubscriptionOffer> SubscriptionOffers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListSubscriptions.</summary>
    public class ListSubscriptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The subscriptions from the specified app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptions")]
        public virtual System.Collections.Generic.IList<Subscription> Subscriptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response containing one or more users with access to an account.</summary>
    public class ListUsersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token to pass to subsequent calls in order to retrieve subsequent results. This will not be set if there
        /// are no more results to return.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The resulting users.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("users")]
        public virtual System.Collections.Generic.IList<User> Users { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A localized store listing. The resource for ListingsService.</summary>
    public class Listing : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Full description of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullDescription")]
        public virtual string FullDescription { get; set; }

        /// <summary>
        /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>Short description of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortDescription")]
        public virtual string ShortDescription { get; set; }

        /// <summary>Localized title of the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>URL of a promotional YouTube video for the app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("video")]
        public virtual string Video { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response listing all localized listings.</summary>
    public class ListingsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The kind of this response ("androidpublisher#listingsListResponse").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>All localized listings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listings")]
        public virtual System.Collections.Generic.IList<Listing> Listings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Localized text in given language.</summary>
    public class LocalizedText : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Language localization code (a BCP-47 language tag; for example, "de-AT" for Austrian German).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; }

        /// <summary>The text in the given language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about taxation and legal compliance for managed products.</summary>
    public class ManagedProductTaxAndComplianceSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Digital content or service classification for products distributed to users in the European Economic Area
        /// (EEA). The withdrawal regime under EEA consumer laws depends on this classification. Refer to the [Help
        /// Center article](https://support.google.com/googleplay/android-developer/answer/10463498) for more
        /// information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eeaWithdrawalRightType")]
        public virtual string EeaWithdrawalRightType { get; set; }

        /// <summary>
        /// Whether this in-app product is declared as a product representing a tokenized digital asset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isTokenizedDigitalAsset")]
        public virtual System.Nullable<bool> IsTokenizedDigitalAsset { get; set; }

        /// <summary>
        /// A mapping from region code to tax rate details. The keys are region codes as defined by Unicode's "CLDR".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxRateInfoByRegionCode")]
        public virtual System.Collections.Generic.IDictionary<string, RegionalTaxRateInfo> TaxRateInfoByRegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for MigrateBasePlanPrices.</summary>
    public class MigrateBasePlanPricesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The unique base plan ID of the base plan to update prices on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basePlanId")]
        public virtual string BasePlanId { get; set; }

        /// <summary>
        /// Optional. The latency tolerance for the propagation of this product update. Defaults to latency-sensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latencyTolerance")]
        public virtual string LatencyTolerance { get; set; }

        /// <summary>
        /// Required. Package name of the parent app. Must be equal to the package_name field on the Subscription
        /// resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>
        /// Required. The ID of the subscription to update. Must be equal to the product_id field on the Subscription
        /// resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>Required. The regional prices to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionalPriceMigrations")]
        public virtual System.Collections.Generic.IList<RegionalPriceMigrationConfig> RegionalPriceMigrations { get; set; }

        /// <summary>
        /// Required. The version of the available regions being used for the regional_price_migrations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionsVersion")]
        public virtual RegionsVersion RegionsVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for MigrateBasePlanPrices.</summary>
    public class MigrateBasePlanPricesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata of a module.</summary>
    public class ModuleMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates the delivery type (e.g. on-demand) of the module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryType")]
        public virtual string DeliveryType { get; set; }

        /// <summary>
        /// Names of the modules that this module directly depends on. Each module implicitly depends on the base
        /// module.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dependencies")]
        public virtual System.Collections.Generic.IList<string> Dependencies { get; set; }

        /// <summary>Indicates the type of this feature module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleType")]
        public virtual string ModuleType { get; set; }

        /// <summary>Module name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The targeting that makes a conditional module installed. Relevant only for Split APKs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targeting")]
        public virtual ModuleTargeting Targeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Targeting on the module level.</summary>
    public class ModuleTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Targeting for device features.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceFeatureTargeting")]
        public virtual System.Collections.Generic.IList<DeviceFeatureTargeting> DeviceFeatureTargeting { get; set; }

        /// <summary>The sdk version that the variant targets</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkVersionTargeting")]
        public virtual SdkVersionTargeting SdkVersionTargeting { get; set; }

        /// <summary>Countries-level targeting</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userCountriesTargeting")]
        public virtual UserCountriesTargeting UserCountriesTargeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an amount of money with its currency type.</summary>
    public class Money : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The three-letter currency code defined in ISO 4217.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>
        /// Number of nano (10^-9) units of the amount. The value must be between -999,999,999 and +999,999,999
        /// inclusive. If `units` is positive, `nanos` must be positive or zero. If `units` is zero, `nanos` can be
        /// positive, zero, or negative. If `units` is negative, `nanos` must be negative or zero. For example $-1.75 is
        /// represented as `units`=-1 and `nanos`=-750,000,000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// The whole units of the amount. For example if `currencyCode` is `"USD"`, then 1 unit is one US dollar.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("units")]
        public virtual System.Nullable<long> Units { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a list of ABIs.</summary>
    public class MultiAbi : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of targeted ABIs, as represented by the Android Platform</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("abi")]
        public virtual System.Collections.Generic.IList<Abi> Abi { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Targeting based on multiple abis.</summary>
    public class MultiAbiTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Targeting of other sibling directories that were in the Bundle. For main splits this is targeting of other
        /// main splits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternatives")]
        public virtual System.Collections.Generic.IList<MultiAbi> Alternatives { get; set; }

        /// <summary>Value of a multi abi.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IList<MultiAbi> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Offer details information related to a purchase line item.</summary>
    public class OfferDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The base plan ID. Present for all base plan and offers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basePlanId")]
        public virtual string BasePlanId { get; set; }

        /// <summary>The offer ID. Only present for discounted offers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerId")]
        public virtual string OfferId { get; set; }

        /// <summary>
        /// The latest offer tags associated with the offer. It includes tags inherited from the base plan.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerTags")]
        public virtual System.Collections.Generic.IList<string> OfferTags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a custom tag specified for a product offer.</summary>
    public class OfferTag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Must conform with RFC-1034. That is, this string can only contain lower-case letters (a-z), numbers (0-9),
        /// and hyphens (-), and be at most 20 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single use promotion code.</summary>
    public class OneTimeCode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a one-time transaction.</summary>
    public class OneTimeExternalTransaction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input only. Provided during the call to Create. Retrieved from the client when the alternative billing flow
        /// is launched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalTransactionToken")]
        public virtual string ExternalTransactionToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details of a recurring external transaction product which doesn't belong to any other more specific category.
    /// </summary>
    public class OtherRecurringProduct : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Pricing information for any new locations Play may launch in.</summary>
    public class OtherRegionsBasePlanConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Price in EUR to use for any new locations Play may launch in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eurPrice")]
        public virtual Money EurPrice { get; set; }

        /// <summary>
        /// Whether the base plan is available for new subscribers in any new locations Play may launch in. If not
        /// specified, this will default to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newSubscriberAvailability")]
        public virtual System.Nullable<bool> NewSubscriberAvailability { get; set; }

        /// <summary>Required. Price in USD to use for any new locations Play may launch in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usdPrice")]
        public virtual Money UsdPrice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for any new locations Play may launch in specified on a subscription offer.</summary>
    public class OtherRegionsSubscriptionOfferConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the subscription offer in any new locations Play may launch in the future. If not specified, this
        /// will default to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherRegionsNewSubscriberAvailability")]
        public virtual System.Nullable<bool> OtherRegionsNewSubscriberAvailability { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for any new locations Play may launch in for a single offer phase.</summary>
    public class OtherRegionsSubscriptionOfferPhaseConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The absolute amount of money subtracted from the base plan price prorated over the phase duration that the
        /// user pays for this offer phase. For example, if the base plan price for this region is $12 for a period of 1
        /// year, then a $1 absolute discount for a phase of a duration of 3 months would correspond to a price of $2.
        /// The resulting price may not be smaller than the minimum price allowed for any new locations Play may launch
        /// in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("absoluteDiscounts")]
        public virtual OtherRegionsSubscriptionOfferPhasePrices AbsoluteDiscounts { get; set; }

        /// <summary>Set to specify this offer is free to obtain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("free")]
        public virtual OtherRegionsSubscriptionOfferPhaseFreePriceOverride Free { get; set; }

        /// <summary>
        /// The absolute price the user pays for this offer phase. The price must not be smaller than the minimum price
        /// allowed for any new locations Play may launch in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherRegionsPrices")]
        public virtual OtherRegionsSubscriptionOfferPhasePrices OtherRegionsPrices { get; set; }

        /// <summary>
        /// The fraction of the base plan price prorated over the phase duration that the user pays for this offer
        /// phase. For example, if the base plan price for this region is $12 for a period of 1 year, then a 50%
        /// discount for a phase of a duration of 3 months would correspond to a price of $1.50. The discount must be
        /// specified as a fraction strictly larger than 0 and strictly smaller than 1. The resulting price will be
        /// rounded to the nearest billable unit (e.g. cents for USD). The relative discount is considered invalid if
        /// the discounted price ends up being smaller than the minimum price allowed in any new locations Play may
        /// launch in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativeDiscount")]
        public virtual System.Nullable<double> RelativeDiscount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the free price override configuration for any new locations Play may launch for a single offer phase.
    /// </summary>
    public class OtherRegionsSubscriptionOfferPhaseFreePriceOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Pricing information for any new locations Play may launch in.</summary>
    public class OtherRegionsSubscriptionOfferPhasePrices : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Price in EUR to use for any new locations Play may launch in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eurPrice")]
        public virtual Money EurPrice { get; set; }

        /// <summary>Required. Price in USD to use for any new locations Play may launch in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usdPrice")]
        public virtual Money UsdPrice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information about the current page. List operations that supports paging return only one "page" of results. This
    /// protocol buffer message describes the page that has been returned.
    /// </summary>
    public class PageInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Maximum number of results returned in one page. ! The number of results included in the API response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resultPerPage")]
        public virtual System.Nullable<int> ResultPerPage { get; set; }

        /// <summary>Index of the first result returned in the current page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>
        /// Total number of results available on the backend ! The total number of results in the result set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A partial refund of a transaction.</summary>
    public class PartialRefund : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A unique id distinguishing this partial refund. If the refund is successful, subsequent refunds
        /// with the same id will fail. Must be unique across refunds for one individual transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refundId")]
        public virtual string RefundId { get; set; }

        /// <summary>
        /// Required. The pre-tax amount of the partial refund. Should be less than the remaining pre-tax amount of the
        /// transaction.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refundPreTaxAmount")]
        public virtual Price RefundPreTaxAmount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information specific to a subscription in paused state.</summary>
    public class PausedStateContext : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _autoResumeTimeRaw;

        private object _autoResumeTime;

        /// <summary>Time at which the subscription will be automatically resumed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoResumeTime")]
        public virtual string AutoResumeTimeRaw
        {
            get => _autoResumeTimeRaw;
            set
            {
                _autoResumeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _autoResumeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="AutoResumeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use AutoResumeTimeDateTimeOffset instead.")]
        public virtual object AutoResumeTime
        {
            get => _autoResumeTime;
            set
            {
                _autoResumeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _autoResumeTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="AutoResumeTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? AutoResumeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(AutoResumeTimeRaw);
            set => AutoResumeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This is an indicator of whether there is a pending cancellation on the virtual installment plan. The
    /// cancellation will happen only after the user finished all committed payments.
    /// </summary>
    public class PendingCancellation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a base plan that does not automatically renew at the end of the base plan, and must be manually
    /// renewed by the user.
    /// </summary>
    public class PrepaidBasePlanType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. Subscription period, specified in ISO 8601 format. For a list of acceptable billing
        /// periods, refer to the help center. The duration is immutable after the base plan is created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingPeriodDuration")]
        public virtual string BillingPeriodDuration { get; set; }

        /// <summary>
        /// Whether users should be able to extend this prepaid base plan in Google Play surfaces. Defaults to
        /// TIME_EXTENSION_ACTIVE if not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeExtension")]
        public virtual string TimeExtension { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to a prepaid plan.</summary>
    public class PrepaidPlan : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _allowExtendAfterTimeRaw;

        private object _allowExtendAfterTime;

        /// <summary>
        /// If present, this is the time after which top up purchases are allowed for the prepaid plan. Will not be
        /// present for expired prepaid plans.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowExtendAfterTime")]
        public virtual string AllowExtendAfterTimeRaw
        {
            get => _allowExtendAfterTimeRaw;
            set
            {
                _allowExtendAfterTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _allowExtendAfterTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="AllowExtendAfterTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use AllowExtendAfterTimeDateTimeOffset instead.")]
        public virtual object AllowExtendAfterTime
        {
            get => _allowExtendAfterTime;
            set
            {
                _allowExtendAfterTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _allowExtendAfterTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="AllowExtendAfterTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? AllowExtendAfterTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(AllowExtendAfterTimeRaw);
            set => AllowExtendAfterTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Definition of a price, i.e. currency and units.</summary>
    public class Price : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// 3 letter Currency code, as defined by ISO 4217. See java/com/google/common/money/CurrencyCode.java
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currency")]
        public virtual string Currency { get; set; }

        /// <summary>Price in 1/million of the currency base unit, represented as a string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceMicros")]
        public virtual string PriceMicros { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A ProductPurchase resource indicates the status of a user's inapp product purchase.</summary>
    public class ProductPurchase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The acknowledgement state of the inapp product. Possible values are: 0. Yet to be acknowledged 1.
        /// Acknowledged
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acknowledgementState")]
        public virtual System.Nullable<int> AcknowledgementState { get; set; }

        /// <summary>
        /// The consumption state of the inapp product. Possible values are: 0. Yet to be consumed 1. Consumed
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumptionState")]
        public virtual System.Nullable<int> ConsumptionState { get; set; }

        /// <summary>A developer-specified string that contains supplemental information about an order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerPayload")]
        public virtual string DeveloperPayload { get; set; }

        /// <summary>This kind represents an inappPurchase object in the androidpublisher service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// An obfuscated version of the id that is uniquely associated with the user's account in your app. Only
        /// present if specified using
        /// https://developer.android.com/reference/com/android/billingclient/api/BillingFlowParams.Builder#setobfuscatedaccountid
        /// when the purchase was made.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obfuscatedExternalAccountId")]
        public virtual string ObfuscatedExternalAccountId { get; set; }

        /// <summary>
        /// An obfuscated version of the id that is uniquely associated with the user's profile in your app. Only
        /// present if specified using
        /// https://developer.android.com/reference/com/android/billingclient/api/BillingFlowParams.Builder#setobfuscatedprofileid
        /// when the purchase was made.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obfuscatedExternalProfileId")]
        public virtual string ObfuscatedExternalProfileId { get; set; }

        /// <summary>The order id associated with the purchase of the inapp product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderId")]
        public virtual string OrderId { get; set; }

        /// <summary>The inapp product SKU. May not be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>The purchase state of the order. Possible values are: 0. Purchased 1. Canceled 2. Pending</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseState")]
        public virtual System.Nullable<int> PurchaseState { get; set; }

        /// <summary>The time the product was purchased, in milliseconds since the epoch (Jan 1, 1970).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseTimeMillis")]
        public virtual System.Nullable<long> PurchaseTimeMillis { get; set; }

        /// <summary>The purchase token generated to identify this purchase. May not be present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseToken")]
        public virtual string PurchaseToken { get; set; }

        /// <summary>
        /// The type of purchase of the inapp product. This field is only set if this purchase was not made using the
        /// standard in-app billing flow. Possible values are: 0. Test (i.e. purchased from a license testing account)
        /// 1. Promo (i.e. purchased using a promo code). Does not include Play Points purchases. 2. Rewarded (i.e. from
        /// watching a video ad instead of paying)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseType")]
        public virtual System.Nullable<int> PurchaseType { get; set; }

        /// <summary>
        /// The quantity associated with the purchase of the inapp product. If not present, the quantity is 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantity")]
        public virtual System.Nullable<int> Quantity { get; set; }

        /// <summary>
        /// The quantity eligible for refund, i.e. quantity that hasn't been refunded. The value reflects quantity-based
        /// partial refunds and full refunds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refundableQuantity")]
        public virtual System.Nullable<int> RefundableQuantity { get; set; }

        /// <summary>ISO 3166-1 alpha-2 billing region code of the user at the time the product was granted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the product.purchases.acknowledge API.</summary>
    public class ProductPurchasesAcknowledgeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Payload to attach to the purchase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerPayload")]
        public virtual string DeveloperPayload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a transaction that is part of a recurring series of payments. This can be a subscription or a
    /// one-time product with multiple payments (such as preorder).
    /// </summary>
    public class RecurringExternalTransaction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details of an external subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalSubscription")]
        public virtual ExternalSubscription ExternalSubscription { get; set; }

        /// <summary>
        /// Input only. Provided during the call to Create. Retrieved from the client when the alternative billing flow
        /// is launched. Required only for the initial purchase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalTransactionToken")]
        public virtual string ExternalTransactionToken { get; set; }

        /// <summary>
        /// The external transaction id of the first transaction of this recurring series of transactions. For example,
        /// for a subscription this would be the transaction id of the first payment. Required when creating recurring
        /// external transactions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialExternalTransactionId")]
        public virtual string InitialExternalTransactionId { get; set; }

        /// <summary>
        /// Input only. Provided during the call to Create. Must only be used when migrating a subscription from manual
        /// monthly reporting to automated reporting.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("migratedTransactionProgram")]
        public virtual string MigratedTransactionProgram { get; set; }

        /// <summary>
        /// Details of a recurring external transaction product which doesn't belong to any other specific category.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherRecurringProduct")]
        public virtual OtherRecurringProduct OtherRecurringProduct { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to refund an existing external transaction.</summary>
    public class RefundExternalTransactionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A full-amount refund.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullRefund")]
        public virtual FullRefund FullRefund { get; set; }

        /// <summary>A partial refund.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partialRefund")]
        public virtual PartialRefund PartialRefund { get; set; }

        private string _refundTimeRaw;

        private object _refundTime;

        /// <summary>Required. The time that the transaction was refunded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refundTime")]
        public virtual string RefundTimeRaw
        {
            get => _refundTimeRaw;
            set
            {
                _refundTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _refundTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RefundTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RefundTimeDateTimeOffset instead.")]
        public virtual object RefundTime
        {
            get => _refundTime;
            set
            {
                _refundTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _refundTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RefundTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RefundTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RefundTimeRaw);
            set => RefundTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a base plan specific to a region.</summary>
    public class RegionalBasePlanConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the base plan in the specified region is available for new subscribers. Existing subscribers will
        /// not have their subscription canceled if this value is set to false. If not specified, this will default to
        /// false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newSubscriberAvailability")]
        public virtual System.Nullable<bool> NewSubscriberAvailability { get; set; }

        /// <summary>
        /// The price of the base plan in the specified region. Must be set if the base plan is available to new
        /// subscribers. Must be set in the currency that is linked to the specified region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Money Price { get; set; }

        /// <summary>Required. Region code this configuration applies to, as defined by ISO 3166-2, e.g. "US".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for migration of a legacy price cohort.</summary>
    public class RegionalPriceMigrationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _oldestAllowedPriceVersionTimeRaw;

        private object _oldestAllowedPriceVersionTime;

        /// <summary>
        /// Required. Subscribers in all legacy price cohorts before this time will be migrated to the current price.
        /// Subscribers in any newer price cohorts are unaffected. Affected subscribers will receive one or more
        /// notifications from Google Play about the price change. Price decreases occur at the subscriber's next
        /// billing date. Price increases occur at the subscriber's next billing date following a notification period
        /// that varies by region and price increase type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldestAllowedPriceVersionTime")]
        public virtual string OldestAllowedPriceVersionTimeRaw
        {
            get => _oldestAllowedPriceVersionTimeRaw;
            set
            {
                _oldestAllowedPriceVersionTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _oldestAllowedPriceVersionTimeRaw = value;
            }
        }

        /// <summary>
        /// <seealso cref="object"/> representation of <see cref="OldestAllowedPriceVersionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use OldestAllowedPriceVersionTimeDateTimeOffset instead.")]
        public virtual object OldestAllowedPriceVersionTime
        {
            get => _oldestAllowedPriceVersionTime;
            set
            {
                _oldestAllowedPriceVersionTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _oldestAllowedPriceVersionTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="OldestAllowedPriceVersionTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? OldestAllowedPriceVersionTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(OldestAllowedPriceVersionTimeRaw);
            set => OldestAllowedPriceVersionTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Optional. The requested type of price increase</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceIncreaseType")]
        public virtual string PriceIncreaseType { get; set; }

        /// <summary>Required. Region code this configuration applies to, as defined by ISO 3166-2, e.g. "US".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a subscription offer in a single region.</summary>
    public class RegionalSubscriptionOfferConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether the subscription offer in the specified region is available for new subscribers. Existing
        /// subscribers will not have their subscription cancelled if this value is set to false. If not specified, this
        /// will default to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newSubscriberAvailability")]
        public virtual System.Nullable<bool> NewSubscriberAvailability { get; set; }

        /// <summary>
        /// Required. Immutable. Region code this configuration applies to, as defined by ISO 3166-2, e.g. "US".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for a single phase of a subscription offer in a single region.</summary>
    public class RegionalSubscriptionOfferPhaseConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The absolute amount of money subtracted from the base plan price prorated over the phase duration that the
        /// user pays for this offer phase. For example, if the base plan price for this region is $12 for a period of 1
        /// year, then a $1 absolute discount for a phase of a duration of 3 months would correspond to a price of $2.
        /// The resulting price may not be smaller than the minimum price allowed for this region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("absoluteDiscount")]
        public virtual Money AbsoluteDiscount { get; set; }

        /// <summary>Set to specify this offer is free to obtain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("free")]
        public virtual RegionalSubscriptionOfferPhaseFreePriceOverride Free { get; set; }

        /// <summary>
        /// The absolute price the user pays for this offer phase. The price must not be smaller than the minimum price
        /// allowed for this region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("price")]
        public virtual Money Price { get; set; }

        /// <summary>Required. Immutable. The region to which this config applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>
        /// The fraction of the base plan price prorated over the phase duration that the user pays for this offer
        /// phase. For example, if the base plan price for this region is $12 for a period of 1 year, then a 50%
        /// discount for a phase of a duration of 3 months would correspond to a price of $1.50. The discount must be
        /// specified as a fraction strictly larger than 0 and strictly smaller than 1. The resulting price will be
        /// rounded to the nearest billable unit (e.g. cents for USD). The relative discount is considered invalid if
        /// the discounted price ends up being smaller than the minimum price allowed in this region.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativeDiscount")]
        public virtual System.Nullable<double> RelativeDiscount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the free price override configuration for a single phase of a subscription offer</summary>
    public class RegionalSubscriptionOfferPhaseFreePriceOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specified details about taxation in a given geographical region.</summary>
    public class RegionalTaxRateInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// You must tell us if your app contains streaming products to correctly charge US state and local sales tax.
        /// Field only supported in the United States.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eligibleForStreamingServiceTaxRate")]
        public virtual System.Nullable<bool> EligibleForStreamingServiceTaxRate { get; set; }

        /// <summary>
        /// To collect communications or amusement taxes in the United States, choose the appropriate tax category.
        /// [Learn more](https://support.google.com/googleplay/android-developer/answer/10463498#streaming_tax).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamingTaxType")]
        public virtual string StreamingTaxType { get; set; }

        /// <summary>
        /// Tax tier to specify reduced tax rate. Developers who sell digital news, magazines, newspapers, books, or
        /// audiobooks in various regions may be eligible for reduced tax rates. [Learn
        /// more](https://support.google.com/googleplay/android-developer/answer/10463498).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxTier")]
        public virtual string TaxTier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Region targeting data for app recovery action targeting.</summary>
    public class Regions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Regions targeted by the recovery action. Region codes are ISO 3166 Alpha-2 country codes. For example, US
        /// stands for United States of America. See https://www.iso.org/iso-3166-country-codes.html for the complete
        /// list of country codes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual System.Collections.Generic.IList<string> RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The version of the available regions being used for the specified resource.</summary>
    public class RegionsVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. A string representing the version of available regions being used for the specified resource.
        /// Regional prices for the resource have to be specified according to the information published in [this
        /// article](https://support.google.com/googleplay/android-developer/answer/10532353). Each time the supported
        /// locations substantially change, the version will be incremented. Using this field will ensure that creating
        /// and updating the resource with an older region's version and set of regional prices and currencies will
        /// succeed even though a new version is available. The latest version is 2022/02.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Object representation for Remote in-app update action type.</summary>
    public class RemoteInAppUpdate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Set to true if Remote In-App Update action type is needed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isRemoteInAppUpdateRequested")]
        public virtual System.Nullable<bool> IsRemoteInAppUpdateRequested { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Data related to Remote In-App Update action such as recovered user count, affected user count etc.
    /// </summary>
    public class RemoteInAppUpdateData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Data related to the recovery action at bundle level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("remoteAppUpdateDataPerBundle")]
        public virtual System.Collections.Generic.IList<RemoteInAppUpdateDataPerBundle> RemoteAppUpdateDataPerBundle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data related to the recovery action at bundle level.</summary>
    public class RemoteInAppUpdateDataPerBundle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total number of devices which have been rescued.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recoveredDeviceCount")]
        public virtual System.Nullable<long> RecoveredDeviceCount { get; set; }

        /// <summary>
        /// Total number of devices affected by this recovery action associated with bundle of the app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDeviceCount")]
        public virtual System.Nullable<long> TotalDeviceCount { get; set; }

        /// <summary>Version Code corresponding to the target bundle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCode")]
        public virtual System.Nullable<long> VersionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information specific to cancellations caused by subscription replacement.</summary>
    public class ReplacementCancellation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Countries where the purchase of this product is restricted to payment methods registered in the same country. If
    /// empty, no payment location restrictions are imposed.
    /// </summary>
    public class RestrictedPaymentCountries : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Region codes to impose payment restrictions on, as defined by ISO 3166-2, e.g. "US".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCodes")]
        public virtual System.Collections.Generic.IList<string> RegionCodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An Android app review.</summary>
    public class Review : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the user who wrote the review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorName")]
        public virtual string AuthorName { get; set; }

        /// <summary>A repeated field containing comments for the review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comments")]
        public virtual System.Collections.Generic.IList<Comment> Comments { get; set; }

        /// <summary>Unique identifier for this review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewId")]
        public virtual string ReviewId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of replying/updating a reply to review.</summary>
    public class ReviewReplyResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which the reply took effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastEdited")]
        public virtual Timestamp LastEdited { get; set; }

        /// <summary>The reply text that was applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replyText")]
        public virtual string ReplyText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response listing reviews.</summary>
    public class ReviewsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about the current page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>List of reviews.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviews")]
        public virtual System.Collections.Generic.IList<Review> Reviews { get; set; }

        /// <summary>Pagination token, to handle a number of products that is over one page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to reply to review or update existing reply.</summary>
    public class ReviewsReplyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The text to set as the reply. Replies of more than approximately 350 characters will be rejected. HTML tags
        /// will be stripped.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replyText")]
        public virtual string ReplyText { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response on status of replying to a review.</summary>
    public class ReviewsReplyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The result of replying/updating a reply to review.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual ReviewReplyResult Result { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Revocation context of the purchases.subscriptionsv2.revoke API.</summary>
    public class RevocationContext : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Used when users should be refunded the full amount of the latest order of the subscription.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullRefund")]
        public virtual RevocationContextFullRefund FullRefund { get; set; }

        /// <summary>
        /// Optional. Used when users should be refunded a prorated amount they paid for their subscription based on the
        /// amount of time remaining in a subscription.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proratedRefund")]
        public virtual RevocationContextProratedRefund ProratedRefund { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Used to determine if the refund type in the RevocationContext is a full refund.</summary>
    public class RevocationContextFullRefund : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Used to determine if the refund type in the RevocationContext is a prorated refund.</summary>
    public class RevocationContextProratedRefund : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the purchases.subscriptionsv2.revoke API.</summary>
    public class RevokeSubscriptionPurchaseRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Additional details around the subscription revocation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revocationContext")]
        public virtual RevocationContext RevocationContext { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the purchases.subscriptionsv2.revoke API.</summary>
    public class RevokeSubscriptionPurchaseResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to update Safety Labels of an app.</summary>
    public class SafetyLabelsUpdateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Contents of the CSV file containing Data Safety responses. For the format of this file, see the
        /// Help Center documentation at
        /// https://support.google.com/googleplay/android-developer/answer/10787469?#zippy=%2Cunderstand-the-csv-format
        /// To download an up to date template, follow the steps at
        /// https://support.google.com/googleplay/android-developer/answer/10787469?#zippy=%2Cexport-to-a-csv-file
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("safetyLabels")]
        public virtual string SafetyLabels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for SafetyLabelsUpdate rpc.</summary>
    public class SafetyLabelsUpdateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a screen density.</summary>
    public class ScreenDensity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Alias for a screen density.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("densityAlias")]
        public virtual string DensityAlias { get; set; }

        /// <summary>Value for density dpi.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("densityDpi")]
        public virtual System.Nullable<int> DensityDpi { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Targeting based on screen density.</summary>
    public class ScreenDensityTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Targeting of other sibling directories that were in the Bundle. For main splits this is targeting of other
        /// main splits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternatives")]
        public virtual System.Collections.Generic.IList<ScreenDensity> Alternatives { get; set; }

        /// <summary>Value of a screen density.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IList<ScreenDensity> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an sdk version.</summary>
    public class SdkVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Inclusive minimum value of an sdk version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual System.Nullable<int> Min { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Targeting based on sdk version.</summary>
    public class SdkVersionTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Targeting of other sibling directories that were in the Bundle. For main splits this is targeting of other
        /// main splits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternatives")]
        public virtual System.Collections.Generic.IList<SdkVersion> Alternatives { get; set; }

        /// <summary>Value of an sdk version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IList<SdkVersion> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The promotion applied on this item when purchased.</summary>
    public class SignupPromotion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A one-time code was applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oneTimeCode")]
        public virtual OneTimeCode OneTimeCode { get; set; }

        /// <summary>A vanity code was applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vanityCode")]
        public virtual VanityCode VanityCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Holds data specific to Split APKs.</summary>
    public class SplitApkMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates whether this APK is the main split of the module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isMasterSplit")]
        public virtual System.Nullable<bool> IsMasterSplit { get; set; }

        /// <summary>Id of the split.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("splitId")]
        public virtual string SplitId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Variant is a group of APKs that covers a part of the device configuration space. APKs from multiple variants are
    /// never combined on one device.
    /// </summary>
    public class SplitApkVariant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set of APKs, one set per module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apkSet")]
        public virtual System.Collections.Generic.IList<ApkSet> ApkSet { get; set; }

        /// <summary>Variant-level targeting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targeting")]
        public virtual VariantTargeting Targeting { get; set; }

        /// <summary>
        /// Number of the variant, starting at 0 (unless overridden). A device will receive APKs from the first variant
        /// that matches the device configuration, with higher variant numbers having priority over lower variant
        /// numbers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variantNumber")]
        public virtual System.Nullable<int> VariantNumber { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Holds data specific to Standalone APKs.</summary>
    public class StandaloneApkMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Names of the modules fused in this standalone APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fusedModuleName")]
        public virtual System.Collections.Generic.IList<string> FusedModuleName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information associated with purchases made with 'Subscribe with Google'.</summary>
    public class SubscribeWithGoogleInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email address of the user when the subscription was purchased.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>The family name of the user when the subscription was purchased.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("familyName")]
        public virtual string FamilyName { get; set; }

        /// <summary>The given name of the user when the subscription was purchased.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("givenName")]
        public virtual string GivenName { get; set; }

        /// <summary>The Google profile id of the user when the subscription was purchased.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileId")]
        public virtual string ProfileId { get; set; }

        /// <summary>The profile name of the user when the subscription was purchased.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileName")]
        public virtual string ProfileName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single subscription for an app.</summary>
    public class Subscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Deprecated: subscription archiving is not supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archived")]
        public virtual System.Nullable<bool> Archived { get; set; }

        /// <summary>
        /// The set of base plans for this subscription. Represents the prices and duration of the subscription if no
        /// other offers apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basePlans")]
        public virtual System.Collections.Generic.IList<BasePlan> BasePlans { get; set; }

        /// <summary>
        /// Required. List of localized listings for this subscription. Must contain at least an entry for the default
        /// language of the parent app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listings")]
        public virtual System.Collections.Generic.IList<SubscriptionListing> Listings { get; set; }

        /// <summary>Immutable. Package name of the parent app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>
        /// Immutable. Unique product ID of the product. Unique within the parent app. Product IDs must be composed of
        /// lower-case letters (a-z), numbers (0-9), underscores (_) and dots (.). It must start with a lower-case
        /// letter or number, and be between 1 and 40 (inclusive) characters in length.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>
        /// Optional. Countries where the purchase of this subscription is restricted to payment methods registered in
        /// the same country. If empty, no payment location restrictions are imposed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedPaymentCountries")]
        public virtual RestrictedPaymentCountries RestrictedPaymentCountries { get; set; }

        /// <summary>Details about taxes and legal compliance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxAndComplianceSettings")]
        public virtual SubscriptionTaxAndComplianceSettings TaxAndComplianceSettings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Information provided by the user when they complete the subscription cancellation flow (cancellation reason
    /// survey).
    /// </summary>
    public class SubscriptionCancelSurveyResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The cancellation reason the user chose in the survey. Possible values are: 0. Other 1. I don't use this
        /// service enough 2. Technical issues 3. Cost-related reasons 4. I found a better app
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelSurveyReason")]
        public virtual System.Nullable<int> CancelSurveyReason { get; set; }

        /// <summary>The customized input cancel reason from the user. Only present when cancelReason is 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInputCancelReason")]
        public virtual string UserInputCancelReason { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A SubscriptionDeferralInfo contains the data needed to defer a subscription purchase to a future expiry time.
    /// </summary>
    public class SubscriptionDeferralInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The desired next expiry time to assign to the subscription, in milliseconds since the Epoch. The given time
        /// must be later/greater than the current expiry time for the subscription.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("desiredExpiryTimeMillis")]
        public virtual System.Nullable<long> DesiredExpiryTimeMillis { get; set; }

        /// <summary>
        /// The expected expiry time for the subscription. If the current expiry time for the subscription is not the
        /// value specified here, the deferral will not occur.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedExpiryTimeMillis")]
        public virtual System.Nullable<long> ExpectedExpiryTimeMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Price change related information of a subscription item.</summary>
    public class SubscriptionItemPriceChangeDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _expectedNewPriceChargeTimeRaw;

        private object _expectedNewPriceChargeTime;

        /// <summary>
        /// The renewal time at which the price change will become effective for the user. This is subject to change(to
        /// a future time) due to cases where the renewal time shifts like pause. This field is only populated if the
        /// price change has not taken effect.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expectedNewPriceChargeTime")]
        public virtual string ExpectedNewPriceChargeTimeRaw
        {
            get => _expectedNewPriceChargeTimeRaw;
            set
            {
                _expectedNewPriceChargeTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expectedNewPriceChargeTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpectedNewPriceChargeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpectedNewPriceChargeTimeDateTimeOffset instead.")]
        public virtual object ExpectedNewPriceChargeTime
        {
            get => _expectedNewPriceChargeTime;
            set
            {
                _expectedNewPriceChargeTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expectedNewPriceChargeTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpectedNewPriceChargeTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpectedNewPriceChargeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpectedNewPriceChargeTimeRaw);
            set => ExpectedNewPriceChargeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>New recurring price for the subscription item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newPrice")]
        public virtual Money NewPrice { get; set; }

        /// <summary>Price change mode specifies how the subscription item price is changing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceChangeMode")]
        public virtual string PriceChangeMode { get; set; }

        /// <summary>State the price change is currently in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceChangeState")]
        public virtual string PriceChangeState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The consumer-visible metadata of a subscription.</summary>
    public class SubscriptionListing : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of benefits shown to the user on platforms such as the Play Store and in restoration flows in the
        /// language of this listing. Plain text. Ordered list of at most four benefits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("benefits")]
        public virtual System.Collections.Generic.IList<string> Benefits { get; set; }

        /// <summary>
        /// The description of this subscription in the language of this listing. Maximum length - 80 characters. Plain
        /// text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Required. The language of this listing, as defined by BCP-47, e.g. "en-US".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>Required. The title of this subscription in the language of this listing. Plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single, temporary offer</summary>
    public class SubscriptionOffer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Immutable. The ID of the base plan to which this offer is an extension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basePlanId")]
        public virtual string BasePlanId { get; set; }

        /// <summary>
        /// Required. Immutable. Unique ID of this subscription offer. Must be unique within the base plan.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerId")]
        public virtual string OfferId { get; set; }

        /// <summary>
        /// List of up to 20 custom tags specified for this offer, and returned to the app through the billing library.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerTags")]
        public virtual System.Collections.Generic.IList<OfferTag> OfferTags { get; set; }

        /// <summary>The configuration for any new locations Play may launch in the future.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherRegionsConfig")]
        public virtual OtherRegionsSubscriptionOfferConfig OtherRegionsConfig { get; set; }

        /// <summary>Required. Immutable. The package name of the app the parent subscription belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>
        /// Required. The phases of this subscription offer. Must contain at least one and at most two entries. Users
        /// will always receive all these phases in the specified order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phases")]
        public virtual System.Collections.Generic.IList<SubscriptionOfferPhase> Phases { get; set; }

        /// <summary>Required. Immutable. The ID of the parent subscription this offer belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>
        /// Required. The region-specific configuration of this offer. Must contain at least one entry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionalConfigs")]
        public virtual System.Collections.Generic.IList<RegionalSubscriptionOfferConfig> RegionalConfigs { get; set; }

        /// <summary>
        /// Output only. The current state of this offer. Can be changed using Activate and Deactivate actions. NB: the
        /// base plan state supersedes this state, so an active offer may not be available if the base plan is not
        /// active.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// The requirements that users need to fulfil to be eligible for this offer. Represents the requirements that
        /// Play will evaluate to decide whether an offer should be returned. Developers may further filter these offers
        /// themselves.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targeting")]
        public virtual SubscriptionOfferTargeting Targeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single phase of a subscription offer.</summary>
    public class SubscriptionOfferPhase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The duration of a single recurrence of this phase. Specified in ISO 8601 format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual string Duration { get; set; }

        /// <summary>Pricing information for any new locations Play may launch in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherRegionsConfig")]
        public virtual OtherRegionsSubscriptionOfferPhaseConfig OtherRegionsConfig { get; set; }

        /// <summary>
        /// Required. The number of times this phase repeats. If this offer phase is not free, each recurrence charges
        /// the user the price of this offer phase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recurrenceCount")]
        public virtual System.Nullable<int> RecurrenceCount { get; set; }

        /// <summary>
        /// Required. The region-specific configuration of this offer phase. This list must contain exactly one entry
        /// for each region for which the subscription offer has a regional config.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionalConfigs")]
        public virtual System.Collections.Generic.IList<RegionalSubscriptionOfferPhaseConfig> RegionalConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines the rule a user needs to satisfy to receive this offer.</summary>
    public class SubscriptionOfferTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Offer targeting rule for new user acquisition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acquisitionRule")]
        public virtual AcquisitionTargetingRule AcquisitionRule { get; set; }

        /// <summary>Offer targeting rule for upgrading users' existing plans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upgradeRule")]
        public virtual UpgradeTargetingRule UpgradeRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains the price change information for a subscription that can be used to control the user journey for the
    /// price change in the app. This can be in the form of seeking confirmation from the user or tailoring the
    /// experience for a successful conversion.
    /// </summary>
    public class SubscriptionPriceChange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The new price the subscription will renew with if the price change is accepted by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newPrice")]
        public virtual Price NewPrice { get; set; }

        /// <summary>
        /// The current state of the price change. Possible values are: 0. Outstanding: State for a pending price change
        /// waiting for the user to agree. In this state, you can optionally seek confirmation from the user using the
        /// In-App API. 1. Accepted: State for an accepted price change that the subscription will renew with unless
        /// it's canceled. The price change takes effect on a future date when the subscription renews. Note that the
        /// change might not occur when the subscription is renewed next.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual System.Nullable<int> State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A SubscriptionPurchase resource indicates the status of a user's subscription purchase.</summary>
    public class SubscriptionPurchase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The acknowledgement state of the subscription product. Possible values are: 0. Yet to be acknowledged 1.
        /// Acknowledged
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acknowledgementState")]
        public virtual System.Nullable<int> AcknowledgementState { get; set; }

        /// <summary>
        /// Whether the subscription will automatically be renewed when it reaches its current expiry time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoRenewing")]
        public virtual System.Nullable<bool> AutoRenewing { get; set; }

        /// <summary>
        /// Time at which the subscription will be automatically resumed, in milliseconds since the Epoch. Only present
        /// if the user has requested to pause the subscription.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoResumeTimeMillis")]
        public virtual System.Nullable<long> AutoResumeTimeMillis { get; set; }

        /// <summary>
        /// The reason why a subscription was canceled or is not auto-renewing. Possible values are: 0. User canceled
        /// the subscription 1. Subscription was canceled by the system, for example because of a billing problem 2.
        /// Subscription was replaced with a new subscription 3. Subscription was canceled by the developer
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelReason")]
        public virtual System.Nullable<int> CancelReason { get; set; }

        /// <summary>
        /// Information provided by the user when they complete the subscription cancellation flow (cancellation reason
        /// survey).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelSurveyResult")]
        public virtual SubscriptionCancelSurveyResult CancelSurveyResult { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 billing country/region code of the user at the time the subscription was granted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>A developer-specified string that contains supplemental information about an order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerPayload")]
        public virtual string DeveloperPayload { get; set; }

        /// <summary>
        /// The email address of the user when the subscription was purchased. Only present for purchases made with
        /// 'Subscribe with Google'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>Time at which the subscription will expire, in milliseconds since the Epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiryTimeMillis")]
        public virtual System.Nullable<long> ExpiryTimeMillis { get; set; }

        /// <summary>
        /// User account identifier in the third-party service. Only present if account linking happened as part of the
        /// subscription purchase flow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalAccountId")]
        public virtual string ExternalAccountId { get; set; }

        /// <summary>
        /// The family name of the user when the subscription was purchased. Only present for purchases made with
        /// 'Subscribe with Google'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("familyName")]
        public virtual string FamilyName { get; set; }

        /// <summary>
        /// The given name of the user when the subscription was purchased. Only present for purchases made with
        /// 'Subscribe with Google'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("givenName")]
        public virtual string GivenName { get; set; }

        /// <summary>
        /// Introductory price information of the subscription. This is only present when the subscription was purchased
        /// with an introductory price. This field does not indicate the subscription is currently in introductory price
        /// period.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("introductoryPriceInfo")]
        public virtual IntroductoryPriceInfo IntroductoryPriceInfo { get; set; }

        /// <summary>This kind represents a subscriptionPurchase object in the androidpublisher service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The purchase token of the originating purchase if this subscription is one of the following: 0. Re-signup of
        /// a canceled but non-lapsed subscription 1. Upgrade/downgrade from a previous subscription For example,
        /// suppose a user originally signs up and you receive purchase token X, then the user cancels and goes through
        /// the resignup flow (before their subscription lapses) and you receive purchase token Y, and finally the user
        /// upgrades their subscription and you receive purchase token Z. If you call this API with purchase token Z,
        /// this field will be set to Y. If you call this API with purchase token Y, this field will be set to X. If you
        /// call this API with purchase token X, this field will not be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedPurchaseToken")]
        public virtual string LinkedPurchaseToken { get; set; }

        /// <summary>
        /// An obfuscated version of the id that is uniquely associated with the user's account in your app. Present for
        /// the following purchases: * If account linking happened as part of the subscription purchase flow. * It was
        /// specified using
        /// https://developer.android.com/reference/com/android/billingclient/api/BillingFlowParams.Builder#setobfuscatedaccountid
        /// when the purchase was made.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obfuscatedExternalAccountId")]
        public virtual string ObfuscatedExternalAccountId { get; set; }

        /// <summary>
        /// An obfuscated version of the id that is uniquely associated with the user's profile in your app. Only
        /// present if specified using
        /// https://developer.android.com/reference/com/android/billingclient/api/BillingFlowParams.Builder#setobfuscatedprofileid
        /// when the purchase was made.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("obfuscatedExternalProfileId")]
        public virtual string ObfuscatedExternalProfileId { get; set; }

        /// <summary>
        /// The order id of the latest recurring order associated with the purchase of the subscription. If the
        /// subscription was canceled because payment was declined, this will be the order id from the payment declined
        /// order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderId")]
        public virtual string OrderId { get; set; }

        /// <summary>
        /// The payment state of the subscription. Possible values are: 0. Payment pending 1. Payment received 2. Free
        /// trial 3. Pending deferred upgrade/downgrade Not present for canceled, expired subscriptions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paymentState")]
        public virtual System.Nullable<int> PaymentState { get; set; }

        /// <summary>
        /// Price of the subscription, For tax exclusive countries, the price doesn't include tax. For tax inclusive
        /// countries, the price includes tax. Price is expressed in micro-units, where 1,000,000 micro-units represents
        /// one unit of the currency. For example, if the subscription price is €1.99, price_amount_micros is 1990000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceAmountMicros")]
        public virtual System.Nullable<long> PriceAmountMicros { get; set; }

        /// <summary>
        /// The latest price change information available. This is present only when there is an upcoming price change
        /// for the subscription yet to be applied. Once the subscription renews with the new price or the subscription
        /// is canceled, no price change information will be returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceChange")]
        public virtual SubscriptionPriceChange PriceChange { get; set; }

        /// <summary>
        /// ISO 4217 currency code for the subscription price. For example, if the price is specified in British pounds
        /// sterling, price_currency_code is "GBP".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priceCurrencyCode")]
        public virtual string PriceCurrencyCode { get; set; }

        /// <summary>
        /// The Google profile id of the user when the subscription was purchased. Only present for purchases made with
        /// 'Subscribe with Google'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileId")]
        public virtual string ProfileId { get; set; }

        /// <summary>
        /// The profile name of the user when the subscription was purchased. Only present for purchases made with
        /// 'Subscribe with Google'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileName")]
        public virtual string ProfileName { get; set; }

        /// <summary>
        /// The promotion code applied on this purchase. This field is only set if a vanity code promotion is applied
        /// when the subscription was purchased.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionCode")]
        public virtual string PromotionCode { get; set; }

        /// <summary>
        /// The type of promotion applied on this purchase. This field is only set if a promotion is applied when the
        /// subscription was purchased. Possible values are: 0. One time code 1. Vanity code
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionType")]
        public virtual System.Nullable<int> PromotionType { get; set; }

        /// <summary>
        /// The type of purchase of the subscription. This field is only set if this purchase was not made using the
        /// standard in-app billing flow. Possible values are: 0. Test (i.e. purchased from a license testing account)
        /// 1. Promo (i.e. purchased using a promo code)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseType")]
        public virtual System.Nullable<int> PurchaseType { get; set; }

        /// <summary>Time at which the subscription was granted, in milliseconds since the Epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeMillis")]
        public virtual System.Nullable<long> StartTimeMillis { get; set; }

        /// <summary>
        /// The time at which the subscription was canceled by the user, in milliseconds since the epoch. Only present
        /// if cancelReason is 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userCancellationTimeMillis")]
        public virtual System.Nullable<long> UserCancellationTimeMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Item-level info for a subscription purchase.</summary>
    public class SubscriptionPurchaseLineItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The item is auto renewing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoRenewingPlan")]
        public virtual AutoRenewingPlan AutoRenewingPlan { get; set; }

        /// <summary>Information for deferred item replacement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deferredItemReplacement")]
        public virtual DeferredItemReplacement DeferredItemReplacement { get; set; }

        private string _expiryTimeRaw;

        private object _expiryTime;

        /// <summary>
        /// Time at which the subscription expired or will expire unless the access is extended (ex. renews).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiryTime")]
        public virtual string ExpiryTimeRaw
        {
            get => _expiryTimeRaw;
            set
            {
                _expiryTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expiryTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpiryTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpiryTimeDateTimeOffset instead.")]
        public virtual object ExpiryTime
        {
            get => _expiryTime;
            set
            {
                _expiryTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expiryTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpiryTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpiryTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpiryTimeRaw);
            set => ExpiryTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The offer details for this item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offerDetails")]
        public virtual OfferDetails OfferDetails { get; set; }

        /// <summary>The item is prepaid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prepaidPlan")]
        public virtual PrepaidPlan PrepaidPlan { get; set; }

        /// <summary>The purchased product ID (for example, 'monthly001').</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productId")]
        public virtual string ProductId { get; set; }

        /// <summary>Promotion details about this item. Only set if a promotion was applied during signup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signupPromotion")]
        public virtual SignupPromotion SignupPromotion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Indicates the status of a user's subscription purchase.</summary>
    public class SubscriptionPurchaseV2 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The acknowledgement state of the subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acknowledgementState")]
        public virtual string AcknowledgementState { get; set; }

        /// <summary>
        /// Additional context around canceled subscriptions. Only present if the subscription currently has
        /// subscription_state SUBSCRIPTION_STATE_CANCELED or SUBSCRIPTION_STATE_EXPIRED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canceledStateContext")]
        public virtual CanceledStateContext CanceledStateContext { get; set; }

        /// <summary>User account identifier in the third-party service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalAccountIdentifiers")]
        public virtual ExternalAccountIdentifiers ExternalAccountIdentifiers { get; set; }

        /// <summary>This kind represents a SubscriptionPurchaseV2 object in the androidpublisher service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The order id of the latest order associated with the purchase of the subscription. For autoRenewing
        /// subscription, this is the order id of signup order if it is not renewed yet, or the last recurring order id
        /// (success, pending, or declined order). For prepaid subscription, this is the order id associated with the
        /// queried purchase token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestOrderId")]
        public virtual string LatestOrderId { get; set; }

        /// <summary>
        /// Item-level info for a subscription purchase. The items in the same purchase should be either all with
        /// AutoRenewingPlan or all with PrepaidPlan.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineItems")]
        public virtual System.Collections.Generic.IList<SubscriptionPurchaseLineItem> LineItems { get; set; }

        /// <summary>
        /// The purchase token of the old subscription if this subscription is one of the following: * Re-signup of a
        /// canceled but non-lapsed subscription * Upgrade/downgrade from a previous subscription. * Convert from
        /// prepaid to auto renewing subscription. * Convert from an auto renewing subscription to prepaid. * Topup a
        /// prepaid subscription.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkedPurchaseToken")]
        public virtual string LinkedPurchaseToken { get; set; }

        /// <summary>
        /// Additional context around paused subscriptions. Only present if the subscription currently has
        /// subscription_state SUBSCRIPTION_STATE_PAUSED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pausedStateContext")]
        public virtual PausedStateContext PausedStateContext { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 billing country/region code of the user at the time the subscription was granted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>
        /// Time at which the subscription was granted. Not set for pending subscriptions (subscription was created but
        /// awaiting payment during signup).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTimeRaw
        {
            get => _startTimeRaw;
            set
            {
                _startTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _startTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
        public virtual object StartTime
        {
            get => _startTime;
            set
            {
                _startTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _startTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>User profile associated with purchases made with 'Subscribe with Google'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscribeWithGoogleInfo")]
        public virtual SubscribeWithGoogleInfo SubscribeWithGoogleInfo { get; set; }

        /// <summary>The current state of the subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionState")]
        public virtual string SubscriptionState { get; set; }

        /// <summary>Only present if this subscription purchase is a test purchase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("testPurchase")]
        public virtual TestPurchase TestPurchase { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the purchases.subscriptions.acknowledge API.</summary>
    public class SubscriptionPurchasesAcknowledgeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Payload to attach to the purchase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerPayload")]
        public virtual string DeveloperPayload { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for the purchases.subscriptions.defer API.</summary>
    public class SubscriptionPurchasesDeferRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The information about the new desired expiry time for the subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deferralInfo")]
        public virtual SubscriptionDeferralInfo DeferralInfo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the purchases.subscriptions.defer API.</summary>
    public class SubscriptionPurchasesDeferResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The new expiry time for the subscription in milliseconds since the Epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newExpiryTimeMillis")]
        public virtual System.Nullable<long> NewExpiryTimeMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about taxation, Google Play policy and legal compliance for subscription products.</summary>
    public class SubscriptionTaxAndComplianceSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Digital content or service classification for products distributed to users in the European Economic Area
        /// (EEA). The withdrawal regime under EEA consumer laws depends on this classification. Refer to the [Help
        /// Center article](https://support.google.com/googleplay/android-developer/answer/10463498) for more
        /// information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eeaWithdrawalRightType")]
        public virtual string EeaWithdrawalRightType { get; set; }

        /// <summary>
        /// Whether this subscription is declared as a product representing a tokenized digital asset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isTokenizedDigitalAsset")]
        public virtual System.Nullable<bool> IsTokenizedDigitalAsset { get; set; }

        /// <summary>
        /// A mapping from region code to tax rate details. The keys are region codes as defined by Unicode's "CLDR".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("taxRateInfoByRegionCode")]
        public virtual System.Collections.Generic.IDictionary<string, RegionalTaxRateInfo> TaxRateInfoByRegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options for system APKs.</summary>
    public class SystemApkOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether to use the rotated key for signing the system APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rotated")]
        public virtual System.Nullable<bool> Rotated { get; set; }

        /// <summary>Whether system APK was generated with uncompressed dex files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uncompressedDexFiles")]
        public virtual System.Nullable<bool> UncompressedDexFiles { get; set; }

        /// <summary>Whether system APK was generated with uncompressed native libraries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uncompressedNativeLibraries")]
        public virtual System.Nullable<bool> UncompressedNativeLibraries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to list previously created system APK variants.</summary>
    public class SystemApksListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All system APK variants created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variants")]
        public virtual System.Collections.Generic.IList<Variant> Variants { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a system feature.</summary>
    public class SystemFeature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information specific to cancellations initiated by Google system.</summary>
    public class SystemInitiatedCancellation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Representation of a System-on-Chip (SoC) of an Android device. Can be used to target S+ devices.
    /// </summary>
    public class SystemOnChip : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The designer of the SoC, eg. "Google" Value of build property "ro.soc.manufacturer"
        /// https://developer.android.com/reference/android/os/Build#SOC_MANUFACTURER Required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; }

        /// <summary>
        /// Required. The model of the SoC, eg. "Tensor" Value of build property "ro.soc.model"
        /// https://developer.android.com/reference/android/os/Build#SOC_MODEL Required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Targeting details for a recovery action such as regions, android sdk levels, app versions etc.
    /// </summary>
    public class Targeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All users are targeted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allUsers")]
        public virtual AllUsers AllUsers { get; set; }

        /// <summary>Targeting is based on android api levels of devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidSdks")]
        public virtual AndroidSdks AndroidSdks { get; set; }

        /// <summary>Targeting is based on the user account region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual Regions Regions { get; set; }

        /// <summary>Target version codes as a list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionList")]
        public virtual AppVersionList VersionList { get; set; }

        /// <summary>Target version codes as a range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionRange")]
        public virtual AppVersionRange VersionRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Targeting information about the generated apks.</summary>
    public class TargetingInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of created asset slices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetSliceSet")]
        public virtual System.Collections.Generic.IList<AssetSliceSet> AssetSliceSet { get; set; }

        /// <summary>The package name of this app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>List of the created variants.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variant")]
        public virtual System.Collections.Generic.IList<SplitApkVariant> Variant { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the scope of subscriptions which a targeting rule can match to target offers to users based on past or
    /// current entitlement.
    /// </summary>
    public class TargetingRuleScope : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The scope of the current targeting rule is any subscription in the parent app.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anySubscriptionInApp")]
        public virtual TargetingRuleScopeAnySubscriptionInApp AnySubscriptionInApp { get; set; }

        /// <summary>
        /// The scope of the current targeting rule is the subscription with the specified subscription ID. Must be a
        /// subscription within the same parent app.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specificSubscriptionInApp")]
        public virtual string SpecificSubscriptionInApp { get; set; }

        /// <summary>
        /// The scope of the current targeting rule is the subscription in which this offer is defined.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thisSubscription")]
        public virtual TargetingRuleScopeThisSubscription ThisSubscription { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents the targeting rule scope corresponding to any subscription in the parent app.</summary>
    public class TargetingRuleScopeAnySubscriptionInApp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the targeting rule scope corresponding to the subscriptions in which this offer is defined.
    /// </summary>
    public class TargetingRuleScopeThisSubscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Update type for targeting. Note it is always a subset Targeting.</summary>
    public class TargetingUpdate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All users are targeted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allUsers")]
        public virtual AllUsers AllUsers { get; set; }

        /// <summary>Additional android sdk levels are targeted by the recovery action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidSdks")]
        public virtual AndroidSdks AndroidSdks { get; set; }

        /// <summary>Additional regions are targeted by the recovery action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual Regions Regions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Whether this subscription purchase is a test purchase.</summary>
    public class TestPurchase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The testers of an app. The resource for TestersService. Note: while it is possible in the Play Console UI to add
    /// testers via email lists, email lists are not supported by this resource.
    /// </summary>
    public class Testers : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All testing Google Groups, as email addresses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("googleGroups")]
        public virtual System.Collections.Generic.IList<string> GoogleGroups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents texture compression format.</summary>
    public class TextureCompressionFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Alias for texture compression format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alias")]
        public virtual string Alias { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Targeting by a texture compression format.</summary>
    public class TextureCompressionFormatTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of alternative TCFs (TCFs targeted by the sibling splits).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternatives")]
        public virtual System.Collections.Generic.IList<TextureCompressionFormat> Alternatives { get; set; }

        /// <summary>The list of targeted TCFs. Should not be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IList<TextureCompressionFormat> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Timestamp represents a point in time independent of any time zone or local calendar, encoded as a count of
    /// seconds and fractions of seconds at nanosecond resolution. The count is relative to an epoch at UTC midnight on
    /// January 1, 1970.
    /// </summary>
    public class Timestamp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Non-negative fractions of a second at nanosecond resolution. Must be from 0 to 999,999,999 inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>Represents seconds of UTC time since Unix epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<long> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Pagination information returned by a List operation when token pagination is enabled. List operations that
    /// supports paging return only one "page" of results. This protocol buffer message describes the page that has been
    /// returned. When using token pagination, clients should use the next/previous token to get another page of the
    /// result. The presence or absence of next/previous token indicates whether a next/previous page is available and
    /// provides a mean of accessing this page. ListRequest.page_token should be set to either next_page_token or
    /// previous_page_token to access another page.
    /// </summary>
    public class TokenPagination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Tokens to pass to the standard list field 'page_token'. Whenever available, tokens are preferred over
        /// manipulating start_index.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("previousPageToken")]
        public virtual string PreviousPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A track configuration. The resource for TracksService.</summary>
    public class Track : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// In a read request, represents all active releases in the track. In an update request, represents desired
        /// changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releases")]
        public virtual System.Collections.Generic.IList<TrackRelease> Releases { get; set; }

        /// <summary>
        /// Identifier of the track. Form factor tracks have a special prefix as an identifier, for example
        /// `wear:production`, `automotive:production`. [More on track
        /// name](https://developers.google.com/android-publisher/tracks#ff-track-name)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("track")]
        public virtual string TrackValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configurations of the new track.</summary>
    public class TrackConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Form factor of the new track. Defaults to the default track.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formFactor")]
        public virtual string FormFactor { get; set; }

        /// <summary>
        /// Required. Identifier of the new track. For default tracks, this field consists of the track alias only. Form
        /// factor tracks have a special prefix as an identifier, for example `wear:production`,
        /// `automotive:production`. This prefix must match the value of the `form_factor` field, if it is not a default
        /// track. [More on track name](https://developers.google.com/android-publisher/tracks#ff-track-name)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("track")]
        public virtual string Track { get; set; }

        /// <summary>Required. Type of the new track. Currently, the only supported value is closedTesting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource for per-track country availability information.</summary>
    public class TrackCountryAvailability : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of one or more countries where artifacts in this track are available. This list includes all
        /// countries that are targeted by the track, even if only specific carriers are targeted in that country.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countries")]
        public virtual System.Collections.Generic.IList<TrackTargetedCountry> Countries { get; set; }

        /// <summary>Whether artifacts in this track are available to "rest of the world" countries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restOfWorld")]
        public virtual System.Nullable<bool> RestOfWorld { get; set; }

        /// <summary>
        /// Whether this track's availability is synced with the default production track. See
        /// https://support.google.com/googleplay/android-developer/answer/7550024 for more information on syncing
        /// country availability with production. Note that if this is true, the returned "countries" and
        /// "rest_of_world" fields will reflect the values for the default production track.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("syncWithProduction")]
        public virtual System.Nullable<bool> SyncWithProduction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A release within a track.</summary>
    public class TrackRelease : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Restricts a release to a specific set of countries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryTargeting")]
        public virtual CountryTargeting CountryTargeting { get; set; }

        /// <summary>
        /// In-app update priority of the release. All newly added APKs in the release will be considered at this
        /// priority. Can take values in the range [0, 5], with 5 the highest priority. Defaults to 0.
        /// in_app_update_priority can not be updated once the release is rolled out. See
        /// https://developer.android.com/guide/playcore/in-app-updates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inAppUpdatePriority")]
        public virtual System.Nullable<int> InAppUpdatePriority { get; set; }

        /// <summary>
        /// The release name. Not required to be unique. If not set, the name is generated from the APK's version_name.
        /// If the release contains multiple APKs, the name is generated from the date.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A description of what is new in this release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseNotes")]
        public virtual System.Collections.Generic.IList<LocalizedText> ReleaseNotes { get; set; }

        /// <summary>The status of the release.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Fraction of users who are eligible for a staged release. 0 &amp;lt; fraction &amp;lt; 1. Can only be set
        /// when status is "inProgress" or "halted".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userFraction")]
        public virtual System.Nullable<double> UserFraction { get; set; }

        /// <summary>
        /// Version codes of all APKs in the release. Must include version codes to retain from previous releases.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionCodes")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> VersionCodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a single country where the contents of a track are available.</summary>
    public class TrackTargetedCountry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The country to target, as a two-letter CLDR code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response listing all tracks.</summary>
    public class TracksListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The kind of this response ("androidpublisher#tracksListResponse").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>All tracks (including tracks with no releases).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<Track> Tracks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message to update the state of a subscription base plan.</summary>
    public class UpdateBasePlanStateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Activates a base plan. Once activated, base plans will be available to new subscribers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activateBasePlanRequest")]
        public virtual ActivateBasePlanRequest ActivateBasePlanRequest { get; set; }

        /// <summary>
        /// Deactivates a base plan. Once deactivated, the base plan will become unavailable to new subscribers, but
        /// existing subscribers will maintain their subscription
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deactivateBasePlanRequest")]
        public virtual DeactivateBasePlanRequest DeactivateBasePlanRequest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UpdateSubscriptionOffer.</summary>
    public class UpdateSubscriptionOfferRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If set to true, and the subscription offer with the given package_name, product_id, base_plan_id
        /// and offer_id doesn't exist, an offer will be created. If a new offer is created, update_mask is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMissing")]
        public virtual System.Nullable<bool> AllowMissing { get; set; }

        /// <summary>
        /// Optional. The latency tolerance for the propagation of this product update. Defaults to latency-sensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latencyTolerance")]
        public virtual string LatencyTolerance { get; set; }

        /// <summary>Required. The version of the available regions being used for the subscription_offer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionsVersion")]
        public virtual RegionsVersion RegionsVersion { get; set; }

        /// <summary>Required. The subscription offer to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptionOffer")]
        public virtual SubscriptionOffer SubscriptionOffer { get; set; }

        /// <summary>Required. The list of fields to be updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message to update the state of a subscription offer.</summary>
    public class UpdateSubscriptionOfferStateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Activates an offer. Once activated, the offer will be available to new subscribers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activateSubscriptionOfferRequest")]
        public virtual ActivateSubscriptionOfferRequest ActivateSubscriptionOfferRequest { get; set; }

        /// <summary>
        /// Deactivates an offer. Once deactivated, the offer will become unavailable to new subscribers, but existing
        /// subscribers will maintain their subscription
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deactivateSubscriptionOfferRequest")]
        public virtual DeactivateSubscriptionOfferRequest DeactivateSubscriptionOfferRequest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UpdateSubscription.</summary>
    public class UpdateSubscriptionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. If set to true, and the subscription with the given package_name and product_id doesn't exist, the
        /// subscription will be created. If a new subscription is created, update_mask is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowMissing")]
        public virtual System.Nullable<bool> AllowMissing { get; set; }

        /// <summary>
        /// Optional. The latency tolerance for the propagation of this product update. Defaults to latency-sensitive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latencyTolerance")]
        public virtual string LatencyTolerance { get; set; }

        /// <summary>Required. The version of the available regions being used for the subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionsVersion")]
        public virtual RegionsVersion RegionsVersion { get; set; }

        /// <summary>Required. The subscription to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual Subscription Subscription { get; set; }

        /// <summary>Required. The list of fields to be updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a targeting rule of the form: User currently has {scope} [with billing period {billing_period}].
    /// </summary>
    public class UpgradeTargetingRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The specific billing period duration, specified in ISO 8601 format, that a user must be currently subscribed
        /// to to be eligible for this rule. If not specified, users subscribed to any billing period are matched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingPeriodDuration")]
        public virtual string BillingPeriodDuration { get; set; }

        /// <summary>
        /// Limit this offer to only once per user. If set to true, a user can never be eligible for this offer again if
        /// they ever subscribed to this offer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oncePerUser")]
        public virtual System.Nullable<bool> OncePerUser { get; set; }

        /// <summary>
        /// Required. The scope of subscriptions this rule considers. Only allows "this subscription" and "specific
        /// subscription in app".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual TargetingRuleScope Scope { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A user resource.</summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The state of the user's access to the Play Console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessState")]
        public virtual string AccessState { get; set; }

        /// <summary>Permissions for the user which apply across the developer account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerAccountPermissions")]
        public virtual System.Collections.Generic.IList<string> DeveloperAccountPermissions { get; set; }

        /// <summary>Immutable. The user's email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        private string _expirationTimeRaw;

        private object _expirationTime;

        /// <summary>
        /// The time at which the user's access expires, if set. When setting this value, it must always be in the
        /// future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual string ExpirationTimeRaw
        {
            get => _expirationTimeRaw;
            set
            {
                _expirationTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expirationTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpirationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpirationTimeDateTimeOffset instead.")]
        public virtual object ExpirationTime
        {
            get => _expirationTime;
            set
            {
                _expirationTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expirationTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpirationTimeRaw);
            set => ExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Output only. Per-app permissions for the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grants")]
        public virtual System.Collections.Generic.IList<Grant> Grants { get; set; }

        /// <summary>
        /// Required. Resource name for this user, following the pattern "developers/{developer}/users/{email}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Whether there are more permissions for the user that are not represented here. This can happen
        /// if the caller does not have permission to manage all apps in the account. This is also `true` if this user
        /// is the account owner. If this field is `true`, it should be taken as a signal that this user cannot be fully
        /// managed via the API. That is, the API caller is not be able to manage all of the permissions this user
        /// holds, either because it doesn't know about them or because the user is the account owner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partial")]
        public virtual System.Nullable<bool> Partial { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>User entry from conversation between user and developer.</summary>
    public class UserComment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Integer Android SDK version of the user's device at the time the review was written, e.g. 23 is Marshmallow.
        /// May be absent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidOsVersion")]
        public virtual System.Nullable<int> AndroidOsVersion { get; set; }

        /// <summary>
        /// Integer version code of the app as installed at the time the review was written. May be absent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appVersionCode")]
        public virtual System.Nullable<int> AppVersionCode { get; set; }

        /// <summary>
        /// String version name of the app as installed at the time the review was written. May be absent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appVersionName")]
        public virtual string AppVersionName { get; set; }

        /// <summary>Codename for the reviewer's device, e.g. klte, flounder. May be absent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual string Device { get; set; }

        /// <summary>Information about the characteristics of the user's device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceMetadata")]
        public virtual DeviceMetadata DeviceMetadata { get; set; }

        /// <summary>The last time at which this comment was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModified")]
        public virtual Timestamp LastModified { get; set; }

        /// <summary>
        /// Untranslated text of the review, where the review was translated. If the review was not translated this is
        /// left blank.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalText")]
        public virtual string OriginalText { get; set; }

        /// <summary>
        /// Language code for the reviewer. This is taken from the device settings so is not guaranteed to match the
        /// language the review is written in. May be absent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reviewerLanguage")]
        public virtual string ReviewerLanguage { get; set; }

        /// <summary>The star rating associated with the review, from 1 to 5.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("starRating")]
        public virtual System.Nullable<int> StarRating { get; set; }

        /// <summary>
        /// The content of the comment, i.e. review body. In some cases users have been able to write a review with
        /// separate title and body; in those cases the title and body are concatenated and separated by a tab
        /// character.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Number of users who have given this review a thumbs down.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbsDownCount")]
        public virtual System.Nullable<int> ThumbsDownCount { get; set; }

        /// <summary>Number of users who have given this review a thumbs up.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbsUpCount")]
        public virtual System.Nullable<int> ThumbsUpCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes an inclusive/exclusive list of country codes that module targets.</summary>
    public class UserCountriesTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of country codes in the two-letter CLDR territory format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCodes")]
        public virtual System.Collections.Generic.IList<string> CountryCodes { get; set; }

        /// <summary>Indicates if the list above is exclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclude")]
        public virtual System.Nullable<bool> Exclude { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A set of user countries. A country set determines what variation of app content gets served to a specific
    /// location.
    /// </summary>
    public class UserCountrySet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of country codes representing countries. A Country code is represented in ISO 3166 alpha-2 format. For
        /// Example:- "IT" for Italy, "GE" for Georgia.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCodes")]
        public virtual System.Collections.Generic.IList<string> CountryCodes { get; set; }

        /// <summary>Country set name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information specific to cancellations initiated by users.</summary>
    public class UserInitiatedCancellation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Information provided by the user when they complete the subscription cancellation flow (cancellation reason
        /// survey).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelSurveyResult")]
        public virtual CancelSurveyResult CancelSurveyResult { get; set; }

        private string _cancelTimeRaw;

        private object _cancelTime;

        /// <summary>
        /// The time at which the subscription was canceled by the user. The user might still have access to the
        /// subscription after this time. Use line_items.expiry_time to determine if a user still has access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelTime")]
        public virtual string CancelTimeRaw
        {
            get => _cancelTimeRaw;
            set
            {
                _cancelTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _cancelTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CancelTimeDateTimeOffset instead.")]
        public virtual object CancelTime
        {
            get => _cancelTime;
            set
            {
                _cancelTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _cancelTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CancelTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CancelTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(CancelTimeRaw);
            set => CancelTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A permission used by this APK.</summary>
    public class UsesPermission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optionally, the maximum SDK version for which the permission is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxSdkVersion")]
        public virtual System.Nullable<int> MaxSdkVersion { get; set; }

        /// <summary>The name of the permission requested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A multiple use, predefined promotion code.</summary>
    public class VanityCode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The promotion code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("promotionCode")]
        public virtual string PromotionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>APK that is suitable for inclusion in a system image. The resource of SystemApksService.</summary>
    public class Variant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The device spec used to generate the APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceSpec")]
        public virtual DeviceSpec DeviceSpec { get; set; }

        /// <summary>Optional. Options applied to the generated APK.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual SystemApkOptions Options { get; set; }

        /// <summary>Output only. The ID of a previously created system APK variant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variantId")]
        public virtual System.Nullable<long> VariantId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Targeting on the level of variants.</summary>
    public class VariantTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The abi that the variant targets</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("abiTargeting")]
        public virtual AbiTargeting AbiTargeting { get; set; }

        /// <summary>Multi-api-level targeting</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiAbiTargeting")]
        public virtual MultiAbiTargeting MultiAbiTargeting { get; set; }

        /// <summary>The screen densities that this variant supports</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenDensityTargeting")]
        public virtual ScreenDensityTargeting ScreenDensityTargeting { get; set; }

        /// <summary>The sdk version that the variant targets</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sdkVersionTargeting")]
        public virtual SdkVersionTargeting SdkVersionTargeting { get; set; }

        /// <summary>Texture-compression-format-level targeting</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textureCompressionFormatTargeting")]
        public virtual TextureCompressionFormatTargeting TextureCompressionFormatTargeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A VoidedPurchase resource indicates a purchase that was either canceled/refunded/charged-back.
    /// </summary>
    public class VoidedPurchase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This kind represents a voided purchase object in the androidpublisher service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The order id which uniquely identifies a one-time purchase, subscription purchase, or subscription renewal.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderId")]
        public virtual string OrderId { get; set; }

        /// <summary>The time at which the purchase was made, in milliseconds since the epoch (Jan 1, 1970).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseTimeMillis")]
        public virtual System.Nullable<long> PurchaseTimeMillis { get; set; }

        /// <summary>
        /// The token which uniquely identifies a one-time purchase or subscription. To uniquely identify subscription
        /// renewals use order_id (available starting from version 3 of the API).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseToken")]
        public virtual string PurchaseToken { get; set; }

        /// <summary>
        /// The voided quantity as the result of a quantity-based partial refund. Voided purchases of quantity-based
        /// partial refunds may only be returned when includeQuantityBasedPartialRefund is set to true.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voidedQuantity")]
        public virtual System.Nullable<int> VoidedQuantity { get; set; }

        /// <summary>
        /// The reason why the purchase was voided, possible values are: 0. Other 1. Remorse 2. Not_received 3.
        /// Defective 4. Accidental_purchase 5. Fraud 6. Friendly_fraud 7. Chargeback 8. Unacknowledged_purchase
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voidedReason")]
        public virtual System.Nullable<int> VoidedReason { get; set; }

        /// <summary>The initiator of voided purchase, possible values are: 0. User 1. Developer 2. Google</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voidedSource")]
        public virtual System.Nullable<int> VoidedSource { get; set; }

        /// <summary>
        /// The time at which the purchase was canceled/refunded/charged-back, in milliseconds since the epoch (Jan 1,
        /// 1970).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voidedTimeMillis")]
        public virtual System.Nullable<long> VoidedTimeMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for the voidedpurchases.list API.</summary>
    public class VoidedPurchasesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>General pagination information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; }

        /// <summary>Pagination information for token pagination.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("voidedPurchases")]
        public virtual System.Collections.Generic.IList<VoidedPurchase> VoidedPurchases { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
