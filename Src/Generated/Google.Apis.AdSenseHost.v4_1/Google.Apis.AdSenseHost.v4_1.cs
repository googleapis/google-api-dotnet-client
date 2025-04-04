// Copyright 2024 Google LLC
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

namespace Google.Apis.AdSenseHost.v4_1
{
    /// <summary>The AdSenseHost Service.</summary>
    public class AdSenseHostService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v4.1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AdSenseHostService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AdSenseHostService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            Adclients = new AdclientsResource(this);
            Associationsessions = new AssociationsessionsResource(this);
            Customchannels = new CustomchannelsResource(this);
            Reports = new ReportsResource(this);
            Urlchannels = new UrlchannelsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://www.googleapis.com/adsensehost/v4.1/");
            BatchUri = GetEffectiveUri(null, "https://www.googleapis.com/batch/adsensehost/v4.1");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "adsensehost";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "adsensehost/v4.1/";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch/adsensehost/v4.1";

        /// <summary>Available OAuth 2.0 scopes for use with the AdSense Host API.</summary>
        public class Scope
        {
            /// <summary>View and manage your AdSense host data and associated accounts</summary>
            public static string Adsensehost = "https://www.googleapis.com/auth/adsensehost";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the AdSense Host API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your AdSense host data and associated accounts</summary>
            public const string Adsensehost = "https://www.googleapis.com/auth/adsensehost";
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }

        /// <summary>Gets the Adclients resource.</summary>
        public virtual AdclientsResource Adclients { get; }

        /// <summary>Gets the Associationsessions resource.</summary>
        public virtual AssociationsessionsResource Associationsessions { get; }

        /// <summary>Gets the Customchannels resource.</summary>
        public virtual CustomchannelsResource Customchannels { get; }

        /// <summary>Gets the Reports resource.</summary>
        public virtual ReportsResource Reports { get; }

        /// <summary>Gets the Urlchannels resource.</summary>
        public virtual UrlchannelsResource Urlchannels { get; }
    }

    /// <summary>A base abstract class for AdSenseHost requests.</summary>
    public abstract class AdSenseHostBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AdSenseHostBaseServiceRequest instance.</summary>
        protected AdSenseHostBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of text/csv</summary>
            [Google.Apis.Util.StringValueAttribute("csv")]
            Csv = 0,

            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json = 1,
        }

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
        /// An opaque string that represents a user for quota purposes. Must not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Deprecated. Please use quotaUser instead.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes AdSenseHost parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
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
            RequestParameters.Add("userIp", new Google.Apis.Discovery.Parameter
            {
                Name = "userIp",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "accounts" collection of methods.</summary>
    public class AccountsResource
    {
        private const string Resource = "accounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Adclients = new AdclientsResource(service);
            Adunits = new AdunitsResource(service);
            Reports = new ReportsResource(service);
        }

        /// <summary>Gets the Adclients resource.</summary>
        public virtual AdclientsResource Adclients { get; }

        /// <summary>The "adclients" collection of methods.</summary>
        public class AdclientsResource
        {
            private const string Resource = "adclients";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AdclientsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Get information about one of the ad clients in the specified publisher's AdSense account.
            /// </summary>
            /// <param name="accountId">Account which contains the ad client.</param>
            /// <param name="adClientId">Ad client to get.</param>
            public virtual GetRequest Get(string accountId, string adClientId)
            {
                return new GetRequest(this.service, accountId, adClientId);
            }

            /// <summary>
            /// Get information about one of the ad clients in the specified publisher's AdSense account.
            /// </summary>
            public class GetRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.AdClient>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string adClientId) : base(service)
                {
                    AccountId = accountId;
                    AdClientId = adClientId;
                    InitParameters();
                }

                /// <summary>Account which contains the ad client.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Ad client to get.</summary>
                [Google.Apis.Util.RequestParameterAttribute("adClientId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AdClientId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/{accountId}/adclients/{adClientId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("adClientId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "adClientId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>List all hosted ad clients in the specified hosted account.</summary>
            /// <param name="accountId">Account for which to list ad clients.</param>
            public virtual ListRequest List(string accountId)
            {
                return new ListRequest(this.service, accountId);
            }

            /// <summary>List all hosted ad clients in the specified hosted account.</summary>
            public class ListRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.AdClients>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId) : base(service)
                {
                    AccountId = accountId;
                    InitParameters();
                }

                /// <summary>Account for which to list ad clients.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>The maximum number of ad clients to include in the response, used for paging.</summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults { get; set; }

                /// <summary>
                /// A continuation token, used to page through ad clients. To retrieve the next page, set this parameter
                /// to the value of "nextPageToken" from the previous response.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/{accountId}/adclients";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
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

        /// <summary>Gets the Adunits resource.</summary>
        public virtual AdunitsResource Adunits { get; }

        /// <summary>The "adunits" collection of methods.</summary>
        public class AdunitsResource
        {
            private const string Resource = "adunits";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AdunitsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Delete the specified ad unit from the specified publisher AdSense account.</summary>
            /// <param name="accountId">Account which contains the ad unit.</param>
            /// <param name="adClientId">Ad client for which to get ad unit.</param>
            /// <param name="adUnitId">Ad unit to delete.</param>
            public virtual DeleteRequest Delete(string accountId, string adClientId, string adUnitId)
            {
                return new DeleteRequest(this.service, accountId, adClientId, adUnitId);
            }

            /// <summary>Delete the specified ad unit from the specified publisher AdSense account.</summary>
            public class DeleteRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.AdUnit>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string accountId, string adClientId, string adUnitId) : base(service)
                {
                    AccountId = accountId;
                    AdClientId = adClientId;
                    AdUnitId = adUnitId;
                    InitParameters();
                }

                /// <summary>Account which contains the ad unit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Ad client for which to get ad unit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("adClientId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AdClientId { get; private set; }

                /// <summary>Ad unit to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("adUnitId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AdUnitId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/{accountId}/adclients/{adClientId}/adunits/{adUnitId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("adClientId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "adClientId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("adUnitId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "adUnitId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Get the specified host ad unit in this AdSense account.</summary>
            /// <param name="accountId">Account which contains the ad unit.</param>
            /// <param name="adClientId">Ad client for which to get ad unit.</param>
            /// <param name="adUnitId">Ad unit to get.</param>
            public virtual GetRequest Get(string accountId, string adClientId, string adUnitId)
            {
                return new GetRequest(this.service, accountId, adClientId, adUnitId);
            }

            /// <summary>Get the specified host ad unit in this AdSense account.</summary>
            public class GetRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.AdUnit>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string accountId, string adClientId, string adUnitId) : base(service)
                {
                    AccountId = accountId;
                    AdClientId = adClientId;
                    AdUnitId = adUnitId;
                    InitParameters();
                }

                /// <summary>Account which contains the ad unit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Ad client for which to get ad unit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("adClientId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AdClientId { get; private set; }

                /// <summary>Ad unit to get.</summary>
                [Google.Apis.Util.RequestParameterAttribute("adUnitId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AdUnitId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/{accountId}/adclients/{adClientId}/adunits/{adUnitId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("adClientId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "adClientId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("adUnitId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "adUnitId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Get ad code for the specified ad unit, attaching the specified host custom channels.</summary>
            /// <param name="accountId">Account which contains the ad client.</param>
            /// <param name="adClientId">Ad client with contains the ad unit.</param>
            /// <param name="adUnitId">Ad unit to get the code for.</param>
            public virtual GetAdCodeRequest GetAdCode(string accountId, string adClientId, string adUnitId)
            {
                return new GetAdCodeRequest(this.service, accountId, adClientId, adUnitId);
            }

            /// <summary>Get ad code for the specified ad unit, attaching the specified host custom channels.</summary>
            public class GetAdCodeRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.AdCode>
            {
                /// <summary>Constructs a new GetAdCode request.</summary>
                public GetAdCodeRequest(Google.Apis.Services.IClientService service, string accountId, string adClientId, string adUnitId) : base(service)
                {
                    AccountId = accountId;
                    AdClientId = adClientId;
                    AdUnitId = adUnitId;
                    InitParameters();
                }

                /// <summary>Account which contains the ad client.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Ad client with contains the ad unit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("adClientId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AdClientId { get; private set; }

                /// <summary>Ad unit to get the code for.</summary>
                [Google.Apis.Util.RequestParameterAttribute("adUnitId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AdUnitId { get; private set; }

                /// <summary>Host custom channel to attach to the ad code.</summary>
                [Google.Apis.Util.RequestParameterAttribute("hostCustomChannelId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> HostCustomChannelId { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getAdCode";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/{accountId}/adclients/{adClientId}/adunits/{adUnitId}/adcode";

                /// <summary>Initializes GetAdCode parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("adClientId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "adClientId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("adUnitId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "adUnitId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("hostCustomChannelId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "hostCustomChannelId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Insert the supplied ad unit into the specified publisher AdSense account.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account which will contain the ad unit.</param>
            /// <param name="adClientId">Ad client into which to insert the ad unit.</param>
            public virtual InsertRequest Insert(Google.Apis.AdSenseHost.v4_1.Data.AdUnit body, string accountId, string adClientId)
            {
                return new InsertRequest(this.service, body, accountId, adClientId);
            }

            /// <summary>Insert the supplied ad unit into the specified publisher AdSense account.</summary>
            public class InsertRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.AdUnit>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AdSenseHost.v4_1.Data.AdUnit body, string accountId, string adClientId) : base(service)
                {
                    AccountId = accountId;
                    AdClientId = adClientId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account which will contain the ad unit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Ad client into which to insert the ad unit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("adClientId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AdClientId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdSenseHost.v4_1.Data.AdUnit Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/{accountId}/adclients/{adClientId}/adunits";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("adClientId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "adClientId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>List all ad units in the specified publisher's AdSense account.</summary>
            /// <param name="accountId">Account which contains the ad client.</param>
            /// <param name="adClientId">Ad client for which to list ad units.</param>
            public virtual ListRequest List(string accountId, string adClientId)
            {
                return new ListRequest(this.service, accountId, adClientId);
            }

            /// <summary>List all ad units in the specified publisher's AdSense account.</summary>
            public class ListRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.AdUnits>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string accountId, string adClientId) : base(service)
                {
                    AccountId = accountId;
                    AdClientId = adClientId;
                    InitParameters();
                }

                /// <summary>Account which contains the ad client.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Ad client for which to list ad units.</summary>
                [Google.Apis.Util.RequestParameterAttribute("adClientId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AdClientId { get; private set; }

                /// <summary>Whether to include inactive ad units. Default: true.</summary>
                [Google.Apis.Util.RequestParameterAttribute("includeInactive", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeInactive { get; set; }

                /// <summary>The maximum number of ad units to include in the response, used for paging.</summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults { get; set; }

                /// <summary>
                /// A continuation token, used to page through ad units. To retrieve the next page, set this parameter
                /// to the value of "nextPageToken" from the previous response.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/{accountId}/adclients/{adClientId}/adunits";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("adClientId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "adClientId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("includeInactive", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeInactive",
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
            /// Update the supplied ad unit in the specified publisher AdSense account. This method supports patch
            /// semantics.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account which contains the ad client.</param>
            /// <param name="adClientId">Ad client which contains the ad unit.</param>
            /// <param name="adUnitId">Ad unit to get.</param>
            public virtual PatchRequest Patch(Google.Apis.AdSenseHost.v4_1.Data.AdUnit body, string accountId, string adClientId, string adUnitId)
            {
                return new PatchRequest(this.service, body, accountId, adClientId, adUnitId);
            }

            /// <summary>
            /// Update the supplied ad unit in the specified publisher AdSense account. This method supports patch
            /// semantics.
            /// </summary>
            public class PatchRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.AdUnit>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AdSenseHost.v4_1.Data.AdUnit body, string accountId, string adClientId, string adUnitId) : base(service)
                {
                    AccountId = accountId;
                    AdClientId = adClientId;
                    AdUnitId = adUnitId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account which contains the ad client.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Ad client which contains the ad unit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("adClientId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AdClientId { get; private set; }

                /// <summary>Ad unit to get.</summary>
                [Google.Apis.Util.RequestParameterAttribute("adUnitId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string AdUnitId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdSenseHost.v4_1.Data.AdUnit Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/{accountId}/adclients/{adClientId}/adunits";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("adClientId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "adClientId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("adUnitId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "adUnitId",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Update the supplied ad unit in the specified publisher AdSense account.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="accountId">Account which contains the ad client.</param>
            /// <param name="adClientId">Ad client which contains the ad unit.</param>
            public virtual UpdateRequest Update(Google.Apis.AdSenseHost.v4_1.Data.AdUnit body, string accountId, string adClientId)
            {
                return new UpdateRequest(this.service, body, accountId, adClientId);
            }

            /// <summary>Update the supplied ad unit in the specified publisher AdSense account.</summary>
            public class UpdateRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.AdUnit>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdSenseHost.v4_1.Data.AdUnit body, string accountId, string adClientId) : base(service)
                {
                    AccountId = accountId;
                    AdClientId = adClientId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Account which contains the ad client.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Ad client which contains the ad unit.</summary>
                [Google.Apis.Util.RequestParameterAttribute("adClientId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AdClientId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AdSenseHost.v4_1.Data.AdUnit Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/{accountId}/adclients/{adClientId}/adunits";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("adClientId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "adClientId",
                        IsRequired = true,
                        ParameterType = "path",
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
            }

            /// <summary>
            /// Generate an AdSense report based on the report request sent in the query parameters. Returns the result
            /// as JSON; to retrieve output in CSV format specify "alt=csv" as a query parameter.
            /// </summary>
            /// <param name="accountId">Hosted account upon which to report.</param>
            /// <param name="startDate">Start of the date range to report on in "YYYY-MM-DD" format, inclusive.</param>
            /// <param name="endDate">End of the date range to report on in "YYYY-MM-DD" format, inclusive.</param>
            public virtual GenerateRequest Generate(string accountId, string startDate, string endDate)
            {
                return new GenerateRequest(this.service, accountId, startDate, endDate);
            }

            /// <summary>
            /// Generate an AdSense report based on the report request sent in the query parameters. Returns the result
            /// as JSON; to retrieve output in CSV format specify "alt=csv" as a query parameter.
            /// </summary>
            public class GenerateRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.Report>
            {
                /// <summary>Constructs a new Generate request.</summary>
                public GenerateRequest(Google.Apis.Services.IClientService service, string accountId, string startDate, string endDate) : base(service)
                {
                    AccountId = accountId;
                    StartDate = startDate;
                    EndDate = endDate;
                    InitParameters();
                }

                /// <summary>Hosted account upon which to report.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccountId { get; private set; }

                /// <summary>Start of the date range to report on in "YYYY-MM-DD" format, inclusive.</summary>
                [Google.Apis.Util.RequestParameterAttribute("startDate", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string StartDate { get; private set; }

                /// <summary>End of the date range to report on in "YYYY-MM-DD" format, inclusive.</summary>
                [Google.Apis.Util.RequestParameterAttribute("endDate", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string EndDate { get; private set; }

                /// <summary>Dimensions to base the report on.</summary>
                [Google.Apis.Util.RequestParameterAttribute("dimension", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> Dimension { get; set; }

                /// <summary>Filters to be run on the report.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> Filter { get; set; }

                /// <summary>
                /// Optional locale to use for translating report output to a local language. Defaults to "en_US" if not
                /// specified.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Locale { get; set; }

                /// <summary>The maximum number of rows of report data to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults { get; set; }

                /// <summary>Numeric columns to include in the report.</summary>
                [Google.Apis.Util.RequestParameterAttribute("metric", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> Metric { get; set; }

                /// <summary>
                /// The name of a dimension or metric to sort the resulting report on, optionally prefixed with "+" to
                /// sort ascending or "-" to sort descending. If no prefix is specified, the column is sorted ascending.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("sort", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> Sort { get; set; }

                /// <summary>Index of the first row of report data to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> StartIndex { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "generate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "accounts/{accountId}/reports";

                /// <summary>Initializes Generate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accountId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("startDate", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startDate",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"\d{4}-\d{2}-\d{2}|(today|startOfMonth|startOfYear)(([\-\+]\d+[dwmy]){0,3}?)",
                    });
                    RequestParameters.Add("endDate", new Google.Apis.Discovery.Parameter
                    {
                        Name = "endDate",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"\d{4}-\d{2}-\d{2}|(today|startOfMonth|startOfYear)(([\-\+]\d+[dwmy]){0,3}?)",
                    });
                    RequestParameters.Add("dimension", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dimension",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"[a-zA-Z_]+",
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"[a-zA-Z_]+(==|=@).+",
                    });
                    RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locale",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"[a-zA-Z_]+",
                    });
                    RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("metric", new Google.Apis.Discovery.Parameter
                    {
                        Name = "metric",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"[a-zA-Z_]+",
                    });
                    RequestParameters.Add("sort", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sort",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"(\+|-)?[a-zA-Z_]+",
                    });
                    RequestParameters.Add("startIndex", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startIndex",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Get information about the selected associated AdSense account.</summary>
        /// <param name="accountId">Account to get information about.</param>
        public virtual GetRequest Get(string accountId)
        {
            return new GetRequest(this.service, accountId);
        }

        /// <summary>Get information about the selected associated AdSense account.</summary>
        public class GetRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.Account>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string accountId) : base(service)
            {
                AccountId = accountId;
                InitParameters();
            }

            /// <summary>Account to get information about.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AccountId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/{accountId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>List hosted accounts associated with this AdSense account by ad client id.</summary>
        /// <param name="filterAdClientId">Ad clients to list accounts for.</param>
        public virtual ListRequest List(Google.Apis.Util.Repeatable<string> filterAdClientId)
        {
            return new ListRequest(this.service, filterAdClientId);
        }

        /// <summary>List hosted accounts associated with this AdSense account by ad client id.</summary>
        public class ListRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.Accounts>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, Google.Apis.Util.Repeatable<string> filterAdClientId) : base(service)
            {
                FilterAdClientId = filterAdClientId;
                InitParameters();
            }

            /// <summary>Ad clients to list accounts for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("filterAdClientId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> FilterAdClientId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("filterAdClientId", new Google.Apis.Discovery.Parameter
                {
                    Name = "filterAdClientId",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "adclients" collection of methods.</summary>
    public class AdclientsResource
    {
        private const string Resource = "adclients";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AdclientsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Get information about one of the ad clients in the Host AdSense account.</summary>
        /// <param name="adClientId">Ad client to get.</param>
        public virtual GetRequest Get(string adClientId)
        {
            return new GetRequest(this.service, adClientId);
        }

        /// <summary>Get information about one of the ad clients in the Host AdSense account.</summary>
        public class GetRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.AdClient>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string adClientId) : base(service)
            {
                AdClientId = adClientId;
                InitParameters();
            }

            /// <summary>Ad client to get.</summary>
            [Google.Apis.Util.RequestParameterAttribute("adClientId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AdClientId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "adclients/{adClientId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("adClientId", new Google.Apis.Discovery.Parameter
                {
                    Name = "adClientId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>List all host ad clients in this AdSense account.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>List all host ad clients in this AdSense account.</summary>
        public class ListRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.AdClients>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>The maximum number of ad clients to include in the response, used for paging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// A continuation token, used to page through ad clients. To retrieve the next page, set this parameter to
            /// the value of "nextPageToken" from the previous response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "adclients";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
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

    /// <summary>The "associationsessions" collection of methods.</summary>
    public class AssociationsessionsResource
    {
        private const string Resource = "associationsessions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AssociationsessionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Create an association session for initiating an association with an AdSense user.</summary>
        /// <param name="productCode">Products to associate with the user.</param>
        /// <param name="websiteUrl">The URL of the user's hosted website.</param>
        public virtual StartRequest Start(StartRequest.ProductCodeEnum productCode, string websiteUrl)
        {
            return new StartRequest(this.service, productCode, websiteUrl);
        }

        /// <summary>Create an association session for initiating an association with an AdSense user.</summary>
        public class StartRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.AssociationSession>
        {
            /// <summary>Constructs a new Start request.</summary>
            public StartRequest(Google.Apis.Services.IClientService service, ProductCodeEnum productCode, string websiteUrl) : base(service)
            {
                ProductCode = productCode;
                WebsiteUrl = websiteUrl;
                InitParameters();
            }

            /// <summary>Products to associate with the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("productCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual ProductCodeEnum ProductCode { get; private set; }

            /// <summary>Products to associate with the user.</summary>
            public enum ProductCodeEnum
            {
                /// <summary>AdSense For Content</summary>
                [Google.Apis.Util.StringValueAttribute("AFC")]
                AFC = 0,

                /// <summary>AdSense For Games</summary>
                [Google.Apis.Util.StringValueAttribute("AFG")]
                AFG = 1,

                /// <summary>AdSense For Mobile Content - deprecated</summary>
                [Google.Apis.Util.StringValueAttribute("AFMC")]
                AFMC = 2,

                /// <summary>AdSense For Search - deprecated</summary>
                [Google.Apis.Util.StringValueAttribute("AFS")]
                AFS = 3,

                /// <summary>AdSense For Video</summary>
                [Google.Apis.Util.StringValueAttribute("AFV")]
                AFV = 4,
            }

            /// <summary>The URL of the user's hosted website.</summary>
            [Google.Apis.Util.RequestParameterAttribute("websiteUrl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string WebsiteUrl { get; private set; }

            /// <summary>
            /// The URL to redirect the user to once association is completed. It receives a token parameter that can
            /// then be used to retrieve the associated account.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("callbackUrl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CallbackUrl { get; set; }

            /// <summary>The preferred locale of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userLocale", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserLocale { get; set; }

            /// <summary>The locale of the user's hosted website.</summary>
            [Google.Apis.Util.RequestParameterAttribute("websiteLocale", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string WebsiteLocale { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "start";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "associationsessions/start";

            /// <summary>Initializes Start parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("productCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "productCode",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("websiteUrl", new Google.Apis.Discovery.Parameter
                {
                    Name = "websiteUrl",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("callbackUrl", new Google.Apis.Discovery.Parameter
                {
                    Name = "callbackUrl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userLocale", new Google.Apis.Discovery.Parameter
                {
                    Name = "userLocale",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("websiteLocale", new Google.Apis.Discovery.Parameter
                {
                    Name = "websiteLocale",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Verify an association session after the association callback returns from AdSense signup.</summary>
        /// <param name="token">The token returned to the association callback URL.</param>
        public virtual VerifyRequest Verify(string token)
        {
            return new VerifyRequest(this.service, token);
        }

        /// <summary>Verify an association session after the association callback returns from AdSense signup.</summary>
        public class VerifyRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.AssociationSession>
        {
            /// <summary>Constructs a new Verify request.</summary>
            public VerifyRequest(Google.Apis.Services.IClientService service, string token) : base(service)
            {
                Token = token;
                InitParameters();
            }

            /// <summary>The token returned to the association callback URL.</summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Token { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "verify";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "associationsessions/verify";

            /// <summary>Initializes Verify parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("token", new Google.Apis.Discovery.Parameter
                {
                    Name = "token",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "customchannels" collection of methods.</summary>
    public class CustomchannelsResource
    {
        private const string Resource = "customchannels";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CustomchannelsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Delete a specific custom channel from the host AdSense account.</summary>
        /// <param name="adClientId">Ad client from which to delete the custom channel.</param>
        /// <param name="customChannelId">Custom channel to delete.</param>
        public virtual DeleteRequest Delete(string adClientId, string customChannelId)
        {
            return new DeleteRequest(this.service, adClientId, customChannelId);
        }

        /// <summary>Delete a specific custom channel from the host AdSense account.</summary>
        public class DeleteRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.CustomChannel>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string adClientId, string customChannelId) : base(service)
            {
                AdClientId = adClientId;
                CustomChannelId = customChannelId;
                InitParameters();
            }

            /// <summary>Ad client from which to delete the custom channel.</summary>
            [Google.Apis.Util.RequestParameterAttribute("adClientId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AdClientId { get; private set; }

            /// <summary>Custom channel to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customChannelId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomChannelId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "adclients/{adClientId}/customchannels/{customChannelId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("adClientId", new Google.Apis.Discovery.Parameter
                {
                    Name = "adClientId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("customChannelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customChannelId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Get a specific custom channel from the host AdSense account.</summary>
        /// <param name="adClientId">Ad client from which to get the custom channel.</param>
        /// <param name="customChannelId">Custom channel to get.</param>
        public virtual GetRequest Get(string adClientId, string customChannelId)
        {
            return new GetRequest(this.service, adClientId, customChannelId);
        }

        /// <summary>Get a specific custom channel from the host AdSense account.</summary>
        public class GetRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.CustomChannel>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string adClientId, string customChannelId) : base(service)
            {
                AdClientId = adClientId;
                CustomChannelId = customChannelId;
                InitParameters();
            }

            /// <summary>Ad client from which to get the custom channel.</summary>
            [Google.Apis.Util.RequestParameterAttribute("adClientId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AdClientId { get; private set; }

            /// <summary>Custom channel to get.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customChannelId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomChannelId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "adclients/{adClientId}/customchannels/{customChannelId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("adClientId", new Google.Apis.Discovery.Parameter
                {
                    Name = "adClientId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("customChannelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customChannelId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Add a new custom channel to the host AdSense account.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="adClientId">Ad client to which the new custom channel will be added.</param>
        public virtual InsertRequest Insert(Google.Apis.AdSenseHost.v4_1.Data.CustomChannel body, string adClientId)
        {
            return new InsertRequest(this.service, body, adClientId);
        }

        /// <summary>Add a new custom channel to the host AdSense account.</summary>
        public class InsertRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.CustomChannel>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AdSenseHost.v4_1.Data.CustomChannel body, string adClientId) : base(service)
            {
                AdClientId = adClientId;
                Body = body;
                InitParameters();
            }

            /// <summary>Ad client to which the new custom channel will be added.</summary>
            [Google.Apis.Util.RequestParameterAttribute("adClientId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AdClientId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdSenseHost.v4_1.Data.CustomChannel Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "adclients/{adClientId}/customchannels";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("adClientId", new Google.Apis.Discovery.Parameter
                {
                    Name = "adClientId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>List all host custom channels in this AdSense account.</summary>
        /// <param name="adClientId">Ad client for which to list custom channels.</param>
        public virtual ListRequest List(string adClientId)
        {
            return new ListRequest(this.service, adClientId);
        }

        /// <summary>List all host custom channels in this AdSense account.</summary>
        public class ListRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.CustomChannels>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string adClientId) : base(service)
            {
                AdClientId = adClientId;
                InitParameters();
            }

            /// <summary>Ad client for which to list custom channels.</summary>
            [Google.Apis.Util.RequestParameterAttribute("adClientId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AdClientId { get; private set; }

            /// <summary>The maximum number of custom channels to include in the response, used for paging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// A continuation token, used to page through custom channels. To retrieve the next page, set this
            /// parameter to the value of "nextPageToken" from the previous response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "adclients/{adClientId}/customchannels";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("adClientId", new Google.Apis.Discovery.Parameter
                {
                    Name = "adClientId",
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
        /// Update a custom channel in the host AdSense account. This method supports patch semantics.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="adClientId">Ad client in which the custom channel will be updated.</param>
        /// <param name="customChannelId">Custom channel to get.</param>
        public virtual PatchRequest Patch(Google.Apis.AdSenseHost.v4_1.Data.CustomChannel body, string adClientId, string customChannelId)
        {
            return new PatchRequest(this.service, body, adClientId, customChannelId);
        }

        /// <summary>
        /// Update a custom channel in the host AdSense account. This method supports patch semantics.
        /// </summary>
        public class PatchRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.CustomChannel>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AdSenseHost.v4_1.Data.CustomChannel body, string adClientId, string customChannelId) : base(service)
            {
                AdClientId = adClientId;
                CustomChannelId = customChannelId;
                Body = body;
                InitParameters();
            }

            /// <summary>Ad client in which the custom channel will be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("adClientId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AdClientId { get; private set; }

            /// <summary>Custom channel to get.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customChannelId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomChannelId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdSenseHost.v4_1.Data.CustomChannel Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "adclients/{adClientId}/customchannels";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("adClientId", new Google.Apis.Discovery.Parameter
                {
                    Name = "adClientId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("customChannelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customChannelId",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Update a custom channel in the host AdSense account.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="adClientId">Ad client in which the custom channel will be updated.</param>
        public virtual UpdateRequest Update(Google.Apis.AdSenseHost.v4_1.Data.CustomChannel body, string adClientId)
        {
            return new UpdateRequest(this.service, body, adClientId);
        }

        /// <summary>Update a custom channel in the host AdSense account.</summary>
        public class UpdateRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.CustomChannel>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdSenseHost.v4_1.Data.CustomChannel body, string adClientId) : base(service)
            {
                AdClientId = adClientId;
                Body = body;
                InitParameters();
            }

            /// <summary>Ad client in which the custom channel will be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("adClientId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AdClientId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdSenseHost.v4_1.Data.CustomChannel Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "adclients/{adClientId}/customchannels";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("adClientId", new Google.Apis.Discovery.Parameter
                {
                    Name = "adClientId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

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
        }

        /// <summary>
        /// Generate an AdSense report based on the report request sent in the query parameters. Returns the result as
        /// JSON; to retrieve output in CSV format specify "alt=csv" as a query parameter.
        /// </summary>
        /// <param name="startDate">Start of the date range to report on in "YYYY-MM-DD" format, inclusive.</param>
        /// <param name="endDate">End of the date range to report on in "YYYY-MM-DD" format, inclusive.</param>
        public virtual GenerateRequest Generate(string startDate, string endDate)
        {
            return new GenerateRequest(this.service, startDate, endDate);
        }

        /// <summary>
        /// Generate an AdSense report based on the report request sent in the query parameters. Returns the result as
        /// JSON; to retrieve output in CSV format specify "alt=csv" as a query parameter.
        /// </summary>
        public class GenerateRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.Report>
        {
            /// <summary>Constructs a new Generate request.</summary>
            public GenerateRequest(Google.Apis.Services.IClientService service, string startDate, string endDate) : base(service)
            {
                StartDate = startDate;
                EndDate = endDate;
                InitParameters();
            }

            /// <summary>Start of the date range to report on in "YYYY-MM-DD" format, inclusive.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StartDate { get; private set; }

            /// <summary>End of the date range to report on in "YYYY-MM-DD" format, inclusive.</summary>
            [Google.Apis.Util.RequestParameterAttribute("endDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EndDate { get; private set; }

            /// <summary>Dimensions to base the report on.</summary>
            [Google.Apis.Util.RequestParameterAttribute("dimension", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Dimension { get; set; }

            /// <summary>Filters to be run on the report.</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Filter { get; set; }

            /// <summary>
            /// Optional locale to use for translating report output to a local language. Defaults to "en_US" if not
            /// specified.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Locale { get; set; }

            /// <summary>The maximum number of rows of report data to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>Numeric columns to include in the report.</summary>
            [Google.Apis.Util.RequestParameterAttribute("metric", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Metric { get; set; }

            /// <summary>
            /// The name of a dimension or metric to sort the resulting report on, optionally prefixed with "+" to sort
            /// ascending or "-" to sort descending. If no prefix is specified, the column is sorted ascending.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sort", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Sort { get; set; }

            /// <summary>Index of the first row of report data to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> StartIndex { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "generate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "reports";

            /// <summary>Initializes Generate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("startDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDate",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"\d{4}-\d{2}-\d{2}|(today|startOfMonth|startOfYear)(([\-\+]\d+[dwmy]){0,3}?)",
                });
                RequestParameters.Add("endDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDate",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"\d{4}-\d{2}-\d{2}|(today|startOfMonth|startOfYear)(([\-\+]\d+[dwmy]){0,3}?)",
                });
                RequestParameters.Add("dimension", new Google.Apis.Discovery.Parameter
                {
                    Name = "dimension",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"[a-zA-Z_]+",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"[a-zA-Z_]+(==|=@).+",
                });
                RequestParameters.Add("locale", new Google.Apis.Discovery.Parameter
                {
                    Name = "locale",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"[a-zA-Z_]+",
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("metric", new Google.Apis.Discovery.Parameter
                {
                    Name = "metric",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"[a-zA-Z_]+",
                });
                RequestParameters.Add("sort", new Google.Apis.Discovery.Parameter
                {
                    Name = "sort",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"(\+|-)?[a-zA-Z_]+",
                });
                RequestParameters.Add("startIndex", new Google.Apis.Discovery.Parameter
                {
                    Name = "startIndex",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "urlchannels" collection of methods.</summary>
    public class UrlchannelsResource
    {
        private const string Resource = "urlchannels";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UrlchannelsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Delete a URL channel from the host AdSense account.</summary>
        /// <param name="adClientId">Ad client from which to delete the URL channel.</param>
        /// <param name="urlChannelId">URL channel to delete.</param>
        public virtual DeleteRequest Delete(string adClientId, string urlChannelId)
        {
            return new DeleteRequest(this.service, adClientId, urlChannelId);
        }

        /// <summary>Delete a URL channel from the host AdSense account.</summary>
        public class DeleteRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.UrlChannel>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string adClientId, string urlChannelId) : base(service)
            {
                AdClientId = adClientId;
                UrlChannelId = urlChannelId;
                InitParameters();
            }

            /// <summary>Ad client from which to delete the URL channel.</summary>
            [Google.Apis.Util.RequestParameterAttribute("adClientId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AdClientId { get; private set; }

            /// <summary>URL channel to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("urlChannelId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UrlChannelId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "adclients/{adClientId}/urlchannels/{urlChannelId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("adClientId", new Google.Apis.Discovery.Parameter
                {
                    Name = "adClientId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("urlChannelId", new Google.Apis.Discovery.Parameter
                {
                    Name = "urlChannelId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Add a new URL channel to the host AdSense account.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="adClientId">Ad client to which the new URL channel will be added.</param>
        public virtual InsertRequest Insert(Google.Apis.AdSenseHost.v4_1.Data.UrlChannel body, string adClientId)
        {
            return new InsertRequest(this.service, body, adClientId);
        }

        /// <summary>Add a new URL channel to the host AdSense account.</summary>
        public class InsertRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.UrlChannel>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AdSenseHost.v4_1.Data.UrlChannel body, string adClientId) : base(service)
            {
                AdClientId = adClientId;
                Body = body;
                InitParameters();
            }

            /// <summary>Ad client to which the new URL channel will be added.</summary>
            [Google.Apis.Util.RequestParameterAttribute("adClientId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AdClientId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdSenseHost.v4_1.Data.UrlChannel Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "adclients/{adClientId}/urlchannels";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("adClientId", new Google.Apis.Discovery.Parameter
                {
                    Name = "adClientId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>List all host URL channels in the host AdSense account.</summary>
        /// <param name="adClientId">Ad client for which to list URL channels.</param>
        public virtual ListRequest List(string adClientId)
        {
            return new ListRequest(this.service, adClientId);
        }

        /// <summary>List all host URL channels in the host AdSense account.</summary>
        public class ListRequest : AdSenseHostBaseServiceRequest<Google.Apis.AdSenseHost.v4_1.Data.UrlChannels>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string adClientId) : base(service)
            {
                AdClientId = adClientId;
                InitParameters();
            }

            /// <summary>Ad client for which to list URL channels.</summary>
            [Google.Apis.Util.RequestParameterAttribute("adClientId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AdClientId { get; private set; }

            /// <summary>The maximum number of URL channels to include in the response, used for paging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// A continuation token, used to page through URL channels. To retrieve the next page, set this parameter
            /// to the value of "nextPageToken" from the previous response.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "adclients/{adClientId}/urlchannels";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("adClientId", new Google.Apis.Discovery.Parameter
                {
                    Name = "adClientId",
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
namespace Google.Apis.AdSenseHost.v4_1.Data
{
    public class Account : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique identifier of this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Kind of resource this is, in this case adsensehost#account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Name of this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Approval status of this account. One of: PENDING, APPROVED, DISABLED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Accounts : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of this response for caching purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The accounts returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Account> Items { get; set; }

        /// <summary>Kind of list this is, in this case adsensehost#accounts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }
    }

    public class AdClient : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether this ad client is opted in to ARC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("arcOptIn")]
        public virtual System.Nullable<bool> ArcOptIn { get; set; }

        /// <summary>Unique identifier of this ad client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Kind of resource this is, in this case adsensehost#adClient.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>This ad client's product code, which corresponds to the PRODUCT_CODE report dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCode")]
        public virtual string ProductCode { get; set; }

        /// <summary>Whether this ad client supports being reported on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsReporting")]
        public virtual System.Nullable<bool> SupportsReporting { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AdClients : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of this response for caching purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ad clients returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<AdClient> Items { get; set; }

        /// <summary>Kind of list this is, in this case adsensehost#adClients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Continuation token used to page through ad clients. To retrieve the next page of results, set the next
        /// request's "pageToken" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }
    }

    public class AdCode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ad code snippet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adCode")]
        public virtual string AdCodeValue { get; set; }

        /// <summary>Kind this is, in this case adsensehost#adCode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AdStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The colors included in the style. These are represented as six hexadecimal characters, similar to HTML color
        /// codes, but without the leading hash.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colors")]
        public virtual ColorsData Colors { get; set; }

        /// <summary>The style of the corners in the ad (deprecated: never populated, ignored).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("corners")]
        public virtual string Corners { get; set; }

        /// <summary>The font which is included in the style.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("font")]
        public virtual FontData Font { get; set; }

        /// <summary>Kind this is, in this case adsensehost#adStyle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// The colors included in the style. These are represented as six hexadecimal characters, similar to HTML color
        /// codes, but without the leading hash.
        /// </summary>
        public class ColorsData
        {
            /// <summary>The color of the ad background.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("background")]
            public virtual string Background { get; set; }

            /// <summary>The color of the ad border.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("border")]
            public virtual string Border { get; set; }

            /// <summary>The color of the ad text.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("text")]
            public virtual string Text { get; set; }

            /// <summary>The color of the ad title.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("title")]
            public virtual string Title { get; set; }

            /// <summary>The color of the ad url.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; }
        }

        /// <summary>The font which is included in the style.</summary>
        public class FontData
        {
            /// <summary>
            /// The family of the font. Possible values are: ACCOUNT_DEFAULT_FAMILY, ADSENSE_DEFAULT_FAMILY, ARIAL,
            /// TIMES and VERDANA.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("family")]
            public virtual string Family { get; set; }

            /// <summary>
            /// The size of the font. Possible values are: ACCOUNT_DEFAULT_SIZE, ADSENSE_DEFAULT_SIZE, SMALL, MEDIUM and
            /// LARGE.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("size")]
            public virtual string Size { get; set; }
        }
    }

    public class AdUnit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identity code of this ad unit, not necessarily unique across ad clients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>
        /// Settings specific to content ads (AFC) and highend mobile content ads (AFMC - deprecated).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentAdsSettings")]
        public virtual ContentAdsSettingsData ContentAdsSettings { get; set; }

        /// <summary>Custom style information specific to this ad unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customStyle")]
        public virtual AdStyle CustomStyle { get; set; }

        /// <summary>
        /// Unique identifier of this ad unit. This should be considered an opaque identifier; it is not safe to rely on
        /// it being in any particular format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Kind of resource this is, in this case adsensehost#adUnit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Settings specific to WAP mobile content ads (AFMC - deprecated).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileContentAdsSettings")]
        public virtual MobileContentAdsSettingsData MobileContentAdsSettings { get; set; }

        /// <summary>Name of this ad unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Status of this ad unit. Possible values are: NEW: Indicates that the ad unit was created within the last
        /// seven days and does not yet have any activity associated with it.  ACTIVE: Indicates that there has been
        /// activity on this ad unit in the last seven days.  INACTIVE: Indicates that there has been no activity on
        /// this ad unit in the last seven days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// Settings specific to content ads (AFC) and highend mobile content ads (AFMC - deprecated).
        /// </summary>
        public class ContentAdsSettingsData
        {
            /// <summary>The backup option to be used in instances where no ad is available.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("backupOption")]
            public virtual BackupOptionData BackupOption { get; set; }

            /// <summary>Size of this ad unit. Size values are in the form SIZE_{width}_{height}.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("size")]
            public virtual string Size { get; set; }

            /// <summary>Type of this ad unit. Possible values are TEXT, TEXT_IMAGE, IMAGE and LINK.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }

            /// <summary>The backup option to be used in instances where no ad is available.</summary>
            public class BackupOptionData
            {
                /// <summary>
                /// Color to use when type is set to COLOR. These are represented as six hexadecimal characters, similar
                /// to HTML color codes, but without the leading hash.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("color")]
                public virtual string Color { get; set; }

                /// <summary>Type of the backup option. Possible values are BLANK, COLOR and URL.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("type")]
                public virtual string Type { get; set; }

                /// <summary>URL to use when type is set to URL.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                public virtual string Url { get; set; }
            }
        }

        /// <summary>Settings specific to WAP mobile content ads (AFMC - deprecated).</summary>
        public class MobileContentAdsSettingsData
        {
            /// <summary>The markup language to use for this ad unit.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("markupLanguage")]
            public virtual string MarkupLanguage { get; set; }

            /// <summary>The scripting language to use for this ad unit.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("scriptingLanguage")]
            public virtual string ScriptingLanguage { get; set; }

            /// <summary>Size of this ad unit.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("size")]
            public virtual string Size { get; set; }

            /// <summary>Type of this ad unit.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }
    }

    public class AdUnits : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of this response for caching purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ad units returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<AdUnit> Items { get; set; }

        /// <summary>Kind of list this is, in this case adsensehost#adUnits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Continuation token used to page through ad units. To retrieve the next page of results, set the next
        /// request's "pageToken" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }
    }

    public class AssociationSession : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hosted account id of the associated publisher after association. Present if status is ACCEPTED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; }

        /// <summary>Unique identifier of this association session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Kind of resource this is, in this case adsensehost#associationSession.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The products to associate with the user. Options: AFC, AFG, AFV, AFS (deprecated), AFMC (deprecated)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCodes")]
        public virtual System.Collections.Generic.IList<string> ProductCodes { get; set; }

        /// <summary>
        /// Redirect URL of this association session. Used to redirect users into the AdSense association flow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redirectUrl")]
        public virtual string RedirectUrl { get; set; }

        /// <summary>
        /// Status of the completed association, available once the association callback token has been verified. One of
        /// ACCEPTED, REJECTED, or ERROR.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>
        /// The preferred locale of the user themselves when going through the AdSense association flow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLocale")]
        public virtual string UserLocale { get; set; }

        /// <summary>The locale of the user's hosted website.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("websiteLocale")]
        public virtual string WebsiteLocale { get; set; }

        /// <summary>The URL of the user's hosted website.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("websiteUrl")]
        public virtual string WebsiteUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CustomChannel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Code of this custom channel, not necessarily unique across ad clients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>
        /// Unique identifier of this custom channel. This should be considered an opaque identifier; it is not safe to
        /// rely on it being in any particular format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Kind of resource this is, in this case adsensehost#customChannel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Name of this custom channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CustomChannels : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of this response for caching purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The custom channels returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<CustomChannel> Items { get; set; }

        /// <summary>Kind of list this is, in this case adsensehost#customChannels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Continuation token used to page through custom channels. To retrieve the next page of results, set the next
        /// request's "pageToken" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }
    }

    public class Report : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The averages of the report. This is the same length as any other row in the report; cells corresponding to
        /// dimension columns are empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("averages")]
        public virtual System.Collections.Generic.IList<string> Averages { get; set; }

        /// <summary>
        /// The header information of the columns requested in the report. This is a list of headers; one for each
        /// dimension in the request, followed by one for each metric in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headers")]
        public virtual System.Collections.Generic.IList<HeadersData> Headers { get; set; }

        /// <summary>Kind this is, in this case adsensehost#report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The output rows of the report. Each row is a list of cells; one for each dimension in the request, followed
        /// by one for each metric in the request. The dimension cells contain strings, and the metric cells contain
        /// numbers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IList<string>> Rows { get; set; }

        /// <summary>
        /// The total number of rows matched by the report request. Fewer rows may be returned in the response due to
        /// being limited by the row count requested or the report row limit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalMatchedRows")]
        public virtual System.Nullable<long> TotalMatchedRows { get; set; }

        /// <summary>
        /// The totals of the report. This is the same length as any other row in the report; cells corresponding to
        /// dimension columns are empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totals")]
        public virtual System.Collections.Generic.IList<string> Totals { get; set; }

        /// <summary>Any warnings associated with generation of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<string> Warnings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// The header information of the columns requested in the report. This is a list of headers; one for each
        /// dimension in the request, followed by one for each metric in the request.
        /// </summary>
        public class HeadersData
        {
            /// <summary>The currency of this column. Only present if the header type is METRIC_CURRENCY.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("currency")]
            public virtual string Currency { get; set; }

            /// <summary>The name of the header.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }

            /// <summary>
            /// The type of the header; one of DIMENSION, METRIC_TALLY, METRIC_RATIO, or METRIC_CURRENCY.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }
        }
    }

    public class UrlChannel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Unique identifier of this URL channel. This should be considered an opaque identifier; it is not safe to
        /// rely on it being in any particular format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Kind of resource this is, in this case adsensehost#urlChannel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// URL Pattern of this URL channel. Does not include "http://" or "https://". Example: www.example.com/home
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlPattern")]
        public virtual string UrlPattern { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class UrlChannels : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of this response for caching purposes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The URL channels returned in this list response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<UrlChannel> Items { get; set; }

        /// <summary>Kind of list this is, in this case adsensehost#urlChannels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Continuation token used to page through URL channels. To retrieve the next page of results, set the next
        /// request's "pageToken" value to this.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }
    }
}
