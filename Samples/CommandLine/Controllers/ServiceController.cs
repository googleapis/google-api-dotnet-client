
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
	public class ServiceController {
	
		private IService _service {get;set;}
		private ServiceView _view {get;set;}
		
		public ServiceController(IService service, ServiceView view) {
			_service = service;
			_view = view;
		}
		
		public void Run() {
			while(GetResourceSelection()) {}	
		}
		
		public bool GetResourceSelection() {
			
			Console.Out.Write("> ");
			string command = Console.In.ReadLine();
			
			if(command.StartsWith("cd ")) {
				var resourceName = command.Substring(command.IndexOf(" ") + 1);
				
				if(resourceName == "..") {
					return false;
				}
			
				if(_service.Resources.ContainsKey(resourceName)) {
					var method = _service.Resources[resourceName];
					
					// get the service.
					ResourceView view = new ResourceView();
					ResourceController controller = new ResourceController(_service, method, view);
					controller.Run();
				}
			}
			else if (command == "ls") {
				_view.Render(_service);
			}
			else if(command == "exit") {
				return false;
			}
			else {	
				Console.Out.WriteLine();
			}
			
			return true;
		}
	}
}
