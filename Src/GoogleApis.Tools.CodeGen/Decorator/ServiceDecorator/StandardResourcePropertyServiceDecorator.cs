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
using System;
using System.CodeDom;

using Google.Apis.Discovery;
using Google.Apis.Testing;

namespace Google.Apis.Tools.CodeGen.Decorator.ServiceDecorator
{
    /// <summary>
    /// Foreach resource that is part of this service this decorator will add a field
    /// and a property getter. e.g.
    ///     <code>
    ///         private Activities activities;
    ///         private Comments comments;
    ///         public virtual Activities Activities {get {return this.activities;}}
    ///         public virtual Comments Comments {get {return this.comments;}}
    ///     </code> 
    /// </summary>
    public class StandardResourcePropertyServiceDecorator : BaseGenerator, IServiceDecorator
    {
        public void DecorateClass (IService service, CodeTypeDeclaration serviceClass)
        {
            int resourceNumber = 1;
            foreach (var pair in service.Resources)
            {
                Resource resource = pair.Value;
                serviceClass.Members.Add(CreateResourceGetter (resource, resourceNumber));
                serviceClass.Members.Add(CreateResourceField (resource, resourceNumber));
                resourceNumber++;
            }
        }
        
        [VisibleForTestOnly]        
        internal CodeMemberField CreateResourceField (Resource resource, int resourceNumber)
        {
            // Add local private variables for each Resource
            var field = new CodeMemberField (GetClassName (resource, resourceNumber), GetFieldName (resource, resourceNumber));
            field.Attributes = MemberAttributes.Final | MemberAttributes.Private;
            return field;
        }
  
        [VisibleForTestOnly]
        internal CodeMemberProperty CreateResourceGetter (Resource resource, int resourceNumber)
        {
            var getter = new CodeMemberProperty ();
            getter.Name = GetClassName (resource, resourceNumber);
            getter.HasGet = true;
            getter.HasSet = false;
            getter.Attributes = MemberAttributes.Public;
            getter.Type = new CodeTypeReference (GetClassName (resource, resourceNumber));
            getter.GetStatements.Add (
                new CodeMethodReturnStatement (
                    ServiceClassGenerator.GetFieldReference (resource, resourceNumber)));
            
            return getter;
        }
        
        public override string ToString ()
        {
            return this.GetType().Name;
        }
    }
}
