/*
Copyright 2011 Google Inc

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
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Linq;
using Google.Apis.Discovery;
using Google.Apis.Logging;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Requests
{
    /// <summary>
    /// Represents an abstract, strongly typed request base class to make requests made to a service.
    /// Supports a strongly typed response.
    /// </summary>
    /// <remarks>Internally uses the dynamic Request class to execute requests.</remarks>
    /// <typeparam name="TResponse">The type of the response object</typeparam>
    public abstract class ServiceRequest<TResponse> : IServiceRequest<TResponse>
    {
        protected ServiceRequest()
        {
            ETagAction = ETagAction.Default;
        }

        /// <summary>
        /// The name of the "GetBody" method
        /// </summary>
        public const string GetBodyMethodName = "GetBody";

        private static readonly ILogger logger = ApplicationContext.Logger.ForType<ServiceRequest<TResponse>>();
        private readonly IRequestProvider service;

        /// <summary>
        /// Defines whether the E-Tag will be used in a specified way or ignored.
        /// </summary>
        public ETagAction ETagAction { get; set; }

        /// <summary>
        /// The E-Tag to use with this request. If this is null, the e-tag of the body will be used (if possible).
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// Selector specifying which fields to include in a partial response.
        /// </summary>
        public string FieldsMask { get; set; }

        /// <summary>
        /// IP address of the site where the request originates. Use this if you want to enforce per-user limits.
        /// </summary>
        public string UserIp { get; set; }

        /// <summary>
        /// Creates a new service request.
        /// </summary>
        protected ServiceRequest(IRequestProvider service)
        {
            this.service = service;
        }

        /// <summary>
        /// Name of the Resource to which the method belongs.
        /// </summary>
        protected abstract string ResourcePath { get; }

        /// <summary>
        /// The name of the method to which this request belongs.
        /// </summary>
        protected abstract string MethodName { get; }

        /// <summary>
        /// The service on which the request will be executed.
        /// </summary>
        protected IRequestProvider Service
        {
            get { return service; }
        }
        
        /// <summary>
        /// Should return the body of the request (if applicable), or null.
        /// </summary>
        protected virtual object GetBody()
        {
            return null;
        }

        /// <summary>
        /// Returns the serialized version of the body, or null if unavailable.
        /// </summary>
        private string GetSerializedBody()
        {
            object body = GetBody();
            if (body == null)
            {
                return null;
            }

            // Serialize the body.
            return service.SerializeObject(body);
        }

        /// <summary>
        /// Builds an executeable base request containing the data of this request class.
        /// </summary>
        [VisibleForTestOnly]
        internal IRequest BuildRequest()
        {
            IRequest request = service.CreateRequest(ResourcePath, MethodName);
            request.WithBody(GetSerializedBody());
            request.WithParameters(CreateParameterDictionary());
            request.WithETagAction(ETagAction);
            request.WithFields(FieldsMask);
            request.WithUserIp(UserIp);

            // Check if there is an ETag to attach.
            if (!string.IsNullOrEmpty(ETag))
            {
                request.WithETag(ETag);
            }
            else
            {
                // If no custom ETag has been set, try to use the one which might come with the body.
                // If this is a ISchemaResponse, the etag has been added to the object as it was created.
                IDirectResponseSchema body = GetBody() as IDirectResponseSchema;
                if (body != null)
                {
                    request.WithETag(body.ETag);
                }
            }

            return request;
        }

        /// <summary>
        /// Retrieves a response asynchronously
        /// </summary>
        /// <param name="responseHandler">Method to call once a response has been received.</param>
        private void GetAsyncResponse(Action<IAsyncRequestResult> responseHandler)
        {
            string requestName = string.Format("{0}.{1}", ResourcePath, MethodName);
            logger.Debug("Start Executing " + requestName);
            IRequest request = BuildRequest();
            request.ExecuteRequestAsync((IAsyncRequestResult result) =>
                                            {
                                                logger.Debug("Done Executing " + requestName);
                                                responseHandler(result);
                                            });
        }

        /// <summary>
        /// Receives a response synchronously.
        /// </summary>
        /// <returns>The received response.</returns>
        private IResponse GetResponse()
        {
            AutoResetEvent waitHandle = new AutoResetEvent(false);
            IAsyncRequestResult result = null;
            GetAsyncResponse(r =>
                                 {
                                     result = r;
                                     waitHandle.Set();
                                 });
            waitHandle.WaitOne();
            return result.GetResponse();
        }

        /// <summary>
        /// Fetches the specified response as an object.
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        [VisibleForTestOnly]
        internal TResponse FetchObject(IResponse response)
        {
            response.ThrowIfNull("response");
            return service.DeserializeResponse<TResponse>(response);
        }

        /// <summary>
        ///Executes the request synchronously and returns the result.
        /// </summary>
        public TResponse Fetch()
        {
            return FetchObject(GetResponse());
        }

        /// <summary>
        /// Executes the request synchronously and returns the unparsed response stream.
        /// </summary>
        /// <remarks>The returned stream is encoded in UTF-8.</remarks>
        public Stream FetchAsStream()
        {
            IResponse response = GetResponse();
            response.ThrowIfNull("response");
            return response.Stream;
        }
        
        /// <summary>
        /// Creates a parameter dictionary by using reflection to look at all properties marked with a KeyAttribute.
        /// </summary>
        [VisibleForTestOnly]
        internal IDictionary<string, object> CreateParameterDictionary()
        {
            var dict = new Dictionary<string, object>();

            // Use reflection to build the parameter dictionary.
            foreach (PropertyInfo property in GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                // Retrieve the attribute.
                RequestParameterAttribute requestParameterAttribute =
                    property.GetCustomAttributes(typeof(RequestParameterAttribute), false).FirstOrDefault() as
                    RequestParameterAttribute;
                if (requestParameterAttribute == null)
                {
                    continue;
                }

                // Get the discovery name of this parameter by looking at the attribute, or taking a lower-case
                // variant of the property name if no special name was set.
                string name = requestParameterAttribute.Name ?? property.Name.ToLower();

                // Set the value in the dictionary.
                var propertyType = property.PropertyType;
                var value = property.GetValue(this, null);

                if (propertyType.IsValueType || value != null)
                {
                    dict.Add(name, value);
                }
            }

            return dict;
        }

        #region Async Support

        /// <summary>
        /// Executes the request asynchronously and optionally calls the specified method once finished.
        /// </summary>
        public void FetchAsync([Optional] ExecuteRequestDelegate<TResponse> methodToCall)
        {
            GetAsyncResponse(
                (IAsyncRequestResult state) =>
                    {
                        var result = new LazyResult<TResponse>(() =>
                                {
                                    // Retrieve and convert the response.
                                    IResponse response = state.GetResponse();
                                    return FetchObject(response);
                                });

                        // Only invoke the method if it was set.
                        if (methodToCall != null)
                        {
                            methodToCall(result);
                        }
                        else
                        {
                            result.GetResult();
                        }
                    });
        }

        /// <summary>
        /// Executes the request asynchronously without parsing the response, 
        /// and calls the specified method once finished.
        /// </summary>
        /// <remarks>The returned stream is encoded in UTF-8.</remarks>
        public void FetchAsyncAsStream([Optional] ExecuteRequestDelegate<Stream> methodToCall)
        {
            GetAsyncResponse(
                (IAsyncRequestResult state) =>
                    {
                        var result = new LazyResult<Stream>(
                            () =>
                                {
                                    // Retrieve and convert the response.
                                    IResponse response = state.GetResponse();
                                    response.ThrowIfNull("response");
                                    return response.Stream;
                                });

                        // Only invoke the method if it was set.
                        if (methodToCall != null)
                        {
                            methodToCall(result);
                        }
                        else
                        {
                            result.GetResult(); // Resolve the result in any case.
                        }
                    });
        }

        /// <summary>
        /// Describes the state of an asynchronous fetch operation.
        /// </summary>
        private class RequestAsyncResult : IAsyncResult
        {
            public bool IsCompleted { get; set; }

            public WaitHandle AsyncWaitHandle { get; set; }

            public object AsyncState { get; set; }

            public bool CompletedSynchronously { get; set; }

            /// <summary>
            /// The result returned by this asynchronous operation.
            /// </summary>
            public object Result { get; set; }
        }

        /// <summary>
        /// Begins an asynchronous Fetch request.
        /// </summary>
        /// <param name="callback">The method to call once the request has been completed. Optional.</param>
        /// <param name="state">
        ///   A user-defined object used to pass application-specific state information to the
        ///   <paramref name="callback"/> method invoked when the asynchronous operation completes. Optional.
        /// </param>
        /// <returns>An IAsyncResult describing the state of the asynchronous operation.</returns>
        public IAsyncResult BeginFetch(AsyncCallback callback, object state)
        {
            return BeginFetchInternal(callback, state, result => FetchObject(result.GetResponse()));
        }

        /// <summary>
        /// Begins an asynchronous FetchAsStream request.
        /// </summary>
        /// <param name="callback">The method to call once the request has been completed. Optional.</param>
        /// <param name="state">
        ///   A user-defined object used to pass application-specific state information to the
        ///   <paramref name="callback"/> method invoked when the asynchronous operation completes. Optional.
        /// </param>
        /// <returns>An IAsyncResult describing the state of the asynchronous operation.</returns>
        public IAsyncResult BeginFetchAsStream(AsyncCallback callback, object state)
        {
            return BeginFetchInternal(callback, state, result => result.GetResponse().Stream);
        }

        [VisibleForTestOnly]
        internal IAsyncResult BeginFetchInternal(AsyncCallback callback,
                                                 object state,
                                                 Func<IAsyncRequestResult, object> fetchFunction)
        {
            RequestAsyncResult asyncState = new RequestAsyncResult();
            asyncState.AsyncState = state;
            asyncState.IsCompleted = false;

            // Create a WaitHandle representing our current task, and run it.
            asyncState.AsyncWaitHandle = new AutoResetEvent(false);
            GetAsyncResponse(
                result =>
                    {
                        // Fetch the result.
                        asyncState.Result = fetchFunction(result);

                        // Signal that the operation has completed.
                        asyncState.IsCompleted = true;
                        if (callback != null)
                        {
                            callback(asyncState);
                        }
                        ((AutoResetEvent)asyncState.AsyncWaitHandle).Set();
                    });
            return asyncState;
        }

        [VisibleForTestOnly]
        internal object EndFetchInternal(IAsyncResult asyncResult)
        {
            RequestAsyncResult asyncState = (RequestAsyncResult) asyncResult;
            asyncState.ThrowIfNull("asyncResult");

            // If this request was not finished, wait for it to finish.
            if (!asyncState.IsCompleted)
            {
                asyncState.AsyncWaitHandle.WaitOne();
                asyncState.CompletedSynchronously = true;
            }

            return asyncState.Result;
        }

        /// <summary>
        /// Completes an asynchronous Fetch request.
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult passed from BeginFetch.</param>
        /// <returns>The response object.</returns>
        /// <remarks>Will complete the request synchronously if called manually.</remarks>
        public TResponse EndFetch(IAsyncResult asyncResult)
        {
            return (TResponse) EndFetchInternal(asyncResult);
        }

        /// <summary>
        /// Completes an asynchronous FetchAsStream request.
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult passed from BeginFetch.</param>
        /// <returns>The response stream.</returns>
        /// <remarks>Will complete the request synchronously if called manually.</remarks>
        public Stream EndFetchAsStream(IAsyncResult asyncResult)
        {
            return (Stream) EndFetchInternal(asyncResult);
        }

        #endregion
    }
}
