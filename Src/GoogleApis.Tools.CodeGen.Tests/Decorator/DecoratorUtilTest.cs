using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Apis.Tools.CodeGen.Decorator;
using NUnit.Framework;

namespace Google.Apis.Tools.CodeGen.Tests.Decorator
{
    /// <summary>
    /// Tests the DecoratorUtil class
    /// </summary>
    [TestFixture]
    public class DecoratorUtilTest
    {
        [Test]
        public void AddAutoPropertyEdgeCaseTest()
        {
            var typeDeclaration = new CodeTypeDeclaration();
            const string name = "TestProperty";
            const string comment = "Comment";

            Assert.Throws<ArgumentNullException>(() => DecoratorUtil.AddAutoProperty<object>(null, name, comment));
            Assert.Throws<ArgumentNullException>(() => DecoratorUtil.AddAutoProperty<object>(typeDeclaration, null, comment));
            Assert.Throws<ArgumentException>(() => DecoratorUtil.AddAutoProperty<object>(typeDeclaration, "", comment));
            Assert.DoesNotThrow(() => DecoratorUtil.AddAutoProperty<object>(typeDeclaration, name, null));
        }

        [Test]
        public void AddAutoPropertyTest()
        {
            var typeDeclaration = new CodeTypeDeclaration();
            const string name = "TestProperty";
            const string comment = "Comment";

            CodeMemberProperty property = DecoratorUtil.AddAutoProperty<int>(typeDeclaration, name, comment);
            Assert.IsNotNull(property);
            Assert.That(property.Name, Is.EqualTo(name));
            Assert.That(property.Type.BaseType, Is.EqualTo(typeof(int).FullName));
            
            Assert.That(typeDeclaration.Members.Count, Is.EqualTo(2));
            Assert.That(typeDeclaration.Members[1], Is.InstanceOf<CodeMemberProperty>());
            Assert.That(typeDeclaration.Members[0], Is.InstanceOf<CodeMemberField>());
           
            // Backening field is tested in its own unit case

            // Test if an exception is thrown when the name is already used
            Assert.Throws<ArgumentException>(() => DecoratorUtil.AddAutoProperty<bool>(typeDeclaration, name, comment));
        }

        [Test]
        public void CreateBackeningFieldEdgeCaseTest()
        {
            var typeDeclaration = new CodeTypeDeclaration();
            const string name = "TestProperty";

            Assert.Throws<ArgumentNullException>(() => DecoratorUtil.CreateBackeningField<object>(null, name));
            Assert.Throws<ArgumentNullException>(() => DecoratorUtil.CreateBackeningField<object>(typeDeclaration, null));
            Assert.Throws<ArgumentException>(() => DecoratorUtil.CreateBackeningField<object>(typeDeclaration, ""));
        }

        [Test]
        public void CreateBackeningFieldTest()
        {
            var typeDeclaration = new CodeTypeDeclaration();
            const string name = "TestProperty";

            CodeMemberField field = DecoratorUtil.CreateBackeningField<bool>(typeDeclaration, name);
            Assert.IsNotNull(field);
            Assert.That(field.Name, Is.EqualTo("testProperty"));
            Assert.That(field.Type.BaseType, Is.EqualTo(typeof(bool).FullName));
        }
    }
}
