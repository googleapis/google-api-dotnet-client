#!/usr/bin/python2.7
# Copyright 2013 Google Inc. All Rights Reserved.
#
#  Licensed under the Apache License, Version 2.0 (the "License");
#  you may not use this file except in compliance with the License.
#  You may obtain a copy of the License at
#
#      http://www.apache.org/licenses/LICENSE-2.0
#
#  Unless required by applicable law or agreed to in writing, software
#  distributed under the License is distributed on an "AS IS" BASIS,
#  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
#  See the License for the specific language governing permissions and
#  limitations under the License.

"""Java protobuf library generator.
"""

__author__ = 'yanivi@google.com (Yaniv Inbar)'

from googleapis.codegen import api_library_generator
from googleapis.codegen import data_types
from googleapis.codegen.java_generator import Java14LanguageModel
from googleapis.codegen.java_generator import JavaApi


class JavaProtoGenerator(api_library_generator.ApiLibraryGenerator):
  """Java protobuf code generator."""

  def __init__(self, discovery, language='javaproto', language_model=None,
               options=None):
    if not language_model:
      language_model = self._GetDefaultLanguageModel(options)
    super(JavaProtoGenerator, self).__init__(JavaApi, discovery, language,
                                             language_model, options=options)

  @classmethod
  def _GetDefaultLanguageModel(cls, options=None):
    return Java14LanguageModel(options=options)

  def AnnotateMethod(self, unused_the_api, method, unused_resource):
    """Annotate a Method with Java Proto specific elements.

    Args:
      unused_the_api: (Api) The API tree which owns this method.
      method: (Method) The method to annotate.
      unused_resource: (Resource) The resource which owns this method.

    Raises:
      ValueError: if missing externalTypeName
    """
    for attr in ('requestType', 'responseType'):
      schema = method.get(attr)
      if schema and not isinstance(schema, data_types.Void):
        name = schema.get('externalTypeName')
        if not name:
          raise ValueError('missing externalTypeName for %s (%s of method %s)'
                           % (schema['id'], attr, method['rpcMethod']))
        java_name = schema.get('javaTypeName')
        proto_name = java_name or 'TO_BE_COMPUTED.' + name[name.rfind('.')+1:]
        schema.SetTemplateValue('protoFullClassName', proto_name)

