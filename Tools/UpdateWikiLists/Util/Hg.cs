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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Google.Apis.Samples.Helper;

namespace UpdateWikiLists.Util
{
    /// <summary>
    /// Mercurial interfacing class
    /// </summary>
    internal sealed class Hg : IDisposable
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

        private Hg(Uri repositoryUri)
        {
            RepositoryUri = repositoryUri;
            WorkingDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(WorkingDirectory);

            Name = repositoryUri.Segments.Last();
            this.CloneFrom(repositoryUri);
        }

        /// <summary>
        /// Commits the pending changes.
        /// </summary>
        /// <param name="message">Description of the changes/the commit.</param>
        public void Commit(string message)
        {
            CommandLine.WriteAction("Commiting changes of " + Name + " ..");
            RunHg(true, "commit -m \"{0}\"", message);
        }

        /// <summary>
        /// Pushes all commited changes to the server.
        /// </summary>
        public void Push()
        {
            CommandLine.WriteAction("Pushing " + Name + " ..");
            RunHg(false, "push");
        }

        private void CloneFrom(Uri uri)
        {
            CommandLine.WriteAction("Fetching "+uri+" ..");
            RunHg(true, "clone {0} {1}", uri.ToString(), WorkingDirectory);
        }

        private void RunHg(bool silent, string command, params string[] args)
        {
            var process = new Process();
            
            string commandLine = string.Format(command, args);
            process.StartInfo = new ProcessStartInfo("hg", commandLine);
            process.StartInfo.WorkingDirectory = WorkingDirectory;

            if (silent)
            {
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.ErrorDataReceived += (sender, error) =>
                                                 {
                                                     if (!string.IsNullOrEmpty(error.Data))
                                                     {
                                                         CommandLine.WriteError(error.Data);
                                                     }
                                                 };
                process.OutputDataReceived += (sender, msg) =>
                                                  {
                                                      if (!string.IsNullOrEmpty(msg.Data))
                                                      {
                                                          CommandLine.WriteResult("msg", msg.Data);
                                                      }
                                                  };
            }

            process.Start();

            if (silent)
            {
                process.BeginErrorReadLine();
                process.BeginOutputReadLine();
            }

            process.WaitForExit();
            if (process.ExitCode != 0)
            {
                string cmdLine = process.StartInfo.FileName + " " + process.StartInfo.Arguments;
                throw new ExternalException("The process '" + cmdLine + "' exited with errors.");
            }
        }

        /// <summary>
        /// Clones a new Mercurial repository.
        /// </summary>
        public static Hg Clone(string repository)
        {
            return new Hg(new Uri(repository));
        }

        public void Dispose()
        {
            CommandLine.WriteAction("Cleaning up " + Name + " ..");
            Directory.Delete(WorkingDirectory, true);
        }
    }
}
