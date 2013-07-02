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

"""A class holding utilities and concepts specific to a programming language.

The LanguageModel class contains conceptual elements which are common to
programming languages, but differ in the details. For example, this class
had the concept of the delimiter between parts of a module. In Java this
would be a '.', in C++ a '::'.
"""
__author__ = 'aiuto@google.com (Tony Aiuto)'

from googleapis.codegen import utilities

# Types of variable name case transforms.
PRESERVE_CASE = 0  # hello worlD
LOWER_CASE = 1  # hello world
UPPER_CASE = 2  # HELLO WORLD
LOWER_CAMEL_CASE = 3  # hello WorlD
UPPER_CAMEL_CASE = 4  # Hello WorlD


class LanguageModel(object):
  """The base class for all LanguageModels.

  There is a matrix of options of the form {TypeOfName}_{Option}, where the
  nametype specifies the kind of variable name we want and the option
  specifies the case transformation, separator or format. The meaning of
  these three options are:

  transform: (enum) The case transform for use for building a name. For the
      input 'hello worlD', the choices yield:
          language_model.PRESERVE_CASE => hello worlD
          language_model.LOWER_CASE => hello world
          language_model.UPPER_CASE => HELLO WORLD
          language_model.LOWER_CAMEL_CASE => hello WorlD
          language_model.UPPER_CAMEL_CASE => Hello WorlD
  separator: (char) The character which will be used to separate the
      parts of a name. May be None to indicate no separator.
  format: (str) The format string which wraps the transformed, separated
      name we are building. May be None for the identity format.

  The nametypes we define are
     array_of: For making a declaration of an array of some data type.
     class_name: For making a name for a class.
     constant: For making a name for a constant.
     member: For making a class member name.
  """

  # Characters in addition to alphanumerics which can be in an identifier.
  allowed_characters = ''

  # The defaults for each of (TypeOfName x Option)
  array_of_transform = None
  array_of_separator = None
  array_of_format = None
  class_name_transform = None
  class_name_separator = None
  class_name_format = None
  constant_transform = None
  constant_separator = None
  constant_format = None
  member_transform = None
  member_separator = None
  member_format = None

  def __init__(self, class_name_delimiter='.', module_name_delimiter=None):
    """Create a LanguageModel.

    Args:
      class_name_delimiter: (str) The string which delimits parts of a class
          name in code.
      module_name_delimiter: (str) The string which delimits parts of a module
          name in code. Defaults to class_name_delimiter
    Raises:
      ValueError: if some element of the class is mis-configured.
    """
    super(LanguageModel, self).__init__()
    self._class_name_delimiter = class_name_delimiter
    self._module_name_delimiter = (
        module_name_delimiter or class_name_delimiter)

    # pylint: disable=g-bad-name
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
  def module_name_delimiter(self):
    return self._module_name_delimiter

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

  def ArrayOf(self, variable, type_name):
    """Produce the string declaring an array of a data type.

    Args:
      variable: (DataType) the data we want an array of.
      type_name: (str) the printable name of that data type. Usually
          variable.codeType.
    Returns:
      (str)
    """
    if (self.array_of_transform or self.array_of_separator
        or self.array_of_format):
      return self.TransformString(variable, type_name, self.array_of_transform,
                                  self.array_of_separator,
                                  self.array_of_format)
    # fall back to older implementation
    return self.CodeTypeForArrayOf(type_name)

  def CodeTypeForArrayOf(self, type_name):
    """Take a type name and return the syntax for an array of them.

    Deprecated. use array_of transformation options in the lanaguge_model
    constructor.

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

  def ToConstantName(self, variable, name):
    """Convert a string to well formatted constant name.

    Args:
      variable: (CodeObject) an element which may appear in the templates.
      name: (str) The Discovery name of the variable.
    Returns:
      (str)
    """
    return self.TransformString(variable, name, self.constant_transform,
                                self.constant_separator,
                                self.constant_format)

  def ToClassName(self, variable, name):
    """Convert a string to a well formmated class name.

    Args:
      variable: (CodeObject) an element which may appear in the templates,
         but typically an Api, Resource, Method or Schema.
      name: (str) The Discovery name of the variable.
    Returns:
      (str)
    """
    return self.TransformString(variable, name, self.class_name_transform,
                                self.class_name_separator,
                                self.class_name_format)

  def ToClassMemberName(self, variable, name):
    """Convert a string to a well formated class member name.

    Class member names are the names used within data member classes. The
    external name would be the Getter name.

    Args:
      variable: (CodeObject) an element which may appear in the templates,
          but typically a Property.
      name: (str) The Discovery name of the variable.
    Returns:
      (str)
    """
    return self.TransformString(variable, name, self.member_transform,
                                self.member_separator, self.member_format)

  def ToMemberName(self, s, api):  # pylint: disable=unused-argument
    """Convert a name to a suitable member name in the target language.

    Subclasses should override as appropriate.

    TODO(user): Make a pass to replace uses of this with ToMemberName or
    whatever is appropriate,

    Args:
      s: (str) A canonical name for data element. (Usually the API wire format)
      api: (Api) The API this element is part of. For use as a hint when the
        name cannot be used directly.
    Returns:
      A name suitable for use as an element in the generator's target language.
    """
    return s

  def ToSafeClassName(self, s, api, parent):  # pylint: disable=unused-argument
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

  def ToPropertyGetterMethodWithDelim(self, prop_name):
    """Convert a property name to the name of the getter method that returns it.

    Subclasses should override as appropriate.

    Args:
      prop_name: (str) The name of a property.
    Returns:
      The language specific name of the getter method that returns the specified
      property. The default implementation returns .getxyz for a property called
      xyz.
    """
    return '%sget%s()' % (self._class_name_delimiter, prop_name)

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

  # pylint: disable=unused-argument
  def DefaultContainerPathForOwner(self, module):
    """Computes the default path to a module for the given owner information.

    For a given module, compute the portions of the path which are determined
    by the owner of the module - excluding the module path itself.

    Subclasses almost certainly want to override this.

    Args:
      module: (template_objects.Module) The module.
    Returns:
      (str) The path to use for the namespace of this API.
    """
    return '/'.join(utilities.ReversedDomainComponents(module.owner_domain))

  def TransformString(self, variable, s, case_transformation,
                      reserved_character_replacement,
                      format_string=None):
    """Applies case and separator transforms to a string.

    Takes a string (usually a wireName) which might be in any case and have
    reserved characters in it and transforms by the rules specified. The string
    is divided into parts at reserved characters, then each part is transformed
    by the case rule and then the parts are joined by the reserved character
    replacement.  Multiple reserved characters in a row are treated as one.

    Note that the camel case transformations preserve existing case except for
    the first character of each word. This provides good results for cases
    where the use has provided a camel cased or proper name. E.g. maxResults,
    YouTube, NASA.

    Note: Do we need rule that transforms NASA to Nasa and nasa when in the
    upper and lower camel variations?  That is, if you specify something in
    ALL CAPS, we assume it is not a mixed case spelling.

    Args:
      variable: (CodeObject) The template variable this string came from. This
          is used to extract details about the variable which may be useful in
          building a name, such as the module it belongs to.
      s: (str) A string to transform.
      case_transformation: (enum) How to change case.
      reserved_character_replacement: (char) What to join parts with.
      format_string: (str) Format string to use to wrap the value after
          performing the case and separator transformations.
    Returns:
      Transformed string.
    """
    # Pick the right transformer method
    if case_transformation == LOWER_CASE:
      transform = lambda s, _: ''.join(s).lower()
    elif case_transformation == UPPER_CASE:
      transform = lambda s, _: ''.join(s).upper()
    elif case_transformation == UPPER_CAMEL_CASE:
      transform = lambda s, _: ''.join([s[0].upper()] + s[1:])
    elif case_transformation == LOWER_CAMEL_CASE:
      # pylint: disable=g-long-lambda
      transform = (
          lambda s, first_word:
          ''.join([s[0].lower() if first_word else s[0].upper()] + s[1:]))
    else:
      transform = lambda s, _: ''.join(s)

    # Split into words at characters which can not be part of an identifier.
    parts = []
    curpart = []
    for c in s:
      # Collect valid characters for an identifier.
      if not c.isalnum() and c not in self.allowed_characters:
        if curpart:
          parts.append(transform(curpart, not parts))
          curpart = []
      else:
        # end the word when we have a bad one.
        curpart.append(c)
    if curpart:
      parts.append(transform(curpart, not parts))

    join_char = reserved_character_replacement or ''
    name = join_char.join(parts)

    if not format_string:
      return name

    expansions = dict(name=name)
    # The variable should always be present in normal execution. We allow
    # it to be None solely for testing.
    # TODO(user): Figure out a way to fail hard if not present during
    # execution, even though django catches the error and siliently ignores it.
    # OR... maybe just fix the tests to always pass in the complete kind of
    # object we need.
    if variable:
      expansions['module'] = variable.module.name
    # TODO(user): Expand the range of things available.
    return format_string.format(**expansions)


class DocumentingLanguageModel(LanguageModel):
  """A language model which displays things in a way humans can read.

  This model is useful for language neutral expression of an Api.
  """

  array_of_format = 'Array<{name}>'

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
