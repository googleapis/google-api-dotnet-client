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
                var destFilename = _path + ".original";
                try
                {
                    File.Delete(destFilename);
                }
                catch (FileNotFoundException) { }
                File.Move(_path, destFilename);
                string json = _json.ToString();
                File.WriteAllText(_path, json);
            }
        }

        public void FromAnyToTypedArray(string jPath, string arrayElementType)
        {
            var obj = (JObject)_json.SelectToken(jPath);
            if (obj["type"]?.ToString() == "any")
            {
                obj["type"] = "array";
                obj.Property("type").AddAfterSelf(new JProperty("items", new JObject(new JProperty("$ref", arrayElementType))));
                changed = true;
            }
        }

        public void FromAnyToTyped(string jPath, string type)
        {
            var obj = (JObject)_json.SelectToken(jPath);
            if (obj["type"]?.ToString() == "any")
            {
                obj.Property("type").Replace(new JProperty("$ref", type));
                changed = true;
            }
        }
    }
}
