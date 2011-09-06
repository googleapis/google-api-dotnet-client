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
using System.IO;
using System.Linq;
using System.Reflection;

/// <summary>
/// Class providing extension methods to existing classes.
/// </summary>
public static class Extensions
{
    /// <summary>
    /// Returns the path to the codebase of this assembly.
    /// </summary>
    public static string GetCodebasePath(this Assembly assembly)
    {
        // Convert the file:// specification into a local path.
        Uri codebase = new Uri(assembly.CodeBase);

        // Get the real filename (.dll instead of .DLL).
        return GetCorrectCasedFile(codebase.LocalPath);
    }

    private static string GetCorrectCasedFile(string file)
    {
        // There is apparently no better way to do this on windows
        return Directory.GetFiles(Path.GetDirectoryName(file), Path.GetFileName(file)).Single();
    }
}

