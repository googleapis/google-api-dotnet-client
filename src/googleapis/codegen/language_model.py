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

"""A class holding utilities and concepts specific to a programming language.

The LanguageModel class contains conceptual elements which are common to
programming languages, but differ in the details. For example, this class
had the concept of the delimiter between parts of a package. In Java this
would be a '.', in C++ a '::'.
"""
__author__ = 'aiuto@google.com (Tony Aiuto)'

from googleapis.codegen import utilities


class LanguageModel(object):
  """The base class for all LanguageModels."""

  def __init__(self,
               class_name_delimiter='.',
               package_name_delimiter=None):
    """Create a LanguageModel.

    Args:
      class_name_delimiter: (str) The string which delimits parts of a class
          name in code.
      package_name_delimiter: (str) The string which delimits parts of a
          package name in code. Defaults to class_name_delimiter
    """
    super(LanguageModel, self).__init__()
    self._class_name_delimiter = class_name_delimiter
    self._package_name_delimiter = (
        package_name_delimiter or class_name_delimiter)

    # pylint: disable-msg=C6409
    self._SUPPORTED_TYPES = {
        'integer': self._Integer,
        'number': self._Float,
        'string': self._String,
        }

  def _Integer(self, data_value):
    """Convert provided int to language specific literal.

    Subclasses should override as appropriate.

    Args:
      data_value: The DataValue object representing the value to be converted
        to a integer literal.

    Returns:
      (str) String representation of value once cast to an integer.
    """
    return u'%d' % long(data_value.value)

  def _Float(self, data_value):
    """Convert provided float to language specific literal.

    Args:
      data_value: The DataValue object representing the value to be converted
        to a float literal.

    Returns:
      (str) String representation of value once cast to an float.

    Raises:
      ValueError: if float is inf as we don't support rendering an inf.
    """
    value = float(data_value.value)
    if value == float('inf'):
      raise ValueError('DataValue does not support rendering of provided Type '
                       '(%s)' % value)

    value = unicode(value)
    # Note that unicode(float()) already appends '.0' if is an integral value.
    return value

  def _String(self, data_value):
    """Convert provided string to language specific literal.

    Subclasses should override as appropriate.

    Args:
      data_value: The DataValue object representing the value to be converted
        to a string literal.

    Returns:
      (str) Value written out as a string wrapped in double quotes.
    """
    # TODO(user): Figure out a generalized solution to literal-related
    # information... replicating template_helpers.py escape information here
    # is bad practice.
    literal_escape = [
        ('\\', '\\\\'),
        ('"', '\\"'),
        ('\n', '\\n'),
        ('\t', '\\t'),
        ('\r', '\\r'),
        ('\f', '\\f'),
        ]
    value = unicode(data_value.value)
    for special, replacement in literal_escape:
      value = value.replace(special, replacement)
    return u'"%s"' % value

  @property
  def class_name_delimiter(self):
    return self._class_name_delimiter

  @property
  def package_name_delimiter(self):
    return self._package_name_delimiter

  def GetCodeTypeFromDictionary(self, json_schema):
    """Convert a json schema primitive type into the most suitable class name.

    Subclasses should override as appropriate.

    Args:
      json_schema: (dict) The defintion dictionary for this type
    Returns:
      A name suitable for use as a class in the generator's target language.
    """
    # COV_NF_START
    raise NotImplementedError(
        'Subclasses of LanguageModel must implement GetCodeTypeFromDictionary')
    # COV_NF_END

  def CodeTypeForArrayOf(self, type_name):
    """Take a type name and return the syntax for an array of them.

    Subclasses must override as appropriate. The base definition is only OK for
    debugging.

    Args:
      type_name: (str) A type name.
    Returns:
      A language specific string meaning "an array of type_name".
    """
    # COV_NF_START
    raise NotImplementedError(  # COV_NF_LINE
        'Subclasses of LanguageModel must implement CodeTypeForArrayOf')
    # COV_NF_END

  def CodeTypeForMapOf(self, type_name):
    """Take a type name and return the syntax for a map of strings of them.

    Subclasses must override as appropriate. The base definition is only OK for
    debugging.

    Args:
      type_name: (str) A type name.
    Returns:
      A language specific string meaning "an array of type_name".
    """
    # COV_NF_START
    raise NotImplementedError(  # COV_NF_LINE
        'Subclasses of LanguageModel must implement CodeTypeForMapOf')
    # COV_NF_END

  def CodeTypeForVoid(self):
    """Return the type name for a void.

    Subclasses may override this default implementation.

    Returns:
      (str) 'void'
    """
    return 'void'

  def ToMemberName(self, s, api):  # pylint: disable-msg=W0613
    """Convert a name to a suitable member name in the target language.

    Subclasses should override as appropriate.

    Args:
      s: (str) A canonical name for data element. (Usually the API wire format)
      api: (Api) The API this element is part of. For use as a hint when the
        name cannot be used directly.
    Returns:
      A name suitable for use as an element in the generator's target language.
    """
    return s

  def ToSafeClassName(self, s, api, parent):  # pylint: disable-msg=W0613
    """Convert a name to a suitable class name in the target language.

    Subclasses should override as appropriate.

    Args:
      s: (str) A canonical name for data element. (Usually the API wire format)
      api: (Api) The API this element is part of. For use as a hint when the
        name cannot be used directly.
      parent: The schema where I was referenced.
    Returns:
      A name suitable for use as an element in the generator's target language.
    """
    return utilities.CamelCase(s)

  def RenderDataValue(self, data_value):
    """Translate a value to an appropriate structure for the target language.

    Args:
      data_value: The DataValue object rendered.
    Returns:
      The string representation of the value the target language expects
      of the type represented by the schema (e.g. a value [1, 2, 3] with
      a schema representing a list would be translated to "[1, 2, 3]" in
      Python but "Arrays.asList({1, 2, 3})" in Java).

    Raises:
      ValueError: if the provided schema is for an unsupported type.
    """
    type_str = data_value.data_type.json_type
    if type_str in self._SUPPORTED_TYPES:
      return self._SUPPORTED_TYPES[type_str](data_value)
    else:
      raise ValueError(
          'Rendering the provided type (%s) is not supported by the %s.' %
          (type_str, type(self).__name__))


class DocumentingLanguageModel(LanguageModel):
  """A language model which displays things in a way humans can read.

  This model is useful for language neutral expression of an Api.
  """

  def CodeTypeForArrayOf(self, type_name):
    """Take a type name and return the syntax for an array of them.

    Override the default

    Args:
      type_name: (str) A type name.
    Returns:
      The string Array<inner data type>
    """
    return 'Array<%s>' % type_name

  def CodeTypeForMapOf(self, type_name):
    """Take a type name and return the syntax for a map of strings of them.

    Override the default

    Args:
      type_name: (str) A type name.
    Returns:
      The string Map<string, inner data type>
    """
    return 'Map<string, %s>' % type_name

  def GetCodeTypeFromDictionary(self, json_schema):
    """Convert a json schema primitive type into the most suitable class name.

    Subclasses should override as appropriate.

    Args:
      json_schema: (dict) The defintion dictionary for this type
    Returns:
      A name suitable for use as a class in the generator's target language.
    """
    json_type = json_schema.get('type', 'UNKNOWN')
    json_format = json_schema.get('format')
    if json_format:
      json_type = '%s (%s)' % (json_type, json_format)
    return json_type
