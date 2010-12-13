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
using Google.Apis;
using Google.Apis.Discovery;


using Google.Apis.Samples.CommandLine.Views;
using Google.Apis.Samples.CommandLine.Controllers;

namespace Google.Apis.Samples.CommandLine.Views
{
	public class MethodView {
		public void Render(Method method) {
			foreach(var parameter in method.Parameters.Values) {
				if(parameter.Required) {
					Console.Out.Write("*");
				}
				
				Console.Out.WriteLine("{0}", parameter.Name);
			}
		}
		
		public void AskForCredentials(Uri url, Dictionary<string, string> extra) {
			var qs = Utilities.DictionaryToQueryString(extra);
			Console.Out.WriteLine("Please visit {0}", url.ToString() + "&" + qs );
			Console.Out.Write("> ", url.ToString());
		}
		
		public void AskForParameter(Parameter p) {
			
			Console.Out.Write("{0} [{1}] > ", p.Name, p.Pattern);
		}
		
		public void AskForBody() {
			Console.Out.Write("Body > ");
		}
	}
}
