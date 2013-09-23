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
using System.Threading;
using Google.Apis.Samples.Helper;

namespace Google.Build.Utils
{
    /// <summary>
    /// Process Runner.
    /// </summary>
    public class Runner
    {
        /// <summary>
        /// The command or application to run.
        /// </summary>
        public string Command { get; private set; }

        /// <summary>
        /// The arguments which are passed to the application.
        /// </summary>
        public string Arguments { get; private set; }

        /// <summary>
        /// The working directory of the application.
        /// </summary>
        public string WorkingDirectory { get; set; }

        public Runner(string command, params string[] args)
        {
            Command = command;
            Arguments = args.Select(arg => "\"" + arg + "\"").Aggregate((a, b) => a + " " + b);
        }

        /// <summary>
        /// Runs the process in a seperate shell window.
        /// </summary>
        public void RunShell()
        {
            RunInternal(setup => {}, process => {});
        }
        
        /// <summary>
        /// Runs the process and redirects the output into the current Console.
        /// </summary>
        public void Run()
        {
            string fileName = Path.GetFileNameWithoutExtension(Command);
            object sync = new object();
            RunInternal((isError, msg) =>
                            {
                                lock (sync)
                                {
                                    if (isError)
                                    {
                                        msg = "{red}" + msg;
                                    }
                                    CommandLine.WriteResult(fileName, msg);
                                }
                            });
        }

        /// <summary>
        /// Runs the process and returns the output.
        /// </summary>
        /// <returns>All messages of the process.</returns>
        public string[] RunAndListen()
        {
            var msgs = new List<string>();
            RunInternal((isError, msg) => msgs.Add(msg));
            return msgs.ToArray();
        }

        private void RunInternal(Action<bool,string> msg)
        {
            Action<bool, DataReceivedEventArgs> msgHandler = (isError, data) =>
                                                                 {
                                                                     if (data.Data != null)
                                                                     {
                                                                         msg(isError, data.Data);
                                                                     }
                                                                 };

            RunInternal(
                info =>
                    {
                        info.RedirectStandardError = true;
                        info.RedirectStandardOutput = true;
                        info.CreateNoWindow = true;
                        info.UseShellExecute = false;
                    }, process =>
                           {
                               process.ErrorDataReceived += (sender, data) => msgHandler(true, data);
                               process.OutputDataReceived += (sender, data) => msgHandler(false, data);
                               process.BeginErrorReadLine();
                               process.BeginOutputReadLine();
                           });
        }

        private void RunInternal(Action<ProcessStartInfo> setupProcess, Action<Process> afterStart)
        {
            // Setup the process.
            var startInfo = new ProcessStartInfo(Command, Arguments);
            startInfo.WorkingDirectory = WorkingDirectory;
            setupProcess(startInfo);
            
            // Launch the process.
            Process process = Process.Start(startInfo);
            afterStart(process);

            // Wait for exit.
            process.WaitForExit();
            Thread.Sleep(0);
            if (process.ExitCode != 0)
            {
                string cmdLine = process.StartInfo.FileName + " " + process.StartInfo.Arguments;
                throw new ExternalException("The process '" + cmdLine + "' exited with errors.", process.ExitCode);
            }
        }
    }
}
