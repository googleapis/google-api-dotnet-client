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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Google.Apis.Logging;
using Newtonsoft.Json.Schema;
using Google.Apis.Testing;
using Google.Apis.Util;

namespace Google.Apis.Discovery.Schema
{
    /// <summary>
    /// Resolves FutureJsonSchemas
    /// </summary>
    public class FutureJsonSchemaResolver : JsonSchemaResolver
    {
        private static readonly ILogger logger = ApplicationContext.Logger.ForType<FutureJsonSchemaResolver>();

        public FutureJsonSchemaResolver()
        {
            LoadedSchemas = new FutureAwareList(LoadedSchemas);
        }

        public override JsonSchema GetSchema(string id)
        {
            JsonSchema alreadyPresent = LoadedSchemas.FirstOrDefault(js => js.Id == id);
            if (alreadyPresent != null)
            {
                return alreadyPresent;
            }

            var future = new FutureJsonSchema(id);
            LoadedSchemas.Add(future);
            return future;
        }

        /// <summary>
        /// Resolves the loaded schemas and throws an exception on unresolved schemas
        /// </summary>
        public void ResolveAndVerify()
        {
            var unresolved = from schema in LoadedSchemas
                             where schema is FutureJsonSchema && ((FutureJsonSchema) schema).Resolved == false
                             select schema as FutureJsonSchema;

            foreach (var futureSchema in unresolved)
            {
                var actual = (from schema in LoadedSchemas
                              where
                                  schema.Id == futureSchema.Id &&
                                  (schema is FutureJsonSchema == false || ((FutureJsonSchema) schema).Resolved)
                              select schema).FirstOrDefault();
                if (actual != null)
                {
                    futureSchema.Resolve(actual);
                    logger.Debug("Last minite resolving of " + futureSchema.Id);
                }
            }

            unresolved = from schema in LoadedSchemas
                         where schema is FutureJsonSchema && ((FutureJsonSchema) schema).Resolved == false
                         select schema as FutureJsonSchema;


            string errors = unresolved.Aggregate("", (s, x) => s + ", " + x.Id);

            if (errors.Length == 0) // no errors
            {
                return;
            }

            throw new InvalidOperationException("The following Schema ids where unresolved " + errors);
        }

        #region Nested type: FutureAwareList

        /// <summary>
        /// A list of (future) json schemas
        /// </summary>
        [VisibleForTestOnly]
        internal class FutureAwareList : IList<JsonSchema>
        {
            private readonly IList<JsonSchema> innerList;

            public FutureAwareList(IList<JsonSchema> innerList)
            {
                this.innerList = innerList;
            }

            #region IList<JsonSchema> implementation

            public int IndexOf(JsonSchema item)
            {
                return innerList.IndexOf(item);
            }


            public void Insert(int index, JsonSchema item)
            {
                innerList.Insert(index, item);
            }


            public void RemoveAt(int index)
            {
                innerList.RemoveAt(index);
            }


            public JsonSchema this[int index]
            {
                get { return innerList[index]; }
                set { innerList[index] = value; }
            }

            #endregion

            #region IEnumerable implementation

            public IEnumerator GetEnumerator()
            {
                return innerList.GetEnumerator();
            }

            #endregion

            #region IEnumerable<JsonSchema> implementation

            IEnumerator<JsonSchema> IEnumerable<JsonSchema>.GetEnumerator()
            {
                return innerList.GetEnumerator();
            }

            #endregion

            #region ICollection<JsonSchema> implementation

            public void Add(JsonSchema item)
            {
                item.ThrowIfNull("item");
                logger.Debug("Adding [{0}]", item.Id);

                JsonSchema alreadyPresent =
                    innerList.FirstOrDefault(js => js.Id == item.Id && string.IsNullOrEmpty(item.Id) == false);

                // New simple entry just add
                if (alreadyPresent == null)
                {
                    innerList.Add(item);
                    return;
                }

                // Double add of a schema (by id) 
                if (alreadyPresent is FutureJsonSchema == false)
                {
                    throw new InvalidOperationException(
                        "Inserted duplicate JsonSchema (with same Id). For Id " + item.Id);
                }

                // We have already required this schema, so we need to resolve the existing FutureJsonSchema
                ((FutureJsonSchema) alreadyPresent).Resolve(item);
            }


            public void Clear()
            {
                innerList.Clear();
            }


            public bool Contains(JsonSchema item)
            {
                return innerList.Contains(item);
            }


            public void CopyTo(JsonSchema[] array, int arrayIndex)
            {
                innerList.CopyTo(array, arrayIndex);
            }


            public bool Remove(JsonSchema item)
            {
                return innerList.Remove(item);
            }


            public int Count
            {
                get { return innerList.Count; }
            }


            public bool IsReadOnly
            {
                get { return innerList.IsReadOnly; }
            }

            #endregion
        }

        #endregion
    }
}