using System;
using NUnit.Framework;
namespace Google.Apis.Tests
{
	[TestFixture()]
	public class APITest
	{
		[Test()]
		public void Constructor ()
		{
			var api = new APIDocument();
			
			Assert.IsInstanceOfType(typeof(APIDocument), api);
			Assert.AreEqual(0, api.Methods.Count);
		}
		
		[Test()]
		public void NameTest ()
		{
			var api = new APIDocument();
			api.Name = "test";
			
			Assert.AreEqual("test", api.Name);
		}
		
		[Test()]
		public void AddMethod () {
			var api = new APIDocument();
			var method = new Method();
			api.AddMethod(method);
			
			Assert.AreEqual(1, api.Methods.Count);
			Assert.AreEqual(api.Methods[0], method);
		}
		
		
		[Test()]
		public void CreateRequest () {
			var api = new APIDocument();
			
			Assert.AreEqual("", api.CreateRequest(null));
		}
	}
}

