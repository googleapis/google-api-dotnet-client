/*
Copyright 2013 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System.Collections.Generic;

namespace Google.Apis.Http
{
    /// <summary>Arguments for creating a HTTP client.</summary>
    public class CreateHttpClientArgs
    {
        /// <summary>Gets or sets whether GZip is enabled.</summary>
        public bool GZipEnabled { get; set; }

        /// <summary>Gets or sets the application name that is sent in the User-Agent header.</summary>
        public string ApplicationName { get; set; }

        /// <summary>Gets a list of initializers to initialize the HTTP client instance.</summary>
        public IList<IConfigurableHttpClientInitializer> Initializers { get; private set; }

        /// <summary>Constructs a new argument instance.</summary>
        public CreateHttpClientArgs()
        {
            Initializers = new List<IConfigurableHttpClientInitializer>();
        }
    }

    /// <summary>
    /// HTTP client factory creates configurable HTTP clients. A unique HTTP client should be created for each service.
    /// </summary>
    public interface IHttpClientFactory
    {
        /// <summary>Creates a new configurable HTTP client.</summary>
        ConfigurableHttpClient CreateHttpClient(CreateHttpClientArgs args);
    }
}
