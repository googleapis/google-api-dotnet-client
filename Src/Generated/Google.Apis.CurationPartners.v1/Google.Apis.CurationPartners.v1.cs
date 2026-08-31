// Copyright 2026 Google LLC
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

namespace Google.Apis.CurationPartners.v1
{
    /// <summary>The CurationPartners Service.</summary>
    public class CurationPartnersService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CurationPartnersService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CurationPartnersService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Curators = new CuratorsResource(this);
            MediaPlanners = new MediaPlannersResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://curationpartners.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://curationpartners.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "curationpartners";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Curation Partners API.</summary>
        public class Scope
        {
            /// <summary>See, create, edit, and delete data entities in your Curation account.</summary>
            public static string CurationPartners = "https://www.googleapis.com/auth/curation-partners";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Curation Partners API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, create, edit, and delete data entities in your Curation account.</summary>
            public const string CurationPartners = "https://www.googleapis.com/auth/curation-partners";
        }

        /// <summary>Gets the Curators resource.</summary>
        public virtual CuratorsResource Curators { get; }

        /// <summary>Gets the MediaPlanners resource.</summary>
        public virtual MediaPlannersResource MediaPlanners { get; }
    }

    /// <summary>A base abstract class for CurationPartners requests.</summary>
    public abstract class CurationPartnersBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CurationPartnersBaseServiceRequest instance.</summary>
        protected CurationPartnersBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CurationPartners parameter list.</summary>
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

    /// <summary>The "curators" collection of methods.</summary>
    public class CuratorsResource
    {
        private const string Resource = "curators";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CuratorsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            CuratedPackages = new CuratedPackagesResource(service);
            DataSegments = new DataSegmentsResource(service);
            Reports = new ReportsResource(service);
        }

        /// <summary>Gets the CuratedPackages resource.</summary>
        public virtual CuratedPackagesResource CuratedPackages { get; }

        /// <summary>The "curatedPackages" collection of methods.</summary>
        public class CuratedPackagesResource
        {
            private const string Resource = "curatedPackages";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CuratedPackagesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Activates an existing curated package.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the curated package to activate. Format:
            /// `curators/{accountId}/curatedPackages/{curatedPackageId}`
            /// </param>
            public virtual ActivateRequest Activate(Google.Apis.CurationPartners.v1.Data.ActivateCuratedPackageRequest body, string name)
            {
                return new ActivateRequest(this.service, body, name);
            }

            /// <summary>Activates an existing curated package.</summary>
            public class ActivateRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.CuratedPackage>
            {
                /// <summary>Constructs a new Activate request.</summary>
                public ActivateRequest(Google.Apis.Services.IClientService service, Google.Apis.CurationPartners.v1.Data.ActivateCuratedPackageRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the curated package to activate. Format:
                /// `curators/{accountId}/curatedPackages/{curatedPackageId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CurationPartners.v1.Data.ActivateCuratedPackageRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "activate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:activate";

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
                        Pattern = @"^curators/[^/]+/curatedPackages/[^/]+$",
                    });
                }
            }

            /// <summary>Creates a new curated package.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent curator account where this curated package will be created. Format:
            /// `curators/{accountId}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.CurationPartners.v1.Data.CuratedPackage body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a new curated package.</summary>
            public class CreateRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.CuratedPackage>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CurationPartners.v1.Data.CuratedPackage body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent curator account where this curated package will be created. Format:
                /// `curators/{accountId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CurationPartners.v1.Data.CuratedPackage Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/curatedPackages";

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
                        Pattern = @"^curators/[^/]+$",
                    });
                }
            }

            /// <summary>Deactivates an existing curated package.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the curated package to deactivate. Format:
            /// `curators/{accountId}/curatedPackages/{curatedPackageId}`
            /// </param>
            public virtual DeactivateRequest Deactivate(Google.Apis.CurationPartners.v1.Data.DeactivateCuratedPackageRequest body, string name)
            {
                return new DeactivateRequest(this.service, body, name);
            }

            /// <summary>Deactivates an existing curated package.</summary>
            public class DeactivateRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.CuratedPackage>
            {
                /// <summary>Constructs a new Deactivate request.</summary>
                public DeactivateRequest(Google.Apis.Services.IClientService service, Google.Apis.CurationPartners.v1.Data.DeactivateCuratedPackageRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the curated package to deactivate. Format:
                /// `curators/{accountId}/curatedPackages/{curatedPackageId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CurationPartners.v1.Data.DeactivateCuratedPackageRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "deactivate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:deactivate";

                /// <summary>Initializes Deactivate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^curators/[^/]+/curatedPackages/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a curated package given its resource name.</summary>
            /// <param name="name">
            /// Required. The name of the curated package to retrieve. Format:
            /// `curators/{accountId}/curatedPackages/{curatedPackageId}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a curated package given its resource name.</summary>
            public class GetRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.CuratedPackage>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the curated package to retrieve. Format:
                /// `curators/{accountId}/curatedPackages/{curatedPackageId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^curators/[^/]+/curatedPackages/[^/]+$",
                    });
                }
            }

            /// <summary>Lists curated packages owned by the specified curator.</summary>
            /// <param name="parent">
            /// Required. The parent curator account which owns this collection of curated packages. Format:
            /// `curators/{accountId}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists curated packages owned by the specified curator.</summary>
            public class ListRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.ListCuratedPackagesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent curator account which owns this collection of curated packages. Format:
                /// `curators/{accountId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Optional query string using the [Cloud API list filtering
                /// syntax](/authorized-buyers/apis/guides/list-filters). Supported columns for filtering are: *
                /// displayName * createTime * updateTime * state * feeCpm.currencyCode * feeCpm.units * feeCpm.nanos *
                /// floorPriceCpm.currencyCode * floorPriceCpm.units * floorPriceCpm.nanos
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. Requested page size. The server may return fewer results than requested. Max allowed page
                /// size is 500. If unspecified, the server will default to 500.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListCuratedPackages` call. Provide this to
                /// retrieve the subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/curatedPackages";

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
                        Pattern = @"^curators/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
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

            /// <summary>Updates an existing curated package.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. The unique resource name for the curated package. Format:
            /// `curators/{accountId}/curatedPackages/{curatedPackageId}`
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.CurationPartners.v1.Data.CuratedPackage body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates an existing curated package.</summary>
            public class PatchRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.CuratedPackage>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CurationPartners.v1.Data.CuratedPackage body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. The unique resource name for the curated package. Format:
                /// `curators/{accountId}/curatedPackages/{curatedPackageId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. List of fields to be updated. If empty or unspecified, the service will update all fields
                /// populated in the update request excluding the output only fields and primitive fields with default
                /// value. Note that explicit field mask is required in order to reset a primitive field back to its
                /// default value, for example, false for boolean fields, 0 for integer fields. A special field mask
                /// consisting of a single path "*" can be used to indicate full replacement (the equivalent of PUT
                /// method), updatable fields unset or unspecified in the input will be cleared or set to default value.
                /// Output only fields will be ignored regardless of the value of updateMask.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CurationPartners.v1.Data.CuratedPackage Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^curators/[^/]+/curatedPackages/[^/]+$",
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

        /// <summary>Gets the DataSegments resource.</summary>
        public virtual DataSegmentsResource DataSegments { get; }

        /// <summary>The "dataSegments" collection of methods.</summary>
        public class DataSegmentsResource
        {
            private const string Resource = "dataSegments";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DataSegmentsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Activates a data segment.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Name of data segment to activate. Format:
            /// `curators/{accountId}/dataSegments/{curatorDataSegmentId}`
            /// </param>
            public virtual ActivateRequest Activate(Google.Apis.CurationPartners.v1.Data.ActivateDataSegmentRequest body, string name)
            {
                return new ActivateRequest(this.service, body, name);
            }

            /// <summary>Activates a data segment.</summary>
            public class ActivateRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.DataSegment>
            {
                /// <summary>Constructs a new Activate request.</summary>
                public ActivateRequest(Google.Apis.Services.IClientService service, Google.Apis.CurationPartners.v1.Data.ActivateDataSegmentRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of data segment to activate. Format:
                /// `curators/{accountId}/dataSegments/{curatorDataSegmentId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CurationPartners.v1.Data.ActivateDataSegmentRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "activate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:activate";

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
                        Pattern = @"^curators/[^/]+/dataSegments/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Creates a data segment owned by the listed curator. The data segment will be created in the `ACTIVE`
            /// state, meaning it will be immediately available for buyers to use in preferred deals, private auction
            /// deals, and auction packages.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource where this data segment will be created. Format: `curators/{accountId}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.CurationPartners.v1.Data.DataSegment body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a data segment owned by the listed curator. The data segment will be created in the `ACTIVE`
            /// state, meaning it will be immediately available for buyers to use in preferred deals, private auction
            /// deals, and auction packages.
            /// </summary>
            public class CreateRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.DataSegment>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CurationPartners.v1.Data.DataSegment body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource where this data segment will be created. Format:
                /// `curators/{accountId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CurationPartners.v1.Data.DataSegment Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/dataSegments";

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
                        Pattern = @"^curators/[^/]+$",
                    });
                }
            }

            /// <summary>Deactivates a data segment.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Name of data segment to deactivate. Format:
            /// `curators/{accountId}/dataSegments/{curatorDataSegmentId}`
            /// </param>
            public virtual DeactivateRequest Deactivate(Google.Apis.CurationPartners.v1.Data.DeactivateDataSegmentRequest body, string name)
            {
                return new DeactivateRequest(this.service, body, name);
            }

            /// <summary>Deactivates a data segment.</summary>
            public class DeactivateRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.DataSegment>
            {
                /// <summary>Constructs a new Deactivate request.</summary>
                public DeactivateRequest(Google.Apis.Services.IClientService service, Google.Apis.CurationPartners.v1.Data.DeactivateDataSegmentRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of data segment to deactivate. Format:
                /// `curators/{accountId}/dataSegments/{curatorDataSegmentId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CurationPartners.v1.Data.DeactivateDataSegmentRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "deactivate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:deactivate";

                /// <summary>Initializes Deactivate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^curators/[^/]+/dataSegments/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a data segment given its name.</summary>
            /// <param name="name">
            /// Required. Name of data segment to get. Format:
            /// `curators/{accountId}/dataSegments/{curatorDataSegmentId}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a data segment given its name.</summary>
            public class GetRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.DataSegment>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of data segment to get. Format:
                /// `curators/{accountId}/dataSegments/{curatorDataSegmentId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^curators/[^/]+/dataSegments/[^/]+$",
                    });
                }
            }

            /// <summary>List the data segments owned by a curator.</summary>
            /// <param name="parent">
            /// Required. Name of the parent curator that can access the data segment. Format: `curators/{accountId}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List the data segments owned by a curator.</summary>
            public class ListRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.ListDataSegmentsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the parent curator that can access the data segment. Format:
                /// `curators/{accountId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Requested page size. The server may return fewer results than requested. Max allowed page
                /// size is 500. If unspecified, the server will default to 500.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Optional. The page token as returned. ListDataSegmentsResponse.nextPageToken</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/dataSegments";

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
                        Pattern = @"^curators/[^/]+$",
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

            /// <summary>Updates a data segment.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Immutable. Identifier. The unique identifier for the data segment. Account ID corresponds to the account
            /// ID that created the segment. Format: `curators/{curatorAccountId}/dataSegments/{curatorDataSegmentId}`
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.CurationPartners.v1.Data.DataSegment body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a data segment.</summary>
            public class PatchRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.DataSegment>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CurationPartners.v1.Data.DataSegment body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Immutable. Identifier. The unique identifier for the data segment. Account ID corresponds to the
                /// account ID that created the segment. Format:
                /// `curators/{curatorAccountId}/dataSegments/{curatorDataSegmentId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Optional. List of fields to be updated. If empty or unspecified, the service will update all fields
                /// populated in the update request excluding the output only fields and primitive fields with default
                /// value. Note that explicit field mask is required in order to reset a primitive field back to its
                /// default value, for example, false for boolean fields, 0 for integer fields. A special field mask
                /// consisting of a single path "*" can be used to indicate full replacement(the equivalent of PUT
                /// method), updatable fields unset or unspecified in the input will be cleared or set to default value.
                /// Output only fields will be ignored regardless of the value of updateMask.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CurationPartners.v1.Data.DataSegment Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^curators/[^/]+/dataSegments/[^/]+$",
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

        /// <summary>Gets the Reports resource.</summary>
        public virtual ReportsResource Reports { get; }

        /// <summary>The "reports" collection of methods.</summary>
        public class ReportsResource
        {
            private const string Resource = "reports";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ReportsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Operations = new OperationsResource(service);
                Results = new ResultsResource(service);
            }

            /// <summary>Gets the Operations resource.</summary>
            public virtual OperationsResource Operations { get; }

            /// <summary>The "operations" collection of methods.</summary>
            public class OperationsResource
            {
                private const string Resource = "operations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OperationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^curators/[^/]+/reports/[^/]+/operations/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Results resource.</summary>
            public virtual ResultsResource Results { get; }

            /// <summary>The "results" collection of methods.</summary>
            public class ResultsResource
            {
                private const string Resource = "results";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ResultsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Returns the result rows from a completed report. The caller must have previously called `RunReport`
                /// and waited for that operation to complete. The rows will be returned according to the order
                /// specified by the `sorts` member of the report definition.
                /// </summary>
                /// <param name="name">
                /// The report result being fetched. Format:
                /// `curators/{account_id}/reports/{report_id}/results/{report_result_id}`
                /// </param>
                public virtual FetchRowsRequest FetchRows(string name)
                {
                    return new FetchRowsRequest(this.service, name);
                }

                /// <summary>
                /// Returns the result rows from a completed report. The caller must have previously called `RunReport`
                /// and waited for that operation to complete. The rows will be returned according to the order
                /// specified by the `sorts` member of the report definition.
                /// </summary>
                public class FetchRowsRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.FetchReportResultRowsResponse>
                {
                    /// <summary>Constructs a new FetchRows request.</summary>
                    public FetchRowsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The report result being fetched. Format:
                    /// `curators/{account_id}/reports/{report_id}/results/{report_result_id}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The maximum number of rows to return. The service may return fewer than this value. If
                    /// unspecified, at most 1,000 rows will be returned. The maximum value is 10,000; values greater
                    /// than 10,000 will be reduced to 10,000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous `FetchReportResultRows` call. Provide this to
                    /// retrieve the second and subsequent batches of rows.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "fetchRows";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:fetchRows";

                    /// <summary>Initializes FetchRows parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^curators/[^/]+/reports/[^/]+/results/[^/]+$",
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

            /// <summary>Creates a `Report` object.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent resource where this `Report` will be created. Format: `curators/{account_id}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.CurationPartners.v1.Data.Report body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>Creates a `Report` object.</summary>
            public class CreateRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.Report>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CurationPartners.v1.Data.Report body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource where this `Report` will be created. Format: `curators/{account_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CurationPartners.v1.Data.Report Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/reports";

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
                        Pattern = @"^curators/[^/]+$",
                    });
                }
            }

            /// <summary>Deletes a `Report` object.</summary>
            /// <param name="name">
            /// Required. Resource name of the report to delete. Format: `curators/{account_id}/reports/{report_id}`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(this.service, name);
            }

            /// <summary>Deletes a `Report` object.</summary>
            public class DeleteRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the report to delete. Format: `curators/{account_id}/reports/{report_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^curators/[^/]+/reports/[^/]+$",
                    });
                }
            }

            /// <summary>Retrieves a `Report` object.</summary>
            /// <param name="name">
            /// Required. The resource name of the report. Format: `curators/{account_id}/reports/{report_id}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Retrieves a `Report` object.</summary>
            public class GetRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.Report>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The resource name of the report. Format: `curators/{account_id}/reports/{report_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^curators/[^/]+/reports/[^/]+$",
                    });
                }
            }

            /// <summary>Lists `Report` objects.</summary>
            /// <param name="parent">
            /// Required. The parent, which owns this collection of reports. Format: `curators/{account_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>Lists `Report` objects.</summary>
            public class ListRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.ListReportsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent, which owns this collection of reports. Format: `curators/{account_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Expression to filter the response. See syntax details at
                /// https://developers.google.com/ad-manager/api/beta/filters
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Optional. Expression to specify sorting order. See syntax details at
                /// https://developers.google.com/ad-manager/api/beta/filters#order
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Optional. The maximum number of `Reports` to return. The service may return fewer than this value.
                /// If unspecified, at most 50 `Reports` will be returned. The maximum value is 1000; values greater
                /// than 1000 will be coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. A page token, received from a previous `ListReports` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListReports` must match the call
                /// that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Optional. Number of individual resources to skip while paginating.</summary>
                [Google.Apis.Util.RequestParameterAttribute("skip", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> Skip { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/reports";

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
                        Pattern = @"^curators/[^/]+$",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
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
                    RequestParameters.Add("skip", new Google.Apis.Discovery.Parameter
                    {
                        Name = "skip",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates a `Report` object.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Identifier. The resource name of the report. Report resource name have the form:
            /// `curators/{account_id}/reports/{report_id}`
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.CurationPartners.v1.Data.Report body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a `Report` object.</summary>
            public class PatchRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.Report>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CurationPartners.v1.Data.Report body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier. The resource name of the report. Report resource name have the form:
                /// `curators/{account_id}/reports/{report_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Optional. The list of fields to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CurationPartners.v1.Data.Report Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^curators/[^/]+/reports/[^/]+$",
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

            /// <summary>
            /// Initiates the execution of an existing report asynchronously. Users can get the report by polling this
            /// operation using `OperationsService.GetOperation`. Poll every 5 seconds initially, with an exponential
            /// backoff. Once a report is complete, the operation will contain a `RunReportResponse` in its response
            /// field containing a report_result that can be passed to the `FetchReportResultRows` method to retrieve
            /// the report data.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The report to run. Format: `curators/{account_id}/reports/{report_id}`
            /// </param>
            public virtual RunRequest Run(Google.Apis.CurationPartners.v1.Data.RunReportRequest body, string name)
            {
                return new RunRequest(this.service, body, name);
            }

            /// <summary>
            /// Initiates the execution of an existing report asynchronously. Users can get the report by polling this
            /// operation using `OperationsService.GetOperation`. Poll every 5 seconds initially, with an exponential
            /// backoff. Once a report is complete, the operation will contain a `RunReportResponse` in its response
            /// field containing a report_result that can be passed to the `FetchReportResultRows` method to retrieve
            /// the report data.
            /// </summary>
            public class RunRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.Operation>
            {
                /// <summary>Constructs a new Run request.</summary>
                public RunRequest(Google.Apis.Services.IClientService service, Google.Apis.CurationPartners.v1.Data.RunReportRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. The report to run. Format: `curators/{account_id}/reports/{report_id}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CurationPartners.v1.Data.RunReportRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "run";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}:run";

                /// <summary>Initializes Run parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^curators/[^/]+/reports/[^/]+$",
                    });
                }
            }
        }
    }

    /// <summary>The "mediaPlanners" collection of methods.</summary>
    public class MediaPlannersResource
    {
        private const string Resource = "mediaPlanners";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MediaPlannersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Lists all media planner accounts that the caller has access to. For curators, this will return all media
        /// planners that have accepted curator terms. For other accounts, attempting to list media planners will return
        /// an error.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>
        /// Lists all media planner accounts that the caller has access to. For curators, this will return all media
        /// planners that have accepted curator terms. For other accounts, attempting to list media planners will return
        /// an error.
        /// </summary>
        public class ListRequest : CurationPartnersBaseServiceRequest<Google.Apis.CurationPartners.v1.Data.ListMediaPlannersResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional query string using the [Cloud API list filtering
            /// syntax](/authorized-buyers/apis/guides/list-filters). Supported columns for filtering are: * `name` *
            /// `displayName` * `ancestorNames`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// The maximum number of media planners to return. If unspecified, at most 100 media planners will be
            /// returned. The maximum value is 500; values above 500 will be coerced to 500.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Optional. A token identifying a page of results the server should return.This value is received from a
            /// previous `ListMediaPlanners` call in ListMediaPlannersResponse.nextPageToken.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/mediaPlanners";

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
}
namespace Google.Apis.CurationPartners.v1.Data
{
    /// <summary>Settings for controlling access to a curated package.</summary>
    public class AccessControlSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Immutable. The list of media planners that are explicitly granted access to the curated package.
        /// Eligible media planners can be found in the mediaPlanners.list method. Only a single media planner may be
        /// allowlisted at this time. Format: `mediaPlanners/{mediaPlannerAccountId}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowlistedMediaPlanners")]
        public virtual System.Collections.Generic.IList<string> AllowlistedMediaPlanners { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for ActivateCuratedPackage.</summary>
    public class ActivateCuratedPackageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for activating a data segment</summary>
    public class ActivateDataSegmentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents size of a single ad slot, or a creative.</summary>
    public class AdSize : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The height of the ad slot in pixels. This field will be present only when size type is `PIXEL`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<long> Height { get; set; }

        /// <summary>The type of the ad slot size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// The width of the ad slot in pixels. This field will be present only when size type is `PIXEL`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<long> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Generic targeting used for targeting dimensions that contains a list of included and excluded numeric IDs. This
    /// cannot be filtered using list filter syntax.
    /// </summary>
    public class CriteriaTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of numeric IDs to be excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedCriteriaIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> ExcludedCriteriaIds { get; set; }

        /// <summary>A list of numeric IDs to be included.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetedCriteriaIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> TargetedCriteriaIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a curated package of inventory created and managed by a Curator.</summary>
    public class CuratedPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Settings for controlling access to the curated package. Access to this curated package is limited
        /// to the allowlisted media planners and the creator. Buyers and bidders can not be allowlisted for or have
        /// direct access to this resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessSettings")]
        public virtual AccessControlSettings AccessSettings { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The timestamp when the curated package was created. Can be used to filter the response of the
        /// curatedPackages.list method.
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
        /// Optional. Immutable. The visibility of the combined curation package fee and data segment fees (the total
        /// curation fee).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("curationFeeVisibility")]
        public virtual string CurationFeeVisibility { get; set; }

        /// <summary>Optional. A description of the curated package, provided by the curator.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. The display name assigned to the curated package by the curator. Can be used to filter the
        /// response of the curatedPackages.list method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Optional. The CPM fee charged by the curator to buyers using this curated package. Can be used to filter the
        /// response of the curatedPackages.list method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feeCpm")]
        public virtual Money FeeCpm { get; set; }

        /// <summary>
        /// Optional. The minimum CPM a buyer has to bid to participate in auctions for inventory in this curated
        /// package. Can be used to filter the response of the curatedPackages.list method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floorPriceCpm")]
        public virtual Money FloorPriceCpm { get; set; }

        /// <summary>
        /// Optional. The fee will be charged as a percentage of the impression cost, represented in millipercent. For
        /// example, 1% is represented as 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("millipercentOfMediaFee")]
        public virtual System.Nullable<long> MillipercentOfMediaFee { get; set; }

        /// <summary>
        /// Identifier. The unique resource name for the curated package. Format:
        /// `curators/{accountId}/curatedPackages/{curatedPackageId}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The state of the curated package. Can be used to filter the response of the
        /// curatedPackages.list method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Optional. Targeting criteria for the curated package.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targeting")]
        public virtual PackageTargeting Targeting { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The timestamp when the curated package was last updated. Can be used to filter the response of
        /// the curatedPackages.list method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines an identifier for a segment of inventory that can be targeted by curators or media planners in the deals
    /// or auction packages UI. Curation of inventory is done by curators on external platforms. -- Next ID: 9 --
    /// </summary>
    public class DataSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. A fixed fee charged per thousand impressions. Once set, the currency code cannot be changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpmFee")]
        public virtual Money CpmFee { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time the data segment was created.</summary>
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
        /// Optional. The fee will be charged as a percentage of the impression cost, represented in millipercent. For
        /// example, 1% is represented as 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("millipercentOfMediaFee")]
        public virtual System.Nullable<long> MillipercentOfMediaFee { get; set; }

        /// <summary>
        /// Immutable. Identifier. The unique identifier for the data segment. Account ID corresponds to the account ID
        /// that created the segment. Format: `curators/{curatorAccountId}/dataSegments/{curatorDataSegmentId}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the data segment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. Time the data segment was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Optional. Immutable. The ID of the User List wrapped by this Data Segment. Curators with a linked Data
        /// Partner account can create a data segment that wraps a user list owned by the linked Data Partner account.
        /// User lists can be uploaded and managed using the [Data Manager
        /// API](https://developers.google.com/data-manager/api/data-partners/audiences). Linking a user list to a data
        /// segment lets you define a segment of inventory that is based on an audience you create.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userListId")]
        public virtual string UserListId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values. * A month and day, with a zero year
    /// (for example, an anniversary). * A year on its own, with a zero month and a zero day. * A year and month, with a
    /// zero day (for example, a credit card expiration date). Related types: * google.type.TimeOfDay *
    /// google.type.DateTime * google.protobuf.Timestamp
    /// </summary>
    public class Date : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>A date range for a report.</summary>
    public class DateRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A fixed date range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixed")]
        public virtual FixedDateRange Fixed__ { get; set; }

        /// <summary>A relative date range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relative")]
        public virtual string Relative { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for DeactivateCuratedPackage.</summary>
    public class DeactivateCuratedPackageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for deactivating a data segment</summary>
    public class DeactivateDataSegmentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of double values.</summary>
    public class DoubleList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The values</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<System.Nullable<double>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for the fetch report result rows endpoint.</summary>
    public class FetchReportResultRowsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The computed fixed date ranges this report includes. Only returned with the first page of results (when
        /// page_token is not included in the request).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRanges")]
        public virtual System.Collections.Generic.IList<FixedDateRange> DateRanges { get; set; }

        /// <summary>
        /// A token that can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Up to `page_size` rows of report data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<Row> Rows { get; set; }

        private string _runTimeRaw;

        private object _runTime;

        /// <summary>
        /// The time at which the report was scheduled to run. For non-scheduled reports, this is the time at which the
        /// report was requested to be run.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runTime")]
        public virtual string RunTimeRaw
        {
            get => _runTimeRaw;
            set
            {
                _runTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _runTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="RunTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RunTimeDateTimeOffset instead.")]
        public virtual object RunTime
        {
            get => _runTime;
            set
            {
                _runTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _runTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="RunTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RunTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(RunTimeRaw);
            set => RunTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// The total number of rows available from this report. Useful for pagination. Only returned with the first
        /// page of results (when page_token is not included in the request).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalRowCount")]
        public virtual System.Nullable<int> TotalRowCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A dimension or a metric in a report.</summary>
    public class Field : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dimension this field represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        /// <summary>The metric this field represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metric")]
        public virtual string Metric { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter on a specific field.</summary>
    public class FieldFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The field to filter on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual Field Field { get; set; }

        /// <summary>Required. The operation of this filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operation")]
        public virtual string Operation { get; set; }

        /// <summary>Required. Values to filter to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<ReportValue> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter over one or more fields.</summary>
    public class Filter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of filters whose results are AND-ed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("andFilter")]
        public virtual FilterList AndFilter { get; set; }

        /// <summary>A filter on a single field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldFilter")]
        public virtual FieldFilter FieldFilter { get; set; }

        /// <summary>A filter whose result is negated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notFilter")]
        public virtual Filter NotFilter { get; set; }

        /// <summary>A list of filters whose results are OR-ed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orFilter")]
        public virtual FilterList OrFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of filters.</summary>
    public class FilterList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A list of filters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filters")]
        public virtual System.Collections.Generic.IList<Filter> Filters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A date range between two fixed dates (inclusive of end date).</summary>
    public class FixedDateRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The end date (inclusive) of this date range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual Date EndDate { get; set; }

        /// <summary>Required. The start date of this date range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual Date StartDate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of integer values.</summary>
    public class IntList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The values</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListCuratedPackages.</summary>
    public class ListCuratedPackagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of curated packages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("curatedPackages")]
        public virtual System.Collections.Generic.IList<CuratedPackage> CuratedPackages { get; set; }

        /// <summary>
        /// A token to retrieve the next page of results. Pass this value in the ListCuratedPackagesRequest.pageToken
        /// field in the subsequent call to `ListCuratedPackages` method to retrieve the next page of results. If empty,
        /// then there are no more results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing data segments.</summary>
    public class ListDataSegmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of data segments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSegments")]
        public virtual System.Collections.Generic.IList<DataSegment> DataSegments { get; set; }

        /// <summary>
        /// Continuation token for fetching the next page of results. Pass this value in the
        /// ListDataSegmentsRequest.pageToken field in the subsequent call to the `ListDataSegments` method to retrieve
        /// the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response containing media planner account information.</summary>
    public class ListMediaPlannersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of media planners.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaPlanners")]
        public virtual System.Collections.Generic.IList<MediaPlanner> MediaPlanners { get; set; }

        /// <summary>
        /// A token which can be passed to a subsequent call to the ListMediaPlanners method to retrieve the next page
        /// of results in ListMediaPlannersRequest.page_token.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response object for `ListReportsResponse` containing matching `Report` objects.</summary>
    public class ListReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The `Report` objects from the specified network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reports")]
        public virtual System.Collections.Generic.IList<Report> Reports { get; set; }

        /// <summary>
        /// Total number of `Report` objects. If a filter was included in the request, this reflects the total number
        /// after the filtering is applied. `total_size` won't be calculated in the response unless it has been included
        /// in a response field mask. The response field mask can be provided to the method by using the URL parameter
        /// `$fields` or `fields`, or by using the HTTP/gRPC header `X-Goog-FieldMask`. For more information, see
        /// https://developers.google.com/ad-manager/api/beta/field-masks
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a media planner account.</summary>
    public class MediaPlanner : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Account ID of the media planner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>
        /// Output only. The ancestor names of the media planner. Format: `mediaPlanners/{mediaPlannerAccountId}`. Can
        /// be used to filter the response of the mediaPlanners.list method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ancestorNames")]
        public virtual System.Collections.Generic.IList<string> AncestorNames { get; set; }

        /// <summary>
        /// Output only. The display name of the media planner. Can be used to filter the response of the
        /// mediaPlanners.list method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Identifier. The unique resource name of the media planner. Format: `mediaPlanners/{mediaPlannerAccountId}`.
        /// Can be used to filter the response of the mediaPlanners.list method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains all metric values requested for a single date range and set of column dimension values (returned in the
    /// columns field of the response). The order of the metrics in each field corresponds to the order of the metrics
    /// specified in the request.
    /// </summary>
    public class MetricValueGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Data for the PRIMARY MetricValueType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryValues")]
        public virtual System.Collections.Generic.IList<ReportValue> PrimaryValues { get; set; }

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

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// Service-specific metadata associated with the operation. It typically contains progress information and
        /// common metadata such as create time. Some services might not provide such metadata. Any method that returns
        /// a long-running operation should document the metadata type, if any.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The server-assigned name, which is only unique within the same service that originally returns it. If you
        /// use the default HTTP mapping, the `name` should be a resource name ending with `operations/{unique_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal, successful response of the operation. If the original method returns no data on success, such as
        /// `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents targeting about where the ads can appear, for example, certain sites or mobile applications.
    /// Different placement targeting types will be logically OR'ed.
    /// </summary>
    public class PackagePlacementTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The list of targeted mobile app categories.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedMobileAppCategoryTargeting")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> IncludedMobileAppCategoryTargeting { get; set; }

        /// <summary>
        /// Optional. The list of targeted or excluded mobile application IDs that publishers own. Currently, only
        /// Android and Apple apps are supported. Android App ID, for example, com.google.android.apps.maps, can be
        /// found in Google Play Store URL. iOS App ID (which is a number) can be found at the end of iTunes store URL.
        /// First party mobile applications is either included or excluded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileAppTargeting")]
        public virtual StringTargetingDimension MobileAppTargeting { get; set; }

        /// <summary>
        /// Optional. The list of targeted or excluded URLs. The domains should have the http/https stripped (for
        /// example, google.com), and can contain a max of 5 paths per url.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uriTargeting")]
        public virtual StringTargetingDimension UriTargeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents targeting about publisher provided signals. Different publisher provided signals types will be
    /// logically OR'ed.
    /// </summary>
    public class PackagePublisherProvidedSignalsTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The list of targeted or excluded audience IDs. Based off of IAB Audience Taxonomy version 1.1
        /// (https://github.com/InteractiveAdvertisingBureau/Taxonomies/blob/main/Audience%20Taxonomies/Audience%20Taxonomy%201.1.tsv)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audienceTargeting")]
        public virtual TaxonomyTargeting AudienceTargeting { get; set; }

        /// <summary>
        /// Optional. The list of targeted or excluded content IDs. Based off of IAB Content Taxonomy version 2.2
        /// (https://github.com/InteractiveAdvertisingBureau/Taxonomies/blob/main/Content%20Taxonomies/Content%20Taxonomy%202.2.tsv)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentTargeting")]
        public virtual TaxonomyTargeting ContentTargeting { get; set; }

        /// <summary>
        /// Optional. The list of targeted and excluded video and audio signals IDs. These are additional signals
        /// supported by publisher provided signals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoAndAudioSignalsTargeting")]
        public virtual StringTargetingDimension VideoAndAudioSignalsTargeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Targeting criteria for curated and auction packages.</summary>
    public class PackageTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The geo criteria IDs to be included or excluded as defined in
        /// https://storage.googleapis.com/adx-rtb-dictionaries/geo-table.csv. If unset, inventory will be targeted
        /// regardless of geo.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoTargeting")]
        public virtual CriteriaTargeting GeoTargeting { get; set; }

        /// <summary>
        /// Optional. The targeted accelerated mobile page type. If unset, inventory will be targeted regardless of AMP
        /// status.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedAcceleratedMobilePageType")]
        public virtual string IncludedAcceleratedMobilePageType { get; set; }

        /// <summary>
        /// Optional. The list of ad sizes to target. If unset, inventory will be targeted regardless of ad size.
        /// Curated packages supports `PIXEL` and `INTERSTITIAL` ad sizes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedAdSizes")]
        public virtual System.Collections.Generic.IList<AdSize> IncludedAdSizes { get; set; }

        /// <summary>
        /// Optional. The included list of targeted authorized seller statuses. If empty, inventory will be targeted
        /// regardless of seller status.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedAuthorizedSellerStatuses")]
        public virtual System.Collections.Generic.IList<string> IncludedAuthorizedSellerStatuses { get; set; }

        /// <summary>
        /// Optional. The creative format to target. If unset, all creative markup types are targeted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedCreativeFormat")]
        public virtual string IncludedCreativeFormat { get; set; }

        /// <summary>
        /// Optional. The active data segments to be targeted. If unset, inventory will be targeted regardless of data
        /// segments. Format: `curators/{account_id}/dataSegments/{data_segment_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedDataSegments")]
        public virtual System.Collections.Generic.IList<string> IncludedDataSegments { get; set; }

        /// <summary>
        /// Optional. The list of included device types to target. If empty, all device types are targeted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedDeviceTypes")]
        public virtual System.Collections.Generic.IList<string> IncludedDeviceTypes { get; set; }

        /// <summary>Optional. The environment to target. If unspecified, all environments are targeted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedEnvironment")]
        public virtual string IncludedEnvironment { get; set; }

        /// <summary>
        /// Optional. The targeted native inventory types. If empty, inventory will be targeted regardless of native
        /// inventory type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedNativeInventoryTypes")]
        public virtual System.Collections.Generic.IList<string> IncludedNativeInventoryTypes { get; set; }

        /// <summary>
        /// Optional. The list of targeted open measurement types. If empty, inventory will be targeted regardless of
        /// Open Measurement support.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedOpenMeasurementTypes")]
        public virtual System.Collections.Generic.IList<string> IncludedOpenMeasurementTypes { get; set; }

        /// <summary>
        /// Optional. The list of targeted restricted categories. If empty, inventory will be targeted regardless of
        /// restricted categories.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedRestrictedCategories")]
        public virtual System.Collections.Generic.IList<string> IncludedRestrictedCategories { get; set; }

        /// <summary>
        /// Optional. The targeted rewarded type. If unset, inventory will be targeted regardless of rewarded type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedRewardedType")]
        public virtual string IncludedRewardedType { get; set; }

        /// <summary>
        /// Optional. The languages to target. If unset, inventory will be targeted regardless of language. See
        /// https://developers.google.com/google-ads/api/data/codes-formats#languages for the list of supported language
        /// codes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageTargeting")]
        public virtual StringTargetingDimension LanguageTargeting { get; set; }

        /// <summary>
        /// Optional. The targeted minimum predicted click through rate, ranging in values [10, 10000] (0.01% - 10%). A
        /// value of 50 means that the configuration will only match adslots for which we predict at least 0.05% click
        /// through rate. An unset value indicates inventory will be targeted regardless of predicted click through
        /// rate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumPredictedClickThroughRatePercentageMillis")]
        public virtual System.Nullable<long> MinimumPredictedClickThroughRatePercentageMillis { get; set; }

        /// <summary>
        /// Optional. The targeted minimum predicted viewability percentage. This value must be a multiple of 10 between
        /// 10 and 90 (inclusive). For example, 10 is valid, but 0, 15, and 100 are not. A value of 10 means that the
        /// configuration will only match adslots for which we predict at least 10% viewability. An unset value
        /// indicates inventory will be targeted regardless of predicted viewability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumPredictedViewabilityPercentage")]
        public virtual System.Nullable<long> MinimumPredictedViewabilityPercentage { get; set; }

        /// <summary>Optional. Placement targeting information, for example, URL, mobile applications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placementTargeting")]
        public virtual PackagePlacementTargeting PlacementTargeting { get; set; }

        /// <summary>
        /// Optional. The publisher provided signals to target. If unset, inventory will be targeted regardless of
        /// publisher provided signals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherProvidedSignalsTargeting")]
        public virtual PackagePublisherProvidedSignalsTargeting PublisherProvidedSignalsTargeting { get; set; }

        /// <summary>
        /// Optional. The targeted publishers. If unset, inventory will be targeted regardless of publisher. Publishers
        /// are identified by their publisher ID from ads.txt / app-ads.txt. See https://iabtechlab.com/ads-txt/ and
        /// https://iabtechlab.com/app-ads-txt/ for more details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherTargeting")]
        public virtual StringTargetingDimension PublisherTargeting { get; set; }

        /// <summary>
        /// Optional. The verticals included or excluded as defined in
        /// https://developers.google.com/authorized-buyers/rtb/downloads/publisher-verticals. If unset, inventory will
        /// be targeted regardless of vertical.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verticalTargeting")]
        public virtual CriteriaTargeting VerticalTargeting { get; set; }

        /// <summary>Optional. Video specific targeting criteria.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoTargeting")]
        public virtual PackageVideoTargeting VideoTargeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Video specific targeting criteria.</summary>
    public class PackageVideoTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The targeted video delivery method. If unset, inventory will be targeted regardless of video
        /// delivery method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedContentDeliveryMethod")]
        public virtual string IncludedContentDeliveryMethod { get; set; }

        /// <summary>
        /// Optional. The targeted maximum video ad duration. If unset, inventory will be targeted regardless of maximum
        /// video ad duration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedMaximumAdDurationTargeting")]
        public virtual string IncludedMaximumAdDurationTargeting { get; set; }

        /// <summary>
        /// Optional. The list of targeted video mime types using the IANA published MIME type strings
        /// (https://www.iana.org/assignments/media-types/media-types.xhtml). If empty, inventory will be targeted
        /// regardless of video mime type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedMimeTypes")]
        public virtual System.Collections.Generic.IList<string> IncludedMimeTypes { get; set; }

        /// <summary>
        /// Optional. The list of targeted video playback methods. If empty, inventory will be targeted regardless of
        /// video playback method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedPlaybackMethods")]
        public virtual System.Collections.Generic.IList<string> IncludedPlaybackMethods { get; set; }

        /// <summary>
        /// Optional. The targeted video player size. If unset, inventory will be targeted regardless of video player
        /// size.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedPlayerSizeTargeting")]
        public virtual VideoPlayerSizeTargeting IncludedPlayerSizeTargeting { get; set; }

        /// <summary>
        /// Optional. The targeted video ad position types. If empty, inventory will be targeted regardless of video ad
        /// position type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includedPositionTypes")]
        public virtual System.Collections.Generic.IList<string> IncludedPositionTypes { get; set; }

        /// <summary>
        /// Optional. The targeted minimum predicted completion rate percentage. This value must be a multiple of 10
        /// between 10 and 90 (inclusive). For example, 10 is valid, but 0, 15, and 100 are not. A value of 10 means
        /// that the configuration will only match adslots for which we predict at least 10% completion rate. An unset
        /// value indicates inventory will be targeted regardless of predicted completion rate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumPredictedCompletionRatePercentage")]
        public virtual System.Nullable<long> MinimumPredictedCompletionRatePercentage { get; set; }

        /// <summary>
        /// Optional. The targeted video plcmt types. If unset, inventory will be targeted regardless of video plcmt
        /// type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plcmtTargeting")]
        public virtual VideoPlcmtTargeting PlcmtTargeting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The `Report` resource.</summary>
    public class Report : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. The instant this report was created.</summary>
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

        /// <summary>Optional. Display name for the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The locale of this report. Locale is set from the user's locale at the time of the request.
        /// Locale can't be modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>
        /// Identifier. The resource name of the report. Report resource name have the form:
        /// `curators/{account_id}/reports/{report_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. The report definition of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportDefinition")]
        public virtual ReportDefinition ReportDefinition { get; set; }

        /// <summary>Output only. Report ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportId")]
        public virtual System.Nullable<long> ReportId { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The instant this report was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The definition of how a report should be run.</summary>
    public class ReportDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The ISO 4217 currency code for this report. Defaults to account currency code if not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; }

        /// <summary>Required. The primary date range of this report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateRange")]
        public virtual DateRange DateRange { get; set; }

        /// <summary>
        /// Required. The list of dimensions to report on. If empty, the report will have no dimensions, and any metrics
        /// will be totals.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<string> Dimensions { get; set; }

        /// <summary>Optional. The filters for this report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filters")]
        public virtual System.Collections.Generic.IList<Filter> Filters { get; set; }

        /// <summary>Required. The list of metrics to report on. If empty, the report will have no metrics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>Optional. Default sorts to apply to this report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sorts")]
        public virtual System.Collections.Generic.IList<Sort> Sorts { get; set; }

        /// <summary>
        /// Optional. If time_zone_source is PROVIDED, this is the time zone to use for this report. Leave empty for any
        /// other time zone source. Time zone in IANA format. For example, "America/New_York".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>
        /// Optional. Where to get the time zone for this report. Defaults to using the Pacific time zone (PT). If
        /// source is PROVIDED, the time_zone field in the report definition must also set a time zone.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZoneSource")]
        public virtual string TimeZoneSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a single value in a report.</summary>
    public class ReportValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>For boolean values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>For bytes values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bytesValue")]
        public virtual string BytesValue { get; set; }

        /// <summary>For lists of double values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleListValue")]
        public virtual DoubleList DoubleListValue { get; set; }

        /// <summary>For double values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("doubleValue")]
        public virtual System.Nullable<double> DoubleValue { get; set; }

        /// <summary>For lists of integer values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intListValue")]
        public virtual IntList IntListValue { get; set; }

        /// <summary>For integer values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        /// <summary>For lists of string values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringListValue")]
        public virtual StringList StringListValue { get; set; }

        /// <summary>For string values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A row of report data.</summary>
    public class Row : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The order of the dimension values is the same as the order of the dimensions specified in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionValues")]
        public virtual System.Collections.Generic.IList<ReportValue> DimensionValues { get; set; }

        /// <summary>
        ///  The length of the metric_value_groups field will be equal to the length of the date_ranges field in the
        /// fetch response. The metric_value_groups field is ordered such that each index corresponds to the date_range
        /// at the same index. For example, given date_ranges [x, y], metric_value_groups will have a length of two. The
        /// first entry in metric_value_groups represents the metrics for date x and the second entry in
        /// metric_value_groups represents the metrics for date y.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metricValueGroups")]
        public virtual System.Collections.Generic.IList<MetricValueGroup> MetricValueGroups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`RunReport` operation metadata.</summary>
    public class RunReportMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An estimate of how close this report is to being completed. Will always be 100 for failed and completed
        /// reports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentComplete")]
        public virtual System.Nullable<int> PercentComplete { get; set; }

        /// <summary>The result's parent report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("report")]
        public virtual string Report { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for a running a report.</summary>
    public class RunReportRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for a completed `RunReport` operation.</summary>
    public class RunReportResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The unique name of the generated result. Use with `FetchReportResultRows` to retrieve data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reportResult")]
        public virtual string ReportResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a sorting in a report.</summary>
    public class Sort : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The sort order. If true the sort will be descending.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("descending")]
        public virtual System.Nullable<bool> Descending { get; set; }

        /// <summary>Required. A field (dimension or metric) to sort by.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual Field Field { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>A list of string values.</summary>
    public class StringList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The values</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Generic targeting with string values.</summary>
    public class StringTargetingDimension : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. How the items in this list should be targeted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectionType")]
        public virtual string SelectionType { get; set; }

        /// <summary>Required. The values specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Defines targeting criteria for handling the IAB audience and content Taxonomy ID space.</summary>
    public class TaxonomyTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The list of excluded content taxonomy IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedTaxonomyIds")]
        public virtual System.Collections.Generic.IList<string> ExcludedTaxonomyIds { get; set; }

        /// <summary>Optional. The list of targeted content taxonomy IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetedTaxonomyIds")]
        public virtual System.Collections.Generic.IList<string> TargetedTaxonomyIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents the size of the video player that can be targeted. Both width and height are required to be set to
    /// non-zero values.
    /// </summary>
    public class VideoPlayerSizeTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The minimum height of the video player in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumHeight")]
        public virtual System.Nullable<long> MinimumHeight { get; set; }

        /// <summary>Required. The minimum width of the video player in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumWidth")]
        public virtual System.Nullable<long> MinimumWidth { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines targeting criteria based on the video placement type, often corresponding to the IAB OpenRTB 'plcmt'
    /// field.
    /// </summary>
    public class VideoPlcmtTargeting : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The selection type for the list of video plcmts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectionType")]
        public virtual string SelectionType { get; set; }

        /// <summary>
        /// Required. The list of targeted video plcmts types. If empty, inventory will be targeted regardless of video
        /// plcmt type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoPlcmtTypes")]
        public virtual System.Collections.Generic.IList<string> VideoPlcmtTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
