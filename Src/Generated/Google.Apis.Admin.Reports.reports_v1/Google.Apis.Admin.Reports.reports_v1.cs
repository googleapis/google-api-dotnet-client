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

namespace Google.Apis.Admin.Reports.reports_v1
{
    /// <summary>The Reports Service.</summary>
    public class ReportsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "reports_v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ReportsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ReportsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Activities = new ActivitiesResource(this);
            Channels = new ChannelsResource(this);
            CustomerUsageReports = new CustomerUsageReportsResource(this);
            EntityUsageReports = new EntityUsageReportsResource(this);
            UserUsageReport = new UserUsageReportResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "admin";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://admin.googleapis.com/";
        #else
            "https://admin.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://admin.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Admin SDK API.</summary>
        public class Scope
        {
            /// <summary>View audit reports for your G Suite domain</summary>
            public static string AdminReportsAuditReadonly = "https://www.googleapis.com/auth/admin.reports.audit.readonly";

            /// <summary>View usage reports for your G Suite domain</summary>
            public static string AdminReportsUsageReadonly = "https://www.googleapis.com/auth/admin.reports.usage.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Admin SDK API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View audit reports for your G Suite domain</summary>
            public const string AdminReportsAuditReadonly = "https://www.googleapis.com/auth/admin.reports.audit.readonly";

            /// <summary>View usage reports for your G Suite domain</summary>
            public const string AdminReportsUsageReadonly = "https://www.googleapis.com/auth/admin.reports.usage.readonly";
        }

        /// <summary>Gets the Activities resource.</summary>
        public virtual ActivitiesResource Activities { get; }

        /// <summary>Gets the Channels resource.</summary>
        public virtual ChannelsResource Channels { get; }

        /// <summary>Gets the CustomerUsageReports resource.</summary>
        public virtual CustomerUsageReportsResource CustomerUsageReports { get; }

        /// <summary>Gets the EntityUsageReports resource.</summary>
        public virtual EntityUsageReportsResource EntityUsageReports { get; }

        /// <summary>Gets the UserUsageReport resource.</summary>
        public virtual UserUsageReportResource UserUsageReport { get; }
    }

    /// <summary>A base abstract class for Reports requests.</summary>
    public abstract class ReportsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ReportsBaseServiceRequest instance.</summary>
        protected ReportsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Reports parameter list.</summary>
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

    /// <summary>The "activities" collection of methods.</summary>
    public class ActivitiesResource
    {
        private const string Resource = "activities";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ActivitiesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Retrieves a list of activities for a specific customer's account and application such as the Admin console
        /// application or the Google Drive application. For more information, see the guides for administrator and
        /// Google Drive activity reports. For more information about the activity report's parameters, see the activity
        /// parameters reference guides.
        /// </summary>
        /// <param name="userKey">
        /// Represents the profile ID or the user email for which the data should be filtered. Can be `all` for all
        /// information, or `userKey` for a user's unique Google Workspace profile ID or their primary email address.
        /// Must not be a deleted user. For a deleted user, call `users.list` in Directory API with `showDeleted=true`,
        /// then use the returned `ID` as the `userKey`.
        /// </param>
        /// <param name="applicationName">Application name for which the events are to be retrieved.</param>
        public virtual ListRequest List(string userKey, ListRequest.ApplicationNameEnum applicationName)
        {
            return new ListRequest(service, userKey, applicationName);
        }

        /// <summary>
        /// Retrieves a list of activities for a specific customer's account and application such as the Admin console
        /// application or the Google Drive application. For more information, see the guides for administrator and
        /// Google Drive activity reports. For more information about the activity report's parameters, see the activity
        /// parameters reference guides.
        /// </summary>
        public class ListRequest : ReportsBaseServiceRequest<Google.Apis.Admin.Reports.reports_v1.Data.Activities>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string userKey, ApplicationNameEnum applicationName) : base(service)
            {
                UserKey = userKey;
                ApplicationName = applicationName;
                InitParameters();
            }

            /// <summary>
            /// Represents the profile ID or the user email for which the data should be filtered. Can be `all` for all
            /// information, or `userKey` for a user's unique Google Workspace profile ID or their primary email
            /// address. Must not be a deleted user. For a deleted user, call `users.list` in Directory API with
            /// `showDeleted=true`, then use the returned `ID` as the `userKey`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>Application name for which the events are to be retrieved.</summary>
            [Google.Apis.Util.RequestParameterAttribute("applicationName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ApplicationNameEnum ApplicationName { get; private set; }

            /// <summary>Application name for which the events are to be retrieved.</summary>
            public enum ApplicationNameEnum
            {
                /// <summary>
                /// The Google Workspace Access Transparency activity reports return information about different types
                /// of Access Transparency activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("access_transparency")]
                AccessTransparency = 1,

                /// <summary>
                /// The Admin console application's activity reports return account information about different types of
                /// administrator activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("admin")]
                Admin = 2,

                /// <summary>
                /// The Google Calendar application's activity reports return information about various Calendar
                /// activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("calendar")]
                Calendar = 3,

                /// <summary>The Chat activity reports return information about various Chat activity events.</summary>
                [Google.Apis.Util.StringValueAttribute("chat")]
                Chat = 4,

                /// <summary>
                /// The Google Drive application's activity reports return information about various Google Drive
                /// activity events. The Drive activity report is only available for Google Workspace Business and
                /// Enterprise customers.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("drive")]
                Drive = 5,

                /// <summary>
                /// The Google Cloud Platform application's activity reports return information about various GCP
                /// activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("gcp")]
                Gcp = 6,

                /// <summary>
                /// The Google+ application's activity reports return information about various Google+ activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("gplus")]
                Gplus = 7,

                /// <summary>
                /// The Google Groups application's activity reports return information about various Groups activity
                /// events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("groups")]
                Groups = 8,

                /// <summary>
                /// The Enterprise Groups activity reports return information about various Enterprise group activity
                /// events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("groups_enterprise")]
                GroupsEnterprise = 9,

                /// <summary>
                /// The Jamboard activity reports return information about various Jamboard activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("jamboard")]
                Jamboard = 10,

                /// <summary>
                /// The Login application's activity reports return account information about different types of Login
                /// activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("login")]
                Login = 11,

                /// <summary>
                /// The Meet Audit activity report return information about different types of Meet Audit activity
                /// events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("meet")]
                Meet = 12,

                /// <summary>
                /// The Mobile Audit activity report return information about different types of Mobile Audit activity
                /// events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("mobile")]
                Mobile = 13,

                /// <summary>
                /// The Rules activity report return information about different types of Rules activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("rules")]
                Rules = 14,

                /// <summary>
                /// The SAML activity report return information about different types of SAML activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("saml")]
                Saml = 15,

                /// <summary>
                /// The Token application's activity reports return account information about different types of Token
                /// activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("token")]
                Token = 16,

                /// <summary>
                /// The User Accounts application's activity reports return account information about different types of
                /// User Accounts activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("user_accounts")]
                UserAccounts = 17,

                /// <summary>
                /// The Context-aware access activity reports return information about users' access denied events due
                /// to Context-aware access rules.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("context_aware_access")]
                ContextAwareAccess = 18,

                /// <summary>
                /// The Chrome activity reports return information about unsafe events reported in the context of the
                /// WebProtect features of BeyondCorp.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("chrome")]
                Chrome = 19,

                /// <summary>
                /// The Data Studio activity reports return information about various types of Data Studio activity
                /// events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("data_studio")]
                DataStudio = 20,

                /// <summary>
                /// The Keep application's activity reports return information about various Google Keep activity
                /// events. The Keep activity report is only available for Google Workspace Business and Enterprise
                /// customers.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("keep")]
                Keep = 21,
            }

            /// <summary>
            /// The Internet Protocol (IP) Address of host where the event was performed. This is an additional way to
            /// filter a report's summary using the IP address of the user whose activity is being reported. This IP
            /// address may or may not reflect the user's physical location. For example, the IP address can be the
            /// user's proxy server's address or a virtual private network (VPN) address. This parameter supports both
            /// IPv4 and IPv6 address versions.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("actorIpAddress", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ActorIpAddress { get; set; }

            /// <summary>The unique ID of the customer to retrieve data for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerId { get; set; }

            /// <summary>
            /// Sets the end of the range of time shown in the report. The date is in the RFC 3339 format, for example
            /// 2010-10-28T10:26:35.000Z. The default value is the approximate time of the API request. An API report
            /// has three basic time concepts: - *Date of the API's request for a report*: When the API created and
            /// retrieved the report. - *Report's start time*: The beginning of the timespan shown in the report. The
            /// `startTime` must be before the `endTime` (if specified) and the current time when the request is made,
            /// or the API returns an error. - *Report's end time*: The end of the timespan shown in the report. For
            /// example, the timespan of events summarized in a report can start in April and end in May. The report
            /// itself can be requested in August. If the `endTime` is not specified, the report returns all activities
            /// from the `startTime` until the current time or the most recent 180 days if the `startTime` is more than
            /// 180 days in the past.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("endTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EndTime { get; set; }

            /// <summary>
            /// The name of the event being queried by the API. Each `eventName` is related to a specific Google
            /// Workspace service or feature which the API organizes into types of events. An example is the Google
            /// Calendar events in the Admin console application's reports. The Calendar Settings `type` structure has
            /// all of the Calendar `eventName` activities reported by the API. When an administrator changes a Calendar
            /// setting, the API reports this activity in the Calendar Settings `type` and `eventName` parameters. For
            /// more information about `eventName` query strings and parameters, see the list of event names for various
            /// applications above in `applicationName`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("eventName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EventName { get; set; }

            /// <summary>
            /// The `filters` query string is a comma-separated list. The list is composed of event parameters that are
            /// manipulated by relational operators. Event parameters are in the form `parameter1 name[parameter1
            /// value],parameter2 name[parameter2 value],...` These event parameters are associated with a specific
            /// `eventName`. An empty report is returned if the filtered request's parameter does not belong to the
            /// `eventName`. For more information about `eventName` parameters, see the list of event names for various
            /// applications above in `applicationName`. In the following Admin Activity example, the &amp;lt;&amp;gt;
            /// operator is URL-encoded in the request's query string (%3C%3E):
            /// GET...&amp;amp;eventName=CHANGE_CALENDAR_SETTING &amp;amp;filters=NEW_VALUE%3C%3EREAD_ONLY_ACCESS In the
            /// following Drive example, the list can be a view or edit event's `doc_id` parameter with a value that is
            /// manipulated by an 'equal to' (==) or 'not equal to' (&amp;lt;&amp;gt;) relational operator. In the first
            /// example, the report returns each edited document's `doc_id`. In the second example, the report returns
            /// each viewed document's `doc_id` that equals the value 12345 and does not return any viewed document's
            /// which have a `doc_id` value of 98765. The &amp;lt;&amp;gt; operator is URL-encoded in the request's
            /// query string (%3C%3E): GET...&amp;amp;eventName=edit&amp;amp;filters=doc_id
            /// GET...&amp;amp;eventName=view&amp;amp;filters=doc_id==12345,doc_id%3C%3E98765 The relational operators
            /// include: - `==` - 'equal to'. - `&amp;lt;&amp;gt;` - 'not equal to'. It is URL-encoded (%3C%3E). -
            /// `&amp;lt;` - 'less than'. It is URL-encoded (%3C). - `&amp;lt;=` - 'less than or equal to'. It is
            /// URL-encoded (%3C=). - `&amp;gt;` - 'greater than'. It is URL-encoded (%3E). - `&amp;gt;=` - 'greater
            /// than or equal to'. It is URL-encoded (%3E=). *Note:* The API doesn't accept multiple values of a
            /// parameter. If a particular parameter is supplied more than once in the API request, the API only accepts
            /// the last value of that request parameter. In addition, if an invalid request parameter is supplied in
            /// the API request, the API ignores that request parameter and returns the response corresponding to the
            /// remaining valid request parameters. If no parameters are requested, all parameters are returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filters", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filters { get; set; }

            /// <summary>
            /// Comma separated group ids (obfuscated) on which user activities are filtered, i.e. the response will
            /// contain activities for only those users that are a part of at least one of the group ids mentioned here.
            /// Format: "id:abc123,id:xyz456"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupIdFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string GroupIdFilter { get; set; }

            /// <summary>
            /// Determines how many activity records are shown on each response page. For example, if the request sets
            /// `maxResults=1` and the report has two activities, the report has two pages. The response's
            /// `nextPageToken` property has the token to the second page. The `maxResults` query string is optional in
            /// the request. The default value is 1000.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// ID of the organizational unit to report on. Activity records will be shown only for users who belong to
            /// the specified organizational unit. Data before Dec 17, 2018 doesn't appear in the filtered results.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orgUnitID", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrgUnitID { get; set; }

            /// <summary>
            /// The token to specify next page. A report with multiple pages has a `nextPageToken` property in the
            /// response. In your follow-on request getting the next page of the report, enter the `nextPageToken` value
            /// in the `pageToken` query string.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Sets the beginning of the range of time shown in the report. The date is in the RFC 3339 format, for
            /// example 2010-10-28T10:26:35.000Z. The report returns all activities from `startTime` until `endTime`.
            /// The `startTime` must be before the `endTime` (if specified) and the current time when the request is
            /// made, or the API returns an error.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StartTime { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/reports/v1/activity/users/{userKey}/applications/{applicationName}";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("applicationName", new Google.Apis.Discovery.Parameter
                {
                    Name = "applicationName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(access_transparency)|(admin)|(calendar)|(chat)|(chrome)|(context_aware_access)|(data_studio)|(drive)|(gcp)|(gplus)|(groups)|(groups_enterprise)|(jamboard)|(keep)|(login)|(meet)|(mobile)|(rules)|(saml)|(token)|(user_accounts)",
                });
                RequestParameters.Add("actorIpAddress", new Google.Apis.Discovery.Parameter
                {
                    Name = "actorIpAddress",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"C.+|my_customer",
                });
                RequestParameters.Add("endTime", new Google.Apis.Discovery.Parameter
                {
                    Name = "endTime",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"(\d\d\d\d)-(\d\d)-(\d\d)T(\d\d):(\d\d):(\d\d)(?:\.(\d+))?(?:(Z)|([-+])(\d\d):(\d\d))",
                });
                RequestParameters.Add("eventName", new Google.Apis.Discovery.Parameter
                {
                    Name = "eventName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("filters", new Google.Apis.Discovery.Parameter
                {
                    Name = "filters",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"(.+[<,<=,==,>=,>,<>].+,)*(.+[<,<=,==,>=,>,<>].+)",
                });
                RequestParameters.Add("groupIdFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupIdFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"(id:[a-z0-9]+(,id:[a-z0-9]+)*)",
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "1000",
                    Pattern = null,
                });
                RequestParameters.Add("orgUnitID", new Google.Apis.Discovery.Parameter
                {
                    Name = "orgUnitID",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"(id:[a-z0-9]+)",
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
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
                    Pattern = @"(\d\d\d\d)-(\d\d)-(\d\d)T(\d\d):(\d\d):(\d\d)(?:\.(\d+))?(?:(Z)|([-+])(\d\d):(\d\d))",
                });
            }
        }

        /// <summary>
        /// Start receiving notifications for account activities. For more information, see Receiving Push
        /// Notifications.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="userKey">
        /// Represents the profile ID or the user email for which the data should be filtered. Can be `all` for all
        /// information, or `userKey` for a user's unique Google Workspace profile ID or their primary email address.
        /// Must not be a deleted user. For a deleted user, call `users.list` in Directory API with `showDeleted=true`,
        /// then use the returned `ID` as the `userKey`.
        /// </param>
        /// <param name="applicationName">Application name for which the events are to be retrieved.</param>
        public virtual WatchRequest Watch(Google.Apis.Admin.Reports.reports_v1.Data.Channel body, string userKey, WatchRequest.ApplicationNameEnum applicationName)
        {
            return new WatchRequest(service, body, userKey, applicationName);
        }

        /// <summary>
        /// Start receiving notifications for account activities. For more information, see Receiving Push
        /// Notifications.
        /// </summary>
        public class WatchRequest : ReportsBaseServiceRequest<Google.Apis.Admin.Reports.reports_v1.Data.Channel>
        {
            /// <summary>Constructs a new Watch request.</summary>
            public WatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Reports.reports_v1.Data.Channel body, string userKey, ApplicationNameEnum applicationName) : base(service)
            {
                UserKey = userKey;
                ApplicationName = applicationName;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Represents the profile ID or the user email for which the data should be filtered. Can be `all` for all
            /// information, or `userKey` for a user's unique Google Workspace profile ID or their primary email
            /// address. Must not be a deleted user. For a deleted user, call `users.list` in Directory API with
            /// `showDeleted=true`, then use the returned `ID` as the `userKey`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>Application name for which the events are to be retrieved.</summary>
            [Google.Apis.Util.RequestParameterAttribute("applicationName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual ApplicationNameEnum ApplicationName { get; private set; }

            /// <summary>Application name for which the events are to be retrieved.</summary>
            public enum ApplicationNameEnum
            {
                /// <summary>
                /// The Google Workspace Access Transparency activity reports return information about different types
                /// of Access Transparency activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("access_transparency")]
                AccessTransparency = 1,

                /// <summary>
                /// The Admin console application's activity reports return account information about different types of
                /// administrator activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("admin")]
                Admin = 2,

                /// <summary>
                /// The Google Calendar application's activity reports return information about various Calendar
                /// activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("calendar")]
                Calendar = 3,

                /// <summary>The Chat activity reports return information about various Chat activity events.</summary>
                [Google.Apis.Util.StringValueAttribute("chat")]
                Chat = 4,

                /// <summary>
                /// The Google Drive application's activity reports return information about various Google Drive
                /// activity events. The Drive activity report is only available for Google Workspace Business and
                /// Google Workspace Enterprise customers.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("drive")]
                Drive = 5,

                /// <summary>
                /// The Google Cloud Platform application's activity reports return information about various GCP
                /// activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("gcp")]
                Gcp = 6,

                /// <summary>
                /// The Google+ application's activity reports return information about various Google+ activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("gplus")]
                Gplus = 7,

                /// <summary>
                /// The Google Groups application's activity reports return information about various Groups activity
                /// events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("groups")]
                Groups = 8,

                /// <summary>
                /// The Enterprise Groups activity reports return information about various Enterprise group activity
                /// events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("groups_enterprise")]
                GroupsEnterprise = 9,

                /// <summary>
                /// The Jamboard activity reports return information about various Jamboard activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("jamboard")]
                Jamboard = 10,

                /// <summary>
                /// The Login application's activity reports return account information about different types of Login
                /// activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("login")]
                Login = 11,

                /// <summary>
                /// The Meet Audit activity report return information about different types of Meet Audit activity
                /// events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("meet")]
                Meet = 12,

                /// <summary>
                /// The Mobile Audit activity report return information about different types of Mobile Audit activity
                /// events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("mobile")]
                Mobile = 13,

                /// <summary>
                /// The Rules activity report return information about different types of Rules activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("rules")]
                Rules = 14,

                /// <summary>
                /// The SAML activity report return information about different types of SAML activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("saml")]
                Saml = 15,

                /// <summary>
                /// The Token application's activity reports return account information about different types of Token
                /// activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("token")]
                Token = 16,

                /// <summary>
                /// The User Accounts application's activity reports return account information about different types of
                /// User Accounts activity events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("user_accounts")]
                UserAccounts = 17,

                /// <summary>
                /// The Context-aware access activity reports return information about users' access denied events due
                /// to Context-aware access rules.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("context_aware_access")]
                ContextAwareAccess = 18,

                /// <summary>
                /// The Chrome activity reports return information about unsafe events reported in the context of the
                /// WebProtect features of BeyondCorp.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("chrome")]
                Chrome = 19,

                /// <summary>
                /// The Data Studio activity reports return information about various types of Data Studio activity
                /// events.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("data_studio")]
                DataStudio = 20,

                /// <summary>
                /// The Keep application's activity reports return information about various Google Keep activity
                /// events. The Keep activity report is only available for Google Workspace Business and Enterprise
                /// customers.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("keep")]
                Keep = 21,
            }

            /// <summary>
            /// The Internet Protocol (IP) Address of host where the event was performed. This is an additional way to
            /// filter a report's summary using the IP address of the user whose activity is being reported. This IP
            /// address may or may not reflect the user's physical location. For example, the IP address can be the
            /// user's proxy server's address or a virtual private network (VPN) address. This parameter supports both
            /// IPv4 and IPv6 address versions.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("actorIpAddress", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ActorIpAddress { get; set; }

            /// <summary>The unique ID of the customer to retrieve data for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerId { get; set; }

            /// <summary>
            /// Sets the end of the range of time shown in the report. The date is in the RFC 3339 format, for example
            /// 2010-10-28T10:26:35.000Z. The default value is the approximate time of the API request. An API report
            /// has three basic time concepts: - *Date of the API's request for a report*: When the API created and
            /// retrieved the report. - *Report's start time*: The beginning of the timespan shown in the report. The
            /// `startTime` must be before the `endTime` (if specified) and the current time when the request is made,
            /// or the API returns an error. - *Report's end time*: The end of the timespan shown in the report. For
            /// example, the timespan of events summarized in a report can start in April and end in May. The report
            /// itself can be requested in August. If the `endTime` is not specified, the report returns all activities
            /// from the `startTime` until the current time or the most recent 180 days if the `startTime` is more than
            /// 180 days in the past.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("endTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EndTime { get; set; }

            /// <summary>
            /// The name of the event being queried by the API. Each `eventName` is related to a specific Google
            /// Workspace service or feature which the API organizes into types of events. An example is the Google
            /// Calendar events in the Admin console application's reports. The Calendar Settings `type` structure has
            /// all of the Calendar `eventName` activities reported by the API. When an administrator changes a Calendar
            /// setting, the API reports this activity in the Calendar Settings `type` and `eventName` parameters. For
            /// more information about `eventName` query strings and parameters, see the list of event names for various
            /// applications above in `applicationName`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("eventName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EventName { get; set; }

            /// <summary>
            /// The `filters` query string is a comma-separated list. The list is composed of event parameters that are
            /// manipulated by relational operators. Event parameters are in the form `parameter1 name[parameter1
            /// value],parameter2 name[parameter2 value],...` These event parameters are associated with a specific
            /// `eventName`. An empty report is returned if the filtered request's parameter does not belong to the
            /// `eventName`. For more information about `eventName` parameters, see the list of event names for various
            /// applications above in `applicationName`. In the following Admin Activity example, the &amp;lt;&amp;gt;
            /// operator is URL-encoded in the request's query string (%3C%3E):
            /// GET...&amp;amp;eventName=CHANGE_CALENDAR_SETTING &amp;amp;filters=NEW_VALUE%3C%3EREAD_ONLY_ACCESS In the
            /// following Drive example, the list can be a view or edit event's `doc_id` parameter with a value that is
            /// manipulated by an 'equal to' (==) or 'not equal to' (&amp;lt;&amp;gt;) relational operator. In the first
            /// example, the report returns each edited document's `doc_id`. In the second example, the report returns
            /// each viewed document's `doc_id` that equals the value 12345 and does not return any viewed document's
            /// which have a `doc_id` value of 98765. The &amp;lt;&amp;gt; operator is URL-encoded in the request's
            /// query string (%3C%3E): GET...&amp;amp;eventName=edit&amp;amp;filters=doc_id
            /// GET...&amp;amp;eventName=view&amp;amp;filters=doc_id==12345,doc_id%3C%3E98765 The relational operators
            /// include: - `==` - 'equal to'. - `&amp;lt;&amp;gt;` - 'not equal to'. It is URL-encoded (%3C%3E). -
            /// `&amp;lt;` - 'less than'. It is URL-encoded (%3C). - `&amp;lt;=` - 'less than or equal to'. It is
            /// URL-encoded (%3C=). - `&amp;gt;` - 'greater than'. It is URL-encoded (%3E). - `&amp;gt;=` - 'greater
            /// than or equal to'. It is URL-encoded (%3E=). *Note:* The API doesn't accept multiple values of a
            /// parameter. If a particular parameter is supplied more than once in the API request, the API only accepts
            /// the last value of that request parameter. In addition, if an invalid request parameter is supplied in
            /// the API request, the API ignores that request parameter and returns the response corresponding to the
            /// remaining valid request parameters. If no parameters are requested, all parameters are returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filters", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filters { get; set; }

            /// <summary>
            /// Comma separated group ids (obfuscated) on which user activities are filtered, i.e. the response will
            /// contain activities for only those users that are a part of at least one of the group ids mentioned here.
            /// Format: "id:abc123,id:xyz456"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupIdFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string GroupIdFilter { get; set; }

            /// <summary>
            /// Determines how many activity records are shown on each response page. For example, if the request sets
            /// `maxResults=1` and the report has two activities, the report has two pages. The response's
            /// `nextPageToken` property has the token to the second page. The `maxResults` query string is optional in
            /// the request. The default value is 1000.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>
            /// ID of the organizational unit to report on. Activity records will be shown only for users who belong to
            /// the specified organizational unit. Data before Dec 17, 2018 doesn't appear in the filtered results.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orgUnitID", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrgUnitID { get; set; }

            /// <summary>
            /// The token to specify next page. A report with multiple pages has a `nextPageToken` property in the
            /// response. In your follow-on request getting the next page of the report, enter the `nextPageToken` value
            /// in the `pageToken` query string.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Sets the beginning of the range of time shown in the report. The date is in the RFC 3339 format, for
            /// example 2010-10-28T10:26:35.000Z. The report returns all activities from `startTime` until `endTime`.
            /// The `startTime` must be before the `endTime` (if specified) and the current time when the request is
            /// made, or the API returns an error.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StartTime { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Reports.reports_v1.Data.Channel Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "watch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/reports/v1/activity/users/{userKey}/applications/{applicationName}/watch";

            /// <summary>Initializes Watch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("applicationName", new Google.Apis.Discovery.Parameter
                {
                    Name = "applicationName",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(access_transparency)|(admin)|(calendar)|(chat)|(chrome)|(context_aware_access)|(data_studio)|(drive)|(gcp)|(gplus)|(groups)|(groups_enterprise)|(jamboard)|(keep)|(login)|(meet)|(mobile)|(rules)|(saml)|(token)|(user_accounts)",
                });
                RequestParameters.Add("actorIpAddress", new Google.Apis.Discovery.Parameter
                {
                    Name = "actorIpAddress",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"C.+|my_customer",
                });
                RequestParameters.Add("endTime", new Google.Apis.Discovery.Parameter
                {
                    Name = "endTime",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"(\d\d\d\d)-(\d\d)-(\d\d)T(\d\d):(\d\d):(\d\d)(?:\.(\d+))?(?:(Z)|([-+])(\d\d):(\d\d))",
                });
                RequestParameters.Add("eventName", new Google.Apis.Discovery.Parameter
                {
                    Name = "eventName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("filters", new Google.Apis.Discovery.Parameter
                {
                    Name = "filters",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"(.+[<,<=,==,>=,>,<>].+,)*(.+[<,<=,==,>=,>,<>].+)",
                });
                RequestParameters.Add("groupIdFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupIdFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"(id:[a-z0-9]+(,id:[a-z0-9]+)*)",
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "1000",
                    Pattern = null,
                });
                RequestParameters.Add("orgUnitID", new Google.Apis.Discovery.Parameter
                {
                    Name = "orgUnitID",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"(id:[a-z0-9]+)",
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
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
                    Pattern = @"(\d\d\d\d)-(\d\d)-(\d\d)T(\d\d):(\d\d):(\d\d)(?:\.(\d+))?(?:(Z)|([-+])(\d\d):(\d\d))",
                });
            }
        }
    }

    /// <summary>The "channels" collection of methods.</summary>
    public class ChannelsResource
    {
        private const string Resource = "channels";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ChannelsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Stop watching resources through this channel.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual StopRequest Stop(Google.Apis.Admin.Reports.reports_v1.Data.Channel body)
        {
            return new StopRequest(service, body);
        }

        /// <summary>Stop watching resources through this channel.</summary>
        public class StopRequest : ReportsBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Stop request.</summary>
            public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Reports.reports_v1.Data.Channel body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Reports.reports_v1.Data.Channel Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "stop";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/reports_v1/channels/stop";

            /// <summary>Initializes Stop parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "customerUsageReports" collection of methods.</summary>
    public class CustomerUsageReportsResource
    {
        private const string Resource = "customerUsageReports";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CustomerUsageReportsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Retrieves a report which is a collection of properties and statistics for a specific customer's account. For
        /// more information, see the Customers Usage Report guide. For more information about the customer report's
        /// parameters, see the Customers Usage parameters reference guides.
        /// </summary>
        /// <param name="date">
        /// Represents the date the usage occurred. The timestamp is in the ISO 8601 format, yyyy-mm-dd. We recommend
        /// you use your account's time zone for this.
        /// </param>
        public virtual GetRequest Get(string date)
        {
            return new GetRequest(service, date);
        }

        /// <summary>
        /// Retrieves a report which is a collection of properties and statistics for a specific customer's account. For
        /// more information, see the Customers Usage Report guide. For more information about the customer report's
        /// parameters, see the Customers Usage parameters reference guides.
        /// </summary>
        public class GetRequest : ReportsBaseServiceRequest<Google.Apis.Admin.Reports.reports_v1.Data.UsageReports>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string date) : base(service)
            {
                Date = date;
                InitParameters();
            }

            /// <summary>
            /// Represents the date the usage occurred. The timestamp is in the ISO 8601 format, yyyy-mm-dd. We
            /// recommend you use your account's time zone for this.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("date", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Date { get; private set; }

            /// <summary>The unique ID of the customer to retrieve data for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerId { get; set; }

            /// <summary>
            /// Token to specify next page. A report with multiple pages has a `nextPageToken` property in the response.
            /// For your follow-on requests getting all of the report's pages, enter the `nextPageToken` value in the
            /// `pageToken` query string.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// The `parameters` query string is a comma-separated list of event parameters that refine a report's
            /// results. The parameter is associated with a specific application. The application values for the
            /// Customers usage report include `accounts`, `app_maker`, `apps_scripts`, `calendar`, `classroom`, `cros`,
            /// `docs`, `gmail`, `gplus`, `device_management`, `meet`, and `sites`. A `parameters` query string is in
            /// the CSV form of `app_name1:param_name1, app_name2:param_name2`. *Note:* The API doesn't accept multiple
            /// values of a parameter. If a particular parameter is supplied more than once in the API request, the API
            /// only accepts the last value of that request parameter. In addition, if an invalid request parameter is
            /// supplied in the API request, the API ignores that request parameter and returns the response
            /// corresponding to the remaining valid request parameters. An example of an invalid request parameter is
            /// one that does not belong to the application. If no parameters are requested, all parameters are
            /// returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parameters", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parameters { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/reports/v1/usage/dates/{date}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("date", new Google.Apis.Discovery.Parameter
                {
                    Name = "date",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(\d){4}-(\d){2}-(\d){2}",
                });
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"C.+|my_customer",
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("parameters", new Google.Apis.Discovery.Parameter
                {
                    Name = "parameters",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"(((accounts)|(app_maker)|(apps_scripts)|(classroom)|(cros)|(gmail)|(calendar)|(docs)|(gplus)|(sites)|(device_management)|(drive)|(meet)):[^,]+,)*(((accounts)|(app_maker)|(apps_scripts)|(classroom)|(cros)|(gmail)|(calendar)|(docs)|(gplus)|(sites)|(device_management)|(drive)|(meet)):[^,]+)",
                });
            }
        }
    }

    /// <summary>The "entityUsageReports" collection of methods.</summary>
    public class EntityUsageReportsResource
    {
        private const string Resource = "entityUsageReports";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public EntityUsageReportsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Retrieves a report which is a collection of properties and statistics for entities used by users within the
        /// account. For more information, see the Entities Usage Report guide. For more information about the entities
        /// report's parameters, see the Entities Usage parameters reference guides.
        /// </summary>
        /// <param name="entityType">Represents the type of entity for the report.</param>
        /// <param name="entityKey">Represents the key of the object to filter the data with.</param>
        /// <param name="date">
        /// Represents the date the usage occurred. The timestamp is in the ISO 8601 format, yyyy-mm-dd. We recommend
        /// you use your account's time zone for this.
        /// </param>
        public virtual GetRequest Get(GetRequest.EntityTypeEnum entityType, GetRequest.EntityKeyEnum entityKey, string date)
        {
            return new GetRequest(service, entityType, entityKey, date);
        }

        /// <summary>
        /// Retrieves a report which is a collection of properties and statistics for entities used by users within the
        /// account. For more information, see the Entities Usage Report guide. For more information about the entities
        /// report's parameters, see the Entities Usage parameters reference guides.
        /// </summary>
        public class GetRequest : ReportsBaseServiceRequest<Google.Apis.Admin.Reports.reports_v1.Data.UsageReports>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, EntityTypeEnum entityType, EntityKeyEnum entityKey, string date) : base(service)
            {
                EntityType = entityType;
                EntityKey = entityKey;
                Date = date;
                InitParameters();
            }

            /// <summary>Represents the type of entity for the report.</summary>
            [Google.Apis.Util.RequestParameterAttribute("entityType", Google.Apis.Util.RequestParameterType.Path)]
            public virtual EntityTypeEnum EntityType { get; private set; }

            /// <summary>Represents the type of entity for the report.</summary>
            public enum EntityTypeEnum
            {
                /// <summary>Returns a report on Google+ communities.</summary>
                [Google.Apis.Util.StringValueAttribute("gplus_communities")]
                GplusCommunities = 1,
            }

            /// <summary>Represents the key of the object to filter the data with.</summary>
            [Google.Apis.Util.RequestParameterAttribute("entityKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual EntityKeyEnum EntityKey { get; private set; }

            /// <summary>Represents the key of the object to filter the data with.</summary>
            public enum EntityKeyEnum
            {
                /// <summary>Returns activity events for all users.</summary>
                [Google.Apis.Util.StringValueAttribute("all")]
                All = 1,

                /// <summary>
                /// Represents an app-specific identifier for the entity. For details on how to obtain the `entityKey`
                /// for a particular `entityType`, see the Entities Usage parameters reference guides.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("entityKey")]
                EntityKey = 2,
            }

            /// <summary>
            /// Represents the date the usage occurred. The timestamp is in the ISO 8601 format, yyyy-mm-dd. We
            /// recommend you use your account's time zone for this.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("date", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Date { get; private set; }

            /// <summary>The unique ID of the customer to retrieve data for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerId { get; set; }

            /// <summary>
            /// The `filters` query string is a comma-separated list of an application's event parameters where the
            /// parameter's value is manipulated by a relational operator. The `filters` query string includes the name
            /// of the application whose usage is returned in the report. The application values for the Entities usage
            /// report include `accounts`, `docs`, and `gmail`. Filters are in the form `[application name]:parameter
            /// name[parameter value],...`. In this example, the `&amp;lt;&amp;gt;` 'not equal to' operator is
            /// URL-encoded in the request's query string (%3C%3E): GET
            /// https://www.googleapis.com/admin/reports/v1/usage/gplus_communities/all/dates/2017-12-01
            /// ?parameters=gplus:community_name,gplus:num_total_members &amp;amp;filters=gplus:num_total_members%3C%3E0
            /// The relational operators include: - `==` - 'equal to'. - `&amp;lt;&amp;gt;` - 'not equal to'. It is
            /// URL-encoded (%3C%3E). - `&amp;lt;` - 'less than'. It is URL-encoded (%3C). - `&amp;lt;=` - 'less than or
            /// equal to'. It is URL-encoded (%3C=). - `&amp;gt;` - 'greater than'. It is URL-encoded (%3E). -
            /// `&amp;gt;=` - 'greater than or equal to'. It is URL-encoded (%3E=). Filters can only be applied to
            /// numeric parameters.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filters", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filters { get; set; }

            /// <summary>
            /// Determines how many activity records are shown on each response page. For example, if the request sets
            /// `maxResults=1` and the report has two activities, the report has two pages. The response's
            /// `nextPageToken` property has the token to the second page.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// Token to specify next page. A report with multiple pages has a `nextPageToken` property in the response.
            /// In your follow-on request getting the next page of the report, enter the `nextPageToken` value in the
            /// `pageToken` query string.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// The `parameters` query string is a comma-separated list of event parameters that refine a report's
            /// results. The parameter is associated with a specific application. The application values for the
            /// Entities usage report are only `gplus`. A `parameter` query string is in the CSV form of
            /// `[app_name1:param_name1], [app_name2:param_name2]...`. *Note:* The API doesn't accept multiple values of
            /// a parameter. If a particular parameter is supplied more than once in the API request, the API only
            /// accepts the last value of that request parameter. In addition, if an invalid request parameter is
            /// supplied in the API request, the API ignores that request parameter and returns the response
            /// corresponding to the remaining valid request parameters. An example of an invalid request parameter is
            /// one that does not belong to the application. If no parameters are requested, all parameters are
            /// returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parameters", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parameters { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/reports/v1/usage/{entityType}/{entityKey}/dates/{date}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("entityType", new Google.Apis.Discovery.Parameter
                {
                    Name = "entityType",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(gplus_communities)",
                });
                RequestParameters.Add("entityKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "entityKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("date", new Google.Apis.Discovery.Parameter
                {
                    Name = "date",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(\d){4}-(\d){2}-(\d){2}",
                });
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"C.+|my_customer",
                });
                RequestParameters.Add("filters", new Google.Apis.Discovery.Parameter
                {
                    Name = "filters",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"(((gplus)):[a-z0-9_]+[<,<=,==,>=,>,!=][^,]+,)*(((gplus)):[a-z0-9_]+[<,<=,==,>=,>,!=][^,]+)",
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "1000",
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
                RequestParameters.Add("parameters", new Google.Apis.Discovery.Parameter
                {
                    Name = "parameters",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"(((gplus)):[^,]+,)*(((gplus)):[^,]+)",
                });
            }
        }
    }

    /// <summary>The "userUsageReport" collection of methods.</summary>
    public class UserUsageReportResource
    {
        private const string Resource = "userUsageReport";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UserUsageReportResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Retrieves a report which is a collection of properties and statistics for a set of users with the account.
        /// For more information, see the User Usage Report guide. For more information about the user report's
        /// parameters, see the Users Usage parameters reference guides.
        /// </summary>
        /// <param name="userKey">
        /// Represents the profile ID or the user email for which the data should be filtered. Can be `all` for all
        /// information, or `userKey` for a user's unique Google Workspace profile ID or their primary email address.
        /// Must not be a deleted user. For a deleted user, call `users.list` in Directory API with `showDeleted=true`,
        /// then use the returned `ID` as the `userKey`.
        /// </param>
        /// <param name="date">
        /// Represents the date the usage occurred. The timestamp is in the ISO 8601 format, yyyy-mm-dd. We recommend
        /// you use your account's time zone for this.
        /// </param>
        public virtual GetRequest Get(string userKey, string date)
        {
            return new GetRequest(service, userKey, date);
        }

        /// <summary>
        /// Retrieves a report which is a collection of properties and statistics for a set of users with the account.
        /// For more information, see the User Usage Report guide. For more information about the user report's
        /// parameters, see the Users Usage parameters reference guides.
        /// </summary>
        public class GetRequest : ReportsBaseServiceRequest<Google.Apis.Admin.Reports.reports_v1.Data.UsageReports>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string userKey, string date) : base(service)
            {
                UserKey = userKey;
                Date = date;
                InitParameters();
            }

            /// <summary>
            /// Represents the profile ID or the user email for which the data should be filtered. Can be `all` for all
            /// information, or `userKey` for a user's unique Google Workspace profile ID or their primary email
            /// address. Must not be a deleted user. For a deleted user, call `users.list` in Directory API with
            /// `showDeleted=true`, then use the returned `ID` as the `userKey`.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>
            /// Represents the date the usage occurred. The timestamp is in the ISO 8601 format, yyyy-mm-dd. We
            /// recommend you use your account's time zone for this.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("date", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Date { get; private set; }

            /// <summary>The unique ID of the customer to retrieve data for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomerId { get; set; }

            /// <summary>
            /// The `filters` query string is a comma-separated list of an application's event parameters where the
            /// parameter's value is manipulated by a relational operator. The `filters` query string includes the name
            /// of the application whose usage is returned in the report. The application values for the Users Usage
            /// Report include `accounts`, `docs`, and `gmail`. Filters are in the form `[application name]:parameter
            /// name[parameter value],...`. In this example, the `&amp;lt;&amp;gt;` 'not equal to' operator is
            /// URL-encoded in the request's query string (%3C%3E): GET
            /// https://www.googleapis.com/admin/reports/v1/usage/users/all/dates/2013-03-03
            /// ?parameters=accounts:last_login_time
            /// &amp;amp;filters=accounts:last_login_time%3C%3E2010-10-28T10:26:35.000Z The relational operators
            /// include: - `==` - 'equal to'. - `&amp;lt;&amp;gt;` - 'not equal to'. It is URL-encoded (%3C%3E). -
            /// `&amp;lt;` - 'less than'. It is URL-encoded (%3C). - `&amp;lt;=` - 'less than or equal to'. It is
            /// URL-encoded (%3C=). - `&amp;gt;` - 'greater than'. It is URL-encoded (%3E). - `&amp;gt;=` - 'greater
            /// than or equal to'. It is URL-encoded (%3E=).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filters", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filters { get; set; }

            /// <summary>
            /// Comma separated group ids (obfuscated) on which user activities are filtered, i.e. the response will
            /// contain activities for only those users that are a part of at least one of the group ids mentioned here.
            /// Format: "id:abc123,id:xyz456"
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("groupIdFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string GroupIdFilter { get; set; }

            /// <summary>
            /// Determines how many activity records are shown on each response page. For example, if the request sets
            /// `maxResults=1` and the report has two activities, the report has two pages. The response's
            /// `nextPageToken` property has the token to the second page. The `maxResults` query string is optional.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// ID of the organizational unit to report on. User activity will be shown only for users who belong to the
            /// specified organizational unit. Data before Dec 17, 2018 doesn't appear in the filtered results.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("orgUnitID", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrgUnitID { get; set; }

            /// <summary>
            /// Token to specify next page. A report with multiple pages has a `nextPageToken` property in the response.
            /// In your follow-on request getting the next page of the report, enter the `nextPageToken` value in the
            /// `pageToken` query string.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// The `parameters` query string is a comma-separated list of event parameters that refine a report's
            /// results. The parameter is associated with a specific application. The application values for the
            /// Customers Usage report include `accounts`, `app_maker`, `apps_scripts`, `calendar`, `classroom`, `cros`,
            /// `docs`, `gmail`, `gplus`, `device_management`, `meet`, and `sites`. A `parameters` query string is in
            /// the CSV form of `app_name1:param_name1, app_name2:param_name2`. *Note:* The API doesn't accept multiple
            /// values of a parameter. If a particular parameter is supplied more than once in the API request, the API
            /// only accepts the last value of that request parameter. In addition, if an invalid request parameter is
            /// supplied in the API request, the API ignores that request parameter and returns the response
            /// corresponding to the remaining valid request parameters. An example of an invalid request parameter is
            /// one that does not belong to the application. If no parameters are requested, all parameters are
            /// returned.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parameters", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parameters { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "admin/reports/v1/usage/users/{userKey}/dates/{date}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userKey", new Google.Apis.Discovery.Parameter
                {
                    Name = "userKey",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("date", new Google.Apis.Discovery.Parameter
                {
                    Name = "date",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"(\d){4}-(\d){2}-(\d){2}",
                });
                RequestParameters.Add("customerId", new Google.Apis.Discovery.Parameter
                {
                    Name = "customerId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"C.+|my_customer",
                });
                RequestParameters.Add("filters", new Google.Apis.Discovery.Parameter
                {
                    Name = "filters",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"(((accounts)|(classroom)|(cros)|(gmail)|(calendar)|(docs)|(gplus)|(sites)|(device_management)|(drive)):[a-z0-9_]+[<,<=,==,>=,>,!=][^,]+,)*(((accounts)|(classroom)|(cros)|(gmail)|(calendar)|(docs)|(gplus)|(sites)|(device_management)|(drive)):[a-z0-9_]+[<,<=,==,>=,>,!=][^,]+)",
                });
                RequestParameters.Add("groupIdFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "groupIdFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"(id:[a-z0-9]+(,id:[a-z0-9]+)*)",
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "1000",
                    Pattern = null,
                });
                RequestParameters.Add("orgUnitID", new Google.Apis.Discovery.Parameter
                {
                    Name = "orgUnitID",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"(id:[a-z0-9]+)",
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("parameters", new Google.Apis.Discovery.Parameter
                {
                    Name = "parameters",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = @"(((accounts)|(classroom)|(cros)|(gmail)|(calendar)|(docs)|(gplus)|(sites)|(device_management)|(drive)):[^,]+,)*(((accounts)|(classroom)|(cros)|(gmail)|(calendar)|(docs)|(gplus)|(sites)|(device_management)|(drive)):[^,]+)",
                });
            }
        }
    }
}
namespace Google.Apis.Admin.Reports.reports_v1.Data
{
    /// <summary>JSON template for a collection of activities.</summary>
    public class Activities : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Each activity record in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Activity> Items { get; set; }

        /// <summary>The type of API resource. For an activity report, the value is `reports#activities`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Token for retrieving the follow-on next page of the report. The `nextPageToken` value is used in the
        /// request's `pageToken` query string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }
    }

    /// <summary>JSON template for the activity resource.</summary>
    public class Activity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User doing the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actor")]
        public virtual ActorData Actor { get; set; }

        /// <summary>ETag of the entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Activity events in the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<EventsData> Events { get; set; }

        /// <summary>Unique identifier for each activity record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual IdData Id { get; set; }

        /// <summary>
        /// IP address of the user doing the action. This is the Internet Protocol (IP) address of the user when logging
        /// into Google Workspace, which may or may not reflect the user's physical location. For example, the IP
        /// address can be the user's proxy server's address or a virtual private network (VPN) address. The API
        /// supports IPv4 and IPv6.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>The type of API resource. For an activity report, the value is `audit#activity`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// This is the domain that is affected by the report's event. For example domain of Admin console or the Drive
        /// application's document owner.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerDomain")]
        public virtual string OwnerDomain { get; set; }

        /// <summary>User doing the action.</summary>
        public class ActorData
        {
            /// <summary>The type of actor.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("callerType")]
            public virtual string CallerType { get; set; }

            /// <summary>
            /// The primary email address of the actor. May be absent if there is no email address associated with the
            /// actor.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("email")]
            public virtual string Email { get; set; }

            /// <summary>
            /// Only present when `callerType` is `KEY`. Can be the `consumer_key` of the requestor for OAuth 2LO API
            /// requests or an identifier for robot accounts.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("key")]
            public virtual string Key { get; set; }

            /// <summary>
            /// The unique Google Workspace profile ID of the actor. May be absent if the actor is not a Google
            /// Workspace user.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("profileId")]
            public virtual string ProfileId { get; set; }
        }

        /// <summary>Activity events in the report.</summary>
        public class EventsData
        {
            /// <summary>
            /// Name of the event. This is the specific name of the activity reported by the API. And each `eventName`
            /// is related to a specific Google Workspace service or feature which the API organizes into types of
            /// events. For `eventName` request parameters in general: - If no `eventName` is given, the report returns
            /// all possible instances of an `eventName`. - When you request an `eventName`, the API's response returns
            /// all activities which contain that `eventName`. It is possible that the returned activities will have
            /// other `eventName` properties in addition to the one requested. For more information about `eventName`
            /// properties, see the list of event names for various applications above in `applicationName`.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }

            /// <summary>
            /// Parameter value pairs for various applications. For more information about `eventName` parameters, see
            /// the list of event names for various applications above in `applicationName`.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
            public virtual System.Collections.Generic.IList<ParametersData> Parameters { get; set; }

            /// <summary>
            /// Type of event. The Google Workspace service or feature that an administrator changes is identified in
            /// the `type` property which identifies an event using the `eventName` property. For a full list of the
            /// API's `type` categories, see the list of event names for various applications above in
            /// `applicationName`.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }

            /// <summary>
            /// Parameter value pairs for various applications. For more information about `eventName` parameters, see
            /// the list of event names for various applications above in `applicationName`.
            /// </summary>
            public class ParametersData
            {
                /// <summary>Boolean value of the parameter.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
                public virtual System.Nullable<bool> BoolValue { get; set; }

                /// <summary>Integer value of the parameter.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
                public virtual System.Nullable<long> IntValue { get; set; }

                /// <summary>
                /// Nested parameter value pairs associated with this parameter. Complex value type for a parameter are
                /// returned as a list of parameter values. For example, the address parameter may have a value as
                /// `[{parameter: [{name: city, value: abc}]}]`
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("messageValue")]
                public virtual MessageValueData MessageValue { get; set; }

                /// <summary>Integer values of the parameter.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("multiIntValue")]
                public virtual System.Collections.Generic.IList<System.Nullable<long>> MultiIntValue { get; set; }

                /// <summary>List of `messageValue` objects.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("multiMessageValue")]
                public virtual System.Collections.Generic.IList<MultiMessageValueData> MultiMessageValue { get; set; }

                /// <summary>String values of the parameter.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("multiValue")]
                public virtual System.Collections.Generic.IList<string> MultiValue { get; set; }

                /// <summary>The name of the parameter.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("name")]
                public virtual string Name { get; set; }

                /// <summary>String value of the parameter.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("value")]
                public virtual string Value { get; set; }

                /// <summary>
                /// Nested parameter value pairs associated with this parameter. Complex value type for a parameter are
                /// returned as a list of parameter values. For example, the address parameter may have a value as
                /// `[{parameter: [{name: city, value: abc}]}]`
                /// </summary>
                public class MessageValueData
                {
                    /// <summary>Parameter values</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("parameter")]
                    public virtual System.Collections.Generic.IList<NestedParameter> Parameter { get; set; }
                }

                /// <summary>List of `messageValue` objects.</summary>
                public class MultiMessageValueData
                {
                    /// <summary>Parameter values</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("parameter")]
                    public virtual System.Collections.Generic.IList<NestedParameter> Parameter { get; set; }
                }
            }
        }

        /// <summary>Unique identifier for each activity record.</summary>
        public class IdData
        {
            /// <summary>
            /// Application name to which the event belongs. For possible values see the list of applications above in
            /// `applicationName`.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("applicationName")]
            public virtual string ApplicationName { get; set; }

            /// <summary>The unique identifier for a Google Workspace account.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
            public virtual string CustomerId { get; set; }

            /// <summary>Time of occurrence of the activity. This is in UNIX epoch time in seconds.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("time")]
            public virtual string TimeRaw { get; set; }

            /// <summary><seealso cref="System.DateTime"/> representation of <see cref="TimeRaw"/>.</summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            public virtual System.Nullable<System.DateTime> Time
            {
                get => Google.Apis.Util.Utilities.GetDateTimeFromString(TimeRaw);
                set => TimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }

            /// <summary>Unique qualifier if multiple events have the same time.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("uniqueQualifier")]
            public virtual System.Nullable<long> UniqueQualifier { get; set; }
        }
    }

    /// <summary>A notification channel used to watch for resource changes.</summary>
    public class Channel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The address where notifications are delivered for this channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; }

        /// <summary>
        /// Date and time of notification channel expiration, expressed as a Unix timestamp, in milliseconds. Optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiration")]
        public virtual System.Nullable<long> Expiration { get; set; }

        /// <summary>A UUID or similar unique string that identifies this channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifies this as a notification channel used to watch for changes to a resource, which is "`api#channel`".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Additional parameters controlling delivery channel behavior. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string, string> Params__ { get; set; }

        /// <summary>A Boolean value to indicate whether payload is wanted. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Nullable<bool> Payload { get; set; }

        /// <summary>
        /// An opaque ID that identifies the resource being watched on this channel. Stable across different API
        /// versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>A version-specific identifier for the watched resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; }

        /// <summary>
        /// An arbitrary string delivered to the target address with each notification delivered over this channel.
        /// Optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; }

        /// <summary>
        /// The type of delivery mechanism used for this channel. The value should be set to `"web_hook"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a parameter used in various reports.</summary>
    public class NestedParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Boolean value of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>Integer value of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
        public virtual System.Nullable<long> IntValue { get; set; }

        /// <summary>Multiple boolean values of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiBoolValue")]
        public virtual System.Collections.Generic.IList<System.Nullable<bool>> MultiBoolValue { get; set; }

        /// <summary>Multiple integer values of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiIntValue")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> MultiIntValue { get; set; }

        /// <summary>Multiple string values of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiValue")]
        public virtual System.Collections.Generic.IList<string> MultiValue { get; set; }

        /// <summary>The name of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>String value of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template for a usage report.</summary>
    public class UsageReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The date of the report request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("date")]
        public virtual string Date { get; set; }

        /// <summary>Output only. Information about the type of the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual EntityData Entity { get; set; }

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The type of API resource. For a usage report, the value is `admin#reports#usageReport`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Output only. Parameter value pairs for various applications. For the Entity Usage Report parameters and
        /// values, see [the Entity Usage parameters
        /// reference](/admin-sdk/reports/v1/reference/usage-ref-appendix-a/entities).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<ParametersData> Parameters { get; set; }

        /// <summary>Output only. Information about the type of the item.</summary>
        public class EntityData
        {
            /// <summary>Output only. The unique identifier of the customer's account.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
            public virtual string CustomerId { get; set; }

            /// <summary>
            /// Output only. Object key. Only relevant if entity.type = "OBJECT" Note: external-facing name of report is
            /// "Entities" rather than "Objects".
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
            public virtual string EntityId { get; set; }

            /// <summary>Output only. The user's immutable Google Workspace profile identifier.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("profileId")]
            public virtual string ProfileId { get; set; }

            /// <summary>Output only. The type of item. The value is `user`.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; }

            /// <summary>Output only. The user's email address. Only relevant if entity.type = "USER"</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("userEmail")]
            public virtual string UserEmail { get; set; }
        }

        /// <summary>
        /// Output only. Parameter value pairs for various applications. For the Entity Usage Report parameters and
        /// values, see [the Entity Usage parameters
        /// reference](/admin-sdk/reports/v1/reference/usage-ref-appendix-a/entities).
        /// </summary>
        public class ParametersData
        {
            /// <summary>Output only. Boolean value of the parameter.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
            public virtual System.Nullable<bool> BoolValue { get; set; }

            /// <summary>The RFC 3339 formatted value of the parameter, for example 2010-10-28T10:26:35.000Z.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("datetimeValue")]
            public virtual string DatetimeValueRaw { get; set; }

            /// <summary><seealso cref="System.DateTime"/> representation of <see cref="DatetimeValueRaw"/>.</summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            public virtual System.Nullable<System.DateTime> DatetimeValue
            {
                get => Google.Apis.Util.Utilities.GetDateTimeFromString(DatetimeValueRaw);
                set => DatetimeValueRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }

            /// <summary>Output only. Integer value of the parameter.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("intValue")]
            public virtual System.Nullable<long> IntValue { get; set; }

            /// <summary>Output only. Nested message value of the parameter.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("msgValue")]
            public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> MsgValue { get; set; }

            /// <summary>
            /// The name of the parameter. For the User Usage Report parameter names, see the User Usage parameters
            /// reference.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }

            /// <summary>Output only. String value of the parameter.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
            public virtual string StringValue { get; set; }
        }
    }

    public class UsageReports : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The type of API resource. For a usage report, the value is `admin#reports#usageReports`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Token to specify next page. A report with multiple pages has a `nextPageToken` property in the response. For
        /// your follow-on requests getting all of the report's pages, enter the `nextPageToken` value in the
        /// `pageToken` query string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Various application parameter records.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usageReports")]
        public virtual System.Collections.Generic.IList<UsageReport> UsageReportsValue { get; set; }

        /// <summary>Warnings, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Collections.Generic.IList<WarningsData> Warnings { get; set; }

        /// <summary>Warnings, if any.</summary>
        public class WarningsData
        {
            /// <summary>Machine readable code or warning type. The warning code value is `200`.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("code")]
            public virtual string Code { get; set; }

            /// <summary>Key-value pairs to give detailed information on the warning.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("data")]
            public virtual System.Collections.Generic.IList<DataData> Data { get; set; }

            /// <summary>
            /// The human readable messages for a warning are: - Data is not available warning - Sorry, data for date
            /// yyyy-mm-dd for application "`application name`" is not available. - Partial data is available warning -
            /// Data for date yyyy-mm-dd for application "`application name`" is not available right now, please try
            /// again after a few hours.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("message")]
            public virtual string Message { get; set; }

            /// <summary>Key-value pairs to give detailed information on the warning.</summary>
            public class DataData
            {
                /// <summary>Key associated with a key-value pair to give detailed information on the warning.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("key")]
                public virtual string Key { get; set; }

                /// <summary>
                /// Value associated with a key-value pair to give detailed information on the warning.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("value")]
                public virtual string Value { get; set; }
            }
        }
    }
}
