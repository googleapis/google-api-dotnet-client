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

namespace Google.Apis.Fitness.v1
{
    /// <summary>The Fitness Service.</summary>
    public class FitnessService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public FitnessService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public FitnessService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Users = new UsersResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "fitness";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://fitness.googleapis.com/fitness/v1/users/";
        #else
            "https://fitness.googleapis.com/fitness/v1/users/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "fitness/v1/users/";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://fitness.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Fitness API.</summary>
        public class Scope
        {
            /// <summary>Use Google Fit to see and store your physical activity data</summary>
            public static string FitnessActivityRead = "https://www.googleapis.com/auth/fitness.activity.read";

            /// <summary>Add to your Google Fit physical activity data</summary>
            public static string FitnessActivityWrite = "https://www.googleapis.com/auth/fitness.activity.write";

            /// <summary>
            /// See info about your blood glucose in Google Fit. I consent to Google sharing my blood glucose
            /// information with this app.
            /// </summary>
            public static string FitnessBloodGlucoseRead = "https://www.googleapis.com/auth/fitness.blood_glucose.read";

            /// <summary>
            /// Add info about your blood glucose to Google Fit. I consent to Google using my blood glucose information
            /// with this app.
            /// </summary>
            public static string FitnessBloodGlucoseWrite = "https://www.googleapis.com/auth/fitness.blood_glucose.write";

            /// <summary>
            /// See info about your blood pressure in Google Fit. I consent to Google sharing my blood pressure
            /// information with this app.
            /// </summary>
            public static string FitnessBloodPressureRead = "https://www.googleapis.com/auth/fitness.blood_pressure.read";

            /// <summary>
            /// Add info about your blood pressure in Google Fit. I consent to Google using my blood pressure
            /// information with this app.
            /// </summary>
            public static string FitnessBloodPressureWrite = "https://www.googleapis.com/auth/fitness.blood_pressure.write";

            /// <summary>See info about your body measurements and heart rate in Google Fit</summary>
            public static string FitnessBodyRead = "https://www.googleapis.com/auth/fitness.body.read";

            /// <summary>Add info about your body measurements and heart rate to Google Fit</summary>
            public static string FitnessBodyWrite = "https://www.googleapis.com/auth/fitness.body.write";

            /// <summary>
            /// See info about your body temperature in Google Fit. I consent to Google sharing my body temperature
            /// information with this app.
            /// </summary>
            public static string FitnessBodyTemperatureRead = "https://www.googleapis.com/auth/fitness.body_temperature.read";

            /// <summary>
            /// Add to info about your body temperature in Google Fit. I consent to Google using my body temperature
            /// information with this app.
            /// </summary>
            public static string FitnessBodyTemperatureWrite = "https://www.googleapis.com/auth/fitness.body_temperature.write";

            /// <summary>
            /// See your heart rate data in Google Fit. I consent to Google sharing my heart rate information with this
            /// app.
            /// </summary>
            public static string FitnessHeartRateRead = "https://www.googleapis.com/auth/fitness.heart_rate.read";

            /// <summary>
            /// Add to your heart rate data in Google Fit. I consent to Google using my heart rate information with this
            /// app.
            /// </summary>
            public static string FitnessHeartRateWrite = "https://www.googleapis.com/auth/fitness.heart_rate.write";

            /// <summary>See your Google Fit speed and distance data</summary>
            public static string FitnessLocationRead = "https://www.googleapis.com/auth/fitness.location.read";

            /// <summary>Add to your Google Fit location data</summary>
            public static string FitnessLocationWrite = "https://www.googleapis.com/auth/fitness.location.write";

            /// <summary>See info about your nutrition in Google Fit</summary>
            public static string FitnessNutritionRead = "https://www.googleapis.com/auth/fitness.nutrition.read";

            /// <summary>Add to info about your nutrition in Google Fit</summary>
            public static string FitnessNutritionWrite = "https://www.googleapis.com/auth/fitness.nutrition.write";

            /// <summary>
            /// See info about your oxygen saturation in Google Fit. I consent to Google sharing my oxygen saturation
            /// information with this app.
            /// </summary>
            public static string FitnessOxygenSaturationRead = "https://www.googleapis.com/auth/fitness.oxygen_saturation.read";

            /// <summary>
            /// Add info about your oxygen saturation in Google Fit. I consent to Google using my oxygen saturation
            /// information with this app.
            /// </summary>
            public static string FitnessOxygenSaturationWrite = "https://www.googleapis.com/auth/fitness.oxygen_saturation.write";

            /// <summary>
            /// See info about your reproductive health in Google Fit. I consent to Google sharing my reproductive
            /// health information with this app.
            /// </summary>
            public static string FitnessReproductiveHealthRead = "https://www.googleapis.com/auth/fitness.reproductive_health.read";

            /// <summary>
            /// Add info about your reproductive health in Google Fit. I consent to Google using my reproductive health
            /// information with this app.
            /// </summary>
            public static string FitnessReproductiveHealthWrite = "https://www.googleapis.com/auth/fitness.reproductive_health.write";

            /// <summary>
            /// See your sleep data in Google Fit. I consent to Google sharing my sleep information with this app.
            /// </summary>
            public static string FitnessSleepRead = "https://www.googleapis.com/auth/fitness.sleep.read";

            /// <summary>
            /// Add to your sleep data in Google Fit. I consent to Google using my sleep information with this app.
            /// </summary>
            public static string FitnessSleepWrite = "https://www.googleapis.com/auth/fitness.sleep.write";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Fitness API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Use Google Fit to see and store your physical activity data</summary>
            public const string FitnessActivityRead = "https://www.googleapis.com/auth/fitness.activity.read";

            /// <summary>Add to your Google Fit physical activity data</summary>
            public const string FitnessActivityWrite = "https://www.googleapis.com/auth/fitness.activity.write";

            /// <summary>
            /// See info about your blood glucose in Google Fit. I consent to Google sharing my blood glucose
            /// information with this app.
            /// </summary>
            public const string FitnessBloodGlucoseRead = "https://www.googleapis.com/auth/fitness.blood_glucose.read";

            /// <summary>
            /// Add info about your blood glucose to Google Fit. I consent to Google using my blood glucose information
            /// with this app.
            /// </summary>
            public const string FitnessBloodGlucoseWrite = "https://www.googleapis.com/auth/fitness.blood_glucose.write";

            /// <summary>
            /// See info about your blood pressure in Google Fit. I consent to Google sharing my blood pressure
            /// information with this app.
            /// </summary>
            public const string FitnessBloodPressureRead = "https://www.googleapis.com/auth/fitness.blood_pressure.read";

            /// <summary>
            /// Add info about your blood pressure in Google Fit. I consent to Google using my blood pressure
            /// information with this app.
            /// </summary>
            public const string FitnessBloodPressureWrite = "https://www.googleapis.com/auth/fitness.blood_pressure.write";

            /// <summary>See info about your body measurements and heart rate in Google Fit</summary>
            public const string FitnessBodyRead = "https://www.googleapis.com/auth/fitness.body.read";

            /// <summary>Add info about your body measurements and heart rate to Google Fit</summary>
            public const string FitnessBodyWrite = "https://www.googleapis.com/auth/fitness.body.write";

            /// <summary>
            /// See info about your body temperature in Google Fit. I consent to Google sharing my body temperature
            /// information with this app.
            /// </summary>
            public const string FitnessBodyTemperatureRead = "https://www.googleapis.com/auth/fitness.body_temperature.read";

            /// <summary>
            /// Add to info about your body temperature in Google Fit. I consent to Google using my body temperature
            /// information with this app.
            /// </summary>
            public const string FitnessBodyTemperatureWrite = "https://www.googleapis.com/auth/fitness.body_temperature.write";

            /// <summary>
            /// See your heart rate data in Google Fit. I consent to Google sharing my heart rate information with this
            /// app.
            /// </summary>
            public const string FitnessHeartRateRead = "https://www.googleapis.com/auth/fitness.heart_rate.read";

            /// <summary>
            /// Add to your heart rate data in Google Fit. I consent to Google using my heart rate information with this
            /// app.
            /// </summary>
            public const string FitnessHeartRateWrite = "https://www.googleapis.com/auth/fitness.heart_rate.write";

            /// <summary>See your Google Fit speed and distance data</summary>
            public const string FitnessLocationRead = "https://www.googleapis.com/auth/fitness.location.read";

            /// <summary>Add to your Google Fit location data</summary>
            public const string FitnessLocationWrite = "https://www.googleapis.com/auth/fitness.location.write";

            /// <summary>See info about your nutrition in Google Fit</summary>
            public const string FitnessNutritionRead = "https://www.googleapis.com/auth/fitness.nutrition.read";

            /// <summary>Add to info about your nutrition in Google Fit</summary>
            public const string FitnessNutritionWrite = "https://www.googleapis.com/auth/fitness.nutrition.write";

            /// <summary>
            /// See info about your oxygen saturation in Google Fit. I consent to Google sharing my oxygen saturation
            /// information with this app.
            /// </summary>
            public const string FitnessOxygenSaturationRead = "https://www.googleapis.com/auth/fitness.oxygen_saturation.read";

            /// <summary>
            /// Add info about your oxygen saturation in Google Fit. I consent to Google using my oxygen saturation
            /// information with this app.
            /// </summary>
            public const string FitnessOxygenSaturationWrite = "https://www.googleapis.com/auth/fitness.oxygen_saturation.write";

            /// <summary>
            /// See info about your reproductive health in Google Fit. I consent to Google sharing my reproductive
            /// health information with this app.
            /// </summary>
            public const string FitnessReproductiveHealthRead = "https://www.googleapis.com/auth/fitness.reproductive_health.read";

            /// <summary>
            /// Add info about your reproductive health in Google Fit. I consent to Google using my reproductive health
            /// information with this app.
            /// </summary>
            public const string FitnessReproductiveHealthWrite = "https://www.googleapis.com/auth/fitness.reproductive_health.write";

            /// <summary>
            /// See your sleep data in Google Fit. I consent to Google sharing my sleep information with this app.
            /// </summary>
            public const string FitnessSleepRead = "https://www.googleapis.com/auth/fitness.sleep.read";

            /// <summary>
            /// Add to your sleep data in Google Fit. I consent to Google using my sleep information with this app.
            /// </summary>
            public const string FitnessSleepWrite = "https://www.googleapis.com/auth/fitness.sleep.write";
        }

        /// <summary>Gets the Users resource.</summary>
        public virtual UsersResource Users { get; }
    }

    /// <summary>A base abstract class for Fitness requests.</summary>
    public abstract class FitnessBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new FitnessBaseServiceRequest instance.</summary>
        protected FitnessBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Fitness parameter list.</summary>
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
            DataSources = new DataSourcesResource(service);
            Dataset = new DatasetResource(service);
            Sessions = new SessionsResource(service);
        }

        /// <summary>Gets the DataSources resource.</summary>
        public virtual DataSourcesResource DataSources { get; }

        /// <summary>The "dataSources" collection of methods.</summary>
        public class DataSourcesResource
        {
            private const string Resource = "dataSources";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DataSourcesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                DataPointChanges = new DataPointChangesResource(service);
                Datasets = new DatasetsResource(service);
            }

            /// <summary>Gets the DataPointChanges resource.</summary>
            public virtual DataPointChangesResource DataPointChanges { get; }

            /// <summary>The "dataPointChanges" collection of methods.</summary>
            public class DataPointChangesResource
            {
                private const string Resource = "dataPointChanges";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public DataPointChangesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Queries for user's data point changes for a particular data source.</summary>
                /// <param name="userId">
                /// List data points for the person identified. Use me to indicate the authenticated user. Only me is
                /// supported at this time.
                /// </param>
                /// <param name="dataSourceId">The data stream ID of the data source that created the dataset.</param>
                public virtual ListRequest List(string userId, string dataSourceId)
                {
                    return new ListRequest(service, userId, dataSourceId);
                }

                /// <summary>Queries for user's data point changes for a particular data source.</summary>
                public class ListRequest : FitnessBaseServiceRequest<Google.Apis.Fitness.v1.Data.ListDataPointChangesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string userId, string dataSourceId) : base(service)
                    {
                        UserId = userId;
                        DataSourceId = dataSourceId;
                        InitParameters();
                    }

                    /// <summary>
                    /// List data points for the person identified. Use me to indicate the authenticated user. Only me
                    /// is supported at this time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>The data stream ID of the data source that created the dataset.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("dataSourceId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string DataSourceId { get; private set; }

                    /// <summary>
                    /// If specified, no more than this many data point changes will be included in the response.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> Limit { get; set; }

                    /// <summary>
                    /// The continuation token, which is used to page through large result sets. To get the next page of
                    /// results, set this parameter to the value of nextPageToken from the previous response.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "{userId}/dataSources/{dataSourceId}/dataPointChanges";

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
                        RequestParameters.Add("dataSourceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dataSourceId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                        {
                            Name = "limit",
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
                }

                /// <summary>
                /// Performs an inclusive delete of all data points whose start and end times have any overlap with the
                /// time range specified by the dataset ID. For most data types, the entire data point will be deleted.
                /// For data types where the time span represents a consistent value (such as
                /// com.google.activity.segment), and a data point straddles either end point of the dataset, only the
                /// overlapping portion of the data point will be deleted.
                /// </summary>
                /// <param name="userId">
                /// Delete a dataset for the person identified. Use me to indicate the authenticated user. Only me is
                /// supported at this time.
                /// </param>
                /// <param name="dataSourceId">The data stream ID of the data source that created the dataset.</param>
                /// <param name="datasetId">
                /// Dataset identifier that is a composite of the minimum data point start time and maximum data point
                /// end time represented as nanoseconds from the epoch. The ID is formatted like: "startTime-endTime"
                /// where startTime and endTime are 64 bit integers.
                /// </param>
                public virtual DeleteRequest Delete(string userId, string dataSourceId, string datasetId)
                {
                    return new DeleteRequest(service, userId, dataSourceId, datasetId);
                }

                /// <summary>
                /// Performs an inclusive delete of all data points whose start and end times have any overlap with the
                /// time range specified by the dataset ID. For most data types, the entire data point will be deleted.
                /// For data types where the time span represents a consistent value (such as
                /// com.google.activity.segment), and a data point straddles either end point of the dataset, only the
                /// overlapping portion of the data point will be deleted.
                /// </summary>
                public class DeleteRequest : FitnessBaseServiceRequest<string>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string userId, string dataSourceId, string datasetId) : base(service)
                    {
                        UserId = userId;
                        DataSourceId = dataSourceId;
                        DatasetId = datasetId;
                        InitParameters();
                    }

                    /// <summary>
                    /// Delete a dataset for the person identified. Use me to indicate the authenticated user. Only me
                    /// is supported at this time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>The data stream ID of the data source that created the dataset.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("dataSourceId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string DataSourceId { get; private set; }

                    /// <summary>
                    /// Dataset identifier that is a composite of the minimum data point start time and maximum data
                    /// point end time represented as nanoseconds from the epoch. The ID is formatted like:
                    /// "startTime-endTime" where startTime and endTime are 64 bit integers.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string DatasetId { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "{userId}/dataSources/{dataSourceId}/datasets/{datasetId}";

                    /// <summary>Initializes Delete parameter list.</summary>
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
                        RequestParameters.Add("dataSourceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dataSourceId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "datasetId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Returns a dataset containing all data points whose start and end times overlap with the specified
                /// range of the dataset minimum start time and maximum end time. Specifically, any data point whose
                /// start time is less than or equal to the dataset end time and whose end time is greater than or equal
                /// to the dataset start time.
                /// </summary>
                /// <param name="userId">
                /// Retrieve a dataset for the person identified. Use me to indicate the authenticated user. Only me is
                /// supported at this time.
                /// </param>
                /// <param name="dataSourceId">The data stream ID of the data source that created the dataset.</param>
                /// <param name="datasetId">
                /// Dataset identifier that is a composite of the minimum data point start time and maximum data point
                /// end time represented as nanoseconds from the epoch. The ID is formatted like: "startTime-endTime"
                /// where startTime and endTime are 64 bit integers.
                /// </param>
                public virtual GetRequest Get(string userId, string dataSourceId, string datasetId)
                {
                    return new GetRequest(service, userId, dataSourceId, datasetId);
                }

                /// <summary>
                /// Returns a dataset containing all data points whose start and end times overlap with the specified
                /// range of the dataset minimum start time and maximum end time. Specifically, any data point whose
                /// start time is less than or equal to the dataset end time and whose end time is greater than or equal
                /// to the dataset start time.
                /// </summary>
                public class GetRequest : FitnessBaseServiceRequest<Google.Apis.Fitness.v1.Data.Dataset>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string userId, string dataSourceId, string datasetId) : base(service)
                    {
                        UserId = userId;
                        DataSourceId = dataSourceId;
                        DatasetId = datasetId;
                        InitParameters();
                    }

                    /// <summary>
                    /// Retrieve a dataset for the person identified. Use me to indicate the authenticated user. Only me
                    /// is supported at this time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>The data stream ID of the data source that created the dataset.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("dataSourceId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string DataSourceId { get; private set; }

                    /// <summary>
                    /// Dataset identifier that is a composite of the minimum data point start time and maximum data
                    /// point end time represented as nanoseconds from the epoch. The ID is formatted like:
                    /// "startTime-endTime" where startTime and endTime are 64 bit integers.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string DatasetId { get; private set; }

                    /// <summary>
                    /// If specified, no more than this many data points will be included in the dataset. If there are
                    /// more data points in the dataset, nextPageToken will be set in the dataset response. The limit is
                    /// applied from the end of the time range. That is, if pageToken is absent, the limit most recent
                    /// data points will be returned.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> Limit { get; set; }

                    /// <summary>
                    /// The continuation token, which is used to page through large datasets. To get the next page of a
                    /// dataset, set this parameter to the value of nextPageToken from the previous response. Each
                    /// subsequent call will yield a partial dataset with data point end timestamps that are strictly
                    /// smaller than those in the previous partial response.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "{userId}/dataSources/{dataSourceId}/datasets/{datasetId}";

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
                        RequestParameters.Add("dataSourceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dataSourceId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "datasetId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                        {
                            Name = "limit",
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
                /// Adds data points to a dataset. The dataset need not be previously created. All points within the
                /// given dataset will be returned with subsquent calls to retrieve this dataset. Data points can belong
                /// to more than one dataset. This method does not use patch semantics: the data points provided are
                /// merely inserted, with no existing data replaced.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="userId">
                /// Patch a dataset for the person identified. Use me to indicate the authenticated user. Only me is
                /// supported at this time.
                /// </param>
                /// <param name="dataSourceId">The data stream ID of the data source that created the dataset.</param>
                /// <param name="datasetId">This field is not used, and can be safely omitted.</param>
                public virtual PatchRequest Patch(Google.Apis.Fitness.v1.Data.Dataset body, string userId, string dataSourceId, string datasetId)
                {
                    return new PatchRequest(service, body, userId, dataSourceId, datasetId);
                }

                /// <summary>
                /// Adds data points to a dataset. The dataset need not be previously created. All points within the
                /// given dataset will be returned with subsquent calls to retrieve this dataset. Data points can belong
                /// to more than one dataset. This method does not use patch semantics: the data points provided are
                /// merely inserted, with no existing data replaced.
                /// </summary>
                public class PatchRequest : FitnessBaseServiceRequest<Google.Apis.Fitness.v1.Data.Dataset>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Fitness.v1.Data.Dataset body, string userId, string dataSourceId, string datasetId) : base(service)
                    {
                        UserId = userId;
                        DataSourceId = dataSourceId;
                        DatasetId = datasetId;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Patch a dataset for the person identified. Use me to indicate the authenticated user. Only me is
                    /// supported at this time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string UserId { get; private set; }

                    /// <summary>The data stream ID of the data source that created the dataset.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("dataSourceId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string DataSourceId { get; private set; }

                    /// <summary>This field is not used, and can be safely omitted.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("datasetId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string DatasetId { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Fitness.v1.Data.Dataset Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "{userId}/dataSources/{dataSourceId}/datasets/{datasetId}";

                    /// <summary>Initializes Patch parameter list.</summary>
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
                        RequestParameters.Add("dataSourceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "dataSourceId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("datasetId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "datasetId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>
            /// Creates a new data source that is unique across all data sources belonging to this user. A data source
            /// is a unique source of sensor data. Data sources can expose raw data coming from hardware sensors on
            /// local or companion devices. They can also expose derived data, created by transforming or merging other
            /// data sources. Multiple data sources can exist for the same data type. Every data point in every dataset
            /// inserted into or read from the Fitness API has an associated data source. Each data source produces a
            /// unique stream of dataset updates, with a unique data source identifier. Not all changes to data source
            /// affect the data stream ID, so that data collected by updated versions of the same application/device can
            /// still be considered to belong to the same data source. Data sources are identified using a string
            /// generated by the server, based on the contents of the source being created. The dataStreamId field
            /// should not be set when invoking this method. It will be automatically generated by the server with the
            /// correct format. If a dataStreamId is set, it must match the format that the server would generate. This
            /// format is a combination of some fields from the data source, and has a specific order. If it doesn't
            /// match, the request will fail with an error. Specifying a DataType which is not a known type (beginning
            /// with "com.google.") will create a DataSource with a *custom data type*. Custom data types are only
            /// readable by the application that created them. Custom data types are *deprecated*; use standard data
            /// types instead. In addition to the data source fields included in the data source ID, the developer
            /// project number that is authenticated when creating the data source is included. This developer project
            /// number is obfuscated when read by any other developer reading public data types.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// Create the data source for the person identified. Use me to indicate the authenticated user. Only me is
            /// supported at this time.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Fitness.v1.Data.DataSource body, string userId)
            {
                return new CreateRequest(service, body, userId);
            }

            /// <summary>
            /// Creates a new data source that is unique across all data sources belonging to this user. A data source
            /// is a unique source of sensor data. Data sources can expose raw data coming from hardware sensors on
            /// local or companion devices. They can also expose derived data, created by transforming or merging other
            /// data sources. Multiple data sources can exist for the same data type. Every data point in every dataset
            /// inserted into or read from the Fitness API has an associated data source. Each data source produces a
            /// unique stream of dataset updates, with a unique data source identifier. Not all changes to data source
            /// affect the data stream ID, so that data collected by updated versions of the same application/device can
            /// still be considered to belong to the same data source. Data sources are identified using a string
            /// generated by the server, based on the contents of the source being created. The dataStreamId field
            /// should not be set when invoking this method. It will be automatically generated by the server with the
            /// correct format. If a dataStreamId is set, it must match the format that the server would generate. This
            /// format is a combination of some fields from the data source, and has a specific order. If it doesn't
            /// match, the request will fail with an error. Specifying a DataType which is not a known type (beginning
            /// with "com.google.") will create a DataSource with a *custom data type*. Custom data types are only
            /// readable by the application that created them. Custom data types are *deprecated*; use standard data
            /// types instead. In addition to the data source fields included in the data source ID, the developer
            /// project number that is authenticated when creating the data source is included. This developer project
            /// number is obfuscated when read by any other developer reading public data types.
            /// </summary>
            public class CreateRequest : FitnessBaseServiceRequest<Google.Apis.Fitness.v1.Data.DataSource>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Fitness.v1.Data.DataSource body, string userId) : base(service)
                {
                    UserId = userId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Create the data source for the person identified. Use me to indicate the authenticated user. Only me
                /// is supported at this time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Fitness.v1.Data.DataSource Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "{userId}/dataSources";

                /// <summary>Initializes Create parameter list.</summary>
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

            /// <summary>
            /// Deletes the specified data source. The request will fail if the data source contains any data points.
            /// </summary>
            /// <param name="userId">
            /// Retrieve a data source for the person identified. Use me to indicate the authenticated user. Only me is
            /// supported at this time.
            /// </param>
            /// <param name="dataSourceId">The data stream ID of the data source to delete.</param>
            public virtual DeleteRequest Delete(string userId, string dataSourceId)
            {
                return new DeleteRequest(service, userId, dataSourceId);
            }

            /// <summary>
            /// Deletes the specified data source. The request will fail if the data source contains any data points.
            /// </summary>
            public class DeleteRequest : FitnessBaseServiceRequest<Google.Apis.Fitness.v1.Data.DataSource>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string userId, string dataSourceId) : base(service)
                {
                    UserId = userId;
                    DataSourceId = dataSourceId;
                    InitParameters();
                }

                /// <summary>
                /// Retrieve a data source for the person identified. Use me to indicate the authenticated user. Only me
                /// is supported at this time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The data stream ID of the data source to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("dataSourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string DataSourceId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "{userId}/dataSources/{dataSourceId}";

                /// <summary>Initializes Delete parameter list.</summary>
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
                    RequestParameters.Add("dataSourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dataSourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Returns the specified data source.</summary>
            /// <param name="userId">
            /// Retrieve a data source for the person identified. Use me to indicate the authenticated user. Only me is
            /// supported at this time.
            /// </param>
            /// <param name="dataSourceId">The data stream ID of the data source to retrieve.</param>
            public virtual GetRequest Get(string userId, string dataSourceId)
            {
                return new GetRequest(service, userId, dataSourceId);
            }

            /// <summary>Returns the specified data source.</summary>
            public class GetRequest : FitnessBaseServiceRequest<Google.Apis.Fitness.v1.Data.DataSource>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string userId, string dataSourceId) : base(service)
                {
                    UserId = userId;
                    DataSourceId = dataSourceId;
                    InitParameters();
                }

                /// <summary>
                /// Retrieve a data source for the person identified. Use me to indicate the authenticated user. Only me
                /// is supported at this time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The data stream ID of the data source to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("dataSourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string DataSourceId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "{userId}/dataSources/{dataSourceId}";

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
                    RequestParameters.Add("dataSourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dataSourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Lists all data sources that are visible to the developer, using the OAuth scopes provided. The list is
            /// not exhaustive; the user may have private data sources that are only visible to other developers, or
            /// calls using other scopes.
            /// </summary>
            /// <param name="userId">
            /// List data sources for the person identified. Use me to indicate the authenticated user. Only me is
            /// supported at this time.
            /// </param>
            public virtual ListRequest List(string userId)
            {
                return new ListRequest(service, userId);
            }

            /// <summary>
            /// Lists all data sources that are visible to the developer, using the OAuth scopes provided. The list is
            /// not exhaustive; the user may have private data sources that are only visible to other developers, or
            /// calls using other scopes.
            /// </summary>
            public class ListRequest : FitnessBaseServiceRequest<Google.Apis.Fitness.v1.Data.ListDataSourcesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
                {
                    UserId = userId;
                    InitParameters();
                }

                /// <summary>
                /// List data sources for the person identified. Use me to indicate the authenticated user. Only me is
                /// supported at this time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>
                /// The names of data types to include in the list. If not specified, all data sources will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dataTypeName", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> DataTypeName { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "{userId}/dataSources";

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
                    RequestParameters.Add("dataTypeName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dataTypeName",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates the specified data source. The dataStreamId, dataType, type, dataStreamName, and device
            /// properties with the exception of version, cannot be modified. Data sources are identified by their
            /// dataStreamId.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// Update the data source for the person identified. Use me to indicate the authenticated user. Only me is
            /// supported at this time.
            /// </param>
            /// <param name="dataSourceId">The data stream ID of the data source to update.</param>
            public virtual UpdateRequest Update(Google.Apis.Fitness.v1.Data.DataSource body, string userId, string dataSourceId)
            {
                return new UpdateRequest(service, body, userId, dataSourceId);
            }

            /// <summary>
            /// Updates the specified data source. The dataStreamId, dataType, type, dataStreamName, and device
            /// properties with the exception of version, cannot be modified. Data sources are identified by their
            /// dataStreamId.
            /// </summary>
            public class UpdateRequest : FitnessBaseServiceRequest<Google.Apis.Fitness.v1.Data.DataSource>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Fitness.v1.Data.DataSource body, string userId, string dataSourceId) : base(service)
                {
                    UserId = userId;
                    DataSourceId = dataSourceId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Update the data source for the person identified. Use me to indicate the authenticated user. Only me
                /// is supported at this time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The data stream ID of the data source to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("dataSourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string DataSourceId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Fitness.v1.Data.DataSource Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "{userId}/dataSources/{dataSourceId}";

                /// <summary>Initializes Update parameter list.</summary>
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
                    RequestParameters.Add("dataSourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dataSourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Dataset resource.</summary>
        public virtual DatasetResource Dataset { get; }

        /// <summary>The "dataset" collection of methods.</summary>
        public class DatasetResource
        {
            private const string Resource = "dataset";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DatasetResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Aggregates data of a certain type or stream into buckets divided by a given type of boundary. Multiple
            /// data sets of multiple types and from multiple sources can be aggregated into exactly one bucket type per
            /// request.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// Aggregate data for the person identified. Use me to indicate the authenticated user. Only me is
            /// supported at this time.
            /// </param>
            public virtual AggregateRequest Aggregate(Google.Apis.Fitness.v1.Data.AggregateRequest body, string userId)
            {
                return new AggregateRequest(service, body, userId);
            }

            /// <summary>
            /// Aggregates data of a certain type or stream into buckets divided by a given type of boundary. Multiple
            /// data sets of multiple types and from multiple sources can be aggregated into exactly one bucket type per
            /// request.
            /// </summary>
            public class AggregateRequest : FitnessBaseServiceRequest<Google.Apis.Fitness.v1.Data.AggregateResponse>
            {
                /// <summary>Constructs a new Aggregate request.</summary>
                public AggregateRequest(Google.Apis.Services.IClientService service, Google.Apis.Fitness.v1.Data.AggregateRequest body, string userId) : base(service)
                {
                    UserId = userId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Aggregate data for the person identified. Use me to indicate the authenticated user. Only me is
                /// supported at this time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Fitness.v1.Data.AggregateRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "aggregate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "{userId}/dataset:aggregate";

                /// <summary>Initializes Aggregate parameter list.</summary>
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

        /// <summary>Gets the Sessions resource.</summary>
        public virtual SessionsResource Sessions { get; }

        /// <summary>The "sessions" collection of methods.</summary>
        public class SessionsResource
        {
            private const string Resource = "sessions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SessionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Deletes a session specified by the given session ID.</summary>
            /// <param name="userId">
            /// Delete a session for the person identified. Use me to indicate the authenticated user. Only me is
            /// supported at this time.
            /// </param>
            /// <param name="sessionId">The ID of the session to be deleted.</param>
            public virtual DeleteRequest Delete(string userId, string sessionId)
            {
                return new DeleteRequest(service, userId, sessionId);
            }

            /// <summary>Deletes a session specified by the given session ID.</summary>
            public class DeleteRequest : FitnessBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string userId, string sessionId) : base(service)
                {
                    UserId = userId;
                    SessionId = sessionId;
                    InitParameters();
                }

                /// <summary>
                /// Delete a session for the person identified. Use me to indicate the authenticated user. Only me is
                /// supported at this time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The ID of the session to be deleted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("sessionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SessionId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "{userId}/sessions/{sessionId}";

                /// <summary>Initializes Delete parameter list.</summary>
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
                    RequestParameters.Add("sessionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sessionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Lists sessions previously created.</summary>
            /// <param name="userId">
            /// List sessions for the person identified. Use me to indicate the authenticated user. Only me is supported
            /// at this time.
            /// </param>
            public virtual ListRequest List(string userId)
            {
                return new ListRequest(service, userId);
            }

            /// <summary>Lists sessions previously created.</summary>
            public class ListRequest : FitnessBaseServiceRequest<Google.Apis.Fitness.v1.Data.ListSessionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
                {
                    UserId = userId;
                    InitParameters();
                }

                /// <summary>
                /// List sessions for the person identified. Use me to indicate the authenticated user. Only me is
                /// supported at this time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>If non-empty, only sessions with these activity types should be returned.</summary>
                [Google.Apis.Util.RequestParameterAttribute("activityType", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> ActivityType { get; set; }

                /// <summary>
                /// An RFC3339 timestamp. Only sessions ending between the start and end times will be included in the
                /// response. If this time is omitted but startTime is specified, all sessions from startTime to the end
                /// of time will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("endTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string EndTime { get; set; }

                /// <summary>
                /// If true, and if both startTime and endTime are omitted, session deletions will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("includeDeleted", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeDeleted { get; set; }

                /// <summary>
                /// The continuation token, which is used for incremental syncing. To get the next batch of changes, set
                /// this parameter to the value of nextPageToken from the previous response. The page token is ignored
                /// if either start or end time is specified. If none of start time, end time, and the page token is
                /// specified, sessions modified in the last 30 days are returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// An RFC3339 timestamp. Only sessions ending between the start and end times will be included in the
                /// response. If this time is omitted but endTime is specified, all sessions from the start of time up
                /// to endTime will be returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string StartTime { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "{userId}/sessions";

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
                    RequestParameters.Add("activityType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "activityType",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("endTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "endTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("includeDeleted", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeDeleted",
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
                    RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates or insert a given session.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userId">
            /// Create sessions for the person identified. Use me to indicate the authenticated user. Only me is
            /// supported at this time.
            /// </param>
            /// <param name="sessionId">The ID of the session to be created.</param>
            public virtual UpdateRequest Update(Google.Apis.Fitness.v1.Data.Session body, string userId, string sessionId)
            {
                return new UpdateRequest(service, body, userId, sessionId);
            }

            /// <summary>Updates or insert a given session.</summary>
            public class UpdateRequest : FitnessBaseServiceRequest<Google.Apis.Fitness.v1.Data.Session>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Fitness.v1.Data.Session body, string userId, string sessionId) : base(service)
                {
                    UserId = userId;
                    SessionId = sessionId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Create sessions for the person identified. Use me to indicate the authenticated user. Only me is
                /// supported at this time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>The ID of the session to be created.</summary>
                [Google.Apis.Util.RequestParameterAttribute("sessionId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SessionId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Fitness.v1.Data.Session Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "{userId}/sessions/{sessionId}";

                /// <summary>Initializes Update parameter list.</summary>
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
                    RequestParameters.Add("sessionId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sessionId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }
}
namespace Google.Apis.Fitness.v1.Data
{
    public class AggregateBucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Available for Bucket.Type.ACTIVITY_TYPE, Bucket.Type.ACTIVITY_SEGMENT</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activity")]
        public virtual System.Nullable<int> Activity { get; set; }

        /// <summary>There will be one dataset per AggregateBy in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual System.Collections.Generic.IList<Dataset> Dataset { get; set; }

        /// <summary>The end time for the aggregated data, in milliseconds since epoch, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeMillis")]
        public virtual System.Nullable<long> EndTimeMillis { get; set; }

        /// <summary>Available for Bucket.Type.SESSION</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("session")]
        public virtual Session Session { get; set; }

        /// <summary>The start time for the aggregated data, in milliseconds since epoch, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeMillis")]
        public virtual System.Nullable<long> StartTimeMillis { get; set; }

        /// <summary>The type of a bucket signifies how the data aggregation is performed in the bucket.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specification of which data to aggregate.</summary>
    public class AggregateBy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A data source ID to aggregate. Only data from the specified data source ID will be included in the
        /// aggregation. If specified, this data source must exist; the OAuth scopes in the supplied credentials must
        /// grant read access to this data type. The dataset in the response will have the same data source ID. Note:
        /// Data can be aggregated by either the dataTypeName or the dataSourceId, not both.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceId")]
        public virtual string DataSourceId { get; set; }

        /// <summary>
        /// The data type to aggregate. All data sources providing this data type will contribute data to the
        /// aggregation. The response will contain a single dataset for this data type name. The dataset will have a
        /// data source ID of derived::com.google.android.gms:aggregated. If the user has no data for this data type, an
        /// empty data set will be returned. Note: Data can be aggregated by either the dataTypeName or the
        /// dataSourceId, not both.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataTypeName")]
        public virtual string DataTypeName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Next id: 10</summary>
    public class AggregateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The specification of data to be aggregated. At least one aggregateBy spec must be provided. All data that is
        /// specified will be aggregated using the same bucketing criteria. There will be one dataset in the response
        /// for every aggregateBy spec.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregateBy")]
        public virtual System.Collections.Generic.IList<AggregateBy> AggregateBy { get; set; }

        /// <summary>
        /// Specifies that data be aggregated each activity segment recorded for a user. Similar to
        /// bucketByActivitySegment, but bucketing is done for each activity segment rather than all segments of the
        /// same type. Mutually exclusive of other bucketing specifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketByActivitySegment")]
        public virtual BucketByActivity BucketByActivitySegment { get; set; }

        /// <summary>
        /// Specifies that data be aggregated by the type of activity being performed when the data was recorded. All
        /// data that was recorded during a certain activity type (.for the given time range) will be aggregated into
        /// the same bucket. Data that was recorded while the user was not active will not be included in the response.
        /// Mutually exclusive of other bucketing specifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketByActivityType")]
        public virtual BucketByActivity BucketByActivityType { get; set; }

        /// <summary>
        /// Specifies that data be aggregated by user sessions. Data that does not fall within the time range of a
        /// session will not be included in the response. Mutually exclusive of other bucketing specifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketBySession")]
        public virtual BucketBySession BucketBySession { get; set; }

        /// <summary>
        /// Specifies that data be aggregated by a single time interval. Mutually exclusive of other bucketing
        /// specifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketByTime")]
        public virtual BucketByTime BucketByTime { get; set; }

        /// <summary>
        /// The end of a window of time. Data that intersects with this time window will be aggregated. The time is in
        /// milliseconds since epoch, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeMillis")]
        public virtual System.Nullable<long> EndTimeMillis { get; set; }

        /// <summary>DO NOT POPULATE THIS FIELD. It is ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filteredDataQualityStandard")]
        public virtual System.Collections.Generic.IList<string> FilteredDataQualityStandard { get; set; }

        /// <summary>
        /// The start of a window of time. Data that intersects with this time window will be aggregated. The time is in
        /// milliseconds since epoch, inclusive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeMillis")]
        public virtual System.Nullable<long> StartTimeMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class AggregateResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of buckets containing the aggregated data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucket")]
        public virtual System.Collections.Generic.IList<AggregateBucket> Bucket { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class Application : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An optional URI that can be used to link back to the application.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detailsUrl")]
        public virtual string DetailsUrl { get; set; }

        /// <summary>
        /// The name of this application. This is required for REST clients, but we do not enforce uniqueness of this
        /// name. It is provided as a matter of convenience for other developers who would like to identify which REST
        /// created an Application or Data Source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Package name for this application. This is used as a unique identifier when created by Android applications,
        /// but cannot be specified by REST clients. REST clients will have their developer project number reflected
        /// into the Data Source data stream IDs, instead of the packageName.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
        public virtual string PackageName { get; set; }

        /// <summary>
        /// Version of the application. You should update this field whenever the application changes in a way that
        /// affects the computation of the data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BucketByActivity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The default activity stream will be used if a specific activityDataSourceId is not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityDataSourceId")]
        public virtual string ActivityDataSourceId { get; set; }

        /// <summary>
        /// Specifies that only activity segments of duration longer than minDurationMillis are considered and used as a
        /// container for aggregated data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minDurationMillis")]
        public virtual System.Nullable<long> MinDurationMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BucketBySession : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies that only sessions of duration longer than minDurationMillis are considered and used as a
        /// container for aggregated data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minDurationMillis")]
        public virtual System.Nullable<long> MinDurationMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BucketByTime : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies that result buckets aggregate data by exactly durationMillis time frames. Time frames that contain
        /// no data will be included in the response with an empty dataset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("durationMillis")]
        public virtual System.Nullable<long> DurationMillis { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("period")]
        public virtual BucketByTimePeriod Period { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class BucketByTimePeriod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>org.joda.timezone.DateTimeZone</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZoneId")]
        public virtual string TimeZoneId { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Nullable<int> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a single data point, generated by a particular data source. A data point holds a value for each
    /// field, an end timestamp and an optional start time. The exact semantics of each of these attributes are
    /// specified in the documentation for the particular data type. A data point can represent an instantaneous
    /// measurement, reading or input observation, as well as averages or aggregates over a time interval. Check the
    /// data type documentation to determine which is the case for a particular data type. Data points always contain
    /// one value for each field of the data type.
    /// </summary>
    public class DataPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>DO NOT USE THIS FIELD. It is ignored, and not stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computationTimeMillis")]
        public virtual System.Nullable<long> ComputationTimeMillis { get; set; }

        /// <summary>The data type defining the format of the values in this data point.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataTypeName")]
        public virtual string DataTypeName { get; set; }

        /// <summary>The end time of the interval represented by this data point, in nanoseconds since epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeNanos")]
        public virtual System.Nullable<long> EndTimeNanos { get; set; }

        /// <summary>
        /// Indicates the last time this data point was modified. Useful only in contexts where we are listing the data
        /// changes, rather than representing the current state of the data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modifiedTimeMillis")]
        public virtual System.Nullable<long> ModifiedTimeMillis { get; set; }

        /// <summary>
        /// If the data point is contained in a dataset for a derived data source, this field will be populated with the
        /// data source stream ID that created the data point originally. WARNING: do not rely on this field for
        /// anything other than debugging. The value of this field, if it is set at all, is an implementation detail and
        /// is not guaranteed to remain consistent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originDataSourceId")]
        public virtual string OriginDataSourceId { get; set; }

        /// <summary>The raw timestamp from the original SensorEvent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawTimestampNanos")]
        public virtual System.Nullable<long> RawTimestampNanos { get; set; }

        /// <summary>
        /// The start time of the interval represented by this data point, in nanoseconds since epoch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeNanos")]
        public virtual System.Nullable<long> StartTimeNanos { get; set; }

        /// <summary>
        /// Values of each data type field for the data point. It is expected that each value corresponding to a data
        /// type field will occur in the same order that the field is listed with in the data type specified in a data
        /// source. Only one of integer and floating point fields will be populated, depending on the format enum value
        /// within data source's type field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IList<Value> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Definition of a unique source of sensor data. Data sources can expose raw data coming from hardware sensors on
    /// local or companion devices. They can also expose derived data, created by transforming or merging other data
    /// sources. Multiple data sources can exist for the same data type. Every data point inserted into or read from
    /// this service has an associated data source. The data source contains enough information to uniquely identify its
    /// data, including the hardware device and the application that collected and/or transformed the data. It also
    /// holds useful metadata, such as the hardware and application versions, and the device type. Each data source
    /// produces a unique stream of data, with a unique identifier. Not all changes to data source affect the stream
    /// identifier, so that data collected by updated versions of the same application/device can still be considered to
    /// belong to the same data stream.
    /// </summary>
    public class DataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Information about an application which feeds sensor data into the platform.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("application")]
        public virtual Application Application { get; set; }

        /// <summary>
        /// DO NOT POPULATE THIS FIELD. It is never populated in responses from the platform, and is ignored in queries.
        /// It will be removed in a future version entirely.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataQualityStandard")]
        public virtual System.Collections.Generic.IList<string> DataQualityStandard { get; set; }

        /// <summary>
        /// A unique identifier for the data stream produced by this data source. The identifier includes: - The
        /// physical device's manufacturer, model, and serial number (UID). - The application's package name or name.
        /// Package name is used when the data source was created by an Android application. The developer project
        /// number is used when the data source was created by a REST client. - The data source's type. - The data
        /// source's stream name. Note that not all attributes of the data source are used as part of the stream
        /// identifier. In particular, the version of the hardware/the application isn't used. This allows us to
        /// preserve the same stream through version updates. This also means that two DataSource objects may represent
        /// the same data stream even if they're not equal. The exact format of the data stream ID created by an Android
        /// application is:
        /// type:dataType.name:application.packageName:device.manufacturer:device.model:device.uid:dataStreamName The
        /// exact format of the data stream ID created by a REST client is: type:dataType.name:developer project
        /// number:device.manufacturer:device.model:device.uid:dataStreamName When any of the optional fields that make
        /// up the data stream ID are absent, they will be omitted from the data stream ID. The minimum viable data
        /// stream ID would be: type:dataType.name:developer project number Finally, the developer project number and
        /// device UID are obfuscated when read by any REST or Android client that did not create the data source. Only
        /// the data source creator will see the developer project number in clear and normal form. This means a client
        /// will see a different set of data_stream_ids than another client with different credentials.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStreamId")]
        public virtual string DataStreamId { get; set; }

        /// <summary>
        /// The stream name uniquely identifies this particular data source among other data sources of the same type
        /// from the same underlying producer. Setting the stream name is optional, but should be done whenever an
        /// application exposes two streams for the same data type, or when a device has two equivalent sensors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataStreamName")]
        public virtual string DataStreamName { get; set; }

        /// <summary>
        /// The data type defines the schema for a stream of data being collected by, inserted into, or queried from the
        /// Fitness API.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual DataType DataType { get; set; }

        /// <summary>
        /// Representation of an integrated device (such as a phone or a wearable) that can hold sensors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual Device Device { get; set; }

        /// <summary>An end-user visible name for this data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// A constant describing the type of this data source. Indicates whether this data source produces raw or
        /// derived data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class DataType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A field represents one dimension of a data type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("field")]
        public virtual System.Collections.Generic.IList<DataTypeField> Field { get; set; }

        /// <summary>
        /// Each data type has a unique, namespaced, name. All data types in the com.google namespace are shared as part
        /// of the platform.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// In case of multi-dimensional data (such as an accelerometer with x, y, and z axes) each field represents one
    /// dimension. Each data type field has a unique name which identifies it. The field also defines the format of the
    /// data (int, float, etc.). This message is only instantiated in code and not used for wire comms or stored in any
    /// way.
    /// </summary>
    public class DataTypeField : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The different supported formats for each field in a data type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>
        /// Defines the name and format of data. Unlike data type names, field names are not namespaced, and only need
        /// to be unique within the data type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("optional")]
        public virtual System.Nullable<bool> Optional { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A dataset represents a projection container for data points. They do not carry any info of their own. Datasets
    /// represent a set of data points from a particular data source. A data point can be found in more than one
    /// dataset.
    /// </summary>
    public class Dataset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data stream ID of the data source that created the points in this dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceId")]
        public virtual string DataSourceId { get; set; }

        /// <summary>
        /// The largest end time of all data points in this possibly partial representation of the dataset. Time is in
        /// nanoseconds from epoch. This should also match the second part of the dataset identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxEndTimeNs")]
        public virtual System.Nullable<long> MaxEndTimeNs { get; set; }

        /// <summary>
        /// The smallest start time of all data points in this possibly partial representation of the dataset. Time is
        /// in nanoseconds from epoch. This should also match the first part of the dataset identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minStartTimeNs")]
        public virtual System.Nullable<long> MinStartTimeNs { get; set; }

        /// <summary>
        /// This token will be set when a dataset is received in response to a GET request and the dataset is too large
        /// to be included in a single response. Provide this value in a subsequent GET request to return the next page
        /// of data points within this dataset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>
        /// A partial list of data points contained in the dataset, ordered by endTimeNanos. This list is considered
        /// complete when retrieving a small dataset and partial when patching a dataset or retrieving a dataset that is
        /// too large to include in a single response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("point")]
        public virtual System.Collections.Generic.IList<DataPoint> Point { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Representation of an integrated device (such as a phone or a wearable) that can hold sensors. Each sensor is
    /// exposed as a data source. The main purpose of the device information contained in this class is to identify the
    /// hardware of a particular data source. This can be useful in different ways, including: - Distinguishing two
    /// similar sensors on different devices (the step counter on two nexus 5 phones, for instance) - Display the source
    /// of data to the user (by using the device make / model) - Treat data differently depending on sensor type
    /// (accelerometers on a watch may give different patterns than those on a phone) - Build different analysis models
    /// for each device/version.
    /// </summary>
    public class Device : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Manufacturer of the product/hardware.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; }

        /// <summary>End-user visible model name for the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; }

        /// <summary>A constant representing the type of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// The serial number or other unique ID for the hardware. This field is obfuscated when read by any REST or
        /// Android client that did not create the data source. Only the data source creator will see the uid field in
        /// clear and normal form. The obfuscation preserves equality; that is, given two IDs, if id1 == id2,
        /// obfuscated(id1) == obfuscated(id2).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>Version string for the device hardware/software.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListDataPointChangesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data stream ID of the data source with data point changes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceId")]
        public virtual string DataSourceId { get; set; }

        /// <summary>
        /// Deleted data points for the user. Note, for modifications this should be parsed before handling insertions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletedDataPoint")]
        public virtual System.Collections.Generic.IList<DataPoint> DeletedDataPoint { get; set; }

        /// <summary>Inserted data points for the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertedDataPoint")]
        public virtual System.Collections.Generic.IList<DataPoint> InsertedDataPoint { get; set; }

        /// <summary>
        /// The continuation token, which is used to page through large result sets. Provide this value in a subsequent
        /// request to return the next page of results.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListDataSourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A previously created data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSource")]
        public virtual System.Collections.Generic.IList<DataSource> DataSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListSessionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If includeDeleted is set to true in the request, and startTime and endTime are omitted, this will include
        /// sessions which were deleted since the last sync.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletedSession")]
        public virtual System.Collections.Generic.IList<Session> DeletedSession { get; set; }

        /// <summary>
        /// Flag to indicate server has more data to transfer. DO NOT USE THIS FIELD. It is never populated in responses
        /// from the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hasMoreData")]
        public virtual System.Nullable<bool> HasMoreData { get; set; }

        /// <summary>
        /// The sync token which is used to sync further changes. This will only be provided if both startTime and
        /// endTime are omitted from the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Sessions with an end time that is between startTime and endTime of the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("session")]
        public virtual System.Collections.Generic.IList<Session> Session { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Holder object for the value of an entry in a map field of a data point. A map value supports a subset of the
    /// formats that the regular Value supports.
    /// </summary>
    public class MapValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Floating point value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fpVal")]
        public virtual System.Nullable<double> FpVal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sessions contain metadata, such as a user-friendly name and time interval information.</summary>
    public class Session : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Session active time. While start_time_millis and end_time_millis define the full session time, the active
        /// time can be shorter and specified by active_time_millis. If the inactive time during the session is known,
        /// it should also be inserted via a com.google.activity.segment data point with a STILL activity value
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeTimeMillis")]
        public virtual System.Nullable<long> ActiveTimeMillis { get; set; }

        /// <summary>The type of activity this session represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activityType")]
        public virtual System.Nullable<int> ActivityType { get; set; }

        /// <summary>The application that created the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("application")]
        public virtual Application Application { get; set; }

        /// <summary>A description for this session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>An end time, in milliseconds since epoch, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTimeMillis")]
        public virtual System.Nullable<long> EndTimeMillis { get; set; }

        /// <summary>
        /// A client-generated identifier that is unique across all sessions owned by this particular user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>A timestamp that indicates when the session was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modifiedTimeMillis")]
        public virtual System.Nullable<long> ModifiedTimeMillis { get; set; }

        /// <summary>A human readable name of the session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A start time, in milliseconds since epoch, inclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTimeMillis")]
        public virtual System.Nullable<long> StartTimeMillis { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Holder object for the value of a single field in a data point. A field value has a particular format and is only
    /// ever set to one of an integer or a floating point value.
    /// </summary>
    public class Value : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Floating point value. When this is set, other values must not be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fpVal")]
        public virtual System.Nullable<double> FpVal { get; set; }

        /// <summary>Integer value. When this is set, other values must not be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intVal")]
        public virtual System.Nullable<int> IntVal { get; set; }

        /// <summary>
        /// Map value. The valid key space and units for the corresponding value of each entry should be documented as
        /// part of the data type definition. Keys should be kept small whenever possible. Data streams with large keys
        /// and high data frequency may be down sampled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mapVal")]
        public virtual System.Collections.Generic.IList<ValueMapValEntry> MapVal { get; set; }

        /// <summary>
        /// String value. When this is set, other values must not be set. Strings should be kept small whenever
        /// possible. Data streams with large string values and high data frequency may be down sampled.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringVal")]
        public virtual string StringVal { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ValueMapValEntry : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual MapValue Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
