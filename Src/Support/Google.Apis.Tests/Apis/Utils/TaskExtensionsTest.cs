/*
Copyright 2020 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Util;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Apis.Tests.Apis.Utils
{
    public class TaskExtensionsTest
    {
        [Fact]
        public void WithCancellationToken_None()
        {
            var task = new TaskCompletionSource<int>().Task;
            // This token can't be cancelled, so the task is just returned directly.
            var result = task.WithCancellationToken(CancellationToken.None);
            Assert.Same(task, result);
        }

        [Fact]
        public async Task WithCancellationToken_TokenIsCancelled()
        {
            var cts = new CancellationTokenSource();
            var tcs = new TaskCompletionSource<int>();

            var result = tcs.Task.WithCancellationToken(cts.Token);
            cts.Cancel();

            await Assert.ThrowsAsync<TaskCanceledException>(async () => await result);
        }

        [Fact]
        public async Task WithCancellationToken_TaskIsCancelled()
        {
            var cts = new CancellationTokenSource();
            var tcs = new TaskCompletionSource<int>();

            var result = tcs.Task.WithCancellationToken(cts.Token);
            tcs.SetCanceled();

            await Assert.ThrowsAsync<TaskCanceledException>(async () => await result);
        }

        [Fact]
        public async Task WithCancellationToken_TaskIsFaulted()
        {
            var cts = new CancellationTokenSource();
            var tcs = new TaskCompletionSource<int>();

            var result = tcs.Task.WithCancellationToken(cts.Token);
            var exception = new Exception();
            tcs.SetException(exception);

            var caught = await Assert.ThrowsAsync<Exception>(async () => await result);
            Assert.Same(exception, caught);
        }

        [Fact]
        public async Task WithCancellationToken_TaskCompletes()
        {
            var cts = new CancellationTokenSource();
            var tcs = new TaskCompletionSource<int>();

            var result = tcs.Task.WithCancellationToken(cts.Token);
            tcs.SetResult(5);

            Assert.Equal(5, await result);
        }
    }
}
