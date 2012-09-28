#!/usr/bin/python2.6
#
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

  _SCHEMA_TYPE_TO_DART_TYPE = {
      'any': 'core.Object',
      'boolean': 'core.bool',
      'integer': 'core.int',
      'long': 'core.long',
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

  def CodeTypeForArrayOf(self, type_name):
    """Take a type name and return the syntax for an array of them.

    Overrides the default.

    Args:
      type_name: (str) A type name.
    Returns:
      (str) A Dart specific string meaning "an array of type_name".
    """
    return 'core.List<%s>' % type_name

  def CodeTypeForMapOf(self, type_name):
    """Take a type name and return the syntax for an array of them.

    Overrides the default.

    Args:
      type_name: (str) A type name.
    Returns:
      (str) A Dart specific string meaning "a Map of string to type_name".
    """
    return 'core.Map<core.String, %s>' % type_name

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
    super(DartGenerator, self).AnnotateResource(the_api, resource)

  def AnnotateParameter(self, method, parameter):
    """Override default implementation.

    If the parameter is an enum, and any enum values have numeric names,
    then replace the name X with VALUE_X.

    Args:
      method: (Method) The method this parameter belongs to.
      parameter: (Parameter) The parameter to annotate.
    """
    enum_type = parameter.GetTemplateValue('enumType')
    if enum_type:

      def Fix(pair):
        if pair[0].isdigit():
          pair = tuple(['VALUE_' + pair[0]] + list(pair[1:]))
        return pair
      pairs = enum_type.GetTemplateValue('pairs')
      enum_type.SetTemplateValue('pairs', map(Fix, pairs))
    super(DartGenerator, self).AnnotateParameter(method, parameter)


class DartApi(api.Api):
  """An Api with Dart annotations."""

  def __init__(self, discovery_doc, **unused_kwargs):
    super(DartApi, self).__init__(discovery_doc)

  def ToClassName(self, s, element_type=None):  # pylint: disable-msg=W0613
    """Convert a discovery name to a suitable Dart class name.

    Overrides the default.

    Args:
      s: (str) A rosy name of data element.
      element_type: (str) The kind of element (resource|method) to name.
    Returns:
      A name suitable for use as a class in the generator's target language.
    """

    candidate = utilities.CamelCase(s)
    if 'api' == element_type:
      candidate += 'Api'
    while candidate in DartLanguageModel.RESERVED_CLASS_NAMES:
      candidate += '_'
    return candidate
