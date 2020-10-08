// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.Oauth2.v2
{
    /// <summary>The Oauth2 Service.</summary>
    public class Oauth2Service : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public Oauth2Service() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public Oauth2Service(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Userinfo = new UserinfoResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "oauth2";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://www.googleapis.com/";
        #else
            "https://www.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://www.googleapis.com/batch/oauth2/v2";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch/oauth2/v2";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google OAuth2 API.</summary>
        public class Scope
        {
            /// <summary>View your email address</summary>
            public static string UserinfoEmail = "https://www.googleapis.com/auth/userinfo.email";

            /// <summary>See your personal info, including any personal info you've made publicly available</summary>
            public static string UserinfoProfile = "https://www.googleapis.com/auth/userinfo.profile";

            /// <summary>Associate you with your personal info on Google</summary>
            public static string Openid = "openid";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google OAuth2 API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View your email address</summary>
            public const string UserinfoEmail = "https://www.googleapis.com/auth/userinfo.email";

            /// <summary>See your personal info, including any personal info you've made publicly available</summary>
            public const string UserinfoProfile = "https://www.googleapis.com/auth/userinfo.profile";

            /// <summary>Associate you with your personal info on Google</summary>
            public const string Openid = "openid";

        }

        public virtual TokeninfoRequest Tokeninfo()
        {
            return new TokeninfoRequest(this);
        }


        public class TokeninfoRequest : Oauth2BaseServiceRequest<Google.Apis.Oauth2.v2.Data.Tokeninfo>
        {
            /// <summary>Constructs a new Tokeninfo request.</summary>
            public TokeninfoRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }



            [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string AccessToken { get; set; }


            [Google.Apis.Util.RequestParameterAttribute("id_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string IdToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "tokeninfo";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "oauth2/v2/tokeninfo";

            /// <summary>Initializes Tokeninfo parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("id_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "id_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }


        /// <summary>Gets the Userinfo resource.</summary>
        public virtual UserinfoResource Userinfo { get; }
    }

    /// <summary>A base abstract class for Oauth2 requests.</summary>
    public abstract class Oauth2BaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new Oauth2BaseServiceRequest instance.</summary>
        protected Oauth2BaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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
            Json,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>An opaque string that represents a user for quota purposes. Must not exceed 40
        /// characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Deprecated. Please use quotaUser instead.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes Oauth2 parameter list.</summary>
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

    /// <summary>The "userinfo" collection of methods.</summary>
    public class UserinfoResource
    {
        private const string Resource = "userinfo";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UserinfoResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            V2 = new V2Resource(service);

        }

        /// <summary>Gets the V2 resource.</summary>
        public virtual V2Resource V2 { get; }

        /// <summary>The "v2" collection of methods.</summary>
        public class V2Resource
        {
            private const string Resource = "v2";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public V2Resource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Me = new MeResource(service);

            }

            /// <summary>Gets the Me resource.</summary>
            public virtual MeResource Me { get; }

            /// <summary>The "me" collection of methods.</summary>
            public class MeResource
            {
                private const string Resource = "me";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public MeResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }



                public virtual GetRequest Get()
                {
                    return new GetRequest(service);
                }


                public class GetRequest : Oauth2BaseServiceRequest<Google.Apis.Oauth2.v2.Data.Userinfo>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service) : base(service)
                    {
                        InitParameters();
                    }



                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "userinfo/v2/me";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                    }

                }
            }
        }


        public virtual GetRequest Get()
        {
            return new GetRequest(service);
        }


        public class GetRequest : Oauth2BaseServiceRequest<Google.Apis.Oauth2.v2.Data.Userinfo>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }



            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "oauth2/v2/userinfo";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }
    }
}

namespace Google.Apis.Oauth2.v2.Data
{    

    public class Tokeninfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Who is the intended audience for this token. In general the same as issued_to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual string Audience { get; set; }

        /// <summary>The email address of the user. Present only if the email scope is present in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The expiry time of the token, as number of seconds left until expiry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expires_in")]
        public virtual System.Nullable<int> ExpiresIn { get; set; }

        /// <summary>To whom was the token issued to. In general the same as audience.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issued_to")]
        public virtual string IssuedTo { get; set; }

        /// <summary>The space separated list of scopes granted to this token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>The obfuscated user id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("user_id")]
        public virtual string UserId { get; set; }

        /// <summary>Boolean flag which is true if the email address is verified. Present only if the email scope is
        /// present in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verified_email")]
        public virtual System.Nullable<bool> VerifiedEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class Userinfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user's email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The user's last name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("family_name")]
        public virtual string FamilyName { get; set; }

        /// <summary>The user's gender.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gender")]
        public virtual string Gender { get; set; }

        /// <summary>The user's first name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("given_name")]
        public virtual string GivenName { get; set; }

        /// <summary>The hosted domain e.g. example.com if the user is Google apps user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hd")]
        public virtual string Hd { get; set; }

        /// <summary>The obfuscated ID of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>URL of the profile page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual string Link { get; set; }

        /// <summary>The user's preferred locale.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>The user's full name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>URL of the user's picture image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("picture")]
        public virtual string Picture { get; set; }

        /// <summary>Boolean flag which is true if the email address is verified. Always verified because we only return
        /// the user's primary email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verified_email")]
        public virtual System.Nullable<bool> VerifiedEmail { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
