// /*
// Copyright 2010 Google Inc
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json.Schema;

using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Discovery.Schema
{
    public class FutureJsonSchemaResolver: JsonSchemaResolver
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger (typeof(FutureJsonSchemaResolver));
        
        public FutureJsonSchemaResolver () : base()
        {
            this.LoadedSchemas = new FutureAwearList(this.LoadedSchemas);
        }
        
        public override JsonSchema GetSchema (string id)
        {
            JsonSchema alreadyPresent = LoadedSchemas.FirstOrDefault(js => js.Id == id);
            if ( alreadyPresent != null ) 
            {
                return alreadyPresent;
            }
            
            var future = new FutureJsonSchema(id);
            this.LoadedSchemas.Add(future);
            return future;
        }
        
        public void ResolveAndVerify()
        {
            
            var unresolved = from schmea in this.LoadedSchemas
                where schmea is FutureJsonSchema && ((FutureJsonSchema)schmea).Resolved == false
                    select schmea as FutureJsonSchema;

            foreach (var futureSchema in unresolved)
            {
                var actual = (from schmea in this.LoadedSchemas
                             where schmea.Id == futureSchema.Id &&
                                    ( schmea is FutureJsonSchema == false ||
                                      ((FutureJsonSchema)schmea).Resolved)
                             select schmea).FirstOrDefault();
                if (actual != null)
                {
                    futureSchema.Resolve(actual);
                    logger.Debug("Last minite resolving of " + futureSchema.Id);
                }
            }

            unresolved = from schmea in this.LoadedSchemas
                             where schmea is FutureJsonSchema && ((FutureJsonSchema)schmea).Resolved == false
                             select schmea as FutureJsonSchema;


            string errors = unresolved.Aggregate("", (s, x) => s += ", " + x.Id);
                
            if(errors.Length == 0) // no errors
            {
                return;
            }
            
            throw new ApplicationException("The following Schema ids where unresolved " + errors);
        }
        
        [VisibleForTestOnly]
        internal class FutureAwearList : IList<JsonSchema>
        {
            private readonly IList<JsonSchema> innerList;
            
            public FutureAwearList(IList<JsonSchema> innerList)
            {
                this.innerList = innerList;
            }
            
            #region IList<JsonSchema> implementation
            public int IndexOf (JsonSchema item)
            {
                return innerList.IndexOf(item);
            }
            
            
            public void Insert (int index, JsonSchema item)
            {
                innerList.Insert(index, item);
            }
            
            
            public void RemoveAt (int index)
            {
                innerList.RemoveAt(index);
            }
            
            
            public JsonSchema this[int index] {
                get {
                    return innerList[index];
                }
                set {
                    innerList[index] = value;
                }
            }
            
            #endregion
            
            
            #region IEnumerable implementation
            public System.Collections.IEnumerator GetEnumerator ()
            {
                return innerList.GetEnumerator();
            }
            
            #endregion
            #region IEnumerable<JsonSchema> implementation
            IEnumerator<JsonSchema> IEnumerable<JsonSchema>.GetEnumerator ()
            {
                return ((IEnumerable<JsonSchema>)innerList).GetEnumerator();
            }
            
            #endregion
            
            #region ICollection<JsonSchema> implementation
            public void Add (JsonSchema item)
            {
                item.ThrowIfNull("item");
                //TODO(davidwaters): remove console
                Console.WriteLine(string.Format("Adding [{0}] [{1}]",item.Id, item.ToString()));
                
                JsonSchema alreadyPresent = innerList.FirstOrDefault(js => js.Id == item.Id && item.Id != null && item.Id.Length > 0);
                
                // New simple entry just add
                if( alreadyPresent == null)
                {
                    innerList.Add(item);
                    return;
                } 
                
                // Double add of a schema (by id) 
                if (alreadyPresent is FutureJsonSchema == false)
                {
                    throw new InvalidOperationException("Inserted duplicate JsonSchema (with same Id). For Id " + item.Id);
                }
                
                // We have already required this schema, so we need to resolve the existing FutureJsonSchema
                ((FutureJsonSchema)alreadyPresent).Resolve(item);
            }
            
            
            public void Clear ()
            {
                innerList.Clear();
            }
            
            
            public bool Contains (JsonSchema item)
            {
                return innerList.Contains(item);
            }
            
            
            public void CopyTo (JsonSchema[] array, int arrayIndex)
            {
                innerList.CopyTo(array, arrayIndex);
            }
            
            
            public bool Remove (JsonSchema item)
            {
                return innerList.Remove(item);
            }
            
            
            public int Count {
                get {
                    return innerList.Count;
                }
            }
            
            
            public bool IsReadOnly {
                get {
                    return innerList.IsReadOnly;
                }
            }
            
            #endregion
           
        }
    }
}

