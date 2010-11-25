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
using System.CodeDom;
using Google.Apis.Discovery;
namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator {
	public class VersionInformationServiceDecorator: IServiceDecorator{
		public const string VERSION_NAME = "VERSION";
		public const string NAME_NAME = "NAME";
		public const string BASE_URI_NAME = "BASE_URI";
		
		public void DecorateClass (Google.Apis.Discovery.IService service, System.CodeDom.CodeTypeDeclaration serviceClass)
		{
			AddInformationFields(serviceClass, service);
		}
		
		private void AddInformationFields(CodeTypeDeclaration serviceClass, IService service){
			AddVersionField(service, serviceClass);
			AddNameField(service, serviceClass);			
			AddUriField(service, serviceClass);
		}
		
		private void AddVersionField(IService service, CodeTypeDeclaration serviceClass) {
			var version = new CodeMemberField(typeof(string), VERSION_NAME);
			version.Attributes = MemberAttributes.Const | MemberAttributes.Private;
			version.InitExpression = new CodePrimitiveExpression(service.Version);
			serviceClass.Members.Add(version);
		}
		
		private void AddNameField(IService service, CodeTypeDeclaration serviceClass) {
			var name = new CodeMemberField(typeof(string),NAME_NAME);
			name.Attributes = MemberAttributes.Const | MemberAttributes.Private;
			name.InitExpression = new CodePrimitiveExpression(service.Name);
			serviceClass.Members.Add(name);
		}
		
		private void AddUriField(IService service, CodeTypeDeclaration serviceClass) {
			var uri = new CodeMemberField(typeof(string),BASE_URI_NAME);
			uri.Attributes = MemberAttributes.Const | MemberAttributes.Private;
			uri.InitExpression = new CodePrimitiveExpression(service.BaseUri.ToString());
			serviceClass.Members.Add(uri);			
		}
	}
}

