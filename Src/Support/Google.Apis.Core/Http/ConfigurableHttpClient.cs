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

using System.Net.Http;

namespace Google.Apis.Http
{
    /// <summary>
    /// Configurable HTTP client inherits from <see cref="System.Net.Http.HttpClient"/> and contains a reference to 
    /// <see cref="Google.Apis.Http.ConfigurableMessageHandler"/>.
    /// </summary>
    public class ConfigurableHttpClient : HttpClient
    {
        /// <summary>Gets the configurable message handler.</summary>
        public ConfigurableMessageHandler MessageHandler { get; private set; }

        /// <summary>Constructs a new HTTP client.</summary>
        public ConfigurableHttpClient(ConfigurableMessageHandler handler)
            : base(handler)
        {
            MessageHandler = handler;
            DefaultRequestHeaders.ExpectContinue = false;
        }
    }
}
