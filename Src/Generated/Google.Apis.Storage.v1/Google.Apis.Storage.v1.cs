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

namespace Google.Apis.Storage.v1
{
    /// <summary>The Storage Service.</summary>
    public class StorageService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public StorageService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public StorageService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            AnywhereCaches = new AnywhereCachesResource(this);
            BucketAccessControls = new BucketAccessControlsResource(this);
            Buckets = new BucketsResource(this);
            Channels = new ChannelsResource(this);
            DefaultObjectAccessControls = new DefaultObjectAccessControlsResource(this);
            Folders = new FoldersResource(this);
            ManagedFolders = new ManagedFoldersResource(this);
            Notifications = new NotificationsResource(this);
            ObjectAccessControls = new ObjectAccessControlsResource(this);
            Objects = new ObjectsResource(this);
            Operations = new OperationsResource(this);
            Projects = new ProjectsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://storage.googleapis.com/storage/v1/");
            BatchUri = GetEffectiveUri(null, "https://storage.googleapis.com/batch/storage/v1");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "storage";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "storage/v1/";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch/storage/v1";

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Storage JSON API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public static string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>Manage your data and permissions in Google Cloud Storage</summary>
            public static string DevstorageFullControl = "https://www.googleapis.com/auth/devstorage.full_control";

            /// <summary>View your data in Google Cloud Storage</summary>
            public static string DevstorageReadOnly = "https://www.googleapis.com/auth/devstorage.read_only";

            /// <summary>Manage your data in Google Cloud Storage</summary>
            public static string DevstorageReadWrite = "https://www.googleapis.com/auth/devstorage.read_write";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Storage JSON API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View your data across Google Cloud Platform services</summary>
            public const string CloudPlatformReadOnly = "https://www.googleapis.com/auth/cloud-platform.read-only";

            /// <summary>Manage your data and permissions in Google Cloud Storage</summary>
            public const string DevstorageFullControl = "https://www.googleapis.com/auth/devstorage.full_control";

            /// <summary>View your data in Google Cloud Storage</summary>
            public const string DevstorageReadOnly = "https://www.googleapis.com/auth/devstorage.read_only";

            /// <summary>Manage your data in Google Cloud Storage</summary>
            public const string DevstorageReadWrite = "https://www.googleapis.com/auth/devstorage.read_write";
        }

        /// <summary>Gets the AnywhereCaches resource.</summary>
        public virtual AnywhereCachesResource AnywhereCaches { get; }

        /// <summary>Gets the BucketAccessControls resource.</summary>
        public virtual BucketAccessControlsResource BucketAccessControls { get; }

        /// <summary>Gets the Buckets resource.</summary>
        public virtual BucketsResource Buckets { get; }

        /// <summary>Gets the Channels resource.</summary>
        public virtual ChannelsResource Channels { get; }

        /// <summary>Gets the DefaultObjectAccessControls resource.</summary>
        public virtual DefaultObjectAccessControlsResource DefaultObjectAccessControls { get; }

        /// <summary>Gets the Folders resource.</summary>
        public virtual FoldersResource Folders { get; }

        /// <summary>Gets the ManagedFolders resource.</summary>
        public virtual ManagedFoldersResource ManagedFolders { get; }

        /// <summary>Gets the Notifications resource.</summary>
        public virtual NotificationsResource Notifications { get; }

        /// <summary>Gets the ObjectAccessControls resource.</summary>
        public virtual ObjectAccessControlsResource ObjectAccessControls { get; }

        /// <summary>Gets the Objects resource.</summary>
        public virtual ObjectsResource Objects { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for Storage requests.</summary>
    public abstract class StorageBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new StorageBaseServiceRequest instance.</summary>
        protected StorageBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json = 0,

            /// <summary>Responses containing object data</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media = 1,
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

        /// <summary>Upload protocol for media (e.g. "media", "multipart", "resumable").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Deprecated. Please use quotaUser instead.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes Storage parameter list.</summary>
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
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
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

    /// <summary>The "anywhereCaches" collection of methods.</summary>
    public class AnywhereCachesResource
    {
        private const string Resource = "anywhereCaches";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AnywhereCachesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Disables an Anywhere Cache instance.</summary>
        /// <param name="bucket">Name of the parent bucket.</param>
        /// <param name="anywhereCacheId">The ID of requested Anywhere Cache instance.</param>
        public virtual DisableRequest Disable(string bucket, string anywhereCacheId)
        {
            return new DisableRequest(this.service, bucket, anywhereCacheId);
        }

        /// <summary>Disables an Anywhere Cache instance.</summary>
        public class DisableRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.AnywhereCache>
        {
            /// <summary>Constructs a new Disable request.</summary>
            public DisableRequest(Google.Apis.Services.IClientService service, string bucket, string anywhereCacheId) : base(service)
            {
                Bucket = bucket;
                AnywhereCacheId = anywhereCacheId;
                InitParameters();
            }

            /// <summary>Name of the parent bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>The ID of requested Anywhere Cache instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("anywhereCacheId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AnywhereCacheId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "disable";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/anywhereCaches/{anywhereCacheId}/disable";

            /// <summary>Initializes Disable parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("anywhereCacheId", new Google.Apis.Discovery.Parameter
                {
                    Name = "anywhereCacheId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the metadata of an Anywhere Cache instance.</summary>
        /// <param name="bucket">Name of the parent bucket.</param>
        /// <param name="anywhereCacheId">The ID of requested Anywhere Cache instance.</param>
        public virtual GetRequest Get(string bucket, string anywhereCacheId)
        {
            return new GetRequest(this.service, bucket, anywhereCacheId);
        }

        /// <summary>Returns the metadata of an Anywhere Cache instance.</summary>
        public class GetRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.AnywhereCache>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string bucket, string anywhereCacheId) : base(service)
            {
                Bucket = bucket;
                AnywhereCacheId = anywhereCacheId;
                InitParameters();
            }

            /// <summary>Name of the parent bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>The ID of requested Anywhere Cache instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("anywhereCacheId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AnywhereCacheId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/anywhereCaches/{anywhereCacheId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("anywhereCacheId", new Google.Apis.Discovery.Parameter
                {
                    Name = "anywhereCacheId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates an Anywhere Cache instance.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of the parent bucket.</param>
        public virtual InsertRequest Insert(Google.Apis.Storage.v1.Data.AnywhereCache body, string bucket)
        {
            return new InsertRequest(this.service, body, bucket);
        }

        /// <summary>Creates an Anywhere Cache instance.</summary>
        public class InsertRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.GoogleLongrunningOperation>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.AnywhereCache body, string bucket) : base(service)
            {
                Bucket = bucket;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the parent bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.AnywhereCache Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/anywhereCaches";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns a list of Anywhere Cache instances of the bucket matching the criteria.</summary>
        /// <param name="bucket">Name of the parent bucket.</param>
        public virtual ListRequest List(string bucket)
        {
            return new ListRequest(this.service, bucket);
        }

        /// <summary>Returns a list of Anywhere Cache instances of the bucket matching the criteria.</summary>
        public class ListRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.AnywhereCaches>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string bucket) : base(service)
            {
                Bucket = bucket;
                InitParameters();
            }

            /// <summary>Name of the parent bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>Maximum number of items to return in a single page of responses. Maximum 1000.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A previously-returned page token representing part of the larger set of results to view.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/anywhereCaches";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
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

        /// <summary>Pauses an Anywhere Cache instance.</summary>
        /// <param name="bucket">Name of the parent bucket.</param>
        /// <param name="anywhereCacheId">The ID of requested Anywhere Cache instance.</param>
        public virtual PauseRequest Pause(string bucket, string anywhereCacheId)
        {
            return new PauseRequest(this.service, bucket, anywhereCacheId);
        }

        /// <summary>Pauses an Anywhere Cache instance.</summary>
        public class PauseRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.AnywhereCache>
        {
            /// <summary>Constructs a new Pause request.</summary>
            public PauseRequest(Google.Apis.Services.IClientService service, string bucket, string anywhereCacheId) : base(service)
            {
                Bucket = bucket;
                AnywhereCacheId = anywhereCacheId;
                InitParameters();
            }

            /// <summary>Name of the parent bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>The ID of requested Anywhere Cache instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("anywhereCacheId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AnywhereCacheId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "pause";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/anywhereCaches/{anywhereCacheId}/pause";

            /// <summary>Initializes Pause parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("anywhereCacheId", new Google.Apis.Discovery.Parameter
                {
                    Name = "anywhereCacheId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Resumes a paused or disabled Anywhere Cache instance.</summary>
        /// <param name="bucket">Name of the parent bucket.</param>
        /// <param name="anywhereCacheId">The ID of requested Anywhere Cache instance.</param>
        public virtual ResumeRequest Resume(string bucket, string anywhereCacheId)
        {
            return new ResumeRequest(this.service, bucket, anywhereCacheId);
        }

        /// <summary>Resumes a paused or disabled Anywhere Cache instance.</summary>
        public class ResumeRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.AnywhereCache>
        {
            /// <summary>Constructs a new Resume request.</summary>
            public ResumeRequest(Google.Apis.Services.IClientService service, string bucket, string anywhereCacheId) : base(service)
            {
                Bucket = bucket;
                AnywhereCacheId = anywhereCacheId;
                InitParameters();
            }

            /// <summary>Name of the parent bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>The ID of requested Anywhere Cache instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("anywhereCacheId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AnywhereCacheId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "resume";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/anywhereCaches/{anywhereCacheId}/resume";

            /// <summary>Initializes Resume parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("anywhereCacheId", new Google.Apis.Discovery.Parameter
                {
                    Name = "anywhereCacheId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates the config(ttl and admissionPolicy) of an Anywhere Cache instance.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of the parent bucket.</param>
        /// <param name="anywhereCacheId">The ID of requested Anywhere Cache instance.</param>
        public virtual UpdateRequest Update(Google.Apis.Storage.v1.Data.AnywhereCache body, string bucket, string anywhereCacheId)
        {
            return new UpdateRequest(this.service, body, bucket, anywhereCacheId);
        }

        /// <summary>Updates the config(ttl and admissionPolicy) of an Anywhere Cache instance.</summary>
        public class UpdateRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.GoogleLongrunningOperation>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.AnywhereCache body, string bucket, string anywhereCacheId) : base(service)
            {
                Bucket = bucket;
                AnywhereCacheId = anywhereCacheId;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the parent bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>The ID of requested Anywhere Cache instance.</summary>
            [Google.Apis.Util.RequestParameterAttribute("anywhereCacheId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string AnywhereCacheId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.AnywhereCache Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/anywhereCaches/{anywhereCacheId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("anywhereCacheId", new Google.Apis.Discovery.Parameter
                {
                    Name = "anywhereCacheId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "bucketAccessControls" collection of methods.</summary>
    public class BucketAccessControlsResource
    {
        private const string Resource = "bucketAccessControls";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BucketAccessControlsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Permanently deletes the ACL entry for the specified entity on the specified bucket.</summary>
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="entity">
        /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress,
        /// allUsers, or allAuthenticatedUsers.
        /// </param>
        public virtual DeleteRequest Delete(string bucket, string entity)
        {
            return new DeleteRequest(this.service, bucket, entity);
        }

        /// <summary>Permanently deletes the ACL entry for the specified entity on the specified bucket.</summary>
        public class DeleteRequest : StorageBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string bucket, string entity) : base(service)
            {
                Bucket = bucket;
                Entity = entity;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId,
            /// group-emailAddress, allUsers, or allAuthenticatedUsers.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("entity", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Entity { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/acl/{entity}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("entity", new Google.Apis.Discovery.Parameter
                {
                    Name = "entity",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the ACL entry for the specified entity on the specified bucket.</summary>
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="entity">
        /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress,
        /// allUsers, or allAuthenticatedUsers.
        /// </param>
        public virtual GetRequest Get(string bucket, string entity)
        {
            return new GetRequest(this.service, bucket, entity);
        }

        /// <summary>Returns the ACL entry for the specified entity on the specified bucket.</summary>
        public class GetRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.BucketAccessControl>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string bucket, string entity) : base(service)
            {
                Bucket = bucket;
                Entity = entity;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId,
            /// group-emailAddress, allUsers, or allAuthenticatedUsers.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("entity", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Entity { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/acl/{entity}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("entity", new Google.Apis.Discovery.Parameter
                {
                    Name = "entity",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a new ACL entry on the specified bucket.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of a bucket.</param>
        public virtual InsertRequest Insert(Google.Apis.Storage.v1.Data.BucketAccessControl body, string bucket)
        {
            return new InsertRequest(this.service, body, bucket);
        }

        /// <summary>Creates a new ACL entry on the specified bucket.</summary>
        public class InsertRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.BucketAccessControl>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.BucketAccessControl body, string bucket) : base(service)
            {
                Bucket = bucket;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.BucketAccessControl Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/acl";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves ACL entries on the specified bucket.</summary>
        /// <param name="bucket">Name of a bucket.</param>
        public virtual ListRequest List(string bucket)
        {
            return new ListRequest(this.service, bucket);
        }

        /// <summary>Retrieves ACL entries on the specified bucket.</summary>
        public class ListRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.BucketAccessControls>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string bucket) : base(service)
            {
                Bucket = bucket;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/acl";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Patches an ACL entry on the specified bucket.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="entity">
        /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress,
        /// allUsers, or allAuthenticatedUsers.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Storage.v1.Data.BucketAccessControl body, string bucket, string entity)
        {
            return new PatchRequest(this.service, body, bucket, entity);
        }

        /// <summary>Patches an ACL entry on the specified bucket.</summary>
        public class PatchRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.BucketAccessControl>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.BucketAccessControl body, string bucket, string entity) : base(service)
            {
                Bucket = bucket;
                Entity = entity;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId,
            /// group-emailAddress, allUsers, or allAuthenticatedUsers.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("entity", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Entity { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.BucketAccessControl Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/acl/{entity}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("entity", new Google.Apis.Discovery.Parameter
                {
                    Name = "entity",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an ACL entry on the specified bucket.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="entity">
        /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress,
        /// allUsers, or allAuthenticatedUsers.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Storage.v1.Data.BucketAccessControl body, string bucket, string entity)
        {
            return new UpdateRequest(this.service, body, bucket, entity);
        }

        /// <summary>Updates an ACL entry on the specified bucket.</summary>
        public class UpdateRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.BucketAccessControl>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.BucketAccessControl body, string bucket, string entity) : base(service)
            {
                Bucket = bucket;
                Entity = entity;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId,
            /// group-emailAddress, allUsers, or allAuthenticatedUsers.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("entity", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Entity { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.BucketAccessControl Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/acl/{entity}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("entity", new Google.Apis.Discovery.Parameter
                {
                    Name = "entity",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "buckets" collection of methods.</summary>
    public class BucketsResource
    {
        private const string Resource = "buckets";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BucketsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Deletes an empty bucket. Deletions are permanent unless soft delete is enabled on the bucket.
        /// </summary>
        /// <param name="bucket">Name of a bucket.</param>
        public virtual DeleteRequest Delete(string bucket)
        {
            return new DeleteRequest(this.service, bucket);
        }

        /// <summary>
        /// Deletes an empty bucket. Deletions are permanent unless soft delete is enabled on the bucket.
        /// </summary>
        public class DeleteRequest : StorageBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string bucket) : base(service)
            {
                Bucket = bucket;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>If set, only deletes the bucket if its metageneration matches this value.</summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>If set, only deletes the bucket if its metageneration does not match this value.</summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns metadata for the specified bucket.</summary>
        /// <param name="bucket">Name of a bucket.</param>
        public virtual GetRequest Get(string bucket)
        {
            return new GetRequest(this.service, bucket);
        }

        /// <summary>Returns metadata for the specified bucket.</summary>
        public class GetRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Bucket>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string bucket) : base(service)
            {
                Bucket = bucket;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// If present, specifies the generation of the bucket. This is required if softDeleted is true.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("generation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Generation { get; set; }

            /// <summary>
            /// Makes the return of the bucket metadata conditional on whether the bucket's current metageneration
            /// matches the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the return of the bucket metadata conditional on whether the bucket's current metageneration does
            /// not match the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>Set of properties to return. Defaults to noAcl.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Set of properties to return. Defaults to noAcl.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Include all properties.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 0,

                /// <summary>Omit owner, acl and defaultObjectAcl properties.</summary>
                [Google.Apis.Util.StringValueAttribute("noAcl")]
                NoAcl = 1,
            }

            /// <summary>
            /// If true, return the soft-deleted version of this bucket. The default is false. For more information, see
            /// [Soft Delete](https://cloud.google.com/storage/docs/soft-delete).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("softDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SoftDeleted { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("generation", new Google.Apis.Discovery.Parameter
                {
                    Name = "generation",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("softDeleted", new Google.Apis.Discovery.Parameter
                {
                    Name = "softDeleted",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns an IAM policy for the specified bucket.</summary>
        /// <param name="bucket">Name of a bucket.</param>
        public virtual GetIamPolicyRequest GetIamPolicy(string bucket)
        {
            return new GetIamPolicyRequest(this.service, bucket);
        }

        /// <summary>Returns an IAM policy for the specified bucket.</summary>
        public class GetIamPolicyRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string bucket) : base(service)
            {
                Bucket = bucket;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// The IAM policy format version to be returned. If the optionsRequestedPolicyVersion is for an older
            /// version that doesn't support part of the requested IAM policy, the request fails.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("optionsRequestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/iam";

            /// <summary>Initializes GetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("optionsRequestedPolicyVersion", new Google.Apis.Discovery.Parameter
                {
                    Name = "optionsRequestedPolicyVersion",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Returns the storage layout configuration for the specified bucket. Note that this operation requires
        /// storage.objects.list permission.
        /// </summary>
        /// <param name="bucket">Name of a bucket.</param>
        public virtual GetStorageLayoutRequest GetStorageLayout(string bucket)
        {
            return new GetStorageLayoutRequest(this.service, bucket);
        }

        /// <summary>
        /// Returns the storage layout configuration for the specified bucket. Note that this operation requires
        /// storage.objects.list permission.
        /// </summary>
        public class GetStorageLayoutRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.BucketStorageLayout>
        {
            /// <summary>Constructs a new GetStorageLayout request.</summary>
            public GetStorageLayoutRequest(Google.Apis.Services.IClientService service, string bucket) : base(service)
            {
                Bucket = bucket;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// An optional prefix used for permission check. It is useful when the caller only has storage.objects.list
            /// permission under a specific prefix.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("prefix", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Prefix { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getStorageLayout";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/storageLayout";

            /// <summary>Initializes GetStorageLayout parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("prefix", new Google.Apis.Discovery.Parameter
                {
                    Name = "prefix",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a new bucket.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="project">A valid API project identifier.</param>
        public virtual InsertRequest Insert(Google.Apis.Storage.v1.Data.Bucket body, string project)
        {
            return new InsertRequest(this.service, body, project);
        }

        /// <summary>Creates a new bucket.</summary>
        public class InsertRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Bucket>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.Bucket body, string project) : base(service)
            {
                Project = project;
                Body = body;
                InitParameters();
            }

            /// <summary>A valid API project identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Project { get; private set; }

            /// <summary>When set to true, object retention is enabled for this bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("enableObjectRetention", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> EnableObjectRetention { get; set; }

            /// <summary>Apply a predefined set of access controls to this bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("predefinedAcl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<PredefinedAclEnum> PredefinedAcl { get; set; }

            /// <summary>Apply a predefined set of access controls to this bucket.</summary>
            public enum PredefinedAclEnum
            {
                /// <summary>
                /// Project team owners get OWNER access, and allAuthenticatedUsers get READER access.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("authenticatedRead")]
                AuthenticatedRead = 0,

                /// <summary>Project team owners get OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("private")]
                Private__ = 1,

                /// <summary>Project team members get access according to their roles.</summary>
                [Google.Apis.Util.StringValueAttribute("projectPrivate")]
                ProjectPrivate = 2,

                /// <summary>Project team owners get OWNER access, and allUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("publicRead")]
                PublicRead = 3,

                /// <summary>Project team owners get OWNER access, and allUsers get WRITER access.</summary>
                [Google.Apis.Util.StringValueAttribute("publicReadWrite")]
                PublicReadWrite = 4,
            }

            /// <summary>Apply a predefined set of default object access controls to this bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("predefinedDefaultObjectAcl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<PredefinedDefaultObjectAclEnum> PredefinedDefaultObjectAcl { get; set; }

            /// <summary>Apply a predefined set of default object access controls to this bucket.</summary>
            public enum PredefinedDefaultObjectAclEnum
            {
                /// <summary>Object owner gets OWNER access, and allAuthenticatedUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("authenticatedRead")]
                AuthenticatedRead = 0,

                /// <summary>Object owner gets OWNER access, and project team owners get OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerFullControl")]
                BucketOwnerFullControl = 1,

                /// <summary>Object owner gets OWNER access, and project team owners get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerRead")]
                BucketOwnerRead = 2,

                /// <summary>Object owner gets OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("private")]
                Private__ = 3,

                /// <summary>
                /// Object owner gets OWNER access, and project team members get access according to their roles.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("projectPrivate")]
                ProjectPrivate = 4,

                /// <summary>Object owner gets OWNER access, and allUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("publicRead")]
                PublicRead = 5,
            }

            /// <summary>
            /// Set of properties to return. Defaults to noAcl, unless the bucket resource specifies acl or
            /// defaultObjectAcl properties, when it defaults to full.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>
            /// Set of properties to return. Defaults to noAcl, unless the bucket resource specifies acl or
            /// defaultObjectAcl properties, when it defaults to full.
            /// </summary>
            public enum ProjectionEnum
            {
                /// <summary>Include all properties.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 0,

                /// <summary>Omit owner, acl and defaultObjectAcl properties.</summary>
                [Google.Apis.Util.StringValueAttribute("noAcl")]
                NoAcl = 1,
            }

            /// <summary>The project to be billed for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.Bucket Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("enableObjectRetention", new Google.Apis.Discovery.Parameter
                {
                    Name = "enableObjectRetention",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "false",
                    Pattern = null,
                });
                RequestParameters.Add("predefinedAcl", new Google.Apis.Discovery.Parameter
                {
                    Name = "predefinedAcl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("predefinedDefaultObjectAcl", new Google.Apis.Discovery.Parameter
                {
                    Name = "predefinedDefaultObjectAcl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a list of buckets for a given project.</summary>
        /// <param name="project">A valid API project identifier.</param>
        public virtual ListRequest List(string project)
        {
            return new ListRequest(this.service, project);
        }

        /// <summary>Retrieves a list of buckets for a given project.</summary>
        public class ListRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Buckets>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string project) : base(service)
            {
                Project = project;
                InitParameters();
            }

            /// <summary>A valid API project identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Project { get; private set; }

            /// <summary>
            /// Maximum number of buckets to return in a single response. The service will use this parameter or 1,000
            /// items, whichever is smaller.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// A previously-returned page token representing part of the larger set of results to view.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Filter results to buckets whose names begin with this prefix.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prefix", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Prefix { get; set; }

            /// <summary>Set of properties to return. Defaults to noAcl.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Set of properties to return. Defaults to noAcl.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Include all properties.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 0,

                /// <summary>Omit owner, acl and defaultObjectAcl properties.</summary>
                [Google.Apis.Util.StringValueAttribute("noAcl")]
                NoAcl = 1,
            }

            /// <summary>
            /// If true, only soft-deleted bucket versions will be returned. The default is false. For more information,
            /// see [Soft Delete](https://cloud.google.com/storage/docs/soft-delete).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("softDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SoftDeleted { get; set; }

            /// <summary>The project to be billed for this request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("project", new Google.Apis.Discovery.Parameter
                {
                    Name = "project",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
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
                RequestParameters.Add("prefix", new Google.Apis.Discovery.Parameter
                {
                    Name = "prefix",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("softDeleted", new Google.Apis.Discovery.Parameter
                {
                    Name = "softDeleted",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Locks retention policy on a bucket.</summary>
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="ifMetagenerationMatch">
        /// Makes the operation conditional on whether bucket's current metageneration matches the given value.
        /// </param>
        public virtual LockRetentionPolicyRequest LockRetentionPolicy(string bucket, long ifMetagenerationMatch)
        {
            return new LockRetentionPolicyRequest(this.service, bucket, ifMetagenerationMatch);
        }

        /// <summary>Locks retention policy on a bucket.</summary>
        public class LockRetentionPolicyRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Bucket>
        {
            /// <summary>Constructs a new LockRetentionPolicy request.</summary>
            public LockRetentionPolicyRequest(Google.Apis.Services.IClientService service, string bucket, long ifMetagenerationMatch) : base(service)
            {
                Bucket = bucket;
                IfMetagenerationMatch = ifMetagenerationMatch;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Makes the operation conditional on whether bucket's current metageneration matches the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual long IfMetagenerationMatch { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "lockRetentionPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/lockRetentionPolicy";

            /// <summary>Initializes LockRetentionPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Patches a bucket. Changes to the bucket will be readable immediately after writing, but configuration
        /// changes may take time to propagate.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of a bucket.</param>
        public virtual PatchRequest Patch(Google.Apis.Storage.v1.Data.Bucket body, string bucket)
        {
            return new PatchRequest(this.service, body, bucket);
        }

        /// <summary>
        /// Patches a bucket. Changes to the bucket will be readable immediately after writing, but configuration
        /// changes may take time to propagate.
        /// </summary>
        public class PatchRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Bucket>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.Bucket body, string bucket) : base(service)
            {
                Bucket = bucket;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Makes the return of the bucket metadata conditional on whether the bucket's current metageneration
            /// matches the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the return of the bucket metadata conditional on whether the bucket's current metageneration does
            /// not match the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>Apply a predefined set of access controls to this bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("predefinedAcl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<PredefinedAclEnum> PredefinedAcl { get; set; }

            /// <summary>Apply a predefined set of access controls to this bucket.</summary>
            public enum PredefinedAclEnum
            {
                /// <summary>
                /// Project team owners get OWNER access, and allAuthenticatedUsers get READER access.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("authenticatedRead")]
                AuthenticatedRead = 0,

                /// <summary>Project team owners get OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("private")]
                Private__ = 1,

                /// <summary>Project team members get access according to their roles.</summary>
                [Google.Apis.Util.StringValueAttribute("projectPrivate")]
                ProjectPrivate = 2,

                /// <summary>Project team owners get OWNER access, and allUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("publicRead")]
                PublicRead = 3,

                /// <summary>Project team owners get OWNER access, and allUsers get WRITER access.</summary>
                [Google.Apis.Util.StringValueAttribute("publicReadWrite")]
                PublicReadWrite = 4,
            }

            /// <summary>Apply a predefined set of default object access controls to this bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("predefinedDefaultObjectAcl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<PredefinedDefaultObjectAclEnum> PredefinedDefaultObjectAcl { get; set; }

            /// <summary>Apply a predefined set of default object access controls to this bucket.</summary>
            public enum PredefinedDefaultObjectAclEnum
            {
                /// <summary>Object owner gets OWNER access, and allAuthenticatedUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("authenticatedRead")]
                AuthenticatedRead = 0,

                /// <summary>Object owner gets OWNER access, and project team owners get OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerFullControl")]
                BucketOwnerFullControl = 1,

                /// <summary>Object owner gets OWNER access, and project team owners get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerRead")]
                BucketOwnerRead = 2,

                /// <summary>Object owner gets OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("private")]
                Private__ = 3,

                /// <summary>
                /// Object owner gets OWNER access, and project team members get access according to their roles.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("projectPrivate")]
                ProjectPrivate = 4,

                /// <summary>Object owner gets OWNER access, and allUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("publicRead")]
                PublicRead = 5,
            }

            /// <summary>Set of properties to return. Defaults to full.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Set of properties to return. Defaults to full.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Include all properties.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 0,

                /// <summary>Omit owner, acl and defaultObjectAcl properties.</summary>
                [Google.Apis.Util.StringValueAttribute("noAcl")]
                NoAcl = 1,
            }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.Bucket Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("predefinedAcl", new Google.Apis.Discovery.Parameter
                {
                    Name = "predefinedAcl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("predefinedDefaultObjectAcl", new Google.Apis.Discovery.Parameter
                {
                    Name = "predefinedDefaultObjectAcl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Initiates a long-running Relocate Bucket operation on the specified bucket.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of the bucket to be moved.</param>
        public virtual RelocateRequest Relocate(Google.Apis.Storage.v1.Data.RelocateBucketRequest body, string bucket)
        {
            return new RelocateRequest(this.service, body, bucket);
        }

        /// <summary>Initiates a long-running Relocate Bucket operation on the specified bucket.</summary>
        public class RelocateRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.GoogleLongrunningOperation>
        {
            /// <summary>Constructs a new Relocate request.</summary>
            public RelocateRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.RelocateBucketRequest body, string bucket) : base(service)
            {
                Bucket = bucket;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the bucket to be moved.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.RelocateBucketRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "relocate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/relocate";

            /// <summary>Initializes Relocate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Restores a soft-deleted bucket.</summary>
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="generation">Generation of a bucket.</param>
        public virtual RestoreRequest Restore(string bucket, long generation)
        {
            return new RestoreRequest(this.service, bucket, generation);
        }

        /// <summary>Restores a soft-deleted bucket.</summary>
        public class RestoreRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Bucket>
        {
            /// <summary>Constructs a new Restore request.</summary>
            public RestoreRequest(Google.Apis.Services.IClientService service, string bucket, long generation) : base(service)
            {
                Bucket = bucket;
                Generation = generation;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>Generation of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("generation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual long Generation { get; private set; }

            /// <summary>Set of properties to return. Defaults to full.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Set of properties to return. Defaults to full.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Include all properties.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 0,

                /// <summary>Omit owner, acl and defaultObjectAcl properties.</summary>
                [Google.Apis.Util.StringValueAttribute("noAcl")]
                NoAcl = 1,
            }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "restore";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/restore";

            /// <summary>Initializes Restore parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("generation", new Google.Apis.Discovery.Parameter
                {
                    Name = "generation",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an IAM policy for the specified bucket.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of a bucket.</param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Storage.v1.Data.Policy body, string bucket)
        {
            return new SetIamPolicyRequest(this.service, body, bucket);
        }

        /// <summary>Updates an IAM policy for the specified bucket.</summary>
        public class SetIamPolicyRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.Policy body, string bucket) : base(service)
            {
                Bucket = bucket;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.Policy Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/iam";

            /// <summary>Initializes SetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Tests a set of permissions on the given bucket to see which, if any, are held by the caller.
        /// </summary>
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="permissions">Permissions to test.</param>
        public virtual TestIamPermissionsRequest TestIamPermissions(string bucket, Google.Apis.Util.Repeatable<string> permissions)
        {
            return new TestIamPermissionsRequest(this.service, bucket, permissions);
        }

        /// <summary>
        /// Tests a set of permissions on the given bucket to see which, if any, are held by the caller.
        /// </summary>
        public class TestIamPermissionsRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.TestIamPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, string bucket, Google.Apis.Util.Repeatable<string> permissions) : base(service)
            {
                Bucket = bucket;
                Permissions = permissions;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>Permissions to test.</summary>
            [Google.Apis.Util.RequestParameterAttribute("permissions", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Permissions { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "testIamPermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/iam/testPermissions";

            /// <summary>Initializes TestIamPermissions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("permissions", new Google.Apis.Discovery.Parameter
                {
                    Name = "permissions",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates a bucket. Changes to the bucket will be readable immediately after writing, but configuration
        /// changes may take time to propagate.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of a bucket.</param>
        public virtual UpdateRequest Update(Google.Apis.Storage.v1.Data.Bucket body, string bucket)
        {
            return new UpdateRequest(this.service, body, bucket);
        }

        /// <summary>
        /// Updates a bucket. Changes to the bucket will be readable immediately after writing, but configuration
        /// changes may take time to propagate.
        /// </summary>
        public class UpdateRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Bucket>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.Bucket body, string bucket) : base(service)
            {
                Bucket = bucket;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Makes the return of the bucket metadata conditional on whether the bucket's current metageneration
            /// matches the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the return of the bucket metadata conditional on whether the bucket's current metageneration does
            /// not match the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>Apply a predefined set of access controls to this bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("predefinedAcl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<PredefinedAclEnum> PredefinedAcl { get; set; }

            /// <summary>Apply a predefined set of access controls to this bucket.</summary>
            public enum PredefinedAclEnum
            {
                /// <summary>
                /// Project team owners get OWNER access, and allAuthenticatedUsers get READER access.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("authenticatedRead")]
                AuthenticatedRead = 0,

                /// <summary>Project team owners get OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("private")]
                Private__ = 1,

                /// <summary>Project team members get access according to their roles.</summary>
                [Google.Apis.Util.StringValueAttribute("projectPrivate")]
                ProjectPrivate = 2,

                /// <summary>Project team owners get OWNER access, and allUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("publicRead")]
                PublicRead = 3,

                /// <summary>Project team owners get OWNER access, and allUsers get WRITER access.</summary>
                [Google.Apis.Util.StringValueAttribute("publicReadWrite")]
                PublicReadWrite = 4,
            }

            /// <summary>Apply a predefined set of default object access controls to this bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("predefinedDefaultObjectAcl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<PredefinedDefaultObjectAclEnum> PredefinedDefaultObjectAcl { get; set; }

            /// <summary>Apply a predefined set of default object access controls to this bucket.</summary>
            public enum PredefinedDefaultObjectAclEnum
            {
                /// <summary>Object owner gets OWNER access, and allAuthenticatedUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("authenticatedRead")]
                AuthenticatedRead = 0,

                /// <summary>Object owner gets OWNER access, and project team owners get OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerFullControl")]
                BucketOwnerFullControl = 1,

                /// <summary>Object owner gets OWNER access, and project team owners get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerRead")]
                BucketOwnerRead = 2,

                /// <summary>Object owner gets OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("private")]
                Private__ = 3,

                /// <summary>
                /// Object owner gets OWNER access, and project team members get access according to their roles.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("projectPrivate")]
                ProjectPrivate = 4,

                /// <summary>Object owner gets OWNER access, and allUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("publicRead")]
                PublicRead = 5,
            }

            /// <summary>Set of properties to return. Defaults to full.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Set of properties to return. Defaults to full.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Include all properties.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 0,

                /// <summary>Omit owner, acl and defaultObjectAcl properties.</summary>
                [Google.Apis.Util.StringValueAttribute("noAcl")]
                NoAcl = 1,
            }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.Bucket Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("predefinedAcl", new Google.Apis.Discovery.Parameter
                {
                    Name = "predefinedAcl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("predefinedDefaultObjectAcl", new Google.Apis.Discovery.Parameter
                {
                    Name = "predefinedDefaultObjectAcl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
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

        /// <summary>Stop watching resources through this channel</summary>
        /// <param name="body">The body of the request.</param>
        public virtual StopRequest Stop(Google.Apis.Storage.v1.Data.Channel body)
        {
            return new StopRequest(this.service, body);
        }

        /// <summary>Stop watching resources through this channel</summary>
        public class StopRequest : StorageBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Stop request.</summary>
            public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.Channel body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.Channel Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "stop";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "channels/stop";

            /// <summary>Initializes Stop parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "defaultObjectAccessControls" collection of methods.</summary>
    public class DefaultObjectAccessControlsResource
    {
        private const string Resource = "defaultObjectAccessControls";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DefaultObjectAccessControlsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Permanently deletes the default object ACL entry for the specified entity on the specified bucket.
        /// </summary>
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="entity">
        /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress,
        /// allUsers, or allAuthenticatedUsers.
        /// </param>
        public virtual DeleteRequest Delete(string bucket, string entity)
        {
            return new DeleteRequest(this.service, bucket, entity);
        }

        /// <summary>
        /// Permanently deletes the default object ACL entry for the specified entity on the specified bucket.
        /// </summary>
        public class DeleteRequest : StorageBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string bucket, string entity) : base(service)
            {
                Bucket = bucket;
                Entity = entity;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId,
            /// group-emailAddress, allUsers, or allAuthenticatedUsers.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("entity", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Entity { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/defaultObjectAcl/{entity}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("entity", new Google.Apis.Discovery.Parameter
                {
                    Name = "entity",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the default object ACL entry for the specified entity on the specified bucket.</summary>
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="entity">
        /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress,
        /// allUsers, or allAuthenticatedUsers.
        /// </param>
        public virtual GetRequest Get(string bucket, string entity)
        {
            return new GetRequest(this.service, bucket, entity);
        }

        /// <summary>Returns the default object ACL entry for the specified entity on the specified bucket.</summary>
        public class GetRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.ObjectAccessControl>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string bucket, string entity) : base(service)
            {
                Bucket = bucket;
                Entity = entity;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId,
            /// group-emailAddress, allUsers, or allAuthenticatedUsers.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("entity", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Entity { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/defaultObjectAcl/{entity}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("entity", new Google.Apis.Discovery.Parameter
                {
                    Name = "entity",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a new default object ACL entry on the specified bucket.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of a bucket.</param>
        public virtual InsertRequest Insert(Google.Apis.Storage.v1.Data.ObjectAccessControl body, string bucket)
        {
            return new InsertRequest(this.service, body, bucket);
        }

        /// <summary>Creates a new default object ACL entry on the specified bucket.</summary>
        public class InsertRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.ObjectAccessControl>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.ObjectAccessControl body, string bucket) : base(service)
            {
                Bucket = bucket;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.ObjectAccessControl Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/defaultObjectAcl";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves default object ACL entries on the specified bucket.</summary>
        /// <param name="bucket">Name of a bucket.</param>
        public virtual ListRequest List(string bucket)
        {
            return new ListRequest(this.service, bucket);
        }

        /// <summary>Retrieves default object ACL entries on the specified bucket.</summary>
        public class ListRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.ObjectAccessControls>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string bucket) : base(service)
            {
                Bucket = bucket;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// If present, only return default ACL listing if the bucket's current metageneration matches this value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>
            /// If present, only return default ACL listing if the bucket's current metageneration does not match the
            /// given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/defaultObjectAcl";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Patches a default object ACL entry on the specified bucket.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="entity">
        /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress,
        /// allUsers, or allAuthenticatedUsers.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Storage.v1.Data.ObjectAccessControl body, string bucket, string entity)
        {
            return new PatchRequest(this.service, body, bucket, entity);
        }

        /// <summary>Patches a default object ACL entry on the specified bucket.</summary>
        public class PatchRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.ObjectAccessControl>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.ObjectAccessControl body, string bucket, string entity) : base(service)
            {
                Bucket = bucket;
                Entity = entity;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId,
            /// group-emailAddress, allUsers, or allAuthenticatedUsers.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("entity", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Entity { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.ObjectAccessControl Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/defaultObjectAcl/{entity}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("entity", new Google.Apis.Discovery.Parameter
                {
                    Name = "entity",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates a default object ACL entry on the specified bucket.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="entity">
        /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress,
        /// allUsers, or allAuthenticatedUsers.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Storage.v1.Data.ObjectAccessControl body, string bucket, string entity)
        {
            return new UpdateRequest(this.service, body, bucket, entity);
        }

        /// <summary>Updates a default object ACL entry on the specified bucket.</summary>
        public class UpdateRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.ObjectAccessControl>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.ObjectAccessControl body, string bucket, string entity) : base(service)
            {
                Bucket = bucket;
                Entity = entity;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId,
            /// group-emailAddress, allUsers, or allAuthenticatedUsers.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("entity", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Entity { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.ObjectAccessControl Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/defaultObjectAcl/{entity}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("entity", new Google.Apis.Discovery.Parameter
                {
                    Name = "entity",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "folders" collection of methods.</summary>
    public class FoldersResource
    {
        private const string Resource = "folders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FoldersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Permanently deletes a folder. Only applicable to buckets with hierarchical namespace enabled.
        /// </summary>
        /// <param name="bucket">Name of the bucket in which the folder resides.</param>
        /// <param name="folder">Name of a folder.</param>
        public virtual DeleteRequest Delete(string bucket, string folder)
        {
            return new DeleteRequest(this.service, bucket, folder);
        }

        /// <summary>
        /// Permanently deletes a folder. Only applicable to buckets with hierarchical namespace enabled.
        /// </summary>
        public class DeleteRequest : StorageBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string bucket, string folder) : base(service)
            {
                Bucket = bucket;
                Folder = folder;
                InitParameters();
            }

            /// <summary>Name of the bucket in which the folder resides.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>Name of a folder.</summary>
            [Google.Apis.Util.RequestParameterAttribute("folder", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Folder { get; private set; }

            /// <summary>If set, only deletes the folder if its metageneration matches this value.</summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>If set, only deletes the folder if its metageneration does not match this value.</summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/folders/{folder}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("folder", new Google.Apis.Discovery.Parameter
                {
                    Name = "folder",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Returns metadata for the specified folder. Only applicable to buckets with hierarchical namespace enabled.
        /// </summary>
        /// <param name="bucket">Name of the bucket in which the folder resides.</param>
        /// <param name="folder">Name of a folder.</param>
        public virtual GetRequest Get(string bucket, string folder)
        {
            return new GetRequest(this.service, bucket, folder);
        }

        /// <summary>
        /// Returns metadata for the specified folder. Only applicable to buckets with hierarchical namespace enabled.
        /// </summary>
        public class GetRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Folder>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string bucket, string folder) : base(service)
            {
                Bucket = bucket;
                Folder = folder;
                InitParameters();
            }

            /// <summary>Name of the bucket in which the folder resides.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>Name of a folder.</summary>
            [Google.Apis.Util.RequestParameterAttribute("folder", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Folder { get; private set; }

            /// <summary>
            /// Makes the return of the folder metadata conditional on whether the folder's current metageneration
            /// matches the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the return of the folder metadata conditional on whether the folder's current metageneration does
            /// not match the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/folders/{folder}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("folder", new Google.Apis.Discovery.Parameter
                {
                    Name = "folder",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a new folder. Only applicable to buckets with hierarchical namespace enabled.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of the bucket in which the folder resides.</param>
        public virtual InsertRequest Insert(Google.Apis.Storage.v1.Data.Folder body, string bucket)
        {
            return new InsertRequest(this.service, body, bucket);
        }

        /// <summary>Creates a new folder. Only applicable to buckets with hierarchical namespace enabled.</summary>
        public class InsertRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Folder>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.Folder body, string bucket) : base(service)
            {
                Bucket = bucket;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the bucket in which the folder resides.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>If true, any parent folder which doesn't exist will be created automatically.</summary>
            [Google.Apis.Util.RequestParameterAttribute("recursive", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Recursive { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.Folder Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/folders";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("recursive", new Google.Apis.Discovery.Parameter
                {
                    Name = "recursive",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Retrieves a list of folders matching the criteria. Only applicable to buckets with hierarchical namespace
        /// enabled.
        /// </summary>
        /// <param name="bucket">Name of the bucket in which to look for folders.</param>
        public virtual ListRequest List(string bucket)
        {
            return new ListRequest(this.service, bucket);
        }

        /// <summary>
        /// Retrieves a list of folders matching the criteria. Only applicable to buckets with hierarchical namespace
        /// enabled.
        /// </summary>
        public class ListRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Folders>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string bucket) : base(service)
            {
                Bucket = bucket;
                InitParameters();
            }

            /// <summary>Name of the bucket in which to look for folders.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Returns results in a directory-like mode. The only supported value is '/'. If set, items will only
            /// contain folders that either exactly match the prefix, or are one level below the prefix.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("delimiter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Delimiter { get; set; }

            /// <summary>
            /// Filter results to folders whose names are lexicographically before endOffset. If startOffset is also
            /// set, the folders listed will have names between startOffset (inclusive) and endOffset (exclusive).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("endOffset", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EndOffset { get; set; }

            /// <summary>Maximum number of items to return in a single page of responses.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A previously-returned page token representing part of the larger set of results to view.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Filter results to folders whose paths begin with this prefix. If set, the value must either be an empty
            /// string or end with a '/'.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("prefix", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Prefix { get; set; }

            /// <summary>
            /// Filter results to folders whose names are lexicographically equal to or after startOffset. If endOffset
            /// is also set, the folders listed will have names between startOffset (inclusive) and endOffset
            /// (exclusive).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("startOffset", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StartOffset { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/folders";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("delimiter", new Google.Apis.Discovery.Parameter
                {
                    Name = "delimiter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("endOffset", new Google.Apis.Discovery.Parameter
                {
                    Name = "endOffset",
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
                RequestParameters.Add("prefix", new Google.Apis.Discovery.Parameter
                {
                    Name = "prefix",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startOffset", new Google.Apis.Discovery.Parameter
                {
                    Name = "startOffset",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Renames a source folder to a destination folder. Only applicable to buckets with hierarchical namespace
        /// enabled.
        /// </summary>
        /// <param name="bucket">Name of the bucket in which the folders are in.</param>
        /// <param name="sourceFolder">Name of the source folder.</param>
        /// <param name="destinationFolder">Name of the destination folder.</param>
        public virtual RenameRequest Rename(string bucket, string sourceFolder, string destinationFolder)
        {
            return new RenameRequest(this.service, bucket, sourceFolder, destinationFolder);
        }

        /// <summary>
        /// Renames a source folder to a destination folder. Only applicable to buckets with hierarchical namespace
        /// enabled.
        /// </summary>
        public class RenameRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.GoogleLongrunningOperation>
        {
            /// <summary>Constructs a new Rename request.</summary>
            public RenameRequest(Google.Apis.Services.IClientService service, string bucket, string sourceFolder, string destinationFolder) : base(service)
            {
                Bucket = bucket;
                SourceFolder = sourceFolder;
                DestinationFolder = destinationFolder;
                InitParameters();
            }

            /// <summary>Name of the bucket in which the folders are in.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>Name of the source folder.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sourceFolder", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SourceFolder { get; private set; }

            /// <summary>Name of the destination folder.</summary>
            [Google.Apis.Util.RequestParameterAttribute("destinationFolder", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DestinationFolder { get; private set; }

            /// <summary>
            /// Makes the operation conditional on whether the source object's current metageneration matches the given
            /// value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifSourceMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfSourceMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the source object's current metageneration does not match the
            /// given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifSourceMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfSourceMetagenerationNotMatch { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "rename";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/folders/{sourceFolder}/renameTo/folders/{destinationFolder}";

            /// <summary>Initializes Rename parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sourceFolder", new Google.Apis.Discovery.Parameter
                {
                    Name = "sourceFolder",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("destinationFolder", new Google.Apis.Discovery.Parameter
                {
                    Name = "destinationFolder",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifSourceMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifSourceMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifSourceMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifSourceMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "managedFolders" collection of methods.</summary>
    public class ManagedFoldersResource
    {
        private const string Resource = "managedFolders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ManagedFoldersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Permanently deletes a managed folder.</summary>
        /// <param name="bucket">Name of the bucket containing the managed folder.</param>
        /// <param name="managedFolder">The managed folder name/path.</param>
        public virtual DeleteRequest Delete(string bucket, string managedFolder)
        {
            return new DeleteRequest(this.service, bucket, managedFolder);
        }

        /// <summary>Permanently deletes a managed folder.</summary>
        public class DeleteRequest : StorageBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string bucket, string managedFolder) : base(service)
            {
                Bucket = bucket;
                ManagedFolder = managedFolder;
                InitParameters();
            }

            /// <summary>Name of the bucket containing the managed folder.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>The managed folder name/path.</summary>
            [Google.Apis.Util.RequestParameterAttribute("managedFolder", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedFolder { get; private set; }

            /// <summary>
            /// Allows the deletion of a managed folder even if it is not empty. A managed folder is empty if there are
            /// no objects or managed folders that it applies to. Callers must have storage.managedFolders.setIamPolicy
            /// permission.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("allowNonEmpty", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> AllowNonEmpty { get; set; }

            /// <summary>If set, only deletes the managed folder if its metageneration matches this value.</summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>
            /// If set, only deletes the managed folder if its metageneration does not match this value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/managedFolders/{managedFolder}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedFolder", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedFolder",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("allowNonEmpty", new Google.Apis.Discovery.Parameter
                {
                    Name = "allowNonEmpty",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns metadata of the specified managed folder.</summary>
        /// <param name="bucket">Name of the bucket containing the managed folder.</param>
        /// <param name="managedFolder">The managed folder name/path.</param>
        public virtual GetRequest Get(string bucket, string managedFolder)
        {
            return new GetRequest(this.service, bucket, managedFolder);
        }

        /// <summary>Returns metadata of the specified managed folder.</summary>
        public class GetRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.ManagedFolder>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string bucket, string managedFolder) : base(service)
            {
                Bucket = bucket;
                ManagedFolder = managedFolder;
                InitParameters();
            }

            /// <summary>Name of the bucket containing the managed folder.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>The managed folder name/path.</summary>
            [Google.Apis.Util.RequestParameterAttribute("managedFolder", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedFolder { get; private set; }

            /// <summary>
            /// Makes the return of the managed folder metadata conditional on whether the managed folder's current
            /// metageneration matches the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the return of the managed folder metadata conditional on whether the managed folder's current
            /// metageneration does not match the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/managedFolders/{managedFolder}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedFolder", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedFolder",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns an IAM policy for the specified managed folder.</summary>
        /// <param name="bucket">Name of the bucket containing the managed folder.</param>
        /// <param name="managedFolder">The managed folder name/path.</param>
        public virtual GetIamPolicyRequest GetIamPolicy(string bucket, string managedFolder)
        {
            return new GetIamPolicyRequest(this.service, bucket, managedFolder);
        }

        /// <summary>Returns an IAM policy for the specified managed folder.</summary>
        public class GetIamPolicyRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string bucket, string managedFolder) : base(service)
            {
                Bucket = bucket;
                ManagedFolder = managedFolder;
                InitParameters();
            }

            /// <summary>Name of the bucket containing the managed folder.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>The managed folder name/path.</summary>
            [Google.Apis.Util.RequestParameterAttribute("managedFolder", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedFolder { get; private set; }

            /// <summary>
            /// The IAM policy format version to be returned. If the optionsRequestedPolicyVersion is for an older
            /// version that doesn't support part of the requested IAM policy, the request fails.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("optionsRequestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/managedFolders/{managedFolder}/iam";

            /// <summary>Initializes GetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedFolder", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedFolder",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("optionsRequestedPolicyVersion", new Google.Apis.Discovery.Parameter
                {
                    Name = "optionsRequestedPolicyVersion",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a new managed folder.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of the bucket containing the managed folder.</param>
        public virtual InsertRequest Insert(Google.Apis.Storage.v1.Data.ManagedFolder body, string bucket)
        {
            return new InsertRequest(this.service, body, bucket);
        }

        /// <summary>Creates a new managed folder.</summary>
        public class InsertRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.ManagedFolder>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.ManagedFolder body, string bucket) : base(service)
            {
                Bucket = bucket;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the bucket containing the managed folder.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.ManagedFolder Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/managedFolders";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists managed folders in the given bucket.</summary>
        /// <param name="bucket">Name of the bucket containing the managed folder.</param>
        public virtual ListRequest List(string bucket)
        {
            return new ListRequest(this.service, bucket);
        }

        /// <summary>Lists managed folders in the given bucket.</summary>
        public class ListRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.ManagedFolders>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string bucket) : base(service)
            {
                Bucket = bucket;
                InitParameters();
            }

            /// <summary>Name of the bucket containing the managed folder.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>Maximum number of items to return in a single page of responses.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A previously-returned page token representing part of the larger set of results to view.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>The managed folder name/path prefix to filter the output list of results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prefix", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Prefix { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/managedFolders";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
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
                RequestParameters.Add("prefix", new Google.Apis.Discovery.Parameter
                {
                    Name = "prefix",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an IAM policy for the specified managed folder.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of the bucket containing the managed folder.</param>
        /// <param name="managedFolder">The managed folder name/path.</param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Storage.v1.Data.Policy body, string bucket, string managedFolder)
        {
            return new SetIamPolicyRequest(this.service, body, bucket, managedFolder);
        }

        /// <summary>Updates an IAM policy for the specified managed folder.</summary>
        public class SetIamPolicyRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.Policy body, string bucket, string managedFolder) : base(service)
            {
                Bucket = bucket;
                ManagedFolder = managedFolder;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the bucket containing the managed folder.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>The managed folder name/path.</summary>
            [Google.Apis.Util.RequestParameterAttribute("managedFolder", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedFolder { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.Policy Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/managedFolders/{managedFolder}/iam";

            /// <summary>Initializes SetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedFolder", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedFolder",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Tests a set of permissions on the given managed folder to see which, if any, are held by the caller.
        /// </summary>
        /// <param name="bucket">Name of the bucket containing the managed folder.</param>
        /// <param name="managedFolder">The managed folder name/path.</param>
        /// <param name="permissions">Permissions to test.</param>
        public virtual TestIamPermissionsRequest TestIamPermissions(string bucket, string managedFolder, Google.Apis.Util.Repeatable<string> permissions)
        {
            return new TestIamPermissionsRequest(this.service, bucket, managedFolder, permissions);
        }

        /// <summary>
        /// Tests a set of permissions on the given managed folder to see which, if any, are held by the caller.
        /// </summary>
        public class TestIamPermissionsRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.TestIamPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, string bucket, string managedFolder, Google.Apis.Util.Repeatable<string> permissions) : base(service)
            {
                Bucket = bucket;
                ManagedFolder = managedFolder;
                Permissions = permissions;
                InitParameters();
            }

            /// <summary>Name of the bucket containing the managed folder.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>The managed folder name/path.</summary>
            [Google.Apis.Util.RequestParameterAttribute("managedFolder", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ManagedFolder { get; private set; }

            /// <summary>Permissions to test.</summary>
            [Google.Apis.Util.RequestParameterAttribute("permissions", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Permissions { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "testIamPermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/managedFolders/{managedFolder}/iam/testPermissions";

            /// <summary>Initializes TestIamPermissions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("managedFolder", new Google.Apis.Discovery.Parameter
                {
                    Name = "managedFolder",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("permissions", new Google.Apis.Discovery.Parameter
                {
                    Name = "permissions",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "notifications" collection of methods.</summary>
    public class NotificationsResource
    {
        private const string Resource = "notifications";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public NotificationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Permanently deletes a notification subscription.</summary>
        /// <param name="bucket">The parent bucket of the notification.</param>
        /// <param name="notification">ID of the notification to delete.</param>
        public virtual DeleteRequest Delete(string bucket, string notification)
        {
            return new DeleteRequest(this.service, bucket, notification);
        }

        /// <summary>Permanently deletes a notification subscription.</summary>
        public class DeleteRequest : StorageBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string bucket, string notification) : base(service)
            {
                Bucket = bucket;
                Notification = notification;
                InitParameters();
            }

            /// <summary>The parent bucket of the notification.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>ID of the notification to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("notification", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Notification { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/notificationConfigs/{notification}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("notification", new Google.Apis.Discovery.Parameter
                {
                    Name = "notification",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>View a notification configuration.</summary>
        /// <param name="bucket">The parent bucket of the notification.</param>
        /// <param name="notification">Notification ID</param>
        public virtual GetRequest Get(string bucket, string notification)
        {
            return new GetRequest(this.service, bucket, notification);
        }

        /// <summary>View a notification configuration.</summary>
        public class GetRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Notification>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string bucket, string notification) : base(service)
            {
                Bucket = bucket;
                Notification = notification;
                InitParameters();
            }

            /// <summary>The parent bucket of the notification.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>Notification ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("notification", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Notification { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/notificationConfigs/{notification}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("notification", new Google.Apis.Discovery.Parameter
                {
                    Name = "notification",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a notification subscription for a given bucket.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">The parent bucket of the notification.</param>
        public virtual InsertRequest Insert(Google.Apis.Storage.v1.Data.Notification body, string bucket)
        {
            return new InsertRequest(this.service, body, bucket);
        }

        /// <summary>Creates a notification subscription for a given bucket.</summary>
        public class InsertRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Notification>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.Notification body, string bucket) : base(service)
            {
                Bucket = bucket;
                Body = body;
                InitParameters();
            }

            /// <summary>The parent bucket of the notification.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.Notification Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/notificationConfigs";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves a list of notification subscriptions for a given bucket.</summary>
        /// <param name="bucket">Name of a Google Cloud Storage bucket.</param>
        public virtual ListRequest List(string bucket)
        {
            return new ListRequest(this.service, bucket);
        }

        /// <summary>Retrieves a list of notification subscriptions for a given bucket.</summary>
        public class ListRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Notifications>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string bucket) : base(service)
            {
                Bucket = bucket;
                InitParameters();
            }

            /// <summary>Name of a Google Cloud Storage bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/notificationConfigs";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "objectAccessControls" collection of methods.</summary>
    public class ObjectAccessControlsResource
    {
        private const string Resource = "objectAccessControls";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ObjectAccessControlsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Permanently deletes the ACL entry for the specified entity on the specified object.</summary>
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="storageObject">
        /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding URI
        /// Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        /// <param name="entity">
        /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress,
        /// allUsers, or allAuthenticatedUsers.
        /// </param>
        public virtual DeleteRequest Delete(string bucket, string storageObject, string entity)
        {
            return new DeleteRequest(this.service, bucket, storageObject, entity);
        }

        /// <summary>Permanently deletes the ACL entry for the specified entity on the specified object.</summary>
        public class DeleteRequest : StorageBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string bucket, string storageObject, string entity) : base(service)
            {
                Bucket = bucket;
                Object = storageObject;
                Entity = entity;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding
            /// URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("object", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Object { get; private set; }

            /// <summary>
            /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId,
            /// group-emailAddress, allUsers, or allAuthenticatedUsers.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("entity", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Entity { get; private set; }

            /// <summary>
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("generation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Generation { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o/{object}/acl/{entity}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("object", new Google.Apis.Discovery.Parameter
                {
                    Name = "object",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("entity", new Google.Apis.Discovery.Parameter
                {
                    Name = "entity",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("generation", new Google.Apis.Discovery.Parameter
                {
                    Name = "generation",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Returns the ACL entry for the specified entity on the specified object.</summary>
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="storageObject">
        /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding URI
        /// Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        /// <param name="entity">
        /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress,
        /// allUsers, or allAuthenticatedUsers.
        /// </param>
        public virtual GetRequest Get(string bucket, string storageObject, string entity)
        {
            return new GetRequest(this.service, bucket, storageObject, entity);
        }

        /// <summary>Returns the ACL entry for the specified entity on the specified object.</summary>
        public class GetRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.ObjectAccessControl>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string bucket, string storageObject, string entity) : base(service)
            {
                Bucket = bucket;
                Object = storageObject;
                Entity = entity;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding
            /// URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("object", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Object { get; private set; }

            /// <summary>
            /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId,
            /// group-emailAddress, allUsers, or allAuthenticatedUsers.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("entity", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Entity { get; private set; }

            /// <summary>
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("generation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Generation { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o/{object}/acl/{entity}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("object", new Google.Apis.Discovery.Parameter
                {
                    Name = "object",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("entity", new Google.Apis.Discovery.Parameter
                {
                    Name = "entity",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("generation", new Google.Apis.Discovery.Parameter
                {
                    Name = "generation",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a new ACL entry on the specified object.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="storageObject">
        /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding URI
        /// Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.Storage.v1.Data.ObjectAccessControl body, string bucket, string storageObject)
        {
            return new InsertRequest(this.service, body, bucket, storageObject);
        }

        /// <summary>Creates a new ACL entry on the specified object.</summary>
        public class InsertRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.ObjectAccessControl>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.ObjectAccessControl body, string bucket, string storageObject) : base(service)
            {
                Bucket = bucket;
                Object = storageObject;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding
            /// URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("object", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Object { get; private set; }

            /// <summary>
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("generation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Generation { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.ObjectAccessControl Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o/{object}/acl";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("object", new Google.Apis.Discovery.Parameter
                {
                    Name = "object",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("generation", new Google.Apis.Discovery.Parameter
                {
                    Name = "generation",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves ACL entries on the specified object.</summary>
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="storageObject">
        /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding URI
        /// Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        public virtual ListRequest List(string bucket, string storageObject)
        {
            return new ListRequest(this.service, bucket, storageObject);
        }

        /// <summary>Retrieves ACL entries on the specified object.</summary>
        public class ListRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.ObjectAccessControls>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string bucket, string storageObject) : base(service)
            {
                Bucket = bucket;
                Object = storageObject;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding
            /// URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("object", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Object { get; private set; }

            /// <summary>
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("generation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Generation { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o/{object}/acl";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("object", new Google.Apis.Discovery.Parameter
                {
                    Name = "object",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("generation", new Google.Apis.Discovery.Parameter
                {
                    Name = "generation",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Patches an ACL entry on the specified object.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="storageObject">
        /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding URI
        /// Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        /// <param name="entity">
        /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress,
        /// allUsers, or allAuthenticatedUsers.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Storage.v1.Data.ObjectAccessControl body, string bucket, string storageObject, string entity)
        {
            return new PatchRequest(this.service, body, bucket, storageObject, entity);
        }

        /// <summary>Patches an ACL entry on the specified object.</summary>
        public class PatchRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.ObjectAccessControl>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.ObjectAccessControl body, string bucket, string storageObject, string entity) : base(service)
            {
                Bucket = bucket;
                Object = storageObject;
                Entity = entity;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding
            /// URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("object", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Object { get; private set; }

            /// <summary>
            /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId,
            /// group-emailAddress, allUsers, or allAuthenticatedUsers.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("entity", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Entity { get; private set; }

            /// <summary>
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("generation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Generation { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.ObjectAccessControl Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o/{object}/acl/{entity}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("object", new Google.Apis.Discovery.Parameter
                {
                    Name = "object",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("entity", new Google.Apis.Discovery.Parameter
                {
                    Name = "entity",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("generation", new Google.Apis.Discovery.Parameter
                {
                    Name = "generation",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an ACL entry on the specified object.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="storageObject">
        /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding URI
        /// Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        /// <param name="entity">
        /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress,
        /// allUsers, or allAuthenticatedUsers.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Storage.v1.Data.ObjectAccessControl body, string bucket, string storageObject, string entity)
        {
            return new UpdateRequest(this.service, body, bucket, storageObject, entity);
        }

        /// <summary>Updates an ACL entry on the specified object.</summary>
        public class UpdateRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.ObjectAccessControl>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.ObjectAccessControl body, string bucket, string storageObject, string entity) : base(service)
            {
                Bucket = bucket;
                Object = storageObject;
                Entity = entity;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of a bucket.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding
            /// URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("object", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Object { get; private set; }

            /// <summary>
            /// The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId,
            /// group-emailAddress, allUsers, or allAuthenticatedUsers.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("entity", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Entity { get; private set; }

            /// <summary>
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("generation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Generation { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.ObjectAccessControl Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o/{object}/acl/{entity}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("object", new Google.Apis.Discovery.Parameter
                {
                    Name = "object",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("entity", new Google.Apis.Discovery.Parameter
                {
                    Name = "entity",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("generation", new Google.Apis.Discovery.Parameter
                {
                    Name = "generation",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "objects" collection of methods.</summary>
    public class ObjectsResource
    {
        private const string Resource = "objects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ObjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Initiates a long-running bulk restore operation on the specified bucket.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of the bucket in which the object resides.</param>
        public virtual BulkRestoreRequest BulkRestore(Google.Apis.Storage.v1.Data.BulkRestoreObjectsRequest body, string bucket)
        {
            return new BulkRestoreRequest(this.service, body, bucket);
        }

        /// <summary>Initiates a long-running bulk restore operation on the specified bucket.</summary>
        public class BulkRestoreRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.GoogleLongrunningOperation>
        {
            /// <summary>Constructs a new BulkRestore request.</summary>
            public BulkRestoreRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.BulkRestoreObjectsRequest body, string bucket) : base(service)
            {
                Bucket = bucket;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the bucket in which the object resides.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.BulkRestoreObjectsRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "bulkRestore";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o/bulkRestore";

            /// <summary>Initializes BulkRestore parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Concatenates a list of existing objects into a new object in the same bucket.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="destinationBucket">
        /// Name of the bucket containing the source objects. The destination object is stored in this bucket.
        /// </param>
        /// <param name="destinationObject">
        /// Name of the new object. For information about how to URL encode object names to be path safe, see [Encoding
        /// URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        public virtual ComposeRequest Compose(Google.Apis.Storage.v1.Data.ComposeRequest body, string destinationBucket, string destinationObject)
        {
            return new ComposeRequest(this.service, body, destinationBucket, destinationObject);
        }

        /// <summary>Concatenates a list of existing objects into a new object in the same bucket.</summary>
        public class ComposeRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Object>
        {
            /// <summary>Constructs a new Compose request.</summary>
            public ComposeRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.ComposeRequest body, string destinationBucket, string destinationObject) : base(service)
            {
                DestinationBucket = destinationBucket;
                DestinationObject = destinationObject;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Name of the bucket containing the source objects. The destination object is stored in this bucket.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("destinationBucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DestinationBucket { get; private set; }

            /// <summary>
            /// Name of the new object. For information about how to URL encode object names to be path safe, see
            /// [Encoding URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("destinationObject", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DestinationObject { get; private set; }

            /// <summary>Apply a predefined set of access controls to the destination object.</summary>
            [Google.Apis.Util.RequestParameterAttribute("destinationPredefinedAcl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<DestinationPredefinedAclEnum> DestinationPredefinedAcl { get; set; }

            /// <summary>Apply a predefined set of access controls to the destination object.</summary>
            public enum DestinationPredefinedAclEnum
            {
                /// <summary>Object owner gets OWNER access, and allAuthenticatedUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("authenticatedRead")]
                AuthenticatedRead = 0,

                /// <summary>Object owner gets OWNER access, and project team owners get OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerFullControl")]
                BucketOwnerFullControl = 1,

                /// <summary>Object owner gets OWNER access, and project team owners get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerRead")]
                BucketOwnerRead = 2,

                /// <summary>Object owner gets OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("private")]
                Private__ = 3,

                /// <summary>
                /// Object owner gets OWNER access, and project team members get access according to their roles.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("projectPrivate")]
                ProjectPrivate = 4,

                /// <summary>Object owner gets OWNER access, and allUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("publicRead")]
                PublicRead = 5,
            }

            /// <summary>
            /// Makes the operation conditional on whether the object's current generation matches the given value.
            /// Setting to 0 makes the operation succeed only if there are no live versions of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current metageneration matches the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>
            /// Resource name of the Cloud KMS key, of the form
            /// projects/my-project/locations/global/keyRings/my-kr/cryptoKeys/my-key, that will be used to encrypt the
            /// object. Overrides the object metadata's kms_key_name value, if any.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("kmsKeyName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string KmsKeyName { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.ComposeRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "compose";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{destinationBucket}/o/{destinationObject}/compose";

            /// <summary>Initializes Compose parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("destinationBucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "destinationBucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("destinationObject", new Google.Apis.Discovery.Parameter
                {
                    Name = "destinationObject",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("destinationPredefinedAcl", new Google.Apis.Discovery.Parameter
                {
                    Name = "destinationPredefinedAcl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("kmsKeyName", new Google.Apis.Discovery.Parameter
                {
                    Name = "kmsKeyName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Copies a source object to a destination object. Optionally overrides metadata.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="sourceBucket">Name of the bucket in which to find the source object.</param>
        /// <param name="sourceObject">
        /// Name of the source object. For information about how to URL encode object names to be path safe, see
        /// [Encoding URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        /// <param name="destinationBucket">
        /// Name of the bucket in which to store the new object. Overrides the provided object metadata's bucket value,
        /// if any.For information about how to URL encode object names to be path safe, see [Encoding URI Path
        /// Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        /// <param name="destinationObject">
        /// Name of the new object. Required when the object metadata is not otherwise provided. Overrides the object
        /// metadata's name value, if any.
        /// </param>
        public virtual CopyRequest Copy(Google.Apis.Storage.v1.Data.Object body, string sourceBucket, string sourceObject, string destinationBucket, string destinationObject)
        {
            return new CopyRequest(this.service, body, sourceBucket, sourceObject, destinationBucket, destinationObject);
        }

        /// <summary>Copies a source object to a destination object. Optionally overrides metadata.</summary>
        public class CopyRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Object>
        {
            /// <summary>Constructs a new Copy request.</summary>
            public CopyRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.Object body, string sourceBucket, string sourceObject, string destinationBucket, string destinationObject) : base(service)
            {
                SourceBucket = sourceBucket;
                SourceObject = sourceObject;
                DestinationBucket = destinationBucket;
                DestinationObject = destinationObject;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the bucket in which to find the source object.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sourceBucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SourceBucket { get; private set; }

            /// <summary>
            /// Name of the source object. For information about how to URL encode object names to be path safe, see
            /// [Encoding URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sourceObject", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SourceObject { get; private set; }

            /// <summary>
            /// Name of the bucket in which to store the new object. Overrides the provided object metadata's bucket
            /// value, if any.For information about how to URL encode object names to be path safe, see [Encoding URI
            /// Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("destinationBucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DestinationBucket { get; private set; }

            /// <summary>
            /// Name of the new object. Required when the object metadata is not otherwise provided. Overrides the
            /// object metadata's name value, if any.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("destinationObject", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DestinationObject { get; private set; }

            /// <summary>
            /// Resource name of the Cloud KMS key, of the form
            /// projects/my-project/locations/global/keyRings/my-kr/cryptoKeys/my-key, that will be used to encrypt the
            /// object. Overrides the object metadata's kms_key_name value, if any.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("destinationKmsKeyName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DestinationKmsKeyName { get; set; }

            /// <summary>Apply a predefined set of access controls to the destination object.</summary>
            [Google.Apis.Util.RequestParameterAttribute("destinationPredefinedAcl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<DestinationPredefinedAclEnum> DestinationPredefinedAcl { get; set; }

            /// <summary>Apply a predefined set of access controls to the destination object.</summary>
            public enum DestinationPredefinedAclEnum
            {
                /// <summary>Object owner gets OWNER access, and allAuthenticatedUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("authenticatedRead")]
                AuthenticatedRead = 0,

                /// <summary>Object owner gets OWNER access, and project team owners get OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerFullControl")]
                BucketOwnerFullControl = 1,

                /// <summary>Object owner gets OWNER access, and project team owners get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerRead")]
                BucketOwnerRead = 2,

                /// <summary>Object owner gets OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("private")]
                Private__ = 3,

                /// <summary>
                /// Object owner gets OWNER access, and project team members get access according to their roles.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("projectPrivate")]
                ProjectPrivate = 4,

                /// <summary>Object owner gets OWNER access, and allUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("publicRead")]
                PublicRead = 5,
            }

            /// <summary>
            /// Makes the operation conditional on whether the destination object's current generation matches the given
            /// value. Setting to 0 makes the operation succeed only if there are no live versions of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the destination object's current generation does not match
            /// the given value. If no live object exists, the precondition fails. Setting to 0 makes the operation
            /// succeed only if there is a live version of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationNotMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the destination object's current metageneration matches the
            /// given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the destination object's current metageneration does not
            /// match the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the source object's current generation matches the given
            /// value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifSourceGenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfSourceGenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the source object's current generation does not match the
            /// given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifSourceGenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfSourceGenerationNotMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the source object's current metageneration matches the given
            /// value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifSourceMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfSourceMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the source object's current metageneration does not match the
            /// given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifSourceMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfSourceMetagenerationNotMatch { get; set; }

            /// <summary>
            /// Set of properties to return. Defaults to noAcl, unless the object resource specifies the acl property,
            /// when it defaults to full.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>
            /// Set of properties to return. Defaults to noAcl, unless the object resource specifies the acl property,
            /// when it defaults to full.
            /// </summary>
            public enum ProjectionEnum
            {
                /// <summary>Include all properties.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 0,

                /// <summary>Omit the owner, acl property.</summary>
                [Google.Apis.Util.StringValueAttribute("noAcl")]
                NoAcl = 1,
            }

            /// <summary>
            /// If present, selects a specific revision of the source object (as opposed to the latest version, the
            /// default).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sourceGeneration", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> SourceGeneration { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.Object Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "copy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{sourceBucket}/o/{sourceObject}/copyTo/b/{destinationBucket}/o/{destinationObject}";

            /// <summary>Initializes Copy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("sourceBucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "sourceBucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sourceObject", new Google.Apis.Discovery.Parameter
                {
                    Name = "sourceObject",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("destinationBucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "destinationBucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("destinationObject", new Google.Apis.Discovery.Parameter
                {
                    Name = "destinationObject",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("destinationKmsKeyName", new Google.Apis.Discovery.Parameter
                {
                    Name = "destinationKmsKeyName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("destinationPredefinedAcl", new Google.Apis.Discovery.Parameter
                {
                    Name = "destinationPredefinedAcl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifSourceGenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifSourceGenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifSourceGenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifSourceGenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifSourceMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifSourceMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifSourceMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifSourceMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sourceGeneration", new Google.Apis.Discovery.Parameter
                {
                    Name = "sourceGeneration",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning is not enabled for the bucket, or
        /// if the generation parameter is used.
        /// </summary>
        /// <param name="bucket">Name of the bucket in which the object resides.</param>
        /// <param name="storageObject">
        /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding URI
        /// Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        public virtual DeleteRequest Delete(string bucket, string storageObject)
        {
            return new DeleteRequest(this.service, bucket, storageObject);
        }

        /// <summary>
        /// Deletes an object and its metadata. Deletions are permanent if versioning is not enabled for the bucket, or
        /// if the generation parameter is used.
        /// </summary>
        public class DeleteRequest : StorageBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string bucket, string storageObject) : base(service)
            {
                Bucket = bucket;
                Object = storageObject;
                InitParameters();
            }

            /// <summary>Name of the bucket in which the object resides.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding
            /// URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("object", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Object { get; private set; }

            /// <summary>
            /// If present, permanently deletes a specific revision of this object (as opposed to the latest version,
            /// the default).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("generation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Generation { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current generation matches the given value.
            /// Setting to 0 makes the operation succeed only if there are no live versions of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current generation does not match the given
            /// value. If no live object exists, the precondition fails. Setting to 0 makes the operation succeed only
            /// if there is a live version of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationNotMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current metageneration matches the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current metageneration does not match the given
            /// value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o/{object}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("object", new Google.Apis.Discovery.Parameter
                {
                    Name = "object",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("generation", new Google.Apis.Discovery.Parameter
                {
                    Name = "generation",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Retrieves an object or its metadata.</summary>
        /// <param name="bucket">Name of the bucket in which the object resides.</param>
        /// <param name="storageObject">
        /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding URI
        /// Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        public virtual GetRequest Get(string bucket, string storageObject)
        {
            return new GetRequest(this.service, bucket, storageObject);
        }

        /// <summary>Retrieves an object or its metadata.</summary>
        public class GetRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Object>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string bucket, string storageObject) : base(service)
            {
                Bucket = bucket;
                Object = storageObject;
                MediaDownloader = new Google.Apis.Download.MediaDownloader(service);
                InitParameters();
            }

            /// <summary>Name of the bucket in which the object resides.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding
            /// URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("object", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Object { get; private set; }

            /// <summary>
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("generation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Generation { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current generation matches the given value.
            /// Setting to 0 makes the operation succeed only if there are no live versions of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current generation does not match the given
            /// value. If no live object exists, the precondition fails. Setting to 0 makes the operation succeed only
            /// if there is a live version of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationNotMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current metageneration matches the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current metageneration does not match the given
            /// value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>Set of properties to return. Defaults to noAcl.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Set of properties to return. Defaults to noAcl.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Include all properties.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 0,

                /// <summary>Omit the owner, acl property.</summary>
                [Google.Apis.Util.StringValueAttribute("noAcl")]
                NoAcl = 1,
            }

            /// <summary>
            /// Restore token used to differentiate soft-deleted objects with the same name and generation. Only
            /// applicable for hierarchical namespace buckets and if softDeleted is set to true. This parameter is
            /// optional, and is only required in the rare case when there are multiple soft-deleted objects with the
            /// same name and generation.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("restoreToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RestoreToken { get; set; }

            /// <summary>
            /// If true, only soft-deleted object versions will be listed. The default is false. For more information,
            /// see [Soft Delete](https://cloud.google.com/storage/docs/soft-delete).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("softDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SoftDeleted { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o/{object}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("object", new Google.Apis.Discovery.Parameter
                {
                    Name = "object",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("generation", new Google.Apis.Discovery.Parameter
                {
                    Name = "generation",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("restoreToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "restoreToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("softDeleted", new Google.Apis.Discovery.Parameter
                {
                    Name = "softDeleted",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

            /// <summary>Gets the media downloader.</summary>
            public Google.Apis.Download.IMediaDownloader MediaDownloader { get; private set; }

            /// <summary>
            /// <para>Synchronously download the media into the given stream.</para>
            /// <para>
            /// Warning: This method hides download errors; use <see cref="DownloadWithStatus(System.IO.Stream)"/>
            /// instead.
            /// </para>
            /// </summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual void Download(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Synchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            /// <returns>The final status of the download; including whether the download succeeded or failed.</returns>
            public virtual Google.Apis.Download.IDownloadProgress DownloadWithStatus(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadAsync(System.IO.Stream stream,
                System.Threading.CancellationToken cancellationToken)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = null;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }

            /// <summary>Synchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual Google.Apis.Download.IDownloadProgress DownloadRange(System.IO.Stream stream, System.Net.Http.Headers.RangeHeaderValue range)
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.Download(this.GenerateRequestUri(), stream);
            }

            /// <summary>Asynchronously download a range of the media into the given stream.</summary>
            /// <remarks>
            /// This method uses the <see cref="MediaDownloader"/> property to perform the download. Progress event
            /// handlers and other configuration may be performed using that property prior to calling this method.
            /// </remarks>
            public virtual System.Threading.Tasks.Task<Google.Apis.Download.IDownloadProgress> DownloadRangeAsync(System.IO.Stream stream,
                System.Net.Http.Headers.RangeHeaderValue range,
                System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                var mediaDownloader = (Google.Apis.Download.MediaDownloader)MediaDownloader;
                mediaDownloader.Range = range;
                return mediaDownloader.DownloadAsync(this.GenerateRequestUri(), stream, cancellationToken);
            }
        }

        /// <summary>Returns an IAM policy for the specified object.</summary>
        /// <param name="bucket">Name of the bucket in which the object resides.</param>
        /// <param name="storageObject">
        /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding URI
        /// Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        public virtual GetIamPolicyRequest GetIamPolicy(string bucket, string storageObject)
        {
            return new GetIamPolicyRequest(this.service, bucket, storageObject);
        }

        /// <summary>Returns an IAM policy for the specified object.</summary>
        public class GetIamPolicyRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Policy>
        {
            /// <summary>Constructs a new GetIamPolicy request.</summary>
            public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string bucket, string storageObject) : base(service)
            {
                Bucket = bucket;
                Object = storageObject;
                InitParameters();
            }

            /// <summary>Name of the bucket in which the object resides.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding
            /// URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("object", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Object { get; private set; }

            /// <summary>
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("generation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Generation { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o/{object}/iam";

            /// <summary>Initializes GetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("object", new Google.Apis.Discovery.Parameter
                {
                    Name = "object",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("generation", new Google.Apis.Discovery.Parameter
                {
                    Name = "generation",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Stores a new object and metadata.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">
        /// Name of the bucket in which to store the new object. Overrides the provided object metadata's bucket value,
        /// if any.
        /// </param>
        public virtual InsertRequest Insert(Google.Apis.Storage.v1.Data.Object body, string bucket)
        {
            return new InsertRequest(this.service, body, bucket);
        }

        /// <summary>Stores a new object and metadata.</summary>
        public class InsertRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Object>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.Object body, string bucket) : base(service)
            {
                Bucket = bucket;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Name of the bucket in which to store the new object. Overrides the provided object metadata's bucket
            /// value, if any.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// If set, sets the contentEncoding property of the final object to this value. Setting this parameter is
            /// equivalent to setting the contentEncoding metadata property. This can be useful when uploading an object
            /// with uploadType=media to indicate the encoding of the content being uploaded.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("contentEncoding", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ContentEncoding { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current generation matches the given value.
            /// Setting to 0 makes the operation succeed only if there are no live versions of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current generation does not match the given
            /// value. If no live object exists, the precondition fails. Setting to 0 makes the operation succeed only
            /// if there is a live version of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationNotMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current metageneration matches the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current metageneration does not match the given
            /// value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>
            /// Resource name of the Cloud KMS key, of the form
            /// projects/my-project/locations/global/keyRings/my-kr/cryptoKeys/my-key, that will be used to encrypt the
            /// object. Overrides the object metadata's kms_key_name value, if any.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("kmsKeyName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string KmsKeyName { get; set; }

            /// <summary>
            /// Name of the object. Required when the object metadata is not otherwise provided. Overrides the object
            /// metadata's name value, if any. For information about how to URL encode object names to be path safe, see
            /// [Encoding URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Name { get; set; }

            /// <summary>Apply a predefined set of access controls to this object.</summary>
            [Google.Apis.Util.RequestParameterAttribute("predefinedAcl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<PredefinedAclEnum> PredefinedAcl { get; set; }

            /// <summary>Apply a predefined set of access controls to this object.</summary>
            public enum PredefinedAclEnum
            {
                /// <summary>Object owner gets OWNER access, and allAuthenticatedUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("authenticatedRead")]
                AuthenticatedRead = 0,

                /// <summary>Object owner gets OWNER access, and project team owners get OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerFullControl")]
                BucketOwnerFullControl = 1,

                /// <summary>Object owner gets OWNER access, and project team owners get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerRead")]
                BucketOwnerRead = 2,

                /// <summary>Object owner gets OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("private")]
                Private__ = 3,

                /// <summary>
                /// Object owner gets OWNER access, and project team members get access according to their roles.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("projectPrivate")]
                ProjectPrivate = 4,

                /// <summary>Object owner gets OWNER access, and allUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("publicRead")]
                PublicRead = 5,
            }

            /// <summary>
            /// Set of properties to return. Defaults to noAcl, unless the object resource specifies the acl property,
            /// when it defaults to full.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>
            /// Set of properties to return. Defaults to noAcl, unless the object resource specifies the acl property,
            /// when it defaults to full.
            /// </summary>
            public enum ProjectionEnum
            {
                /// <summary>Include all properties.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 0,

                /// <summary>Omit the owner, acl property.</summary>
                [Google.Apis.Util.StringValueAttribute("noAcl")]
                NoAcl = 1,
            }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.Object Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("contentEncoding", new Google.Apis.Discovery.Parameter
                {
                    Name = "contentEncoding",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("kmsKeyName", new Google.Apis.Discovery.Parameter
                {
                    Name = "kmsKeyName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("predefinedAcl", new Google.Apis.Discovery.Parameter
                {
                    Name = "predefinedAcl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Stores a new object and metadata.</summary>
        /// <remarks>
        /// Considerations regarding <paramref name="stream"/>:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before reading
        /// commences. If <paramref name="stream"/> is not seekable, then it will be read from its current position
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
        /// </description>
        /// </item>
        /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
        /// </list>
        /// </remarks>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">
        /// Name of the bucket in which to store the new object. Overrides the provided object metadata's bucket value,
        /// if any.
        /// </param>
        /// <param name="stream">The stream to upload. See remarks for further information.</param>
        /// <param name="contentType">The content type of the stream to upload.</param>
        public virtual InsertMediaUpload Insert(Google.Apis.Storage.v1.Data.Object body, string bucket, System.IO.Stream stream, string contentType)
        {
            return new InsertMediaUpload(service, body, bucket, stream, contentType);
        }

        /// <summary>Insert media upload which supports resumable upload.</summary>
        public class InsertMediaUpload : Google.Apis.Upload.ResumableUpload<Google.Apis.Storage.v1.Data.Object, Google.Apis.Storage.v1.Data.Object>
        {
            /// <summary>Data format for the response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<AltEnum> Alt { get; set; }

            /// <summary>Data format for the response.</summary>
            public enum AltEnum
            {
                /// <summary>Responses with Content-Type of application/json</summary>
                [Google.Apis.Util.StringValueAttribute("json")]
                Json = 0,

                /// <summary>Responses containing object data</summary>
                [Google.Apis.Util.StringValueAttribute("media")]
                Media = 1,
            }

            /// <summary>Selector specifying which fields to include in a partial response.</summary>
            [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Fields { get; set; }

            /// <summary>
            /// API key. Your API key identifies your project and provides you with API access, quota, and reports.
            /// Required unless you provide an OAuth 2.0 token.
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

            /// <summary>Upload protocol for media (e.g. "media", "multipart", "resumable").</summary>
            [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UploadType { get; set; }

            /// <summary>Deprecated. Please use quotaUser instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserIp { get; set; }

            /// <summary>
            /// Name of the bucket in which to store the new object. Overrides the provided object metadata's bucket
            /// value, if any.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// If set, sets the contentEncoding property of the final object to this value. Setting this parameter is
            /// equivalent to setting the contentEncoding metadata property. This can be useful when uploading an object
            /// with uploadType=media to indicate the encoding of the content being uploaded.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("contentEncoding", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ContentEncoding { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current generation matches the given value.
            /// Setting to 0 makes the operation succeed only if there are no live versions of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current generation does not match the given
            /// value. If no live object exists, the precondition fails. Setting to 0 makes the operation succeed only
            /// if there is a live version of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationNotMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current metageneration matches the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current metageneration does not match the given
            /// value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>
            /// Resource name of the Cloud KMS key, of the form
            /// projects/my-project/locations/global/keyRings/my-kr/cryptoKeys/my-key, that will be used to encrypt the
            /// object. Overrides the object metadata's kms_key_name value, if any.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("kmsKeyName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string KmsKeyName { get; set; }

            /// <summary>
            /// Name of the object. Required when the object metadata is not otherwise provided. Overrides the object
            /// metadata's name value, if any. For information about how to URL encode object names to be path safe, see
            /// [Encoding URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Name { get; set; }

            /// <summary>Apply a predefined set of access controls to this object.</summary>
            [Google.Apis.Util.RequestParameterAttribute("predefinedAcl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<PredefinedAclEnum> PredefinedAcl { get; set; }

            /// <summary>Apply a predefined set of access controls to this object.</summary>
            public enum PredefinedAclEnum
            {
                /// <summary>Object owner gets OWNER access, and allAuthenticatedUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("authenticatedRead")]
                AuthenticatedRead = 0,

                /// <summary>Object owner gets OWNER access, and project team owners get OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerFullControl")]
                BucketOwnerFullControl = 1,

                /// <summary>Object owner gets OWNER access, and project team owners get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerRead")]
                BucketOwnerRead = 2,

                /// <summary>Object owner gets OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("private")]
                Private__ = 3,

                /// <summary>
                /// Object owner gets OWNER access, and project team members get access according to their roles.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("projectPrivate")]
                ProjectPrivate = 4,

                /// <summary>Object owner gets OWNER access, and allUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("publicRead")]
                PublicRead = 5,
            }

            /// <summary>
            /// Set of properties to return. Defaults to noAcl, unless the object resource specifies the acl property,
            /// when it defaults to full.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>
            /// Set of properties to return. Defaults to noAcl, unless the object resource specifies the acl property,
            /// when it defaults to full.
            /// </summary>
            public enum ProjectionEnum
            {
                /// <summary>Include all properties.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 0,

                /// <summary>Omit the owner, acl property.</summary>
                [Google.Apis.Util.StringValueAttribute("noAcl")]
                NoAcl = 1,
            }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Constructs a new Insert media upload instance.</summary>
            /// <remarks>
            /// Considerations regarding <paramref name="stream"/>:
            /// <list type="bullet">
            /// <item>
            /// <description>
            /// If <paramref name="stream"/> is seekable, then the stream position will be reset to <c>0</c> before
            /// reading commences. If <paramref name="stream"/> is not seekable, then it will be read from its current
            /// position
            /// </description>
            /// </item>
            /// <item>
            /// <description>
            /// Caller is responsible for maintaining the <paramref name="stream"/> open until the upload is completed
            /// </description>
            /// </item>
            /// <item><description>Caller is responsible for closing the <paramref name="stream"/></description></item>
            /// </list>
            /// </remarks>
            public InsertMediaUpload(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.Object body, string bucket, System.IO.Stream stream, string contentType)
                : base(service, string.Format("/{0}/{1}{2}", "upload", service.BasePath, "b/{bucket}/o"), "POST", stream, contentType)
            {
                Bucket = bucket;
                Body = body;
            }
        }

        /// <summary>Retrieves a list of objects matching the criteria.</summary>
        /// <param name="bucket">Name of the bucket in which to look for objects.</param>
        public virtual ListRequest List(string bucket)
        {
            return new ListRequest(this.service, bucket);
        }

        /// <summary>Retrieves a list of objects matching the criteria.</summary>
        public class ListRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Objects>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string bucket) : base(service)
            {
                Bucket = bucket;
                InitParameters();
            }

            /// <summary>Name of the bucket in which to look for objects.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Returns results in a directory-like mode. items will contain only objects whose names, aside from the
            /// prefix, do not contain delimiter. Objects whose names, aside from the prefix, contain delimiter will
            /// have their name, truncated after the delimiter, returned in prefixes. Duplicate prefixes are omitted.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("delimiter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Delimiter { get; set; }

            /// <summary>
            /// Filter results to objects whose names are lexicographically before endOffset. If startOffset is also
            /// set, the objects listed will have names between startOffset (inclusive) and endOffset (exclusive).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("endOffset", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EndOffset { get; set; }

            /// <summary>
            /// Filter the returned objects. Currently only supported for the contexts field. If delimiter is set, the
            /// returned prefixes are exempt from this filter.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Only applicable if delimiter is set to '/'. If true, will also include folders and managed folders
            /// (besides objects) in the returned prefixes.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeFoldersAsPrefixes", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeFoldersAsPrefixes { get; set; }

            /// <summary>
            /// If true, objects that end in exactly one instance of delimiter will have their metadata included in
            /// items in addition to prefixes.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeTrailingDelimiter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeTrailingDelimiter { get; set; }

            /// <summary>Filter results to objects and prefixes that match this glob pattern.</summary>
            [Google.Apis.Util.RequestParameterAttribute("matchGlob", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string MatchGlob { get; set; }

            /// <summary>
            /// Maximum number of items plus prefixes to return in a single page of responses. As duplicate prefixes are
            /// omitted, fewer total results may be returned than requested. The service will use this parameter or
            /// 1,000 items, whichever is smaller.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// A previously-returned page token representing part of the larger set of results to view.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Filter results to objects whose names begin with this prefix.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prefix", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Prefix { get; set; }

            /// <summary>Set of properties to return. Defaults to noAcl.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Set of properties to return. Defaults to noAcl.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Include all properties.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 0,

                /// <summary>Omit the owner, acl property.</summary>
                [Google.Apis.Util.StringValueAttribute("noAcl")]
                NoAcl = 1,
            }

            /// <summary>
            /// If true, only soft-deleted object versions will be listed. The default is false. For more information,
            /// see [Soft Delete](https://cloud.google.com/storage/docs/soft-delete).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("softDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> SoftDeleted { get; set; }

            /// <summary>
            /// Filter results to objects whose names are lexicographically equal to or after startOffset. If endOffset
            /// is also set, the objects listed will have names between startOffset (inclusive) and endOffset
            /// (exclusive).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("startOffset", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StartOffset { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>
            /// If true, lists all versions of an object as distinct results. The default is false. For more
            /// information, see [Object Versioning](https://cloud.google.com/storage/docs/object-versioning).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("versions", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Versions { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("delimiter", new Google.Apis.Discovery.Parameter
                {
                    Name = "delimiter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("endOffset", new Google.Apis.Discovery.Parameter
                {
                    Name = "endOffset",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeFoldersAsPrefixes", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeFoldersAsPrefixes",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeTrailingDelimiter", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeTrailingDelimiter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("matchGlob", new Google.Apis.Discovery.Parameter
                {
                    Name = "matchGlob",
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
                RequestParameters.Add("prefix", new Google.Apis.Discovery.Parameter
                {
                    Name = "prefix",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("softDeleted", new Google.Apis.Discovery.Parameter
                {
                    Name = "softDeleted",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startOffset", new Google.Apis.Discovery.Parameter
                {
                    Name = "startOffset",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("versions", new Google.Apis.Discovery.Parameter
                {
                    Name = "versions",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Moves the source object to the destination object in the same bucket.</summary>
        /// <param name="bucket">Name of the bucket in which the object resides.</param>
        /// <param name="sourceObject">
        /// Name of the source object. For information about how to URL encode object names to be path safe, see
        /// [Encoding URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        /// <param name="destinationObject">
        /// Name of the destination object. For information about how to URL encode object names to be path safe, see
        /// [Encoding URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        public virtual MoveRequest Move(string bucket, string sourceObject, string destinationObject)
        {
            return new MoveRequest(this.service, bucket, sourceObject, destinationObject);
        }

        /// <summary>Moves the source object to the destination object in the same bucket.</summary>
        public class MoveRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Object>
        {
            /// <summary>Constructs a new Move request.</summary>
            public MoveRequest(Google.Apis.Services.IClientService service, string bucket, string sourceObject, string destinationObject) : base(service)
            {
                Bucket = bucket;
                SourceObject = sourceObject;
                DestinationObject = destinationObject;
                InitParameters();
            }

            /// <summary>Name of the bucket in which the object resides.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Name of the source object. For information about how to URL encode object names to be path safe, see
            /// [Encoding URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sourceObject", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SourceObject { get; private set; }

            /// <summary>
            /// Name of the destination object. For information about how to URL encode object names to be path safe,
            /// see [Encoding URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("destinationObject", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DestinationObject { get; private set; }

            /// <summary>
            /// Makes the operation conditional on whether the destination object's current generation matches the given
            /// value. Setting to 0 makes the operation succeed only if there are no live versions of the object.
            /// `ifGenerationMatch` and `ifGenerationNotMatch` conditions are mutually exclusive: it's an error for both
            /// of them to be set in the request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the destination object's current generation does not match
            /// the given value. If no live object exists, the precondition fails. Setting to 0 makes the operation
            /// succeed only if there is a live version of the object.`ifGenerationMatch` and `ifGenerationNotMatch`
            /// conditions are mutually exclusive: it's an error for both of them to be set in the request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationNotMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the destination object's current metageneration matches the
            /// given value. `ifMetagenerationMatch` and `ifMetagenerationNotMatch` conditions are mutually exclusive:
            /// it's an error for both of them to be set in the request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the destination object's current metageneration does not
            /// match the given value. `ifMetagenerationMatch` and `ifMetagenerationNotMatch` conditions are mutually
            /// exclusive: it's an error for both of them to be set in the request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the source object's current generation matches the given
            /// value. `ifSourceGenerationMatch` and `ifSourceGenerationNotMatch` conditions are mutually exclusive:
            /// it's an error for both of them to be set in the request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifSourceGenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfSourceGenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the source object's current generation does not match the
            /// given value. `ifSourceGenerationMatch` and `ifSourceGenerationNotMatch` conditions are mutually
            /// exclusive: it's an error for both of them to be set in the request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifSourceGenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfSourceGenerationNotMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the source object's current metageneration matches the given
            /// value. `ifSourceMetagenerationMatch` and `ifSourceMetagenerationNotMatch` conditions are mutually
            /// exclusive: it's an error for both of them to be set in the request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifSourceMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfSourceMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the source object's current metageneration does not match the
            /// given value. `ifSourceMetagenerationMatch` and `ifSourceMetagenerationNotMatch` conditions are mutually
            /// exclusive: it's an error for both of them to be set in the request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifSourceMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfSourceMetagenerationNotMatch { get; set; }

            /// <summary>Set of properties to return. Defaults to noAcl.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Set of properties to return. Defaults to noAcl.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Include all properties.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 0,

                /// <summary>Omit the owner, acl property.</summary>
                [Google.Apis.Util.StringValueAttribute("noAcl")]
                NoAcl = 1,
            }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "move";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o/{sourceObject}/moveTo/o/{destinationObject}";

            /// <summary>Initializes Move parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sourceObject", new Google.Apis.Discovery.Parameter
                {
                    Name = "sourceObject",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("destinationObject", new Google.Apis.Discovery.Parameter
                {
                    Name = "destinationObject",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifSourceGenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifSourceGenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifSourceGenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifSourceGenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifSourceMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifSourceMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifSourceMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifSourceMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Patches an object's metadata.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of the bucket in which the object resides.</param>
        /// <param name="storageObject">
        /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding URI
        /// Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Storage.v1.Data.Object body, string bucket, string storageObject)
        {
            return new PatchRequest(this.service, body, bucket, storageObject);
        }

        /// <summary>Patches an object's metadata.</summary>
        public class PatchRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Object>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.Object body, string bucket, string storageObject) : base(service)
            {
                Bucket = bucket;
                Object = storageObject;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the bucket in which the object resides.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding
            /// URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("object", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Object { get; private set; }

            /// <summary>
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("generation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Generation { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current generation matches the given value.
            /// Setting to 0 makes the operation succeed only if there are no live versions of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current generation does not match the given
            /// value. If no live object exists, the precondition fails. Setting to 0 makes the operation succeed only
            /// if there is a live version of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationNotMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current metageneration matches the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current metageneration does not match the given
            /// value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>
            /// Must be true to remove the retention configuration, reduce its unlocked retention period, or change its
            /// mode from unlocked to locked.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("overrideUnlockedRetention", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> OverrideUnlockedRetention { get; set; }

            /// <summary>Apply a predefined set of access controls to this object.</summary>
            [Google.Apis.Util.RequestParameterAttribute("predefinedAcl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<PredefinedAclEnum> PredefinedAcl { get; set; }

            /// <summary>Apply a predefined set of access controls to this object.</summary>
            public enum PredefinedAclEnum
            {
                /// <summary>Object owner gets OWNER access, and allAuthenticatedUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("authenticatedRead")]
                AuthenticatedRead = 0,

                /// <summary>Object owner gets OWNER access, and project team owners get OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerFullControl")]
                BucketOwnerFullControl = 1,

                /// <summary>Object owner gets OWNER access, and project team owners get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerRead")]
                BucketOwnerRead = 2,

                /// <summary>Object owner gets OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("private")]
                Private__ = 3,

                /// <summary>
                /// Object owner gets OWNER access, and project team members get access according to their roles.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("projectPrivate")]
                ProjectPrivate = 4,

                /// <summary>Object owner gets OWNER access, and allUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("publicRead")]
                PublicRead = 5,
            }

            /// <summary>Set of properties to return. Defaults to full.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Set of properties to return. Defaults to full.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Include all properties.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 0,

                /// <summary>Omit the owner, acl property.</summary>
                [Google.Apis.Util.StringValueAttribute("noAcl")]
                NoAcl = 1,
            }

            /// <summary>The project to be billed for this request, for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.Object Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o/{object}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("object", new Google.Apis.Discovery.Parameter
                {
                    Name = "object",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("generation", new Google.Apis.Discovery.Parameter
                {
                    Name = "generation",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("overrideUnlockedRetention", new Google.Apis.Discovery.Parameter
                {
                    Name = "overrideUnlockedRetention",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("predefinedAcl", new Google.Apis.Discovery.Parameter
                {
                    Name = "predefinedAcl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Restores a soft-deleted object.</summary>
        /// <param name="bucket">Name of the bucket in which the object resides.</param>
        /// <param name="storageObject">
        /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding URI
        /// Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        /// <param name="generation">Selects a specific revision of this object.</param>
        public virtual RestoreRequest Restore(string bucket, string storageObject, long generation)
        {
            return new RestoreRequest(this.service, bucket, storageObject, generation);
        }

        /// <summary>Restores a soft-deleted object.</summary>
        public class RestoreRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Object>
        {
            /// <summary>Constructs a new Restore request.</summary>
            public RestoreRequest(Google.Apis.Services.IClientService service, string bucket, string storageObject, long generation) : base(service)
            {
                Bucket = bucket;
                Object = storageObject;
                Generation = generation;
                InitParameters();
            }

            /// <summary>Name of the bucket in which the object resides.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding
            /// URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("object", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Object { get; private set; }

            /// <summary>Selects a specific revision of this object.</summary>
            [Google.Apis.Util.RequestParameterAttribute("generation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual long Generation { get; private set; }

            /// <summary>
            /// If true, copies the source object's ACL; otherwise, uses the bucket's default object ACL. The default is
            /// false.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("copySourceAcl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> CopySourceAcl { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's one live generation matches the given value.
            /// Setting to 0 makes the operation succeed only if there are no live versions of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether none of the object's live generations match the given value.
            /// If no live object exists, the precondition fails. Setting to 0 makes the operation succeed only if there
            /// is a live version of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationNotMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's one live metageneration matches the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether none of the object's live metagenerations match the given
            /// value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>Set of properties to return. Defaults to full.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Set of properties to return. Defaults to full.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Include all properties.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 0,

                /// <summary>Omit the owner, acl property.</summary>
                [Google.Apis.Util.StringValueAttribute("noAcl")]
                NoAcl = 1,
            }

            /// <summary>
            /// Restore token used to differentiate sof-deleted objects with the same name and generation. Only
            /// applicable for hierarchical namespace buckets. This parameter is optional, and is only required in the
            /// rare case when there are multiple soft-deleted objects with the same name and generation.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("restoreToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RestoreToken { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "restore";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o/{object}/restore";

            /// <summary>Initializes Restore parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("object", new Google.Apis.Discovery.Parameter
                {
                    Name = "object",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("generation", new Google.Apis.Discovery.Parameter
                {
                    Name = "generation",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("copySourceAcl", new Google.Apis.Discovery.Parameter
                {
                    Name = "copySourceAcl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("restoreToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "restoreToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Rewrites a source object to a destination object. Optionally overrides metadata.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="sourceBucket">Name of the bucket in which to find the source object.</param>
        /// <param name="sourceObject">
        /// Name of the source object. For information about how to URL encode object names to be path safe, see
        /// [Encoding URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        /// <param name="destinationBucket">
        /// Name of the bucket in which to store the new object. Overrides the provided object metadata's bucket value,
        /// if any.
        /// </param>
        /// <param name="destinationObject">
        /// Name of the new object. Required when the object metadata is not otherwise provided. Overrides the object
        /// metadata's name value, if any. For information about how to URL encode object names to be path safe, see
        /// [Encoding URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        public virtual RewriteRequest Rewrite(Google.Apis.Storage.v1.Data.Object body, string sourceBucket, string sourceObject, string destinationBucket, string destinationObject)
        {
            return new RewriteRequest(this.service, body, sourceBucket, sourceObject, destinationBucket, destinationObject);
        }

        /// <summary>Rewrites a source object to a destination object. Optionally overrides metadata.</summary>
        public class RewriteRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.RewriteResponse>
        {
            /// <summary>Constructs a new Rewrite request.</summary>
            public RewriteRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.Object body, string sourceBucket, string sourceObject, string destinationBucket, string destinationObject) : base(service)
            {
                SourceBucket = sourceBucket;
                SourceObject = sourceObject;
                DestinationBucket = destinationBucket;
                DestinationObject = destinationObject;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the bucket in which to find the source object.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sourceBucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SourceBucket { get; private set; }

            /// <summary>
            /// Name of the source object. For information about how to URL encode object names to be path safe, see
            /// [Encoding URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sourceObject", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SourceObject { get; private set; }

            /// <summary>
            /// Name of the bucket in which to store the new object. Overrides the provided object metadata's bucket
            /// value, if any.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("destinationBucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DestinationBucket { get; private set; }

            /// <summary>
            /// Name of the new object. Required when the object metadata is not otherwise provided. Overrides the
            /// object metadata's name value, if any. For information about how to URL encode object names to be path
            /// safe, see [Encoding URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("destinationObject", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DestinationObject { get; private set; }

            /// <summary>
            /// Resource name of the Cloud KMS key, of the form
            /// projects/my-project/locations/global/keyRings/my-kr/cryptoKeys/my-key, that will be used to encrypt the
            /// object. Overrides the object metadata's kms_key_name value, if any.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("destinationKmsKeyName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string DestinationKmsKeyName { get; set; }

            /// <summary>Apply a predefined set of access controls to the destination object.</summary>
            [Google.Apis.Util.RequestParameterAttribute("destinationPredefinedAcl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<DestinationPredefinedAclEnum> DestinationPredefinedAcl { get; set; }

            /// <summary>Apply a predefined set of access controls to the destination object.</summary>
            public enum DestinationPredefinedAclEnum
            {
                /// <summary>Object owner gets OWNER access, and allAuthenticatedUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("authenticatedRead")]
                AuthenticatedRead = 0,

                /// <summary>Object owner gets OWNER access, and project team owners get OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerFullControl")]
                BucketOwnerFullControl = 1,

                /// <summary>Object owner gets OWNER access, and project team owners get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerRead")]
                BucketOwnerRead = 2,

                /// <summary>Object owner gets OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("private")]
                Private__ = 3,

                /// <summary>
                /// Object owner gets OWNER access, and project team members get access according to their roles.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("projectPrivate")]
                ProjectPrivate = 4,

                /// <summary>Object owner gets OWNER access, and allUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("publicRead")]
                PublicRead = 5,
            }

            /// <summary>
            /// Makes the operation conditional on whether the object's current generation matches the given value.
            /// Setting to 0 makes the operation succeed only if there are no live versions of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current generation does not match the given
            /// value. If no live object exists, the precondition fails. Setting to 0 makes the operation succeed only
            /// if there is a live version of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationNotMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the destination object's current metageneration matches the
            /// given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the destination object's current metageneration does not
            /// match the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the source object's current generation matches the given
            /// value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifSourceGenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfSourceGenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the source object's current generation does not match the
            /// given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifSourceGenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfSourceGenerationNotMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the source object's current metageneration matches the given
            /// value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifSourceMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfSourceMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the source object's current metageneration does not match the
            /// given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifSourceMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfSourceMetagenerationNotMatch { get; set; }

            /// <summary>
            /// The maximum number of bytes that will be rewritten per rewrite request. Most callers shouldn't need to
            /// specify this parameter - it is primarily in place to support testing. If specified the value must be an
            /// integral multiple of 1 MiB (1048576). Also, this only applies to requests where the source and
            /// destination span locations and/or storage classes. Finally, this value must not change across rewrite
            /// calls else you'll get an error that the rewriteToken is invalid.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxBytesRewrittenPerCall", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxBytesRewrittenPerCall { get; set; }

            /// <summary>
            /// Set of properties to return. Defaults to noAcl, unless the object resource specifies the acl property,
            /// when it defaults to full.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>
            /// Set of properties to return. Defaults to noAcl, unless the object resource specifies the acl property,
            /// when it defaults to full.
            /// </summary>
            public enum ProjectionEnum
            {
                /// <summary>Include all properties.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 0,

                /// <summary>Omit the owner, acl property.</summary>
                [Google.Apis.Util.StringValueAttribute("noAcl")]
                NoAcl = 1,
            }

            /// <summary>
            /// Include this field (from the previous rewrite response) on each rewrite request after the first one,
            /// until the rewrite response 'done' flag is true. Calls that provide a rewriteToken can omit all other
            /// request fields, but if included those fields must match the values provided in the first rewrite
            /// request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("rewriteToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RewriteToken { get; set; }

            /// <summary>
            /// If present, selects a specific revision of the source object (as opposed to the latest version, the
            /// default).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("sourceGeneration", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> SourceGeneration { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.Object Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "rewrite";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{sourceBucket}/o/{sourceObject}/rewriteTo/b/{destinationBucket}/o/{destinationObject}";

            /// <summary>Initializes Rewrite parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("sourceBucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "sourceBucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sourceObject", new Google.Apis.Discovery.Parameter
                {
                    Name = "sourceObject",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("destinationBucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "destinationBucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("destinationObject", new Google.Apis.Discovery.Parameter
                {
                    Name = "destinationObject",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("destinationKmsKeyName", new Google.Apis.Discovery.Parameter
                {
                    Name = "destinationKmsKeyName",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("destinationPredefinedAcl", new Google.Apis.Discovery.Parameter
                {
                    Name = "destinationPredefinedAcl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifSourceGenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifSourceGenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifSourceGenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifSourceGenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifSourceMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifSourceMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifSourceMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifSourceMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxBytesRewrittenPerCall", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxBytesRewrittenPerCall",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("rewriteToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "rewriteToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sourceGeneration", new Google.Apis.Discovery.Parameter
                {
                    Name = "sourceGeneration",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an IAM policy for the specified object.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of the bucket in which the object resides.</param>
        /// <param name="storageObject">
        /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding URI
        /// Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Storage.v1.Data.Policy body, string bucket, string storageObject)
        {
            return new SetIamPolicyRequest(this.service, body, bucket, storageObject);
        }

        /// <summary>Updates an IAM policy for the specified object.</summary>
        public class SetIamPolicyRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Policy>
        {
            /// <summary>Constructs a new SetIamPolicy request.</summary>
            public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.Policy body, string bucket, string storageObject) : base(service)
            {
                Bucket = bucket;
                Object = storageObject;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the bucket in which the object resides.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding
            /// URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("object", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Object { get; private set; }

            /// <summary>
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("generation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Generation { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.Policy Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "setIamPolicy";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o/{object}/iam";

            /// <summary>Initializes SetIamPolicy parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("object", new Google.Apis.Discovery.Parameter
                {
                    Name = "object",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("generation", new Google.Apis.Discovery.Parameter
                {
                    Name = "generation",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Tests a set of permissions on the given object to see which, if any, are held by the caller.
        /// </summary>
        /// <param name="bucket">Name of the bucket in which the object resides.</param>
        /// <param name="storageObject">
        /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding URI
        /// Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        /// <param name="permissions">Permissions to test.</param>
        public virtual TestIamPermissionsRequest TestIamPermissions(string bucket, string storageObject, Google.Apis.Util.Repeatable<string> permissions)
        {
            return new TestIamPermissionsRequest(this.service, bucket, storageObject, permissions);
        }

        /// <summary>
        /// Tests a set of permissions on the given object to see which, if any, are held by the caller.
        /// </summary>
        public class TestIamPermissionsRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.TestIamPermissionsResponse>
        {
            /// <summary>Constructs a new TestIamPermissions request.</summary>
            public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, string bucket, string storageObject, Google.Apis.Util.Repeatable<string> permissions) : base(service)
            {
                Bucket = bucket;
                Object = storageObject;
                Permissions = permissions;
                InitParameters();
            }

            /// <summary>Name of the bucket in which the object resides.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding
            /// URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("object", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Object { get; private set; }

            /// <summary>Permissions to test.</summary>
            [Google.Apis.Util.RequestParameterAttribute("permissions", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Permissions { get; private set; }

            /// <summary>
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("generation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Generation { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "testIamPermissions";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o/{object}/iam/testPermissions";

            /// <summary>Initializes TestIamPermissions parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("object", new Google.Apis.Discovery.Parameter
                {
                    Name = "object",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("permissions", new Google.Apis.Discovery.Parameter
                {
                    Name = "permissions",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("generation", new Google.Apis.Discovery.Parameter
                {
                    Name = "generation",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Updates an object's metadata.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of the bucket in which the object resides.</param>
        /// <param name="storageObject">
        /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding URI
        /// Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Storage.v1.Data.Object body, string bucket, string storageObject)
        {
            return new UpdateRequest(this.service, body, bucket, storageObject);
        }

        /// <summary>Updates an object's metadata.</summary>
        public class UpdateRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Object>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.Object body, string bucket, string storageObject) : base(service)
            {
                Bucket = bucket;
                Object = storageObject;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the bucket in which the object resides.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Name of the object. For information about how to URL encode object names to be path safe, see [Encoding
            /// URI Path Parts](https://cloud.google.com/storage/docs/request-endpoints#encoding).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("object", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Object { get; private set; }

            /// <summary>
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("generation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> Generation { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current generation matches the given value.
            /// Setting to 0 makes the operation succeed only if there are no live versions of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current generation does not match the given
            /// value. If no live object exists, the precondition fails. Setting to 0 makes the operation succeed only
            /// if there is a live version of the object.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifGenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfGenerationNotMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current metageneration matches the given value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationMatch { get; set; }

            /// <summary>
            /// Makes the operation conditional on whether the object's current metageneration does not match the given
            /// value.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("ifMetagenerationNotMatch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> IfMetagenerationNotMatch { get; set; }

            /// <summary>
            /// Must be true to remove the retention configuration, reduce its unlocked retention period, or change its
            /// mode from unlocked to locked.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("overrideUnlockedRetention", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> OverrideUnlockedRetention { get; set; }

            /// <summary>Apply a predefined set of access controls to this object.</summary>
            [Google.Apis.Util.RequestParameterAttribute("predefinedAcl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<PredefinedAclEnum> PredefinedAcl { get; set; }

            /// <summary>Apply a predefined set of access controls to this object.</summary>
            public enum PredefinedAclEnum
            {
                /// <summary>Object owner gets OWNER access, and allAuthenticatedUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("authenticatedRead")]
                AuthenticatedRead = 0,

                /// <summary>Object owner gets OWNER access, and project team owners get OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerFullControl")]
                BucketOwnerFullControl = 1,

                /// <summary>Object owner gets OWNER access, and project team owners get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("bucketOwnerRead")]
                BucketOwnerRead = 2,

                /// <summary>Object owner gets OWNER access.</summary>
                [Google.Apis.Util.StringValueAttribute("private")]
                Private__ = 3,

                /// <summary>
                /// Object owner gets OWNER access, and project team members get access according to their roles.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("projectPrivate")]
                ProjectPrivate = 4,

                /// <summary>Object owner gets OWNER access, and allUsers get READER access.</summary>
                [Google.Apis.Util.StringValueAttribute("publicRead")]
                PublicRead = 5,
            }

            /// <summary>Set of properties to return. Defaults to full.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Set of properties to return. Defaults to full.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Include all properties.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 0,

                /// <summary>Omit the owner, acl property.</summary>
                [Google.Apis.Util.StringValueAttribute("noAcl")]
                NoAcl = 1,
            }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.Object Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o/{object}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("object", new Google.Apis.Discovery.Parameter
                {
                    Name = "object",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("generation", new Google.Apis.Discovery.Parameter
                {
                    Name = "generation",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifGenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifGenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ifMetagenerationNotMatch", new Google.Apis.Discovery.Parameter
                {
                    Name = "ifMetagenerationNotMatch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("overrideUnlockedRetention", new Google.Apis.Discovery.Parameter
                {
                    Name = "overrideUnlockedRetention",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("predefinedAcl", new Google.Apis.Discovery.Parameter
                {
                    Name = "predefinedAcl",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Watch for changes on all objects in a bucket.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of the bucket in which to look for objects.</param>
        public virtual WatchAllRequest WatchAll(Google.Apis.Storage.v1.Data.Channel body, string bucket)
        {
            return new WatchAllRequest(this.service, body, bucket);
        }

        /// <summary>Watch for changes on all objects in a bucket.</summary>
        public class WatchAllRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.Channel>
        {
            /// <summary>Constructs a new WatchAll request.</summary>
            public WatchAllRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.Channel body, string bucket) : base(service)
            {
                Bucket = bucket;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the bucket in which to look for objects.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// Returns results in a directory-like mode. items will contain only objects whose names, aside from the
            /// prefix, do not contain delimiter. Objects whose names, aside from the prefix, contain delimiter will
            /// have their name, truncated after the delimiter, returned in prefixes. Duplicate prefixes are omitted.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("delimiter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Delimiter { get; set; }

            /// <summary>
            /// Filter results to objects whose names are lexicographically before endOffset. If startOffset is also
            /// set, the objects listed will have names between startOffset (inclusive) and endOffset (exclusive).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("endOffset", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EndOffset { get; set; }

            /// <summary>
            /// If true, objects that end in exactly one instance of delimiter will have their metadata included in
            /// items in addition to prefixes.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeTrailingDelimiter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeTrailingDelimiter { get; set; }

            /// <summary>
            /// Maximum number of items plus prefixes to return in a single page of responses. As duplicate prefixes are
            /// omitted, fewer total results may be returned than requested. The service will use this parameter or
            /// 1,000 items, whichever is smaller.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>
            /// A previously-returned page token representing part of the larger set of results to view.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Filter results to objects whose names begin with this prefix.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prefix", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Prefix { get; set; }

            /// <summary>Set of properties to return. Defaults to noAcl.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Set of properties to return. Defaults to noAcl.</summary>
            public enum ProjectionEnum
            {
                /// <summary>Include all properties.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full = 0,

                /// <summary>Omit the owner, acl property.</summary>
                [Google.Apis.Util.StringValueAttribute("noAcl")]
                NoAcl = 1,
            }

            /// <summary>
            /// Filter results to objects whose names are lexicographically equal to or after startOffset. If endOffset
            /// is also set, the objects listed will have names between startOffset (inclusive) and endOffset
            /// (exclusive).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("startOffset", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StartOffset { get; set; }

            /// <summary>The project to be billed for this request. Required for Requester Pays buckets.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserProject { get; set; }

            /// <summary>
            /// If true, lists all versions of an object as distinct results. The default is false. For more
            /// information, see [Object Versioning](https://cloud.google.com/storage/docs/object-versioning).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("versions", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Versions { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.Channel Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "watchAll";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/o/watch";

            /// <summary>Initializes WatchAll parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("delimiter", new Google.Apis.Discovery.Parameter
                {
                    Name = "delimiter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("endOffset", new Google.Apis.Discovery.Parameter
                {
                    Name = "endOffset",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeTrailingDelimiter", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeTrailingDelimiter",
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
                RequestParameters.Add("prefix", new Google.Apis.Discovery.Parameter
                {
                    Name = "prefix",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("projection", new Google.Apis.Discovery.Parameter
                {
                    Name = "projection",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startOffset", new Google.Apis.Discovery.Parameter
                {
                    Name = "startOffset",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                {
                    Name = "userProject",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("versions", new Google.Apis.Discovery.Parameter
                {
                    Name = "versions",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

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
        /// Starts asynchronous advancement of the relocate bucket operation in the case of required write downtime, to
        /// allow it to lock the bucket at the source location, and proceed with the bucket location swap. The server
        /// makes a best effort to advance the relocate bucket operation, but success is not guaranteed.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="bucket">Name of the bucket to advance the relocate for.</param>
        /// <param name="operationId">ID of the operation resource.</param>
        public virtual AdvanceRelocateBucketRequest AdvanceRelocateBucket(Google.Apis.Storage.v1.Data.AdvanceRelocateBucketOperationRequest body, string bucket, string operationId)
        {
            return new AdvanceRelocateBucketRequest(this.service, body, bucket, operationId);
        }

        /// <summary>
        /// Starts asynchronous advancement of the relocate bucket operation in the case of required write downtime, to
        /// allow it to lock the bucket at the source location, and proceed with the bucket location swap. The server
        /// makes a best effort to advance the relocate bucket operation, but success is not guaranteed.
        /// </summary>
        public class AdvanceRelocateBucketRequest : StorageBaseServiceRequest<string>
        {
            /// <summary>Constructs a new AdvanceRelocateBucket request.</summary>
            public AdvanceRelocateBucketRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.AdvanceRelocateBucketOperationRequest body, string bucket, string operationId) : base(service)
            {
                Bucket = bucket;
                OperationId = operationId;
                Body = body;
                InitParameters();
            }

            /// <summary>Name of the bucket to advance the relocate for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>ID of the operation resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("operationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OperationId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Storage.v1.Data.AdvanceRelocateBucketOperationRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "advanceRelocateBucket";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/operations/{operationId}/advanceRelocateBucket";

            /// <summary>Initializes AdvanceRelocateBucket parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("operationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "operationId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed.
        /// </summary>
        /// <param name="bucket">The parent bucket of the operation resource.</param>
        /// <param name="operationId">The ID of the operation resource.</param>
        public virtual CancelRequest Cancel(string bucket, string operationId)
        {
            return new CancelRequest(this.service, bucket, operationId);
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed.
        /// </summary>
        public class CancelRequest : StorageBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Cancel request.</summary>
            public CancelRequest(Google.Apis.Services.IClientService service, string bucket, string operationId) : base(service)
            {
                Bucket = bucket;
                OperationId = operationId;
                InitParameters();
            }

            /// <summary>The parent bucket of the operation resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>The ID of the operation resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("operationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OperationId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "cancel";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/operations/{operationId}/cancel";

            /// <summary>Initializes Cancel parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("operationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "operationId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Gets the latest state of a long-running operation.</summary>
        /// <param name="bucket">The parent bucket of the operation resource.</param>
        /// <param name="operationId">The ID of the operation resource.</param>
        public virtual GetRequest Get(string bucket, string operationId)
        {
            return new GetRequest(this.service, bucket, operationId);
        }

        /// <summary>Gets the latest state of a long-running operation.</summary>
        public class GetRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.GoogleLongrunningOperation>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string bucket, string operationId) : base(service)
            {
                Bucket = bucket;
                OperationId = operationId;
                InitParameters();
            }

            /// <summary>The parent bucket of the operation resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>The ID of the operation resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("operationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OperationId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/operations/{operationId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("operationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "operationId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Lists operations that match the specified filter in the request.</summary>
        /// <param name="bucket">Name of the bucket in which to look for operations.</param>
        public virtual ListRequest List(string bucket)
        {
            return new ListRequest(this.service, bucket);
        }

        /// <summary>Lists operations that match the specified filter in the request.</summary>
        public class ListRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.GoogleLongrunningListOperationsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string bucket) : base(service)
            {
                Bucket = bucket;
                InitParameters();
            }

            /// <summary>Name of the bucket in which to look for operations.</summary>
            [Google.Apis.Util.RequestParameterAttribute("bucket", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Bucket { get; private set; }

            /// <summary>
            /// A filter to narrow down results to a preferred subset. The filtering language is documented in more
            /// detail in [AIP-160](https://google.aip.dev/160).
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>
            /// Maximum number of items to return in a single page of responses. Fewer total results may be returned
            /// than requested. The service uses this parameter or 100 items, whichever is smaller.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// A previously-returned page token representing part of the larger set of results to view.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "b/{bucket}/operations";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("bucket", new Google.Apis.Discovery.Parameter
                {
                    Name = "bucket",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
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
            HmacKeys = new HmacKeysResource(service);
            ServiceAccount = new ServiceAccountResource(service);
        }

        /// <summary>Gets the HmacKeys resource.</summary>
        public virtual HmacKeysResource HmacKeys { get; }

        /// <summary>The "hmacKeys" collection of methods.</summary>
        public class HmacKeysResource
        {
            private const string Resource = "hmacKeys";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public HmacKeysResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a new HMAC key for the specified service account.</summary>
            /// <param name="projectId">Project ID owning the service account.</param>
            /// <param name="serviceAccountEmail">Email address of the service account.</param>
            public virtual CreateRequest Create(string projectId, string serviceAccountEmail)
            {
                return new CreateRequest(this.service, projectId, serviceAccountEmail);
            }

            /// <summary>Creates a new HMAC key for the specified service account.</summary>
            public class CreateRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.HmacKey>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, string projectId, string serviceAccountEmail) : base(service)
                {
                    ProjectId = projectId;
                    ServiceAccountEmail = serviceAccountEmail;
                    InitParameters();
                }

                /// <summary>Project ID owning the service account.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>Email address of the service account.</summary>
                [Google.Apis.Util.RequestParameterAttribute("serviceAccountEmail", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ServiceAccountEmail { get; private set; }

                /// <summary>The project to be billed for this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UserProject { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "projects/{projectId}/hmacKeys";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("serviceAccountEmail", new Google.Apis.Discovery.Parameter
                    {
                        Name = "serviceAccountEmail",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userProject",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes an HMAC key.</summary>
            /// <param name="projectId">Project ID owning the requested key</param>
            /// <param name="accessId">Name of the HMAC key to be deleted.</param>
            public virtual DeleteRequest Delete(string projectId, string accessId)
            {
                return new DeleteRequest(this.service, projectId, accessId);
            }

            /// <summary>Deletes an HMAC key.</summary>
            public class DeleteRequest : StorageBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string projectId, string accessId) : base(service)
                {
                    ProjectId = projectId;
                    AccessId = accessId;
                    InitParameters();
                }

                /// <summary>Project ID owning the requested key</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>Name of the HMAC key to be deleted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accessId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccessId { get; private set; }

                /// <summary>The project to be billed for this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UserProject { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "projects/{projectId}/hmacKeys/{accessId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("accessId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accessId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userProject",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Retrieves an HMAC key's metadata</summary>
            /// <param name="projectId">Project ID owning the service account of the requested key.</param>
            /// <param name="accessId">Name of the HMAC key.</param>
            public virtual GetRequest Get(string projectId, string accessId)
            {
                return new GetRequest(this.service, projectId, accessId);
            }

            /// <summary>Retrieves an HMAC key's metadata</summary>
            public class GetRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.HmacKeyMetadata>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string projectId, string accessId) : base(service)
                {
                    ProjectId = projectId;
                    AccessId = accessId;
                    InitParameters();
                }

                /// <summary>Project ID owning the service account of the requested key.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>Name of the HMAC key.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accessId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccessId { get; private set; }

                /// <summary>The project to be billed for this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UserProject { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "projects/{projectId}/hmacKeys/{accessId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("accessId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accessId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userProject",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Retrieves a list of HMAC keys matching the criteria.</summary>
            /// <param name="projectId">Name of the project in which to look for HMAC keys.</param>
            public virtual ListRequest List(string projectId)
            {
                return new ListRequest(this.service, projectId);
            }

            /// <summary>Retrieves a list of HMAC keys matching the criteria.</summary>
            public class ListRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.HmacKeysMetadata>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string projectId) : base(service)
                {
                    ProjectId = projectId;
                    InitParameters();
                }

                /// <summary>Name of the project in which to look for HMAC keys.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>
                /// Maximum number of items to return in a single page of responses. The service uses this parameter or
                /// 250 items, whichever is smaller. The max number of items per page will also be limited by the number
                /// of distinct service accounts in the response. If the number of service accounts in a single response
                /// is too high, the page will truncated and a next page token will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults { get; set; }

                /// <summary>
                /// A previously-returned page token representing part of the larger set of results to view.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>If present, only keys for the given service account are returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("serviceAccountEmail", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ServiceAccountEmail { get; set; }

                /// <summary>Whether or not to show keys in the DELETED state.</summary>
                [Google.Apis.Util.RequestParameterAttribute("showDeletedKeys", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> ShowDeletedKeys { get; set; }

                /// <summary>The project to be billed for this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UserProject { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "projects/{projectId}/hmacKeys";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
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
                        DefaultValue = "250",
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
                    RequestParameters.Add("serviceAccountEmail", new Google.Apis.Discovery.Parameter
                    {
                        Name = "serviceAccountEmail",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("showDeletedKeys", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showDeletedKeys",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userProject",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates the state of an HMAC key. See the [HMAC Key resource
            /// descriptor](https://cloud.google.com/storage/docs/json_api/v1/projects/hmacKeys/update#request-body) for
            /// valid states.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="projectId">Project ID owning the service account of the updated key.</param>
            /// <param name="accessId">Name of the HMAC key being updated.</param>
            public virtual UpdateRequest Update(Google.Apis.Storage.v1.Data.HmacKeyMetadata body, string projectId, string accessId)
            {
                return new UpdateRequest(this.service, body, projectId, accessId);
            }

            /// <summary>
            /// Updates the state of an HMAC key. See the [HMAC Key resource
            /// descriptor](https://cloud.google.com/storage/docs/json_api/v1/projects/hmacKeys/update#request-body) for
            /// valid states.
            /// </summary>
            public class UpdateRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.HmacKeyMetadata>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Storage.v1.Data.HmacKeyMetadata body, string projectId, string accessId) : base(service)
                {
                    ProjectId = projectId;
                    AccessId = accessId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Project ID owning the service account of the updated key.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>Name of the HMAC key being updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("accessId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string AccessId { get; private set; }

                /// <summary>The project to be billed for this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UserProject { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Storage.v1.Data.HmacKeyMetadata Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "projects/{projectId}/hmacKeys/{accessId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("accessId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accessId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userProject",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the ServiceAccount resource.</summary>
        public virtual ServiceAccountResource ServiceAccount { get; }

        /// <summary>The "serviceAccount" collection of methods.</summary>
        public class ServiceAccountResource
        {
            private const string Resource = "serviceAccount";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ServiceAccountResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Get the email address of this project's Google Cloud Storage service account.</summary>
            /// <param name="projectId">Project ID</param>
            public virtual GetRequest Get(string projectId)
            {
                return new GetRequest(this.service, projectId);
            }

            /// <summary>Get the email address of this project's Google Cloud Storage service account.</summary>
            public class GetRequest : StorageBaseServiceRequest<Google.Apis.Storage.v1.Data.ServiceAccount>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string projectId) : base(service)
                {
                    ProjectId = projectId;
                    InitParameters();
                }

                /// <summary>Project ID</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>The project to be billed for this request.</summary>
                [Google.Apis.Util.RequestParameterAttribute("userProject", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string UserProject { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "projects/{projectId}/serviceAccount";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("userProject", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userProject",
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
namespace Google.Apis.Storage.v1.Data
{
    /// <summary>An AdvanceRelocateBucketOperation request.</summary>
    public class AdvanceRelocateBucketOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the time when the relocation will revert to the sync stage if the relocation hasn't succeeded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual string ExpireTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExpireTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ExpireTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExpireTimeDateTimeOffset instead.")]
        public virtual System.DateTime? ExpireTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ExpireTimeRaw);
            set => ExpireTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// Specifies the duration after which the relocation will revert to the sync stage if the relocation hasn't
        /// succeeded. Optional, if not supplied, a default value of 12h will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An Anywhere Cache instance.</summary>
    public class AnywhereCache : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cache-level entry admission policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("admissionPolicy")]
        public virtual string AdmissionPolicy { get; set; }

        /// <summary>The ID of the Anywhere cache instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anywhereCacheId")]
        public virtual string AnywhereCacheId { get; set; }

        /// <summary>The name of the bucket containing this cache instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>The creation time of the cache instance in RFC 3339 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual System.DateTime? CreateTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The ID of the resource, including the project number, bucket name and anywhere cache ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The kind of item this is. For Anywhere Cache, this is always storage#anywhereCache.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>True if the cache instance has an active Update long-running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingUpdate")]
        public virtual System.Nullable<bool> PendingUpdate { get; set; }

        /// <summary>The link to this cache instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The current state of the cache instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The TTL of all cache entries in whole seconds. e.g., "7200s". </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>The modification time of the cache instance metadata in RFC 3339 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual System.DateTime? UpdateTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The zone in which the cache instance is running. For example, us-central1-a.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of Anywhere Caches.</summary>
    public class AnywhereCaches : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<AnywhereCache> Items { get; set; }

        /// <summary>
        /// The kind of item this is. For lists of Anywhere Caches, this is always storage#anywhereCaches.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The continuation token, used to page through large result sets. Provide this value in a subsequent request
        /// to return the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A bucket.</summary>
    public class Bucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Access controls on the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acl")]
        public virtual System.Collections.Generic.IList<BucketAccessControl> Acl { get; set; }

        /// <summary>The bucket's Autoclass configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoclass")]
        public virtual AutoclassData Autoclass { get; set; }

        /// <summary>The bucket's billing configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billing")]
        public virtual BillingData Billing { get; set; }

        /// <summary>The bucket's Cross-Origin Resource Sharing (CORS) configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cors")]
        public virtual System.Collections.Generic.IList<CorsData> Cors { get; set; }

        /// <summary>The bucket's custom placement configuration for Custom Dual Regions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customPlacementConfig")]
        public virtual CustomPlacementConfigData CustomPlacementConfig { get; set; }

        /// <summary>
        /// The default value for event-based hold on newly created objects in this bucket. Event-based hold is a way to
        /// retain objects indefinitely until an event occurs, signified by the hold's release. After being released,
        /// such objects will be subject to bucket-level retention (if any). One sample use case of this flag is for
        /// banks to hold loan documents for at least 3 years after loan is paid in full. Here, bucket-level retention
        /// is 3 years and the event is loan being paid in full. In this example, these objects will be held intact for
        /// any number of years until the event has occurred (event-based hold on the object is released) and then 3
        /// more years after that. That means retention duration of the objects begins from the moment event-based hold
        /// transitioned from true to false. Objects under event-based hold cannot be deleted, overwritten or archived
        /// until the hold is removed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultEventBasedHold")]
        public virtual System.Nullable<bool> DefaultEventBasedHold { get; set; }

        /// <summary>Default access controls to apply to new objects when no ACL is provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultObjectAcl")]
        public virtual System.Collections.Generic.IList<ObjectAccessControl> DefaultObjectAcl { get; set; }

        /// <summary>Encryption configuration for a bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryption")]
        public virtual EncryptionData Encryption { get; set; }

        /// <summary>HTTP 1.1 Entity tag for the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The generation of this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>The hard delete time of the bucket in RFC 3339 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hardDeleteTime")]
        public virtual string HardDeleteTimeRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="HardDeleteTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? HardDeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(HardDeleteTimeRaw);
            set => HardDeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="HardDeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use HardDeleteTimeDateTimeOffset instead.")]
        public virtual System.DateTime? HardDeleteTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(HardDeleteTimeRaw);
            set => HardDeleteTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The bucket's hierarchical namespace configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hierarchicalNamespace")]
        public virtual HierarchicalNamespaceData HierarchicalNamespace { get; set; }

        /// <summary>The bucket's IAM configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iamConfiguration")]
        public virtual IamConfigurationData IamConfiguration { get; set; }

        /// <summary>The ID of the bucket. For buckets, the id and name properties are the same.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The bucket's IP filter configuration. Specifies the network sources that are allowed to access the
        /// operations on the bucket, as well as its underlying objects. Only enforced when the mode is set to
        /// 'Enabled'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipFilter")]
        public virtual IpFilterData IpFilter { get; set; }

        /// <summary>The kind of item this is. For buckets, this is always storage#bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>User-provided labels, in key/value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The bucket's lifecycle configuration. See [Lifecycle
        /// Management](https://cloud.google.com/storage/docs/lifecycle) for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifecycle")]
        public virtual LifecycleData Lifecycle { get; set; }

        /// <summary>
        /// The location of the bucket. Object data for objects in the bucket resides in physical storage within this
        /// region. Defaults to US. See the [Developer's Guide](https://cloud.google.com/storage/docs/locations) for the
        /// authoritative list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The type of the bucket location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationType")]
        public virtual string LocationType { get; set; }

        /// <summary>
        /// The bucket's logging configuration, which defines the destination bucket and optional name prefix for the
        /// current bucket's logs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logging")]
        public virtual LoggingData Logging { get; set; }

        /// <summary>The metadata generation of this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metageneration")]
        public virtual System.Nullable<long> Metageneration { get; set; }

        /// <summary>The name of the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The bucket's object retention config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectRetention")]
        public virtual ObjectRetentionData ObjectRetention { get; set; }

        /// <summary>The owner of the bucket. This is always the project team's owner group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("owner")]
        public virtual OwnerData Owner { get; set; }

        /// <summary>The project number of the project the bucket belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectNumber")]
        public virtual System.Nullable<ulong> ProjectNumber { get; set; }

        /// <summary>
        /// The bucket's retention policy. The retention policy enforces a minimum retention time for all objects
        /// contained in the bucket, based on their creation time. Any attempt to overwrite or delete objects younger
        /// than the retention period will result in a PERMISSION_DENIED error. An unlocked retention policy can be
        /// modified or removed from the bucket via a storage.buckets.update operation. A locked retention policy cannot
        /// be removed or shortened in duration for the lifetime of the bucket. Attempting to remove or decrease period
        /// of a locked retention policy will result in a PERMISSION_DENIED error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionPolicy")]
        public virtual RetentionPolicyData RetentionPolicy { get; set; }

        /// <summary>
        /// The Recovery Point Objective (RPO) of this bucket. Set to ASYNC_TURBO to turn on Turbo Replication on a
        /// bucket.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rpo")]
        public virtual string Rpo { get; set; }

        /// <summary>Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPZI")]
        public virtual System.Nullable<bool> SatisfiesPZI { get; set; }

        /// <summary>Reserved for future use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("satisfiesPZS")]
        public virtual System.Nullable<bool> SatisfiesPZS { get; set; }

        /// <summary>The URI of this bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// The bucket's soft delete policy, which defines the period of time that soft-deleted objects will be
        /// retained, and cannot be permanently deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softDeletePolicy")]
        public virtual SoftDeletePolicyData SoftDeletePolicy { get; set; }

        /// <summary>The soft delete time of the bucket in RFC 3339 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softDeleteTime")]
        public virtual string SoftDeleteTimeRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="SoftDeleteTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SoftDeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(SoftDeleteTimeRaw);
            set => SoftDeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="SoftDeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SoftDeleteTimeDateTimeOffset instead.")]
        public virtual System.DateTime? SoftDeleteTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(SoftDeleteTimeRaw);
            set => SoftDeleteTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// The bucket's default storage class, used whenever no storageClass is specified for a newly-created object.
        /// This defines how objects in the bucket are stored and determines the SLA and the cost of storage. Values
        /// include MULTI_REGIONAL, REGIONAL, STANDARD, NEARLINE, COLDLINE, ARCHIVE, and DURABLE_REDUCED_AVAILABILITY.
        /// If this value is not specified when the bucket is created, it will default to STANDARD. For more
        /// information, see [Storage Classes](https://cloud.google.com/storage/docs/storage-classes).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageClass")]
        public virtual string StorageClass { get; set; }

        /// <summary>The creation time of the bucket in RFC 3339 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeCreated")]
        public virtual string TimeCreatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="TimeCreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimeCreatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(TimeCreatedRaw);
            set => TimeCreatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="TimeCreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimeCreatedDateTimeOffset instead.")]
        public virtual System.DateTime? TimeCreated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(TimeCreatedRaw);
            set => TimeCreatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The modification time of the bucket in RFC 3339 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdatedDateTimeOffset instead.")]
        public virtual System.DateTime? Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The bucket's versioning configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versioning")]
        public virtual VersioningData Versioning { get; set; }

        /// <summary>
        /// The bucket's website configuration, controlling how the service behaves when accessing bucket contents as a
        /// web site. See the [Static Website Examples](https://cloud.google.com/storage/docs/static-website) for more
        /// information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("website")]
        public virtual WebsiteData Website { get; set; }

        /// <summary>The bucket's Autoclass configuration.</summary>
        public class AutoclassData
        {
            /// <summary>Whether or not Autoclass is enabled on this bucket</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
            public virtual System.Nullable<bool> Enabled { get; set; }

            /// <summary>
            /// The storage class that objects in the bucket eventually transition to if they are not read for a certain
            /// length of time. Valid values are NEARLINE and ARCHIVE.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("terminalStorageClass")]
            public virtual string TerminalStorageClass { get; set; }

            /// <summary>
            /// A date and time in RFC 3339 format representing the time of the most recent update to
            /// "terminalStorageClass".
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("terminalStorageClassUpdateTime")]
            public virtual string TerminalStorageClassUpdateTimeRaw { get; set; }

            /// <summary>
            /// <seealso cref="System.DateTimeOffset"/> representation of
            /// <see cref="TerminalStorageClassUpdateTimeRaw"/>.
            /// </summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            public virtual System.DateTimeOffset? TerminalStorageClassUpdateTimeDateTimeOffset
            {
                get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(TerminalStorageClassUpdateTimeRaw);
                set => TerminalStorageClassUpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
            }

            /// <summary>
            /// <seealso cref="System.DateTime"/> representation of <see cref="TerminalStorageClassUpdateTimeRaw"/>.
            /// </summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TerminalStorageClassUpdateTimeDateTimeOffset instead.")]
            public virtual System.DateTime? TerminalStorageClassUpdateTime
            {
                get => Google.Apis.Util.Utilities.GetDateTimeFromString(TerminalStorageClassUpdateTimeRaw);
                set => TerminalStorageClassUpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }

            /// <summary>
            /// A date and time in RFC 3339 format representing the instant at which "enabled" was last toggled.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("toggleTime")]
            public virtual string ToggleTimeRaw { get; set; }

            /// <summary>
            /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ToggleTimeRaw"/>.
            /// </summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            public virtual System.DateTimeOffset? ToggleTimeDateTimeOffset
            {
                get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(ToggleTimeRaw);
                set => ToggleTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
            }

            /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ToggleTimeRaw"/>.</summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ToggleTimeDateTimeOffset instead.")]
            public virtual System.DateTime? ToggleTime
            {
                get => Google.Apis.Util.Utilities.GetDateTimeFromString(ToggleTimeRaw);
                set => ToggleTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }
        }

        /// <summary>The bucket's billing configuration.</summary>
        public class BillingData
        {
            /// <summary>When set to true, Requester Pays is enabled for this bucket.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("requesterPays")]
            public virtual System.Nullable<bool> RequesterPays { get; set; }
        }

        /// <summary>The bucket's Cross-Origin Resource Sharing (CORS) configuration.</summary>
        public class CorsData
        {
            /// <summary>
            /// The value, in seconds, to return in the  Access-Control-Max-Age header used in preflight responses.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("maxAgeSeconds")]
            public virtual System.Nullable<int> MaxAgeSeconds { get; set; }

            /// <summary>
            /// The list of HTTP methods on which to include CORS response headers, (GET, OPTIONS, POST, etc) Note: "*"
            /// is permitted in the list of methods, and means "any method".
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("method")]
            public virtual System.Collections.Generic.IList<string> Method { get; set; }

            /// <summary>
            /// The list of Origins eligible to receive CORS response headers. Note: "*" is permitted in the list of
            /// origins, and means "any Origin".
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("origin")]
            public virtual System.Collections.Generic.IList<string> Origin { get; set; }

            /// <summary>
            /// The list of HTTP headers other than the simple response headers to give permission for the user-agent to
            /// share across domains.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("responseHeader")]
            public virtual System.Collections.Generic.IList<string> ResponseHeader { get; set; }
        }

        /// <summary>The bucket's custom placement configuration for Custom Dual Regions.</summary>
        public class CustomPlacementConfigData
        {
            /// <summary>The list of regional locations in which data is placed.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("dataLocations")]
            public virtual System.Collections.Generic.IList<string> DataLocations { get; set; }
        }

        /// <summary>Encryption configuration for a bucket.</summary>
        public class EncryptionData
        {
            /// <summary>
            /// If set, the new objects created in this bucket must comply with this enforcement config. Changing this
            /// has no effect on existing objects; it applies to new objects only. If omitted, the new objects are
            /// allowed to be encrypted with Customer Managed Encryption type by default.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("customerManagedEncryptionEnforcementConfig")]
            public virtual CustomerManagedEncryptionEnforcementConfigData CustomerManagedEncryptionEnforcementConfig { get; set; }

            /// <summary>
            /// If set, the new objects created in this bucket must comply with this enforcement config. Changing this
            /// has no effect on existing objects; it applies to new objects only. If omitted, the new objects are
            /// allowed to be encrypted with Customer Supplied Encryption type by default.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("customerSuppliedEncryptionEnforcementConfig")]
            public virtual CustomerSuppliedEncryptionEnforcementConfigData CustomerSuppliedEncryptionEnforcementConfig { get; set; }

            /// <summary>
            /// A Cloud KMS key that will be used to encrypt objects inserted into this bucket, if no encryption method
            /// is specified.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("defaultKmsKeyName")]
            public virtual string DefaultKmsKeyName { get; set; }

            /// <summary>
            /// If set, the new objects created in this bucket must comply with this enforcement config. Changing this
            /// has no effect on existing objects; it applies to new objects only. If omitted, the new objects are
            /// allowed to be encrypted with Google Managed Encryption type by default.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("googleManagedEncryptionEnforcementConfig")]
            public virtual GoogleManagedEncryptionEnforcementConfigData GoogleManagedEncryptionEnforcementConfig { get; set; }

            /// <summary>
            /// If set, the new objects created in this bucket must comply with this enforcement config. Changing this
            /// has no effect on existing objects; it applies to new objects only. If omitted, the new objects are
            /// allowed to be encrypted with Customer Managed Encryption type by default.
            /// </summary>
            public class CustomerManagedEncryptionEnforcementConfigData
            {
                /// <summary>
                /// Server-determined value that indicates the time from which configuration was enforced and effective.
                /// This value is in RFC 3339 format.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("effectiveTime")]
                public virtual string EffectiveTimeRaw { get; set; }

                /// <summary>
                /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="EffectiveTimeRaw"/>.
                /// </summary>
                [Newtonsoft.Json.JsonIgnoreAttribute]
                public virtual System.DateTimeOffset? EffectiveTimeDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(EffectiveTimeRaw);
                    set => EffectiveTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
                }

                /// <summary>
                /// <seealso cref="System.DateTime"/> representation of <see cref="EffectiveTimeRaw"/>.
                /// </summary>
                [Newtonsoft.Json.JsonIgnoreAttribute]
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EffectiveTimeDateTimeOffset instead.")]
                public virtual System.DateTime? EffectiveTime
                {
                    get => Google.Apis.Util.Utilities.GetDateTimeFromString(EffectiveTimeRaw);
                    set => EffectiveTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
                }

                /// <summary>Restriction mode for Customer-Managed Encryption Keys. Defaults to NotRestricted.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("restrictionMode")]
                public virtual string RestrictionMode { get; set; }
            }

            /// <summary>
            /// If set, the new objects created in this bucket must comply with this enforcement config. Changing this
            /// has no effect on existing objects; it applies to new objects only. If omitted, the new objects are
            /// allowed to be encrypted with Customer Supplied Encryption type by default.
            /// </summary>
            public class CustomerSuppliedEncryptionEnforcementConfigData
            {
                /// <summary>
                /// Server-determined value that indicates the time from which configuration was enforced and effective.
                /// This value is in RFC 3339 format.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("effectiveTime")]
                public virtual string EffectiveTimeRaw { get; set; }

                /// <summary>
                /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="EffectiveTimeRaw"/>.
                /// </summary>
                [Newtonsoft.Json.JsonIgnoreAttribute]
                public virtual System.DateTimeOffset? EffectiveTimeDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(EffectiveTimeRaw);
                    set => EffectiveTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
                }

                /// <summary>
                /// <seealso cref="System.DateTime"/> representation of <see cref="EffectiveTimeRaw"/>.
                /// </summary>
                [Newtonsoft.Json.JsonIgnoreAttribute]
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EffectiveTimeDateTimeOffset instead.")]
                public virtual System.DateTime? EffectiveTime
                {
                    get => Google.Apis.Util.Utilities.GetDateTimeFromString(EffectiveTimeRaw);
                    set => EffectiveTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
                }

                /// <summary>
                /// Restriction mode for Customer-Supplied Encryption Keys. Defaults to NotRestricted.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("restrictionMode")]
                public virtual string RestrictionMode { get; set; }
            }

            /// <summary>
            /// If set, the new objects created in this bucket must comply with this enforcement config. Changing this
            /// has no effect on existing objects; it applies to new objects only. If omitted, the new objects are
            /// allowed to be encrypted with Google Managed Encryption type by default.
            /// </summary>
            public class GoogleManagedEncryptionEnforcementConfigData
            {
                /// <summary>
                /// Server-determined value that indicates the time from which configuration was enforced and effective.
                /// This value is in RFC 3339 format.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("effectiveTime")]
                public virtual string EffectiveTimeRaw { get; set; }

                /// <summary>
                /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="EffectiveTimeRaw"/>.
                /// </summary>
                [Newtonsoft.Json.JsonIgnoreAttribute]
                public virtual System.DateTimeOffset? EffectiveTimeDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(EffectiveTimeRaw);
                    set => EffectiveTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
                }

                /// <summary>
                /// <seealso cref="System.DateTime"/> representation of <see cref="EffectiveTimeRaw"/>.
                /// </summary>
                [Newtonsoft.Json.JsonIgnoreAttribute]
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EffectiveTimeDateTimeOffset instead.")]
                public virtual System.DateTime? EffectiveTime
                {
                    get => Google.Apis.Util.Utilities.GetDateTimeFromString(EffectiveTimeRaw);
                    set => EffectiveTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
                }

                /// <summary>Restriction mode for Google-Managed Encryption Keys. Defaults to NotRestricted.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("restrictionMode")]
                public virtual string RestrictionMode { get; set; }
            }
        }

        /// <summary>The bucket's hierarchical namespace configuration.</summary>
        public class HierarchicalNamespaceData
        {
            /// <summary>When set to true, hierarchical namespace is enabled for this bucket.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
            public virtual System.Nullable<bool> Enabled { get; set; }
        }

        /// <summary>The bucket's IAM configuration.</summary>
        public class IamConfigurationData
        {
            /// <summary>
            /// The bucket's uniform bucket-level access configuration. The feature was formerly known as Bucket Policy
            /// Only. For backward compatibility, this field will be populated with identical information as the
            /// uniformBucketLevelAccess field. We recommend using the uniformBucketLevelAccess field to enable and
            /// disable the feature.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("bucketPolicyOnly")]
            public virtual BucketPolicyOnlyData BucketPolicyOnly { get; set; }

            /// <summary>
            /// The bucket's Public Access Prevention configuration. Currently, 'inherited' and 'enforced' are
            /// supported.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("publicAccessPrevention")]
            public virtual string PublicAccessPrevention { get; set; }

            /// <summary>The bucket's uniform bucket-level access configuration.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("uniformBucketLevelAccess")]
            public virtual UniformBucketLevelAccessData UniformBucketLevelAccess { get; set; }

            /// <summary>
            /// The bucket's uniform bucket-level access configuration. The feature was formerly known as Bucket Policy
            /// Only. For backward compatibility, this field will be populated with identical information as the
            /// uniformBucketLevelAccess field. We recommend using the uniformBucketLevelAccess field to enable and
            /// disable the feature.
            /// </summary>
            public class BucketPolicyOnlyData
            {
                /// <summary>If set, access is controlled only by bucket-level or above IAM policies.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
                public virtual System.Nullable<bool> Enabled { get; set; }

                /// <summary>
                /// The deadline for changing iamConfiguration.bucketPolicyOnly.enabled from true to false in RFC 3339
                /// format. iamConfiguration.bucketPolicyOnly.enabled may be changed from true to false until the locked
                /// time, after which the field is immutable.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("lockedTime")]
                public virtual string LockedTimeRaw { get; set; }

                /// <summary>
                /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LockedTimeRaw"/>.
                /// </summary>
                [Newtonsoft.Json.JsonIgnoreAttribute]
                public virtual System.DateTimeOffset? LockedTimeDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(LockedTimeRaw);
                    set => LockedTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
                }

                /// <summary><seealso cref="System.DateTime"/> representation of <see cref="LockedTimeRaw"/>.</summary>
                [Newtonsoft.Json.JsonIgnoreAttribute]
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LockedTimeDateTimeOffset instead.")]
                public virtual System.DateTime? LockedTime
                {
                    get => Google.Apis.Util.Utilities.GetDateTimeFromString(LockedTimeRaw);
                    set => LockedTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
                }
            }

            /// <summary>The bucket's uniform bucket-level access configuration.</summary>
            public class UniformBucketLevelAccessData
            {
                /// <summary>If set, access is controlled only by bucket-level or above IAM policies.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
                public virtual System.Nullable<bool> Enabled { get; set; }

                /// <summary>
                /// The deadline for changing iamConfiguration.uniformBucketLevelAccess.enabled from true to false in
                /// RFC 3339  format. iamConfiguration.uniformBucketLevelAccess.enabled may be changed from true to
                /// false until the locked time, after which the field is immutable.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("lockedTime")]
                public virtual string LockedTimeRaw { get; set; }

                /// <summary>
                /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="LockedTimeRaw"/>.
                /// </summary>
                [Newtonsoft.Json.JsonIgnoreAttribute]
                public virtual System.DateTimeOffset? LockedTimeDateTimeOffset
                {
                    get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(LockedTimeRaw);
                    set => LockedTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
                }

                /// <summary><seealso cref="System.DateTime"/> representation of <see cref="LockedTimeRaw"/>.</summary>
                [Newtonsoft.Json.JsonIgnoreAttribute]
                [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use LockedTimeDateTimeOffset instead.")]
                public virtual System.DateTime? LockedTime
                {
                    get => Google.Apis.Util.Utilities.GetDateTimeFromString(LockedTimeRaw);
                    set => LockedTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
                }
            }
        }

        /// <summary>
        /// The bucket's IP filter configuration. Specifies the network sources that are allowed to access the
        /// operations on the bucket, as well as its underlying objects. Only enforced when the mode is set to
        /// 'Enabled'.
        /// </summary>
        public class IpFilterData
        {
            /// <summary>
            /// Whether to allow all service agents to access the bucket regardless of the IP filter configuration.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("allowAllServiceAgentAccess")]
            public virtual System.Nullable<bool> AllowAllServiceAgentAccess { get; set; }

            /// <summary>Whether to allow cross-org VPCs in the bucket's IP filter configuration.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("allowCrossOrgVpcs")]
            public virtual System.Nullable<bool> AllowCrossOrgVpcs { get; set; }

            /// <summary>The mode of the IP filter. Valid values are 'Enabled' and 'Disabled'.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("mode")]
            public virtual string Mode { get; set; }

            /// <summary>The public network source of the bucket's IP filter.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("publicNetworkSource")]
            public virtual PublicNetworkSourceData PublicNetworkSource { get; set; }

            /// <summary>
            /// The list of [VPC network](https://cloud.google.com/vpc/docs/vpc) sources of the bucket's IP filter.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("vpcNetworkSources")]
            public virtual System.Collections.Generic.IList<VpcNetworkSourcesData> VpcNetworkSources { get; set; }

            /// <summary>The public network source of the bucket's IP filter.</summary>
            public class PublicNetworkSourceData
            {
                /// <summary>The list of public IPv4, IPv6 cidr ranges that are allowed to access the bucket.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("allowedIpCidrRanges")]
                public virtual System.Collections.Generic.IList<string> AllowedIpCidrRanges { get; set; }
            }

            /// <summary>
            /// The list of [VPC network](https://cloud.google.com/vpc/docs/vpc) sources of the bucket's IP filter.
            /// </summary>
            public class VpcNetworkSourcesData
            {
                /// <summary>
                /// The list of IPv4, IPv6 cidr ranges subnetworks that are allowed to access the bucket.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("allowedIpCidrRanges")]
                public virtual System.Collections.Generic.IList<string> AllowedIpCidrRanges { get; set; }

                /// <summary>Name of the network. Format: projects/{PROJECT_ID}/global/networks/{NETWORK_NAME}</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("network")]
                public virtual string Network { get; set; }
            }
        }

        /// <summary>
        /// The bucket's lifecycle configuration. See [Lifecycle
        /// Management](https://cloud.google.com/storage/docs/lifecycle) for more information.
        /// </summary>
        public class LifecycleData
        {
            /// <summary>
            /// A lifecycle management rule, which is made of an action to take and the condition(s) under which the
            /// action will be taken.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("rule")]
            public virtual System.Collections.Generic.IList<RuleData> Rule { get; set; }

            /// <summary>
            /// A lifecycle management rule, which is made of an action to take and the condition(s) under which the
            /// action will be taken.
            /// </summary>
            public class RuleData
            {
                /// <summary>The action to take.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("action")]
                public virtual ActionData Action { get; set; }

                /// <summary>The condition(s) under which the action will be taken.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("condition")]
                public virtual ConditionData Condition { get; set; }

                /// <summary>The action to take.</summary>
                public class ActionData
                {
                    /// <summary>Target storage class. Required iff the type of the action is SetStorageClass.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("storageClass")]
                    public virtual string StorageClass { get; set; }

                    /// <summary>
                    /// Type of the action. Currently, only Delete, SetStorageClass, and AbortIncompleteMultipartUpload
                    /// are supported.
                    /// </summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("type")]
                    public virtual string Type { get; set; }
                }

                /// <summary>The condition(s) under which the action will be taken.</summary>
                public class ConditionData
                {
                    /// <summary>
                    /// Age of an object (in days). This condition is satisfied when an object reaches the specified
                    /// age.
                    /// </summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("age")]
                    public virtual System.Nullable<int> Age { get; set; }

                    /// <summary>
                    /// A date in RFC 3339 format with only the date part (for instance, "2013-01-15"). This condition
                    /// is satisfied when an object is created before midnight of the specified date in UTC.
                    /// </summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("createdBefore")]
                    public virtual string CreatedBefore { get; set; }

                    /// <summary>
                    /// A date in RFC 3339 format with only the date part (for instance, "2013-01-15"). This condition
                    /// is satisfied when the custom time on an object is before this date in UTC.
                    /// </summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("customTimeBefore")]
                    public virtual string CustomTimeBefore { get; set; }

                    /// <summary>
                    /// Number of days elapsed since the user-specified timestamp set on an object. The condition is
                    /// satisfied if the days elapsed is at least this number. If no custom timestamp is specified on an
                    /// object, the condition does not apply.
                    /// </summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("daysSinceCustomTime")]
                    public virtual System.Nullable<int> DaysSinceCustomTime { get; set; }

                    /// <summary>
                    /// Number of days elapsed since the noncurrent timestamp of an object. The condition is satisfied
                    /// if the days elapsed is at least this number. This condition is relevant only for versioned
                    /// objects. The value of the field must be a nonnegative integer. If it's zero, the object version
                    /// will become eligible for Lifecycle action as soon as it becomes noncurrent.
                    /// </summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("daysSinceNoncurrentTime")]
                    public virtual System.Nullable<int> DaysSinceNoncurrentTime { get; set; }

                    /// <summary>
                    /// Relevant only for versioned objects. If the value is true, this condition matches live objects;
                    /// if the value is false, it matches archived objects.
                    /// </summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("isLive")]
                    public virtual System.Nullable<bool> IsLive { get; set; }

                    /// <summary>
                    /// A regular expression that satisfies the RE2 syntax. This condition is satisfied when the name of
                    /// the object matches the RE2 pattern. Note: This feature is currently in the "Early Access" launch
                    /// stage and is only available to a whitelisted set of users; that means that this feature may be
                    /// changed in backward-incompatible ways and that it is not guaranteed to be released.
                    /// </summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("matchesPattern")]
                    public virtual string MatchesPattern { get; set; }

                    /// <summary>
                    /// List of object name prefixes. This condition will be satisfied when at least one of the prefixes
                    /// exactly matches the beginning of the object name.
                    /// </summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("matchesPrefix")]
                    public virtual System.Collections.Generic.IList<string> MatchesPrefix { get; set; }

                    /// <summary>
                    /// Objects having any of the storage classes specified by this condition will be matched. Values
                    /// include MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE, STANDARD, and
                    /// DURABLE_REDUCED_AVAILABILITY.
                    /// </summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("matchesStorageClass")]
                    public virtual System.Collections.Generic.IList<string> MatchesStorageClass { get; set; }

                    /// <summary>
                    /// List of object name suffixes. This condition will be satisfied when at least one of the suffixes
                    /// exactly matches the end of the object name.
                    /// </summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("matchesSuffix")]
                    public virtual System.Collections.Generic.IList<string> MatchesSuffix { get; set; }

                    /// <summary>
                    /// A date in RFC 3339 format with only the date part (for instance, "2013-01-15"). This condition
                    /// is satisfied when the noncurrent time on an object is before this date in UTC. This condition is
                    /// relevant only for versioned objects.
                    /// </summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("noncurrentTimeBefore")]
                    public virtual string NoncurrentTimeBefore { get; set; }

                    /// <summary>
                    /// Relevant only for versioned objects. If the value is N, this condition is satisfied when there
                    /// are at least N versions (including the live version) newer than this version of the object.
                    /// </summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("numNewerVersions")]
                    public virtual System.Nullable<int> NumNewerVersions { get; set; }
                }
            }
        }

        /// <summary>
        /// The bucket's logging configuration, which defines the destination bucket and optional name prefix for the
        /// current bucket's logs.
        /// </summary>
        public class LoggingData
        {
            /// <summary>The destination bucket where the current bucket's logs should be placed.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("logBucket")]
            public virtual string LogBucket { get; set; }

            /// <summary>A prefix for log object names.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("logObjectPrefix")]
            public virtual string LogObjectPrefix { get; set; }
        }

        /// <summary>The bucket's object retention config.</summary>
        public class ObjectRetentionData
        {
            /// <summary>The bucket's object retention mode. Can be Enabled.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("mode")]
            public virtual string Mode { get; set; }
        }

        /// <summary>The owner of the bucket. This is always the project team's owner group.</summary>
        public class OwnerData
        {
            /// <summary>The entity, in the form project-owner-projectId.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("entity")]
            public virtual string Entity { get; set; }

            /// <summary>The ID for the entity.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
            public virtual string EntityId { get; set; }
        }

        /// <summary>
        /// The bucket's retention policy. The retention policy enforces a minimum retention time for all objects
        /// contained in the bucket, based on their creation time. Any attempt to overwrite or delete objects younger
        /// than the retention period will result in a PERMISSION_DENIED error. An unlocked retention policy can be
        /// modified or removed from the bucket via a storage.buckets.update operation. A locked retention policy cannot
        /// be removed or shortened in duration for the lifetime of the bucket. Attempting to remove or decrease period
        /// of a locked retention policy will result in a PERMISSION_DENIED error.
        /// </summary>
        public class RetentionPolicyData
        {
            /// <summary>
            /// Server-determined value that indicates the time from which policy was enforced and effective. This value
            /// is in RFC 3339 format.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("effectiveTime")]
            public virtual string EffectiveTimeRaw { get; set; }

            /// <summary>
            /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="EffectiveTimeRaw"/>.
            /// </summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            public virtual System.DateTimeOffset? EffectiveTimeDateTimeOffset
            {
                get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(EffectiveTimeRaw);
                set => EffectiveTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
            }

            /// <summary><seealso cref="System.DateTime"/> representation of <see cref="EffectiveTimeRaw"/>.</summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EffectiveTimeDateTimeOffset instead.")]
            public virtual System.DateTime? EffectiveTime
            {
                get => Google.Apis.Util.Utilities.GetDateTimeFromString(EffectiveTimeRaw);
                set => EffectiveTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }

            /// <summary>Once locked, an object retention policy cannot be modified.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("isLocked")]
            public virtual System.Nullable<bool> IsLocked { get; set; }

            /// <summary>
            /// The duration in seconds that objects need to be retained. Retention duration must be greater than zero
            /// and less than 100 years. Note that enforcement of retention periods less than a day is not guaranteed.
            /// Such periods should only be used for testing purposes.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("retentionPeriod")]
            public virtual System.Nullable<long> RetentionPeriod { get; set; }
        }

        /// <summary>
        /// The bucket's soft delete policy, which defines the period of time that soft-deleted objects will be
        /// retained, and cannot be permanently deleted.
        /// </summary>
        public class SoftDeletePolicyData
        {
            /// <summary>
            /// Server-determined value that indicates the time from which the policy, or one with a greater retention,
            /// was effective. This value is in RFC 3339 format.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("effectiveTime")]
            public virtual string EffectiveTimeRaw { get; set; }

            /// <summary>
            /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="EffectiveTimeRaw"/>.
            /// </summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            public virtual System.DateTimeOffset? EffectiveTimeDateTimeOffset
            {
                get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(EffectiveTimeRaw);
                set => EffectiveTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
            }

            /// <summary><seealso cref="System.DateTime"/> representation of <see cref="EffectiveTimeRaw"/>.</summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EffectiveTimeDateTimeOffset instead.")]
            public virtual System.DateTime? EffectiveTime
            {
                get => Google.Apis.Util.Utilities.GetDateTimeFromString(EffectiveTimeRaw);
                set => EffectiveTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }

            /// <summary>
            /// The duration in seconds that soft-deleted objects in the bucket will be retained and cannot be
            /// permanently deleted.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("retentionDurationSeconds")]
            public virtual System.Nullable<long> RetentionDurationSeconds { get; set; }
        }

        /// <summary>The bucket's versioning configuration.</summary>
        public class VersioningData
        {
            /// <summary>While set to true, versioning is fully enabled for this bucket.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
            public virtual System.Nullable<bool> Enabled { get; set; }
        }

        /// <summary>
        /// The bucket's website configuration, controlling how the service behaves when accessing bucket contents as a
        /// web site. See the [Static Website Examples](https://cloud.google.com/storage/docs/static-website) for more
        /// information.
        /// </summary>
        public class WebsiteData
        {
            /// <summary>
            /// If the requested object path is missing, the service will ensure the path has a trailing '/', append
            /// this suffix, and attempt to retrieve the resulting object. This allows the creation of index.html
            /// objects to represent directory pages.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("mainPageSuffix")]
            public virtual string MainPageSuffix { get; set; }

            /// <summary>
            /// If the requested object path is missing, and any mainPageSuffix object is missing, if applicable, the
            /// service will return the named object from this bucket as the content for a 404 Not Found result.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("notFoundPage")]
            public virtual string NotFoundPage { get; set; }
        }
    }

    /// <summary>An access-control entry.</summary>
    public class BucketAccessControl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>The domain associated with the entity, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>The email address associated with the entity, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>
        /// The entity holding the permission, in one of the following forms:  - user-userId  - user-email  -
        /// group-groupId  - group-email  - domain-domain  - project-team-projectId  - allUsers  - allAuthenticatedUsers
        /// Examples:  - The user liz@example.com would be user-liz@example.com.  - The group example@googlegroups.com
        /// would be group-example@googlegroups.com.  - To refer to all members of the Google Apps for Business domain
        /// example.com, the entity would be domain-example.com.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual string Entity { get; set; }

        /// <summary>The ID for the entity, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
        public virtual string EntityId { get; set; }

        /// <summary>HTTP 1.1 Entity tag for the access-control entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID of the access-control entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The kind of item this is. For bucket access control entries, this is always storage#bucketAccessControl.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The project team associated with the entity, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectTeam")]
        public virtual ProjectTeamData ProjectTeam { get; set; }

        /// <summary>The access permission for the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The link to this access-control entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The project team associated with the entity, if any.</summary>
        public class ProjectTeamData
        {
            /// <summary>The project number.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("projectNumber")]
            public virtual string ProjectNumber { get; set; }

            /// <summary>The team.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("team")]
            public virtual string Team { get; set; }
        }
    }

    /// <summary>An access-control list.</summary>
    public class BucketAccessControls : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<BucketAccessControl> Items { get; set; }

        /// <summary>
        /// The kind of item this is. For lists of bucket access control entries, this is always
        /// storage#bucketAccessControls.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The storage layout configuration of a bucket.</summary>
    public class BucketStorageLayout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>The bucket's custom placement configuration for Custom Dual Regions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customPlacementConfig")]
        public virtual CustomPlacementConfigData CustomPlacementConfig { get; set; }

        /// <summary>The bucket's hierarchical namespace configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hierarchicalNamespace")]
        public virtual HierarchicalNamespaceData HierarchicalNamespace { get; set; }

        /// <summary>The kind of item this is. For storage layout, this is always storage#storageLayout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The location of the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>The type of the bucket location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationType")]
        public virtual string LocationType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>The bucket's custom placement configuration for Custom Dual Regions.</summary>
        public class CustomPlacementConfigData
        {
            /// <summary>The list of regional locations in which data is placed.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("dataLocations")]
            public virtual System.Collections.Generic.IList<string> DataLocations { get; set; }
        }

        /// <summary>The bucket's hierarchical namespace configuration.</summary>
        public class HierarchicalNamespaceData
        {
            /// <summary>When set to true, hierarchical namespace is enabled for this bucket.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
            public virtual System.Nullable<bool> Enabled { get; set; }
        }
    }

    /// <summary>A list of buckets.</summary>
    public class Buckets : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Bucket> Items { get; set; }

        /// <summary>The kind of item this is. For lists of buckets, this is always storage#buckets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The continuation token, used to page through large result sets. Provide this value in a subsequent request
        /// to return the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A bulk restore objects request.</summary>
    public class BulkRestoreObjectsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If false (default), the restore will not overwrite live objects with the same name at the destination. This
        /// means some deleted objects may be skipped. If true, live objects will be overwritten resulting in a
        /// noncurrent object (if versioning is enabled). If versioning is not enabled, overwriting the object will
        /// result in a soft-deleted object. In either case, if a noncurrent object already exists with the same name, a
        /// live version can be written without issue.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowOverwrite")]
        public virtual System.Nullable<bool> AllowOverwrite { get; set; }

        /// <summary>
        /// If true, copies the source object's ACL; otherwise, uses the bucket's default object ACL. The default is
        /// false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copySourceAcl")]
        public virtual System.Nullable<bool> CopySourceAcl { get; set; }

        /// <summary>Restores only the objects that were created after this time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdAfterTime")]
        public virtual string CreatedAfterTimeRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedAfterTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedAfterTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedAfterTimeRaw);
            set => CreatedAfterTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedAfterTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedAfterTimeDateTimeOffset instead.")]
        public virtual System.DateTime? CreatedAfterTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedAfterTimeRaw);
            set => CreatedAfterTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Restores only the objects that were created before this time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createdBeforeTime")]
        public virtual string CreatedBeforeTimeRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="CreatedBeforeTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreatedBeforeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreatedBeforeTimeRaw);
            set => CreatedBeforeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreatedBeforeTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreatedBeforeTimeDateTimeOffset instead.")]
        public virtual System.DateTime? CreatedBeforeTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreatedBeforeTimeRaw);
            set => CreatedBeforeTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// Restores only the objects matching any of the specified glob(s). If this parameter is not specified, all
        /// objects will be restored within the specified time range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchGlobs")]
        public virtual System.Collections.Generic.IList<string> MatchGlobs { get; set; }

        /// <summary>Restores only the objects that were soft-deleted after this time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softDeletedAfterTime")]
        public virtual string SoftDeletedAfterTimeRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="SoftDeletedAfterTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SoftDeletedAfterTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(SoftDeletedAfterTimeRaw);
            set => SoftDeletedAfterTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary>
        /// <seealso cref="System.DateTime"/> representation of <see cref="SoftDeletedAfterTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SoftDeletedAfterTimeDateTimeOffset instead.")]
        public virtual System.DateTime? SoftDeletedAfterTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(SoftDeletedAfterTimeRaw);
            set => SoftDeletedAfterTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Restores only the objects that were soft-deleted before this time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softDeletedBeforeTime")]
        public virtual string SoftDeletedBeforeTimeRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="SoftDeletedBeforeTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SoftDeletedBeforeTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(SoftDeletedBeforeTimeRaw);
            set => SoftDeletedBeforeTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary>
        /// <seealso cref="System.DateTime"/> representation of <see cref="SoftDeletedBeforeTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SoftDeletedBeforeTimeDateTimeOffset instead.")]
        public virtual System.DateTime? SoftDeletedBeforeTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(SoftDeletedBeforeTimeRaw);
            set => SoftDeletedBeforeTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An notification channel used to watch for resource changes.</summary>
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
        /// Identifies this as a notification channel used to watch for changes to a resource, which is "api#channel".
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

        /// <summary>The type of delivery mechanism used for this channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Compose request.</summary>
    public class ComposeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Properties of the resulting object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual Object Destination { get; set; }

        /// <summary>The kind of item this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The list of source objects that will be concatenated into a single object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceObjects")]
        public virtual System.Collections.Generic.IList<SourceObjectsData> SourceObjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>The list of source objects that will be concatenated into a single object.</summary>
        public class SourceObjectsData
        {
            /// <summary>The generation of this object to use as the source.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("generation")]
            public virtual System.Nullable<long> Generation { get; set; }

            /// <summary>The source object's name. All source objects must reside in the same bucket.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; }

            /// <summary>Conditions that must be met for this operation to execute.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("objectPreconditions")]
            public virtual ObjectPreconditionsData ObjectPreconditions { get; set; }

            /// <summary>Conditions that must be met for this operation to execute.</summary>
            public class ObjectPreconditionsData
            {
                /// <summary>
                /// Only perform the composition if the generation of the source object that would be used matches this
                /// value. If this value and a generation are both specified, they must be the same value or the call
                /// will fail.
                /// </summary>
                [Newtonsoft.Json.JsonPropertyAttribute("ifGenerationMatch")]
                public virtual System.Nullable<long> IfGenerationMatch { get; set; }
            }
        }
    }

    /// <summary>
    /// Represents an expression text. Example: title: "User account presence" description: "Determines whether the
    /// request has a user account" expression: "size(request.user) &amp;gt; 0"
    /// </summary>
    public class Expr : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An optional description of the expression. This is a longer text which describes the expression, e.g. when
        /// hovered over it in a UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Textual representation of an expression in Common Expression Language syntax. The application context of the
        /// containing message determines which well-known feature set of CEL is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        /// <summary>
        /// An optional string indicating the location of the expression for error reporting, e.g. a file name and a
        /// position in the file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// An optional title for the expression, i.e. a short string describing its purpose. This can be used e.g. in
        /// UIs which allow to enter the expression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A folder. Only available in buckets with hierarchical namespace enabled.</summary>
    public class Folder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the bucket containing this folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>The creation time of the folder in RFC 3339 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual System.DateTime? CreateTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The ID of the folder, including the bucket name, folder name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The kind of item this is. For folders, this is always storage#folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The version of the metadata for this folder. Used for preconditions and for detecting changes in metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metageneration")]
        public virtual System.Nullable<long> Metageneration { get; set; }

        /// <summary>The name of the folder. Required if not specified by URL parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Only present if the folder is part of an ongoing rename folder operation. Contains information which can be
        /// used to query the operation status.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pendingRenameInfo")]
        public virtual PendingRenameInfoData PendingRenameInfo { get; set; }

        /// <summary>The link to this folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The modification time of the folder metadata in RFC 3339 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual System.DateTime? UpdateTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>
        /// Only present if the folder is part of an ongoing rename folder operation. Contains information which can be
        /// used to query the operation status.
        /// </summary>
        public class PendingRenameInfoData
        {
            /// <summary>The ID of the rename folder operation.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("operationId")]
            public virtual string OperationId { get; set; }
        }
    }

    /// <summary>A list of folders.</summary>
    public class Folders : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Folder> Items { get; set; }

        /// <summary>The kind of item this is. For lists of folders, this is always storage#folders.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The continuation token, used to page through large result sets. Provide this value in a subsequent request
        /// to return the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for storage.buckets.operations.list.</summary>
    public class GoogleLongrunningListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The kind of item this is. For lists of operations, this is always storage#operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The continuation token, used to page through large result sets. Provide this value in a subsequent request
        /// to return the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<GoogleLongrunningOperation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class GoogleLongrunningOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is "false", it means the operation is still in progress. If "true", the operation is completed,
        /// and either "error" or "response" is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; }

        /// <summary>The kind of item this is. For operations, this is always storage#operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Service-specific metadata associated with the operation. It typically contains progress information and
        /// common metadata such as create time. Some services might not provide such metadata. Any method that returns
        /// a long-running operation should document the metadata type, if any.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The server-assigned name, which is only unique within the same service that originally returns it. If you
        /// use the default HTTP mapping, the "name" should be a resource name ending with "operations/{operationId}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal response of the operation in case of success. If the original method returns no data on success,
        /// such as "Delete", the response is google.protobuf.Empty. If the original method is standard
        /// Get/Create/Update, the response should be the resource. For other methods, the response should have the type
        /// "XxxResponse", where "Xxx" is the original method name. For example, if the original method name is
        /// "TakeSnapshot()", the inferred response type is "TakeSnapshotResponse".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The link to this long running operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The "Status" type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each "Status" message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class GoogleRpcStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>A developer-facing error message, which should be in English.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template to produce a JSON-style HMAC Key resource for Create responses.</summary>
    public class HmacKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The kind of item this is. For HMAC keys, this is always storage#hmacKey.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Key metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual HmacKeyMetadata Metadata { get; set; }

        /// <summary>HMAC secret key material.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secret")]
        public virtual string Secret { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSON template to produce a JSON-style HMAC Key metadata resource.</summary>
    public class HmacKeyMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the HMAC Key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessId")]
        public virtual string AccessId { get; set; }

        /// <summary>HTTP 1.1 Entity tag for the HMAC key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The ID of the HMAC key, including the Project ID and the Access ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The kind of item this is. For HMAC Key metadata, this is always storage#hmacKeyMetadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Project ID owning the service account to which the key authenticates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The link to this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The email address of the key's associated service account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; }

        /// <summary>The state of the key. Can be one of ACTIVE, INACTIVE, or DELETED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The creation time of the HMAC key in RFC 3339 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeCreated")]
        public virtual string TimeCreatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="TimeCreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimeCreatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(TimeCreatedRaw);
            set => TimeCreatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="TimeCreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimeCreatedDateTimeOffset instead.")]
        public virtual System.DateTime? TimeCreated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(TimeCreatedRaw);
            set => TimeCreatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The last modification time of the HMAC key metadata in RFC 3339 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdatedDateTimeOffset instead.")]
        public virtual System.DateTime? Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }
    }

    /// <summary>A list of hmacKeys.</summary>
    public class HmacKeysMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<HmacKeyMetadata> Items { get; set; }

        /// <summary>The kind of item this is. For lists of hmacKeys, this is always storage#hmacKeysMetadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The continuation token, used to page through large result sets. Provide this value in a subsequent request
        /// to return the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A managed folder.</summary>
    public class ManagedFolder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the bucket containing this managed folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>The creation time of the managed folder in RFC 3339 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual System.DateTime? CreateTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The ID of the managed folder, including the bucket name and managed folder name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The kind of item this is. For managed folders, this is always storage#managedFolder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The version of the metadata for this managed folder. Used for preconditions and for detecting changes in
        /// metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metageneration")]
        public virtual System.Nullable<long> Metageneration { get; set; }

        /// <summary>The name of the managed folder. Required if not specified by URL parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The link to this managed folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The last update time of the managed folder metadata in RFC 3339 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual System.DateTime? UpdateTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of managed folders.</summary>
    public class ManagedFolders : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<ManagedFolder> Items { get; set; }

        /// <summary>
        /// The kind of item this is. For lists of managed folders, this is always storage#managedFolders.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The continuation token, used to page through large result sets. Provide this value in a subsequent request
        /// to return the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A subscription to receive Google PubSub notifications.</summary>
    public class Notification : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An optional list of additional attributes to attach to each Cloud PubSub message published for this
        /// notification subscription.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("custom_attributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> CustomAttributes { get; set; }

        /// <summary>HTTP 1.1 Entity tag for this subscription notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// If present, only send notifications about listed event types. If empty, sent notifications for all event
        /// types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("event_types")]
        public virtual System.Collections.Generic.IList<string> EventTypes { get; set; }

        /// <summary>The ID of the notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The kind of item this is. For notifications, this is always storage#notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// If present, only apply this notification configuration to object names that begin with this prefix.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object_name_prefix")]
        public virtual string ObjectNamePrefix { get; set; }

        /// <summary>The desired content of the Payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload_format")]
        public virtual string PayloadFormat { get; set; }

        /// <summary>The canonical URL of this notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// The Cloud PubSub topic to which this subscription publishes. Formatted as:
        /// '//pubsub.googleapis.com/projects/{project-identifier}/topics/{my-topic}'
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; }
    }

    /// <summary>A list of notification subscriptions.</summary>
    public class Notifications : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Notification> Items { get; set; }

        /// <summary>
        /// The kind of item this is. For lists of notifications, this is always storage#notifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An object.</summary>
    public class Object : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Access controls on the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acl")]
        public virtual System.Collections.Generic.IList<ObjectAccessControl> Acl { get; set; }

        /// <summary>The name of the bucket containing this object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>
        /// Cache-Control directive for the object data. If omitted, and the object is accessible to all anonymous
        /// users, the default will be public, max-age=3600.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cacheControl")]
        public virtual string CacheControl { get; set; }

        /// <summary>
        /// Number of underlying components that make up this object. Components are accumulated by compose operations.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("componentCount")]
        public virtual System.Nullable<int> ComponentCount { get; set; }

        /// <summary>Content-Disposition of the object data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentDisposition")]
        public virtual string ContentDisposition { get; set; }

        /// <summary>Content-Encoding of the object data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentEncoding")]
        public virtual string ContentEncoding { get; set; }

        /// <summary>Content-Language of the object data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentLanguage")]
        public virtual string ContentLanguage { get; set; }

        /// <summary>
        /// Content-Type of the object data. If an object is stored without a Content-Type, it is served as
        /// application/octet-stream.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>
        /// User-defined or system-defined object contexts. Each object context is a key-payload pair, where the key
        /// provides the identification and the payload holds the associated value and additional metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contexts")]
        public virtual ContextsData Contexts { get; set; }

        /// <summary>
        /// CRC32c checksum, as described in RFC 4960, Appendix B; encoded using base64 in big-endian byte order. For
        /// more information about using the CRC32c checksum, see [Data Validation and Change
        /// Detection](https://cloud.google.com/storage/docs/data-validation).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("crc32c")]
        public virtual string Crc32c { get; set; }

        /// <summary>A timestamp in RFC 3339 format specified by the user for an object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customTime")]
        public virtual string CustomTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CustomTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CustomTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CustomTimeRaw);
            set => CustomTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CustomTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CustomTimeDateTimeOffset instead.")]
        public virtual System.DateTime? CustomTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CustomTimeRaw);
            set => CustomTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Metadata of customer-supplied encryption key, if the object is encrypted by such a key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerEncryption")]
        public virtual CustomerEncryptionData CustomerEncryption { get; set; }

        /// <summary>HTTP 1.1 Entity tag for the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Whether an object is under event-based hold. Event-based hold is a way to retain objects until an event
        /// occurs, which is signified by the hold's release (i.e. this value is set to false). After being released
        /// (set to false), such objects will be subject to bucket-level retention (if any). One sample use case of this
        /// flag is for banks to hold loan documents for at least 3 years after loan is paid in full. Here, bucket-level
        /// retention is 3 years and the event is the loan being paid in full. In this example, these objects will be
        /// held intact for any number of years until the event has occurred (event-based hold on the object is
        /// released) and then 3 more years after that. That means retention duration of the objects begins from the
        /// moment event-based hold transitioned from true to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventBasedHold")]
        public virtual System.Nullable<bool> EventBasedHold { get; set; }

        /// <summary>The content generation of this object. Used for object versioning.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>
        /// This is the time (in the future) when the soft-deleted object will no longer be restorable. It is equal to
        /// the soft delete time plus the current soft delete retention duration of the bucket.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hardDeleteTime")]
        public virtual string HardDeleteTimeRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="HardDeleteTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? HardDeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(HardDeleteTimeRaw);
            set => HardDeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="HardDeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use HardDeleteTimeDateTimeOffset instead.")]
        public virtual System.DateTime? HardDeleteTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(HardDeleteTimeRaw);
            set => HardDeleteTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The ID of the object, including the bucket name, object name, and generation number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>The kind of item this is. For objects, this is always storage#object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// Not currently supported. Specifying the parameter causes the request to fail with status code 400 - Bad
        /// Request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; }

        /// <summary>
        /// MD5 hash of the data; encoded using base64. For more information about using the MD5 hash, see [Data
        /// Validation and Change Detection](https://cloud.google.com/storage/docs/data-validation).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("md5Hash")]
        public virtual string Md5Hash { get; set; }

        /// <summary>Media download link.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaLink")]
        public virtual string MediaLink { get; set; }

        /// <summary>User-provided metadata, in key/value pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The version of the metadata for this object at this generation. Used for preconditions and for detecting
        /// changes in metadata. A metageneration number is only meaningful in the context of a particular generation of
        /// a particular object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metageneration")]
        public virtual System.Nullable<long> Metageneration { get; set; }

        /// <summary>The name of the object. Required if not specified by URL parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The owner of the object. This will always be the uploader of the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("owner")]
        public virtual OwnerData Owner { get; set; }

        /// <summary>
        /// Restore token used to differentiate deleted objects with the same name and generation. This field is only
        /// returned for deleted objects in hierarchical namespace buckets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restoreToken")]
        public virtual string RestoreToken { get; set; }

        /// <summary>A collection of object level retention parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retention")]
        public virtual RetentionData Retention { get; set; }

        /// <summary>
        /// A server-determined value that specifies the earliest time that the object's retention period expires. This
        /// value is in RFC 3339 format. Note 1: This field is not provided for objects with an active event-based hold,
        /// since retention expiration is unknown until the hold is removed. Note 2: This value can be provided even
        /// when temporary hold is set (so that the user can reason about policy without having to first unset the
        /// temporary hold).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retentionExpirationTime")]
        public virtual string RetentionExpirationTimeRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RetentionExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? RetentionExpirationTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(RetentionExpirationTimeRaw);
            set => RetentionExpirationTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary>
        /// <seealso cref="System.DateTime"/> representation of <see cref="RetentionExpirationTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RetentionExpirationTimeDateTimeOffset instead.")]
        public virtual System.DateTime? RetentionExpirationTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(RetentionExpirationTimeRaw);
            set => RetentionExpirationTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The link to this object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>Content-Length of the data in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<ulong> Size { get; set; }

        /// <summary>The time at which the object became soft-deleted in RFC 3339 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softDeleteTime")]
        public virtual string SoftDeleteTimeRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="SoftDeleteTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? SoftDeleteTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(SoftDeleteTimeRaw);
            set => SoftDeleteTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="SoftDeleteTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use SoftDeleteTimeDateTimeOffset instead.")]
        public virtual System.DateTime? SoftDeleteTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(SoftDeleteTimeRaw);
            set => SoftDeleteTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>Storage class of the object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storageClass")]
        public virtual string StorageClass { get; set; }

        /// <summary>
        /// Whether an object is under temporary hold. While this flag is set to true, the object is protected against
        /// deletion and overwrites. A common use case of this flag is regulatory investigations where objects need to
        /// be retained while the investigation is ongoing. Note that unlike event-based hold, temporary hold does not
        /// impact retention expiration time of an object.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("temporaryHold")]
        public virtual System.Nullable<bool> TemporaryHold { get; set; }

        /// <summary>The creation time of the object in RFC 3339 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeCreated")]
        public virtual string TimeCreatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="TimeCreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimeCreatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(TimeCreatedRaw);
            set => TimeCreatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="TimeCreatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimeCreatedDateTimeOffset instead.")]
        public virtual System.DateTime? TimeCreated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(TimeCreatedRaw);
            set => TimeCreatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// The time at which the object became noncurrent in RFC 3339 format. Will be returned if and only if this
        /// version of the object has been deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeDeleted")]
        public virtual string TimeDeletedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="TimeDeletedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimeDeletedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(TimeDeletedRaw);
            set => TimeDeletedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="TimeDeletedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimeDeletedDateTimeOffset instead.")]
        public virtual System.DateTime? TimeDeleted
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(TimeDeletedRaw);
            set => TimeDeletedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The time when the object was finalized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeFinalized")]
        public virtual string TimeFinalizedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="TimeFinalizedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimeFinalizedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(TimeFinalizedRaw);
            set => TimeFinalizedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="TimeFinalizedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimeFinalizedDateTimeOffset instead.")]
        public virtual System.DateTime? TimeFinalized
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(TimeFinalizedRaw);
            set => TimeFinalizedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// The time at which the object's storage class was last changed. When the object is initially created, it will
        /// be set to timeCreated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeStorageClassUpdated")]
        public virtual string TimeStorageClassUpdatedRaw { get; set; }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="TimeStorageClassUpdatedRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? TimeStorageClassUpdatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(TimeStorageClassUpdatedRaw);
            set => TimeStorageClassUpdatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary>
        /// <seealso cref="System.DateTime"/> representation of <see cref="TimeStorageClassUpdatedRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use TimeStorageClassUpdatedDateTimeOffset instead.")]
        public virtual System.DateTime? TimeStorageClassUpdated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(TimeStorageClassUpdatedRaw);
            set => TimeStorageClassUpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// The modification time of the object metadata in RFC 3339 format. Set initially to object creation time and
        /// then updated whenever any metadata of the object changes. This includes changes made by a requester, such as
        /// modifying custom metadata, as well as changes made by Cloud Storage on behalf of a requester, such as
        /// changing the storage class based on an Object Lifecycle Configuration.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updated")]
        public virtual string UpdatedRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdatedDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdatedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdatedDateTimeOffset instead.")]
        public virtual System.DateTime? Updated
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdatedRaw);
            set => UpdatedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>
        /// User-defined or system-defined object contexts. Each object context is a key-payload pair, where the key
        /// provides the identification and the payload holds the associated value and additional metadata.
        /// </summary>
        public class ContextsData
        {
            /// <summary>User-defined object contexts.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("custom")]
            public virtual System.Collections.Generic.IDictionary<string, ObjectCustomContextPayload> Custom { get; set; }
        }

        /// <summary>Metadata of customer-supplied encryption key, if the object is encrypted by such a key.</summary>
        public class CustomerEncryptionData
        {
            /// <summary>The encryption algorithm.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("encryptionAlgorithm")]
            public virtual string EncryptionAlgorithm { get; set; }

            /// <summary>SHA256 hash value of the encryption key.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("keySha256")]
            public virtual string KeySha256 { get; set; }
        }

        /// <summary>The owner of the object. This will always be the uploader of the object.</summary>
        public class OwnerData
        {
            /// <summary>The entity, in the form user-userId.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("entity")]
            public virtual string Entity { get; set; }

            /// <summary>The ID for the entity.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
            public virtual string EntityId { get; set; }
        }

        /// <summary>A collection of object level retention parameters.</summary>
        public class RetentionData
        {
            /// <summary>The bucket's object retention mode, can only be Unlocked or Locked.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("mode")]
            public virtual string Mode { get; set; }

            /// <summary>A time in RFC 3339 format until which object retention protects this object.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("retainUntilTime")]
            public virtual string RetainUntilTimeRaw { get; set; }

            /// <summary>
            /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="RetainUntilTimeRaw"/>.
            /// </summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            public virtual System.DateTimeOffset? RetainUntilTimeDateTimeOffset
            {
                get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(RetainUntilTimeRaw);
                set => RetainUntilTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
            }

            /// <summary><seealso cref="System.DateTime"/> representation of <see cref="RetainUntilTimeRaw"/>.</summary>
            [Newtonsoft.Json.JsonIgnoreAttribute]
            [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use RetainUntilTimeDateTimeOffset instead.")]
            public virtual System.DateTime? RetainUntilTime
            {
                get => Google.Apis.Util.Utilities.GetDateTimeFromString(RetainUntilTimeRaw);
                set => RetainUntilTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }
        }
    }

    /// <summary>An access-control entry.</summary>
    public class ObjectAccessControl : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual string Bucket { get; set; }

        /// <summary>The domain associated with the entity, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; }

        /// <summary>The email address associated with the entity, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>
        /// The entity holding the permission, in one of the following forms:  - user-userId  - user-email  -
        /// group-groupId  - group-email  - domain-domain  - project-team-projectId  - allUsers  - allAuthenticatedUsers
        /// Examples:  - The user liz@example.com would be user-liz@example.com.  - The group example@googlegroups.com
        /// would be group-example@googlegroups.com.  - To refer to all members of the Google Apps for Business domain
        /// example.com, the entity would be domain-example.com.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entity")]
        public virtual string Entity { get; set; }

        /// <summary>The ID for the entity, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityId")]
        public virtual string EntityId { get; set; }

        /// <summary>HTTP 1.1 Entity tag for the access-control entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>The content generation of the object, if applied to an object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<long> Generation { get; set; }

        /// <summary>The ID of the access-control entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// The kind of item this is. For object access control entries, this is always storage#objectAccessControl.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The name of the object, if applied to an object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("object")]
        public virtual string Object__ { get; set; }

        /// <summary>The project team associated with the entity, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectTeam")]
        public virtual ProjectTeamData ProjectTeam { get; set; }

        /// <summary>The access permission for the entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The link to this access-control entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The project team associated with the entity, if any.</summary>
        public class ProjectTeamData
        {
            /// <summary>The project number.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("projectNumber")]
            public virtual string ProjectNumber { get; set; }

            /// <summary>The team.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("team")]
            public virtual string Team { get; set; }
        }
    }

    /// <summary>An access-control list.</summary>
    public class ObjectAccessControls : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<ObjectAccessControl> Items { get; set; }

        /// <summary>
        /// The kind of item this is. For lists of object access control entries, this is always
        /// storage#objectAccessControls.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The payload of a single user-defined object context.</summary>
    public class ObjectCustomContextPayload : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which the object context was created in RFC 3339 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual System.DateTime? CreateTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The time at which the object context was last updated in RFC 3339 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.DiscoveryFormat.ParseDateTimeToDateTimeOffset(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.DiscoveryFormat.FormatDateTimeOffsetToDateTime(value);
        }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual System.DateTime? UpdateTime
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>The value of the object context.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of objects.</summary>
    public class Objects : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Object> Items { get; set; }

        /// <summary>The kind of item this is. For lists of objects, this is always storage#objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The continuation token, used to page through large result sets. Provide this value in a subsequent request
        /// to return the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The list of prefixes of objects matching-but-not-listed up to and including the requested delimiter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefixes")]
        public virtual System.Collections.Generic.IList<string> Prefixes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A bucket/object/managedFolder IAM policy.</summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An association between a role, which comes with a set of permissions, and members who may assume that role.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<BindingsData> Bindings { get; set; }

        /// <summary>HTTP 1.1  Entity tag for the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// The kind of item this is. For policies, this is always storage#policy. This field is ignored on input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The ID of the resource to which this policy belongs. Will be of the form projects/_/buckets/bucket for
        /// buckets, projects/_/buckets/bucket/objects/object for objects, and
        /// projects/_/buckets/bucket/managedFolders/managedFolder. A specific generation may be specified by appending
        /// #generationNumber to the end of the object name, e.g. projects/_/buckets/my-bucket/objects/data.txt#17. The
        /// current generation can be denoted with #0. This field is ignored on input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; }

        /// <summary>The IAM policy format version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }

        /// <summary>
        /// An association between a role, which comes with a set of permissions, and members who may assume that role.
        /// </summary>
        public class BindingsData
        {
            /// <summary>
            /// The condition that is associated with this binding. NOTE: an unsatisfied condition will not allow user
            /// access via current binding. Different bindings, including their conditions, are examined independently.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("condition")]
            public virtual Expr Condition { get; set; }

            /// <summary>
            /// A collection of identifiers for members who may assume the provided role. Recognized identifiers are as
            /// follows:   - allUsers - A special identifier that represents anyone on the internet; with or without a
            /// Google account.   - allAuthenticatedUsers - A special identifier that represents anyone who is
            /// authenticated with a Google account or a service account.   - user:emailid - An email address that
            /// represents a specific account. For example, user:alice@gmail.com or user:joe@example.com.   -
            /// serviceAccount:emailid - An email address that represents a service account. For example,
            /// serviceAccount:my-other-app@appspot.gserviceaccount.com .   - group:emailid - An email address that
            /// represents a Google group. For example, group:admins@example.com.   - domain:domain - A Google Apps
            /// domain name that represents all the users of that domain. For example, domain:google.com or
            /// domain:example.com.   - projectOwner:projectid - Owners of the given project. For example,
            /// projectOwner:my-example-project   - projectEditor:projectid - Editors of the given project. For example,
            /// projectEditor:my-example-project   - projectViewer:projectid - Viewers of the given project. For
            /// example, projectViewer:my-example-project
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("members")]
            public virtual System.Collections.Generic.IList<string> Members { get; set; }

            /// <summary>
            /// The role to which members belong. Two types of roles are supported: new IAM roles, which grant
            /// permissions that do not map directly to those provided by ACLs, and legacy IAM roles, which do map
            /// directly to ACL permissions. All roles are of the format roles/storage.specificRole. The new IAM roles
            /// are:   - roles/storage.admin - Full control of Google Cloud Storage resources.   -
            /// roles/storage.objectViewer - Read-Only access to Google Cloud Storage objects.   -
            /// roles/storage.objectCreator - Access to create objects in Google Cloud Storage.   -
            /// roles/storage.objectAdmin - Full control of Google Cloud Storage objects.   The legacy IAM roles are:
            /// - roles/storage.legacyObjectReader - Read-only access to objects without listing. Equivalent to an ACL
            /// entry on an object with the READER role.   - roles/storage.legacyObjectOwner - Read/write access to
            /// existing objects without listing. Equivalent to an ACL entry on an object with the OWNER role.   -
            /// roles/storage.legacyBucketReader - Read access to buckets with object listing. Equivalent to an ACL
            /// entry on a bucket with the READER role.   - roles/storage.legacyBucketWriter - Read access to buckets
            /// with object listing/creation/deletion. Equivalent to an ACL entry on a bucket with the WRITER role.   -
            /// roles/storage.legacyBucketOwner - Read and write access to existing buckets with object
            /// listing/creation/deletion. Equivalent to an ACL entry on a bucket with the OWNER role.
            /// </summary>
            [Newtonsoft.Json.JsonPropertyAttribute("role")]
            public virtual string Role { get; set; }
        }
    }

    /// <summary>A Relocate Bucket request.</summary>
    public class RelocateBucketRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bucket's new custom placement configuration if relocating to a Custom Dual Region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationCustomPlacementConfig")]
        public virtual DestinationCustomPlacementConfigData DestinationCustomPlacementConfig { get; set; }

        /// <summary>The new location the bucket will be relocated to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationLocation")]
        public virtual string DestinationLocation { get; set; }

        /// <summary>If true, validate the operation, but do not actually relocate the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validateOnly")]
        public virtual System.Nullable<bool> ValidateOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }

        /// <summary>The bucket's new custom placement configuration if relocating to a Custom Dual Region.</summary>
        public class DestinationCustomPlacementConfigData
        {
            /// <summary>The list of regional locations in which data is placed.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("dataLocations")]
            public virtual System.Collections.Generic.IList<string> DataLocations { get; set; }
        }
    }

    /// <summary>A rewrite response.</summary>
    public class RewriteResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// true if the copy is finished; otherwise, false if the copy is in progress. This property is always present
        /// in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The kind of item this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The total size of the object being copied in bytes. This property is always present in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectSize")]
        public virtual System.Nullable<long> ObjectSize { get; set; }

        /// <summary>
        /// A resource containing the metadata for the copied-to object. This property is present in the response only
        /// when copying completes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual Object Resource { get; set; }

        /// <summary>
        /// A token to use in subsequent requests to continue copying data. This token is present in the response only
        /// when there is more data to copy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rewriteToken")]
        public virtual string RewriteToken { get; set; }

        /// <summary>
        /// The total bytes written so far, which can be used to provide a waiting user with a progress indicator. This
        /// property is always present in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalBytesRewritten")]
        public virtual System.Nullable<long> TotalBytesRewritten { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A subscription to receive Google PubSub notifications.</summary>
    public class ServiceAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email_address")]
        public virtual string EmailAddress { get; set; }

        /// <summary>The kind of item this is. For notifications, this is always storage#notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A storage.(buckets|objects|managedFolders).testIamPermissions response.</summary>
    public class TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The kind of item this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// The permissions held by the caller. Permissions are always of the format storage.resource.capability, where
        /// resource is one of buckets, objects, or managedFolders. The supported permissions are as follows:   -
        /// storage.buckets.delete - Delete bucket.   - storage.buckets.get - Read bucket metadata.   -
        /// storage.buckets.getIamPolicy - Read bucket IAM policy.   - storage.buckets.create - Create bucket.   -
        /// storage.buckets.list - List buckets.   - storage.buckets.setIamPolicy - Update bucket IAM policy.   -
        /// storage.buckets.update - Update bucket metadata.   - storage.objects.delete - Delete object.   -
        /// storage.objects.get - Read object data and metadata.   - storage.objects.getIamPolicy - Read object IAM
        /// policy.   - storage.objects.create - Create object.   - storage.objects.list - List objects.   -
        /// storage.objects.setIamPolicy - Update object IAM policy.   - storage.objects.update - Update object
        /// metadata.  - storage.managedFolders.delete - Delete managed folder.   - storage.managedFolders.get - Read
        /// managed folder metadata.   - storage.managedFolders.getIamPolicy - Read managed folder IAM policy.   -
        /// storage.managedFolders.create - Create managed folder.   - storage.managedFolders.list - List managed
        /// folders.   - storage.managedFolders.setIamPolicy - Update managed folder IAM policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
