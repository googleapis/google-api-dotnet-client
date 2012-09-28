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

"""GWT/Java library generator based on RequestFactory."""

__author__ = 'robertvawter@google.com (Bob Vawter)'

from googleapis.codegen import java_generator
from googleapis.codegen.import_definition import ImportDefinition


class GwtGenerator(java_generator.JavaGenerator):
  """The GWT code generator."""

  def __init__(self, discovery, options=None):
    super(GwtGenerator, self).__init__(discovery, 'gwt', GwtLanguageModel(),
                                       options=options)

  def _InnerModelClassesSupported(self):
    """Gets whether or not inner model classes are supported."""
    return False

  def DefaultPackagePath(self, api):
    """Overrides the default implementation."""
    return 'com/google/api/gwt/services/%s/shared' % api.values['name']

  def AnnotateApi(self, api):
    """Add GWT specific annotations to the Api dictionary."""
    super(GwtGenerator, self).AnnotateApi(api)

  def AnnotateMethod(self, api, method, unused_resource):
    """Add GWT-specific annotations and naming schemes."""
    method.SetTemplateValue('className',
                            '%sRequest' % method.values['className'])
    super(GwtGenerator, self).AnnotateMethod(api, method, None)

  def AnnotateParameter(self, method, parameter):
    """Add GWT-specific annotations to parameter declaration.

    If the parameter is an enum, and any enum values have numeric names,
    then replace the name X with VALUE_X.

    Args:
      method: (Method) The method this parameter belongs to.
      parameter: (Parameter) The parameter to annotate.
    """
    super(GwtGenerator, self).AnnotateParameter(method, parameter)
    enum_type = parameter.values.get('enumType')
    if enum_type:

      def Fix(pair):
        if pair[0].isdigit():
          pair = tuple(['VALUE_' + pair[0]] + list(pair[1:]))
        return pair
      pairs = enum_type.GetTemplateValue('pairs')
      enum_type.SetTemplateValue('pairs', map(Fix, pairs))
      # For generated enums, we need to qualify the parent class of the enum so
      # that two methods that take a similarly-named enum parameter don't get
      # confused.
      parameter.SetTemplateValue('codeType', '%s.%s' %
                                 (method.values['className'],
                                  enum_type.values['className']))


class GwtLanguageModel(java_generator.JavaLanguageModel):
  """A LanguageModel for GWT."""

  # Dictionary of json type and format to its corresponding import definition.
  # The first import in the imports list is the primary import.
  TYPE_FORMAT_TO_DATATYPE_AND_IMPORTS = {
      ('boolean', None): ('Boolean', ImportDefinition(['java.lang.Boolean'])),
      # Use String instead of Object for GWT
      ('any', None): ('String', ImportDefinition(['java.lang.String'])),
      ('integer', 'int16'): ('Short', ImportDefinition(['java.lang.Short'])),
      ('integer', 'int32'): ('Integer',
                             ImportDefinition(['java.lang.Integer'])),
      # Java does not support Unsigned Integers
      ('integer', 'uint32'): ('Long', ImportDefinition(['java.lang.Long'])),
      ('number', 'double'): ('Double', ImportDefinition(['java.lang.Double'])),
      ('number', 'float'): ('Float', ImportDefinition(['java.lang.Float'])),
      # Use Splittable instead of Object for GWT
      ('object', None): ('Splittable', ImportDefinition(
          ['com.google.web.bindery.autobean.shared.Splittable'])),
      ('string', None): ('String', ImportDefinition(['java.lang.String'])),
      ('string', 'byte'): ('String', ImportDefinition(['java.lang.String'])),
      # GWT does not support date-time
      ('string', 'date-time'): ('String',
                                ImportDefinition(['java.lang.String'])),
      ('string', 'int64'): ('Long', ImportDefinition(['java.lang.Long'])),
      # Java does not support Unsigned Integers
      ('string', 'uint64'): ('BigInteger',
                             ImportDefinition(['java.math.BigInteger'])),
      }

  def __init__(self):
    super(GwtLanguageModel, self).__init__()
    self._type_map = GwtLanguageModel.TYPE_FORMAT_TO_DATATYPE_AND_IMPORTS

  def CodeTypeForVoid(self):
    """Return a GWT style void.

    Overrides the default.

    Returns:
      (str) 'EmptyResponse'
    """
    # TODO(user): Handle empty responses in a more graceful way. Instead of
    # passing the type to use for empty responses, just signal that an empty
    # response is required, and handle that in the templates.
    return 'EmptyResponse'
