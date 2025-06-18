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

namespace Google.Apis.AuthorizedBuyersMarketplace.v1beta
{
    /// <summary>The AuthorizedBuyersMarketplace Service.</summary>
    public class AuthorizedBuyersMarketplaceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AuthorizedBuyersMarketplaceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AuthorizedBuyersMarketplaceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Curators = new CuratorsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://authorizedbuyersmarketplace.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://authorizedbuyersmarketplace.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "authorizedbuyersmarketplace";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Authorized Buyers Marketplace API.</summary>
        public class Scope
        {
            /// <summary>See, create, edit, and delete your Authorized Buyers Marketplace entities.</summary>
            public static string AuthorizedBuyersMarketplace = "https://www.googleapis.com/auth/authorized-buyers-marketplace";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Authorized Buyers Marketplace API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, create, edit, and delete your Authorized Buyers Marketplace entities.</summary>
            public const string AuthorizedBuyersMarketplace = "https://www.googleapis.com/auth/authorized-buyers-marketplace";
        }

        /// <summary>Gets the Curators resource.</summary>
        public virtual CuratorsResource Curators { get; }
    }

    /// <summary>A base abstract class for AuthorizedBuyersMarketplace requests.</summary>
    public abstract class AuthorizedBuyersMarketplaceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AuthorizedBuyersMarketplaceBaseServiceRequest instance.</summary>
        protected AuthorizedBuyersMarketplaceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes AuthorizedBuyersMarketplace parameter list.</summary>
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
            DataSegments = new DataSegmentsResource(service);
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
            /// Required. Name of data segment to activate. v1alpha format:
            /// `buyers/{accountId}/dataSegments/{curatorDataSegmentId}` v1beta format:
            /// `curators/{accountId}/dataSegments/{curatorDataSegmentId}`
            /// </param>
            public virtual ActivateRequest Activate(Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data.ActivateDataSegmentRequest body, string name)
            {
                return new ActivateRequest(this.service, body, name);
            }

            /// <summary>Activates a data segment.</summary>
            public class ActivateRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data.DataSegment>
            {
                /// <summary>Constructs a new Activate request.</summary>
                public ActivateRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data.ActivateDataSegmentRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of data segment to activate. v1alpha format:
                /// `buyers/{accountId}/dataSegments/{curatorDataSegmentId}` v1beta format:
                /// `curators/{accountId}/dataSegments/{curatorDataSegmentId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data.ActivateDataSegmentRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "activate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}:activate";

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
            /// Required. The parent resource where this data segment will be created. v1alpha format:
            /// `buyers/{accountId}` v1beta format: `curators/{accountId}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data.DataSegment body, string parent)
            {
                return new CreateRequest(this.service, body, parent);
            }

            /// <summary>
            /// Creates a data segment owned by the listed curator. The data segment will be created in the `ACTIVE`
            /// state, meaning it will be immediately available for buyers to use in preferred deals, private auction
            /// deals, and auction packages.
            /// </summary>
            public class CreateRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data.DataSegment>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data.DataSegment body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent resource where this data segment will be created. v1alpha format:
                /// `buyers/{accountId}` v1beta format: `curators/{accountId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data.DataSegment Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+parent}/dataSegments";

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
            /// Required. Name of data segment to deactivate. v1alpha format:
            /// `buyers/{accountId}/dataSegments/{curatorDataSegmentId}` v1beta format:
            /// `curators/{accountId}/dataSegments/{curatorDataSegmentId}`
            /// </param>
            public virtual DeactivateRequest Deactivate(Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data.DeactivateDataSegmentRequest body, string name)
            {
                return new DeactivateRequest(this.service, body, name);
            }

            /// <summary>Deactivates a data segment.</summary>
            public class DeactivateRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data.DataSegment>
            {
                /// <summary>Constructs a new Deactivate request.</summary>
                public DeactivateRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data.DeactivateDataSegmentRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of data segment to deactivate. v1alpha format:
                /// `buyers/{accountId}/dataSegments/{curatorDataSegmentId}` v1beta format:
                /// `curators/{accountId}/dataSegments/{curatorDataSegmentId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data.DeactivateDataSegmentRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "deactivate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}:deactivate";

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
            /// Required. Name of data segment to get. v1alpha format:
            /// `buyers/{accountId}/dataSegments/{curatorDataSegmentId}` v1beta format:
            /// `curators/{accountId}/dataSegments/{curatorDataSegmentId}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a data segment given its name.</summary>
            public class GetRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data.DataSegment>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of data segment to get. v1alpha format:
                /// `buyers/{accountId}/dataSegments/{curatorDataSegmentId}` v1beta format:
                /// `curators/{accountId}/dataSegments/{curatorDataSegmentId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
            /// Required. Name of the parent curator that can access the data segment. v1alpha format:
            /// `buyers/{accountId}` v1beta format: `curators/{accountId}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>List the data segments owned by a curator.</summary>
            public class ListRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data.ListDataSegmentsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the parent curator that can access the data segment. v1alpha format:
                /// `buyers/{accountId}` v1beta format: `curators/{accountId}`
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
                public override string RestPath => "v1beta/{+parent}/dataSegments";

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
            /// ID that created the segment. v1alpha format: `buyers/{accountId}/dataSegments/{curatorDataSegmentId}`
            /// v1beta format: `curators/{curatorAccountId}/dataSegments/{curatorDataSegmentId}`
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data.DataSegment body, string name)
            {
                return new PatchRequest(this.service, body, name);
            }

            /// <summary>Updates a data segment.</summary>
            public class PatchRequest : AuthorizedBuyersMarketplaceBaseServiceRequest<Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data.DataSegment>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data.DataSegment body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Immutable. Identifier. The unique identifier for the data segment. Account ID corresponds to the
                /// account ID that created the segment. v1alpha format:
                /// `buyers/{accountId}/dataSegments/{curatorDataSegmentId}` v1beta format:
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
                Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data.DataSegment Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta/{+name}";

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
    }
}
namespace Google.Apis.AuthorizedBuyersMarketplace.v1beta.Data
{
    /// <summary>Request message for activating a data segment</summary>
    public class ActivateDataSegmentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines an identifier for a segment of inventory that can be targeted by curators or media planners in the deals
    /// or auction packages UI. Curation of inventory is done by curators on external platforms.
    /// </summary>
    public class DataSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. This will be charged when other accounts use this data segment. For example, when other accounts
        /// add this data segment to a deal or auction package. Once set, the currency code cannot be changed.
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
        /// Immutable. Identifier. The unique identifier for the data segment. Account ID corresponds to the account ID
        /// that created the segment. v1alpha format: `buyers/{accountId}/dataSegments/{curatorDataSegmentId}` v1beta
        /// format: `curators/{curatorAccountId}/dataSegments/{curatorDataSegmentId}`
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for deactivating a data segment</summary>
    public class DeactivateDataSegmentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
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
}
