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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

using Google.Apis.Utils;
using Google.Apis.Utils.Trace;

namespace Google.Apis.Release.Repositories
{
    /// <summary>Mercurial repository interface class.</summary>
    public sealed class Hg : IDisposable
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
                string[] changes = RunListeningHg("status");
                return changes.Length >= 1;
            }
        }

        /// <summary>Gets indication if there are incoming changes.</summary>
        public bool HasIncomingChanges
        {
            get
            {
                try
                {
                    RunListeningHg("incoming");
                    return true; // Exit code was 0
                }
                catch (ExternalException)
                {
                    return false;
                }
            }
        }

        /// <summary>Gets indication if the working copy has un-pushed changes.</summary>
        public bool HasUnpushedChanges
        {
            get
            {
                try
                {
                    string[] changes = RunListeningHg(string.Format("outgoing {0} {1}", "-l", "1"));
                    return changes.Length >= 4;
                }
                catch (ExternalException)
                {
                    // RunListeningHg throws an ExternalException when the launched process returns non-zero on exiting
                    // the executable "hg outgoing" returns 1 if there where no changes.
                    // So treat ExternalException as no changes.
                    return false;
                }
            }
        }

        /// <summary>
        /// Constructs a new repository. It creates a new repository if the folder doesn't exists, otherwise it gets
        /// the current status of the repository.
        /// </summary>
        /// <param name="repositoryUri">The URI of this repository</param>
        /// <param name="localDir">The local directory which contains the repository files</param>
        public Hg(Uri repositoryUri, string localDir)
        {
            RepositoryUri = repositoryUri;
            WorkingDirectory = Path.GetFullPath(localDir);
            Name = repositoryUri.Segments.Last();

            if (!Directory.Exists(WorkingDirectory))
            {
                TraceSource.TraceEvent(TraceEventType.Information, "[{0}] Fetching {1}", Name, repositoryUri);
                Directory.CreateDirectory(WorkingDirectory);
                RunHg(string.Format("clone {0} {1}", repositoryUri.ToString(), WorkingDirectory));
            }
            else
            {
                TraceSource.TraceEvent(TraceEventType.Information, "[{0}] Using an existing repository", Name);
                RunHg("status");
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

            RunHg("status -m -a -r");

            TraceSource.TraceEvent(TraceEventType.Information, "[{0}] Committing changes", Name);
            RunHg(string.Format("commit -m \"{0}\"", message));
            return true;
        }

        /// <summary>Adds a tag to the last revision.</summary>
        /// <param name="tagName">The tag to add.</param>
        /// <param name="force">
        /// If set to true will overwrite existing labels of this name see "hg help tag" and its --force parameter.
        /// </param>
        public void Tag(string tagName, bool force = false)
        {
            TraceSource.TraceEvent(TraceEventType.Information, "[{0}] Tagging with {1}", Name, tagName);
            string options = (force ? "-f " : "");
            RunHg(string.Format("tag {0}\"{1}\"", options, tagName));
        }

        /// <summary>Adds all unversioned files and remove all versioned files.</summary>
        public void AddRemoveFiles()
        {
            RunHg("addremove");
        }

        /// <summary>Pushes all committed changes to the server.</summary>
        public void Push()
        {
            if (!HasUnpushedChanges)
            {
                return;
            }

            TraceSource.TraceEvent(TraceEventType.Information, "Pushing {0}", Name);
            RunHg("push");
        }

        /// <summary>Updates the repository by the branch name.</summary>
        public void Update(string branchName)
        {
            TraceSource.TraceEvent(TraceEventType.Information, "[{0}] Updating branch to {1}", Name, branchName);
            RunHg("update " + branchName);
        }

        /// <summary>Creates the combined path of the specified directories.</summary>
        public string Combine(params string[] dirs)
        {
            return dirs.Aggregate(WorkingDirectory, Path.Combine);
        }

        /// <summary>Creates a change list by listing all changes made since the last release.</summary>
        public IEnumerable<string> CreateChangelist()
        {
            Regex tagRegex = new Regex("Added tag [0-9A-Za-z.-]+ for changeset [^b]+", RegexOptions.Compiled);
            string branch = RunListeningHg("branch").Single();
            return RunListeningHg(string.Format("log --template \"{{rev}}: {{desc}}\\r\\n\" -b {0}", branch))
                        .TakeWhile(line => !tagRegex.IsMatch(line));
        }

        /// <summary>Runs a HG command. In addition it prints errors and messages to trace.</summary>
        private void RunHg(string command)
        {
            RunHg(command,
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
                        TraceSource.TraceEvent(TraceEventType.Information, "[{0}] hg {1}", Name, msg);
                    }
                });
        }

        /// <summary>
        /// Run a HG command which the specific callback for errors or messages returned from the command.
        /// </summary>
        private void RunHg(string command, Action<string> errorCallback = null, Action<string> messageCallback = null)
        {
            var process = new Process();

            process.StartInfo = new ProcessStartInfo("hg", command);
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

        /// <summary>Runs a HG command and returns all its errors and messages output.</summary>
        private string[] RunListeningHg(string command)
        {
            var msgs = new List<string>();
            RunHg(command, msgs.Add, msgs.Add);
            return msgs.ToArray();
        }

        public void Dispose()
        {
            TraceSource.TraceEvent(TraceEventType.Information, "[{0}] Cleaning up", Name);
            Directory.Delete(WorkingDirectory, true);
        }
    }
}
