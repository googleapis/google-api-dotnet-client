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

namespace Google.Apis.PostmasterTools.v1beta1
{
    /// <summary>The PostmasterTools Service.</summary>
    public class PostmasterToolsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PostmasterToolsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PostmasterToolsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Domains = new DomainsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "gmailpostmastertools";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://gmailpostmastertools.googleapis.com/";
        #else
            "https://gmailpostmastertools.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://gmailpostmastertools.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Gmail Postmaster Tools API.</summary>
        public class Scope
        {
            /// <summary>
            /// See email traffic metrics for the domains you have registered in Gmail Postmaster Tools
            /// </summary>
            public static string PostmasterReadonly = "https://www.googleapis.com/auth/postmaster.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Gmail Postmaster Tools API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See email traffic metrics for the domains you have registered in Gmail Postmaster Tools
            /// </summary>
            public const string PostmasterReadonly = "https://www.googleapis.com/auth/postmaster.readonly";
        }

        /// <summary>Gets the Domains resource.</summary>
        public virtual DomainsResource Domains { get; }
    }

    /// <summary>A base abstract class for PostmasterTools requests.</summary>
    public abstract class PostmasterToolsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new PostmasterToolsBaseServiceRequest instance.</summary>
        protected PostmasterToolsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes PostmasterTools parameter list.</summary>
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

    /// <summary>The "domains" collection of methods.</summary>
    public class DomainsResource
    {
        private const string Resource = "domains";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DomainsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            TrafficStats = new TrafficStatsResource(service);
        }

        /// <summary>Gets the TrafficStats resource.</summary>
        public virtual TrafficStatsResource TrafficStats { get; }

        /// <summary>The "trafficStats" collection of methods.</summary>
        public class TrafficStatsResource
        {
            private const string Resource = "trafficStats";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TrafficStatsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Get traffic statistics for a domain on a specific date. Returns PERMISSION_DENIED if user does not have
            /// permission to access TrafficStats for the domain.
            /// </summary>
            /// <param name="name">
            /// The resource name of the traffic statistics to get. E.g.,
            /// domains/mymail.mydomain.com/trafficStats/20160807.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Get traffic statistics for a domain on a specific date. Returns PERMISSION_DENIED if user does not have
            /// permission to access TrafficStats for the domain.
            /// </summary>
            public class GetRequest : PostmasterToolsBaseServiceRequest<Google.Apis.PostmasterTools.v1beta1.Data.TrafficStats>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the traffic statistics to get. E.g.,
                /// domains/mymail.mydomain.com/trafficStats/20160807.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+name}";

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
                        Pattern = @"^domains/[^/]+/trafficStats/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// List traffic statistics for all available days. Returns PERMISSION_DENIED if user does not have
            /// permission to access TrafficStats for the domain.
            /// </summary>
            /// <param name="parent">
            /// The resource name of the domain whose traffic statistics we'd like to list. It should have the form
            /// `domains/{domain_name}`, where domain_name is the fully qualified domain name.
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// List traffic statistics for all available days. Returns PERMISSION_DENIED if user does not have
            /// permission to access TrafficStats for the domain.
            /// </summary>
            public class ListRequest : PostmasterToolsBaseServiceRequest<Google.Apis.PostmasterTools.v1beta1.Data.ListTrafficStatsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// The resource name of the domain whose traffic statistics we'd like to list. It should have the form
                /// `domains/{domain_name}`, where domain_name is the fully qualified domain name.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by
                /// itself or a year and month where the day isn't significant.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("endDate.day", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> EndDateDay { get; set; }

                /// <summary>
                /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("endDate.month", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> EndDateMonth { get; set; }

                /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
                [Google.Apis.Util.RequestParameterAttribute("endDate.year", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> EndDateYear { get; set; }

                /// <summary>
                /// Requested page size. Server may return fewer TrafficStats than requested. If unspecified, server
                /// will pick an appropriate default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The next_page_token value returned from a previous List request, if any. This is the value of
                /// ListTrafficStatsResponse.next_page_token returned from the previous call to `ListTrafficStats`
                /// method.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by
                /// itself or a year and month where the day isn't significant.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startDate.day", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartDateDay { get; set; }

                /// <summary>
                /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startDate.month", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartDateMonth { get; set; }

                /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
                [Google.Apis.Util.RequestParameterAttribute("startDate.year", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> StartDateYear { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta1/{+parent}/trafficStats";

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
                        Pattern = @"^domains/[^/]+$",
                    });
                    RequestParameters.Add("endDate.day", new Google.Apis.Discovery.Parameter
                    {
                        Name = "endDate.day",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("endDate.month", new Google.Apis.Discovery.Parameter
                    {
                        Name = "endDate.month",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("endDate.year", new Google.Apis.Discovery.Parameter
                    {
                        Name = "endDate.year",
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
                    RequestParameters.Add("startDate.day", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startDate.day",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("startDate.month", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startDate.month",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("startDate.year", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startDate.year",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>
        /// Gets a specific domain registered by the client. Returns NOT_FOUND if the domain does not exist.
        /// </summary>
        /// <param name="name">
        /// The resource name of the domain. It should have the form `domains/{domain_name}`, where domain_name is the
        /// fully qualified domain name.
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Gets a specific domain registered by the client. Returns NOT_FOUND if the domain does not exist.
        /// </summary>
        public class GetRequest : PostmasterToolsBaseServiceRequest<Google.Apis.PostmasterTools.v1beta1.Data.Domain>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the domain. It should have the form `domains/{domain_name}`, where domain_name is
            /// the fully qualified domain name.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/{+name}";

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
                    Pattern = @"^domains/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Lists the domains that have been registered by the client. The order of domains in the response is
        /// unspecified and non-deterministic. Newly created domains will not necessarily be added to the end of this
        /// list.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Lists the domains that have been registered by the client. The order of domains in the response is
        /// unspecified and non-deterministic. Newly created domains will not necessarily be added to the end of this
        /// list.
        /// </summary>
        public class ListRequest : PostmasterToolsBaseServiceRequest<Google.Apis.PostmasterTools.v1beta1.Data.ListDomainsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Requested page size. Server may return fewer domains than requested. If unspecified, server will pick an
            /// appropriate default.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// The next_page_token value returned from a previous List request, if any. This is the value of
            /// ListDomainsResponse.next_page_token returned from the previous call to `ListDomains` method.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/domains";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
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
namespace Google.Apis.PostmasterTools.v1beta1.Data
{
    /// <summary>Metric on a particular delivery error type.</summary>
    public class DeliveryError : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The class of delivery error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorClass")]
        public virtual string ErrorClass { get; set; }

        /// <summary>The ratio of messages where the error occurred vs all authenticated traffic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorRatio")]
        public virtual System.Nullable<double> ErrorRatio { get; set; }

        /// <summary>The type of delivery error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorType")]
        public virtual string ErrorType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A registered domain resource in the Postmaster API.</summary>
    public class Domain : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Timestamp when the user registered this domain. Assigned by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The resource name of the Domain. Domain names have the form `domains/{domain_name}`, where domain_name is
        /// the fully qualified domain name (i.e., mymail.mydomain.com).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>User’s permission for this domain. Assigned by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual string Permission { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>[Feedback loop](https://support.google.com/mail/answer/6254652) identifier information.</summary>
    public class FeedbackLoop : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Feedback loop identifier that uniquely identifies individual campaigns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The ratio of user marked spam messages with the identifier vs the total number of inboxed messages with that
        /// identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spamRatio")]
        public virtual System.Nullable<double> SpamRatio { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>IP Reputation information for a set of IPs in a specific reputation category.</summary>
    public class IpReputation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Total number of unique IPs in this reputation category. This metric only pertains to traffic that passed
        /// [SPF](http://www.openspf.org/) or [DKIM](http://www.dkim.org/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipCount")]
        public virtual System.Nullable<long> IpCount { get; set; }

        /// <summary>
        /// Total number of unique IPs in this reputation category. This metric only pertains to traffic that passed
        /// [SPF](http://www.openspf.org/) or [DKIM](http://www.dkim.org/). Deprecated to be complied with ApiLinter for
        /// Quantities. Use ip_count instead.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numIps")]
        public virtual System.Nullable<long> NumIps { get; set; }

        /// <summary>The reputation category this IP reputation represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reputation")]
        public virtual string Reputation { get; set; }

        /// <summary>A sample of IPs in this reputation category.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleIps")]
        public virtual System.Collections.Generic.IList<string> SampleIps { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListDomains.</summary>
    public class ListDomainsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of domains.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<Domain> Domains { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for ListTrafficStats.</summary>
    public class ListTrafficStatsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The list of TrafficStats.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trafficStats")]
        public virtual System.Collections.Generic.IList<TrafficStats> TrafficStats { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Email traffic statistics pertaining to a specific date.</summary>
    public class TrafficStats : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Delivery errors for the domain. This metric only pertains to traffic that passed
        /// [SPF](http://www.openspf.org/) or [DKIM](http://www.dkim.org/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryErrors")]
        public virtual System.Collections.Generic.IList<DeliveryError> DeliveryErrors { get; set; }

        /// <summary>
        /// The ratio of mail that successfully authenticated with DKIM vs. all mail that attempted to authenticate with
        /// [DKIM](http://www.dkim.org/). Spoofed mail is excluded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dkimSuccessRatio")]
        public virtual System.Nullable<double> DkimSuccessRatio { get; set; }

        /// <summary>
        /// The ratio of mail that passed [DMARC](https://dmarc.org/) alignment checks vs all mail received from the
        /// domain that successfully authenticated with either of [SPF](http://www.openspf.org/) or
        /// [DKIM](http://www.dkim.org/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dmarcSuccessRatio")]
        public virtual System.Nullable<double> DmarcSuccessRatio { get; set; }

        /// <summary>Reputation of the domain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainReputation")]
        public virtual string DomainReputation { get; set; }

        /// <summary>
        /// The ratio of incoming mail (to Gmail), that passed secure transport (TLS) vs all mail received from that
        /// domain. This metric only pertains to traffic that passed [SPF](http://www.openspf.org/) or
        /// [DKIM](http://www.dkim.org/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inboundEncryptionRatio")]
        public virtual System.Nullable<double> InboundEncryptionRatio { get; set; }

        /// <summary>
        /// Reputation information pertaining to the IP addresses of the email servers for the domain. There is exactly
        /// one entry for each reputation category except REPUTATION_CATEGORY_UNSPECIFIED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipReputations")]
        public virtual System.Collections.Generic.IList<IpReputation> IpReputations { get; set; }

        /// <summary>
        /// The resource name of the traffic statistics. Traffic statistic names have the form
        /// `domains/{domain}/trafficStats/{date}`, where domain_name is the fully qualified domain name (i.e.,
        /// mymail.mydomain.com) of the domain this traffic statistics pertains to and date is the date in yyyymmdd
        /// format that these statistics corresponds to. For example: domains/mymail.mydomain.com/trafficStats/20160807
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ratio of outgoing mail (from Gmail) that was accepted over secure transport (TLS).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outboundEncryptionRatio")]
        public virtual System.Nullable<double> OutboundEncryptionRatio { get; set; }

        /// <summary>
        /// Spammy [Feedback loop identifiers] (https://support.google.com/mail/answer/6254652) with their individual
        /// spam rates. This metric only pertains to traffic that is authenticated by [DKIM](http://www.dkim.org/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spammyFeedbackLoops")]
        public virtual System.Collections.Generic.IList<FeedbackLoop> SpammyFeedbackLoops { get; set; }

        /// <summary>
        /// The ratio of mail that successfully authenticated with SPF vs. all mail that attempted to authenticate with
        /// [SPF](http://www.openspf.org/). Spoofed mail is excluded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spfSuccessRatio")]
        public virtual System.Nullable<double> SpfSuccessRatio { get; set; }

        /// <summary>
        /// The ratio of user-report spam vs. email that was sent to the inbox. This metric only pertains to emails
        /// authenticated by [DKIM](http://www.dkim.org/).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userReportedSpamRatio")]
        public virtual System.Nullable<double> UserReportedSpamRatio { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
