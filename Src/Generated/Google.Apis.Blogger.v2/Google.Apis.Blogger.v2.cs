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

namespace Google.Apis.Blogger.v2
{
    /// <summary>The Blogger Service.</summary>
    public class BloggerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

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
            Blogs = new BlogsResource(this);
            Comments = new CommentsResource(this);
            Pages = new PagesResource(this);
            Posts = new PostsResource(this);
            Users = new UsersResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://blogger.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://blogger.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "blogger";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Blogger API.</summary>
        public class Scope
        {
            /// <summary>Manage your Blogger account</summary>
            public static string Blogger = "https://www.googleapis.com/auth/blogger";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Blogger API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage your Blogger account</summary>
            public const string Blogger = "https://www.googleapis.com/auth/blogger";
        }

        /// <summary>Gets the Blogs resource.</summary>
        public virtual BlogsResource Blogs { get; }

        /// <summary>Gets the Comments resource.</summary>
        public virtual CommentsResource Comments { get; }

        /// <summary>Gets the Pages resource.</summary>
        public virtual PagesResource Pages { get; }

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
            return new GetRequest(this.service, blogId);
        }

        /// <summary>Gets a blog by id.</summary>
        public class GetRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v2.Data.Blog>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string blogId) : base(service)
            {
                BlogId = blogId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("blogId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BlogId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/blogs/{blogId}";

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
            }
        }

        /// <summary>Lists blogs by user id, possibly filtered.</summary>
        /// <param name="userId"><c>null</c></param>
        public virtual ListRequest List(string userId)
        {
            return new ListRequest(this.service, userId);
        }

        /// <summary>Lists blogs by user id, possibly filtered.</summary>
        public class ListRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v2.Data.BlogList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
            {
                UserId = userId;
                InitParameters();
            }

            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/users/{userId}/blogs";

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

        /// <summary>Gets a comment by blog id, post id and comment id.</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="postId"><c>null</c></param>
        /// <param name="commentId"><c>null</c></param>
        public virtual GetRequest Get(string blogId, string postId, string commentId)
        {
            return new GetRequest(this.service, blogId, postId, commentId);
        }

        /// <summary>Gets a comment by blog id, post id and comment id.</summary>
        public class GetRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v2.Data.Comment>
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

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/blogs/{blogId}/posts/{postId}/comments/{commentId}";

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
            }
        }

        /// <summary>Lists comments.</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="postId"><c>null</c></param>
        public virtual ListRequest List(string blogId, string postId)
        {
            return new ListRequest(this.service, blogId, postId);
        }

        /// <summary>Lists comments.</summary>
        public class ListRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v2.Data.CommentList>
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

            [Google.Apis.Util.RequestParameterAttribute("fetchBodies", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FetchBodies { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("startDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StartDate { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/blogs/{blogId}/posts/{postId}/comments";

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

        /// <summary>Gets a page by blog id and page id.</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="pageId"><c>null</c></param>
        public virtual GetRequest Get(string blogId, string pageId)
        {
            return new GetRequest(this.service, blogId, pageId);
        }

        /// <summary>Gets a page by blog id and page id.</summary>
        public class GetRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v2.Data.Page>
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

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/blogs/{blogId}/pages/{pageId}";

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
            }
        }

        /// <summary>Lists pages.</summary>
        /// <param name="blogId"><c>null</c></param>
        public virtual ListRequest List(string blogId)
        {
            return new ListRequest(this.service, blogId);
        }

        /// <summary>Lists pages.</summary>
        public class ListRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v2.Data.PageList>
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

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/blogs/{blogId}/pages";

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

        /// <summary>Gets a post by blog id and post id</summary>
        /// <param name="blogId"><c>null</c></param>
        /// <param name="postId"><c>null</c></param>
        public virtual GetRequest Get(string blogId, string postId)
        {
            return new GetRequest(this.service, blogId, postId);
        }

        /// <summary>Gets a post by blog id and post id</summary>
        public class GetRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v2.Data.Post>
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

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/blogs/{blogId}/posts/{postId}";

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
            }
        }

        /// <summary>Lists posts.</summary>
        /// <param name="blogId"><c>null</c></param>
        public virtual ListRequest List(string blogId)
        {
            return new ListRequest(this.service, blogId);
        }

        /// <summary>Lists posts.</summary>
        public class ListRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v2.Data.PostList>
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

            [Google.Apis.Util.RequestParameterAttribute("startDate", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StartDate { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v2/blogs/{blogId}/posts";

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
                RequestParameters.Add("startDate", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDate",
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

        /// <summary>Gets a user by user id.</summary>
        /// <param name="userId"><c>null</c></param>
        public virtual GetRequest Get(string userId)
        {
            return new GetRequest(this.service, userId);
        }

        /// <summary>Gets a user by user id.</summary>
        public class GetRequest : BloggerBaseServiceRequest<Google.Apis.Blogger.v2.Data.User>
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
            public override string RestPath => "v2/users/{userId}";

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
namespace Google.Apis.Blogger.v2.Data
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
