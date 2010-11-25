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
using Google.Apis.Authentication;
using Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator;

namespace Google.Apis.Tools.CodeGen {


	public class ServiceClassGenerator:BaseGenerator {
		private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(ServiceClassGenerator));
		
		public const string GENERIC_SERVICE_NAME = "genericService";
		private const string AUTHENTICATOR_NAME = "authenticator";
		
		private readonly IEnumerable<IServiceDecorator> decorators;
		private readonly IService service;

		public ServiceClassGenerator(IService service, IEnumerable<IServiceDecorator> decorators) {
			this.decorators = decorators;
			this.service = service;
		}
		
		public CodeTypeDeclaration CreateServiceClass(){
			string serviceClassName = UpperFirstLetter(service.Name) + "Service";
			Logger.DebugFormat("Starting Generation of Class {0}", serviceClassName);
			var serviceClass = new CodeTypeDeclaration(serviceClassName);
			var baseConstructor = CreateConstructorWithArgs();
			
			AddServiceFields(serviceClass);
			
			int resourceNumber = 1;
			foreach(var pair in service.Resources){
				Resource resource = pair.Value;
				AddResourceGetter(serviceClass, resource, resourceNumber);				
				AddResourceField(serviceClass, resource, resourceNumber);
				AddResourceAssignment(baseConstructor, resource, resourceNumber);
				resourceNumber++;
			}
			
			serviceClass.Members.Add(baseConstructor);
			
			foreach(IServiceDecorator serviceDecorator in decorators){
				serviceDecorator.DecorateClass(service, serviceClass);
			}
			
			return serviceClass;					
		}
		
		private CodeConstructor CreateConstructorWithArgs(){
			var constructor = new CodeConstructor();
			constructor.Attributes = MemberAttributes.Public;
			constructor.Parameters.Add(new CodeParameterDeclarationExpression(typeof(IService),GENERIC_SERVICE_NAME));
			constructor.Parameters.Add(new CodeParameterDeclarationExpression(typeof(IAuthenticator),AUTHENTICATOR_NAME));
			
			
			{
				var assignService = new CodeAssignStatement();
				assignService.Left = new CodeFieldReferenceExpression(
					new CodeThisReferenceExpression(),
				    GENERIC_SERVICE_NAME);			
				assignService.Right = new CodeVariableReferenceExpression(GENERIC_SERVICE_NAME);
				
				constructor.Statements.Add(assignService);
			}
			
			{
				var assignAuthenticator = new CodeAssignStatement();
				assignAuthenticator.Left = new CodeFieldReferenceExpression(
					new CodeThisReferenceExpression(),
				    AUTHENTICATOR_NAME);			
				assignAuthenticator.Right = new CodeVariableReferenceExpression(AUTHENTICATOR_NAME);
				
				constructor.Statements.Add(assignAuthenticator); 
			}
			
			
			return constructor;
		}

		
		/// <summary>
		/// Declars the fields genericService and authenticator
		/// <code>
		/// 	private Google.Apis.Discovery.IService genericService;
		///     private Google.Apis.Authentication.IAuthenticator authenticator;
		/// </code>
		/// </summary>
		/// <param name="serviceClass">
		/// </param>
		private void AddServiceFields(CodeTypeDeclaration serviceClass){
			var field = new CodeMemberField(typeof(IService),GENERIC_SERVICE_NAME);				
			field.Attributes = MemberAttributes.Final | MemberAttributes.Private;
			serviceClass.Members.Add(field);			
			
			field = new CodeMemberField(typeof(IAuthenticator),AUTHENTICATOR_NAME);				
			field.Attributes = MemberAttributes.Final | MemberAttributes.Private;
			serviceClass.Members.Add(field);
		}
		
		
		private void AddResourceField(CodeTypeDeclaration serviceClass,
		                               Resource resource, int resourceNumber){
			// Add local private variables for each Resource
			var field = new CodeMemberField(
				GetClassName(resource,resourceNumber),GetFieldName(resource, resourceNumber));				
			field.Attributes = MemberAttributes.Final | MemberAttributes.Private;
			serviceClass.Members.Add(field);
		}
		
		private void AddResourceGetter(CodeTypeDeclaration serviceClass, 
		                              Resource resource, int resourceNumber){
			var getter = new CodeMemberProperty();
			getter.Name = GetClassName(resource,resourceNumber);
			getter.HasGet = true;
			getter.HasSet = false;
			getter.Attributes = MemberAttributes.Public;
			getter.Type = new CodeTypeReference(GetClassName(resource, resourceNumber));
			getter.GetStatements.Add(
			     new CodeMethodReturnStatement(GetFieldReference(resource, resourceNumber)));
			
			serviceClass.Members.Add(getter);
		}
		
		private CodeExpression GetFieldReference(Resource resource, int resourceNumber){
			return new CodeFieldReferenceExpression(
			     	new CodeThisReferenceExpression(),
			        GetFieldName(resource, resourceNumber));
		}
		
		
		private void AddResourceAssignment(
		                                   CodeConstructor constructor, 
		                                   Resource resource, 
		                                   int resourceNumber){
			constructor.Statements.Add(
				new CodeAssignStatement(GetFieldReference(resource, resourceNumber),
			        new CodeObjectCreateExpression(
			        	GetClassName(resource, resourceNumber), 
			            new CodeThisReferenceExpression())                                           
			        ));
		}
		
	}
}
