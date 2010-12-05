using System;
using System.CodeDom;
using System.Collections.Generic;

using Google.Apis.Discovery;
using Google.Apis.Testing;

namespace Google.Apis.Tools.CodeGen.Decorator.ResourceDecorator
{
    public class StandardServiceFieldResourceDecorator: IResourceDecorator
    {
        public void DecorateClass (Resource resource, string className, CodeTypeDeclaration resourceClass, ResourceClassGenerator generator, string serviceClassName, IEnumerable<IResourceDecorator> allDecorators)
        {
            resourceClass.Members.Add (CreateServiceField());
        }

        public void DecorateMethodBeforeExecute (Resource resource, Method method, CodeMemberMethod codeMember)
        {
            // NoOp
        }

        public void DecorateMethodAfterExecute (Resource resource, Method method, CodeMemberMethod codeMember)
        {
            // NoOp
        }
        
         /// <summary>
        /// Adds <code>private BuzzService service;</code> to the resource class.
        /// </summary>
        [VisibleForTestOnly]
        internal CodeMemberField CreateServiceField ()
        {
            var serviceField = new CodeMemberField (typeof(IRequestExecutor), ResourceBaseGenerator.ServiceFieldName);
            serviceField.Attributes = MemberAttributes.Final | MemberAttributes.Private;
            
            return serviceField;
        }
    }
}

