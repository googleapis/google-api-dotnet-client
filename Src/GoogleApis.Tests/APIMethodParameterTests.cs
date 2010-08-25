
using System;
using NUnit.Framework;
namespace Apiary.Tests
{
	[TestFixture()]
	public class APIMethodParameterTests
	{
		[Test()]
		public void Constructor ()
		{
			Assert.IsInstanceOfType(typeof(MethodParameter), new MethodParameter());
		}
		
		[Test()]
		public void Name ()
		{
			var method = new MethodParameter();
			method.Name = "test";
			Assert.AreEqual(method.Name, "test");
		}
	}
}
