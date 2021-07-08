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

namespace Google.Apis.Sheets.v4
{
    /// <summary>The Sheets Service.</summary>
    public class SheetsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v4";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SheetsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SheetsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Spreadsheets = new SpreadsheetsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "sheets";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://sheets.googleapis.com/";
        #else
            "https://sheets.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://sheets.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google Sheets API.</summary>
        public class Scope
        {
            /// <summary>See, edit, create, and delete all of your Google Drive files</summary>
            public static string Drive = "https://www.googleapis.com/auth/drive";

            /// <summary>
            /// See, edit, create, and delete only the specific Google Drive files you use with this app
            /// </summary>
            public static string DriveFile = "https://www.googleapis.com/auth/drive.file";

            /// <summary>See and download all your Google Drive files</summary>
            public static string DriveReadonly = "https://www.googleapis.com/auth/drive.readonly";

            /// <summary>See, edit, create, and delete all your Google Sheets spreadsheets</summary>
            public static string Spreadsheets = "https://www.googleapis.com/auth/spreadsheets";

            /// <summary>See all your Google Sheets spreadsheets</summary>
            public static string SpreadsheetsReadonly = "https://www.googleapis.com/auth/spreadsheets.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Sheets API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, create, and delete all of your Google Drive files</summary>
            public const string Drive = "https://www.googleapis.com/auth/drive";

            /// <summary>
            /// See, edit, create, and delete only the specific Google Drive files you use with this app
            /// </summary>
            public const string DriveFile = "https://www.googleapis.com/auth/drive.file";

            /// <summary>See and download all your Google Drive files</summary>
            public const string DriveReadonly = "https://www.googleapis.com/auth/drive.readonly";

            /// <summary>See, edit, create, and delete all your Google Sheets spreadsheets</summary>
            public const string Spreadsheets = "https://www.googleapis.com/auth/spreadsheets";

            /// <summary>See all your Google Sheets spreadsheets</summary>
            public const string SpreadsheetsReadonly = "https://www.googleapis.com/auth/spreadsheets.readonly";
        }

        /// <summary>Gets the Spreadsheets resource.</summary>
        public virtual SpreadsheetsResource Spreadsheets { get; }
    }

    /// <summary>A base abstract class for Sheets requests.</summary>
    public abstract class SheetsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SheetsBaseServiceRequest instance.</summary>
        protected SheetsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Sheets parameter list.</summary>
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

    /// <summary>The "spreadsheets" collection of methods.</summary>
    public class SpreadsheetsResource
    {
        private const string Resource = "spreadsheets";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SpreadsheetsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            DeveloperMetadata = new DeveloperMetadataResource(service);
            Sheets = new SheetsResource(service);
            Values = new ValuesResource(service);
        }

        /// <summary>Gets the DeveloperMetadata resource.</summary>
        public virtual DeveloperMetadataResource DeveloperMetadata { get; }

        /// <summary>The "developerMetadata" collection of methods.</summary>
        public class DeveloperMetadataResource
        {
            private const string Resource = "developerMetadata";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public DeveloperMetadataResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Returns the developer metadata with the specified ID. The caller must specify the spreadsheet ID and the
            /// developer metadata's unique metadataId.
            /// </summary>
            /// <param name="spreadsheetId">The ID of the spreadsheet to retrieve metadata from.</param>
            /// <param name="metadataId">The ID of the developer metadata to retrieve.</param>
            public virtual GetRequest Get(string spreadsheetId, int metadataId)
            {
                return new GetRequest(service, spreadsheetId, metadataId);
            }

            /// <summary>
            /// Returns the developer metadata with the specified ID. The caller must specify the spreadsheet ID and the
            /// developer metadata's unique metadataId.
            /// </summary>
            public class GetRequest : SheetsBaseServiceRequest<Google.Apis.Sheets.v4.Data.DeveloperMetadata>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string spreadsheetId, int metadataId) : base(service)
                {
                    SpreadsheetId = spreadsheetId;
                    MetadataId = metadataId;
                    InitParameters();
                }

                /// <summary>The ID of the spreadsheet to retrieve metadata from.</summary>
                [Google.Apis.Util.RequestParameterAttribute("spreadsheetId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SpreadsheetId { get; private set; }

                /// <summary>The ID of the developer metadata to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("metadataId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int MetadataId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v4/spreadsheets/{spreadsheetId}/developerMetadata/{metadataId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("spreadsheetId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "spreadsheetId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("metadataId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "metadataId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns all developer metadata matching the specified DataFilter. If the provided DataFilter represents
            /// a DeveloperMetadataLookup object, this will return all DeveloperMetadata entries selected by it. If the
            /// DataFilter represents a location in a spreadsheet, this will return all developer metadata associated
            /// with locations intersecting that region.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="spreadsheetId">The ID of the spreadsheet to retrieve metadata from.</param>
            public virtual SearchRequest Search(Google.Apis.Sheets.v4.Data.SearchDeveloperMetadataRequest body, string spreadsheetId)
            {
                return new SearchRequest(service, body, spreadsheetId);
            }

            /// <summary>
            /// Returns all developer metadata matching the specified DataFilter. If the provided DataFilter represents
            /// a DeveloperMetadataLookup object, this will return all DeveloperMetadata entries selected by it. If the
            /// DataFilter represents a location in a spreadsheet, this will return all developer metadata associated
            /// with locations intersecting that region.
            /// </summary>
            public class SearchRequest : SheetsBaseServiceRequest<Google.Apis.Sheets.v4.Data.SearchDeveloperMetadataResponse>
            {
                /// <summary>Constructs a new Search request.</summary>
                public SearchRequest(Google.Apis.Services.IClientService service, Google.Apis.Sheets.v4.Data.SearchDeveloperMetadataRequest body, string spreadsheetId) : base(service)
                {
                    SpreadsheetId = spreadsheetId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The ID of the spreadsheet to retrieve metadata from.</summary>
                [Google.Apis.Util.RequestParameterAttribute("spreadsheetId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SpreadsheetId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Sheets.v4.Data.SearchDeveloperMetadataRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "search";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v4/spreadsheets/{spreadsheetId}/developerMetadata:search";

                /// <summary>Initializes Search parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("spreadsheetId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "spreadsheetId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Sheets resource.</summary>
        public virtual SheetsResource Sheets { get; }

        /// <summary>The "sheets" collection of methods.</summary>
        public class SheetsResource
        {
            private const string Resource = "sheets";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SheetsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Copies a single sheet from a spreadsheet to another spreadsheet. Returns the properties of the newly
            /// created sheet.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="spreadsheetId">The ID of the spreadsheet containing the sheet to copy.</param>
            /// <param name="sheetId">The ID of the sheet to copy.</param>
            public virtual CopyToRequest CopyTo(Google.Apis.Sheets.v4.Data.CopySheetToAnotherSpreadsheetRequest body, string spreadsheetId, int sheetId)
            {
                return new CopyToRequest(service, body, spreadsheetId, sheetId);
            }

            /// <summary>
            /// Copies a single sheet from a spreadsheet to another spreadsheet. Returns the properties of the newly
            /// created sheet.
            /// </summary>
            public class CopyToRequest : SheetsBaseServiceRequest<Google.Apis.Sheets.v4.Data.SheetProperties>
            {
                /// <summary>Constructs a new CopyTo request.</summary>
                public CopyToRequest(Google.Apis.Services.IClientService service, Google.Apis.Sheets.v4.Data.CopySheetToAnotherSpreadsheetRequest body, string spreadsheetId, int sheetId) : base(service)
                {
                    SpreadsheetId = spreadsheetId;
                    SheetId = sheetId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The ID of the spreadsheet containing the sheet to copy.</summary>
                [Google.Apis.Util.RequestParameterAttribute("spreadsheetId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SpreadsheetId { get; private set; }

                /// <summary>The ID of the sheet to copy.</summary>
                [Google.Apis.Util.RequestParameterAttribute("sheetId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual int SheetId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Sheets.v4.Data.CopySheetToAnotherSpreadsheetRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "copyTo";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v4/spreadsheets/{spreadsheetId}/sheets/{sheetId}:copyTo";

                /// <summary>Initializes CopyTo parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("spreadsheetId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "spreadsheetId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("sheetId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sheetId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Values resource.</summary>
        public virtual ValuesResource Values { get; }

        /// <summary>The "values" collection of methods.</summary>
        public class ValuesResource
        {
            private const string Resource = "values";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ValuesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Appends values to a spreadsheet. The input range is used to search for existing data and find a "table"
            /// within that range. Values will be appended to the next row of the table, starting with the first column
            /// of the table. See the [guide](/sheets/api/guides/values#appending_values) and [sample
            /// code](/sheets/api/samples/writing#append_values) for specific details of how tables are detected and
            /// data is appended. The caller must specify the spreadsheet ID, range, and a valueInputOption. The
            /// `valueInputOption` only controls how the input data will be added to the sheet (column-wise or
            /// row-wise), it does not influence what cell the data starts being written to.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="spreadsheetId">The ID of the spreadsheet to update.</param>
            /// <param name="range">
            /// The A1 notation of a range to search for a logical table of data. Values are appended after the last row
            /// of the table.
            /// </param>
            public virtual AppendRequest Append(Google.Apis.Sheets.v4.Data.ValueRange body, string spreadsheetId, string range)
            {
                return new AppendRequest(service, body, spreadsheetId, range);
            }

            /// <summary>
            /// Appends values to a spreadsheet. The input range is used to search for existing data and find a "table"
            /// within that range. Values will be appended to the next row of the table, starting with the first column
            /// of the table. See the [guide](/sheets/api/guides/values#appending_values) and [sample
            /// code](/sheets/api/samples/writing#append_values) for specific details of how tables are detected and
            /// data is appended. The caller must specify the spreadsheet ID, range, and a valueInputOption. The
            /// `valueInputOption` only controls how the input data will be added to the sheet (column-wise or
            /// row-wise), it does not influence what cell the data starts being written to.
            /// </summary>
            public class AppendRequest : SheetsBaseServiceRequest<Google.Apis.Sheets.v4.Data.AppendValuesResponse>
            {
                /// <summary>Constructs a new Append request.</summary>
                public AppendRequest(Google.Apis.Services.IClientService service, Google.Apis.Sheets.v4.Data.ValueRange body, string spreadsheetId, string range) : base(service)
                {
                    SpreadsheetId = spreadsheetId;
                    Range = range;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The ID of the spreadsheet to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("spreadsheetId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SpreadsheetId { get; private set; }

                /// <summary>
                /// The A1 notation of a range to search for a logical table of data. Values are appended after the last
                /// row of the table.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("range", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Range { get; private set; }

                /// <summary>
                /// Determines if the update response should include the values of the cells that were appended. By
                /// default, responses do not include the updated values.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("includeValuesInResponse", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeValuesInResponse { get; set; }

                /// <summary>How the input data should be inserted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("insertDataOption", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<InsertDataOptionEnum> InsertDataOption { get; set; }

                /// <summary>How the input data should be inserted.</summary>
                public enum InsertDataOptionEnum
                {
                    /// <summary>
                    /// The new data overwrites existing data in the areas it is written. (Note: adding data to the end
                    /// of the sheet will still insert new rows or columns so the data can be written.)
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("OVERWRITE")]
                    OVERWRITE = 0,

                    /// <summary>Rows are inserted for the new data.</summary>
                    [Google.Apis.Util.StringValueAttribute("INSERT_ROWS")]
                    INSERTROWS = 1,
                }

                /// <summary>
                /// Determines how dates, times, and durations in the response should be rendered. This is ignored if
                /// response_value_render_option is FORMATTED_VALUE. The default dateTime render option is
                /// SERIAL_NUMBER.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("responseDateTimeRenderOption", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ResponseDateTimeRenderOptionEnum> ResponseDateTimeRenderOption { get; set; }

                /// <summary>
                /// Determines how dates, times, and durations in the response should be rendered. This is ignored if
                /// response_value_render_option is FORMATTED_VALUE. The default dateTime render option is
                /// SERIAL_NUMBER.
                /// </summary>
                public enum ResponseDateTimeRenderOptionEnum
                {
                    /// <summary>
                    /// Instructs date, time, datetime, and duration fields to be output as doubles in "serial number"
                    /// format, as popularized by Lotus 1-2-3. The whole number portion of the value (left of the
                    /// decimal) counts the days since December 30th 1899. The fractional portion (right of the decimal)
                    /// counts the time as a fraction of the day. For example, January 1st 1900 at noon would be 2.5, 2
                    /// because it's 2 days after December 30st 1899, and .5 because noon is half a day. February 1st
                    /// 1900 at 3pm would be 33.625. This correctly treats the year 1900 as not a leap year.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SERIAL_NUMBER")]
                    SERIALNUMBER = 0,

                    /// <summary>
                    /// Instructs date, time, datetime, and duration fields to be output as strings in their given
                    /// number format (which is dependent on the spreadsheet locale).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FORMATTED_STRING")]
                    FORMATTEDSTRING = 1,
                }

                /// <summary>
                /// Determines how values in the response should be rendered. The default render option is
                /// FORMATTED_VALUE.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("responseValueRenderOption", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ResponseValueRenderOptionEnum> ResponseValueRenderOption { get; set; }

                /// <summary>
                /// Determines how values in the response should be rendered. The default render option is
                /// FORMATTED_VALUE.
                /// </summary>
                public enum ResponseValueRenderOptionEnum
                {
                    /// <summary>
                    /// Values will be calculated &amp;amp; formatted in the reply according to the cell's formatting.
                    /// Formatting is based on the spreadsheet's locale, not the requesting user's locale. For example,
                    /// if `A1` is `1.23` and `A2` is `=A1` and formatted as currency, then `A2` would return `"$1.23"`.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FORMATTED_VALUE")]
                    FORMATTEDVALUE = 0,

                    /// <summary>
                    /// Values will be calculated, but not formatted in the reply. For example, if `A1` is `1.23` and
                    /// `A2` is `=A1` and formatted as currency, then `A2` would return the number `1.23`.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("UNFORMATTED_VALUE")]
                    UNFORMATTEDVALUE = 1,

                    /// <summary>
                    /// Values will not be calculated. The reply will include the formulas. For example, if `A1` is
                    /// `1.23` and `A2` is `=A1` and formatted as currency, then A2 would return `"=A1"`.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FORMULA")]
                    FORMULA = 2,
                }

                /// <summary>How the input data should be interpreted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("valueInputOption", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ValueInputOptionEnum> ValueInputOption { get; set; }

                /// <summary>How the input data should be interpreted.</summary>
                public enum ValueInputOptionEnum
                {
                    /// <summary>Default input value. This value must not be used.</summary>
                    [Google.Apis.Util.StringValueAttribute("INPUT_VALUE_OPTION_UNSPECIFIED")]
                    INPUTVALUEOPTIONUNSPECIFIED = 0,

                    /// <summary>The values the user has entered will not be parsed and will be stored as-is.</summary>
                    [Google.Apis.Util.StringValueAttribute("RAW")]
                    RAW = 1,

                    /// <summary>
                    /// The values will be parsed as if the user typed them into the UI. Numbers will stay as numbers,
                    /// but strings may be converted to numbers, dates, etc. following the same rules that are applied
                    /// when entering text into a cell via the Google Sheets UI.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("USER_ENTERED")]
                    USERENTERED = 2,
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Sheets.v4.Data.ValueRange Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "append";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v4/spreadsheets/{spreadsheetId}/values/{range}:append";

                /// <summary>Initializes Append parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("spreadsheetId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "spreadsheetId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("range", new Google.Apis.Discovery.Parameter
                    {
                        Name = "range",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("includeValuesInResponse", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeValuesInResponse",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("insertDataOption", new Google.Apis.Discovery.Parameter
                    {
                        Name = "insertDataOption",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("responseDateTimeRenderOption", new Google.Apis.Discovery.Parameter
                    {
                        Name = "responseDateTimeRenderOption",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("responseValueRenderOption", new Google.Apis.Discovery.Parameter
                    {
                        Name = "responseValueRenderOption",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("valueInputOption", new Google.Apis.Discovery.Parameter
                    {
                        Name = "valueInputOption",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Clears one or more ranges of values from a spreadsheet. The caller must specify the spreadsheet ID and
            /// one or more ranges. Only values are cleared -- all other properties of the cell (such as formatting,
            /// data validation, etc..) are kept.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="spreadsheetId">The ID of the spreadsheet to update.</param>
            public virtual BatchClearRequest BatchClear(Google.Apis.Sheets.v4.Data.BatchClearValuesRequest body, string spreadsheetId)
            {
                return new BatchClearRequest(service, body, spreadsheetId);
            }

            /// <summary>
            /// Clears one or more ranges of values from a spreadsheet. The caller must specify the spreadsheet ID and
            /// one or more ranges. Only values are cleared -- all other properties of the cell (such as formatting,
            /// data validation, etc..) are kept.
            /// </summary>
            public class BatchClearRequest : SheetsBaseServiceRequest<Google.Apis.Sheets.v4.Data.BatchClearValuesResponse>
            {
                /// <summary>Constructs a new BatchClear request.</summary>
                public BatchClearRequest(Google.Apis.Services.IClientService service, Google.Apis.Sheets.v4.Data.BatchClearValuesRequest body, string spreadsheetId) : base(service)
                {
                    SpreadsheetId = spreadsheetId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The ID of the spreadsheet to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("spreadsheetId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SpreadsheetId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Sheets.v4.Data.BatchClearValuesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchClear";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v4/spreadsheets/{spreadsheetId}/values:batchClear";

                /// <summary>Initializes BatchClear parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("spreadsheetId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "spreadsheetId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Clears one or more ranges of values from a spreadsheet. The caller must specify the spreadsheet ID and
            /// one or more DataFilters. Ranges matching any of the specified data filters will be cleared. Only values
            /// are cleared -- all other properties of the cell (such as formatting, data validation, etc..) are kept.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="spreadsheetId">The ID of the spreadsheet to update.</param>
            public virtual BatchClearByDataFilterRequest BatchClearByDataFilter(Google.Apis.Sheets.v4.Data.BatchClearValuesByDataFilterRequest body, string spreadsheetId)
            {
                return new BatchClearByDataFilterRequest(service, body, spreadsheetId);
            }

            /// <summary>
            /// Clears one or more ranges of values from a spreadsheet. The caller must specify the spreadsheet ID and
            /// one or more DataFilters. Ranges matching any of the specified data filters will be cleared. Only values
            /// are cleared -- all other properties of the cell (such as formatting, data validation, etc..) are kept.
            /// </summary>
            public class BatchClearByDataFilterRequest : SheetsBaseServiceRequest<Google.Apis.Sheets.v4.Data.BatchClearValuesByDataFilterResponse>
            {
                /// <summary>Constructs a new BatchClearByDataFilter request.</summary>
                public BatchClearByDataFilterRequest(Google.Apis.Services.IClientService service, Google.Apis.Sheets.v4.Data.BatchClearValuesByDataFilterRequest body, string spreadsheetId) : base(service)
                {
                    SpreadsheetId = spreadsheetId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The ID of the spreadsheet to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("spreadsheetId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SpreadsheetId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Sheets.v4.Data.BatchClearValuesByDataFilterRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchClearByDataFilter";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v4/spreadsheets/{spreadsheetId}/values:batchClearByDataFilter";

                /// <summary>Initializes BatchClearByDataFilter parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("spreadsheetId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "spreadsheetId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns one or more ranges of values from a spreadsheet. The caller must specify the spreadsheet ID and
            /// one or more ranges.
            /// </summary>
            /// <param name="spreadsheetId">The ID of the spreadsheet to retrieve data from.</param>
            public virtual BatchGetRequest BatchGet(string spreadsheetId)
            {
                return new BatchGetRequest(service, spreadsheetId);
            }

            /// <summary>
            /// Returns one or more ranges of values from a spreadsheet. The caller must specify the spreadsheet ID and
            /// one or more ranges.
            /// </summary>
            public class BatchGetRequest : SheetsBaseServiceRequest<Google.Apis.Sheets.v4.Data.BatchGetValuesResponse>
            {
                /// <summary>Constructs a new BatchGet request.</summary>
                public BatchGetRequest(Google.Apis.Services.IClientService service, string spreadsheetId) : base(service)
                {
                    SpreadsheetId = spreadsheetId;
                    InitParameters();
                }

                /// <summary>The ID of the spreadsheet to retrieve data from.</summary>
                [Google.Apis.Util.RequestParameterAttribute("spreadsheetId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SpreadsheetId { get; private set; }

                /// <summary>
                /// How dates, times, and durations should be represented in the output. This is ignored if
                /// value_render_option is FORMATTED_VALUE. The default dateTime render option is SERIAL_NUMBER.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dateTimeRenderOption", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<DateTimeRenderOptionEnum> DateTimeRenderOption { get; set; }

                /// <summary>
                /// How dates, times, and durations should be represented in the output. This is ignored if
                /// value_render_option is FORMATTED_VALUE. The default dateTime render option is SERIAL_NUMBER.
                /// </summary>
                public enum DateTimeRenderOptionEnum
                {
                    /// <summary>
                    /// Instructs date, time, datetime, and duration fields to be output as doubles in "serial number"
                    /// format, as popularized by Lotus 1-2-3. The whole number portion of the value (left of the
                    /// decimal) counts the days since December 30th 1899. The fractional portion (right of the decimal)
                    /// counts the time as a fraction of the day. For example, January 1st 1900 at noon would be 2.5, 2
                    /// because it's 2 days after December 30st 1899, and .5 because noon is half a day. February 1st
                    /// 1900 at 3pm would be 33.625. This correctly treats the year 1900 as not a leap year.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SERIAL_NUMBER")]
                    SERIALNUMBER = 0,

                    /// <summary>
                    /// Instructs date, time, datetime, and duration fields to be output as strings in their given
                    /// number format (which is dependent on the spreadsheet locale).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FORMATTED_STRING")]
                    FORMATTEDSTRING = 1,
                }

                /// <summary>
                /// The major dimension that results should use. For example, if the spreadsheet data is:
                /// `A1=1,B1=2,A2=3,B2=4`, then requesting `range=A1:B2,majorDimension=ROWS` returns `[[1,2],[3,4]]`,
                /// whereas requesting `range=A1:B2,majorDimension=COLUMNS` returns `[[1,3],[2,4]]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("majorDimension", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<MajorDimensionEnum> MajorDimension { get; set; }

                /// <summary>
                /// The major dimension that results should use. For example, if the spreadsheet data is:
                /// `A1=1,B1=2,A2=3,B2=4`, then requesting `range=A1:B2,majorDimension=ROWS` returns `[[1,2],[3,4]]`,
                /// whereas requesting `range=A1:B2,majorDimension=COLUMNS` returns `[[1,3],[2,4]]`.
                /// </summary>
                public enum MajorDimensionEnum
                {
                    /// <summary>The default value, do not use.</summary>
                    [Google.Apis.Util.StringValueAttribute("DIMENSION_UNSPECIFIED")]
                    DIMENSIONUNSPECIFIED = 0,

                    /// <summary>Operates on the rows of a sheet.</summary>
                    [Google.Apis.Util.StringValueAttribute("ROWS")]
                    ROWS = 1,

                    /// <summary>Operates on the columns of a sheet.</summary>
                    [Google.Apis.Util.StringValueAttribute("COLUMNS")]
                    COLUMNS = 2,
                }

                /// <summary>The A1 notation or R1C1 notation of the range to retrieve values from.</summary>
                [Google.Apis.Util.RequestParameterAttribute("ranges", Google.Apis.Util.RequestParameterType.Query)]
                public virtual Google.Apis.Util.Repeatable<string> Ranges { get; set; }

                /// <summary>
                /// How values should be represented in the output. The default render option is
                /// ValueRenderOption.FORMATTED_VALUE.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("valueRenderOption", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ValueRenderOptionEnum> ValueRenderOption { get; set; }

                /// <summary>
                /// How values should be represented in the output. The default render option is
                /// ValueRenderOption.FORMATTED_VALUE.
                /// </summary>
                public enum ValueRenderOptionEnum
                {
                    /// <summary>
                    /// Values will be calculated &amp;amp; formatted in the reply according to the cell's formatting.
                    /// Formatting is based on the spreadsheet's locale, not the requesting user's locale. For example,
                    /// if `A1` is `1.23` and `A2` is `=A1` and formatted as currency, then `A2` would return `"$1.23"`.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FORMATTED_VALUE")]
                    FORMATTEDVALUE = 0,

                    /// <summary>
                    /// Values will be calculated, but not formatted in the reply. For example, if `A1` is `1.23` and
                    /// `A2` is `=A1` and formatted as currency, then `A2` would return the number `1.23`.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("UNFORMATTED_VALUE")]
                    UNFORMATTEDVALUE = 1,

                    /// <summary>
                    /// Values will not be calculated. The reply will include the formulas. For example, if `A1` is
                    /// `1.23` and `A2` is `=A1` and formatted as currency, then A2 would return `"=A1"`.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FORMULA")]
                    FORMULA = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchGet";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v4/spreadsheets/{spreadsheetId}/values:batchGet";

                /// <summary>Initializes BatchGet parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("spreadsheetId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "spreadsheetId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("dateTimeRenderOption", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dateTimeRenderOption",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("majorDimension", new Google.Apis.Discovery.Parameter
                    {
                        Name = "majorDimension",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("ranges", new Google.Apis.Discovery.Parameter
                    {
                        Name = "ranges",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("valueRenderOption", new Google.Apis.Discovery.Parameter
                    {
                        Name = "valueRenderOption",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns one or more ranges of values that match the specified data filters. The caller must specify the
            /// spreadsheet ID and one or more DataFilters. Ranges that match any of the data filters in the request
            /// will be returned.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="spreadsheetId">The ID of the spreadsheet to retrieve data from.</param>
            public virtual BatchGetByDataFilterRequest BatchGetByDataFilter(Google.Apis.Sheets.v4.Data.BatchGetValuesByDataFilterRequest body, string spreadsheetId)
            {
                return new BatchGetByDataFilterRequest(service, body, spreadsheetId);
            }

            /// <summary>
            /// Returns one or more ranges of values that match the specified data filters. The caller must specify the
            /// spreadsheet ID and one or more DataFilters. Ranges that match any of the data filters in the request
            /// will be returned.
            /// </summary>
            public class BatchGetByDataFilterRequest : SheetsBaseServiceRequest<Google.Apis.Sheets.v4.Data.BatchGetValuesByDataFilterResponse>
            {
                /// <summary>Constructs a new BatchGetByDataFilter request.</summary>
                public BatchGetByDataFilterRequest(Google.Apis.Services.IClientService service, Google.Apis.Sheets.v4.Data.BatchGetValuesByDataFilterRequest body, string spreadsheetId) : base(service)
                {
                    SpreadsheetId = spreadsheetId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The ID of the spreadsheet to retrieve data from.</summary>
                [Google.Apis.Util.RequestParameterAttribute("spreadsheetId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SpreadsheetId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Sheets.v4.Data.BatchGetValuesByDataFilterRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchGetByDataFilter";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v4/spreadsheets/{spreadsheetId}/values:batchGetByDataFilter";

                /// <summary>Initializes BatchGetByDataFilter parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("spreadsheetId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "spreadsheetId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Sets values in one or more ranges of a spreadsheet. The caller must specify the spreadsheet ID, a
            /// valueInputOption, and one or more ValueRanges.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="spreadsheetId">The ID of the spreadsheet to update.</param>
            public virtual BatchUpdateRequest BatchUpdate(Google.Apis.Sheets.v4.Data.BatchUpdateValuesRequest body, string spreadsheetId)
            {
                return new BatchUpdateRequest(service, body, spreadsheetId);
            }

            /// <summary>
            /// Sets values in one or more ranges of a spreadsheet. The caller must specify the spreadsheet ID, a
            /// valueInputOption, and one or more ValueRanges.
            /// </summary>
            public class BatchUpdateRequest : SheetsBaseServiceRequest<Google.Apis.Sheets.v4.Data.BatchUpdateValuesResponse>
            {
                /// <summary>Constructs a new BatchUpdate request.</summary>
                public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Sheets.v4.Data.BatchUpdateValuesRequest body, string spreadsheetId) : base(service)
                {
                    SpreadsheetId = spreadsheetId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The ID of the spreadsheet to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("spreadsheetId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SpreadsheetId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Sheets.v4.Data.BatchUpdateValuesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchUpdate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v4/spreadsheets/{spreadsheetId}/values:batchUpdate";

                /// <summary>Initializes BatchUpdate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("spreadsheetId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "spreadsheetId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Sets values in one or more ranges of a spreadsheet. The caller must specify the spreadsheet ID, a
            /// valueInputOption, and one or more DataFilterValueRanges.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="spreadsheetId">The ID of the spreadsheet to update.</param>
            public virtual BatchUpdateByDataFilterRequest BatchUpdateByDataFilter(Google.Apis.Sheets.v4.Data.BatchUpdateValuesByDataFilterRequest body, string spreadsheetId)
            {
                return new BatchUpdateByDataFilterRequest(service, body, spreadsheetId);
            }

            /// <summary>
            /// Sets values in one or more ranges of a spreadsheet. The caller must specify the spreadsheet ID, a
            /// valueInputOption, and one or more DataFilterValueRanges.
            /// </summary>
            public class BatchUpdateByDataFilterRequest : SheetsBaseServiceRequest<Google.Apis.Sheets.v4.Data.BatchUpdateValuesByDataFilterResponse>
            {
                /// <summary>Constructs a new BatchUpdateByDataFilter request.</summary>
                public BatchUpdateByDataFilterRequest(Google.Apis.Services.IClientService service, Google.Apis.Sheets.v4.Data.BatchUpdateValuesByDataFilterRequest body, string spreadsheetId) : base(service)
                {
                    SpreadsheetId = spreadsheetId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The ID of the spreadsheet to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("spreadsheetId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SpreadsheetId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Sheets.v4.Data.BatchUpdateValuesByDataFilterRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "batchUpdateByDataFilter";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v4/spreadsheets/{spreadsheetId}/values:batchUpdateByDataFilter";

                /// <summary>Initializes BatchUpdateByDataFilter parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("spreadsheetId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "spreadsheetId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Clears values from a spreadsheet. The caller must specify the spreadsheet ID and range. Only values are
            /// cleared -- all other properties of the cell (such as formatting, data validation, etc..) are kept.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="spreadsheetId">The ID of the spreadsheet to update.</param>
            /// <param name="range">The A1 notation or R1C1 notation of the values to clear.</param>
            public virtual ClearRequest Clear(Google.Apis.Sheets.v4.Data.ClearValuesRequest body, string spreadsheetId, string range)
            {
                return new ClearRequest(service, body, spreadsheetId, range);
            }

            /// <summary>
            /// Clears values from a spreadsheet. The caller must specify the spreadsheet ID and range. Only values are
            /// cleared -- all other properties of the cell (such as formatting, data validation, etc..) are kept.
            /// </summary>
            public class ClearRequest : SheetsBaseServiceRequest<Google.Apis.Sheets.v4.Data.ClearValuesResponse>
            {
                /// <summary>Constructs a new Clear request.</summary>
                public ClearRequest(Google.Apis.Services.IClientService service, Google.Apis.Sheets.v4.Data.ClearValuesRequest body, string spreadsheetId, string range) : base(service)
                {
                    SpreadsheetId = spreadsheetId;
                    Range = range;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The ID of the spreadsheet to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("spreadsheetId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SpreadsheetId { get; private set; }

                /// <summary>The A1 notation or R1C1 notation of the values to clear.</summary>
                [Google.Apis.Util.RequestParameterAttribute("range", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Range { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Sheets.v4.Data.ClearValuesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "clear";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v4/spreadsheets/{spreadsheetId}/values/{range}:clear";

                /// <summary>Initializes Clear parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("spreadsheetId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "spreadsheetId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("range", new Google.Apis.Discovery.Parameter
                    {
                        Name = "range",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns a range of values from a spreadsheet. The caller must specify the spreadsheet ID and a range.
            /// </summary>
            /// <param name="spreadsheetId">The ID of the spreadsheet to retrieve data from.</param>
            /// <param name="range">The A1 notation or R1C1 notation of the range to retrieve values from.</param>
            public virtual GetRequest Get(string spreadsheetId, string range)
            {
                return new GetRequest(service, spreadsheetId, range);
            }

            /// <summary>
            /// Returns a range of values from a spreadsheet. The caller must specify the spreadsheet ID and a range.
            /// </summary>
            public class GetRequest : SheetsBaseServiceRequest<Google.Apis.Sheets.v4.Data.ValueRange>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string spreadsheetId, string range) : base(service)
                {
                    SpreadsheetId = spreadsheetId;
                    Range = range;
                    InitParameters();
                }

                /// <summary>The ID of the spreadsheet to retrieve data from.</summary>
                [Google.Apis.Util.RequestParameterAttribute("spreadsheetId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SpreadsheetId { get; private set; }

                /// <summary>The A1 notation or R1C1 notation of the range to retrieve values from.</summary>
                [Google.Apis.Util.RequestParameterAttribute("range", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Range { get; private set; }

                /// <summary>
                /// How dates, times, and durations should be represented in the output. This is ignored if
                /// value_render_option is FORMATTED_VALUE. The default dateTime render option is SERIAL_NUMBER.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("dateTimeRenderOption", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<DateTimeRenderOptionEnum> DateTimeRenderOption { get; set; }

                /// <summary>
                /// How dates, times, and durations should be represented in the output. This is ignored if
                /// value_render_option is FORMATTED_VALUE. The default dateTime render option is SERIAL_NUMBER.
                /// </summary>
                public enum DateTimeRenderOptionEnum
                {
                    /// <summary>
                    /// Instructs date, time, datetime, and duration fields to be output as doubles in "serial number"
                    /// format, as popularized by Lotus 1-2-3. The whole number portion of the value (left of the
                    /// decimal) counts the days since December 30th 1899. The fractional portion (right of the decimal)
                    /// counts the time as a fraction of the day. For example, January 1st 1900 at noon would be 2.5, 2
                    /// because it's 2 days after December 30st 1899, and .5 because noon is half a day. February 1st
                    /// 1900 at 3pm would be 33.625. This correctly treats the year 1900 as not a leap year.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SERIAL_NUMBER")]
                    SERIALNUMBER = 0,

                    /// <summary>
                    /// Instructs date, time, datetime, and duration fields to be output as strings in their given
                    /// number format (which is dependent on the spreadsheet locale).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FORMATTED_STRING")]
                    FORMATTEDSTRING = 1,
                }

                /// <summary>
                /// The major dimension that results should use. For example, if the spreadsheet data is:
                /// `A1=1,B1=2,A2=3,B2=4`, then requesting `range=A1:B2,majorDimension=ROWS` returns `[[1,2],[3,4]]`,
                /// whereas requesting `range=A1:B2,majorDimension=COLUMNS` returns `[[1,3],[2,4]]`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("majorDimension", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<MajorDimensionEnum> MajorDimension { get; set; }

                /// <summary>
                /// The major dimension that results should use. For example, if the spreadsheet data is:
                /// `A1=1,B1=2,A2=3,B2=4`, then requesting `range=A1:B2,majorDimension=ROWS` returns `[[1,2],[3,4]]`,
                /// whereas requesting `range=A1:B2,majorDimension=COLUMNS` returns `[[1,3],[2,4]]`.
                /// </summary>
                public enum MajorDimensionEnum
                {
                    /// <summary>The default value, do not use.</summary>
                    [Google.Apis.Util.StringValueAttribute("DIMENSION_UNSPECIFIED")]
                    DIMENSIONUNSPECIFIED = 0,

                    /// <summary>Operates on the rows of a sheet.</summary>
                    [Google.Apis.Util.StringValueAttribute("ROWS")]
                    ROWS = 1,

                    /// <summary>Operates on the columns of a sheet.</summary>
                    [Google.Apis.Util.StringValueAttribute("COLUMNS")]
                    COLUMNS = 2,
                }

                /// <summary>
                /// How values should be represented in the output. The default render option is FORMATTED_VALUE.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("valueRenderOption", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ValueRenderOptionEnum> ValueRenderOption { get; set; }

                /// <summary>
                /// How values should be represented in the output. The default render option is FORMATTED_VALUE.
                /// </summary>
                public enum ValueRenderOptionEnum
                {
                    /// <summary>
                    /// Values will be calculated &amp;amp; formatted in the reply according to the cell's formatting.
                    /// Formatting is based on the spreadsheet's locale, not the requesting user's locale. For example,
                    /// if `A1` is `1.23` and `A2` is `=A1` and formatted as currency, then `A2` would return `"$1.23"`.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FORMATTED_VALUE")]
                    FORMATTEDVALUE = 0,

                    /// <summary>
                    /// Values will be calculated, but not formatted in the reply. For example, if `A1` is `1.23` and
                    /// `A2` is `=A1` and formatted as currency, then `A2` would return the number `1.23`.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("UNFORMATTED_VALUE")]
                    UNFORMATTEDVALUE = 1,

                    /// <summary>
                    /// Values will not be calculated. The reply will include the formulas. For example, if `A1` is
                    /// `1.23` and `A2` is `=A1` and formatted as currency, then A2 would return `"=A1"`.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FORMULA")]
                    FORMULA = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v4/spreadsheets/{spreadsheetId}/values/{range}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("spreadsheetId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "spreadsheetId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("range", new Google.Apis.Discovery.Parameter
                    {
                        Name = "range",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("dateTimeRenderOption", new Google.Apis.Discovery.Parameter
                    {
                        Name = "dateTimeRenderOption",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("majorDimension", new Google.Apis.Discovery.Parameter
                    {
                        Name = "majorDimension",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("valueRenderOption", new Google.Apis.Discovery.Parameter
                    {
                        Name = "valueRenderOption",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Sets values in a range of a spreadsheet. The caller must specify the spreadsheet ID, range, and a
            /// valueInputOption.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="spreadsheetId">The ID of the spreadsheet to update.</param>
            /// <param name="range">The A1 notation of the values to update.</param>
            public virtual UpdateRequest Update(Google.Apis.Sheets.v4.Data.ValueRange body, string spreadsheetId, string range)
            {
                return new UpdateRequest(service, body, spreadsheetId, range);
            }

            /// <summary>
            /// Sets values in a range of a spreadsheet. The caller must specify the spreadsheet ID, range, and a
            /// valueInputOption.
            /// </summary>
            public class UpdateRequest : SheetsBaseServiceRequest<Google.Apis.Sheets.v4.Data.UpdateValuesResponse>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Sheets.v4.Data.ValueRange body, string spreadsheetId, string range) : base(service)
                {
                    SpreadsheetId = spreadsheetId;
                    Range = range;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The ID of the spreadsheet to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("spreadsheetId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string SpreadsheetId { get; private set; }

                /// <summary>The A1 notation of the values to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("range", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Range { get; private set; }

                /// <summary>
                /// Determines if the update response should include the values of the cells that were updated. By
                /// default, responses do not include the updated values. If the range to write was larger than the
                /// range actually written, the response includes all values in the requested range (excluding trailing
                /// empty rows and columns).
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("includeValuesInResponse", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<bool> IncludeValuesInResponse { get; set; }

                /// <summary>
                /// Determines how dates, times, and durations in the response should be rendered. This is ignored if
                /// response_value_render_option is FORMATTED_VALUE. The default dateTime render option is
                /// SERIAL_NUMBER.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("responseDateTimeRenderOption", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ResponseDateTimeRenderOptionEnum> ResponseDateTimeRenderOption { get; set; }

                /// <summary>
                /// Determines how dates, times, and durations in the response should be rendered. This is ignored if
                /// response_value_render_option is FORMATTED_VALUE. The default dateTime render option is
                /// SERIAL_NUMBER.
                /// </summary>
                public enum ResponseDateTimeRenderOptionEnum
                {
                    /// <summary>
                    /// Instructs date, time, datetime, and duration fields to be output as doubles in "serial number"
                    /// format, as popularized by Lotus 1-2-3. The whole number portion of the value (left of the
                    /// decimal) counts the days since December 30th 1899. The fractional portion (right of the decimal)
                    /// counts the time as a fraction of the day. For example, January 1st 1900 at noon would be 2.5, 2
                    /// because it's 2 days after December 30st 1899, and .5 because noon is half a day. February 1st
                    /// 1900 at 3pm would be 33.625. This correctly treats the year 1900 as not a leap year.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("SERIAL_NUMBER")]
                    SERIALNUMBER = 0,

                    /// <summary>
                    /// Instructs date, time, datetime, and duration fields to be output as strings in their given
                    /// number format (which is dependent on the spreadsheet locale).
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FORMATTED_STRING")]
                    FORMATTEDSTRING = 1,
                }

                /// <summary>
                /// Determines how values in the response should be rendered. The default render option is
                /// FORMATTED_VALUE.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("responseValueRenderOption", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ResponseValueRenderOptionEnum> ResponseValueRenderOption { get; set; }

                /// <summary>
                /// Determines how values in the response should be rendered. The default render option is
                /// FORMATTED_VALUE.
                /// </summary>
                public enum ResponseValueRenderOptionEnum
                {
                    /// <summary>
                    /// Values will be calculated &amp;amp; formatted in the reply according to the cell's formatting.
                    /// Formatting is based on the spreadsheet's locale, not the requesting user's locale. For example,
                    /// if `A1` is `1.23` and `A2` is `=A1` and formatted as currency, then `A2` would return `"$1.23"`.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FORMATTED_VALUE")]
                    FORMATTEDVALUE = 0,

                    /// <summary>
                    /// Values will be calculated, but not formatted in the reply. For example, if `A1` is `1.23` and
                    /// `A2` is `=A1` and formatted as currency, then `A2` would return the number `1.23`.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("UNFORMATTED_VALUE")]
                    UNFORMATTEDVALUE = 1,

                    /// <summary>
                    /// Values will not be calculated. The reply will include the formulas. For example, if `A1` is
                    /// `1.23` and `A2` is `=A1` and formatted as currency, then A2 would return `"=A1"`.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("FORMULA")]
                    FORMULA = 2,
                }

                /// <summary>How the input data should be interpreted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("valueInputOption", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ValueInputOptionEnum> ValueInputOption { get; set; }

                /// <summary>How the input data should be interpreted.</summary>
                public enum ValueInputOptionEnum
                {
                    /// <summary>Default input value. This value must not be used.</summary>
                    [Google.Apis.Util.StringValueAttribute("INPUT_VALUE_OPTION_UNSPECIFIED")]
                    INPUTVALUEOPTIONUNSPECIFIED = 0,

                    /// <summary>The values the user has entered will not be parsed and will be stored as-is.</summary>
                    [Google.Apis.Util.StringValueAttribute("RAW")]
                    RAW = 1,

                    /// <summary>
                    /// The values will be parsed as if the user typed them into the UI. Numbers will stay as numbers,
                    /// but strings may be converted to numbers, dates, etc. following the same rules that are applied
                    /// when entering text into a cell via the Google Sheets UI.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("USER_ENTERED")]
                    USERENTERED = 2,
                }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Sheets.v4.Data.ValueRange Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "update";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v4/spreadsheets/{spreadsheetId}/values/{range}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("spreadsheetId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "spreadsheetId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("range", new Google.Apis.Discovery.Parameter
                    {
                        Name = "range",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("includeValuesInResponse", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeValuesInResponse",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("responseDateTimeRenderOption", new Google.Apis.Discovery.Parameter
                    {
                        Name = "responseDateTimeRenderOption",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("responseValueRenderOption", new Google.Apis.Discovery.Parameter
                    {
                        Name = "responseValueRenderOption",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("valueInputOption", new Google.Apis.Discovery.Parameter
                    {
                        Name = "valueInputOption",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>
        /// Applies one or more updates to the spreadsheet. Each request is validated before being applied. If any
        /// request is not valid then the entire request will fail and nothing will be applied. Some requests have
        /// replies to give you some information about how they are applied. The replies will mirror the requests. For
        /// example, if you applied 4 updates and the 3rd one had a reply, then the response will have 2 empty replies,
        /// the actual reply, and another empty reply, in that order. Due to the collaborative nature of spreadsheets,
        /// it is not guaranteed that the spreadsheet will reflect exactly your changes after this completes, however it
        /// is guaranteed that the updates in the request will be applied together atomically. Your changes may be
        /// altered with respect to collaborator changes. If there are no collaborators, the spreadsheet should reflect
        /// your changes.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="spreadsheetId">The spreadsheet to apply the updates to.</param>
        public virtual BatchUpdateRequest BatchUpdate(Google.Apis.Sheets.v4.Data.BatchUpdateSpreadsheetRequest body, string spreadsheetId)
        {
            return new BatchUpdateRequest(service, body, spreadsheetId);
        }

        /// <summary>
        /// Applies one or more updates to the spreadsheet. Each request is validated before being applied. If any
        /// request is not valid then the entire request will fail and nothing will be applied. Some requests have
        /// replies to give you some information about how they are applied. The replies will mirror the requests. For
        /// example, if you applied 4 updates and the 3rd one had a reply, then the response will have 2 empty replies,
        /// the actual reply, and another empty reply, in that order. Due to the collaborative nature of spreadsheets,
        /// it is not guaranteed that the spreadsheet will reflect exactly your changes after this completes, however it
        /// is guaranteed that the updates in the request will be applied together atomically. Your changes may be
        /// altered with respect to collaborator changes. If there are no collaborators, the spreadsheet should reflect
        /// your changes.
        /// </summary>
        public class BatchUpdateRequest : SheetsBaseServiceRequest<Google.Apis.Sheets.v4.Data.BatchUpdateSpreadsheetResponse>
        {
            /// <summary>Constructs a new BatchUpdate request.</summary>
            public BatchUpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Sheets.v4.Data.BatchUpdateSpreadsheetRequest body, string spreadsheetId) : base(service)
            {
                SpreadsheetId = spreadsheetId;
                Body = body;
                InitParameters();
            }

            /// <summary>The spreadsheet to apply the updates to.</summary>
            [Google.Apis.Util.RequestParameterAttribute("spreadsheetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SpreadsheetId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Sheets.v4.Data.BatchUpdateSpreadsheetRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "batchUpdate";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v4/spreadsheets/{spreadsheetId}:batchUpdate";

            /// <summary>Initializes BatchUpdate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("spreadsheetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "spreadsheetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>Creates a spreadsheet, returning the newly created spreadsheet.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Sheets.v4.Data.Spreadsheet body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates a spreadsheet, returning the newly created spreadsheet.</summary>
        public class CreateRequest : SheetsBaseServiceRequest<Google.Apis.Sheets.v4.Data.Spreadsheet>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Sheets.v4.Data.Spreadsheet body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Sheets.v4.Data.Spreadsheet Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v4/spreadsheets";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Returns the spreadsheet at the given ID. The caller must specify the spreadsheet ID. By default, data within
        /// grids will not be returned. You can include grid data one of two ways: * Specify a field mask listing your
        /// desired fields using the `fields` URL parameter in HTTP * Set the includeGridData URL parameter to true. If
        /// a field mask is set, the `includeGridData` parameter is ignored For large spreadsheets, it is recommended to
        /// retrieve only the specific fields of the spreadsheet that you want. To retrieve only subsets of the
        /// spreadsheet, use the ranges URL parameter. Multiple ranges can be specified. Limiting the range will return
        /// only the portions of the spreadsheet that intersect the requested ranges. Ranges are specified using A1
        /// notation.
        /// </summary>
        /// <param name="spreadsheetId">The spreadsheet to request.</param>
        public virtual GetRequest Get(string spreadsheetId)
        {
            return new GetRequest(service, spreadsheetId);
        }

        /// <summary>
        /// Returns the spreadsheet at the given ID. The caller must specify the spreadsheet ID. By default, data within
        /// grids will not be returned. You can include grid data one of two ways: * Specify a field mask listing your
        /// desired fields using the `fields` URL parameter in HTTP * Set the includeGridData URL parameter to true. If
        /// a field mask is set, the `includeGridData` parameter is ignored For large spreadsheets, it is recommended to
        /// retrieve only the specific fields of the spreadsheet that you want. To retrieve only subsets of the
        /// spreadsheet, use the ranges URL parameter. Multiple ranges can be specified. Limiting the range will return
        /// only the portions of the spreadsheet that intersect the requested ranges. Ranges are specified using A1
        /// notation.
        /// </summary>
        public class GetRequest : SheetsBaseServiceRequest<Google.Apis.Sheets.v4.Data.Spreadsheet>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string spreadsheetId) : base(service)
            {
                SpreadsheetId = spreadsheetId;
                InitParameters();
            }

            /// <summary>The spreadsheet to request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("spreadsheetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SpreadsheetId { get; private set; }

            /// <summary>
            /// True if grid data should be returned. This parameter is ignored if a field mask was set in the request.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("includeGridData", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeGridData { get; set; }

            /// <summary>The ranges to retrieve from the spreadsheet.</summary>
            [Google.Apis.Util.RequestParameterAttribute("ranges", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Ranges { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v4/spreadsheets/{spreadsheetId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("spreadsheetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "spreadsheetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeGridData", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeGridData",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("ranges", new Google.Apis.Discovery.Parameter
                {
                    Name = "ranges",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Returns the spreadsheet at the given ID. The caller must specify the spreadsheet ID. This method differs
        /// from GetSpreadsheet in that it allows selecting which subsets of spreadsheet data to return by specifying a
        /// dataFilters parameter. Multiple DataFilters can be specified. Specifying one or more data filters will
        /// return the portions of the spreadsheet that intersect ranges matched by any of the filters. By default, data
        /// within grids will not be returned. You can include grid data one of two ways: * Specify a field mask listing
        /// your desired fields using the `fields` URL parameter in HTTP * Set the includeGridData parameter to true. If
        /// a field mask is set, the `includeGridData` parameter is ignored For large spreadsheets, it is recommended to
        /// retrieve only the specific fields of the spreadsheet that you want.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="spreadsheetId">The spreadsheet to request.</param>
        public virtual GetByDataFilterRequest GetByDataFilter(Google.Apis.Sheets.v4.Data.GetSpreadsheetByDataFilterRequest body, string spreadsheetId)
        {
            return new GetByDataFilterRequest(service, body, spreadsheetId);
        }

        /// <summary>
        /// Returns the spreadsheet at the given ID. The caller must specify the spreadsheet ID. This method differs
        /// from GetSpreadsheet in that it allows selecting which subsets of spreadsheet data to return by specifying a
        /// dataFilters parameter. Multiple DataFilters can be specified. Specifying one or more data filters will
        /// return the portions of the spreadsheet that intersect ranges matched by any of the filters. By default, data
        /// within grids will not be returned. You can include grid data one of two ways: * Specify a field mask listing
        /// your desired fields using the `fields` URL parameter in HTTP * Set the includeGridData parameter to true. If
        /// a field mask is set, the `includeGridData` parameter is ignored For large spreadsheets, it is recommended to
        /// retrieve only the specific fields of the spreadsheet that you want.
        /// </summary>
        public class GetByDataFilterRequest : SheetsBaseServiceRequest<Google.Apis.Sheets.v4.Data.Spreadsheet>
        {
            /// <summary>Constructs a new GetByDataFilter request.</summary>
            public GetByDataFilterRequest(Google.Apis.Services.IClientService service, Google.Apis.Sheets.v4.Data.GetSpreadsheetByDataFilterRequest body, string spreadsheetId) : base(service)
            {
                SpreadsheetId = spreadsheetId;
                Body = body;
                InitParameters();
            }

            /// <summary>The spreadsheet to request.</summary>
            [Google.Apis.Util.RequestParameterAttribute("spreadsheetId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SpreadsheetId { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Sheets.v4.Data.GetSpreadsheetByDataFilterRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getByDataFilter";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v4/spreadsheets/{spreadsheetId}:getByDataFilter";

            /// <summary>Initializes GetByDataFilter parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("spreadsheetId", new Google.Apis.Discovery.Parameter
                {
                    Name = "spreadsheetId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Sheets.v4.Data
{
    /// <summary>Adds a new banded range to the spreadsheet.</summary>
    public class AddBandingRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The banded range to add. The bandedRangeId field is optional; if one is not set, an id will be randomly
        /// generated. (It is an error to specify the ID of a range that already exists.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bandedRange")]
        public virtual BandedRange BandedRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of adding a banded range.</summary>
    public class AddBandingResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The banded range that was added.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bandedRange")]
        public virtual BandedRange BandedRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Adds a chart to a sheet in the spreadsheet.</summary>
    public class AddChartRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The chart that should be added to the spreadsheet, including the position where it should be placed. The
        /// chartId field is optional; if one is not set, an id will be randomly generated. (It is an error to specify
        /// the ID of an embedded object that already exists.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chart")]
        public virtual EmbeddedChart Chart { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of adding a chart to a spreadsheet.</summary>
    public class AddChartResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The newly added chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chart")]
        public virtual EmbeddedChart Chart { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Adds a new conditional format rule at the given index. All subsequent rules' indexes are incremented.
    /// </summary>
    public class AddConditionalFormatRuleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The zero-based index where the rule should be inserted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>The rule to add.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rule")]
        public virtual ConditionalFormatRule Rule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Adds a data source. After the data source is added successfully, an associated DATA_SOURCE sheet is created and
    /// an execution is triggered to refresh the sheet to read data from the data source. The request requires an
    /// additional `bigquery.readonly` OAuth scope.
    /// </summary>
    public class AddDataSourceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data source to add.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSource")]
        public virtual DataSource DataSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of adding a data source.</summary>
    public class AddDataSourceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data execution status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataExecutionStatus")]
        public virtual DataExecutionStatus DataExecutionStatus { get; set; }

        /// <summary>The data source that was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSource")]
        public virtual DataSource DataSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Creates a group over the specified range. If the requested range is a superset of the range of an existing group
    /// G, then the depth of G is incremented and this new group G' has the depth of that group. For example, a group
    /// [C:D, depth 1] + [B:E] results in groups [B:E, depth 1] and [C:D, depth 2]. If the requested range is a subset
    /// of the range of an existing group G, then the depth of the new group G' becomes one greater than the depth of G.
    /// For example, a group [B:E, depth 1] + [C:D] results in groups [B:E, depth 1] and [C:D, depth 2]. If the
    /// requested range starts before and ends within, or starts within and ends after, the range of an existing group
    /// G, then the range of the existing group G becomes the union of the ranges, and the new group G' has depth one
    /// greater than the depth of G and range as the intersection of the ranges. For example, a group [B:D, depth 1] +
    /// [C:E] results in groups [B:E, depth 1] and [C:D, depth 2].
    /// </summary>
    public class AddDimensionGroupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The range over which to create a group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual DimensionRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of adding a group.</summary>
    public class AddDimensionGroupResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All groups of a dimension after adding a group to that dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionGroups")]
        public virtual System.Collections.Generic.IList<DimensionGroup> DimensionGroups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Adds a filter view.</summary>
    public class AddFilterViewRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The filter to add. The filterViewId field is optional; if one is not set, an id will be randomly generated.
        /// (It is an error to specify the ID of a filter that already exists.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual FilterView Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of adding a filter view.</summary>
    public class AddFilterViewResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The newly added filter view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual FilterView Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Adds a named range to the spreadsheet.</summary>
    public class AddNamedRangeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The named range to add. The namedRangeId field is optional; if one is not set, an id will be randomly
        /// generated. (It is an error to specify the ID of a range that already exists.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedRange")]
        public virtual NamedRange NamedRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of adding a named range.</summary>
    public class AddNamedRangeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The named range to add.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedRange")]
        public virtual NamedRange NamedRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Adds a new protected range.</summary>
    public class AddProtectedRangeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The protected range to be added. The protectedRangeId field is optional; if one is not set, an id will be
        /// randomly generated. (It is an error to specify the ID of a range that already exists.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectedRange")]
        public virtual ProtectedRange ProtectedRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of adding a new protected range.</summary>
    public class AddProtectedRangeResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The newly added protected range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectedRange")]
        public virtual ProtectedRange ProtectedRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Adds a new sheet. When a sheet is added at a given index, all subsequent sheets' indexes are incremented. To add
    /// an object sheet, use AddChartRequest instead and specify EmbeddedObjectPosition.sheetId or
    /// EmbeddedObjectPosition.newSheet.
    /// </summary>
    public class AddSheetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The properties the new sheet should have. All properties are optional. The sheetId field is optional; if one
        /// is not set, an id will be randomly generated. (It is an error to specify the ID of a sheet that already
        /// exists.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual SheetProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of adding a sheet.</summary>
    public class AddSheetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The properties of the newly added sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual SheetProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Adds a slicer to a sheet in the spreadsheet.</summary>
    public class AddSlicerRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The slicer that should be added to the spreadsheet, including the position where it should be placed. The
        /// slicerId field is optional; if one is not set, an id will be randomly generated. (It is an error to specify
        /// the ID of a slicer that already exists.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slicer")]
        public virtual Slicer Slicer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of adding a slicer to a spreadsheet.</summary>
    public class AddSlicerResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The newly added slicer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slicer")]
        public virtual Slicer Slicer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Adds new cells after the last row with data in a sheet, inserting new rows into the sheet if necessary.
    /// </summary>
    public class AppendCellsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields of CellData that should be updated. At least one field must be specified. The root is the
        /// CellData; 'row.values.' should not be specified. A single `"*"` can be used as short-hand for listing every
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The data to append.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<RowData> Rows { get; set; }

        /// <summary>The sheet ID to append the data to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetId")]
        public virtual System.Nullable<int> SheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Appends rows or columns to the end of a sheet.</summary>
    public class AppendDimensionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether rows or columns should be appended.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        /// <summary>The number of rows or columns to append.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("length")]
        public virtual System.Nullable<int> Length { get; set; }

        /// <summary>The sheet to append rows or columns to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetId")]
        public virtual System.Nullable<int> SheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response when updating a range of values in a spreadsheet.</summary>
    public class AppendValuesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The spreadsheet the updates were applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheetId")]
        public virtual string SpreadsheetId { get; set; }

        /// <summary>
        /// The range (in A1 notation) of the table that values are being appended to (before the values were appended).
        /// Empty if no table was found.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableRange")]
        public virtual string TableRange { get; set; }

        /// <summary>Information about the updates that were applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updates")]
        public virtual UpdateValuesResponse Updates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Fills in more data based on existing data.</summary>
    public class AutoFillRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The range to autofill. This will examine the range and detect the location that has data and automatically
        /// fill that data in to the rest of the range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>
        /// The source and destination areas to autofill. This explicitly lists the source of the autofill and where to
        /// extend that data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceAndDestination")]
        public virtual SourceAndDestination SourceAndDestination { get; set; }

        /// <summary>
        /// True if we should generate data with the "alternate" series. This differs based on the type and amount of
        /// source data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useAlternateSeries")]
        public virtual System.Nullable<bool> UseAlternateSeries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Automatically resizes one or more dimensions based on the contents of the cells in that dimension.
    /// </summary>
    public class AutoResizeDimensionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dimensions on a data source sheet to automatically resize.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceSheetDimensions")]
        public virtual DataSourceSheetDimensionRange DataSourceSheetDimensions { get; set; }

        /// <summary>The dimensions to automatically resize.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual DimensionRange Dimensions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A banded (alternating colors) range in a sheet.</summary>
    public class BandedRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id of the banded range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bandedRangeId")]
        public virtual System.Nullable<int> BandedRangeId { get; set; }

        /// <summary>
        /// Properties for column bands. These properties are applied on a column- by-column basis throughout all the
        /// columns in the range. At least one of row_properties or column_properties must be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnProperties")]
        public virtual BandingProperties ColumnProperties { get; set; }

        /// <summary>The range over which these properties are applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>
        /// Properties for row bands. These properties are applied on a row-by-row basis throughout all the rows in the
        /// range. At least one of row_properties or column_properties must be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowProperties")]
        public virtual BandingProperties RowProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Properties referring a single dimension (either row or column). If both BandedRange.row_properties and
    /// BandedRange.column_properties are set, the fill colors are applied to cells according to the following rules: *
    /// header_color and footer_color take priority over band colors. * first_band_color takes priority over
    /// second_band_color. * row_properties takes priority over column_properties. For example, the first row color
    /// takes priority over the first column color, but the first column color takes priority over the second row color.
    /// Similarly, the row header takes priority over the column header in the top left cell, but the column header
    /// takes priority over the first row color if the row header is not set.
    /// </summary>
    public class BandingProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The first color that is alternating. (Required)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstBandColor")]
        public virtual Color FirstBandColor { get; set; }

        /// <summary>
        /// The first color that is alternating. (Required) If first_band_color is also set, this field takes
        /// precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstBandColorStyle")]
        public virtual ColorStyle FirstBandColorStyle { get; set; }

        /// <summary>
        /// The color of the last row or column. If this field is not set, the last row or column is filled with either
        /// first_band_color or second_band_color, depending on the color of the previous row or column.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footerColor")]
        public virtual Color FooterColor { get; set; }

        /// <summary>
        /// The color of the last row or column. If this field is not set, the last row or column is filled with either
        /// first_band_color or second_band_color, depending on the color of the previous row or column. If footer_color
        /// is also set, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footerColorStyle")]
        public virtual ColorStyle FooterColorStyle { get; set; }

        /// <summary>
        /// The color of the first row or column. If this field is set, the first row or column is filled with this
        /// color and the colors alternate between first_band_color and second_band_color starting from the second row
        /// or column. Otherwise, the first row or column is filled with first_band_color and the colors proceed to
        /// alternate as they normally would.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerColor")]
        public virtual Color HeaderColor { get; set; }

        /// <summary>
        /// The color of the first row or column. If this field is set, the first row or column is filled with this
        /// color and the colors alternate between first_band_color and second_band_color starting from the second row
        /// or column. Otherwise, the first row or column is filled with first_band_color and the colors proceed to
        /// alternate as they normally would. If header_color is also set, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerColorStyle")]
        public virtual ColorStyle HeaderColorStyle { get; set; }

        /// <summary>The second color that is alternating. (Required)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondBandColor")]
        public virtual Color SecondBandColor { get; set; }

        /// <summary>
        /// The second color that is alternating. (Required) If second_band_color is also set, this field takes
        /// precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("secondBandColorStyle")]
        public virtual ColorStyle SecondBandColorStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Formatting options for baseline value.</summary>
    public class BaselineValueFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The comparison type of key value with baseline value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comparisonType")]
        public virtual string ComparisonType { get; set; }

        /// <summary>Description which is appended after the baseline value. This field is optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Color to be used, in case baseline value represents a negative change for key value. This field is optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negativeColor")]
        public virtual Color NegativeColor { get; set; }

        /// <summary>
        /// Color to be used, in case baseline value represents a negative change for key value. This field is optional.
        /// If negative_color is also set, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negativeColorStyle")]
        public virtual ColorStyle NegativeColorStyle { get; set; }

        /// <summary>
        /// Specifies the horizontal text positioning of baseline value. This field is optional. If not specified,
        /// default positioning is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual TextPosition Position { get; set; }

        /// <summary>
        /// Color to be used, in case baseline value represents a positive change for key value. This field is optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("positiveColor")]
        public virtual Color PositiveColor { get; set; }

        /// <summary>
        /// Color to be used, in case baseline value represents a positive change for key value. This field is optional.
        /// If positive_color is also set, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("positiveColorStyle")]
        public virtual ColorStyle PositiveColorStyle { get; set; }

        /// <summary>Text formatting options for baseline value. The link field is not supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textFormat")]
        public virtual TextFormat TextFormat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An axis of the chart. A chart may not have more than one axis per axis position.</summary>
    public class BasicChartAxis : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The format of the title. Only valid if the axis is not associated with the domain. The link field is not
        /// supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual TextFormat Format { get; set; }

        /// <summary>The position of this axis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual string Position { get; set; }

        /// <summary>
        /// The title of this axis. If set, this overrides any title inferred from headers of the data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The axis title text position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("titleTextPosition")]
        public virtual TextPosition TitleTextPosition { get; set; }

        /// <summary>The view window options for this axis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewWindowOptions")]
        public virtual ChartAxisViewWindowOptions ViewWindowOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The domain of a chart. For example, if charting stock prices over time, this would be the date.
    /// </summary>
    public class BasicChartDomain : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The data of the domain. For example, if charting stock prices over time, this is the data representing the
        /// dates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual ChartData Domain { get; set; }

        /// <summary>True to reverse the order of the domain values (horizontal axis).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reversed")]
        public virtual System.Nullable<bool> Reversed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A single series of data in a chart. For example, if charting stock prices over time, multiple series may exist,
    /// one for the "Open Price", "High Price", "Low Price" and "Close Price".
    /// </summary>
    public class BasicChartSeries : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The color for elements (such as bars, lines, and points) associated with this series. If empty, a default
        /// color is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>
        /// The color for elements (such as bars, lines, and points) associated with this series. If empty, a default
        /// color is used. If color is also set, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorStyle")]
        public virtual ColorStyle ColorStyle { get; set; }

        /// <summary>Information about the data labels for this series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataLabel")]
        public virtual DataLabel DataLabel { get; set; }

        /// <summary>
        /// The line style of this series. Valid only if the chartType is AREA, LINE, or SCATTER. COMBO charts are also
        /// supported if the series chart type is AREA or LINE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineStyle")]
        public virtual LineStyle LineStyle { get; set; }

        /// <summary>
        /// The style for points associated with this series. Valid only if the chartType is AREA, LINE, or SCATTER.
        /// COMBO charts are also supported if the series chart type is AREA, LINE, or SCATTER. If empty, a default
        /// point style is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointStyle")]
        public virtual PointStyle PointStyle { get; set; }

        /// <summary>The data being visualized in this chart series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("series")]
        public virtual ChartData Series { get; set; }

        /// <summary>Style override settings for series data points.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("styleOverrides")]
        public virtual System.Collections.Generic.IList<BasicSeriesDataPointStyleOverride> StyleOverrides { get; set; }

        /// <summary>
        /// The minor axis that will specify the range of values for this series. For example, if charting stocks over
        /// time, the "Volume" series may want to be pinned to the right with the prices pinned to the left, because the
        /// scale of trading volume is different than the scale of prices. It is an error to specify an axis that isn't
        /// a valid minor axis for the chart's type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetAxis")]
        public virtual string TargetAxis { get; set; }

        /// <summary>
        /// The type of this series. Valid only if the chartType is COMBO. Different types will change the way the
        /// series is visualized. Only LINE, AREA, and COLUMN are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specification for a basic chart. See BasicChartType for the list of charts this supports.</summary>
    public class BasicChartSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The axis on the chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("axis")]
        public virtual System.Collections.Generic.IList<BasicChartAxis> Axis { get; set; }

        /// <summary>The type of the chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chartType")]
        public virtual string ChartType { get; set; }

        /// <summary>The behavior of tooltips and data highlighting when hovering on data and chart area.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compareMode")]
        public virtual string CompareMode { get; set; }

        /// <summary>The domain of data this is charting. Only a single domain is supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<BasicChartDomain> Domains { get; set; }

        /// <summary>
        /// The number of rows or columns in the data that are "headers". If not set, Google Sheets will guess how many
        /// rows are headers based on the data. (Note that BasicChartAxis.title may override the axis title inferred
        /// from the header values.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerCount")]
        public virtual System.Nullable<int> HeaderCount { get; set; }

        /// <summary>
        /// If some values in a series are missing, gaps may appear in the chart (e.g, segments of lines in a line chart
        /// will be missing). To eliminate these gaps set this to true. Applies to Line, Area, and Combo charts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interpolateNulls")]
        public virtual System.Nullable<bool> InterpolateNulls { get; set; }

        /// <summary>The position of the chart legend.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legendPosition")]
        public virtual string LegendPosition { get; set; }

        /// <summary>
        /// Gets whether all lines should be rendered smooth or straight by default. Applies to Line charts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lineSmoothing")]
        public virtual System.Nullable<bool> LineSmoothing { get; set; }

        /// <summary>The data this chart is visualizing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("series")]
        public virtual System.Collections.Generic.IList<BasicChartSeries> Series { get; set; }

        /// <summary>
        /// The stacked type for charts that support vertical stacking. Applies to Area, Bar, Column, Combo, and Stepped
        /// Area charts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackedType")]
        public virtual string StackedType { get; set; }

        /// <summary>True to make the chart 3D. Applies to Bar and Column charts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threeDimensional")]
        public virtual System.Nullable<bool> ThreeDimensional { get; set; }

        /// <summary>
        /// Controls whether to display additional data labels on stacked charts which sum the total value of all
        /// stacked values at each value along the domain axis. These data labels can only be set when chart_type is one
        /// of AREA, BAR, COLUMN, COMBO or STEPPED_AREA and stacked_type is either STACKED or PERCENT_STACKED. In
        /// addition, for COMBO, this will only be supported if there is only one type of stackable series type or one
        /// type has more series than the others and each of the other types have no more than one series. For example,
        /// if a chart has two stacked bar series and one area series, the total data labels will be supported. If it
        /// has three bar series and two area series, total data labels are not allowed. Neither CUSTOM nor placement
        /// can be set on the total_data_label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDataLabel")]
        public virtual DataLabel TotalDataLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The default filter associated with a sheet.</summary>
    public class BasicFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The criteria for showing/hiding values per column. The map's key is the column index, and the value is the
        /// criteria for that column. This field is deprecated in favor of filter_specs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("criteria")]
        public virtual System.Collections.Generic.IDictionary<string, FilterCriteria> Criteria { get; set; }

        /// <summary>
        /// The filter criteria per column. Both criteria and filter_specs are populated in responses. If both fields
        /// are specified in an update request, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterSpecs")]
        public virtual System.Collections.Generic.IList<FilterSpec> FilterSpecs { get; set; }

        /// <summary>The range the filter covers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>
        /// The sort order per column. Later specifications are used when values are equal in the earlier
        /// specifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortSpecs")]
        public virtual System.Collections.Generic.IList<SortSpec> SortSpecs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Style override settings for a single series data point.</summary>
    public class BasicSeriesDataPointStyleOverride : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Color of the series data point. If empty, the series default is used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>
        /// Color of the series data point. If empty, the series default is used. If color is also set, this field takes
        /// precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorStyle")]
        public virtual ColorStyle ColorStyle { get; set; }

        /// <summary>Zero based index of the series data point.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>
        /// Point style of the series data point. Valid only if the chartType is AREA, LINE, or SCATTER. COMBO charts
        /// are also supported if the series chart type is AREA, LINE, or SCATTER. If empty, the series default is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointStyle")]
        public virtual PointStyle PointStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for clearing more than one range selected by a DataFilter in a spreadsheet.</summary>
    public class BatchClearValuesByDataFilterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The DataFilters used to determine which ranges to clear.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataFilters")]
        public virtual System.Collections.Generic.IList<DataFilter> DataFilters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response when clearing a range of values selected with DataFilters in a spreadsheet.</summary>
    public class BatchClearValuesByDataFilterResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ranges that were cleared, in A1 notation. If the requests are for an unbounded range or a ranger larger
        /// than the bounds of the sheet, this is the actual ranges that were cleared, bounded to the sheet's limits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clearedRanges")]
        public virtual System.Collections.Generic.IList<string> ClearedRanges { get; set; }

        /// <summary>The spreadsheet the updates were applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheetId")]
        public virtual string SpreadsheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for clearing more than one range of values in a spreadsheet.</summary>
    public class BatchClearValuesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ranges to clear, in A1 or R1C1 notation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ranges")]
        public virtual System.Collections.Generic.IList<string> Ranges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response when clearing a range of values in a spreadsheet.</summary>
    public class BatchClearValuesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ranges that were cleared, in A1 notation. If the requests are for an unbounded range or a ranger larger
        /// than the bounds of the sheet, this is the actual ranges that were cleared, bounded to the sheet's limits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clearedRanges")]
        public virtual System.Collections.Generic.IList<string> ClearedRanges { get; set; }

        /// <summary>The spreadsheet the updates were applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheetId")]
        public virtual string SpreadsheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The request for retrieving a range of values in a spreadsheet selected by a set of DataFilters.
    /// </summary>
    public class BatchGetValuesByDataFilterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The data filters used to match the ranges of values to retrieve. Ranges that match any of the specified data
        /// filters are included in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataFilters")]
        public virtual System.Collections.Generic.IList<DataFilter> DataFilters { get; set; }

        /// <summary>
        /// How dates, times, and durations should be represented in the output. This is ignored if value_render_option
        /// is FORMATTED_VALUE. The default dateTime render option is SERIAL_NUMBER.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTimeRenderOption")]
        public virtual string DateTimeRenderOption { get; set; }

        /// <summary>
        /// The major dimension that results should use. For example, if the spreadsheet data is: `A1=1,B1=2,A2=3,B2=4`,
        /// then a request that selects that range and sets `majorDimension=ROWS` returns `[[1,2],[3,4]]`, whereas a
        /// request that sets `majorDimension=COLUMNS` returns `[[1,3],[2,4]]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("majorDimension")]
        public virtual string MajorDimension { get; set; }

        /// <summary>
        /// How values should be represented in the output. The default render option is FORMATTED_VALUE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueRenderOption")]
        public virtual string ValueRenderOption { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The response when retrieving more than one range of values in a spreadsheet selected by DataFilters.
    /// </summary>
    public class BatchGetValuesByDataFilterResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the spreadsheet the data was retrieved from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheetId")]
        public virtual string SpreadsheetId { get; set; }

        /// <summary>The requested values with the list of data filters that matched them.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueRanges")]
        public virtual System.Collections.Generic.IList<MatchedValueRange> ValueRanges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response when retrieving more than one range of values in a spreadsheet.</summary>
    public class BatchGetValuesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the spreadsheet the data was retrieved from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheetId")]
        public virtual string SpreadsheetId { get; set; }

        /// <summary>
        /// The requested values. The order of the ValueRanges is the same as the order of the requested ranges.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueRanges")]
        public virtual System.Collections.Generic.IList<ValueRange> ValueRanges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for updating any aspect of a spreadsheet.</summary>
    public class BatchUpdateSpreadsheetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Determines if the update response should include the spreadsheet resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeSpreadsheetInResponse")]
        public virtual System.Nullable<bool> IncludeSpreadsheetInResponse { get; set; }

        /// <summary>
        /// A list of updates to apply to the spreadsheet. Requests will be applied in the order they are specified. If
        /// any request is not valid, no requests will be applied.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requests")]
        public virtual System.Collections.Generic.IList<Request> Requests { get; set; }

        /// <summary>
        /// True if grid data should be returned. Meaningful only if include_spreadsheet_in_response is 'true'. This
        /// parameter is ignored if a field mask was set in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseIncludeGridData")]
        public virtual System.Nullable<bool> ResponseIncludeGridData { get; set; }

        /// <summary>
        /// Limits the ranges included in the response spreadsheet. Meaningful only if include_spreadsheet_in_response
        /// is 'true'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseRanges")]
        public virtual System.Collections.Generic.IList<string> ResponseRanges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The reply for batch updating a spreadsheet.</summary>
    public class BatchUpdateSpreadsheetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The reply of the updates. This maps 1:1 with the updates, although replies to some requests may be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replies")]
        public virtual System.Collections.Generic.IList<Response> Replies { get; set; }

        /// <summary>The spreadsheet the updates were applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheetId")]
        public virtual string SpreadsheetId { get; set; }

        /// <summary>
        /// The spreadsheet after updates were applied. This is only set if
        /// BatchUpdateSpreadsheetRequest.include_spreadsheet_in_response is `true`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedSpreadsheet")]
        public virtual Spreadsheet UpdatedSpreadsheet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for updating more than one range of values in a spreadsheet.</summary>
    public class BatchUpdateValuesByDataFilterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The new values to apply to the spreadsheet. If more than one range is matched by the specified DataFilter
        /// the specified values are applied to all of those ranges.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual System.Collections.Generic.IList<DataFilterValueRange> Data { get; set; }

        /// <summary>
        /// Determines if the update response should include the values of the cells that were updated. By default,
        /// responses do not include the updated values. The `updatedData` field within each of the
        /// BatchUpdateValuesResponse.responses contains the updated values. If the range to write was larger than the
        /// range actually written, the response includes all values in the requested range (excluding trailing empty
        /// rows and columns).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeValuesInResponse")]
        public virtual System.Nullable<bool> IncludeValuesInResponse { get; set; }

        /// <summary>
        /// Determines how dates, times, and durations in the response should be rendered. This is ignored if
        /// response_value_render_option is FORMATTED_VALUE. The default dateTime render option is SERIAL_NUMBER.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseDateTimeRenderOption")]
        public virtual string ResponseDateTimeRenderOption { get; set; }

        /// <summary>
        /// Determines how values in the response should be rendered. The default render option is FORMATTED_VALUE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseValueRenderOption")]
        public virtual string ResponseValueRenderOption { get; set; }

        /// <summary>How the input data should be interpreted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueInputOption")]
        public virtual string ValueInputOption { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response when updating a range of values in a spreadsheet.</summary>
    public class BatchUpdateValuesByDataFilterResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The response for each range updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<UpdateValuesByDataFilterResponse> Responses { get; set; }

        /// <summary>The spreadsheet the updates were applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheetId")]
        public virtual string SpreadsheetId { get; set; }

        /// <summary>The total number of cells updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalUpdatedCells")]
        public virtual System.Nullable<int> TotalUpdatedCells { get; set; }

        /// <summary>The total number of columns where at least one cell in the column was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalUpdatedColumns")]
        public virtual System.Nullable<int> TotalUpdatedColumns { get; set; }

        /// <summary>The total number of rows where at least one cell in the row was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalUpdatedRows")]
        public virtual System.Nullable<int> TotalUpdatedRows { get; set; }

        /// <summary>The total number of sheets where at least one cell in the sheet was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalUpdatedSheets")]
        public virtual System.Nullable<int> TotalUpdatedSheets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for updating more than one range of values in a spreadsheet.</summary>
    public class BatchUpdateValuesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The new values to apply to the spreadsheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual System.Collections.Generic.IList<ValueRange> Data { get; set; }

        /// <summary>
        /// Determines if the update response should include the values of the cells that were updated. By default,
        /// responses do not include the updated values. The `updatedData` field within each of the
        /// BatchUpdateValuesResponse.responses contains the updated values. If the range to write was larger than the
        /// range actually written, the response includes all values in the requested range (excluding trailing empty
        /// rows and columns).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeValuesInResponse")]
        public virtual System.Nullable<bool> IncludeValuesInResponse { get; set; }

        /// <summary>
        /// Determines how dates, times, and durations in the response should be rendered. This is ignored if
        /// response_value_render_option is FORMATTED_VALUE. The default dateTime render option is SERIAL_NUMBER.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseDateTimeRenderOption")]
        public virtual string ResponseDateTimeRenderOption { get; set; }

        /// <summary>
        /// Determines how values in the response should be rendered. The default render option is FORMATTED_VALUE.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseValueRenderOption")]
        public virtual string ResponseValueRenderOption { get; set; }

        /// <summary>How the input data should be interpreted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueInputOption")]
        public virtual string ValueInputOption { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response when updating a range of values in a spreadsheet.</summary>
    public class BatchUpdateValuesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>One UpdateValuesResponse per requested range, in the same order as the requests appeared.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responses")]
        public virtual System.Collections.Generic.IList<UpdateValuesResponse> Responses { get; set; }

        /// <summary>The spreadsheet the updates were applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheetId")]
        public virtual string SpreadsheetId { get; set; }

        /// <summary>The total number of cells updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalUpdatedCells")]
        public virtual System.Nullable<int> TotalUpdatedCells { get; set; }

        /// <summary>The total number of columns where at least one cell in the column was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalUpdatedColumns")]
        public virtual System.Nullable<int> TotalUpdatedColumns { get; set; }

        /// <summary>The total number of rows where at least one cell in the row was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalUpdatedRows")]
        public virtual System.Nullable<int> TotalUpdatedRows { get; set; }

        /// <summary>The total number of sheets where at least one cell in the sheet was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalUpdatedSheets")]
        public virtual System.Nullable<int> TotalUpdatedSheets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specification of a BigQuery data source that's connected to a sheet.</summary>
    public class BigQueryDataSourceSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID of a BigQuery enabled GCP project with a billing account attached. For any queries executed against
        /// the data source, the project is charged.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>A BigQueryQuerySpec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("querySpec")]
        public virtual BigQueryQuerySpec QuerySpec { get; set; }

        /// <summary>A BigQueryTableSpec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableSpec")]
        public virtual BigQueryTableSpec TableSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a custom BigQuery query.</summary>
    public class BigQueryQuerySpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The raw query string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rawQuery")]
        public virtual string RawQuery { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies a BigQuery table definition. Only [native tables](https://cloud.google.com/bigquery/docs/tables-intro)
    /// is allowed.
    /// </summary>
    public class BigQueryTableSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The BigQuery dataset id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("datasetId")]
        public virtual string DatasetId { get; set; }

        /// <summary>The BigQuery table id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableId")]
        public virtual string TableId { get; set; }

        /// <summary>
        /// The ID of a BigQuery project the table belongs to. If not specified, the project_id is assumed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableProjectId")]
        public virtual string TableProjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A condition that can evaluate to true or false. BooleanConditions are used by conditional formatting, data
    /// validation, and the criteria in filters.
    /// </summary>
    public class BooleanCondition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of condition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>
        /// The values of the condition. The number of supported values depends on the condition type. Some support zero
        /// values, others one or two values, and ConditionType.ONE_OF_LIST supports an arbitrary number of values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<ConditionValue> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A rule that may or may not match, depending on the condition.</summary>
    public class BooleanRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The condition of the rule. If the condition evaluates to true, the format is applied.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual BooleanCondition Condition { get; set; }

        /// <summary>
        /// The format to apply. Conditional formatting can only apply a subset of formatting: bold, italic,
        /// strikethrough, foreground color &amp;amp; background color.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual CellFormat Format { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A border along a cell.</summary>
    public class Border : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The color of the border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>The color of the border. If color is also set, this field takes precedence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorStyle")]
        public virtual ColorStyle ColorStyle { get; set; }

        /// <summary>The style of the border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("style")]
        public virtual string Style { get; set; }

        /// <summary>
        /// The width of the border, in pixels. Deprecated; the width is determined by the "style" field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The borders of the cell.</summary>
    public class Borders : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bottom border of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottom")]
        public virtual Border Bottom { get; set; }

        /// <summary>The left border of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("left")]
        public virtual Border Left { get; set; }

        /// <summary>The right border of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("right")]
        public virtual Border Right { get; set; }

        /// <summary>The top border of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("top")]
        public virtual Border Top { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A bubble chart.</summary>
    public class BubbleChartSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bubble border color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bubbleBorderColor")]
        public virtual Color BubbleBorderColor { get; set; }

        /// <summary>The bubble border color. If bubble_border_color is also set, this field takes precedence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bubbleBorderColorStyle")]
        public virtual ColorStyle BubbleBorderColorStyle { get; set; }

        /// <summary>The data containing the bubble labels. These do not need to be unique.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bubbleLabels")]
        public virtual ChartData BubbleLabels { get; set; }

        /// <summary>
        /// The max radius size of the bubbles, in pixels. If specified, the field must be a positive value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bubbleMaxRadiusSize")]
        public virtual System.Nullable<int> BubbleMaxRadiusSize { get; set; }

        /// <summary>
        /// The minimum radius size of the bubbles, in pixels. If specific, the field must be a positive value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bubbleMinRadiusSize")]
        public virtual System.Nullable<int> BubbleMinRadiusSize { get; set; }

        /// <summary>
        /// The opacity of the bubbles between 0 and 1.0. 0 is fully transparent and 1 is fully opaque.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bubbleOpacity")]
        public virtual System.Nullable<float> BubbleOpacity { get; set; }

        /// <summary>
        /// The data containing the bubble sizes. Bubble sizes are used to draw the bubbles at different sizes relative
        /// to each other. If specified, group_ids must also be specified. This field is optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bubbleSizes")]
        public virtual ChartData BubbleSizes { get; set; }

        /// <summary>
        /// The format of the text inside the bubbles. Strikethrough, underline, and link are not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bubbleTextStyle")]
        public virtual TextFormat BubbleTextStyle { get; set; }

        /// <summary>
        /// The data containing the bubble x-values. These values locate the bubbles in the chart horizontally.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual ChartData Domain { get; set; }

        /// <summary>
        /// The data containing the bubble group IDs. All bubbles with the same group ID are drawn in the same color. If
        /// bubble_sizes is specified then this field must also be specified but may contain blank values. This field is
        /// optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupIds")]
        public virtual ChartData GroupIds { get; set; }

        /// <summary>Where the legend of the chart should be drawn.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legendPosition")]
        public virtual string LegendPosition { get; set; }

        /// <summary>
        /// The data containing the bubble y-values. These values locate the bubbles in the chart vertically.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("series")]
        public virtual ChartData Series { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A candlestick chart.</summary>
    public class CandlestickChartSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Candlestick chart data. Only one CandlestickData is supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual System.Collections.Generic.IList<CandlestickData> Data { get; set; }

        /// <summary>
        /// The domain data (horizontal axis) for the candlestick chart. String data will be treated as discrete labels,
        /// other data will be treated as continuous values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual CandlestickDomain Domain { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The Candlestick chart data, each containing the low, open, close, and high values for a series.
    /// </summary>
    public class CandlestickData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The range data (vertical axis) for the close/final value for each candle. This is the top of the candle
        /// body. If greater than the open value the candle will be filled. Otherwise the candle will be hollow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("closeSeries")]
        public virtual CandlestickSeries CloseSeries { get; set; }

        /// <summary>
        /// The range data (vertical axis) for the high/maximum value for each candle. This is the top of the candle's
        /// center line.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("highSeries")]
        public virtual CandlestickSeries HighSeries { get; set; }

        /// <summary>
        /// The range data (vertical axis) for the low/minimum value for each candle. This is the bottom of the candle's
        /// center line.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lowSeries")]
        public virtual CandlestickSeries LowSeries { get; set; }

        /// <summary>
        /// The range data (vertical axis) for the open/initial value for each candle. This is the bottom of the candle
        /// body. If less than the close value the candle will be filled. Otherwise the candle will be hollow.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openSeries")]
        public virtual CandlestickSeries OpenSeries { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The domain of a CandlestickChart.</summary>
    public class CandlestickDomain : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data of the CandlestickDomain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual ChartData Data { get; set; }

        /// <summary>True to reverse the order of the domain values (horizontal axis).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reversed")]
        public virtual System.Nullable<bool> Reversed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The series of a CandlestickData.</summary>
    public class CandlestickSeries : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data of the CandlestickSeries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual ChartData Data { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data about a specific cell.</summary>
    public class CellData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Information about a data source formula on the cell. The field is set if user_entered_value is
        /// a formula referencing some DATA_SOURCE sheet, e.g. `=SUM(DataSheet!Column)`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceFormula")]
        public virtual DataSourceFormula DataSourceFormula { get; set; }

        /// <summary>
        /// A data source table anchored at this cell. The size of data source table itself is computed dynamically
        /// based on its configuration. Only the first cell of the data source table contains the data source table
        /// definition. The other cells will contain the display values of the data source table result in their
        /// effective_value fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceTable")]
        public virtual DataSourceTable DataSourceTable { get; set; }

        /// <summary>
        /// A data validation rule on the cell, if any. When writing, the new data validation rule will overwrite any
        /// prior rule.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataValidation")]
        public virtual DataValidationRule DataValidation { get; set; }

        /// <summary>
        /// The effective format being used by the cell. This includes the results of applying any conditional
        /// formatting and, if the cell contains a formula, the computed number format. If the effective format is the
        /// default format, effective format will not be written. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveFormat")]
        public virtual CellFormat EffectiveFormat { get; set; }

        /// <summary>
        /// The effective value of the cell. For cells with formulas, this is the calculated value. For cells with
        /// literals, this is the same as the user_entered_value. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveValue")]
        public virtual ExtendedValue EffectiveValue { get; set; }

        /// <summary>
        /// The formatted value of the cell. This is the value as it's shown to the user. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedValue")]
        public virtual string FormattedValue { get; set; }

        /// <summary>
        /// A hyperlink this cell points to, if any. If the cell contains multiple hyperlinks, this field will be empty.
        /// This field is read-only. To set it, use a `=HYPERLINK` formula in the userEnteredValue.formulaValue field. A
        /// cell-level link can also be set from the userEnteredFormat.textFormat field. Alternatively, set a hyperlink
        /// in the textFormatRun.format.link field that spans the entire cell.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hyperlink")]
        public virtual string Hyperlink { get; set; }

        /// <summary>Any note on the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("note")]
        public virtual string Note { get; set; }

        /// <summary>
        /// A pivot table anchored at this cell. The size of pivot table itself is computed dynamically based on its
        /// data, grouping, filters, values, etc. Only the top-left cell of the pivot table contains the pivot table
        /// definition. The other cells will contain the calculated values of the results of the pivot in their
        /// effective_value fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pivotTable")]
        public virtual PivotTable PivotTable { get; set; }

        /// <summary>
        /// Runs of rich text applied to subsections of the cell. Runs are only valid on user entered strings, not
        /// formulas, bools, or numbers. Properties of a run start at a specific index in the text and continue until
        /// the next run. Runs will inherit the properties of the cell unless explicitly changed. When writing, the new
        /// runs will overwrite any prior runs. When writing a new user_entered_value, previous runs are erased.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textFormatRuns")]
        public virtual System.Collections.Generic.IList<TextFormatRun> TextFormatRuns { get; set; }

        /// <summary>
        /// The format the user entered for the cell. When writing, the new format will be merged with the existing
        /// format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEnteredFormat")]
        public virtual CellFormat UserEnteredFormat { get; set; }

        /// <summary>
        /// The value the user entered in the cell. e.g, `1234`, `'Hello'`, or `=NOW()` Note: Dates, Times and DateTimes
        /// are represented as doubles in serial number format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEnteredValue")]
        public virtual ExtendedValue UserEnteredValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The format of a cell.</summary>
    public class CellFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The background color of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual Color BackgroundColor { get; set; }

        /// <summary>
        /// The background color of the cell. If background_color is also set, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColorStyle")]
        public virtual ColorStyle BackgroundColorStyle { get; set; }

        /// <summary>The borders of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("borders")]
        public virtual Borders Borders { get; set; }

        /// <summary>The horizontal alignment of the value in the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizontalAlignment")]
        public virtual string HorizontalAlignment { get; set; }

        /// <summary>How a hyperlink, if it exists, should be displayed in the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hyperlinkDisplayType")]
        public virtual string HyperlinkDisplayType { get; set; }

        /// <summary>A format describing how number values should be represented to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberFormat")]
        public virtual NumberFormat NumberFormat { get; set; }

        /// <summary>The padding of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("padding")]
        public virtual Padding Padding { get; set; }

        /// <summary>The direction of the text in the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textDirection")]
        public virtual string TextDirection { get; set; }

        /// <summary>
        /// The format of the text in the cell (unless overridden by a format run). Setting a cell-level link here will
        /// clear the cell's existing links. Setting the link field in a TextFormatRun will take precedence over the
        /// cell-level link.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textFormat")]
        public virtual TextFormat TextFormat { get; set; }

        /// <summary>The rotation applied to text in a cell</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textRotation")]
        public virtual TextRotation TextRotation { get; set; }

        /// <summary>The vertical alignment of the value in the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verticalAlignment")]
        public virtual string VerticalAlignment { get; set; }

        /// <summary>The wrap strategy for the value in the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wrapStrategy")]
        public virtual string WrapStrategy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The options that define a "view window" for a chart (such as the visible values in an axis).</summary>
    public class ChartAxisViewWindowOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum numeric value to be shown in this view window. If unset, will automatically determine a maximum
        /// value that looks good for the data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewWindowMax")]
        public virtual System.Nullable<double> ViewWindowMax { get; set; }

        /// <summary>
        /// The minimum numeric value to be shown in this view window. If unset, will automatically determine a minimum
        /// value that looks good for the data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewWindowMin")]
        public virtual System.Nullable<double> ViewWindowMin { get; set; }

        /// <summary>The view window's mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("viewWindowMode")]
        public virtual string ViewWindowMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Custom number formatting options for chart attributes.</summary>
    public class ChartCustomNumberFormatOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom prefix to be prepended to the chart attribute. This field is optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prefix")]
        public virtual string Prefix { get; set; }

        /// <summary>Custom suffix to be appended to the chart attribute. This field is optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suffix")]
        public virtual string Suffix { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The data included in a domain or series.</summary>
    public class ChartData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The aggregation type for the series of a data source chart. Only supported for data source charts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregateType")]
        public virtual string AggregateType { get; set; }

        /// <summary>The reference to the data source column that the data reads from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnReference")]
        public virtual DataSourceColumnReference ColumnReference { get; set; }

        /// <summary>
        /// The rule to group the data by if the ChartData backs the domain of a data source chart. Only supported for
        /// data source charts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupRule")]
        public virtual ChartGroupRule GroupRule { get; set; }

        /// <summary>The source ranges of the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceRange")]
        public virtual ChartSourceRange SourceRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Allows you to organize the date-time values in a source data column into buckets based on selected parts of
    /// their date or time values.
    /// </summary>
    public class ChartDateTimeRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of date-time grouping to apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An optional setting on the ChartData of the domain of a data source chart that defines buckets for the values in
    /// the domain rather than breaking out each individual value. For example, when plotting a data source chart, you
    /// can specify a histogram rule on the domain (it should only contain numeric values), grouping its values into
    /// buckets. Any values of a chart series that fall into the same bucket are aggregated based on the aggregate_type.
    /// </summary>
    public class ChartGroupRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A ChartDateTimeRule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTimeRule")]
        public virtual ChartDateTimeRule DateTimeRule { get; set; }

        /// <summary>A ChartHistogramRule</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogramRule")]
        public virtual ChartHistogramRule HistogramRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Allows you to organize numeric values in a source data column into buckets of constant size.</summary>
    public class ChartHistogramRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The size of the buckets that are created. Must be positive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intervalSize")]
        public virtual System.Nullable<double> IntervalSize { get; set; }

        /// <summary>
        /// The maximum value at which items are placed into buckets. Values greater than the maximum are grouped into a
        /// single bucket. If omitted, it is determined by the maximum item value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual System.Nullable<double> MaxValue { get; set; }

        /// <summary>
        /// The minimum value at which items are placed into buckets. Values that are less than the minimum are grouped
        /// into a single bucket. If omitted, it is determined by the minimum item value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual System.Nullable<double> MinValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Source ranges for a chart.</summary>
    public class ChartSourceRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ranges of data for a series or domain. Exactly one dimension must have a length of 1, and all sources in
        /// the list must have the same dimension with length 1. The domain (if it exists) &amp;amp; all series must
        /// have the same number of source ranges. If using more than one source range, then the source range at a given
        /// offset must be in order and contiguous across the domain and series. For example, these are valid
        /// configurations: domain sources: A1:A5 series1 sources: B1:B5 series2 sources: D6:D10 domain sources: A1:A5,
        /// C10:C12 series1 sources: B1:B5, D10:D12 series2 sources: C1:C5, E10:E12
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<GridRange> Sources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specifications of a chart.</summary>
    public class ChartSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The alternative text that describes the chart. This is often used for accessibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("altText")]
        public virtual string AltText { get; set; }

        /// <summary>The background color of the entire chart. Not applicable to Org charts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual Color BackgroundColor { get; set; }

        /// <summary>
        /// The background color of the entire chart. Not applicable to Org charts. If background_color is also set,
        /// this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColorStyle")]
        public virtual ColorStyle BackgroundColorStyle { get; set; }

        /// <summary>
        /// A basic chart specification, can be one of many kinds of charts. See BasicChartType for the list of all
        /// charts this supports.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicChart")]
        public virtual BasicChartSpec BasicChart { get; set; }

        /// <summary>A bubble chart specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bubbleChart")]
        public virtual BubbleChartSpec BubbleChart { get; set; }

        /// <summary>A candlestick chart specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("candlestickChart")]
        public virtual CandlestickChartSpec CandlestickChart { get; set; }

        /// <summary>If present, the field contains data source chart specific properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceChartProperties")]
        public virtual DataSourceChartProperties DataSourceChartProperties { get; set; }

        /// <summary>
        /// The filters applied to the source data of the chart. Only supported for data source charts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterSpecs")]
        public virtual System.Collections.Generic.IList<FilterSpec> FilterSpecs { get; set; }

        /// <summary>
        /// The name of the font to use by default for all chart text (e.g. title, axis labels, legend). If a font is
        /// specified for a specific part of the chart it will override this font name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontName")]
        public virtual string FontName { get; set; }

        /// <summary>Determines how the charts will use hidden rows or columns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiddenDimensionStrategy")]
        public virtual string HiddenDimensionStrategy { get; set; }

        /// <summary>A histogram chart specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogramChart")]
        public virtual HistogramChartSpec HistogramChart { get; set; }

        /// <summary>
        /// True to make a chart fill the entire space in which it's rendered with minimum padding. False to use the
        /// default padding. (Not applicable to Geo and Org charts.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximized")]
        public virtual System.Nullable<bool> Maximized { get; set; }

        /// <summary>An org chart specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgChart")]
        public virtual OrgChartSpec OrgChart { get; set; }

        /// <summary>A pie chart specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pieChart")]
        public virtual PieChartSpec PieChart { get; set; }

        /// <summary>A scorecard chart specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scorecardChart")]
        public virtual ScorecardChartSpec ScorecardChart { get; set; }

        /// <summary>
        /// The order to sort the chart data by. Only a single sort spec is supported. Only supported for data source
        /// charts.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortSpecs")]
        public virtual System.Collections.Generic.IList<SortSpec> SortSpecs { get; set; }

        /// <summary>The subtitle of the chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; }

        /// <summary>The subtitle text format. Strikethrough, underline, and link are not supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitleTextFormat")]
        public virtual TextFormat SubtitleTextFormat { get; set; }

        /// <summary>The subtitle text position. This field is optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitleTextPosition")]
        public virtual TextPosition SubtitleTextPosition { get; set; }

        /// <summary>The title of the chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The title text format. Strikethrough, underline, and link are not supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("titleTextFormat")]
        public virtual TextFormat TitleTextFormat { get; set; }

        /// <summary>The title text position. This field is optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("titleTextPosition")]
        public virtual TextPosition TitleTextPosition { get; set; }

        /// <summary>A treemap chart specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("treemapChart")]
        public virtual TreemapChartSpec TreemapChart { get; set; }

        /// <summary>A waterfall chart specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("waterfallChart")]
        public virtual WaterfallChartSpec WaterfallChart { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Clears the basic filter, if any exists on the sheet.</summary>
    public class ClearBasicFilterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The sheet ID on which the basic filter should be cleared.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetId")]
        public virtual System.Nullable<int> SheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for clearing a range of values in a spreadsheet.</summary>
    public class ClearValuesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response when clearing a range of values in a spreadsheet.</summary>
    public class ClearValuesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The range (in A1 notation) that was cleared. (If the request was for an unbounded range or a ranger larger
        /// than the bounds of the sheet, this will be the actual range that was cleared, bounded to the sheet's
        /// limits.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clearedRange")]
        public virtual string ClearedRange { get; set; }

        /// <summary>The spreadsheet the updates were applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheetId")]
        public virtual string SpreadsheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a color in the RGBA color space. This representation is designed for simplicity of conversion to/from
    /// color representations in various languages over compactness. For example, the fields of this representation can
    /// be trivially provided to the constructor of `java.awt.Color` in Java; it can also be trivially provided to
    /// UIColor's `+colorWithRed:green:blue:alpha` method in iOS; and, with just a little work, it can be easily
    /// formatted into a CSS `rgba()` string in JavaScript. This reference page doesn't carry information about the
    /// absolute color space that should be used to interpret the RGB value (e.g. sRGB, Adobe RGB, DCI-P3, BT.2020,
    /// etc.). By default, applications should assume the sRGB color space. When color equality needs to be decided,
    /// implementations, unless documented otherwise, treat two colors as equal if all their red, green, blue, and alpha
    /// values each differ by at most 1e-5. Example (Java): import com.google.type.Color; // ... public static
    /// java.awt.Color fromProto(Color protocolor) { float alpha = protocolor.hasAlpha() ?
    /// protocolor.getAlpha().getValue() : 1.0; return new java.awt.Color( protocolor.getRed(), protocolor.getGreen(),
    /// protocolor.getBlue(), alpha); } public static Color toProto(java.awt.Color color) { float red = (float)
    /// color.getRed(); float green = (float) color.getGreen(); float blue = (float) color.getBlue(); float denominator
    /// = 255.0; Color.Builder resultBuilder = Color .newBuilder() .setRed(red / denominator) .setGreen(green /
    /// denominator) .setBlue(blue / denominator); int alpha = color.getAlpha(); if (alpha != 255) { result.setAlpha(
    /// FloatValue .newBuilder() .setValue(((float) alpha) / denominator) .build()); } return resultBuilder.build(); }
    /// // ... Example (iOS / Obj-C): // ... static UIColor* fromProto(Color* protocolor) { float red = [protocolor
    /// red]; float green = [protocolor green]; float blue = [protocolor blue]; FloatValue* alpha_wrapper = [protocolor
    /// alpha]; float alpha = 1.0; if (alpha_wrapper != nil) { alpha = [alpha_wrapper value]; } return [UIColor
    /// colorWithRed:red green:green blue:blue alpha:alpha]; } static Color* toProto(UIColor* color) { CGFloat red,
    /// green, blue, alpha; if (![color getRed:&amp;amp;red green:&amp;amp;green blue:&amp;amp;blue
    /// alpha:&amp;amp;alpha]) { return nil; } Color* result = [[Color alloc] init]; [result setRed:red]; [result
    /// setGreen:green]; [result setBlue:blue]; if (alpha &amp;lt;= 0.9999) { [result
    /// setAlpha:floatWrapperWithValue(alpha)]; } [result autorelease]; return result; } // ... Example (JavaScript): //
    /// ... var protoToCssColor = function(rgb_color) { var redFrac = rgb_color.red || 0.0; var greenFrac =
    /// rgb_color.green || 0.0; var blueFrac = rgb_color.blue || 0.0; var red = Math.floor(redFrac * 255); var green =
    /// Math.floor(greenFrac * 255); var blue = Math.floor(blueFrac * 255); if (!('alpha' in rgb_color)) { return
    /// rgbToCssColor(red, green, blue); } var alphaFrac = rgb_color.alpha.value || 0.0; var rgbParams = [red, green,
    /// blue].join(','); return ['rgba(', rgbParams, ',', alphaFrac, ')'].join(''); }; var rgbToCssColor = function(red,
    /// green, blue) { var rgbNumber = new Number((red &amp;lt;&amp;lt; 16) | (green &amp;lt;&amp;lt; 8) | blue); var
    /// hexString = rgbNumber.toString(16); var missingZeros = 6 - hexString.length; var resultBuilder = ['#']; for (var
    /// i = 0; i &amp;lt; missingZeros; i++) { resultBuilder.push('0'); } resultBuilder.push(hexString); return
    /// resultBuilder.join(''); }; // ...
    /// </summary>
    public class Color : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fraction of this color that should be applied to the pixel. That is, the final pixel color is defined by
        /// the equation: `pixel color = alpha * (this color) + (1.0 - alpha) * (background color)` This means that a
        /// value of 1.0 corresponds to a solid color, whereas a value of 0.0 corresponds to a completely transparent
        /// color. This uses a wrapper message rather than a simple float scalar so that it is possible to distinguish
        /// between a default value and the value being unset. If omitted, this color object is rendered as a solid
        /// color (as if the alpha value had been explicitly given a value of 1.0).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alpha")]
        public virtual System.Nullable<float> Alpha { get; set; }

        /// <summary>The amount of blue in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blue")]
        public virtual System.Nullable<float> Blue { get; set; }

        /// <summary>The amount of green in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("green")]
        public virtual System.Nullable<float> Green { get; set; }

        /// <summary>The amount of red in the color as a value in the interval [0, 1].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("red")]
        public virtual System.Nullable<float> Red { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A color value.</summary>
    public class ColorStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>RGB color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rgbColor")]
        public virtual Color RgbColor { get; set; }

        /// <summary>Theme color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("themeColor")]
        public virtual string ThemeColor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The value of the condition.</summary>
    public class ConditionValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A relative date (based on the current date). Valid only if the type is DATE_BEFORE, DATE_AFTER,
        /// DATE_ON_OR_BEFORE or DATE_ON_OR_AFTER. Relative dates are not supported in data validation. They are
        /// supported only in conditional formatting and conditional filters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relativeDate")]
        public virtual string RelativeDate { get; set; }

        /// <summary>
        /// A value the condition is based on. The value is parsed as if the user typed into a cell. Formulas are
        /// supported (and must begin with an `=` or a '+').
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEnteredValue")]
        public virtual string UserEnteredValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A rule describing a conditional format.</summary>
    public class ConditionalFormatRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The formatting is either "on" or "off" according to the rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("booleanRule")]
        public virtual BooleanRule BooleanRule { get; set; }

        /// <summary>The formatting will vary based on the gradients in the rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gradientRule")]
        public virtual GradientRule GradientRule { get; set; }

        /// <summary>
        /// The ranges that are formatted if the condition is true. All the ranges must be on the same grid.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ranges")]
        public virtual System.Collections.Generic.IList<GridRange> Ranges { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Copies data from the source to the destination.</summary>
    public class CopyPasteRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The location to paste to. If the range covers a span that's a multiple of the source's height or width, then
        /// the data will be repeated to fill in the destination range. If the range is smaller than the source range,
        /// the entire source data will still be copied (beyond the end of the destination range).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual GridRange Destination { get; set; }

        /// <summary>How that data should be oriented when pasting.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pasteOrientation")]
        public virtual string PasteOrientation { get; set; }

        /// <summary>What kind of data to paste.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pasteType")]
        public virtual string PasteType { get; set; }

        /// <summary>The source range to copy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual GridRange Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request to copy a sheet across spreadsheets.</summary>
    public class CopySheetToAnotherSpreadsheetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the spreadsheet to copy the sheet to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationSpreadsheetId")]
        public virtual string DestinationSpreadsheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to create developer metadata.</summary>
    public class CreateDeveloperMetadataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The developer metadata to create.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerMetadata")]
        public virtual DeveloperMetadata DeveloperMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from creating developer metadata.</summary>
    public class CreateDeveloperMetadataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The developer metadata that was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerMetadata")]
        public virtual DeveloperMetadata DeveloperMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Moves data from the source to the destination.</summary>
    public class CutPasteRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The top-left coordinate where the data should be pasted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual GridCoordinate Destination { get; set; }

        /// <summary>
        /// What kind of data to paste. All the source data will be cut, regardless of what is pasted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pasteType")]
        public virtual string PasteType { get; set; }

        /// <summary>The source data to cut.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual GridRange Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The data execution status. A data execution is created to sync a data source object with the latest data from a
    /// DataSource. It is usually scheduled to run at background, you can check its state to tell if an execution
    /// completes There are several scenarios where a data execution is triggered to run: * Adding a data source creates
    /// an associated data source sheet as well as a data execution to sync the data from the data source to the sheet.
    /// * Updating a data source creates a data execution to refresh the associated data source sheet similarly. * You
    /// can send refresh request to explicitly refresh one or multiple data source objects.
    /// </summary>
    public class DataExecutionStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The error code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorCode")]
        public virtual string ErrorCode { get; set; }

        /// <summary>The error message, which may be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorMessage")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>Gets the time the data last successfully refreshed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastRefreshTime")]
        public virtual object LastRefreshTime { get; set; }

        /// <summary>The state of the data execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Filter that describes what data should be selected or returned from a request.</summary>
    public class DataFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Selects data that matches the specified A1 range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("a1Range")]
        public virtual string A1Range { get; set; }

        /// <summary>
        /// Selects data associated with the developer metadata matching the criteria described by this
        /// DeveloperMetadataLookup.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerMetadataLookup")]
        public virtual DeveloperMetadataLookup DeveloperMetadataLookup { get; set; }

        /// <summary>Selects data that matches the range described by the GridRange.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gridRange")]
        public virtual GridRange GridRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A range of values whose location is specified by a DataFilter.</summary>
    public class DataFilterValueRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data filter describing the location of the values in the spreadsheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataFilter")]
        public virtual DataFilter DataFilter { get; set; }

        /// <summary>The major dimension of the values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("majorDimension")]
        public virtual string MajorDimension { get; set; }

        /// <summary>
        /// The data to be written. If the provided values exceed any of the ranges matched by the data filter then the
        /// request fails. If the provided values are less than the matched ranges only the specified values are
        /// written, existing values in the matched ranges remain unaffected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IList<object>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Settings for one set of data labels. Data labels are annotations that appear next to a set of data, such as the
    /// points on a line chart, and provide additional information about what the data represents, such as a text
    /// representation of the value behind that point on the graph.
    /// </summary>
    public class DataLabel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Data to use for custom labels. Only used if type is set to CUSTOM. This data must be the same length as the
        /// series or other element this data label is applied to. In addition, if the series is split into multiple
        /// source ranges, this source data must come from the next column in the source data. For example, if the
        /// series is B2:B4,E6:E8 then this data must come from C2:C4,F6:F8.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLabelData")]
        public virtual ChartData CustomLabelData { get; set; }

        /// <summary>The placement of the data label relative to the labeled data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placement")]
        public virtual string Placement { get; set; }

        /// <summary>The text format used for the data label. The link field is not supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textFormat")]
        public virtual TextFormat TextFormat { get; set; }

        /// <summary>The type of the data label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about an external data source in the spreadsheet.</summary>
    public class DataSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All calculated columns in the data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calculatedColumns")]
        public virtual System.Collections.Generic.IList<DataSourceColumn> CalculatedColumns { get; set; }

        /// <summary>The spreadsheet-scoped unique ID that identifies the data source. Example: 1080547365.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceId")]
        public virtual string DataSourceId { get; set; }

        /// <summary>
        /// The ID of the Sheet connected with the data source. The field cannot be changed once set. When creating a
        /// data source, an associated DATA_SOURCE sheet is also created, if the field is not specified, the ID of the
        /// created sheet will be randomly generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetId")]
        public virtual System.Nullable<int> SheetId { get; set; }

        /// <summary>The DataSourceSpec for the data source connected with this spreadsheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual DataSourceSpec Spec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties of a data source chart.</summary>
    public class DataSourceChartProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The data execution status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataExecutionStatus")]
        public virtual DataExecutionStatus DataExecutionStatus { get; set; }

        /// <summary>ID of the data source that the chart is associated with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceId")]
        public virtual string DataSourceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A column in a data source.</summary>
    public class DataSourceColumn : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The formula of the calculated column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formula")]
        public virtual string Formula { get; set; }

        /// <summary>The column reference.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reference")]
        public virtual DataSourceColumnReference Reference { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An unique identifier that references a data source column.</summary>
    public class DataSourceColumnReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The display name of the column. It should be unique within a data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A data source formula.</summary>
    public class DataSourceFormula : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The data execution status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataExecutionStatus")]
        public virtual DataExecutionStatus DataExecutionStatus { get; set; }

        /// <summary>The ID of the data source the formula is associated with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceId")]
        public virtual string DataSourceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Reference to a data source object.</summary>
    public class DataSourceObjectReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>References to a data source chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chartId")]
        public virtual System.Nullable<int> ChartId { get; set; }

        /// <summary>References to a cell containing DataSourceFormula.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceFormulaCell")]
        public virtual GridCoordinate DataSourceFormulaCell { get; set; }

        /// <summary>References to a data source PivotTable anchored at the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourcePivotTableAnchorCell")]
        public virtual GridCoordinate DataSourcePivotTableAnchorCell { get; set; }

        /// <summary>References to a DataSourceTable anchored at the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceTableAnchorCell")]
        public virtual GridCoordinate DataSourceTableAnchorCell { get; set; }

        /// <summary>References to a DATA_SOURCE sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetId")]
        public virtual string SheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A list of references to data source objects.</summary>
    public class DataSourceObjectReferences : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The references.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("references")]
        public virtual System.Collections.Generic.IList<DataSourceObjectReference> References { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A parameter in a data source's query. The parameter allows the user to pass in values from the spreadsheet into
    /// a query.
    /// </summary>
    public class DataSourceParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Named parameter. Must be a legitimate identifier for the DataSource that supports it. For example, [BigQuery
        /// identifier](https://cloud.google.com/bigquery/docs/reference/standard-sql/lexical#identifiers).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>ID of a NamedRange. Its size must be 1x1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedRangeId")]
        public virtual string NamedRangeId { get; set; }

        /// <summary>A range that contains the value of the parameter. Its size must be 1x1.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A schedule for data to refresh every day in a given time interval.</summary>
    public class DataSourceRefreshDailySchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The start time of a time interval in which a data source refresh is scheduled. Only `hours` part is used.
        /// The time interval size defaults to that in the Sheets editor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A monthly schedule for data to refresh on specific days in the month in a given time interval.
    /// </summary>
    public class DataSourceRefreshMonthlySchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Days of the month to refresh. Only 1-28 are supported, mapping to the 1st to the 28th day. At lesat one day
        /// must be specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("daysOfMonth")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> DaysOfMonth { get; set; }

        /// <summary>
        /// The start time of a time interval in which a data source refresh is scheduled. Only `hours` part is used.
        /// The time interval size defaults to that in the Sheets editor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Schedule for refreshing the data source. Data sources in the spreadsheet are refreshed within a time interval.
    /// You can specify the start time by clicking the Scheduled Refresh button in the Sheets editor, but the interval
    /// is fixed at 4 hours. For example, if you specify a start time of 8am , the refresh will take place between 8am
    /// and 12pm every day.
    /// </summary>
    public class DataSourceRefreshSchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Daily refresh schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dailySchedule")]
        public virtual DataSourceRefreshDailySchedule DailySchedule { get; set; }

        /// <summary>True if the refresh schedule is enabled, or false otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabled")]
        public virtual System.Nullable<bool> Enabled { get; set; }

        /// <summary>Monthly refresh schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("monthlySchedule")]
        public virtual DataSourceRefreshMonthlySchedule MonthlySchedule { get; set; }

        /// <summary>Output only. The time interval of the next run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextRun")]
        public virtual Interval NextRun { get; set; }

        /// <summary>The scope of the refresh. Must be ALL_DATA_SOURCES.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshScope")]
        public virtual string RefreshScope { get; set; }

        /// <summary>Weekly refresh schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("weeklySchedule")]
        public virtual DataSourceRefreshWeeklySchedule WeeklySchedule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A weekly schedule for data to refresh on specific days in a given time interval.</summary>
    public class DataSourceRefreshWeeklySchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Days of the week to refresh. At least one day must be specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("daysOfWeek")]
        public virtual System.Collections.Generic.IList<string> DaysOfWeek { get; set; }

        /// <summary>
        /// The start time of a time interval in which a data source refresh is scheduled. Only `hours` part is used.
        /// The time interval size defaults to that in the Sheets editor.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual TimeOfDay StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A range along a single dimension on a DATA_SOURCE sheet.</summary>
    public class DataSourceSheetDimensionRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The columns on the data source sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnReferences")]
        public virtual System.Collections.Generic.IList<DataSourceColumnReference> ColumnReferences { get; set; }

        /// <summary>The ID of the data source sheet the range is on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetId")]
        public virtual System.Nullable<int> SheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional properties of a DATA_SOURCE sheet.</summary>
    public class DataSourceSheetProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The columns displayed on the sheet, corresponding to the values in RowData.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<DataSourceColumn> Columns { get; set; }

        /// <summary>The data execution status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataExecutionStatus")]
        public virtual DataExecutionStatus DataExecutionStatus { get; set; }

        /// <summary>ID of the DataSource the sheet is connected to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceId")]
        public virtual string DataSourceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This specifies the details of the data source. For example, for BigQuery, this specifies information about the
    /// BigQuery source.
    /// </summary>
    public class DataSourceSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A BigQueryDataSourceSpec.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigQuery")]
        public virtual BigQueryDataSourceSpec BigQuery { get; set; }

        /// <summary>The parameters of the data source, used when querying the data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<DataSourceParameter> Parameters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A data source table, which allows the user to import a static table of data from the DataSource into Sheets.
    /// This is also known as "Extract" in the Sheets editor.
    /// </summary>
    public class DataSourceTable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type to select columns for the data source table. Defaults to SELECTED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnSelectionType")]
        public virtual string ColumnSelectionType { get; set; }

        /// <summary>Columns selected for the data source table. The column_selection_type must be SELECTED.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<DataSourceColumnReference> Columns { get; set; }

        /// <summary>Output only. The data execution status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataExecutionStatus")]
        public virtual DataExecutionStatus DataExecutionStatus { get; set; }

        /// <summary>The ID of the data source the data source table is associated with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceId")]
        public virtual string DataSourceId { get; set; }

        /// <summary>Filter specifications in the data source table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterSpecs")]
        public virtual System.Collections.Generic.IList<FilterSpec> FilterSpecs { get; set; }

        /// <summary>
        /// The limit of rows to return. If not set, a default limit is applied. Please refer to the Sheets editor for
        /// the default and max limit.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowLimit")]
        public virtual System.Nullable<int> RowLimit { get; set; }

        /// <summary>
        /// Sort specifications in the data source table. The result of the data source table is sorted based on the
        /// sort specifications in order.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortSpecs")]
        public virtual System.Collections.Generic.IList<SortSpec> SortSpecs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A data validation rule.</summary>
    public class DataValidationRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The condition that data in the cell must match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual BooleanCondition Condition { get; set; }

        /// <summary>A message to show the user when adding data to the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputMessage")]
        public virtual string InputMessage { get; set; }

        /// <summary>
        /// True if the UI should be customized based on the kind of condition. If true, "List" conditions will show a
        /// dropdown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showCustomUi")]
        public virtual System.Nullable<bool> ShowCustomUi { get; set; }

        /// <summary>True if invalid data should be rejected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strict")]
        public virtual System.Nullable<bool> Strict { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Allows you to organize the date-time values in a source data column into buckets based on selected parts of
    /// their date or time values. For example, consider a pivot table showing sales transactions by date:
    /// +----------+--------------+ | Date | SUM of Sales | +----------+--------------+ | 1/1/2017 | $621.14 | |
    /// 2/3/2017 | $708.84 | | 5/8/2017 | $326.84 | ... +----------+--------------+ Applying a date-time group rule with
    /// a DateTimeRuleType of YEAR_MONTH results in the following pivot table. +--------------+--------------+ | Grouped
    /// Date | SUM of Sales | +--------------+--------------+ | 2017-Jan | $53,731.78 | | 2017-Feb | $83,475.32 | |
    /// 2017-Mar | $94,385.05 | ... +--------------+--------------+
    /// </summary>
    public class DateTimeRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The type of date-time grouping to apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Removes the banded range with the given ID from the spreadsheet.</summary>
    public class DeleteBandingRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the banded range to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bandedRangeId")]
        public virtual System.Nullable<int> BandedRangeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deletes a conditional format rule at the given index. All subsequent rules' indexes are decremented.
    /// </summary>
    public class DeleteConditionalFormatRuleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The zero-based index of the rule to be deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>The sheet the rule is being deleted from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetId")]
        public virtual System.Nullable<int> SheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of deleting a conditional format rule.</summary>
    public class DeleteConditionalFormatRuleResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The rule that was deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rule")]
        public virtual ConditionalFormatRule Rule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deletes a data source. The request also deletes the associated data source sheet, and unlinks all associated
    /// data source objects.
    /// </summary>
    public class DeleteDataSourceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the data source to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceId")]
        public virtual string DataSourceId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to delete developer metadata.</summary>
    public class DeleteDeveloperMetadataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The data filter describing the criteria used to select which developer metadata entry to delete.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataFilter")]
        public virtual DataFilter DataFilter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from deleting developer metadata.</summary>
    public class DeleteDeveloperMetadataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The metadata that was deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletedDeveloperMetadata")]
        public virtual System.Collections.Generic.IList<DeveloperMetadata> DeletedDeveloperMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Deletes a group over the specified range by decrementing the depth of the dimensions in the range. For example,
    /// assume the sheet has a depth-1 group over B:E and a depth-2 group over C:D. Deleting a group over D:E leaves the
    /// sheet with a depth-1 group over B:D and a depth-2 group over C:C.
    /// </summary>
    public class DeleteDimensionGroupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The range of the group to be deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual DimensionRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of deleting a group.</summary>
    public class DeleteDimensionGroupResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All groups of a dimension after deleting a group from that dimension.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionGroups")]
        public virtual System.Collections.Generic.IList<DimensionGroup> DimensionGroups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletes the dimensions from the sheet.</summary>
    public class DeleteDimensionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dimensions to delete from the sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual DimensionRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Removes rows within this range that contain values in the specified columns that are duplicates of values in any
    /// previous row. Rows with identical values but different letter cases, formatting, or formulas are considered to
    /// be duplicates. This request also removes duplicate rows hidden from view (for example, due to a filter). When
    /// removing duplicates, the first instance of each duplicate row scanning from the top downwards is kept in the
    /// resulting range. Content outside of the specified range isn't removed, and rows considered duplicates do not
    /// have to be adjacent to each other in the range.
    /// </summary>
    public class DeleteDuplicatesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The columns in the range to analyze for duplicate values. If no columns are selected then all columns are
        /// analyzed for duplicates.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("comparisonColumns")]
        public virtual System.Collections.Generic.IList<DimensionRange> ComparisonColumns { get; set; }

        /// <summary>The range to remove duplicates rows from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of removing duplicates in a range.</summary>
    public class DeleteDuplicatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of duplicate rows removed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duplicatesRemovedCount")]
        public virtual System.Nullable<int> DuplicatesRemovedCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletes the embedded object with the given ID.</summary>
    public class DeleteEmbeddedObjectRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the embedded object to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual System.Nullable<int> ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletes a particular filter view.</summary>
    public class DeleteFilterViewRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the filter to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterId")]
        public virtual System.Nullable<int> FilterId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Removes the named range with the given ID from the spreadsheet.</summary>
    public class DeleteNamedRangeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the named range to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedRangeId")]
        public virtual string NamedRangeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletes the protected range with the given ID.</summary>
    public class DeleteProtectedRangeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the protected range to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectedRangeId")]
        public virtual System.Nullable<int> ProtectedRangeId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletes a range of cells, shifting other cells into the deleted area.</summary>
    public class DeleteRangeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The range of cells to delete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>
        /// The dimension from which deleted cells will be replaced with. If ROWS, existing cells will be shifted upward
        /// to replace the deleted cells. If COLUMNS, existing cells will be shifted left to replace the deleted cells.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shiftDimension")]
        public virtual string ShiftDimension { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Deletes the requested sheet.</summary>
    public class DeleteSheetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The ID of the sheet to delete. If the sheet is of DATA_SOURCE type, the associated DataSource is also
        /// deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetId")]
        public virtual System.Nullable<int> SheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Developer metadata associated with a location or object in a spreadsheet. Developer metadata may be used to
    /// associate arbitrary data with various parts of a spreadsheet and will remain associated at those locations as
    /// they move around and the spreadsheet is edited. For example, if developer metadata is associated with row 5 and
    /// another row is then subsequently inserted above row 5, that original metadata will still be associated with the
    /// row it was first associated with (what is now row 6). If the associated object is deleted its metadata is
    /// deleted too.
    /// </summary>
    public class DeveloperMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The location where the metadata is associated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual DeveloperMetadataLocation Location { get; set; }

        /// <summary>
        /// The spreadsheet-scoped unique ID that identifies the metadata. IDs may be specified when metadata is
        /// created, otherwise one will be randomly generated and assigned. Must be positive.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataId")]
        public virtual System.Nullable<int> MetadataId { get; set; }

        /// <summary>
        /// The metadata key. There may be multiple metadata in a spreadsheet with the same key. Developer metadata must
        /// always have a key specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataKey")]
        public virtual string MetadataKey { get; set; }

        /// <summary>Data associated with the metadata's key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataValue")]
        public virtual string MetadataValue { get; set; }

        /// <summary>The metadata visibility. Developer metadata must always have a visibility specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibility")]
        public virtual string Visibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A location where metadata may be associated in a spreadsheet.</summary>
    public class DeveloperMetadataLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Represents the row or column when metadata is associated with a dimension. The specified DimensionRange must
        /// represent a single row or column; it cannot be unbounded or span multiple rows or columns.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionRange")]
        public virtual DimensionRange DimensionRange { get; set; }

        /// <summary>The type of location this object represents. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationType")]
        public virtual string LocationType { get; set; }

        /// <summary>The ID of the sheet when metadata is associated with an entire sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetId")]
        public virtual System.Nullable<int> SheetId { get; set; }

        /// <summary>True when metadata is associated with an entire spreadsheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheet")]
        public virtual System.Nullable<bool> Spreadsheet { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Selects DeveloperMetadata that matches all of the specified fields. For example, if only a metadata ID is
    /// specified this considers the DeveloperMetadata with that particular unique ID. If a metadata key is specified,
    /// this considers all developer metadata with that key. If a key, visibility, and location type are all specified,
    /// this considers all developer metadata with that key and visibility that are associated with a location of that
    /// type. In general, this selects all DeveloperMetadata that matches the intersection of all the specified fields;
    /// any field or combination of fields may be specified.
    /// </summary>
    public class DeveloperMetadataLookup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Determines how this lookup matches the location. If this field is specified as EXACT, only developer
        /// metadata associated on the exact location specified is matched. If this field is specified to INTERSECTING,
        /// developer metadata associated on intersecting locations is also matched. If left unspecified, this field
        /// assumes a default value of INTERSECTING. If this field is specified, a metadataLocation must also be
        /// specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationMatchingStrategy")]
        public virtual string LocationMatchingStrategy { get; set; }

        /// <summary>
        /// Limits the selected developer metadata to those entries which are associated with locations of the specified
        /// type. For example, when this field is specified as ROW this lookup only considers developer metadata
        /// associated on rows. If the field is left unspecified, all location types are considered. This field cannot
        /// be specified as SPREADSHEET when the locationMatchingStrategy is specified as INTERSECTING or when the
        /// metadataLocation is specified as a non-spreadsheet location: spreadsheet metadata cannot intersect any other
        /// developer metadata location. This field also must be left unspecified when the locationMatchingStrategy is
        /// specified as EXACT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationType")]
        public virtual string LocationType { get; set; }

        /// <summary>
        /// Limits the selected developer metadata to that which has a matching DeveloperMetadata.metadata_id.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataId")]
        public virtual System.Nullable<int> MetadataId { get; set; }

        /// <summary>
        /// Limits the selected developer metadata to that which has a matching DeveloperMetadata.metadata_key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataKey")]
        public virtual string MetadataKey { get; set; }

        /// <summary>
        /// Limits the selected developer metadata to those entries associated with the specified location. This field
        /// either matches exact locations or all intersecting locations according the specified
        /// locationMatchingStrategy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataLocation")]
        public virtual DeveloperMetadataLocation MetadataLocation { get; set; }

        /// <summary>
        /// Limits the selected developer metadata to that which has a matching DeveloperMetadata.metadata_value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadataValue")]
        public virtual string MetadataValue { get; set; }

        /// <summary>
        /// Limits the selected developer metadata to that which has a matching DeveloperMetadata.visibility. If left
        /// unspecified, all developer metadata visibile to the requesting project is considered.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibility")]
        public virtual string Visibility { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A group over an interval of rows or columns on a sheet, which can contain or be contained within other groups. A
    /// group can be collapsed or expanded as a unit on the sheet.
    /// </summary>
    public class DimensionGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This field is true if this group is collapsed. A collapsed group remains collapsed if an overlapping group
        /// at a shallower depth is expanded. A true value does not imply that all dimensions within the group are
        /// hidden, since a dimension's visibility can change independently from this group property. However, when this
        /// property is updated, all dimensions within it are set to hidden if this field is true, or set to visible if
        /// this field is false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collapsed")]
        public virtual System.Nullable<bool> Collapsed { get; set; }

        /// <summary>
        /// The depth of the group, representing how many groups have a range that wholly contains the range of this
        /// group.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("depth")]
        public virtual System.Nullable<int> Depth { get; set; }

        /// <summary>The range over which this group exists.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual DimensionRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties about a dimension.</summary>
    public class DimensionProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. If set, this is a column in a data source sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceColumnReference")]
        public virtual DataSourceColumnReference DataSourceColumnReference { get; set; }

        /// <summary>The developer metadata associated with a single row or column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerMetadata")]
        public virtual System.Collections.Generic.IList<DeveloperMetadata> DeveloperMetadata { get; set; }

        /// <summary>True if this dimension is being filtered. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiddenByFilter")]
        public virtual System.Nullable<bool> HiddenByFilter { get; set; }

        /// <summary>True if this dimension is explicitly hidden.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiddenByUser")]
        public virtual System.Nullable<bool> HiddenByUser { get; set; }

        /// <summary>The height (if a row) or width (if a column) of the dimension in pixels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pixelSize")]
        public virtual System.Nullable<int> PixelSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A range along a single dimension on a sheet. All indexes are zero-based. Indexes are half open: the start index
    /// is inclusive and the end index is exclusive. Missing indexes indicate the range is unbounded on that side.
    /// </summary>
    public class DimensionRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dimension of the span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        /// <summary>The end (exclusive) of the span, or not set if unbounded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endIndex")]
        public virtual System.Nullable<int> EndIndex { get; set; }

        /// <summary>The sheet this span is on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetId")]
        public virtual System.Nullable<int> SheetId { get; set; }

        /// <summary>The start (inclusive) of the span, or not set if unbounded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Duplicates a particular filter view.</summary>
    public class DuplicateFilterViewRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the filter being duplicated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterId")]
        public virtual System.Nullable<int> FilterId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of a filter view being duplicated.</summary>
    public class DuplicateFilterViewResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The newly created filter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual FilterView Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Duplicates the contents of a sheet.</summary>
    public class DuplicateSheetRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The zero-based index where the new sheet should be inserted. The index of all sheets after this are
        /// incremented.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertSheetIndex")]
        public virtual System.Nullable<int> InsertSheetIndex { get; set; }

        /// <summary>
        /// If set, the ID of the new sheet. If not set, an ID is chosen. If set, the ID must not conflict with any
        /// existing sheet ID. If set, it must be non-negative.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newSheetId")]
        public virtual System.Nullable<int> NewSheetId { get; set; }

        /// <summary>The name of the new sheet. If empty, a new name is chosen for you.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newSheetName")]
        public virtual string NewSheetName { get; set; }

        /// <summary>
        /// The sheet to duplicate. If the source sheet is of DATA_SOURCE type, its backing DataSource is also
        /// duplicated and associated with the new copy of the sheet. No data execution is triggered, the grid data of
        /// this sheet is also copied over but only available after the batch request completes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceSheetId")]
        public virtual System.Nullable<int> SourceSheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of duplicating a sheet.</summary>
    public class DuplicateSheetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The properties of the duplicate sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual SheetProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The editors of a protected range.</summary>
    public class Editors : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True if anyone in the document's domain has edit access to the protected range. Domain protection is only
        /// supported on documents within a domain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainUsersCanEdit")]
        public virtual System.Nullable<bool> DomainUsersCanEdit { get; set; }

        /// <summary>The email addresses of groups with edit access to the protected range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groups")]
        public virtual System.Collections.Generic.IList<string> Groups { get; set; }

        /// <summary>The email addresses of users with edit access to the protected range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("users")]
        public virtual System.Collections.Generic.IList<string> Users { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A chart embedded in a sheet.</summary>
    public class EmbeddedChart : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The border of the chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("border")]
        public virtual EmbeddedObjectBorder Border { get; set; }

        /// <summary>The ID of the chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chartId")]
        public virtual System.Nullable<int> ChartId { get; set; }

        /// <summary>The position of the chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual EmbeddedObjectPosition Position { get; set; }

        /// <summary>The specification of the chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual ChartSpec Spec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A border along an embedded object.</summary>
    public class EmbeddedObjectBorder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The color of the border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>The color of the border. If color is also set, this field takes precedence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorStyle")]
        public virtual ColorStyle ColorStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The position of an embedded object such as a chart.</summary>
    public class EmbeddedObjectPosition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If true, the embedded object is put on a new sheet whose ID is chosen for you. Used only when writing.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newSheet")]
        public virtual System.Nullable<bool> NewSheet { get; set; }

        /// <summary>The position at which the object is overlaid on top of a grid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("overlayPosition")]
        public virtual OverlayPosition OverlayPosition { get; set; }

        /// <summary>
        /// The sheet this is on. Set only if the embedded object is on its own sheet. Must be non-negative.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetId")]
        public virtual System.Nullable<int> SheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An error in a cell.</summary>
    public class ErrorValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A message with more information about the error (in the spreadsheet's locale).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The type of error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The kinds of value that a cell in a spreadsheet can have.</summary>
    public class ExtendedValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents a boolean value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; }

        /// <summary>Represents an error. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorValue")]
        public virtual ErrorValue ErrorValue { get; set; }

        /// <summary>Represents a formula.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formulaValue")]
        public virtual string FormulaValue { get; set; }

        /// <summary>
        /// Represents a double value. Note: Dates, Times and DateTimes are represented as doubles in SERIAL_NUMBER
        /// format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberValue")]
        public virtual System.Nullable<double> NumberValue { get; set; }

        /// <summary>
        /// Represents a string value. Leading single quotes are not included. For example, if the user typed `'123`
        /// into the UI, this would be represented as a `stringValue` of `"123"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Criteria for showing/hiding rows in a filter or filter view.</summary>
    public class FilterCriteria : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A condition that must be true for values to be shown. (This does not override hidden_values -- if a value is
        /// listed there, it will still be hidden.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual BooleanCondition Condition { get; set; }

        /// <summary>Values that should be hidden.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hiddenValues")]
        public virtual System.Collections.Generic.IList<string> HiddenValues { get; set; }

        /// <summary>
        /// The background fill color to filter by; only cells with this fill color are shown. Mutually exclusive with
        /// visible_foreground_color.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibleBackgroundColor")]
        public virtual Color VisibleBackgroundColor { get; set; }

        /// <summary>
        /// The background fill color to filter by; only cells with this fill color are shown. This field is mutually
        /// exclusive with visible_foreground_color, and must be set to an RGB-type color. If visible_background_color
        /// is also set, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibleBackgroundColorStyle")]
        public virtual ColorStyle VisibleBackgroundColorStyle { get; set; }

        /// <summary>
        /// The foreground color to filter by; only cells with this foreground color are shown. Mutually exclusive with
        /// visible_background_color.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibleForegroundColor")]
        public virtual Color VisibleForegroundColor { get; set; }

        /// <summary>
        /// The foreground color to filter by; only cells with this foreground color are shown. This field is mutually
        /// exclusive with visible_background_color, and must be set to an RGB-type color. If visible_foreground_color
        /// is also set, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibleForegroundColorStyle")]
        public virtual ColorStyle VisibleForegroundColorStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The filter criteria associated with a specific column.</summary>
    public class FilterSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The column index.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnIndex")]
        public virtual System.Nullable<int> ColumnIndex { get; set; }

        /// <summary>Reference to a data source column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceColumnReference")]
        public virtual DataSourceColumnReference DataSourceColumnReference { get; set; }

        /// <summary>The criteria for the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterCriteria")]
        public virtual FilterCriteria FilterCriteria { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A filter view.</summary>
    public class FilterView : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The criteria for showing/hiding values per column. The map's key is the column index, and the value is the
        /// criteria for that column. This field is deprecated in favor of filter_specs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("criteria")]
        public virtual System.Collections.Generic.IDictionary<string, FilterCriteria> Criteria { get; set; }

        /// <summary>
        /// The filter criteria for showing/hiding values per column. Both criteria and filter_specs are populated in
        /// responses. If both fields are specified in an update request, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterSpecs")]
        public virtual System.Collections.Generic.IList<FilterSpec> FilterSpecs { get; set; }

        /// <summary>The ID of the filter view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterViewId")]
        public virtual System.Nullable<int> FilterViewId { get; set; }

        /// <summary>
        /// The named range this filter view is backed by, if any. When writing, only one of range or named_range_id may
        /// be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedRangeId")]
        public virtual string NamedRangeId { get; set; }

        /// <summary>
        /// The range this filter view covers. When writing, only one of range or named_range_id may be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>
        /// The sort order per column. Later specifications are used when values are equal in the earlier
        /// specifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortSpecs")]
        public virtual System.Collections.Generic.IList<SortSpec> SortSpecs { get; set; }

        /// <summary>The name of the filter view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Finds and replaces data in cells over a range, sheet, or all sheets.</summary>
    public class FindReplaceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True to find/replace over all sheets.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allSheets")]
        public virtual System.Nullable<bool> AllSheets { get; set; }

        /// <summary>The value to search.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("find")]
        public virtual string Find { get; set; }

        /// <summary>True if the search should include cells with formulas. False to skip cells with formulas.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeFormulas")]
        public virtual System.Nullable<bool> IncludeFormulas { get; set; }

        /// <summary>True if the search is case sensitive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchCase")]
        public virtual System.Nullable<bool> MatchCase { get; set; }

        /// <summary>True if the find value should match the entire cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchEntireCell")]
        public virtual System.Nullable<bool> MatchEntireCell { get; set; }

        /// <summary>The range to find/replace over.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>The value to use as the replacement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replacement")]
        public virtual string Replacement { get; set; }

        /// <summary>
        /// True if the find value is a regex. The regular expression and replacement should follow Java regex rules at
        /// https://docs.oracle.com/javase/8/docs/api/java/util/regex/Pattern.html. The replacement string is allowed to
        /// refer to capturing groups. For example, if one cell has the contents `"Google Sheets"` and another has
        /// `"Google Docs"`, then searching for `"o.* (.*)"` with a replacement of `"$1 Rocks"` would change the
        /// contents of the cells to `"GSheets Rocks"` and `"GDocs Rocks"` respectively.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchByRegex")]
        public virtual System.Nullable<bool> SearchByRegex { get; set; }

        /// <summary>The sheet to find/replace over.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetId")]
        public virtual System.Nullable<int> SheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of the find/replace.</summary>
    public class FindReplaceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of formula cells changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formulasChanged")]
        public virtual System.Nullable<int> FormulasChanged { get; set; }

        /// <summary>
        /// The number of occurrences (possibly multiple within a cell) changed. For example, if replacing `"e"` with
        /// `"o"` in `"Google Sheets"`, this would be `"3"` because `"Google Sheets"` -&amp;gt; `"Googlo Shoots"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("occurrencesChanged")]
        public virtual System.Nullable<int> OccurrencesChanged { get; set; }

        /// <summary>The number of rows changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowsChanged")]
        public virtual System.Nullable<int> RowsChanged { get; set; }

        /// <summary>The number of sheets changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetsChanged")]
        public virtual System.Nullable<int> SheetsChanged { get; set; }

        /// <summary>The number of non-formula cells changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valuesChanged")]
        public virtual System.Nullable<int> ValuesChanged { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request for retrieving a Spreadsheet.</summary>
    public class GetSpreadsheetByDataFilterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The DataFilters used to select which ranges to retrieve from the spreadsheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataFilters")]
        public virtual System.Collections.Generic.IList<DataFilter> DataFilters { get; set; }

        /// <summary>
        /// True if grid data should be returned. This parameter is ignored if a field mask was set in the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeGridData")]
        public virtual System.Nullable<bool> IncludeGridData { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A rule that applies a gradient color scale format, based on the interpolation points listed. The format of a
    /// cell will vary based on its contents as compared to the values of the interpolation points.
    /// </summary>
    public class GradientRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The final interpolation point.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxpoint")]
        public virtual InterpolationPoint Maxpoint { get; set; }

        /// <summary>An optional midway interpolation point.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("midpoint")]
        public virtual InterpolationPoint Midpoint { get; set; }

        /// <summary>The starting interpolation point.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minpoint")]
        public virtual InterpolationPoint Minpoint { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A coordinate in a sheet. All indexes are zero-based.</summary>
    public class GridCoordinate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The column index of the coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnIndex")]
        public virtual System.Nullable<int> ColumnIndex { get; set; }

        /// <summary>The row index of the coordinate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowIndex")]
        public virtual System.Nullable<int> RowIndex { get; set; }

        /// <summary>The sheet this coordinate is on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetId")]
        public virtual System.Nullable<int> SheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data in the grid, as well as metadata about the dimensions.</summary>
    public class GridData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Metadata about the requested columns in the grid, starting with the column in start_column.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnMetadata")]
        public virtual System.Collections.Generic.IList<DimensionProperties> ColumnMetadata { get; set; }

        /// <summary>
        /// The data in the grid, one entry per row, starting with the row in startRow. The values in RowData will
        /// correspond to columns starting at start_column.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowData")]
        public virtual System.Collections.Generic.IList<RowData> RowData { get; set; }

        /// <summary>Metadata about the requested rows in the grid, starting with the row in start_row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowMetadata")]
        public virtual System.Collections.Generic.IList<DimensionProperties> RowMetadata { get; set; }

        /// <summary>The first column this GridData refers to, zero-based.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startColumn")]
        public virtual System.Nullable<int> StartColumn { get; set; }

        /// <summary>The first row this GridData refers to, zero-based.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startRow")]
        public virtual System.Nullable<int> StartRow { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties of a grid.</summary>
    public class GridProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of columns in the grid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnCount")]
        public virtual System.Nullable<int> ColumnCount { get; set; }

        /// <summary>True if the column grouping control toggle is shown after the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnGroupControlAfter")]
        public virtual System.Nullable<bool> ColumnGroupControlAfter { get; set; }

        /// <summary>The number of columns that are frozen in the grid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frozenColumnCount")]
        public virtual System.Nullable<int> FrozenColumnCount { get; set; }

        /// <summary>The number of rows that are frozen in the grid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("frozenRowCount")]
        public virtual System.Nullable<int> FrozenRowCount { get; set; }

        /// <summary>True if the grid isn't showing gridlines in the UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hideGridlines")]
        public virtual System.Nullable<bool> HideGridlines { get; set; }

        /// <summary>The number of rows in the grid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowCount")]
        public virtual System.Nullable<int> RowCount { get; set; }

        /// <summary>True if the row grouping control toggle is shown after the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowGroupControlAfter")]
        public virtual System.Nullable<bool> RowGroupControlAfter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A range on a sheet. All indexes are zero-based. Indexes are half open, i.e. the start index is inclusive and the
    /// end index is exclusive -- [start_index, end_index). Missing indexes indicate the range is unbounded on that
    /// side. For example, if `"Sheet1"` is sheet ID 0, then: `Sheet1!A1:A1 == sheet_id: 0, start_row_index: 0,
    /// end_row_index: 1, start_column_index: 0, end_column_index: 1` `Sheet1!A3:B4 == sheet_id: 0, start_row_index: 2,
    /// end_row_index: 4, start_column_index: 0, end_column_index: 2` `Sheet1!A:B == sheet_id: 0, start_column_index: 0,
    /// end_column_index: 2` `Sheet1!A5:B == sheet_id: 0, start_row_index: 4, start_column_index: 0, end_column_index:
    /// 2` `Sheet1 == sheet_id:0` The start index must always be less than or equal to the end index. If the start index
    /// equals the end index, then the range is empty. Empty ranges are typically not meaningful and are usually
    /// rendered in the UI as `#REF!`.
    /// </summary>
    public class GridRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The end column (exclusive) of the range, or not set if unbounded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endColumnIndex")]
        public virtual System.Nullable<int> EndColumnIndex { get; set; }

        /// <summary>The end row (exclusive) of the range, or not set if unbounded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endRowIndex")]
        public virtual System.Nullable<int> EndRowIndex { get; set; }

        /// <summary>The sheet this range is on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetId")]
        public virtual System.Nullable<int> SheetId { get; set; }

        /// <summary>The start column (inclusive) of the range, or not set if unbounded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startColumnIndex")]
        public virtual System.Nullable<int> StartColumnIndex { get; set; }

        /// <summary>The start row (inclusive) of the range, or not set if unbounded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startRowIndex")]
        public virtual System.Nullable<int> StartRowIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A histogram chart. A histogram chart groups data items into bins, displaying each bin as a column of stacked
    /// items. Histograms are used to display the distribution of a dataset. Each column of items represents a range
    /// into which those items fall. The number of bins can be chosen automatically or specified explicitly.
    /// </summary>
    public class HistogramChartSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// By default the bucket size (the range of values stacked in a single column) is chosen automatically, but it
        /// may be overridden here. E.g., A bucket size of 1.5 results in buckets from 0 - 1.5, 1.5 - 3.0, etc. Cannot
        /// be negative. This field is optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bucketSize")]
        public virtual System.Nullable<double> BucketSize { get; set; }

        /// <summary>The position of the chart legend.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legendPosition")]
        public virtual string LegendPosition { get; set; }

        /// <summary>
        /// The outlier percentile is used to ensure that outliers do not adversely affect the calculation of bucket
        /// sizes. For example, setting an outlier percentile of 0.05 indicates that the top and bottom 5% of values
        /// when calculating buckets. The values are still included in the chart, they will be added to the first or
        /// last buckets instead of their own buckets. Must be between 0.0 and 0.5.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outlierPercentile")]
        public virtual System.Nullable<double> OutlierPercentile { get; set; }

        /// <summary>
        /// The series for a histogram may be either a single series of values to be bucketed or multiple series, each
        /// of the same length, containing the name of the series followed by the values to be bucketed for that series.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("series")]
        public virtual System.Collections.Generic.IList<HistogramSeries> Series { get; set; }

        /// <summary>Whether horizontal divider lines should be displayed between items in each column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showItemDividers")]
        public virtual System.Nullable<bool> ShowItemDividers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Allows you to organize the numeric values in a source data column into buckets of a constant size. All values
    /// from HistogramRule.start to HistogramRule.end are placed into groups of size HistogramRule.interval. In
    /// addition, all values below HistogramRule.start are placed in one group, and all values above HistogramRule.end
    /// are placed in another. Only HistogramRule.interval is required, though if HistogramRule.start and
    /// HistogramRule.end are both provided, HistogramRule.start must be less than HistogramRule.end. For example, a
    /// pivot table showing average purchase amount by age that has 50+ rows: +-----+-------------------+ | Age |
    /// AVERAGE of Amount | +-----+-------------------+ | 16 | $27.13 | | 17 | $5.24 | | 18 | $20.15 | ...
    /// +-----+-------------------+ could be turned into a pivot table that looks like the one below by applying a
    /// histogram group rule with a HistogramRule.start of 25, an HistogramRule.interval of 20, and an HistogramRule.end
    /// of 65. +-------------+-------------------+ | Grouped Age | AVERAGE of Amount |
    /// +-------------+-------------------+ | &amp;lt; 25 | $19.34 | | 25-45 | $31.43 | | 45-65 | $35.87 | | &amp;gt; 65
    /// | $27.55 | +-------------+-------------------+ | Grand Total | $29.12 | +-------------+-------------------+
    /// </summary>
    public class HistogramRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The maximum value at which items are placed into buckets of constant size. Values above end are lumped into
        /// a single bucket. This field is optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("end")]
        public virtual System.Nullable<double> End { get; set; }

        /// <summary>The size of the buckets that are created. Must be positive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("interval")]
        public virtual System.Nullable<double> Interval { get; set; }

        /// <summary>
        /// The minimum value at which items are placed into buckets of constant size. Values below start are lumped
        /// into a single bucket. This field is optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual System.Nullable<double> Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A histogram series containing the series color and data.</summary>
    public class HistogramSeries : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The color of the column representing this series in each bucket. This field is optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("barColor")]
        public virtual Color BarColor { get; set; }

        /// <summary>
        /// The color of the column representing this series in each bucket. This field is optional. If bar_color is
        /// also set, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("barColorStyle")]
        public virtual ColorStyle BarColorStyle { get; set; }

        /// <summary>The data for this histogram series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual ChartData Data { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Inserts rows or columns in a sheet at a particular index.</summary>
    public class InsertDimensionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Whether dimension properties should be extended from the dimensions before or after the newly inserted
        /// dimensions. True to inherit from the dimensions before (in which case the start index must be greater than
        /// 0), and false to inherit from the dimensions after. For example, if row index 0 has red background and row
        /// index 1 has a green background, then inserting 2 rows at index 1 can inherit either the green or red
        /// background. If `inheritFromBefore` is true, the two new rows will be red (because the row before the
        /// insertion point was red), whereas if `inheritFromBefore` is false, the two new rows will be green (because
        /// the row after the insertion point was green).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inheritFromBefore")]
        public virtual System.Nullable<bool> InheritFromBefore { get; set; }

        /// <summary>The dimensions to insert. Both the start and end indexes must be bounded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual DimensionRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Inserts cells into a range, shifting the existing cells over or down.</summary>
    public class InsertRangeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The range to insert new cells into.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>
        /// The dimension which will be shifted when inserting cells. If ROWS, existing cells will be shifted down. If
        /// COLUMNS, existing cells will be shifted right.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shiftDimension")]
        public virtual string ShiftDimension { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A single interpolation point on a gradient conditional format. These pin the gradient color scale according to
    /// the color, type and value chosen.
    /// </summary>
    public class InterpolationPoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The color this interpolation point should use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>
        /// The color this interpolation point should use. If color is also set, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorStyle")]
        public virtual ColorStyle ColorStyle { get; set; }

        /// <summary>How the value should be interpreted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The value this interpolation point uses. May be a formula. Unused if type is MIN or MAX.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time interval, encoded as a Timestamp start (inclusive) and a Timestamp end (exclusive). The start
    /// must be less than or equal to the end. When the start equals the end, the interval is empty (matches no time).
    /// When both start and end are unspecified, the interval matches any time.
    /// </summary>
    public class Interval : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Exclusive end of the interval. If specified, a Timestamp matching this interval will have to be
        /// before the end.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Optional. Inclusive start of the interval. If specified, a Timestamp matching this interval will have to be
        /// the same or after the start.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Settings to control how circular dependencies are resolved with iterative calculation.</summary>
    public class IterativeCalculationSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When iterative calculation is enabled and successive results differ by less than this threshold value, the
        /// calculation rounds stop.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("convergenceThreshold")]
        public virtual System.Nullable<double> ConvergenceThreshold { get; set; }

        /// <summary>
        /// When iterative calculation is enabled, the maximum number of calculation rounds to perform.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxIterations")]
        public virtual System.Nullable<int> MaxIterations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Formatting options for key value.</summary>
    public class KeyValueFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the horizontal text positioning of key value. This field is optional. If not specified, default
        /// positioning is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual TextPosition Position { get; set; }

        /// <summary>Text formatting options for key value. The link field is not supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textFormat")]
        public virtual TextFormat TextFormat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties that describe the style of a line.</summary>
    public class LineStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dash type of the line.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The thickness of the line, in px.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An external or local reference.</summary>
    public class Link : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The link identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Allows you to manually organize the values in a source data column into buckets with names of your choosing. For
    /// example, a pivot table that aggregates population by state: +-------+-------------------+ | State | SUM of
    /// Population | +-------+-------------------+ | AK | 0.7 | | AL | 4.8 | | AR | 2.9 | ...
    /// +-------+-------------------+ could be turned into a pivot table that aggregates population by time zone by
    /// providing a list of groups (for example, groupName = 'Central', items = ['AL', 'AR', 'IA', ...]) to a manual
    /// group rule. Note that a similar effect could be achieved by adding a time zone column to the source data and
    /// adjusting the pivot table. +-----------+-------------------+ | Time Zone | SUM of Population |
    /// +-----------+-------------------+ | Central | 106.3 | | Eastern | 151.9 | | Mountain | 17.4 | ...
    /// +-----------+-------------------+
    /// </summary>
    public class ManualRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of group names and the corresponding items from the source data that map to each group name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groups")]
        public virtual System.Collections.Generic.IList<ManualRuleGroup> Groups { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A group name and a list of items from the source data that should be placed in the group with this name.
    /// </summary>
    public class ManualRuleGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The group name, which must be a string. Each group in a given ManualRule must have a unique group name.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupName")]
        public virtual ExtendedValue GroupName { get; set; }

        /// <summary>
        /// The items in the source data that should be placed into this group. Each item may be a string, number, or
        /// boolean. Items may appear in at most one group within a given ManualRule. Items that do not appear in any
        /// group will appear on their own.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<ExtendedValue> Items { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A developer metadata entry and the data filters specified in the original request that matched it.
    /// </summary>
    public class MatchedDeveloperMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>All filters matching the returned developer metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataFilters")]
        public virtual System.Collections.Generic.IList<DataFilter> DataFilters { get; set; }

        /// <summary>The developer metadata matching the specified filters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerMetadata")]
        public virtual DeveloperMetadata DeveloperMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A value range that was matched by one or more data filers.</summary>
    public class MatchedValueRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The DataFilters from the request that matched the range of values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataFilters")]
        public virtual System.Collections.Generic.IList<DataFilter> DataFilters { get; set; }

        /// <summary>The values matched by the DataFilter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueRange")]
        public virtual ValueRange ValueRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Merges all cells in the range.</summary>
    public class MergeCellsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How the cells should be merged.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mergeType")]
        public virtual string MergeType { get; set; }

        /// <summary>The range of cells to merge.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Moves one or more rows or columns.</summary>
    public class MoveDimensionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The zero-based start index of where to move the source data to, based on the coordinates *before* the source
        /// data is removed from the grid. Existing data will be shifted down or right (depending on the dimension) to
        /// make room for the moved dimensions. The source dimensions are removed from the grid, so the the data may end
        /// up in a different index than specified. For example, given `A1..A5` of `0, 1, 2, 3, 4` and wanting to move
        /// `"1"` and `"2"` to between `"3"` and `"4"`, the source would be `ROWS [1..3)`,and the destination index
        /// would be `"4"` (the zero-based index of row 5). The end result would be `A1..A5` of `0, 3, 1, 2, 4`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationIndex")]
        public virtual System.Nullable<int> DestinationIndex { get; set; }

        /// <summary>The source dimensions to move.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual DimensionRange Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A named range.</summary>
    public class NamedRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the named range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ID of the named range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedRangeId")]
        public virtual string NamedRangeId { get; set; }

        /// <summary>The range this represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The number format of a cell.</summary>
    public class NumberFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Pattern string used for formatting. If not set, a default pattern based on the user's locale will be used if
        /// necessary for the given type. See the [Date and Number Formats guide](/sheets/api/guides/formats) for more
        /// information about the supported patterns.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pattern")]
        public virtual string Pattern { get; set; }

        /// <summary>The type of the number format. When writing, this field must be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An org chart. Org charts require a unique set of labels in labels and may optionally include parent_labels and
    /// tooltips. parent_labels contain, for each node, the label identifying the parent node. tooltips contain, for
    /// each node, an optional tooltip. For example, to describe an OrgChart with Alice as the CEO, Bob as the President
    /// (reporting to Alice) and Cathy as VP of Sales (also reporting to Alice), have labels contain "Alice", "Bob",
    /// "Cathy", parent_labels contain "", "Alice", "Alice" and tooltips contain "CEO", "President", "VP Sales".
    /// </summary>
    public class OrgChartSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data containing the labels for all the nodes in the chart. Labels must be unique.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual ChartData Labels { get; set; }

        /// <summary>The color of the org chart nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeColor")]
        public virtual Color NodeColor { get; set; }

        /// <summary>The color of the org chart nodes. If node_color is also set, this field takes precedence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeColorStyle")]
        public virtual ColorStyle NodeColorStyle { get; set; }

        /// <summary>The size of the org chart nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeSize")]
        public virtual string NodeSize { get; set; }

        /// <summary>
        /// The data containing the label of the parent for the corresponding node. A blank value indicates that the
        /// node has no parent and is a top-level node. This field is optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentLabels")]
        public virtual ChartData ParentLabels { get; set; }

        /// <summary>The color of the selected org chart nodes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedNodeColor")]
        public virtual Color SelectedNodeColor { get; set; }

        /// <summary>
        /// The color of the selected org chart nodes. If selected_node_color is also set, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selectedNodeColorStyle")]
        public virtual ColorStyle SelectedNodeColorStyle { get; set; }

        /// <summary>
        /// The data containing the tooltip for the corresponding node. A blank value results in no tooltip being
        /// displayed for the node. This field is optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tooltips")]
        public virtual ChartData Tooltips { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The location an object is overlaid on top of a grid.</summary>
    public class OverlayPosition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cell the object is anchored to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anchorCell")]
        public virtual GridCoordinate AnchorCell { get; set; }

        /// <summary>The height of the object, in pixels. Defaults to 371.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("heightPixels")]
        public virtual System.Nullable<int> HeightPixels { get; set; }

        /// <summary>The horizontal offset, in pixels, that the object is offset from the anchor cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offsetXPixels")]
        public virtual System.Nullable<int> OffsetXPixels { get; set; }

        /// <summary>The vertical offset, in pixels, that the object is offset from the anchor cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("offsetYPixels")]
        public virtual System.Nullable<int> OffsetYPixels { get; set; }

        /// <summary>The width of the object, in pixels. Defaults to 600.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("widthPixels")]
        public virtual System.Nullable<int> WidthPixels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The amount of padding around the cell, in pixels. When updating padding, every field must be specified.
    /// </summary>
    public class Padding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The bottom padding of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottom")]
        public virtual System.Nullable<int> Bottom { get; set; }

        /// <summary>The left padding of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("left")]
        public virtual System.Nullable<int> Left { get; set; }

        /// <summary>The right padding of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("right")]
        public virtual System.Nullable<int> Right { get; set; }

        /// <summary>The top padding of the cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("top")]
        public virtual System.Nullable<int> Top { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Inserts data into the spreadsheet starting at the specified coordinate.</summary>
    public class PasteDataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The coordinate at which the data should start being inserted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coordinate")]
        public virtual GridCoordinate Coordinate { get; set; }

        /// <summary>The data to insert.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; }

        /// <summary>The delimiter in the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delimiter")]
        public virtual string Delimiter { get; set; }

        /// <summary>True if the data is HTML.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("html")]
        public virtual System.Nullable<bool> Html { get; set; }

        /// <summary>How the data should be pasted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A pie chart.</summary>
    public class PieChartSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data that covers the domain of the pie chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual ChartData Domain { get; set; }

        /// <summary>Where the legend of the pie chart should be drawn.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("legendPosition")]
        public virtual string LegendPosition { get; set; }

        /// <summary>The size of the hole in the pie chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pieHole")]
        public virtual System.Nullable<double> PieHole { get; set; }

        /// <summary>The data that covers the one and only series of the pie chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("series")]
        public virtual ChartData Series { get; set; }

        /// <summary>True if the pie is three dimensional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("threeDimensional")]
        public virtual System.Nullable<bool> ThreeDimensional { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Criteria for showing/hiding rows in a pivot table.</summary>
    public class PivotFilterCriteria : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A condition that must be true for values to be shown. (`visibleValues` does not override this -- even if a
        /// value is listed there, it is still hidden if it does not meet the condition.) Condition values that refer to
        /// ranges in A1-notation are evaluated relative to the pivot table sheet. References are treated absolutely, so
        /// are not filled down the pivot table. For example, a condition value of `=A1` on "Pivot Table 1" is treated
        /// as `'Pivot Table 1'!$A$1`. The source data of the pivot table can be referenced by column header name. For
        /// example, if the source data has columns named "Revenue" and "Cost" and a condition is applied to the
        /// "Revenue" column with type `NUMBER_GREATER` and value `=Cost`, then only columns where "Revenue" &amp;gt;
        /// "Cost" are included.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual BooleanCondition Condition { get; set; }

        /// <summary>
        /// Whether values are visible by default. If true, the visible_values are ignored, all values that meet
        /// condition (if specified) are shown. If false, values that are both in visible_values and meet condition are
        /// shown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibleByDefault")]
        public virtual System.Nullable<bool> VisibleByDefault { get; set; }

        /// <summary>Values that should be included. Values not listed here are excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("visibleValues")]
        public virtual System.Collections.Generic.IList<string> VisibleValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The pivot table filter criteria associated with a specific source column offset.</summary>
    public class PivotFilterSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The column offset of the source range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnOffsetIndex")]
        public virtual System.Nullable<int> ColumnOffsetIndex { get; set; }

        /// <summary>The reference to the data source column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceColumnReference")]
        public virtual DataSourceColumnReference DataSourceColumnReference { get; set; }

        /// <summary>The criteria for the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterCriteria")]
        public virtual PivotFilterCriteria FilterCriteria { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single grouping (either row or column) in a pivot table.</summary>
    public class PivotGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The reference to the data source column this grouping is based on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceColumnReference")]
        public virtual DataSourceColumnReference DataSourceColumnReference { get; set; }

        /// <summary>The count limit on rows or columns to apply to this pivot group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupLimit")]
        public virtual PivotGroupLimit GroupLimit { get; set; }

        /// <summary>The group rule to apply to this row/column group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupRule")]
        public virtual PivotGroupRule GroupRule { get; set; }

        /// <summary>
        /// The labels to use for the row/column groups which can be customized. For example, in the following pivot
        /// table, the row label is `Region` (which could be renamed to `State`) and the column label is `Product`
        /// (which could be renamed `Item`). Pivot tables created before December 2017 do not have header labels. If
        /// you'd like to add header labels to an existing pivot table, please delete the existing pivot table and then
        /// create a new pivot table with same parameters. +--------------+---------+-------+ | SUM of Units | Product |
        /// | | Region | Pen | Paper | +--------------+---------+-------+ | New York | 345 | 98 | | Oregon | 234 | 123 |
        /// | Tennessee | 531 | 415 | +--------------+---------+-------+ | Grand Total | 1110 | 636 |
        /// +--------------+---------+-------+
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>
        /// True if the headings in this pivot group should be repeated. This is only valid for row groupings and is
        /// ignored by columns. By default, we minimize repetition of headings by not showing higher level headings
        /// where they are the same. For example, even though the third row below corresponds to "Q1 Mar", "Q1" is not
        /// shown because it is redundant with previous rows. Setting repeat_headings to true would cause "Q1" to be
        /// repeated for "Feb" and "Mar". +--------------+ | Q1 | Jan | | | Feb | | | Mar | +--------+-----+ | Q1 Total
        /// | +--------------+
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repeatHeadings")]
        public virtual System.Nullable<bool> RepeatHeadings { get; set; }

        /// <summary>True if the pivot table should include the totals for this grouping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showTotals")]
        public virtual System.Nullable<bool> ShowTotals { get; set; }

        /// <summary>The order the values in this group should be sorted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortOrder")]
        public virtual string SortOrder { get; set; }

        /// <summary>
        /// The column offset of the source range that this grouping is based on. For example, if the source was
        /// `C10:E15`, a `sourceColumnOffset` of `0` means this group refers to column `C`, whereas the offset `1` would
        /// refer to column `D`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceColumnOffset")]
        public virtual System.Nullable<int> SourceColumnOffset { get; set; }

        /// <summary>
        /// The bucket of the opposite pivot group to sort by. If not specified, sorting is alphabetical by this group's
        /// values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueBucket")]
        public virtual PivotGroupSortValueBucket ValueBucket { get; set; }

        /// <summary>Metadata about values in the grouping.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueMetadata")]
        public virtual System.Collections.Generic.IList<PivotGroupValueMetadata> ValueMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The count limit on rows or columns in the pivot group.</summary>
    public class PivotGroupLimit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The order in which the group limit is applied to the pivot table. Pivot group limits are applied from lower
        /// to higher order number. Order numbers are normalized to consecutive integers from 0. For write request, to
        /// fully customize the applying orders, all pivot group limits should have this field set with an unique
        /// number. Otherwise, the order is determined by the index in the PivotTable.rows list and then the
        /// PivotTable.columns list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applyOrder")]
        public virtual System.Nullable<int> ApplyOrder { get; set; }

        /// <summary>The count limit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countLimit")]
        public virtual System.Nullable<int> CountLimit { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An optional setting on a PivotGroup that defines buckets for the values in the source data column rather than
    /// breaking out each individual value. Only one PivotGroup with a group rule may be added for each column in the
    /// source data, though on any given column you may add both a PivotGroup that has a rule and a PivotGroup that does
    /// not.
    /// </summary>
    public class PivotGroupRule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A DateTimeRule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dateTimeRule")]
        public virtual DateTimeRule DateTimeRule { get; set; }

        /// <summary>A HistogramRule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("histogramRule")]
        public virtual HistogramRule HistogramRule { get; set; }

        /// <summary>A ManualRule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manualRule")]
        public virtual ManualRule ManualRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about which values in a pivot group should be used for sorting.</summary>
    public class PivotGroupSortValueBucket : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Determines the bucket from which values are chosen to sort. For example, in a pivot table with one row group
        /// &amp;amp; two column groups, the row group can list up to two values. The first value corresponds to a value
        /// within the first column group, and the second value corresponds to a value in the second column group. If no
        /// values are listed, this would indicate that the row should be sorted according to the "Grand Total" over the
        /// column groups. If a single value is listed, this would correspond to using the "Total" of that bucket.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buckets")]
        public virtual System.Collections.Generic.IList<ExtendedValue> Buckets { get; set; }

        /// <summary>
        /// The offset in the PivotTable.values list which the values in this grouping should be sorted by.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valuesIndex")]
        public virtual System.Nullable<int> ValuesIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata about a value in a pivot grouping.</summary>
    public class PivotGroupValueMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if the data corresponding to the value is collapsed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("collapsed")]
        public virtual System.Nullable<bool> Collapsed { get; set; }

        /// <summary>
        /// The calculated value the metadata corresponds to. (Note that formulaValue is not valid, because the values
        /// will be calculated.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual ExtendedValue Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A pivot table.</summary>
    public class PivotTable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Each column grouping in the pivot table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columns")]
        public virtual System.Collections.Generic.IList<PivotGroup> Columns { get; set; }

        /// <summary>
        /// An optional mapping of filters per source column offset. The filters are applied before aggregating data
        /// into the pivot table. The map's key is the column offset of the source range that you want to filter, and
        /// the value is the criteria for that column. For example, if the source was `C10:E15`, a key of `0` will have
        /// the filter for column `C`, whereas the key `1` is for column `D`. This field is deprecated in favor of
        /// filter_specs.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("criteria")]
        public virtual System.Collections.Generic.IDictionary<string, PivotFilterCriteria> Criteria { get; set; }

        /// <summary>Output only. The data execution status for data source pivot tables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataExecutionStatus")]
        public virtual DataExecutionStatus DataExecutionStatus { get; set; }

        /// <summary>The ID of the data source the pivot table is reading data from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceId")]
        public virtual string DataSourceId { get; set; }

        /// <summary>
        /// The filters applied to the source columns before aggregating data for the pivot table. Both criteria and
        /// filter_specs are populated in responses. If both fields are specified in an update request, this field takes
        /// precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterSpecs")]
        public virtual System.Collections.Generic.IList<PivotFilterSpec> FilterSpecs { get; set; }

        /// <summary>Each row grouping in the pivot table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<PivotGroup> Rows { get; set; }

        /// <summary>The range the pivot table is reading data from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual GridRange Source { get; set; }

        /// <summary>Whether values should be listed horizontally (as columns) or vertically (as rows).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueLayout")]
        public virtual string ValueLayout { get; set; }

        /// <summary>A list of values to include in the pivot table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<PivotValue> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The definition of how a value in a pivot table should be calculated.</summary>
    public class PivotValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If specified, indicates that pivot values should be displayed as the result of a calculation with another
        /// pivot value. For example, if calculated_display_type is specified as PERCENT_OF_GRAND_TOTAL, all the pivot
        /// values are displayed as the percentage of the grand total. In the Sheets editor, this is referred to as
        /// "Show As" in the value section of a pivot table.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calculatedDisplayType")]
        public virtual string CalculatedDisplayType { get; set; }

        /// <summary>The reference to the data source column that this value reads from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceColumnReference")]
        public virtual DataSourceColumnReference DataSourceColumnReference { get; set; }

        /// <summary>A custom formula to calculate the value. The formula must start with an `=` character.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formula")]
        public virtual string Formula { get; set; }

        /// <summary>A name to use for the value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The column offset of the source range that this value reads from. For example, if the source was `C10:E15`,
        /// a `sourceColumnOffset` of `0` means this value refers to column `C`, whereas the offset `1` would refer to
        /// column `D`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceColumnOffset")]
        public virtual System.Nullable<int> SourceColumnOffset { get; set; }

        /// <summary>
        /// A function to summarize the value. If formula is set, the only supported values are SUM and CUSTOM. If
        /// sourceColumnOffset is set, then `CUSTOM` is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("summarizeFunction")]
        public virtual string SummarizeFunction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The style of a point on the chart.</summary>
    public class PointStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The point shape. If empty or unspecified, a default shape is used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shape")]
        public virtual string Shape { get; set; }

        /// <summary>The point size. If empty, a default size is used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<double> Size { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A protected range.</summary>
    public class ProtectedRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of this protected range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The users and groups with edit access to the protected range. This field is only visible to users with edit
        /// access to the protected range and the document. Editors are not supported with warning_only protection.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("editors")]
        public virtual Editors Editors { get; set; }

        /// <summary>
        /// The named range this protected range is backed by, if any. When writing, only one of range or named_range_id
        /// may be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedRangeId")]
        public virtual string NamedRangeId { get; set; }

        /// <summary>The ID of the protected range. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectedRangeId")]
        public virtual System.Nullable<int> ProtectedRangeId { get; set; }

        /// <summary>
        /// The range that is being protected. The range may be fully unbounded, in which case this is considered a
        /// protected sheet. When writing, only one of range or named_range_id may be set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>
        /// True if the user who requested this protected range can edit the protected area. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestingUserCanEdit")]
        public virtual System.Nullable<bool> RequestingUserCanEdit { get; set; }

        /// <summary>
        /// The list of unprotected ranges within a protected sheet. Unprotected ranges are only supported on protected
        /// sheets.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unprotectedRanges")]
        public virtual System.Collections.Generic.IList<GridRange> UnprotectedRanges { get; set; }

        /// <summary>
        /// True if this protected range will show a warning when editing. Warning-based protection means that every
        /// user can edit data in the protected range, except editing will prompt a warning asking the user to confirm
        /// the edit. When writing: if this field is true, then editors is ignored. Additionally, if this field is
        /// changed from true to false and the `editors` field is not set (nor included in the field mask), then the
        /// editors will be set to all the editors in the document.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warningOnly")]
        public virtual System.Nullable<bool> WarningOnly { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Randomizes the order of the rows in a range.</summary>
    public class RandomizeRangeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The range to randomize.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The execution status of refreshing one data source object.</summary>
    public class RefreshDataSourceObjectExecutionStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data execution status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataExecutionStatus")]
        public virtual DataExecutionStatus DataExecutionStatus { get; set; }

        /// <summary>Reference to a data source object being refreshed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reference")]
        public virtual DataSourceObjectReference Reference { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Refreshes one or multiple data source objects in the spreadsheet by the specified references. The request
    /// requires an additional `bigquery.readonly` OAuth scope. If there are multiple refresh requests referencing the
    /// same data source objects in one batch, only the last refresh request is processed, and all those requests will
    /// have the same response accordingly.
    /// </summary>
    public class RefreshDataSourceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Reference to a DataSource. If specified, refreshes all associated data source objects for the data source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceId")]
        public virtual string DataSourceId { get; set; }

        /// <summary>
        /// Refreshes the data source objects regardless of the current state. If not set and a referenced data source
        /// object was in error state, the refresh will fail immediately.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("force")]
        public virtual System.Nullable<bool> Force { get; set; }

        /// <summary>Refreshes all existing data source objects in the spreadsheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAll")]
        public virtual System.Nullable<bool> IsAll { get; set; }

        /// <summary>References to data source objects to refresh.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("references")]
        public virtual DataSourceObjectReferences References { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from refreshing one or multiple data source objects.</summary>
    public class RefreshDataSourceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// All the refresh status for the data source object references specified in the request. If is_all is
        /// specified, the field contains only those in failure status.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statuses")]
        public virtual System.Collections.Generic.IList<RefreshDataSourceObjectExecutionStatus> Statuses { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Updates all cells in the range to the values in the given Cell object. Only the fields listed in the fields
    /// field are updated; others are unchanged. If writing a cell with a formula, the formula's ranges will
    /// automatically increment for each field in the range. For example, if writing a cell with formula `=A1` into
    /// range B2:C4, B2 would be `=A1`, B3 would be `=A2`, B4 would be `=A3`, C2 would be `=B1`, C3 would be `=B2`, C4
    /// would be `=B3`. To keep the formula's ranges static, use the `$` indicator. For example, use the formula `=$A$1`
    /// to prevent both the row and the column from incrementing.
    /// </summary>
    public class RepeatCellRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data to write.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cell")]
        public virtual CellData Cell { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `cell` is implied and
        /// should not be specified. A single `"*"` can be used as short-hand for listing every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The range to repeat the cell in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single kind of update to apply to a spreadsheet.</summary>
    public class Request : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Adds a new banded range</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addBanding")]
        public virtual AddBandingRequest AddBanding { get; set; }

        /// <summary>Adds a chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addChart")]
        public virtual AddChartRequest AddChart { get; set; }

        /// <summary>Adds a new conditional format rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addConditionalFormatRule")]
        public virtual AddConditionalFormatRuleRequest AddConditionalFormatRule { get; set; }

        /// <summary>Adds a data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addDataSource")]
        public virtual AddDataSourceRequest AddDataSource { get; set; }

        /// <summary>Creates a group over the specified range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addDimensionGroup")]
        public virtual AddDimensionGroupRequest AddDimensionGroup { get; set; }

        /// <summary>Adds a filter view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addFilterView")]
        public virtual AddFilterViewRequest AddFilterView { get; set; }

        /// <summary>Adds a named range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addNamedRange")]
        public virtual AddNamedRangeRequest AddNamedRange { get; set; }

        /// <summary>Adds a protected range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addProtectedRange")]
        public virtual AddProtectedRangeRequest AddProtectedRange { get; set; }

        /// <summary>Adds a sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addSheet")]
        public virtual AddSheetRequest AddSheet { get; set; }

        /// <summary>Adds a slicer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addSlicer")]
        public virtual AddSlicerRequest AddSlicer { get; set; }

        /// <summary>Appends cells after the last row with data in a sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appendCells")]
        public virtual AppendCellsRequest AppendCells { get; set; }

        /// <summary>Appends dimensions to the end of a sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("appendDimension")]
        public virtual AppendDimensionRequest AppendDimension { get; set; }

        /// <summary>Automatically fills in more data based on existing data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoFill")]
        public virtual AutoFillRequest AutoFill { get; set; }

        /// <summary>
        /// Automatically resizes one or more dimensions based on the contents of the cells in that dimension.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoResizeDimensions")]
        public virtual AutoResizeDimensionsRequest AutoResizeDimensions { get; set; }

        /// <summary>Clears the basic filter on a sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clearBasicFilter")]
        public virtual ClearBasicFilterRequest ClearBasicFilter { get; set; }

        /// <summary>Copies data from one area and pastes it to another.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("copyPaste")]
        public virtual CopyPasteRequest CopyPaste { get; set; }

        /// <summary>Creates new developer metadata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createDeveloperMetadata")]
        public virtual CreateDeveloperMetadataRequest CreateDeveloperMetadata { get; set; }

        /// <summary>Cuts data from one area and pastes it to another.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cutPaste")]
        public virtual CutPasteRequest CutPaste { get; set; }

        /// <summary>Removes a banded range</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteBanding")]
        public virtual DeleteBandingRequest DeleteBanding { get; set; }

        /// <summary>Deletes an existing conditional format rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteConditionalFormatRule")]
        public virtual DeleteConditionalFormatRuleRequest DeleteConditionalFormatRule { get; set; }

        /// <summary>Deletes a data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteDataSource")]
        public virtual DeleteDataSourceRequest DeleteDataSource { get; set; }

        /// <summary>Deletes developer metadata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteDeveloperMetadata")]
        public virtual DeleteDeveloperMetadataRequest DeleteDeveloperMetadata { get; set; }

        /// <summary>Deletes rows or columns in a sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteDimension")]
        public virtual DeleteDimensionRequest DeleteDimension { get; set; }

        /// <summary>Deletes a group over the specified range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteDimensionGroup")]
        public virtual DeleteDimensionGroupRequest DeleteDimensionGroup { get; set; }

        /// <summary>Removes rows containing duplicate values in specified columns of a cell range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteDuplicates")]
        public virtual DeleteDuplicatesRequest DeleteDuplicates { get; set; }

        /// <summary>Deletes an embedded object (e.g, chart, image) in a sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteEmbeddedObject")]
        public virtual DeleteEmbeddedObjectRequest DeleteEmbeddedObject { get; set; }

        /// <summary>Deletes a filter view from a sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteFilterView")]
        public virtual DeleteFilterViewRequest DeleteFilterView { get; set; }

        /// <summary>Deletes a named range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteNamedRange")]
        public virtual DeleteNamedRangeRequest DeleteNamedRange { get; set; }

        /// <summary>Deletes a protected range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteProtectedRange")]
        public virtual DeleteProtectedRangeRequest DeleteProtectedRange { get; set; }

        /// <summary>Deletes a range of cells from a sheet, shifting the remaining cells.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteRange")]
        public virtual DeleteRangeRequest DeleteRange { get; set; }

        /// <summary>Deletes a sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteSheet")]
        public virtual DeleteSheetRequest DeleteSheet { get; set; }

        /// <summary>Duplicates a filter view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duplicateFilterView")]
        public virtual DuplicateFilterViewRequest DuplicateFilterView { get; set; }

        /// <summary>Duplicates a sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duplicateSheet")]
        public virtual DuplicateSheetRequest DuplicateSheet { get; set; }

        /// <summary>Finds and replaces occurrences of some text with other text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findReplace")]
        public virtual FindReplaceRequest FindReplace { get; set; }

        /// <summary>Inserts new rows or columns in a sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertDimension")]
        public virtual InsertDimensionRequest InsertDimension { get; set; }

        /// <summary>Inserts new cells in a sheet, shifting the existing cells.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("insertRange")]
        public virtual InsertRangeRequest InsertRange { get; set; }

        /// <summary>Merges cells together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mergeCells")]
        public virtual MergeCellsRequest MergeCells { get; set; }

        /// <summary>Moves rows or columns to another location in a sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moveDimension")]
        public virtual MoveDimensionRequest MoveDimension { get; set; }

        /// <summary>Pastes data (HTML or delimited) into a sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pasteData")]
        public virtual PasteDataRequest PasteData { get; set; }

        /// <summary>Randomizes the order of the rows in a range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("randomizeRange")]
        public virtual RandomizeRangeRequest RandomizeRange { get; set; }

        /// <summary>Refreshs one or multiple data sources and associated dbobjects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshDataSource")]
        public virtual RefreshDataSourceRequest RefreshDataSource { get; set; }

        /// <summary>Repeats a single cell across a range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repeatCell")]
        public virtual RepeatCellRequest RepeatCell { get; set; }

        /// <summary>Sets the basic filter on a sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setBasicFilter")]
        public virtual SetBasicFilterRequest SetBasicFilter { get; set; }

        /// <summary>Sets data validation for one or more cells.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setDataValidation")]
        public virtual SetDataValidationRequest SetDataValidation { get; set; }

        /// <summary>Sorts data in a range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortRange")]
        public virtual SortRangeRequest SortRange { get; set; }

        /// <summary>Converts a column of text into many columns of text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textToColumns")]
        public virtual TextToColumnsRequest TextToColumns { get; set; }

        /// <summary>Trims cells of whitespace (such as spaces, tabs, or new lines).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trimWhitespace")]
        public virtual TrimWhitespaceRequest TrimWhitespace { get; set; }

        /// <summary>Unmerges merged cells.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unmergeCells")]
        public virtual UnmergeCellsRequest UnmergeCells { get; set; }

        /// <summary>Updates a banded range</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateBanding")]
        public virtual UpdateBandingRequest UpdateBanding { get; set; }

        /// <summary>Updates the borders in a range of cells.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateBorders")]
        public virtual UpdateBordersRequest UpdateBorders { get; set; }

        /// <summary>Updates many cells at once.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateCells")]
        public virtual UpdateCellsRequest UpdateCells { get; set; }

        /// <summary>Updates a chart's specifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateChartSpec")]
        public virtual UpdateChartSpecRequest UpdateChartSpec { get; set; }

        /// <summary>Updates an existing conditional format rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateConditionalFormatRule")]
        public virtual UpdateConditionalFormatRuleRequest UpdateConditionalFormatRule { get; set; }

        /// <summary>Updates a data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateDataSource")]
        public virtual UpdateDataSourceRequest UpdateDataSource { get; set; }

        /// <summary>Updates an existing developer metadata entry</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateDeveloperMetadata")]
        public virtual UpdateDeveloperMetadataRequest UpdateDeveloperMetadata { get; set; }

        /// <summary>Updates the state of the specified group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateDimensionGroup")]
        public virtual UpdateDimensionGroupRequest UpdateDimensionGroup { get; set; }

        /// <summary>Updates dimensions' properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateDimensionProperties")]
        public virtual UpdateDimensionPropertiesRequest UpdateDimensionProperties { get; set; }

        /// <summary>Updates an embedded object's border.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateEmbeddedObjectBorder")]
        public virtual UpdateEmbeddedObjectBorderRequest UpdateEmbeddedObjectBorder { get; set; }

        /// <summary>Updates an embedded object's (e.g. chart, image) position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateEmbeddedObjectPosition")]
        public virtual UpdateEmbeddedObjectPositionRequest UpdateEmbeddedObjectPosition { get; set; }

        /// <summary>Updates the properties of a filter view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateFilterView")]
        public virtual UpdateFilterViewRequest UpdateFilterView { get; set; }

        /// <summary>Updates a named range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateNamedRange")]
        public virtual UpdateNamedRangeRequest UpdateNamedRange { get; set; }

        /// <summary>Updates a protected range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateProtectedRange")]
        public virtual UpdateProtectedRangeRequest UpdateProtectedRange { get; set; }

        /// <summary>Updates a sheet's properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateSheetProperties")]
        public virtual UpdateSheetPropertiesRequest UpdateSheetProperties { get; set; }

        /// <summary>Updates a slicer's specifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateSlicerSpec")]
        public virtual UpdateSlicerSpecRequest UpdateSlicerSpec { get; set; }

        /// <summary>Updates the spreadsheet's properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateSpreadsheetProperties")]
        public virtual UpdateSpreadsheetPropertiesRequest UpdateSpreadsheetProperties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single response from an update.</summary>
    public class Response : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A reply from adding a banded range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addBanding")]
        public virtual AddBandingResponse AddBanding { get; set; }

        /// <summary>A reply from adding a chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addChart")]
        public virtual AddChartResponse AddChart { get; set; }

        /// <summary>A reply from adding a data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addDataSource")]
        public virtual AddDataSourceResponse AddDataSource { get; set; }

        /// <summary>A reply from adding a dimension group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addDimensionGroup")]
        public virtual AddDimensionGroupResponse AddDimensionGroup { get; set; }

        /// <summary>A reply from adding a filter view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addFilterView")]
        public virtual AddFilterViewResponse AddFilterView { get; set; }

        /// <summary>A reply from adding a named range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addNamedRange")]
        public virtual AddNamedRangeResponse AddNamedRange { get; set; }

        /// <summary>A reply from adding a protected range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addProtectedRange")]
        public virtual AddProtectedRangeResponse AddProtectedRange { get; set; }

        /// <summary>A reply from adding a sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addSheet")]
        public virtual AddSheetResponse AddSheet { get; set; }

        /// <summary>A reply from adding a slicer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addSlicer")]
        public virtual AddSlicerResponse AddSlicer { get; set; }

        /// <summary>A reply from creating a developer metadata entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createDeveloperMetadata")]
        public virtual CreateDeveloperMetadataResponse CreateDeveloperMetadata { get; set; }

        /// <summary>A reply from deleting a conditional format rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteConditionalFormatRule")]
        public virtual DeleteConditionalFormatRuleResponse DeleteConditionalFormatRule { get; set; }

        /// <summary>A reply from deleting a developer metadata entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteDeveloperMetadata")]
        public virtual DeleteDeveloperMetadataResponse DeleteDeveloperMetadata { get; set; }

        /// <summary>A reply from deleting a dimension group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteDimensionGroup")]
        public virtual DeleteDimensionGroupResponse DeleteDimensionGroup { get; set; }

        /// <summary>A reply from removing rows containing duplicate values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deleteDuplicates")]
        public virtual DeleteDuplicatesResponse DeleteDuplicates { get; set; }

        /// <summary>A reply from duplicating a filter view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duplicateFilterView")]
        public virtual DuplicateFilterViewResponse DuplicateFilterView { get; set; }

        /// <summary>A reply from duplicating a sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duplicateSheet")]
        public virtual DuplicateSheetResponse DuplicateSheet { get; set; }

        /// <summary>A reply from doing a find/replace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findReplace")]
        public virtual FindReplaceResponse FindReplace { get; set; }

        /// <summary>A reply from refreshing data source objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("refreshDataSource")]
        public virtual RefreshDataSourceResponse RefreshDataSource { get; set; }

        /// <summary>A reply from trimming whitespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trimWhitespace")]
        public virtual TrimWhitespaceResponse TrimWhitespace { get; set; }

        /// <summary>A reply from updating a conditional format rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateConditionalFormatRule")]
        public virtual UpdateConditionalFormatRuleResponse UpdateConditionalFormatRule { get; set; }

        /// <summary>A reply from updating a data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateDataSource")]
        public virtual UpdateDataSourceResponse UpdateDataSource { get; set; }

        /// <summary>A reply from updating a developer metadata entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateDeveloperMetadata")]
        public virtual UpdateDeveloperMetadataResponse UpdateDeveloperMetadata { get; set; }

        /// <summary>A reply from updating an embedded object's position.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateEmbeddedObjectPosition")]
        public virtual UpdateEmbeddedObjectPositionResponse UpdateEmbeddedObjectPosition { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data about each cell in a row.</summary>
    public class RowData : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The values in the row, one per column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<CellData> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A scorecard chart. Scorecard charts are used to highlight key performance indicators, known as KPIs, on the
    /// spreadsheet. A scorecard chart can represent things like total sales, average cost, or a top selling item. You
    /// can specify a single data value, or aggregate over a range of data. Percentage or absolute difference from a
    /// baseline value can be highlighted, like changes over time.
    /// </summary>
    public class ScorecardChartSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The aggregation type for key and baseline chart data in scorecard chart. This field is not supported for
        /// data source charts. Use the ChartData.aggregateType field of the key_value_data or baseline_value_data
        /// instead for data source charts. This field is optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregateType")]
        public virtual string AggregateType { get; set; }

        /// <summary>The data for scorecard baseline value. This field is optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baselineValueData")]
        public virtual ChartData BaselineValueData { get; set; }

        /// <summary>
        /// Formatting options for baseline value. This field is needed only if baseline_value_data is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baselineValueFormat")]
        public virtual BaselineValueFormat BaselineValueFormat { get; set; }

        /// <summary>
        /// Custom formatting options for numeric key/baseline values in scorecard chart. This field is used only when
        /// number_format_source is set to CUSTOM. This field is optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customFormatOptions")]
        public virtual ChartCustomNumberFormatOptions CustomFormatOptions { get; set; }

        /// <summary>The data for scorecard key value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyValueData")]
        public virtual ChartData KeyValueData { get; set; }

        /// <summary>Formatting options for key value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyValueFormat")]
        public virtual KeyValueFormat KeyValueFormat { get; set; }

        /// <summary>The number format source used in the scorecard chart. This field is optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberFormatSource")]
        public virtual string NumberFormatSource { get; set; }

        /// <summary>
        /// Value to scale scorecard key and baseline value. For example, a factor of 10 can be used to divide all
        /// values in the chart by 10. This field is optional.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scaleFactor")]
        public virtual System.Nullable<double> ScaleFactor { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to retrieve all developer metadata matching the set of specified criteria.</summary>
    public class SearchDeveloperMetadataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The data filters describing the criteria used to determine which DeveloperMetadata entries to return.
        /// DeveloperMetadata matching any of the specified filters are included in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataFilters")]
        public virtual System.Collections.Generic.IList<DataFilter> DataFilters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A reply to a developer metadata search request.</summary>
    public class SearchDeveloperMetadataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The metadata matching the criteria of the search request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchedDeveloperMetadata")]
        public virtual System.Collections.Generic.IList<MatchedDeveloperMetadata> MatchedDeveloperMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sets the basic filter associated with a sheet.</summary>
    public class SetBasicFilterRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The filter to set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual BasicFilter Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Sets a data validation rule to every cell in the range. To clear validation in a range, call this with no rule
    /// specified.
    /// </summary>
    public class SetDataValidationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The range the data validation rule should apply to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>
        /// The data validation rule to set on each cell in the range, or empty to clear the data validation in the
        /// range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rule")]
        public virtual DataValidationRule Rule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A sheet in a spreadsheet.</summary>
    public class Sheet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The banded (alternating colors) ranges on this sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bandedRanges")]
        public virtual System.Collections.Generic.IList<BandedRange> BandedRanges { get; set; }

        /// <summary>The filter on this sheet, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicFilter")]
        public virtual BasicFilter BasicFilter { get; set; }

        /// <summary>The specifications of every chart on this sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("charts")]
        public virtual System.Collections.Generic.IList<EmbeddedChart> Charts { get; set; }

        /// <summary>
        /// All column groups on this sheet, ordered by increasing range start index, then by group depth.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnGroups")]
        public virtual System.Collections.Generic.IList<DimensionGroup> ColumnGroups { get; set; }

        /// <summary>The conditional format rules in this sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionalFormats")]
        public virtual System.Collections.Generic.IList<ConditionalFormatRule> ConditionalFormats { get; set; }

        /// <summary>
        /// Data in the grid, if this is a grid sheet. The number of GridData objects returned is dependent on the
        /// number of ranges requested on this sheet. For example, if this is representing `Sheet1`, and the spreadsheet
        /// was requested with ranges `Sheet1!A1:C10` and `Sheet1!D15:E20`, then the first GridData will have a
        /// startRow/startColumn of `0`, while the second one will have `startRow 14` (zero-based row 15), and
        /// `startColumn 3` (zero-based column D). For a DATA_SOURCE sheet, you can not request a specific range, the
        /// GridData contains all the values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual System.Collections.Generic.IList<GridData> Data { get; set; }

        /// <summary>The developer metadata associated with a sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerMetadata")]
        public virtual System.Collections.Generic.IList<DeveloperMetadata> DeveloperMetadata { get; set; }

        /// <summary>The filter views in this sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterViews")]
        public virtual System.Collections.Generic.IList<FilterView> FilterViews { get; set; }

        /// <summary>The ranges that are merged together.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("merges")]
        public virtual System.Collections.Generic.IList<GridRange> Merges { get; set; }

        /// <summary>The properties of the sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual SheetProperties Properties { get; set; }

        /// <summary>The protected ranges in this sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectedRanges")]
        public virtual System.Collections.Generic.IList<ProtectedRange> ProtectedRanges { get; set; }

        /// <summary>
        /// All row groups on this sheet, ordered by increasing range start index, then by group depth.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowGroups")]
        public virtual System.Collections.Generic.IList<DimensionGroup> RowGroups { get; set; }

        /// <summary>The slicers on this sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slicers")]
        public virtual System.Collections.Generic.IList<Slicer> Slicers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties of a sheet.</summary>
    public class SheetProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. If present, the field contains DATA_SOURCE sheet specific properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceSheetProperties")]
        public virtual DataSourceSheetProperties DataSourceSheetProperties { get; set; }

        /// <summary>
        /// Additional properties of the sheet if this sheet is a grid. (If the sheet is an object sheet, containing a
        /// chart or image, then this field will be absent.) When writing it is an error to set any grid properties on
        /// non-grid sheets. If this sheet is a DATA_SOURCE sheet, this field is output only but contains the properties
        /// that reflect how a data source sheet is rendered in the UI, e.g. row_count.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gridProperties")]
        public virtual GridProperties GridProperties { get; set; }

        /// <summary>True if the sheet is hidden in the UI, false if it's visible.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hidden")]
        public virtual System.Nullable<bool> Hidden { get; set; }

        /// <summary>
        /// The index of the sheet within the spreadsheet. When adding or updating sheet properties, if this field is
        /// excluded then the sheet is added or moved to the end of the sheet list. When updating sheet indices or
        /// inserting sheets, movement is considered in "before the move" indexes. For example, if there were 3 sheets
        /// (S1, S2, S3) in order to move S1 ahead of S2 the index would have to be set to 2. A sheet index update
        /// request is ignored if the requested index is identical to the sheets current index or if the requested new
        /// index is equal to the current sheet index + 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>True if the sheet is an RTL sheet instead of an LTR sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rightToLeft")]
        public virtual System.Nullable<bool> RightToLeft { get; set; }

        /// <summary>The ID of the sheet. Must be non-negative. This field cannot be changed once set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetId")]
        public virtual System.Nullable<int> SheetId { get; set; }

        /// <summary>The type of sheet. Defaults to GRID. This field cannot be changed once set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetType")]
        public virtual string SheetType { get; set; }

        /// <summary>The color of the tab in the UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tabColor")]
        public virtual Color TabColor { get; set; }

        /// <summary>The color of the tab in the UI. If tab_color is also set, this field takes precedence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tabColorStyle")]
        public virtual ColorStyle TabColorStyle { get; set; }

        /// <summary>The name of the sheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A slicer in a sheet.</summary>
    public class Slicer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The position of the slicer. Note that slicer can be positioned only on existing sheet. Also, width and
        /// height of slicer can be automatically adjusted to keep it within permitted limits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual EmbeddedObjectPosition Position { get; set; }

        /// <summary>The ID of the slicer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slicerId")]
        public virtual System.Nullable<int> SlicerId { get; set; }

        /// <summary>The specification of the slicer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual SlicerSpec Spec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The specifications of a slicer.</summary>
    public class SlicerSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if the filter should apply to pivot tables. If not set, default to `True`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applyToPivotTables")]
        public virtual System.Nullable<bool> ApplyToPivotTables { get; set; }

        /// <summary>The background color of the slicer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual Color BackgroundColor { get; set; }

        /// <summary>
        /// The background color of the slicer. If background_color is also set, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColorStyle")]
        public virtual ColorStyle BackgroundColorStyle { get; set; }

        /// <summary>The column index in the data table on which the filter is applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnIndex")]
        public virtual System.Nullable<int> ColumnIndex { get; set; }

        /// <summary>The data range of the slicer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataRange")]
        public virtual GridRange DataRange { get; set; }

        /// <summary>The filtering criteria of the slicer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filterCriteria")]
        public virtual FilterCriteria FilterCriteria { get; set; }

        /// <summary>The horizontal alignment of title in the slicer. If unspecified, defaults to `LEFT`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizontalAlignment")]
        public virtual string HorizontalAlignment { get; set; }

        /// <summary>The text format of title in the slicer. The link field is not supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textFormat")]
        public virtual TextFormat TextFormat { get; set; }

        /// <summary>The title of the slicer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Sorts data in rows based on a sort order per column.</summary>
    public class SortRangeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The range to sort.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>
        /// The sort order per column. Later specifications are used when values are equal in the earlier
        /// specifications.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortSpecs")]
        public virtual System.Collections.Generic.IList<SortSpec> SortSpecs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A sort order associated with a specific column or row.</summary>
    public class SortSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The background fill color to sort by; cells with this fill color are sorted to the top. Mutually exclusive
        /// with foreground_color.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColor")]
        public virtual Color BackgroundColor { get; set; }

        /// <summary>
        /// The background fill color to sort by; cells with this fill color are sorted to the top. Mutually exclusive
        /// with foreground_color, and must be an RGB-type color. If background_color is also set, this field takes
        /// precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("backgroundColorStyle")]
        public virtual ColorStyle BackgroundColorStyle { get; set; }

        /// <summary>Reference to a data source column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceColumnReference")]
        public virtual DataSourceColumnReference DataSourceColumnReference { get; set; }

        /// <summary>The dimension the sort should be applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionIndex")]
        public virtual System.Nullable<int> DimensionIndex { get; set; }

        /// <summary>
        /// The foreground color to sort by; cells with this foreground color are sorted to the top. Mutually exclusive
        /// with background_color.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foregroundColor")]
        public virtual Color ForegroundColor { get; set; }

        /// <summary>
        /// The foreground color to sort by; cells with this foreground color are sorted to the top. Mutually exclusive
        /// with background_color, and must be an RGB-type color. If foreground_color is also set, this field takes
        /// precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foregroundColorStyle")]
        public virtual ColorStyle ForegroundColorStyle { get; set; }

        /// <summary>The order data should be sorted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sortOrder")]
        public virtual string SortOrder { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A combination of a source range and how to extend that source.</summary>
    public class SourceAndDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The dimension that data should be filled into.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; }

        /// <summary>
        /// The number of rows or columns that data should be filled into. Positive numbers expand beyond the last row
        /// or last column of the source. Negative numbers expand before the first row or first column of the source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fillLength")]
        public virtual System.Nullable<int> FillLength { get; set; }

        /// <summary>The location of the data to use as the source of the autofill.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual GridRange Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource that represents a spreadsheet.</summary>
    public class Spreadsheet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. A list of data source refresh schedules.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceSchedules")]
        public virtual System.Collections.Generic.IList<DataSourceRefreshSchedule> DataSourceSchedules { get; set; }

        /// <summary>A list of external data sources connected with the spreadsheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSources")]
        public virtual System.Collections.Generic.IList<DataSource> DataSources { get; set; }

        /// <summary>The developer metadata associated with a spreadsheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerMetadata")]
        public virtual System.Collections.Generic.IList<DeveloperMetadata> DeveloperMetadata { get; set; }

        /// <summary>The named ranges defined in a spreadsheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedRanges")]
        public virtual System.Collections.Generic.IList<NamedRange> NamedRanges { get; set; }

        /// <summary>Overall properties of a spreadsheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual SpreadsheetProperties Properties { get; set; }

        /// <summary>The sheets that are part of a spreadsheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheets")]
        public virtual System.Collections.Generic.IList<Sheet> Sheets { get; set; }

        /// <summary>The ID of the spreadsheet. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheetId")]
        public virtual string SpreadsheetId { get; set; }

        /// <summary>The url of the spreadsheet. This field is read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheetUrl")]
        public virtual string SpreadsheetUrl { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Properties of a spreadsheet.</summary>
    public class SpreadsheetProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The amount of time to wait before volatile functions are recalculated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoRecalc")]
        public virtual string AutoRecalc { get; set; }

        /// <summary>
        /// The default format of all cells in the spreadsheet. CellData.effectiveFormat will not be set if the cell's
        /// format is equal to this default format. This field is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultFormat")]
        public virtual CellFormat DefaultFormat { get; set; }

        /// <summary>
        /// Determines whether and how circular references are resolved with iterative calculation. Absence of this
        /// field means that circular references result in calculation errors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iterativeCalculationSettings")]
        public virtual IterativeCalculationSettings IterativeCalculationSettings { get; set; }

        /// <summary>
        /// The locale of the spreadsheet in one of the following formats: * an ISO 639-1 language code such as `en` *
        /// an ISO 639-2 language code such as `fil`, if no 639-1 code exists * a combination of the ISO language code
        /// and country code, such as `en_US` Note: when updating this field, not all locales/languages are supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locale")]
        public virtual string Locale { get; set; }

        /// <summary>Theme applied to the spreadsheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheetTheme")]
        public virtual SpreadsheetTheme SpreadsheetTheme { get; set; }

        /// <summary>
        /// The time zone of the spreadsheet, in CLDR format such as `America/New_York`. If the time zone isn't
        /// recognized, this may be a custom time zone such as `GMT-07:00`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; }

        /// <summary>The title of the spreadsheet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents spreadsheet theme</summary>
    public class SpreadsheetTheme : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the primary font family.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryFontFamily")]
        public virtual string PrimaryFontFamily { get; set; }

        /// <summary>The spreadsheet theme color pairs. To update you must provide all theme color pairs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("themeColors")]
        public virtual System.Collections.Generic.IList<ThemeColorPair> ThemeColors { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The format of a run of text in a cell. Absent values indicate that the field isn't specified.</summary>
    public class TextFormat : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>True if the text is bold.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bold")]
        public virtual System.Nullable<bool> Bold { get; set; }

        /// <summary>The font family.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontFamily")]
        public virtual string FontFamily { get; set; }

        /// <summary>The size of the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fontSize")]
        public virtual System.Nullable<int> FontSize { get; set; }

        /// <summary>The foreground color of the text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foregroundColor")]
        public virtual Color ForegroundColor { get; set; }

        /// <summary>
        /// The foreground color of the text. If foreground_color is also set, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("foregroundColorStyle")]
        public virtual ColorStyle ForegroundColorStyle { get; set; }

        /// <summary>True if the text is italicized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("italic")]
        public virtual System.Nullable<bool> Italic { get; set; }

        /// <summary>
        /// The link destination of the text, if any. Setting the link field in a TextFormatRun will clear the cell's
        /// existing links or a cell-level link set in the same request. When a link is set, the text foreground color
        /// will be set to the default link color and the text will be underlined. If these fields are modified in the
        /// same request, those values will be used instead of the link defaults.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual Link Link { get; set; }

        /// <summary>True if the text has a strikethrough.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("strikethrough")]
        public virtual System.Nullable<bool> Strikethrough { get; set; }

        /// <summary>True if the text is underlined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("underline")]
        public virtual System.Nullable<bool> Underline { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A run of a text format. The format of this run continues until the start index of the next run. When updating,
    /// all fields must be set.
    /// </summary>
    public class TextFormatRun : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The format of this run. Absent values inherit the cell's format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual TextFormat Format { get; set; }

        /// <summary>The character index where this run starts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Position settings for text.</summary>
    public class TextPosition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Horizontal alignment setting for the piece of text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizontalAlignment")]
        public virtual string HorizontalAlignment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The rotation applied to text in a cell.</summary>
    public class TextRotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The angle between the standard orientation and the desired orientation. Measured in degrees. Valid values
        /// are between -90 and 90. Positive angles are angled upwards, negative are angled downwards. Note: For LTR
        /// text direction positive angles are in the counterclockwise direction, whereas for RTL they are in the
        /// clockwise direction
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("angle")]
        public virtual System.Nullable<int> Angle { get; set; }

        /// <summary>
        /// If true, text reads top to bottom, but the orientation of individual characters is unchanged. For example: |
        /// V | | e | | r | | t | | i | | c | | a | | l |
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vertical")]
        public virtual System.Nullable<bool> Vertical { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Splits a column of text into multiple columns, based on a delimiter in each cell.</summary>
    public class TextToColumnsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The delimiter to use. Used only if delimiterType is CUSTOM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delimiter")]
        public virtual string Delimiter { get; set; }

        /// <summary>The delimiter type to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delimiterType")]
        public virtual string DelimiterType { get; set; }

        /// <summary>The source data range. This must span exactly one column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual GridRange Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A pair mapping a spreadsheet theme color type to the concrete color it represents.</summary>
    public class ThemeColorPair : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The concrete color corresponding to the theme color type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual ColorStyle Color { get; set; }

        /// <summary>The type of the spreadsheet theme color.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorType")]
        public virtual string ColorType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class TimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for
        /// scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows
        /// leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A color scale for a treemap chart.</summary>
    public class TreemapChartColorScale : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The background color for cells with a color value greater than or equal to maxValue. Defaults to #109618 if
        /// not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValueColor")]
        public virtual Color MaxValueColor { get; set; }

        /// <summary>
        /// The background color for cells with a color value greater than or equal to maxValue. Defaults to #109618 if
        /// not specified. If max_value_color is also set, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValueColorStyle")]
        public virtual ColorStyle MaxValueColorStyle { get; set; }

        /// <summary>
        /// The background color for cells with a color value at the midpoint between minValue and maxValue. Defaults to
        /// #efe6dc if not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("midValueColor")]
        public virtual Color MidValueColor { get; set; }

        /// <summary>
        /// The background color for cells with a color value at the midpoint between minValue and maxValue. Defaults to
        /// #efe6dc if not specified. If mid_value_color is also set, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("midValueColorStyle")]
        public virtual ColorStyle MidValueColorStyle { get; set; }

        /// <summary>
        /// The background color for cells with a color value less than or equal to minValue. Defaults to #dc3912 if not
        /// specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValueColor")]
        public virtual Color MinValueColor { get; set; }

        /// <summary>
        /// The background color for cells with a color value less than or equal to minValue. Defaults to #dc3912 if not
        /// specified. If min_value_color is also set, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValueColorStyle")]
        public virtual ColorStyle MinValueColorStyle { get; set; }

        /// <summary>
        /// The background color for cells that have no color data associated with them. Defaults to #000000 if not
        /// specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noDataColor")]
        public virtual Color NoDataColor { get; set; }

        /// <summary>
        /// The background color for cells that have no color data associated with them. Defaults to #000000 if not
        /// specified. If no_data_color is also set, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noDataColorStyle")]
        public virtual ColorStyle NoDataColorStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Treemap chart.</summary>
    public class TreemapChartSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The data that determines the background color of each treemap data cell. This field is optional. If not
        /// specified, size_data is used to determine background colors. If specified, the data is expected to be
        /// numeric. color_scale will determine how the values in this data map to data cell background colors.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorData")]
        public virtual ChartData ColorData { get; set; }

        /// <summary>
        /// The color scale for data cells in the treemap chart. Data cells are assigned colors based on their color
        /// values. These color values come from color_data, or from size_data if color_data is not specified. Cells
        /// with color values less than or equal to min_value will have minValueColor as their background color. Cells
        /// with color values greater than or equal to max_value will have maxValueColor as their background color.
        /// Cells with color values between min_value and max_value will have background colors on a gradient between
        /// minValueColor and maxValueColor, the midpoint of the gradient being midValueColor. Cells with missing or
        /// non-numeric color values will have noDataColor as their background color.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorScale")]
        public virtual TreemapChartColorScale ColorScale { get; set; }

        /// <summary>The background color for header cells.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerColor")]
        public virtual Color HeaderColor { get; set; }

        /// <summary>
        /// The background color for header cells. If header_color is also set, this field takes precedence.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("headerColorStyle")]
        public virtual ColorStyle HeaderColorStyle { get; set; }

        /// <summary>True to hide tooltips.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hideTooltips")]
        public virtual System.Nullable<bool> HideTooltips { get; set; }

        /// <summary>
        /// The number of additional data levels beyond the labeled levels to be shown on the treemap chart. These
        /// levels are not interactive and are shown without their labels. Defaults to 0 if not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hintedLevels")]
        public virtual System.Nullable<int> HintedLevels { get; set; }

        /// <summary>The data that contains the treemap cell labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual ChartData Labels { get; set; }

        /// <summary>
        /// The number of data levels to show on the treemap chart. These levels are interactive and are shown with
        /// their labels. Defaults to 2 if not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("levels")]
        public virtual System.Nullable<int> Levels { get; set; }

        /// <summary>
        /// The maximum possible data value. Cells with values greater than this will have the same color as cells with
        /// this value. If not specified, defaults to the actual maximum value from color_data, or the maximum value
        /// from size_data if color_data is not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
        public virtual System.Nullable<double> MaxValue { get; set; }

        /// <summary>
        /// The minimum possible data value. Cells with values less than this will have the same color as cells with
        /// this value. If not specified, defaults to the actual minimum value from color_data, or the minimum value
        /// from size_data if color_data is not specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
        public virtual System.Nullable<double> MinValue { get; set; }

        /// <summary>The data the contains the treemap cells' parent labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentLabels")]
        public virtual ChartData ParentLabels { get; set; }

        /// <summary>
        /// The data that determines the size of each treemap data cell. This data is expected to be numeric. The cells
        /// corresponding to non-numeric or missing data will not be rendered. If color_data is not specified, this data
        /// is used to determine data cell background colors as well.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeData")]
        public virtual ChartData SizeData { get; set; }

        /// <summary>The text format for all labels on the chart. The link field is not supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textFormat")]
        public virtual TextFormat TextFormat { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Trims the whitespace (such as spaces, tabs, or new lines) in every cell in the specified range. This request
    /// removes all whitespace from the start and end of each cell's text, and reduces any subsequence of remaining
    /// whitespace characters to a single space. If the resulting trimmed text starts with a '+' or '=' character, the
    /// text remains as a string value and isn't interpreted as a formula.
    /// </summary>
    public class TrimWhitespaceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The range whose cells to trim.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of trimming whitespace in cells.</summary>
    public class TrimWhitespaceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of cells that were trimmed of whitespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cellsChangedCount")]
        public virtual System.Nullable<int> CellsChangedCount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Unmerges cells in the given range.</summary>
    public class UnmergeCellsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The range within which all cells should be unmerged. If the range spans multiple merges, all will be
        /// unmerged. The range must not partially span any merge.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates properties of the supplied banded range.</summary>
    public class UpdateBandingRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The banded range to update with the new properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bandedRange")]
        public virtual BandedRange BandedRange { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `bandedRange` is implied
        /// and should not be specified. A single `"*"` can be used as short-hand for listing every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Updates the borders of a range. If a field is not set in the request, that means the border remains as-is. For
    /// example, with two subsequent UpdateBordersRequest: 1. range: A1:A5 `{ top: RED, bottom: WHITE }` 2. range: A1:A5
    /// `{ left: BLUE }` That would result in A1:A5 having a borders of `{ top: RED, bottom: WHITE, left: BLUE }`. If
    /// you want to clear a border, explicitly set the style to NONE.
    /// </summary>
    public class UpdateBordersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The border to put at the bottom of the range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bottom")]
        public virtual Border Bottom { get; set; }

        /// <summary>The horizontal border to put within the range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("innerHorizontal")]
        public virtual Border InnerHorizontal { get; set; }

        /// <summary>The vertical border to put within the range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("innerVertical")]
        public virtual Border InnerVertical { get; set; }

        /// <summary>The border to put at the left of the range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("left")]
        public virtual Border Left { get; set; }

        /// <summary>The range whose borders should be updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>The border to put at the right of the range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("right")]
        public virtual Border Right { get; set; }

        /// <summary>The border to put at the top of the range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("top")]
        public virtual Border Top { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates all cells in a range with new data.</summary>
    public class UpdateCellsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields of CellData that should be updated. At least one field must be specified. The root is the
        /// CellData; 'row.values.' should not be specified. A single `"*"` can be used as short-hand for listing every
        /// field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>
        /// The range to write data to. If the data in rows does not cover the entire requested range, the fields
        /// matching those set in fields will be cleared.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual GridRange Range { get; set; }

        /// <summary>The data to write.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<RowData> Rows { get; set; }

        /// <summary>
        /// The coordinate to start writing data at. Any number of rows and columns (including a different number of
        /// columns per row) may be written.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("start")]
        public virtual GridCoordinate Start { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Updates a chart's specifications. (This does not move or resize a chart. To move or resize a chart, use
    /// UpdateEmbeddedObjectPositionRequest.)
    /// </summary>
    public class UpdateChartSpecRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the chart to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chartId")]
        public virtual System.Nullable<int> ChartId { get; set; }

        /// <summary>The specification to apply to the chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual ChartSpec Spec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Updates a conditional format rule at the given index, or moves a conditional format rule to another index.
    /// </summary>
    public class UpdateConditionalFormatRuleRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The zero-based index of the rule that should be replaced or moved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("index")]
        public virtual System.Nullable<int> Index { get; set; }

        /// <summary>The zero-based new index the rule should end up at.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newIndex")]
        public virtual System.Nullable<int> NewIndex { get; set; }

        /// <summary>The rule that should replace the rule at the given index.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rule")]
        public virtual ConditionalFormatRule Rule { get; set; }

        /// <summary>The sheet of the rule to move. Required if new_index is set, unused otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sheetId")]
        public virtual System.Nullable<int> SheetId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of updating a conditional format rule.</summary>
    public class UpdateConditionalFormatRuleResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The index of the new rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newIndex")]
        public virtual System.Nullable<int> NewIndex { get; set; }

        /// <summary>
        /// The new rule that replaced the old rule (if replacing), or the rule that was moved (if moved)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newRule")]
        public virtual ConditionalFormatRule NewRule { get; set; }

        /// <summary>
        /// The old index of the rule. Not set if a rule was replaced (because it is the same as new_index).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldIndex")]
        public virtual System.Nullable<int> OldIndex { get; set; }

        /// <summary>The old (deleted) rule. Not set if a rule was moved (because it is the same as new_rule).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oldRule")]
        public virtual ConditionalFormatRule OldRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Updates a data source. After the data source is updated successfully, an execution is triggered to refresh the
    /// associated DATA_SOURCE sheet to read data from the updated data source. The request requires an additional
    /// `bigquery.readonly` OAuth scope.
    /// </summary>
    public class UpdateDataSourceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data source to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSource")]
        public virtual DataSource DataSource { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `dataSource` is implied
        /// and should not be specified. A single `"*"` can be used as short-hand for listing every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from updating data source.</summary>
    public class UpdateDataSourceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data execution status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataExecutionStatus")]
        public virtual DataExecutionStatus DataExecutionStatus { get; set; }

        /// <summary>The updated data source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSource")]
        public virtual DataSource DataSource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A request to update properties of developer metadata. Updates the properties of the developer metadata selected
    /// by the filters to the values provided in the DeveloperMetadata resource. Callers must specify the properties
    /// they wish to update in the fields parameter, as well as specify at least one DataFilter matching the metadata
    /// they wish to update.
    /// </summary>
    public class UpdateDeveloperMetadataRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The filters matching the developer metadata entries to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataFilters")]
        public virtual System.Collections.Generic.IList<DataFilter> DataFilters { get; set; }

        /// <summary>The value that all metadata matched by the data filters will be updated to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerMetadata")]
        public virtual DeveloperMetadata DeveloperMetadata { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `developerMetadata` is
        /// implied and should not be specified. A single `"*"` can be used as short-hand for listing every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response from updating developer metadata.</summary>
    public class UpdateDeveloperMetadataResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The updated developer metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerMetadata")]
        public virtual System.Collections.Generic.IList<DeveloperMetadata> DeveloperMetadata { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates the state of the specified group.</summary>
    public class UpdateDimensionGroupRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The group whose state should be updated. The range and depth of the group should specify a valid group on
        /// the sheet, and all other fields updated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionGroup")]
        public virtual DimensionGroup DimensionGroup { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `dimensionGroup` is
        /// implied and should not be specified. A single `"*"` can be used as short-hand for listing every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates properties of dimensions within the specified range.</summary>
    public class UpdateDimensionPropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The columns on a data source sheet to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataSourceSheetRange")]
        public virtual DataSourceSheetDimensionRange DataSourceSheetRange { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `properties` is implied
        /// and should not be specified. A single `"*"` can be used as short-hand for listing every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>Properties to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual DimensionProperties Properties { get; set; }

        /// <summary>The rows or columns to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual DimensionRange Range { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates an embedded object's border property.</summary>
    public class UpdateEmbeddedObjectBorderRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The border that applies to the embedded object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("border")]
        public virtual EmbeddedObjectBorder Border { get; set; }

        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `border` is implied and
        /// should not be specified. A single `"*"` can be used as short-hand for listing every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The ID of the embedded object to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual System.Nullable<int> ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Update an embedded object's position (such as a moving or resizing a chart or image).</summary>
    public class UpdateEmbeddedObjectPositionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields of OverlayPosition that should be updated when setting a new position. Used only if
        /// newPosition.overlayPosition is set, in which case at least one field must be specified. The root
        /// `newPosition.overlayPosition` is implied and should not be specified. A single `"*"` can be used as
        /// short-hand for listing every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>
        /// An explicit position to move the embedded object to. If newPosition.sheetId is set, a new sheet with that ID
        /// will be created. If newPosition.newSheet is set to true, a new sheet will be created with an ID that will be
        /// chosen for you.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newPosition")]
        public virtual EmbeddedObjectPosition NewPosition { get; set; }

        /// <summary>The ID of the object to moved.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("objectId")]
        public virtual System.Nullable<int> ObjectId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The result of updating an embedded object's position.</summary>
    public class UpdateEmbeddedObjectPositionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The new position of the embedded object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual EmbeddedObjectPosition Position { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates properties of the filter view.</summary>
    public class UpdateFilterViewRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `filter` is implied and
        /// should not be specified. A single `"*"` can be used as short-hand for listing every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The new properties of the filter view.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual FilterView Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates properties of the named range with the specified namedRangeId.</summary>
    public class UpdateNamedRangeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `namedRange` is implied
        /// and should not be specified. A single `"*"` can be used as short-hand for listing every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The named range to update with the new properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namedRange")]
        public virtual NamedRange NamedRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates an existing protected range with the specified protectedRangeId.</summary>
    public class UpdateProtectedRangeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `protectedRange` is
        /// implied and should not be specified. A single `"*"` can be used as short-hand for listing every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The protected range to update with the new properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protectedRange")]
        public virtual ProtectedRange ProtectedRange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates properties of the sheet with the specified sheetId.</summary>
    public class UpdateSheetPropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `properties` is implied
        /// and should not be specified. A single `"*"` can be used as short-hand for listing every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The properties to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual SheetProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Updates a slicer's specifications. (This does not move or resize a slicer. To move or resize a slicer use
    /// UpdateEmbeddedObjectPositionRequest.
    /// </summary>
    public class UpdateSlicerSpecRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root `SlicerSpec` is implied
        /// and should not be specified. A single "*"` can be used as short-hand for listing every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The id of the slicer to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slicerId")]
        public virtual System.Nullable<int> SlicerId { get; set; }

        /// <summary>The specification to apply to the slicer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual SlicerSpec Spec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Updates properties of a spreadsheet.</summary>
    public class UpdateSpreadsheetPropertiesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The fields that should be updated. At least one field must be specified. The root 'properties' is implied
        /// and should not be specified. A single `"*"` can be used as short-hand for listing every field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual object Fields { get; set; }

        /// <summary>The properties to update.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual SpreadsheetProperties Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response when updating a range of values by a data filter in a spreadsheet.</summary>
    public class UpdateValuesByDataFilterResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data filter that selected the range that was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataFilter")]
        public virtual DataFilter DataFilter { get; set; }

        /// <summary>The number of cells updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedCells")]
        public virtual System.Nullable<int> UpdatedCells { get; set; }

        /// <summary>The number of columns where at least one cell in the column was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedColumns")]
        public virtual System.Nullable<int> UpdatedColumns { get; set; }

        /// <summary>
        /// The values of the cells in the range matched by the dataFilter after all updates were applied. This is only
        /// included if the request's `includeValuesInResponse` field was `true`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedData")]
        public virtual ValueRange UpdatedData { get; set; }

        /// <summary>The range (in A1 notation) that updates were applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedRange")]
        public virtual string UpdatedRange { get; set; }

        /// <summary>The number of rows where at least one cell in the row was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedRows")]
        public virtual System.Nullable<int> UpdatedRows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response when updating a range of values in a spreadsheet.</summary>
    public class UpdateValuesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The spreadsheet the updates were applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spreadsheetId")]
        public virtual string SpreadsheetId { get; set; }

        /// <summary>The number of cells updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedCells")]
        public virtual System.Nullable<int> UpdatedCells { get; set; }

        /// <summary>The number of columns where at least one cell in the column was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedColumns")]
        public virtual System.Nullable<int> UpdatedColumns { get; set; }

        /// <summary>
        /// The values of the cells after updates were applied. This is only included if the request's
        /// `includeValuesInResponse` field was `true`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedData")]
        public virtual ValueRange UpdatedData { get; set; }

        /// <summary>The range (in A1 notation) that updates were applied to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedRange")]
        public virtual string UpdatedRange { get; set; }

        /// <summary>The number of rows where at least one cell in the row was updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updatedRows")]
        public virtual System.Nullable<int> UpdatedRows { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Data within a range of the spreadsheet.</summary>
    public class ValueRange : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The major dimension of the values. For output, if the spreadsheet data is: `A1=1,B1=2,A2=3,B2=4`, then
        /// requesting `range=A1:B2,majorDimension=ROWS` will return `[[1,2],[3,4]]`, whereas requesting
        /// `range=A1:B2,majorDimension=COLUMNS` will return `[[1,3],[2,4]]`. For input, with
        /// `range=A1:B2,majorDimension=ROWS` then `[[1,2],[3,4]]` will set `A1=1,B1=2,A2=3,B2=4`. With
        /// `range=A1:B2,majorDimension=COLUMNS` then `[[1,2],[3,4]]` will set `A1=1,B1=3,A2=2,B2=4`. When writing, if
        /// this field is not set, it defaults to ROWS.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("majorDimension")]
        public virtual string MajorDimension { get; set; }

        /// <summary>
        /// The range the values cover, in A1 notation. For output, this range indicates the entire requested range,
        /// even though the values will exclude trailing rows and columns. When appending values, this field represents
        /// the range to search for a table, after which values will be appended.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("range")]
        public virtual string Range { get; set; }

        /// <summary>
        /// The data that was read or to be written. This is an array of arrays, the outer array representing all the
        /// data and each inner array representing a major dimension. Each item in the inner array corresponds with one
        /// cell. For output, empty trailing rows and columns will not be included. For input, supported value types
        /// are: bool, string, and double. Null values will be skipped. To set a cell to an empty value, set the string
        /// value to an empty string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("values")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IList<object>> Values { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Styles for a waterfall chart column.</summary>
    public class WaterfallChartColumnStyle : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The color of the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("color")]
        public virtual Color Color { get; set; }

        /// <summary>The color of the column. If color is also set, this field takes precedence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("colorStyle")]
        public virtual ColorStyle ColorStyle { get; set; }

        /// <summary>The label of the column's legend.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A custom subtotal column for a waterfall chart series.</summary>
    public class WaterfallChartCustomSubtotal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// True if the data point at subtotal_index is the subtotal. If false, the subtotal will be computed and appear
        /// after the data point.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataIsSubtotal")]
        public virtual System.Nullable<bool> DataIsSubtotal { get; set; }

        /// <summary>A label for the subtotal column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("label")]
        public virtual string Label { get; set; }

        /// <summary>
        /// The 0-based index of a data point within the series. If data_is_subtotal is true, the data point at this
        /// index is the subtotal. Otherwise, the subtotal appears after the data point with this index. A series can
        /// have multiple subtotals at arbitrary indices, but subtotals do not affect the indices of the data points.
        /// For example, if a series has three data points, their indices will always be 0, 1, and 2, regardless of how
        /// many subtotals exist on the series or what data points they are associated with.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtotalIndex")]
        public virtual System.Nullable<int> SubtotalIndex { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The domain of a waterfall chart.</summary>
    public class WaterfallChartDomain : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The data of the WaterfallChartDomain.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual ChartData Data { get; set; }

        /// <summary>True to reverse the order of the domain values (horizontal axis).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reversed")]
        public virtual System.Nullable<bool> Reversed { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A single series of data for a waterfall chart.</summary>
    public class WaterfallChartSeries : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Custom subtotal columns appearing in this series. The order in which subtotals are defined is not
        /// significant. Only one subtotal may be defined for each data point.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customSubtotals")]
        public virtual System.Collections.Generic.IList<WaterfallChartCustomSubtotal> CustomSubtotals { get; set; }

        /// <summary>The data being visualized in this series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual ChartData Data { get; set; }

        /// <summary>Information about the data labels for this series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataLabel")]
        public virtual DataLabel DataLabel { get; set; }

        /// <summary>
        /// True to hide the subtotal column from the end of the series. By default, a subtotal column will appear at
        /// the end of each series. Setting this field to true will hide that subtotal column for this series.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hideTrailingSubtotal")]
        public virtual System.Nullable<bool> HideTrailingSubtotal { get; set; }

        /// <summary>Styles for all columns in this series with negative values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negativeColumnsStyle")]
        public virtual WaterfallChartColumnStyle NegativeColumnsStyle { get; set; }

        /// <summary>Styles for all columns in this series with positive values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("positiveColumnsStyle")]
        public virtual WaterfallChartColumnStyle PositiveColumnsStyle { get; set; }

        /// <summary>Styles for all subtotal columns in this series.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtotalColumnsStyle")]
        public virtual WaterfallChartColumnStyle SubtotalColumnsStyle { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A waterfall chart.</summary>
    public class WaterfallChartSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The line style for the connector lines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectorLineStyle")]
        public virtual LineStyle ConnectorLineStyle { get; set; }

        /// <summary>The domain data (horizontal axis) for the waterfall chart.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual WaterfallChartDomain Domain { get; set; }

        /// <summary>True to interpret the first value as a total.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstValueIsTotal")]
        public virtual System.Nullable<bool> FirstValueIsTotal { get; set; }

        /// <summary>True to hide connector lines between columns.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hideConnectorLines")]
        public virtual System.Nullable<bool> HideConnectorLines { get; set; }

        /// <summary>The data this waterfall chart is visualizing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("series")]
        public virtual System.Collections.Generic.IList<WaterfallChartSeries> Series { get; set; }

        /// <summary>The stacked type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stackedType")]
        public virtual string StackedType { get; set; }

        /// <summary>
        /// Controls whether to display additional data labels on stacked charts which sum the total value of all
        /// stacked values at each value along the domain axis. stacked_type must be STACKED and neither CUSTOM nor
        /// placement can be set on the total_data_label.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalDataLabel")]
        public virtual DataLabel TotalDataLabel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
