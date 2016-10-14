using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoveryDocPatcher
{
    class Patcher
    {
        public static Patcher Load(string path)
        {
            return new Patcher(path, JObject.Parse(File.ReadAllText(path)));
        }

        private Patcher(string path, JObject json)
        {
            _path = path;
            _json = json;
        }

        private readonly string _path;
        private readonly JObject _json;
        private bool changed = false;

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
            JToken oldToken = JToken.Parse(oldContent.Replace('\'', '"'));
            JToken newToken = JToken.Parse(newContent.Replace('\'', '"'));
            Replace(jPath, oldToken, newToken);
        }
    }
}
