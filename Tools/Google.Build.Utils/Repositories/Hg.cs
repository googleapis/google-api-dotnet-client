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
using Google.Apis.Samples.Helper;

namespace Google.Build.Utils.Repositories
{
    /// <summary>
    /// Mercurial interfacing class
    /// </summary>
    public sealed class Hg : IDisposable
    {
        /// <summary>
        /// Name of the repository.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The URI of the repositoty
        /// </summary>
        public Uri RepositoryUri { get; private set; }

        /// <summary>
        /// The local working directory.
        /// </summary>
        public string WorkingDirectory { get; private set; }

        /// <summary>
        /// True if this working copy has pending changes.
        /// </summary>
        public bool HasUncommitedChanges
        {
            get
            {
                string[] changes = RunListeningHg("status");
                return changes.Length >= 1;
            }
        }

        /// <summary>
        /// True if there are unpulled, incoming changes.
        /// </summary>
        public bool HasIncomingChanges
        {
            get
            {
                try
                {
                    RunListeningHg("incoming");
                    return true; // Exit code was 0
                } catch (ExternalException)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// True if this working copy has unpushed changes.
        /// </summary>
        public bool HasUnpushedChanges
        {
            get
            {
                string[] changes = RunListeningHg("outgoing", "-l", "1");
                return changes.Length >= 4;
            }
        }

        private Hg(Uri repositoryUri) : this(repositoryUri, Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()))
        {
            
        }
        private Hg(Uri repositoryUri, string localDir)
        {
            RepositoryUri = repositoryUri;
            WorkingDirectory = Path.GetFullPath(localDir);
            Name = repositoryUri.Segments.Last();

            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
                this.CloneFrom(repositoryUri);
            }
            else
            {
                CommandLine.WriteAction("Using existing repository for " + Name + " at " + WorkingDirectory + " ..");
                RunHg("status");
            }
        }

        /// <summary>
        /// Commits the pending changes.
        /// </summary>
        /// <param name="message">Description of the changes/the commit.</param>
        /// <returns>Whether a commit was made/possible.</returns>
        public bool Commit(string message)
        {
            if (!HasUncommitedChanges)
            {
                return false;
            }

            RunHg("status -m -a -r");

            CommandLine.WriteAction("Commiting changes of " + Name + " ..");
            RunHg("commit -m \"{0}\"", message);
            return true;
        }

        /// <summary>
        /// Adds a tag to the last revision.
        /// </summary>
        /// <param name="tagName">The tag to add.</param>
        public void Tag(string tagName)
        {
            CommandLine.WriteAction("Tagging " + Name + " with "+tagName+"..");
            RunHg("tag \"{0}\"", tagName);
        }

        /// <summary>
        /// Adds all unversioned files to the current commit.
        /// </summary>
        public void AddUnversionedFiles()
        {
            RunHg("add");
        }

        /// <summary>
        /// Marks all versioned files which have been deleted as removed.
        /// </summary>
        public void RemoveDeletedFiles()
        {
            var missingFiles = RunListeningHg("status -d")
                                .Where(l => l.StartsWith("! "))
                                .Select(l => "\"" + l.Substring("! ".Length) + "\"");
            
            string files = String.Join(" ", missingFiles);
            if (!string.IsNullOrEmpty(files))
            {
                CommandLine.WriteAction("Removing files: "+files);
                RunHg("remove {0}", files);
            }
        }

        /// <summary>
        /// Pushes all commited changes to the server.
        /// </summary>
        public void Push()
        {
            if (!HasUnpushedChanges)
            {
                return;
            }

            CommandLine.WriteAction("Pushing " + Name + " ..");
            RunShellHg("push");
        }

        /// <summary>
        /// Pulls and updates this clone.
        /// </summary>
        public void PullUpdate()
        {
            RunShellHg("hg pull");
            RunShellHg("hg update");
        }

        /// <summary>
        /// Outputs the diff to the default output stream.
        /// </summary>
        public void ShowDiff()
        {
            RunShellHg("diff");
        }

        /// <summary>
        /// Creates the combined path of the specified directories.
        /// </summary>
        public string Combine(params string[] dirs)
        {
            return dirs.Aggregate(WorkingDirectory, Path.Combine);
        }

        /// <summary>
        /// Creates a change list by listing all changes made since the last release.
        /// </summary>
        public IEnumerable<string> CreateChangelist()
        {
            Regex tagRegex = new Regex("Added tag [^b]+ for changeset [^b]+", RegexOptions.Compiled);
            string branch = RunListeningHg("branch").Single();
            return RunListeningHg("log --template \"{{rev}}: {{desc}}\\r\\n\" -b {0}", branch)
                        .TakeWhile(line => !tagRegex.IsMatch(line));
        }

        private void CloneFrom(Uri uri)
        {
            CommandLine.WriteAction("Fetching "+uri+" ..");
            RunHg("clone {0} {1}", uri.ToString(), WorkingDirectory);
        }

        private void RunShellHg(string command, params string[] args)
        {
            RunHg(command, null, null, args);
        }

        private void RunHg(string command, params string[] args)
        {
            RunHg(
                command, error =>
                             {
                                 if (!string.IsNullOrEmpty(error))
                                 {
                                     CommandLine.WriteError(error);
                                 }
                             }, msg =>
                                    {
                                        if (!string.IsNullOrEmpty(msg))
                                        {
                                            CommandLine.WriteResult("hg", msg);
                                        }
                                    }, args);
        }

        private string[] RunListeningHg(string command, params string[] args)
        {
            var msgs = new List<string>();
            RunHg(command, msgs.Add, msgs.Add, args);
            return msgs.ToArray();
        }

        private void RunHg(string command, Action<string> errors, Action<string> msgs, params string[] args)
        {
            var process = new Process();

            string commandLine = string.Format(command, args);
            process.StartInfo = new ProcessStartInfo("hg", commandLine);
            process.StartInfo.WorkingDirectory = WorkingDirectory;

            if (errors != null || msgs != null)
            {
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
            }

            process.Start();

            if (errors != null)
            {
                process.ErrorDataReceived += (sender, msg) =>
                                                 {
                                                     if (msg.Data != null)
                                                     {
                                                         errors(msg.Data);
                                                     }
                                                 };
                process.BeginErrorReadLine();
            }
            if (msgs != null)
            {
                process.OutputDataReceived += (sender, msg) =>
                                                  {
                                                      if (msg.Data != null)
                                                      {
                                                          msgs(msg.Data);
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

        /// <summary>
        /// Clones a new Mercurial repository.
        /// </summary>
        public static Hg Clone(string repository)
        {
            return new Hg(new Uri(repository));
        }

        /// <summary>
        /// Reuses the existing local repository, or creates a new clone of it does not exist.
        /// </summary>
        /// <param name="localDir">The local Mercurial repository.</param>
        /// <param name="repository">The remote URL.</param>
        public static Hg Get(string localDir, string repository)
        {
            return new Hg(new Uri(repository), localDir);
        }

        public void Dispose()
        {
            CommandLine.WriteAction("Cleaning up " + Name + " ..");
            Directory.Delete(WorkingDirectory, true);
        }
    }
}
