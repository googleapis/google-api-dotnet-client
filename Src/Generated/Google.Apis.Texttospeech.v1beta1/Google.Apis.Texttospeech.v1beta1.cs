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

namespace Google.Apis.Texttospeech.v1beta1
{
    /// <summary>The Texttospeech Service.</summary>
    public class TexttospeechService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public TexttospeechService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public TexttospeechService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Text = new TextResource(this);
            Voices = new VoicesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "texttospeech";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://texttospeech.googleapis.com/";
        #else
            "https://texttospeech.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://texttospeech.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Text-to-Speech API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Text-to-Speech API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Text resource.</summary>
        public virtual TextResource Text { get; }

        /// <summary>Gets the Voices resource.</summary>
        public virtual VoicesResource Voices { get; }
    }

    /// <summary>A base abstract class for Texttospeech requests.</summary>
    public abstract class TexttospeechBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new TexttospeechBaseServiceRequest instance.</summary>
        protected TexttospeechBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Texttospeech parameter list.</summary>
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

    /// <summary>The "text" collection of methods.</summary>
    public class TextResource
    {
        private const string Resource = "text";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TextResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Synthesizes speech synchronously: receive results after all text input has been processed.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual SynthesizeRequest Synthesize(Google.Apis.Texttospeech.v1beta1.Data.SynthesizeSpeechRequest body)
        {
            return new SynthesizeRequest(service, body);
        }

        /// <summary>
        /// Synthesizes speech synchronously: receive results after all text input has been processed.
        /// </summary>
        public class SynthesizeRequest : TexttospeechBaseServiceRequest<Google.Apis.Texttospeech.v1beta1.Data.SynthesizeSpeechResponse>
        {
            /// <summary>Constructs a new Synthesize request.</summary>
            public SynthesizeRequest(Google.Apis.Services.IClientService service, Google.Apis.Texttospeech.v1beta1.Data.SynthesizeSpeechRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Texttospeech.v1beta1.Data.SynthesizeSpeechRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "synthesize";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/text:synthesize";

            /// <summary>Initializes Synthesize parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }

    /// <summary>The "voices" collection of methods.</summary>
    public class VoicesResource
    {
        private const string Resource = "voices";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public VoicesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Returns a list of Voice supported for synthesis.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Returns a list of Voice supported for synthesis.</summary>
        public class ListRequest : TexttospeechBaseServiceRequest<Google.Apis.Texttospeech.v1beta1.Data.ListVoicesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Optional. Recommended. [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag. If not
            /// specified, the API will return all supported voices. If specified, the ListVoices call will only return
            /// voices that can be used to synthesize this language_code. E.g. when specifying "en-NZ", you will get
            /// supported "en-NZ" voices; when specifying "no", you will get supported "no-\*" (Norwegian) and "nb-\*"
            /// (Norwegian Bokmal) voices; specifying "zh" will also get supported "cmn-\*" voices; specifying "zh-hk"
            /// will also get supported "yue-hk" voices.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LanguageCode { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta1/voices";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("languageCode", new Google.Apis.Discovery.Parameter
                {
                    Name = "languageCode",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Texttospeech.v1beta1.Data
{
    /// <summary>Description of audio data to be synthesized.</summary>
    public class AudioConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The format of the audio byte stream.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioEncoding")]
        public virtual string AudioEncoding { get; set; }

        /// <summary>
        /// Optional. Input only. An identifier which selects 'audio effects' profiles that are applied on (post
        /// synthesized) text to speech. Effects are applied on top of each other in the order they are given. See
        /// [audio profiles](https://cloud.google.com/text-to-speech/docs/audio-profiles) for current supported profile
        /// ids.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectsProfileId")]
        public virtual System.Collections.Generic.IList<string> EffectsProfileId { get; set; }

        /// <summary>
        /// Optional. Input only. Speaking pitch, in the range [-20.0, 20.0]. 20 means increase 20 semitones from the
        /// original pitch. -20 means decrease 20 semitones from the original pitch.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pitch")]
        public virtual System.Nullable<double> Pitch { get; set; }

        /// <summary>
        /// Optional. The synthesis sample rate (in hertz) for this audio. When this is specified in
        /// SynthesizeSpeechRequest, if this is different from the voice's natural sample rate, then the synthesizer
        /// will honor this request by converting to the desired sample rate (which might result in worse audio
        /// quality), unless the specified sample rate is not supported for the encoding chosen, in which case it will
        /// fail the request and return google.rpc.Code.INVALID_ARGUMENT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleRateHertz")]
        public virtual System.Nullable<int> SampleRateHertz { get; set; }

        /// <summary>
        /// Optional. Input only. Speaking rate/speed, in the range [0.25, 4.0]. 1.0 is the normal native speed
        /// supported by the specific voice. 2.0 is twice as fast, and 0.5 is half as fast. If unset(0.0), defaults to
        /// the native 1.0 speed. Any other values &amp;lt; 0.25 or &amp;gt; 4.0 will return an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speakingRate")]
        public virtual System.Nullable<double> SpeakingRate { get; set; }

        /// <summary>
        /// Optional. Input only. Volume gain (in dB) of the normal native volume supported by the specific voice, in
        /// the range [-96.0, 16.0]. If unset, or set to a value of 0.0 (dB), will play at normal native signal
        /// amplitude. A value of -6.0 (dB) will play at approximately half the amplitude of the normal native signal
        /// amplitude. A value of +6.0 (dB) will play at approximately twice the amplitude of the normal native signal
        /// amplitude. Strongly recommend not to exceed +10 (dB) as there's usually no effective increase in loudness
        /// for any value greater than that.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeGainDb")]
        public virtual System.Nullable<double> VolumeGainDb { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The message returned to the client by the `ListVoices` method.</summary>
    public class ListVoicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of voices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voices")]
        public virtual System.Collections.Generic.IList<Voice> Voices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains text input to be synthesized. Either `text` or `ssml` must be supplied. Supplying both or neither
    /// returns google.rpc.Code.INVALID_ARGUMENT. The input size is limited to 5000 characters.
    /// </summary>
    public class SynthesisInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The SSML document to be synthesized. The SSML document must be valid and well-formed. Otherwise the RPC will
        /// fail and return google.rpc.Code.INVALID_ARGUMENT. For more information, see
        /// [SSML](https://cloud.google.com/text-to-speech/docs/ssml).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssml")]
        public virtual string Ssml { get; set; }

        /// <summary>The raw text to be synthesized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The top-level message sent by the client for the `SynthesizeSpeech` method.</summary>
    public class SynthesizeSpeechRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The configuration of the synthesized audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioConfig")]
        public virtual AudioConfig AudioConfig { get; set; }

        /// <summary>Whether and what timepoints are returned in the response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableTimePointing")]
        public virtual System.Collections.Generic.IList<string> EnableTimePointing { get; set; }

        /// <summary>Required. The Synthesizer requires either plain text or SSML as input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("input")]
        public virtual SynthesisInput Input { get; set; }

        /// <summary>Required. The desired voice of the synthesized audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voice")]
        public virtual VoiceSelectionParams Voice { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The message returned to the client by the `SynthesizeSpeech` method.</summary>
    public class SynthesizeSpeechResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The audio metadata of `audio_content`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioConfig")]
        public virtual AudioConfig AudioConfig { get; set; }

        /// <summary>
        /// The audio data bytes encoded as specified in the request, including the header for encodings that are
        /// wrapped in containers (e.g. MP3, OGG_OPUS). For LINEAR16 audio, we include the WAV header. Note: as with all
        /// bytes fields, protobuffers use a pure binary representation, whereas JSON representations use base64.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioContent")]
        public virtual string AudioContent { get; set; }

        /// <summary>
        /// A link between a position in the original request input and a corresponding time in the output audio. It's
        /// only supported via `` of SSML input.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timepoints")]
        public virtual System.Collections.Generic.IList<Timepoint> Timepoints { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// This contains a mapping between a certain point in the input text and a corresponding time in the output audio.
    /// </summary>
    public class Timepoint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Timepoint name as received from the client within `` tag.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("markName")]
        public virtual string MarkName { get; set; }

        /// <summary>Time offset in seconds from the start of the synthesized audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeSeconds")]
        public virtual System.Nullable<double> TimeSeconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Description of a voice supported by the TTS service.</summary>
    public class Voice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The languages that this voice supports, expressed as [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt)
        /// language tags (e.g. "en-US", "es-419", "cmn-tw").
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCodes")]
        public virtual System.Collections.Generic.IList<string> LanguageCodes { get; set; }

        /// <summary>The name of this voice. Each distinct voice has a unique name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The natural sample rate (in hertz) for this voice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("naturalSampleRateHertz")]
        public virtual System.Nullable<int> NaturalSampleRateHertz { get; set; }

        /// <summary>The gender of this voice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssmlGender")]
        public virtual string SsmlGender { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Description of which voice to use for a synthesis request.</summary>
    public class VoiceSelectionParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The language (and potentially also the region) of the voice expressed as a
        /// [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag, e.g. "en-US". This should not include a
        /// script tag (e.g. use "cmn-cn" rather than "cmn-Hant-cn"), because the script will be inferred from the input
        /// provided in the SynthesisInput. The TTS service will use this parameter to help choose an appropriate voice.
        /// Note that the TTS service may choose a voice with a slightly different language code than the one selected;
        /// it may substitute a different region (e.g. using en-US rather than en-CA if there isn't a Canadian voice
        /// available), or even a different language, e.g. using "nb" (Norwegian Bokmal) instead of "no" (Norwegian)".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; }

        /// <summary>
        /// The name of the voice. If not set, the service will choose a voice based on the other parameters such as
        /// language_code and gender.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The preferred gender of the voice. If not set, the service will choose a voice based on the other parameters
        /// such as language_code and name. Note that this is only a preference, not requirement; if a voice of the
        /// appropriate gender is not available, the synthesizer should substitute a voice with a different gender
        /// rather than failing the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssmlGender")]
        public virtual string SsmlGender { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
