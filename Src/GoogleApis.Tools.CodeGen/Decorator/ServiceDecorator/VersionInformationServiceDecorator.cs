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
using Google.Apis.Testing;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator {
	
	/// <summary>
	/// Adds private constants Version (VersionName), Name (NameName) and BaseUri (BaseUriName) 
	/// To the ServiceClass.
	/// </summary>
	public class VersionInformationServiceDecorator: IServiceDecorator{
		public const string VersionName = "Version";
		public const string NameName = "Name";
		public const string BaseUriName = "BaseUri";
		
		public void DecorateClass (Google.Apis.Discovery.IService service, System.CodeDom.CodeTypeDeclaration serviceClass)
		{
			serviceClass.Members.Add(CreateVersionField(service));
			serviceClass.Members.Add(CreateNameField(service));			
			serviceClass.Members.Add(CreateUriField(service));
		}
		
		[VisibleForTestOnly]
		internal CodeMemberField CreateVersionField(IService service) {
			var version = new CodeMemberField(typeof(string), VersionName);
			version.Attributes = MemberAttributes.Const | MemberAttributes.Private;
			version.InitExpression = new CodePrimitiveExpression(service.Version);
			return version;
		}
		
		[VisibleForTestOnly]
		internal CodeMemberField CreateNameField(IService service) {
			var name = new CodeMemberField(typeof(string),NameName);
			name.Attributes = MemberAttributes.Const | MemberAttributes.Private;
			name.InitExpression = new CodePrimitiveExpression(service.Name);
			return name;
		}
		
		[VisibleForTestOnly]
		internal CodeMemberField CreateUriField(IService service) {
			var uri = new CodeMemberField(typeof(string),BaseUriName);
			uri.Attributes = MemberAttributes.Const | MemberAttributes.Private;
			uri.InitExpression = new CodePrimitiveExpression(service.BaseUri.ToString());
			return uri;			
		}
	}
}

