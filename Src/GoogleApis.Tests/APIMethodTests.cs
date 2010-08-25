
using System;
using NUnit.Framework;
namespace Apiary.Tests
{
	[TestFixture()]
	public class APIMethodTests
	{
		[Test()]
		public void Constructor ()
		{
			var method = new Method();
			Assert.IsInstanceOfType(typeof(Method), method);
		}
		
		[Test()]
		public void Name ()
		{
			var method = new Method();
			method.Name = "test";
			Assert.AreEqual(method.Name, "test");
		}
		
		[Test()]
		public void PathUrl ()
		{
			var method = new Method();
			method.PathURL = "test";
			Assert.AreEqual(method.PathURL, "test");
		}
		
		[Test()]
		public void AddParameter ()
		{
			var method = new Method();
			var parameter = new MethodParameter();
			
		}
	}
}
