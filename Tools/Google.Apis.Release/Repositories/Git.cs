/*
Copyright 2015 Google Inc

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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

using Google.Apis.Utils;
using Google.Apis.Utils.Trace;

namespace Google.Apis.Release.Repositories
{
    /// <summary>
    /// Git repository. The class content was copied from the HG repository. The commands were converted to Git style
    /// using: https://github.com/sympy/sympy/wiki/Git-hg-rosetta-stone.
    /// TODO(peleyal): Consider adding an ISourceControl (both Git and Hg should inherit form it). Currently there is
    /// no need, because I'm not expecting changing the host project again, and we have bigger battels... 
    /// </summary>
    public sealed class Git : IDisposable
    {
        static readonly TraceSource TraceSource = new TraceSource("Google.Apis");

        /// <summary>Gets the name of the repository.summary>
        public string Name { get; private set; }

        /// <summary>Gets the URI of the repository</summary>
        public Uri RepositoryUri { get; private set; }

        /// <summary>Gets the local working directory.</summary>
        public string WorkingDirectory { get; private set; }

        /// <summary>Gets indication if repository has pending changes.</summary>
        public bool HasUncommitedChanges
        {
            get 
            { 
                return !RunListeningGit("status").Contains("nothing to commit, working directory clean");
            }
        }

        /// <summary>Gets indication if there are incoming changes.</summary>
        public bool HasIncomingChanges
        {
            get 
            { 
                return RunListeningGit("whatchanged ..origin").Length > 0; 
            }
        }

        /// <summary>
        /// Constructs a new repository. It creates a new repository if the folder doesn't exists, otherwise it gets
        /// the current status of the repository.
        /// </summary>
        /// <param name="repositoryUri">The URI of this repository</param>
        /// <param name="localDir">The local directory which contains the repository files</param>
        public Git(Uri repositoryUri, string localDir)
        {
            RepositoryUri = repositoryUri;

            WorkingDirectory = string.IsNullOrEmpty(localDir) ? Environment.CurrentDirectory :
                Path.GetFullPath(localDir);
            Name = repositoryUri.Segments.Last();

            if (!Directory.Exists(WorkingDirectory))
            {
                TraceSource.TraceEvent(TraceEventType.Information, "[{0}] Fetching {1}", Name, repositoryUri);
                Directory.CreateDirectory(WorkingDirectory);
                RunGit(string.Format("clone {0} {1}", repositoryUri.ToString(), WorkingDirectory));
            }
            else
            {
                TraceSource.TraceEvent(TraceEventType.Information, "[{0}] Using an existing repository", Name);
                RunGit("fetch");
                RunGit("status");
            }
        }

        /// <summary>Commits the pending changes.</summary>
        /// <param name="message">Description of the changes/the commit.</param>
        /// <returns>Whether a commit was made/possible.</returns>
        public bool Commit(string message)
        {
            if (!HasUncommitedChanges)
            {
                return false;
            }

            TraceSource.TraceEvent(TraceEventType.Information, "[{0}] Committing changes", Name);
            RunGit(string.Format("commit -m \"{0}\"", message));
            return true;
        }

        /// <summary>Adds a tag to the last revision.</summary>
        /// <param name="tagName">The tag to add.</param>
        /// <param name="force">
        /// If set to true will overwrite existing labels of this name see "Git help tag" and its --force parameter.
        /// </param>
        public void Tag(string tagName, bool force = false)
        {
            TraceSource.TraceEvent(TraceEventType.Information, "[{0}] Tagging with {1}", Name, tagName);
            string options = (force ? "-f " : "");
            RunGit(string.Format("tag {0}\"{1}\"", options, tagName));
        }

        /// <summary>Adds all unversioned files and remove all versioned files.</summary>
        public void AddRemoveFiles()
        {
            RunGit("add -A");
        }

        /// <summary>Pushes all committed changes to the server.</summary>
        public void Push()
        {
            TraceSource.TraceEvent(TraceEventType.Information, "Pushing {0}", Name);
            RunGit("push");
        }

        /// <summary>Updates the repository by the branch name.</summary>
        public void Update(string branchName)
        {
            TraceSource.TraceEvent(TraceEventType.Information, "[{0}] Updating branch to {1}", Name, branchName);
            // TODO(peleyal): Double check that it's the same intention as "hg update [name]".
            RunGit("checkout " + branchName);
        }

        /// <summary>Creates the combined path of the specified directories.</summary>
        public string Combine(params string[] dirs)
        {
            return dirs.Aggregate(WorkingDirectory, Path.Combine);
        }

        /// <summary>Creates a change list by listing all changes made since the last release.</summary>
        public IEnumerable<string> CreateChangelist()
        {
            var comments = RunListeningGit("log --pretty=format:%s");
            return comments.TakeWhile(c => c.StartsWith("Added tag"));
        }

        /// <summary>Runs a Git command. In addition it prints errors and messages to trace.</summary>
        private void RunGitAndPrint(string command)
        {
            RunGit(command,
                error =>
                {
                    if (!string.IsNullOrEmpty(error))
                    {
                        TraceSource.TraceEvent(TraceEventType.Error, "[{0}] {1}", Name, error);
                    }
                },
                msg =>
                {
                    if (!string.IsNullOrEmpty(msg))
                    {
                        TraceSource.TraceEvent(TraceEventType.Information, "[{0}] Git {1}", Name, msg);
                    }
                });
        }

        /// <summary>
        /// Run a Git command which the specific callback for errors or messages returned from the command.
        /// </summary>
        private void RunGit(string command, Action<string> errorCallback = null, Action<string> messageCallback = null)
        {
            var process = new Process();

            process.StartInfo = new ProcessStartInfo("git", command);
            process.StartInfo.WorkingDirectory = WorkingDirectory;

            if (errorCallback != null || messageCallback != null)
            {
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
            }

            process.Start();
            if (errorCallback != null)
            {
                process.ErrorDataReceived += (sender, msg) =>
                {
                    if (msg.Data != null)
                    {
                        errorCallback(msg.Data);
                    }
                };
                process.BeginErrorReadLine();
            }
            if (messageCallback != null)
            {
                process.OutputDataReceived += (sender, msg) =>
                {
                    if (msg.Data != null)
                    {
                        messageCallback(msg.Data);
                    }
                };
                process.BeginOutputReadLine();
            }

            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                string cmdLine = process.StartInfo.FileName + " " + process.StartInfo.Arguments;
                throw new ExternalException("The process '" + cmdLine + "' exited with errors.", process.ExitCode);
            }
        }

        /// <summary>Runs a Git command and returns all its errors and messages output.</summary>
        private string[] RunListeningGit(string command)
        {
            var msgs = new List<string>();
            RunGit(command, msgs.Add, msgs.Add);
            return msgs.ToArray();
        }

        public void Dispose()
        {
            TraceSource.TraceEvent(TraceEventType.Information, "[{0}] Cleaning up", Name);
            Directory.Delete(WorkingDirectory, true);
        }
    }
}
