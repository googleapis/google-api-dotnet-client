/*
Copyright 2010 Google Inc

Licensed under the Apache License, Version 2.0 (the ""License"");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an ""AS IS"" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using System;
using System.CodeDom.Compiler;
using System.IO;
using NAnt.Core;
using NAnt.Core.Attributes;
using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen;
using Google.Apis.Util;

namespace Google.Apis.Tools.NAntTasks
{
    /// <summary>
    /// This class provides a NAnt task that generates one service
    /// based on the passed in parameters.
    /// </summary>
    [TaskName("google-api-generate")]
    public class GoogleApiGenerate : Task
    {
        /// <summary>
        /// The Url of the discovery document e.g. 
        /// <example>
        ///     https://www.googleapis.com/discovery/v1/apis/discovery/v1/rest
        /// </example>
        /// </summary>
        [TaskAttribute("discoveryurl", Required = true)]
        [StringValidator(AllowEmpty = false)]
        public string DiscoveryUrl { get; set; }

        /// <summary>
        /// The location of the File to write to
        /// </summary>
        [TaskAttribute("outputfile", Required = true)]
        public FileInfo OutputFile { get; set; }

        /// <summary>
        /// The namespace that the generated code should use e.g.
        /// <example>
        ///     Google.Apis.Discovery
        /// </example>
        /// </summary>
        [TaskAttribute("clientnamespace", Required = true)]
        [StringValidator(AllowEmpty = false)]
        public string ClientNamespace { get; set; }

        /// <summary>
        /// The version of the Api e.g.
        /// <example>
        ///     v1
        /// </example>
        /// </summary>
        [TaskAttribute("apiversion", Required = true)]
        [StringValidator(AllowEmpty = false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// The BaseUrl the generated code will connect to at runtime by default e.g.
        /// <example>
        ///     https://www.googleapis.com
        /// </example>
        /// </summary>
        [TaskAttribute("baseurl", Required = true)]
        [StringValidator(AllowEmpty = false)]
        public string BaseUrl { get; set; }

        /// <summary>
        ///     Checks all the parameters and calls the GoogleServiceGenerator.
        /// </summary>
        protected override void ExecuteTask()
        {
            DiscoveryUrl.ThrowIfNullOrEmpty("DiscoveryUrl");
            OutputFile.ThrowIfNull("OutputFile");
            ClientNamespace.ThrowIfNullOrEmpty("ClientNamespace");
            ApiVersion.ThrowIfNullOrEmpty("ApiVersion");
            BaseUrl.ThrowIfNullOrEmpty("BaseUrl");

            Project.Log(Level.Info, "Fetching Discovery " + DiscoveryUrl);
            var fetcher = new WebDiscoveryDevice(new Uri(DiscoveryUrl));
            var discovery = new DiscoveryService(fetcher);
            var param = new FactoryParameterV1_0(BaseUrl, null);
            var service = discovery.GetService(DiscoveryVersion.Version_1_0, param);
            var generator = new GoogleServiceGenerator(service, ClientNamespace);
            var provider = CodeDomProvider.CreateProvider("CSharp");
            Project.Log(Level.Info, "Generating To File " + OutputFile.FullName);
            using (StreamWriter sw = new StreamWriter(OutputFile.FullName, false))
            {
                IndentedTextWriter tw = new IndentedTextWriter(sw, "  ");
                provider.GenerateCodeFromCompileUnit(generator.GenerateCode(), tw, new CodeGeneratorOptions());
                tw.Close();
            }
        }
    }
}