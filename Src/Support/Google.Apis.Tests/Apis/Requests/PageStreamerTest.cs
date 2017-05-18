/*
Copyright 2016 Google Inc

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

using Google.Apis.Discovery;
using Google.Apis.Requests;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Tests.Apis.Requests
{
    /// <summary>Tests for <see cref="PageStreamer{TResource, TRequest, TResponse, TToken}" />.</summary>
    public class PageStreamerTest
    {
        private static readonly PageStreamedResource simpleResource = new PageStreamedResource(
            "simple",
            new Page(null, 1, 2, 3),
            new Page("x", 4, 5),
            new Page("y", 6, 7));

        private static readonly PageStreamedResource resourceWithEmptyPages = new PageStreamedResource(
            "empty pages",
            new Page(null, 1, 2, 3),
            new Page("a"),
            new Page("b"),
            new Page("c", 4, 5),
            new Page("d"));

        public static PageStreamedResource[][] AllResources = new[] {
            simpleResource,
            resourceWithEmptyPages
        }.Select(x => new[] { x }).ToArray();

        [Theory, MemberData(nameof(AllResources))]
        public void Fetch(PageStreamedResource resource)
        {
            var actual = PageStreamedResource.PageStreamer.Fetch(new Request(resource));
            Assert.Equal(resource.AllItems, actual);
        }

        [Theory, MemberData(nameof(AllResources))]
        public async Task FetchAllAsync(PageStreamedResource resource)
        {
            var actual = await PageStreamedResource.PageStreamer.FetchAllAsync(
                new Request(resource),
                CancellationToken.None);
            Assert.Equal(resource.AllItems, actual);
        }

        // Note: this doesn't test all the possible timings of cancellation
        [Fact]
        public async Task Cancellation()
        {
            var cts = new CancellationTokenSource();
            var gatekeeperSource = new TaskCompletionSource<int>();
            var resource = new PageStreamedResource(
                "check",
                new Page("x", 1, 2, 3),
                new Page("y", 4, 5),
                new Page(null, 6, 7));
            resource.gateKeeper = gatekeeperSource.Task;            

            var task = PageStreamedResource.PageStreamer.FetchAllAsync(new Request(resource), cts.Token);
            // Delay the resource fetching until we've cancelled the token
            cts.Cancel();
            gatekeeperSource.SetResult(0);
            // TODO: Move to Assert.ThrowsAsync when we update to an appropriate version of NUnit.
            // Assert.That is available, but the documentation is unclear how this interacts with await.
            try
            {
                await task;
                Assert.True(false, "Expected exception");
            }
            catch (OperationCanceledException)
            {
                // Expected
            }
        }

        // Has to be public so we can use it as a parameter for test cases
        public class PageStreamedResource
        {
            internal static readonly PageStreamer<int, Request, Page, string> PageStreamer =
                new PageStreamer<int, Request, Page, string>(
                    (request, token) => request.Token = token,
                    page => page.NextPageToken,
                    page => page.Items);

            // Task to await when fetching pages; defaults to an already completed task,
            // but can be set to another task to allow for more fine-grained interaction.
            internal Task gateKeeper = Task.FromResult(0);
            internal List<Page> Pages { get; private set; }
            internal string Name { get; set; }

            internal PageStreamedResource(string name, params Page[] pages)
            {                
                this.Name = name;
                this.Pages = pages.ToList();
                for (int i = 0; i < pages.Length - 1; i++)
                {
                    Pages[i].NextPageToken = Pages[i + 1].CurrentPageToken;
                }
            }

            public override string ToString()
            {
                return Name;
            }

            internal Page GetPage(string token)
            {
                // This will fail if we provide a token that doesn't exist.
                return Pages.Single(p => p.CurrentPageToken == token);
            }

            internal async Task<Page> GetPageAsync(string token, CancellationToken cancellationToken)
            {
                await gateKeeper;
                cancellationToken.ThrowIfCancellationRequested();
                return GetPage(token);
            }

            public IEnumerable<int> AllItems => Pages.SelectMany(page => page.Items);
        }

        /// <summary>
        /// Request to work with <see cref="PageStreamedResource"/>; feels like overkill (in a non-HTTP context)
        /// due to having to implement <see cref="IClientServiceRequest{Page}"/> but there isn't an interface
        /// which only includes <c>Execute</c> and <c>ExecuteAsync.</c>
        /// </summary>
        internal class Request : IClientServiceRequest<Page>
        {
            internal string Token { get; set; }

            private readonly PageStreamedResource resource;

            internal Request(PageStreamedResource resource)
            {
                this.resource = resource;
            }

            // Properties which are more easily implemented by returning dummy values than by throwing exceptions
            public string MethodName { get { return null; } }
            public string RestPath { get { return null; } }
            public string HttpMethod { get { return null; } }
            public IDictionary<string, IParameter> RequestParameters { get { return new Dictionary<string, IParameter>(); } }
            public IClientService Service { get { return null; } }

            public Task<Page> ExecuteAsync()
            {
                return ExecuteAsync(CancellationToken.None);
            }

            public Task<Page> ExecuteAsync(CancellationToken cancellationToken)
            {
                return resource.GetPageAsync(Token, cancellationToken);
            }

            public Page Execute()
            {
                return resource.GetPage(Token);
            }

            // Methods that we know we won't call. (PageStreamer only needs to know how to execute requests, not the low-level bits.)
            public HttpRequestMessage CreateRequest(bool? overrideGZipEnabled = default(bool?))
            {
                throw new NotImplementedException();
            }

            public Task<Stream> ExecuteAsStreamAsync()
            {
                throw new NotImplementedException();
            }

            public Task<Stream> ExecuteAsStreamAsync(CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }

            public Stream ExecuteAsStream()
            {
                throw new NotImplementedException();
            }
        }

        internal class Page
        {
            internal List<int> Items { get; }
            /// <summary>
            /// The page token used to request this page.
            /// </summary>
            internal string CurrentPageToken { get; }
            /// <summary>
            /// The page token included with this page in order to request the next page of results.
            /// (This will be null if this is the last page of results.)
            /// </summary>
            internal string NextPageToken { get; set; }

            internal Page(string token, params int[] items)
            {
                this.CurrentPageToken = token;
                this.Items = items.ToList();
            }
        }
    }
}
