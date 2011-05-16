using System;
using System.CodeDom;
using System.Collections.Generic;

using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    public class SchemaUtil
    {
        private SchemaUtil ()
        {
            throw new NotSupportedException("Don't construct");
        }
        
        static internal CodeMemberProperty FindCodePropertyForName(CodeTypeDeclaration typeDeclaration, string name, int index, 
            IEnumerable<string> otherNames)
        {
            string propertyName = SchemaDecoratorUtil.GetPropertyName(name, index, otherNames);
            CodeMemberProperty property = typeDeclaration.Members.FindPropertyByName(propertyName);
            property.ThrowIfNull(string.Format("Failed to find property by name[{0}] for propertySchemaName[{1}]", propertyName, name));
            return property;
        }
    }
}

