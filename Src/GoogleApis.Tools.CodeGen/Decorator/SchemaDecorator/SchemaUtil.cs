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

using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    /// <summary>
    /// Utility class for schemas
    /// </summary>
    public static class SchemaUtil
    {
        /// <summary>
        /// Finds a property by the name specified within the schema
        /// </summary>
        internal static CodeMemberProperty FindCodePropertyForName(CodeTypeDeclaration typeDeclaration,
                                                                   string name,
                                                                   int index,
                                                                   IEnumerable<string> otherNames)
        {
            IEnumerable<string> illegalWords = otherNames.Concat(new[] { typeDeclaration.Name });
            string propertyName = GeneratorUtils.GetPropertyName(name, illegalWords);
            
            CodeMemberProperty property = typeDeclaration.Members.FindPropertyByName(propertyName);
            property.ThrowIfNull(
                string.Format("Failed to find property by name[{0}] for propertySchemaName[{1}]", propertyName, name));
            return property;
        }
    }
}