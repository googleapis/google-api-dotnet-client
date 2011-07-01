
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
using Google.Apis;
using Google.Apis.Discovery;


using Google.Apis.Samples.CommandLine.Views;
using Google.Apis.Samples.CommandLine.Controllers;

namespace Google.Apis.Samples.CommandLine.Controllers
{
	public class ResourceController {
		
		private IService _service {get;set;}
		private ResourceView _view {get;set;}
		private IResource _resource {get;set;}
		
		public ResourceController(IService service, IResource resource, ResourceView view) {
			_service = service;
			_view = view;
			_resource = resource;
		}
		
		public void Run() {
			while(GetMethodSelection()) {}	
		}
		
		public bool GetMethodSelection() {
			Console.Out.Write("{0} > ", _resource.Name);
			string command = Console.In.ReadLine();
			
			if(command.StartsWith("cd ")) 
			{
				// get the service.
				var methodName = command.Substring(command.IndexOf(" ") + 1);
				
				if(methodName == "..") {
					return false;
				}
				
				if(_resource.Methods.ContainsKey(methodName)) {
					var method = _resource.Methods[methodName];
				
					// get the service.
					MethodView view = new MethodView();
					MethodController controller = new MethodController(_service, _resource, method, view);
					controller.Run();
				}
			}
			else if (command == "ls") {
				_view.Render(_resource);
			}
			else {
				Console.Out.WriteLine();	
			}
			
			return true;
		}
	}
}
