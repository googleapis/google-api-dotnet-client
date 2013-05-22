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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace Google.Apis.Http
{
    /// <summary>
    /// Http request execute interceptor to intercept a <see cref="System.Net.Http.HttpRequestMessage"/> before it has
    /// been sent. Sample usage is attaching "Authorization" header to a request.
    /// </summary>
    public interface IHttpExecuteInterceptor
    {
        /// <summary> Invoked before the request is being sent. </summary>
        void Intercept(HttpRequestMessage request);
    }
}
