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

namespace Google.Apis.Meet.v2
{
    /// <summary>The Meet Service.</summary>
    public class MeetService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public MeetService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public MeetService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            ConferenceRecords = new ConferenceRecordsResource(this);
            Spaces = new SpacesResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://meet.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://meet.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "meet";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Google Meet API.</summary>
        public class Scope
        {
            /// <summary>
            /// Create, edit, and see information about your Google Meet conferences created by the app.
            /// </summary>
            public static string MeetingsSpaceCreated = "https://www.googleapis.com/auth/meetings.space.created";

            /// <summary>Read information about any of your Google Meet conferences</summary>
            public static string MeetingsSpaceReadonly = "https://www.googleapis.com/auth/meetings.space.readonly";

            /// <summary>Edit, and see settings for all of your Google Meet calls.</summary>
            public static string MeetingsSpaceSettings = "https://www.googleapis.com/auth/meetings.space.settings";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Meet API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// Create, edit, and see information about your Google Meet conferences created by the app.
            /// </summary>
            public const string MeetingsSpaceCreated = "https://www.googleapis.com/auth/meetings.space.created";

            /// <summary>Read information about any of your Google Meet conferences</summary>
            public const string MeetingsSpaceReadonly = "https://www.googleapis.com/auth/meetings.space.readonly";

            /// <summary>Edit, and see settings for all of your Google Meet calls.</summary>
            public const string MeetingsSpaceSettings = "https://www.googleapis.com/auth/meetings.space.settings";
        }

        /// <summary>Gets the ConferenceRecords resource.</summary>
        public virtual ConferenceRecordsResource ConferenceRecords { get; }

        /// <summary>Gets the Spaces resource.</summary>
        public virtual SpacesResource Spaces { get; }
    }

    /// <summary>A base abstract class for Meet requests.</summary>
    public abstract class MeetBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new MeetBaseServiceRequest instance.</summary>
        protected MeetBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Meet parameter list.</summary>
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

    /// <summary>The "conferenceRecords" collection of methods.</summary>
    public class ConferenceRecordsResource
    {
        private const string Resource = "conferenceRecords";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ConferenceRecordsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Participants = new ParticipantsResource(service);
            Recordings = new RecordingsResource(service);
            Transcripts = new TranscriptsResource(service);
        }

        /// <summary>Gets the Participants resource.</summary>
        public virtual ParticipantsResource Participants { get; }

        /// <summary>The "participants" collection of methods.</summary>
        public class ParticipantsResource
        {
            private const string Resource = "participants";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ParticipantsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                ParticipantSessions = new ParticipantSessionsResource(service);
            }

            /// <summary>Gets the ParticipantSessions resource.</summary>
            public virtual ParticipantSessionsResource ParticipantSessions { get; }

            /// <summary>The "participantSessions" collection of methods.</summary>
            public class ParticipantSessionsResource
            {
                private const string Resource = "participantSessions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ParticipantSessionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Gets a participant session by participant session ID.</summary>
                /// <param name="name">Required. Resource name of the participant.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>Gets a participant session by participant session ID.</summary>
                public class GetRequest : MeetBaseServiceRequest<Google.Apis.Meet.v2.Data.ParticipantSession>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Resource name of the participant.</summary>
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
                            Pattern = @"^conferenceRecords/[^/]+/participants/[^/]+/participantSessions/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists the participant sessions of a participant in a conference record. By default, ordered by join
                /// time and in descending order. This API supports `fields` as standard parameters like every other
                /// API. However, when the `fields` request parameter is omitted this API defaults to
                /// `'participantsessions/*, next_page_token'`.
                /// </summary>
                /// <param name="parent">
                /// Required. Format: `conferenceRecords/{conference_record}/participants/{participant}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists the participant sessions of a participant in a conference record. By default, ordered by join
                /// time and in descending order. This API supports `fields` as standard parameters like every other
                /// API. However, when the `fields` request parameter is omitted this API defaults to
                /// `'participantsessions/*, next_page_token'`.
                /// </summary>
                public class ListRequest : MeetBaseServiceRequest<Google.Apis.Meet.v2.Data.ListParticipantSessionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `conferenceRecords/{conference_record}/participants/{participant}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Optional. User specified filtering condition in [EBNF
                    /// format](https://en.wikipedia.org/wiki/Extended_Backus%E2%80%93Naur_form). The following are the
                    /// filterable fields: * `start_time` * `end_time` For example, `end_time IS NULL` returns active
                    /// participant sessions in the conference record.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Optional. Maximum number of participant sessions to return. The service might return fewer than
                    /// this value. If unspecified, at most 100 participants are returned. The maximum value is 250;
                    /// values above 250 are coerced to 250. Maximum might change in the future.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Optional. Page token returned from previous List Call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/participantSessions";

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
                            Pattern = @"^conferenceRecords/[^/]+/participants/[^/]+$",
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
            }

            /// <summary>Gets a participant by participant ID.</summary>
            /// <param name="name">Required. Resource name of the participant.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a participant by participant ID.</summary>
            public class GetRequest : MeetBaseServiceRequest<Google.Apis.Meet.v2.Data.Participant>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Resource name of the participant.</summary>
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
                        Pattern = @"^conferenceRecords/[^/]+/participants/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the participants in a conference record. By default, ordered by join time and in descending order.
            /// This API supports `fields` as standard parameters like every other API. However, when the `fields`
            /// request parameter is omitted, this API defaults to `'participants/*, next_page_token'`.
            /// </summary>
            /// <param name="parent">Required. Format: `conferenceRecords/{conference_record}`</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists the participants in a conference record. By default, ordered by join time and in descending order.
            /// This API supports `fields` as standard parameters like every other API. However, when the `fields`
            /// request parameter is omitted, this API defaults to `'participants/*, next_page_token'`.
            /// </summary>
            public class ListRequest : MeetBaseServiceRequest<Google.Apis.Meet.v2.Data.ListParticipantsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Format: `conferenceRecords/{conference_record}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. User specified filtering condition in [EBNF
                /// format](https://en.wikipedia.org/wiki/Extended_Backus%E2%80%93Naur_form). The following are the
                /// filterable fields: * `earliest_start_time` * `latest_end_time` For example, `latest_end_time IS
                /// NULL` returns active participants in the conference.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Maximum number of participants to return. The service might return fewer than this value. If
                /// unspecified, at most 100 participants are returned. The maximum value is 250; values above 250 are
                /// coerced to 250. Maximum might change in the future.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Page token returned from previous List Call.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/participants";

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
                        Pattern = @"^conferenceRecords/[^/]+$",
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
        }

        /// <summary>Gets the Recordings resource.</summary>
        public virtual RecordingsResource Recordings { get; }

        /// <summary>The "recordings" collection of methods.</summary>
        public class RecordingsResource
        {
            private const string Resource = "recordings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RecordingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Gets a recording by recording ID.</summary>
            /// <param name="name">Required. Resource name of the recording.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a recording by recording ID.</summary>
            public class GetRequest : MeetBaseServiceRequest<Google.Apis.Meet.v2.Data.Recording>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Resource name of the recording.</summary>
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
                        Pattern = @"^conferenceRecords/[^/]+/recordings/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the recording resources from the conference record. By default, ordered by start time and in
            /// ascending order.
            /// </summary>
            /// <param name="parent">Required. Format: `conferenceRecords/{conference_record}`</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists the recording resources from the conference record. By default, ordered by start time and in
            /// ascending order.
            /// </summary>
            public class ListRequest : MeetBaseServiceRequest<Google.Apis.Meet.v2.Data.ListRecordingsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Format: `conferenceRecords/{conference_record}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Maximum number of recordings to return. The service might return fewer than this value. If
                /// unspecified, at most 10 recordings are returned. The maximum value is 100; values above 100 are
                /// coerced to 100. Maximum might change in the future.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Page token returned from previous List Call.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/recordings";

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
                        Pattern = @"^conferenceRecords/[^/]+$",
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

        /// <summary>Gets the Transcripts resource.</summary>
        public virtual TranscriptsResource Transcripts { get; }

        /// <summary>The "transcripts" collection of methods.</summary>
        public class TranscriptsResource
        {
            private const string Resource = "transcripts";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TranscriptsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Entries = new EntriesResource(service);
            }

            /// <summary>Gets the Entries resource.</summary>
            public virtual EntriesResource Entries { get; }

            /// <summary>The "entries" collection of methods.</summary>
            public class EntriesResource
            {
                private const string Resource = "entries";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EntriesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Gets a `TranscriptEntry` resource by entry ID. Note: The transcript entries returned by the Google
                /// Meet API might not match the transcription found in the Google Docs transcript file. This can occur
                /// when 1) we have interleaved speakers within milliseconds, or 2) the Google Docs transcript file is
                /// modified after generation.
                /// </summary>
                /// <param name="name">Required. Resource name of the `TranscriptEntry`.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(this.service, name);
                }

                /// <summary>
                /// Gets a `TranscriptEntry` resource by entry ID. Note: The transcript entries returned by the Google
                /// Meet API might not match the transcription found in the Google Docs transcript file. This can occur
                /// when 1) we have interleaved speakers within milliseconds, or 2) the Google Docs transcript file is
                /// modified after generation.
                /// </summary>
                public class GetRequest : MeetBaseServiceRequest<Google.Apis.Meet.v2.Data.TranscriptEntry>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>Required. Resource name of the `TranscriptEntry`.</summary>
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
                            Pattern = @"^conferenceRecords/[^/]+/transcripts/[^/]+/entries/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists the structured transcript entries per transcript. By default, ordered by start time and in
                /// ascending order. Note: The transcript entries returned by the Google Meet API might not match the
                /// transcription found in the Google Docs transcript file. This can occur when 1) we have interleaved
                /// speakers within milliseconds, or 2) the Google Docs transcript file is modified after generation.
                /// </summary>
                /// <param name="parent">
                /// Required. Format: `conferenceRecords/{conference_record}/transcripts/{transcript}`
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(this.service, parent);
                }

                /// <summary>
                /// Lists the structured transcript entries per transcript. By default, ordered by start time and in
                /// ascending order. Note: The transcript entries returned by the Google Meet API might not match the
                /// transcription found in the Google Docs transcript file. This can occur when 1) we have interleaved
                /// speakers within milliseconds, or 2) the Google Docs transcript file is modified after generation.
                /// </summary>
                public class ListRequest : MeetBaseServiceRequest<Google.Apis.Meet.v2.Data.ListTranscriptEntriesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Format: `conferenceRecords/{conference_record}/transcripts/{transcript}`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Maximum number of entries to return. The service might return fewer than this value. If
                    /// unspecified, at most 10 entries are returned. The maximum value is 100; values above 100 are
                    /// coerced to 100. Maximum might change in the future.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>Page token returned from previous List Call.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v2/{+parent}/entries";

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
                            Pattern = @"^conferenceRecords/[^/]+/transcripts/[^/]+$",
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

            /// <summary>Gets a transcript by transcript ID.</summary>
            /// <param name="name">Required. Resource name of the transcript.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(this.service, name);
            }

            /// <summary>Gets a transcript by transcript ID.</summary>
            public class GetRequest : MeetBaseServiceRequest<Google.Apis.Meet.v2.Data.Transcript>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Resource name of the transcript.</summary>
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
                        Pattern = @"^conferenceRecords/[^/]+/transcripts/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists the set of transcripts from the conference record. By default, ordered by start time and in
            /// ascending order.
            /// </summary>
            /// <param name="parent">Required. Format: `conferenceRecords/{conference_record}`</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(this.service, parent);
            }

            /// <summary>
            /// Lists the set of transcripts from the conference record. By default, ordered by start time and in
            /// ascending order.
            /// </summary>
            public class ListRequest : MeetBaseServiceRequest<Google.Apis.Meet.v2.Data.ListTranscriptsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Format: `conferenceRecords/{conference_record}`</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Maximum number of transcripts to return. The service might return fewer than this value. If
                /// unspecified, at most 10 transcripts are returned. The maximum value is 100; values above 100 are
                /// coerced to 100. Maximum might change in the future.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Page token returned from previous List Call.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/transcripts";

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
                        Pattern = @"^conferenceRecords/[^/]+$",
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

        /// <summary>Gets a conference record by conference ID.</summary>
        /// <param name="name">Required. Resource name of the conference.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>Gets a conference record by conference ID.</summary>
        public class GetRequest : MeetBaseServiceRequest<Google.Apis.Meet.v2.Data.ConferenceRecord>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>Required. Resource name of the conference.</summary>
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
                    Pattern = @"^conferenceRecords/[^/]+$",
                });
            }
        }

        /// <summary>Lists the conference records. By default, ordered by start time and in descending order.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Lists the conference records. By default, ordered by start time and in descending order.</summary>
        public class ListRequest : MeetBaseServiceRequest<Google.Apis.Meet.v2.Data.ListConferenceRecordsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. User specified filtering condition in [EBNF
            /// format](https://en.wikipedia.org/wiki/Extended_Backus%E2%80%93Naur_form). The following are the
            /// filterable fields: * `space.meeting_code` * `space.name` * `start_time` * `end_time` For example,
            /// consider the following filters: * `space.name = "spaces/NAME"` * `space.meeting_code = "abc-mnop-xyz"` *
            /// `start_time&amp;gt;="2024-01-01T00:00:00.000Z" AND start_time&amp;lt;="2024-01-02T00:00:00.000Z"` *
            /// `end_time IS NULL`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Optional. Maximum number of conference records to return. The service might return fewer than this
            /// value. If unspecified, at most 25 conference records are returned. The maximum value is 100; values
            /// above 100 are coerced to 100. Maximum might change in the future.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>Optional. Page token returned from previous List Call.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/conferenceRecords";

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

    /// <summary>The "spaces" collection of methods.</summary>
    public class SpacesResource
    {
        private const string Resource = "spaces";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SpacesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Creates a space.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Meet.v2.Data.Space body)
        {
            return new CreateRequest(this.service, body);
        }

        /// <summary>Creates a space.</summary>
        public class CreateRequest : MeetBaseServiceRequest<Google.Apis.Meet.v2.Data.Space>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Meet.v2.Data.Space body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Meet.v2.Data.Space Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/spaces";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Ends an active conference (if there's one). For an example, see [End active
        /// conference](https://developers.google.com/meet/api/guides/meeting-spaces#end-active-conference).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Required. Resource name of the space. Format: `spaces/{space}`. `{space}` is the resource identifier for the
        /// space. It's a unique, server-generated ID and is case sensitive. For example, `jQCFfuBOdN5z`. For more
        /// information, see [How Meet identifies a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
        /// </param>
        public virtual EndActiveConferenceRequest EndActiveConference(Google.Apis.Meet.v2.Data.EndActiveConferenceRequest body, string name)
        {
            return new EndActiveConferenceRequest(this.service, body, name);
        }

        /// <summary>
        /// Ends an active conference (if there's one). For an example, see [End active
        /// conference](https://developers.google.com/meet/api/guides/meeting-spaces#end-active-conference).
        /// </summary>
        public class EndActiveConferenceRequest : MeetBaseServiceRequest<Google.Apis.Meet.v2.Data.Empty>
        {
            /// <summary>Constructs a new EndActiveConference request.</summary>
            public EndActiveConferenceRequest(Google.Apis.Services.IClientService service, Google.Apis.Meet.v2.Data.EndActiveConferenceRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name of the space. Format: `spaces/{space}`. `{space}` is the resource identifier for
            /// the space. It's a unique, server-generated ID and is case sensitive. For example, `jQCFfuBOdN5z`. For
            /// more information, see [How Meet identifies a meeting
            /// space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Meet.v2.Data.EndActiveConferenceRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "endActiveConference";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/{+name}:endActiveConference";

            /// <summary>Initializes EndActiveConference parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^spaces/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Gets details about a meeting space. For an example, see [Get a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#get-meeting-space).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space. Format: `spaces/{space}` or `spaces/{meetingCode}`. `{space}` is the
        /// resource identifier for the space. It's a unique, server-generated ID and is case sensitive. For example,
        /// `jQCFfuBOdN5z`. `{meetingCode}` is an alias for the space. It's a typeable, unique character string and is
        /// non-case sensitive. For example, `abc-mnop-xyz`. The maximum length is 128 characters. A `meetingCode`
        /// shouldn't be stored long term as it can become dissociated from a meeting space and can be reused for
        /// different meeting spaces in the future. Generally, a `meetingCode` expires 365 days after last use. For more
        /// information, see [Learn about meeting codes in Google
        /// Meet](https://support.google.com/meet/answer/10710509). For more information, see [How Meet identifies a
        /// meeting space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(this.service, name);
        }

        /// <summary>
        /// Gets details about a meeting space. For an example, see [Get a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#get-meeting-space).
        /// </summary>
        public class GetRequest : MeetBaseServiceRequest<Google.Apis.Meet.v2.Data.Space>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name of the space. Format: `spaces/{space}` or `spaces/{meetingCode}`. `{space}` is
            /// the resource identifier for the space. It's a unique, server-generated ID and is case sensitive. For
            /// example, `jQCFfuBOdN5z`. `{meetingCode}` is an alias for the space. It's a typeable, unique character
            /// string and is non-case sensitive. For example, `abc-mnop-xyz`. The maximum length is 128 characters. A
            /// `meetingCode` shouldn't be stored long term as it can become dissociated from a meeting space and can be
            /// reused for different meeting spaces in the future. Generally, a `meetingCode` expires 365 days after
            /// last use. For more information, see [Learn about meeting codes in Google
            /// Meet](https://support.google.com/meet/answer/10710509). For more information, see [How Meet identifies a
            /// meeting space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
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
                    Pattern = @"^spaces/[^/]+$",
                });
            }
        }

        /// <summary>
        /// Updates details about a meeting space. For an example, see [Update a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#update-meeting-space).
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Immutable. Resource name of the space. Format: `spaces/{space}`. `{space}` is the resource identifier for
        /// the space. It's a unique, server-generated ID and is case sensitive. For example, `jQCFfuBOdN5z`. For more
        /// information, see [How Meet identifies a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Meet.v2.Data.Space body, string name)
        {
            return new PatchRequest(this.service, body, name);
        }

        /// <summary>
        /// Updates details about a meeting space. For an example, see [Update a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#update-meeting-space).
        /// </summary>
        public class PatchRequest : MeetBaseServiceRequest<Google.Apis.Meet.v2.Data.Space>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Meet.v2.Data.Space body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Immutable. Resource name of the space. Format: `spaces/{space}`. `{space}` is the resource identifier
            /// for the space. It's a unique, server-generated ID and is case sensitive. For example, `jQCFfuBOdN5z`.
            /// For more information, see [How Meet identifies a meeting
            /// space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// Optional. Field mask used to specify the fields to be updated in the space. If update_mask isn't
            /// provided(not set, set with empty paths, or only has "" as paths), it defaults to update all fields
            /// provided with values in the request. Using "*" as update_mask will update all fields, including deleting
            /// fields not set in the request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Meet.v2.Data.Space Body { get; set; }

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
                    Pattern = @"^spaces/[^/]+$",
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
namespace Google.Apis.Meet.v2.Data
{
    /// <summary>Active conference.</summary>
    public class ActiveConference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Reference to 'ConferenceRecord' resource. Format: `conferenceRecords/{conference_record}` where
        /// `{conference_record}` is a unique ID for each instance of a call within a space.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conferenceRecord")]
        public virtual string ConferenceRecord { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>User who joins anonymously (meaning not signed into a Google Account).</summary>
    public class AnonymousUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. User provided name when they join a conference anonymously.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Single instance of a meeting held in a space.</summary>
    public class ConferenceRecord : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// Output only. Timestamp when the conference ended. Set for past conferences. Unset if the conference is
        /// ongoing.
        /// </summary>
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

        private string _expireTimeRaw;

        private object _expireTime;

        /// <summary>
        /// Output only. Server enforced expiration time for when this conference record resource is deleted. The
        /// resource is deleted 30 days after the conference ends.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw
        {
            get => _expireTimeRaw;
            set
            {
                _expireTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _expireTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual object ExpireTime
        {
            get => _expireTime;
            set
            {
                _expireTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _expireTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Identifier. Resource name of the conference record. Format: `conferenceRecords/{conference_record}` where
        /// `{conference_record}` is a unique ID for each instance of a call within a space.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The space where the conference was held.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("space")]
        public virtual string Space { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. Timestamp when the conference started. Always set.</summary>
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

    /// <summary>Google Docs location where the transcript file is saved.</summary>
    public class DocsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The document ID for the underlying Google Docs transcript file. For example,
        /// "1kuceFZohVoCh6FulBHxwy6I15Ogpc4hP". Use the `documents.get` method of the Google Docs API
        /// (https://developers.google.com/docs/api/reference/rest/v1/documents/get) to fetch the content.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("document")]
        public virtual string Document { get; set; }

        /// <summary>
        /// Output only. URI for the Google Docs transcript file. Use
        /// `https://docs.google.com/document/d/{$DocumentId}/view` to browse the transcript in the browser.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportUri")]
        public virtual string ExportUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Export location where a recording file is saved in Google Drive.</summary>
    public class DriveDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Link used to play back the recording file in the browser. For example,
        /// `https://drive.google.com/file/d/{$fileId}/view`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exportUri")]
        public virtual string ExportUri { get; set; }

        /// <summary>
        /// Output only. The `fileId` for the underlying MP4 file. For example, "1kuceFZohVoCh6FulBHxwy6I15Ogpc4hP". Use
        /// `$ GET https://www.googleapis.com/drive/v3/files/{$fileId}?alt=media` to download the blob. For more
        /// information, see https://developers.google.com/drive/api/v3/reference/files/get.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("file")]
        public virtual string File { get; set; }

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

    /// <summary>Request to end an ongoing conference of a space.</summary>
    public class EndActiveConferenceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of ListConferenceRecords method.</summary>
    public class ListConferenceRecordsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of conferences in one page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conferenceRecords")]
        public virtual System.Collections.Generic.IList<ConferenceRecord> ConferenceRecords { get; set; }

        /// <summary>
        /// Token to be circulated back for further List call if current List does NOT include all the Conferences.
        /// Unset if all conferences have been returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of ListParticipants method.</summary>
    public class ListParticipantSessionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to be circulated back for further List call if current List doesn't include all the participants.
        /// Unset if all participants are returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of participants in one page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("participantSessions")]
        public virtual System.Collections.Generic.IList<ParticipantSession> ParticipantSessions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of ListParticipants method.</summary>
    public class ListParticipantsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to be circulated back for further List call if current List doesn't include all the participants.
        /// Unset if all participants are returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of participants in one page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("participants")]
        public virtual System.Collections.Generic.IList<Participant> Participants { get; set; }

        /// <summary>
        /// Total, exact number of `participants`. By default, this field isn't included in the response. Set the field
        /// mask in [SystemParameterContext](https://cloud.google.com/apis/docs/system-parameters) to receive this field
        /// in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListRecordings method.</summary>
    public class ListRecordingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to be circulated back for further List call if current List doesn't include all the recordings. Unset
        /// if all recordings are returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of recordings in one page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recordings")]
        public virtual System.Collections.Generic.IList<Recording> Recordings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListTranscriptEntries method.</summary>
    public class ListTranscriptEntriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to be circulated back for further List call if current List doesn't include all the transcript
        /// entries. Unset if all entries are returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of TranscriptEntries in one page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcriptEntries")]
        public virtual System.Collections.Generic.IList<TranscriptEntry> TranscriptEntries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for ListTranscripts method.</summary>
    public class ListTranscriptsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to be circulated back for further List call if current List doesn't include all the transcripts. Unset
        /// if all transcripts are returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of transcripts in one page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcripts")]
        public virtual System.Collections.Generic.IList<Transcript> Transcripts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>User who attended or is attending a conference.</summary>
    public class Participant : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Anonymous user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anonymousUser")]
        public virtual AnonymousUser AnonymousUser { get; set; }

        private string _earliestStartTimeRaw;

        private object _earliestStartTime;

        /// <summary>Output only. Time when the participant first joined the meeting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("earliestStartTime")]
        public virtual string EarliestStartTimeRaw
        {
            get => _earliestStartTimeRaw;
            set
            {
                _earliestStartTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _earliestStartTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EarliestStartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EarliestStartTimeDateTimeOffset instead.")]
        public virtual object EarliestStartTime
        {
            get => _earliestStartTime;
            set
            {
                _earliestStartTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _earliestStartTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="EarliestStartTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EarliestStartTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(EarliestStartTimeRaw);
            set => EarliestStartTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        private string _latestEndTimeRaw;

        private object _latestEndTime;

        /// <summary>
        /// Output only. Time when the participant left the meeting for the last time. This can be null if it's an
        /// active meeting.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latestEndTime")]
        public virtual string LatestEndTimeRaw
        {
            get => _latestEndTimeRaw;
            set
            {
                _latestEndTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _latestEndTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="LatestEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LatestEndTimeDateTimeOffset instead.")]
        public virtual object LatestEndTime
        {
            get => _latestEndTime;
            set
            {
                _latestEndTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _latestEndTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="LatestEndTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? LatestEndTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseGoogleDateTimeToDateTimeOffset(LatestEndTimeRaw);
            set => LatestEndTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToGoogleDateTime(value);
        }

        /// <summary>
        /// Output only. Resource name of the participant. Format:
        /// `conferenceRecords/{conference_record}/participants/{participant}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>User calling from their phone.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneUser")]
        public virtual PhoneUser PhoneUser { get; set; }

        /// <summary>Signed-in user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signedinUser")]
        public virtual SignedinUser SignedinUser { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Refers to each unique join or leave session when a user joins a conference from a device. Note that any time a
    /// user joins the conference a new unique ID is assigned. That means if a user joins a space multiple times from
    /// the same device, they're assigned different IDs, and are also be treated as different participant sessions.
    /// </summary>
    public class ParticipantSession : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>
        /// Output only. Timestamp when the user session ends. Unset if the user session hasn’t ended.
        /// </summary>
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

        /// <summary>Identifier. Session id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. Timestamp when the user session starts.</summary>
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
    /// User dialing in from a phone where the user's identity is unknown because they haven't signed in with a Google
    /// Account.
    /// </summary>
    public class PhoneUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Partially redacted user's phone number when calling.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about a recording created during a conference.</summary>
    public class Recording : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Recording is saved to Google Drive as an MP4 file. The `drive_destination` includes the Drive
        /// `fileId` that can be used to download the file using the `files.get` method of the Drive API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveDestination")]
        public virtual DriveDestination DriveDestination { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. Timestamp when the recording ended.</summary>
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

        /// <summary>
        /// Output only. Resource name of the recording. Format:
        /// `conferenceRecords/{conference_record}/recordings/{recording}` where `{recording}` is a 1:1 mapping to each
        /// unique recording session during the conference.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. Timestamp when the recording started.</summary>
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

        /// <summary>Output only. Current state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A signed-in user can be: a) An individual joining from a personal computer, mobile device, or through companion
    /// mode. b) A robot account used by conference room devices.
    /// </summary>
    public class SignedinUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. For a personal device, it's the user's first name and last name. For a robot account, it's the
        /// administrator-specified device name. For example, "Altostrat Room".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Unique ID for the user. Interoperable with Admin SDK API and People API. Format: `users/{user}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user")]
        public virtual string User { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Virtual place where conferences are held. Only one active conference can be held in one space at any given time.
    /// </summary>
    public class Space : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Active conference, if it exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeConference")]
        public virtual ActiveConference ActiveConference { get; set; }

        /// <summary>Configuration pertaining to the meeting space.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual SpaceConfig Config { get; set; }

        /// <summary>
        /// Output only. Type friendly unique string used to join the meeting. Format: `[a-z]+-[a-z]+-[a-z]+`. For
        /// example, `abc-mnop-xyz`. The maximum length is 128 characters. Can only be used as an alias of the space
        /// name to get the space.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetingCode")]
        public virtual string MeetingCode { get; set; }

        /// <summary>
        /// Output only. URI used to join meetings consisting of `https://meet.google.com/` followed by the
        /// `meeting_code`. For example, `https://meet.google.com/abc-mnop-xyz`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meetingUri")]
        public virtual string MeetingUri { get; set; }

        /// <summary>
        /// Immutable. Resource name of the space. Format: `spaces/{space}`. `{space}` is the resource identifier for
        /// the space. It's a unique, server-generated ID and is case sensitive. For example, `jQCFfuBOdN5z`. For more
        /// information, see [How Meet identifies a meeting
        /// space](https://developers.google.com/meet/api/guides/meeting-spaces#identify-meeting-space).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration pertaining to a meeting space.</summary>
    public class SpaceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Access type of the meeting space that determines who can join without knocking. Default: The user's default
        /// access settings. Controlled by the user's admin for enterprise users or RESTRICTED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessType")]
        public virtual string AccessType { get; set; }

        /// <summary>
        /// Defines the entry points that can be used to join meetings hosted in this meeting space. Default:
        /// EntryPointAccess.ALL
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryPointAccess")]
        public virtual string EntryPointAccess { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Metadata for a transcript generated from a conference. It refers to the ASR (Automatic Speech Recognition)
    /// result of user's speech during the conference.
    /// </summary>
    public class Transcript : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Where the Google Docs transcript is saved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("docsDestination")]
        public virtual DocsDestination DocsDestination { get; set; }

        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. Timestamp when the transcript stopped.</summary>
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

        /// <summary>
        /// Output only. Resource name of the transcript. Format:
        /// `conferenceRecords/{conference_record}/transcripts/{transcript}`, where `{transcript}` is a 1:1 mapping to
        /// each unique transcription session of the conference.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. Timestamp when the transcript started.</summary>
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

        /// <summary>Output only. Current state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Single entry for one user’s speech during a transcript session.</summary>
    public class TranscriptEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _endTimeRaw;

        private object _endTime;

        /// <summary>Output only. Timestamp when the transcript entry ended.</summary>
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

        /// <summary>
        /// Output only. Language of spoken text, such as "en-US". IETF BCP 47 syntax
        /// (https://tools.ietf.org/html/bcp47)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// Output only. Resource name of the entry. Format:
        /// "conferenceRecords/{conference_record}/transcripts/{transcript}/entries/{entry}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Refers to the participant who speaks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("participant")]
        public virtual string Participant { get; set; }

        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Output only. Timestamp when the transcript entry started.</summary>
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

        /// <summary>
        /// Output only. The transcribed text of the participant's voice, at maximum 10K words. Note that the limit is
        /// subject to change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
