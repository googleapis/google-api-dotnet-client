/*
Copyright 2012 Google Inc

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
using System.Net;
using System.Text;

using NUnit.Framework;

namespace Google.Apis.Tests.Utility
{
    /// <summary>
    /// MockServer creates a server which allows us to set up and validate requests and
    /// supply mocked responses.
    /// </summary>
    public class MockServer : IDisposable
    {
        protected HttpListener Listener { get; set; }
        public int Port { get; private set; }
        public string BaseUri { get; private set; }
        public string UploadUri { get; private set; }

        // Would rather use a "correct" port-finding logic but the HttpListener
        // class doesn't support it.
        private const int DefaultPort = 22123;

        public MockServer()
        {
            this.Port = DefaultPort;
            this.BaseUri = String.Format("http://localhost:{0}/", this.Port);
            this.UploadUri = String.Format("http://localhost:{0}/upload", this.Port);

            this.Listener = new HttpListener();
            this.Listener.Prefixes.Add(this.BaseUri);
            this.Listener.Start();

            this.Listener.BeginGetContext(OnRequest, null);
        }

        private Queue<Action<HttpListenerContext>> ServerActions
            = new Queue<Action<HttpListenerContext>>();

        private void OnRequest(IAsyncResult asyncResult)
        {
            var context = this.Listener.EndGetContext(asyncResult);
            if (ServerActions.Count > 0)
            {
                var action = ServerActions.Dequeue();
                try
                {
                    action(context);
                }
                catch (Exception ex)
                {
                    context.Response.StatusCode = 500;
                    JsonError(context.Response.OutputStream, ex.Message);
                }
            }
            else
            {
                context.Response.StatusCode = 404;
                JsonError(context.Response.OutputStream, "Server received an unexpected request.");
            }
            context.Response.Close();

            if (ServerActions.Count != 0)
                this.Listener.BeginGetContext(OnRequest, null);
        }

        private void JsonError(Stream outputStream, string errorMessage)
        {
            var sb = new StringBuilder();
            sb.Append("{ 'error' : { 'message' : '");
            sb.Append(errorMessage); // TODO: JSON encode
            sb.Append("' } }");
            using (StreamWriter sw = new StreamWriter(outputStream))
            {
                sw.Write(sb.ToString());
            }
        }

        /// <summary>
        /// Tell the MockServer to expect a request and program the response.
        /// </summary>
        /// <param name="requestAction">
        /// A callback to validate the request and prepare the response.
        /// </param>
        public void ExpectRequest(Action<HttpListenerContext> requestAction)
        {
            ServerActions.Enqueue(requestAction);
        }

        protected void ValidateMethodsCompleted()
        {
            Assert.That(ServerActions.Count, Is.EqualTo(0), "Expected server actions were not completed.");
        }

        #region Disposable

        void IDisposable.Dispose()
        {
            Dispose(true);
        }

        ~MockServer()
        {
            Dispose(false);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Listener.Stop();
                ValidateMethodsCompleted();
            }
        }

        #endregion
    }

}
