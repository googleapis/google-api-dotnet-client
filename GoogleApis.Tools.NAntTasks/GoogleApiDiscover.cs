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
using Google.Apis.Authentication;
using Google.Apis.Discovery;
using Google.Apis.Discovery.v1.Data;
using Google.Apis.Tools.CodeGen;
using Google.Apis.Util;
using NAnt.Core;
using NAnt.Core.Attributes;

using DiscoveryService = Google.Apis.Discovery.v1.DiscoveryService;

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
    ///     <item>google.api.field.separator - 
    ///         the character seperating fields - currently '|'
    ///     </item>
    ///     <item>google.api.api.separator - 
    ///         the character seperating apis - currently '^'
    ///     </item>
    ///     <item> google.api.suggested.regex -
    ///         a regular expression to use to parse each api
    ///     </item>
    ///     <item> google.api.all - 
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
    [TaskName("google-api-discover")]
    public class GoogleApiDiscover : Task
    {
        private const char FieldSeparator = '|';
        private const char ApiSeparator = '^';
        private readonly static char[] InvalidChars = new char[] { FieldSeparator, ApiSeparator };

        // Any char which is not FieldSeparator, zero or more times
        private readonly static string FieldMatcher = "[^" + FieldSeparator + "]*";
        private readonly static string SuggestedRegex =
            "(?'apiname'" + FieldMatcher + ")\\|" +
            "(?'apiversion'" + FieldMatcher + ")\\|" +
            "(?'apiclassname'" + FieldMatcher + ")\\|" +
            "(?'apinamespace'" + FieldMatcher + ")\\|" +
            "(?'apititle'" + FieldMatcher + ")\\|" +
            "(?'apidescription'" + FieldMatcher + ")\\|" +
            "(?'apidocumentationlink'" + FieldMatcher + ")\\|" +
            "(?'apiicon32url'" + FieldMatcher + ")";
        private static readonly string ApiFormatString = string.Join(FieldSeparator.ToString(),
            new[] { "{0}", "{1}", "{2}", "{3}", "{4}", "{5}", "{6}", "{7}"});

        private string property = "google.api.all";

        /// <summary> 
        ///   The name of the NAnt property we will write the list of GoogleApis to. 
        /// </summary>
        [TaskAttribute("property", Required = false)]
        [StringValidator(AllowEmpty = false)]
        public string Property
        {
            get { return property; }
            set { property = value; }
        }

        protected override void ExecuteTask()
        {
            Properties["google.api.field.separator"] = FieldSeparator.ToString();
            Properties["google.api.api.separator"] = ApiSeparator.ToString();
            Properties["google.api.suggested.regex"] = SuggestedRegex;

            var auth = new DelegateAuthenticator(request => request.Headers["X-User-IP"] = "0.0.0.0");
            var discovery = new DiscoveryService(auth);
           
            DirectoryList apis = discovery.Apis.List().Fetch();
            string[] apiStrings = new string[apis.Items.Count];
            int apiNumber = 0;
            foreach (DirectoryList.ItemsData item in apis.Items)
            {
                apiStrings[apiNumber] = string.Format(ApiFormatString, 
                    GetName(item), GetVersion(item), 
                    GetClassName(item), GetNamespace(item),
                    GetTitle(item), GetDescription(item), GetDocumentationLink(item),
                    GetIcon32Url(item));
                Project.Log(Level.Info, "Adding Service " + apiStrings[apiNumber]);
                apiNumber++;
            }
            Properties[Property] = string.Join(ApiSeparator.ToString(), apiStrings);
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
            return string.Format("Googles {0} service client api. {1}", 
                GetName(item), MakeSafe(item.Description));
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
                return "";
            }
            return str.Replace("_", InvalidChars);
        }
    }
}
