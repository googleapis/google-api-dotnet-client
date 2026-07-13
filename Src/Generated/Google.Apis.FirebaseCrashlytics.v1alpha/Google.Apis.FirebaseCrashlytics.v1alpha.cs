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

namespace Google.Apis.FirebaseCrashlytics.v1alpha
{
    /// <summary>The FirebaseCrashlytics Service.</summary>
    public class FirebaseCrashlyticsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FirebaseCrashlyticsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FirebaseCrashlyticsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://firebasecrashlytics.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://firebasecrashlytics.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "firebasecrashlytics";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Firebase Crashlytics API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and administer all your Firebase data and settings</summary>
            public static string Firebase = "https://www.googleapis.com/auth/firebase";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Firebase Crashlytics API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and administer all your Firebase data and settings</summary>
            public const string Firebase = "https://www.googleapis.com/auth/firebase";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for FirebaseCrashlytics requests.</summary>
    public abstract class FirebaseCrashlyticsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new FirebaseCrashlyticsBaseServiceRequest instance.</summary>
        protected FirebaseCrashlyticsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes FirebaseCrashlytics parameter list.</summary>
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
            Apps = new AppsResource(service);
        }

        /// <summary>Gets the Apps resource.</summary>
        public virtual AppsResource Apps { get; }

        /// <summary>The "apps" collection of methods.</summary>
        public class AppsResource
        {
            private const string Resource = "apps";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AppsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Events = new EventsResource(service);
                Issues = new IssuesResource(service);
                Reports = new ReportsResource(service);
                Users = new UsersResource(service);
            }

            /// <summary>Gets the Events resource.</summary>
            public virtual EventsResource Events { get; }

            /// <summary>The "events" collection of methods.</summary>
            public class EventsResource
            {
                private const string Resource = "events";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EventsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Fetch a batch of up to 100 events by name.</summary>
                /// <param name="parent">
                /// Required. The firebase application. Format: "projects/{project}/apps/{app_id}".
                /// </param>
                public virtual BatchGetRequest BatchGet(string parent)
                {
                    return new BatchGetRequest(this.service, parent);
                }

                /// <summary>Fetch a batch of up to 100 events by name.</summary>
                public class BatchGetRequest : FirebaseCrashlyticsBaseServiceRequest<Google.Apis.FirebaseCrashlytics.v1alpha.Data.BatchGetEventsResponse>
                {
                    /// <summary>Constructs a new BatchGet request.</summary>
                    public BatchGetRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The firebase application. Format: "projects/{project}/apps/{app_id}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. The resource names of the desired events. A maximum of 100 events can be retrieved in
                    /// a batch. Format: "projects/{project}/apps/{app_id}/events/{event_id}". The app_id and event_id
                    /// are required, but project may be "-" to conserve space in long URIs.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("names", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> Names { get; set; }

                    /// <summary>
                    /// Optional. The list of Event fields to include in the response. If omitted, the full event is
                    /// returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object ReadMask { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchGet";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/events:batchGet";

                    /// <summary>Initializes BatchGet parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+$",
                        });
                        RequestParameters.Add("names", new Google.Apis.Discovery.Parameter
                        {
                            Name = "names",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "readMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// List the events for an issue matching filter criteria, sorted in descending order by timestamp.
                /// </summary>
                /// <param name="parent">
                /// Required. The Firebase application. Format: "projects/{project}/apps/{app_id}".
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// List the events for an issue matching filter criteria, sorted in descending order by timestamp.
                /// </summary>
                public class ListRequest : FirebaseCrashlyticsBaseServiceRequest<Google.Apis.FirebaseCrashlytics.v1alpha.Data.ListEventsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The Firebase application. Format: "projects/{project}/apps/{app_id}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. Only count events from the given browser. This string matches Browser.display_name.
                    /// Format: "name (display_version)" e.g. "Chrome (123)", or just "name" for all possible versions,
                    /// e.g. simply "Chrome".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.browser.displayNames", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> FilterBrowserDisplayNames { get; set; }

                    /// <summary>
                    /// Only counts events from the given Device model. This string matches Device.display_name. Format:
                    /// "manufacturer (model)" e.g. "Google (Pixel 6)", or just "manufacturer" for all possible models,
                    /// e.g. simply "Google". Note that a device's marketing_name field can not be used for filtering.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.device.displayNames", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> FilterDeviceDisplayNames { get; set; }

                    /// <summary>
                    /// Only counts events from devices with the given form factor (e.g. phone or tablet).
                    /// </summary>
                    /// <remarks>
                    /// Use this property to set a single value for the parameter, or
                    /// <see cref="FilterDeviceFormFactorsList"/> to set multiple values. Do not set both properties.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("filter.device.formFactors", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<FilterDeviceFormFactorsEnum> FilterDeviceFormFactors { get; set; }

                    /// <summary>
                    /// Only counts events from devices with the given form factor (e.g. phone or tablet).
                    /// </summary>
                    /// <remarks>
                    /// Use this property to set one or more values for the parameter. Do not set both this property and
                    /// <see cref="FilterDeviceFormFactors"/>.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("filter.device.formFactors", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<FilterDeviceFormFactorsEnum> FilterDeviceFormFactorsList { get; set; }

                    /// <summary>
                    /// Only counts events from devices with the given form factor (e.g. phone or tablet).
                    /// </summary>
                    public enum FilterDeviceFormFactorsEnum
                    {
                        /// <summary>Unknown.</summary>
                        [Google.Apis.Util.StringValueAttribute("FORM_FACTOR_UNSPECIFIED")]
                        FORMFACTORUNSPECIFIED = 0,

                        /// <summary>
                        /// Includes mobile phones, small foldables and other form factors not fitting the other
                        /// categories.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("PHONE")]
                        PHONE = 1,

                        /// <summary>Includes tablets and larger foldables.</summary>
                        [Google.Apis.Util.StringValueAttribute("TABLET")]
                        TABLET = 2,

                        /// <summary>Includes desktops, laptops, Chromebooks, etc.</summary>
                        [Google.Apis.Util.StringValueAttribute("DESKTOP")]
                        DESKTOP = 3,

                        /// <summary>Includes televisions and set-tops.</summary>
                        [Google.Apis.Util.StringValueAttribute("TV")]
                        TV = 4,

                        /// <summary>Includes both watches and other wearables.</summary>
                        [Google.Apis.Util.StringValueAttribute("WATCH")]
                        WATCH = 5,
                    }

                    private object _filterIntervalEndTime;

                    /// <summary>
                    /// String representation of <see cref="FilterIntervalEndTimeDateTimeOffset"/>, formatted for
                    /// inclusion in the HTTP request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.interval.endTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FilterIntervalEndTimeRaw { get; private set; }

                    /// <summary>
                    /// <seealso cref="object"/> representation of <see cref="FilterIntervalEndTimeRaw"/>.
                    /// </summary>
                    [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FilterIntervalEndTimeDateTimeOffset instead.")]
                    public virtual object FilterIntervalEndTime
                    {
                        get => _filterIntervalEndTime;
                        set
                        {
                            FilterIntervalEndTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                            _filterIntervalEndTime = value;
                        }
                    }

                    public virtual System.DateTimeOffset? FilterIntervalEndTimeDateTimeOffset
                    {
                        get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FilterIntervalEndTimeRaw);
                        set
                        {
                            FilterIntervalEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                            _filterIntervalEndTime = value;
                        }
                    }

                    private object _filterIntervalStartTime;

                    /// <summary>
                    /// String representation of <see cref="FilterIntervalStartTimeDateTimeOffset"/>, formatted for
                    /// inclusion in the HTTP request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.interval.startTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FilterIntervalStartTimeRaw { get; private set; }

                    /// <summary>
                    /// <seealso cref="object"/> representation of <see cref="FilterIntervalStartTimeRaw"/>.
                    /// </summary>
                    [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FilterIntervalStartTimeDateTimeOffset instead.")]
                    public virtual object FilterIntervalStartTime
                    {
                        get => _filterIntervalStartTime;
                        set
                        {
                            FilterIntervalStartTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                            _filterIntervalStartTime = value;
                        }
                    }

                    public virtual System.DateTimeOffset? FilterIntervalStartTimeDateTimeOffset
                    {
                        get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FilterIntervalStartTimeRaw);
                        set
                        {
                            FilterIntervalStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                            _filterIntervalStartTime = value;
                        }
                    }

                    /// <summary>
                    /// Optional. A space separated list of filter terms matched against the contents of the issue.
                    /// Contents include the title and the stack trace. Matches must begin at alphanumeric tokens, i.e.,
                    /// 'util.Sorted' matches 'java.util.SortedSet' but not 'myutil.SortedArray'. The filter matches if
                    /// all filter terms match. All non-alphanumeric characters are ignored for matching. Filtering is
                    /// assumed to be prefix-search and order-independent unless phrases are surrounded by "". Any terms
                    /// contained in quotes are searched using exact-match (given filter term "foo", we will not return
                    /// "foobar"), and must appear in the order given exactly. To get order-dependence but
                    /// prefix-search, use a * within the quotes ("abc foo*" will match "abc foobar", but not "foo abc"
                    /// "abcd foobar", or "abc xyz foobar").
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.content", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FilterIssueContent { get; set; }

                    /// <summary>
                    /// Optional. Only counts events of the given error types. This field matches [Issue.error_type].
                    /// </summary>
                    /// <remarks>
                    /// Use this property to set a single value for the parameter, or
                    /// <see cref="FilterIssueErrorTypesList"/> to set multiple values. Do not set both properties.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.errorTypes", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<FilterIssueErrorTypesEnum> FilterIssueErrorTypes { get; set; }

                    /// <summary>
                    /// Optional. Only counts events of the given error types. This field matches [Issue.error_type].
                    /// </summary>
                    /// <remarks>
                    /// Use this property to set one or more values for the parameter. Do not set both this property and
                    /// <see cref="FilterIssueErrorTypes"/>.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.errorTypes", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<FilterIssueErrorTypesEnum> FilterIssueErrorTypesList { get; set; }

                    /// <summary>
                    /// Optional. Only counts events of the given error types. This field matches [Issue.error_type].
                    /// </summary>
                    public enum FilterIssueErrorTypesEnum
                    {
                        /// <summary>Unknown.</summary>
                        [Google.Apis.Util.StringValueAttribute("ERROR_TYPE_UNSPECIFIED")]
                        ERRORTYPEUNSPECIFIED = 0,

                        /// <summary>Fatal crash event.</summary>
                        [Google.Apis.Util.StringValueAttribute("FATAL")]
                        FATAL = 1,

                        /// <summary>Non-fatal event, such as a caught Java exception or NSError on iOS.</summary>
                        [Google.Apis.Util.StringValueAttribute("NON_FATAL")]
                        NONFATAL = 2,

                        /// <summary>Application not responding error, Android only.</summary>
                        [Google.Apis.Util.StringValueAttribute("ANR")]
                        ANR = 3,
                    }

                    /// <summary>
                    /// Optional. Only counts events in the given issue ID. This field matches [Issue.id].
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.id", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FilterIssueId { get; set; }

                    /// <summary>
                    /// Optional. Only returns issues currently marked with the given signals. This field matches
                    /// [Issue.signals.signal].
                    /// </summary>
                    /// <remarks>
                    /// Use this property to set a single value for the parameter, or
                    /// <see cref="FilterIssueSignalsList"/> to set multiple values. Do not set both properties.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.signals", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<FilterIssueSignalsEnum> FilterIssueSignals { get; set; }

                    /// <summary>
                    /// Optional. Only returns issues currently marked with the given signals. This field matches
                    /// [Issue.signals.signal].
                    /// </summary>
                    /// <remarks>
                    /// Use this property to set one or more values for the parameter. Do not set both this property and
                    /// <see cref="FilterIssueSignals"/>.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.signals", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<FilterIssueSignalsEnum> FilterIssueSignalsList { get; set; }

                    /// <summary>
                    /// Optional. Only returns issues currently marked with the given signals. This field matches
                    /// [Issue.signals.signal].
                    /// </summary>
                    public enum FilterIssueSignalsEnum
                    {
                        /// <summary>Default.</summary>
                        [Google.Apis.Util.StringValueAttribute("SIGNAL_UNSPECIFIED")]
                        SIGNALUNSPECIFIED = 0,

                        /// <summary>Indicates an issue that is impacting end users early in the app session.</summary>
                        [Google.Apis.Util.StringValueAttribute("SIGNAL_EARLY")]
                        SIGNALEARLY = 1,

                        /// <summary>Indicates newly detected issues.</summary>
                        [Google.Apis.Util.StringValueAttribute("SIGNAL_FRESH")]
                        SIGNALFRESH = 2,

                        /// <summary>Indicates previously closed issues which have been detected again.</summary>
                        [Google.Apis.Util.StringValueAttribute("SIGNAL_REGRESSED")]
                        SIGNALREGRESSED = 3,

                        /// <summary>Indicates issues impacting some end users multiple times.</summary>
                        [Google.Apis.Util.StringValueAttribute("SIGNAL_REPETITIVE")]
                        SIGNALREPETITIVE = 4,
                    }

                    /// <summary>
                    /// Optional. Deprecated: Prefer `states` field. Only includes events for issues with the given
                    /// issue state. Only available for `topIssues` reports.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.state", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<FilterIssueStateEnum> FilterIssueState { get; set; }

                    /// <summary>
                    /// Optional. Deprecated: Prefer `states` field. Only includes events for issues with the given
                    /// issue state. Only available for `topIssues` reports.
                    /// </summary>
                    public enum FilterIssueStateEnum
                    {
                        /// <summary>Unknown.</summary>
                        [Google.Apis.Util.StringValueAttribute("STATE_UNSPECIFIED")]
                        STATEUNSPECIFIED = 0,

                        /// <summary>Ongoing issue.</summary>
                        [Google.Apis.Util.StringValueAttribute("OPEN")]
                        OPEN = 1,

                        /// <summary>Issue resolved.</summary>
                        [Google.Apis.Util.StringValueAttribute("CLOSED")]
                        CLOSED = 2,

                        /// <summary>Issue muted. No alerts will be fired for this issue.</summary>
                        [Google.Apis.Util.StringValueAttribute("MUTED")]
                        MUTED = 3,
                    }

                    /// <summary>
                    /// Optional. Only includes events for issues with the given issue states. Only available for
                    /// `topIssues` reports.
                    /// </summary>
                    /// <remarks>
                    /// Use this property to set a single value for the parameter, or
                    /// <see cref="FilterIssueStatesList"/> to set multiple values. Do not set both properties.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.states", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<FilterIssueStatesEnum> FilterIssueStates { get; set; }

                    /// <summary>
                    /// Optional. Only includes events for issues with the given issue states. Only available for
                    /// `topIssues` reports.
                    /// </summary>
                    /// <remarks>
                    /// Use this property to set one or more values for the parameter. Do not set both this property and
                    /// <see cref="FilterIssueStates"/>.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.states", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<FilterIssueStatesEnum> FilterIssueStatesList { get; set; }

                    /// <summary>
                    /// Optional. Only includes events for issues with the given issue states. Only available for
                    /// `topIssues` reports.
                    /// </summary>
                    public enum FilterIssueStatesEnum
                    {
                        /// <summary>Unknown.</summary>
                        [Google.Apis.Util.StringValueAttribute("STATE_UNSPECIFIED")]
                        STATEUNSPECIFIED = 0,

                        /// <summary>Ongoing issue.</summary>
                        [Google.Apis.Util.StringValueAttribute("OPEN")]
                        OPEN = 1,

                        /// <summary>Issue resolved.</summary>
                        [Google.Apis.Util.StringValueAttribute("CLOSED")]
                        CLOSED = 2,

                        /// <summary>Issue muted. No alerts will be fired for this issue.</summary>
                        [Google.Apis.Util.StringValueAttribute("MUTED")]
                        MUTED = 3,
                    }

                    /// <summary>
                    /// Optional. Only counts events for the given issue variant ID. This field matches
                    /// [IssueVariant.id].
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.variantId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FilterIssueVariantId { get; set; }

                    /// <summary>
                    /// Only counts events in the given operating system and version. This string matches
                    /// OperatingSystem.display_name. Format: "osName (osVersion)" e.g. "Android (11)". or just "osName"
                    /// for all versions, e.g. simply "iPadOS".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.operatingSystem.displayNames", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> FilterOperatingSystemDisplayNames { get; set; }

                    /// <summary>
                    /// Only counts events in the given app version. This string matches Version.display_name. Format:
                    /// "display_version (build_version)" e.g. "1.2.3 (456)".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.version.displayNames", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> FilterVersionDisplayNames { get; set; }

                    /// <summary>Optional. The maximum number of events per page. If omitted, defaults to 10.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. A page token, received from a previous calls.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Optional. The list of Event fields to include in the response. If omitted, the full event is
                    /// returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("readMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object ReadMask { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/events";

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
                            Pattern = @"^projects/[^/]+/apps/[^/]+$",
                        });
                        RequestParameters.Add("filter.browser.displayNames", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.browser.displayNames",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.device.displayNames", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.device.displayNames",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.device.formFactors", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.device.formFactors",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.interval.endTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.interval.endTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.interval.startTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.interval.startTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.issue.content", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.issue.content",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.issue.errorTypes", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.issue.errorTypes",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.issue.id", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.issue.id",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.issue.signals", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.issue.signals",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.issue.state", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.issue.state",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.issue.states", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.issue.states",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.issue.variantId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.issue.variantId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.operatingSystem.displayNames", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.operatingSystem.displayNames",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.version.displayNames", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.version.displayNames",
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
                        RequestParameters.Add("readMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "readMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>Gets the Issues resource.</summary>
            public virtual IssuesResource Issues { get; }

            /// <summary>The "issues" collection of methods.</summary>
            public class IssuesResource
            {
                private const string Resource = "issues";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public IssuesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Notes = new NotesResource(service);
                }

                /// <summary>Gets the Notes resource.</summary>
                public virtual NotesResource Notes { get; }

                /// <summary>The "notes" collection of methods.</summary>
                public class NotesResource
                {
                    private const string Resource = "notes";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public NotesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Create a new note for an issue.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The parent resource where this note will be created. Format:
                    /// "projects/{project}/apps/{app}/issues/{issue}".
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.FirebaseCrashlytics.v1alpha.Data.Note body, string parent)
                    {
                        return new CreateRequest(this.service, body, parent);
                    }

                    /// <summary>Create a new note for an issue.</summary>
                    public class CreateRequest : FirebaseCrashlyticsBaseServiceRequest<Google.Apis.FirebaseCrashlytics.v1alpha.Data.Note>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseCrashlytics.v1alpha.Data.Note body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The parent resource where this note will be created. Format:
                        /// "projects/{project}/apps/{app}/issues/{issue}".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.FirebaseCrashlytics.v1alpha.Data.Note Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/notes";

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
                                Pattern = @"^projects/[^/]+/apps/[^/]+/issues/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Delete a note by its name.</summary>
                    /// <param name="name">
                    /// Required. The name of the note to delete. Format:
                    /// projects/{project}/apps/{app}/issues/{issue}/notes/{note}.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(this.service, name);
                    }

                    /// <summary>Delete a note by its name.</summary>
                    public class DeleteRequest : FirebaseCrashlyticsBaseServiceRequest<Google.Apis.FirebaseCrashlytics.v1alpha.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the note to delete. Format:
                        /// projects/{project}/apps/{app}/issues/{issue}/notes/{note}.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+name}";

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
                                Pattern = @"^projects/[^/]+/apps/[^/]+/issues/[^/]+/notes/[^/]+$",
                            });
                        }
                    }

                    /// <summary>List all notes for a certain issue, sorted in descending order by timestamp.</summary>
                    /// <param name="parent">
                    /// Required. The issue the notes belongs to. Format:
                    /// "projects/{project}/apps/{app}/issues/{issue}".
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(this.service, parent);
                    }

                    /// <summary>List all notes for a certain issue, sorted in descending order by timestamp.</summary>
                    public class ListRequest : FirebaseCrashlyticsBaseServiceRequest<Google.Apis.FirebaseCrashlytics.v1alpha.Data.ListNotesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The issue the notes belongs to. Format:
                        /// "projects/{project}/apps/{app}/issues/{issue}".
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. The maximum number of notes per page. If omitted, defaults to 10.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>Optional. A page token, received from a previous calls.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1alpha/{+parent}/notes";

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
                                Pattern = @"^projects/[^/]+/apps/[^/]+/issues/[^/]+$",
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

                /// <summary>
                /// Change the state of a group of issues. This method is not atomic, so partial failures can occur. In
                /// the event of a partial failure, the request will fail and you will need to call `GetIssue` to see
                /// which issues were not updated.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The parent resource shared by all issues being updated. Format:
                /// projects/{project}/apps/{app}. If this is set, the parent field in the UpdateIssueRequest messages
                /// must either be empty or match this field.
                /// </param>
                public virtual BatchUpdateRequest BatchUpdate(Google.Apis.FirebaseCrashlytics.v1alpha.Data.BatchUpdateIssuesRequest body, string parent)
                {
                    return new BatchUpdateRequest(this.service, body, parent);
                }

                /// <summary>
                /// Change the state of a group of issues. This method is not atomic, so partial failures can occur. In
                /// the event of a partial failure, the request will fail and you will need to call `GetIssue` to see
                /// which issues were not updated.
                /// </summary>
                public class BatchUpdateRequest : FirebaseCrashlyticsBaseServiceRequest<Google.Apis.FirebaseCrashlytics.v1alpha.Data.BatchUpdateIssuesResponse>
                {
                    /// <summary>Constructs a new BatchUpdate request.</summary>
                    public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseCrashlytics.v1alpha.Data.BatchUpdateIssuesRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The parent resource shared by all issues being updated. Format:
                    /// projects/{project}/apps/{app}. If this is set, the parent field in the UpdateIssueRequest
                    /// messages must either be empty or match this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseCrashlytics.v1alpha.Data.BatchUpdateIssuesRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "batchUpdate";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/issues:batchUpdate";

                    /// <summary>Initializes BatchUpdate parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieve an issue.</summary>
                /// <param name="name">
                /// Required. The name of the issue to retrieve. Format: "projects/{project}/apps/{app}/issues/{issue}".
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Retrieve an issue.</summary>
                public class GetRequest : FirebaseCrashlyticsBaseServiceRequest<Google.Apis.FirebaseCrashlytics.v1alpha.Data.Issue>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the issue to retrieve. Format:
                    /// "projects/{project}/apps/{app}/issues/{issue}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/apps/[^/]+/issues/[^/]+$",
                        });
                    }
                }

                /// <summary>Change the state of an issue.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. Output only. Immutable. Identifier. The name of the issue resource. Format:
                /// "projects/{project}/apps/{app}/issues/{issue}".
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.FirebaseCrashlytics.v1alpha.Data.Issue body, string name)
                {
                    return new PatchRequest(this.service, body, name);
                }

                /// <summary>Change the state of an issue.</summary>
                public class PatchRequest : FirebaseCrashlyticsBaseServiceRequest<Google.Apis.FirebaseCrashlytics.v1alpha.Data.Issue>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.FirebaseCrashlytics.v1alpha.Data.Issue body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Output only. Immutable. Identifier. The name of the issue resource. Format:
                    /// "projects/{project}/apps/{app}/issues/{issue}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. The list of Issue fields to update. Currently only "state" is mutable.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.FirebaseCrashlytics.v1alpha.Data.Issue Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/apps/[^/]+/issues/[^/]+$",
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
                }

                /// <summary>Get a report with its computed results.</summary>
                /// <param name="name">
                /// Required. The report name. Format: "projects/{project}/apps/{app_id}/reports/{report}".
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Get a report with its computed results.</summary>
                public class GetRequest : FirebaseCrashlyticsBaseServiceRequest<Google.Apis.FirebaseCrashlytics.v1alpha.Data.Report>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The report name. Format: "projects/{project}/apps/{app_id}/reports/{report}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Optional. Only count events from the given browser. This string matches Browser.display_name.
                    /// Format: "name (display_version)" e.g. "Chrome (123)", or just "name" for all possible versions,
                    /// e.g. simply "Chrome".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.browser.displayNames", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> FilterBrowserDisplayNames { get; set; }

                    /// <summary>
                    /// Only counts events from the given Device model. This string matches Device.display_name. Format:
                    /// "manufacturer (model)" e.g. "Google (Pixel 6)", or just "manufacturer" for all possible models,
                    /// e.g. simply "Google". Note that a device's marketing_name field can not be used for filtering.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.device.displayNames", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> FilterDeviceDisplayNames { get; set; }

                    /// <summary>
                    /// Only counts events from devices with the given form factor (e.g. phone or tablet).
                    /// </summary>
                    /// <remarks>
                    /// Use this property to set a single value for the parameter, or
                    /// <see cref="FilterDeviceFormFactorsList"/> to set multiple values. Do not set both properties.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("filter.device.formFactors", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<FilterDeviceFormFactorsEnum> FilterDeviceFormFactors { get; set; }

                    /// <summary>
                    /// Only counts events from devices with the given form factor (e.g. phone or tablet).
                    /// </summary>
                    /// <remarks>
                    /// Use this property to set one or more values for the parameter. Do not set both this property and
                    /// <see cref="FilterDeviceFormFactors"/>.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("filter.device.formFactors", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<FilterDeviceFormFactorsEnum> FilterDeviceFormFactorsList { get; set; }

                    /// <summary>
                    /// Only counts events from devices with the given form factor (e.g. phone or tablet).
                    /// </summary>
                    public enum FilterDeviceFormFactorsEnum
                    {
                        /// <summary>Unknown.</summary>
                        [Google.Apis.Util.StringValueAttribute("FORM_FACTOR_UNSPECIFIED")]
                        FORMFACTORUNSPECIFIED = 0,

                        /// <summary>
                        /// Includes mobile phones, small foldables and other form factors not fitting the other
                        /// categories.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("PHONE")]
                        PHONE = 1,

                        /// <summary>Includes tablets and larger foldables.</summary>
                        [Google.Apis.Util.StringValueAttribute("TABLET")]
                        TABLET = 2,

                        /// <summary>Includes desktops, laptops, Chromebooks, etc.</summary>
                        [Google.Apis.Util.StringValueAttribute("DESKTOP")]
                        DESKTOP = 3,

                        /// <summary>Includes televisions and set-tops.</summary>
                        [Google.Apis.Util.StringValueAttribute("TV")]
                        TV = 4,

                        /// <summary>Includes both watches and other wearables.</summary>
                        [Google.Apis.Util.StringValueAttribute("WATCH")]
                        WATCH = 5,
                    }

                    private object _filterIntervalEndTime;

                    /// <summary>
                    /// String representation of <see cref="FilterIntervalEndTimeDateTimeOffset"/>, formatted for
                    /// inclusion in the HTTP request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.interval.endTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FilterIntervalEndTimeRaw { get; private set; }

                    /// <summary>
                    /// <seealso cref="object"/> representation of <see cref="FilterIntervalEndTimeRaw"/>.
                    /// </summary>
                    [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FilterIntervalEndTimeDateTimeOffset instead.")]
                    public virtual object FilterIntervalEndTime
                    {
                        get => _filterIntervalEndTime;
                        set
                        {
                            FilterIntervalEndTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                            _filterIntervalEndTime = value;
                        }
                    }

                    public virtual System.DateTimeOffset? FilterIntervalEndTimeDateTimeOffset
                    {
                        get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FilterIntervalEndTimeRaw);
                        set
                        {
                            FilterIntervalEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                            _filterIntervalEndTime = value;
                        }
                    }

                    private object _filterIntervalStartTime;

                    /// <summary>
                    /// String representation of <see cref="FilterIntervalStartTimeDateTimeOffset"/>, formatted for
                    /// inclusion in the HTTP request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.interval.startTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FilterIntervalStartTimeRaw { get; private set; }

                    /// <summary>
                    /// <seealso cref="object"/> representation of <see cref="FilterIntervalStartTimeRaw"/>.
                    /// </summary>
                    [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FilterIntervalStartTimeDateTimeOffset instead.")]
                    public virtual object FilterIntervalStartTime
                    {
                        get => _filterIntervalStartTime;
                        set
                        {
                            FilterIntervalStartTimeRaw = Google.Apis.Util.Utilities.ConvertToString(value);
                            _filterIntervalStartTime = value;
                        }
                    }

                    public virtual System.DateTimeOffset? FilterIntervalStartTimeDateTimeOffset
                    {
                        get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FilterIntervalStartTimeRaw);
                        set
                        {
                            FilterIntervalStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
                            _filterIntervalStartTime = value;
                        }
                    }

                    /// <summary>
                    /// Optional. A space separated list of filter terms matched against the contents of the issue.
                    /// Contents include the title and the stack trace. Matches must begin at alphanumeric tokens, i.e.,
                    /// 'util.Sorted' matches 'java.util.SortedSet' but not 'myutil.SortedArray'. The filter matches if
                    /// all filter terms match. All non-alphanumeric characters are ignored for matching. Filtering is
                    /// assumed to be prefix-search and order-independent unless phrases are surrounded by "". Any terms
                    /// contained in quotes are searched using exact-match (given filter term "foo", we will not return
                    /// "foobar"), and must appear in the order given exactly. To get order-dependence but
                    /// prefix-search, use a * within the quotes ("abc foo*" will match "abc foobar", but not "foo abc"
                    /// "abcd foobar", or "abc xyz foobar").
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.content", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FilterIssueContent { get; set; }

                    /// <summary>
                    /// Optional. Only counts events of the given error types. This field matches [Issue.error_type].
                    /// </summary>
                    /// <remarks>
                    /// Use this property to set a single value for the parameter, or
                    /// <see cref="FilterIssueErrorTypesList"/> to set multiple values. Do not set both properties.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.errorTypes", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<FilterIssueErrorTypesEnum> FilterIssueErrorTypes { get; set; }

                    /// <summary>
                    /// Optional. Only counts events of the given error types. This field matches [Issue.error_type].
                    /// </summary>
                    /// <remarks>
                    /// Use this property to set one or more values for the parameter. Do not set both this property and
                    /// <see cref="FilterIssueErrorTypes"/>.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.errorTypes", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<FilterIssueErrorTypesEnum> FilterIssueErrorTypesList { get; set; }

                    /// <summary>
                    /// Optional. Only counts events of the given error types. This field matches [Issue.error_type].
                    /// </summary>
                    public enum FilterIssueErrorTypesEnum
                    {
                        /// <summary>Unknown.</summary>
                        [Google.Apis.Util.StringValueAttribute("ERROR_TYPE_UNSPECIFIED")]
                        ERRORTYPEUNSPECIFIED = 0,

                        /// <summary>Fatal crash event.</summary>
                        [Google.Apis.Util.StringValueAttribute("FATAL")]
                        FATAL = 1,

                        /// <summary>Non-fatal event, such as a caught Java exception or NSError on iOS.</summary>
                        [Google.Apis.Util.StringValueAttribute("NON_FATAL")]
                        NONFATAL = 2,

                        /// <summary>Application not responding error, Android only.</summary>
                        [Google.Apis.Util.StringValueAttribute("ANR")]
                        ANR = 3,
                    }

                    /// <summary>
                    /// Optional. Only counts events in the given issue ID. This field matches [Issue.id].
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.id", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FilterIssueId { get; set; }

                    /// <summary>
                    /// Optional. Only returns issues currently marked with the given signals. This field matches
                    /// [Issue.signals.signal].
                    /// </summary>
                    /// <remarks>
                    /// Use this property to set a single value for the parameter, or
                    /// <see cref="FilterIssueSignalsList"/> to set multiple values. Do not set both properties.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.signals", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<FilterIssueSignalsEnum> FilterIssueSignals { get; set; }

                    /// <summary>
                    /// Optional. Only returns issues currently marked with the given signals. This field matches
                    /// [Issue.signals.signal].
                    /// </summary>
                    /// <remarks>
                    /// Use this property to set one or more values for the parameter. Do not set both this property and
                    /// <see cref="FilterIssueSignals"/>.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.signals", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<FilterIssueSignalsEnum> FilterIssueSignalsList { get; set; }

                    /// <summary>
                    /// Optional. Only returns issues currently marked with the given signals. This field matches
                    /// [Issue.signals.signal].
                    /// </summary>
                    public enum FilterIssueSignalsEnum
                    {
                        /// <summary>Default.</summary>
                        [Google.Apis.Util.StringValueAttribute("SIGNAL_UNSPECIFIED")]
                        SIGNALUNSPECIFIED = 0,

                        /// <summary>Indicates an issue that is impacting end users early in the app session.</summary>
                        [Google.Apis.Util.StringValueAttribute("SIGNAL_EARLY")]
                        SIGNALEARLY = 1,

                        /// <summary>Indicates newly detected issues.</summary>
                        [Google.Apis.Util.StringValueAttribute("SIGNAL_FRESH")]
                        SIGNALFRESH = 2,

                        /// <summary>Indicates previously closed issues which have been detected again.</summary>
                        [Google.Apis.Util.StringValueAttribute("SIGNAL_REGRESSED")]
                        SIGNALREGRESSED = 3,

                        /// <summary>Indicates issues impacting some end users multiple times.</summary>
                        [Google.Apis.Util.StringValueAttribute("SIGNAL_REPETITIVE")]
                        SIGNALREPETITIVE = 4,
                    }

                    /// <summary>
                    /// Optional. Deprecated: Prefer `states` field. Only includes events for issues with the given
                    /// issue state. Only available for `topIssues` reports.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.state", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<FilterIssueStateEnum> FilterIssueState { get; set; }

                    /// <summary>
                    /// Optional. Deprecated: Prefer `states` field. Only includes events for issues with the given
                    /// issue state. Only available for `topIssues` reports.
                    /// </summary>
                    public enum FilterIssueStateEnum
                    {
                        /// <summary>Unknown.</summary>
                        [Google.Apis.Util.StringValueAttribute("STATE_UNSPECIFIED")]
                        STATEUNSPECIFIED = 0,

                        /// <summary>Ongoing issue.</summary>
                        [Google.Apis.Util.StringValueAttribute("OPEN")]
                        OPEN = 1,

                        /// <summary>Issue resolved.</summary>
                        [Google.Apis.Util.StringValueAttribute("CLOSED")]
                        CLOSED = 2,

                        /// <summary>Issue muted. No alerts will be fired for this issue.</summary>
                        [Google.Apis.Util.StringValueAttribute("MUTED")]
                        MUTED = 3,
                    }

                    /// <summary>
                    /// Optional. Only includes events for issues with the given issue states. Only available for
                    /// `topIssues` reports.
                    /// </summary>
                    /// <remarks>
                    /// Use this property to set a single value for the parameter, or
                    /// <see cref="FilterIssueStatesList"/> to set multiple values. Do not set both properties.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.states", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<FilterIssueStatesEnum> FilterIssueStates { get; set; }

                    /// <summary>
                    /// Optional. Only includes events for issues with the given issue states. Only available for
                    /// `topIssues` reports.
                    /// </summary>
                    /// <remarks>
                    /// Use this property to set one or more values for the parameter. Do not set both this property and
                    /// <see cref="FilterIssueStates"/>.
                    /// </remarks>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.states", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<FilterIssueStatesEnum> FilterIssueStatesList { get; set; }

                    /// <summary>
                    /// Optional. Only includes events for issues with the given issue states. Only available for
                    /// `topIssues` reports.
                    /// </summary>
                    public enum FilterIssueStatesEnum
                    {
                        /// <summary>Unknown.</summary>
                        [Google.Apis.Util.StringValueAttribute("STATE_UNSPECIFIED")]
                        STATEUNSPECIFIED = 0,

                        /// <summary>Ongoing issue.</summary>
                        [Google.Apis.Util.StringValueAttribute("OPEN")]
                        OPEN = 1,

                        /// <summary>Issue resolved.</summary>
                        [Google.Apis.Util.StringValueAttribute("CLOSED")]
                        CLOSED = 2,

                        /// <summary>Issue muted. No alerts will be fired for this issue.</summary>
                        [Google.Apis.Util.StringValueAttribute("MUTED")]
                        MUTED = 3,
                    }

                    /// <summary>
                    /// Optional. Only counts events for the given issue variant ID. This field matches
                    /// [IssueVariant.id].
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.issue.variantId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FilterIssueVariantId { get; set; }

                    /// <summary>
                    /// Only counts events in the given operating system and version. This string matches
                    /// OperatingSystem.display_name. Format: "osName (osVersion)" e.g. "Android (11)". or just "osName"
                    /// for all versions, e.g. simply "iPadOS".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.operatingSystem.displayNames", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> FilterOperatingSystemDisplayNames { get; set; }

                    /// <summary>
                    /// Only counts events in the given app version. This string matches Version.display_name. Format:
                    /// "display_version (build_version)" e.g. "1.2.3 (456)".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter.version.displayNames", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual Google.Apis.Util.Repeatable<string> FilterVersionDisplayNames { get; set; }

                    /// <summary>
                    /// Optional. The report response will contain one data point per time grain. If omitted, the report
                    /// will contain a single data point for the complete interval.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("granularity", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<GranularityEnum> Granularity { get; set; }

                    /// <summary>
                    /// Optional. The report response will contain one data point per time grain. If omitted, the report
                    /// will contain a single data point for the complete interval.
                    /// </summary>
                    public enum GranularityEnum
                    {
                        /// <summary>Unknown.</summary>
                        [Google.Apis.Util.StringValueAttribute("TIME_GRANULARITY_UNSPECIFIED")]
                        TIMEGRANULARITYUNSPECIFIED = 0,

                        /// <summary>Returns a single interval for the requested time range.</summary>
                        [Google.Apis.Util.StringValueAttribute("TIME_GRANULARITY_NONE")]
                        TIMEGRANULARITYNONE = 1,

                        /// <summary>Hour.</summary>
                        [Google.Apis.Util.StringValueAttribute("TIME_GRANULARITY_HOUR")]
                        TIMEGRANULARITYHOUR = 2,

                        /// <summary>Day.</summary>
                        [Google.Apis.Util.StringValueAttribute("TIME_GRANULARITY_DAY")]
                        TIMEGRANULARITYDAY = 3,
                    }

                    /// <summary>
                    /// Optional. The maximum number of result groups to return. If omitted, defaults to 25.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// Optional. A page token, received from a previous call. The page token is only valid for the
                    /// exact same set of filters, which must also be sent in subsequent requests. This token is valid
                    /// for 10 minutes after the first request.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

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
                            Pattern = @"^projects/[^/]+/apps/[^/]+/reports/[^/]+$",
                        });
                        RequestParameters.Add("filter.browser.displayNames", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.browser.displayNames",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.device.displayNames", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.device.displayNames",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.device.formFactors", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.device.formFactors",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.interval.endTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.interval.endTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.interval.startTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.interval.startTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.issue.content", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.issue.content",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.issue.errorTypes", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.issue.errorTypes",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.issue.id", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.issue.id",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.issue.signals", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.issue.signals",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.issue.state", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.issue.state",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.issue.states", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.issue.states",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.issue.variantId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.issue.variantId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.operatingSystem.displayNames", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.operatingSystem.displayNames",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter.version.displayNames", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter.version.displayNames",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("granularity", new Google.Apis.Discovery.Parameter
                        {
                            Name = "granularity",
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

                /// <summary>List all of the available reports.</summary>
                /// <param name="parent">
                /// Required. The firebase application. Format: "projects/{project}/apps/{app_id}".
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>List all of the available reports.</summary>
                public class ListRequest : FirebaseCrashlyticsBaseServiceRequest<Google.Apis.FirebaseCrashlytics.v1alpha.Data.ListReportsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The firebase application. Format: "projects/{project}/apps/{app_id}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+parent}/reports";

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
                            Pattern = @"^projects/[^/]+/apps/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets the Users resource.</summary>
            public virtual UsersResource Users { get; }

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

                /// <summary>
                /// Enqueues a request to permanently remove crash reports associated with the specified user. All
                /// reports belonging to the specified user will be deleted typically within 24 hours of receiving the
                /// crash report.
                /// </summary>
                /// <param name="name">
                /// Required. Resource name for user reports, in the format: projects/
                /// PROJECT_IDENTIFIER/apps/APP_ID/users/USER_ID/crashReports - PROJECT_IDENTIFIER: The Firebase
                /// project's project number (recommended) or its project ID. Learn more about using project identifiers
                /// in Google's [AIP 2510 standard](https://google.aip.dev/cloud/2510). - APP_ID: The globally unique,
                /// Firebase-assigned identifier for the Firebase App. This is not your package name or bundle ID. Learn
                /// how to [find your app ID](https://firebase.google.com/support/faq/#find-app-id). - USER_ID: The user
                /// ID set using the Crashlytics SDK. Learn how to [set user
                /// identifiers](https://firebase.google.com/docs/crashlytics/customize-crash-reports#set-user-ids).
                /// </param>
                public virtual DeleteCrashReportsRequest DeleteCrashReports(string name)
                {
                    return new DeleteCrashReportsRequest(this.service, name);
                }

                /// <summary>
                /// Enqueues a request to permanently remove crash reports associated with the specified user. All
                /// reports belonging to the specified user will be deleted typically within 24 hours of receiving the
                /// crash report.
                /// </summary>
                public class DeleteCrashReportsRequest : FirebaseCrashlyticsBaseServiceRequest<Google.Apis.FirebaseCrashlytics.v1alpha.Data.DeleteUserCrashReportsResponse>
                {
                    /// <summary>Constructs a new DeleteCrashReports request.</summary>
                    public DeleteCrashReportsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name for user reports, in the format: projects/
                    /// PROJECT_IDENTIFIER/apps/APP_ID/users/USER_ID/crashReports - PROJECT_IDENTIFIER: The Firebase
                    /// project's project number (recommended) or its project ID. Learn more about using project
                    /// identifiers in Google's [AIP 2510 standard](https://google.aip.dev/cloud/2510). - APP_ID: The
                    /// globally unique, Firebase-assigned identifier for the Firebase App. This is not your package
                    /// name or bundle ID. Learn how to [find your app
                    /// ID](https://firebase.google.com/support/faq/#find-app-id). - USER_ID: The user ID set using the
                    /// Crashlytics SDK. Learn how to [set user
                    /// identifiers](https://firebase.google.com/docs/crashlytics/customize-crash-reports#set-user-ids).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "deleteCrashReports";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

                    /// <summary>Initializes DeleteCrashReports parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/apps/[^/]+/users/[^/]+/crashReports$",
                        });
                    }
                }
            }
        }
    }
}
namespace Google.Apis.FirebaseCrashlytics.v1alpha.Data
{
    /// <summary>Response message for the BatchGetEvents method.</summary>
    public class BatchGetEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of retrieved events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<Event> Events { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the BatchUpdateIssues method.</summary>
    public class BatchUpdateIssuesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The request message specifying the resources to update. A maximum of 100 issues can be modified in
        /// a batch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<UpdateIssueRequest> Requests { get; set; }

        /// <summary>
        /// Optional. The list of Issue fields to update. If this is set, the update_mask field in the
        /// UpdateIssueRequest messages must either be empty or match this field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the BatchUpdateIssues method.</summary>
    public class BatchUpdateIssuesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Issues updated in the same order as in BatchUpdateIssuesRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issues")]
        public virtual System.Collections.Generic.IList<Issue> Issues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Analytics events recorded during the session.</summary>
    public class Breadcrumb : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>Device timestamp for the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Event parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string, string> Params__ { get; set; }

        /// <summary>Analytic event name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Web browser metadata.</summary>
    public class Browser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Browser name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("browser")]
        public virtual string BrowserValue { get; set; }

        /// <summary>Browser name and version number. Formatted to be suitable for passing to BrowserFilter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Browser display version number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayVersion")]
        public virtual string DisplayVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for the DeleteUserCrashReports method. All crash reports associated with the specified user
    /// will be deleted typically within 24 hours of receiving the crash report.
    /// </summary>
    public class DeleteUserCrashReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _targetCompleteTimeRaw;

        private object _targetCompleteTime;

        /// <summary>Target time to complete the delete crash reports operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetCompleteTime")]
        public virtual string TargetCompleteTimeRaw
        {
            get => _targetCompleteTimeRaw;
            set
            {
                _targetCompleteTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _targetCompleteTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="TargetCompleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TargetCompleteTimeDateTimeOffset instead.")]
        public virtual object TargetCompleteTime
        {
            get => _targetCompleteTime;
            set
            {
                _targetCompleteTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _targetCompleteTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="TargetCompleteTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TargetCompleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(TargetCompleteTimeRaw);
            set => TargetCompleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mobile device metadata.</summary>
    public class Device : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Device processor architecture.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("architecture")]
        public virtual string Architecture { get; set; }

        /// <summary>
        /// An invariant name of the manufacturer that submitted this product in its most recognizable public form, e.g.
        /// "Google".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("companyName")]
        public virtual string CompanyName { get; set; }

        /// <summary>Full device name, suitable for passing to DeviceFilter. Format: "manufacturer (model)".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>See FormFactor message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formFactor")]
        public virtual string FormFactor { get; set; }

        /// <summary>Device brand name which is consistent with android.os.Build.BRAND.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; }

        /// <summary>Marketing name, most recognizable public form, e.g. "Pixel 6".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marketingName")]
        public virtual string MarketingName { get; set; }

        /// <summary>
        /// The model name which is consistent with android.os.Build.MODEL, e.g. ("SPH-L710", "GT-I9300").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

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

    /// <summary>A non-fatal error and its stacktrace, only from Apple apps.</summary>
    public class Error : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True when the Crashlytics analysis has determined that the stacktrace in this error is where the fault
        /// occurred.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blamed")]
        public virtual System.Nullable<bool> Blamed { get; set; }

        /// <summary>Error code associated with the app's custom logged NSError.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<long> Code { get; set; }

        /// <summary>The frames in the error's stacktrace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<Frame> Frames { get; set; }

        /// <summary>The queue on which the thread was running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queue")]
        public virtual string Queue { get; set; }

        /// <summary>The subtitle of the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; }

        /// <summary>The title of the error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The message describing a single Crashlytics event. Related to BigQuery export schema, which can be found at
    /// [Export Crashlytics data to
    /// BigQuery](https://firebase.google.com/docs/crashlytics/bigquery-export#dataset-schema-crashlytics)
    /// </summary>
    public class Event : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>App orientation at the time of the crash (portrait or landscape).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appOrientation")]
        public virtual string AppOrientation { get; set; }

        /// <summary>
        /// The stack trace frame blamed by Crashlytics processing. May not be present in future analyzer.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blameFrame")]
        public virtual Frame BlameFrame { get; set; }

        /// <summary>Analytics events recorded by the analytics SDK during the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("breadcrumbs")]
        public virtual System.Collections.Generic.IList<Breadcrumb> Breadcrumbs { get; set; }

        /// <summary>Browser and version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("browser")]
        public virtual Browser Browser { get; set; }

        /// <summary>Metadata provided by the app's build system, including version control repository info.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildStamp")]
        public virtual string BuildStamp { get; set; }

        /// <summary>
        /// The bundle name for iOS apps or the package name of Android apps. Format: "com.mycompany.myapp".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bundleOrPackage")]
        public virtual string BundleOrPackage { get; set; }

        /// <summary>Crashlytics SDK version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crashlyticsSdkVersion")]
        public virtual string CrashlyticsSdkVersion { get; set; }

        /// <summary>Custom keys set by the developer during the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customKeys")]
        public virtual System.Collections.Generic.IDictionary<string, string> CustomKeys { get; set; }

        /// <summary>Mobile device metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual Device Device { get; set; }

        /// <summary>Device orientation at the time of the crash (portrait or landscape).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceOrientation")]
        public virtual string DeviceOrientation { get; set; }

        /// <summary>Apple only. A non-fatal error captured by the iOS SDK and its stacktrace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Collections.Generic.IList<Error> Errors { get; set; }

        /// <summary>Output only. Immutable. The unique event identifier is assigned during processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventId")]
        public virtual string EventId { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>Device timestamp that the event was recorded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Android and web only. Exceptions that occurred during this event. Nested exceptions are presented in reverse
        /// chronological order, so that the last record is the first exception thrown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exceptions")]
        public virtual System.Collections.Generic.IList<Exception> Exceptions { get; set; }

        /// <summary>
        /// Unique identifier for the device-app installation. This field is used to compute the unique number of
        /// impacted users.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("installationUuid")]
        public virtual string InstallationUuid { get; set; }

        /// <summary>Details for the [Issue] assigned to this [Event].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issue")]
        public virtual Issue Issue { get; set; }

        /// <summary>
        /// The subtitle of the issue in which the event was grouped. This is usually a symbol or an exception message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueSubtitle")]
        public virtual string IssueSubtitle { get; set; }

        /// <summary>
        /// The title of the issue in which the event was grouped. This is usually a source file or method name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueTitle")]
        public virtual string IssueTitle { get; set; }

        /// <summary>Details for the [IssueVariant] assigned to this [Event].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issueVariant")]
        public virtual IssueVariant IssueVariant { get; set; }

        /// <summary>Log messages recorded by the developer during the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logs")]
        public virtual System.Collections.Generic.IList<Log> Logs { get; set; }

        /// <summary>Mobile device memory usage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memory")]
        public virtual Memory Memory { get; set; }

        /// <summary>
        /// Required. Output only. Immutable. Identifier. The name of the event resource. Format:
        /// "projects/{project}/apps/{app_id}/events/{event}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Operating system and version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystem")]
        public virtual OperatingSystem OperatingSystem { get; set; }

        /// <summary>ANDROID, IOS, or WEB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; }

        /// <summary>The state of the app process at the time of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processState")]
        public virtual string ProcessState { get; set; }

        private string _receivedTimeRaw;

        private object _receivedTime;

        /// <summary>Server timestamp that the event was received by Crashlytics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("receivedTime")]
        public virtual string ReceivedTimeRaw
        {
            get => _receivedTimeRaw;
            set
            {
                _receivedTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _receivedTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReceivedTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReceivedTimeDateTimeOffset instead.")]
        public virtual object ReceivedTime
        {
            get => _receivedTime;
            set
            {
                _receivedTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _receivedTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReceivedTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReceivedTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ReceivedTimeRaw);
            set => ReceivedTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Web only. The route path of the web application when the event occurred, excluding query
        /// parameters and fragment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("routePath")]
        public virtual string RoutePath { get; set; }

        /// <summary>Unique identifier for the Firebase session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionId")]
        public virtual string SessionId { get; set; }

        /// <summary>Mobile device disk/flash usage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storage")]
        public virtual Storage Storage { get; set; }

        /// <summary>
        /// Application threads present at the time the event was recorded. Each contains a stacktrace. One thread will
        /// be blamed for the error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threads")]
        public virtual System.Collections.Generic.IList<Thread> Threads { get; set; }

        /// <summary>End user identifiers for the device owner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual User User { get; set; }

        /// <summary>Mobile application version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual Version Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Java or Javascript exception and its stacktrace. Only from Android or web apps.</summary>
    public class Exception : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True when the Crashlytics analysis has determined that this thread is where the fault occurred.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blamed")]
        public virtual System.Nullable<bool> Blamed { get; set; }

        /// <summary>A message associated with the exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exceptionMessage")]
        public virtual string ExceptionMessage { get; set; }

        /// <summary>The frames in the exception's stacktrace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<Frame> Frames { get; set; }

        /// <summary>True for all but the last-thrown exception (i.e. the first record).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nested")]
        public virtual System.Nullable<bool> Nested { get; set; }

        /// <summary>The subtitle of the exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; }

        /// <summary>The title of the exception.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The exception type e.g. java.lang.IllegalStateException.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sessions recorded by the Firebase App Quality Sessions SDK.</summary>
    public class FirebaseSessionEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Mobile device metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual Device Device { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>The start timestamp for the session event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Session event type. The SDK only supports SESSION_START events at this time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
        public virtual string EventType { get; set; }

        /// <summary>Uniquely identifies a device with Firebase apps installed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firebaseInstallationId")]
        public virtual string FirebaseInstallationId { get; set; }

        /// <summary>
        /// The identifier of the first session since the last cold start. This id and the session_id will be the same
        /// for app launches.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstSessionId")]
        public virtual string FirstSessionId { get; set; }

        /// <summary>Operating system and version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystem")]
        public virtual OperatingSystem OperatingSystem { get; set; }

        /// <summary>Unique identifier for the Firebase session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionId")]
        public virtual string SessionId { get; set; }

        /// <summary>Indicates the number of sessions since the last cold start.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionIndex")]
        public virtual System.Nullable<int> SessionIndex { get; set; }

        /// <summary>Mobile application version numbers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual Version Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A frame in a stacktrace.</summary>
    public class Frame : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The address in the binary image which contains the code. Present for native frames.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual System.Nullable<long> Address { get; set; }

        /// <summary>
        /// True when the Crashlytics analysis has determined that this frame is likely to be the cause of the error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blamed")]
        public virtual System.Nullable<bool> Blamed { get; set; }

        /// <summary>The column on the line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("column")]
        public virtual System.Nullable<long> Column { get; set; }

        /// <summary>The name of the source file in which the frame is found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("file")]
        public virtual string File { get; set; }

        /// <summary>The display name of the library that includes the frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("library")]
        public virtual string Library { get; set; }

        /// <summary>The line number in the file of the frame.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("line")]
        public virtual System.Nullable<long> Line { get; set; }

        /// <summary>The byte offset into the binary image that contains the code. Present for native frames.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offset")]
        public virtual System.Nullable<long> Offset { get; set; }

        /// <summary>One of DEVELOPER, VENDOR, RUNTIME, PLATFORM, or SYSTEM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("owner")]
        public virtual string Owner { get; set; }

        /// <summary>
        /// The frame symbol after it has been deobfuscated or symbolicated. The raw symbol from the device if it could
        /// not be hydrated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("symbol")]
        public virtual string Symbol { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A set of computed metric values for a time interval</summary>
    public class IntervalMetrics : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>The end of the interval covered by the computation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual string EndTimeRaw
        {
            get => _endTimeRaw;
            set
            {
                _endTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _endTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EndTimeDateTimeOffset instead.")]
        public virtual object EndTime
        {
            get => _endTime;
            set
            {
                _endTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _endTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EndTimeRaw);
            set => EndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>The total count of events in the interval.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventsCount")]
        public virtual System.Nullable<long> EventsCount { get; set; }

        /// <summary>The number of distinct users in the set of events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impactedUsersCount")]
        public virtual System.Nullable<long> ImpactedUsersCount { get; set; }

        /// <summary>The number of distinct sessions in the set of events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionsCount")]
        public virtual System.Nullable<long> SessionsCount { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>The start of the interval covered by the computation.</summary>
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

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An issue describes a set of similar events that have been analyzed by Crashlytics and grouped together. All
    /// events within an issue will be of the same error_type: crash, non-fatal exception or ANR. All events within an
    /// issue will contain similar stack traces in their blamed thread.
    /// </summary>
    public class Issue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Immutable. Indicates whether this issue is a crash, non-fatal exception, or ANR.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorType")]
        public virtual string ErrorType { get; set; }

        private string _firstSeenTimeRaw;

        private object _firstSeenTime;

        /// <summary>Output only. Immutable. The first time this issue was seen.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstSeenTime")]
        public virtual string FirstSeenTimeRaw
        {
            get => _firstSeenTimeRaw;
            set
            {
                _firstSeenTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _firstSeenTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="FirstSeenTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use FirstSeenTimeDateTimeOffset instead.")]
        public virtual object FirstSeenTime
        {
            get => _firstSeenTime;
            set
            {
                _firstSeenTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _firstSeenTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="FirstSeenTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? FirstSeenTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(FirstSeenTimeRaw);
            set => FirstSeenTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Immutable. The first app display_version in which this issue was seen, populated for mobile
        /// issues only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstSeenVersion")]
        public virtual string FirstSeenVersion { get; set; }

        /// <summary>Output only. Immutable. Unique identifier for the issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        private string _lastSeenTimeRaw;

        private object _lastSeenTime;

        /// <summary>Output only. The most recent time this issue was seen.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSeenTime")]
        public virtual string LastSeenTimeRaw
        {
            get => _lastSeenTimeRaw;
            set
            {
                _lastSeenTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _lastSeenTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LastSeenTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LastSeenTimeDateTimeOffset instead.")]
        public virtual object LastSeenTime
        {
            get => _lastSeenTime;
            set
            {
                _lastSeenTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _lastSeenTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="LastSeenTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LastSeenTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LastSeenTimeRaw);
            set => LastSeenTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. The most recent app display_version in which this issue was seen, populated for mobile issues
        /// only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSeenVersion")]
        public virtual string LastSeenVersion { get; set; }

        /// <summary>
        /// Required. Output only. Immutable. Identifier. The name of the issue resource. Format:
        /// "projects/{project}/apps/{app}/issues/{issue}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The number of notes attached to an issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notesCount")]
        public virtual System.Nullable<long> NotesCount { get; set; }

        /// <summary>Output only. The resource name for a sample event in this issue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleEvent")]
        public virtual string SampleEvent { get; set; }

        /// <summary>Output only. Immutable. Distinctive characteristics assigned by the Crashlytics analyzer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signals")]
        public virtual System.Collections.Generic.IList<IssueSignals> Signals { get; set; }

        /// <summary>
        /// Output only. Indicates whether this issue is open, closed or muted. For details on how issue states change
        /// without user actions, see [Regressed
        /// Issues](https://firebase.google.com/docs/crashlytics/troubleshooting?platform=ios#regressed-issues).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        private string _stateUpdateTimeRaw;

        private object _stateUpdateTime;

        /// <summary>Output only. The time at which the issue state was last changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateUpdateTime")]
        public virtual string StateUpdateTimeRaw
        {
            get => _stateUpdateTimeRaw;
            set
            {
                _stateUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _stateUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StateUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StateUpdateTimeDateTimeOffset instead.")]
        public virtual object StateUpdateTime
        {
            get => _stateUpdateTime;
            set
            {
                _stateUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _stateUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="StateUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StateUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(StateUpdateTimeRaw);
            set => StateUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Immutable. Caption subtitle. This is usually a symbol or an exception message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; }

        /// <summary>Output only. Immutable. Caption title. This is usually a source file or method name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Output only. Provides a link to the Issue on the Firebase console. When this Issue is obtained as part of a
        /// Report, then the link will be configured with the same time interval and filters as the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>
        /// Output only. Immutable. The top 12 variants (subgroups) within the issue. Variants group events within an
        /// issue that are very similar. A single result implies that the variant is the same as the parent issue. This
        /// field will be empty when multiple issues are requested. Request a single issue to list variants.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variants")]
        public virtual System.Collections.Generic.IList<IssueVariant> Variants { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Distinctive characteristics assigned by the Crashlytics analyzer.</summary>
    public class IssueSignals : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Supporting detail information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Output only. The signal name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signal")]
        public virtual string Signal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A variant is a subgroup of an issue where all events have very similar stack traces. Issues may contain one or
    /// more variants.
    /// </summary>
    public class IssueVariant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Immutable. Distinct identifier for the variant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Output only. The resource name for a sample event in this variant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleEvent")]
        public virtual string SampleEvent { get; set; }

        /// <summary>
        /// Output only. Provides a link to the variant on the Firebase console. When this variant is obtained as part
        /// of a Report, then the link will be configured with the same time interval and filters as the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListEvents method.</summary>
    public class ListEventsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Returns one element per event, in descending order the by event timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<Event> Events { get; set; }

        /// <summary>
        /// A pagination token to retrieve the next page of events. The next page will have earlier or later events
        /// depending on the request's ordering. If this field is not present, there are no subsequent events.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for the ListNotes method.</summary>
    public class ListNotesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A pagination token to retrieve the next page of notes. If this field is not present, there are no subsequent
        /// notes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Returns notes ordered descending by the timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual System.Collections.Generic.IList<Note> Notes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response method for the ListReports method. The response will always include all of the available reports.
    /// </summary>
    public class ListReportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The report objects returned will contain their names and usage instructions, but include no results. Use the
        /// `GetReport` method to run the report and obtain the paged results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reports")]
        public virtual System.Collections.Generic.IList<Report> Reports { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Developer-provided log lines recorded during the session.</summary>
    public class Log : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _logTimeRaw;

        private object _logTime;

        /// <summary>Device timestamp when the line was logged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logTime")]
        public virtual string LogTimeRaw
        {
            get => _logTimeRaw;
            set
            {
                _logTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _logTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LogTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LogTimeDateTimeOffset instead.")]
        public virtual object LogTime
        {
            get => _logTime;
            set
            {
                _logTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _logTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="LogTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LogTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LogTimeRaw);
            set => LogTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>Log message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mobile device memory usage.</summary>
    public class Memory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bytes free.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("free")]
        public virtual System.Nullable<long> Free { get; set; }

        /// <summary>Bytes in use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("used")]
        public virtual System.Nullable<long> Used { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Developer notes for an issue.</summary>
    public class Note : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The email of the author of the note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("author")]
        public virtual string Author { get; set; }

        /// <summary>Immutable. The body of the note.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("body")]
        public virtual string Body { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>Output only. Time when the note was created.</summary>
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
        /// Output only. Identifier. Format: "projects/{project}/apps/app/issues/{issue}/notes/{note}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mobile device operating system metadata.</summary>
    public class OperatingSystem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The device category (mobile, tablet, desktop).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceType")]
        public virtual string DeviceType { get; set; }

        /// <summary>Name and version number. Formatted to be suitable for passing to OperatingSystemFilter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>Operating system display version number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayVersion")]
        public virtual string DisplayVersion { get; set; }

        /// <summary>Indicates if the OS has been modified or "jailbroken".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modificationState")]
        public virtual string ModificationState { get; set; }

        /// <summary>Operating system name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("os")]
        public virtual string Os { get; set; }

        /// <summary>The OS type on Apple platforms (iOS, iPadOS, etc.).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a release track in the Play Developer Console.</summary>
    public class PlayTrack : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User-generated or auto-generated name of the track. PROD and INTERNAL track types always have auto-generated
        /// names, e.g. "prod" and "internal" respectively. Tracks of type EARLY_ACCESS always have a user-generated
        /// name. Other track types do not have any guarantees, might have user-generated or auto-generated names.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The type of track (prod, internal, etc...).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response message for the GetReport method. A report consists of the results of a query over an application's
    /// events. The events may be filtered by various criteria defined in the filters proto. The result will consist of
    /// a number of paginated groups, of a type relevant to the report such as issues or device models.
    /// </summary>
    public class Report : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The displayable title of the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Aggregate event statistics in the report will be grouped by a dimension, such as by issue or by version. The
        /// response contains one element per group, and all ReportGroup messages will have the same parent field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groups")]
        public virtual System.Collections.Generic.IList<ReportGroup> Groups { get; set; }

        /// <summary>The name of the report. Format: "projects/{project}/apps/{app_id}/reports/{report}".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. A page token used to retrieve additional report groups. If this field is not present, there are
        /// no subsequent pages available to retrieve.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Output only. The total number of groups retrievable by the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>
        /// Usage instructions for the report with a description of the result metrics. This field contains a
        /// description of the underlying query and describes the expected response data with any known caveats. This
        /// string can be displayed in the UI of any integration that offers comprehensive access to all Crashlytics
        /// reports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usage")]
        public virtual string Usage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A group of results in an EventReport. In any report, the group_parent field is strictly the same type for all of
    /// the groups in any collection.
    /// </summary>
    public class ReportGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Browser metrics group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("browser")]
        public virtual Browser Browser { get; set; }

        /// <summary>Device metrics group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual Device Device { get; set; }

        /// <summary>Issue metrics group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issue")]
        public virtual Issue Issue { get; set; }

        /// <summary>
        /// Scalar metrics will contain a single object covering the entire interval, while time-dimensioned graphs will
        /// contain one per time grain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<IntervalMetrics> Metrics { get; set; }

        /// <summary>Operating system metrics group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystem")]
        public virtual OperatingSystem OperatingSystem { get; set; }

        /// <summary>
        /// When applicable, this field contains additional nested groupings. For example, events can be grouped by
        /// operating system and by operating system version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subgroups")]
        public virtual System.Collections.Generic.IList<ReportGroup> Subgroups { get; set; }

        /// <summary>Issue variant metrics group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variant")]
        public virtual IssueVariant Variant { get; set; }

        /// <summary>Version metrics group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual Version Version { get; set; }

        /// <summary>Web metrics group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webMetricsGroup")]
        public virtual WebMetricsGroup WebMetricsGroup { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mobile device disk/flash usage. Not reported for all devices.</summary>
    public class Storage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Bytes free.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("free")]
        public virtual System.Nullable<long> Free { get; set; }

        /// <summary>Bytes used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("used")]
        public virtual System.Nullable<long> Used { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An application thread.</summary>
    public class Thread : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True when the Crashlytics analysis has determined that the stacktrace in this thread is where the fault
        /// occurred.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blamed")]
        public virtual System.Nullable<bool> Blamed { get; set; }

        /// <summary>
        /// The address of the signal that caused the application to crash. Only present on crashed native threads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crashAddress")]
        public virtual System.Nullable<long> CrashAddress { get; set; }

        /// <summary>True when the thread has crashed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crashed")]
        public virtual System.Nullable<bool> Crashed { get; set; }

        /// <summary>The frames in the thread's stacktrace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frames")]
        public virtual System.Collections.Generic.IList<Frame> Frames { get; set; }

        /// <summary>The name of the thread.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The queue on which the thread was running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queue")]
        public virtual string Queue { get; set; }

        /// <summary>
        /// The name of the signal that caused the app to crash. Only present on crashed native threads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signal")]
        public virtual string Signal { get; set; }

        /// <summary>
        /// The code of the signal that caused the app to crash. Only present on crashed native threads.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signalCode")]
        public virtual string SignalCode { get; set; }

        /// <summary>The subtitle of the thread.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; }

        /// <summary>The system id of the thread, only available for ANR threads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sysThreadId")]
        public virtual System.Nullable<long> SysThreadId { get; set; }

        /// <summary>The id of the thread, only available for ANR threads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threadId")]
        public virtual System.Nullable<long> ThreadId { get; set; }

        /// <summary>Output only. The state of the thread at the time the ANR occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threadState")]
        public virtual string ThreadState { get; set; }

        /// <summary>The title of the thread.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for the UpdateIssue method.</summary>
    public class UpdateIssueRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The issue to update. The issue's `name` field is used to identify the issue to update. Format:
        /// "projects/{project}/apps/{app}/issues/{issue}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issue")]
        public virtual Issue Issue { get; set; }

        /// <summary>Optional. The list of Issue fields to update. Currently only "state" is mutable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Developer-provided end user identifiers.</summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>User id if provided by the app developer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Application software version.</summary>
    public class Version : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Mobile only. One display_version can have many build_version. On Android, strictly the same as "version
        /// code". On iOS, strictly the same as "build number" or CFBundleVersion.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildVersion")]
        public virtual string BuildVersion { get; set; }

        /// <summary>
        /// Compound readable string containing both display and build versions. Format: "display_version
        /// (build_version)" e.g. "1.2.3 (456)". This string can be used for filtering with the
        /// VersionFilter.display_name field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Readable version string, e.g. "1.2.3". On Android, strictly the same as "version name". On iOS, strictly the
        /// same as "version number" or CFBundleShortVersionString.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayVersion")]
        public virtual string DisplayVersion { get; set; }

        /// <summary>
        /// Indicates releases which have artifacts that are currently available in the Play Store to the target
        /// audience of the track. Versions may be available in multiple tracks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tracks")]
        public virtual System.Collections.Generic.IList<PlayTrack> Tracks { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a grouping for metrics specific to web applications.</summary>
    public class WebMetricsGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id of the web metrics group</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
