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
using System.Collections.Generic;
using Google.Apis.Discovery;
using Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator;

namespace Google.Apis.Tools.CodeGen {


	public class ResourceClassGenerator: ResourceBaseGenerator{					
		private readonly Resource resource; 
		private readonly String serviceClassName; 
		private readonly int resourceNumber;
		private readonly IEnumerable<IResourceDecorator> decorators;
		private readonly String className;

		public ResourceClassGenerator(Resource resource, String serviceClassName, int resourceNumber, 
		                              IEnumerable<IResourceDecorator> decorators) {
			this.resource = resource;
			this.serviceClassName = serviceClassName;
			this.resourceNumber = resourceNumber;
			this.decorators = decorators;
			this.className = GetClassName(resource, this.resourceNumber);
		}
		
		/// <summary>
		/// Create the class for a given resource and add all the methods.
		/// </summary>
		/// <param name="res">
		/// A <see cref="Resource"/>
		/// </param>
		/// <returns>
		/// A <see cref="CodeTypeDeclaration"/>
		/// </returns>
		public CodeTypeDeclaration CreateClass() {
			var resourceClass = new CodeTypeDeclaration(this.className);			
			
			AddServiceField(resourceClass);
			AddResourceNameConst(resourceClass, resource.Name);
			
			foreach(IResourceDecorator decorator in this.decorators){
				decorator.DecorateClass(this.resource, className, resourceClass, this,this.serviceClassName, this.decorators);
			}
					
			return resourceClass;
		}
		
		/// <summary>
		/// Adds <code>private BuzzService service;</code> to the resource class.
		/// </summary>
		internal static void AddServiceField(CodeTypeDeclaration resourceClass){
			var serviceField = new CodeMemberField(typeof(IRequestExecutor),ServiceFieldName);				
			serviceField.Attributes = MemberAttributes.Final | MemberAttributes.Private;
			resourceClass.Members.Add(serviceField);
		}
		
		/// <summary>
		/// Adds <code>private const string RESOURCE = "activities";</code> to the resource class
		/// </summary>
		internal static void AddResourceNameConst(CodeTypeDeclaration resourceClass, string resourceName){
			var serviceField = new CodeMemberField(typeof(string),ResourceNameConst);				
			serviceField.Attributes = MemberAttributes.Const | MemberAttributes.Private;
			serviceField.InitExpression = new CodePrimitiveExpression(resourceName);
			
			resourceClass.Members.Add(serviceField);
		}
		
		protected override string GetClassName ()
		{
			return className;
		}
	}
}
