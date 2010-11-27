using System;
namespace Google.Apis.Tools.CodeGen.Tests
{
	public abstract class BaseResourceDecoratorTest
	{
		protected const string SERVICE_CLASS_NAME = "Google.Apis.Tools.CodeGen.Tests.TestServiceClass";
		protected const string RESOURCE_CLASS_NAME = "Google.Apis.Tools.CodeGen.Tests.TestResourceClass";
		protected const string RESOURCE_NAME = "TestResource";
		
		protected KeyValuePair<string, object> CreateJsonResourceDefinition(){
			JSON.JSONDictionary json = new JSON.JSONDictionary();
			
			return new KeyValuePair<string, object>(RESOURCE_NAME,json);
		}
	}
}