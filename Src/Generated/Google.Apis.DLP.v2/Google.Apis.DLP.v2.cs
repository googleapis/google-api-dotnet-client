// Copyright 2021 Google LLC
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

namespace Google.Apis.DLP.v2
{
    /// <summary>The DLP Service.</summary>
    public class DLPService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DLPService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DLPService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            InfoTypes = new InfoTypesResource(this);
            Locations = new LocationsResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "dlp";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://dlp.googleapis.com/";
        #else
            "https://dlp.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://dlp.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Data Loss Prevention (DLP) API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>
        /// Available OAuth 2.0 scope constants for use with the Cloud Data Loss Prevention (DLP) API.
        /// </summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the InfoTypes resource.</summary>
        public virtual InfoTypesResource InfoTypes { get; }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for DLP requests.</summary>
    public abstract class DLPBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new DLPBaseServiceRequest instance.</summary>
        protected DLPBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes DLP parameter list.</summary>
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

    /// <summary>The "infoTypes" collection of methods.</summary>
    public class InfoTypesResource
    {
        private const string Resource = "infoTypes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public InfoTypesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Returns a list of the sensitive information types that the DLP API supports. See
        /// https://cloud.google.com/dlp/docs/infotypes-reference to learn more.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Returns a list of the sensitive information types that the DLP API supports. See
        /// https://cloud.google.com/dlp/docs/infotypes-reference to learn more.
        /// </summary>
        public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListInfoTypesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// filter to only return infoTypes supported by certain parts of the API. Defaults to supported_by=INSPECT.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// BCP-47 language code for localized infoType friendly names. If omitted, or if localized strings are not
            /// available, en-US strings will be returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>Deprecated. This field has no effect.</summary>
            [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LocationId { get; set; }

            /// <summary>
            /// The parent resource name. The format of this value is as follows: locations/ LOCATION_ID
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/infoTypes";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "locationId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "locations" collection of methods.</summary>
    public class LocationsResource
    {
        private const string Resource = "locations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public LocationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            InfoTypes = new InfoTypesResource(service);
        }

        /// <summary>Gets the InfoTypes resource.</summary>
        public virtual InfoTypesResource InfoTypes { get; }

        /// <summary>The "infoTypes" collection of methods.</summary>
        public class InfoTypesResource
        {
            private const string Resource = "infoTypes";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public InfoTypesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Returns a list of the sensitive information types that the DLP API supports. See
            /// https://cloud.google.com/dlp/docs/infotypes-reference to learn more.
            /// </summary>
            /// <param name="parent">
            /// The parent resource name. The format of this value is as follows: locations/ LOCATION_ID
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Returns a list of the sensitive information types that the DLP API supports. See
            /// https://cloud.google.com/dlp/docs/infotypes-reference to learn more.
            /// </summary>
            public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListInfoTypesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// The parent resource name. The format of this value is as follows: locations/ LOCATION_ID
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// filter to only return infoTypes supported by certain parts of the API. Defaults to
                /// supported_by=INSPECT.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// BCP-47 language code for localized infoType friendly names. If omitted, or if localized strings are
                /// not available, en-US strings will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LanguageCode { get; set; }

                /// <summary>Deprecated. This field has no effect.</summary>
                [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LocationId { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/infoTypes";

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
                        Pattern = @"^locations/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "languageCode",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locationId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }

    /// <summary>The "organizations" collection of methods.</summary>
    public class OrganizationsResource
    {
        private const string Resource = "organizations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrganizationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            DeidentifyTemplates = new DeidentifyTemplatesResource(service);
            InspectTemplates = new InspectTemplatesResource(service);
            Locations = new LocationsResource(service);
            StoredInfoTypes = new StoredInfoTypesResource(service);
        }

        /// <summary>Gets the DeidentifyTemplates resource.</summary>
        public virtual DeidentifyTemplatesResource DeidentifyTemplates { get; }

        /// <summary>The "deidentifyTemplates" collection of methods.</summary>
        public class DeidentifyTemplatesResource
        {
            private const string Resource = "deidentifyTemplates";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DeidentifyTemplatesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a DeidentifyTemplate for re-using frequently used configuration for de-identifying content,
            /// images, and storage. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn more.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Parent resource name. The format of this value varies depending on the scope of the request
            /// (project or organization) and whether you have [specified a processing
            /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location specified:
            /// `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified (defaults to
            /// global): `projects/`PROJECT_ID + Organizations scope, location specified:
            /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified (defaults to
            /// global): `organizations/`ORG_ID The following example `parent` string specifies a parent project with
            /// the identifier `example-project`, and specifies the `europe-west3` location for processing data:
            /// parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual CreateRequest Create(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateDeidentifyTemplateRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a DeidentifyTemplate for re-using frequently used configuration for de-identifying content,
            /// images, and storage. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn more.
            /// </summary>
            public class CreateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyTemplate>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateDeidentifyTemplateRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateDeidentifyTemplateRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/deidentifyTemplates";

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
                        Pattern = @"^organizations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
            /// more.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the organization and deidentify template to be deleted, for example
            /// `organizations/433245324/deidentifyTemplates/432452342` or
            /// projects/project-id/deidentifyTemplates/432452342.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
            /// more.
            /// </summary>
            public class DeleteRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the organization and deidentify template to be deleted, for example
                /// `organizations/433245324/deidentifyTemplates/432452342` or
                /// projects/project-id/deidentifyTemplates/432452342.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^organizations/[^/]+/deidentifyTemplates/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets a DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn more.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the organization and deidentify template to be read, for example
            /// `organizations/433245324/deidentifyTemplates/432452342` or
            /// projects/project-id/deidentifyTemplates/432452342.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Gets a DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn more.
            /// </summary>
            public class GetRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyTemplate>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the organization and deidentify template to be read, for example
                /// `organizations/433245324/deidentifyTemplates/432452342` or
                /// projects/project-id/deidentifyTemplates/432452342.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/deidentifyTemplates/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists DeidentifyTemplates. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn more.
            /// </summary>
            /// <param name="parent">
            /// Required. Parent resource name. The format of this value varies depending on the scope of the request
            /// (project or organization) and whether you have [specified a processing
            /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location specified:
            /// `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified (defaults to
            /// global): `projects/`PROJECT_ID + Organizations scope, location specified:
            /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified (defaults to
            /// global): `organizations/`ORG_ID The following example `parent` string specifies a parent project with
            /// the identifier `example-project`, and specifies the `europe-west3` location for processing data:
            /// parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists DeidentifyTemplates. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn more.
            /// </summary>
            public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListDeidentifyTemplatesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Deprecated. This field has no effect.</summary>
                [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LocationId { get; set; }

                /// <summary>
                /// Comma separated list of fields to order by, followed by `asc` or `desc` postfix. This list is
                /// case-insensitive, default sorting order is ascending, redundant space characters are insignificant.
                /// Example: `name asc,update_time, create_time desc` Supported fields are: - `create_time`: corresponds
                /// to time the template was created. - `update_time`: corresponds to time the template was last
                /// updated. - `name`: corresponds to template's name. - `display_name`: corresponds to template's
                /// display name.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Size of the page, can be limited by server. If zero server returns a page of max size 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Page token to continue retrieval. Comes from previous call to `ListDeidentifyTemplates`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/deidentifyTemplates";

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
                        Pattern = @"^organizations/[^/]+$",
                    });
                    RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locationId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
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

            /// <summary>
            /// Updates the DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
            /// more.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Resource name of organization and deidentify template to be updated, for example
            /// `organizations/433245324/deidentifyTemplates/432452342` or
            /// projects/project-id/deidentifyTemplates/432452342.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateDeidentifyTemplateRequest body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates the DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
            /// more.
            /// </summary>
            public class PatchRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyTemplate>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateDeidentifyTemplateRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of organization and deidentify template to be updated, for example
                /// `organizations/433245324/deidentifyTemplates/432452342` or
                /// projects/project-id/deidentifyTemplates/432452342.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateDeidentifyTemplateRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^organizations/[^/]+/deidentifyTemplates/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the InspectTemplates resource.</summary>
        public virtual InspectTemplatesResource InspectTemplates { get; }

        /// <summary>The "inspectTemplates" collection of methods.</summary>
        public class InspectTemplatesResource
        {
            private const string Resource = "inspectTemplates";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public InspectTemplatesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates an InspectTemplate for re-using frequently used configuration for inspecting content, images,
            /// and storage. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Parent resource name. The format of this value varies depending on the scope of the request
            /// (project or organization) and whether you have [specified a processing
            /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location specified:
            /// `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified (defaults to
            /// global): `projects/`PROJECT_ID + Organizations scope, location specified:
            /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified (defaults to
            /// global): `organizations/`ORG_ID The following example `parent` string specifies a parent project with
            /// the identifier `example-project`, and specifies the `europe-west3` location for processing data:
            /// parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual CreateRequest Create(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateInspectTemplateRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates an InspectTemplate for re-using frequently used configuration for inspecting content, images,
            /// and storage. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            public class CreateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectTemplate>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateInspectTemplateRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateInspectTemplateRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/inspectTemplates";

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
                        Pattern = @"^organizations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes an InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the organization and inspectTemplate to be deleted, for example
            /// `organizations/433245324/inspectTemplates/432452342` or projects/project-id/inspectTemplates/432452342.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes an InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            public class DeleteRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the organization and inspectTemplate to be deleted, for example
                /// `organizations/433245324/inspectTemplates/432452342` or
                /// projects/project-id/inspectTemplates/432452342.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^organizations/[^/]+/inspectTemplates/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets an InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the organization and inspectTemplate to be read, for example
            /// `organizations/433245324/inspectTemplates/432452342` or projects/project-id/inspectTemplates/432452342.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Gets an InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            public class GetRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectTemplate>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the organization and inspectTemplate to be read, for example
                /// `organizations/433245324/inspectTemplates/432452342` or
                /// projects/project-id/inspectTemplates/432452342.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/inspectTemplates/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists InspectTemplates. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            /// <param name="parent">
            /// Required. Parent resource name. The format of this value varies depending on the scope of the request
            /// (project or organization) and whether you have [specified a processing
            /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location specified:
            /// `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified (defaults to
            /// global): `projects/`PROJECT_ID + Organizations scope, location specified:
            /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified (defaults to
            /// global): `organizations/`ORG_ID The following example `parent` string specifies a parent project with
            /// the identifier `example-project`, and specifies the `europe-west3` location for processing data:
            /// parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists InspectTemplates. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListInspectTemplatesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Deprecated. This field has no effect.</summary>
                [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LocationId { get; set; }

                /// <summary>
                /// Comma separated list of fields to order by, followed by `asc` or `desc` postfix. This list is
                /// case-insensitive, default sorting order is ascending, redundant space characters are insignificant.
                /// Example: `name asc,update_time, create_time desc` Supported fields are: - `create_time`: corresponds
                /// to time the template was created. - `update_time`: corresponds to time the template was last
                /// updated. - `name`: corresponds to template's name. - `display_name`: corresponds to template's
                /// display name.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Size of the page, can be limited by server. If zero server returns a page of max size 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Page token to continue retrieval. Comes from previous call to `ListInspectTemplates`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/inspectTemplates";

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
                        Pattern = @"^organizations/[^/]+$",
                    });
                    RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locationId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
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

            /// <summary>
            /// Updates the InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Resource name of organization and inspectTemplate to be updated, for example
            /// `organizations/433245324/inspectTemplates/432452342` or projects/project-id/inspectTemplates/432452342.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateInspectTemplateRequest body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates the InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            public class PatchRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectTemplate>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateInspectTemplateRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of organization and inspectTemplate to be updated, for example
                /// `organizations/433245324/inspectTemplates/432452342` or
                /// projects/project-id/inspectTemplates/432452342.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateInspectTemplateRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^organizations/[^/]+/inspectTemplates/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>The "locations" collection of methods.</summary>
        public class LocationsResource
        {
            private const string Resource = "locations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LocationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                DeidentifyTemplates = new DeidentifyTemplatesResource(service);
                DlpJobs = new DlpJobsResource(service);
                InspectTemplates = new InspectTemplatesResource(service);
                JobTriggers = new JobTriggersResource(service);
                StoredInfoTypes = new StoredInfoTypesResource(service);
            }

            /// <summary>Gets the DeidentifyTemplates resource.</summary>
            public virtual DeidentifyTemplatesResource DeidentifyTemplates { get; }

            /// <summary>The "deidentifyTemplates" collection of methods.</summary>
            public class DeidentifyTemplatesResource
            {
                private const string Resource = "deidentifyTemplates";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DeidentifyTemplatesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a DeidentifyTemplate for re-using frequently used configuration for de-identifying content,
                /// images, and storage. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn more.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateDeidentifyTemplateRequest body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a DeidentifyTemplate for re-using frequently used configuration for de-identifying content,
                /// images, and storage. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn more.
                /// </summary>
                public class CreateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyTemplate>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateDeidentifyTemplateRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on the scope of the
                    /// request (project or organization) and whether you have [specified a processing
                    /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                    /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                    /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                    /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                    /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                    /// parent project with the identifier `example-project`, and specifies the `europe-west3` location
                    /// for processing data: parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateDeidentifyTemplateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/deidentifyTemplates";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
                /// more.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the organization and deidentify template to be deleted, for example
                /// `organizations/433245324/deidentifyTemplates/432452342` or
                /// projects/project-id/deidentifyTemplates/432452342.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
                /// more.
                /// </summary>
                public class DeleteRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the organization and deidentify template to be deleted, for example
                    /// `organizations/433245324/deidentifyTemplates/432452342` or
                    /// projects/project-id/deidentifyTemplates/432452342.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/deidentifyTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets a DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
                /// more.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the organization and deidentify template to be read, for example
                /// `organizations/433245324/deidentifyTemplates/432452342` or
                /// projects/project-id/deidentifyTemplates/432452342.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets a DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
                /// more.
                /// </summary>
                public class GetRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyTemplate>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the organization and deidentify template to be read, for example
                    /// `organizations/433245324/deidentifyTemplates/432452342` or
                    /// projects/project-id/deidentifyTemplates/432452342.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/deidentifyTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists DeidentifyTemplates. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
                /// more.
                /// </summary>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists DeidentifyTemplates. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
                /// more.
                /// </summary>
                public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListDeidentifyTemplatesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on the scope of the
                    /// request (project or organization) and whether you have [specified a processing
                    /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                    /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                    /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                    /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                    /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                    /// parent project with the identifier `example-project`, and specifies the `europe-west3` location
                    /// for processing data: parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Deprecated. This field has no effect.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LocationId { get; set; }

                    /// <summary>
                    /// Comma separated list of fields to order by, followed by `asc` or `desc` postfix. This list is
                    /// case-insensitive, default sorting order is ascending, redundant space characters are
                    /// insignificant. Example: `name asc,update_time, create_time desc` Supported fields are: -
                    /// `create_time`: corresponds to time the template was created. - `update_time`: corresponds to
                    /// time the template was last updated. - `name`: corresponds to template's name. - `display_name`:
                    /// corresponds to template's display name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Size of the page, can be limited by server. If zero server returns a page of max size 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Page token to continue retrieval. Comes from previous call to `ListDeidentifyTemplates`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/deidentifyTemplates";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "locationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
                            IsRequired = false,
                            ParameterType = "query",
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

                /// <summary>
                /// Updates the DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to
                /// learn more.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Resource name of organization and deidentify template to be updated, for example
                /// `organizations/433245324/deidentifyTemplates/432452342` or
                /// projects/project-id/deidentifyTemplates/432452342.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateDeidentifyTemplateRequest body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to
                /// learn more.
                /// </summary>
                public class PatchRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyTemplate>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateDeidentifyTemplateRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of organization and deidentify template to be updated, for example
                    /// `organizations/433245324/deidentifyTemplates/432452342` or
                    /// projects/project-id/deidentifyTemplates/432452342.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateDeidentifyTemplateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/deidentifyTemplates/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the DlpJobs resource.</summary>
            public virtual DlpJobsResource DlpJobs { get; }

            /// <summary>The "dlpJobs" collection of methods.</summary>
            public class DlpJobsResource
            {
                private const string Resource = "dlpJobs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DlpJobsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Lists DlpJobs that match the specified filter in the request. See
                /// https://cloud.google.com/dlp/docs/inspecting-storage and
                /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
                /// </summary>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on whether you have
                /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects
                /// scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no
                /// location specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists DlpJobs that match the specified filter in the request. See
                /// https://cloud.google.com/dlp/docs/inspecting-storage and
                /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
                /// </summary>
                public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListDlpJobsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on whether you have
                    /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): +
                    /// Projects scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects
                    /// scope, no location specified (defaults to global): `projects/`PROJECT_ID The following example
                    /// `parent` string specifies a parent project with the identifier `example-project`, and specifies
                    /// the `europe-west3` location for processing data:
                    /// parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Allows filtering. Supported syntax: * Filter expressions are made up of one or more
                    /// restrictions. * Restrictions can be combined by `AND` or `OR` logical operators. A sequence of
                    /// restrictions implicitly uses `AND`. * A restriction has the form of `{field} {operator}
                    /// {value}`. * Supported fields/values for inspect jobs: - `state` -
                    /// PENDING|RUNNING|CANCELED|FINISHED|FAILED - `inspected_storage` -
                    /// DATASTORE|CLOUD_STORAGE|BIGQUERY - `trigger_name` - The resource name of the trigger that
                    /// created job. - 'end_time` - Corresponds to time the job finished. - 'start_time` - Corresponds
                    /// to time the job finished. * Supported fields for risk analysis jobs: - `state` -
                    /// RUNNING|CANCELED|FINISHED|FAILED - 'end_time` - Corresponds to time the job finished. -
                    /// 'start_time` - Corresponds to time the job finished. * The operator must be `=` or `!=`.
                    /// Examples: * inspected_storage = cloud_storage AND state = done * inspected_storage =
                    /// cloud_storage OR inspected_storage = bigquery * inspected_storage = cloud_storage AND (state =
                    /// done OR state = canceled) * end_time &amp;gt; \"2017-12-12T00:00:00+00:00\" The length of this
                    /// field should be no more than 500 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Deprecated. This field has no effect.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LocationId { get; set; }

                    /// <summary>
                    /// Comma separated list of fields to order by, followed by `asc` or `desc` postfix. This list is
                    /// case-insensitive, default sorting order is ascending, redundant space characters are
                    /// insignificant. Example: `name asc, end_time asc, create_time desc` Supported fields are: -
                    /// `create_time`: corresponds to time the job was created. - `end_time`: corresponds to time the
                    /// job ended. - `name`: corresponds to job's name. - `state`: corresponds to `state`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>The standard list page size.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The standard list page token.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>The type of job. Defaults to `DlpJobType.INSPECT`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<TypeEnum> Type { get; set; }

                    /// <summary>The type of job. Defaults to `DlpJobType.INSPECT`</summary>
                    public enum TypeEnum
                    {
                        /// <summary>Defaults to INSPECT_JOB.</summary>
                        [Google.Apis.Util.StringValueAttribute("DLP_JOB_TYPE_UNSPECIFIED")]
                        DLPJOBTYPEUNSPECIFIED = 0,

                        /// <summary>The job inspected Google Cloud for sensitive data.</summary>
                        [Google.Apis.Util.StringValueAttribute("INSPECT_JOB")]
                        INSPECTJOB = 1,

                        /// <summary>The job executed a Risk Analysis computation.</summary>
                        [Google.Apis.Util.StringValueAttribute("RISK_ANALYSIS_JOB")]
                        RISKANALYSISJOB = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/dlpJobs";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "locationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
                            IsRequired = false,
                            ParameterType = "query",
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

            /// <summary>Gets the InspectTemplates resource.</summary>
            public virtual InspectTemplatesResource InspectTemplates { get; }

            /// <summary>The "inspectTemplates" collection of methods.</summary>
            public class InspectTemplatesResource
            {
                private const string Resource = "inspectTemplates";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InspectTemplatesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates an InspectTemplate for re-using frequently used configuration for inspecting content,
                /// images, and storage. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateInspectTemplateRequest body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates an InspectTemplate for re-using frequently used configuration for inspecting content,
                /// images, and storage. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                public class CreateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectTemplate>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateInspectTemplateRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on the scope of the
                    /// request (project or organization) and whether you have [specified a processing
                    /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                    /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                    /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                    /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                    /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                    /// parent project with the identifier `example-project`, and specifies the `europe-west3` location
                    /// for processing data: parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateInspectTemplateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/inspectTemplates";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes an InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the organization and inspectTemplate to be deleted, for example
                /// `organizations/433245324/inspectTemplates/432452342` or
                /// projects/project-id/inspectTemplates/432452342.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes an InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                public class DeleteRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the organization and inspectTemplate to be deleted, for example
                    /// `organizations/433245324/inspectTemplates/432452342` or
                    /// projects/project-id/inspectTemplates/432452342.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/inspectTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets an InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the organization and inspectTemplate to be read, for example
                /// `organizations/433245324/inspectTemplates/432452342` or
                /// projects/project-id/inspectTemplates/432452342.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets an InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                public class GetRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectTemplate>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the organization and inspectTemplate to be read, for example
                    /// `organizations/433245324/inspectTemplates/432452342` or
                    /// projects/project-id/inspectTemplates/432452342.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/inspectTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists InspectTemplates. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists InspectTemplates. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListInspectTemplatesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on the scope of the
                    /// request (project or organization) and whether you have [specified a processing
                    /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                    /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                    /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                    /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                    /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                    /// parent project with the identifier `example-project`, and specifies the `europe-west3` location
                    /// for processing data: parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Deprecated. This field has no effect.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LocationId { get; set; }

                    /// <summary>
                    /// Comma separated list of fields to order by, followed by `asc` or `desc` postfix. This list is
                    /// case-insensitive, default sorting order is ascending, redundant space characters are
                    /// insignificant. Example: `name asc,update_time, create_time desc` Supported fields are: -
                    /// `create_time`: corresponds to time the template was created. - `update_time`: corresponds to
                    /// time the template was last updated. - `name`: corresponds to template's name. - `display_name`:
                    /// corresponds to template's display name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Size of the page, can be limited by server. If zero server returns a page of max size 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Page token to continue retrieval. Comes from previous call to `ListInspectTemplates`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/inspectTemplates";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "locationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
                            IsRequired = false,
                            ParameterType = "query",
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

                /// <summary>
                /// Updates the InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Resource name of organization and inspectTemplate to be updated, for example
                /// `organizations/433245324/inspectTemplates/432452342` or
                /// projects/project-id/inspectTemplates/432452342.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateInspectTemplateRequest body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                public class PatchRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectTemplate>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateInspectTemplateRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of organization and inspectTemplate to be updated, for example
                    /// `organizations/433245324/inspectTemplates/432452342` or
                    /// projects/project-id/inspectTemplates/432452342.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateInspectTemplateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/inspectTemplates/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the JobTriggers resource.</summary>
            public virtual JobTriggersResource JobTriggers { get; }

            /// <summary>The "jobTriggers" collection of methods.</summary>
            public class JobTriggersResource
            {
                private const string Resource = "jobTriggers";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public JobTriggersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a job trigger to run DLP actions such as scanning storage for sensitive information on a set
                /// schedule. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on whether you have
                /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects
                /// scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no
                /// location specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateJobTriggerRequest body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a job trigger to run DLP actions such as scanning storage for sensitive information on a set
                /// schedule. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                public class CreateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2JobTrigger>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateJobTriggerRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on whether you have
                    /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): +
                    /// Projects scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects
                    /// scope, no location specified (defaults to global): `projects/`PROJECT_ID The following example
                    /// `parent` string specifies a parent project with the identifier `example-project`, and specifies
                    /// the `europe-west3` location for processing data:
                    /// parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateJobTriggerRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/jobTriggers";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the project and the triggeredJob, for example
                /// `projects/dlp-test-project/jobTriggers/53234423`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                public class DeleteRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the project and the triggeredJob, for example
                    /// `projects/dlp-test-project/jobTriggers/53234423`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/jobTriggers/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the project and the triggeredJob, for example
                /// `projects/dlp-test-project/jobTriggers/53234423`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                public class GetRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2JobTrigger>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the project and the triggeredJob, for example
                    /// `projects/dlp-test-project/jobTriggers/53234423`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/jobTriggers/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists job triggers. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on whether you have
                /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects
                /// scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no
                /// location specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists job triggers. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListJobTriggersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on whether you have
                    /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): +
                    /// Projects scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects
                    /// scope, no location specified (defaults to global): `projects/`PROJECT_ID The following example
                    /// `parent` string specifies a parent project with the identifier `example-project`, and specifies
                    /// the `europe-west3` location for processing data:
                    /// parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Allows filtering. Supported syntax: * Filter expressions are made up of one or more
                    /// restrictions. * Restrictions can be combined by `AND` or `OR` logical operators. A sequence of
                    /// restrictions implicitly uses `AND`. * A restriction has the form of `{field} {operator}
                    /// {value}`. * Supported fields/values for inspect triggers: - `status` - HEALTHY|PAUSED|CANCELLED
                    /// - `inspected_storage` - DATASTORE|CLOUD_STORAGE|BIGQUERY - 'last_run_time` - RFC 3339 formatted
                    /// timestamp, surrounded by quotation marks. Nanoseconds are ignored. - 'error_count' - Number of
                    /// errors that have occurred while running. * The operator must be `=` or `!=` for status and
                    /// inspected_storage. Examples: * inspected_storage = cloud_storage AND status = HEALTHY *
                    /// inspected_storage = cloud_storage OR inspected_storage = bigquery * inspected_storage =
                    /// cloud_storage AND (state = PAUSED OR state = HEALTHY) * last_run_time &amp;gt;
                    /// \"2017-12-12T00:00:00+00:00\" The length of this field should be no more than 500 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Deprecated. This field has no effect.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LocationId { get; set; }

                    /// <summary>
                    /// Comma separated list of triggeredJob fields to order by, followed by `asc` or `desc` postfix.
                    /// This list is case-insensitive, default sorting order is ascending, redundant space characters
                    /// are insignificant. Example: `name asc,update_time, create_time desc` Supported fields are: -
                    /// `create_time`: corresponds to time the JobTrigger was created. - `update_time`: corresponds to
                    /// time the JobTrigger was last updated. - `last_run_time`: corresponds to the last time the
                    /// JobTrigger ran. - `name`: corresponds to JobTrigger's name. - `display_name`: corresponds to
                    /// JobTrigger's display name. - `status`: corresponds to JobTrigger's status.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Size of the page, can be limited by a server.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Page token to continue retrieval. Comes from previous call to ListJobTriggers. `order_by` field
                    /// must not change for subsequent calls.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>The type of jobs. Will use `DlpJobType.INSPECT` if not set.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<TypeEnum> Type { get; set; }

                    /// <summary>The type of jobs. Will use `DlpJobType.INSPECT` if not set.</summary>
                    public enum TypeEnum
                    {
                        /// <summary>Defaults to INSPECT_JOB.</summary>
                        [Google.Apis.Util.StringValueAttribute("DLP_JOB_TYPE_UNSPECIFIED")]
                        DLPJOBTYPEUNSPECIFIED = 0,

                        /// <summary>The job inspected Google Cloud for sensitive data.</summary>
                        [Google.Apis.Util.StringValueAttribute("INSPECT_JOB")]
                        INSPECTJOB = 1,

                        /// <summary>The job executed a Risk Analysis computation.</summary>
                        [Google.Apis.Util.StringValueAttribute("RISK_ANALYSIS_JOB")]
                        RISKANALYSISJOB = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/jobTriggers";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "locationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
                            IsRequired = false,
                            ParameterType = "query",
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

                /// <summary>
                /// Updates a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Resource name of the project and the triggeredJob, for example
                /// `projects/dlp-test-project/jobTriggers/53234423`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateJobTriggerRequest body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                public class PatchRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2JobTrigger>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateJobTriggerRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the project and the triggeredJob, for example
                    /// `projects/dlp-test-project/jobTriggers/53234423`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateJobTriggerRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/jobTriggers/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the StoredInfoTypes resource.</summary>
            public virtual StoredInfoTypesResource StoredInfoTypes { get; }

            /// <summary>The "storedInfoTypes" collection of methods.</summary>
            public class StoredInfoTypesResource
            {
                private const string Resource = "storedInfoTypes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public StoredInfoTypesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a pre-built stored infoType to be used for inspection. See
                /// https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn more.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateStoredInfoTypeRequest body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a pre-built stored infoType to be used for inspection. See
                /// https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn more.
                /// </summary>
                public class CreateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2StoredInfoType>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateStoredInfoTypeRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on the scope of the
                    /// request (project or organization) and whether you have [specified a processing
                    /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                    /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                    /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                    /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                    /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                    /// parent project with the identifier `example-project`, and specifies the `europe-west3` location
                    /// for processing data: parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateStoredInfoTypeRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/storedInfoTypes";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a stored infoType. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
                /// more.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the organization and storedInfoType to be deleted, for example
                /// `organizations/433245324/storedInfoTypes/432452342` or
                /// projects/project-id/storedInfoTypes/432452342.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a stored infoType. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
                /// more.
                /// </summary>
                public class DeleteRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the organization and storedInfoType to be deleted, for example
                    /// `organizations/433245324/storedInfoTypes/432452342` or
                    /// projects/project-id/storedInfoTypes/432452342.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/storedInfoTypes/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets a stored infoType. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
                /// more.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the organization and storedInfoType to be read, for example
                /// `organizations/433245324/storedInfoTypes/432452342` or
                /// projects/project-id/storedInfoTypes/432452342.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets a stored infoType. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
                /// more.
                /// </summary>
                public class GetRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2StoredInfoType>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the organization and storedInfoType to be read, for example
                    /// `organizations/433245324/storedInfoTypes/432452342` or
                    /// projects/project-id/storedInfoTypes/432452342.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/storedInfoTypes/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists stored infoTypes. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
                /// more.
                /// </summary>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists stored infoTypes. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
                /// more.
                /// </summary>
                public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListStoredInfoTypesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on the scope of the
                    /// request (project or organization) and whether you have [specified a processing
                    /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                    /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                    /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                    /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                    /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                    /// parent project with the identifier `example-project`, and specifies the `europe-west3` location
                    /// for processing data: parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Deprecated. This field has no effect.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LocationId { get; set; }

                    /// <summary>
                    /// Comma separated list of fields to order by, followed by `asc` or `desc` postfix. This list is
                    /// case-insensitive, default sorting order is ascending, redundant space characters are
                    /// insignificant. Example: `name asc, display_name, create_time desc` Supported fields are: -
                    /// `create_time`: corresponds to time the most recent version of the resource was created. -
                    /// `state`: corresponds to the state of the resource. - `name`: corresponds to resource name. -
                    /// `display_name`: corresponds to info type's display name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Size of the page, can be limited by server. If zero server returns a page of max size 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Page token to continue retrieval. Comes from previous call to `ListStoredInfoTypes`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/storedInfoTypes";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "locationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
                            IsRequired = false,
                            ParameterType = "query",
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

                /// <summary>
                /// Updates the stored infoType by creating a new version. The existing version will continue to be used
                /// until the new version is ready. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
                /// learn more.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Resource name of organization and storedInfoType to be updated, for example
                /// `organizations/433245324/storedInfoTypes/432452342` or
                /// projects/project-id/storedInfoTypes/432452342.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateStoredInfoTypeRequest body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the stored infoType by creating a new version. The existing version will continue to be used
                /// until the new version is ready. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
                /// learn more.
                /// </summary>
                public class PatchRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2StoredInfoType>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateStoredInfoTypeRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of organization and storedInfoType to be updated, for example
                    /// `organizations/433245324/storedInfoTypes/432452342` or
                    /// projects/project-id/storedInfoTypes/432452342.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateStoredInfoTypeRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^organizations/[^/]+/locations/[^/]+/storedInfoTypes/[^/]+$",
                        });
                    }
                }
            }
        }

        /// <summary>Gets the StoredInfoTypes resource.</summary>
        public virtual StoredInfoTypesResource StoredInfoTypes { get; }

        /// <summary>The "storedInfoTypes" collection of methods.</summary>
        public class StoredInfoTypesResource
        {
            private const string Resource = "storedInfoTypes";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public StoredInfoTypesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a pre-built stored infoType to be used for inspection. See
            /// https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn more.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Parent resource name. The format of this value varies depending on the scope of the request
            /// (project or organization) and whether you have [specified a processing
            /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location specified:
            /// `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified (defaults to
            /// global): `projects/`PROJECT_ID + Organizations scope, location specified:
            /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified (defaults to
            /// global): `organizations/`ORG_ID The following example `parent` string specifies a parent project with
            /// the identifier `example-project`, and specifies the `europe-west3` location for processing data:
            /// parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual CreateRequest Create(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateStoredInfoTypeRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a pre-built stored infoType to be used for inspection. See
            /// https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn more.
            /// </summary>
            public class CreateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2StoredInfoType>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateStoredInfoTypeRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateStoredInfoTypeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/storedInfoTypes";

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
                        Pattern = @"^organizations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a stored infoType. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
            /// more.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the organization and storedInfoType to be deleted, for example
            /// `organizations/433245324/storedInfoTypes/432452342` or projects/project-id/storedInfoTypes/432452342.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a stored infoType. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
            /// more.
            /// </summary>
            public class DeleteRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the organization and storedInfoType to be deleted, for example
                /// `organizations/433245324/storedInfoTypes/432452342` or
                /// projects/project-id/storedInfoTypes/432452342.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^organizations/[^/]+/storedInfoTypes/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets a stored infoType. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn more.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the organization and storedInfoType to be read, for example
            /// `organizations/433245324/storedInfoTypes/432452342` or projects/project-id/storedInfoTypes/432452342.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Gets a stored infoType. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn more.
            /// </summary>
            public class GetRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2StoredInfoType>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the organization and storedInfoType to be read, for example
                /// `organizations/433245324/storedInfoTypes/432452342` or
                /// projects/project-id/storedInfoTypes/432452342.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/storedInfoTypes/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists stored infoTypes. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn more.
            /// </summary>
            /// <param name="parent">
            /// Required. Parent resource name. The format of this value varies depending on the scope of the request
            /// (project or organization) and whether you have [specified a processing
            /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location specified:
            /// `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified (defaults to
            /// global): `projects/`PROJECT_ID + Organizations scope, location specified:
            /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified (defaults to
            /// global): `organizations/`ORG_ID The following example `parent` string specifies a parent project with
            /// the identifier `example-project`, and specifies the `europe-west3` location for processing data:
            /// parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists stored infoTypes. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn more.
            /// </summary>
            public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListStoredInfoTypesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Deprecated. This field has no effect.</summary>
                [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LocationId { get; set; }

                /// <summary>
                /// Comma separated list of fields to order by, followed by `asc` or `desc` postfix. This list is
                /// case-insensitive, default sorting order is ascending, redundant space characters are insignificant.
                /// Example: `name asc, display_name, create_time desc` Supported fields are: - `create_time`:
                /// corresponds to time the most recent version of the resource was created. - `state`: corresponds to
                /// the state of the resource. - `name`: corresponds to resource name. - `display_name`: corresponds to
                /// info type's display name.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Size of the page, can be limited by server. If zero server returns a page of max size 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Page token to continue retrieval. Comes from previous call to `ListStoredInfoTypes`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/storedInfoTypes";

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
                        Pattern = @"^organizations/[^/]+$",
                    });
                    RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locationId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
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

            /// <summary>
            /// Updates the stored infoType by creating a new version. The existing version will continue to be used
            /// until the new version is ready. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
            /// more.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Resource name of organization and storedInfoType to be updated, for example
            /// `organizations/433245324/storedInfoTypes/432452342` or projects/project-id/storedInfoTypes/432452342.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateStoredInfoTypeRequest body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates the stored infoType by creating a new version. The existing version will continue to be used
            /// until the new version is ready. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
            /// more.
            /// </summary>
            public class PatchRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2StoredInfoType>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateStoredInfoTypeRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of organization and storedInfoType to be updated, for example
                /// `organizations/433245324/storedInfoTypes/432452342` or
                /// projects/project-id/storedInfoTypes/432452342.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateStoredInfoTypeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^organizations/[^/]+/storedInfoTypes/[^/]+$",
                    });
                }
            }
        }
    }

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Content = new ContentResource(service);
            DeidentifyTemplates = new DeidentifyTemplatesResource(service);
            DlpJobs = new DlpJobsResource(service);
            Image = new ImageResource(service);
            InspectTemplates = new InspectTemplatesResource(service);
            JobTriggers = new JobTriggersResource(service);
            Locations = new LocationsResource(service);
            StoredInfoTypes = new StoredInfoTypesResource(service);
        }

        /// <summary>Gets the Content resource.</summary>
        public virtual ContentResource Content { get; }

        /// <summary>The "content" collection of methods.</summary>
        public class ContentResource
        {
            private const string Resource = "content";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ContentResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// De-identifies potentially sensitive info from a ContentItem. This method has limits on input size and
            /// output size. See https://cloud.google.com/dlp/docs/deidentify-sensitive-data to learn more. When no
            /// InfoTypes or CustomInfoTypes are specified in this request, the system will automatically choose what
            /// detectors to run. By default this may be all types, but may change over time as detectors are updated.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Parent resource name. The format of this value varies depending on whether you have [specified a
            /// processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
            /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
            /// (defaults to global): `projects/`PROJECT_ID The following example `parent` string specifies a parent
            /// project with the identifier `example-project`, and specifies the `europe-west3` location for processing
            /// data: parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual DeidentifyRequest Deidentify(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyContentRequest body, string parent)
            {
                return new DeidentifyRequest(service, body, parent);
            }

            /// <summary>
            /// De-identifies potentially sensitive info from a ContentItem. This method has limits on input size and
            /// output size. See https://cloud.google.com/dlp/docs/deidentify-sensitive-data to learn more. When no
            /// InfoTypes or CustomInfoTypes are specified in this request, the system will automatically choose what
            /// detectors to run. By default this may be all types, but may change over time as detectors are updated.
            /// </summary>
            public class DeidentifyRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyContentResponse>
            {
                /// <summary>Constructs a new Deidentify request.</summary>
                public DeidentifyRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyContentRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Parent resource name. The format of this value varies depending on whether you have [specified a
                /// processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope,
                /// location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location
                /// specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyContentRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "deidentify";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/content:deidentify";

                /// <summary>Initializes Deidentify parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Finds potentially sensitive info in content. This method has limits on input size, processing time, and
            /// output size. When no InfoTypes or CustomInfoTypes are specified in this request, the system will
            /// automatically choose what detectors to run. By default this may be all types, but may change over time
            /// as detectors are updated. For how to guides, see https://cloud.google.com/dlp/docs/inspecting-images and
            /// https://cloud.google.com/dlp/docs/inspecting-text,
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Parent resource name. The format of this value varies depending on whether you have [specified a
            /// processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
            /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
            /// (defaults to global): `projects/`PROJECT_ID The following example `parent` string specifies a parent
            /// project with the identifier `example-project`, and specifies the `europe-west3` location for processing
            /// data: parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual InspectRequest Inspect(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectContentRequest body, string parent)
            {
                return new InspectRequest(service, body, parent);
            }

            /// <summary>
            /// Finds potentially sensitive info in content. This method has limits on input size, processing time, and
            /// output size. When no InfoTypes or CustomInfoTypes are specified in this request, the system will
            /// automatically choose what detectors to run. By default this may be all types, but may change over time
            /// as detectors are updated. For how to guides, see https://cloud.google.com/dlp/docs/inspecting-images and
            /// https://cloud.google.com/dlp/docs/inspecting-text,
            /// </summary>
            public class InspectRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectContentResponse>
            {
                /// <summary>Constructs a new Inspect request.</summary>
                public InspectRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectContentRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Parent resource name. The format of this value varies depending on whether you have [specified a
                /// processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope,
                /// location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location
                /// specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectContentRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "inspect";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/content:inspect";

                /// <summary>Initializes Inspect parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Re-identifies content that has been de-identified. See
            /// https://cloud.google.com/dlp/docs/pseudonymization#re-identification_in_free_text_code_example to learn
            /// more.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Parent resource name. The format of this value varies depending on whether you have [specified
            /// a processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope,
            /// location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location
            /// specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string specifies a
            /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
            /// processing data: parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual ReidentifyRequest Reidentify(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ReidentifyContentRequest body, string parent)
            {
                return new ReidentifyRequest(service, body, parent);
            }

            /// <summary>
            /// Re-identifies content that has been de-identified. See
            /// https://cloud.google.com/dlp/docs/pseudonymization#re-identification_in_free_text_code_example to learn
            /// more.
            /// </summary>
            public class ReidentifyRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ReidentifyContentResponse>
            {
                /// <summary>Constructs a new Reidentify request.</summary>
                public ReidentifyRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ReidentifyContentRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent resource name. The format of this value varies depending on whether you have
                /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects
                /// scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no
                /// location specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ReidentifyContentRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "reidentify";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/content:reidentify";

                /// <summary>Initializes Reidentify parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the DeidentifyTemplates resource.</summary>
        public virtual DeidentifyTemplatesResource DeidentifyTemplates { get; }

        /// <summary>The "deidentifyTemplates" collection of methods.</summary>
        public class DeidentifyTemplatesResource
        {
            private const string Resource = "deidentifyTemplates";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DeidentifyTemplatesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a DeidentifyTemplate for re-using frequently used configuration for de-identifying content,
            /// images, and storage. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn more.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Parent resource name. The format of this value varies depending on the scope of the request
            /// (project or organization) and whether you have [specified a processing
            /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location specified:
            /// `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified (defaults to
            /// global): `projects/`PROJECT_ID + Organizations scope, location specified:
            /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified (defaults to
            /// global): `organizations/`ORG_ID The following example `parent` string specifies a parent project with
            /// the identifier `example-project`, and specifies the `europe-west3` location for processing data:
            /// parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual CreateRequest Create(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateDeidentifyTemplateRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a DeidentifyTemplate for re-using frequently used configuration for de-identifying content,
            /// images, and storage. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn more.
            /// </summary>
            public class CreateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyTemplate>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateDeidentifyTemplateRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateDeidentifyTemplateRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/deidentifyTemplates";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
            /// more.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the organization and deidentify template to be deleted, for example
            /// `organizations/433245324/deidentifyTemplates/432452342` or
            /// projects/project-id/deidentifyTemplates/432452342.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
            /// more.
            /// </summary>
            public class DeleteRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the organization and deidentify template to be deleted, for example
                /// `organizations/433245324/deidentifyTemplates/432452342` or
                /// projects/project-id/deidentifyTemplates/432452342.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^projects/[^/]+/deidentifyTemplates/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets a DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn more.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the organization and deidentify template to be read, for example
            /// `organizations/433245324/deidentifyTemplates/432452342` or
            /// projects/project-id/deidentifyTemplates/432452342.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Gets a DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn more.
            /// </summary>
            public class GetRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyTemplate>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the organization and deidentify template to be read, for example
                /// `organizations/433245324/deidentifyTemplates/432452342` or
                /// projects/project-id/deidentifyTemplates/432452342.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/deidentifyTemplates/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists DeidentifyTemplates. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn more.
            /// </summary>
            /// <param name="parent">
            /// Required. Parent resource name. The format of this value varies depending on the scope of the request
            /// (project or organization) and whether you have [specified a processing
            /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location specified:
            /// `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified (defaults to
            /// global): `projects/`PROJECT_ID + Organizations scope, location specified:
            /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified (defaults to
            /// global): `organizations/`ORG_ID The following example `parent` string specifies a parent project with
            /// the identifier `example-project`, and specifies the `europe-west3` location for processing data:
            /// parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists DeidentifyTemplates. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn more.
            /// </summary>
            public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListDeidentifyTemplatesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Deprecated. This field has no effect.</summary>
                [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LocationId { get; set; }

                /// <summary>
                /// Comma separated list of fields to order by, followed by `asc` or `desc` postfix. This list is
                /// case-insensitive, default sorting order is ascending, redundant space characters are insignificant.
                /// Example: `name asc,update_time, create_time desc` Supported fields are: - `create_time`: corresponds
                /// to time the template was created. - `update_time`: corresponds to time the template was last
                /// updated. - `name`: corresponds to template's name. - `display_name`: corresponds to template's
                /// display name.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Size of the page, can be limited by server. If zero server returns a page of max size 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Page token to continue retrieval. Comes from previous call to `ListDeidentifyTemplates`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/deidentifyTemplates";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locationId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
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

            /// <summary>
            /// Updates the DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
            /// more.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Resource name of organization and deidentify template to be updated, for example
            /// `organizations/433245324/deidentifyTemplates/432452342` or
            /// projects/project-id/deidentifyTemplates/432452342.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateDeidentifyTemplateRequest body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates the DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
            /// more.
            /// </summary>
            public class PatchRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyTemplate>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateDeidentifyTemplateRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of organization and deidentify template to be updated, for example
                /// `organizations/433245324/deidentifyTemplates/432452342` or
                /// projects/project-id/deidentifyTemplates/432452342.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateDeidentifyTemplateRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^projects/[^/]+/deidentifyTemplates/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the DlpJobs resource.</summary>
        public virtual DlpJobsResource DlpJobs { get; }

        /// <summary>The "dlpJobs" collection of methods.</summary>
        public class DlpJobsResource
        {
            private const string Resource = "dlpJobs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DlpJobsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Starts asynchronous cancellation on a long-running DlpJob. The server makes a best effort to cancel the
            /// DlpJob, but success is not guaranteed. See https://cloud.google.com/dlp/docs/inspecting-storage and
            /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The name of the DlpJob resource to be cancelled.</param>
            public virtual CancelRequest Cancel(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CancelDlpJobRequest body, string name)
            {
                return new CancelRequest(service, body, name);
            }

            /// <summary>
            /// Starts asynchronous cancellation on a long-running DlpJob. The server makes a best effort to cancel the
            /// DlpJob, but success is not guaranteed. See https://cloud.google.com/dlp/docs/inspecting-storage and
            /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
            /// </summary>
            public class CancelRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Cancel request.</summary>
                public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CancelDlpJobRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The name of the DlpJob resource to be cancelled.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CancelDlpJobRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "cancel";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}:cancel";

                /// <summary>Initializes Cancel parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/dlpJobs/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Creates a new job to inspect storage or calculate risk metrics. See
            /// https://cloud.google.com/dlp/docs/inspecting-storage and
            /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more. When no InfoTypes or
            /// CustomInfoTypes are specified in inspect jobs, the system will automatically choose what detectors to
            /// run. By default this may be all types, but may change over time as detectors are updated.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Parent resource name. The format of this value varies depending on whether you have [specified
            /// a processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope,
            /// location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location
            /// specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string specifies a
            /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
            /// processing data: parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual CreateRequest Create(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateDlpJobRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a new job to inspect storage or calculate risk metrics. See
            /// https://cloud.google.com/dlp/docs/inspecting-storage and
            /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more. When no InfoTypes or
            /// CustomInfoTypes are specified in inspect jobs, the system will automatically choose what detectors to
            /// run. By default this may be all types, but may change over time as detectors are updated.
            /// </summary>
            public class CreateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DlpJob>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateDlpJobRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent resource name. The format of this value varies depending on whether you have
                /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects
                /// scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no
                /// location specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateDlpJobRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/dlpJobs";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a long-running DlpJob. This method indicates that the client is no longer interested in the
            /// DlpJob result. The job will be cancelled if possible. See
            /// https://cloud.google.com/dlp/docs/inspecting-storage and
            /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
            /// </summary>
            /// <param name="name">Required. The name of the DlpJob resource to be deleted.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a long-running DlpJob. This method indicates that the client is no longer interested in the
            /// DlpJob result. The job will be cancelled if possible. See
            /// https://cloud.google.com/dlp/docs/inspecting-storage and
            /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
            /// </summary>
            public class DeleteRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the DlpJob resource to be deleted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^projects/[^/]+/dlpJobs/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the latest state of a long-running DlpJob. See https://cloud.google.com/dlp/docs/inspecting-storage
            /// and https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
            /// </summary>
            /// <param name="name">Required. The name of the DlpJob resource.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Gets the latest state of a long-running DlpJob. See https://cloud.google.com/dlp/docs/inspecting-storage
            /// and https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
            /// </summary>
            public class GetRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DlpJob>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. The name of the DlpJob resource.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/dlpJobs/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists DlpJobs that match the specified filter in the request. See
            /// https://cloud.google.com/dlp/docs/inspecting-storage and
            /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
            /// </summary>
            /// <param name="parent">
            /// Required. Parent resource name. The format of this value varies depending on whether you have [specified
            /// a processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope,
            /// location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location
            /// specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string specifies a
            /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
            /// processing data: parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists DlpJobs that match the specified filter in the request. See
            /// https://cloud.google.com/dlp/docs/inspecting-storage and
            /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
            /// </summary>
            public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListDlpJobsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent resource name. The format of this value varies depending on whether you have
                /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects
                /// scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no
                /// location specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Allows filtering. Supported syntax: * Filter expressions are made up of one or more restrictions. *
                /// Restrictions can be combined by `AND` or `OR` logical operators. A sequence of restrictions
                /// implicitly uses `AND`. * A restriction has the form of `{field} {operator} {value}`. * Supported
                /// fields/values for inspect jobs: - `state` - PENDING|RUNNING|CANCELED|FINISHED|FAILED -
                /// `inspected_storage` - DATASTORE|CLOUD_STORAGE|BIGQUERY - `trigger_name` - The resource name of the
                /// trigger that created job. - 'end_time` - Corresponds to time the job finished. - 'start_time` -
                /// Corresponds to time the job finished. * Supported fields for risk analysis jobs: - `state` -
                /// RUNNING|CANCELED|FINISHED|FAILED - 'end_time` - Corresponds to time the job finished. - 'start_time`
                /// - Corresponds to time the job finished. * The operator must be `=` or `!=`. Examples: *
                /// inspected_storage = cloud_storage AND state = done * inspected_storage = cloud_storage OR
                /// inspected_storage = bigquery * inspected_storage = cloud_storage AND (state = done OR state =
                /// canceled) * end_time &amp;gt; \"2017-12-12T00:00:00+00:00\" The length of this field should be no
                /// more than 500 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Deprecated. This field has no effect.</summary>
                [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LocationId { get; set; }

                /// <summary>
                /// Comma separated list of fields to order by, followed by `asc` or `desc` postfix. This list is
                /// case-insensitive, default sorting order is ascending, redundant space characters are insignificant.
                /// Example: `name asc, end_time asc, create_time desc` Supported fields are: - `create_time`:
                /// corresponds to time the job was created. - `end_time`: corresponds to time the job ended. - `name`:
                /// corresponds to job's name. - `state`: corresponds to `state`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>The standard list page size.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The standard list page token.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>The type of job. Defaults to `DlpJobType.INSPECT`</summary>
                [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<TypeEnum> Type { get; set; }

                /// <summary>The type of job. Defaults to `DlpJobType.INSPECT`</summary>
                public enum TypeEnum
                {
                    /// <summary>Defaults to INSPECT_JOB.</summary>
                    [Google.Apis.Util.StringValueAttribute("DLP_JOB_TYPE_UNSPECIFIED")]
                    DLPJOBTYPEUNSPECIFIED = 0,

                    /// <summary>The job inspected Google Cloud for sensitive data.</summary>
                    [Google.Apis.Util.StringValueAttribute("INSPECT_JOB")]
                    INSPECTJOB = 1,

                    /// <summary>The job executed a Risk Analysis computation.</summary>
                    [Google.Apis.Util.StringValueAttribute("RISK_ANALYSIS_JOB")]
                    RISKANALYSISJOB = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/dlpJobs";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locationId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
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

        /// <summary>Gets the Image resource.</summary>
        public virtual ImageResource Image { get; }

        /// <summary>The "image" collection of methods.</summary>
        public class ImageResource
        {
            private const string Resource = "image";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ImageResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Redacts potentially sensitive info from an image. This method has limits on input size, processing time,
            /// and output size. See https://cloud.google.com/dlp/docs/redacting-sensitive-data-images to learn more.
            /// When no InfoTypes or CustomInfoTypes are specified in this request, the system will automatically choose
            /// what detectors to run. By default this may be all types, but may change over time as detectors are
            /// updated.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Parent resource name. The format of this value varies depending on whether you have [specified a
            /// processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
            /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
            /// (defaults to global): `projects/`PROJECT_ID The following example `parent` string specifies a parent
            /// project with the identifier `example-project`, and specifies the `europe-west3` location for processing
            /// data: parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual RedactRequest Redact(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2RedactImageRequest body, string parent)
            {
                return new RedactRequest(service, body, parent);
            }

            /// <summary>
            /// Redacts potentially sensitive info from an image. This method has limits on input size, processing time,
            /// and output size. See https://cloud.google.com/dlp/docs/redacting-sensitive-data-images to learn more.
            /// When no InfoTypes or CustomInfoTypes are specified in this request, the system will automatically choose
            /// what detectors to run. By default this may be all types, but may change over time as detectors are
            /// updated.
            /// </summary>
            public class RedactRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2RedactImageResponse>
            {
                /// <summary>Constructs a new Redact request.</summary>
                public RedactRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2RedactImageRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Parent resource name. The format of this value varies depending on whether you have [specified a
                /// processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope,
                /// location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location
                /// specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2RedactImageRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "redact";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/image:redact";

                /// <summary>Initializes Redact parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the InspectTemplates resource.</summary>
        public virtual InspectTemplatesResource InspectTemplates { get; }

        /// <summary>The "inspectTemplates" collection of methods.</summary>
        public class InspectTemplatesResource
        {
            private const string Resource = "inspectTemplates";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public InspectTemplatesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates an InspectTemplate for re-using frequently used configuration for inspecting content, images,
            /// and storage. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Parent resource name. The format of this value varies depending on the scope of the request
            /// (project or organization) and whether you have [specified a processing
            /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location specified:
            /// `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified (defaults to
            /// global): `projects/`PROJECT_ID + Organizations scope, location specified:
            /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified (defaults to
            /// global): `organizations/`ORG_ID The following example `parent` string specifies a parent project with
            /// the identifier `example-project`, and specifies the `europe-west3` location for processing data:
            /// parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual CreateRequest Create(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateInspectTemplateRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates an InspectTemplate for re-using frequently used configuration for inspecting content, images,
            /// and storage. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            public class CreateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectTemplate>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateInspectTemplateRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateInspectTemplateRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/inspectTemplates";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes an InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the organization and inspectTemplate to be deleted, for example
            /// `organizations/433245324/inspectTemplates/432452342` or projects/project-id/inspectTemplates/432452342.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes an InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            public class DeleteRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the organization and inspectTemplate to be deleted, for example
                /// `organizations/433245324/inspectTemplates/432452342` or
                /// projects/project-id/inspectTemplates/432452342.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^projects/[^/]+/inspectTemplates/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets an InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the organization and inspectTemplate to be read, for example
            /// `organizations/433245324/inspectTemplates/432452342` or projects/project-id/inspectTemplates/432452342.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Gets an InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            public class GetRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectTemplate>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the organization and inspectTemplate to be read, for example
                /// `organizations/433245324/inspectTemplates/432452342` or
                /// projects/project-id/inspectTemplates/432452342.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/inspectTemplates/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists InspectTemplates. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            /// <param name="parent">
            /// Required. Parent resource name. The format of this value varies depending on the scope of the request
            /// (project or organization) and whether you have [specified a processing
            /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location specified:
            /// `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified (defaults to
            /// global): `projects/`PROJECT_ID + Organizations scope, location specified:
            /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified (defaults to
            /// global): `organizations/`ORG_ID The following example `parent` string specifies a parent project with
            /// the identifier `example-project`, and specifies the `europe-west3` location for processing data:
            /// parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists InspectTemplates. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListInspectTemplatesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Deprecated. This field has no effect.</summary>
                [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LocationId { get; set; }

                /// <summary>
                /// Comma separated list of fields to order by, followed by `asc` or `desc` postfix. This list is
                /// case-insensitive, default sorting order is ascending, redundant space characters are insignificant.
                /// Example: `name asc,update_time, create_time desc` Supported fields are: - `create_time`: corresponds
                /// to time the template was created. - `update_time`: corresponds to time the template was last
                /// updated. - `name`: corresponds to template's name. - `display_name`: corresponds to template's
                /// display name.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Size of the page, can be limited by server. If zero server returns a page of max size 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Page token to continue retrieval. Comes from previous call to `ListInspectTemplates`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/inspectTemplates";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locationId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
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

            /// <summary>
            /// Updates the InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Resource name of organization and inspectTemplate to be updated, for example
            /// `organizations/433245324/inspectTemplates/432452342` or projects/project-id/inspectTemplates/432452342.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateInspectTemplateRequest body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates the InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
            /// </summary>
            public class PatchRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectTemplate>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateInspectTemplateRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of organization and inspectTemplate to be updated, for example
                /// `organizations/433245324/inspectTemplates/432452342` or
                /// projects/project-id/inspectTemplates/432452342.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateInspectTemplateRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^projects/[^/]+/inspectTemplates/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the JobTriggers resource.</summary>
        public virtual JobTriggersResource JobTriggers { get; }

        /// <summary>The "jobTriggers" collection of methods.</summary>
        public class JobTriggersResource
        {
            private const string Resource = "jobTriggers";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public JobTriggersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Activate a job trigger. Causes the immediate execute of a trigger instead of waiting on the trigger
            /// event to occur.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Resource name of the trigger to activate, for example
            /// `projects/dlp-test-project/jobTriggers/53234423`.
            /// </param>
            public virtual ActivateRequest Activate(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ActivateJobTriggerRequest body, string name)
            {
                return new ActivateRequest(service, body, name);
            }

            /// <summary>
            /// Activate a job trigger. Causes the immediate execute of a trigger instead of waiting on the trigger
            /// event to occur.
            /// </summary>
            public class ActivateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DlpJob>
            {
                /// <summary>Constructs a new Activate request.</summary>
                public ActivateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ActivateJobTriggerRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the trigger to activate, for example
                /// `projects/dlp-test-project/jobTriggers/53234423`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ActivateJobTriggerRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "activate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}:activate";

                /// <summary>Initializes Activate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/jobTriggers/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Creates a job trigger to run DLP actions such as scanning storage for sensitive information on a set
            /// schedule. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Parent resource name. The format of this value varies depending on whether you have [specified
            /// a processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope,
            /// location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location
            /// specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string specifies a
            /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
            /// processing data: parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual CreateRequest Create(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateJobTriggerRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a job trigger to run DLP actions such as scanning storage for sensitive information on a set
            /// schedule. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
            /// </summary>
            public class CreateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2JobTrigger>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateJobTriggerRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent resource name. The format of this value varies depending on whether you have
                /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects
                /// scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no
                /// location specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateJobTriggerRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/jobTriggers";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the project and the triggeredJob, for example
            /// `projects/dlp-test-project/jobTriggers/53234423`.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
            /// </summary>
            public class DeleteRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the project and the triggeredJob, for example
                /// `projects/dlp-test-project/jobTriggers/53234423`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^projects/[^/]+/jobTriggers/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the project and the triggeredJob, for example
            /// `projects/dlp-test-project/jobTriggers/53234423`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Gets a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
            /// </summary>
            public class GetRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2JobTrigger>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the project and the triggeredJob, for example
                /// `projects/dlp-test-project/jobTriggers/53234423`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/jobTriggers/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists job triggers. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
            /// </summary>
            /// <param name="parent">
            /// Required. Parent resource name. The format of this value varies depending on whether you have [specified
            /// a processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope,
            /// location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location
            /// specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string specifies a
            /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
            /// processing data: parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists job triggers. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
            /// </summary>
            public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListJobTriggersResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent resource name. The format of this value varies depending on whether you have
                /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects
                /// scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no
                /// location specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Allows filtering. Supported syntax: * Filter expressions are made up of one or more restrictions. *
                /// Restrictions can be combined by `AND` or `OR` logical operators. A sequence of restrictions
                /// implicitly uses `AND`. * A restriction has the form of `{field} {operator} {value}`. * Supported
                /// fields/values for inspect triggers: - `status` - HEALTHY|PAUSED|CANCELLED - `inspected_storage` -
                /// DATASTORE|CLOUD_STORAGE|BIGQUERY - 'last_run_time` - RFC 3339 formatted timestamp, surrounded by
                /// quotation marks. Nanoseconds are ignored. - 'error_count' - Number of errors that have occurred
                /// while running. * The operator must be `=` or `!=` for status and inspected_storage. Examples: *
                /// inspected_storage = cloud_storage AND status = HEALTHY * inspected_storage = cloud_storage OR
                /// inspected_storage = bigquery * inspected_storage = cloud_storage AND (state = PAUSED OR state =
                /// HEALTHY) * last_run_time &amp;gt; \"2017-12-12T00:00:00+00:00\" The length of this field should be
                /// no more than 500 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>Deprecated. This field has no effect.</summary>
                [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LocationId { get; set; }

                /// <summary>
                /// Comma separated list of triggeredJob fields to order by, followed by `asc` or `desc` postfix. This
                /// list is case-insensitive, default sorting order is ascending, redundant space characters are
                /// insignificant. Example: `name asc,update_time, create_time desc` Supported fields are: -
                /// `create_time`: corresponds to time the JobTrigger was created. - `update_time`: corresponds to time
                /// the JobTrigger was last updated. - `last_run_time`: corresponds to the last time the JobTrigger ran.
                /// - `name`: corresponds to JobTrigger's name. - `display_name`: corresponds to JobTrigger's display
                /// name. - `status`: corresponds to JobTrigger's status.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>Size of the page, can be limited by a server.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Page token to continue retrieval. Comes from previous call to ListJobTriggers. `order_by` field must
                /// not change for subsequent calls.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>The type of jobs. Will use `DlpJobType.INSPECT` if not set.</summary>
                [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<TypeEnum> Type { get; set; }

                /// <summary>The type of jobs. Will use `DlpJobType.INSPECT` if not set.</summary>
                public enum TypeEnum
                {
                    /// <summary>Defaults to INSPECT_JOB.</summary>
                    [Google.Apis.Util.StringValueAttribute("DLP_JOB_TYPE_UNSPECIFIED")]
                    DLPJOBTYPEUNSPECIFIED = 0,

                    /// <summary>The job inspected Google Cloud for sensitive data.</summary>
                    [Google.Apis.Util.StringValueAttribute("INSPECT_JOB")]
                    INSPECTJOB = 1,

                    /// <summary>The job executed a Risk Analysis computation.</summary>
                    [Google.Apis.Util.StringValueAttribute("RISK_ANALYSIS_JOB")]
                    RISKANALYSISJOB = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/jobTriggers";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locationId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
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

            /// <summary>
            /// Updates a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Resource name of the project and the triggeredJob, for example
            /// `projects/dlp-test-project/jobTriggers/53234423`.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateJobTriggerRequest body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
            /// </summary>
            public class PatchRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2JobTrigger>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateJobTriggerRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the project and the triggeredJob, for example
                /// `projects/dlp-test-project/jobTriggers/53234423`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateJobTriggerRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^projects/[^/]+/jobTriggers/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>The "locations" collection of methods.</summary>
        public class LocationsResource
        {
            private const string Resource = "locations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LocationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Content = new ContentResource(service);
                DeidentifyTemplates = new DeidentifyTemplatesResource(service);
                DlpJobs = new DlpJobsResource(service);
                Image = new ImageResource(service);
                InspectTemplates = new InspectTemplatesResource(service);
                JobTriggers = new JobTriggersResource(service);
                StoredInfoTypes = new StoredInfoTypesResource(service);
            }

            /// <summary>Gets the Content resource.</summary>
            public virtual ContentResource Content { get; }

            /// <summary>The "content" collection of methods.</summary>
            public class ContentResource
            {
                private const string Resource = "content";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ContentResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// De-identifies potentially sensitive info from a ContentItem. This method has limits on input size
                /// and output size. See https://cloud.google.com/dlp/docs/deidentify-sensitive-data to learn more. When
                /// no InfoTypes or CustomInfoTypes are specified in this request, the system will automatically choose
                /// what detectors to run. By default this may be all types, but may change over time as detectors are
                /// updated.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Parent resource name. The format of this value varies depending on whether you have [specified a
                /// processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope,
                /// location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location
                /// specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual DeidentifyRequest Deidentify(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyContentRequest body, string parent)
                {
                    return new DeidentifyRequest(service, body, parent);
                }

                /// <summary>
                /// De-identifies potentially sensitive info from a ContentItem. This method has limits on input size
                /// and output size. See https://cloud.google.com/dlp/docs/deidentify-sensitive-data to learn more. When
                /// no InfoTypes or CustomInfoTypes are specified in this request, the system will automatically choose
                /// what detectors to run. By default this may be all types, but may change over time as detectors are
                /// updated.
                /// </summary>
                public class DeidentifyRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyContentResponse>
                {
                    /// <summary>Constructs a new Deidentify request.</summary>
                    public DeidentifyRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyContentRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Parent resource name. The format of this value varies depending on whether you have [specified a
                    /// processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope,
                    /// location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location
                    /// specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                    /// specifies a parent project with the identifier `example-project`, and specifies the
                    /// `europe-west3` location for processing data:
                    /// parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyContentRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "deidentify";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/content:deidentify";

                    /// <summary>Initializes Deidentify parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Finds potentially sensitive info in content. This method has limits on input size, processing time,
                /// and output size. When no InfoTypes or CustomInfoTypes are specified in this request, the system will
                /// automatically choose what detectors to run. By default this may be all types, but may change over
                /// time as detectors are updated. For how to guides, see
                /// https://cloud.google.com/dlp/docs/inspecting-images and
                /// https://cloud.google.com/dlp/docs/inspecting-text,
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Parent resource name. The format of this value varies depending on whether you have [specified a
                /// processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope,
                /// location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location
                /// specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual InspectRequest Inspect(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectContentRequest body, string parent)
                {
                    return new InspectRequest(service, body, parent);
                }

                /// <summary>
                /// Finds potentially sensitive info in content. This method has limits on input size, processing time,
                /// and output size. When no InfoTypes or CustomInfoTypes are specified in this request, the system will
                /// automatically choose what detectors to run. By default this may be all types, but may change over
                /// time as detectors are updated. For how to guides, see
                /// https://cloud.google.com/dlp/docs/inspecting-images and
                /// https://cloud.google.com/dlp/docs/inspecting-text,
                /// </summary>
                public class InspectRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectContentResponse>
                {
                    /// <summary>Constructs a new Inspect request.</summary>
                    public InspectRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectContentRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Parent resource name. The format of this value varies depending on whether you have [specified a
                    /// processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope,
                    /// location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location
                    /// specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                    /// specifies a parent project with the identifier `example-project`, and specifies the
                    /// `europe-west3` location for processing data:
                    /// parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectContentRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "inspect";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/content:inspect";

                    /// <summary>Initializes Inspect parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Re-identifies content that has been de-identified. See
                /// https://cloud.google.com/dlp/docs/pseudonymization#re-identification_in_free_text_code_example to
                /// learn more.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on whether you have
                /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects
                /// scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no
                /// location specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual ReidentifyRequest Reidentify(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ReidentifyContentRequest body, string parent)
                {
                    return new ReidentifyRequest(service, body, parent);
                }

                /// <summary>
                /// Re-identifies content that has been de-identified. See
                /// https://cloud.google.com/dlp/docs/pseudonymization#re-identification_in_free_text_code_example to
                /// learn more.
                /// </summary>
                public class ReidentifyRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ReidentifyContentResponse>
                {
                    /// <summary>Constructs a new Reidentify request.</summary>
                    public ReidentifyRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ReidentifyContentRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on whether you have
                    /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): +
                    /// Projects scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects
                    /// scope, no location specified (defaults to global): `projects/`PROJECT_ID The following example
                    /// `parent` string specifies a parent project with the identifier `example-project`, and specifies
                    /// the `europe-west3` location for processing data:
                    /// parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ReidentifyContentRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "reidentify";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/content:reidentify";

                    /// <summary>Initializes Reidentify parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the DeidentifyTemplates resource.</summary>
            public virtual DeidentifyTemplatesResource DeidentifyTemplates { get; }

            /// <summary>The "deidentifyTemplates" collection of methods.</summary>
            public class DeidentifyTemplatesResource
            {
                private const string Resource = "deidentifyTemplates";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DeidentifyTemplatesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a DeidentifyTemplate for re-using frequently used configuration for de-identifying content,
                /// images, and storage. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn more.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateDeidentifyTemplateRequest body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a DeidentifyTemplate for re-using frequently used configuration for de-identifying content,
                /// images, and storage. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn more.
                /// </summary>
                public class CreateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyTemplate>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateDeidentifyTemplateRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on the scope of the
                    /// request (project or organization) and whether you have [specified a processing
                    /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                    /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                    /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                    /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                    /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                    /// parent project with the identifier `example-project`, and specifies the `europe-west3` location
                    /// for processing data: parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateDeidentifyTemplateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/deidentifyTemplates";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
                /// more.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the organization and deidentify template to be deleted, for example
                /// `organizations/433245324/deidentifyTemplates/432452342` or
                /// projects/project-id/deidentifyTemplates/432452342.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
                /// more.
                /// </summary>
                public class DeleteRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the organization and deidentify template to be deleted, for example
                    /// `organizations/433245324/deidentifyTemplates/432452342` or
                    /// projects/project-id/deidentifyTemplates/432452342.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deidentifyTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets a DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
                /// more.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the organization and deidentify template to be read, for example
                /// `organizations/433245324/deidentifyTemplates/432452342` or
                /// projects/project-id/deidentifyTemplates/432452342.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets a DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
                /// more.
                /// </summary>
                public class GetRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyTemplate>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the organization and deidentify template to be read, for example
                    /// `organizations/433245324/deidentifyTemplates/432452342` or
                    /// projects/project-id/deidentifyTemplates/432452342.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deidentifyTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists DeidentifyTemplates. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
                /// more.
                /// </summary>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists DeidentifyTemplates. See https://cloud.google.com/dlp/docs/creating-templates-deid to learn
                /// more.
                /// </summary>
                public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListDeidentifyTemplatesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on the scope of the
                    /// request (project or organization) and whether you have [specified a processing
                    /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                    /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                    /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                    /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                    /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                    /// parent project with the identifier `example-project`, and specifies the `europe-west3` location
                    /// for processing data: parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Deprecated. This field has no effect.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LocationId { get; set; }

                    /// <summary>
                    /// Comma separated list of fields to order by, followed by `asc` or `desc` postfix. This list is
                    /// case-insensitive, default sorting order is ascending, redundant space characters are
                    /// insignificant. Example: `name asc,update_time, create_time desc` Supported fields are: -
                    /// `create_time`: corresponds to time the template was created. - `update_time`: corresponds to
                    /// time the template was last updated. - `name`: corresponds to template's name. - `display_name`:
                    /// corresponds to template's display name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Size of the page, can be limited by server. If zero server returns a page of max size 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Page token to continue retrieval. Comes from previous call to `ListDeidentifyTemplates`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/deidentifyTemplates";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "locationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
                            IsRequired = false,
                            ParameterType = "query",
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

                /// <summary>
                /// Updates the DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to
                /// learn more.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Resource name of organization and deidentify template to be updated, for example
                /// `organizations/433245324/deidentifyTemplates/432452342` or
                /// projects/project-id/deidentifyTemplates/432452342.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateDeidentifyTemplateRequest body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the DeidentifyTemplate. See https://cloud.google.com/dlp/docs/creating-templates-deid to
                /// learn more.
                /// </summary>
                public class PatchRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DeidentifyTemplate>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateDeidentifyTemplateRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of organization and deidentify template to be updated, for example
                    /// `organizations/433245324/deidentifyTemplates/432452342` or
                    /// projects/project-id/deidentifyTemplates/432452342.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateDeidentifyTemplateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/deidentifyTemplates/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the DlpJobs resource.</summary>
            public virtual DlpJobsResource DlpJobs { get; }

            /// <summary>The "dlpJobs" collection of methods.</summary>
            public class DlpJobsResource
            {
                private const string Resource = "dlpJobs";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DlpJobsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running DlpJob. The server makes a best effort to cancel
                /// the DlpJob, but success is not guaranteed. See https://cloud.google.com/dlp/docs/inspecting-storage
                /// and https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. The name of the DlpJob resource to be cancelled.</param>
                public virtual CancelRequest Cancel(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CancelDlpJobRequest body, string name)
                {
                    return new CancelRequest(service, body, name);
                }

                /// <summary>
                /// Starts asynchronous cancellation on a long-running DlpJob. The server makes a best effort to cancel
                /// the DlpJob, but success is not guaranteed. See https://cloud.google.com/dlp/docs/inspecting-storage
                /// and https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
                /// </summary>
                public class CancelRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CancelDlpJobRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the DlpJob resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CancelDlpJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:cancel";

                    /// <summary>Initializes Cancel parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dlpJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Creates a new job to inspect storage or calculate risk metrics. See
                /// https://cloud.google.com/dlp/docs/inspecting-storage and
                /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more. When no InfoTypes or
                /// CustomInfoTypes are specified in inspect jobs, the system will automatically choose what detectors
                /// to run. By default this may be all types, but may change over time as detectors are updated.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on whether you have
                /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects
                /// scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no
                /// location specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateDlpJobRequest body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a new job to inspect storage or calculate risk metrics. See
                /// https://cloud.google.com/dlp/docs/inspecting-storage and
                /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more. When no InfoTypes or
                /// CustomInfoTypes are specified in inspect jobs, the system will automatically choose what detectors
                /// to run. By default this may be all types, but may change over time as detectors are updated.
                /// </summary>
                public class CreateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DlpJob>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateDlpJobRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on whether you have
                    /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): +
                    /// Projects scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects
                    /// scope, no location specified (defaults to global): `projects/`PROJECT_ID The following example
                    /// `parent` string specifies a parent project with the identifier `example-project`, and specifies
                    /// the `europe-west3` location for processing data:
                    /// parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateDlpJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/dlpJobs";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a long-running DlpJob. This method indicates that the client is no longer interested in the
                /// DlpJob result. The job will be cancelled if possible. See
                /// https://cloud.google.com/dlp/docs/inspecting-storage and
                /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
                /// </summary>
                /// <param name="name">Required. The name of the DlpJob resource to be deleted.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a long-running DlpJob. This method indicates that the client is no longer interested in the
                /// DlpJob result. The job will be cancelled if possible. See
                /// https://cloud.google.com/dlp/docs/inspecting-storage and
                /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
                /// </summary>
                public class DeleteRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the DlpJob resource to be deleted.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dlpJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Finish a running hybrid DlpJob. Triggers the finalization steps and running of any enabled actions
                /// that have not yet run.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. The name of the DlpJob resource to be cancelled.</param>
                public virtual FinishRequest Finish(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2FinishDlpJobRequest body, string name)
                {
                    return new FinishRequest(service, body, name);
                }

                /// <summary>
                /// Finish a running hybrid DlpJob. Triggers the finalization steps and running of any enabled actions
                /// that have not yet run.
                /// </summary>
                public class FinishRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Finish request.</summary>
                    public FinishRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2FinishDlpJobRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the DlpJob resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2FinishDlpJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "finish";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:finish";

                    /// <summary>Initializes Finish parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dlpJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the latest state of a long-running DlpJob. See
                /// https://cloud.google.com/dlp/docs/inspecting-storage and
                /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
                /// </summary>
                /// <param name="name">Required. The name of the DlpJob resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running DlpJob. See
                /// https://cloud.google.com/dlp/docs/inspecting-storage and
                /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
                /// </summary>
                public class GetRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DlpJob>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. The name of the DlpJob resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dlpJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Inspect hybrid content and store findings to a job. To review the findings, inspect the job.
                /// Inspection will occur asynchronously.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Resource name of the job to execute a hybrid inspect on, for example
                /// `projects/dlp-test-project/dlpJob/53234423`.
                /// </param>
                public virtual HybridInspectRequest HybridInspect(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2HybridInspectDlpJobRequest body, string name)
                {
                    return new HybridInspectRequest(service, body, name);
                }

                /// <summary>
                /// Inspect hybrid content and store findings to a job. To review the findings, inspect the job.
                /// Inspection will occur asynchronously.
                /// </summary>
                public class HybridInspectRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2HybridInspectResponse>
                {
                    /// <summary>Constructs a new HybridInspect request.</summary>
                    public HybridInspectRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2HybridInspectDlpJobRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the job to execute a hybrid inspect on, for example
                    /// `projects/dlp-test-project/dlpJob/53234423`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2HybridInspectDlpJobRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "hybridInspect";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:hybridInspect";

                    /// <summary>Initializes HybridInspect parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/dlpJobs/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists DlpJobs that match the specified filter in the request. See
                /// https://cloud.google.com/dlp/docs/inspecting-storage and
                /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
                /// </summary>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on whether you have
                /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects
                /// scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no
                /// location specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists DlpJobs that match the specified filter in the request. See
                /// https://cloud.google.com/dlp/docs/inspecting-storage and
                /// https://cloud.google.com/dlp/docs/compute-risk-analysis to learn more.
                /// </summary>
                public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListDlpJobsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on whether you have
                    /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): +
                    /// Projects scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects
                    /// scope, no location specified (defaults to global): `projects/`PROJECT_ID The following example
                    /// `parent` string specifies a parent project with the identifier `example-project`, and specifies
                    /// the `europe-west3` location for processing data:
                    /// parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Allows filtering. Supported syntax: * Filter expressions are made up of one or more
                    /// restrictions. * Restrictions can be combined by `AND` or `OR` logical operators. A sequence of
                    /// restrictions implicitly uses `AND`. * A restriction has the form of `{field} {operator}
                    /// {value}`. * Supported fields/values for inspect jobs: - `state` -
                    /// PENDING|RUNNING|CANCELED|FINISHED|FAILED - `inspected_storage` -
                    /// DATASTORE|CLOUD_STORAGE|BIGQUERY - `trigger_name` - The resource name of the trigger that
                    /// created job. - 'end_time` - Corresponds to time the job finished. - 'start_time` - Corresponds
                    /// to time the job finished. * Supported fields for risk analysis jobs: - `state` -
                    /// RUNNING|CANCELED|FINISHED|FAILED - 'end_time` - Corresponds to time the job finished. -
                    /// 'start_time` - Corresponds to time the job finished. * The operator must be `=` or `!=`.
                    /// Examples: * inspected_storage = cloud_storage AND state = done * inspected_storage =
                    /// cloud_storage OR inspected_storage = bigquery * inspected_storage = cloud_storage AND (state =
                    /// done OR state = canceled) * end_time &amp;gt; \"2017-12-12T00:00:00+00:00\" The length of this
                    /// field should be no more than 500 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Deprecated. This field has no effect.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LocationId { get; set; }

                    /// <summary>
                    /// Comma separated list of fields to order by, followed by `asc` or `desc` postfix. This list is
                    /// case-insensitive, default sorting order is ascending, redundant space characters are
                    /// insignificant. Example: `name asc, end_time asc, create_time desc` Supported fields are: -
                    /// `create_time`: corresponds to time the job was created. - `end_time`: corresponds to time the
                    /// job ended. - `name`: corresponds to job's name. - `state`: corresponds to `state`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>The standard list page size.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The standard list page token.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>The type of job. Defaults to `DlpJobType.INSPECT`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<TypeEnum> Type { get; set; }

                    /// <summary>The type of job. Defaults to `DlpJobType.INSPECT`</summary>
                    public enum TypeEnum
                    {
                        /// <summary>Defaults to INSPECT_JOB.</summary>
                        [Google.Apis.Util.StringValueAttribute("DLP_JOB_TYPE_UNSPECIFIED")]
                        DLPJOBTYPEUNSPECIFIED = 0,

                        /// <summary>The job inspected Google Cloud for sensitive data.</summary>
                        [Google.Apis.Util.StringValueAttribute("INSPECT_JOB")]
                        INSPECTJOB = 1,

                        /// <summary>The job executed a Risk Analysis computation.</summary>
                        [Google.Apis.Util.StringValueAttribute("RISK_ANALYSIS_JOB")]
                        RISKANALYSISJOB = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/dlpJobs";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "locationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
                            IsRequired = false,
                            ParameterType = "query",
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

            /// <summary>Gets the Image resource.</summary>
            public virtual ImageResource Image { get; }

            /// <summary>The "image" collection of methods.</summary>
            public class ImageResource
            {
                private const string Resource = "image";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ImageResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Redacts potentially sensitive info from an image. This method has limits on input size, processing
                /// time, and output size. See https://cloud.google.com/dlp/docs/redacting-sensitive-data-images to
                /// learn more. When no InfoTypes or CustomInfoTypes are specified in this request, the system will
                /// automatically choose what detectors to run. By default this may be all types, but may change over
                /// time as detectors are updated.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Parent resource name. The format of this value varies depending on whether you have [specified a
                /// processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope,
                /// location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location
                /// specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual RedactRequest Redact(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2RedactImageRequest body, string parent)
                {
                    return new RedactRequest(service, body, parent);
                }

                /// <summary>
                /// Redacts potentially sensitive info from an image. This method has limits on input size, processing
                /// time, and output size. See https://cloud.google.com/dlp/docs/redacting-sensitive-data-images to
                /// learn more. When no InfoTypes or CustomInfoTypes are specified in this request, the system will
                /// automatically choose what detectors to run. By default this may be all types, but may change over
                /// time as detectors are updated.
                /// </summary>
                public class RedactRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2RedactImageResponse>
                {
                    /// <summary>Constructs a new Redact request.</summary>
                    public RedactRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2RedactImageRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Parent resource name. The format of this value varies depending on whether you have [specified a
                    /// processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope,
                    /// location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location
                    /// specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                    /// specifies a parent project with the identifier `example-project`, and specifies the
                    /// `europe-west3` location for processing data:
                    /// parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2RedactImageRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "redact";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/image:redact";

                    /// <summary>Initializes Redact parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the InspectTemplates resource.</summary>
            public virtual InspectTemplatesResource InspectTemplates { get; }

            /// <summary>The "inspectTemplates" collection of methods.</summary>
            public class InspectTemplatesResource
            {
                private const string Resource = "inspectTemplates";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InspectTemplatesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates an InspectTemplate for re-using frequently used configuration for inspecting content,
                /// images, and storage. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateInspectTemplateRequest body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates an InspectTemplate for re-using frequently used configuration for inspecting content,
                /// images, and storage. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                public class CreateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectTemplate>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateInspectTemplateRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on the scope of the
                    /// request (project or organization) and whether you have [specified a processing
                    /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                    /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                    /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                    /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                    /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                    /// parent project with the identifier `example-project`, and specifies the `europe-west3` location
                    /// for processing data: parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateInspectTemplateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/inspectTemplates";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes an InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the organization and inspectTemplate to be deleted, for example
                /// `organizations/433245324/inspectTemplates/432452342` or
                /// projects/project-id/inspectTemplates/432452342.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes an InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                public class DeleteRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the organization and inspectTemplate to be deleted, for example
                    /// `organizations/433245324/inspectTemplates/432452342` or
                    /// projects/project-id/inspectTemplates/432452342.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/inspectTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets an InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the organization and inspectTemplate to be read, for example
                /// `organizations/433245324/inspectTemplates/432452342` or
                /// projects/project-id/inspectTemplates/432452342.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets an InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                public class GetRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectTemplate>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the organization and inspectTemplate to be read, for example
                    /// `organizations/433245324/inspectTemplates/432452342` or
                    /// projects/project-id/inspectTemplates/432452342.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/inspectTemplates/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists InspectTemplates. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists InspectTemplates. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListInspectTemplatesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on the scope of the
                    /// request (project or organization) and whether you have [specified a processing
                    /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                    /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                    /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                    /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                    /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                    /// parent project with the identifier `example-project`, and specifies the `europe-west3` location
                    /// for processing data: parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Deprecated. This field has no effect.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LocationId { get; set; }

                    /// <summary>
                    /// Comma separated list of fields to order by, followed by `asc` or `desc` postfix. This list is
                    /// case-insensitive, default sorting order is ascending, redundant space characters are
                    /// insignificant. Example: `name asc,update_time, create_time desc` Supported fields are: -
                    /// `create_time`: corresponds to time the template was created. - `update_time`: corresponds to
                    /// time the template was last updated. - `name`: corresponds to template's name. - `display_name`:
                    /// corresponds to template's display name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Size of the page, can be limited by server. If zero server returns a page of max size 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Page token to continue retrieval. Comes from previous call to `ListInspectTemplates`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/inspectTemplates";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "locationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
                            IsRequired = false,
                            ParameterType = "query",
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

                /// <summary>
                /// Updates the InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Resource name of organization and inspectTemplate to be updated, for example
                /// `organizations/433245324/inspectTemplates/432452342` or
                /// projects/project-id/inspectTemplates/432452342.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateInspectTemplateRequest body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the InspectTemplate. See https://cloud.google.com/dlp/docs/creating-templates to learn more.
                /// </summary>
                public class PatchRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2InspectTemplate>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateInspectTemplateRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of organization and inspectTemplate to be updated, for example
                    /// `organizations/433245324/inspectTemplates/432452342` or
                    /// projects/project-id/inspectTemplates/432452342.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateInspectTemplateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/inspectTemplates/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the JobTriggers resource.</summary>
            public virtual JobTriggersResource JobTriggers { get; }

            /// <summary>The "jobTriggers" collection of methods.</summary>
            public class JobTriggersResource
            {
                private const string Resource = "jobTriggers";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public JobTriggersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Activate a job trigger. Causes the immediate execute of a trigger instead of waiting on the trigger
                /// event to occur.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Resource name of the trigger to activate, for example
                /// `projects/dlp-test-project/jobTriggers/53234423`.
                /// </param>
                public virtual ActivateRequest Activate(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ActivateJobTriggerRequest body, string name)
                {
                    return new ActivateRequest(service, body, name);
                }

                /// <summary>
                /// Activate a job trigger. Causes the immediate execute of a trigger instead of waiting on the trigger
                /// event to occur.
                /// </summary>
                public class ActivateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2DlpJob>
                {
                    /// <summary>Constructs a new Activate request.</summary>
                    public ActivateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ActivateJobTriggerRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the trigger to activate, for example
                    /// `projects/dlp-test-project/jobTriggers/53234423`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ActivateJobTriggerRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "activate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:activate";

                    /// <summary>Initializes Activate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobTriggers/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Creates a job trigger to run DLP actions such as scanning storage for sensitive information on a set
                /// schedule. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on whether you have
                /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects
                /// scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no
                /// location specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateJobTriggerRequest body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a job trigger to run DLP actions such as scanning storage for sensitive information on a set
                /// schedule. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                public class CreateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2JobTrigger>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateJobTriggerRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on whether you have
                    /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): +
                    /// Projects scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects
                    /// scope, no location specified (defaults to global): `projects/`PROJECT_ID The following example
                    /// `parent` string specifies a parent project with the identifier `example-project`, and specifies
                    /// the `europe-west3` location for processing data:
                    /// parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateJobTriggerRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/jobTriggers";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the project and the triggeredJob, for example
                /// `projects/dlp-test-project/jobTriggers/53234423`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                public class DeleteRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the project and the triggeredJob, for example
                    /// `projects/dlp-test-project/jobTriggers/53234423`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobTriggers/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the project and the triggeredJob, for example
                /// `projects/dlp-test-project/jobTriggers/53234423`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                public class GetRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2JobTrigger>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the project and the triggeredJob, for example
                    /// `projects/dlp-test-project/jobTriggers/53234423`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobTriggers/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Inspect hybrid content and store findings to a trigger. The inspection will be processed
                /// asynchronously. To review the findings monitor the jobs within the trigger.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Resource name of the trigger to execute a hybrid inspect on, for example
                /// `projects/dlp-test-project/jobTriggers/53234423`.
                /// </param>
                public virtual HybridInspectRequest HybridInspect(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2HybridInspectJobTriggerRequest body, string name)
                {
                    return new HybridInspectRequest(service, body, name);
                }

                /// <summary>
                /// Inspect hybrid content and store findings to a trigger. The inspection will be processed
                /// asynchronously. To review the findings monitor the jobs within the trigger.
                /// </summary>
                public class HybridInspectRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2HybridInspectResponse>
                {
                    /// <summary>Constructs a new HybridInspect request.</summary>
                    public HybridInspectRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2HybridInspectJobTriggerRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the trigger to execute a hybrid inspect on, for example
                    /// `projects/dlp-test-project/jobTriggers/53234423`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2HybridInspectJobTriggerRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "hybridInspect";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}:hybridInspect";

                    /// <summary>Initializes HybridInspect parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobTriggers/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists job triggers. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on whether you have
                /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): + Projects
                /// scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no
                /// location specified (defaults to global): `projects/`PROJECT_ID The following example `parent` string
                /// specifies a parent project with the identifier `example-project`, and specifies the `europe-west3`
                /// location for processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists job triggers. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListJobTriggersResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on whether you have
                    /// [specified a processing location](https://cloud.google.com/dlp/docs/specifying-location): +
                    /// Projects scope, location specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects
                    /// scope, no location specified (defaults to global): `projects/`PROJECT_ID The following example
                    /// `parent` string specifies a parent project with the identifier `example-project`, and specifies
                    /// the `europe-west3` location for processing data:
                    /// parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Allows filtering. Supported syntax: * Filter expressions are made up of one or more
                    /// restrictions. * Restrictions can be combined by `AND` or `OR` logical operators. A sequence of
                    /// restrictions implicitly uses `AND`. * A restriction has the form of `{field} {operator}
                    /// {value}`. * Supported fields/values for inspect triggers: - `status` - HEALTHY|PAUSED|CANCELLED
                    /// - `inspected_storage` - DATASTORE|CLOUD_STORAGE|BIGQUERY - 'last_run_time` - RFC 3339 formatted
                    /// timestamp, surrounded by quotation marks. Nanoseconds are ignored. - 'error_count' - Number of
                    /// errors that have occurred while running. * The operator must be `=` or `!=` for status and
                    /// inspected_storage. Examples: * inspected_storage = cloud_storage AND status = HEALTHY *
                    /// inspected_storage = cloud_storage OR inspected_storage = bigquery * inspected_storage =
                    /// cloud_storage AND (state = PAUSED OR state = HEALTHY) * last_run_time &amp;gt;
                    /// \"2017-12-12T00:00:00+00:00\" The length of this field should be no more than 500 characters.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>Deprecated. This field has no effect.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LocationId { get; set; }

                    /// <summary>
                    /// Comma separated list of triggeredJob fields to order by, followed by `asc` or `desc` postfix.
                    /// This list is case-insensitive, default sorting order is ascending, redundant space characters
                    /// are insignificant. Example: `name asc,update_time, create_time desc` Supported fields are: -
                    /// `create_time`: corresponds to time the JobTrigger was created. - `update_time`: corresponds to
                    /// time the JobTrigger was last updated. - `last_run_time`: corresponds to the last time the
                    /// JobTrigger ran. - `name`: corresponds to JobTrigger's name. - `display_name`: corresponds to
                    /// JobTrigger's display name. - `status`: corresponds to JobTrigger's status.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>Size of the page, can be limited by a server.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Page token to continue retrieval. Comes from previous call to ListJobTriggers. `order_by` field
                    /// must not change for subsequent calls.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>The type of jobs. Will use `DlpJobType.INSPECT` if not set.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<TypeEnum> Type { get; set; }

                    /// <summary>The type of jobs. Will use `DlpJobType.INSPECT` if not set.</summary>
                    public enum TypeEnum
                    {
                        /// <summary>Defaults to INSPECT_JOB.</summary>
                        [Google.Apis.Util.StringValueAttribute("DLP_JOB_TYPE_UNSPECIFIED")]
                        DLPJOBTYPEUNSPECIFIED = 0,

                        /// <summary>The job inspected Google Cloud for sensitive data.</summary>
                        [Google.Apis.Util.StringValueAttribute("INSPECT_JOB")]
                        INSPECTJOB = 1,

                        /// <summary>The job executed a Risk Analysis computation.</summary>
                        [Google.Apis.Util.StringValueAttribute("RISK_ANALYSIS_JOB")]
                        RISKANALYSISJOB = 2,
                    }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/jobTriggers";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "locationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
                            IsRequired = false,
                            ParameterType = "query",
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

                /// <summary>
                /// Updates a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Resource name of the project and the triggeredJob, for example
                /// `projects/dlp-test-project/jobTriggers/53234423`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateJobTriggerRequest body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates a job trigger. See https://cloud.google.com/dlp/docs/creating-job-triggers to learn more.
                /// </summary>
                public class PatchRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2JobTrigger>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateJobTriggerRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the project and the triggeredJob, for example
                    /// `projects/dlp-test-project/jobTriggers/53234423`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateJobTriggerRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/jobTriggers/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the StoredInfoTypes resource.</summary>
            public virtual StoredInfoTypesResource StoredInfoTypes { get; }

            /// <summary>The "storedInfoTypes" collection of methods.</summary>
            public class StoredInfoTypesResource
            {
                private const string Resource = "storedInfoTypes";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public StoredInfoTypesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a pre-built stored infoType to be used for inspection. See
                /// https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn more.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual CreateRequest Create(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateStoredInfoTypeRequest body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a pre-built stored infoType to be used for inspection. See
                /// https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn more.
                /// </summary>
                public class CreateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2StoredInfoType>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateStoredInfoTypeRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on the scope of the
                    /// request (project or organization) and whether you have [specified a processing
                    /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                    /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                    /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                    /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                    /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                    /// parent project with the identifier `example-project`, and specifies the `europe-west3` location
                    /// for processing data: parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateStoredInfoTypeRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/storedInfoTypes";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes a stored infoType. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
                /// more.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the organization and storedInfoType to be deleted, for example
                /// `organizations/433245324/storedInfoTypes/432452342` or
                /// projects/project-id/storedInfoTypes/432452342.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes a stored infoType. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
                /// more.
                /// </summary>
                public class DeleteRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the organization and storedInfoType to be deleted, for example
                    /// `organizations/433245324/storedInfoTypes/432452342` or
                    /// projects/project-id/storedInfoTypes/432452342.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/storedInfoTypes/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets a stored infoType. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
                /// more.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name of the organization and storedInfoType to be read, for example
                /// `organizations/433245324/storedInfoTypes/432452342` or
                /// projects/project-id/storedInfoTypes/432452342.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets a stored infoType. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
                /// more.
                /// </summary>
                public class GetRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2StoredInfoType>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the organization and storedInfoType to be read, for example
                    /// `organizations/433245324/storedInfoTypes/432452342` or
                    /// projects/project-id/storedInfoTypes/432452342.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/storedInfoTypes/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists stored infoTypes. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
                /// more.
                /// </summary>
                /// <param name="parent">
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists stored infoTypes. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
                /// more.
                /// </summary>
                public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListStoredInfoTypesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Parent resource name. The format of this value varies depending on the scope of the
                    /// request (project or organization) and whether you have [specified a processing
                    /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                    /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                    /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                    /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                    /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                    /// parent project with the identifier `example-project`, and specifies the `europe-west3` location
                    /// for processing data: parent=projects/example-project/locations/europe-west3
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Deprecated. This field has no effect.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LocationId { get; set; }

                    /// <summary>
                    /// Comma separated list of fields to order by, followed by `asc` or `desc` postfix. This list is
                    /// case-insensitive, default sorting order is ascending, redundant space characters are
                    /// insignificant. Example: `name asc, display_name, create_time desc` Supported fields are: -
                    /// `create_time`: corresponds to time the most recent version of the resource was created. -
                    /// `state`: corresponds to the state of the resource. - `name`: corresponds to resource name. -
                    /// `display_name`: corresponds to info type's display name.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// Size of the page, can be limited by server. If zero server returns a page of max size 100.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Page token to continue retrieval. Comes from previous call to `ListStoredInfoTypes`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/storedInfoTypes";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "locationId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
                            IsRequired = false,
                            ParameterType = "query",
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

                /// <summary>
                /// Updates the stored infoType by creating a new version. The existing version will continue to be used
                /// until the new version is ready. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
                /// learn more.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Resource name of organization and storedInfoType to be updated, for example
                /// `organizations/433245324/storedInfoTypes/432452342` or
                /// projects/project-id/storedInfoTypes/432452342.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateStoredInfoTypeRequest body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the stored infoType by creating a new version. The existing version will continue to be used
                /// until the new version is ready. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to
                /// learn more.
                /// </summary>
                public class PatchRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2StoredInfoType>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateStoredInfoTypeRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of organization and storedInfoType to be updated, for example
                    /// `organizations/433245324/storedInfoTypes/432452342` or
                    /// projects/project-id/storedInfoTypes/432452342.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateStoredInfoTypeRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/storedInfoTypes/[^/]+$",
                        });
                    }
                }
            }
        }

        /// <summary>Gets the StoredInfoTypes resource.</summary>
        public virtual StoredInfoTypesResource StoredInfoTypes { get; }

        /// <summary>The "storedInfoTypes" collection of methods.</summary>
        public class StoredInfoTypesResource
        {
            private const string Resource = "storedInfoTypes";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public StoredInfoTypesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a pre-built stored infoType to be used for inspection. See
            /// https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn more.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Parent resource name. The format of this value varies depending on the scope of the request
            /// (project or organization) and whether you have [specified a processing
            /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location specified:
            /// `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified (defaults to
            /// global): `projects/`PROJECT_ID + Organizations scope, location specified:
            /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified (defaults to
            /// global): `organizations/`ORG_ID The following example `parent` string specifies a parent project with
            /// the identifier `example-project`, and specifies the `europe-west3` location for processing data:
            /// parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual CreateRequest Create(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateStoredInfoTypeRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a pre-built stored infoType to be used for inspection. See
            /// https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn more.
            /// </summary>
            public class CreateRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2StoredInfoType>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateStoredInfoTypeRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2CreateStoredInfoTypeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/storedInfoTypes";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a stored infoType. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
            /// more.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the organization and storedInfoType to be deleted, for example
            /// `organizations/433245324/storedInfoTypes/432452342` or projects/project-id/storedInfoTypes/432452342.
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a stored infoType. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
            /// more.
            /// </summary>
            public class DeleteRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the organization and storedInfoType to be deleted, for example
                /// `organizations/433245324/storedInfoTypes/432452342` or
                /// projects/project-id/storedInfoTypes/432452342.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^projects/[^/]+/storedInfoTypes/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets a stored infoType. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn more.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name of the organization and storedInfoType to be read, for example
            /// `organizations/433245324/storedInfoTypes/432452342` or projects/project-id/storedInfoTypes/432452342.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Gets a stored infoType. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn more.
            /// </summary>
            public class GetRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2StoredInfoType>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the organization and storedInfoType to be read, for example
                /// `organizations/433245324/storedInfoTypes/432452342` or
                /// projects/project-id/storedInfoTypes/432452342.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/storedInfoTypes/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists stored infoTypes. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn more.
            /// </summary>
            /// <param name="parent">
            /// Required. Parent resource name. The format of this value varies depending on the scope of the request
            /// (project or organization) and whether you have [specified a processing
            /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location specified:
            /// `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified (defaults to
            /// global): `projects/`PROJECT_ID + Organizations scope, location specified:
            /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified (defaults to
            /// global): `organizations/`ORG_ID The following example `parent` string specifies a parent project with
            /// the identifier `example-project`, and specifies the `europe-west3` location for processing data:
            /// parent=projects/example-project/locations/europe-west3
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists stored infoTypes. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn more.
            /// </summary>
            public class ListRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2ListStoredInfoTypesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Parent resource name. The format of this value varies depending on the scope of the
                /// request (project or organization) and whether you have [specified a processing
                /// location](https://cloud.google.com/dlp/docs/specifying-location): + Projects scope, location
                /// specified: `projects/`PROJECT_ID`/locations/`LOCATION_ID + Projects scope, no location specified
                /// (defaults to global): `projects/`PROJECT_ID + Organizations scope, location specified:
                /// `organizations/`ORG_ID`/locations/`LOCATION_ID + Organizations scope, no location specified
                /// (defaults to global): `organizations/`ORG_ID The following example `parent` string specifies a
                /// parent project with the identifier `example-project`, and specifies the `europe-west3` location for
                /// processing data: parent=projects/example-project/locations/europe-west3
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Deprecated. This field has no effect.</summary>
                [Google.Apis.Util.RequestParameterAttribute("locationId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string LocationId { get; set; }

                /// <summary>
                /// Comma separated list of fields to order by, followed by `asc` or `desc` postfix. This list is
                /// case-insensitive, default sorting order is ascending, redundant space characters are insignificant.
                /// Example: `name asc, display_name, create_time desc` Supported fields are: - `create_time`:
                /// corresponds to time the most recent version of the resource was created. - `state`: corresponds to
                /// the state of the resource. - `name`: corresponds to resource name. - `display_name`: corresponds to
                /// info type's display name.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Size of the page, can be limited by server. If zero server returns a page of max size 100.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Page token to continue retrieval. Comes from previous call to `ListStoredInfoTypes`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/storedInfoTypes";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("locationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locationId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
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

            /// <summary>
            /// Updates the stored infoType by creating a new version. The existing version will continue to be used
            /// until the new version is ready. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
            /// more.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Resource name of organization and storedInfoType to be updated, for example
            /// `organizations/433245324/storedInfoTypes/432452342` or projects/project-id/storedInfoTypes/432452342.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateStoredInfoTypeRequest body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates the stored infoType by creating a new version. The existing version will continue to be used
            /// until the new version is ready. See https://cloud.google.com/dlp/docs/creating-stored-infotypes to learn
            /// more.
            /// </summary>
            public class PatchRequest : DLPBaseServiceRequest<Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2StoredInfoType>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateStoredInfoTypeRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of organization and storedInfoType to be updated, for example
                /// `organizations/433245324/storedInfoTypes/432452342` or
                /// projects/project-id/storedInfoTypes/432452342.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.DLP.v2.Data.GooglePrivacyDlpV2UpdateStoredInfoTypeRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                        Pattern = @"^projects/[^/]+/storedInfoTypes/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.DLP.v2.Data
{
    /// <summary>
    /// A task to execute on the completion of a job. See https://cloud.google.com/dlp/docs/concepts-actions to learn
    /// more.
    /// </summary>
    public class GooglePrivacyDlpV2Action : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Enable email notification for project owners and editors on job's completion/failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobNotificationEmails")]
        public virtual GooglePrivacyDlpV2JobNotificationEmails JobNotificationEmails { get; set; }

        /// <summary>Publish a notification to a pubsub topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubSub")]
        public virtual GooglePrivacyDlpV2PublishToPubSub PubSub { get; set; }

        /// <summary>Publish findings to Cloud Datahub.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishFindingsToCloudDataCatalog")]
        public virtual GooglePrivacyDlpV2PublishFindingsToCloudDataCatalog PublishFindingsToCloudDataCatalog { get; set; }

        /// <summary>Publish summary to Cloud Security Command Center (Alpha).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishSummaryToCscc")]
        public virtual GooglePrivacyDlpV2PublishSummaryToCscc PublishSummaryToCscc { get; set; }

        /// <summary>Enable Stackdriver metric dlp.googleapis.com/finding_count.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishToStackdriver")]
        public virtual GooglePrivacyDlpV2PublishToStackdriver PublishToStackdriver { get; set; }

        /// <summary>Save resulting findings in a provided location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("saveFindings")]
        public virtual GooglePrivacyDlpV2SaveFindings SaveFindings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ActivateJobTrigger.</summary>
    public class GooglePrivacyDlpV2ActivateJobTriggerRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result of a risk analysis operation request.</summary>
    public class GooglePrivacyDlpV2AnalyzeDataSourceRiskDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Categorical stats result</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoricalStatsResult")]
        public virtual GooglePrivacyDlpV2CategoricalStatsResult CategoricalStatsResult { get; set; }

        /// <summary>Delta-presence result</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deltaPresenceEstimationResult")]
        public virtual GooglePrivacyDlpV2DeltaPresenceEstimationResult DeltaPresenceEstimationResult { get; set; }

        /// <summary>K-anonymity result</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kAnonymityResult")]
        public virtual GooglePrivacyDlpV2KAnonymityResult KAnonymityResult { get; set; }

        /// <summary>K-map result</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kMapEstimationResult")]
        public virtual GooglePrivacyDlpV2KMapEstimationResult KMapEstimationResult { get; set; }

        /// <summary>L-divesity result</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lDiversityResult")]
        public virtual GooglePrivacyDlpV2LDiversityResult LDiversityResult { get; set; }

        /// <summary>Numerical stats result</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numericalStatsResult")]
        public virtual GooglePrivacyDlpV2NumericalStatsResult NumericalStatsResult { get; set; }

        /// <summary>The configuration used for this job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedOptions")]
        public virtual GooglePrivacyDlpV2RequestedRiskAnalysisOptions RequestedOptions { get; set; }

        /// <summary>Privacy metric to compute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPrivacyMetric")]
        public virtual GooglePrivacyDlpV2PrivacyMetric RequestedPrivacyMetric { get; set; }

        /// <summary>Input dataset to compute metrics over.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedSourceTable")]
        public virtual GooglePrivacyDlpV2BigQueryTable RequestedSourceTable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An auxiliary table contains statistical information on the relative frequency of different quasi-identifiers
    /// values. It has one or several quasi-identifiers columns, and one column that indicates the relative frequency of
    /// each quasi-identifier tuple. If a tuple is present in the data but not in the auxiliary table, the corresponding
    /// relative frequency is assumed to be zero (and thus, the tuple is highly reidentifiable).
    /// </summary>
    public class GooglePrivacyDlpV2AuxiliaryTable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Quasi-identifier columns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quasiIds")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2QuasiIdField> QuasiIds { get; set; }

        /// <summary>
        /// Required. The relative frequency column must contain a floating-point number between 0 and 1 (inclusive).
        /// Null values are assumed to be zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativeFrequency")]
        public virtual GooglePrivacyDlpV2FieldId RelativeFrequency { get; set; }

        /// <summary>Required. Auxiliary table location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual GooglePrivacyDlpV2BigQueryTable Table { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message defining a field of a BigQuery table.</summary>
    public class GooglePrivacyDlpV2BigQueryField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Designated field in the BigQuery table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual GooglePrivacyDlpV2FieldId Field { get; set; }

        /// <summary>Source table of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual GooglePrivacyDlpV2BigQueryTable Table { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Row key for identifying a record in BigQuery table.</summary>
    public class GooglePrivacyDlpV2BigQueryKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Row number inferred at the time the table was scanned. This value is nondeterministic, cannot be queried,
        /// and may be null for inspection jobs. To locate findings within a table, specify
        /// `inspect_job.storage_config.big_query_options.identifying_fields` in `CreateDlpJobRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowNumber")]
        public virtual System.Nullable<long> RowNumber { get; set; }

        /// <summary>Complete BigQuery table reference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableReference")]
        public virtual GooglePrivacyDlpV2BigQueryTable TableReference { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options defining BigQuery table and row identifiers.</summary>
    public class GooglePrivacyDlpV2BigQueryOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// References to fields excluded from scanning. This allows you to skip inspection of entire columns which you
        /// know have no findings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedFields")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2FieldId> ExcludedFields { get; set; }

        /// <summary>
        /// Table fields that may uniquely identify a row within the table. When
        /// `actions.saveFindings.outputConfig.table` is specified, the values of columns specified here are available
        /// in the output table under `location.content_locations.record_location.record_key.id_values`. Nested fields
        /// such as `person.birthdate.year` are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identifyingFields")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2FieldId> IdentifyingFields { get; set; }

        /// <summary>
        /// Max number of rows to scan. If the table has more rows than this value, the rest of the rows are omitted. If
        /// not set, or if set to 0, all rows will be scanned. Only one of rows_limit and rows_limit_percent can be
        /// specified. Cannot be used in conjunction with TimespanConfig.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowsLimit")]
        public virtual System.Nullable<long> RowsLimit { get; set; }

        /// <summary>
        /// Max percentage of rows to scan. The rest are omitted. The number of rows scanned is rounded down. Must be
        /// between 0 and 100, inclusively. Both 0 and 100 means no limit. Defaults to 0. Only one of rows_limit and
        /// rows_limit_percent can be specified. Cannot be used in conjunction with TimespanConfig.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowsLimitPercent")]
        public virtual System.Nullable<int> RowsLimitPercent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sampleMethod")]
        public virtual string SampleMethod { get; set; }

        /// <summary>Complete BigQuery table reference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableReference")]
        public virtual GooglePrivacyDlpV2BigQueryTable TableReference { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message defining the location of a BigQuery table. A table is uniquely identified by its project_id, dataset_id,
    /// and table_name. Within a query a table is often referenced with a string in the format of: `:.` or `..`.
    /// </summary>
    public class GooglePrivacyDlpV2BigQueryTable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Dataset ID of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>
        /// The Google Cloud Platform project ID of the project containing the table. If omitted, project ID is inferred
        /// from the API call.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>Name of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
        public virtual string TableId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Bounding box encompassing detected text within an image.</summary>
    public class GooglePrivacyDlpV2BoundingBox : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Height of the bounding box in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; }

        /// <summary>Left coordinate of the bounding box. (0,0) is upper left.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("left")]
        public virtual System.Nullable<int> Left { get; set; }

        /// <summary>Top coordinate of the bounding box. (0,0) is upper left.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("top")]
        public virtual System.Nullable<int> Top { get; set; }

        /// <summary>Width of the bounding box in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Bucket is represented as a range, along with replacement values.</summary>
    public class GooglePrivacyDlpV2Bucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Upper bound of the range, exclusive; type must match min.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("max")]
        public virtual GooglePrivacyDlpV2Value Max { get; set; }

        /// <summary>Lower bound of the range, inclusive. Type should be the same as max if used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("min")]
        public virtual GooglePrivacyDlpV2Value Min { get; set; }

        /// <summary>Required. Replacement value for this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replacementValue")]
        public virtual GooglePrivacyDlpV2Value ReplacementValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically
    /// provided by the user for custom behavior, such as 1-30 -&amp;gt; LOW 31-65 -&amp;gt; MEDIUM 66-100 -&amp;gt;
    /// HIGH This can be used on data of type: number, long, string, timestamp. If the bound `Value` type differs from
    /// the type of data being transformed, we will first attempt converting the type of the data to be transformed to
    /// match the type of the bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn
    /// more.
    /// </summary>
    public class GooglePrivacyDlpV2BucketingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set of buckets. Ranges must be non-overlapping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buckets")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2Bucket> Buckets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container for bytes to inspect or redact.</summary>
    public class GooglePrivacyDlpV2ByteContentItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Content data to inspect or redact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>The type of data stored in the bytes string. Default will be TEXT_UTF8.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for canceling a DLP job.</summary>
    public class GooglePrivacyDlpV2CancelDlpJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Compute numerical stats over an individual column, including number of distinct values and value count
    /// distribution.
    /// </summary>
    public class GooglePrivacyDlpV2CategoricalStatsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Field to compute categorical stats on. All column types are supported except for arrays and structs.
        /// However, it may be more informative to use NumericalStats when the field type is supported, depending on the
        /// data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual GooglePrivacyDlpV2FieldId Field { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Histogram of value frequencies in the column.</summary>
    public class GooglePrivacyDlpV2CategoricalStatsHistogramBucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total number of values in this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketSize")]
        public virtual System.Nullable<long> BucketSize { get; set; }

        /// <summary>Total number of distinct values in this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketValueCount")]
        public virtual System.Nullable<long> BucketValueCount { get; set; }

        /// <summary>
        /// Sample of value frequencies in this bucket. The total number of values returned per bucket is capped at 20.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketValues")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2ValueFrequency> BucketValues { get; set; }

        /// <summary>Lower bound on the value frequency of the values in this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueFrequencyLowerBound")]
        public virtual System.Nullable<long> ValueFrequencyLowerBound { get; set; }

        /// <summary>Upper bound on the value frequency of the values in this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueFrequencyUpperBound")]
        public virtual System.Nullable<long> ValueFrequencyUpperBound { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result of the categorical stats computation.</summary>
    public class GooglePrivacyDlpV2CategoricalStatsResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Histogram of value frequencies in the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueFrequencyHistogramBuckets")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2CategoricalStatsHistogramBucket> ValueFrequencyHistogramBuckets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Partially mask a string by replacing a given number of characters with a fixed character. Masking can start from
    /// the beginning or end of the string. This can be used on data of any type (numbers, longs, and so on) and when
    /// de-identifying structured data we'll attempt to preserve the original data's type. (This allows you to take a
    /// long like 123 and modify it to a string like **3.
    /// </summary>
    public class GooglePrivacyDlpV2CharacterMaskConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When masking a string, items in this list will be skipped when replacing characters. For example, if the
        /// input string is `555-555-5555` and you instruct Cloud DLP to skip `-` and mask 5 characters with `*`, Cloud
        /// DLP returns `***-**5-5555`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("charactersToIgnore")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2CharsToIgnore> CharactersToIgnore { get; set; }

        /// <summary>
        /// Character to use to mask the sensitive values—for example, `*` for an alphabetic string such as a name, or
        /// `0` for a numeric string such as ZIP code or credit card number. This string must have a length of 1. If not
        /// supplied, this value defaults to `*` for strings, and `0` for digits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maskingCharacter")]
        public virtual string MaskingCharacter { get; set; }

        /// <summary>
        /// Number of characters to mask. If not set, all matching chars will be masked. Skipped characters do not count
        /// towards this tally.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberToMask")]
        public virtual System.Nullable<int> NumberToMask { get; set; }

        /// <summary>
        /// Mask characters in reverse order. For example, if `masking_character` is `0`, `number_to_mask` is `14`, and
        /// `reverse_order` is `false`, then the input string `1234-5678-9012-3456` is masked as `00000000000000-3456`.
        /// If `masking_character` is `*`, `number_to_mask` is `3`, and `reverse_order` is `true`, then the string
        /// `12345` is masked as `12***`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reverseOrder")]
        public virtual System.Nullable<bool> ReverseOrder { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Characters to skip when doing deidentification of a value. These will be left alone and skipped.
    /// </summary>
    public class GooglePrivacyDlpV2CharsToIgnore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Characters to not transform when masking.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("charactersToSkip")]
        public virtual string CharactersToSkip { get; set; }

        /// <summary>Common characters to not transform when masking. Useful to avoid removing punctuation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonCharactersToIgnore")]
        public virtual string CommonCharactersToIgnore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message representing a set of files in Cloud Storage.</summary>
    public class GooglePrivacyDlpV2CloudStorageFileSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The url, in the format `gs:///`. Trailing wildcard in the path is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options defining a file or a set of files within a Google Cloud Storage bucket.</summary>
    public class GooglePrivacyDlpV2CloudStorageOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Max number of bytes to scan from a file. If a scanned file's size is bigger than this value then the rest of
        /// the bytes are omitted. Only one of bytes_limit_per_file and bytes_limit_per_file_percent can be specified.
        /// Cannot be set if de-identification is requested.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesLimitPerFile")]
        public virtual System.Nullable<long> BytesLimitPerFile { get; set; }

        /// <summary>
        /// Max percentage of bytes to scan from a file. The rest are omitted. The number of bytes scanned is rounded
        /// down. Must be between 0 and 100, inclusively. Both 0 and 100 means no limit. Defaults to 0. Only one of
        /// bytes_limit_per_file and bytes_limit_per_file_percent can be specified. Cannot be set if de-identification
        /// is requested.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesLimitPerFilePercent")]
        public virtual System.Nullable<int> BytesLimitPerFilePercent { get; set; }

        /// <summary>The set of one or more files to scan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileSet")]
        public virtual GooglePrivacyDlpV2FileSet FileSet { get; set; }

        /// <summary>
        /// List of file type groups to include in the scan. If empty, all files are scanned and available data format
        /// processors are applied. In addition, the binary content of the selected files is always scanned as well.
        /// Images are scanned only as binary if the specified region does not support image inspection and no
        /// file_types were specified. Image inspection is restricted to 'global', 'us', 'asia', and 'europe'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileTypes")]
        public virtual System.Collections.Generic.IList<string> FileTypes { get; set; }

        /// <summary>
        /// Limits the number of files to scan to this percentage of the input FileSet. Number of files scanned is
        /// rounded down. Must be between 0 and 100, inclusively. Both 0 and 100 means no limit. Defaults to 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filesLimitPercent")]
        public virtual System.Nullable<int> FilesLimitPercent { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("sampleMethod")]
        public virtual string SampleMethod { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message representing a single file or path in Cloud Storage.</summary>
    public class GooglePrivacyDlpV2CloudStoragePath : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A url representing a file or path (no wildcards) in Cloud Storage. Example:
        /// gs://[BUCKET_NAME]/dictionary.txt
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message representing a set of files in a Cloud Storage bucket. Regular expressions are used to allow
    /// fine-grained control over which files in the bucket to include. Included files are those that match at least one
    /// item in `include_regex` and do not match any items in `exclude_regex`. Note that a file that matches items from
    /// both lists will _not_ be included. For a match to occur, the entire file path (i.e., everything in the url after
    /// the bucket name) must match the regular expression. For example, given the input `{bucket_name: "mybucket",
    /// include_regex: ["directory1/.*"], exclude_regex: ["directory1/excluded.*"]}`: *
    /// `gs://mybucket/directory1/myfile` will be included * `gs://mybucket/directory1/directory2/myfile` will be
    /// included (`.*` matches across `/`) * `gs://mybucket/directory0/directory1/myfile` will _not_ be included (the
    /// full path doesn't match any items in `include_regex`) * `gs://mybucket/directory1/excludedfile` will _not_ be
    /// included (the path matches an item in `exclude_regex`) If `include_regex` is left empty, it will match all files
    /// by default (this is equivalent to setting `include_regex: [".*"]`). Some other common use cases: *
    /// `{bucket_name: "mybucket", exclude_regex: [".*\.pdf"]}` will include all files in `mybucket` except for .pdf
    /// files * `{bucket_name: "mybucket", include_regex: ["directory/[^/]+"]}` will include all files directly under
    /// `gs://mybucket/directory/`, without matching across `/`
    /// </summary>
    public class GooglePrivacyDlpV2CloudStorageRegexFileSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of a Cloud Storage bucket. Required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketName")]
        public virtual string BucketName { get; set; }

        /// <summary>
        /// A list of regular expressions matching file paths to exclude. All files in the bucket that match at least
        /// one of these regular expressions will be excluded from the scan. Regular expressions use RE2
        /// [syntax](https://github.com/google/re2/wiki/Syntax); a guide can be found under the google/re2 repository on
        /// GitHub.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeRegex")]
        public virtual System.Collections.Generic.IList<string> ExcludeRegex { get; set; }

        /// <summary>
        /// A list of regular expressions matching file paths to include. All files in the bucket that match at least
        /// one of these regular expressions will be included in the set of files, except for those that also match an
        /// item in `exclude_regex`. Leaving this field empty will match all files by default (this is equivalent to
        /// including `.*` in the list). Regular expressions use RE2
        /// [syntax](https://github.com/google/re2/wiki/Syntax); a guide can be found under the google/re2 repository on
        /// GitHub.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeRegex")]
        public virtual System.Collections.Generic.IList<string> IncludeRegex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a color in the RGB color space.</summary>
    public class GooglePrivacyDlpV2Color : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The amount of blue in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blue")]
        public virtual System.Nullable<float> Blue { get; set; }

        /// <summary>The amount of green in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("green")]
        public virtual System.Nullable<float> Green { get; set; }

        /// <summary>The amount of red in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("red")]
        public virtual System.Nullable<float> Red { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The field type of `value` and `field` do not need to match to be considered equal, but not all comparisons are
    /// possible. EQUAL_TO and NOT_EQUAL_TO attempt to compare even with incompatible types, but all other comparisons
    /// are invalid with incompatible types. A `value` of type: - `string` can be compared against all other types -
    /// `boolean` can only be compared against other booleans - `integer` can be compared against doubles or a string if
    /// the string value can be parsed as an integer. - `double` can be compared against integers or a string if the
    /// string can be parsed as a double. - `Timestamp` can be compared against strings in RFC 3339 date string format.
    /// - `TimeOfDay` can be compared against timestamps and strings in the format of 'HH:mm:ss'. If we fail to compare
    /// do to type mismatch, a warning will be given and the condition will evaluate to false.
    /// </summary>
    public class GooglePrivacyDlpV2Condition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Field within the record this condition is evaluated against.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual GooglePrivacyDlpV2FieldId Field { get; set; }

        /// <summary>Required. Operator used to compare the field or infoType to the value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operator")]
        public virtual string Operator__ { get; set; }

        /// <summary>Value to compare against. [Mandatory, except for `EXISTS` tests.]</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual GooglePrivacyDlpV2Value Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A collection of conditions.</summary>
    public class GooglePrivacyDlpV2Conditions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A collection of conditions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2Condition> Conditions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a container that may contain DLP findings. Examples of a container include a file, table, or database
    /// record.
    /// </summary>
    public class GooglePrivacyDlpV2Container : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A string representation of the full container name. Examples: - BigQuery: 'Project:DataSetId.TableId' -
        /// Google Cloud Storage: 'gs://Bucket/folders/filename.txt'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullPath")]
        public virtual string FullPath { get; set; }

        /// <summary>
        /// Project where the finding was found. Can be different from the project that owns the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// The rest of the path after the root. Examples: - For BigQuery table `project_id:dataset_id.table_id`, the
        /// relative path is `table_id` - Google Cloud Storage file `gs://bucket/folder/filename.txt`, the relative path
        /// is `folder/filename.txt`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativePath")]
        public virtual string RelativePath { get; set; }

        /// <summary>
        /// The root of the container. Examples: - For BigQuery table `project_id:dataset_id.table_id`, the root is
        /// `dataset_id` - For Google Cloud Storage file `gs://bucket/folder/filename.txt`, the root is `gs://bucket`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootPath")]
        public virtual string RootPath { get; set; }

        /// <summary>Container type, for example BigQuery or Google Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// Findings container modification timestamp, if applicable. For Google Cloud Storage contains last file
        /// modification timestamp. For BigQuery table contains last_modified_time property. For Datastore - not
        /// populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Findings container version, if available ("generation" for Google Cloud Storage).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container structure for the content to inspect.</summary>
    public class GooglePrivacyDlpV2ContentItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Content data to inspect or redact. Replaces `type` and `data`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("byteItem")]
        public virtual GooglePrivacyDlpV2ByteContentItem ByteItem { get; set; }

        /// <summary>
        /// Structured content for inspection. See https://cloud.google.com/dlp/docs/inspecting-text#inspecting_a_table
        /// to learn more.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual GooglePrivacyDlpV2Table Table { get; set; }

        /// <summary>String data to inspect or redact.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Precise location of the finding within a document, record, image, or metadata container.</summary>
    public class GooglePrivacyDlpV2ContentLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the container where the finding is located. The top level name is the source file name or table
        /// name. Names of some common storage containers are formatted as follows: * BigQuery tables:
        /// `{project_id}:{dataset_id}.{table_id}` * Cloud Storage files: `gs://{bucket}/{path}` * Datastore namespace:
        /// {namespace} Nested names could be absent if the embedded object has no string identifier (for an example an
        /// image contained within a document).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerName")]
        public virtual string ContainerName { get; set; }

        /// <summary>
        /// Findings container modification timestamp, if applicable. For Google Cloud Storage contains last file
        /// modification timestamp. For BigQuery table contains last_modified_time property. For Datastore - not
        /// populated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerTimestamp")]
        public virtual object ContainerTimestamp { get; set; }

        /// <summary>Findings container version, if available ("generation" for Google Cloud Storage).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerVersion")]
        public virtual string ContainerVersion { get; set; }

        /// <summary>Location data for document files.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("documentLocation")]
        public virtual GooglePrivacyDlpV2DocumentLocation DocumentLocation { get; set; }

        /// <summary>Location within an image's pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageLocation")]
        public virtual GooglePrivacyDlpV2ImageLocation ImageLocation { get; set; }

        /// <summary>Location within the metadata for inspected content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataLocation")]
        public virtual GooglePrivacyDlpV2MetadataLocation MetadataLocation { get; set; }

        /// <summary>Location within a row or record of a database table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordLocation")]
        public virtual GooglePrivacyDlpV2RecordLocation RecordLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CreateDeidentifyTemplate.</summary>
    public class GooglePrivacyDlpV2CreateDeidentifyTemplateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The DeidentifyTemplate to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deidentifyTemplate")]
        public virtual GooglePrivacyDlpV2DeidentifyTemplate DeidentifyTemplate { get; set; }

        /// <summary>Deprecated. This field has no effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>
        /// The template id can contain uppercase and lowercase letters, numbers, and hyphens; that is, it must match
        /// the regular expression: `[a-zA-Z\d-_]+`. The maximum length is 100 characters. Can be empty to allow the
        /// system to generate one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateId")]
        public virtual string TemplateId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request message for CreateDlpJobRequest. Used to initiate long running jobs such as calculating risk metrics or
    /// inspecting Google Cloud Storage.
    /// </summary>
    public class GooglePrivacyDlpV2CreateDlpJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An inspection job scans a storage repository for InfoTypes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectJob")]
        public virtual GooglePrivacyDlpV2InspectJobConfig InspectJob { get; set; }

        /// <summary>
        /// The job id can contain uppercase and lowercase letters, numbers, and hyphens; that is, it must match the
        /// regular expression: `[a-zA-Z\d-_]+`. The maximum length is 100 characters. Can be empty to allow the system
        /// to generate one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobId")]
        public virtual string JobId { get; set; }

        /// <summary>Deprecated. This field has no effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>A risk analysis job calculates re-identification risk metrics for a BigQuery table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("riskJob")]
        public virtual GooglePrivacyDlpV2RiskAnalysisJobConfig RiskJob { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CreateInspectTemplate.</summary>
    public class GooglePrivacyDlpV2CreateInspectTemplateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The InspectTemplate to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectTemplate")]
        public virtual GooglePrivacyDlpV2InspectTemplate InspectTemplate { get; set; }

        /// <summary>Deprecated. This field has no effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>
        /// The template id can contain uppercase and lowercase letters, numbers, and hyphens; that is, it must match
        /// the regular expression: `[a-zA-Z\d-_]+`. The maximum length is 100 characters. Can be empty to allow the
        /// system to generate one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("templateId")]
        public virtual string TemplateId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CreateJobTrigger.</summary>
    public class GooglePrivacyDlpV2CreateJobTriggerRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The JobTrigger to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobTrigger")]
        public virtual GooglePrivacyDlpV2JobTrigger JobTrigger { get; set; }

        /// <summary>Deprecated. This field has no effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>
        /// The trigger id can contain uppercase and lowercase letters, numbers, and hyphens; that is, it must match the
        /// regular expression: `[a-zA-Z\d-_]+`. The maximum length is 100 characters. Can be empty to allow the system
        /// to generate one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerId")]
        public virtual string TriggerId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CreateStoredInfoType.</summary>
    public class GooglePrivacyDlpV2CreateStoredInfoTypeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Configuration of the storedInfoType to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GooglePrivacyDlpV2StoredInfoTypeConfig Config { get; set; }

        /// <summary>Deprecated. This field has no effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>
        /// The storedInfoType ID can contain uppercase and lowercase letters, numbers, and hyphens; that is, it must
        /// match the regular expression: `[a-zA-Z\d-_]+`. The maximum length is 100 characters. Can be empty to allow
        /// the system to generate one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storedInfoTypeId")]
        public virtual string StoredInfoTypeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded
    /// representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
    /// </summary>
    public class GooglePrivacyDlpV2CryptoDeterministicConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A context may be used for higher security and maintaining referential integrity such that the same
        /// identifier in two different contexts will be given a distinct surrogate. The context is appended to
        /// plaintext value being encrypted. On decryption the provided context is validated against the value used
        /// during encryption. If a context was provided during encryption, same context must be provided during
        /// decryption as well. If the context is not set, plaintext would be used as is for encryption. If the context
        /// is set but: 1. there is no record present when transforming a given value or 2. the field is not present
        /// when transforming a given value, plaintext would be used as is for encryption. Note that case (1) is
        /// expected when an `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual GooglePrivacyDlpV2FieldId Context { get; set; }

        /// <summary>
        /// The key used by the encryption function. For deterministic encryption using AES-SIV, the provided key is
        /// internally expanded to 64 bytes prior to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKey")]
        public virtual GooglePrivacyDlpV2CryptoKey CryptoKey { get; set; }

        /// <summary>
        /// The custom info type to annotate the surrogate with. This annotation will be applied to the surrogate by
        /// prefixing it with the name of the custom info type followed by the number of characters comprising the
        /// surrogate. The following scheme defines the format: {info type name}({surrogate character
        /// count}):{surrogate} For example, if the name of custom info type is 'MY_TOKEN_INFO_TYPE' and the surrogate
        /// is 'abc', the full replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the
        /// surrogate when inspecting content using the custom info type 'Surrogate'. This facilitates reversal of the
        /// surrogate when it occurs in free text. Note: For record transformations where the entire cell in a table is
        /// being transformed, surrogates are not mandatory. Surrogates are used to denote the location of the token and
        /// are necessary for re-identification in free form text. In order for inspection to work properly, the name of
        /// this info type must not occur naturally anywhere in your data; otherwise, inspection may either - reverse a
        /// surrogate that does not correspond to an actual identifier - be unable to parse the surrogate and result in
        /// an error Therefore, choose your custom info type name carefully after considering what your data looks like.
        /// One way to select a name that has a high chance of yielding reliable detection is to include one or more
        /// unicode characters that are highly improbable to exist in your data. For example, assuming your data is
        /// entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so:
        /// ⧝MY_TOKEN_TYPE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("surrogateInfoType")]
        public virtual GooglePrivacyDlpV2InfoType SurrogateInfoType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be
    /// either 32 or 64 bytes. Outputs a base64 encoded representation of the hashed output (for example,
    /// L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=). Currently, only string and integer values can be hashed. See
    /// https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// </summary>
    public class GooglePrivacyDlpV2CryptoHashConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The key used by the hash function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKey")]
        public virtual GooglePrivacyDlpV2CryptoKey CryptoKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This is a data encryption key (DEK) (as opposed to a key encryption key (KEK) stored by KMS). When using KMS to
    /// wrap/unwrap DEKs, be sure to set an appropriate IAM policy on the KMS CryptoKey (KEK) to ensure an attacker
    /// cannot unwrap the data crypto key.
    /// </summary>
    public class GooglePrivacyDlpV2CryptoKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Kms wrapped key</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsWrapped")]
        public virtual GooglePrivacyDlpV2KmsWrappedCryptoKey KmsWrapped { get; set; }

        /// <summary>Transient crypto key</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transient")]
        public virtual GooglePrivacyDlpV2TransientCryptoKey Transient { get; set; }

        /// <summary>Unwrapped crypto key</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unwrapped")]
        public virtual GooglePrivacyDlpV2UnwrappedCryptoKey Unwrapped { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation;
    /// however when used in the `ReidentifyContent` API method, it serves the opposite function by reversing the
    /// surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and
    /// context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two
    /// characters long. In the case that the identifier is the empty string, it will be skipped. See
    /// https://cloud.google.com/dlp/docs/pseudonymization to learn more. Note: We recommend using
    /// CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size,
    /// plus warrant referential integrity.
    /// </summary>
    public class GooglePrivacyDlpV2CryptoReplaceFfxFpeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Common alphabets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commonAlphabet")]
        public virtual string CommonAlphabet { get; set; }

        /// <summary>
        /// The 'tweak', a context may be used for higher security since the same identifier in two different contexts
        /// won't be given the same surrogate. If the context is not set, a default tweak will be used. If the context
        /// is set but: 1. there is no record present when transforming a given value or 1. the field is not present
        /// when transforming a given value, a default tweak will be used. Note that case (1) is expected when an
        /// `InfoTypeTransformation` is applied to both structured and non-structured `ContentItem`s. Currently, the
        /// referenced field may be of value type integer or string. The tweak is constructed as a sequence of bytes in
        /// big endian byte order such that: - a 64 bit integer is encoded followed by a single byte of value 1 - a
        /// string is encoded in UTF-8 format followed by a single byte of value 2
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual GooglePrivacyDlpV2FieldId Context { get; set; }

        /// <summary>Required. The key used by the encryption algorithm.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKey")]
        public virtual GooglePrivacyDlpV2CryptoKey CryptoKey { get; set; }

        /// <summary>
        /// This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This
        /// happens before/after encryption/decryption. Each character listed must appear only once. Number of
        /// characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not
        /// matter. The full list of allowed characters is:
        /// 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz
        /// ~`!@#$%^&amp;amp;*()_-+={[}]|\:;"'&amp;lt;,&amp;gt;.?/
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customAlphabet")]
        public virtual string CustomAlphabet { get; set; }

        /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("radix")]
        public virtual System.Nullable<int> Radix { get; set; }

        /// <summary>
        /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by
        /// prefixing it with the name of the custom infoType followed by the number of characters comprising the
        /// surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate For
        /// example, if the name of custom infoType is 'MY_TOKEN_INFO_TYPE' and the surrogate is 'abc', the full
        /// replacement value will be: 'MY_TOKEN_INFO_TYPE(3):abc' This annotation identifies the surrogate when
        /// inspecting content using the custom infoType
        /// [`SurrogateType`](https://cloud.google.com/dlp/docs/reference/rest/v2/InspectConfig#surrogatetype). This
        /// facilitates reversal of the surrogate when it occurs in free text. In order for inspection to work properly,
        /// the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a
        /// surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name
        /// carefully after considering what your data looks like. One way to select a name that has a high chance of
        /// yielding reliable detection is to include one or more unicode characters that are highly improbable to exist
        /// in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the
        /// hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("surrogateInfoType")]
        public virtual GooglePrivacyDlpV2InfoType SurrogateInfoType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Custom information type provided by the user. Used to find domain-specific sensitive information configurable to
    /// the data in question.
    /// </summary>
    public class GooglePrivacyDlpV2CustomInfoType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set of detection rules to apply to all findings of this CustomInfoType. Rules are applied in order that they
        /// are specified. Not supported for the `surrogate_type` CustomInfoType.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectionRules")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2DetectionRule> DetectionRules { get; set; }

        /// <summary>A list of phrases to detect as a CustomInfoType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dictionary")]
        public virtual GooglePrivacyDlpV2Dictionary Dictionary { get; set; }

        /// <summary>
        /// If set to EXCLUSION_TYPE_EXCLUDE this infoType will not cause a finding to be returned. It still can be used
        /// for rules matching.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusionType")]
        public virtual string ExclusionType { get; set; }

        /// <summary>
        /// CustomInfoType can either be a new infoType, or an extension of built-in infoType, when the name matches one
        /// of existing infoTypes and that infoType is specified in `InspectContent.info_types` field. Specifying the
        /// latter adds findings to the one detected by the system. If built-in info type is not specified in
        /// `InspectContent.info_types` list then the name is treated as a custom info type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoType")]
        public virtual GooglePrivacyDlpV2InfoType InfoType { get; set; }

        /// <summary>
        /// Likelihood to return for this CustomInfoType. This base value can be altered by a detection rule if the
        /// finding meets the criteria specified by the rule. Defaults to `VERY_LIKELY` if not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("likelihood")]
        public virtual string Likelihood { get; set; }

        /// <summary>Regular expression based CustomInfoType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regex")]
        public virtual GooglePrivacyDlpV2Regex Regex { get; set; }

        /// <summary>
        /// Load an existing `StoredInfoType` resource for use in `InspectDataSource`. Not currently supported in
        /// `InspectContent`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storedType")]
        public virtual GooglePrivacyDlpV2StoredType StoredType { get; set; }

        /// <summary>
        /// Message for detecting output from deidentification transformations that support reversing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("surrogateType")]
        public virtual GooglePrivacyDlpV2SurrogateType SurrogateType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Record key for a finding in Cloud Datastore.</summary>
    public class GooglePrivacyDlpV2DatastoreKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Datastore entity key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityKey")]
        public virtual GooglePrivacyDlpV2Key EntityKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Options defining a data set within Google Cloud Datastore.</summary>
    public class GooglePrivacyDlpV2DatastoreOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The kind to process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual GooglePrivacyDlpV2KindExpression Kind { get; set; }

        /// <summary>
        /// A partition ID identifies a grouping of entities. The grouping is always by project and namespace, however
        /// the namespace ID may be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionId")]
        public virtual GooglePrivacyDlpV2PartitionId PartitionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Shifts dates by random number of days, with option to be consistent for the same context. See
    /// https://cloud.google.com/dlp/docs/concepts-date-shifting to learn more.
    /// </summary>
    public class GooglePrivacyDlpV2DateShiftConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Points to the field that contains the context, for example, an entity id. If set, must also set cryptoKey.
        /// If set, shift will be consistent for the given context.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual GooglePrivacyDlpV2FieldId Context { get; set; }

        /// <summary>
        /// Causes the shift to be computed based on this key and the context. This results in the same shift for the
        /// same context and crypto_key. If set, must also set context. Can only be applied to table items.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKey")]
        public virtual GooglePrivacyDlpV2CryptoKey CryptoKey { get; set; }

        /// <summary>Required. For example, -5 means shift date to at most 5 days back in the past.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowerBoundDays")]
        public virtual System.Nullable<int> LowerBoundDays { get; set; }

        /// <summary>
        /// Required. Range of shift in days. Actual shift will be selected at random within this range (inclusive
        /// ends). Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each
        /// direction. For example, 3 means shift date to at most 3 days into the future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upperBoundDays")]
        public virtual System.Nullable<int> UpperBoundDays { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for a date time object. e.g. 2018-01-01, 5th August.</summary>
    public class GooglePrivacyDlpV2DateTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>One or more of the following must be set. Must be a valid date or time value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual GoogleTypeDate Date { get; set; }

        /// <summary>Day of week</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfWeek")]
        public virtual string DayOfWeek { get; set; }

        /// <summary>Time of day</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("time")]
        public virtual GoogleTypeTimeOfDay Time { get; set; }

        /// <summary>Time zone</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual GooglePrivacyDlpV2TimeZone TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration that controls how the data will change.</summary>
    public class GooglePrivacyDlpV2DeidentifyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Treat the dataset as free-form text and apply the same free text transformation everywhere.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoTypeTransformations")]
        public virtual GooglePrivacyDlpV2InfoTypeTransformations InfoTypeTransformations { get; set; }

        /// <summary>
        /// Treat the dataset as structured. Transformations can be applied to specific locations within structured
        /// datasets, such as transforming a column within a table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordTransformations")]
        public virtual GooglePrivacyDlpV2RecordTransformations RecordTransformations { get; set; }

        /// <summary>
        /// Mode for handling transformation errors. If left unspecified, the default mode is
        /// `TransformationErrorHandling.ThrowError`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformationErrorHandling")]
        public virtual GooglePrivacyDlpV2TransformationErrorHandling TransformationErrorHandling { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to de-identify a list of items.</summary>
    public class GooglePrivacyDlpV2DeidentifyContentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Configuration for the de-identification of the content item. Items specified here will override the template
        /// referenced by the deidentify_template_name argument.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deidentifyConfig")]
        public virtual GooglePrivacyDlpV2DeidentifyConfig DeidentifyConfig { get; set; }

        /// <summary>
        /// Template to use. Any configuration directly specified in deidentify_config will override those set in the
        /// template. Singular fields that are set in this request will replace their corresponding fields in the
        /// template. Repeated fields are appended. Singular sub-messages and groups are recursively merged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deidentifyTemplateName")]
        public virtual string DeidentifyTemplateName { get; set; }

        /// <summary>
        /// Configuration for the inspector. Items specified here will override the template referenced by the
        /// inspect_template_name argument.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectConfig")]
        public virtual GooglePrivacyDlpV2InspectConfig InspectConfig { get; set; }

        /// <summary>
        /// Template to use. Any configuration directly specified in inspect_config will override those set in the
        /// template. Singular fields that are set in this request will replace their corresponding fields in the
        /// template. Repeated fields are appended. Singular sub-messages and groups are recursively merged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectTemplateName")]
        public virtual string InspectTemplateName { get; set; }

        /// <summary>The item to de-identify. Will be treated as text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("item")]
        public virtual GooglePrivacyDlpV2ContentItem Item { get; set; }

        /// <summary>Deprecated. This field has no effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Results of de-identifying a ContentItem.</summary>
    public class GooglePrivacyDlpV2DeidentifyContentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The de-identified item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("item")]
        public virtual GooglePrivacyDlpV2ContentItem Item { get; set; }

        /// <summary>An overview of the changes that were made on the `item`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overview")]
        public virtual GooglePrivacyDlpV2TransformationOverview Overview { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// DeidentifyTemplates contains instructions on how to de-identify content. See
    /// https://cloud.google.com/dlp/docs/concepts-templates to learn more.
    /// </summary>
    public class GooglePrivacyDlpV2DeidentifyTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The creation timestamp of an inspectTemplate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The core content of the template.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deidentifyConfig")]
        public virtual GooglePrivacyDlpV2DeidentifyConfig DeidentifyConfig { get; set; }

        /// <summary>Short description (max 256 chars).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display name (max 256 chars).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The template name. The template will have one of the following formats:
        /// `projects/PROJECT_ID/deidentifyTemplates/TEMPLATE_ID` OR
        /// `organizations/ORGANIZATION_ID/deidentifyTemplates/TEMPLATE_ID`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The last update timestamp of an inspectTemplate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// δ-presence metric, used to estimate how likely it is for an attacker to figure out that one given individual
    /// appears in a de-identified dataset. Similarly to the k-map metric, we cannot compute δ-presence exactly without
    /// knowing the attack dataset, so we use a statistical model instead.
    /// </summary>
    public class GooglePrivacyDlpV2DeltaPresenceEstimationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Several auxiliary tables can be used in the analysis. Each custom_tag used to tag a quasi-identifiers field
        /// must appear in exactly one field of one auxiliary table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auxiliaryTables")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2StatisticalTable> AuxiliaryTables { get; set; }

        /// <summary>Required. Fields considered to be quasi-identifiers. No two fields can have the same tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quasiIds")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2QuasiId> QuasiIds { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 region code to use in the statistical modeling. Set if no column is tagged with a
        /// region-specific InfoType (like US_ZIP_5) or a region code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A DeltaPresenceEstimationHistogramBucket message with the following values: min_probability: 0.1
    /// max_probability: 0.2 frequency: 42 means that there are 42 records for which δ is in [0.1, 0.2). An important
    /// particular case is when min_probability = max_probability = 1: then, every individual who shares this
    /// quasi-identifier combination is in the dataset.
    /// </summary>
    public class GooglePrivacyDlpV2DeltaPresenceEstimationHistogramBucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of records within these probability bounds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketSize")]
        public virtual System.Nullable<long> BucketSize { get; set; }

        /// <summary>Total number of distinct quasi-identifier tuple values in this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketValueCount")]
        public virtual System.Nullable<long> BucketValueCount { get; set; }

        /// <summary>
        /// Sample of quasi-identifier tuple values in this bucket. The total number of classes returned per bucket is
        /// capped at 20.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketValues")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2DeltaPresenceEstimationQuasiIdValues> BucketValues { get; set; }

        /// <summary>Always greater than or equal to min_probability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxProbability")]
        public virtual System.Nullable<double> MaxProbability { get; set; }

        /// <summary>Between 0 and 1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minProbability")]
        public virtual System.Nullable<double> MinProbability { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A tuple of values for the quasi-identifier columns.</summary>
    public class GooglePrivacyDlpV2DeltaPresenceEstimationQuasiIdValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The estimated probability that a given individual sharing these quasi-identifier values is in the dataset.
        /// This value, typically called δ, is the ratio between the number of records in the dataset with these
        /// quasi-identifier values, and the total number of individuals (inside *and* outside the dataset) with these
        /// quasi-identifier values. For example, if there are 15 individuals in the dataset who share the same
        /// quasi-identifier values, and an estimated 100 people in the entire population with these values, then δ is
        /// 0.15.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedProbability")]
        public virtual System.Nullable<double> EstimatedProbability { get; set; }

        /// <summary>The quasi-identifier values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quasiIdsValues")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2Value> QuasiIdsValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Result of the δ-presence computation. Note that these results are an estimation, not exact values.
    /// </summary>
    public class GooglePrivacyDlpV2DeltaPresenceEstimationResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The intervals [min_probability, max_probability) do not overlap. If a value doesn't correspond to any such
        /// interval, the associated frequency is zero. For example, the following records: {min_probability: 0,
        /// max_probability: 0.1, frequency: 17} {min_probability: 0.2, max_probability: 0.3, frequency: 42}
        /// {min_probability: 0.3, max_probability: 0.4, frequency: 99} mean that there are no record with an estimated
        /// probability in [0.1, 0.2) nor larger or equal to 0.4.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deltaPresenceEstimationHistogram")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2DeltaPresenceEstimationHistogramBucket> DeltaPresenceEstimationHistogram { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deprecated; use `InspectionRuleSet` instead. Rule for modifying a `CustomInfoType` to alter behavior under
    /// certain circumstances, depending on the specific details of the rule. Not supported for the `surrogate_type`
    /// custom infoType.
    /// </summary>
    public class GooglePrivacyDlpV2DetectionRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Hotword-based detection rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hotwordRule")]
        public virtual GooglePrivacyDlpV2HotwordRule HotwordRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Custom information type based on a dictionary of words or phrases. This can be used to match sensitive
    /// information specific to the data, such as a list of employee IDs or job titles. Dictionary words are
    /// case-insensitive and all characters other than letters and digits in the unicode [Basic Multilingual
    /// Plane](https://en.wikipedia.org/wiki/Plane_%28Unicode%29#Basic_Multilingual_Plane) will be replaced with
    /// whitespace when scanning for matches, so the dictionary phrase "Sam Johnson" will match all three phrases "sam
    /// johnson", "Sam, Johnson", and "Sam (Johnson)". Additionally, the characters surrounding any match must be of a
    /// different type than the adjacent characters within the word, so letters must be next to non-letters and digits
    /// next to non-digits. For example, the dictionary word "jen" will match the first three letters of the text
    /// "jen123" but will return no matches for "jennifer". Dictionary words containing a large number of characters
    /// that are not letters or digits may result in unexpected findings because such characters are treated as
    /// whitespace. The [limits](https://cloud.google.com/dlp/limits) page contains details about the size limits of
    /// dictionaries. For dictionaries that do not fit within these constraints, consider using
    /// `LargeCustomDictionaryConfig` in the `StoredInfoType` API.
    /// </summary>
    public class GooglePrivacyDlpV2Dictionary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Newline-delimited file of words in Cloud Storage. Only a single file is accepted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudStoragePath")]
        public virtual GooglePrivacyDlpV2CloudStoragePath CloudStoragePath { get; set; }

        /// <summary>List of words or phrases to search for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wordList")]
        public virtual GooglePrivacyDlpV2WordList WordList { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Combines all of the information about a DLP job.</summary>
    public class GooglePrivacyDlpV2DlpJob : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Time when the job was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Time when the job finished.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>A stream of errors encountered running the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2Error> Errors { get; set; }

        /// <summary>Results from inspecting a data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectDetails")]
        public virtual GooglePrivacyDlpV2InspectDataSourceDetails InspectDetails { get; set; }

        /// <summary>If created by a job trigger, the resource name of the trigger that instantiated the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobTriggerName")]
        public virtual string JobTriggerName { get; set; }

        /// <summary>The server-assigned name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Results from analyzing risk of a data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("riskDetails")]
        public virtual GooglePrivacyDlpV2AnalyzeDataSourceRiskDetails RiskDetails { get; set; }

        /// <summary>Time when the job started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>State of a job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The type of job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of a finding within a document.</summary>
    public class GooglePrivacyDlpV2DocumentLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Offset of the line, from the beginning of the file, where the finding is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileOffset")]
        public virtual System.Nullable<long> FileOffset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An entity in a dataset is a field or set of fields that correspond to a single person. For example, in medical
    /// records the `EntityId` might be a patient identifier, or for financial records it might be an account
    /// identifier. This message is used when generalizations or analysis must take into account that multiple rows
    /// correspond to the same entity.
    /// </summary>
    public class GooglePrivacyDlpV2EntityId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Composite key indicating which field contains the entity identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual GooglePrivacyDlpV2FieldId Field { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details information about an error encountered during job execution or the results of an unsuccessful activation
    /// of the JobTrigger.
    /// </summary>
    public class GooglePrivacyDlpV2Error : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Detailed error codes and messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual GoogleRpcStatus Details { get; set; }

        /// <summary>The times the error occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamps")]
        public virtual System.Collections.Generic.IList<object> Timestamps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of exclude infoTypes.</summary>
    public class GooglePrivacyDlpV2ExcludeInfoTypes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// InfoType list in ExclusionRule rule drops a finding when it overlaps or contained within with a finding of
        /// an infoType from this list. For example, for `InspectionRuleSet.info_types` containing "PHONE_NUMBER"` and
        /// `exclusion_rule` containing `exclude_info_types.info_types` with "EMAIL_ADDRESS" the phone number findings
        /// are dropped if they overlap with EMAIL_ADDRESS finding. That leads to "555-222-2222@example.org" to generate
        /// only a single finding, namely email address.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoTypes")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2InfoType> InfoTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The rule that specifies conditions when findings of infoTypes specified in `InspectionRuleSet` are removed from
    /// results.
    /// </summary>
    public class GooglePrivacyDlpV2ExclusionRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Dictionary which defines the rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dictionary")]
        public virtual GooglePrivacyDlpV2Dictionary Dictionary { get; set; }

        /// <summary>Set of infoTypes for which findings would affect this rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeInfoTypes")]
        public virtual GooglePrivacyDlpV2ExcludeInfoTypes ExcludeInfoTypes { get; set; }

        /// <summary>How the rule is applied, see MatchingType documentation for details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchingType")]
        public virtual string MatchingType { get; set; }

        /// <summary>Regular expression which defines the rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regex")]
        public virtual GooglePrivacyDlpV2Regex Regex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An expression, consisting or an operator and conditions.</summary>
    public class GooglePrivacyDlpV2Expressions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Conditions to apply to the expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual GooglePrivacyDlpV2Conditions Conditions { get; set; }

        /// <summary>
        /// The operator to apply to the result of conditions. Default and currently only supported value is `AND`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logicalOperator")]
        public virtual string LogicalOperator { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>General identifier of a data field in a storage service.</summary>
    public class GooglePrivacyDlpV2FieldId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name describing the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The transformation to apply to the field.</summary>
    public class GooglePrivacyDlpV2FieldTransformation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Only apply the transformation if the condition evaluates to true for the given `RecordCondition`. The
        /// conditions are allowed to reference fields that are not used in the actual transformation. Example Use
        /// Cases: - Apply a different bucket transformation to an age column if the zip code column for the same record
        /// is within a specific range. - Redact a field if the date of birth field is greater than 85.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GooglePrivacyDlpV2RecordCondition Condition { get; set; }

        /// <summary>
        /// Required. Input field(s) to apply the transformation to. When you have columns that reference their position
        /// within a list, omit the index from the FieldId. FieldId name matching ignores the index. For example,
        /// instead of "contact.nums[0].type", use "contact.nums.type".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2FieldId> Fields { get; set; }

        /// <summary>
        /// Treat the contents of the field as free text, and selectively transform content that matches an `InfoType`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoTypeTransformations")]
        public virtual GooglePrivacyDlpV2InfoTypeTransformations InfoTypeTransformations { get; set; }

        /// <summary>Apply the transformation to the entire field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primitiveTransformation")]
        public virtual GooglePrivacyDlpV2PrimitiveTransformation PrimitiveTransformation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Set of files to scan.</summary>
    public class GooglePrivacyDlpV2FileSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The regex-filtered set of files to scan. Exactly one of `url` or `regex_file_set` must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regexFileSet")]
        public virtual GooglePrivacyDlpV2CloudStorageRegexFileSet RegexFileSet { get; set; }

        /// <summary>
        /// The Cloud Storage url of the file(s) to scan, in the format `gs:///`. Trailing wildcard in the path is
        /// allowed. If the url ends in a trailing slash, the bucket or directory represented by the url will be scanned
        /// non-recursively (content in sub-directories will not be scanned). This means that `gs://mybucket/` is
        /// equivalent to `gs://mybucket/*`, and `gs://mybucket/directory/` is equivalent to
        /// `gs://mybucket/directory/*`. Exactly one of `url` or `regex_file_set` must be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a piece of potentially sensitive content.</summary>
    public class GooglePrivacyDlpV2Finding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Timestamp when finding was detected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The unique finding id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findingId")]
        public virtual string FindingId { get; set; }

        /// <summary>The type of content that might have been found. Provided if `excluded_types` is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoType")]
        public virtual GooglePrivacyDlpV2InfoType InfoType { get; set; }

        /// <summary>Time the job started that produced this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobCreateTime")]
        public virtual object JobCreateTime { get; set; }

        /// <summary>The job that stored the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobName")]
        public virtual string JobName { get; set; }

        /// <summary>
        /// The labels associated with this `Finding`. Label keys must be between 1 and 63 characters long and must
        /// conform to the following regular expression: `[a-z]([-a-z0-9]*[a-z0-9])?`. Label values must be between 0
        /// and 63 characters long and must conform to the regular expression `([a-z]([-a-z0-9]*[a-z0-9])?)?`. No more
        /// than 10 labels can be associated with a given finding. Examples: * `"environment" : "production"` *
        /// `"pipeline" : "etl"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>Confidence of how likely it is that the `info_type` is correct.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("likelihood")]
        public virtual string Likelihood { get; set; }

        /// <summary>Where the content was found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual GooglePrivacyDlpV2Location Location { get; set; }

        /// <summary>
        /// Resource name in format projects/{project}/locations/{location}/findings/{finding} Populated only when
        /// viewing persisted findings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The content that was found. Even if the content is not textual, it may be converted to a textual
        /// representation here. Provided if `include_quote` is true and the finding is less than or equal to 4096 bytes
        /// long. If the finding exceeds 4096 bytes in length, the quote may be omitted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quote")]
        public virtual string Quote { get; set; }

        /// <summary>
        /// Contains data parsed from quotes. Only populated if include_quote was set to true and a supported infoType
        /// was requested. Currently supported infoTypes: DATE, DATE_OF_BIRTH and TIME.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quoteInfo")]
        public virtual GooglePrivacyDlpV2QuoteInfo QuoteInfo { get; set; }

        /// <summary>The job that stored the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Job trigger name, if applicable, for this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerName")]
        public virtual string TriggerName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration to control the number of findings returned. Cannot be set if de-identification is requested.
    /// </summary>
    public class GooglePrivacyDlpV2FindingLimits : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration of findings limit given for specified infoTypes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxFindingsPerInfoType")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2InfoTypeLimit> MaxFindingsPerInfoType { get; set; }

        /// <summary>
        /// Max number of findings that will be returned for each item scanned. When set within `InspectJobConfig`, the
        /// maximum returned is 2000 regardless if this is set higher. When set within `InspectContentRequest`, this
        /// field is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxFindingsPerItem")]
        public virtual System.Nullable<int> MaxFindingsPerItem { get; set; }

        /// <summary>
        /// Max number of findings that will be returned per request/job. When set within `InspectContentRequest`, the
        /// maximum returned is 2000 regardless if this is set higher.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxFindingsPerRequest")]
        public virtual System.Nullable<int> MaxFindingsPerRequest { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for finishing a DLP hybrid job.</summary>
    public class GooglePrivacyDlpV2FinishDlpJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality,
    /// but requires more configuration. This message is provided as a convenience to the user for simple bucketing
    /// strategies. The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if
    /// lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with "10-20".
    /// This can be used on data of type: double, long. If the bound Value type differs from the type of data being
    /// transformed, we will first attempt converting the type of the data to be transformed to match the type of the
    /// bound before comparing. See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// </summary>
    public class GooglePrivacyDlpV2FixedSizeBucketingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Size of each bucket (except for minimum and maximum buckets). So if `lower_bound` = 10,
        /// `upper_bound` = 89, and `bucket_size` = 10, then the following buckets would be used: -10, 10-20, 20-30,
        /// 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+. Precision up to 2 decimals works.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketSize")]
        public virtual System.Nullable<double> BucketSize { get; set; }

        /// <summary>
        /// Required. Lower bound value of buckets. All values less than `lower_bound` are grouped together into a
        /// single bucket; for example if `lower_bound` = 10, then all values less than 10 are replaced with the value
        /// "-10".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowerBound")]
        public virtual GooglePrivacyDlpV2Value LowerBound { get; set; }

        /// <summary>
        /// Required. Upper bound value of buckets. All values greater than upper_bound are grouped together into a
        /// single bucket; for example if `upper_bound` = 89, then all values greater than 89 are replaced with the
        /// value "89+".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upperBound")]
        public virtual GooglePrivacyDlpV2Value UpperBound { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The rule that adjusts the likelihood of findings within a certain proximity of hotwords.</summary>
    public class GooglePrivacyDlpV2HotwordRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Regular expression pattern defining what qualifies as a hotword.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hotwordRegex")]
        public virtual GooglePrivacyDlpV2Regex HotwordRegex { get; set; }

        /// <summary>Likelihood adjustment to apply to all matching findings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("likelihoodAdjustment")]
        public virtual GooglePrivacyDlpV2LikelihoodAdjustment LikelihoodAdjustment { get; set; }

        /// <summary>
        /// Proximity of the finding within which the entire hotword must reside. The total length of the window cannot
        /// exceed 1000 characters. Note that the finding itself will be included in the window, so that hotwords may be
        /// used to match substrings of the finding itself. For example, the certainty of a phone number regex
        /// "\(\d{3}\) \d{3}-\d{4}" could be adjusted upwards if the area code is known to be the local area code of a
        /// company office using the hotword regex "\(xxx\)", where "xxx" is the area code in question.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("proximity")]
        public virtual GooglePrivacyDlpV2Proximity Proximity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An individual hybrid item to inspect. Will be stored temporarily during processing.</summary>
    public class GooglePrivacyDlpV2HybridContentItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Supplementary information that will be added to each finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findingDetails")]
        public virtual GooglePrivacyDlpV2HybridFindingDetails FindingDetails { get; set; }

        /// <summary>The item to inspect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("item")]
        public virtual GooglePrivacyDlpV2ContentItem Item { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Populate to associate additional data with each finding.</summary>
    public class GooglePrivacyDlpV2HybridFindingDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Details about the container where the content being inspected is from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containerDetails")]
        public virtual GooglePrivacyDlpV2Container ContainerDetails { get; set; }

        /// <summary>
        /// Offset in bytes of the line, from the beginning of the file, where the finding is located. Populate if the
        /// item being scanned is only part of a bigger item, such as a shard of a file and you want to track the
        /// absolute position of the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileOffset")]
        public virtual System.Nullable<long> FileOffset { get; set; }

        /// <summary>
        /// Labels to represent user provided metadata about the data being inspected. If configured by the job, some
        /// key values may be required. The labels associated with `Finding`'s produced by hybrid inspection. Label keys
        /// must be between 1 and 63 characters long and must conform to the following regular expression:
        /// `[a-z]([-a-z0-9]*[a-z0-9])?`. Label values must be between 0 and 63 characters long and must conform to the
        /// regular expression `([a-z]([-a-z0-9]*[a-z0-9])?)?`. No more than 10 labels can be associated with a given
        /// finding. Examples: * `"environment" : "production"` * `"pipeline" : "etl"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Offset of the row for tables. Populate if the row(s) being scanned are part of a bigger dataset and you want
        /// to keep track of their absolute position.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowOffset")]
        public virtual System.Nullable<long> RowOffset { get; set; }

        /// <summary>
        /// If the container is a table, additional information to make findings meaningful such as the columns that are
        /// primary keys. If not known ahead of time, can also be set within each inspect hybrid call and the two will
        /// be merged. Note that identifying_fields will only be stored to BigQuery, and only if the BigQuery action has
        /// been included.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableOptions")]
        public virtual GooglePrivacyDlpV2TableOptions TableOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to search for potentially sensitive info in a custom location.</summary>
    public class GooglePrivacyDlpV2HybridInspectDlpJobRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The item to inspect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hybridItem")]
        public virtual GooglePrivacyDlpV2HybridContentItem HybridItem { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to search for potentially sensitive info in a custom location.</summary>
    public class GooglePrivacyDlpV2HybridInspectJobTriggerRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The item to inspect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hybridItem")]
        public virtual GooglePrivacyDlpV2HybridContentItem HybridItem { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Quota exceeded errors will be thrown once quota has been met.</summary>
    public class GooglePrivacyDlpV2HybridInspectResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics related to processing hybrid inspect requests.</summary>
    public class GooglePrivacyDlpV2HybridInspectStatistics : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The number of hybrid inspection requests aborted because the job ran out of quota or was ended before they
        /// could be processed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("abortedCount")]
        public virtual System.Nullable<long> AbortedCount { get; set; }

        /// <summary>
        /// The number of hybrid requests currently being processed. Only populated when called via method `getDlpJob`.
        /// A burst of traffic may cause hybrid inspect requests to be enqueued. Processing will take place as quickly
        /// as possible, but resource limitations may impact how long a request is enqueued for.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingCount")]
        public virtual System.Nullable<long> PendingCount { get; set; }

        /// <summary>The number of hybrid inspection requests processed within this job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processedCount")]
        public virtual System.Nullable<long> ProcessedCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration to control jobs where the content being inspected is outside of Google Cloud Platform.
    /// </summary>
    public class GooglePrivacyDlpV2HybridOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A short description of where the data is coming from. Will be stored once in the job. 256 max length.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// To organize findings, these labels will be added to each finding. Label keys must be between 1 and 63
        /// characters long and must conform to the following regular expression: `[a-z]([-a-z0-9]*[a-z0-9])?`. Label
        /// values must be between 0 and 63 characters long and must conform to the regular expression
        /// `([a-z]([-a-z0-9]*[a-z0-9])?)?`. No more than 10 labels can be associated with a given finding. Examples: *
        /// `"environment" : "production"` * `"pipeline" : "etl"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// These are labels that each inspection request must include within their 'finding_labels' map. Request may
        /// contain others, but any missing one of these will be rejected. Label keys must be between 1 and 63
        /// characters long and must conform to the following regular expression: `[a-z]([-a-z0-9]*[a-z0-9])?`. No more
        /// than 10 keys can be required.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredFindingLabelKeys")]
        public virtual System.Collections.Generic.IList<string> RequiredFindingLabelKeys { get; set; }

        /// <summary>
        /// If the container is a table, additional information to make findings meaningful such as the columns that are
        /// primary keys.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableOptions")]
        public virtual GooglePrivacyDlpV2TableOptions TableOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of the finding within an image.</summary>
    public class GooglePrivacyDlpV2ImageLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bounding boxes locating the pixels within the image containing the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boundingBoxes")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2BoundingBox> BoundingBoxes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for determining how redaction of images should occur.</summary>
    public class GooglePrivacyDlpV2ImageRedactionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Only one per info_type should be provided per request. If not specified, and redact_all_text is false, the
        /// DLP API will redact all text that it matches against all info_types that are found, but not specified in
        /// another ImageRedactionConfig.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoType")]
        public virtual GooglePrivacyDlpV2InfoType InfoType { get; set; }

        /// <summary>
        /// If true, all text found in the image, regardless whether it matches an info_type, is redacted. Only one
        /// should be provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redactAllText")]
        public virtual System.Nullable<bool> RedactAllText { get; set; }

        /// <summary>
        /// The color to use when redacting content from an image. If not specified, the default is black.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redactionColor")]
        public virtual GooglePrivacyDlpV2Color RedactionColor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Type of information detected by the API.</summary>
    public class GooglePrivacyDlpV2InfoType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the information type. Either a name of your choosing when creating a CustomInfoType, or one of the
        /// names listed at https://cloud.google.com/dlp/docs/infotypes-reference when specifying a built-in type. When
        /// sending Cloud DLP results to Data Catalog, infoType names should conform to the pattern
        /// `[A-Za-z0-9$-_]{1,64}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>InfoType description.</summary>
    public class GooglePrivacyDlpV2InfoTypeDescription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the infotype. Translated when language is provided in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Human readable form of the infoType name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Internal name of the infoType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Which parts of the API supports this InfoType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedBy")]
        public virtual System.Collections.Generic.IList<string> SupportedBy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Max findings configuration per infoType, per content item or long running DlpJob.</summary>
    public class GooglePrivacyDlpV2InfoTypeLimit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Type of information the findings limit applies to. Only one limit per info_type should be provided. If
        /// InfoTypeLimit does not have an info_type, the DLP API applies the limit against all info_types that are
        /// found but not specified in another InfoTypeLimit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoType")]
        public virtual GooglePrivacyDlpV2InfoType InfoType { get; set; }

        /// <summary>Max findings limit for the given infoType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxFindings")]
        public virtual System.Nullable<int> MaxFindings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics regarding a specific InfoType.</summary>
    public class GooglePrivacyDlpV2InfoTypeStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of findings for this infoType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>The type of finding this stat is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoType")]
        public virtual GooglePrivacyDlpV2InfoType InfoType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A transformation to apply to text that is identified as a specific info_type.</summary>
    public class GooglePrivacyDlpV2InfoTypeTransformation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// InfoTypes to apply the transformation to. An empty list will cause this transformation to apply to all
        /// findings that correspond to infoTypes that were requested in `InspectConfig`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoTypes")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2InfoType> InfoTypes { get; set; }

        /// <summary>Required. Primitive transformation to apply to the infoType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primitiveTransformation")]
        public virtual GooglePrivacyDlpV2PrimitiveTransformation PrimitiveTransformation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A type of transformation that will scan unstructured text and apply various `PrimitiveTransformation`s to each
    /// finding, where the transformation is applied to only values that were identified as a specific info_type.
    /// </summary>
    public class GooglePrivacyDlpV2InfoTypeTransformations : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Transformation for each infoType. Cannot specify more than one for a given infoType.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformations")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2InfoTypeTransformation> Transformations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration description of the scanning process. When used with redactContent only info_types and
    /// min_likelihood are currently used.
    /// </summary>
    public class GooglePrivacyDlpV2InspectConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of options defining data content to scan. If empty, text, images, and other content will be included.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentOptions")]
        public virtual System.Collections.Generic.IList<string> ContentOptions { get; set; }

        /// <summary>
        /// CustomInfoTypes provided by the user. See https://cloud.google.com/dlp/docs/creating-custom-infotypes to
        /// learn more.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customInfoTypes")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2CustomInfoType> CustomInfoTypes { get; set; }

        /// <summary>When true, excludes type information of the findings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludeInfoTypes")]
        public virtual System.Nullable<bool> ExcludeInfoTypes { get; set; }

        /// <summary>
        /// When true, a contextual quote from the data that triggered a finding is included in the response; see
        /// Finding.quote.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeQuote")]
        public virtual System.Nullable<bool> IncludeQuote { get; set; }

        /// <summary>
        /// Restricts what info_types to look for. The values must correspond to InfoType values returned by
        /// ListInfoTypes or listed at https://cloud.google.com/dlp/docs/infotypes-reference. When no InfoTypes or
        /// CustomInfoTypes are specified in a request, the system may automatically choose what detectors to run. By
        /// default this may be all types, but may change over time as detectors are updated. If you need precise
        /// control and predictability as to what detectors are run you should specify specific InfoTypes listed in the
        /// reference, otherwise a default list will be used, which may change over time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoTypes")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2InfoType> InfoTypes { get; set; }

        /// <summary>Configuration to control the number of findings returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("limits")]
        public virtual GooglePrivacyDlpV2FindingLimits Limits { get; set; }

        /// <summary>
        /// Only returns findings equal or above this threshold. The default is POSSIBLE. See
        /// https://cloud.google.com/dlp/docs/likelihood to learn more.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minLikelihood")]
        public virtual string MinLikelihood { get; set; }

        /// <summary>
        /// Set of rules to apply to the findings for this InspectConfig. Exclusion rules, contained in the set are
        /// executed in the end, other rules are executed in the order they are specified for each info type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ruleSet")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2InspectionRuleSet> RuleSet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to search for potentially sensitive info in a ContentItem.</summary>
    public class GooglePrivacyDlpV2InspectContentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Configuration for the inspector. What specified here will override the template referenced by the
        /// inspect_template_name argument.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectConfig")]
        public virtual GooglePrivacyDlpV2InspectConfig InspectConfig { get; set; }

        /// <summary>
        /// Template to use. Any configuration directly specified in inspect_config will override those set in the
        /// template. Singular fields that are set in this request will replace their corresponding fields in the
        /// template. Repeated fields are appended. Singular sub-messages and groups are recursively merged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectTemplateName")]
        public virtual string InspectTemplateName { get; set; }

        /// <summary>The item to inspect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("item")]
        public virtual GooglePrivacyDlpV2ContentItem Item { get; set; }

        /// <summary>Deprecated. This field has no effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Results of inspecting an item.</summary>
    public class GooglePrivacyDlpV2InspectContentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The findings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual GooglePrivacyDlpV2InspectResult Result { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The results of an inspect DataSource job.</summary>
    public class GooglePrivacyDlpV2InspectDataSourceDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration used for this job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedOptions")]
        public virtual GooglePrivacyDlpV2RequestedOptions RequestedOptions { get; set; }

        /// <summary>A summary of the outcome of this inspection job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("result")]
        public virtual GooglePrivacyDlpV2Result Result { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Controls what and how to inspect for findings.</summary>
    public class GooglePrivacyDlpV2InspectJobConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Actions to execute at the completion of the job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2Action> Actions { get; set; }

        /// <summary>How and what to scan for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectConfig")]
        public virtual GooglePrivacyDlpV2InspectConfig InspectConfig { get; set; }

        /// <summary>
        /// If provided, will be used as the default for all values in InspectConfig. `inspect_config` will be merged
        /// into the values persisted as part of the template.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectTemplateName")]
        public virtual string InspectTemplateName { get; set; }

        /// <summary>The data to scan.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageConfig")]
        public virtual GooglePrivacyDlpV2StorageConfig StorageConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>All the findings for a single scanned item.</summary>
    public class GooglePrivacyDlpV2InspectResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of findings for an item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findings")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2Finding> Findings { get; set; }

        /// <summary>
        /// If true, then this item might have more findings than were returned, and the findings returned are an
        /// arbitrary subset of all findings. The findings list might be truncated because the input items were too
        /// large, or because the server reached the maximum amount of resources allowed for a single API call. For best
        /// results, divide the input into smaller batches.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findingsTruncated")]
        public virtual System.Nullable<bool> FindingsTruncated { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The inspectTemplate contains a configuration (set of types of sensitive data to be detected) to be used anywhere
    /// you otherwise would normally specify InspectConfig. See https://cloud.google.com/dlp/docs/concepts-templates to
    /// learn more.
    /// </summary>
    public class GooglePrivacyDlpV2InspectTemplate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The creation timestamp of an inspectTemplate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Short description (max 256 chars).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display name (max 256 chars).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The core content of the template. Configuration of the scanning process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectConfig")]
        public virtual GooglePrivacyDlpV2InspectConfig InspectConfig { get; set; }

        /// <summary>
        /// Output only. The template name. The template will have one of the following formats:
        /// `projects/PROJECT_ID/inspectTemplates/TEMPLATE_ID` OR
        /// `organizations/ORGANIZATION_ID/inspectTemplates/TEMPLATE_ID`;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The last update timestamp of an inspectTemplate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single inspection rule to be applied to infoTypes, specified in `InspectionRuleSet`.</summary>
    public class GooglePrivacyDlpV2InspectionRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Exclusion rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusionRule")]
        public virtual GooglePrivacyDlpV2ExclusionRule ExclusionRule { get; set; }

        /// <summary>Hotword-based detection rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hotwordRule")]
        public virtual GooglePrivacyDlpV2HotwordRule HotwordRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Rule set for modifying a set of infoTypes to alter behavior under certain circumstances, depending on the
    /// specific details of the rules within the set.
    /// </summary>
    public class GooglePrivacyDlpV2InspectionRuleSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of infoTypes this rule set is applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoTypes")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2InfoType> InfoTypes { get; set; }

        /// <summary>Set of rules to be applied to infoTypes. The rules are applied in order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rules")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2InspectionRule> Rules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Enable email notification to project owners and editors on jobs's completion/failure.</summary>
    public class GooglePrivacyDlpV2JobNotificationEmails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains a configuration to make dlp api calls on a repeating basis. See
    /// https://cloud.google.com/dlp/docs/concepts-job-triggers to learn more.
    /// </summary>
    public class GooglePrivacyDlpV2JobTrigger : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The creation timestamp of a triggeredJob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>User provided description (max 256 chars)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Display name (max 100 chars)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. A stream of errors encountered when the trigger was activated. Repeated errors may result in
        /// the JobTrigger automatically being paused. Will return the last 100 errors. Whenever the JobTrigger is
        /// modified this list will be cleared.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2Error> Errors { get; set; }

        /// <summary>For inspect jobs, a snapshot of the configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectJob")]
        public virtual GooglePrivacyDlpV2InspectJobConfig InspectJob { get; set; }

        /// <summary>Output only. The timestamp of the last time this trigger executed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastRunTime")]
        public virtual object LastRunTime { get; set; }

        /// <summary>
        /// Unique resource name for the triggeredJob, assigned by the service when the triggeredJob is created, for
        /// example `projects/dlp-test-project/jobTriggers/53234423`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. A status for this trigger.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// A list of triggers which will be OR'ed together. Only one in the list needs to trigger for a job to be
        /// started. The list may contain only a single Schedule trigger and must have at least one object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggers")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2Trigger> Triggers { get; set; }

        /// <summary>Output only. The last update timestamp of a triggeredJob.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>k-anonymity metric, used for analysis of reidentification risk.</summary>
    public class GooglePrivacyDlpV2KAnonymityConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Message indicating that multiple rows might be associated to a single individual. If the same entity_id is
        /// associated to multiple quasi-identifier tuples over distinct rows, we consider the entire collection of
        /// tuples as the composite quasi-identifier. This collection is a multiset: the order in which the different
        /// tuples appear in the dataset is ignored, but their frequency is taken into account. Important note: a
        /// maximum of 1000 rows can be associated to a single entity ID. If more rows are associated with the same
        /// entity ID, some might be ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
        public virtual GooglePrivacyDlpV2EntityId EntityId { get; set; }

        /// <summary>
        /// Set of fields to compute k-anonymity over. When multiple fields are specified, they are considered a single
        /// composite key. Structs and repeated data types are not supported; however, nested fields are supported so
        /// long as they are not structs themselves or nested within a repeated field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quasiIds")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2FieldId> QuasiIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The set of columns' values that share the same ldiversity value</summary>
    public class GooglePrivacyDlpV2KAnonymityEquivalenceClass : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Size of the equivalence class, for example number of rows with the above set of values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("equivalenceClassSize")]
        public virtual System.Nullable<long> EquivalenceClassSize { get; set; }

        /// <summary>
        /// Set of values defining the equivalence class. One value per quasi-identifier column in the original
        /// KAnonymity metric message. The order is always the same as the original request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quasiIdsValues")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2Value> QuasiIdsValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Histogram of k-anonymity equivalence classes.</summary>
    public class GooglePrivacyDlpV2KAnonymityHistogramBucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total number of equivalence classes in this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketSize")]
        public virtual System.Nullable<long> BucketSize { get; set; }

        /// <summary>Total number of distinct equivalence classes in this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketValueCount")]
        public virtual System.Nullable<long> BucketValueCount { get; set; }

        /// <summary>
        /// Sample of equivalence classes in this bucket. The total number of classes returned per bucket is capped at
        /// 20.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketValues")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2KAnonymityEquivalenceClass> BucketValues { get; set; }

        /// <summary>Lower bound on the size of the equivalence classes in this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("equivalenceClassSizeLowerBound")]
        public virtual System.Nullable<long> EquivalenceClassSizeLowerBound { get; set; }

        /// <summary>Upper bound on the size of the equivalence classes in this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("equivalenceClassSizeUpperBound")]
        public virtual System.Nullable<long> EquivalenceClassSizeUpperBound { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result of the k-anonymity computation.</summary>
    public class GooglePrivacyDlpV2KAnonymityResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Histogram of k-anonymity equivalence classes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("equivalenceClassHistogramBuckets")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2KAnonymityHistogramBucket> EquivalenceClassHistogramBuckets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Reidentifiability metric. This corresponds to a risk model similar to what is called "journalist risk" in the
    /// literature, except the attack dataset is statistically modeled instead of being perfectly known. This can be
    /// done using publicly available data (like the US Census), or using a custom statistical model (indicated as one
    /// or several BigQuery tables), or by extrapolating from the distribution of values in the input dataset.
    /// </summary>
    public class GooglePrivacyDlpV2KMapEstimationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Several auxiliary tables can be used in the analysis. Each custom_tag used to tag a quasi-identifiers column
        /// must appear in exactly one column of one auxiliary table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auxiliaryTables")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2AuxiliaryTable> AuxiliaryTables { get; set; }

        /// <summary>
        /// Required. Fields considered to be quasi-identifiers. No two columns can have the same tag.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quasiIds")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2TaggedField> QuasiIds { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 region code to use in the statistical modeling. Set if no column is tagged with a
        /// region-specific InfoType (like US_ZIP_5) or a region code.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A KMapEstimationHistogramBucket message with the following values: min_anonymity: 3 max_anonymity: 5 frequency:
    /// 42 means that there are 42 records whose quasi-identifier values correspond to 3, 4 or 5 people in the overlying
    /// population. An important particular case is when min_anonymity = max_anonymity = 1: the frequency field then
    /// corresponds to the number of uniquely identifiable records.
    /// </summary>
    public class GooglePrivacyDlpV2KMapEstimationHistogramBucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of records within these anonymity bounds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketSize")]
        public virtual System.Nullable<long> BucketSize { get; set; }

        /// <summary>Total number of distinct quasi-identifier tuple values in this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketValueCount")]
        public virtual System.Nullable<long> BucketValueCount { get; set; }

        /// <summary>
        /// Sample of quasi-identifier tuple values in this bucket. The total number of classes returned per bucket is
        /// capped at 20.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketValues")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2KMapEstimationQuasiIdValues> BucketValues { get; set; }

        /// <summary>Always greater than or equal to min_anonymity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxAnonymity")]
        public virtual System.Nullable<long> MaxAnonymity { get; set; }

        /// <summary>Always positive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minAnonymity")]
        public virtual System.Nullable<long> MinAnonymity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A tuple of values for the quasi-identifier columns.</summary>
    public class GooglePrivacyDlpV2KMapEstimationQuasiIdValues : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The estimated anonymity for these quasi-identifier values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("estimatedAnonymity")]
        public virtual System.Nullable<long> EstimatedAnonymity { get; set; }

        /// <summary>The quasi-identifier values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quasiIdsValues")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2Value> QuasiIdsValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Result of the reidentifiability analysis. Note that these results are an estimation, not exact values.
    /// </summary>
    public class GooglePrivacyDlpV2KMapEstimationResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The intervals [min_anonymity, max_anonymity] do not overlap. If a value doesn't correspond to any such
        /// interval, the associated frequency is zero. For example, the following records: {min_anonymity: 1,
        /// max_anonymity: 1, frequency: 17} {min_anonymity: 2, max_anonymity: 3, frequency: 42} {min_anonymity: 5,
        /// max_anonymity: 10, frequency: 99} mean that there are no record with an estimated anonymity of 4, 5, or
        /// larger than 10.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kMapEstimationHistogram")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2KMapEstimationHistogramBucket> KMapEstimationHistogram { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A unique identifier for a Datastore entity. If a key's partition ID or any of its path kinds or names are
    /// reserved/read-only, the key is reserved/read-only. A reserved/read-only key is forbidden in certain documented
    /// contexts.
    /// </summary>
    public class GooglePrivacyDlpV2Key : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Entities are partitioned into subsets, currently identified by a project ID and namespace ID. Queries are
        /// scoped to a single partition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partitionId")]
        public virtual GooglePrivacyDlpV2PartitionId PartitionId { get; set; }

        /// <summary>
        /// The entity path. An entity path consists of one or more elements composed of a kind and a string or
        /// numerical identifier, which identify entities. The first element identifies a _root entity_, the second
        /// element identifies a _child_ of the root entity, the third element identifies a child of the second entity,
        /// and so forth. The entities identified by all prefixes of the path are called the element's _ancestors_. A
        /// path can never be empty, and a path can have at most 100 elements.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2PathElement> Path { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A representation of a Datastore kind.</summary>
    public class GooglePrivacyDlpV2KindExpression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the kind.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key.
    /// Authorization requires the following IAM permissions when sending a request to perform a crypto transformation
    /// using a KMS-wrapped crypto key: dlp.kms.encrypt For more information, see [Creating a wrapped key]
    /// (https://cloud.google.com/dlp/docs/create-wrapped-key).
    /// </summary>
    public class GooglePrivacyDlpV2KmsWrappedCryptoKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The resource name of the KMS CryptoKey to use for unwrapping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKeyName")]
        public virtual string CryptoKeyName { get; set; }

        /// <summary>Required. The wrapped data crypto key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wrappedKey")]
        public virtual string WrappedKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>l-diversity metric, used for analysis of reidentification risk.</summary>
    public class GooglePrivacyDlpV2LDiversityConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set of quasi-identifiers indicating how equivalence classes are defined for the l-diversity computation.
        /// When multiple fields are specified, they are considered a single composite key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quasiIds")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2FieldId> QuasiIds { get; set; }

        /// <summary>Sensitive field for computing the l-value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sensitiveAttribute")]
        public virtual GooglePrivacyDlpV2FieldId SensitiveAttribute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The set of columns' values that share the same ldiversity value.</summary>
    public class GooglePrivacyDlpV2LDiversityEquivalenceClass : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Size of the k-anonymity equivalence class.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("equivalenceClassSize")]
        public virtual System.Nullable<long> EquivalenceClassSize { get; set; }

        /// <summary>Number of distinct sensitive values in this equivalence class.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numDistinctSensitiveValues")]
        public virtual System.Nullable<long> NumDistinctSensitiveValues { get; set; }

        /// <summary>
        /// Quasi-identifier values defining the k-anonymity equivalence class. The order is always the same as the
        /// original request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quasiIdsValues")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2Value> QuasiIdsValues { get; set; }

        /// <summary>Estimated frequencies of top sensitive values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topSensitiveValues")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2ValueFrequency> TopSensitiveValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Histogram of l-diversity equivalence class sensitive value frequencies.</summary>
    public class GooglePrivacyDlpV2LDiversityHistogramBucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total number of equivalence classes in this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketSize")]
        public virtual System.Nullable<long> BucketSize { get; set; }

        /// <summary>Total number of distinct equivalence classes in this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketValueCount")]
        public virtual System.Nullable<long> BucketValueCount { get; set; }

        /// <summary>
        /// Sample of equivalence classes in this bucket. The total number of classes returned per bucket is capped at
        /// 20.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketValues")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2LDiversityEquivalenceClass> BucketValues { get; set; }

        /// <summary>Lower bound on the sensitive value frequencies of the equivalence classes in this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sensitiveValueFrequencyLowerBound")]
        public virtual System.Nullable<long> SensitiveValueFrequencyLowerBound { get; set; }

        /// <summary>Upper bound on the sensitive value frequencies of the equivalence classes in this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sensitiveValueFrequencyUpperBound")]
        public virtual System.Nullable<long> SensitiveValueFrequencyUpperBound { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result of the l-diversity computation.</summary>
    public class GooglePrivacyDlpV2LDiversityResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Histogram of l-diversity equivalence class sensitive value frequencies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sensitiveValueFrequencyHistogramBuckets")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2LDiversityHistogramBucket> SensitiveValueFrequencyHistogramBuckets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for a custom dictionary created from a data source of any size up to the maximum size defined in
    /// the [limits](https://cloud.google.com/dlp/limits) page. The artifacts of dictionary creation are stored in the
    /// specified Google Cloud Storage location. Consider using `CustomInfoType.Dictionary` for smaller dictionaries
    /// that satisfy the size requirements.
    /// </summary>
    public class GooglePrivacyDlpV2LargeCustomDictionaryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Field in a BigQuery table where each cell represents a dictionary phrase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigQueryField")]
        public virtual GooglePrivacyDlpV2BigQueryField BigQueryField { get; set; }

        /// <summary>Set of files containing newline-delimited lists of dictionary phrases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudStorageFileSet")]
        public virtual GooglePrivacyDlpV2CloudStorageFileSet CloudStorageFileSet { get; set; }

        /// <summary>
        /// Location to store dictionary artifacts in Google Cloud Storage. These files will only be accessible by
        /// project owners and the DLP API. If any of these artifacts are modified, the dictionary is considered invalid
        /// and can no longer be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputPath")]
        public virtual GooglePrivacyDlpV2CloudStoragePath OutputPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Summary statistics of a custom dictionary.</summary>
    public class GooglePrivacyDlpV2LargeCustomDictionaryStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Approximate number of distinct phrases in the dictionary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("approxNumPhrases")]
        public virtual System.Nullable<long> ApproxNumPhrases { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Skips the data without modifying it if the requested transformation would cause an error. For example, if a
    /// `DateShift` transformation were applied an an IP address, this mode would leave the IP address unchanged in the
    /// response.
    /// </summary>
    public class GooglePrivacyDlpV2LeaveUntransformed : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message for specifying an adjustment to the likelihood of a finding as part of a detection rule.
    /// </summary>
    public class GooglePrivacyDlpV2LikelihoodAdjustment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set the likelihood of a finding to a fixed value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedLikelihood")]
        public virtual string FixedLikelihood { get; set; }

        /// <summary>
        /// Increase or decrease the likelihood by the specified number of levels. For example, if a finding would be
        /// `POSSIBLE` without the detection rule and `relative_likelihood` is 1, then it is upgraded to `LIKELY`, while
        /// a value of -1 would downgrade it to `UNLIKELY`. Likelihood may never drop below `VERY_UNLIKELY` or exceed
        /// `VERY_LIKELY`, so applying an adjustment of 1 followed by an adjustment of -1 when base likelihood is
        /// `VERY_LIKELY` will result in a final likelihood of `LIKELY`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativeLikelihood")]
        public virtual System.Nullable<int> RelativeLikelihood { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListDeidentifyTemplates.</summary>
    public class GooglePrivacyDlpV2ListDeidentifyTemplatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of deidentify templates, up to page_size in ListDeidentifyTemplatesRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deidentifyTemplates")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2DeidentifyTemplate> DeidentifyTemplates { get; set; }

        /// <summary>
        /// If the next page is available then the next page token to be used in following ListDeidentifyTemplates
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for listing DLP jobs.</summary>
    public class GooglePrivacyDlpV2ListDlpJobsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of DlpJobs that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobs")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2DlpJob> Jobs { get; set; }

        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response to the ListInfoTypes request.</summary>
    public class GooglePrivacyDlpV2ListInfoTypesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set of sensitive infoTypes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoTypes")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2InfoTypeDescription> InfoTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListInspectTemplates.</summary>
    public class GooglePrivacyDlpV2ListInspectTemplatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of inspectTemplates, up to page_size in ListInspectTemplatesRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectTemplates")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2InspectTemplate> InspectTemplates { get; set; }

        /// <summary>
        /// If the next page is available then the next page token to be used in following ListInspectTemplates request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListJobTriggers.</summary>
    public class GooglePrivacyDlpV2ListJobTriggersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of triggeredJobs, up to page_size in ListJobTriggersRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobTriggers")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2JobTrigger> JobTriggers { get; set; }

        /// <summary>
        /// If the next page is available then the next page token to be used in following ListJobTriggers request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListStoredInfoTypes.</summary>
    public class GooglePrivacyDlpV2ListStoredInfoTypesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the next page is available then the next page token to be used in following ListStoredInfoTypes request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of storedInfoTypes, up to page_size in ListStoredInfoTypesRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storedInfoTypes")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2StoredInfoType> StoredInfoTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the location of the finding.</summary>
    public class GooglePrivacyDlpV2Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Zero-based byte offsets delimiting the finding. These are relative to the finding's containing element. Note
        /// that when the content is not textual, this references the UTF-8 encoded textual representation of the
        /// content. Omitted if content is an image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("byteRange")]
        public virtual GooglePrivacyDlpV2Range ByteRange { get; set; }

        /// <summary>
        /// Unicode character offsets delimiting the finding. These are relative to the finding's containing element.
        /// Provided when the content is text.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codepointRange")]
        public virtual GooglePrivacyDlpV2Range CodepointRange { get; set; }

        /// <summary>Information about the container where this finding occurred, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("container")]
        public virtual GooglePrivacyDlpV2Container Container { get; set; }

        /// <summary>
        /// List of nested objects pointing to the precise location of the finding within the file or record.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLocations")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2ContentLocation> ContentLocations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Job trigger option for hybrid jobs. Jobs must be manually created and finished.</summary>
    public class GooglePrivacyDlpV2Manual : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata Location</summary>
    public class GooglePrivacyDlpV2MetadataLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Storage metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageLabel")]
        public virtual GooglePrivacyDlpV2StorageMetadataLabel StorageLabel { get; set; }

        /// <summary>Type of metadata containing the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Compute numerical stats over an individual column, including min, max, and quantiles.</summary>
    public class GooglePrivacyDlpV2NumericalStatsConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Field to compute numerical stats on. Supported types are integer, float, date, datetime, timestamp, time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual GooglePrivacyDlpV2FieldId Field { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result of the numerical stats computation.</summary>
    public class GooglePrivacyDlpV2NumericalStatsResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Maximum value appearing in the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual GooglePrivacyDlpV2Value MaxValue { get; set; }

        /// <summary>Minimum value appearing in the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual GooglePrivacyDlpV2Value MinValue { get; set; }

        /// <summary>List of 99 values that partition the set of field values into 100 equal sized buckets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quantileValues")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2Value> QuantileValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud repository for storing output.</summary>
    public class GooglePrivacyDlpV2OutputStorageConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Schema used for writing the findings for Inspect jobs. This field is only used for Inspect and must be
        /// unspecified for Risk jobs. Columns are derived from the `Finding` object. If appending to an existing table,
        /// any columns from the predefined schema that are missing will be added. No columns in the existing table will
        /// be deleted. If unspecified, then all available columns will be used for a new table or an (existing) table
        /// with no schema, and no changes will be made to an existing table that has a schema. Only for use with
        /// external storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputSchema")]
        public virtual string OutputSchema { get; set; }

        /// <summary>
        /// Store findings in an existing table or a new table in an existing dataset. If table_id is not set a new one
        /// will be generated for you with the following format: dlp_googleapis_yyyy_mm_dd_[dlp_job_id]. Pacific
        /// timezone will be used for generating the date details. For Inspect, each column in an existing output table
        /// must have the same name, type, and mode of a field in the `Finding` object. For Risk, an existing output
        /// table should be the output of a previous Risk analysis job run on the same source table, with the same
        /// privacy metric and quasi-identifiers. Risk jobs that analyze the same table but compute a different privacy
        /// metric, or use different sets of quasi-identifiers, cannot store their results in the same table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual GooglePrivacyDlpV2BigQueryTable Table { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Datastore partition ID. A partition ID identifies a grouping of entities. The grouping is always by project and
    /// namespace, however the namespace ID may be empty. A partition ID contains several dimensions: project ID and
    /// namespace ID.
    /// </summary>
    public class GooglePrivacyDlpV2PartitionId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If not empty, the ID of the namespace to which the entities belong.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespaceId")]
        public virtual string NamespaceId { get; set; }

        /// <summary>The ID of the project to which the entities belong.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A (kind, ID/name) pair used to construct a key path. If either name or ID is set, the element is complete. If
    /// neither is set, the element is incomplete.
    /// </summary>
    public class GooglePrivacyDlpV2PathElement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The auto-allocated ID of the entity. Never equal to zero. Values less than zero are discouraged and may not
        /// be supported in the future.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; }

        /// <summary>
        /// The kind of the entity. A kind matching regex `__.*__` is reserved/read-only. A kind must not contain more
        /// than 1500 bytes when UTF-8 encoded. Cannot be `""`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The name of the entity. A name matching regex `__.*__` is reserved/read-only. A name must not be more than
        /// 1500 bytes when UTF-8 encoded. Cannot be `""`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A rule for transforming a value.</summary>
    public class GooglePrivacyDlpV2PrimitiveTransformation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bucketing</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketingConfig")]
        public virtual GooglePrivacyDlpV2BucketingConfig BucketingConfig { get; set; }

        /// <summary>Mask</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("characterMaskConfig")]
        public virtual GooglePrivacyDlpV2CharacterMaskConfig CharacterMaskConfig { get; set; }

        /// <summary>Deterministic Crypto</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoDeterministicConfig")]
        public virtual GooglePrivacyDlpV2CryptoDeterministicConfig CryptoDeterministicConfig { get; set; }

        /// <summary>Crypto</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoHashConfig")]
        public virtual GooglePrivacyDlpV2CryptoHashConfig CryptoHashConfig { get; set; }

        /// <summary>Ffx-Fpe</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoReplaceFfxFpeConfig")]
        public virtual GooglePrivacyDlpV2CryptoReplaceFfxFpeConfig CryptoReplaceFfxFpeConfig { get; set; }

        /// <summary>Date Shift</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateShiftConfig")]
        public virtual GooglePrivacyDlpV2DateShiftConfig DateShiftConfig { get; set; }

        /// <summary>Fixed size bucketing</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedSizeBucketingConfig")]
        public virtual GooglePrivacyDlpV2FixedSizeBucketingConfig FixedSizeBucketingConfig { get; set; }

        /// <summary>Redact</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redactConfig")]
        public virtual GooglePrivacyDlpV2RedactConfig RedactConfig { get; set; }

        /// <summary>Replace</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaceConfig")]
        public virtual GooglePrivacyDlpV2ReplaceValueConfig ReplaceConfig { get; set; }

        /// <summary>Replace with infotype</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaceWithInfoTypeConfig")]
        public virtual GooglePrivacyDlpV2ReplaceWithInfoTypeConfig ReplaceWithInfoTypeConfig { get; set; }

        /// <summary>Time extraction</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timePartConfig")]
        public virtual GooglePrivacyDlpV2TimePartConfig TimePartConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Privacy metric to compute for reidentification risk analysis.</summary>
    public class GooglePrivacyDlpV2PrivacyMetric : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Categorical stats</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categoricalStatsConfig")]
        public virtual GooglePrivacyDlpV2CategoricalStatsConfig CategoricalStatsConfig { get; set; }

        /// <summary>delta-presence</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deltaPresenceEstimationConfig")]
        public virtual GooglePrivacyDlpV2DeltaPresenceEstimationConfig DeltaPresenceEstimationConfig { get; set; }

        /// <summary>K-anonymity</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kAnonymityConfig")]
        public virtual GooglePrivacyDlpV2KAnonymityConfig KAnonymityConfig { get; set; }

        /// <summary>k-map</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kMapEstimationConfig")]
        public virtual GooglePrivacyDlpV2KMapEstimationConfig KMapEstimationConfig { get; set; }

        /// <summary>l-diversity</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lDiversityConfig")]
        public virtual GooglePrivacyDlpV2LDiversityConfig LDiversityConfig { get; set; }

        /// <summary>Numerical stats</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numericalStatsConfig")]
        public virtual GooglePrivacyDlpV2NumericalStatsConfig NumericalStatsConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for specifying a window around a finding to apply a detection rule.</summary>
    public class GooglePrivacyDlpV2Proximity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of characters after the finding to consider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowAfter")]
        public virtual System.Nullable<int> WindowAfter { get; set; }

        /// <summary>Number of characters before the finding to consider.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("windowBefore")]
        public virtual System.Nullable<int> WindowBefore { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Publish findings of a DlpJob to Cloud Data Catalog. Labels summarizing the results of the DlpJob will be applied
    /// to the entry for the resource scanned in Cloud Data Catalog. Any labels previously written by another DlpJob
    /// will be deleted. InfoType naming patterns are strictly enforced when using this feature. Note that the findings
    /// will be persisted in Cloud Data Catalog storage and are governed by Data Catalog service-specific policy, see
    /// https://cloud.google.com/terms/service-terms Only a single instance of this action can be specified and only
    /// allowed if all resources being scanned are BigQuery tables. Compatible with: Inspect
    /// </summary>
    public class GooglePrivacyDlpV2PublishFindingsToCloudDataCatalog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Publish the result summary of a DlpJob to the Cloud Security Command Center (CSCC Alpha). This action is only
    /// available for projects which are parts of an organization and whitelisted for the alpha Cloud Security Command
    /// Center. The action will publish count of finding instances and their info types. The summary of findings will be
    /// persisted in CSCC and are governed by CSCC service-specific policy, see
    /// https://cloud.google.com/terms/service-terms Only a single instance of this action can be specified. Compatible
    /// with: Inspect
    /// </summary>
    public class GooglePrivacyDlpV2PublishSummaryToCscc : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Publish a message into given Pub/Sub topic when DlpJob has completed. The message contains a single field,
    /// `DlpJobName`, which is equal to the finished job's
    /// [`DlpJob.name`](https://cloud.google.com/dlp/docs/reference/rest/v2/projects.dlpJobs#DlpJob). Compatible with:
    /// Inspect, Risk
    /// </summary>
    public class GooglePrivacyDlpV2PublishToPubSub : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Cloud Pub/Sub topic to send notifications to. The topic must have given publishing access rights to the DLP
        /// API service account executing the long running DlpJob sending the notifications. Format is
        /// projects/{project}/topics/{topic}.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Enable Stackdriver metric dlp.googleapis.com/finding_count. This will publish a metric to stack driver on each
    /// infotype requested and how many findings were found for it. CustomDetectors will be bucketed as 'Custom' under
    /// the Stackdriver label 'info_type'.
    /// </summary>
    public class GooglePrivacyDlpV2PublishToStackdriver : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A column with a semantic tag attached.</summary>
    public class GooglePrivacyDlpV2QuasiId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A column can be tagged with a custom tag. In this case, the user must indicate an auxiliary table that
        /// contains statistical information on the possible values of this column (below).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customTag")]
        public virtual string CustomTag { get; set; }

        /// <summary>Required. Identifies the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual GooglePrivacyDlpV2FieldId Field { get; set; }

        /// <summary>
        /// If no semantic tag is indicated, we infer the statistical model from the distribution of values in the input
        /// data
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inferred")]
        public virtual GoogleProtobufEmpty Inferred { get; set; }

        /// <summary>
        /// A column can be tagged with a InfoType to use the relevant public dataset as a statistical model of
        /// population, if available. We currently support US ZIP codes, region codes, ages and genders. To
        /// programmatically obtain the list of supported InfoTypes, use ListInfoTypes with the
        /// supported_by=RISK_ANALYSIS filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoType")]
        public virtual GooglePrivacyDlpV2InfoType InfoType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A quasi-identifier column has a custom_tag, used to know which column in the data corresponds to which column in
    /// the statistical model.
    /// </summary>
    public class GooglePrivacyDlpV2QuasiIdField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A auxiliary field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customTag")]
        public virtual string CustomTag { get; set; }

        /// <summary>Identifies the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual GooglePrivacyDlpV2FieldId Field { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A quasi-identifier column has a custom_tag, used to know which column in the data corresponds to which column in
    /// the statistical model.
    /// </summary>
    public class GooglePrivacyDlpV2QuasiIdentifierField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A column can be tagged with a custom tag. In this case, the user must indicate an auxiliary table that
        /// contains statistical information on the possible values of this column (below).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customTag")]
        public virtual string CustomTag { get; set; }

        /// <summary>Identifies the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual GooglePrivacyDlpV2FieldId Field { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for infoType-dependent details parsed from quote.</summary>
    public class GooglePrivacyDlpV2QuoteInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The date time indicated by the quote.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTime")]
        public virtual GooglePrivacyDlpV2DateTime DateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Generic half-open interval [start, end)</summary>
    public class GooglePrivacyDlpV2Range : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Index of the last character of the range (exclusive).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual System.Nullable<long> End { get; set; }

        /// <summary>Index of the first character of the range (inclusive).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual System.Nullable<long> Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A condition for determining whether a transformation should be applied to a field.</summary>
    public class GooglePrivacyDlpV2RecordCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expressions")]
        public virtual GooglePrivacyDlpV2Expressions Expressions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message for a unique key indicating a record that contains a finding.</summary>
    public class GooglePrivacyDlpV2RecordKey : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("bigQueryKey")]
        public virtual GooglePrivacyDlpV2BigQueryKey BigQueryKey { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("datastoreKey")]
        public virtual GooglePrivacyDlpV2DatastoreKey DatastoreKey { get; set; }

        /// <summary>
        /// Values of identifying columns in the given row. Order of values matches the order of `identifying_fields`
        /// specified in the scanning request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idValues")]
        public virtual System.Collections.Generic.IList<string> IdValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of a finding within a row or record.</summary>
    public class GooglePrivacyDlpV2RecordLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Field id of the field containing the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldId")]
        public virtual GooglePrivacyDlpV2FieldId FieldId { get; set; }

        /// <summary>Key of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordKey")]
        public virtual GooglePrivacyDlpV2RecordKey RecordKey { get; set; }

        /// <summary>Location within a `ContentItem.Table`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableLocation")]
        public virtual GooglePrivacyDlpV2TableLocation TableLocation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration to suppress records whose suppression conditions evaluate to true.</summary>
    public class GooglePrivacyDlpV2RecordSuppression : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A condition that when it evaluates to true will result in the record being evaluated to be suppressed from
        /// the transformed content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual GooglePrivacyDlpV2RecordCondition Condition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A type of transformation that is applied over structured data such as a table.</summary>
    public class GooglePrivacyDlpV2RecordTransformations : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Transform the record by applying various field transformations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldTransformations")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2FieldTransformation> FieldTransformations { get; set; }

        /// <summary>
        /// Configuration defining which records get suppressed entirely. Records that match any suppression rule are
        /// omitted from the output.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordSuppressions")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2RecordSuppression> RecordSuppressions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Redact a given value. For example, if used with an `InfoTypeTransformation` transforming PHONE_NUMBER, and input
    /// 'My phone number is 206-555-0123', the output would be 'My phone number is '.
    /// </summary>
    public class GooglePrivacyDlpV2RedactConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request to search for potentially sensitive info in an image and redact it by covering it with a colored
    /// rectangle.
    /// </summary>
    public class GooglePrivacyDlpV2RedactImageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The content must be PNG, JPEG, SVG or BMP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("byteItem")]
        public virtual GooglePrivacyDlpV2ByteContentItem ByteItem { get; set; }

        /// <summary>The configuration for specifying what content to redact from images.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageRedactionConfigs")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2ImageRedactionConfig> ImageRedactionConfigs { get; set; }

        /// <summary>Whether the response should include findings along with the redacted image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeFindings")]
        public virtual System.Nullable<bool> IncludeFindings { get; set; }

        /// <summary>Configuration for the inspector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectConfig")]
        public virtual GooglePrivacyDlpV2InspectConfig InspectConfig { get; set; }

        /// <summary>Deprecated. This field has no effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Results of redacting an image.</summary>
    public class GooglePrivacyDlpV2RedactImageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If an image was being inspected and the InspectConfig's include_quote was set to true, then this field will
        /// include all text, if any, that was found in the image.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extractedText")]
        public virtual string ExtractedText { get; set; }

        /// <summary>The findings. Populated when include_findings in the request is true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectResult")]
        public virtual GooglePrivacyDlpV2InspectResult InspectResult { get; set; }

        /// <summary>The redacted image. The type will be the same as the original image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redactedImage")]
        public virtual string RedactedImage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message defining a custom regular expression.</summary>
    public class GooglePrivacyDlpV2Regex : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The index of the submatch to extract as findings. When not specified, the entire match is returned. No more
        /// than 3 may be included.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupIndexes")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> GroupIndexes { get; set; }

        /// <summary>
        /// Pattern defining the regular expression. Its syntax (https://github.com/google/re2/wiki/Syntax) can be found
        /// under the google/re2 repository on GitHub.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pattern")]
        public virtual string Pattern { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to re-identify an item.</summary>
    public class GooglePrivacyDlpV2ReidentifyContentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration for the inspector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectConfig")]
        public virtual GooglePrivacyDlpV2InspectConfig InspectConfig { get; set; }

        /// <summary>
        /// Template to use. Any configuration directly specified in `inspect_config` will override those set in the
        /// template. Singular fields that are set in this request will replace their corresponding fields in the
        /// template. Repeated fields are appended. Singular sub-messages and groups are recursively merged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectTemplateName")]
        public virtual string InspectTemplateName { get; set; }

        /// <summary>The item to re-identify. Will be treated as text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("item")]
        public virtual GooglePrivacyDlpV2ContentItem Item { get; set; }

        /// <summary>Deprecated. This field has no effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>
        /// Configuration for the re-identification of the content item. This field shares the same proto message type
        /// that is used for de-identification, however its usage here is for the reversal of the previous
        /// de-identification. Re-identification is performed by examining the transformations used to de-identify the
        /// items and executing the reverse. This requires that only reversible transformations be provided here. The
        /// reversible transformations are: - `CryptoDeterministicConfig` - `CryptoReplaceFfxFpeConfig`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reidentifyConfig")]
        public virtual GooglePrivacyDlpV2DeidentifyConfig ReidentifyConfig { get; set; }

        /// <summary>
        /// Template to use. References an instance of `DeidentifyTemplate`. Any configuration directly specified in
        /// `reidentify_config` or `inspect_config` will override those set in the template. The `DeidentifyTemplate`
        /// used must include only reversible transformations. Singular fields that are set in this request will replace
        /// their corresponding fields in the template. Repeated fields are appended. Singular sub-messages and groups
        /// are recursively merged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reidentifyTemplateName")]
        public virtual string ReidentifyTemplateName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Results of re-identifying a item.</summary>
    public class GooglePrivacyDlpV2ReidentifyContentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The re-identified item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("item")]
        public virtual GooglePrivacyDlpV2ContentItem Item { get; set; }

        /// <summary>An overview of the changes that were made to the `item`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overview")]
        public virtual GooglePrivacyDlpV2TransformationOverview Overview { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Replace each input value with a given `Value`.</summary>
    public class GooglePrivacyDlpV2ReplaceValueConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Value to replace it with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newValue")]
        public virtual GooglePrivacyDlpV2Value NewValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Replace each matching finding with the name of the info_type.</summary>
    public class GooglePrivacyDlpV2ReplaceWithInfoTypeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Snapshot of the inspection configuration.</summary>
    public class GooglePrivacyDlpV2RequestedOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Inspect config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobConfig")]
        public virtual GooglePrivacyDlpV2InspectJobConfig JobConfig { get; set; }

        /// <summary>If run with an InspectTemplate, a snapshot of its state at the time of this run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshotInspectTemplate")]
        public virtual GooglePrivacyDlpV2InspectTemplate SnapshotInspectTemplate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Risk analysis options.</summary>
    public class GooglePrivacyDlpV2RequestedRiskAnalysisOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The job config for the risk job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobConfig")]
        public virtual GooglePrivacyDlpV2RiskAnalysisJobConfig JobConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>All result fields mentioned below are updated while the job is processing.</summary>
    public class GooglePrivacyDlpV2Result : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Statistics related to the processing of hybrid inspect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hybridStats")]
        public virtual GooglePrivacyDlpV2HybridInspectStatistics HybridStats { get; set; }

        /// <summary>Statistics of how many instances of each info type were found during inspect job.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoTypeStats")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2InfoTypeStats> InfoTypeStats { get; set; }

        /// <summary>Total size in bytes that were processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processedBytes")]
        public virtual System.Nullable<long> ProcessedBytes { get; set; }

        /// <summary>Estimate of the number of bytes to process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalEstimatedBytes")]
        public virtual System.Nullable<long> TotalEstimatedBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for a risk analysis job. See https://cloud.google.com/dlp/docs/concepts-risk-analysis to learn
    /// more.
    /// </summary>
    public class GooglePrivacyDlpV2RiskAnalysisJobConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Actions to execute at the completion of the job. Are executed in the order provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2Action> Actions { get; set; }

        /// <summary>Privacy metric to compute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privacyMetric")]
        public virtual GooglePrivacyDlpV2PrivacyMetric PrivacyMetric { get; set; }

        /// <summary>Input dataset to compute metrics over.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceTable")]
        public virtual GooglePrivacyDlpV2BigQueryTable SourceTable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Values of the row.</summary>
    public class GooglePrivacyDlpV2Row : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Individual cells.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2Value> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// If set, the detailed findings will be persisted to the specified OutputStorageConfig. Only a single instance of
    /// this action can be specified. Compatible with: Inspect, Risk
    /// </summary>
    public class GooglePrivacyDlpV2SaveFindings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Location to store findings outside of DLP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual GooglePrivacyDlpV2OutputStorageConfig OutputConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Schedule for inspect job triggers.</summary>
    public class GooglePrivacyDlpV2Schedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// With this option a job is started a regular periodic basis. For example: every day (86400 seconds). A
        /// scheduled start time will be skipped if the previous execution has not ended when its scheduled time occurs.
        /// This value must be set to a time duration greater than or equal to 1 day and can be no longer than 60 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recurrencePeriodDuration")]
        public virtual object RecurrencePeriodDuration { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An auxiliary table containing statistical information on the relative frequency of different quasi-identifiers
    /// values. It has one or several quasi-identifiers columns, and one column that indicates the relative frequency of
    /// each quasi-identifier tuple. If a tuple is present in the data but not in the auxiliary table, the corresponding
    /// relative frequency is assumed to be zero (and thus, the tuple is highly reidentifiable).
    /// </summary>
    public class GooglePrivacyDlpV2StatisticalTable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Quasi-identifier columns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quasiIds")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2QuasiIdentifierField> QuasiIds { get; set; }

        /// <summary>
        /// Required. The relative frequency column must contain a floating-point number between 0 and 1 (inclusive).
        /// Null values are assumed to be zero.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativeFrequency")]
        public virtual GooglePrivacyDlpV2FieldId RelativeFrequency { get; set; }

        /// <summary>Required. Auxiliary table location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual GooglePrivacyDlpV2BigQueryTable Table { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Shared message indicating Cloud storage type.</summary>
    public class GooglePrivacyDlpV2StorageConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>BigQuery options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigQueryOptions")]
        public virtual GooglePrivacyDlpV2BigQueryOptions BigQueryOptions { get; set; }

        /// <summary>Google Cloud Storage options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudStorageOptions")]
        public virtual GooglePrivacyDlpV2CloudStorageOptions CloudStorageOptions { get; set; }

        /// <summary>Google Cloud Datastore options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datastoreOptions")]
        public virtual GooglePrivacyDlpV2DatastoreOptions DatastoreOptions { get; set; }

        /// <summary>Hybrid inspection options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hybridOptions")]
        public virtual GooglePrivacyDlpV2HybridOptions HybridOptions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("timespanConfig")]
        public virtual GooglePrivacyDlpV2TimespanConfig TimespanConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Storage metadata label to indicate which metadata entry contains findings.</summary>
    public class GooglePrivacyDlpV2StorageMetadataLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// StoredInfoType resource message that contains information about the current version and any pending updates.
    /// </summary>
    public class GooglePrivacyDlpV2StoredInfoType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Current version of the stored info type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentVersion")]
        public virtual GooglePrivacyDlpV2StoredInfoTypeVersion CurrentVersion { get; set; }

        /// <summary>Resource name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Pending versions of the stored info type. Empty if no versions are pending.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingVersions")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2StoredInfoTypeVersion> PendingVersions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for stored infoTypes. All fields and subfield are provided by the user. For more information, see
    /// https://cloud.google.com/dlp/docs/creating-custom-infotypes.
    /// </summary>
    public class GooglePrivacyDlpV2StoredInfoTypeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the StoredInfoType (max 256 characters).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Store dictionary-based CustomInfoType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dictionary")]
        public virtual GooglePrivacyDlpV2Dictionary Dictionary { get; set; }

        /// <summary>Display name of the StoredInfoType (max 256 characters).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>StoredInfoType where findings are defined by a dictionary of phrases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("largeCustomDictionary")]
        public virtual GooglePrivacyDlpV2LargeCustomDictionaryConfig LargeCustomDictionary { get; set; }

        /// <summary>Store regular expression-based StoredInfoType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regex")]
        public virtual GooglePrivacyDlpV2Regex Regex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Statistics for a StoredInfoType.</summary>
    public class GooglePrivacyDlpV2StoredInfoTypeStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>StoredInfoType where findings are defined by a dictionary of phrases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("largeCustomDictionary")]
        public virtual GooglePrivacyDlpV2LargeCustomDictionaryStats LargeCustomDictionary { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Version of a StoredInfoType, including the configuration used to build it, create timestamp, and current state.
    /// </summary>
    public class GooglePrivacyDlpV2StoredInfoTypeVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>StoredInfoType configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GooglePrivacyDlpV2StoredInfoTypeConfig Config { get; set; }

        /// <summary>
        /// Create timestamp of the version. Read-only, determined by the system when the version is created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Errors that occurred when creating this storedInfoType version, or anomalies detected in the storedInfoType
        /// data that render it unusable. Only the five most recent errors will be displayed, with the most recent error
        /// appearing first. For example, some of the data for stored custom dictionaries is put in the user's Google
        /// Cloud Storage bucket, and if this data is modified or deleted by the user or another system, the dictionary
        /// becomes invalid. If any errors occur, fix the problem indicated by the error message and use the
        /// UpdateStoredInfoType API method to create another version of the storedInfoType to continue using it,
        /// reusing the same `config` if it was not the source of the error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2Error> Errors { get; set; }

        /// <summary>
        /// Stored info type version state. Read-only, updated by the system during dictionary creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Statistics about this storedInfoType version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual GooglePrivacyDlpV2StoredInfoTypeStats Stats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reference to a StoredInfoType to use with scanning.</summary>
    public class GooglePrivacyDlpV2StoredType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Timestamp indicating when the version of the `StoredInfoType` used for inspection was created. Output-only
        /// field, populated by the system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// Resource name of the requested `StoredInfoType`, for example
        /// `organizations/433245324/storedInfoTypes/432452342` or `projects/project-id/storedInfoTypes/432452342`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A collection that informs the user the number of times a particular `TransformationResultCode` and error details
    /// occurred.
    /// </summary>
    public class GooglePrivacyDlpV2SummaryResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Outcome of the transformation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>Number of transformations counted by this result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>A place for warnings or errors to show up if a transformation didn't work as expected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual string Details { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message for detecting output from deidentification transformations such as
    /// [`CryptoReplaceFfxFpeConfig`](https://cloud.google.com/dlp/docs/reference/rest/v2/organizations.deidentifyTemplates#cryptoreplaceffxfpeconfig).
    /// These types of transformations are those that perform pseudonymization, thereby producing a "surrogate" as
    /// output. This should be used in conjunction with a field on the transformation such as `surrogate_info_type`.
    /// This CustomInfoType does not support the use of `detection_rules`.
    /// </summary>
    public class GooglePrivacyDlpV2SurrogateType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Structured content to inspect. Up to 50,000 `Value`s per request allowed. See
    /// https://cloud.google.com/dlp/docs/inspecting-structured-text#inspecting_a_table to learn more.
    /// </summary>
    public class GooglePrivacyDlpV2Table : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Headers of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2FieldId> Headers { get; set; }

        /// <summary>Rows of the table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2Row> Rows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Location of a finding within a table.</summary>
    public class GooglePrivacyDlpV2TableLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The zero-based index of the row where the finding is located. Only populated for resources that have a
        /// natural ordering, not BigQuery. In BigQuery, to identify the row a finding came from, populate
        /// BigQueryOptions.identifying_fields with your primary key column names and when you store the findings the
        /// value of those columns will be stored inside of Finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowIndex")]
        public virtual System.Nullable<long> RowIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Instructions regarding the table content being inspected.</summary>
    public class GooglePrivacyDlpV2TableOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The columns that are the primary keys for table objects included in ContentItem. A copy of this cell's value
        /// will stored alongside alongside each finding so that the finding can be traced to the specific row it came
        /// from. No more than 3 may be provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identifyingFields")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2FieldId> IdentifyingFields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A column with a semantic tag attached.</summary>
    public class GooglePrivacyDlpV2TaggedField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A column can be tagged with a custom tag. In this case, the user must indicate an auxiliary table that
        /// contains statistical information on the possible values of this column (below).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customTag")]
        public virtual string CustomTag { get; set; }

        /// <summary>Required. Identifies the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual GooglePrivacyDlpV2FieldId Field { get; set; }

        /// <summary>
        /// If no semantic tag is indicated, we infer the statistical model from the distribution of values in the input
        /// data
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inferred")]
        public virtual GoogleProtobufEmpty Inferred { get; set; }

        /// <summary>
        /// A column can be tagged with a InfoType to use the relevant public dataset as a statistical model of
        /// population, if available. We currently support US ZIP codes, region codes, ages and genders. To
        /// programmatically obtain the list of supported InfoTypes, use ListInfoTypes with the
        /// supported_by=RISK_ANALYSIS filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoType")]
        public virtual GooglePrivacyDlpV2InfoType InfoType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Throw an error and fail the request when a transformation error occurs.</summary>
    public class GooglePrivacyDlpV2ThrowError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// For use with `Date`, `Timestamp`, and `TimeOfDay`, extract or preserve a portion of the value.
    /// </summary>
    public class GooglePrivacyDlpV2TimePartConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The part of the time to keep.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partToExtract")]
        public virtual string PartToExtract { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Time zone of the date time object.</summary>
    public class GooglePrivacyDlpV2TimeZone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Set only if the offset can be determined. Positive for time ahead of UTC. E.g. For "UTC-9", this value is
        /// -540.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offsetMinutes")]
        public virtual System.Nullable<int> OffsetMinutes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration of the timespan of the items to include in scanning. Currently only supported when inspecting
    /// Google Cloud Storage and BigQuery.
    /// </summary>
    public class GooglePrivacyDlpV2TimespanConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When the job is started by a JobTrigger we will automatically figure out a valid start_time to avoid
        /// scanning files that have not been modified since the last time the JobTrigger executed. This will be based
        /// on the time of the execution of the last run of the JobTrigger.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableAutoPopulationOfTimespanConfig")]
        public virtual System.Nullable<bool> EnableAutoPopulationOfTimespanConfig { get; set; }

        /// <summary>
        /// Exclude files, tables, or rows newer than this value. If not set, no upper time limit is applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Exclude files, tables, or rows older than this value. If not set, no lower time limit is applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>
        /// Specification of the field containing the timestamp of scanned items. Used for data sources like Datastore
        /// and BigQuery. For BigQuery: If this value is not specified and the table was modified between the given
        /// start and end times, the entire table will be scanned. If this value is specified, then rows are filtered
        /// based on the given start and end times. Rows with a `NULL` value in the provided BigQuery column are
        /// skipped. Valid data types of the provided BigQuery column are: `INTEGER`, `DATE`, `TIMESTAMP`, and
        /// `DATETIME`. For Datastore: If this value is specified, then entities are filtered based on the given start
        /// and end times. If an entity does not contain the provided timestamp property or contains empty or invalid
        /// values, then it is included. Valid data types of the provided timestamp property are: `TIMESTAMP`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampField")]
        public virtual GooglePrivacyDlpV2FieldId TimestampField { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// How to handle transformation errors during de-identification. A transformation error occurs when the requested
    /// transformation is incompatible with the data. For example, trying to de-identify an IP address using a
    /// `DateShift` transformation would result in a transformation error, since date info cannot be extracted from an
    /// IP address. Information about any incompatible transformations, and how they were handled, is returned in the
    /// response as part of the `TransformationOverviews`.
    /// </summary>
    public class GooglePrivacyDlpV2TransformationErrorHandling : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Ignore errors</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leaveUntransformed")]
        public virtual GooglePrivacyDlpV2LeaveUntransformed LeaveUntransformed { get; set; }

        /// <summary>Throw an error</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("throwError")]
        public virtual GooglePrivacyDlpV2ThrowError ThrowError { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Overview of the modifications that occurred.</summary>
    public class GooglePrivacyDlpV2TransformationOverview : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Transformations applied to the dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformationSummaries")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2TransformationSummary> TransformationSummaries { get; set; }

        /// <summary>Total size in bytes that were transformed in some way.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformedBytes")]
        public virtual System.Nullable<long> TransformedBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Summary of a single transformation. Only one of 'transformation', 'field_transformation', or 'record_suppress'
    /// will be set.
    /// </summary>
    public class GooglePrivacyDlpV2TransformationSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Set if the transformation was limited to a specific FieldId.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual GooglePrivacyDlpV2FieldId Field { get; set; }

        /// <summary>
        /// The field transformation that was applied. If multiple field transformations are requested for a single
        /// field, this list will contain all of them; otherwise, only one is supplied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldTransformations")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2FieldTransformation> FieldTransformations { get; set; }

        /// <summary>Set if the transformation was limited to a specific InfoType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoType")]
        public virtual GooglePrivacyDlpV2InfoType InfoType { get; set; }

        /// <summary>The specific suppression option these stats apply to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordSuppress")]
        public virtual GooglePrivacyDlpV2RecordSuppression RecordSuppress { get; set; }

        /// <summary>Collection of all transformations that took place or had an error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<GooglePrivacyDlpV2SummaryResult> Results { get; set; }

        /// <summary>The specific transformation these stats apply to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformation")]
        public virtual GooglePrivacyDlpV2PrimitiveTransformation Transformation { get; set; }

        /// <summary>Total size in bytes that were transformed in some way.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformedBytes")]
        public virtual System.Nullable<long> TransformedBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// </summary>
    public class GooglePrivacyDlpV2TransientCryptoKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is
        /// generated per name: two separate `TransientCryptoKey` protos share the same generated key if their names are
        /// the same. When the data crypto key is generated, this name is not used in any way (repeating the api call
        /// will result in a different key being generated).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>What event needs to occur for a new job to be started.</summary>
    public class GooglePrivacyDlpV2Trigger : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For use with hybrid jobs. Jobs must be manually created and finished.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manual")]
        public virtual GooglePrivacyDlpV2Manual Manual { get; set; }

        /// <summary>Create a job on a repeating basis based on the elapse of time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schedule")]
        public virtual GooglePrivacyDlpV2Schedule Schedule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if
    /// possible.
    /// </summary>
    public class GooglePrivacyDlpV2UnwrappedCryptoKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A 128/192/256 bit key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UpdateDeidentifyTemplate.</summary>
    public class GooglePrivacyDlpV2UpdateDeidentifyTemplateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>New DeidentifyTemplate value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deidentifyTemplate")]
        public virtual GooglePrivacyDlpV2DeidentifyTemplate DeidentifyTemplate { get; set; }

        /// <summary>Mask to control which fields get updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UpdateInspectTemplate.</summary>
    public class GooglePrivacyDlpV2UpdateInspectTemplateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>New InspectTemplate value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectTemplate")]
        public virtual GooglePrivacyDlpV2InspectTemplate InspectTemplate { get; set; }

        /// <summary>Mask to control which fields get updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UpdateJobTrigger.</summary>
    public class GooglePrivacyDlpV2UpdateJobTriggerRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>New JobTrigger value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jobTrigger")]
        public virtual GooglePrivacyDlpV2JobTrigger JobTrigger { get; set; }

        /// <summary>Mask to control which fields get updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for UpdateStoredInfoType.</summary>
    public class GooglePrivacyDlpV2UpdateStoredInfoTypeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Updated configuration for the storedInfoType. If not provided, a new version of the storedInfoType will be
        /// created with the existing configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GooglePrivacyDlpV2StoredInfoTypeConfig Config { get; set; }

        /// <summary>Mask to control which fields get updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Set of primitive values supported by the system. Note that for the purposes of inspection or transformation, the
    /// number of bytes considered to comprise a 'Value' is based on its representation as a UTF-8 encoded string. For
    /// example, if 'integer_value' is set to 123456789, the number of bytes would be counted as 9, even though an int64
    /// only holds up to 8 bytes of data.
    /// </summary>
    public class GooglePrivacyDlpV2Value : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>boolean</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanValue")]
        public virtual System.Nullable<bool> BooleanValue { get; set; }

        /// <summary>date</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateValue")]
        public virtual GoogleTypeDate DateValue { get; set; }

        /// <summary>day of week</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dayOfWeekValue")]
        public virtual string DayOfWeekValue { get; set; }

        /// <summary>float</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floatValue")]
        public virtual System.Nullable<double> FloatValue { get; set; }

        /// <summary>integer</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integerValue")]
        public virtual System.Nullable<long> IntegerValue { get; set; }

        /// <summary>string</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>time of day</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeValue")]
        public virtual GoogleTypeTimeOfDay TimeValue { get; set; }

        /// <summary>timestamp</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestampValue")]
        public virtual object TimestampValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A value of a field, including its frequency.</summary>
    public class GooglePrivacyDlpV2ValueFrequency : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How many times the value is contained in the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>A value contained in the field in question.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual GooglePrivacyDlpV2Value Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message defining a list of words or phrases to search for in the data.</summary>
    public class GooglePrivacyDlpV2WordList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase
        /// must contain at least 2 characters that are letters or digits. [required]
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("words")]
        public virtual System.Collections.Generic.IList<string> Words { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class GoogleProtobufEmpty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class GoogleRpcStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values * A month and day value, with a zero
    /// year, such as an anniversary * A year on its own, with zero month and day values * A year and month value, with
    /// a zero day, such as a credit card expiration date Related types are google.type.TimeOfDay and
    /// `google.protobuf.Timestamp`.
    /// </summary>
    public class GoogleTypeDate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a
        /// year and month where the day isn't significant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class GoogleTypeTimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for
        /// scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows
        /// leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
