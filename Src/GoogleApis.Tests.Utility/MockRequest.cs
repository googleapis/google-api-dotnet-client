/*
Copyright 2010 Google Inc

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
using System.IO;
using System.Threading;
using Google.Apis.Requests;
using Google.Apis.Authentication;

namespace Google.Apis.Testing
{
    /// <summary>
    /// Mock request for testing purposes.
    /// </summary>
    public class MockRequest : IRequest
    {
        public MockRequest()
        {
            HasExecuted = false;
        }

        public bool SuspendAsyncRequest = false;

        public string RpcName { get; set; }
        public ReturnType ReturnType { get; set; }
        public ParameterCollection Parameters { get; set; }
        public string Body { get; set; }
        public IAuthenticator Authenticator { get; set; }
        public bool HasExecuted { get; set; }
        public Stream StreamToReturn { get; set; }
        public string DeveloperKey { get; set; }
        public string ETag { get; set; }
        public ETagAction ETagAction { get; set; }
        public string UserIp { get; set; }
        public string Fields { get; set; }

        #region IRequest Members

        public IRequest On(string rpcName)
        {
            RpcName = rpcName;
            return this;
        }


        public IRequest Returning(ReturnType returnType)
        {
            ReturnType = returnType;
            return this;
        }

        public IRequest WithParameters(IDictionary<string, object> parameters)
        {
            Parameters = ParameterCollection.FromDictionary(parameters);
            return this;
        }

        public IRequest WithParameters(IEnumerable<KeyValuePair<string, string>> parameters)
        {
            Parameters = new ParameterCollection(parameters);
            return this;
        }

        public IRequest WithParameters(string parameters)
        {
            Parameters = ParameterCollection.FromQueryString(parameters);
            return this;
        }

        public IRequest WithFields(string mask)
        {
            Fields = mask;
            return this;
        }

        public IRequest WithUserIp(string userIp)
        {
            UserIp = userIp;
            return this;
        }

        public IRequest WithBody(string body)
        {
            Body = body;
            return this;
        }
        
        public IRequest WithAuthentication(IAuthenticator authenticator)
        {
            Authenticator = authenticator;
            return this;
        }

        public IRequest WithKey(string key)
        {
            DeveloperKey = key;
            return this;
        }

        public IRequest WithETag(string etag)
        {
            ETag = etag;
            return this;
        }

        public IRequest WithETagAction(ETagAction action)
        {
            ETagAction = action;
            return this;
        }

        private class MockAsyncRequestResult : IAsyncRequestResult
        {
            private readonly IResponse response;
            
            public MockAsyncRequestResult(IResponse response)
            {
                this.response = response;
            }
            
            public IResponse GetResponse()
            {
                return response;
            }
        }

        public virtual void ExecuteRequestAsync(Action<IAsyncRequestResult> responseHandler)
        {
            ThreadPool.QueueUserWorkItem((o) =>
                                             {
                                                 while (SuspendAsyncRequest)
                                                 {
                                                     Thread.Sleep(10);
                                                 }

                                                 responseHandler(new MockAsyncRequestResult(ExecuteRequest()));
                                             });
        }

        public IResponse ExecuteRequest()
        {
            HasExecuted = true;
            return new MockResponse() { Stream = StreamToReturn, ETag = this.ETag };
        }

        #endregion

        public IRequest WithBody(IDictionary<string, string> parameters)
        {
            throw new NotImplementedException();
        }
    }
}