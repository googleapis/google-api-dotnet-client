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

namespace Google.Apis.Webfonts.v1
{
    /// <summary>The Webfonts Service.</summary>
    public class WebfontsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public WebfontsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public WebfontsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Webfonts = new WebfontsResource(this);
            BaseUri = GetEffectiveUri(BaseUriOverride, "https://webfonts.googleapis.com/");
            BatchUri = GetEffectiveUri(null, "https://webfonts.googleapis.com/batch");
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "webfonts";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri { get; }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri { get; }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Gets the Webfonts resource.</summary>
        public virtual WebfontsResource Webfonts { get; }
    }

    /// <summary>A base abstract class for Webfonts requests.</summary>
    public abstract class WebfontsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new WebfontsBaseServiceRequest instance.</summary>
        protected WebfontsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Webfonts parameter list.</summary>
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

    /// <summary>The "webfonts" collection of methods.</summary>
    public class WebfontsResource
    {
        private const string Resource = "webfonts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public WebfontsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Retrieves the list of fonts currently served by the Google Fonts Developer API.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(this.service);
        }

        /// <summary>Retrieves the list of fonts currently served by the Google Fonts Developer API.</summary>
        public class ListRequest : WebfontsBaseServiceRequest<Google.Apis.Webfonts.v1.Data.WebfontList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Controls the font urls in `Webfont.files`, by default, static ttf fonts are sent.</summary>
            /// <remarks>
            /// Use this property to set a single value for the parameter, or <see cref="CapabilityList"/> to set
            /// multiple values. Do not set both properties.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("capability", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<CapabilityEnum> Capability { get; set; }

            /// <summary>Controls the font urls in `Webfont.files`, by default, static ttf fonts are sent.</summary>
            /// <remarks>
            /// Use this property to set one or more values for the parameter. Do not set both this property and
            /// <see cref="Capability"/>.
            /// </remarks>
            [Google.Apis.Util.RequestParameterAttribute("capability", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<CapabilityEnum> CapabilityList { get; set; }

            /// <summary>Controls the font urls in `Webfont.files`, by default, static ttf fonts are sent.</summary>
            public enum CapabilityEnum
            {
                /// <summary>Default means static ttf fonts.</summary>
                [Google.Apis.Util.StringValueAttribute("CAPABILITY_UNSPECIFIED")]
                CAPABILITYUNSPECIFIED = 0,

                /// <summary>Use WOFF2(Compressed)instead of ttf.</summary>
                [Google.Apis.Util.StringValueAttribute("WOFF2")]
                WOFF2 = 1,

                /// <summary>
                /// Prefer variable font files instead of static fonts instantiated at standard weights.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("VF")]
                VF = 2,

                /// <summary>Include tags that apply to the entire family in the response.</summary>
                [Google.Apis.Util.StringValueAttribute("FAMILY_TAGS")]
                FAMILYTAGS = 3,
            }

            /// <summary>
            /// Filters by Webfont.category, if category is found in Webfont.categories. If not set, returns all
            /// families.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("category", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Category { get; set; }

            /// <summary>Filters by Webfont.family, using literal match. If not set, returns all families</summary>
            [Google.Apis.Util.RequestParameterAttribute("family", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Family { get; set; }

            /// <summary>Enables sorting of the list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sort", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SortEnum> Sort { get; set; }

            /// <summary>Enables sorting of the list.</summary>
            public enum SortEnum
            {
                /// <summary>No sorting specified, use the default sorting method.</summary>
                [Google.Apis.Util.StringValueAttribute("SORT_UNDEFINED")]
                SORTUNDEFINED = 0,

                /// <summary>Sort alphabetically</summary>
                [Google.Apis.Util.StringValueAttribute("ALPHA")]
                ALPHA = 1,

                /// <summary>Sort by date added</summary>
                [Google.Apis.Util.StringValueAttribute("DATE")]
                DATE = 2,

                /// <summary>Sort by popularity</summary>
                [Google.Apis.Util.StringValueAttribute("POPULARITY")]
                POPULARITY = 3,

                /// <summary>Sort by number of styles</summary>
                [Google.Apis.Util.StringValueAttribute("STYLE")]
                STYLE = 4,

                /// <summary>Sort by trending</summary>
                [Google.Apis.Util.StringValueAttribute("TRENDING")]
                TRENDING = 5,
            }

            /// <summary>
            /// Filters by Webfont.subset, if subset is found in Webfont.subsets. If not set, returns all families.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("subset", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Subset { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/webfonts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("capability", new Google.Apis.Discovery.Parameter
                {
                    Name = "capability",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("category", new Google.Apis.Discovery.Parameter
                {
                    Name = "category",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("family", new Google.Apis.Discovery.Parameter
                {
                    Name = "family",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("sort", new Google.Apis.Discovery.Parameter
                {
                    Name = "sort",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("subset", new Google.Apis.Discovery.Parameter
                {
                    Name = "subset",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Webfonts.v1.Data
{
    /// <summary>Metadata for a variable font axis.</summary>
    public class Axis : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>maximum value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual System.Nullable<float> End { get; set; }

        /// <summary>minimum value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual System.Nullable<float> Start { get; set; }

        /// <summary>tag name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata for a tag.</summary>
    public class Tag : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The weight of the tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weight")]
        public virtual System.Nullable<float> Weight { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata describing a family of fonts.</summary>
    public class Webfont : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Axis for variable fonts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("axes")]
        public virtual System.Collections.Generic.IList<Axis> Axes { get; set; }

        /// <summary>The category of the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>The color format(s) available for this family.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorCapabilities")]
        public virtual System.Collections.Generic.IList<string> ColorCapabilities { get; set; }

        /// <summary>The name of the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("family")]
        public virtual string Family { get; set; }

        /// <summary>
        /// The font files (with all supported scripts) for each one of the available variants, as a key : value map.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IDictionary<string, string> Files { get; set; }

        /// <summary>This kind represents a webfont object in the webfonts service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The date (format "yyyy-MM-dd") the font was modified for the last time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastModified")]
        public virtual string LastModified { get; set; }

        /// <summary>Font URL for menu subset, a subset of the font that is enough to display the font name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("menu")]
        public virtual string Menu { get; set; }

        /// <summary>The scripts supported by the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subsets")]
        public virtual System.Collections.Generic.IList<string> Subsets { get; set; }

        /// <summary>The tags that apply to this family.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<Tag> Tags { get; set; }

        /// <summary>The available variants for the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variants")]
        public virtual System.Collections.Generic.IList<string> Variants { get; set; }

        /// <summary>The font version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response containing the list of fonts currently served by the Google Fonts API.</summary>
    public class WebfontList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of fonts currently served by the Google Fonts API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Webfont> Items { get; set; }

        /// <summary>This kind represents a list of webfont objects in the webfonts service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
