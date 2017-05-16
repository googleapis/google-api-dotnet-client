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

using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace DiscoveryDocPatcher
{
    class Patcher
    {
        public static Patcher Load(string path) =>
            new Patcher(path, JObject.Parse(File.ReadAllText(path)));

        private readonly string _path;
        private readonly JObject _json;
        private bool changed = false;

        private Patcher(string path, JObject json)
        {
            _path = path;
            _json = json;
        }

        public void SaveWithBackup()
        {
            if (changed)
            {
                File.Move(_path, _path + ".original");
                string json = _json.ToString();
                File.WriteAllText(_path, json);
            }
        }

        public void Remove(string jPath, JToken oldToken, JToken replacedToken)
        {
            // replacedToken is used if this remove operation has already been carried
            // out on this jPath. It contains the token that is expected to be at the
            // jPath *after* the remove operation.
            var token = _json.SelectToken(jPath);
            if (!JToken.DeepEquals(token, oldToken))
            {
                if (JToken.DeepEquals(token, replacedToken))
                {
                    // Already replaced, so do nothing.
                    return;
                }
                throw new InvalidOperationException("Content wrong");
            }
            changed = true;
            token.Remove();
        }

        public void Remove(string jPath, string oldContent, string replacedContent)
        {
            // Single quotes replaced with double quotes, to ease caller string literals.
            JToken oldToken = JToken.Parse(oldContent.Replace('\'', '"'));
            JToken replacedToken = JToken.Parse(replacedContent.Replace('\'', '"'));
            Remove(jPath, oldToken, replacedToken);
        }

        public void Replace(string jPath, JToken oldToken, JToken newToken)
        {
            var token = _json.SelectToken(jPath);
            if (!JToken.DeepEquals(token, oldToken))
            {
                if (JToken.DeepEquals(token, newToken))
                {
                    // Already replaced, so do nothing.
                    return;
                }
                throw new InvalidOperationException("Content wrong");
            }
            changed = true;
            token.Replace(newToken);
        }

        public void Replace(string jPath, string oldContent, string newContent)
        {
            // Single quotes replaced with double quotes, to ease caller string literals.
            JToken oldToken = JToken.Parse(oldContent.Replace('\'', '"'));
            JToken newToken = JToken.Parse(newContent.Replace('\'', '"'));
            Replace(jPath, oldToken, newToken);
        }
    }
}
