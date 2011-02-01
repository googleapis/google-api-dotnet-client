using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

using Google.Apis.Discovery;
using Google.Apis.Discovery.Schema;
using Google.Apis.Tools.CodeGen.Decorator.SchemaDecorator;
using Google.Apis.Tools.CodeGen.Generator;
using Google.Apis.Util;

namespace Google.Apis.Tools.CodeGen
{
    /// <summary>
    /// For a given service, creates a namespace and generates a class for each schema defined in that service.
    /// Using the ISchemaDecorators provided.  
    /// </summary>
    public class GoogleSchemaGenerator
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger (typeof(GoogleSchemaGenerator));
        
        public readonly IEnumerable<ISchemaDecorator> DeafultSchemaDecorators = (new List<ISchemaDecorator>(){}).AsReadOnly();
        private readonly IList<ISchemaDecorator> decorators;
        private readonly string schemaNamespace;
        
        public GoogleSchemaGenerator (IEnumerable<ISchemaDecorator> decorators, string schemaNamespace)
        {
            decorators.ThrowIfNull("decorators");
            schemaNamespace.ThrowIfNull("schemaNamespace");
            this.decorators = new List<ISchemaDecorator>(decorators).AsReadOnly();
            this.schemaNamespace = schemaNamespace;
        }
        
        public CodeNamespace GenerateSchemaClasses(IService service)
        {
            service.ThrowIfNull("service");
            
            logger.DebugFormat("Starting to generate schemas for {1} in namespace {0}", schemaNamespace, service.Name);
            LogDecorators();
            var codeNamespace = new CodeNamespace(schemaNamespace);
            SchemaGenerator generator = new SchemaGenerator(decorators);
            foreach(var schemaPair in service.Schemas)
            {
                logger.DebugFormat("Generating Schema {0}", schemaPair.Key);
                codeNamespace.Types.Add(generator.CreateClass(schemaPair.Value));
            }
            return codeNamespace;
        }
        
        private void LogDecorators()
        {
            if(logger.IsDebugEnabled == false)
            {
                return;
            }
            logger.Debug("With descorators:");
            if(decorators.Any() == false)
            {
                logger.Debug(">>>NO DECORATORS");
            }
                
            foreach(var decorator in decorators)
            {
                logger.DebugFormat(">>>{0} [{1}]", decorator.ToString(), decorator.GetType().FullName);
            }
        }
    }
}

