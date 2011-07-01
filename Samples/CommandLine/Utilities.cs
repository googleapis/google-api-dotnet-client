/*
Copyright 2010 Google Inc

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

namespace Google.Apis.Samples.CommandLine
{
	public static class Utilities
	{
		public static Dictionary<string, string> QueryStringToDictionary(string qs) {
			var results = new Dictionary<string, string>();
			
			var qsParam = qs.Split('&');
			
			foreach(var param in qsParam)
			{
				var info = param.Split('=');
				
				if(info.Length == 2) {
					results.Add(info[0], info[1]);
				}
			}
			
			return results;
		}
		
		public static string DictionaryToQueryString(Dictionary<string, string> qs) {
			var results = new List<string>();
			
			
			foreach(var param in qs){
				results.Add(param.Key + "=" + param.Value);
			}
			
			return String.Join("&", results.ToArray());
		}
	}
}

