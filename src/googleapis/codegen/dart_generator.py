#!/usr/bin/python2.7
# Copyright 2011 Google Inc. All Rights Reserved.
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

"""Dart library generator.

This module generates Dart code from a Google API discovery documents.
"""

__author__ = 'aiuto@google.com (Tony Aiuto)'

from googleapis.codegen import api
from googleapis.codegen import api_library_generator
from googleapis.codegen import language_model
from googleapis.codegen import utilities


class DartLanguageModel(language_model.LanguageModel):
  """A LanguageModel for Dart."""

  language = 'dart'

  _SCHEMA_TYPE_TO_DART_TYPE = {
      'any': 'core.Object',
      'boolean': 'core.bool',
      'integer': 'core.int',
      'long': 'core.int',
      'number': 'core.double',
      'string': 'core.String',
      'object': 'core.Object',
      }

  _DART_KEYWORDS = [
      'break', 'case', 'catch', 'class', 'const', 'continue', 'default',
      'else', 'extends', 'final', 'finally', 'for', 'in', 'is', 'new', 'null',
      'return', 'static', 'super', 'switch', 'throw', 'try', 'var', 'void',
      'while'
      ]

  # We can not create classes which match a Dart keyword or built in object
  # type.
  RESERVED_CLASS_NAMES = _DART_KEYWORDS + _SCHEMA_TYPE_TO_DART_TYPE.values()

  array_of_policy = language_model.NamingPolicy(
      format_string='core.List<{name}>')
  map_of_policy = language_model.NamingPolicy(
      format_string='core.Map<core.String, {name}>')

  def __init__(self):
    super(DartLanguageModel, self).__init__(class_name_delimiter='')

  def GetCodeTypeFromDictionary(self, def_dict):
    """Gets an element's data type from its JSON definition.

    Overrides the default.

    Args:
      def_dict: (dict) The defintion dictionary for this type
    Returns:
      A name suitable for use as a Dart data type
    """
    json_type = def_dict.get('type', 'String')
    native_type = self._SCHEMA_TYPE_TO_DART_TYPE.get(json_type)
    return native_type

  def ToMemberName(self, s, unused_the_api):
    """CamelCase a wire format name into a suitable Dart variable name."""
    candidate = utilities.CamelCase(s)
    candidate = candidate[0].lower() + candidate[1:]
    while candidate in self.RESERVED_CLASS_NAMES:
      candidate += '_'
    return candidate

DART_LANGUAGE_MODEL = DartLanguageModel()


class DartGenerator(api_library_generator.ApiLibraryGenerator):
  """The Dart code generator."""

  def __init__(self, discovery, options=None):
    super(DartGenerator, self).__init__(
        DartApi,
        discovery,
        language='dart',
        language_model=DART_LANGUAGE_MODEL,
        options=options)

  def AnnotateResource(self, the_api, resource):
    """Override default implementation.

    Prepend the resource class name to each sub-resource since Dart doesn't
    support nested classes. Append 'Resource' to the class name so resources
    are less likely to conflict with models.

    Args:
      the_api: (Api) The API this Resource belongs to.
      resource: (Resource) The Resource to annotate.
    """
    for r in resource.values['resources']:
      r.values['className'] = (resource.values['className'] +
                               r.values['className'])
      self.AnnotateResource(the_api, r)
    resource.values['className'] += 'Resource'

    parent_list = resource.ancestors[1:]
    parent_list.append(resource)
    parent_classes = [p.values.get('className') for p in parent_list]
    resource.SetTemplateValue('contextCodeType', '.'.join(parent_classes))
    super(DartGenerator, self).AnnotateResource(the_api, resource)

  def AnnotateMethod(self, the_api, method, unused_resource):
    """Add Dart-specific annotations and naming schemes."""
    parent_list = method.ancestors[1:]
    parent_list.append(method)
    parent_classes = [p.values.get('className') for p in parent_list]
    method.SetTemplateValue('contextCodeType', '.'.join(parent_classes))
    super(DartGenerator, self).AnnotateMethod(the_api, method, None)


class DartApi(api.Api):
  """An Api with Dart annotations."""

  def __init__(self, discovery_doc, **unused_kwargs):
    super(DartApi, self).__init__(discovery_doc)

  # pylint: disable=unused-argument
  def ToClassName(self, s, element, element_type=None):
    """Convert a discovery name to a suitable Dart class name.

    Overrides the default.

    Args:
      s: (str) A rosy name of data element.
      element: (object) The object we need a class name for.
      element_type: (str) The kind of element (resource|method) to name.
    Returns:
      A name suitable for use as a class in the generator's target language.
    """

    candidate = utilities.CamelCase(s)
    if isinstance(element, api.Api):
      candidate += 'Api'
    while candidate in DartLanguageModel.RESERVED_CLASS_NAMES:
      candidate += '_'
    return candidate
