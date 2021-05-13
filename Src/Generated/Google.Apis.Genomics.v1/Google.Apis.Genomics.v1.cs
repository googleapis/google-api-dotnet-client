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

namespace Google.Apis.Genomics.v1
{
    /// <summary>The Genomics Service.</summary>
    public class GenomicsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public GenomicsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public GenomicsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "genomics";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://genomics.googleapis.com/";
        #else
            "https://genomics.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://genomics.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif
    }

    /// <summary>A base abstract class for Genomics requests.</summary>
    public abstract class GenomicsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new GenomicsBaseServiceRequest instance.</summary>
        protected GenomicsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Genomics parameter list.</summary>
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
}
namespace Google.Apis.Genomics.v1.Data
{
    /// <summary>Carries information about an accelerator that can be attached to a VM.</summary>
    public class Accelerator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How many accelerators of this type to attach.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>
        /// The accelerator type string (for example, "nvidia-tesla-k80"). Only NVIDIA GPU accelerators are currently
        /// supported. If an NVIDIA GPU is attached, the required runtime libraries will be made available to all
        /// containers under `/usr/local/nvidia`. The driver version to install must be specified using the NVIDIA
        /// driver version parameter on the virtual machine specification. Note that attaching a GPU increases the
        /// worker VM startup time by a few minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a single action that runs a Docker container.</summary>
    public class Action : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If specified, overrides the `CMD` specified in the container. If the container also has an `ENTRYPOINT` the
        /// values are used as entrypoint arguments. Otherwise, they are used as a command and arguments to run inside
        /// the container.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("commands")]
        public virtual System.Collections.Generic.IList<string> Commands { get; set; }

        /// <summary>
        /// If the specified image is hosted on a private registry other than Google Container Registry, the credentials
        /// required to pull the image must be specified here as an encrypted secret. The secret must decrypt to a
        /// JSON-encoded dictionary containing both `username` and `password` keys.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("credentials")]
        public virtual Secret Credentials { get; set; }

        /// <summary>
        /// The encrypted environment to pass into the container. This environment is merged with values specified in
        /// the google.genomics.v2alpha1.Pipeline message, overwriting any duplicate values. The secret must decrypt to
        /// a JSON-encoded dictionary where key-value pairs serve as environment variable names and their values. The
        /// decoded environment variables can overwrite the values specified by the `environment` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedEnvironment")]
        public virtual Secret EncryptedEnvironment { get; set; }

        /// <summary>If specified, overrides the `ENTRYPOINT` specified in the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entrypoint")]
        public virtual string Entrypoint { get; set; }

        /// <summary>
        /// The environment to pass into the container. This environment is merged with values specified in the
        /// google.genomics.v2alpha1.Pipeline message, overwriting any duplicate values. In addition to the values
        /// passed here, a few other values are automatically injected into the environment. These cannot be hidden or
        /// overwritten. `GOOGLE_PIPELINE_FAILED` will be set to "1" if the pipeline failed because an action has exited
        /// with a non-zero status (and did not have the `IGNORE_EXIT_STATUS` flag set). This can be used to determine
        /// if additional debug or logging actions should execute. `GOOGLE_LAST_EXIT_STATUS` will be set to the exit
        /// status of the last non-background action that executed. This can be used by workflow engine authors to
        /// determine whether an individual action has succeeded or failed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual System.Collections.Generic.IDictionary<string, string> Environment { get; set; }

        /// <summary>The set of flags to apply to this action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flags")]
        public virtual System.Collections.Generic.IList<string> Flags { get; set; }

        /// <summary>
        /// Required. The URI to pull the container image from. Note that all images referenced by actions in the
        /// pipeline are pulled before the first action runs. If multiple actions reference the same image, it is only
        /// pulled once, ensuring that the same image is used for all actions in a single pipeline. The image URI can be
        /// either a complete host and image specification (e.g., quay.io/biocontainers/samtools), a library and image
        /// name (e.g., google/cloud-sdk) or a bare image name ('bash') to pull from the default library. No schema is
        /// required in any of these cases. If the specified image is not public, the service account specified for the
        /// Virtual Machine must have access to pull the images from GCR, or appropriate credentials must be specified
        /// in the google.genomics.v2alpha1.Action.credentials field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>
        /// Labels to associate with the action. This field is provided to assist workflow engine authors in identifying
        /// actions (for example, to indicate what sort of action they perform, such as localization or debugging). They
        /// are returned in the operation metadata, but are otherwise ignored.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// A list of mounts to make available to the action. In addition to the values specified here, every action has
        /// a special virtual disk mounted under `/google` that contains log files and other operational components. -
        /// /google/logs All logs written during the pipeline execution. - /google/logs/output The combined standard
        /// output and standard error of all actions run as part of the pipeline execution. -
        /// /google/logs/action/*/stdout The complete contents of each individual action's standard output. -
        /// /google/logs/action/*/stderr The complete contents of each individual action's standard error output.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mounts")]
        public virtual System.Collections.Generic.IList<Mount> Mounts { get; set; }

        /// <summary>
        /// An optional name for the container. The container hostname will be set to this name, making it useful for
        /// inter-container communication. The name must contain only upper and lowercase alphanumeric characters and
        /// hyphens and cannot start with a hyphen.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// An optional identifier for a PID namespace to run the action inside. Multiple actions should use the same
        /// string to share a namespace. If unspecified, a separate isolated namespace is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pidNamespace")]
        public virtual string PidNamespace { get; set; }

        /// <summary>
        /// A map of containers to host port mappings for this container. If the container already specifies exposed
        /// ports, use the `PUBLISH_EXPOSED_PORTS` flag instead. The host port number must be less than 65536. If it is
        /// zero, an unused random port is assigned. To determine the resulting port number, consult the
        /// `ContainerStartedEvent` in the operation metadata.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("portMappings")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<int>> PortMappings { get; set; }

        /// <summary>
        /// The maximum amount of time to give the action to complete. If the action fails to complete before the
        /// timeout, it will be terminated and the exit status will be non-zero. The pipeline will continue or terminate
        /// based on the rules defined by the `ALWAYS_RUN` and `IGNORE_EXIT_STATUS` flags.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event generated when a container is forcibly terminated by the worker. Currently, this only occurs when the
    /// container outlives the timeout specified by the user.
    /// </summary>
    public class ContainerKilledEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The numeric ID of the action that started the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual System.Nullable<int> ActionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated when a container starts.</summary>
    public class ContainerStartedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The numeric ID of the action that started this container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual System.Nullable<int> ActionId { get; set; }

        /// <summary>
        /// The public IP address that can be used to connect to the container. This field is only populated when at
        /// least one port mapping is present. If the instance was created with a private address, this field will be
        /// empty even if port mappings exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>
        /// The container-to-host port mappings installed for this container. This set will contain any ports exposed
        /// using the `PUBLISH_EXPOSED_PORTS` flag as well as any specified in the `Action` definition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("portMappings")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<int>> PortMappings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated when a container exits.</summary>
    public class ContainerStoppedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The numeric ID of the action that started this container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual System.Nullable<int> ActionId { get; set; }

        /// <summary>The exit status of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitStatus")]
        public virtual System.Nullable<int> ExitStatus { get; set; }

        /// <summary>
        /// The tail end of any content written to standard error by the container. If the content emits large amounts
        /// of debugging noise or contains sensitive information, you can prevent the content from being printed by
        /// setting the `DISABLE_STANDARD_ERROR_CAPTURE` flag. Note that only a small amount of the end of the stream is
        /// captured here. The entire stream is stored in the `/google/logs` directory mounted into each action, and can
        /// be copied off the machine as described elsewhere.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stderr")]
        public virtual string Stderr { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event generated whenever a resource limitation or transient error delays execution of a pipeline that was
    /// otherwise ready to run.
    /// </summary>
    public class DelayedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A textual description of the cause of the delay. The string can change without notice because it is often
        /// generated by another service (such as Compute Engine).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cause")]
        public virtual string Cause { get; set; }

        /// <summary>
        /// If the delay was caused by a resource shortage, this field lists the Compute Engine metrics that are
        /// preventing this operation from running (for example, `CPUS` or `INSTANCES`). If the particular metric is not
        /// known, a single `UNKNOWN` metric will be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Carries information about a disk that can be attached to a VM. See
    /// https://cloud.google.com/compute/docs/disks/performance for more information about disk type, size, and
    /// performance considerations. Specify either `Volume` or `Disk`, but not both.
    /// </summary>
    public class Disk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A user-supplied name for the disk. Used when mounting the disk into actions. The name must contain only
        /// upper and lowercase alphanumeric characters and hyphens and cannot start with a hyphen.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The size, in GB, of the disk to attach. If the size is not specified, a default is chosen to ensure
        /// reasonable I/O performance. If the disk type is specified as `local-ssd`, multiple local drives are
        /// automatically combined to provide the requested size. Note, however, that each physical SSD is 375GB in
        /// size, and no more than 8 drives can be attached to a single instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<int> SizeGb { get; set; }

        /// <summary>An optional image to put on the disk before attaching it to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceImage")]
        public virtual string SourceImage { get; set; }

        /// <summary>The Compute Engine disk type. If unspecified, `pd-standard` is used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Carries information about events that occur during pipeline execution.</summary>
    public class Event : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A human-readable description of the event. Note that these strings can change at any time without notice.
        /// Any application logic must use the information in the `details` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Machine-readable details about the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IDictionary<string, object> Details { get; set; }

        /// <summary>The time at which the event occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual object Timestamp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for an existing disk to be attached to the VM.</summary>
    public class ExistingDisk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If `disk` contains slashes, the Cloud Life Sciences API assumes that it is a complete URL for the disk. If
        /// `disk` does not contain slashes, the Cloud Life Sciences API assumes that the disk is a zonal disk and a URL
        /// will be generated of the form `zones//disks/`, where `` is the zone in which the instance is allocated. The
        /// disk must be ext4 formatted. If all `Mount` references to this disk have the `read_only` flag set to true,
        /// the disk will be attached in `read-only` mode and can be shared with other instances. Otherwise, the disk
        /// will be available for writing but cannot be shared.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disk")]
        public virtual string Disk { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event generated when the execution of a pipeline has failed. Note that other events can continue to occur
    /// after this event.
    /// </summary>
    public class FailedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human-readable description of the cause of the failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cause")]
        public virtual string Cause { get; set; }

        /// <summary>The Google standard error code that best describes this failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Carries information about the pipeline execution that is returned in the long running operation's metadata
    /// field.
    /// </summary>
    public class Metadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time at which the operation was created by the API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The time at which execution was completed and resources were cleaned up.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The list of events that have happened so far during the execution of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<Event> Events { get; set; }

        /// <summary>The user-defined labels associated with this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The pipeline this operation represents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pipeline")]
        public virtual Pipeline Pipeline { get; set; }

        /// <summary>The first time at which resources were allocated to execute the pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Carries information about a particular disk mount inside a container.</summary>
    public class Mount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the disk to mount, as specified in the resources section.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disk")]
        public virtual string Disk { get; set; }

        /// <summary>The path to mount the disk inside the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>If true, the disk is mounted read-only inside the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readOnly")]
        public virtual System.Nullable<bool> ReadOnly__ { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration for an `NFSMount` to be attached to the VM.</summary>
    public class NFSMount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A target NFS mount. The target must be specified as `address:/mount".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>VM networking options.</summary>
    public class Network : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The network name to attach the VM's network interface to. The value will be prefixed with `global/networks/`
        /// unless it contains a `/`, in which case it is assumed to be a fully specified network resource URL. If
        /// unspecified, the global default network is used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// If the specified network is configured for custom subnet creation, the name of the subnetwork to attach the
        /// instance to must be specified here. The value is prefixed with `regions/*/subnetworks/` unless it contains a
        /// `/`, in which case it is assumed to be a fully specified subnetwork resource URL. If the `*` character
        /// appears in the value, it is replaced with the region that the virtual machine has been allocated in.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subnetwork")]
        public virtual string Subnetwork { get; set; }

        /// <summary>
        /// If set to true, do not attach a public IP address to the VM. Note that without a public IP address,
        /// additional configuration is required to allow the VM to access Google services. See
        /// https://cloud.google.com/vpc/docs/configure-private-google-access for more information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("usePrivateAddress")]
        public virtual System.Nullable<bool> UsePrivateAddress { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Configuration for a persistent disk to be attached to the VM. See
    /// https://cloud.google.com/compute/docs/disks/performance for more information about disk type, size, and
    /// performance considerations.
    /// </summary>
    public class PersistentDisk : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The size, in GB, of the disk to attach. If the size is not specified, a default is chosen to ensure
        /// reasonable I/O performance. If the disk type is specified as `local-ssd`, multiple local drives are
        /// automatically combined to provide the requested size. Note, however, that each physical SSD is 375GB in
        /// size, and no more than 8 drives can be attached to a single instance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sizeGb")]
        public virtual System.Nullable<int> SizeGb { get; set; }

        /// <summary>An image to put on the disk before attaching it to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceImage")]
        public virtual string SourceImage { get; set; }

        /// <summary>The Compute Engine disk type. If unspecified, `pd-standard` is used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies a series of actions to execute, expressed as Docker containers.</summary>
    public class Pipeline : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of actions to execute, in the order they are specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actions")]
        public virtual System.Collections.Generic.IList<Action> Actions { get; set; }

        /// <summary>
        /// The encrypted environment to pass into every action. Each action can also specify its own encrypted
        /// environment. The secret must decrypt to a JSON-encoded dictionary where key-value pairs serve as environment
        /// variable names and their values. The decoded environment variables can overwrite the values specified by the
        /// `environment` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptedEnvironment")]
        public virtual Secret EncryptedEnvironment { get; set; }

        /// <summary>
        /// The environment to pass into every action. Each action can also specify additional environment variables but
        /// cannot delete an entry from this map (though they can overwrite it with a different value).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual System.Collections.Generic.IDictionary<string, string> Environment { get; set; }

        /// <summary>The resources required for execution.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual Resources Resources { get; set; }

        /// <summary>
        /// The maximum amount of time to give the pipeline to complete. This includes the time spent waiting for a
        /// worker to be allocated. If the pipeline fails to complete before the timeout, it will be cancelled and the
        /// error code will be set to DEADLINE_EXCEEDED. If unspecified, it will default to 7 days.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated when the worker starts pulling an image.</summary>
    public class PullStartedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI of the image that was pulled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated when the worker stops pulling an image.</summary>
    public class PullStoppedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI of the image that was pulled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The system resources for the pipeline run. At least one zone or region must be specified or the pipeline run
    /// will fail.
    /// </summary>
    public class Resources : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The project ID to allocate resources in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>The list of regions allowed for VM allocation. If set, the `zones` field must not be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual System.Collections.Generic.IList<string> Regions { get; set; }

        /// <summary>The virtual machine specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("virtualMachine")]
        public virtual VirtualMachine VirtualMachine { get; set; }

        /// <summary>The list of zones allowed for VM allocation. If set, the `regions` field must not be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zones")]
        public virtual System.Collections.Generic.IList<string> Zones { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to the RunPipeline method, returned in the operation's result field on success.</summary>
    public class RunPipelineResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Holds encrypted information that is only decrypted and stored in RAM by the worker VM when running the pipeline.
    /// </summary>
    public class Secret : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The value of the cipherText response from the `encrypt` method. This field is intentionally unaudited.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cipherText")]
        public virtual string CipherText { get; set; }

        /// <summary>
        /// The name of the Cloud KMS key that will be used to decrypt the secret value. The VM service account must
        /// have the required permissions and authentication scopes to invoke the `decrypt` method on the specified key.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyName")]
        public virtual string KeyName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Carries information about a Google Cloud service account.</summary>
    public class ServiceAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Email address of the service account. If not specified, the default Compute Engine service account for the
        /// project will be used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>
        /// List of scopes to be enabled for this service account on the VM, in addition to the cloud-platform API scope
        /// that will be added by default.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event generated when the execution of a container results in a non-zero exit status that was not otherwise
    /// ignored. Execution will continue, but only actions that are flagged as `ALWAYS_RUN` will be executed. Other
    /// actions will be skipped.
    /// </summary>
    public class UnexpectedExitStatusEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The numeric ID of the action that started the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual System.Nullable<int> ActionId { get; set; }

        /// <summary>The exit status of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitStatus")]
        public virtual System.Nullable<int> ExitStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Carries information about a Compute Engine VM resource.</summary>
    public class VirtualMachine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of accelerators to attach to the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accelerators")]
        public virtual System.Collections.Generic.IList<Accelerator> Accelerators { get; set; }

        /// <summary>
        /// The size of the boot disk, in GB. The boot disk must be large enough to accommodate all of the Docker images
        /// from each action in the pipeline at the same time. If not specified, a small but reasonable default value is
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootDiskSizeGb")]
        public virtual System.Nullable<int> BootDiskSizeGb { get; set; }

        /// <summary>
        /// The host operating system image to use. Currently, only Container-Optimized OS images can be used. The
        /// default value is `projects/cos-cloud/global/images/family/cos-stable`, which selects the latest stable
        /// release of Container-Optimized OS. This option is provided to allow testing against the beta release of the
        /// operating system to ensure that the new version does not interact negatively with production pipelines. To
        /// test a pipeline against the beta release of Container-Optimized OS, use the value
        /// `projects/cos-cloud/global/images/family/cos-beta`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootImage")]
        public virtual string BootImage { get; set; }

        /// <summary>
        /// The CPU platform to request. An instance based on a newer platform can be allocated, but never one with
        /// fewer capabilities. The value of this parameter must be a valid Compute Engine CPU platform name (such as
        /// "Intel Skylake"). This parameter is only useful for carefully optimized work loads where the CPU platform
        /// has a significant impact. For more information about the effect of this parameter, see
        /// https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuPlatform")]
        public virtual string CpuPlatform { get; set; }

        /// <summary>
        /// The list of disks to create and attach to the VM. Specify either the `volumes[]` field or the `disks[]`
        /// field, but not both.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disks")]
        public virtual System.Collections.Generic.IList<Disk> Disks { get; set; }

        /// <summary>
        /// The Compute Engine Disk Images to use as a Docker cache. The disks will be mounted into the Docker folder in
        /// a way that the images present in the cache will not need to be pulled. The digests of the cached images must
        /// match those of the tags used or the latest version will still be pulled. The root directory of the ext4
        /// image must contain `image` and `overlay2` directories copied from the Docker directory of a VM where the
        /// desired Docker images have already been pulled. Any images pulled that are not cached will be stored on the
        /// first cache disk instead of the boot disk. Only a single image is supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerCacheImages")]
        public virtual System.Collections.Generic.IList<string> DockerCacheImages { get; set; }

        /// <summary>Whether Stackdriver monitoring should be enabled on the VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableStackdriverMonitoring")]
        public virtual System.Nullable<bool> EnableStackdriverMonitoring { get; set; }

        /// <summary>
        /// Optional set of labels to apply to the VM and any attached disk resources. These labels must adhere to the
        /// [name and value restrictions](https://cloud.google.com/compute/docs/labeling-resources) on VM labels imposed
        /// by Compute Engine. Labels keys with the prefix 'google-' are reserved for use by Google. Labels applied at
        /// creation time to the VM. Applied on a best-effort basis to attached disk resources shortly after VM
        /// creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Required. The machine type of the virtual machine to create. Must be the short name of a standard machine
        /// type (such as "n1-standard-1") or a custom machine type (such as "custom-1-4096", where "1" indicates the
        /// number of vCPUs and "4096" indicates the memory in MB). See [Creating an instance with a custom machine
        /// type](https://cloud.google.com/compute/docs/instances/creating-instance-with-custom-machine-type#create) for
        /// more specifications on creating a custom machine type.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>The VM network configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("network")]
        public virtual Network Network { get; set; }

        /// <summary>
        /// The NVIDIA driver version to use when attaching an NVIDIA GPU accelerator. The version specified here must
        /// be compatible with the GPU libraries contained in the container being executed, and must be one of the
        /// drivers hosted in the `nvidia-drivers-us-public` bucket on Google Cloud Storage.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nvidiaDriverVersion")]
        public virtual string NvidiaDriverVersion { get; set; }

        /// <summary>If true, allocate a preemptible VM.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preemptible")]
        public virtual System.Nullable<bool> Preemptible { get; set; }

        /// <summary>
        /// The service account to install on the VM. This account does not need any permissions other than those
        /// required by the pipeline.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual ServiceAccount ServiceAccount { get; set; }

        /// <summary>
        /// The list of disks and other storage to create or attach to the VM. Specify either the `volumes[]` field or
        /// the `disks[]` field, but not both.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumes")]
        public virtual System.Collections.Generic.IList<Volume> Volumes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Carries information about storage that can be attached to a VM. Specify either `Volume` or `Disk`, but not both.
    /// </summary>
    public class Volume : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Configuration for a existing disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("existingDisk")]
        public virtual ExistingDisk ExistingDisk { get; set; }

        /// <summary>Configuration for an NFS mount.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nfsMount")]
        public virtual NFSMount NfsMount { get; set; }

        /// <summary>Configuration for a persistent disk.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("persistentDisk")]
        public virtual PersistentDisk PersistentDisk { get; set; }

        /// <summary>
        /// A user-supplied name for the volume. Used when mounting the volume into `Actions`. The name must contain
        /// only upper and lowercase alphanumeric characters and hyphens and cannot start with a hyphen.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volume")]
        public virtual string VolumeValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated after a worker VM has been assigned to run the pipeline.</summary>
    public class WorkerAssignedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The worker's instance name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>The machine type that was assigned for the worker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>The zone the worker is running in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event generated when the worker VM that was assigned to the pipeline has been released (deleted).
    /// </summary>
    public class WorkerReleasedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The worker's instance name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>The zone the worker was running in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
