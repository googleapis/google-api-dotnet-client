#!/usr/bin/python2.6
#
# Copyright 2010 Google Inc. All Rights Reserved.
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

"""Template objects which represent data types.

This module contains objects which usable in templates and represent data type
idioms.
"""

__author__ = 'aiuto@google.com (Tony Aiuto)'

from googleapis.codegen import template_objects


class DataType(template_objects.CodeObject):
  """Template object which represents a data type.

  This is the base class for things which might be data type definitions, such
  as Schema objects derived from JSONSchema blocks or primitive types.
  """

  def __init__(self, def_dict, api, parent=None, language_model=None):
    """Construct a DataType.

    Args:
      def_dict: (dict) The discovery dictionary for this element.
      api: (Api) The Api instance which owns this element.
      parent: (CodeObject) The parent of this element.
      language_model: (LanguageModel) The language we are targetting.
        Dynamically defaults to the parent's language model.
    """
    super(DataType, self).__init__(def_dict, api, parent=parent,
                                   language_model=language_model)
    self._json_type = def_dict.get('type')
    # If the schema has an id, that is a good default class name for it.
    schema_id = def_dict.get('id')
    if schema_id:
      self.SetTemplateValue('className', schema_id)

  @property
  def json_type(self):
    """Expose the type element from the JSON Schema type definition."""
    return self._json_type

  @property
  def code_type(self):
    """Returns the string representing this datatype."""
    #raise NotImplementedError('DataType subclasses must implement code_type')
    return self.values.get('codeType') or self.values.get('className')

  @property
  def safe_code_type(self):
    """Returns the safe code type representing this datatype."""
    return self.safeClassName or self.code_type

  @property
  def class_name(self):
    return self.GetTemplateValue('className')

  @property
  def safeClassName(self):  # pylint: disable-msg=C6409
    """Returns a language appropriate name for this object.

    This property should only be used during template expansion. It is computed
    once, using the LanguageModel in play, and then that value is cached.

    Returns:
      (str) a name for an instance of this object.
    """
    safe_class_name = self.GetTemplateValue('safe_class_name')
    if not safe_class_name:
      safe_class_name = self.values.get('wireName')
      if not safe_class_name:
        return None
      language_model = self._FindNearestLanguageModel()
      if language_model:
        safe_class_name = language_model.ToSafeClassName(
            safe_class_name, self._api, self._parent)
      self.SetTemplateValue('safeClassName', safe_class_name)
    return safe_class_name


class PrimitiveDataType(DataType):
  """DataType which represents a "built in" data type.

  Primitive types are those which are provided by the language or one of its
  packages, rather than those defined by the API.  A language specific
  generater should annotate PrimitiveDataType objects with a specific codeType
  before using them to generate code.
  """

  def __init__(self, def_dict, api, parent=None):
    """Construct a PrimitiveDataType.

    Args:
      def_dict: (dict) The discovery dictionary for this element.
      api: (Api) The Api instance which owns this element.
      parent: (TemplateObject) The parent of this object.
    """
    super(PrimitiveDataType, self).__init__(def_dict, api, parent=parent)
    self.SetTemplateValue('builtIn', True)

  @property
  def class_name(self):
    return self.code_type

  @property
  def fullClassName(self):  # pylint: disable-msg=C6409
    """Override the TemplateObject path chaining."""
    return self.code_type

  @property
  def code_type(self):
    """Returns the language specific type representing this datatype."""
    language_model = self._FindNearestLanguageModel()
    if language_model:
      s = language_model.GetCodeTypeFromDictionary(self._def_dict)
      return s
    return self.values.get('type')

  @property
  def safe_code_type(self):
    """Returns the safe code type representing this datatype."""
    return self.code_type

  @property
  def json_format(self):
    """Expose the format element from the JSON Schema type definition."""
    return self.values.get('format')


class ComplexDataType(DataType):
  """A DataType which requires a definition: that is, not primitive.

  ComplexDataTypes are structured objects and containers of objects.
  """

  def __init__(self, default_name, def_dict, api, parent=None,
               language_model=None, wire_name=None):
    """Construct an ComplexDataType.

    Args:
      default_name: (str) The name to give this type if there is no 'id' in
        the default dict.
      def_dict: (dict) The discovery dictionary for this element.
      api: (Api) The Api instance which owns this element.
      parent: (CodeObject) The parent of this element.
      language_model: (LanguageModel) The language we are targetting.
        Dynamically defaults to the parent's language model.
      wire_name: (str) The identifier used in the wire protocol for this object.
    Raises:
      ValueError: if there is no identifing name for this object.
    """
    super(ComplexDataType, self).__init__(def_dict, api, parent=parent,
                                          language_model=language_model)
    name = def_dict.get('id') or default_name or wire_name
    if not name:
      raise ValueError(
          'Complex data types must have an id or be assigned a name: %s' %
          def_dict)
    self.SetTemplateValue('wireName', wire_name or name)

  @property
  def code_type(self):
    """Returns the string representing this datatype."""
    return self.values.get('codeType') or self.className

  @property
  def safe_code_type(self):
    """Returns the safe code type representing this datatype."""
    return self.safeClassName or self.code_type

  @property
  def class_name(self):
    return self.values.get('className')

  @property
  def className(self):  # pylint: disable-msg=C6409
    return self.class_name or self.safeClassName


class ArrayDataType(ComplexDataType):
  """DataType which represents a array of another DataType."""

  def __init__(self, default_name, base_type, parent=None, wire_name=None):
    """Construct an ArrayDataType.

    Args:
      default_name: (str) The name to give this type if there is no 'id' in
        the default dict.
      base_type: (DataType) The DataType to represent an array of.
      parent: (TemplateObject) The parent of this object.
      wire_name: (str) The identifier used in the wire protocol for this object.
    """
    # Access to protected _language_model OK here. pylint: disable-msg=W0212
    super(ArrayDataType, self).__init__(
        default_name, {}, base_type.api, parent=parent,
        language_model=base_type._language_model,
        wire_name=wire_name)
    self._base_type = base_type
    self._json_type = 'array'
    self.SetTemplateValue('isContainer', True)
    self.SetTemplateValue('baseType', base_type)
    self.SetTemplateValue('builtIn', True)
    self.SetTemplateValue('arrayOf', base_type)
    # TODO(user): This gets parenting right so language models propogate down.
    # We should invert the computation of code_type so we ask the language
    # model for code type of a primative.
    if isinstance(base_type, PrimitiveDataType):
      self._base_type.SetParent(self)

  @property
  def code_type(self):
    """Returns the string representing the datatype of this variable.

    Note: This may should only be called after the language model is set.

    Returns:
      (str) A printable representation of this data type.
    """
    language_model = self._FindNearestLanguageModel()
    return language_model.CodeTypeForArrayOf(self._base_type.code_type)

  @property
  def safe_code_type(self):
    language_model = self._FindNearestLanguageModel()
    return language_model.CodeTypeForArrayOf(self._base_type.safe_code_type)


class MapDataType(ComplexDataType):
  """DataType which represents a map of string to another DataType.

  This is the base class for things which might be data type definitions, such
  as Schema objects derived from JSONSchema blocks or primitive types.
  """

  def __init__(self, default_name, base_type, parent=None, wire_name=None):
    """Construct a MapDataType.

    Args:
      default_name: (str) The name to give this type if there is no 'id' in
        the default dict.
      base_type: (DataType) The DataType to represent an map of string to.
      parent: (TemplateObject) The parent of this object.
      wire_name: (str) The identifier used in the wire protocol for this object.
    """
    # Access to protected _language_model OK here. pylint: disable-msg=W0212
    super(MapDataType, self).__init__(default_name, {}, base_type.api,
                                      parent=parent,
                                      language_model=base_type._language_model,
                                      wire_name=wire_name)
    self._base_type = base_type
    self._json_type = 'map'
    if isinstance(base_type, PrimitiveDataType):
      self._base_type.SetParent(self)
    # Mark me as not generatable
    self.SetTemplateValue('isContainer', True)
    self.SetTemplateValue('baseType', base_type)
    self.SetTemplateValue('builtIn', True)
    self.SetTemplateValue('mapOf', base_type)

  @property
  def code_type(self):
    """Returns the string representing the datatype of this variable.

    Note: This may should only be called after the language model is set.

    Returns:
      (str) A printable representation of this data type.
    """
    language_model = self._FindNearestLanguageModel()
    return language_model.CodeTypeForMapOf(self._base_type.code_type)

  @property
  def safe_code_type(self):
    """Returns the string representing the safe datatype of this variable.

    Note: This may should only be called after the language model is set.

    Returns:
      (str) A printable representation of this data type.
    """
    language_model = self._FindNearestLanguageModel()
    return language_model.CodeTypeForMapOf(self._base_type.safe_code_type)


class SchemaReference(DataType):
  """DataType which represents a type alias to named schema.

  Provides a lazy reference to schema by name.
  """

  def __init__(self, referenced_schema, api):
    """Construct a SchemaReference.

    Args:
      referenced_schema: (str) The name of the schema we are referencing.
      api: (Api) The Api instance which owns this element.

    Returns:
      SchemaReference
    """
    super(SchemaReference, self).__init__({}, api)
    self._referenced_schema = referenced_schema
    self.SetTemplateValue('className', referenced_schema)
    self.SetTemplateValue('wireName', referenced_schema)
    self.SetTemplateValue('reference', True)

  @property
  def values(self):
    """Forwards the 'values' property of this object to the referenced object.

    This enables GetTemplateValue called on a Ref to effectively return
    the value for the truly desired schema.

    This may be safely called at any time, but may not produce expected
    results until after the entire API has been parsed. In practice, this
    means that anything done during template expansion is fine.

    Returns:
      dict of values which can be used in template.
    """
    s = self.api.SchemaByName(self._referenced_schema)
    if s:
      return s.values
    return self._def_dict

  @property
  def code_type(self):
    """Returns the string representing the datatype of this variable."""
    s = self.api.SchemaByName(self._referenced_schema)
    if s:
      return s.code_type
    return self._def_dict.get('codeType') or self._def_dict.get('className')

  @property
  def safe_code_type(self):  # pylint: disable-msg=C6409
    return self.api.SchemaByName(self._referenced_schema).safe_code_type

  @property
  def parent(self):
    """Returns the parent of the schema I reference."""
    return self.api.SchemaByName(self._referenced_schema).parent


class Void(PrimitiveDataType):
  """DataType which represents a 'void'.

  Some API methods have no response. To provide some consistency in assigning
  a responseType to these methods, we use the Void data type. When it is
  referenced in a template, it forwards requests for it's code_type to a
  langauge model specific emitter.
  """

  def __init__(self, api):
    """Construct a Void.

    Args:
      api: (Api) The Api instance which owns this element. This is used for
        a parent chain so that we can pick up the language model at template
        generation time.

    Returns:
      Void
    """
    super(Void, self).__init__({}, api, parent=api)

  @property
  def code_type(self):
    """Returns the string representing the datatype of this variable."""
    language_model = self._FindNearestLanguageModel()
    if language_model:
      return language_model.CodeTypeForVoid()
    return 'void'
