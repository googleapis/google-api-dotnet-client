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

namespace Google.Apis.CloudHealthcare.v1
{
    /// <summary>The CloudHealthcare Service.</summary>
    public class CloudHealthcareService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudHealthcareService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudHealthcareService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "healthcare";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://healthcare.googleapis.com/";
        #else
            "https://healthcare.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://healthcare.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Healthcare API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Healthcare API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for CloudHealthcare requests.</summary>
    public abstract class CloudHealthcareBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudHealthcareBaseServiceRequest instance.</summary>
        protected CloudHealthcareBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudHealthcare parameter list.</summary>
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
            Locations = new LocationsResource(service);
        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>The "locations" collection of methods.</summary>
        public class LocationsResource
        {
            private const string Resource = "locations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LocationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Datasets = new DatasetsResource(service);
            }

            /// <summary>Gets the Datasets resource.</summary>
            public virtual DatasetsResource Datasets { get; }

            /// <summary>The "datasets" collection of methods.</summary>
            public class DatasetsResource
            {
                private const string Resource = "datasets";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DatasetsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    ConsentStores = new ConsentStoresResource(service);
                    DicomStores = new DicomStoresResource(service);
                    FhirStores = new FhirStoresResource(service);
                    Hl7V2Stores = new Hl7V2StoresResource(service);
                    Operations = new OperationsResource(service);
                }

                /// <summary>Gets the ConsentStores resource.</summary>
                public virtual ConsentStoresResource ConsentStores { get; }

                /// <summary>The "consentStores" collection of methods.</summary>
                public class ConsentStoresResource
                {
                    private const string Resource = "consentStores";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ConsentStoresResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        AttributeDefinitions = new AttributeDefinitionsResource(service);
                        ConsentArtifacts = new ConsentArtifactsResource(service);
                        Consents = new ConsentsResource(service);
                        UserDataMappings = new UserDataMappingsResource(service);
                    }

                    /// <summary>Gets the AttributeDefinitions resource.</summary>
                    public virtual AttributeDefinitionsResource AttributeDefinitions { get; }

                    /// <summary>The "attributeDefinitions" collection of methods.</summary>
                    public class AttributeDefinitionsResource
                    {
                        private const string Resource = "attributeDefinitions";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public AttributeDefinitionsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Creates a new Attribute definition in the parent consent store.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The name of the consent store that this Attribute definition belongs to.
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.CloudHealthcare.v1.Data.AttributeDefinition body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Creates a new Attribute definition in the parent consent store.</summary>
                        public class CreateRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.AttributeDefinition>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.AttributeDefinition body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the consent store that this Attribute definition belongs to.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Required. The ID of the Attribute definition to create. The string must match the
                            /// following regex: `_a-zA-Z{0,255}` and must not be a reserved keyword within the Common
                            /// Expression Language as listed on
                            /// https://github.com/google/cel-spec/blob/master/doc/langdef.md.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("attributeDefinitionId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string AttributeDefinitionId { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.AttributeDefinition Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/attributeDefinitions";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+$",
                                });
                                RequestParameters.Add("attributeDefinitionId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "attributeDefinitionId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>
                        /// Deletes the specified Attribute definition. Fails if the Attribute definition is referenced
                        /// by any User data mapping, or the latest revision of any Consent.
                        /// </summary>
                        /// <param name="name">
                        /// Required. The resource name of the Attribute definition to delete. To preserve referential
                        /// integrity, Attribute definitions referenced by a User data mapping or the latest revision of
                        /// a Consent cannot be deleted.
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>
                        /// Deletes the specified Attribute definition. Fails if the Attribute definition is referenced
                        /// by any User data mapping, or the latest revision of any Consent.
                        /// </summary>
                        public class DeleteRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Empty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the Attribute definition to delete. To preserve
                            /// referential integrity, Attribute definitions referenced by a User data mapping or the
                            /// latest revision of a Consent cannot be deleted.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+/attributeDefinitions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Gets the specified Attribute definition.</summary>
                        /// <param name="name">Required. The resource name of the Attribute definition to get.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Gets the specified Attribute definition.</summary>
                        public class GetRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.AttributeDefinition>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The resource name of the Attribute definition to get.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+/attributeDefinitions/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Lists the Attribute definitions in the specified consent store.</summary>
                        /// <param name="parent">
                        /// Required. Name of the consent store to retrieve Attribute definitions from.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Lists the Attribute definitions in the specified consent store.</summary>
                        public class ListRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ListAttributeDefinitionsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Name of the consent store to retrieve Attribute definitions from.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. Restricts the attributes returned to those matching a filter. The only field
                            /// available for filtering is `category`. For example, `filter=category=\"REQUEST\"`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// Optional. Limit on the number of Attribute definitions to return in a single response.
                            /// If not specified, 100 is used. May not be larger than 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. Token to retrieve the next page of results or empty to get the first page.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/attributeDefinitions";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+$",
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

                        /// <summary>Updates the specified Attribute definition.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Resource name of the Attribute definition, of the form
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/attributeDefinitions/{attribute_definition_id}`.
                        /// Cannot be changed after creation.
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.CloudHealthcare.v1.Data.AttributeDefinition body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>Updates the specified Attribute definition.</summary>
                        public class PatchRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.AttributeDefinition>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.AttributeDefinition body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Resource name of the Attribute definition, of the form
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/attributeDefinitions/{attribute_definition_id}`.
                            /// Cannot be changed after creation.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Required. The update mask that applies to the resource. For the `FieldMask` definition,
                            /// see
                            /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask.
                            /// Only the `description`, `allowed_values`, `consent_default_values` and
                            /// `data_mapping_default_value` fields can be updated. The updated `allowed_values` must
                            /// contain all values from the previous `allowed_values`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.AttributeDefinition Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+/attributeDefinitions/[^/]+$",
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

                    /// <summary>Gets the ConsentArtifacts resource.</summary>
                    public virtual ConsentArtifactsResource ConsentArtifacts { get; }

                    /// <summary>The "consentArtifacts" collection of methods.</summary>
                    public class ConsentArtifactsResource
                    {
                        private const string Resource = "consentArtifacts";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public ConsentArtifactsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Creates a new Consent artifact in the parent consent store.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// Required. The name of the consent store this Consent artifact belongs to.
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.CloudHealthcare.v1.Data.ConsentArtifact body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Creates a new Consent artifact in the parent consent store.</summary>
                        public class CreateRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ConsentArtifact>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.ConsentArtifact body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the consent store this Consent artifact belongs to.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.ConsentArtifact Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/consentArtifacts";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Deletes the specified Consent artifact. Fails if the artifact is referenced by the latest
                        /// revision of any Consent.
                        /// </summary>
                        /// <param name="name">
                        /// Required. The resource name of the Consent artifact to delete. To preserve referential
                        /// integrity, Consent artifacts referenced by the latest revision of a Consent cannot be
                        /// deleted.
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>
                        /// Deletes the specified Consent artifact. Fails if the artifact is referenced by the latest
                        /// revision of any Consent.
                        /// </summary>
                        public class DeleteRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Empty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the Consent artifact to delete. To preserve referential
                            /// integrity, Consent artifacts referenced by the latest revision of a Consent cannot be
                            /// deleted.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+/consentArtifacts/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Gets the specified Consent artifact.</summary>
                        /// <param name="name">Required. The resource name of the Consent artifact to retrieve.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Gets the specified Consent artifact.</summary>
                        public class GetRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ConsentArtifact>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The resource name of the Consent artifact to retrieve.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+/consentArtifacts/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Lists the Consent artifacts in the specified consent store.</summary>
                        /// <param name="parent">
                        /// Required. Name of the consent store to retrieve consent artifacts from.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Lists the Consent artifacts in the specified consent store.</summary>
                        public class ListRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ListConsentArtifactsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Name of the consent store to retrieve consent artifacts from.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. Restricts the artifacts returned to those matching a filter. The following
                            /// syntax is available: * A string field value can be written as text inside quotation
                            /// marks, for example `"query text"`. The only valid relational operation for text fields
                            /// is equality (`=`), where text is searched within the field, rather than having the field
                            /// be equal to the text. For example, `"Comment = great"` returns messages with `great` in
                            /// the comment field. * A number field value can be written as an integer, a decimal, or an
                            /// exponential. The valid relational operators for number fields are the equality operator
                            /// (`=`), along with the less than/greater than operators (`&amp;lt;`, `&amp;lt;=`,
                            /// `&amp;gt;`, `&amp;gt;=`). Note that there is no inequality (`!=`) operator. You can
                            /// prepend the `NOT` operator to an expression to negate it. * A date field value must be
                            /// written in `yyyy-mm-dd` form. Fields with date and time use the RFC3339 time format.
                            /// Leading zeros are required for one-digit months and days. The valid relational operators
                            /// for date fields are the equality operator (`=`) , along with the less than/greater than
                            /// operators (`&amp;lt;`, `&amp;lt;=`, `&amp;gt;`, `&amp;gt;=`). Note that there is no
                            /// inequality (`!=`) operator. You can prepend the `NOT` operator to an expression to
                            /// negate it. * Multiple field query expressions can be combined in one query by adding
                            /// `AND` or `OR` operators between the expressions. If a boolean operator appears within a
                            /// quoted string, it is not treated as special, it's just another part of the character
                            /// string to be matched. You can prepend the `NOT` operator to an expression to negate it.
                            /// The fields available for filtering are: - user_id. For example,
                            /// `filter=user_id=\"user123\"`. - consent_content_version - metadata. For example,
                            /// `filter=Metadata(\"testkey\")=\"value\"` or `filter=HasMetadata(\"testkey\")`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// Optional. Limit on the number of consent artifacts to return in a single response. If
                            /// not specified, 100 is used. May not be larger than 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. The next_page_token value returned from the previous List request, if any.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/consentArtifacts";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+$",
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

                    /// <summary>Gets the Consents resource.</summary>
                    public virtual ConsentsResource Consents { get; }

                    /// <summary>The "consents" collection of methods.</summary>
                    public class ConsentsResource
                    {
                        private const string Resource = "consents";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public ConsentsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Activates the latest revision of the specified Consent by committing a new revision with
                        /// `state` updated to `ACTIVE`. If the latest revision of the specified Consent is in the
                        /// `ACTIVE` state, no new revision is committed. A FAILED_PRECONDITION error occurs if the
                        /// latest revision of the specified Consent is in the `REJECTED` or `REVOKED` state.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The resource name of the Consent to activate, of the form
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}`.
                        /// An INVALID_ARGUMENT error occurs if `revision_id` is specified in the name.
                        /// </param>
                        public virtual ActivateRequest Activate(Google.Apis.CloudHealthcare.v1.Data.ActivateConsentRequest body, string name)
                        {
                            return new ActivateRequest(service, body, name);
                        }

                        /// <summary>
                        /// Activates the latest revision of the specified Consent by committing a new revision with
                        /// `state` updated to `ACTIVE`. If the latest revision of the specified Consent is in the
                        /// `ACTIVE` state, no new revision is committed. A FAILED_PRECONDITION error occurs if the
                        /// latest revision of the specified Consent is in the `REJECTED` or `REVOKED` state.
                        /// </summary>
                        public class ActivateRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Consent>
                        {
                            /// <summary>Constructs a new Activate request.</summary>
                            public ActivateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.ActivateConsentRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the Consent to activate, of the form
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}`.
                            /// An INVALID_ARGUMENT error occurs if `revision_id` is specified in the name.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.ActivateConsentRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "activate";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:activate";

                            /// <summary>Initializes Activate parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+/consents/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Creates a new Consent in the parent consent store.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">Required. Name of the consent store.</param>
                        public virtual CreateRequest Create(Google.Apis.CloudHealthcare.v1.Data.Consent body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Creates a new Consent in the parent consent store.</summary>
                        public class CreateRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Consent>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.Consent body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. Name of the consent store.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.Consent Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/consents";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Deletes the Consent and its revisions. To keep a record of the Consent but mark it inactive,
                        /// see [RevokeConsent]. To delete a revision of a Consent, see [DeleteConsentRevision]. This
                        /// operation does not delete the related Consent artifact.
                        /// </summary>
                        /// <param name="name">
                        /// Required. The resource name of the Consent to delete, of the form
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}`.
                        /// An INVALID_ARGUMENT error occurs if `revision_id` is specified in the name.
                        /// </param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>
                        /// Deletes the Consent and its revisions. To keep a record of the Consent but mark it inactive,
                        /// see [RevokeConsent]. To delete a revision of a Consent, see [DeleteConsentRevision]. This
                        /// operation does not delete the related Consent artifact.
                        /// </summary>
                        public class DeleteRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Empty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the Consent to delete, of the form
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}`.
                            /// An INVALID_ARGUMENT error occurs if `revision_id` is specified in the name.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+/consents/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Deletes the specified revision of a Consent. An INVALID_ARGUMENT error occurs if the
                        /// specified revision is the latest revision.
                        /// </summary>
                        /// <param name="name">
                        /// Required. The resource name of the Consent revision to delete, of the form
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}@{revision_id}`.
                        /// An INVALID_ARGUMENT error occurs if `revision_id` is not specified in the name.
                        /// </param>
                        public virtual DeleteRevisionRequest DeleteRevision(string name)
                        {
                            return new DeleteRevisionRequest(service, name);
                        }

                        /// <summary>
                        /// Deletes the specified revision of a Consent. An INVALID_ARGUMENT error occurs if the
                        /// specified revision is the latest revision.
                        /// </summary>
                        public class DeleteRevisionRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Empty>
                        {
                            /// <summary>Constructs a new DeleteRevision request.</summary>
                            public DeleteRevisionRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the Consent revision to delete, of the form
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}@{revision_id}`.
                            /// An INVALID_ARGUMENT error occurs if `revision_id` is not specified in the name.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "deleteRevision";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:deleteRevision";

                            /// <summary>Initializes DeleteRevision parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+/consents/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Gets the specified revision of a Consent, or the latest revision if `revision_id` is not
                        /// specified in the resource name.
                        /// </summary>
                        /// <param name="name">
                        /// Required. The resource name of the Consent to retrieve, of the form
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}`.
                        /// In order to retrieve a previous revision of the Consent, also provide the revision ID:
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}@{revision_id}`
                        /// </param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>
                        /// Gets the specified revision of a Consent, or the latest revision if `revision_id` is not
                        /// specified in the resource name.
                        /// </summary>
                        public class GetRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Consent>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the Consent to retrieve, of the form
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}`.
                            /// In order to retrieve a previous revision of the Consent, also provide the revision ID:
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}@{revision_id}`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+/consents/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists the Consent in the given consent store, returning each Consent's latest revision.
                        /// </summary>
                        /// <param name="parent">Required. Name of the consent store to retrieve Consents from.</param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>
                        /// Lists the Consent in the given consent store, returning each Consent's latest revision.
                        /// </summary>
                        public class ListRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ListConsentsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>Required. Name of the consent store to retrieve Consents from.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. Restricts the Consents returned to those matching a filter. The following
                            /// syntax is available: * A string field value can be written as text inside quotation
                            /// marks, for example `"query text"`. The only valid relational operation for text fields
                            /// is equality (`=`), where text is searched within the field, rather than having the field
                            /// be equal to the text. For example, `"Comment = great"` returns messages with `great` in
                            /// the comment field. * A number field value can be written as an integer, a decimal, or an
                            /// exponential. The valid relational operators for number fields are the equality operator
                            /// (`=`), along with the less than/greater than operators (`&amp;lt;`, `&amp;lt;=`,
                            /// `&amp;gt;`, `&amp;gt;=`). Note that there is no inequality (`!=`) operator. You can
                            /// prepend the `NOT` operator to an expression to negate it. * A date field value must be
                            /// written in `yyyy-mm-dd` form. Fields with date and time use the RFC3339 time format.
                            /// Leading zeros are required for one-digit months and days. The valid relational operators
                            /// for date fields are the equality operator (`=`) , along with the less than/greater than
                            /// operators (`&amp;lt;`, `&amp;lt;=`, `&amp;gt;`, `&amp;gt;=`). Note that there is no
                            /// inequality (`!=`) operator. You can prepend the `NOT` operator to an expression to
                            /// negate it. * Multiple field query expressions can be combined in one query by adding
                            /// `AND` or `OR` operators between the expressions. If a boolean operator appears within a
                            /// quoted string, it is not treated as special, it's just another part of the character
                            /// string to be matched. You can prepend the `NOT` operator to an expression to negate it.
                            /// The fields available for filtering are: - user_id. For example,
                            /// `filter='user_id="user123"'`. - consent_artifact - state - revision_create_time -
                            /// metadata. For example, `filter=Metadata(\"testkey\")=\"value\"` or
                            /// `filter=HasMetadata(\"testkey\")`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// Optional. Limit on the number of Consents to return in a single response. If not
                            /// specified, 100 is used. May not be larger than 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. The next_page_token value returned from the previous List request, if any.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/consents";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+$",
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

                        /// <summary>
                        /// Lists the revisions of the specified Consent in reverse chronological order.
                        /// </summary>
                        /// <param name="name">
                        /// Required. The resource name of the Consent to retrieve revisions for.
                        /// </param>
                        public virtual ListRevisionsRequest ListRevisions(string name)
                        {
                            return new ListRevisionsRequest(service, name);
                        }

                        /// <summary>
                        /// Lists the revisions of the specified Consent in reverse chronological order.
                        /// </summary>
                        public class ListRevisionsRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ListConsentRevisionsResponse>
                        {
                            /// <summary>Constructs a new ListRevisions request.</summary>
                            public ListRevisionsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The resource name of the Consent to retrieve revisions for.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Optional. Restricts the revisions returned to those matching a filter. The following
                            /// syntax is available: * A string field value can be written as text inside quotation
                            /// marks, for example `"query text"`. The only valid relational operation for text fields
                            /// is equality (`=`), where text is searched within the field, rather than having the field
                            /// be equal to the text. For example, `"Comment = great"` returns messages with `great` in
                            /// the comment field. * A number field value can be written as an integer, a decimal, or an
                            /// exponential. The valid relational operators for number fields are the equality operator
                            /// (`=`), along with the less than/greater than operators (`&amp;lt;`, `&amp;lt;=`,
                            /// `&amp;gt;`, `&amp;gt;=`). Note that there is no inequality (`!=`) operator. You can
                            /// prepend the `NOT` operator to an expression to negate it. * A date field value must be
                            /// written in `yyyy-mm-dd` form. Fields with date and time use the RFC3339 time format.
                            /// Leading zeros are required for one-digit months and days. The valid relational operators
                            /// for date fields are the equality operator (`=`) , along with the less than/greater than
                            /// operators (`&amp;lt;`, `&amp;lt;=`, `&amp;gt;`, `&amp;gt;=`). Note that there is no
                            /// inequality (`!=`) operator. You can prepend the `NOT` operator to an expression to
                            /// negate it. * Multiple field query expressions can be combined in one query by adding
                            /// `AND` or `OR` operators between the expressions. If a boolean operator appears within a
                            /// quoted string, it is not treated as special, it's just another part of the character
                            /// string to be matched. You can prepend the `NOT` operator to an expression to negate it.
                            /// Fields available for filtering are: - user_id. For example,
                            /// `filter='user_id="user123"'`. - consent_artifact - state - revision_create_time -
                            /// metadata. For example, `filter=Metadata(\"testkey\")=\"value\"` or
                            /// `filter=HasMetadata(\"testkey\")`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// Optional. Limit on the number of revisions to return in a single response. If not
                            /// specified, 100 is used. May not be larger than 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. Token to retrieve the next page of results or empty if there are no more
                            /// results in the list.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "listRevisions";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:listRevisions";

                            /// <summary>Initializes ListRevisions parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+/consents/[^/]+$",
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

                        /// <summary>
                        /// Updates the latest revision of the specified Consent by committing a new revision with the
                        /// changes. A FAILED_PRECONDITION error occurs if the latest revision of the specified Consent
                        /// is in the `REJECTED` or `REVOKED` state.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Resource name of the Consent, of the form
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}`.
                        /// Cannot be changed after creation.
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.CloudHealthcare.v1.Data.Consent body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>
                        /// Updates the latest revision of the specified Consent by committing a new revision with the
                        /// changes. A FAILED_PRECONDITION error occurs if the latest revision of the specified Consent
                        /// is in the `REJECTED` or `REVOKED` state.
                        /// </summary>
                        public class PatchRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Consent>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.Consent body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Resource name of the Consent, of the form
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}`.
                            /// Cannot be changed after creation.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Required. The update mask to apply to the resource. For the `FieldMask` definition, see
                            /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask.
                            /// Only the `user_id`, `policies`, `consent_artifact`, and `metadata` fields can be
                            /// updated.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.Consent Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+/consents/[^/]+$",
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

                        /// <summary>
                        /// Rejects the latest revision of the specified Consent by committing a new revision with
                        /// `state` updated to `REJECTED`. If the latest revision of the specified Consent is in the
                        /// `REJECTED` state, no new revision is committed. A FAILED_PRECONDITION error occurs if the
                        /// latest revision of the specified Consent is in the `ACTIVE` or `REVOKED` state.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The resource name of the Consent to reject, of the form
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}`.
                        /// An INVALID_ARGUMENT error occurs if `revision_id` is specified in the name.
                        /// </param>
                        public virtual RejectRequest Reject(Google.Apis.CloudHealthcare.v1.Data.RejectConsentRequest body, string name)
                        {
                            return new RejectRequest(service, body, name);
                        }

                        /// <summary>
                        /// Rejects the latest revision of the specified Consent by committing a new revision with
                        /// `state` updated to `REJECTED`. If the latest revision of the specified Consent is in the
                        /// `REJECTED` state, no new revision is committed. A FAILED_PRECONDITION error occurs if the
                        /// latest revision of the specified Consent is in the `ACTIVE` or `REVOKED` state.
                        /// </summary>
                        public class RejectRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Consent>
                        {
                            /// <summary>Constructs a new Reject request.</summary>
                            public RejectRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.RejectConsentRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the Consent to reject, of the form
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}`.
                            /// An INVALID_ARGUMENT error occurs if `revision_id` is specified in the name.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.RejectConsentRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "reject";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:reject";

                            /// <summary>Initializes Reject parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+/consents/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Revokes the latest revision of the specified Consent by committing a new revision with
                        /// `state` updated to `REVOKED`. If the latest revision of the specified Consent is in the
                        /// `REVOKED` state, no new revision is committed. A FAILED_PRECONDITION error occurs if the
                        /// latest revision of the given consent is in `DRAFT` or `REJECTED` state.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Required. The resource name of the Consent to revoke, of the form
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}`.
                        /// An INVALID_ARGUMENT error occurs if `revision_id` is specified in the name.
                        /// </param>
                        public virtual RevokeRequest Revoke(Google.Apis.CloudHealthcare.v1.Data.RevokeConsentRequest body, string name)
                        {
                            return new RevokeRequest(service, body, name);
                        }

                        /// <summary>
                        /// Revokes the latest revision of the specified Consent by committing a new revision with
                        /// `state` updated to `REVOKED`. If the latest revision of the specified Consent is in the
                        /// `REVOKED` state, no new revision is committed. A FAILED_PRECONDITION error occurs if the
                        /// latest revision of the given consent is in `DRAFT` or `REJECTED` state.
                        /// </summary>
                        public class RevokeRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Consent>
                        {
                            /// <summary>Constructs a new Revoke request.</summary>
                            public RevokeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.RevokeConsentRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The resource name of the Consent to revoke, of the form
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}`.
                            /// An INVALID_ARGUMENT error occurs if `revision_id` is specified in the name.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.RevokeConsentRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "revoke";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:revoke";

                            /// <summary>Initializes Revoke parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+/consents/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Gets the UserDataMappings resource.</summary>
                    public virtual UserDataMappingsResource UserDataMappings { get; }

                    /// <summary>The "userDataMappings" collection of methods.</summary>
                    public class UserDataMappingsResource
                    {
                        private const string Resource = "userDataMappings";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public UserDataMappingsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>Archives the specified User data mapping.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Required. The resource name of the User data mapping to archive.</param>
                        public virtual ArchiveRequest Archive(Google.Apis.CloudHealthcare.v1.Data.ArchiveUserDataMappingRequest body, string name)
                        {
                            return new ArchiveRequest(service, body, name);
                        }

                        /// <summary>Archives the specified User data mapping.</summary>
                        public class ArchiveRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ArchiveUserDataMappingResponse>
                        {
                            /// <summary>Constructs a new Archive request.</summary>
                            public ArchiveRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.ArchiveUserDataMappingRequest body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. The resource name of the User data mapping to archive.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.ArchiveUserDataMappingRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "archive";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}:archive";

                            /// <summary>Initializes Archive parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+/userDataMappings/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Creates a new User data mapping in the parent consent store.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">Required. Name of the consent store.</param>
                        public virtual CreateRequest Create(Google.Apis.CloudHealthcare.v1.Data.UserDataMapping body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Creates a new User data mapping in the parent consent store.</summary>
                        public class CreateRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.UserDataMapping>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.UserDataMapping body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Required. Name of the consent store.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.UserDataMapping Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/userDataMappings";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Deletes the specified User data mapping.</summary>
                        /// <param name="name">Required. The resource name of the User data mapping to delete.</param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>Deletes the specified User data mapping.</summary>
                        public class DeleteRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Empty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The resource name of the User data mapping to delete.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+/userDataMappings/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Gets the specified User data mapping.</summary>
                        /// <param name="name">Required. The resource name of the User data mapping to retrieve.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Gets the specified User data mapping.</summary>
                        public class GetRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.UserDataMapping>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Required. The resource name of the User data mapping to retrieve.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+/userDataMappings/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Lists the User data mappings in the specified consent store.</summary>
                        /// <param name="parent">
                        /// Required. Name of the consent store to retrieve User data mappings from.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Lists the User data mappings in the specified consent store.</summary>
                        public class ListRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ListUserDataMappingsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. Name of the consent store to retrieve User data mappings from.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Optional. Restricts the User data mappings returned to those matching a filter. The
                            /// following syntax is available: * A string field value can be written as text inside
                            /// quotation marks, for example `"query text"`. The only valid relational operation for
                            /// text fields is equality (`=`), where text is searched within the field, rather than
                            /// having the field be equal to the text. For example, `"Comment = great"` returns messages
                            /// with `great` in the comment field. * A number field value can be written as an integer,
                            /// a decimal, or an exponential. The valid relational operators for number fields are the
                            /// equality operator (`=`), along with the less than/greater than operators (`&amp;lt;`,
                            /// `&amp;lt;=`, `&amp;gt;`, `&amp;gt;=`). Note that there is no inequality (`!=`) operator.
                            /// You can prepend the `NOT` operator to an expression to negate it. * A date field value
                            /// must be written in `yyyy-mm-dd` form. Fields with date and time use the RFC3339 time
                            /// format. Leading zeros are required for one-digit months and days. The valid relational
                            /// operators for date fields are the equality operator (`=`) , along with the less
                            /// than/greater than operators (`&amp;lt;`, `&amp;lt;=`, `&amp;gt;`, `&amp;gt;=`). Note
                            /// that there is no inequality (`!=`) operator. You can prepend the `NOT` operator to an
                            /// expression to negate it. * Multiple field query expressions can be combined in one query
                            /// by adding `AND` or `OR` operators between the expressions. If a boolean operator appears
                            /// within a quoted string, it is not treated as special, it's just another part of the
                            /// character string to be matched. You can prepend the `NOT` operator to an expression to
                            /// negate it. The fields available for filtering are: - data_id - user_id. For example,
                            /// `filter=user_id=\"user123\"`. - archived - archive_time
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// Optional. Limit on the number of User data mappings to return in a single response. If
                            /// not specified, 100 is used. May not be larger than 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// Optional. Token to retrieve the next page of results, or empty to get the first page.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/userDataMappings";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+$",
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

                        /// <summary>Updates the specified User data mapping.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Resource name of the User data mapping, of the form
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/userDataMappings/{user_data_mapping_id}`.
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.CloudHealthcare.v1.Data.UserDataMapping body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>Updates the specified User data mapping.</summary>
                        public class PatchRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.UserDataMapping>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.UserDataMapping body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Resource name of the User data mapping, of the form
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/userDataMappings/{user_data_mapping_id}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Required. The update mask that applies to the resource. For the `FieldMask` definition,
                            /// see
                            /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask.
                            /// Only the `data_id`, `user_id` and `resource_attributes` fields can be updated.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.UserDataMapping Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+/userDataMappings/[^/]+$",
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

                    /// <summary>
                    /// Checks if a particular data_id of a User data mapping in the specified consent store is
                    /// consented for the specified use.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="consentStore">
                    /// Required. Name of the consent store where the requested data_id is stored, of the form
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}`.
                    /// </param>
                    public virtual CheckDataAccessRequest CheckDataAccess(Google.Apis.CloudHealthcare.v1.Data.CheckDataAccessRequest body, string consentStore)
                    {
                        return new CheckDataAccessRequest(service, body, consentStore);
                    }

                    /// <summary>
                    /// Checks if a particular data_id of a User data mapping in the specified consent store is
                    /// consented for the specified use.
                    /// </summary>
                    public class CheckDataAccessRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.CheckDataAccessResponse>
                    {
                        /// <summary>Constructs a new CheckDataAccess request.</summary>
                        public CheckDataAccessRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.CheckDataAccessRequest body, string consentStore) : base(service)
                        {
                            ConsentStore = consentStore;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. Name of the consent store where the requested data_id is stored, of the form
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("consentStore", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ConsentStore { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.CheckDataAccessRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "checkDataAccess";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+consentStore}:checkDataAccess";

                        /// <summary>Initializes CheckDataAccess parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("consentStore", new Google.Apis.Discovery.Parameter
                            {
                                Name = "consentStore",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Creates a new consent store in the parent dataset. Attempting to create a consent store with the
                    /// same ID as an existing store fails with an ALREADY_EXISTS error.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The name of the dataset this consent store belongs to.</param>
                    public virtual CreateRequest Create(Google.Apis.CloudHealthcare.v1.Data.ConsentStore body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>
                    /// Creates a new consent store in the parent dataset. Attempting to create a consent store with the
                    /// same ID as an existing store fails with an ALREADY_EXISTS error.
                    /// </summary>
                    public class CreateRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ConsentStore>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.ConsentStore body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. The name of the dataset this consent store belongs to.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Required. The ID of the consent store to create. The string must match the following regex:
                        /// `[\p{L}\p{N}_\-\.]{1,256}`. Cannot be changed after creation.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("consentStoreId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string ConsentStoreId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.ConsentStore Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/consentStores";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
                            });
                            RequestParameters.Add("consentStoreId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "consentStoreId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes the specified consent store and removes all the consent store's data.</summary>
                    /// <param name="name">Required. The resource name of the consent store to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes the specified consent store and removes all the consent store's data.</summary>
                    public class DeleteRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the consent store to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Evaluates the user's Consents for all matching User data mappings. Note: User data mappings are
                    /// indexed asynchronously, which can cause a slight delay between the time mappings are created or
                    /// updated and when they are included in EvaluateUserConsents results.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="consentStore">
                    /// Required. Name of the consent store to retrieve User data mappings from.
                    /// </param>
                    public virtual EvaluateUserConsentsRequest EvaluateUserConsents(Google.Apis.CloudHealthcare.v1.Data.EvaluateUserConsentsRequest body, string consentStore)
                    {
                        return new EvaluateUserConsentsRequest(service, body, consentStore);
                    }

                    /// <summary>
                    /// Evaluates the user's Consents for all matching User data mappings. Note: User data mappings are
                    /// indexed asynchronously, which can cause a slight delay between the time mappings are created or
                    /// updated and when they are included in EvaluateUserConsents results.
                    /// </summary>
                    public class EvaluateUserConsentsRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.EvaluateUserConsentsResponse>
                    {
                        /// <summary>Constructs a new EvaluateUserConsents request.</summary>
                        public EvaluateUserConsentsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.EvaluateUserConsentsRequest body, string consentStore) : base(service)
                        {
                            ConsentStore = consentStore;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the consent store to retrieve User data mappings from.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("consentStore", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ConsentStore { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.EvaluateUserConsentsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "evaluateUserConsents";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+consentStore}:evaluateUserConsents";

                        /// <summary>Initializes EvaluateUserConsents parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("consentStore", new Google.Apis.Discovery.Parameter
                            {
                                Name = "consentStore",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets the specified consent store.</summary>
                    /// <param name="name">Required. The resource name of the consent store to get.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets the specified consent store.</summary>
                    public class GetRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ConsentStore>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>Required. The resource name of the consent store to get.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(service, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                        /// specifying an invalid value will be rejected. Requests for policies with any conditional
                        /// bindings must specify version 3. Policies without any conditional bindings may specify any
                        /// valid value or leave the field unset. To learn which resources support conditions in their
                        /// IAM policies, see the [IAM
                        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:getIamPolicy";

                        /// <summary>Initializes GetIamPolicy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+$",
                            });
                            RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                            {
                                Name = "options.requestedPolicyVersion",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Lists the consent stores in the specified dataset.</summary>
                    /// <param name="parent">Required. Name of the dataset.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists the consent stores in the specified dataset.</summary>
                    public class ListRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ListConsentStoresResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the dataset.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Optional. Restricts the stores returned to those matching a filter. Only filtering on labels
                        /// is supported. For example, `filter=labels.key=value`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Optional. Limit on the number of consent stores to return in a single response. If not
                        /// specified, 100 is used. May not be larger than 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// Optional. Token to retrieve the next page of results, or empty to get the first page.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/consentStores";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
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

                    /// <summary>Updates the specified consent store.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Resource name of the consent store, of the form
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}`.
                    /// Cannot be changed after creation.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CloudHealthcare.v1.Data.ConsentStore body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates the specified consent store.</summary>
                    public class PatchRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ConsentStore>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.ConsentStore body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Resource name of the consent store, of the form
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}`.
                        /// Cannot be changed after creation.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. The update mask that applies to the resource. For the `FieldMask` definition, see
                        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask.
                        /// Only the `labels`, `default_consent_ttl`, and `enable_consent_create_on_update` fields are
                        /// allowed to be updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.ConsentStore Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+$",
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

                    /// <summary>
                    /// Queries all data_ids that are consented for a specified use in the given consent store and
                    /// writes them to a specified destination. The returned Operation includes a progress counter for
                    /// the number of User data mappings processed. If the request is successful, a detailed response is
                    /// returned of type QueryAccessibleDataResponse, contained in the response field when the operation
                    /// finishes. The metadata field type is OperationMetadata. Errors are logged to Cloud Logging (see
                    /// [Viewing error logs in Cloud
                    /// Logging](https://cloud.google.com/healthcare/docs/how-tos/logging)). For example, the following
                    /// sample log entry shows a `failed to evaluate consent policy` error that occurred during a
                    /// QueryAccessibleData call to consent store
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}`.
                    /// ```json jsonPayload: { @type:
                    /// "type.googleapis.com/google.cloud.healthcare.logging.QueryAccessibleDataLogEntry" error: { code:
                    /// 9 message: "failed to evaluate consent policy" } resourceName:
                    /// "projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}"
                    /// } logName: "projects/{project_id}/logs/healthcare.googleapis.com%2Fquery_accessible_data"
                    /// operation: { id:
                    /// "projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/operations/{operation_id}"
                    /// producer: "healthcare.googleapis.com/QueryAccessibleData" } receiveTimestamp: "TIMESTAMP"
                    /// resource: { labels: { consent_store_id: "{consent_store_id}" dataset_id: "{dataset_id}"
                    /// location: "{location_id}" project_id: "{project_id}" } type: "healthcare_consent_store" }
                    /// severity: "ERROR" timestamp: "TIMESTAMP" ```
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="consentStore">
                    /// Required. Name of the consent store to retrieve User data mappings from.
                    /// </param>
                    public virtual QueryAccessibleDataRequest QueryAccessibleData(Google.Apis.CloudHealthcare.v1.Data.QueryAccessibleDataRequest body, string consentStore)
                    {
                        return new QueryAccessibleDataRequest(service, body, consentStore);
                    }

                    /// <summary>
                    /// Queries all data_ids that are consented for a specified use in the given consent store and
                    /// writes them to a specified destination. The returned Operation includes a progress counter for
                    /// the number of User data mappings processed. If the request is successful, a detailed response is
                    /// returned of type QueryAccessibleDataResponse, contained in the response field when the operation
                    /// finishes. The metadata field type is OperationMetadata. Errors are logged to Cloud Logging (see
                    /// [Viewing error logs in Cloud
                    /// Logging](https://cloud.google.com/healthcare/docs/how-tos/logging)). For example, the following
                    /// sample log entry shows a `failed to evaluate consent policy` error that occurred during a
                    /// QueryAccessibleData call to consent store
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}`.
                    /// ```json jsonPayload: { @type:
                    /// "type.googleapis.com/google.cloud.healthcare.logging.QueryAccessibleDataLogEntry" error: { code:
                    /// 9 message: "failed to evaluate consent policy" } resourceName:
                    /// "projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}"
                    /// } logName: "projects/{project_id}/logs/healthcare.googleapis.com%2Fquery_accessible_data"
                    /// operation: { id:
                    /// "projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/operations/{operation_id}"
                    /// producer: "healthcare.googleapis.com/QueryAccessibleData" } receiveTimestamp: "TIMESTAMP"
                    /// resource: { labels: { consent_store_id: "{consent_store_id}" dataset_id: "{dataset_id}"
                    /// location: "{location_id}" project_id: "{project_id}" } type: "healthcare_consent_store" }
                    /// severity: "ERROR" timestamp: "TIMESTAMP" ```
                    /// </summary>
                    public class QueryAccessibleDataRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new QueryAccessibleData request.</summary>
                        public QueryAccessibleDataRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.QueryAccessibleDataRequest body, string consentStore) : base(service)
                        {
                            ConsentStore = consentStore;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>Required. Name of the consent store to retrieve User data mappings from.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("consentStore", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string ConsentStore { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.QueryAccessibleDataRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "queryAccessibleData";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+consentStore}:queryAccessibleData";

                        /// <summary>Initializes QueryAccessibleData parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("consentStore", new Google.Apis.Discovery.Parameter
                            {
                                Name = "consentStore",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudHealthcare.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:setIamPolicy";

                        /// <summary>Initializes SetIamPolicy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:testIamPermissions";

                        /// <summary>Initializes TestIamPermissions parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/consentStores/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the DicomStores resource.</summary>
                public virtual DicomStoresResource DicomStores { get; }

                /// <summary>The "dicomStores" collection of methods.</summary>
                public class DicomStoresResource
                {
                    private const string Resource = "dicomStores";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DicomStoresResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Studies = new StudiesResource(service);
                    }

                    /// <summary>Gets the Studies resource.</summary>
                    public virtual StudiesResource Studies { get; }

                    /// <summary>The "studies" collection of methods.</summary>
                    public class StudiesResource
                    {
                        private const string Resource = "studies";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public StudiesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                            Series = new SeriesResource(service);
                        }

                        /// <summary>Gets the Series resource.</summary>
                        public virtual SeriesResource Series { get; }

                        /// <summary>The "series" collection of methods.</summary>
                        public class SeriesResource
                        {
                            private const string Resource = "series";

                            /// <summary>The service which this resource belongs to.</summary>
                            private readonly Google.Apis.Services.IClientService service;

                            /// <summary>Constructs a new resource.</summary>
                            public SeriesResource(Google.Apis.Services.IClientService service)
                            {
                                this.service = service;
                                Instances = new InstancesResource(service);
                            }

                            /// <summary>Gets the Instances resource.</summary>
                            public virtual InstancesResource Instances { get; }

                            /// <summary>The "instances" collection of methods.</summary>
                            public class InstancesResource
                            {
                                private const string Resource = "instances";

                                /// <summary>The service which this resource belongs to.</summary>
                                private readonly Google.Apis.Services.IClientService service;

                                /// <summary>Constructs a new resource.</summary>
                                public InstancesResource(Google.Apis.Services.IClientService service)
                                {
                                    this.service = service;
                                    Frames = new FramesResource(service);
                                }

                                /// <summary>Gets the Frames resource.</summary>
                                public virtual FramesResource Frames { get; }

                                /// <summary>The "frames" collection of methods.</summary>
                                public class FramesResource
                                {
                                    private const string Resource = "frames";

                                    /// <summary>The service which this resource belongs to.</summary>
                                    private readonly Google.Apis.Services.IClientService service;

                                    /// <summary>Constructs a new resource.</summary>
                                    public FramesResource(Google.Apis.Services.IClientService service)
                                    {
                                        this.service = service;
                                    }

                                    /// <summary>
                                    /// RetrieveFrames returns instances associated with the given study, series, SOP
                                    /// Instance UID and frame numbers. See [RetrieveTransaction]
                                    /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.4}.
                                    /// For details on the implementation of RetrieveFrames, see [DICOM
                                    /// frames](https://cloud.google.com/healthcare/docs/dicom#dicom_frames) in the
                                    /// Cloud Healthcare API conformance statement. For samples that show how to call
                                    /// RetrieveFrames, see [Retrieving DICOM
                                    /// data](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#retrieving_dicom_data).
                                    /// </summary>
                                    /// <param name="parent">
                                    /// The name of the DICOM store that is being accessed. For example,
                                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                                    /// </param>
                                    /// <param name="dicomWebPath">
                                    /// The path of the RetrieveFrames DICOMweb request. For example,
                                    /// `studies/{study_uid}/series/{series_uid}/instances/{instance_uid}/frames/{frame_list}`.
                                    /// </param>
                                    public virtual RetrieveFramesRequest RetrieveFrames(string parent, string dicomWebPath)
                                    {
                                        return new RetrieveFramesRequest(service, parent, dicomWebPath);
                                    }

                                    /// <summary>
                                    /// RetrieveFrames returns instances associated with the given study, series, SOP
                                    /// Instance UID and frame numbers. See [RetrieveTransaction]
                                    /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.4}.
                                    /// For details on the implementation of RetrieveFrames, see [DICOM
                                    /// frames](https://cloud.google.com/healthcare/docs/dicom#dicom_frames) in the
                                    /// Cloud Healthcare API conformance statement. For samples that show how to call
                                    /// RetrieveFrames, see [Retrieving DICOM
                                    /// data](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#retrieving_dicom_data).
                                    /// </summary>
                                    public class RetrieveFramesRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                                    {
                                        /// <summary>Constructs a new RetrieveFrames request.</summary>
                                        public RetrieveFramesRequest(Google.Apis.Services.IClientService service, string parent, string dicomWebPath) : base(service)
                                        {
                                            Parent = parent;
                                            DicomWebPath = dicomWebPath;
                                            InitParameters();
                                        }

                                        /// <summary>
                                        /// The name of the DICOM store that is being accessed. For example,
                                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                                        /// </summary>
                                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                        public virtual string Parent { get; private set; }

                                        /// <summary>
                                        /// The path of the RetrieveFrames DICOMweb request. For example,
                                        /// `studies/{study_uid}/series/{series_uid}/instances/{instance_uid}/frames/{frame_list}`.
                                        /// </summary>
                                        [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                                        public virtual string DicomWebPath { get; private set; }

                                        /// <summary>Gets the method name.</summary>
                                        public override string MethodName => "retrieveFrames";

                                        /// <summary>Gets the HTTP method.</summary>
                                        public override string HttpMethod => "GET";

                                        /// <summary>Gets the REST path.</summary>
                                        public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                                        /// <summary>Initializes RetrieveFrames parameter list.</summary>
                                        protected override void InitParameters()
                                        {
                                            base.InitParameters();
                                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                            {
                                                Name = "parent",
                                                IsRequired = true,
                                                ParameterType = "path",
                                                DefaultValue = null,
                                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                                            });
                                            RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                                            {
                                                Name = "dicomWebPath",
                                                IsRequired = true,
                                                ParameterType = "path",
                                                DefaultValue = null,
                                                Pattern = @"^studies/[^/]+/series/[^/]+/instances/[^/]+/frames/[^/]+$",
                                            });
                                        }
                                    }

                                    /// <summary>
                                    /// RetrieveRenderedFrames returns instances associated with the given study,
                                    /// series, SOP Instance UID and frame numbers in an acceptable Rendered Media Type.
                                    /// See [RetrieveTransaction]
                                    /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.4).
                                    /// For details on the implementation of RetrieveRenderedFrames, see [Rendered
                                    /// resources](https://cloud.google.com/healthcare/docs/dicom#rendered_resources) in
                                    /// the Cloud Healthcare API conformance statement. For samples that show how to
                                    /// call RetrieveRenderedFrames, see [Retrieving consumer image
                                    /// formats](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#retrieving_consumer_image_formats).
                                    /// </summary>
                                    /// <param name="parent">
                                    /// The name of the DICOM store that is being accessed. For example,
                                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                                    /// </param>
                                    /// <param name="dicomWebPath">
                                    /// The path of the RetrieveRenderedFrames DICOMweb request. For example,
                                    /// `studies/{study_uid}/series/{series_uid}/instances/{instance_uid}/frames/{frame_list}/rendered`.
                                    /// </param>
                                    public virtual RetrieveRenderedRequest RetrieveRendered(string parent, string dicomWebPath)
                                    {
                                        return new RetrieveRenderedRequest(service, parent, dicomWebPath);
                                    }

                                    /// <summary>
                                    /// RetrieveRenderedFrames returns instances associated with the given study,
                                    /// series, SOP Instance UID and frame numbers in an acceptable Rendered Media Type.
                                    /// See [RetrieveTransaction]
                                    /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.4).
                                    /// For details on the implementation of RetrieveRenderedFrames, see [Rendered
                                    /// resources](https://cloud.google.com/healthcare/docs/dicom#rendered_resources) in
                                    /// the Cloud Healthcare API conformance statement. For samples that show how to
                                    /// call RetrieveRenderedFrames, see [Retrieving consumer image
                                    /// formats](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#retrieving_consumer_image_formats).
                                    /// </summary>
                                    public class RetrieveRenderedRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                                    {
                                        /// <summary>Constructs a new RetrieveRendered request.</summary>
                                        public RetrieveRenderedRequest(Google.Apis.Services.IClientService service, string parent, string dicomWebPath) : base(service)
                                        {
                                            Parent = parent;
                                            DicomWebPath = dicomWebPath;
                                            InitParameters();
                                        }

                                        /// <summary>
                                        /// The name of the DICOM store that is being accessed. For example,
                                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                                        /// </summary>
                                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                        public virtual string Parent { get; private set; }

                                        /// <summary>
                                        /// The path of the RetrieveRenderedFrames DICOMweb request. For example,
                                        /// `studies/{study_uid}/series/{series_uid}/instances/{instance_uid}/frames/{frame_list}/rendered`.
                                        /// </summary>
                                        [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                                        public virtual string DicomWebPath { get; private set; }

                                        /// <summary>Gets the method name.</summary>
                                        public override string MethodName => "retrieveRendered";

                                        /// <summary>Gets the HTTP method.</summary>
                                        public override string HttpMethod => "GET";

                                        /// <summary>Gets the REST path.</summary>
                                        public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                                        /// <summary>Initializes RetrieveRendered parameter list.</summary>
                                        protected override void InitParameters()
                                        {
                                            base.InitParameters();
                                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                            {
                                                Name = "parent",
                                                IsRequired = true,
                                                ParameterType = "path",
                                                DefaultValue = null,
                                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                                            });
                                            RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                                            {
                                                Name = "dicomWebPath",
                                                IsRequired = true,
                                                ParameterType = "path",
                                                DefaultValue = null,
                                                Pattern = @"^studies/[^/]+/series/[^/]+/instances/[^/]+/frames/[^/]+/rendered$",
                                            });
                                        }
                                    }
                                }

                                /// <summary>
                                /// DeleteInstance deletes an instance associated with the given study, series, and SOP
                                /// Instance UID. Delete requests are equivalent to the GET requests specified in the
                                /// Retrieve transaction. Study and series search results can take a few seconds to be
                                /// updated after an instance is deleted using DeleteInstance. For samples that show how
                                /// to call DeleteInstance, see [Deleting a study, series, or
                                /// instance](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#deleting_a_study_series_or_instance).
                                /// </summary>
                                /// <param name="parent">
                                /// The name of the DICOM store that is being accessed. For example,
                                /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                                /// </param>
                                /// <param name="dicomWebPath">
                                /// The path of the DeleteInstance request. For example,
                                /// `studies/{study_uid}/series/{series_uid}/instances/{instance_uid}`.
                                /// </param>
                                public virtual DeleteRequest Delete(string parent, string dicomWebPath)
                                {
                                    return new DeleteRequest(service, parent, dicomWebPath);
                                }

                                /// <summary>
                                /// DeleteInstance deletes an instance associated with the given study, series, and SOP
                                /// Instance UID. Delete requests are equivalent to the GET requests specified in the
                                /// Retrieve transaction. Study and series search results can take a few seconds to be
                                /// updated after an instance is deleted using DeleteInstance. For samples that show how
                                /// to call DeleteInstance, see [Deleting a study, series, or
                                /// instance](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#deleting_a_study_series_or_instance).
                                /// </summary>
                                public class DeleteRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Empty>
                                {
                                    /// <summary>Constructs a new Delete request.</summary>
                                    public DeleteRequest(Google.Apis.Services.IClientService service, string parent, string dicomWebPath) : base(service)
                                    {
                                        Parent = parent;
                                        DicomWebPath = dicomWebPath;
                                        InitParameters();
                                    }

                                    /// <summary>
                                    /// The name of the DICOM store that is being accessed. For example,
                                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                                    /// </summary>
                                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                    public virtual string Parent { get; private set; }

                                    /// <summary>
                                    /// The path of the DeleteInstance request. For example,
                                    /// `studies/{study_uid}/series/{series_uid}/instances/{instance_uid}`.
                                    /// </summary>
                                    [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                                    public virtual string DicomWebPath { get; private set; }

                                    /// <summary>Gets the method name.</summary>
                                    public override string MethodName => "delete";

                                    /// <summary>Gets the HTTP method.</summary>
                                    public override string HttpMethod => "DELETE";

                                    /// <summary>Gets the REST path.</summary>
                                    public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                                    /// <summary>Initializes Delete parameter list.</summary>
                                    protected override void InitParameters()
                                    {
                                        base.InitParameters();
                                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "parent",
                                            IsRequired = true,
                                            ParameterType = "path",
                                            DefaultValue = null,
                                            Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                                        });
                                        RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "dicomWebPath",
                                            IsRequired = true,
                                            ParameterType = "path",
                                            DefaultValue = null,
                                            Pattern = @"^studies/[^/]+/series/[^/]+/instances/[^/]+$",
                                        });
                                    }
                                }

                                /// <summary>
                                /// RetrieveInstance returns instance associated with the given study, series, and SOP
                                /// Instance UID. See [RetrieveTransaction]
                                /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.4). For
                                /// details on the implementation of RetrieveInstance, see [DICOM
                                /// study/series/instances](https://cloud.google.com/healthcare/docs/dicom#dicom_studyseriesinstances)
                                /// and [DICOM
                                /// instances](https://cloud.google.com/healthcare/docs/dicom#dicom_instances) in the
                                /// Cloud Healthcare API conformance statement. For samples that show how to call
                                /// RetrieveInstance, see [Retrieving an
                                /// instance](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#retrieving_an_instance).
                                /// </summary>
                                /// <param name="parent">
                                /// The name of the DICOM store that is being accessed. For example,
                                /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                                /// </param>
                                /// <param name="dicomWebPath">
                                /// The path of the RetrieveInstance DICOMweb request. For example,
                                /// `studies/{study_uid}/series/{series_uid}/instances/{instance_uid}`.
                                /// </param>
                                public virtual RetrieveInstanceRequest RetrieveInstance(string parent, string dicomWebPath)
                                {
                                    return new RetrieveInstanceRequest(service, parent, dicomWebPath);
                                }

                                /// <summary>
                                /// RetrieveInstance returns instance associated with the given study, series, and SOP
                                /// Instance UID. See [RetrieveTransaction]
                                /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.4). For
                                /// details on the implementation of RetrieveInstance, see [DICOM
                                /// study/series/instances](https://cloud.google.com/healthcare/docs/dicom#dicom_studyseriesinstances)
                                /// and [DICOM
                                /// instances](https://cloud.google.com/healthcare/docs/dicom#dicom_instances) in the
                                /// Cloud Healthcare API conformance statement. For samples that show how to call
                                /// RetrieveInstance, see [Retrieving an
                                /// instance](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#retrieving_an_instance).
                                /// </summary>
                                public class RetrieveInstanceRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                                {
                                    /// <summary>Constructs a new RetrieveInstance request.</summary>
                                    public RetrieveInstanceRequest(Google.Apis.Services.IClientService service, string parent, string dicomWebPath) : base(service)
                                    {
                                        Parent = parent;
                                        DicomWebPath = dicomWebPath;
                                        InitParameters();
                                    }

                                    /// <summary>
                                    /// The name of the DICOM store that is being accessed. For example,
                                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                                    /// </summary>
                                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                    public virtual string Parent { get; private set; }

                                    /// <summary>
                                    /// The path of the RetrieveInstance DICOMweb request. For example,
                                    /// `studies/{study_uid}/series/{series_uid}/instances/{instance_uid}`.
                                    /// </summary>
                                    [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                                    public virtual string DicomWebPath { get; private set; }

                                    /// <summary>Gets the method name.</summary>
                                    public override string MethodName => "retrieveInstance";

                                    /// <summary>Gets the HTTP method.</summary>
                                    public override string HttpMethod => "GET";

                                    /// <summary>Gets the REST path.</summary>
                                    public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                                    /// <summary>Initializes RetrieveInstance parameter list.</summary>
                                    protected override void InitParameters()
                                    {
                                        base.InitParameters();
                                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "parent",
                                            IsRequired = true,
                                            ParameterType = "path",
                                            DefaultValue = null,
                                            Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                                        });
                                        RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "dicomWebPath",
                                            IsRequired = true,
                                            ParameterType = "path",
                                            DefaultValue = null,
                                            Pattern = @"^studies/[^/]+/series/[^/]+/instances/[^/]+$",
                                        });
                                    }
                                }

                                /// <summary>
                                /// RetrieveInstanceMetadata returns instance associated with the given study, series,
                                /// and SOP Instance UID presented as metadata with the bulk data removed. See
                                /// [RetrieveTransaction]
                                /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.4). For
                                /// details on the implementation of RetrieveInstanceMetadata, see [Metadata
                                /// resources](https://cloud.google.com/healthcare/docs/dicom#metadata_resources) in the
                                /// Cloud Healthcare API conformance statement. For samples that show how to call
                                /// RetrieveInstanceMetadata, see [Retrieving
                                /// metadata](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#retrieving_metadata).
                                /// </summary>
                                /// <param name="parent">
                                /// The name of the DICOM store that is being accessed. For example,
                                /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                                /// </param>
                                /// <param name="dicomWebPath">
                                /// The path of the RetrieveInstanceMetadata DICOMweb request. For example,
                                /// `studies/{study_uid}/series/{series_uid}/instances/{instance_uid}/metadata`.
                                /// </param>
                                public virtual RetrieveMetadataRequest RetrieveMetadata(string parent, string dicomWebPath)
                                {
                                    return new RetrieveMetadataRequest(service, parent, dicomWebPath);
                                }

                                /// <summary>
                                /// RetrieveInstanceMetadata returns instance associated with the given study, series,
                                /// and SOP Instance UID presented as metadata with the bulk data removed. See
                                /// [RetrieveTransaction]
                                /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.4). For
                                /// details on the implementation of RetrieveInstanceMetadata, see [Metadata
                                /// resources](https://cloud.google.com/healthcare/docs/dicom#metadata_resources) in the
                                /// Cloud Healthcare API conformance statement. For samples that show how to call
                                /// RetrieveInstanceMetadata, see [Retrieving
                                /// metadata](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#retrieving_metadata).
                                /// </summary>
                                public class RetrieveMetadataRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                                {
                                    /// <summary>Constructs a new RetrieveMetadata request.</summary>
                                    public RetrieveMetadataRequest(Google.Apis.Services.IClientService service, string parent, string dicomWebPath) : base(service)
                                    {
                                        Parent = parent;
                                        DicomWebPath = dicomWebPath;
                                        InitParameters();
                                    }

                                    /// <summary>
                                    /// The name of the DICOM store that is being accessed. For example,
                                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                                    /// </summary>
                                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                    public virtual string Parent { get; private set; }

                                    /// <summary>
                                    /// The path of the RetrieveInstanceMetadata DICOMweb request. For example,
                                    /// `studies/{study_uid}/series/{series_uid}/instances/{instance_uid}/metadata`.
                                    /// </summary>
                                    [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                                    public virtual string DicomWebPath { get; private set; }

                                    /// <summary>Gets the method name.</summary>
                                    public override string MethodName => "retrieveMetadata";

                                    /// <summary>Gets the HTTP method.</summary>
                                    public override string HttpMethod => "GET";

                                    /// <summary>Gets the REST path.</summary>
                                    public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                                    /// <summary>Initializes RetrieveMetadata parameter list.</summary>
                                    protected override void InitParameters()
                                    {
                                        base.InitParameters();
                                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "parent",
                                            IsRequired = true,
                                            ParameterType = "path",
                                            DefaultValue = null,
                                            Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                                        });
                                        RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "dicomWebPath",
                                            IsRequired = true,
                                            ParameterType = "path",
                                            DefaultValue = null,
                                            Pattern = @"^studies/[^/]+/series/[^/]+/instances/[^/]+/metadata$",
                                        });
                                    }
                                }

                                /// <summary>
                                /// RetrieveRenderedInstance returns instance associated with the given study, series,
                                /// and SOP Instance UID in an acceptable Rendered Media Type. See [RetrieveTransaction]
                                /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.4). For
                                /// details on the implementation of RetrieveRenderedInstance, see [Rendered
                                /// resources](https://cloud.google.com/healthcare/docs/dicom#rendered_resources) in the
                                /// Cloud Healthcare API conformance statement. For samples that show how to call
                                /// RetrieveRenderedInstance, see [Retrieving consumer image
                                /// formats](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#retrieving_consumer_image_formats).
                                /// </summary>
                                /// <param name="parent">
                                /// The name of the DICOM store that is being accessed. For example,
                                /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                                /// </param>
                                /// <param name="dicomWebPath">
                                /// The path of the RetrieveRenderedInstance DICOMweb request. For example,
                                /// `studies/{study_uid}/series/{series_uid}/instances/{instance_uid}/rendered`.
                                /// </param>
                                public virtual RetrieveRenderedRequest RetrieveRendered(string parent, string dicomWebPath)
                                {
                                    return new RetrieveRenderedRequest(service, parent, dicomWebPath);
                                }

                                /// <summary>
                                /// RetrieveRenderedInstance returns instance associated with the given study, series,
                                /// and SOP Instance UID in an acceptable Rendered Media Type. See [RetrieveTransaction]
                                /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.4). For
                                /// details on the implementation of RetrieveRenderedInstance, see [Rendered
                                /// resources](https://cloud.google.com/healthcare/docs/dicom#rendered_resources) in the
                                /// Cloud Healthcare API conformance statement. For samples that show how to call
                                /// RetrieveRenderedInstance, see [Retrieving consumer image
                                /// formats](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#retrieving_consumer_image_formats).
                                /// </summary>
                                public class RetrieveRenderedRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                                {
                                    /// <summary>Constructs a new RetrieveRendered request.</summary>
                                    public RetrieveRenderedRequest(Google.Apis.Services.IClientService service, string parent, string dicomWebPath) : base(service)
                                    {
                                        Parent = parent;
                                        DicomWebPath = dicomWebPath;
                                        InitParameters();
                                    }

                                    /// <summary>
                                    /// The name of the DICOM store that is being accessed. For example,
                                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                                    /// </summary>
                                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                    public virtual string Parent { get; private set; }

                                    /// <summary>
                                    /// The path of the RetrieveRenderedInstance DICOMweb request. For example,
                                    /// `studies/{study_uid}/series/{series_uid}/instances/{instance_uid}/rendered`.
                                    /// </summary>
                                    [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                                    public virtual string DicomWebPath { get; private set; }

                                    /// <summary>Gets the method name.</summary>
                                    public override string MethodName => "retrieveRendered";

                                    /// <summary>Gets the HTTP method.</summary>
                                    public override string HttpMethod => "GET";

                                    /// <summary>Gets the REST path.</summary>
                                    public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                                    /// <summary>Initializes RetrieveRendered parameter list.</summary>
                                    protected override void InitParameters()
                                    {
                                        base.InitParameters();
                                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "parent",
                                            IsRequired = true,
                                            ParameterType = "path",
                                            DefaultValue = null,
                                            Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                                        });
                                        RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                                        {
                                            Name = "dicomWebPath",
                                            IsRequired = true,
                                            ParameterType = "path",
                                            DefaultValue = null,
                                            Pattern = @"^studies/[^/]+/series/[^/]+/instances/[^/]+/rendered$",
                                        });
                                    }
                                }
                            }

                            /// <summary>
                            /// DeleteSeries deletes all instances within the given study and series. Delete requests
                            /// are equivalent to the GET requests specified in the Retrieve transaction. The method
                            /// returns an Operation which will be marked successful when the deletion is complete.
                            /// Warning: Instances cannot be inserted into a series that is being deleted by an
                            /// operation until the operation completes. For samples that show how to call DeleteSeries,
                            /// see [Deleting a study, series, or
                            /// instance](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#deleting_a_study_series_or_instance).
                            /// </summary>
                            /// <param name="parent">
                            /// The name of the DICOM store that is being accessed. For example,
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                            /// </param>
                            /// <param name="dicomWebPath">
                            /// The path of the DeleteSeries request. For example,
                            /// `studies/{study_uid}/series/{series_uid}`.
                            /// </param>
                            public virtual DeleteRequest Delete(string parent, string dicomWebPath)
                            {
                                return new DeleteRequest(service, parent, dicomWebPath);
                            }

                            /// <summary>
                            /// DeleteSeries deletes all instances within the given study and series. Delete requests
                            /// are equivalent to the GET requests specified in the Retrieve transaction. The method
                            /// returns an Operation which will be marked successful when the deletion is complete.
                            /// Warning: Instances cannot be inserted into a series that is being deleted by an
                            /// operation until the operation completes. For samples that show how to call DeleteSeries,
                            /// see [Deleting a study, series, or
                            /// instance](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#deleting_a_study_series_or_instance).
                            /// </summary>
                            public class DeleteRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Operation>
                            {
                                /// <summary>Constructs a new Delete request.</summary>
                                public DeleteRequest(Google.Apis.Services.IClientService service, string parent, string dicomWebPath) : base(service)
                                {
                                    Parent = parent;
                                    DicomWebPath = dicomWebPath;
                                    InitParameters();
                                }

                                /// <summary>
                                /// The name of the DICOM store that is being accessed. For example,
                                /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Parent { get; private set; }

                                /// <summary>
                                /// The path of the DeleteSeries request. For example,
                                /// `studies/{study_uid}/series/{series_uid}`.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string DicomWebPath { get; private set; }

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "delete";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "DELETE";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                                /// <summary>Initializes Delete parameter list.</summary>
                                protected override void InitParameters()
                                {
                                    base.InitParameters();
                                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "parent",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                                    });
                                    RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "dicomWebPath",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = @"^studies/[^/]+/series/[^/]+$",
                                    });
                                }
                            }

                            /// <summary>
                            /// RetrieveSeriesMetadata returns instance associated with the given study and series,
                            /// presented as metadata with the bulk data removed. See [RetrieveTransaction]
                            /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.4). For
                            /// details on the implementation of RetrieveSeriesMetadata, see [Metadata
                            /// resources](https://cloud.google.com/healthcare/docs/dicom#metadata_resources) in the
                            /// Cloud Healthcare API conformance statement. For samples that show how to call
                            /// RetrieveSeriesMetadata, see [Retrieving
                            /// metadata](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#retrieving_metadata).
                            /// </summary>
                            /// <param name="parent">
                            /// The name of the DICOM store that is being accessed. For example,
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                            /// </param>
                            /// <param name="dicomWebPath">
                            /// The path of the RetrieveSeriesMetadata DICOMweb request. For example,
                            /// `studies/{study_uid}/series/{series_uid}/metadata`.
                            /// </param>
                            public virtual RetrieveMetadataRequest RetrieveMetadata(string parent, string dicomWebPath)
                            {
                                return new RetrieveMetadataRequest(service, parent, dicomWebPath);
                            }

                            /// <summary>
                            /// RetrieveSeriesMetadata returns instance associated with the given study and series,
                            /// presented as metadata with the bulk data removed. See [RetrieveTransaction]
                            /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.4). For
                            /// details on the implementation of RetrieveSeriesMetadata, see [Metadata
                            /// resources](https://cloud.google.com/healthcare/docs/dicom#metadata_resources) in the
                            /// Cloud Healthcare API conformance statement. For samples that show how to call
                            /// RetrieveSeriesMetadata, see [Retrieving
                            /// metadata](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#retrieving_metadata).
                            /// </summary>
                            public class RetrieveMetadataRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                            {
                                /// <summary>Constructs a new RetrieveMetadata request.</summary>
                                public RetrieveMetadataRequest(Google.Apis.Services.IClientService service, string parent, string dicomWebPath) : base(service)
                                {
                                    Parent = parent;
                                    DicomWebPath = dicomWebPath;
                                    InitParameters();
                                }

                                /// <summary>
                                /// The name of the DICOM store that is being accessed. For example,
                                /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Parent { get; private set; }

                                /// <summary>
                                /// The path of the RetrieveSeriesMetadata DICOMweb request. For example,
                                /// `studies/{study_uid}/series/{series_uid}/metadata`.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string DicomWebPath { get; private set; }

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "retrieveMetadata";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "GET";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                                /// <summary>Initializes RetrieveMetadata parameter list.</summary>
                                protected override void InitParameters()
                                {
                                    base.InitParameters();
                                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "parent",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                                    });
                                    RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "dicomWebPath",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = @"^studies/[^/]+/series/[^/]+/metadata$",
                                    });
                                }
                            }

                            /// <summary>
                            /// RetrieveSeries returns all instances within the given study and series. See
                            /// [RetrieveTransaction]
                            /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.4). For
                            /// details on the implementation of RetrieveSeries, see [DICOM
                            /// study/series/instances](https://cloud.google.com/healthcare/docs/dicom#dicom_studyseriesinstances)
                            /// in the Cloud Healthcare API conformance statement. For samples that show how to call
                            /// RetrieveSeries, see [Retrieving DICOM
                            /// data](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#retrieving_dicom_data).
                            /// </summary>
                            /// <param name="parent">
                            /// The name of the DICOM store that is being accessed. For example,
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                            /// </param>
                            /// <param name="dicomWebPath">
                            /// The path of the RetrieveSeries DICOMweb request. For example,
                            /// `studies/{study_uid}/series/{series_uid}`.
                            /// </param>
                            public virtual RetrieveSeriesRequest RetrieveSeries(string parent, string dicomWebPath)
                            {
                                return new RetrieveSeriesRequest(service, parent, dicomWebPath);
                            }

                            /// <summary>
                            /// RetrieveSeries returns all instances within the given study and series. See
                            /// [RetrieveTransaction]
                            /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.4). For
                            /// details on the implementation of RetrieveSeries, see [DICOM
                            /// study/series/instances](https://cloud.google.com/healthcare/docs/dicom#dicom_studyseriesinstances)
                            /// in the Cloud Healthcare API conformance statement. For samples that show how to call
                            /// RetrieveSeries, see [Retrieving DICOM
                            /// data](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#retrieving_dicom_data).
                            /// </summary>
                            public class RetrieveSeriesRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                            {
                                /// <summary>Constructs a new RetrieveSeries request.</summary>
                                public RetrieveSeriesRequest(Google.Apis.Services.IClientService service, string parent, string dicomWebPath) : base(service)
                                {
                                    Parent = parent;
                                    DicomWebPath = dicomWebPath;
                                    InitParameters();
                                }

                                /// <summary>
                                /// The name of the DICOM store that is being accessed. For example,
                                /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Parent { get; private set; }

                                /// <summary>
                                /// The path of the RetrieveSeries DICOMweb request. For example,
                                /// `studies/{study_uid}/series/{series_uid}`.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string DicomWebPath { get; private set; }

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "retrieveSeries";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "GET";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                                /// <summary>Initializes RetrieveSeries parameter list.</summary>
                                protected override void InitParameters()
                                {
                                    base.InitParameters();
                                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "parent",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                                    });
                                    RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "dicomWebPath",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = @"^studies/[^/]+/series/[^/]+$",
                                    });
                                }
                            }

                            /// <summary>
                            /// SearchForInstances returns a list of matching instances. See [Search Transaction]
                            /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.6). For
                            /// details on the implementation of SearchForInstances, see [Search
                            /// transaction](https://cloud.google.com/healthcare/docs/dicom#search_transaction) in the
                            /// Cloud Healthcare API conformance statement. For samples that show how to call
                            /// SearchForInstances, see [Searching for studies, series, instances, and
                            /// frames](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#searching_for_studies_series_instances_and_frames).
                            /// </summary>
                            /// <param name="parent">
                            /// The name of the DICOM store that is being accessed. For example,
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                            /// </param>
                            /// <param name="dicomWebPath">
                            /// The path of the SearchForInstancesRequest DICOMweb request. For example, `instances`,
                            /// `series/{series_uid}/instances`, or `studies/{study_uid}/instances`.
                            /// </param>
                            public virtual SearchForInstancesRequest SearchForInstances(string parent, string dicomWebPath)
                            {
                                return new SearchForInstancesRequest(service, parent, dicomWebPath);
                            }

                            /// <summary>
                            /// SearchForInstances returns a list of matching instances. See [Search Transaction]
                            /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.6). For
                            /// details on the implementation of SearchForInstances, see [Search
                            /// transaction](https://cloud.google.com/healthcare/docs/dicom#search_transaction) in the
                            /// Cloud Healthcare API conformance statement. For samples that show how to call
                            /// SearchForInstances, see [Searching for studies, series, instances, and
                            /// frames](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#searching_for_studies_series_instances_and_frames).
                            /// </summary>
                            public class SearchForInstancesRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                            {
                                /// <summary>Constructs a new SearchForInstances request.</summary>
                                public SearchForInstancesRequest(Google.Apis.Services.IClientService service, string parent, string dicomWebPath) : base(service)
                                {
                                    Parent = parent;
                                    DicomWebPath = dicomWebPath;
                                    InitParameters();
                                }

                                /// <summary>
                                /// The name of the DICOM store that is being accessed. For example,
                                /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Parent { get; private set; }

                                /// <summary>
                                /// The path of the SearchForInstancesRequest DICOMweb request. For example,
                                /// `instances`, `series/{series_uid}/instances`, or `studies/{study_uid}/instances`.
                                /// </summary>
                                [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string DicomWebPath { get; private set; }

                                /// <summary>Gets the method name.</summary>
                                public override string MethodName => "searchForInstances";

                                /// <summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "GET";

                                /// <summary>Gets the REST path.</summary>
                                public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                                /// <summary>Initializes SearchForInstances parameter list.</summary>
                                protected override void InitParameters()
                                {
                                    base.InitParameters();
                                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "parent",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                                    });
                                    RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "dicomWebPath",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = @"^studies/[^/]+/series/[^/]+/instances$",
                                    });
                                }
                            }
                        }

                        /// <summary>
                        /// DeleteStudy deletes all instances within the given study. Delete requests are equivalent to
                        /// the GET requests specified in the Retrieve transaction. The method returns an Operation
                        /// which will be marked successful when the deletion is complete. Warning: Instances cannot be
                        /// inserted into a study that is being deleted by an operation until the operation completes.
                        /// For samples that show how to call DeleteStudy, see [Deleting a study, series, or
                        /// instance](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#deleting_a_study_series_or_instance).
                        /// </summary>
                        /// <param name="parent"><c>null</c></param>
                        /// <param name="dicomWebPath">
                        /// The path of the DeleteStudy request. For example, `studies/{study_uid}`.
                        /// </param>
                        public virtual DeleteRequest Delete(string parent, string dicomWebPath)
                        {
                            return new DeleteRequest(service, parent, dicomWebPath);
                        }

                        /// <summary>
                        /// DeleteStudy deletes all instances within the given study. Delete requests are equivalent to
                        /// the GET requests specified in the Retrieve transaction. The method returns an Operation
                        /// which will be marked successful when the deletion is complete. Warning: Instances cannot be
                        /// inserted into a study that is being deleted by an operation until the operation completes.
                        /// For samples that show how to call DeleteStudy, see [Deleting a study, series, or
                        /// instance](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#deleting_a_study_series_or_instance).
                        /// </summary>
                        public class DeleteRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Operation>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string parent, string dicomWebPath) : base(service)
                            {
                                Parent = parent;
                                DicomWebPath = dicomWebPath;
                                InitParameters();
                            }

                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// The path of the DeleteStudy request. For example, `studies/{study_uid}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string DicomWebPath { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                            /// <summary>Initializes Delete parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                                });
                                RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "dicomWebPath",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^studies/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// RetrieveStudyMetadata returns instance associated with the given study presented as metadata
                        /// with the bulk data removed. See [RetrieveTransaction]
                        /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.4). For details
                        /// on the implementation of RetrieveStudyMetadata, see [Metadata
                        /// resources](https://cloud.google.com/healthcare/docs/dicom#metadata_resources) in the Cloud
                        /// Healthcare API conformance statement. For samples that show how to call
                        /// RetrieveStudyMetadata, see [Retrieving
                        /// metadata](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#retrieving_metadata).
                        /// </summary>
                        /// <param name="parent">
                        /// The name of the DICOM store that is being accessed. For example,
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                        /// </param>
                        /// <param name="dicomWebPath">
                        /// The path of the RetrieveStudyMetadata DICOMweb request. For example,
                        /// `studies/{study_uid}/metadata`.
                        /// </param>
                        public virtual RetrieveMetadataRequest RetrieveMetadata(string parent, string dicomWebPath)
                        {
                            return new RetrieveMetadataRequest(service, parent, dicomWebPath);
                        }

                        /// <summary>
                        /// RetrieveStudyMetadata returns instance associated with the given study presented as metadata
                        /// with the bulk data removed. See [RetrieveTransaction]
                        /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.4). For details
                        /// on the implementation of RetrieveStudyMetadata, see [Metadata
                        /// resources](https://cloud.google.com/healthcare/docs/dicom#metadata_resources) in the Cloud
                        /// Healthcare API conformance statement. For samples that show how to call
                        /// RetrieveStudyMetadata, see [Retrieving
                        /// metadata](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#retrieving_metadata).
                        /// </summary>
                        public class RetrieveMetadataRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new RetrieveMetadata request.</summary>
                            public RetrieveMetadataRequest(Google.Apis.Services.IClientService service, string parent, string dicomWebPath) : base(service)
                            {
                                Parent = parent;
                                DicomWebPath = dicomWebPath;
                                InitParameters();
                            }

                            /// <summary>
                            /// The name of the DICOM store that is being accessed. For example,
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// The path of the RetrieveStudyMetadata DICOMweb request. For example,
                            /// `studies/{study_uid}/metadata`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string DicomWebPath { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "retrieveMetadata";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                            /// <summary>Initializes RetrieveMetadata parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                                });
                                RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "dicomWebPath",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^studies/[^/]+/metadata$",
                                });
                            }
                        }

                        /// <summary>
                        /// RetrieveStudy returns all instances within the given study. See [RetrieveTransaction]
                        /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.4). For details
                        /// on the implementation of RetrieveStudy, see [DICOM
                        /// study/series/instances](https://cloud.google.com/healthcare/docs/dicom#dicom_studyseriesinstances)
                        /// in the Cloud Healthcare API conformance statement. For samples that show how to call
                        /// RetrieveStudy, see [Retrieving DICOM
                        /// data](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#retrieving_dicom_data).
                        /// </summary>
                        /// <param name="parent">
                        /// The name of the DICOM store that is being accessed. For example,
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                        /// </param>
                        /// <param name="dicomWebPath">
                        /// The path of the RetrieveStudy DICOMweb request. For example, `studies/{study_uid}`.
                        /// </param>
                        public virtual RetrieveStudyRequest RetrieveStudy(string parent, string dicomWebPath)
                        {
                            return new RetrieveStudyRequest(service, parent, dicomWebPath);
                        }

                        /// <summary>
                        /// RetrieveStudy returns all instances within the given study. See [RetrieveTransaction]
                        /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.4). For details
                        /// on the implementation of RetrieveStudy, see [DICOM
                        /// study/series/instances](https://cloud.google.com/healthcare/docs/dicom#dicom_studyseriesinstances)
                        /// in the Cloud Healthcare API conformance statement. For samples that show how to call
                        /// RetrieveStudy, see [Retrieving DICOM
                        /// data](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#retrieving_dicom_data).
                        /// </summary>
                        public class RetrieveStudyRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new RetrieveStudy request.</summary>
                            public RetrieveStudyRequest(Google.Apis.Services.IClientService service, string parent, string dicomWebPath) : base(service)
                            {
                                Parent = parent;
                                DicomWebPath = dicomWebPath;
                                InitParameters();
                            }

                            /// <summary>
                            /// The name of the DICOM store that is being accessed. For example,
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// The path of the RetrieveStudy DICOMweb request. For example, `studies/{study_uid}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string DicomWebPath { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "retrieveStudy";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                            /// <summary>Initializes RetrieveStudy parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                                });
                                RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "dicomWebPath",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^studies/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// SearchForInstances returns a list of matching instances. See [Search Transaction]
                        /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.6). For details
                        /// on the implementation of SearchForInstances, see [Search
                        /// transaction](https://cloud.google.com/healthcare/docs/dicom#search_transaction) in the Cloud
                        /// Healthcare API conformance statement. For samples that show how to call SearchForInstances,
                        /// see [Searching for studies, series, instances, and
                        /// frames](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#searching_for_studies_series_instances_and_frames).
                        /// </summary>
                        /// <param name="parent">
                        /// The name of the DICOM store that is being accessed. For example,
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                        /// </param>
                        /// <param name="dicomWebPath">
                        /// The path of the SearchForInstancesRequest DICOMweb request. For example, `instances`,
                        /// `series/{series_uid}/instances`, or `studies/{study_uid}/instances`.
                        /// </param>
                        public virtual SearchForInstancesRequest SearchForInstances(string parent, string dicomWebPath)
                        {
                            return new SearchForInstancesRequest(service, parent, dicomWebPath);
                        }

                        /// <summary>
                        /// SearchForInstances returns a list of matching instances. See [Search Transaction]
                        /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.6). For details
                        /// on the implementation of SearchForInstances, see [Search
                        /// transaction](https://cloud.google.com/healthcare/docs/dicom#search_transaction) in the Cloud
                        /// Healthcare API conformance statement. For samples that show how to call SearchForInstances,
                        /// see [Searching for studies, series, instances, and
                        /// frames](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#searching_for_studies_series_instances_and_frames).
                        /// </summary>
                        public class SearchForInstancesRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new SearchForInstances request.</summary>
                            public SearchForInstancesRequest(Google.Apis.Services.IClientService service, string parent, string dicomWebPath) : base(service)
                            {
                                Parent = parent;
                                DicomWebPath = dicomWebPath;
                                InitParameters();
                            }

                            /// <summary>
                            /// The name of the DICOM store that is being accessed. For example,
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// The path of the SearchForInstancesRequest DICOMweb request. For example, `instances`,
                            /// `series/{series_uid}/instances`, or `studies/{study_uid}/instances`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string DicomWebPath { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "searchForInstances";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                            /// <summary>Initializes SearchForInstances parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                                });
                                RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "dicomWebPath",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^studies/[^/]+/instances$",
                                });
                            }
                        }

                        /// <summary>
                        /// SearchForSeries returns a list of matching series. See [Search Transaction]
                        /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.6). For details
                        /// on the implementation of SearchForSeries, see [Search
                        /// transaction](https://cloud.google.com/healthcare/docs/dicom#search_transaction) in the Cloud
                        /// Healthcare API conformance statement. For samples that show how to call SearchForSeries, see
                        /// [Searching for studies, series, instances, and
                        /// frames](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#searching_for_studies_series_instances_and_frames).
                        /// </summary>
                        /// <param name="parent">
                        /// The name of the DICOM store that is being accessed. For example,
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                        /// </param>
                        /// <param name="dicomWebPath">
                        /// The path of the SearchForSeries DICOMweb request. For example, `series` or
                        /// `studies/{study_uid}/series`.
                        /// </param>
                        public virtual SearchForSeriesRequest SearchForSeries(string parent, string dicomWebPath)
                        {
                            return new SearchForSeriesRequest(service, parent, dicomWebPath);
                        }

                        /// <summary>
                        /// SearchForSeries returns a list of matching series. See [Search Transaction]
                        /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.6). For details
                        /// on the implementation of SearchForSeries, see [Search
                        /// transaction](https://cloud.google.com/healthcare/docs/dicom#search_transaction) in the Cloud
                        /// Healthcare API conformance statement. For samples that show how to call SearchForSeries, see
                        /// [Searching for studies, series, instances, and
                        /// frames](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#searching_for_studies_series_instances_and_frames).
                        /// </summary>
                        public class SearchForSeriesRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new SearchForSeries request.</summary>
                            public SearchForSeriesRequest(Google.Apis.Services.IClientService service, string parent, string dicomWebPath) : base(service)
                            {
                                Parent = parent;
                                DicomWebPath = dicomWebPath;
                                InitParameters();
                            }

                            /// <summary>
                            /// The name of the DICOM store that is being accessed. For example,
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// The path of the SearchForSeries DICOMweb request. For example, `series` or
                            /// `studies/{study_uid}/series`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string DicomWebPath { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "searchForSeries";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                            /// <summary>Initializes SearchForSeries parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                                });
                                RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "dicomWebPath",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^studies/[^/]+/series$",
                                });
                            }
                        }

                        /// <summary>
                        /// StoreInstances stores DICOM instances associated with study instance unique identifiers
                        /// (SUID). See [Store Transaction]
                        /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.5). For details
                        /// on the implementation of StoreInstances, see [Store
                        /// transaction](https://cloud.google.com/healthcare/docs/dicom#store_transaction) in the Cloud
                        /// Healthcare API conformance statement. For samples that show how to call StoreInstances, see
                        /// [Storing DICOM
                        /// data](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#storing_dicom_data).
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">
                        /// The name of the DICOM store that is being accessed. For example,
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                        /// </param>
                        /// <param name="dicomWebPath">
                        /// The path of the StoreInstances DICOMweb request. For example, `studies/[{study_uid}]`. Note
                        /// that the `study_uid` is optional.
                        /// </param>
                        public virtual StoreInstancesRequest StoreInstances(Google.Apis.CloudHealthcare.v1.Data.HttpBody body, string parent, string dicomWebPath)
                        {
                            return new StoreInstancesRequest(service, body, parent, dicomWebPath);
                        }

                        /// <summary>
                        /// StoreInstances stores DICOM instances associated with study instance unique identifiers
                        /// (SUID). See [Store Transaction]
                        /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.5). For details
                        /// on the implementation of StoreInstances, see [Store
                        /// transaction](https://cloud.google.com/healthcare/docs/dicom#store_transaction) in the Cloud
                        /// Healthcare API conformance statement. For samples that show how to call StoreInstances, see
                        /// [Storing DICOM
                        /// data](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#storing_dicom_data).
                        /// </summary>
                        public class StoreInstancesRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new StoreInstances request.</summary>
                            public StoreInstancesRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.HttpBody body, string parent, string dicomWebPath) : base(service)
                            {
                                Parent = parent;
                                DicomWebPath = dicomWebPath;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// The name of the DICOM store that is being accessed. For example,
                            /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// The path of the StoreInstances DICOMweb request. For example, `studies/[{study_uid}]`.
                            /// Note that the `study_uid` is optional.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string DicomWebPath { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.HttpBody Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "storeInstances";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                            /// <summary>Initializes StoreInstances parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                                });
                                RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "dicomWebPath",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^studies/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Creates a new DICOM store within the parent dataset.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">The name of the dataset this DICOM store belongs to.</param>
                    public virtual CreateRequest Create(Google.Apis.CloudHealthcare.v1.Data.DicomStore body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a new DICOM store within the parent dataset.</summary>
                    public class CreateRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.DicomStore>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.DicomStore body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The name of the dataset this DICOM store belongs to.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The ID of the DICOM store that is being created. Any string value up to 256 characters in
                        /// length.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("dicomStoreId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string DicomStoreId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.DicomStore Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/dicomStores";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
                            });
                            RequestParameters.Add("dicomStoreId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "dicomStoreId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// De-identifies data from the source store and writes it to the destination store. The metadata
                    /// field type is OperationMetadata. If the request is successful, the response field type is
                    /// DeidentifyDicomStoreSummary. If errors occur, error is set. The LRO result may still be
                    /// successful if de-identification fails for some DICOM instances. The output DICOM store will not
                    /// contain these failed resources. Failed resource totals are tracked in Operation.metadata. Error
                    /// details are also logged to Cloud Logging (see [Viewing error logs in Cloud
                    /// Logging](/healthcare/docs/how-tos/logging)).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="sourceStore">
                    /// Source DICOM store resource name. For example,
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                    /// </param>
                    public virtual DeidentifyRequest Deidentify(Google.Apis.CloudHealthcare.v1.Data.DeidentifyDicomStoreRequest body, string sourceStore)
                    {
                        return new DeidentifyRequest(service, body, sourceStore);
                    }

                    /// <summary>
                    /// De-identifies data from the source store and writes it to the destination store. The metadata
                    /// field type is OperationMetadata. If the request is successful, the response field type is
                    /// DeidentifyDicomStoreSummary. If errors occur, error is set. The LRO result may still be
                    /// successful if de-identification fails for some DICOM instances. The output DICOM store will not
                    /// contain these failed resources. Failed resource totals are tracked in Operation.metadata. Error
                    /// details are also logged to Cloud Logging (see [Viewing error logs in Cloud
                    /// Logging](/healthcare/docs/how-tos/logging)).
                    /// </summary>
                    public class DeidentifyRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Deidentify request.</summary>
                        public DeidentifyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.DeidentifyDicomStoreRequest body, string sourceStore) : base(service)
                        {
                            SourceStore = sourceStore;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Source DICOM store resource name. For example,
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("sourceStore", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string SourceStore { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.DeidentifyDicomStoreRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "deidentify";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+sourceStore}:deidentify";

                        /// <summary>Initializes Deidentify parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("sourceStore", new Google.Apis.Discovery.Parameter
                            {
                                Name = "sourceStore",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Deletes the specified DICOM store and removes all images that are contained within it.
                    /// </summary>
                    /// <param name="name">The resource name of the DICOM store to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>
                    /// Deletes the specified DICOM store and removes all images that are contained within it.
                    /// </summary>
                    public class DeleteRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The resource name of the DICOM store to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Exports data to the specified destination by copying it from the DICOM store. Errors are also
                    /// logged to Cloud Logging. For more information, see [Viewing error logs in Cloud
                    /// Logging](https://cloud.google.com/healthcare/docs/how-tos/logging). The metadata field type is
                    /// OperationMetadata.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The DICOM store resource name from which to export the data. For example,
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                    /// </param>
                    public virtual ExportRequest Export(Google.Apis.CloudHealthcare.v1.Data.ExportDicomDataRequest body, string name)
                    {
                        return new ExportRequest(service, body, name);
                    }

                    /// <summary>
                    /// Exports data to the specified destination by copying it from the DICOM store. Errors are also
                    /// logged to Cloud Logging. For more information, see [Viewing error logs in Cloud
                    /// Logging](https://cloud.google.com/healthcare/docs/how-tos/logging). The metadata field type is
                    /// OperationMetadata.
                    /// </summary>
                    public class ExportRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Export request.</summary>
                        public ExportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.ExportDicomDataRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The DICOM store resource name from which to export the data. For example,
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.ExportDicomDataRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "export";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:export";

                        /// <summary>Initializes Export parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets the specified DICOM store.</summary>
                    /// <param name="name">The resource name of the DICOM store to get.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets the specified DICOM store.</summary>
                    public class GetRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.DicomStore>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The resource name of the DICOM store to get.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(service, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                        /// specifying an invalid value will be rejected. Requests for policies with any conditional
                        /// bindings must specify version 3. Policies without any conditional bindings may specify any
                        /// valid value or leave the field unset. To learn which resources support conditions in their
                        /// IAM policies, see the [IAM
                        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:getIamPolicy";

                        /// <summary>Initializes GetIamPolicy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                            });
                            RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                            {
                                Name = "options.requestedPolicyVersion",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Imports data into the DICOM store by copying it from the specified source. Errors are logged to
                    /// Cloud Logging. For more information, see [Viewing error logs in Cloud
                    /// Logging](https://cloud.google.com/healthcare/docs/how-tos/logging). The metadata field type is
                    /// OperationMetadata.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The name of the DICOM store resource into which the data is imported. For example,
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                    /// </param>
                    public virtual ImportRequest Import(Google.Apis.CloudHealthcare.v1.Data.ImportDicomDataRequest body, string name)
                    {
                        return new ImportRequest(service, body, name);
                    }

                    /// <summary>
                    /// Imports data into the DICOM store by copying it from the specified source. Errors are logged to
                    /// Cloud Logging. For more information, see [Viewing error logs in Cloud
                    /// Logging](https://cloud.google.com/healthcare/docs/how-tos/logging). The metadata field type is
                    /// OperationMetadata.
                    /// </summary>
                    public class ImportRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Import request.</summary>
                        public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.ImportDicomDataRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name of the DICOM store resource into which the data is imported. For example,
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.ImportDicomDataRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "import";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:import";

                        /// <summary>Initializes Import parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists the DICOM stores in the given dataset.</summary>
                    /// <param name="parent">Name of the dataset.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists the DICOM stores in the given dataset.</summary>
                    public class ListRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ListDicomStoresResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Name of the dataset.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Restricts stores returned to those matching a filter. The following syntax is available: * A
                        /// string field value can be written as text inside quotation marks, for example `"query
                        /// text"`. The only valid relational operation for text fields is equality (`=`), where text is
                        /// searched within the field, rather than having the field be equal to the text. For example,
                        /// `"Comment = great"` returns messages with `great` in the comment field. * A number field
                        /// value can be written as an integer, a decimal, or an exponential. The valid relational
                        /// operators for number fields are the equality operator (`=`), along with the less
                        /// than/greater than operators (`&amp;lt;`, `&amp;lt;=`, `&amp;gt;`, `&amp;gt;=`). Note that
                        /// there is no inequality (`!=`) operator. You can prepend the `NOT` operator to an expression
                        /// to negate it. * A date field value must be written in `yyyy-mm-dd` form. Fields with date
                        /// and time use the RFC3339 time format. Leading zeros are required for one-digit months and
                        /// days. The valid relational operators for date fields are the equality operator (`=`) , along
                        /// with the less than/greater than operators (`&amp;lt;`, `&amp;lt;=`, `&amp;gt;`,
                        /// `&amp;gt;=`). Note that there is no inequality (`!=`) operator. You can prepend the `NOT`
                        /// operator to an expression to negate it. * Multiple field query expressions can be combined
                        /// in one query by adding `AND` or `OR` operators between the expressions. If a boolean
                        /// operator appears within a quoted string, it is not treated as special, it's just another
                        /// part of the character string to be matched. You can prepend the `NOT` operator to an
                        /// expression to negate it. Only filtering on labels is supported. For example,
                        /// `labels.key=value`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Limit on the number of DICOM stores to return in a single response. If not specified, 100 is
                        /// used. May not be larger than 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// The next_page_token value returned from the previous List request, if any.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/dicomStores";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
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

                    /// <summary>Updates the specified DICOM store.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Resource name of the DICOM store, of the form
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CloudHealthcare.v1.Data.DicomStore body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates the specified DICOM store.</summary>
                    public class PatchRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.DicomStore>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.DicomStore body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Resource name of the DICOM store, of the form
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// The update mask applies to the resource. For the `FieldMask` definition, see
                        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.DicomStore Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
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

                    /// <summary>
                    /// SearchForInstances returns a list of matching instances. See [Search Transaction]
                    /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.6). For details on
                    /// the implementation of SearchForInstances, see [Search
                    /// transaction](https://cloud.google.com/healthcare/docs/dicom#search_transaction) in the Cloud
                    /// Healthcare API conformance statement. For samples that show how to call SearchForInstances, see
                    /// [Searching for studies, series, instances, and
                    /// frames](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#searching_for_studies_series_instances_and_frames).
                    /// </summary>
                    /// <param name="parent">
                    /// The name of the DICOM store that is being accessed. For example,
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                    /// </param>
                    /// <param name="dicomWebPath">
                    /// The path of the SearchForInstancesRequest DICOMweb request. For example, `instances`,
                    /// `series/{series_uid}/instances`, or `studies/{study_uid}/instances`.
                    /// </param>
                    public virtual SearchForInstancesRequest SearchForInstances(string parent, string dicomWebPath)
                    {
                        return new SearchForInstancesRequest(service, parent, dicomWebPath);
                    }

                    /// <summary>
                    /// SearchForInstances returns a list of matching instances. See [Search Transaction]
                    /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.6). For details on
                    /// the implementation of SearchForInstances, see [Search
                    /// transaction](https://cloud.google.com/healthcare/docs/dicom#search_transaction) in the Cloud
                    /// Healthcare API conformance statement. For samples that show how to call SearchForInstances, see
                    /// [Searching for studies, series, instances, and
                    /// frames](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#searching_for_studies_series_instances_and_frames).
                    /// </summary>
                    public class SearchForInstancesRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                    {
                        /// <summary>Constructs a new SearchForInstances request.</summary>
                        public SearchForInstancesRequest(Google.Apis.Services.IClientService service, string parent, string dicomWebPath) : base(service)
                        {
                            Parent = parent;
                            DicomWebPath = dicomWebPath;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name of the DICOM store that is being accessed. For example,
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The path of the SearchForInstancesRequest DICOMweb request. For example, `instances`,
                        /// `series/{series_uid}/instances`, or `studies/{study_uid}/instances`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string DicomWebPath { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "searchForInstances";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                        /// <summary>Initializes SearchForInstances parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                            });
                            RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                            {
                                Name = "dicomWebPath",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^instances$",
                            });
                        }
                    }

                    /// <summary>
                    /// SearchForSeries returns a list of matching series. See [Search Transaction]
                    /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.6). For details on
                    /// the implementation of SearchForSeries, see [Search
                    /// transaction](https://cloud.google.com/healthcare/docs/dicom#search_transaction) in the Cloud
                    /// Healthcare API conformance statement. For samples that show how to call SearchForSeries, see
                    /// [Searching for studies, series, instances, and
                    /// frames](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#searching_for_studies_series_instances_and_frames).
                    /// </summary>
                    /// <param name="parent">
                    /// The name of the DICOM store that is being accessed. For example,
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                    /// </param>
                    /// <param name="dicomWebPath">
                    /// The path of the SearchForSeries DICOMweb request. For example, `series` or
                    /// `studies/{study_uid}/series`.
                    /// </param>
                    public virtual SearchForSeriesRequest SearchForSeries(string parent, string dicomWebPath)
                    {
                        return new SearchForSeriesRequest(service, parent, dicomWebPath);
                    }

                    /// <summary>
                    /// SearchForSeries returns a list of matching series. See [Search Transaction]
                    /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.6). For details on
                    /// the implementation of SearchForSeries, see [Search
                    /// transaction](https://cloud.google.com/healthcare/docs/dicom#search_transaction) in the Cloud
                    /// Healthcare API conformance statement. For samples that show how to call SearchForSeries, see
                    /// [Searching for studies, series, instances, and
                    /// frames](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#searching_for_studies_series_instances_and_frames).
                    /// </summary>
                    public class SearchForSeriesRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                    {
                        /// <summary>Constructs a new SearchForSeries request.</summary>
                        public SearchForSeriesRequest(Google.Apis.Services.IClientService service, string parent, string dicomWebPath) : base(service)
                        {
                            Parent = parent;
                            DicomWebPath = dicomWebPath;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name of the DICOM store that is being accessed. For example,
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The path of the SearchForSeries DICOMweb request. For example, `series` or
                        /// `studies/{study_uid}/series`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string DicomWebPath { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "searchForSeries";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                        /// <summary>Initializes SearchForSeries parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                            });
                            RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                            {
                                Name = "dicomWebPath",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^series$",
                            });
                        }
                    }

                    /// <summary>
                    /// SearchForStudies returns a list of matching studies. See [Search Transaction]
                    /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.6). For details on
                    /// the implementation of SearchForStudies, see [Search
                    /// transaction](https://cloud.google.com/healthcare/docs/dicom#search_transaction) in the Cloud
                    /// Healthcare API conformance statement. For samples that show how to call SearchForStudies, see
                    /// [Searching for studies, series, instances, and
                    /// frames](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#searching_for_studies_series_instances_and_frames).
                    /// </summary>
                    /// <param name="parent">
                    /// The name of the DICOM store that is being accessed. For example,
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                    /// </param>
                    /// <param name="dicomWebPath">
                    /// The path of the SearchForStudies DICOMweb request. For example, `studies`.
                    /// </param>
                    public virtual SearchForStudiesRequest SearchForStudies(string parent, string dicomWebPath)
                    {
                        return new SearchForStudiesRequest(service, parent, dicomWebPath);
                    }

                    /// <summary>
                    /// SearchForStudies returns a list of matching studies. See [Search Transaction]
                    /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.6). For details on
                    /// the implementation of SearchForStudies, see [Search
                    /// transaction](https://cloud.google.com/healthcare/docs/dicom#search_transaction) in the Cloud
                    /// Healthcare API conformance statement. For samples that show how to call SearchForStudies, see
                    /// [Searching for studies, series, instances, and
                    /// frames](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#searching_for_studies_series_instances_and_frames).
                    /// </summary>
                    public class SearchForStudiesRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                    {
                        /// <summary>Constructs a new SearchForStudies request.</summary>
                        public SearchForStudiesRequest(Google.Apis.Services.IClientService service, string parent, string dicomWebPath) : base(service)
                        {
                            Parent = parent;
                            DicomWebPath = dicomWebPath;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name of the DICOM store that is being accessed. For example,
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The path of the SearchForStudies DICOMweb request. For example, `studies`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string DicomWebPath { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "searchForStudies";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                        /// <summary>Initializes SearchForStudies parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                            });
                            RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                            {
                                Name = "dicomWebPath",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^studies$",
                            });
                        }
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudHealthcare.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:setIamPolicy";

                        /// <summary>Initializes SetIamPolicy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// StoreInstances stores DICOM instances associated with study instance unique identifiers (SUID).
                    /// See [Store Transaction]
                    /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.5). For details on
                    /// the implementation of StoreInstances, see [Store
                    /// transaction](https://cloud.google.com/healthcare/docs/dicom#store_transaction) in the Cloud
                    /// Healthcare API conformance statement. For samples that show how to call StoreInstances, see
                    /// [Storing DICOM
                    /// data](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#storing_dicom_data).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// The name of the DICOM store that is being accessed. For example,
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                    /// </param>
                    /// <param name="dicomWebPath">
                    /// The path of the StoreInstances DICOMweb request. For example, `studies/[{study_uid}]`. Note that
                    /// the `study_uid` is optional.
                    /// </param>
                    public virtual StoreInstancesRequest StoreInstances(Google.Apis.CloudHealthcare.v1.Data.HttpBody body, string parent, string dicomWebPath)
                    {
                        return new StoreInstancesRequest(service, body, parent, dicomWebPath);
                    }

                    /// <summary>
                    /// StoreInstances stores DICOM instances associated with study instance unique identifiers (SUID).
                    /// See [Store Transaction]
                    /// (http://dicom.nema.org/medical/dicom/current/output/html/part18.html#sect_10.5). For details on
                    /// the implementation of StoreInstances, see [Store
                    /// transaction](https://cloud.google.com/healthcare/docs/dicom#store_transaction) in the Cloud
                    /// Healthcare API conformance statement. For samples that show how to call StoreInstances, see
                    /// [Storing DICOM
                    /// data](https://cloud.google.com/healthcare/docs/how-tos/dicomweb#storing_dicom_data).
                    /// </summary>
                    public class StoreInstancesRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                    {
                        /// <summary>Constructs a new StoreInstances request.</summary>
                        public StoreInstancesRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.HttpBody body, string parent, string dicomWebPath) : base(service)
                        {
                            Parent = parent;
                            DicomWebPath = dicomWebPath;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name of the DICOM store that is being accessed. For example,
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The path of the StoreInstances DICOMweb request. For example, `studies/[{study_uid}]`. Note
                        /// that the `study_uid` is optional.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("dicomWebPath", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string DicomWebPath { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.HttpBody Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "storeInstances";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/dicomWeb/{+dicomWebPath}";

                        /// <summary>Initializes StoreInstances parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                            });
                            RequestParameters.Add("dicomWebPath", new Google.Apis.Discovery.Parameter
                            {
                                Name = "dicomWebPath",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^studies$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:testIamPermissions";

                        /// <summary>Initializes TestIamPermissions parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/dicomStores/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the FhirStores resource.</summary>
                public virtual FhirStoresResource FhirStores { get; }

                /// <summary>The "fhirStores" collection of methods.</summary>
                public class FhirStoresResource
                {
                    private const string Resource = "fhirStores";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public FhirStoresResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Fhir = new FhirResource(service);
                    }

                    /// <summary>Gets the Fhir resource.</summary>
                    public virtual FhirResource Fhir { get; }

                    /// <summary>The "fhir" collection of methods.</summary>
                    public class FhirResource
                    {
                        private const string Resource = "fhir";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public FhirResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Retrieves a Patient resource and resources related to that patient. Implements the FHIR
                        /// extended operation Patient-everything
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/patient-operations.html#everything),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/patient-operations.html#everything),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/patient-operations.html#everything)). On
                        /// success, the response body contains a JSON-encoded representation of a `Bundle` resource of
                        /// type `searchset`, containing the results of the operation. Errors generated by the FHIR
                        /// store contain a JSON-encoded `OperationOutcome` resource describing the reason for the
                        /// error. If the request cannot be mapped to a valid API method on a FHIR store, a generic GCP
                        /// error might be returned instead. The resources in scope for the response are: * The patient
                        /// resource itself. * All the resources directly referenced by the patient resource. *
                        /// Resources directly referencing the patient resource that meet the inclusion criteria. The
                        /// inclusion criteria are based on the membership rules in the patient compartment definition
                        /// ([DSTU2](http://hl7.org/fhir/DSTU2/compartment-patient.html),
                        /// [STU3](http://www.hl7.org/fhir/stu3/compartmentdefinition-patient.html),
                        /// [R4](http://hl7.org/fhir/R4/compartmentdefinition-patient.html)), which details the eligible
                        /// resource types and referencing search parameters. For samples that show how to call
                        /// `Patient-everything`, see [Getting all patient compartment
                        /// resources](/healthcare/docs/how-tos/fhir-resources#getting_all_patient_compartment_resources).
                        /// </summary>
                        /// <param name="name">
                        /// Name of the `Patient` resource for which the information is required.
                        /// </param>
                        public virtual PatientEverythingRequest PatientEverything(string name)
                        {
                            return new PatientEverythingRequest(service, name);
                        }

                        /// <summary>
                        /// Retrieves a Patient resource and resources related to that patient. Implements the FHIR
                        /// extended operation Patient-everything
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/patient-operations.html#everything),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/patient-operations.html#everything),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/patient-operations.html#everything)). On
                        /// success, the response body contains a JSON-encoded representation of a `Bundle` resource of
                        /// type `searchset`, containing the results of the operation. Errors generated by the FHIR
                        /// store contain a JSON-encoded `OperationOutcome` resource describing the reason for the
                        /// error. If the request cannot be mapped to a valid API method on a FHIR store, a generic GCP
                        /// error might be returned instead. The resources in scope for the response are: * The patient
                        /// resource itself. * All the resources directly referenced by the patient resource. *
                        /// Resources directly referencing the patient resource that meet the inclusion criteria. The
                        /// inclusion criteria are based on the membership rules in the patient compartment definition
                        /// ([DSTU2](http://hl7.org/fhir/DSTU2/compartment-patient.html),
                        /// [STU3](http://www.hl7.org/fhir/stu3/compartmentdefinition-patient.html),
                        /// [R4](http://hl7.org/fhir/R4/compartmentdefinition-patient.html)), which details the eligible
                        /// resource types and referencing search parameters. For samples that show how to call
                        /// `Patient-everything`, see [Getting all patient compartment
                        /// resources](/healthcare/docs/how-tos/fhir-resources#getting_all_patient_compartment_resources).
                        /// </summary>
                        public class PatientEverythingRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new PatientEverything request.</summary>
                            public PatientEverythingRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Name of the `Patient` resource for which the information is required.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Maximum number of resources in a page. If not specified, 100 is used. May not be larger
                            /// than 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("_count", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> Count { get; set; }

                            /// <summary>
                            /// Used to retrieve the next or previous page of results when using pagination. Set
                            /// `_page_token` to the value of _page_token set in next or previous page links' url. Next
                            /// and previous page are returned in the response bundle's links field, where
                            /// `link.relation` is "previous" or "next". Omit `_page_token` if no previous request has
                            /// been made.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("_page_token", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>
                            /// If provided, only resources updated after this time are returned. The time uses the
                            /// format YYYY-MM-DDThh:mm:ss.sss+zz:zz. For example, `2015-02-07T13:28:17.239+02:00` or
                            /// `2017-01-01T00:00:00Z`. The time must be specified to the second and include a time
                            /// zone.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("_since", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Since { get; set; }

                            /// <summary>
                            /// String of comma-delimited FHIR resource types. If provided, only resources of the
                            /// specified resource type(s) are returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("_type", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Type { get; set; }

                            /// <summary>
                            /// The response includes records prior to the end date. If no end date is provided, all
                            /// records subsequent to the start date are in scope.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("end", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string End { get; set; }

                            /// <summary>
                            /// The response includes records subsequent to the start date. If no start date is
                            /// provided, all records prior to the end date are in scope.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("start", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Start { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "Patient-everything";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}/$everything";

                            /// <summary>Initializes PatientEverything parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+/fhir/Patient/[^/]+$",
                                });
                                RequestParameters.Add("_count", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "_count",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("_page_token", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "_page_token",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("_since", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "_since",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("_type", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "_type",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("end", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "end",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("start", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "start",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>
                        /// Deletes all the historical versions of a resource (excluding the current version) from the
                        /// FHIR store. To remove all versions of a resource, first delete the current version and then
                        /// call this method. This is not a FHIR standard operation. For samples that show how to call
                        /// `Resource-purge`, see [Deleting historical versions of a FHIR
                        /// resource](/healthcare/docs/how-tos/fhir-resources#deleting_historical_versions_of_a_fhir_resource).
                        /// </summary>
                        /// <param name="name">The name of the resource to purge.</param>
                        public virtual ResourcePurgeRequest ResourcePurge(string name)
                        {
                            return new ResourcePurgeRequest(service, name);
                        }

                        /// <summary>
                        /// Deletes all the historical versions of a resource (excluding the current version) from the
                        /// FHIR store. To remove all versions of a resource, first delete the current version and then
                        /// call this method. This is not a FHIR standard operation. For samples that show how to call
                        /// `Resource-purge`, see [Deleting historical versions of a FHIR
                        /// resource](/healthcare/docs/how-tos/fhir-resources#deleting_historical_versions_of_a_fhir_resource).
                        /// </summary>
                        public class ResourcePurgeRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Empty>
                        {
                            /// <summary>Constructs a new ResourcePurge request.</summary>
                            public ResourcePurgeRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>The name of the resource to purge.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "Resource-purge";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}/$purge";

                            /// <summary>Initializes ResourcePurge parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+/fhir/[^/]+/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Gets the FHIR capability statement
                        /// ([STU3](http://hl7.org/implement/standards/fhir/STU3/capabilitystatement.html),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/capabilitystatement.html)), or the
                        /// [conformance statement](http://hl7.org/implement/standards/fhir/DSTU2/conformance.html) in
                        /// the DSTU2 case for the store, which contains a description of functionality supported by the
                        /// server. Implements the FHIR standard capabilities interaction
                        /// ([STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#capabilities),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#capabilities)), or the
                        /// [conformance
                        /// interaction](http://hl7.org/implement/standards/fhir/DSTU2/http.html#conformance) in the
                        /// DSTU2 case. On success, the response body contains a JSON-encoded representation of a
                        /// `CapabilityStatement` resource.
                        /// </summary>
                        /// <param name="name">Name of the FHIR store to retrieve the capabilities for.</param>
                        public virtual CapabilitiesRequest Capabilities(string name)
                        {
                            return new CapabilitiesRequest(service, name);
                        }

                        /// <summary>
                        /// Gets the FHIR capability statement
                        /// ([STU3](http://hl7.org/implement/standards/fhir/STU3/capabilitystatement.html),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/capabilitystatement.html)), or the
                        /// [conformance statement](http://hl7.org/implement/standards/fhir/DSTU2/conformance.html) in
                        /// the DSTU2 case for the store, which contains a description of functionality supported by the
                        /// server. Implements the FHIR standard capabilities interaction
                        /// ([STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#capabilities),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#capabilities)), or the
                        /// [conformance
                        /// interaction](http://hl7.org/implement/standards/fhir/DSTU2/http.html#conformance) in the
                        /// DSTU2 case. On success, the response body contains a JSON-encoded representation of a
                        /// `CapabilityStatement` resource.
                        /// </summary>
                        public class CapabilitiesRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new Capabilities request.</summary>
                            public CapabilitiesRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>Name of the FHIR store to retrieve the capabilities for.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "capabilities";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}/fhir/metadata";

                            /// <summary>Initializes Capabilities parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Creates a FHIR resource. Implements the FHIR standard create interaction
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#create),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#create),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#create)), which creates a new
                        /// resource with a server-assigned resource ID. The request body must contain a JSON-encoded
                        /// FHIR resource, and the request headers must contain `Content-Type: application/fhir+json`.
                        /// On success, the response body contains a JSON-encoded representation of the resource as it
                        /// was created on the server, including the server-assigned resource ID and version ID. Errors
                        /// generated by the FHIR store contain a JSON-encoded `OperationOutcome` resource describing
                        /// the reason for the error. If the request cannot be mapped to a valid API method on a FHIR
                        /// store, a generic GCP error might be returned instead. For samples that show how to call
                        /// `create`, see [Creating a FHIR
                        /// resource](/healthcare/docs/how-tos/fhir-resources#creating_a_fhir_resource).
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">The name of the FHIR store this resource belongs to.</param>
                        /// <param name="type">
                        /// The FHIR resource type to create, such as Patient or Observation. For a complete list, see
                        /// the FHIR Resource Index
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/resourcelist.html),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/resourcelist.html),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/resourcelist.html)). Must match the resource
                        /// type in the provided content.
                        /// </param>
                        public virtual CreateRequest Create(Google.Apis.CloudHealthcare.v1.Data.HttpBody body, string parent, string type)
                        {
                            return new CreateRequest(service, body, parent, type);
                        }

                        /// <summary>
                        /// Creates a FHIR resource. Implements the FHIR standard create interaction
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#create),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#create),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#create)), which creates a new
                        /// resource with a server-assigned resource ID. The request body must contain a JSON-encoded
                        /// FHIR resource, and the request headers must contain `Content-Type: application/fhir+json`.
                        /// On success, the response body contains a JSON-encoded representation of the resource as it
                        /// was created on the server, including the server-assigned resource ID and version ID. Errors
                        /// generated by the FHIR store contain a JSON-encoded `OperationOutcome` resource describing
                        /// the reason for the error. If the request cannot be mapped to a valid API method on a FHIR
                        /// store, a generic GCP error might be returned instead. For samples that show how to call
                        /// `create`, see [Creating a FHIR
                        /// resource](/healthcare/docs/how-tos/fhir-resources#creating_a_fhir_resource).
                        /// </summary>
                        public class CreateRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.HttpBody body, string parent, string type) : base(service)
                            {
                                Parent = parent;
                                Type = type;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>The name of the FHIR store this resource belongs to.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// The FHIR resource type to create, such as Patient or Observation. For a complete list,
                            /// see the FHIR Resource Index
                            /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/resourcelist.html),
                            /// [STU3](http://hl7.org/implement/standards/fhir/STU3/resourcelist.html),
                            /// [R4](http://hl7.org/implement/standards/fhir/R4/resourcelist.html)). Must match the
                            /// resource type in the provided content.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Type { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.HttpBody Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/fhir/{+type}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+$",
                                });
                                RequestParameters.Add("type", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "type",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Deletes a FHIR resource. Implements the FHIR standard delete interaction
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#delete),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#delete),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#delete)). Note: Unless resource
                        /// versioning is disabled by setting the disable_resource_versioning flag on the FHIR store,
                        /// the deleted resources will be moved to a history repository that can still be retrieved
                        /// through vread and related methods, unless they are removed by the purge method. For samples
                        /// that show how to call `delete`, see [Deleting a FHIR
                        /// resource](/healthcare/docs/how-tos/fhir-resources#deleting_a_fhir_resource).
                        /// </summary>
                        /// <param name="name">The name of the resource to delete.</param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>
                        /// Deletes a FHIR resource. Implements the FHIR standard delete interaction
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#delete),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#delete),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#delete)). Note: Unless resource
                        /// versioning is disabled by setting the disable_resource_versioning flag on the FHIR store,
                        /// the deleted resources will be moved to a history repository that can still be retrieved
                        /// through vread and related methods, unless they are removed by the purge method. For samples
                        /// that show how to call `delete`, see [Deleting a FHIR
                        /// resource](/healthcare/docs/how-tos/fhir-resources#deleting_a_fhir_resource).
                        /// </summary>
                        public class DeleteRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>The name of the resource to delete.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+/fhir/[^/]+/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Executes all the requests in the given Bundle. Implements the FHIR standard
                        /// batch/transaction interaction
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#transaction),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#transaction),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#transaction)). Supports all
                        /// interactions within a bundle, except search. This method accepts Bundles of type `batch` and
                        /// `transaction`, processing them according to the batch processing rules
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#2.1.0.16.1),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#2.21.0.17.1),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#brules)) and transaction
                        /// processing rules
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#2.1.0.16.2),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#2.21.0.17.2),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#trules)). The request body must
                        /// contain a JSON-encoded FHIR `Bundle` resource, and the request headers must contain
                        /// `Content-Type: application/fhir+json`. For a batch bundle or a successful transaction the
                        /// response body will contain a JSON-encoded representation of a `Bundle` resource of type
                        /// `batch-response` or `transaction-response` containing one entry for each entry in the
                        /// request, with the outcome of processing the entry. In the case of an error for a transaction
                        /// bundle, the response body will contain a JSON-encoded `OperationOutcome` resource describing
                        /// the reason for the error. If the request cannot be mapped to a valid API method on a FHIR
                        /// store, a generic GCP error might be returned instead. For samples that show how to call
                        /// `executeBundle`, see [Managing FHIR resources using FHIR
                        /// bundles](/healthcare/docs/how-tos/fhir-bundles).
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">Name of the FHIR store in which this bundle will be executed.</param>
                        public virtual ExecuteBundleRequest ExecuteBundle(Google.Apis.CloudHealthcare.v1.Data.HttpBody body, string parent)
                        {
                            return new ExecuteBundleRequest(service, body, parent);
                        }

                        /// <summary>
                        /// Executes all the requests in the given Bundle. Implements the FHIR standard
                        /// batch/transaction interaction
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#transaction),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#transaction),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#transaction)). Supports all
                        /// interactions within a bundle, except search. This method accepts Bundles of type `batch` and
                        /// `transaction`, processing them according to the batch processing rules
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#2.1.0.16.1),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#2.21.0.17.1),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#brules)) and transaction
                        /// processing rules
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#2.1.0.16.2),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#2.21.0.17.2),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#trules)). The request body must
                        /// contain a JSON-encoded FHIR `Bundle` resource, and the request headers must contain
                        /// `Content-Type: application/fhir+json`. For a batch bundle or a successful transaction the
                        /// response body will contain a JSON-encoded representation of a `Bundle` resource of type
                        /// `batch-response` or `transaction-response` containing one entry for each entry in the
                        /// request, with the outcome of processing the entry. In the case of an error for a transaction
                        /// bundle, the response body will contain a JSON-encoded `OperationOutcome` resource describing
                        /// the reason for the error. If the request cannot be mapped to a valid API method on a FHIR
                        /// store, a generic GCP error might be returned instead. For samples that show how to call
                        /// `executeBundle`, see [Managing FHIR resources using FHIR
                        /// bundles](/healthcare/docs/how-tos/fhir-bundles).
                        /// </summary>
                        public class ExecuteBundleRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new ExecuteBundle request.</summary>
                            public ExecuteBundleRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.HttpBody body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Name of the FHIR store in which this bundle will be executed.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.HttpBody Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "executeBundle";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/fhir";

                            /// <summary>Initializes ExecuteBundle parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists all the versions of a resource (including the current version and deleted versions)
                        /// from the FHIR store. Implements the per-resource form of the FHIR standard history
                        /// interaction ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#history),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#history),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#history)). On success, the
                        /// response body contains a JSON-encoded representation of a `Bundle` resource of type
                        /// `history`, containing the version history sorted from most recent to oldest versions. Errors
                        /// generated by the FHIR store contain a JSON-encoded `OperationOutcome` resource describing
                        /// the reason for the error. If the request cannot be mapped to a valid API method on a FHIR
                        /// store, a generic GCP error might be returned instead. For samples that show how to call
                        /// `history`, see [Listing FHIR resource
                        /// versions](/healthcare/docs/how-tos/fhir-resources#listing_fhir_resource_versions).
                        /// </summary>
                        /// <param name="name">The name of the resource to retrieve.</param>
                        public virtual HistoryRequest History(string name)
                        {
                            return new HistoryRequest(service, name);
                        }

                        /// <summary>
                        /// Lists all the versions of a resource (including the current version and deleted versions)
                        /// from the FHIR store. Implements the per-resource form of the FHIR standard history
                        /// interaction ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#history),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#history),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#history)). On success, the
                        /// response body contains a JSON-encoded representation of a `Bundle` resource of type
                        /// `history`, containing the version history sorted from most recent to oldest versions. Errors
                        /// generated by the FHIR store contain a JSON-encoded `OperationOutcome` resource describing
                        /// the reason for the error. If the request cannot be mapped to a valid API method on a FHIR
                        /// store, a generic GCP error might be returned instead. For samples that show how to call
                        /// `history`, see [Listing FHIR resource
                        /// versions](/healthcare/docs/how-tos/fhir-resources#listing_fhir_resource_versions).
                        /// </summary>
                        public class HistoryRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new History request.</summary>
                            public HistoryRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>The name of the resource to retrieve.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Only include resource versions that were current at some point during the time period
                            /// specified in the date time value. The date parameter format is
                            /// yyyy-mm-ddThh:mm:ss[Z|(+|-)hh:mm] Clients may specify any of the following: * An entire
                            /// year: `_at=2019` * An entire month: `_at=2019-01` * A specific day: `_at=2019-01-20` * A
                            /// specific second: `_at=2018-12-31T23:59:58Z`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("_at", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string At { get; set; }

                            /// <summary>
                            /// The maximum number of search results on a page. If not specified, 100 is used. May not
                            /// be larger than 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("_count", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> Count { get; set; }

                            /// <summary>
                            /// Used to retrieve the first, previous, next, or last page of resource versions when using
                            /// pagination. Value should be set to the value of `_page_token` set in next or previous
                            /// page links' URLs. Next and previous page are returned in the response bundle's links
                            /// field, where `link.relation` is "previous" or "next". Omit `_page_token` if no previous
                            /// request has been made.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("_page_token", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>
                            /// Only include resource versions that were created at or after the given instant in time.
                            /// The instant in time uses the format YYYY-MM-DDThh:mm:ss.sss+zz:zz (for example
                            /// 2015-02-07T13:28:17.239+02:00 or 2017-01-01T00:00:00Z). The time must be specified to
                            /// the second and include a time zone.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("_since", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Since { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "history";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}/_history";

                            /// <summary>Initializes History parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+/fhir/[^/]+/[^/]+$",
                                });
                                RequestParameters.Add("_at", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "_at",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("_count", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "_count",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("_page_token", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "_page_token",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("_since", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "_since",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>
                        /// Updates part of an existing resource by applying the operations specified in a [JSON
                        /// Patch](http://jsonpatch.com/) document. Implements the FHIR standard patch interaction
                        /// ([STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#patch),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#patch)). DSTU2 doesn't define a
                        /// patch method, but the server supports it in the same way it supports STU3. The request body
                        /// must contain a JSON Patch document, and the request headers must contain `Content-Type:
                        /// application/json-patch+json`. On success, the response body contains a JSON-encoded
                        /// representation of the updated resource, including the server-assigned version ID. Errors
                        /// generated by the FHIR store contain a JSON-encoded `OperationOutcome` resource describing
                        /// the reason for the error. If the request cannot be mapped to a valid API method on a FHIR
                        /// store, a generic GCP error might be returned instead. For samples that show how to call
                        /// `patch`, see [Patching a FHIR
                        /// resource](/healthcare/docs/how-tos/fhir-resources#patching_a_fhir_resource).
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">The name of the resource to update.</param>
                        public virtual PatchRequest Patch(Google.Apis.CloudHealthcare.v1.Data.HttpBody body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>
                        /// Updates part of an existing resource by applying the operations specified in a [JSON
                        /// Patch](http://jsonpatch.com/) document. Implements the FHIR standard patch interaction
                        /// ([STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#patch),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#patch)). DSTU2 doesn't define a
                        /// patch method, but the server supports it in the same way it supports STU3. The request body
                        /// must contain a JSON Patch document, and the request headers must contain `Content-Type:
                        /// application/json-patch+json`. On success, the response body contains a JSON-encoded
                        /// representation of the updated resource, including the server-assigned version ID. Errors
                        /// generated by the FHIR store contain a JSON-encoded `OperationOutcome` resource describing
                        /// the reason for the error. If the request cannot be mapped to a valid API method on a FHIR
                        /// store, a generic GCP error might be returned instead. For samples that show how to call
                        /// `patch`, see [Patching a FHIR
                        /// resource](/healthcare/docs/how-tos/fhir-resources#patching_a_fhir_resource).
                        /// </summary>
                        public class PatchRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.HttpBody body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>The name of the resource to update.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.HttpBody Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+/fhir/[^/]+/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Gets the contents of a FHIR resource. Implements the FHIR standard read interaction
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#read),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#read),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#read)). Also supports the FHIR
                        /// standard conditional read interaction
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#cread),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#cread),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#cread)) specified by supplying an
                        /// `If-Modified-Since` header with a date/time value or an `If-None-Match` header with an ETag
                        /// value. On success, the response body contains a JSON-encoded representation of the resource.
                        /// Errors generated by the FHIR store contain a JSON-encoded `OperationOutcome` resource
                        /// describing the reason for the error. If the request cannot be mapped to a valid API method
                        /// on a FHIR store, a generic GCP error might be returned instead. For samples that show how to
                        /// call `read`, see [Getting a FHIR
                        /// resource](/healthcare/docs/how-tos/fhir-resources#getting_a_fhir_resource).
                        /// </summary>
                        /// <param name="name">The name of the resource to retrieve.</param>
                        public virtual ReadRequest Read(string name)
                        {
                            return new ReadRequest(service, name);
                        }

                        /// <summary>
                        /// Gets the contents of a FHIR resource. Implements the FHIR standard read interaction
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#read),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#read),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#read)). Also supports the FHIR
                        /// standard conditional read interaction
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#cread),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#cread),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#cread)) specified by supplying an
                        /// `If-Modified-Since` header with a date/time value or an `If-None-Match` header with an ETag
                        /// value. On success, the response body contains a JSON-encoded representation of the resource.
                        /// Errors generated by the FHIR store contain a JSON-encoded `OperationOutcome` resource
                        /// describing the reason for the error. If the request cannot be mapped to a valid API method
                        /// on a FHIR store, a generic GCP error might be returned instead. For samples that show how to
                        /// call `read`, see [Getting a FHIR
                        /// resource](/healthcare/docs/how-tos/fhir-resources#getting_a_fhir_resource).
                        /// </summary>
                        public class ReadRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new Read request.</summary>
                            public ReadRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>The name of the resource to retrieve.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "read";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

                            /// <summary>Initializes Read parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+/fhir/[^/]+/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Searches for resources in the given FHIR store according to criteria specified as query
                        /// parameters. Implements the FHIR standard search interaction
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#search),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#search),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#search)) using the search
                        /// semantics described in the FHIR Search specification
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/search.html),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/search.html),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/search.html)). Supports four methods of
                        /// search defined by the specification: * `GET [base]?[parameters]` to search across all
                        /// resources. * `GET [base]/[type]?[parameters]` to search resources of a specified type. *
                        /// `POST [base]/_search?[parameters]` as an alternate form having the same semantics as the
                        /// `GET` method across all resources. * `POST [base]/[type]/_search?[parameters]` as an
                        /// alternate form having the same semantics as the `GET` method for the specified type. The
                        /// `GET` and `POST` methods do not support compartment searches. The `POST` method does not
                        /// support `application/x-www-form-urlencoded` search parameters. On success, the response body
                        /// contains a JSON-encoded representation of a `Bundle` resource of type `searchset`,
                        /// containing the results of the search. Errors generated by the FHIR store contain a
                        /// JSON-encoded `OperationOutcome` resource describing the reason for the error. If the request
                        /// cannot be mapped to a valid API method on a FHIR store, a generic GCP error might be
                        /// returned instead. The server's capability statement, retrieved through capabilities,
                        /// indicates what search parameters are supported on each FHIR resource. A list of all search
                        /// parameters defined by the specification can be found in the FHIR Search Parameter Registry
                        /// ([STU3](http://hl7.org/implement/standards/fhir/STU3/searchparameter-registry.html),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/searchparameter-registry.html)). FHIR search
                        /// parameters for DSTU2 can be found on each resource's definition page. Supported search
                        /// modifiers: `:missing`, `:exact`, `:contains`, `:text`, `:in`, `:not-in`, `:above`, `:below`,
                        /// `:[type]`, `:not`, and `:recurse`. Supported search result parameters: `_sort`, `_count`,
                        /// `_include`, `_revinclude`, `_summary=text`, `_summary=data`, and `_elements`. The maximum
                        /// number of search results returned defaults to 100, which can be overridden by the `_count`
                        /// parameter up to a maximum limit of 1000. If there are additional results, the returned
                        /// `Bundle` will contain pagination links. Resources with a total size larger than 5MB or a
                        /// field count larger than 50,000 might not be fully searchable as the server might trim its
                        /// generated search index in those cases. Note: FHIR resources are indexed asynchronously, so
                        /// there might be a slight delay between the time a resource is created or changes and when the
                        /// change is reflected in search results. For samples and detailed information, see [Searching
                        /// for FHIR resources](/healthcare/docs/how-tos/fhir-search) and [Advanced FHIR search
                        /// features](/healthcare/docs/how-tos/fhir-advanced-search).
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">Name of the FHIR store to retrieve resources from.</param>
                        public virtual SearchRequest Search(Google.Apis.CloudHealthcare.v1.Data.SearchResourcesRequest body, string parent)
                        {
                            return new SearchRequest(service, body, parent);
                        }

                        /// <summary>
                        /// Searches for resources in the given FHIR store according to criteria specified as query
                        /// parameters. Implements the FHIR standard search interaction
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#search),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#search),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#search)) using the search
                        /// semantics described in the FHIR Search specification
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/search.html),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/search.html),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/search.html)). Supports four methods of
                        /// search defined by the specification: * `GET [base]?[parameters]` to search across all
                        /// resources. * `GET [base]/[type]?[parameters]` to search resources of a specified type. *
                        /// `POST [base]/_search?[parameters]` as an alternate form having the same semantics as the
                        /// `GET` method across all resources. * `POST [base]/[type]/_search?[parameters]` as an
                        /// alternate form having the same semantics as the `GET` method for the specified type. The
                        /// `GET` and `POST` methods do not support compartment searches. The `POST` method does not
                        /// support `application/x-www-form-urlencoded` search parameters. On success, the response body
                        /// contains a JSON-encoded representation of a `Bundle` resource of type `searchset`,
                        /// containing the results of the search. Errors generated by the FHIR store contain a
                        /// JSON-encoded `OperationOutcome` resource describing the reason for the error. If the request
                        /// cannot be mapped to a valid API method on a FHIR store, a generic GCP error might be
                        /// returned instead. The server's capability statement, retrieved through capabilities,
                        /// indicates what search parameters are supported on each FHIR resource. A list of all search
                        /// parameters defined by the specification can be found in the FHIR Search Parameter Registry
                        /// ([STU3](http://hl7.org/implement/standards/fhir/STU3/searchparameter-registry.html),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/searchparameter-registry.html)). FHIR search
                        /// parameters for DSTU2 can be found on each resource's definition page. Supported search
                        /// modifiers: `:missing`, `:exact`, `:contains`, `:text`, `:in`, `:not-in`, `:above`, `:below`,
                        /// `:[type]`, `:not`, and `:recurse`. Supported search result parameters: `_sort`, `_count`,
                        /// `_include`, `_revinclude`, `_summary=text`, `_summary=data`, and `_elements`. The maximum
                        /// number of search results returned defaults to 100, which can be overridden by the `_count`
                        /// parameter up to a maximum limit of 1000. If there are additional results, the returned
                        /// `Bundle` will contain pagination links. Resources with a total size larger than 5MB or a
                        /// field count larger than 50,000 might not be fully searchable as the server might trim its
                        /// generated search index in those cases. Note: FHIR resources are indexed asynchronously, so
                        /// there might be a slight delay between the time a resource is created or changes and when the
                        /// change is reflected in search results. For samples and detailed information, see [Searching
                        /// for FHIR resources](/healthcare/docs/how-tos/fhir-search) and [Advanced FHIR search
                        /// features](/healthcare/docs/how-tos/fhir-advanced-search).
                        /// </summary>
                        public class SearchRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new Search request.</summary>
                            public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.SearchResourcesRequest body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Name of the FHIR store to retrieve resources from.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.SearchResourcesRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "search";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/fhir/_search";

                            /// <summary>Initializes Search parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Searches for resources in the given FHIR store according to criteria specified as query
                        /// parameters. Implements the FHIR standard search interaction
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#search),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#search),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#search)) using the search
                        /// semantics described in the FHIR Search specification
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/search.html),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/search.html),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/search.html)). Supports four methods of
                        /// search defined by the specification: * `GET [base]?[parameters]` to search across all
                        /// resources. * `GET [base]/[type]?[parameters]` to search resources of a specified type. *
                        /// `POST [base]/_search?[parameters]` as an alternate form having the same semantics as the
                        /// `GET` method across all resources. * `POST [base]/[type]/_search?[parameters]` as an
                        /// alternate form having the same semantics as the `GET` method for the specified type. The
                        /// `GET` and `POST` methods do not support compartment searches. The `POST` method does not
                        /// support `application/x-www-form-urlencoded` search parameters. On success, the response body
                        /// contains a JSON-encoded representation of a `Bundle` resource of type `searchset`,
                        /// containing the results of the search. Errors generated by the FHIR store contain a
                        /// JSON-encoded `OperationOutcome` resource describing the reason for the error. If the request
                        /// cannot be mapped to a valid API method on a FHIR store, a generic GCP error might be
                        /// returned instead. The server's capability statement, retrieved through capabilities,
                        /// indicates what search parameters are supported on each FHIR resource. A list of all search
                        /// parameters defined by the specification can be found in the FHIR Search Parameter Registry
                        /// ([STU3](http://hl7.org/implement/standards/fhir/STU3/searchparameter-registry.html),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/searchparameter-registry.html)). FHIR search
                        /// parameters for DSTU2 can be found on each resource's definition page. Supported search
                        /// modifiers: `:missing`, `:exact`, `:contains`, `:text`, `:in`, `:not-in`, `:above`, `:below`,
                        /// `:[type]`, `:not`, and `:recurse`. Supported search result parameters: `_sort`, `_count`,
                        /// `_include`, `_revinclude`, `_summary=text`, `_summary=data`, and `_elements`. The maximum
                        /// number of search results returned defaults to 100, which can be overridden by the `_count`
                        /// parameter up to a maximum limit of 1000. If there are additional results, the returned
                        /// `Bundle` will contain pagination links. Resources with a total size larger than 5MB or a
                        /// field count larger than 50,000 might not be fully searchable as the server might trim its
                        /// generated search index in those cases. Note: FHIR resources are indexed asynchronously, so
                        /// there might be a slight delay between the time a resource is created or changes and when the
                        /// change is reflected in search results. For samples and detailed information, see [Searching
                        /// for FHIR resources](/healthcare/docs/how-tos/fhir-search) and [Advanced FHIR search
                        /// features](/healthcare/docs/how-tos/fhir-advanced-search).
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">Name of the FHIR store to retrieve resources from.</param>
                        /// <param name="resourceType">
                        /// The FHIR resource type to search, such as Patient or Observation. For a complete list, see
                        /// the FHIR Resource Index
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/resourcelist.html),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/resourcelist.html),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/resourcelist.html)).
                        /// </param>
                        public virtual SearchTypeRequest SearchType(Google.Apis.CloudHealthcare.v1.Data.SearchResourcesRequest body, string parent, string resourceType)
                        {
                            return new SearchTypeRequest(service, body, parent, resourceType);
                        }

                        /// <summary>
                        /// Searches for resources in the given FHIR store according to criteria specified as query
                        /// parameters. Implements the FHIR standard search interaction
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#search),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#search),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#search)) using the search
                        /// semantics described in the FHIR Search specification
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/search.html),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/search.html),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/search.html)). Supports four methods of
                        /// search defined by the specification: * `GET [base]?[parameters]` to search across all
                        /// resources. * `GET [base]/[type]?[parameters]` to search resources of a specified type. *
                        /// `POST [base]/_search?[parameters]` as an alternate form having the same semantics as the
                        /// `GET` method across all resources. * `POST [base]/[type]/_search?[parameters]` as an
                        /// alternate form having the same semantics as the `GET` method for the specified type. The
                        /// `GET` and `POST` methods do not support compartment searches. The `POST` method does not
                        /// support `application/x-www-form-urlencoded` search parameters. On success, the response body
                        /// contains a JSON-encoded representation of a `Bundle` resource of type `searchset`,
                        /// containing the results of the search. Errors generated by the FHIR store contain a
                        /// JSON-encoded `OperationOutcome` resource describing the reason for the error. If the request
                        /// cannot be mapped to a valid API method on a FHIR store, a generic GCP error might be
                        /// returned instead. The server's capability statement, retrieved through capabilities,
                        /// indicates what search parameters are supported on each FHIR resource. A list of all search
                        /// parameters defined by the specification can be found in the FHIR Search Parameter Registry
                        /// ([STU3](http://hl7.org/implement/standards/fhir/STU3/searchparameter-registry.html),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/searchparameter-registry.html)). FHIR search
                        /// parameters for DSTU2 can be found on each resource's definition page. Supported search
                        /// modifiers: `:missing`, `:exact`, `:contains`, `:text`, `:in`, `:not-in`, `:above`, `:below`,
                        /// `:[type]`, `:not`, and `:recurse`. Supported search result parameters: `_sort`, `_count`,
                        /// `_include`, `_revinclude`, `_summary=text`, `_summary=data`, and `_elements`. The maximum
                        /// number of search results returned defaults to 100, which can be overridden by the `_count`
                        /// parameter up to a maximum limit of 1000. If there are additional results, the returned
                        /// `Bundle` will contain pagination links. Resources with a total size larger than 5MB or a
                        /// field count larger than 50,000 might not be fully searchable as the server might trim its
                        /// generated search index in those cases. Note: FHIR resources are indexed asynchronously, so
                        /// there might be a slight delay between the time a resource is created or changes and when the
                        /// change is reflected in search results. For samples and detailed information, see [Searching
                        /// for FHIR resources](/healthcare/docs/how-tos/fhir-search) and [Advanced FHIR search
                        /// features](/healthcare/docs/how-tos/fhir-advanced-search).
                        /// </summary>
                        public class SearchTypeRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new SearchType request.</summary>
                            public SearchTypeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.SearchResourcesRequest body, string parent, string resourceType) : base(service)
                            {
                                Parent = parent;
                                ResourceType = resourceType;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>Name of the FHIR store to retrieve resources from.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// The FHIR resource type to search, such as Patient or Observation. For a complete list,
                            /// see the FHIR Resource Index
                            /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/resourcelist.html),
                            /// [STU3](http://hl7.org/implement/standards/fhir/STU3/resourcelist.html),
                            /// [R4](http://hl7.org/implement/standards/fhir/R4/resourcelist.html)).
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("resourceType", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string ResourceType { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.SearchResourcesRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "search-type";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/fhir/{resourceType}/_search";

                            /// <summary>Initializes SearchType parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+$",
                                });
                                RequestParameters.Add("resourceType", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "resourceType",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }

                        /// <summary>
                        /// Updates the entire contents of a resource. Implements the FHIR standard update interaction
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#update),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#update),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#update)). If the specified
                        /// resource does not exist and the FHIR store has enable_update_create set, creates the
                        /// resource with the client-specified ID. It is strongly advised not to include or encode any
                        /// sensitive data such as patient identifiers in client-specified resource IDs. Those IDs are
                        /// part of the FHIR resource path recorded in Cloud Audit Logs and Pub/Sub notifications. Those
                        /// IDs can also be contained in reference fields within other resources. The request body must
                        /// contain a JSON-encoded FHIR resource, and the request headers must contain `Content-Type:
                        /// application/fhir+json`. The resource must contain an `id` element having an identical value
                        /// to the ID in the REST path of the request. On success, the response body contains a
                        /// JSON-encoded representation of the updated resource, including the server-assigned version
                        /// ID. Errors generated by the FHIR store contain a JSON-encoded `OperationOutcome` resource
                        /// describing the reason for the error. If the request cannot be mapped to a valid API method
                        /// on a FHIR store, a generic GCP error might be returned instead. For samples that show how to
                        /// call `update`, see [Updating a FHIR
                        /// resource](/healthcare/docs/how-tos/fhir-resources#updating_a_fhir_resource).
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">The name of the resource to update.</param>
                        public virtual UpdateRequest Update(Google.Apis.CloudHealthcare.v1.Data.HttpBody body, string name)
                        {
                            return new UpdateRequest(service, body, name);
                        }

                        /// <summary>
                        /// Updates the entire contents of a resource. Implements the FHIR standard update interaction
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#update),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#update),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#update)). If the specified
                        /// resource does not exist and the FHIR store has enable_update_create set, creates the
                        /// resource with the client-specified ID. It is strongly advised not to include or encode any
                        /// sensitive data such as patient identifiers in client-specified resource IDs. Those IDs are
                        /// part of the FHIR resource path recorded in Cloud Audit Logs and Pub/Sub notifications. Those
                        /// IDs can also be contained in reference fields within other resources. The request body must
                        /// contain a JSON-encoded FHIR resource, and the request headers must contain `Content-Type:
                        /// application/fhir+json`. The resource must contain an `id` element having an identical value
                        /// to the ID in the REST path of the request. On success, the response body contains a
                        /// JSON-encoded representation of the updated resource, including the server-assigned version
                        /// ID. Errors generated by the FHIR store contain a JSON-encoded `OperationOutcome` resource
                        /// describing the reason for the error. If the request cannot be mapped to a valid API method
                        /// on a FHIR store, a generic GCP error might be returned instead. For samples that show how to
                        /// call `update`, see [Updating a FHIR
                        /// resource](/healthcare/docs/how-tos/fhir-resources#updating_a_fhir_resource).
                        /// </summary>
                        public class UpdateRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new Update request.</summary>
                            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.HttpBody body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>The name of the resource to update.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.HttpBody Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "update";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PUT";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

                            /// <summary>Initializes Update parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+/fhir/[^/]+/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Gets the contents of a version (current or historical) of a FHIR resource by version ID.
                        /// Implements the FHIR standard vread interaction
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#vread),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#vread),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#vread)). On success, the response
                        /// body contains a JSON-encoded representation of the resource. Errors generated by the FHIR
                        /// store contain a JSON-encoded `OperationOutcome` resource describing the reason for the
                        /// error. If the request cannot be mapped to a valid API method on a FHIR store, a generic GCP
                        /// error might be returned instead. For samples that show how to call `vread`, see [Retrieving
                        /// a FHIR resource
                        /// version](/healthcare/docs/how-tos/fhir-resources#retrieving_a_fhir_resource_version).
                        /// </summary>
                        /// <param name="name">The name of the resource version to retrieve.</param>
                        public virtual VreadRequest Vread(string name)
                        {
                            return new VreadRequest(service, name);
                        }

                        /// <summary>
                        /// Gets the contents of a version (current or historical) of a FHIR resource by version ID.
                        /// Implements the FHIR standard vread interaction
                        /// ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/http.html#vread),
                        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/http.html#vread),
                        /// [R4](http://hl7.org/implement/standards/fhir/R4/http.html#vread)). On success, the response
                        /// body contains a JSON-encoded representation of the resource. Errors generated by the FHIR
                        /// store contain a JSON-encoded `OperationOutcome` resource describing the reason for the
                        /// error. If the request cannot be mapped to a valid API method on a FHIR store, a generic GCP
                        /// error might be returned instead. For samples that show how to call `vread`, see [Retrieving
                        /// a FHIR resource
                        /// version](/healthcare/docs/how-tos/fhir-resources#retrieving_a_fhir_resource_version).
                        /// </summary>
                        public class VreadRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.HttpBody>
                        {
                            /// <summary>Constructs a new Vread request.</summary>
                            public VreadRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>The name of the resource version to retrieve.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "vread";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

                            /// <summary>Initializes Vread parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+/fhir/[^/]+/[^/]+/_history/[^/]+$",
                                });
                            }
                        }
                    }

                    /// <summary>Creates a new FHIR store within the parent dataset.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">The name of the dataset this FHIR store belongs to.</param>
                    public virtual CreateRequest Create(Google.Apis.CloudHealthcare.v1.Data.FhirStore body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a new FHIR store within the parent dataset.</summary>
                    public class CreateRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.FhirStore>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.FhirStore body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The name of the dataset this FHIR store belongs to.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The ID of the FHIR store that is being created. The string must match the following regex:
                        /// `[\p{L}\p{N}_\-\.]{1,256}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("fhirStoreId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string FhirStoreId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.FhirStore Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/fhirStores";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
                            });
                            RequestParameters.Add("fhirStoreId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "fhirStoreId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// De-identifies data from the source store and writes it to the destination store. The metadata
                    /// field type is OperationMetadata. If the request is successful, the response field type is
                    /// DeidentifyFhirStoreSummary. If errors occur, error is set. Error details are also logged to
                    /// Cloud Logging (see [Viewing error logs in Cloud
                    /// Logging](https://cloud.google.com/healthcare/docs/how-tos/logging)).
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="sourceStore">
                    /// Source FHIR store resource name. For example,
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/fhirStores/{fhir_store_id}`.
                    /// </param>
                    public virtual DeidentifyRequest Deidentify(Google.Apis.CloudHealthcare.v1.Data.DeidentifyFhirStoreRequest body, string sourceStore)
                    {
                        return new DeidentifyRequest(service, body, sourceStore);
                    }

                    /// <summary>
                    /// De-identifies data from the source store and writes it to the destination store. The metadata
                    /// field type is OperationMetadata. If the request is successful, the response field type is
                    /// DeidentifyFhirStoreSummary. If errors occur, error is set. Error details are also logged to
                    /// Cloud Logging (see [Viewing error logs in Cloud
                    /// Logging](https://cloud.google.com/healthcare/docs/how-tos/logging)).
                    /// </summary>
                    public class DeidentifyRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Deidentify request.</summary>
                        public DeidentifyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.DeidentifyFhirStoreRequest body, string sourceStore) : base(service)
                        {
                            SourceStore = sourceStore;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Source FHIR store resource name. For example,
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/fhirStores/{fhir_store_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("sourceStore", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string SourceStore { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.DeidentifyFhirStoreRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "deidentify";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+sourceStore}:deidentify";

                        /// <summary>Initializes Deidentify parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("sourceStore", new Google.Apis.Discovery.Parameter
                            {
                                Name = "sourceStore",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Deletes the specified FHIR store and removes all resources within it.</summary>
                    /// <param name="name">The resource name of the FHIR store to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes the specified FHIR store and removes all resources within it.</summary>
                    public class DeleteRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The resource name of the FHIR store to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Export resources from the FHIR store to the specified destination. This method returns an
                    /// Operation that can be used to track the status of the export by calling GetOperation. Immediate
                    /// fatal errors appear in the error field, errors are also logged to Cloud Logging (see [Viewing
                    /// error logs in Cloud Logging](https://cloud.google.com/healthcare/docs/how-tos/logging)).
                    /// Otherwise, when the operation finishes, a detailed response of type ExportResourcesResponse is
                    /// returned in the response field. The metadata field type for this operation is OperationMetadata.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The name of the FHIR store to export resource from, in the format of
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/fhirStores/{fhir_store_id}`.
                    /// </param>
                    public virtual ExportRequest Export(Google.Apis.CloudHealthcare.v1.Data.ExportResourcesRequest body, string name)
                    {
                        return new ExportRequest(service, body, name);
                    }

                    /// <summary>
                    /// Export resources from the FHIR store to the specified destination. This method returns an
                    /// Operation that can be used to track the status of the export by calling GetOperation. Immediate
                    /// fatal errors appear in the error field, errors are also logged to Cloud Logging (see [Viewing
                    /// error logs in Cloud Logging](https://cloud.google.com/healthcare/docs/how-tos/logging)).
                    /// Otherwise, when the operation finishes, a detailed response of type ExportResourcesResponse is
                    /// returned in the response field. The metadata field type for this operation is OperationMetadata.
                    /// </summary>
                    public class ExportRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Export request.</summary>
                        public ExportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.ExportResourcesRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name of the FHIR store to export resource from, in the format of
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/fhirStores/{fhir_store_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.ExportResourcesRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "export";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:export";

                        /// <summary>Initializes Export parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets the configuration of the specified FHIR store.</summary>
                    /// <param name="name">The resource name of the FHIR store to get.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets the configuration of the specified FHIR store.</summary>
                    public class GetRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.FhirStore>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The resource name of the FHIR store to get.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(service, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                        /// specifying an invalid value will be rejected. Requests for policies with any conditional
                        /// bindings must specify version 3. Policies without any conditional bindings may specify any
                        /// valid value or leave the field unset. To learn which resources support conditions in their
                        /// IAM policies, see the [IAM
                        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:getIamPolicy";

                        /// <summary>Initializes GetIamPolicy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+$",
                            });
                            RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                            {
                                Name = "options.requestedPolicyVersion",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Imports resources to the FHIR store by loading data from the specified sources. This method is
                    /// optimized to load large quantities of data using import semantics that ignore some FHIR store
                    /// configuration options and are not suitable for all use cases. It is primarily intended to load
                    /// data into an empty FHIR store that is not being used by other clients. In cases where this
                    /// method is not appropriate, consider using ExecuteBundle to load data. Every resource in the
                    /// input must contain a client-supplied ID. Each resource is stored using the supplied ID
                    /// regardless of the enable_update_create setting on the FHIR store. It is strongly advised not to
                    /// include or encode any sensitive data such as patient identifiers in client-specified resource
                    /// IDs. Those IDs are part of the FHIR resource path recorded in Cloud Audit Logs and Cloud Pub/Sub
                    /// notifications. Those IDs can also be contained in reference fields within other resources. The
                    /// import process does not enforce referential integrity, regardless of the
                    /// disable_referential_integrity setting on the FHIR store. This allows the import of resources
                    /// with arbitrary interdependencies without considering grouping or ordering, but if the input data
                    /// contains invalid references or if some resources fail to be imported, the FHIR store might be
                    /// left in a state that violates referential integrity. The import process does not trigger Pub/Sub
                    /// notification or BigQuery streaming update, regardless of how those are configured on the FHIR
                    /// store. If a resource with the specified ID already exists, the most recent version of the
                    /// resource is overwritten without creating a new historical version, regardless of the
                    /// disable_resource_versioning setting on the FHIR store. If transient failures occur during the
                    /// import, it's possible that successfully imported resources will be overwritten more than once.
                    /// The import operation is idempotent unless the input data contains multiple valid resources with
                    /// the same ID but different contents. In that case, after the import completes, the store contains
                    /// exactly one resource with that ID but there is no ordering guarantee on which version of the
                    /// contents it will have. The operation result counters do not count duplicate IDs as an error and
                    /// count one success for each resource in the input, which might result in a success count larger
                    /// than the number of resources in the FHIR store. This often occurs when importing data organized
                    /// in bundles produced by Patient-everything where each bundle contains its own copy of a resource
                    /// such as Practitioner that might be referred to by many patients. If some resources fail to
                    /// import, for example due to parsing errors, successfully imported resources are not rolled back.
                    /// The location and format of the input data is specified by the parameters in
                    /// ImportResourcesRequest. Note that if no format is specified, this method assumes the `BUNDLE`
                    /// format. When using the `BUNDLE` format this method ignores the `Bundle.type` field, except that
                    /// `history` bundles are rejected, and does not apply any of the bundle processing semantics for
                    /// batch or transaction bundles. Unlike in ExecuteBundle, transaction bundles are not executed as a
                    /// single transaction and bundle-internal references are not rewritten. The bundle is treated as a
                    /// collection of resources to be written as provided in `Bundle.entry.resource`, ignoring
                    /// `Bundle.entry.request`. As an example, this allows the import of `searchset` bundles produced by
                    /// a FHIR search or Patient-everything operation. This method returns an Operation that can be used
                    /// to track the status of the import by calling GetOperation. Immediate fatal errors appear in the
                    /// error field, errors are also logged to Cloud Logging (see [Viewing error logs in Cloud
                    /// Logging](https://cloud.google.com/healthcare/docs/how-tos/logging)). Otherwise, when the
                    /// operation finishes, a detailed response of type ImportResourcesResponse is returned in the
                    /// response field. The metadata field type for this operation is OperationMetadata.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The name of the FHIR store to import FHIR resources to, in the format of
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/fhirStores/{fhir_store_id}`.
                    /// </param>
                    public virtual ImportRequest Import(Google.Apis.CloudHealthcare.v1.Data.ImportResourcesRequest body, string name)
                    {
                        return new ImportRequest(service, body, name);
                    }

                    /// <summary>
                    /// Imports resources to the FHIR store by loading data from the specified sources. This method is
                    /// optimized to load large quantities of data using import semantics that ignore some FHIR store
                    /// configuration options and are not suitable for all use cases. It is primarily intended to load
                    /// data into an empty FHIR store that is not being used by other clients. In cases where this
                    /// method is not appropriate, consider using ExecuteBundle to load data. Every resource in the
                    /// input must contain a client-supplied ID. Each resource is stored using the supplied ID
                    /// regardless of the enable_update_create setting on the FHIR store. It is strongly advised not to
                    /// include or encode any sensitive data such as patient identifiers in client-specified resource
                    /// IDs. Those IDs are part of the FHIR resource path recorded in Cloud Audit Logs and Cloud Pub/Sub
                    /// notifications. Those IDs can also be contained in reference fields within other resources. The
                    /// import process does not enforce referential integrity, regardless of the
                    /// disable_referential_integrity setting on the FHIR store. This allows the import of resources
                    /// with arbitrary interdependencies without considering grouping or ordering, but if the input data
                    /// contains invalid references or if some resources fail to be imported, the FHIR store might be
                    /// left in a state that violates referential integrity. The import process does not trigger Pub/Sub
                    /// notification or BigQuery streaming update, regardless of how those are configured on the FHIR
                    /// store. If a resource with the specified ID already exists, the most recent version of the
                    /// resource is overwritten without creating a new historical version, regardless of the
                    /// disable_resource_versioning setting on the FHIR store. If transient failures occur during the
                    /// import, it's possible that successfully imported resources will be overwritten more than once.
                    /// The import operation is idempotent unless the input data contains multiple valid resources with
                    /// the same ID but different contents. In that case, after the import completes, the store contains
                    /// exactly one resource with that ID but there is no ordering guarantee on which version of the
                    /// contents it will have. The operation result counters do not count duplicate IDs as an error and
                    /// count one success for each resource in the input, which might result in a success count larger
                    /// than the number of resources in the FHIR store. This often occurs when importing data organized
                    /// in bundles produced by Patient-everything where each bundle contains its own copy of a resource
                    /// such as Practitioner that might be referred to by many patients. If some resources fail to
                    /// import, for example due to parsing errors, successfully imported resources are not rolled back.
                    /// The location and format of the input data is specified by the parameters in
                    /// ImportResourcesRequest. Note that if no format is specified, this method assumes the `BUNDLE`
                    /// format. When using the `BUNDLE` format this method ignores the `Bundle.type` field, except that
                    /// `history` bundles are rejected, and does not apply any of the bundle processing semantics for
                    /// batch or transaction bundles. Unlike in ExecuteBundle, transaction bundles are not executed as a
                    /// single transaction and bundle-internal references are not rewritten. The bundle is treated as a
                    /// collection of resources to be written as provided in `Bundle.entry.resource`, ignoring
                    /// `Bundle.entry.request`. As an example, this allows the import of `searchset` bundles produced by
                    /// a FHIR search or Patient-everything operation. This method returns an Operation that can be used
                    /// to track the status of the import by calling GetOperation. Immediate fatal errors appear in the
                    /// error field, errors are also logged to Cloud Logging (see [Viewing error logs in Cloud
                    /// Logging](https://cloud.google.com/healthcare/docs/how-tos/logging)). Otherwise, when the
                    /// operation finishes, a detailed response of type ImportResourcesResponse is returned in the
                    /// response field. The metadata field type for this operation is OperationMetadata.
                    /// </summary>
                    public class ImportRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Import request.</summary>
                        public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.ImportResourcesRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The name of the FHIR store to import FHIR resources to, in the format of
                        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/fhirStores/{fhir_store_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.ImportResourcesRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "import";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:import";

                        /// <summary>Initializes Import parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Lists the FHIR stores in the given dataset.</summary>
                    /// <param name="parent">Name of the dataset.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists the FHIR stores in the given dataset.</summary>
                    public class ListRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ListFhirStoresResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Name of the dataset.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Restricts stores returned to those matching a filter. The following syntax is available: * A
                        /// string field value can be written as text inside quotation marks, for example `"query
                        /// text"`. The only valid relational operation for text fields is equality (`=`), where text is
                        /// searched within the field, rather than having the field be equal to the text. For example,
                        /// `"Comment = great"` returns messages with `great` in the comment field. * A number field
                        /// value can be written as an integer, a decimal, or an exponential. The valid relational
                        /// operators for number fields are the equality operator (`=`), along with the less
                        /// than/greater than operators (`&amp;lt;`, `&amp;lt;=`, `&amp;gt;`, `&amp;gt;=`). Note that
                        /// there is no inequality (`!=`) operator. You can prepend the `NOT` operator to an expression
                        /// to negate it. * A date field value must be written in `yyyy-mm-dd` form. Fields with date
                        /// and time use the RFC3339 time format. Leading zeros are required for one-digit months and
                        /// days. The valid relational operators for date fields are the equality operator (`=`) , along
                        /// with the less than/greater than operators (`&amp;lt;`, `&amp;lt;=`, `&amp;gt;`,
                        /// `&amp;gt;=`). Note that there is no inequality (`!=`) operator. You can prepend the `NOT`
                        /// operator to an expression to negate it. * Multiple field query expressions can be combined
                        /// in one query by adding `AND` or `OR` operators between the expressions. If a boolean
                        /// operator appears within a quoted string, it is not treated as special, it's just another
                        /// part of the character string to be matched. You can prepend the `NOT` operator to an
                        /// expression to negate it. Only filtering on labels is supported, for example
                        /// `labels.key=value`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Limit on the number of FHIR stores to return in a single response. If not specified, 100 is
                        /// used. May not be larger than 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// The next_page_token value returned from the previous List request, if any.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/fhirStores";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
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

                    /// <summary>Updates the configuration of the specified FHIR store.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Output only. Resource name of the FHIR store, of the form
                    /// `projects/{project_id}/datasets/{dataset_id}/fhirStores/{fhir_store_id}`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CloudHealthcare.v1.Data.FhirStore body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates the configuration of the specified FHIR store.</summary>
                    public class PatchRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.FhirStore>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.FhirStore body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Output only. Resource name of the FHIR store, of the form
                        /// `projects/{project_id}/datasets/{dataset_id}/fhirStores/{fhir_store_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// The update mask applies to the resource. For the `FieldMask` definition, see
                        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.FhirStore Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+$",
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

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudHealthcare.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:setIamPolicy";

                        /// <summary>Initializes SetIamPolicy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:testIamPermissions";

                        /// <summary>Initializes TestIamPermissions parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/fhirStores/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the Hl7V2Stores resource.</summary>
                public virtual Hl7V2StoresResource Hl7V2Stores { get; }

                /// <summary>The "hl7V2Stores" collection of methods.</summary>
                public class Hl7V2StoresResource
                {
                    private const string Resource = "hl7V2Stores";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public Hl7V2StoresResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Messages = new MessagesResource(service);
                    }

                    /// <summary>Gets the Messages resource.</summary>
                    public virtual MessagesResource Messages { get; }

                    /// <summary>The "messages" collection of methods.</summary>
                    public class MessagesResource
                    {
                        private const string Resource = "messages";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public MessagesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Parses and stores an HL7v2 message. This method triggers an asynchronous notification to any
                        /// Pub/Sub topic configured in Hl7V2Store.Hl7V2NotificationConfig, if the filtering matches the
                        /// message. If an MLLP adapter is configured to listen to a Pub/Sub topic, the adapter
                        /// transmits the message when a notification is received.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">The name of the dataset this message belongs to.</param>
                        public virtual CreateRequest Create(Google.Apis.CloudHealthcare.v1.Data.CreateMessageRequest body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>
                        /// Parses and stores an HL7v2 message. This method triggers an asynchronous notification to any
                        /// Pub/Sub topic configured in Hl7V2Store.Hl7V2NotificationConfig, if the filtering matches the
                        /// message. If an MLLP adapter is configured to listen to a Pub/Sub topic, the adapter
                        /// transmits the message when a notification is received.
                        /// </summary>
                        public class CreateRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Message>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.CreateMessageRequest body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>The name of the dataset this message belongs to.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.CreateMessageRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/messages";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/hl7V2Stores/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Deletes an HL7v2 message.</summary>
                        /// <param name="name">The resource name of the HL7v2 message to delete.</param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>Deletes an HL7v2 message.</summary>
                        public class DeleteRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Empty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>The resource name of the HL7v2 message to delete.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/hl7V2Stores/[^/]+/messages/[^/]+$",
                                });
                            }
                        }

                        /// <summary>Gets an HL7v2 message.</summary>
                        /// <param name="name">The resource name of the HL7v2 message to retrieve.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Gets an HL7v2 message.</summary>
                        public class GetRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Message>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>The resource name of the HL7v2 message to retrieve.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// Specifies which parts of the Message resource to return in the response. When
                            /// unspecified, equivalent to FULL.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<ViewEnum> View { get; set; }

                            /// <summary>
                            /// Specifies which parts of the Message resource to return in the response. When
                            /// unspecified, equivalent to FULL.
                            /// </summary>
                            public enum ViewEnum
                            {
                                /// <summary>Not specified, equivalent to FULL.</summary>
                                [Google.Apis.Util.StringValueAttribute("MESSAGE_VIEW_UNSPECIFIED")]
                                MESSAGEVIEWUNSPECIFIED = 0,

                                /// <summary>
                                /// Server responses include all the message fields except parsed_data field, and
                                /// schematized_data fields.
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("RAW_ONLY")]
                                RAWONLY = 1,

                                /// <summary>
                                /// Server responses include all the message fields except data field, and
                                /// schematized_data fields.
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("PARSED_ONLY")]
                                PARSEDONLY = 2,

                                /// <summary>Server responses include all the message fields.</summary>
                                [Google.Apis.Util.StringValueAttribute("FULL")]
                                FULL = 3,

                                /// <summary>
                                /// Server responses include all the message fields except data and parsed_data fields.
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("SCHEMATIZED_ONLY")]
                                SCHEMATIZEDONLY = 5,

                                /// <summary>Server responses include only the name field.</summary>
                                [Google.Apis.Util.StringValueAttribute("BASIC")]
                                BASIC = 4,
                            }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/hl7V2Stores/[^/]+/messages/[^/]+$",
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

                        /// <summary>
                        /// Parses and stores an HL7v2 message. This method triggers an asynchronous notification to any
                        /// Pub/Sub topic configured in Hl7V2Store.Hl7V2NotificationConfig, if the filtering matches the
                        /// message. If an MLLP adapter is configured to listen to a Pub/Sub topic, the adapter
                        /// transmits the message when a notification is received. If the method is successful, it
                        /// generates a response containing an HL7v2 acknowledgment (`ACK`) message. If the method
                        /// encounters an error, it returns a negative acknowledgment (`NACK`) message. This behavior is
                        /// suitable for replying to HL7v2 interface systems that expect these acknowledgments.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">The name of the HL7v2 store this message belongs to.</param>
                        public virtual IngestRequest Ingest(Google.Apis.CloudHealthcare.v1.Data.IngestMessageRequest body, string parent)
                        {
                            return new IngestRequest(service, body, parent);
                        }

                        /// <summary>
                        /// Parses and stores an HL7v2 message. This method triggers an asynchronous notification to any
                        /// Pub/Sub topic configured in Hl7V2Store.Hl7V2NotificationConfig, if the filtering matches the
                        /// message. If an MLLP adapter is configured to listen to a Pub/Sub topic, the adapter
                        /// transmits the message when a notification is received. If the method is successful, it
                        /// generates a response containing an HL7v2 acknowledgment (`ACK`) message. If the method
                        /// encounters an error, it returns a negative acknowledgment (`NACK`) message. This behavior is
                        /// suitable for replying to HL7v2 interface systems that expect these acknowledgments.
                        /// </summary>
                        public class IngestRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.IngestMessageResponse>
                        {
                            /// <summary>Constructs a new Ingest request.</summary>
                            public IngestRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.IngestMessageRequest body, string parent) : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>The name of the HL7v2 store this message belongs to.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.IngestMessageRequest Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "ingest";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/messages:ingest";

                            /// <summary>Initializes Ingest parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/hl7V2Stores/[^/]+$",
                                });
                            }
                        }

                        /// <summary>
                        /// Lists all the messages in the given HL7v2 store with support for filtering. Note: HL7v2
                        /// messages are indexed asynchronously, so there might be a slight delay between the time a
                        /// message is created and when it can be found through a filter.
                        /// </summary>
                        /// <param name="parent">Name of the HL7v2 store to retrieve messages from.</param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>
                        /// Lists all the messages in the given HL7v2 store with support for filtering. Note: HL7v2
                        /// messages are indexed asynchronously, so there might be a slight delay between the time a
                        /// message is created and when it can be found through a filter.
                        /// </summary>
                        public class ListRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ListMessagesResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>Name of the HL7v2 store to retrieve messages from.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// Restricts messages returned to those matching a filter. The following syntax is
                            /// available: * A string field value can be written as text inside quotation marks, for
                            /// example `"query text"`. The only valid relational operation for text fields is equality
                            /// (`=`), where text is searched within the field, rather than having the field be equal to
                            /// the text. For example, `"Comment = great"` returns messages with `great` in the comment
                            /// field. * A number field value can be written as an integer, a decimal, or an
                            /// exponential. The valid relational operators for number fields are the equality operator
                            /// (`=`), along with the less than/greater than operators (`&amp;lt;`, `&amp;lt;=`,
                            /// `&amp;gt;`, `&amp;gt;=`). Note that there is no inequality (`!=`) operator. You can
                            /// prepend the `NOT` operator to an expression to negate it. * A date field value must be
                            /// written in `yyyy-mm-dd` form. Fields with date and time use the RFC3339 time format.
                            /// Leading zeros are required for one-digit months and days. The valid relational operators
                            /// for date fields are the equality operator (`=`) , along with the less than/greater than
                            /// operators (`&amp;lt;`, `&amp;lt;=`, `&amp;gt;`, `&amp;gt;=`). Note that there is no
                            /// inequality (`!=`) operator. You can prepend the `NOT` operator to an expression to
                            /// negate it. * Multiple field query expressions can be combined in one query by adding
                            /// `AND` or `OR` operators between the expressions. If a boolean operator appears within a
                            /// quoted string, it is not treated as special, it's just another part of the character
                            /// string to be matched. You can prepend the `NOT` operator to an expression to negate it.
                            /// Fields/functions available for filtering are: * `message_type`, from the MSH-9.1 field.
                            /// For example, `NOT message_type = "ADT"`. * `send_date` or `sendDate`, the YYYY-MM-DD
                            /// date the message was sent in the dataset's time_zone, from the MSH-7 segment. For
                            /// example, `send_date &amp;lt; "2017-01-02"`. * `send_time`, the timestamp when the
                            /// message was sent, using the RFC3339 time format for comparisons, from the MSH-7 segment.
                            /// For example, `send_time &amp;lt; "2017-01-02T00:00:00-05:00"`. * `create_time`, the
                            /// timestamp when the message was created in the HL7v2 store. Use the RFC3339 time format
                            /// for comparisons. For example, `create_time &amp;lt; "2017-01-02T00:00:00-05:00"`. *
                            /// `send_facility`, the care center that the message came from, from the MSH-4 segment. For
                            /// example, `send_facility = "ABC"`. * `PatientId(value, type)`, which matches if the
                            /// message lists a patient having an ID of the given value and type in the PID-2, PID-3, or
                            /// PID-4 segments. For example, `PatientId("123456", "MRN")`. * `labels.x`, a string value
                            /// of the label with key `x` as set using the Message.labels map. For example,
                            /// `labels."priority"="high"`. The operator `:*` can be used to assert the existence of a
                            /// label. For example, `labels."priority":*`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string Filter { get; set; }

                            /// <summary>
                            /// Orders messages returned by the specified order_by clause. Syntax:
                            /// https://cloud.google.com/apis/design/design_patterns#sorting_order Fields available for
                            /// ordering are: * `send_time`
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string OrderBy { get; set; }

                            /// <summary>
                            /// Limit on the number of messages to return in a single response. If not specified, 100 is
                            /// used. May not be larger than 1000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// The next_page_token value returned from the previous List request, if any.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>
                            /// Specifies the parts of the Message to return in the response. When unspecified,
                            /// equivalent to BASIC. Setting this to anything other than BASIC with a `page_size` larger
                            /// than the default can generate a large response, which impacts the performance of this
                            /// method.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<ViewEnum> View { get; set; }

                            /// <summary>
                            /// Specifies the parts of the Message to return in the response. When unspecified,
                            /// equivalent to BASIC. Setting this to anything other than BASIC with a `page_size` larger
                            /// than the default can generate a large response, which impacts the performance of this
                            /// method.
                            /// </summary>
                            public enum ViewEnum
                            {
                                /// <summary>Not specified, equivalent to FULL.</summary>
                                [Google.Apis.Util.StringValueAttribute("MESSAGE_VIEW_UNSPECIFIED")]
                                MESSAGEVIEWUNSPECIFIED = 0,

                                /// <summary>
                                /// Server responses include all the message fields except parsed_data field, and
                                /// schematized_data fields.
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("RAW_ONLY")]
                                RAWONLY = 1,

                                /// <summary>
                                /// Server responses include all the message fields except data field, and
                                /// schematized_data fields.
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("PARSED_ONLY")]
                                PARSEDONLY = 2,

                                /// <summary>Server responses include all the message fields.</summary>
                                [Google.Apis.Util.StringValueAttribute("FULL")]
                                FULL = 3,

                                /// <summary>
                                /// Server responses include all the message fields except data and parsed_data fields.
                                /// </summary>
                                [Google.Apis.Util.StringValueAttribute("SCHEMATIZED_ONLY")]
                                SCHEMATIZEDONLY = 5,

                                /// <summary>Server responses include only the name field.</summary>
                                [Google.Apis.Util.StringValueAttribute("BASIC")]
                                BASIC = 4,
                            }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/messages";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/hl7V2Stores/[^/]+$",
                                });
                                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "filter",
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

                        /// <summary>
                        /// Update the message. The contents of the message in Message.data and data extracted from the
                        /// contents such as Message.create_time cannot be altered. Only the Message.labels field is
                        /// allowed to be updated. The labels in the request are merged with the existing set of labels.
                        /// Existing labels with the same keys are updated.
                        /// </summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">
                        /// Resource name of the Message, of the form
                        /// `projects/{project_id}/datasets/{dataset_id}/hl7V2Stores/{hl7_v2_store_id}/messages/{message_id}`.
                        /// Assigned by the server.
                        /// </param>
                        public virtual PatchRequest Patch(Google.Apis.CloudHealthcare.v1.Data.Message body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>
                        /// Update the message. The contents of the message in Message.data and data extracted from the
                        /// contents such as Message.create_time cannot be altered. Only the Message.labels field is
                        /// allowed to be updated. The labels in the request are merged with the existing set of labels.
                        /// Existing labels with the same keys are updated.
                        /// </summary>
                        public class PatchRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Message>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.Message body, string name) : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }

                            /// <summary>
                            /// Resource name of the Message, of the form
                            /// `projects/{project_id}/datasets/{dataset_id}/hl7V2Stores/{hl7_v2_store_id}/messages/{message_id}`.
                            /// Assigned by the server.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// The update mask applies to the resource. For the `FieldMask` definition, see
                            /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }

                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.CloudHealthcare.v1.Data.Message Body { get; set; }

                            /// <summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/hl7V2Stores/[^/]+/messages/[^/]+$",
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

                    /// <summary>Creates a new HL7v2 store within the parent dataset.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">The name of the dataset this HL7v2 store belongs to.</param>
                    public virtual CreateRequest Create(Google.Apis.CloudHealthcare.v1.Data.Hl7V2Store body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a new HL7v2 store within the parent dataset.</summary>
                    public class CreateRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Hl7V2Store>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.Hl7V2Store body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The name of the dataset this HL7v2 store belongs to.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// The ID of the HL7v2 store that is being created. The string must match the following regex:
                        /// `[\p{L}\p{N}_\-\.]{1,256}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("hl7V2StoreId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Hl7V2StoreId { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.Hl7V2Store Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/hl7V2Stores";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
                            });
                            RequestParameters.Add("hl7V2StoreId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "hl7V2StoreId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Deletes the specified HL7v2 store and removes all messages that it contains.</summary>
                    /// <param name="name">The resource name of the HL7v2 store to delete.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes the specified HL7v2 store and removes all messages that it contains.</summary>
                    public class DeleteRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The resource name of the HL7v2 store to delete.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/hl7V2Stores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets the specified HL7v2 store.</summary>
                    /// <param name="name">The resource name of the HL7v2 store to get.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets the specified HL7v2 store.</summary>
                    public class GetRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Hl7V2Store>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The resource name of the HL7v2 store to get.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/hl7V2Stores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                    {
                        return new GetIamPolicyRequest(service, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                        {
                            Resource = resource;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>
                        /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                        /// specifying an invalid value will be rejected. Requests for policies with any conditional
                        /// bindings must specify version 3. Policies without any conditional bindings may specify any
                        /// valid value or leave the field unset. To learn which resources support conditions in their
                        /// IAM policies, see the [IAM
                        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:getIamPolicy";

                        /// <summary>Initializes GetIamPolicy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/hl7V2Stores/[^/]+$",
                            });
                            RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                            {
                                Name = "options.requestedPolicyVersion",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>Lists the HL7v2 stores in the given dataset.</summary>
                    /// <param name="parent">Name of the dataset.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Lists the HL7v2 stores in the given dataset.</summary>
                    public class ListRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ListHl7V2StoresResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>Name of the dataset.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// Restricts stores returned to those matching a filter. The following syntax is available: * A
                        /// string field value can be written as text inside quotation marks, for example `"query
                        /// text"`. The only valid relational operation for text fields is equality (`=`), where text is
                        /// searched within the field, rather than having the field be equal to the text. For example,
                        /// `"Comment = great"` returns messages with `great` in the comment field. * A number field
                        /// value can be written as an integer, a decimal, or an exponential. The valid relational
                        /// operators for number fields are the equality operator (`=`), along with the less
                        /// than/greater than operators (`&amp;lt;`, `&amp;lt;=`, `&amp;gt;`, `&amp;gt;=`). Note that
                        /// there is no inequality (`!=`) operator. You can prepend the `NOT` operator to an expression
                        /// to negate it. * A date field value must be written in `yyyy-mm-dd` form. Fields with date
                        /// and time use the RFC3339 time format. Leading zeros are required for one-digit months and
                        /// days. The valid relational operators for date fields are the equality operator (`=`) , along
                        /// with the less than/greater than operators (`&amp;lt;`, `&amp;lt;=`, `&amp;gt;`,
                        /// `&amp;gt;=`). Note that there is no inequality (`!=`) operator. You can prepend the `NOT`
                        /// operator to an expression to negate it. * Multiple field query expressions can be combined
                        /// in one query by adding `AND` or `OR` operators between the expressions. If a boolean
                        /// operator appears within a quoted string, it is not treated as special, it's just another
                        /// part of the character string to be matched. You can prepend the `NOT` operator to an
                        /// expression to negate it. Only filtering on labels is supported. For example,
                        /// `labels.key=value`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>
                        /// Limit on the number of HL7v2 stores to return in a single response. If not specified, 100 is
                        /// used. May not be larger than 1000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// The next_page_token value returned from the previous List request, if any.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/hl7V2Stores";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
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

                    /// <summary>Updates the HL7v2 store.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Resource name of the HL7v2 store, of the form
                    /// `projects/{project_id}/datasets/{dataset_id}/hl7V2Stores/{hl7v2_store_id}`.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CloudHealthcare.v1.Data.Hl7V2Store body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates the HL7v2 store.</summary>
                    public class PatchRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Hl7V2Store>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.Hl7V2Store body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Resource name of the HL7v2 store, of the form
                        /// `projects/{project_id}/datasets/{dataset_id}/hl7V2Stores/{hl7v2_store_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// The update mask applies to the resource. For the `FieldMask` definition, see
                        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.Hl7V2Store Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/hl7V2Stores/[^/]+$",
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

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudHealthcare.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy. Can
                    /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                    /// </summary>
                    public class SetIamPolicyRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:setIamPolicy";

                        /// <summary>Initializes SetIamPolicy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/hl7V2Stores/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                    /// designed to be used for building permission-aware UIs and command-line tools, not for
                    /// authorization checking. This operation may "fail open" without warning.
                    /// </summary>
                    public class TestIamPermissionsRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                        /// documentation for the appropriate value for this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:testIamPermissions";

                        /// <summary>Initializes TestIamPermissions parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/hl7V2Stores/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the Operations resource.</summary>
                public virtual OperationsResource Operations { get; }

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
                    /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">The name of the operation resource to be cancelled.</param>
                    public virtual CancelRequest Cancel(Google.Apis.CloudHealthcare.v1.Data.CancelOperationRequest body, string name)
                    {
                        return new CancelRequest(service, body, name);
                    }

                    /// <summary>
                    /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
                    /// cancel the operation, but success is not guaranteed. If the server doesn't support this method,
                    /// it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                    /// methods to check whether the cancellation succeeded or whether the operation completed despite
                    /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                    /// operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to
                    /// `Code.CANCELLED`.
                    /// </summary>
                    public class CancelRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Cancel request.</summary>
                        public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.CancelOperationRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>The name of the operation resource to be cancelled.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudHealthcare.v1.Data.CancelOperationRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "cancel";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:cancel";

                        /// <summary>Initializes Cancel parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    /// <param name="name">The name of the operation resource.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>
                    /// Gets the latest state of a long-running operation. Clients can use this method to poll the
                    /// operation result at intervals as recommended by the API service.
                    /// </summary>
                    public class GetRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Operation>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The name of the operation resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+/operations/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                    /// override the binding to use different resource name schemes, such as `users/*/operations`. To
                    /// override the binding, API services can add a binding such as `"/v1/{name=users/*}/operations"`
                    /// to their service configuration. For backwards compatibility, the default name includes the
                    /// operations collection id, however overriding users must ensure the name binding is the parent
                    /// resource, without the operations collection id.
                    /// </summary>
                    /// <param name="name">The name of the operation's parent resource.</param>
                    public virtual ListRequest List(string name)
                    {
                        return new ListRequest(service, name);
                    }

                    /// <summary>
                    /// Lists operations that match the specified filter in the request. If the server doesn't support
                    /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                    /// override the binding to use different resource name schemes, such as `users/*/operations`. To
                    /// override the binding, API services can add a binding such as `"/v1/{name=users/*}/operations"`
                    /// to their service configuration. For backwards compatibility, the default name includes the
                    /// operations collection id, however overriding users must ensure the name binding is the parent
                    /// resource, without the operations collection id.
                    /// </summary>
                    public class ListRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ListOperationsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>The name of the operation's parent resource.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The standard list filter.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string Filter { get; set; }

                        /// <summary>The standard list page size.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The standard list page token.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}/operations";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
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

                /// <summary>
                /// Creates a new health dataset. Results are returned through the Operation interface which returns
                /// either an `Operation.response` which contains a Dataset or `Operation.error`. The metadata field
                /// type is OperationMetadata.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// The name of the project where the server creates the dataset. For example,
                /// `projects/{project_id}/locations/{location_id}`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudHealthcare.v1.Data.Dataset body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a new health dataset. Results are returned through the Operation interface which returns
                /// either an `Operation.response` which contains a Dataset or `Operation.error`. The metadata field
                /// type is OperationMetadata.
                /// </summary>
                public class CreateRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.Dataset body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the project where the server creates the dataset. For example,
                    /// `projects/{project_id}/locations/{location_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The ID of the dataset that is being created. The string must match the following regex:
                    /// `[\p{L}\p{N}_\-\.]{1,256}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string DatasetId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudHealthcare.v1.Data.Dataset Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/datasets";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "datasetId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Creates a new dataset containing de-identified data from the source dataset. The metadata field type
                /// is OperationMetadata. If the request is successful, the response field type is DeidentifySummary. If
                /// errors occur, error is set. The LRO result may still be successful if de-identification fails for
                /// some DICOM instances. The new de-identified dataset will not contain these failed resources. Failed
                /// resource totals are tracked in Operation.metadata. Error details are also logged to Cloud Logging.
                /// For more information, see [Viewing error logs in Cloud
                /// Logging](https://cloud.google.com/healthcare/docs/how-tos/logging).
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="sourceDataset">
                /// Source dataset resource name. For example,
                /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}`.
                /// </param>
                public virtual DeidentifyRequest Deidentify(Google.Apis.CloudHealthcare.v1.Data.DeidentifyDatasetRequest body, string sourceDataset)
                {
                    return new DeidentifyRequest(service, body, sourceDataset);
                }

                /// <summary>
                /// Creates a new dataset containing de-identified data from the source dataset. The metadata field type
                /// is OperationMetadata. If the request is successful, the response field type is DeidentifySummary. If
                /// errors occur, error is set. The LRO result may still be successful if de-identification fails for
                /// some DICOM instances. The new de-identified dataset will not contain these failed resources. Failed
                /// resource totals are tracked in Operation.metadata. Error details are also logged to Cloud Logging.
                /// For more information, see [Viewing error logs in Cloud
                /// Logging](https://cloud.google.com/healthcare/docs/how-tos/logging).
                /// </summary>
                public class DeidentifyRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Deidentify request.</summary>
                    public DeidentifyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.DeidentifyDatasetRequest body, string sourceDataset) : base(service)
                    {
                        SourceDataset = sourceDataset;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Source dataset resource name. For example,
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("sourceDataset", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string SourceDataset { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudHealthcare.v1.Data.DeidentifyDatasetRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "deidentify";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+sourceDataset}:deidentify";

                    /// <summary>Initializes Deidentify parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("sourceDataset", new Google.Apis.Discovery.Parameter
                        {
                            Name = "sourceDataset",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Deletes the specified health dataset and all data contained in the dataset. Deleting a dataset does
                /// not affect the sources from which the dataset was imported (if any).
                /// </summary>
                /// <param name="name">
                /// The name of the dataset to delete. For example,
                /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes the specified health dataset and all data contained in the dataset. Deleting a dataset does
                /// not affect the sources from which the dataset was imported (if any).
                /// </summary>
                public class DeleteRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the dataset to delete. For example,
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets any metadata associated with a dataset.</summary>
                /// <param name="name">
                /// The name of the dataset to read. For example,
                /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets any metadata associated with a dataset.</summary>
                public class GetRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Dataset>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the dataset to read. For example,
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(string resource)
                {
                    return new GetIamPolicyRequest(service, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource) : base(service)
                    {
                        Resource = resource;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>
                    /// Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                    /// specifying an invalid value will be rejected. Requests for policies with any conditional
                    /// bindings must specify version 3. Policies without any conditional bindings may specify any valid
                    /// value or leave the field unset. To learn which resources support conditions in their IAM
                    /// policies, see the [IAM
                    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:getIamPolicy";

                    /// <summary>Initializes GetIamPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
                        });
                        RequestParameters.Add("options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "options.requestedPolicyVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Lists the health datasets in the current project.</summary>
                /// <param name="parent">
                /// The name of the project whose datasets should be listed. For example,
                /// `projects/{project_id}/locations/{location_id}`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists the health datasets in the current project.</summary>
                public class ListRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ListDatasetsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the project whose datasets should be listed. For example,
                    /// `projects/{project_id}/locations/{location_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of items to return. If not specified, 100 is used. May not be larger than
                    /// 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The next_page_token value returned from a previous List request, if any.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/datasets";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
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

                /// <summary>Updates dataset metadata.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Resource name of the dataset, of the form
                /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudHealthcare.v1.Data.Dataset body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates dataset metadata.</summary>
                public class PatchRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Dataset>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.Dataset body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Resource name of the dataset, of the form
                    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The update mask applies to the resource. For the `FieldMask` definition, see
                    /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudHealthcare.v1.Data.Dataset Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

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
                            Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
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

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See the operation documentation for
                /// the appropriate value for this field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudHealthcare.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy. Can return
                /// `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.
                /// </summary>
                public class SetIamPolicyRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See the operation documentation
                    /// for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudHealthcare.v1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:setIamPolicy";

                    /// <summary>Initializes SetIamPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
                /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
                /// checking. This operation may "fail open" without warning.
                /// </summary>
                public class TestIamPermissionsRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See the operation
                    /// documentation for the appropriate value for this field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudHealthcare.v1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:testIamPermissions";

                    /// <summary>Initializes TestIamPermissions parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/datasets/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.Location>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Resource name for the location.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

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
                        Pattern = @"^projects/[^/]+/locations/[^/]+$",
                    });
                }
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : CloudHealthcareBaseServiceRequest<Google.Apis.CloudHealthcare.v1.Data.ListLocationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>The resource that owns the locations collection, if applicable.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// A filter to narrow down results to a preferred subset. The filtering language accepts strings like
                /// "displayName=tokyo", and is documented in more detail in [AIP-160](https://google.aip.dev/160).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// The maximum number of results to return. If not set, the service selects a default.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token received from the `next_page_token` field in the response. Send that page token to
                /// receive the subsequent page.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}/locations";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
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
    }
}
namespace Google.Apis.CloudHealthcare.v1.Data
{
    /// <summary>
    /// Activates the latest revision of the specified Consent by committing a new revision with `state` updated to
    /// `ACTIVE`. If the latest revision of the given Consent is in the `ACTIVE` state, no new revision is committed. A
    /// FAILED_PRECONDITION error occurs if the latest revision of the given consent is in the `REJECTED` or `REVOKED`
    /// state.
    /// </summary>
    public class ActivateConsentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The resource name of the Consent artifact that contains documentation of the user's consent, of
        /// the form
        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consentArtifacts/{consent_artifact_id}`.
        /// If the draft Consent had a Consent artifact, this Consent artifact overwrites it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consentArtifact")]
        public virtual string ConsentArtifact { get; set; }

        /// <summary>Timestamp in UTC of when this Consent is considered expired.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>The time to live for this Consent from when it is marked as active.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Archives the specified User data mapping.</summary>
    public class ArchiveUserDataMappingRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Archives the specified User data mapping.</summary>
    public class ArchiveUserDataMappingResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An attribute value for a Consent or User data mapping. Each Attribute must have a corresponding
    /// AttributeDefinition in the consent store that defines the default and allowed values.
    /// </summary>
    public class Attribute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates the name of an attribute defined in the consent store.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeDefinitionId")]
        public virtual string AttributeDefinitionId { get; set; }

        /// <summary>
        /// Required. The value of the attribute. Must be an acceptable value as defined in the consent store. For
        /// example, if the consent store defines "data type" with acceptable values "questionnaire" and "step-count",
        /// when the attribute name is data type, this field must contain one of those values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A client-defined consent attribute.</summary>
    public class AttributeDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Possible values for the attribute. The number of allowed values must not exceed 100. An empty list
        /// is invalid. The list can only be expanded after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedValues")]
        public virtual System.Collections.Generic.IList<string> AllowedValues { get; set; }

        /// <summary>
        /// Required. The category of the attribute. The value of this field cannot be changed after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>
        /// Optional. Default values of the attribute in Consents. If no default values are specified, it defaults to an
        /// empty value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consentDefaultValues")]
        public virtual System.Collections.Generic.IList<string> ConsentDefaultValues { get; set; }

        /// <summary>
        /// Optional. Default value of the attribute in User data mappings. If no default value is specified, it
        /// defaults to an empty value. This field is only applicable to attributes of the category `RESOURCE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataMappingDefaultValue")]
        public virtual string DataMappingDefaultValue { get; set; }

        /// <summary>Optional. A description of the attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Resource name of the Attribute definition, of the form
        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/attributeDefinitions/{attribute_definition_id}`.
        /// Cannot be changed after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the audit configuration for a service. The configuration determines which permission types are logged,
    /// and what identities, if any, are exempted from logging. An AuditConfig must have one or more AuditLogConfigs. If
    /// there are AuditConfigs for both `allServices` and a specific service, the union of the two AuditConfigs is used
    /// for that service: the log_types specified in each AuditConfig are enabled, and the exempted_members in each
    /// AuditLogConfig are exempted. Example Policy with multiple AuditConfigs: { "audit_configs": [ { "service":
    /// "allServices", "audit_log_configs": [ { "log_type": "DATA_READ", "exempted_members": [ "user:jose@example.com" ]
    /// }, { "log_type": "DATA_WRITE" }, { "log_type": "ADMIN_READ" } ] }, { "service": "sampleservice.googleapis.com",
    /// "audit_log_configs": [ { "log_type": "DATA_READ" }, { "log_type": "DATA_WRITE", "exempted_members": [
    /// "user:aliya@example.com" ] } ] } ] } For sampleservice, this policy enables DATA_READ, DATA_WRITE and ADMIN_READ
    /// logging. It also exempts jose@example.com from DATA_READ logging, and aliya@example.com from DATA_WRITE logging.
    /// </summary>
    public class AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<AuditLogConfig> AuditLogConfigs { get; set; }

        /// <summary>
        /// Specifies a service that will be enabled for audit logging. For example, `storage.googleapis.com`,
        /// `cloudsql.googleapis.com`. `allServices` is a special value that covers all services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides the configuration for logging a type of permissions. Example: { "audit_log_configs": [ { "log_type":
    /// "DATA_READ", "exempted_members": [ "user:jose@example.com" ] }, { "log_type": "DATA_WRITE" } ] } This enables
    /// 'DATA_READ' and 'DATA_WRITE' logging, while exempting jose@example.com from DATA_READ logging.
    /// </summary>
    public class AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the identities that do not cause logging for this type of permission. Follows the same format of
        /// Binding.members.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptedMembers")]
        public virtual System.Collections.Generic.IList<string> ExemptedMembers { get; set; }

        /// <summary>The log type that this config enables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logType")]
        public virtual string LogType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members` with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// members in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the identities requesting access for a Cloud Platform resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. * `user:{emailid}`: An email address that represents a specific
        /// Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address that
        /// represents a service account. For example, `my-other-app@appspot.gserviceaccount.com`. * `group:{emailid}`:
        /// An email address that represents a Google group. For example, `admins@example.com`. *
        /// `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that
        /// has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is
        /// recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that
        /// domain. For example, `google.com` or `example.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Mask a string by replacing its characters with a fixed character.</summary>
    public class CharacterMaskConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Character to mask the sensitive values. If not supplied, defaults to "*".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maskingCharacter")]
        public virtual string MaskingCharacter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Checks if a particular data_id of a User data mapping in the given consent store is consented for a given use.
    /// </summary>
    public class CheckDataAccessRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specific Consents to evaluate the access request against. These Consents must have the same
        /// `user_id` as the evaluated User data mapping, must exist in the current `consent_store`, and have a `state`
        /// of either `ACTIVE` or `DRAFT`. A maximum of 100 Consents can be provided here. If no selection is specified,
        /// the access request is evaluated against all `ACTIVE` unexpired Consents with the same `user_id` as the
        /// evaluated User data mapping.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consentList")]
        public virtual ConsentList ConsentList { get; set; }

        /// <summary>
        /// Required. The unique identifier of the resource to check access for. This identifier must correspond to a
        /// User data mapping in the given consent store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataId")]
        public virtual string DataId { get; set; }

        /// <summary>The values of request attributes associated with this access request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestAttributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> RequestAttributes { get; set; }

        /// <summary>
        /// Optional. The view for CheckDataAccessResponse. If unspecified, defaults to `BASIC` and returns `consented`
        /// as `TRUE` or `FALSE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseView")]
        public virtual string ResponseView { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Checks if a particular data_id of a User data mapping in the given consent store is consented for a given use.
    /// </summary>
    public class CheckDataAccessResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource names of all evaluated Consents mapped to their evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consentDetails")]
        public virtual System.Collections.Generic.IDictionary<string, ConsentEvaluation> ConsentDetails { get; set; }

        /// <summary>Whether the requested resource is consented for the given use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consented")]
        public virtual System.Nullable<bool> Consented { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a user's consent.</summary>
    public class Consent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The resource name of the Consent artifact that contains proof of the end user's consent, of the
        /// form
        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consentArtifacts/{consent_artifact_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consentArtifact")]
        public virtual string ConsentArtifact { get; set; }

        /// <summary>Timestamp in UTC of when this Consent is considered expired.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>
        /// Optional. User-supplied key-value pairs used to organize Consent resources. Metadata keys must: - be between
        /// 1 and 63 characters long - have a UTF-8 encoding of maximum 128 bytes - begin with a letter - consist of up
        /// to 63 characters including lowercase letters, numeric characters, underscores, and dashes Metadata values
        /// must be: - be between 1 and 63 characters long - have a UTF-8 encoding of maximum 128 bytes - consist of up
        /// to 63 characters including lowercase letters, numeric characters, underscores, and dashes No more than 64
        /// metadata entries can be associated with a given consent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Resource name of the Consent, of the form
        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}`.
        /// Cannot be changed after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Optional. Represents a user's consent in terms of the resources that can be accessed and under what
        /// conditions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policies")]
        public virtual System.Collections.Generic.IList<GoogleCloudHealthcareV1ConsentPolicy> Policies { get; set; }

        /// <summary>Output only. The timestamp that the revision was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionCreateTime")]
        public virtual object RevisionCreateTime { get; set; }

        /// <summary>
        /// Output only. The revision ID of the Consent. The format is an 8-character hexadecimal string. Refer to a
        /// specific revision of a Consent by appending `@{revision_id}` to the Consent's resource name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("revisionId")]
        public virtual string RevisionId { get; set; }

        /// <summary>Required. Indicates the current state of this Consent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Input only. The time to live for this Consent from when it is created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; }

        /// <summary>Required. User's UUID provided by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Documentation of a user's consent.</summary>
    public class ConsentArtifact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Screenshots, PDFs, or other binary information documenting the user's consent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consentContentScreenshots")]
        public virtual System.Collections.Generic.IList<Image> ConsentContentScreenshots { get; set; }

        /// <summary>Optional. An string indicating the version of the consent information shown to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consentContentVersion")]
        public virtual string ConsentContentVersion { get; set; }

        /// <summary>Optional. A signature from a guardian.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guardianSignature")]
        public virtual Signature GuardianSignature { get; set; }

        /// <summary>
        /// Optional. Metadata associated with the Consent artifact. For example, the consent locale or user agent
        /// version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Resource name of the Consent artifact, of the form
        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consentArtifacts/{consent_artifact_id}`.
        /// Cannot be changed after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Required. User's UUID provided by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>Optional. User's signature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userSignature")]
        public virtual Signature UserSignature { get; set; }

        /// <summary>Optional. A signature from a witness.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("witnessSignature")]
        public virtual Signature WitnessSignature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The detailed evaluation of a particular Consent.</summary>
    public class ConsentEvaluation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The evaluation result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("evaluationResult")]
        public virtual string EvaluationResult { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of resource names of Consent resources.</summary>
    public class ConsentList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource names of the Consents to evaluate against, of the form
        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consents/{consent_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consents")]
        public virtual System.Collections.Generic.IList<string> Consents { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a consent store.</summary>
    public class ConsentStore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Default time to live for Consents created in this store. Must be at least 24 hours. Updating this
        /// field will not affect the expiration time of existing consents.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultConsentTtl")]
        public virtual object DefaultConsentTtl { get; set; }

        /// <summary>
        /// Optional. If `true`, UpdateConsent creates the Consent if it does not already exist. If unspecified,
        /// defaults to `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableConsentCreateOnUpdate")]
        public virtual System.Nullable<bool> EnableConsentCreateOnUpdate { get; set; }

        /// <summary>
        /// Optional. User-supplied key-value pairs used to organize consent stores. Label keys must be between 1 and 63
        /// characters long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular
        /// expression: \p{Ll}\p{Lo}{0,62}. Label values must be between 1 and 63 characters long, have a UTF-8 encoding
        /// of maximum 128 bytes, and must conform to the following PCRE regular expression:
        /// [\p{Ll}\p{Lo}\p{N}_-]{0,63}. No more than 64 labels can be associated with a given store. For more
        /// information: https://cloud.google.com/healthcare/docs/how-tos/labeling-resources
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Resource name of the consent store, of the form
        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}`.
        /// Cannot be changed after creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Creates a new message.</summary>
    public class CreateMessageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>HL7v2 message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. Outputs a
    /// base64-encoded representation of the hashed output (for example,
    /// `L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=`).
    /// </summary>
    public class CryptoHashConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An AES 128/192/256 bit key. Causes the hash to be computed based on this key. A default key is generated for
        /// each Deidentify operation and is used wherever crypto_key is not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKey")]
        public virtual string CryptoKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A message representing a health dataset. A health dataset represents a collection of healthcare data pertaining
    /// to one or more patients. This may include multiple modalities of healthcare data, such as electronic medical
    /// records or medical imaging data.
    /// </summary>
    public class Dataset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Resource name of the dataset, of the form
        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The default timezone used by this dataset. Must be a either a valid IANA time zone name such as
        /// "America/New_York" or empty, which defaults to UTC. This is used for parsing times in resources, such as HL7
        /// messages, where no explicit timezone is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Shift a date forward or backward in time by a random amount which is consistent for a given patient and crypto
    /// key combination.
    /// </summary>
    public class DateShiftConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An AES 128/192/256 bit key. Causes the shift to be computed based on this key and the patient ID. A default
        /// key is generated for each Deidentify operation and is used wherever crypto_key is not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoKey")]
        public virtual string CryptoKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configures de-id options specific to different types of content. Each submessage customizes the handling of an
    /// https://tools.ietf.org/html/rfc6838 media type or subtype. Configs are applied in a nested manner at runtime.
    /// </summary>
    public class DeidentifyConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configures de-id of application/DICOM content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dicom")]
        public virtual DicomConfig Dicom { get; set; }

        /// <summary>Configures de-id of application/FHIR content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fhir")]
        public virtual FhirConfig Fhir { get; set; }

        /// <summary>
        /// Configures de-identification of image pixels wherever they are found in the source_dataset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual ImageConfig Image { get; set; }

        /// <summary>Configures de-identification of text wherever it is found in the source_dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual TextConfig Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Redacts identifying information from the specified dataset.</summary>
    public class DeidentifyDatasetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deidentify configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual DeidentifyConfig Config { get; set; }

        /// <summary>
        /// The name of the dataset resource to create and write the redacted data to. * The destination dataset must
        /// not exist. * The destination dataset must be in the same location as the source dataset. De-identifying data
        /// across multiple locations is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationDataset")]
        public virtual string DestinationDataset { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Creates a new DICOM store with sensitive information de-identified.</summary>
    public class DeidentifyDicomStoreRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>De-identify configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual DeidentifyConfig Config { get; set; }

        /// <summary>
        /// The name of the DICOM store to create and write the redacted data to. For example,
        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`. * The
        /// destination dataset must exist. * The source dataset and destination dataset must both reside in the same
        /// location. De-identifying data across multiple locations is not supported. * The destination DICOM store must
        /// not exist. * The caller must have the necessary permissions to create the destination DICOM store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationStore")]
        public virtual string DestinationStore { get; set; }

        /// <summary>Filter configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterConfig")]
        public virtual DicomFilterConfig FilterConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Creates a new FHIR store with sensitive information de-identified.</summary>
    public class DeidentifyFhirStoreRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deidentify configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual DeidentifyConfig Config { get; set; }

        /// <summary>
        /// The name of the FHIR store to create and write the redacted data to. For example,
        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/fhirStores/{fhir_store_id}`. * The
        /// destination dataset must exist. * The source dataset and destination dataset must both reside in the same
        /// location. De-identifying data across multiple locations is not supported. * The destination FHIR store must
        /// exist. * The caller must have the healthcare.fhirResources.update permission to write to the destination
        /// FHIR store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationStore")]
        public virtual string DestinationStore { get; set; }

        /// <summary>
        /// A filter specifying the resources to include in the output. If not specified, all resources are included in
        /// the output.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceFilter")]
        public virtual FhirFilter ResourceFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains a summary of the Deidentify operation.</summary>
    public class DeidentifySummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the parameters needed for de-identification of DICOM stores.</summary>
    public class DicomConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Tag filtering profile that determines which tags to keep/remove.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterProfile")]
        public virtual string FilterProfile { get; set; }

        /// <summary>List of tags to keep. Remove all other tags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keepList")]
        public virtual TagFilterList KeepList { get; set; }

        /// <summary>List of tags to remove. Keep all other tags.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removeList")]
        public virtual TagFilterList RemoveList { get; set; }

        /// <summary>
        /// If true, skip replacing StudyInstanceUID, SeriesInstanceUID, SOPInstanceUID, and MediaStorageSOPInstanceUID
        /// and leave them untouched. The Cloud Healthcare API regenerates these UIDs by default based on the DICOM
        /// Standard's reasoning: "Whilst these UIDs cannot be mapped directly to an individual out of context, given
        /// access to the original images, or to a database of the original images containing the UIDs, it would be
        /// possible to recover the individual's identity."
        /// http://dicom.nema.org/medical/dicom/current/output/chtml/part15/sect_E.3.9.html
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("skipIdRedaction")]
        public virtual System.Nullable<bool> SkipIdRedaction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the filter configuration for DICOM resources.</summary>
    public class DicomFilterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Cloud Storage location of the filter configuration file. The `gcs_uri` must be in the format
        /// `gs://bucket/path/to/object`. The filter configuration file must contain a list of resource paths separated
        /// by newline characters (\n or \r\n). Each resource path must be in the format
        /// "/studies/{studyUID}[/series/{seriesUID}[/instances/{instanceUID}]]" The Cloud Healthcare API service
        /// account must have the `roles/storage.objectViewer` Cloud IAM role for this Cloud Storage location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourcePathsGcsUri")]
        public virtual string ResourcePathsGcsUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a DICOM store.</summary>
    public class DicomStore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User-supplied key-value pairs used to organize DICOM stores. Label keys must be between 1 and 63 characters
        /// long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression:
        /// \p{Ll}\p{Lo}{0,62} Label values are optional, must be between 1 and 63 characters long, have a UTF-8
        /// encoding of maximum 128 bytes, and must conform to the following PCRE regular expression:
        /// [\p{Ll}\p{Lo}\p{N}_-]{0,63} No more than 64 labels can be associated with a given store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Resource name of the DICOM store, of the form
        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/dicomStores/{dicom_store_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Notification destination for new DICOM instances. Supplied by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfig")]
        public virtual NotificationConfig NotificationConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Evaluate a user's Consents for all matching User data mappings. Note: User data mappings are indexed
    /// asynchronously, causing slight delays between the time mappings are created or updated and when they are
    /// included in EvaluateUserConsents results.
    /// </summary>
    public class EvaluateUserConsentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Specific Consents to evaluate the access request against. These Consents must have the same
        /// `user_id` as the User data mappings being evalauted, must exist in the current `consent_store`, and must
        /// have a `state` of either `ACTIVE` or `DRAFT`. A maximum of 100 Consents can be provided here. If
        /// unspecified, all `ACTIVE` unexpired Consents in the current `consent_store` will be evaluated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consentList")]
        public virtual ConsentList ConsentList { get; set; }

        /// <summary>
        /// Optional. Limit on the number of User data mappings to return in a single response. If not specified, 100 is
        /// used. May not be larger than 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>Optional. Token to retrieve the next page of results, or empty to get the first page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        /// <summary>Required. The values of request attributes associated with this access request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestAttributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> RequestAttributes { get; set; }

        /// <summary>
        /// Optional. The values of resource attributes associated with the resources being requested. If no values are
        /// specified, then all resources are queried.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceAttributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> ResourceAttributes { get; set; }

        /// <summary>
        /// Optional. The view for EvaluateUserConsentsResponse. If unspecified, defaults to `BASIC` and returns
        /// `consented` as `TRUE` or `FALSE`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseView")]
        public virtual string ResponseView { get; set; }

        /// <summary>Required. User ID to evaluate consents for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class EvaluateUserConsentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list. This token is
        /// valid for 72 hours after it is created.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The consent evaluation result for each `data_id`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("results")]
        public virtual System.Collections.Generic.IList<Result> Results { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Exports data from the specified DICOM store. If a given resource, such as a DICOM object with the same
    /// SOPInstance UID, already exists in the output, it is overwritten with the version in the source dataset.
    /// Exported DICOM data persists when the DICOM store from which it was exported is deleted.
    /// </summary>
    public class ExportDicomDataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The BigQuery output destination. You can only export to a BigQuery dataset that's in the same project as the
        /// DICOM store you're exporting from. The Cloud Healthcare Service Agent requires two IAM roles on the BigQuery
        /// location: `roles/bigquery.dataEditor` and `roles/bigquery.jobUser`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryDestination")]
        public virtual GoogleCloudHealthcareV1DicomBigQueryDestination BigqueryDestination { get; set; }

        /// <summary>
        /// The Cloud Storage output destination. The Cloud Healthcare Service Agent requires the
        /// `roles/storage.objectAdmin` Cloud IAM roles on the Cloud Storage location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GoogleCloudHealthcareV1DicomGcsDestination GcsDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Returns additional information in regards to a completed DICOM store export.</summary>
    public class ExportDicomDataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to export resources.</summary>
    public class ExportResourcesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The BigQuery output destination. The Cloud Healthcare Service Agent requires two IAM roles on the BigQuery
        /// location: `roles/bigquery.dataEditor` and `roles/bigquery.jobUser`. The output is one BigQuery table per
        /// resource type. Note that unlike in FhirStore.StreamConfig.BigQueryDestination, BigQuery views will not be
        /// created by ExportResources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryDestination")]
        public virtual GoogleCloudHealthcareV1FhirBigQueryDestination BigqueryDestination { get; set; }

        /// <summary>
        /// The Cloud Storage output destination. The Healthcare Service Agent account requires the
        /// `roles/storage.objectAdmin` role on the Cloud Storage location. The exported outputs are organized by FHIR
        /// resource types. The server creates one object per resource type. Each object contains newline delimited
        /// JSON, and each line is a FHIR resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GoogleCloudHealthcareV1FhirGcsDestination GcsDestination { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response when all resources export successfully. This structure is included in the response to describe the
    /// detailed outcome after the operation finishes successfully.
    /// </summary>
    public class ExportResourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression
    /// language. The syntax and semantics of CEL are documented at https://github.com/google/cel-spec. Example
    /// (Comparison): title: "Summary size limit" description: "Determines if a summary is less than 100 chars"
    /// expression: "document.summary.size() &amp;lt; 100" Example (Equality): title: "Requestor is owner" description:
    /// "Determines if requestor is the document owner" expression: "document.owner == request.auth.claims.email"
    /// Example (Logic): title: "Public documents" description: "Determine whether the document should be publicly
    /// visible" expression: "document.type != 'private' &amp;amp;&amp;amp; document.type != 'internal'" Example (Data
    /// Manipulation): title: "Notification string" description: "Create a notification string with a timestamp."
    /// expression: "'New message received at ' + string(document.create_time)" The exact variables and functions that
    /// may be referenced within an expression are determined by the service that evaluates it. See the service
    /// documentation for additional information.
    /// </summary>
    public class Expr : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Description of the expression. This is a longer text which describes the expression, e.g. when
        /// hovered over it in a UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        /// <summary>
        /// Optional. String indicating the location of the expression for error reporting, e.g. a file name and a
        /// position in the file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs
        /// which allow to enter the expression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how to handle de-identification of a FHIR store.</summary>
    public class FhirConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies FHIR paths to match and how to transform them. Any field that is not matched by a FieldMetadata is
        /// passed through to the output dataset unmodified. All extensions are removed in the output.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldMetadataList")]
        public virtual System.Collections.Generic.IList<FieldMetadata> FieldMetadataList { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Filter configuration.</summary>
    public class FhirFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of resources to include in the output. If this list is empty or not specified, all resources are
        /// included in the output.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual Resources Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a FHIR store.</summary>
    public class FhirStore : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, overrides the default search behavior for this FHIR store to `handling=strict` which returns an
        /// error for unrecognized search parameters. If false, uses the FHIR specification default `handling=lenient`
        /// which ignores unrecognized search parameters. The handling can always be changed from the default on an
        /// individual API call by setting the HTTP header `Prefer: handling=strict` or `Prefer: handling=lenient`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultSearchHandlingStrict")]
        public virtual System.Nullable<bool> DefaultSearchHandlingStrict { get; set; }

        /// <summary>
        /// Immutable. Whether to disable referential integrity in this FHIR store. This field is immutable after FHIR
        /// store creation. The default value is false, meaning that the API enforces referential integrity and fails
        /// the requests that result in inconsistent state in the FHIR store. When this field is set to true, the API
        /// skips referential integrity checks. Consequently, operations that rely on references, such as
        /// GetPatientEverything, do not return all the results if broken references exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableReferentialIntegrity")]
        public virtual System.Nullable<bool> DisableReferentialIntegrity { get; set; }

        /// <summary>
        /// Immutable. Whether to disable resource versioning for this FHIR store. This field can not be changed after
        /// the creation of FHIR store. If set to false, which is the default behavior, all write operations cause
        /// historical versions to be recorded automatically. The historical versions can be fetched through the history
        /// APIs, but cannot be updated. If set to true, no historical versions are kept. The server sends errors for
        /// attempts to read the historical versions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disableResourceVersioning")]
        public virtual System.Nullable<bool> DisableResourceVersioning { get; set; }

        /// <summary>
        /// Whether this FHIR store has the [updateCreate
        /// capability](https://www.hl7.org/fhir/capabilitystatement-definitions.html#CapabilityStatement.rest.resource.updateCreate).
        /// This determines if the client can use an Update operation to create a new resource with a client-specified
        /// ID. If false, all IDs are server-assigned through the Create operation and attempts to update a non-existent
        /// resource return errors. It is strongly advised not to include or encode any sensitive data such as patient
        /// identifiers in client-specified resource IDs. Those IDs are part of the FHIR resource path recorded in Cloud
        /// audit logs and Pub/Sub notifications. Those IDs can also be contained in reference fields within other
        /// resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableUpdateCreate")]
        public virtual System.Nullable<bool> EnableUpdateCreate { get; set; }

        /// <summary>
        /// User-supplied key-value pairs used to organize FHIR stores. Label keys must be between 1 and 63 characters
        /// long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression:
        /// \p{Ll}\p{Lo}{0,62} Label values are optional, must be between 1 and 63 characters long, have a UTF-8
        /// encoding of maximum 128 bytes, and must conform to the following PCRE regular expression:
        /// [\p{Ll}\p{Lo}\p{N}_-]{0,63} No more than 64 labels can be associated with a given store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Output only. Resource name of the FHIR store, of the form
        /// `projects/{project_id}/datasets/{dataset_id}/fhirStores/{fhir_store_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// If non-empty, publish all resource modifications of this FHIR store to this destination. The Pub/Sub message
        /// attributes contain a map with a string describing the action that has triggered the notification. For
        /// example, "action":"CreateResource".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfig")]
        public virtual NotificationConfig NotificationConfig { get; set; }

        /// <summary>
        /// A list of streaming configs that configure the destinations of streaming export for every resource mutation
        /// in this FHIR store. Each store is allowed to have up to 10 streaming configs. After a new config is added,
        /// the next resource mutation is streamed to the new location in addition to the existing ones. When a location
        /// is removed from the list, the server stops streaming to that location. Before adding a new config, you must
        /// add the required
        /// [`bigquery.dataEditor`](https://cloud.google.com/bigquery/docs/access-control#bigquery.dataEditor) role to
        /// your project's **Cloud Healthcare Service Agent** [service
        /// account](https://cloud.google.com/iam/docs/service-accounts). Some lag (typically on the order of dozens of
        /// seconds) is expected before the results show up in the streaming destination.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamConfigs")]
        public virtual System.Collections.Generic.IList<StreamConfig> StreamConfigs { get; set; }

        /// <summary>
        /// Immutable. The FHIR specification version that this FHIR store supports natively. This field is immutable
        /// after store creation. Requests are rejected if they contain FHIR resources of a different version. Version
        /// is required for every FHIR store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A (sub) field of a type.</summary>
    public class Field : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The maximum number of times this field can be repeated. 0 or -1 means unbounded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxOccurs")]
        public virtual System.Nullable<int> MaxOccurs { get; set; }

        /// <summary>The minimum number of times this field must be present/repeated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minOccurs")]
        public virtual System.Nullable<int> MinOccurs { get; set; }

        /// <summary>The name of the field. For example, "PID-1" or just "1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The HL7v2 table this field refers to. For example, PID-15 (Patient's Primary Language) usually refers to
        /// table "0296".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("table")]
        public virtual string Table { get; set; }

        /// <summary>The type of this field. A Type with this name must be defined in an Hl7TypesConfig.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies FHIR paths to match, and how to handle de-identification of matching fields.</summary>
    public class FieldMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deidentify action for one field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>
        /// List of paths to FHIR fields to be redacted. Each path is a period-separated list where each component is
        /// either a field name or FHIR type name, for example: Patient, HumanName. For "choice" types (those defined in
        /// the FHIR spec with the form: field[x]) we use two separate components. For example, "deceasedAge.unit" is
        /// matched by "Deceased.Age.unit". Supported types are: AdministrativeGenderCode, Code, Date, DateTime,
        /// Decimal, HumanName, Id, LanguageCode, Markdown, Oid, String, Uri, Uuid, Xhtml. Base64Binary is also
        /// supported, but may only be kept as-is or have all the content removed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("paths")]
        public virtual System.Collections.Generic.IList<string> Paths { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Cloud Storage location for export.</summary>
    public class GoogleCloudHealthcareV1ConsentGcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// URI for a Cloud Storage directory where the server writes result files, in the format
        /// `gs://{bucket-id}/{path/to/destination/dir}`. If there is no trailing slash, the service appends one when
        /// composing the object path. The user is responsible for creating the Cloud Storage bucket and directory
        /// referenced in `uri_prefix`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uriPrefix")]
        public virtual string UriPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a user's consent in terms of the resources that can be accessed and under what conditions.
    /// </summary>
    public class GoogleCloudHealthcareV1ConsentPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The request conditions to meet to grant access. In addition to any supported comparison operators,
        /// authorization rules may have `IN` operator as well as at most 10 logical operators that are limited to `AND`
        /// (`&amp;amp;&amp;amp;`), `OR` (`||`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizationRule")]
        public virtual Expr AuthorizationRule { get; set; }

        /// <summary>
        /// The resources that this policy applies to. A resource is a match if it matches all the attributes listed
        /// here. If empty, this policy applies to all User data mappings for the given user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceAttributes")]
        public virtual System.Collections.Generic.IList<Attribute> ResourceAttributes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains a summary of the DeidentifyDicomStore operation.</summary>
    public class GoogleCloudHealthcareV1DeidentifyDeidentifyDicomStoreSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains a summary of the DeidentifyFhirStore operation.</summary>
    public class GoogleCloudHealthcareV1DeidentifyDeidentifyFhirStoreSummary : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The BigQuery table where the server writes the output.</summary>
    public class GoogleCloudHealthcareV1DicomBigQueryDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the destination table already exists and this flag is `TRUE`, the table is overwritten by the contents of
        /// the DICOM store. If the flag is not set and the destination table already exists, the export call returns an
        /// error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("force")]
        public virtual System.Nullable<bool> Force { get; set; }

        /// <summary>
        /// BigQuery URI to a table, up to 2000 characters long, in the format `bq://projectId.bqDatasetId.tableId`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableUri")]
        public virtual string TableUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The Cloud Storage location where the server writes the output and the export configuration.</summary>
    public class GoogleCloudHealthcareV1DicomGcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// MIME types supported by DICOM spec. Each file is written in the following format:
        /// `.../{study_id}/{series_id}/{instance_id}[/{frame_number}].{extension}` The frame_number component exists
        /// only for multi-frame instances. Supported MIME types are consistent with supported formats in DICOMweb:
        /// https://cloud.google.com/healthcare/docs/dicom#retrieve_transaction. Specifically, the following are
        /// supported: - application/dicom; transfer-syntax=1.2.840.10008.1.2.1 (uncompressed DICOM) -
        /// application/dicom; transfer-syntax=1.2.840.10008.1.2.4.50 (DICOM with embedded JPEG Baseline) -
        /// application/dicom; transfer-syntax=1.2.840.10008.1.2.4.90 (DICOM with embedded JPEG 2000 Lossless Only) -
        /// application/dicom; transfer-syntax=1.2.840.10008.1.2.4.91 (DICOM with embedded JPEG 2000) -
        /// application/dicom; transfer-syntax=* (DICOM with no transcoding) - application/octet-stream;
        /// transfer-syntax=1.2.840.10008.1.2.1 (raw uncompressed PixelData) - application/octet-stream;
        /// transfer-syntax=* (raw PixelData in whatever format it was uploaded in) - image/jpeg;
        /// transfer-syntax=1.2.840.10008.1.2.4.50 (Consumer JPEG) - image/png The following extensions are used for
        /// output files: - application/dicom -&amp;gt; .dcm - image/jpeg -&amp;gt; .jpg - image/png -&amp;gt; .png -
        /// application/octet-stream -&amp;gt; no extension If unspecified, the instances are exported in the original
        /// DICOM format they were uploaded in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; }

        /// <summary>
        /// The Cloud Storage destination to export to. URI for a Cloud Storage directory where the server writes the
        /// result files, in the format `gs://{bucket-id}/{path/to/destination/dir}`). If there is no trailing slash,
        /// the service appends one when composing the object path. The user is responsible for creating the Cloud
        /// Storage bucket referenced in `uri_prefix`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uriPrefix")]
        public virtual string UriPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the configuration for importing data from Cloud Storage.</summary>
    public class GoogleCloudHealthcareV1DicomGcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Points to a Cloud Storage URI containing file(s) with content only. The URI must be in the following format:
        /// `gs://{bucket_id}/{object_id}`. The URI can include wildcards in `object_id` and thus identify multiple
        /// files. Supported wildcards: * '*' to match 0 or more non-separator characters * '**' to match 0 or more
        /// characters (including separators). Must be used at the end of a path and with no other wildcards in the
        /// path. Can also be used with a file extension (such as .dcm), which imports all files with the extension in
        /// the specified directory and its sub-directories. For example, `gs://my-bucket/my-directory/**.dcm` imports
        /// all files with .dcm extensions in `my-directory/` and its sub-directories. * '?' to match 1 character. All
        /// other URI formats are invalid. Files matching the wildcard are expected to contain content only, no
        /// metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration for exporting to BigQuery.</summary>
    public class GoogleCloudHealthcareV1FhirBigQueryDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// BigQuery URI to an existing dataset, up to 2000 characters long, in the format `bq://projectId.bqDatasetId`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetUri")]
        public virtual string DatasetUri { get; set; }

        /// <summary>
        /// If this flag is `TRUE`, all tables are deleted from the dataset before the new exported tables are written.
        /// If the flag is not set and the destination dataset contains tables, the export call returns an error. If
        /// `write_disposition` is specified, this parameter is ignored. force=false is equivalent to
        /// write_disposition=WRITE_EMPTY and force=true is equivalent to write_disposition=WRITE_TRUNCATE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("force")]
        public virtual System.Nullable<bool> Force { get; set; }

        /// <summary>The configuration for the exported BigQuery schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaConfig")]
        public virtual SchemaConfig SchemaConfig { get; set; }

        /// <summary>
        /// Determines if existing data in the destination dataset is overwritten, appended to, or not written if the
        /// tables contain data. If a write_disposition is specified, the `force` parameter is ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("writeDisposition")]
        public virtual string WriteDisposition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration for exporting to Cloud Storage.</summary>
    public class GoogleCloudHealthcareV1FhirGcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// URI for a Cloud Storage directory where result files should be written, in the format of
        /// `gs://{bucket-id}/{path/to/destination/dir}`. If there is no trailing slash, the service appends one when
        /// composing the object path. The user is responsible for creating the Cloud Storage bucket referenced in
        /// `uri_prefix`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uriPrefix")]
        public virtual string UriPrefix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies the configuration for importing data from Cloud Storage.</summary>
    public class GoogleCloudHealthcareV1FhirGcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Points to a Cloud Storage URI containing file(s) to import. The URI must be in the following format:
        /// `gs://{bucket_id}/{object_id}`. The URI can include wildcards in `object_id` and thus identify multiple
        /// files. Supported wildcards: * `*` to match 0 or more non-separator characters * `**` to match 0 or more
        /// characters (including separators). Must be used at the end of a path and with no other wildcards in the
        /// path. Can also be used with a file extension (such as .ndjson), which imports all files with the extension
        /// in the specified directory and its sub-directories. For example, `gs://my-bucket/my-directory/**.ndjson`
        /// imports all files with `.ndjson` extensions in `my-directory/` and its sub-directories. * `?` to match 1
        /// character Files matching the wildcard are expected to contain content only, no metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Construct representing a logical group or a segment.</summary>
    public class GroupOrSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual SchemaGroup Group { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("segment")]
        public virtual SchemaSegment Segment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Root config message for HL7v2 schema. This contains a schema structure of groups and segments, and filters that
    /// determine which messages to apply the schema structure to.
    /// </summary>
    public class Hl7SchemaConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Map from each HL7v2 message type and trigger event pair, such as ADT_A04, to its schema configuration root
        /// group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageSchemaConfigs")]
        public virtual System.Collections.Generic.IDictionary<string, SchemaGroup> MessageSchemaConfigs { get; set; }

        /// <summary>
        /// Each VersionSource is tested and only if they all match is the schema used for the message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Collections.Generic.IList<VersionSource> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Root config for HL7v2 datatype definitions for a specific HL7v2 version.</summary>
    public class Hl7TypesConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HL7v2 type definitions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual System.Collections.Generic.IList<Type> Type { get; set; }

        /// <summary>
        /// The version selectors that this config applies to. A message must match ALL version sources to apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Collections.Generic.IList<VersionSource> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies where and whether to send notifications upon changes to a data store.</summary>
    public class Hl7V2NotificationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Restricts notifications sent for messages matching a filter. If this is empty, all messages are matched. The
        /// following syntax is available: * A string field value can be written as text inside quotation marks, for
        /// example `"query text"`. The only valid relational operation for text fields is equality (`=`), where text is
        /// searched within the field, rather than having the field be equal to the text. For example, `"Comment =
        /// great"` returns messages with `great` in the comment field. * A number field value can be written as an
        /// integer, a decimal, or an exponential. The valid relational operators for number fields are the equality
        /// operator (`=`), along with the less than/greater than operators (`&amp;lt;`, `&amp;lt;=`, `&amp;gt;`,
        /// `&amp;gt;=`). Note that there is no inequality (`!=`) operator. You can prepend the `NOT` operator to an
        /// expression to negate it. * A date field value must be written in `yyyy-mm-dd` form. Fields with date and
        /// time use the RFC3339 time format. Leading zeros are required for one-digit months and days. The valid
        /// relational operators for date fields are the equality operator (`=`) , along with the less than/greater than
        /// operators (`&amp;lt;`, `&amp;lt;=`, `&amp;gt;`, `&amp;gt;=`). Note that there is no inequality (`!=`)
        /// operator. You can prepend the `NOT` operator to an expression to negate it. * Multiple field query
        /// expressions can be combined in one query by adding `AND` or `OR` operators between the expressions. If a
        /// boolean operator appears within a quoted string, it is not treated as special, it's just another part of the
        /// character string to be matched. You can prepend the `NOT` operator to an expression to negate it. The
        /// following fields and functions are available for filtering: * `message_type`, from the MSH-9.1 field. For
        /// example, `NOT message_type = "ADT"`. * `send_date` or `sendDate`, the YYYY-MM-DD date the message was sent
        /// in the dataset's time_zone, from the MSH-7 segment. For example, `send_date &amp;lt; "2017-01-02"`. *
        /// `send_time`, the timestamp when the message was sent, using the RFC3339 time format for comparisons, from
        /// the MSH-7 segment. For example, `send_time &amp;lt; "2017-01-02T00:00:00-05:00"`. * `create_time`, the
        /// timestamp when the message was created in the HL7v2 store. Use the RFC3339 time format for comparisons. For
        /// example, `create_time &amp;lt; "2017-01-02T00:00:00-05:00"`. * `send_facility`, the care center that the
        /// message came from, from the MSH-4 segment. For example, `send_facility = "ABC"`. * `PatientId(value, type)`,
        /// which matches if the message lists a patient having an ID of the given value and type in the PID-2, PID-3,
        /// or PID-4 segments. For example, `PatientId("123456", "MRN")`. * `labels.x`, a string value of the label with
        /// key `x` as set using the Message.labels map. For example, `labels."priority"="high"`. The operator `:*` can
        /// be used to assert the existence of a label. For example, `labels."priority":*`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// The [Pub/Sub](https://cloud.google.com/pubsub/docs/) topic that notifications of changes are published on.
        /// Supplied by the client. The notification is a `PubsubMessage` with the following fields: *
        /// `PubsubMessage.Data` contains the resource name. * `PubsubMessage.MessageId` is the ID of this notification.
        /// It's guaranteed to be unique within the topic. * `PubsubMessage.PublishTime` is the time when the message
        /// was published. Note that notifications are only sent if the topic is non-empty. [Topic
        /// names](https://cloud.google.com/pubsub/docs/overview#names) must be scoped to a project. The Cloud
        /// Healthcare API service account, service-PROJECT_NUMBER@gcp-sa-healthcare.iam.gserviceaccount.com, must have
        /// publisher permissions on the given Pub/Sub topic. Not having adequate permissions causes the calls that send
        /// notifications to fail. If a notification cannot be published to Pub/Sub, errors are logged to Cloud Logging.
        /// For more information, see [Viewing error logs in Cloud
        /// Logging](https://cloud.google.com/healthcare/docs/how-tos/logging)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopic")]
        public virtual string PubsubTopic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an HL7v2 store.</summary>
    public class Hl7V2Store : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// User-supplied key-value pairs used to organize HL7v2 stores. Label keys must be between 1 and 63 characters
        /// long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression:
        /// \p{Ll}\p{Lo}{0,62} Label values are optional, must be between 1 and 63 characters long, have a UTF-8
        /// encoding of maximum 128 bytes, and must conform to the following PCRE regular expression:
        /// [\p{Ll}\p{Lo}\p{N}_-]{0,63} No more than 64 labels can be associated with a given store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Resource name of the HL7v2 store, of the form
        /// `projects/{project_id}/datasets/{dataset_id}/hl7V2Stores/{hl7v2_store_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A list of notification configs. Each configuration uses a filter to determine whether to publish a message
        /// (both Ingest &amp;amp; Create) on the corresponding notification destination. Only the message name is sent
        /// as part of the notification. Supplied by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfigs")]
        public virtual System.Collections.Generic.IList<Hl7V2NotificationConfig> NotificationConfigs { get; set; }

        /// <summary>The configuration for the parser. It determines how the server parses the messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parserConfig")]
        public virtual ParserConfig ParserConfig { get; set; }

        /// <summary>
        /// Determines whether to reject duplicate messages. A duplicate message is a message with the same raw bytes as
        /// a message that has already been ingested/created in this HL7v2 store. The default value is false, meaning
        /// that the store accepts the duplicate messages and it also returns the same ACK message in the
        /// IngestMessageResponse as has been returned previously. Note that only one resource is created in the store.
        /// When this field is set to true, CreateMessage/IngestMessage requests with a duplicate message will be
        /// rejected by the store, and IngestMessageErrorDetail returns a NACK message upon rejection.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rejectDuplicateMessage")]
        public virtual System.Nullable<bool> RejectDuplicateMessage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message that represents an arbitrary HTTP body. It should only be used for payload formats that can't be
    /// represented as JSON, such as raw binary or an HTML page. This message can be used both in streaming and
    /// non-streaming API methods in the request as well as the response. It can be used as a top-level request field,
    /// which is convenient if one wants to extract parameters from either the URL or HTTP template into the request
    /// fields and also want access to the raw HTTP body. Example: message GetResourceRequest { // A unique request id.
    /// string request_id = 1; // The raw HTTP body is bound to this field. google.api.HttpBody http_body = 2; } service
    /// ResourceService { rpc GetResource(GetResourceRequest) returns (google.api.HttpBody); rpc
    /// UpdateResource(google.api.HttpBody) returns (google.protobuf.Empty); } Example with streaming methods: service
    /// CaldavService { rpc GetCalendar(stream google.api.HttpBody) returns (stream google.api.HttpBody); rpc
    /// UpdateCalendar(stream google.api.HttpBody) returns (stream google.api.HttpBody); } Use of this type only changes
    /// how the request and response bodies are handled, all other features will continue to work unchanged.
    /// </summary>
    public class HttpBody : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HTTP Content-Type header value specifying the content type of the body.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; }

        /// <summary>The HTTP request/response body as raw binary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// Application specific response metadata. Must be set in the first response for streaming APIs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extensions")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Extensions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Raw bytes representing consent artifact content.</summary>
    public class Image : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Input only. Points to a Cloud Storage URI containing the consent artifact content. The URI must be in the
        /// following format: `gs://{bucket_id}/{object_id}`. The Cloud Healthcare API service account must have the
        /// `roles/storage.objectViewer` Cloud IAM role for this Cloud Storage location. The consent artifact content at
        /// this URI is copied to a Cloud Storage location managed by the Cloud Healthcare API. Responses to fetching
        /// requests return the consent artifact content in raw_bytes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUri")]
        public virtual string GcsUri { get; set; }

        /// <summary>
        /// Consent artifact content represented as a stream of bytes. This field is populated when returned in
        /// GetConsentArtifact response, but not included in CreateConsentArtifact and ListConsentArtifact response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawBytes")]
        public virtual string RawBytes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how to handle de-identification of image pixels.</summary>
    public class ImageConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Determines how to redact text from image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textRedactionMode")]
        public virtual string TextRedactionMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Imports data into the specified DICOM store. Returns an error if any of the files to import are not DICOM files.
    /// This API accepts duplicate DICOM instances by ignoring the newly-pushed instance. It does not overwrite.
    /// </summary>
    public class ImportDicomDataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Cloud Storage source data location and import configuration. The Cloud Healthcare Service Agent requires the
        /// `roles/storage.objectViewer` Cloud IAM roles on the Cloud Storage location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudHealthcareV1DicomGcsSource GcsSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Returns additional information in regards to a completed DICOM store import.</summary>
    public class ImportDicomDataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to import resources.</summary>
    public class ImportResourcesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The content structure in the source location. If not specified, the server treats the input source files as
        /// BUNDLE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentStructure")]
        public virtual string ContentStructure { get; set; }

        /// <summary>
        /// Cloud Storage source data location and import configuration. The Healthcare Service Agent account requires
        /// the `roles/storage.objectAdmin` role on the Cloud Storage location. Each Cloud Storage object should be a
        /// text file that contains the format specified in ContentStructure.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GoogleCloudHealthcareV1FhirGcsSource GcsSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Final response of importing resources. This structure is included in the response to describe the detailed
    /// outcome after the operation finishes successfully.
    /// </summary>
    public class ImportResourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A transformation to apply to text that is identified as a specific info_type.</summary>
    public class InfoTypeTransformation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Config for character mask.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("characterMaskConfig")]
        public virtual CharacterMaskConfig CharacterMaskConfig { get; set; }

        /// <summary>Config for crypto hash.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cryptoHashConfig")]
        public virtual CryptoHashConfig CryptoHashConfig { get; set; }

        /// <summary>Config for date shift.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateShiftConfig")]
        public virtual DateShiftConfig DateShiftConfig { get; set; }

        /// <summary>
        /// InfoTypes to apply this transformation to. If this is not specified, the transformation applies to any
        /// info_type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoTypes")]
        public virtual System.Collections.Generic.IList<string> InfoTypes { get; set; }

        /// <summary>Config for text redaction.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redactConfig")]
        public virtual RedactConfig RedactConfig { get; set; }

        /// <summary>Config for replace with InfoType.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replaceWithInfoTypeConfig")]
        public virtual ReplaceWithInfoTypeConfig ReplaceWithInfoTypeConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Ingests a message into the specified HL7v2 store.</summary>
    public class IngestMessageRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>HL7v2 message to ingest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Acknowledges that a message has been ingested into the specified HL7v2 store.</summary>
    public class IngestMessageResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>HL7v2 ACK message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hl7Ack")]
        public virtual string Hl7Ack { get; set; }

        /// <summary>Created message resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual Message Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListAttributeDefinitionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The returned Attribute definitions. The maximum number of attributes returned is determined by the value of
        /// page_size in the ListAttributeDefinitionsRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributeDefinitions")]
        public virtual System.Collections.Generic.IList<AttributeDefinition> AttributeDefinitions { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListConsentArtifactsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The returned Consent artifacts. The maximum number of artifacts returned is determined by the value of
        /// page_size in the ListConsentArtifactsRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consentArtifacts")]
        public virtual System.Collections.Generic.IList<ConsentArtifact> ConsentArtifacts { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListConsentRevisionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The returned Consent revisions. The maximum number of revisions returned is determined by the value of
        /// `page_size` in the ListConsentRevisionsRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consents")]
        public virtual System.Collections.Generic.IList<Consent> Consents { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListConsentStoresResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The returned consent stores. The maximum number of stores returned is determined by the value of page_size
        /// in the ListConsentStoresRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consentStores")]
        public virtual System.Collections.Generic.IList<ConsentStore> ConsentStores { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListConsentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The returned Consents. The maximum number of Consents returned is determined by the value of page_size in
        /// the ListConsentsRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consents")]
        public virtual System.Collections.Generic.IList<Consent> Consents { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Lists the available datasets.</summary>
    public class ListDatasetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The first page of datasets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasets")]
        public virtual System.Collections.Generic.IList<Dataset> Datasets { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Lists the DICOM stores in the given dataset.</summary>
    public class ListDicomStoresResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The returned DICOM stores. Won't be more DICOM stores than the value of page_size in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dicomStores")]
        public virtual System.Collections.Generic.IList<DicomStore> DicomStores { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Lists the FHIR stores in the given dataset.</summary>
    public class ListFhirStoresResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The returned FHIR stores. Won't be more FHIR stores than the value of page_size in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fhirStores")]
        public virtual System.Collections.Generic.IList<FhirStore> FhirStores { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Lists the HL7v2 stores in the given dataset.</summary>
    public class ListHl7V2StoresResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The returned HL7v2 stores. Won't be more HL7v2 stores than the value of page_size in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hl7V2Stores")]
        public virtual System.Collections.Generic.IList<Hl7V2Store> Hl7V2Stores { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Locations.ListLocations.</summary>
    public class ListLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of locations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<Location> Locations { get; set; }

        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Lists the messages in the specified HL7v2 store.</summary>
    public class ListMessagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The returned Messages. Won't be more Messages than the value of page_size in the request. See view for
        /// populated fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hl7V2Messages")]
        public virtual System.Collections.Generic.IList<Message> Hl7V2Messages { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class ListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListUserDataMappingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token to retrieve the next page of results, or empty if there are no more results in the list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// The returned User data mappings. The maximum number of User data mappings returned is determined by the
        /// value of page_size in the ListUserDataMappingsRequest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userDataMappings")]
        public virtual System.Collections.Generic.IList<UserDataMapping> UserDataMappings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that represents Google Cloud Platform location.</summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The friendly name for this location, typically a nearby city name. For example, "Tokyo".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Cross-service attributes for the location. For example {"cloud.googleapis.com/region": "us-east1"}
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The canonical id for this location. For example: `"us-east1"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; }

        /// <summary>Service-specific metadata. For example the available capacity at the given location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// Resource name for the location, which may vary between implementations. For example:
        /// `"projects/example-project/locations/us-east1"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A complete HL7v2 message. See [Introduction to HL7 Standards]
    /// (https://www.hl7.org/implement/standards/index.cfm?ref=common) for details on the standard.
    /// </summary>
    public class Message : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The datetime when the message was created. Set by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Raw message bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>
        /// User-supplied key-value pairs used to organize HL7v2 stores. Label keys must be between 1 and 63 characters
        /// long, have a UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression:
        /// \p{Ll}\p{Lo}{0,62} Label values are optional, must be between 1 and 63 characters long, have a UTF-8
        /// encoding of maximum 128 bytes, and must conform to the following PCRE regular expression:
        /// [\p{Ll}\p{Lo}\p{N}_-]{0,63} No more than 64 labels can be associated with a given store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The message type for this message. MSH-9.1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageType")]
        public virtual string MessageType { get; set; }

        /// <summary>
        /// Resource name of the Message, of the form
        /// `projects/{project_id}/datasets/{dataset_id}/hl7V2Stores/{hl7_v2_store_id}/messages/{message_id}`. Assigned
        /// by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The parsed version of the raw message data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parsedData")]
        public virtual ParsedData ParsedData { get; set; }

        /// <summary>All patient IDs listed in the PID-2, PID-3, and PID-4 segments of this message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("patientIds")]
        public virtual System.Collections.Generic.IList<PatientId> PatientIds { get; set; }

        /// <summary>
        /// The parsed version of the raw message data schematized according to this store's schemas and type
        /// definitions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schematizedData")]
        public virtual SchematizedData SchematizedData { get; set; }

        /// <summary>The hospital that this message came from. MSH-4.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sendFacility")]
        public virtual string SendFacility { get; set; }

        /// <summary>The datetime the sending application sent this message. MSH-7.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sendTime")]
        public virtual object SendTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies where to send notifications upon changes to a data store.</summary>
    public class NotificationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The [Pub/Sub](https://cloud.google.com/pubsub/docs/) topic that notifications of changes are published on.
        /// Supplied by the client. PubsubMessage.Data contains the resource name. PubsubMessage.MessageId is the ID of
        /// this message. It is guaranteed to be unique within the topic. PubsubMessage.PublishTime is the time at which
        /// the message was published. Notifications are only sent if the topic is non-empty. [Topic
        /// names](https://cloud.google.com/pubsub/docs/overview#names) must be scoped to a project. Cloud Healthcare
        /// API service account must have publisher permissions on the given Pub/Sub topic. Not having adequate
        /// permissions causes the calls that send notifications to fail. If a notification can't be published to
        /// Pub/Sub, errors are logged to Cloud Logging (see [Viewing error logs in Cloud
        /// Logging](https://cloud.google.com/healthcare/docs/how-tos/logging)). If the number of errors exceeds a
        /// certain rate, some aren't submitted. Note that not all operations trigger notifications, see [Configuring
        /// Pub/Sub notifications](https://cloud.google.com/healthcare/docs/how-tos/pubsub) for specific details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopic")]
        public virtual string PubsubTopic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// Service-specific metadata associated with the operation. It typically contains progress information and
        /// common metadata such as create time. Some services might not provide such metadata. Any method that returns
        /// a long-running operation should document the metadata type, if any.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The server-assigned name, which is only unique within the same service that originally returns it. If you
        /// use the default HTTP mapping, the `name` should be a resource name ending with `operations/{unique_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal response of the operation in case of success. If the original method returns no data on success,
        /// such as `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// OperationMetadata provides information about the operation execution. Returned in the long-running operation's
    /// metadata field.
    /// </summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the API method that initiated the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiMethodName")]
        public virtual string ApiMethodName { get; set; }

        /// <summary>Specifies if cancellation was requested for the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelRequested")]
        public virtual System.Nullable<bool> CancelRequested { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("counter")]
        public virtual ProgressCounter Counter { get; set; }

        /// <summary>The time at which the operation was created by the API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The time at which execution was completed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// A link to audit and error logs in the log viewer. Error logs are generated only by some operations, listed
        /// at [Viewing error logs in Cloud Logging](https://cloud.google.com/healthcare/docs/how-tos/logging).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logsUrl")]
        public virtual string LogsUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The content of a HL7v2 message in a structured format.</summary>
    public class ParsedData : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<Segment> Segments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration for the parser. It determines how the server parses the messages.</summary>
    public class ParserConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Determines whether messages with no header are allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowNullHeader")]
        public virtual System.Nullable<bool> AllowNullHeader { get; set; }

        /// <summary>Schemas used to parse messages in this store, if schematized parsing is desired.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual SchemaPackage Schema { get; set; }

        /// <summary>
        /// Byte(s) to use as the segment terminator. If this is unset, '\r' is used as segment terminator, matching the
        /// HL7 version 2 specification.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentTerminator")]
        public virtual string SegmentTerminator { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A patient identifier and associated type.</summary>
    public class PatientId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ID type. For example, MRN or NHS.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The patient's unique identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members` to a single `role`. Members can
    /// be user accounts, service accounts, Google groups, and domains (such as G Suite). A `role` is a named list of
    /// permissions; each `role` can be an IAM predefined role or a user-created custom role. For some types of Google
    /// Cloud resources, a `binding` can also specify a `condition`, which is a logical expression that allows access to
    /// a resource only if the expression evaluates to `true`. A condition can add constraints based on attributes of
    /// the request, the resource, or both. To learn which resources support conditions in their IAM policies, see the
    /// [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** {
    /// "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') - etag: BwWWja0YfJA= - version: 3 For a description of IAM and its
    /// features, see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members` to a `role`. Optionally, may specify a `condition` that determines how and
        /// when the `bindings` are applied. Each of the `bindings` must contain at least one member.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; }

        /// <summary>
        /// `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy
        /// from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform policy updates in order to avoid race conditions: An `etag` is returned
        /// in the response to `getIamPolicy`, and systems are expected to put that etag in the request to
        /// `setIamPolicy` to ensure that their change will be applied to the same version of the policy. **Important:**
        /// If you use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit
        /// this field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Specifies the format of the policy. Valid values are `0`, `1`, and `3`. Requests that specify an invalid
        /// value are rejected. Any operation that affects conditional role bindings must specify version `3`. This
        /// requirement applies to the following operations: * Getting a policy that includes a conditional role binding
        /// * Adding a conditional role binding to a policy * Changing a conditional role binding in a policy * Removing
        /// any role binding, with or without a condition, from a policy that includes conditions **Important:** If you
        /// use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit this
        /// field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost. If a policy does not include any conditions, operations on
        /// that policy may specify any valid version or leave the field unset. To learn which resources support
        /// conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }
    }

    /// <summary>ProgressCounter provides counters to describe an operation's progress.</summary>
    public class ProgressCounter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of units that failed in the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("failure")]
        public virtual System.Nullable<long> Failure { get; set; }

        /// <summary>The number of units that are pending in the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pending")]
        public virtual System.Nullable<long> Pending { get; set; }

        /// <summary>The number of units that succeeded in the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("success")]
        public virtual System.Nullable<long> Success { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Queries all data_ids that are consented for a given use in the given consent store and writes them to a
    /// specified destination. The returned Operation includes a progress counter for the number of User data mappings
    /// processed. Errors are logged to Cloud Logging (see [Viewing error logs in Cloud Logging]
    /// (https://cloud.google.com/healthcare/docs/how-tos/logging) and [QueryAccessibleData] for a sample log entry).
    /// </summary>
    public class QueryAccessibleDataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The Cloud Storage destination. The Cloud Healthcare API service account must have the
        /// `roles/storage.objectAdmin` Cloud IAM role for this Cloud Storage location.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GoogleCloudHealthcareV1ConsentGcsDestination GcsDestination { get; set; }

        /// <summary>The values of request attributes associated with this access request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestAttributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> RequestAttributes { get; set; }

        /// <summary>
        /// Optional. The values of resource attributes associated with the type of resources being requested. If no
        /// values are specified, then all resource types are included in the output.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceAttributes")]
        public virtual System.Collections.Generic.IDictionary<string, string> ResourceAttributes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Response for successful QueryAccessibleData operations. This structure is included in the response upon
    /// operation completion.
    /// </summary>
    public class QueryAccessibleDataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// List of files, each of which contains a list of data_id(s) that are consented for a specified use in the
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsUris")]
        public virtual System.Collections.Generic.IList<string> GcsUris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Define how to redact sensitive values. Default behaviour is erase. For example, "My name is Jane." becomes "My
    /// name is ."
    /// </summary>
    public class RedactConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Rejects the latest revision of the specified Consent by committing a new revision with `state` updated to
    /// `REJECTED`. If the latest revision of the given Consent is in the `REJECTED` state, no new revision is
    /// committed.
    /// </summary>
    public class RejectConsentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The resource name of the Consent artifact that contains documentation of the user's rejection of
        /// the draft Consent, of the form
        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consentArtifacts/{consent_artifact_id}`.
        /// If the draft Consent had a Consent artifact, this Consent artifact overwrites it.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consentArtifact")]
        public virtual string ConsentArtifact { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// When using the INSPECT_AND_TRANSFORM action, each match is replaced with the name of the info_type. For example,
    /// "My name is Jane" becomes "My name is [PERSON_NAME]." The TRANSFORM action is equivalent to redacting.
    /// </summary>
    public class ReplaceWithInfoTypeConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of FHIR resources.</summary>
    public class Resources : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of resources IDs. For example, "Patient/1234".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<string> ResourcesValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The consent evaluation result for a single `data_id`.</summary>
    public class Result : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource names of all evaluated Consents mapped to their evaluation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consentDetails")]
        public virtual System.Collections.Generic.IDictionary<string, ConsentEvaluation> ConsentDetails { get; set; }

        /// <summary>Whether the resource is consented for the given use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consented")]
        public virtual System.Nullable<bool> Consented { get; set; }

        /// <summary>The unique identifier of the evaluated resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataId")]
        public virtual string DataId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Revokes the latest revision of the specified Consent by committing a new revision with `state` updated to
    /// `REVOKED`. If the latest revision of the given Consent is in the `REVOKED` state, no new revision is committed.
    /// </summary>
    public class RevokeConsentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The resource name of the Consent artifact that contains proof of the user's revocation of the
        /// Consent, of the form
        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/consentArtifacts/{consent_artifact_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consentArtifact")]
        public virtual string ConsentArtifact { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for the FHIR BigQuery schema. Determines how the server generates the schema.</summary>
    public class SchemaConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The depth for all recursive structures in the output analytics schema. For example, `concept` in the
        /// CodeSystem resource is a recursive structure; when the depth is 2, the CodeSystem table will have a column
        /// called `concept.concept` but not `concept.concept.concept`. If not specified or set to 0, the server will
        /// use the default value 2. The maximum depth allowed is 5.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recursiveStructureDepth")]
        public virtual System.Nullable<long> RecursiveStructureDepth { get; set; }

        /// <summary>Specifies the output schema type. Schema type is required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaType")]
        public virtual string SchemaType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An HL7v2 logical group construct.</summary>
    public class SchemaGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True indicates that this is a choice group, meaning that only one of its segments can exist in a given
        /// message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("choice")]
        public virtual System.Nullable<bool> Choice { get; set; }

        /// <summary>The maximum number of times this group can be repeated. 0 or -1 means unbounded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxOccurs")]
        public virtual System.Nullable<int> MaxOccurs { get; set; }

        /// <summary>Nested groups and/or segments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<GroupOrSegment> Members { get; set; }

        /// <summary>The minimum number of times this group must be present/repeated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minOccurs")]
        public virtual System.Nullable<int> MinOccurs { get; set; }

        /// <summary>The name of this group. For example, "ORDER_DETAIL".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A schema package contains a set of schemas and type definitions.</summary>
    public class SchemaPackage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Flag to ignore all min_occurs restrictions in the schema. This means that incoming messages can omit any
        /// group, segment, field, component, or subcomponent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ignoreMinOccurs")]
        public virtual System.Nullable<bool> IgnoreMinOccurs { get; set; }

        /// <summary>
        /// Schema configs that are layered based on their VersionSources that match the incoming message. Schema
        /// configs present in higher indices override those in lower indices with the same message type and trigger
        /// event if their VersionSources all match an incoming message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemas")]
        public virtual System.Collections.Generic.IList<Hl7SchemaConfig> Schemas { get; set; }

        /// <summary>Determines how messages that fail to parse are handled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schematizedParsingType")]
        public virtual string SchematizedParsingType { get; set; }

        /// <summary>
        /// Schema type definitions that are layered based on their VersionSources that match the incoming message. Type
        /// definitions present in higher indices override those in lower indices with the same type name if their
        /// VersionSources all match an incoming message.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("types")]
        public virtual System.Collections.Generic.IList<Hl7TypesConfig> Types { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An HL7v2 Segment.</summary>
    public class SchemaSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum number of times this segment can be present in this group. 0 or -1 means unbounded.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxOccurs")]
        public virtual System.Nullable<int> MaxOccurs { get; set; }

        /// <summary>The minimum number of times this segment can be present in this group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minOccurs")]
        public virtual System.Nullable<int> MinOccurs { get; set; }

        /// <summary>The Segment type. For example, "PID".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The content of an HL7v2 message in a structured format as specified by a schema.</summary>
    public class SchematizedData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>JSON output of the parser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>The error output of the parser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual string Error { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to search the resources in the specified FHIR store.</summary>
    public class SearchResourcesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The FHIR resource type to search, such as Patient or Observation. For a complete list, see the FHIR Resource
        /// Index ([DSTU2](http://hl7.org/implement/standards/fhir/DSTU2/resourcelist.html),
        /// [STU3](http://hl7.org/implement/standards/fhir/STU3/resourcelist.html),
        /// [R4](http://hl7.org/implement/standards/fhir/R4/resourcelist.html)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A segment in a structured format.</summary>
    public class Segment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A mapping from the positional location to the value. The key string uses zero-based indexes separated by
        /// dots to identify Fields, components and sub-components. A bracket notation is also used to identify
        /// different instances of a repeated field. Regex for key: (\d+)(\[\d+\])?(.\d+)?(.\d+)? Examples of (key,
        /// value) pairs: * (0.1, "hemoglobin") denotes that the first component of Field 0 has the value "hemoglobin".
        /// * (1.1.2, "CBC") denotes that the second sub-component of the first component of Field 1 has the value
        /// "CBC". * (1[0].1, "HbA1c") denotes that the first component of the first Instance of Field 1, which is
        /// repeated, has the value "HbA1c".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IDictionary<string, string> Fields { get; set; }

        /// <summary>A string that indicates the type of segment. For example, EVN or PID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segmentId")]
        public virtual string SegmentId { get; set; }

        /// <summary>
        /// Set ID for segments that can be in a set. This can be empty if it's missing or isn't applicable.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setId")]
        public virtual string SetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>
        /// OPTIONAL: A FieldMask specifying which fields of the policy to modify. Only the fields in the mask will be
        /// modified. If no mask is provided, the following default mask is used: `paths: "bindings, etag"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>User signature.</summary>
    public class Signature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. An image of the user's signature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Image Image { get; set; }

        /// <summary>
        /// Optional. Metadata associated with the user's signature. For example, the user's name or the user's title.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>Optional. Timestamp of the signature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatureTime")]
        public virtual object SignatureTime { get; set; }

        /// <summary>Required. User's UUID provided by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains configuration for streaming FHIR export.</summary>
    public class StreamConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The destination BigQuery structure that contains both the dataset location and corresponding schema config.
        /// The output is organized in one table per resource type. The server reuses the existing tables (if any) that
        /// are named after the resource types. For example, "Patient", "Observation". When there is no existing table
        /// for a given resource type, the server attempts to create one. When a table schema doesn't align with the
        /// schema config, either because of existing incompatible schema or out of band incompatible modification, the
        /// server does not stream in new data. BigQuery imposes a 1 MB limit on streaming insert row size, therefore
        /// any resource mutation that generates more than 1 MB of BigQuery data is not streamed. One resolution in this
        /// case is to delete the incompatible table and let the server recreate one, though the newly created table
        /// only contains data after the table recreation. Results are appended to the corresponding BigQuery tables.
        /// Different versions of the same resource are distinguishable by the meta.versionId and meta.lastUpdated
        /// columns. The operation (CREATE/UPDATE/DELETE) that results in the new version is recorded in the meta.tag.
        /// The tables contain all historical resource versions since streaming was enabled. For query convenience, the
        /// server also creates one view per table of the same name containing only the current resource version. The
        /// streamed data in the BigQuery dataset is not guaranteed to be completely unique. The combination of the id
        /// and meta.versionId columns should ideally identify a single unique row. But in rare cases, duplicates may
        /// exist. At query time, users may use the SQL select statement to keep only one of the duplicate rows given an
        /// id and meta.versionId pair. Alternatively, the server created view mentioned above also filters out
        /// duplicates. If a resource mutation cannot be streamed to BigQuery, errors are logged to Cloud Logging. For
        /// more information, see [Viewing error logs in Cloud
        /// Logging](https://cloud.google.com/healthcare/docs/how-tos/logging)).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigqueryDestination")]
        public virtual GoogleCloudHealthcareV1FhirBigQueryDestination BigqueryDestination { get; set; }

        /// <summary>
        /// Supply a FHIR resource type (such as "Patient" or "Observation"). See
        /// https://www.hl7.org/fhir/valueset-resource-types.html for a list of all FHIR resource types. The server
        /// treats an empty list as an intent to stream all the supported resource types in this FHIR store.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceTypes")]
        public virtual System.Collections.Generic.IList<string> ResourceTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>List of tags to be filtered.</summary>
    public class TagFilterList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Tags to be filtered. Tags must be DICOM Data Elements, File Meta Elements, or Directory Structuring
        /// Elements, as defined at: http://dicom.nema.org/medical/dicom/current/output/html/part06.html#table_6-1,.
        /// They may be provided by "Keyword" or "Tag". For example "PatientID", "00100010".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tags")]
        public virtual System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as '*' or 'storage.*')
        /// are not allowed. For more information see [IAM
        /// Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class TextConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The transformations to apply to the detected data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transformations")]
        public virtual System.Collections.Generic.IList<InfoTypeTransformation> Transformations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A type definition for some HL7v2 type (incl. Segments and Datatypes).</summary>
    public class Type : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The (sub) fields this type has (if not primitive).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<Field> Fields { get; set; }

        /// <summary>
        /// The name of this type. This would be the segment or datatype name. For example, "PID" or "XPN".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// If this is a primitive type then this field is the type of the primitive For example, STRING. Leave
        /// unspecified for composite types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primitive")]
        public virtual string Primitive { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Maps a resource to the associated user and Attributes.</summary>
    public class UserDataMapping : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Indicates the time when this mapping was archived.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveTime")]
        public virtual object ArchiveTime { get; set; }

        /// <summary>Output only. Indicates whether this mapping is archived.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archived")]
        public virtual System.Nullable<bool> Archived { get; set; }

        /// <summary>Required. A unique identifier for the mapped resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataId")]
        public virtual string DataId { get; set; }

        /// <summary>
        /// Resource name of the User data mapping, of the form
        /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}/consentStores/{consent_store_id}/userDataMappings/{user_data_mapping_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Attributes of the resource. Only explicitly set attributes are displayed here. Attribute definitions with
        /// defaults set implicitly apply to these User data mappings. Attributes listed here must be single valued,
        /// that is, exactly one value is specified for the field "values" in each Attribute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceAttributes")]
        public virtual System.Collections.Generic.IList<Attribute> ResourceAttributes { get; set; }

        /// <summary>Required. User's UUID provided by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a selector for extracting and matching an MSH field to a value.</summary>
    public class VersionSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The field to extract from the MSH segment. For example, "3.1" or "18[1].1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mshField")]
        public virtual string MshField { get; set; }

        /// <summary>The value to match with the field. For example, "My Application Name" or "2.3".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
