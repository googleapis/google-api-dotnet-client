/*
Copyright 2010 Google Inc

Licensed under the Apache License, Version 2.0 (the ""License"");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an ""AS IS"" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using NAnt.Core;
using NAnt.Core.Attributes;
using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen;
using Google.Apis.Util;
using Google.Apis.Discovery.V1.Data;
using DiscoveryService = Google.Apis.Discovery.V1.DiscoveryService;


namespace Google.Apis.Tools.NAntTasks
{
   
    /// <summary>
    /// This class provides a NAnt task that discovers all public 
    /// GoogleApis and makes the list of them available.
    /// 
    /// <para>
    ///   When executed this task assigns the nant variable named in 
    ///   <seealso cref="Property"/> (defaults to google.apis.all) to 
    ///   a ^ dilemited list of apis. Each item of this list is it's self
    ///   a | delimited list of properties. You can then use foreach and regex 
    ///   to loop over all apis and extract the fields.
    /// </para>
    /// Variables set by this task
    /// <list type="bullet">
    ///     <item>google.api.field.seperator - 
    ///         the charector seperating fields - currently '|'
    ///     </item>
    ///     <item>google.api.api.seperator - 
    ///         the charector seperating apis - currently '^'
    ///     </item>
    ///     <item> google.api.suggested.regex -
    ///         a regular expression to use to parse each api
    ///     </item>
    ///     <item> google.apis.all - 
    ///         the string which is all the apis e.g.
    ///         buzz|v1|Buzz|...^discovery|v1|Discovery|...^customserach|V3.4|CustomSearch|...
    ///     </item>
    ///  </list>
    ///  The fields return in each api are (inorder)
    ///  <list type="number">
    ///     <item>apiname</item>
    ///     <item>apiversion</item>
    ///     <item>apiclassname</item>
    ///     <item>apinamespace</item>
    ///     <item>apititle</item>
    ///     <item>apidescription</item>
    ///     <item>apidocumentationlink</item>
    ///     <item>apiicon32url</item>
    ///  </list>
    /// </summary>
    [TaskName("googleapidiscover")]
    public class GoogleApiDiscover : Task
    {
        private const char FieldSeperator = '|';
        private const char ApiSeperator = '^';
        private readonly static char[] InvalidChars = new char[] { FieldSeperator, ApiSeperator };

        // Any char which is not FieldSeperator, zero or more times
        private readonly static string FieldMatcher = "[^" + FieldSeperator + "]*";
        private readonly static string SuggestedRegex =
            "(?'apiname'" + FieldMatcher + ")\\|" +
            "(?'apiversion'" + FieldMatcher + ")\\|" +
            "(?'apiclassname'" + FieldMatcher + ")\\|" +
            "(?'apinamespace'" + FieldMatcher + ")\\|" +
            "(?'apititle'" + FieldMatcher + ")\\|" +
            "(?'apidescription'" + FieldMatcher + ")\\|" +
            "(?'apidocumentationlink'" + FieldMatcher + ")\\|" +
            "(?'apiicon32url'" + FieldMatcher + ")";
        private static readonly string ApiFormatString = string.Join(FieldSeperator.ToString(),
            new[] { "{0}", "{1}", "{2}", "{3}", "{4}", "{5}", "{6}", "{7}"});

        private string property = "google.apis.all";

        [TaskAttribute("property", Required = false)]
        [StringValidator(AllowEmpty = false)]
        public string Property
        {
            get { return property; }
            set { property = value; }
        }
         
        protected override void ExecuteTask()
        {
            Properties["google.api.field.seperator"] = FieldSeperator.ToString();
            Properties["google.api.api.seperator"] = ApiSeperator.ToString();
            Properties["google.api.suggested.regex"] = SuggestedRegex;

            var discovery = new DiscoveryService();
            DirectoryList apis = discovery.Apis.List(null, null, true);
            string[] apiStrings = new string[apis.Items.Count];
            int apiNumber = 0;
            foreach (DirectoryList.ItemsData item in apis.Items)
            {
                apiStrings[apiNumber] =string.Format(ApiFormatString, 
                    GetName(item), GetVersion(item), 
                    GetClassName(item), GetNamespace(item),
                    GetTitle(item), GetDescription(item), GetDocumentationLink(item),
                    GetIcon32Url(item));
                Project.Log(Level.Info, "Adding Service " + apiStrings[apiNumber]);
                apiNumber++;
            }
            Properties[Property] = string.Join(ApiSeperator.ToString(), apiStrings);
        }

        private string GetNamespace(DirectoryList.ItemsData item)
        {
            return GeneratorUtils.UpperFirstLetter(item.Version).Replace('.', '_');
        }

        private string GetClassName(DirectoryList.ItemsData item)
        {
            return GeneratorUtils.UpperFirstLetter(item.Name);
        }

        private string GetVersion(DirectoryList.ItemsData item)
        {
            return item.Version;
        }

        private string GetName(DirectoryList.ItemsData item)
        {
            return item.Name;
        }

        private string GetTitle(DirectoryList.ItemsData item)
        {
            return item.Title.IsNotNullOrEmpty() ? MakeSafe(item.Title) : GetName(item);
        }

        private string GetDescription(DirectoryList.ItemsData item)
        {
            return item.Description.IsNotNullOrEmpty() ? 
                MakeSafe(item.Description): 
                item.Id;
        }

        private string GetDocumentationLink(DirectoryList.ItemsData item)
        {
            return item.DocumentationLink ?? "";
        }

        private string GetIcon32Url(DirectoryList.ItemsData item)
        {
            if (item.Icons == null)
            {
                return "";
            }
            return item.Icons.X32 ?? "";
        }

        private string MakeSafe(string str)
        {
            if (str.IsNullOrEmpty())
            {
                return str;
            }
            return str.Replace("_", InvalidChars);
        }
    }
}
