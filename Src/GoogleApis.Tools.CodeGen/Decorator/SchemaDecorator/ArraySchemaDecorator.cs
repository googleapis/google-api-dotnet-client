using System.CodeDom;

using Newtonsoft.Json.Schema;

using Google.Apis.Discovery.Schema;
using Google.Apis.Util;


namespace Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator
{
    /// <summary>
    /// Decorator for schemes which represent an array themself (type: array)
    /// This Decorator constructs an IList implementation for the scheme
    /// </summary>
    public class ArraySchemaDecorator : ISchemaDecorator
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(ArraySchemaDecorator));

        public void DecorateClass(CodeTypeDeclaration typeDeclaration, ISchema schema, 
                                  INestedClassProvider internalClassProvider)
        {
            typeDeclaration.ThrowIfNull("typeDeclaration");
            schema.ThrowIfNull("schema");
            internalClassProvider.ThrowIfNull("internalClassProvider");

            JsonSchema details = schema.SchemaDetails;
            details.ThrowIfNull("schemaDetails");

            // Check if this decorator can be applied to the schema);
            if (details.Type != JsonSchemaType.Array)
                return;

            if (details.Items == null || details.Items.Count != 1)
            {
                logger.WarnFormat("Found array scheme of unhandled type. {0}", details);
                return; //not supported
            }

            // Generate or find the nested type
            var itemScheme = details.Items[0];
            CodeTypeReference item = SchemaDecoratorUtil.GetCodeType(itemScheme, internalClassProvider);

            // Change the current type to a List
            typeDeclaration.BaseTypes.Add("List<" + typeDeclaration.Name + "." + item.BaseType + ">");
        }
    }
}
