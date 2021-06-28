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

namespace Google.Apis.RealTimeBidding.v1alpha
{
    /// <summary>The RealTimeBidding Service.</summary>
    public class RealTimeBiddingService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public RealTimeBiddingService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public RealTimeBiddingService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Bidders = new BiddersResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "realtimebidding";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://realtimebidding.googleapis.com/";
        #else
            "https://realtimebidding.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://realtimebidding.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Real-time Bidding API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, create, edit, and delete your Authorized Buyers and Open Bidding account entities
            /// </summary>
            public static string RealtimeBidding = "https://www.googleapis.com/auth/realtime-bidding";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Real-time Bidding API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, create, edit, and delete your Authorized Buyers and Open Bidding account entities
            /// </summary>
            public const string RealtimeBidding = "https://www.googleapis.com/auth/realtime-bidding";
        }

        /// <summary>Gets the Bidders resource.</summary>
        public virtual BiddersResource Bidders { get; }
    }

    /// <summary>A base abstract class for RealTimeBidding requests.</summary>
    public abstract class RealTimeBiddingBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new RealTimeBiddingBaseServiceRequest instance.</summary>
        protected RealTimeBiddingBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes RealTimeBidding parameter list.</summary>
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

    /// <summary>The "bidders" collection of methods.</summary>
    public class BiddersResource
    {
        private const string Resource = "bidders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BiddersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            BiddingFunctions = new BiddingFunctionsResource(service);
        }

        /// <summary>Gets the BiddingFunctions resource.</summary>
        public virtual BiddingFunctionsResource BiddingFunctions { get; }

        /// <summary>The "biddingFunctions" collection of methods.</summary>
        public class BiddingFunctionsResource
        {
            private const string Resource = "biddingFunctions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BiddingFunctionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Activates an existing bidding function. An activated function is available for invocation for the
            /// server-side TURTLEDOVE simulations.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the bidding function to activate. Format:
            /// `bidders/{bidder_account_id}/biddingFunction/{bidding_function_name}`
            /// </param>
            public virtual ActivateRequest Activate(Google.Apis.RealTimeBidding.v1alpha.Data.ActivateBiddingFunctionRequest body, string name)
            {
                return new ActivateRequest(service, body, name);
            }

            /// <summary>
            /// Activates an existing bidding function. An activated function is available for invocation for the
            /// server-side TURTLEDOVE simulations.
            /// </summary>
            public class ActivateRequest : RealTimeBiddingBaseServiceRequest<Google.Apis.RealTimeBidding.v1alpha.Data.BiddingFunction>
            {
                /// <summary>Constructs a new Activate request.</summary>
                public ActivateRequest(Google.Apis.Services.IClientService service, Google.Apis.RealTimeBidding.v1alpha.Data.ActivateBiddingFunctionRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the bidding function to activate. Format:
                /// `bidders/{bidder_account_id}/biddingFunction/{bidding_function_name}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RealTimeBidding.v1alpha.Data.ActivateBiddingFunctionRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "activate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}:activate";

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
                        Pattern = @"^bidders/[^/]+/biddingFunctions/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Archives an existing bidding function. An archived function will not be available for function
            /// invocation for the server-side TURTLEDOVE simulations unless it is activated.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. The name of the bidding function to archive. Format:
            /// `bidders/{bidder_account_id}/biddingFunction/{bidding_function_name}`
            /// </param>
            public virtual ArchiveRequest Archive(Google.Apis.RealTimeBidding.v1alpha.Data.ArchiveBiddingFunctionRequest body, string name)
            {
                return new ArchiveRequest(service, body, name);
            }

            /// <summary>
            /// Archives an existing bidding function. An archived function will not be available for function
            /// invocation for the server-side TURTLEDOVE simulations unless it is activated.
            /// </summary>
            public class ArchiveRequest : RealTimeBiddingBaseServiceRequest<Google.Apis.RealTimeBidding.v1alpha.Data.BiddingFunction>
            {
                /// <summary>Constructs a new Archive request.</summary>
                public ArchiveRequest(Google.Apis.Services.IClientService service, Google.Apis.RealTimeBidding.v1alpha.Data.ArchiveBiddingFunctionRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the bidding function to archive. Format:
                /// `bidders/{bidder_account_id}/biddingFunction/{bidding_function_name}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RealTimeBidding.v1alpha.Data.ArchiveBiddingFunctionRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "archive";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+name}:archive";

                /// <summary>Initializes Archive parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^bidders/[^/]+/biddingFunctions/[^/]+$",
                    });
                }
            }

            /// <summary>Creates a new bidding function.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the bidder for which to create the bidding function. Format:
            /// `bidders/{bidderAccountId}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.RealTimeBidding.v1alpha.Data.BiddingFunction body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a new bidding function.</summary>
            public class CreateRequest : RealTimeBiddingBaseServiceRequest<Google.Apis.RealTimeBidding.v1alpha.Data.BiddingFunction>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.RealTimeBidding.v1alpha.Data.BiddingFunction body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the bidder for which to create the bidding function. Format:
                /// `bidders/{bidderAccountId}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.RealTimeBidding.v1alpha.Data.BiddingFunction Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/biddingFunctions";

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
                        Pattern = @"^bidders/[^/]+$",
                    });
                }
            }

            /// <summary>Lists the bidding functions that a bidder currently has registered.</summary>
            /// <param name="parent">
            /// Required. Name of the bidder whose bidding functions will be listed. Format:
            /// `bidders/{bidder_account_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists the bidding functions that a bidder currently has registered.</summary>
            public class ListRequest : RealTimeBiddingBaseServiceRequest<Google.Apis.RealTimeBidding.v1alpha.Data.ListBiddingFunctionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the bidder whose bidding functions will be listed. Format:
                /// `bidders/{bidder_account_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The maximum number of bidding functions to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A token identifying a page of results the server should return. This value is received from a
                /// previous `ListBiddingFunctions` call in ListBiddingFunctionsResponse.nextPageToken.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha/{+parent}/biddingFunctions";

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
                        Pattern = @"^bidders/[^/]+$",
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
}
namespace Google.Apis.RealTimeBidding.v1alpha.Data
{
    /// <summary>The request to activate a bidding function.</summary>
    public class ActivateBiddingFunctionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to archive a bidding function.</summary>
    public class ArchiveBiddingFunctionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The bidding function to be executed as part of the TURTLEDOVE simulation experiment bidding flow.
    /// </summary>
    public class BiddingFunction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The raw Javascript source code of the bidding function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("biddingFunction")]
        public virtual string BiddingFunctionValue { get; set; }

        /// <summary>
        /// The name of the bidding function that must follow the pattern:
        /// `bidders/{bidder_account_id}/biddingFunctions/{bidding_function_name}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The state of the bidding function.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The type of the bidding function to be created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response containing a list of a bidder's bidding functions.</summary>
    public class ListBiddingFunctionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of a bidder's bidding functions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("biddingFunctions")]
        public virtual System.Collections.Generic.IList<BiddingFunction> BiddingFunctions { get; set; }

        /// <summary>
        /// A token which can be passed to a subsequent call to the `ListBiddingFunctions` method to retrieve the next
        /// page of results in ListBiddingFunctionsRequest.pageToken.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
