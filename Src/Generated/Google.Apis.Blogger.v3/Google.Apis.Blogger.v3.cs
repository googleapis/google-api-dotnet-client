// Copyright 2022 Google LLC
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

namespace Google.Apis.Blogger.v3
{
    /// <summary>The Blogger Service.</summary>
    public class BloggerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v3";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public BloggerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public BloggerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            BlogUserInfos = new BlogUserInfosResource(this);
            Blogs = new BlogsResource(this);
            Comments = new CommentsResource(this);
            PageViews = new PageViewsResource(this);
            Pages = new PagesResource(this);
            PostUserInfos = new PostUserInfosResource(this);
            Posts = new PostsResource(this);
            Users = new UsersResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "blogger";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://blogger.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://blogger.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Blogger API.</summary>
        public class Scope
        {
            /// <summary>Manage your Blogger account</summary>
            public static string Blogger = "https://www.googleapis.com/auth/blogger";

            /// <summary>View your Blogger account</summary>
            public static string BloggerReadonly = "https://www.googleapis.com/auth/blogger.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Blogger API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage your Blogger account</summary>
            public const string Blogger = "https://www.googleapis.com/auth/blogger";

            /// <summary>View your Blogger account</summary>
            public const string BloggerReadonly = "https://www.googleapis.com/auth/blogger.readonly";
        }

        /// <summary>Gets the BlogUserInfos resource.</summary>
        public virtual BlogUserInfosResource BlogUserInfos { get; }

        /// <summary>Gets the Blogs resource.</summary>
        public virtual BlogsResource Blogs { get; }

        /// <summary>Gets the Comments resource.</summary>
        public virtual CommentsResource Comments { get; }

        /// <summary>Gets the PageViews resource.</summary>
        public virtual PageViewsResource PageViews { get; }

        /// <summary>Gets the Pages resource.</summary>
        public virtual PagesResource Pages { get; }

        /// <summary>Gets the PostUserInfos resource.</summary>
        public virtual PostUserInfosResource PostUserInfos { get; }

        /// <summary>Gets the Posts resource.</summary>
        public virtual PostsResource Posts { get; }

        /// <summary>Gets the Users resource.</summary>
        public virtual UsersResource Users { get; }
    }

    /// <summary>A base abstract class for Blogger requests.</summary>
    public abstract class BloggerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new BloggerBaseServiceRequest instance.</summary>
        protected BloggerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Blogger parameter list.</summary>
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

    /// <summary>The "blogUserInfos" collection of methods.</summary>
    public class BlogUserInfosResource
    {
        private const string Resource = "blogUserInfos";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BlogUserInfosResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets one blog and user info pair by blog id and user id.</summary>
        /// <param name="userId"><c>null</c></param>
        /// <param name="blogId"><c>null</c></param>
        public virtual GetRequest Get(string userId, string blogId)
        {
            return new GetRequest(service, userId, blogId);
        }

        /// <summary>Gets one blog and user info pair by blog id and user id.</summary>
        public class GetRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.BlogUserInfo>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string userId, string blogId) : base(service)
            {
                UserId = userId;
                BlogId = blogId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("maxPosts", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxPosts { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/users/{userId}/blogs/{blogId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxPosts", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxPosts",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "blogs" collection of methods.</summary>
    public class BlogsResource
    {
        private const string Resource = "blogs";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BlogsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets a blog by id.</summary>
        /// <param name="blogId"><c>null</c></param>
        public virtual GetRequest Get(string blogId)
        {
            return new GetRequest(service, blogId);
        }

        /// <summary>Gets a blog by id.</summary>
        public class GetRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Blog>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string blogId) : base(service)
            {
                BlogId = blogId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("maxPosts", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxPosts { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            public enum ViewEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_TYPE_UNSPECIFIED")]
                VIEWTYPEUNSPECIFIED = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("READER")]
                READER = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("AUTHOR")]
                AUTHOR = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ADMIN")]
                ADMIN = 3,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxPosts", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxPosts",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets a blog by url.</summary>
        /// <param name="url"><c>null</c></param>
        public virtual GetByUrlRequest GetByUrl(string url)
        {
            return new GetByUrlRequest(service, url);
        }

        /// <summary>Gets a blog by url.</summary>
        public class GetByUrlRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Blog>
        {
            /// <summary>Constructs a new GetByUrl request.</summary>
            public GetByUrlRequest(Google.Apis.Services.IClientService service, string url) : base(service)
            {
                Url = url;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("url", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Url { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            public enum ViewEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_TYPE_UNSPECIFIED")]
                VIEWTYPEUNSPECIFIED = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("READER")]
                READER = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("AUTHOR")]
                AUTHOR = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ADMIN")]
                ADMIN = 3,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getByUrl";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/byurl";

            /// <summary>Initializes GetByUrl parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("url", new Google.Apis.Discovery.Parameter
                {
                    Name = "url",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists blogs by user.</summary>
        /// <param name="userId"><c>null</c></param>
        public virtual ListByUserRequest ListByUser(string userId)
        {
            return new ListByUserRequest(service, userId);
        }

        /// <summary>Lists blogs by user.</summary>
        public class ListByUserRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.BlogList>
        {
            /// <summary>Constructs a new ListByUser request.</summary>
            public ListByUserRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
            {
                UserId = userId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("fetchUserInfo", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FetchUserInfo { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("role", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<RoleEnum> Role { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("role", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<RoleEnum> RoleList { get; set; }

            public enum RoleEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_TYPE_UNSPECIFIED")]
                VIEWTYPEUNSPECIFIED = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("READER")]
                READER = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("AUTHOR")]
                AUTHOR = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ADMIN")]
                ADMIN = 3,
            }

            /// <summary>Default value of status is LIVE.</summary>
            /// <remarks>
            /// Use this property to set a single value for the parameter, or <see cref="StatusList"/> to set multiple
            /// values. Do not set both properties.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("status", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<StatusEnum> Status { get; set; }

            /// <summary>Default value of status is LIVE.</summary>
            /// <remarks>
            /// Use this property to set one or more values for the parameter. Do not set both this property and
            /// <see cref="Status"/>.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("status", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<StatusEnum> StatusList { get; set; }

            /// <summary>Default value of status is LIVE.</summary>
            public enum StatusEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("LIVE")]
                LIVE = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("DELETED")]
                DELETED = 1,
            }

            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            public enum ViewEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_TYPE_UNSPECIFIED")]
                VIEWTYPEUNSPECIFIED = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("READER")]
                READER = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("AUTHOR")]
                AUTHOR = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ADMIN")]
                ADMIN = 3,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listByUser";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/users/{userId}/blogs";

            /// <summary>Initializes ListByUser parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fetchUserInfo", new Google.Apis.Discovery.Parameter
                {
                    Name = "fetchUserInfo",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("role", new Google.Apis.Discovery.Parameter
                {
                    Name = "role",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("status", new Google.Apis.Discovery.Parameter
                {
                    Name = "status",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "LIVE",
                    Pattern = null,
                });
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "comments" collection of methods.</summary>
    public class CommentsResource
    {
        private const string Resource = "comments";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CommentsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Marks a comment as not spam by blog id, post id and comment id.</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="postId"><c>null</c></param>
        /// <param name="commentId"><c>null</c></param>
        public virtual ApproveRequest Approve(string blogId, string postId, string commentId)
        {
            return new ApproveRequest(service, blogId, postId, commentId);
        }

        /// <summary>Marks a comment as not spam by blog id, post id and comment id.</summary>
        public class ApproveRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Comment>
        {
            /// <summary>Constructs a new Approve request.</summary>
            public ApproveRequest(Google.Apis.Services.IClientService service, string blogId, string postId, string commentId) : base(service)
            {
                BlogId = blogId;
                PostId = postId;
                CommentId = commentId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("postId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PostId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("commentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CommentId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "approve";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/posts/{postId}/comments/{commentId}/approve";

            /// <summary>Initializes Approve parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("postId", new Google.Apis.Discovery.Parameter
                {
                    Name = "postId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("commentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "commentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Deletes a comment by blog id, post id and comment id.</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="postId"><c>null</c></param>
        /// <param name="commentId"><c>null</c></param>
        public virtual DeleteRequest Delete(string blogId, string postId, string commentId)
        {
            return new DeleteRequest(service, blogId, postId, commentId);
        }

        /// <summary>Deletes a comment by blog id, post id and comment id.</summary>
        public class DeleteRequest : BloggerBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string blogId, string postId, string commentId) : base(service)
            {
                BlogId = blogId;
                PostId = postId;
                CommentId = commentId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("postId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PostId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("commentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CommentId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/posts/{postId}/comments/{commentId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("postId", new Google.Apis.Discovery.Parameter
                {
                    Name = "postId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("commentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "commentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets a comment by id.</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="postId"><c>null</c></param>
        /// <param name="commentId"><c>null</c></param>
        public virtual GetRequest Get(string blogId, string postId, string commentId)
        {
            return new GetRequest(service, blogId, postId, commentId);
        }

        /// <summary>Gets a comment by id.</summary>
        public class GetRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Comment>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string blogId, string postId, string commentId) : base(service)
            {
                BlogId = blogId;
                PostId = postId;
                CommentId = commentId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("postId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PostId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("commentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CommentId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            public enum ViewEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_TYPE_UNSPECIFIED")]
                VIEWTYPEUNSPECIFIED = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("READER")]
                READER = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("AUTHOR")]
                AUTHOR = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ADMIN")]
                ADMIN = 3,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/posts/{postId}/comments/{commentId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("postId", new Google.Apis.Discovery.Parameter
                {
                    Name = "postId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("commentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "commentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists comments.</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="postId"><c>null</c></param>
        public virtual ListRequest List(string blogId, string postId)
        {
            return new ListRequest(service, blogId, postId);
        }

        /// <summary>Lists comments.</summary>
        public class ListRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.CommentList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string blogId, string postId) : base(service)
            {
                BlogId = blogId;
                PostId = postId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("postId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PostId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("endDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EndDate { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("fetchBodies", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FetchBodies { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("startDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StartDate { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("status", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<StatusEnum> Status { get; set; }

            public enum StatusEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("LIVE")]
                LIVE = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("EMPTIED")]
                EMPTIED = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("PENDING")]
                PENDING = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("SPAM")]
                SPAM = 3,
            }

            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            public enum ViewEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_TYPE_UNSPECIFIED")]
                VIEWTYPEUNSPECIFIED = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("READER")]
                READER = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("AUTHOR")]
                AUTHOR = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ADMIN")]
                ADMIN = 3,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/posts/{postId}/comments";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("postId", new Google.Apis.Discovery.Parameter
                {
                    Name = "postId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("endDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDate",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fetchBodies", new Google.Apis.Discovery.Parameter
                {
                    Name = "fetchBodies",
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
                RequestParameters.Add("startDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDate",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("status", new Google.Apis.Discovery.Parameter
                {
                    Name = "status",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists comments by blog.</summary>
        /// <param name="blogId"><c>null</c></param>
        public virtual ListByBlogRequest ListByBlog(string blogId)
        {
            return new ListByBlogRequest(service, blogId);
        }

        /// <summary>Lists comments by blog.</summary>
        public class ListByBlogRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.CommentList>
        {
            /// <summary>Constructs a new ListByBlog request.</summary>
            public ListByBlogRequest(Google.Apis.Services.IClientService service, string blogId) : base(service)
            {
                BlogId = blogId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("endDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EndDate { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("fetchBodies", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FetchBodies { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("startDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StartDate { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("status", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<StatusEnum> Status { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("status", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<StatusEnum> StatusList { get; set; }

            public enum StatusEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("LIVE")]
                LIVE = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("EMPTIED")]
                EMPTIED = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("PENDING")]
                PENDING = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("SPAM")]
                SPAM = 3,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "listByBlog";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/comments";

            /// <summary>Initializes ListByBlog parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("endDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDate",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fetchBodies", new Google.Apis.Discovery.Parameter
                {
                    Name = "fetchBodies",
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
                RequestParameters.Add("startDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDate",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("status", new Google.Apis.Discovery.Parameter
                {
                    Name = "status",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Marks a comment as spam by blog id, post id and comment id.</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="postId"><c>null</c></param>
        /// <param name="commentId"><c>null</c></param>
        public virtual MarkAsSpamRequest MarkAsSpam(string blogId, string postId, string commentId)
        {
            return new MarkAsSpamRequest(service, blogId, postId, commentId);
        }

        /// <summary>Marks a comment as spam by blog id, post id and comment id.</summary>
        public class MarkAsSpamRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Comment>
        {
            /// <summary>Constructs a new MarkAsSpam request.</summary>
            public MarkAsSpamRequest(Google.Apis.Services.IClientService service, string blogId, string postId, string commentId) : base(service)
            {
                BlogId = blogId;
                PostId = postId;
                CommentId = commentId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("postId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PostId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("commentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CommentId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "markAsSpam";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/posts/{postId}/comments/{commentId}/spam";

            /// <summary>Initializes MarkAsSpam parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("postId", new Google.Apis.Discovery.Parameter
                {
                    Name = "postId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("commentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "commentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Removes the content of a comment by blog id, post id and comment id.</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="postId"><c>null</c></param>
        /// <param name="commentId"><c>null</c></param>
        public virtual RemoveContentRequest RemoveContent(string blogId, string postId, string commentId)
        {
            return new RemoveContentRequest(service, blogId, postId, commentId);
        }

        /// <summary>Removes the content of a comment by blog id, post id and comment id.</summary>
        public class RemoveContentRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Comment>
        {
            /// <summary>Constructs a new RemoveContent request.</summary>
            public RemoveContentRequest(Google.Apis.Services.IClientService service, string blogId, string postId, string commentId) : base(service)
            {
                BlogId = blogId;
                PostId = postId;
                CommentId = commentId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("postId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PostId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("commentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CommentId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "removeContent";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/posts/{postId}/comments/{commentId}/removecontent";

            /// <summary>Initializes RemoveContent parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("postId", new Google.Apis.Discovery.Parameter
                {
                    Name = "postId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("commentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "commentId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "pageViews" collection of methods.</summary>
    public class PageViewsResource
    {
        private const string Resource = "pageViews";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PageViewsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets page views by blog id.</summary>
        /// <param name="blogId"><c>null</c></param>
        public virtual GetRequest Get(string blogId)
        {
            return new GetRequest(service, blogId);
        }

        /// <summary>Gets page views by blog id.</summary>
        public class GetRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Pageviews>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string blogId) : base(service)
            {
                BlogId = blogId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("range", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<RangeEnum> Range { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("range", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<RangeEnum> RangeList { get; set; }

            public enum RangeEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("all")]
                All = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("30DAYS")]
                Value30DAYS = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("7DAYS")]
                Value7DAYS = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/pageviews";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("range", new Google.Apis.Discovery.Parameter
                {
                    Name = "range",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "pages" collection of methods.</summary>
    public class PagesResource
    {
        private const string Resource = "pages";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PagesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a page by blog id and page id.</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="pageId"><c>null</c></param>
        public virtual DeleteRequest Delete(string blogId, string pageId)
        {
            return new DeleteRequest(service, blogId, pageId);
        }

        /// <summary>Deletes a page by blog id and page id.</summary>
        public class DeleteRequest : BloggerBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string blogId, string pageId) : base(service)
            {
                BlogId = blogId;
                PageId = pageId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("pageId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PageId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/pages/{pageId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageId", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets a page by blog id and page id.</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="pageId"><c>null</c></param>
        public virtual GetRequest Get(string blogId, string pageId)
        {
            return new GetRequest(service, blogId, pageId);
        }

        /// <summary>Gets a page by blog id and page id.</summary>
        public class GetRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Page>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string blogId, string pageId) : base(service)
            {
                BlogId = blogId;
                PageId = pageId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("pageId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PageId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            public enum ViewEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_TYPE_UNSPECIFIED")]
                VIEWTYPEUNSPECIFIED = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("READER")]
                READER = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("AUTHOR")]
                AUTHOR = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ADMIN")]
                ADMIN = 3,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/pages/{pageId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageId", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a page.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="blogId"><c>null</c></param>
        public virtual InsertRequest Insert(Google.Apis.Blogger.v3.Data.Page body, string blogId)
        {
            return new InsertRequest(service, body, blogId);
        }

        /// <summary>Inserts a page.</summary>
        public class InsertRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Page>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Blogger.v3.Data.Page body, string blogId) : base(service)
            {
                BlogId = blogId;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("isDraft", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IsDraft { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Blogger.v3.Data.Page Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/pages";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("isDraft", new Google.Apis.Discovery.Parameter
                {
                    Name = "isDraft",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists pages.</summary>
        /// <param name="blogId"><c>null</c></param>
        public virtual ListRequest List(string blogId)
        {
            return new ListRequest(service, blogId);
        }

        /// <summary>Lists pages.</summary>
        public class ListRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.PageList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string blogId) : base(service)
            {
                BlogId = blogId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("fetchBodies", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FetchBodies { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("status", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<StatusEnum> Status { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("status", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<StatusEnum> StatusList { get; set; }

            public enum StatusEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("LIVE")]
                LIVE = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("DRAFT")]
                DRAFT = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("SOFT_TRASHED")]
                SOFTTRASHED = 2,
            }

            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            public enum ViewEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_TYPE_UNSPECIFIED")]
                VIEWTYPEUNSPECIFIED = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("READER")]
                READER = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("AUTHOR")]
                AUTHOR = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ADMIN")]
                ADMIN = 3,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/pages";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fetchBodies", new Google.Apis.Discovery.Parameter
                {
                    Name = "fetchBodies",
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
                RequestParameters.Add("status", new Google.Apis.Discovery.Parameter
                {
                    Name = "status",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Patches a page.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="pageId"><c>null</c></param>
        public virtual PatchRequest Patch(Google.Apis.Blogger.v3.Data.Page body, string blogId, string pageId)
        {
            return new PatchRequest(service, body, blogId, pageId);
        }

        /// <summary>Patches a page.</summary>
        public class PatchRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Page>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Blogger.v3.Data.Page body, string blogId, string pageId) : base(service)
            {
                BlogId = blogId;
                PageId = pageId;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("pageId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PageId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("publish", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Publish { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("revert", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Revert { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Blogger.v3.Data.Page Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/pages/{pageId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageId", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("publish", new Google.Apis.Discovery.Parameter
                {
                    Name = "publish",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("revert", new Google.Apis.Discovery.Parameter
                {
                    Name = "revert",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Publishes a page.</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="pageId"><c>null</c></param>
        public virtual PublishRequest Publish(string blogId, string pageId)
        {
            return new PublishRequest(service, blogId, pageId);
        }

        /// <summary>Publishes a page.</summary>
        public class PublishRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Page>
        {
            /// <summary>Constructs a new Publish request.</summary>
            public PublishRequest(Google.Apis.Services.IClientService service, string blogId, string pageId) : base(service)
            {
                BlogId = blogId;
                PageId = pageId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("pageId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PageId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "publish";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/pages/{pageId}/publish";

            /// <summary>Initializes Publish parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageId", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Reverts a published or scheduled page to draft state.</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="pageId"><c>null</c></param>
        public virtual RevertRequest Revert(string blogId, string pageId)
        {
            return new RevertRequest(service, blogId, pageId);
        }

        /// <summary>Reverts a published or scheduled page to draft state.</summary>
        public class RevertRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Page>
        {
            /// <summary>Constructs a new Revert request.</summary>
            public RevertRequest(Google.Apis.Services.IClientService service, string blogId, string pageId) : base(service)
            {
                BlogId = blogId;
                PageId = pageId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("pageId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PageId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "revert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/pages/{pageId}/revert";

            /// <summary>Initializes Revert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageId", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates a page by blog id and page id.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="pageId"><c>null</c></param>
        public virtual UpdateRequest Update(Google.Apis.Blogger.v3.Data.Page body, string blogId, string pageId)
        {
            return new UpdateRequest(service, body, blogId, pageId);
        }

        /// <summary>Updates a page by blog id and page id.</summary>
        public class UpdateRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Page>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Blogger.v3.Data.Page body, string blogId, string pageId) : base(service)
            {
                BlogId = blogId;
                PageId = pageId;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("pageId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PageId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("publish", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Publish { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("revert", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Revert { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Blogger.v3.Data.Page Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/pages/{pageId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageId", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("publish", new Google.Apis.Discovery.Parameter
                {
                    Name = "publish",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("revert", new Google.Apis.Discovery.Parameter
                {
                    Name = "revert",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "postUserInfos" collection of methods.</summary>
    public class PostUserInfosResource
    {
        private const string Resource = "postUserInfos";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PostUserInfosResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Gets one post and user info pair, by post_id and user_id.</summary>
        /// <param name="userId"><c>null</c></param>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="postId"><c>null</c></param>
        public virtual GetRequest Get(string userId, string blogId, string postId)
        {
            return new GetRequest(service, userId, blogId, postId);
        }

        /// <summary>Gets one post and user info pair, by post_id and user_id.</summary>
        public class GetRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.PostUserInfo>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string userId, string blogId, string postId) : base(service)
            {
                UserId = userId;
                BlogId = blogId;
                PostId = postId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("postId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PostId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("maxComments", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxComments { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/users/{userId}/blogs/{blogId}/posts/{postId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("postId", new Google.Apis.Discovery.Parameter
                {
                    Name = "postId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxComments", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxComments",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists post and user info pairs.</summary>
        /// <param name="userId"><c>null</c></param>
        /// <param name="blogId"><c>null</c></param>
        public virtual ListRequest List(string userId, string blogId)
        {
            return new ListRequest(service, userId, blogId);
        }

        /// <summary>Lists post and user info pairs.</summary>
        public class ListRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.PostUserInfosList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string userId, string blogId) : base(service)
            {
                UserId = userId;
                BlogId = blogId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("endDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EndDate { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("fetchBodies", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FetchBodies { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("labels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Labels { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderByEnum> OrderBy { get; set; }

            public enum OrderByEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ORDER_BY_UNSPECIFIED")]
                ORDERBYUNSPECIFIED = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("PUBLISHED")]
                PUBLISHED = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("UPDATED")]
                UPDATED = 2,
            }

            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("startDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StartDate { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("status", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<StatusEnum> Status { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("status", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<StatusEnum> StatusList { get; set; }

            public enum StatusEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("LIVE")]
                LIVE = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("DRAFT")]
                DRAFT = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("SCHEDULED")]
                SCHEDULED = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("SOFT_TRASHED")]
                SOFTTRASHED = 3,
            }

            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            public enum ViewEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_TYPE_UNSPECIFIED")]
                VIEWTYPEUNSPECIFIED = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("READER")]
                READER = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("AUTHOR")]
                AUTHOR = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ADMIN")]
                ADMIN = 3,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/users/{userId}/blogs/{blogId}/posts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("endDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDate",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fetchBodies", new Google.Apis.Discovery.Parameter
                {
                    Name = "fetchBodies",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("labels", new Google.Apis.Discovery.Parameter
                {
                    Name = "labels",
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
                RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                {
                    Name = "orderBy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "PUBLISHED",
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
                RequestParameters.Add("startDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDate",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("status", new Google.Apis.Discovery.Parameter
                {
                    Name = "status",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "posts" collection of methods.</summary>
    public class PostsResource
    {
        private const string Resource = "posts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PostsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Deletes a post by blog id and post id.</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="postId"><c>null</c></param>
        public virtual DeleteRequest Delete(string blogId, string postId)
        {
            return new DeleteRequest(service, blogId, postId);
        }

        /// <summary>Deletes a post by blog id and post id.</summary>
        public class DeleteRequest : BloggerBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string blogId, string postId) : base(service)
            {
                BlogId = blogId;
                PostId = postId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("postId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PostId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/posts/{postId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("postId", new Google.Apis.Discovery.Parameter
                {
                    Name = "postId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets a post by blog id and post id</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="postId"><c>null</c></param>
        public virtual GetRequest Get(string blogId, string postId)
        {
            return new GetRequest(service, blogId, postId);
        }

        /// <summary>Gets a post by blog id and post id</summary>
        public class GetRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Post>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string blogId, string postId) : base(service)
            {
                BlogId = blogId;
                PostId = postId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("postId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PostId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("fetchBody", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FetchBody { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("fetchImages", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FetchImages { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("maxComments", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxComments { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            public enum ViewEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_TYPE_UNSPECIFIED")]
                VIEWTYPEUNSPECIFIED = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("READER")]
                READER = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("AUTHOR")]
                AUTHOR = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ADMIN")]
                ADMIN = 3,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/posts/{postId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("postId", new Google.Apis.Discovery.Parameter
                {
                    Name = "postId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fetchBody", new Google.Apis.Discovery.Parameter
                {
                    Name = "fetchBody",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
                RequestParameters.Add("fetchImages", new Google.Apis.Discovery.Parameter
                {
                    Name = "fetchImages",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxComments", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxComments",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets a post by path.</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="path"><c>null</c></param>
        public virtual GetByPathRequest GetByPath(string blogId, string path)
        {
            return new GetByPathRequest(service, blogId, path);
        }

        /// <summary>Gets a post by path.</summary>
        public class GetByPathRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Post>
        {
            /// <summary>Constructs a new GetByPath request.</summary>
            public GetByPathRequest(Google.Apis.Services.IClientService service, string blogId, string path) : base(service)
            {
                BlogId = blogId;
                Path = path;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("path", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Path { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("maxComments", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxComments { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            public enum ViewEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_TYPE_UNSPECIFIED")]
                VIEWTYPEUNSPECIFIED = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("READER")]
                READER = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("AUTHOR")]
                AUTHOR = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ADMIN")]
                ADMIN = 3,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getByPath";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/posts/bypath";

            /// <summary>Initializes GetByPath parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("path", new Google.Apis.Discovery.Parameter
                {
                    Name = "path",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxComments", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxComments",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Inserts a post.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="blogId"><c>null</c></param>
        public virtual InsertRequest Insert(Google.Apis.Blogger.v3.Data.Post body, string blogId)
        {
            return new InsertRequest(service, body, blogId);
        }

        /// <summary>Inserts a post.</summary>
        public class InsertRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Post>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Blogger.v3.Data.Post body, string blogId) : base(service)
            {
                BlogId = blogId;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("fetchBody", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FetchBody { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("fetchImages", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FetchImages { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("isDraft", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IsDraft { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Blogger.v3.Data.Post Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/posts";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fetchBody", new Google.Apis.Discovery.Parameter
                {
                    Name = "fetchBody",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
                RequestParameters.Add("fetchImages", new Google.Apis.Discovery.Parameter
                {
                    Name = "fetchImages",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("isDraft", new Google.Apis.Discovery.Parameter
                {
                    Name = "isDraft",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists posts.</summary>
        /// <param name="blogId"><c>null</c></param>
        public virtual ListRequest List(string blogId)
        {
            return new ListRequest(service, blogId);
        }

        /// <summary>Lists posts.</summary>
        public class ListRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.PostList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string blogId) : base(service)
            {
                BlogId = blogId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("endDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EndDate { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("fetchBodies", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FetchBodies { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("fetchImages", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FetchImages { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("labels", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Labels { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderByEnum> OrderBy { get; set; }

            public enum OrderByEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ORDER_BY_UNSPECIFIED")]
                ORDERBYUNSPECIFIED = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("PUBLISHED")]
                PUBLISHED = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("UPDATED")]
                UPDATED = 2,
            }

            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("startDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StartDate { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("status", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<StatusEnum> Status { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("status", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<StatusEnum> StatusList { get; set; }

            public enum StatusEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("LIVE")]
                LIVE = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("DRAFT")]
                DRAFT = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("SCHEDULED")]
                SCHEDULED = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("SOFT_TRASHED")]
                SOFTTRASHED = 3,
            }

            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            public enum ViewEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_TYPE_UNSPECIFIED")]
                VIEWTYPEUNSPECIFIED = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("READER")]
                READER = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("AUTHOR")]
                AUTHOR = 2,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ADMIN")]
                ADMIN = 3,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/posts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("endDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDate",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fetchBodies", new Google.Apis.Discovery.Parameter
                {
                    Name = "fetchBodies",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
                RequestParameters.Add("fetchImages", new Google.Apis.Discovery.Parameter
                {
                    Name = "fetchImages",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("labels", new Google.Apis.Discovery.Parameter
                {
                    Name = "labels",
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
                RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                {
                    Name = "orderBy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "PUBLISHED",
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
                RequestParameters.Add("startDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDate",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("status", new Google.Apis.Discovery.Parameter
                {
                    Name = "status",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("view", new Google.Apis.Discovery.Parameter
                {
                    Name = "view",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Patches a post.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="postId"><c>null</c></param>
        public virtual PatchRequest Patch(Google.Apis.Blogger.v3.Data.Post body, string blogId, string postId)
        {
            return new PatchRequest(service, body, blogId, postId);
        }

        /// <summary>Patches a post.</summary>
        public class PatchRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Post>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Blogger.v3.Data.Post body, string blogId, string postId) : base(service)
            {
                BlogId = blogId;
                PostId = postId;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("postId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PostId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("fetchBody", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FetchBody { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("fetchImages", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FetchImages { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("maxComments", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxComments { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("publish", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Publish { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("revert", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Revert { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Blogger.v3.Data.Post Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/posts/{postId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("postId", new Google.Apis.Discovery.Parameter
                {
                    Name = "postId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fetchBody", new Google.Apis.Discovery.Parameter
                {
                    Name = "fetchBody",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
                RequestParameters.Add("fetchImages", new Google.Apis.Discovery.Parameter
                {
                    Name = "fetchImages",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxComments", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxComments",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("publish", new Google.Apis.Discovery.Parameter
                {
                    Name = "publish",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("revert", new Google.Apis.Discovery.Parameter
                {
                    Name = "revert",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Publishes a post.</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="postId"><c>null</c></param>
        public virtual PublishRequest Publish(string blogId, string postId)
        {
            return new PublishRequest(service, blogId, postId);
        }

        /// <summary>Publishes a post.</summary>
        public class PublishRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Post>
        {
            /// <summary>Constructs a new Publish request.</summary>
            public PublishRequest(Google.Apis.Services.IClientService service, string blogId, string postId) : base(service)
            {
                BlogId = blogId;
                PostId = postId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("postId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PostId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("publishDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PublishDate { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "publish";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/posts/{postId}/publish";

            /// <summary>Initializes Publish parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("postId", new Google.Apis.Discovery.Parameter
                {
                    Name = "postId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("publishDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "publishDate",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Reverts a published or scheduled post to draft state.</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="postId"><c>null</c></param>
        public virtual RevertRequest Revert(string blogId, string postId)
        {
            return new RevertRequest(service, blogId, postId);
        }

        /// <summary>Reverts a published or scheduled post to draft state.</summary>
        public class RevertRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Post>
        {
            /// <summary>Constructs a new Revert request.</summary>
            public RevertRequest(Google.Apis.Services.IClientService service, string blogId, string postId) : base(service)
            {
                BlogId = blogId;
                PostId = postId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("postId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PostId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "revert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/posts/{postId}/revert";

            /// <summary>Initializes Revert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("postId", new Google.Apis.Discovery.Parameter
                {
                    Name = "postId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Searches for posts matching given query terms in the specified blog.</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="q"><c>null</c></param>
        public virtual SearchRequest Search(string blogId, string q)
        {
            return new SearchRequest(service, blogId, q);
        }

        /// <summary>Searches for posts matching given query terms in the specified blog.</summary>
        public class SearchRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.PostList>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service, string blogId, string q) : base(service)
            {
                BlogId = blogId;
                Q = q;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("q", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Q { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("fetchBodies", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FetchBodies { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderByEnum> OrderBy { get; set; }

            public enum OrderByEnum
            {
                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("ORDER_BY_UNSPECIFIED")]
                ORDERBYUNSPECIFIED = 0,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("PUBLISHED")]
                PUBLISHED = 1,

                /// <summary></summary>
                [Google.Apis.Util.StringValueAttribute("UPDATED")]
                UPDATED = 2,
            }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "search";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/posts/search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("q", new Google.Apis.Discovery.Parameter
                {
                    Name = "q",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fetchBodies", new Google.Apis.Discovery.Parameter
                {
                    Name = "fetchBodies",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
                RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                {
                    Name = "orderBy",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "PUBLISHED",
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates a post by blog id and post id.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="postId"><c>null</c></param>
        public virtual UpdateRequest Update(Google.Apis.Blogger.v3.Data.Post body, string blogId, string postId)
        {
            return new UpdateRequest(service, body, blogId, postId);
        }

        /// <summary>Updates a post by blog id and post id.</summary>
        public class UpdateRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.Post>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Blogger.v3.Data.Post body, string blogId, string postId) : base(service)
            {
                BlogId = blogId;
                PostId = postId;
                Body = body;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("postId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PostId { get; private set; }

            [Google.Apis.Util.RequestParameterAttribute("fetchBody", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FetchBody { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("fetchImages", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FetchImages { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("maxComments", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxComments { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("publish", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Publish { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("revert", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Revert { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Blogger.v3.Data.Post Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/blogs/{blogId}/posts/{postId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("blogId", new Google.Apis.Discovery.Parameter
                {
                    Name = "blogId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("postId", new Google.Apis.Discovery.Parameter
                {
                    Name = "postId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fetchBody", new Google.Apis.Discovery.Parameter
                {
                    Name = "fetchBody",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
                RequestParameters.Add("fetchImages", new Google.Apis.Discovery.Parameter
                {
                    Name = "fetchImages",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxComments", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxComments",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("publish", new Google.Apis.Discovery.Parameter
                {
                    Name = "publish",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("revert", new Google.Apis.Discovery.Parameter
                {
                    Name = "revert",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
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

        /// <summary>Gets one user by user_id.</summary>
        /// <param name="userId"><c>null</c></param>
        public virtual GetRequest Get(string userId)
        {
            return new GetRequest(service, userId);
        }

        /// <summary>Gets one user by user_id.</summary>
        public class GetRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v3.Data.User>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
            {
                UserId = userId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v3/users/{userId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Blogger.v3.Data
{
    public class Blog : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The JSON custom meta-data for the Blog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customMetaData")]
        public virtual string CustomMetaData { get; set; }

        /// <summary>The description of this blog. This is displayed underneath the title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The identifier for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The kind of this entry. Always blogger#blog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The locale this Blog is set to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual LocaleData Locale { get; set; }

        /// <summary>The name of this blog. This is displayed as the title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The container of pages in this blog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pages")]
        public virtual PagesData Pages { get; set; }

        /// <summary>The container of posts in this blog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("posts")]
        public virtual PostsData Posts { get; set; }

        /// <summary>RFC 3339 date-time when this blog was published.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("published")]
        public virtual string Published { get; set; }

        /// <summary>The API REST URL to fetch this resource from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The status of the blog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>RFC 3339 date-time when this blog was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string Updated { get; set; }

        /// <summary>The URL where this blog is published.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>The locale this Blog is set to.</summary>
        public class LocaleData
        {
            /// <summary>The country this blog's locale is set to.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("country")]
            public virtual string Country { get; set; }

            /// <summary>The language this blog is authored in.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("language")]
            public virtual string Language { get; set; }

            /// <summary>The language variant this blog is authored in.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("variant")]
            public virtual string Variant { get; set; }
        }

        /// <summary>The container of pages in this blog.</summary>
        public class PagesData
        {
            /// <summary>The URL of the container for pages in this blog.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
            public virtual string SelfLink { get; set; }

            /// <summary>The count of pages in this blog.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
            public virtual System.Nullable<int> TotalItems { get; set; }
        }

        /// <summary>The container of posts in this blog.</summary>
        public class PostsData
        {
            /// <summary>The List of Posts for this Blog.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("items")]
            public virtual System.Collections.Generic.IList<Post> Items { get; set; }

            /// <summary>The URL of the container for posts in this blog.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
            public virtual string SelfLink { get; set; }

            /// <summary>The count of posts in this blog.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
            public virtual System.Nullable<int> TotalItems { get; set; }
        }
    }

    public class BlogList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Admin level list of blog per-user information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blogUserInfos")]
        public virtual System.Collections.Generic.IList<BlogUserInfo> BlogUserInfos { get; set; }

        /// <summary>The list of Blogs this user has Authorship or Admin rights over.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Blog> Items { get; set; }

        /// <summary>The kind of this entity. Always blogger#blogList.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BlogPerUserInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the Blog resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blogId")]
        public virtual string BlogId { get; set; }

        /// <summary>True if the user has Admin level access to the blog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasAdminAccess")]
        public virtual System.Nullable<bool> HasAdminAccess { get; set; }

        /// <summary>The kind of this entity. Always blogger#blogPerUserInfo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The Photo Album Key for the user when adding photos to the blog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photosAlbumKey")]
        public virtual string PhotosAlbumKey { get; set; }

        /// <summary>Access permissions that the user has for the blog (ADMIN, AUTHOR, or READER).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>ID of the User.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BlogUserInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Blog resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blog")]
        public virtual Blog Blog { get; set; }

        /// <summary>Information about a User for the Blog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blog_user_info")]
        public virtual BlogPerUserInfo BlogUserInfoValue { get; set; }

        /// <summary>The kind of this entity. Always blogger#blogUserInfo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Comment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The author of this Comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("author")]
        public virtual AuthorData Author { get; set; }

        /// <summary>Data about the blog containing this comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blog")]
        public virtual BlogData Blog { get; set; }

        /// <summary>The actual content of the comment. May include HTML markup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The identifier for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Data about the comment this is in reply to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inReplyTo")]
        public virtual InReplyToData InReplyTo { get; set; }

        /// <summary>The kind of this entry. Always blogger#comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Data about the post containing this comment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("post")]
        public virtual PostData Post { get; set; }

        /// <summary>RFC 3339 date-time when this comment was published.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("published")]
        public virtual string Published { get; set; }

        /// <summary>The API REST URL to fetch this resource from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The status of the comment (only populated for admin users).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>RFC 3339 date-time when this comment was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string Updated { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>The author of this Comment.</summary>
        public class AuthorData
        {
            /// <summary>The display name.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
            public virtual string DisplayName { get; set; }

            /// <summary>The identifier of the creator.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }

            /// <summary>The creator's avatar.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("image")]
            public virtual ImageData Image { get; set; }

            /// <summary>The URL of the creator's Profile page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; }

            /// <summary>The creator's avatar.</summary>
            public class ImageData
            {
                /// <summary>The creator's avatar URL.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                public virtual string Url { get; set; }
            }
        }

        /// <summary>Data about the blog containing this comment.</summary>
        public class BlogData
        {
            /// <summary>The identifier of the blog containing this comment.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }
        }

        /// <summary>Data about the comment this is in reply to.</summary>
        public class InReplyToData
        {
            /// <summary>The identified of the parent of this comment.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }
        }

        /// <summary>Data about the post containing this comment.</summary>
        public class PostData
        {
            /// <summary>The identifier of the post containing this comment.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }
        }
    }

    public class CommentList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The List of Comments for a Post.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Comment> Items { get; set; }

        /// <summary>The kind of this entry. Always blogger#commentList.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Pagination token to fetch the next page, if one exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Pagination token to fetch the previous page, if one exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prevPageToken")]
        public virtual string PrevPageToken { get; set; }
    }

    public class Page : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The author of this Page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("author")]
        public virtual AuthorData Author { get; set; }

        /// <summary>Data about the blog containing this Page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blog")]
        public virtual BlogData Blog { get; set; }

        /// <summary>The body content of this Page, in HTML.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>Etag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The identifier for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The kind of this entity. Always blogger#page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>RFC 3339 date-time when this Page was published.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("published")]
        public virtual string Published { get; set; }

        /// <summary>The API REST URL to fetch this resource from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The status of the page for admin resources (either LIVE or DRAFT).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The title of this entity. This is the name displayed in the Admin user interface.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>RFC 3339 date-time when this Page was trashed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trashed")]
        public virtual string Trashed { get; set; }

        /// <summary>RFC 3339 date-time when this Page was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string Updated { get; set; }

        /// <summary>The URL that this Page is displayed at.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The author of this Page.</summary>
        public class AuthorData
        {
            /// <summary>The display name.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
            public virtual string DisplayName { get; set; }

            /// <summary>The identifier of the creator.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }

            /// <summary>The creator's avatar.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("image")]
            public virtual ImageData Image { get; set; }

            /// <summary>The URL of the creator's Profile page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; }

            /// <summary>The creator's avatar.</summary>
            public class ImageData
            {
                /// <summary>The creator's avatar URL.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                public virtual string Url { get; set; }
            }
        }

        /// <summary>Data about the blog containing this Page.</summary>
        public class BlogData
        {
            /// <summary>The identifier of the blog containing this page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }
        }
    }

    public class PageList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The list of Pages for a Blog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Page> Items { get; set; }

        /// <summary>The kind of this entity. Always blogger#pageList.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Pagination token to fetch the next page, if one exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }
    }

    public class Pageviews : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Blog Id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blogId")]
        public virtual string BlogId { get; set; }

        /// <summary>The container of posts in this blog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("counts")]
        public virtual System.Collections.Generic.IList<CountsData> Counts { get; set; }

        /// <summary>The kind of this entry. Always blogger#page_views.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>The container of posts in this blog.</summary>
        public class CountsData
        {
            /// <summary>Count of page views for the given time range.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("count")]
            public virtual System.Nullable<long> Count { get; set; }

            /// <summary>Time range the given count applies to.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("timeRange")]
            public virtual string TimeRange { get; set; }
        }
    }

    public class Post : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The author of this Post.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("author")]
        public virtual AuthorData Author { get; set; }

        /// <summary>Data about the blog containing this Post.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blog")]
        public virtual BlogData Blog { get; set; }

        /// <summary>The content of the Post. May contain HTML markup.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; }

        /// <summary>The JSON meta-data for the Post.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customMetaData")]
        public virtual string CustomMetaData { get; set; }

        /// <summary>Etag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The identifier of this Post.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Display image for the Post.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("images")]
        public virtual System.Collections.Generic.IList<ImagesData> Images { get; set; }

        /// <summary>The kind of this entity. Always blogger#post.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The list of labels this Post was tagged with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>The location for geotagged posts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual LocationData Location { get; set; }

        /// <summary>RFC 3339 date-time when this Post was published.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("published")]
        public virtual string Published { get; set; }

        /// <summary>Comment control and display setting for readers of this post.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readerComments")]
        public virtual string ReaderComments { get; set; }

        /// <summary>The container of comments on this Post.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replies")]
        public virtual RepliesData Replies { get; set; }

        /// <summary>The API REST URL to fetch this resource from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Status of the post. Only set for admin-level requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The title of the Post.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The title link URL, similar to atom's related link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("titleLink")]
        public virtual string TitleLink { get; set; }

        /// <summary>RFC 3339 date-time when this Post was last trashed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trashed")]
        public virtual string Trashed { get; set; }

        /// <summary>RFC 3339 date-time when this Post was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string Updated { get; set; }

        /// <summary>The URL where this Post is displayed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The author of this Post.</summary>
        public class AuthorData
        {
            /// <summary>The display name.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
            public virtual string DisplayName { get; set; }

            /// <summary>The identifier of the creator.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }

            /// <summary>The creator's avatar.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("image")]
            public virtual ImageData Image { get; set; }

            /// <summary>The URL of the creator's Profile page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; }

            /// <summary>The creator's avatar.</summary>
            public class ImageData
            {
                /// <summary>The creator's avatar URL.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                public virtual string Url { get; set; }
            }
        }

        /// <summary>Data about the blog containing this Post.</summary>
        public class BlogData
        {
            /// <summary>The identifier of the Blog that contains this Post.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("id")]
            public virtual string Id { get; set; }
        }

        /// <summary>Display image for the Post.</summary>
        public class ImagesData
        {
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; }
        }

        /// <summary>The location for geotagged posts.</summary>
        public class LocationData
        {
            /// <summary>Location's latitude.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("lat")]
            public virtual System.Nullable<double> Lat { get; set; }

            /// <summary>Location's longitude.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("lng")]
            public virtual System.Nullable<double> Lng { get; set; }

            /// <summary>Location name.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }

            /// <summary>Location's viewport span. Can be used when rendering a map preview.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("span")]
            public virtual string Span { get; set; }
        }

        /// <summary>The container of comments on this Post.</summary>
        public class RepliesData
        {
            /// <summary>The List of Comments for this Post.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("items")]
            public virtual System.Collections.Generic.IList<Comment> Items { get; set; }

            /// <summary>The URL of the comments on this post.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
            public virtual string SelfLink { get; set; }

            /// <summary>The count of comments on this post.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
            public virtual System.Nullable<long> TotalItems { get; set; }
        }
    }

    public class PostList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Etag of the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The list of Posts for this Blog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Post> Items { get; set; }

        /// <summary>The kind of this entity. Always blogger#postList.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Pagination token to fetch the next page, if one exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Pagination token to fetch the previous page, if one exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prevPageToken")]
        public virtual string PrevPageToken { get; set; }
    }

    public class PostPerUserInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID of the Blog that the post resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blogId")]
        public virtual string BlogId { get; set; }

        /// <summary>True if the user has Author level access to the post.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasEditAccess")]
        public virtual System.Nullable<bool> HasEditAccess { get; set; }

        /// <summary>The kind of this entity. Always blogger#postPerUserInfo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>ID of the Post resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postId")]
        public virtual string PostId { get; set; }

        /// <summary>ID of the User.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PostUserInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The kind of this entity. Always blogger#postUserInfo.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The Post resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("post")]
        public virtual Post Post { get; set; }

        /// <summary>Information about a User for the Post.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("post_user_info")]
        public virtual PostPerUserInfo PostUserInfoValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PostUserInfosList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of Posts with User information for the post, for this Blog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<PostUserInfo> Items { get; set; }

        /// <summary>The kind of this entity. Always blogger#postList.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Pagination token to fetch the next page, if one exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Profile summary information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("about")]
        public virtual string About { get; set; }

        /// <summary>The container of blogs for this user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blogs")]
        public virtual BlogsData Blogs { get; set; }

        /// <summary>The timestamp of when this profile was created, in seconds since epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string Created { get; set; }

        /// <summary>The display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The identifier for this User.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The kind of this entity. Always blogger#user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>This user's locale</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual LocaleData Locale { get; set; }

        /// <summary>The API REST URL to fetch this resource from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The user's profile page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>The container of blogs for this user.</summary>
        public class BlogsData
        {
            /// <summary>The URL of the Blogs for this user.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
            public virtual string SelfLink { get; set; }
        }

        /// <summary>This user's locale</summary>
        public class LocaleData
        {
            /// <summary>The country this blog's locale is set to.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("country")]
            public virtual string Country { get; set; }

            /// <summary>The language this blog is authored in.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("language")]
            public virtual string Language { get; set; }

            /// <summary>The language variant this blog is authored in.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("variant")]
            public virtual string Variant { get; set; }
        }
    }
}
