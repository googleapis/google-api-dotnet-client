#!/usr/bin/python2.7
# Copyright 2012 Google Inc. All Rights Reserved.
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

"""C++ library generator.

Specializations to the code Generator for C++ bindings.
"""

__author__ = 'ewiseblatt@google.com (Eric Wiseblatt)'

import re
import gflags as flags
from googleapis.codegen import api
from googleapis.codegen import api_library_generator
from googleapis.codegen import cpp_import_manager
from googleapis.codegen import data_types
from googleapis.codegen import language_model
from googleapis.codegen import utilities
from googleapis.codegen.import_definition import ImportDefinition

FLAGS = flags.FLAGS
flags.DEFINE_boolean(
    'cpp_generator_add_owner_dir',
    True,
    'Adds owner subdirectory to --output_dir path.')


# This pattern is used to extract the DT and DD text groups.
# It is meant to be applied to the split partions of the dl_pattern_re.
# It turns  'A - Description A\nB - Description B'
#     into  ['', 'A', 'Description A', '', 'B', 'Description B', '']
DT_DD_PATTERN_RE = re.compile(
    r"""\s*-?\s?   # Skip leading spaces and leading - decorator from the key.
        (\S+)      # Capture the (single-word) key.
        \s*[\-\:]   # There must be a '-' or ':' after the key, but
                   # can be surrounded by spaces, even on different line.
        \s*        # The - or : seperator can be followed by spaces (or eoln).
       ([^\n]+)    # The value is everything to eoln.
                   # We already prefiltered the length, so dont worry about it.
       """,
    re.VERBOSE)

# This threshold is somewhat arbitrary -- two 80 character lines.
# We dont want the dd elements to be bigger than this or else it probably
# wasnt a dd. If the very last line was cut off at this length then we'll
# assume that it is runoff and the list was not terminated with an EOL.
# In that case we'll back off and just keep the first sentence for the DD
# and stick the remainder after the DL closes along with the rest of the
# text.
MAX_DD_LEN = 160

# This pattern is used to extract the content for a DL.
# It will be the entire string for all the individual element definitions.
# It turns  'Plain text\nMore plain text'
#      into ['Plain text\nMore plain text']
# and turns 'Before\nA - Description A\nB - Description B\nAfter'
#      into ['Before', 'A - Description A\nB - Description B', '\nAfter']
#                      +--------  DL list contents  --------+
_DL_PATTERN = r"""\n
        (         # Capture group for the whole matched RE.
        (?:       # Non-capture group for the DT/DD name/value pair.
        \s*-?\s?  # Skip leading spaces and single dash starting the line.
        \S+       # The key must be a single word without any spaces.
        \s?[\-\:] # The key can have a space (and even eoln)
                  # But then must have a dash or colon
        \s*       # Can have spaces or eoln after the dash/colon
        [^\n]{5,%d}  # The value part needs to be 5..N chars up to EOLN
        )         # That's the end of this DT/DD pair.
        {2,}      # To have a DL, we need at least 2 DT/DD pairs.
        \n?       # strip trailing space because we'll be adding it back in
                  # when we join with the next fragment.
        )         # End the capture group for all the tuples in the list.
        """ % MAX_DD_LEN
DL_PATTERN_RE = re.compile(_DL_PATTERN, re.VERBOSE)


class CppGenerator(api_library_generator.ApiLibraryGenerator):
  """The C++ code generator."""

  # pylint: disable=redefined-outer-name
  def __init__(self, discovery, language='cpp', language_model=None,
               options=None):
    if not language_model:
      language_model = CppLanguageModel(options)
    super(CppGenerator, self).__init__(CppApi, discovery, language,
                                       language_model, options=options)

  def _InnerModelClassesSupported(self):
    """Gets whether or not inner model classes are supported."""
    return True

  def _HeaderFileName(self, path, filename):
    if not path:
      return '%s.h' % filename
    return '%s/%s.h' % (path, filename)

  def _DLifyDescription(self, text):
    """Substitutes <DL> list into text based on patterns.

    Args:
      text: (string) the text to transform is assumed to be HTML escaped.

    Returns:
      Patterns that look like DLl lists will be replaced with HTML markup.
    """

    # Mark beginning of string with \n so we can catch things at the beginning
    # since we require a \n at the start of the first key.
    sentinel = '\n'

    # Look for pattern in the form \n<term> - <description>\n and extract
    # them out into a <dl> list.
    # Note that descriptions are normally HTML safe, but that check already
    # happened so this will actually produce HTML, which we want.

    # We'll partition the text by the DL lists.
    dl_partitions = DL_PATTERN_RE.split(sentinel + text)  # , 0, re.MULTILINE)
    dl_partitions[0] = dl_partitions[0][len(sentinel):]
    if len(dl_partitions) == 1:
      return text

    # We'll iterate over the partitions and attempt to split the DT/DD pairs.
    # If we cannot then the partition was between the lists in the split.
    # If we can, then we'll use that split to form the lines in the DL.
    result = []
    for partition in dl_partitions:
      dl = DT_DD_PATTERN_RE.split(partition)
      if len(dl) == 1:
        if dl[0]:  # skip empty strings
          result.append(dl[0])
          continue
      else:
        # we have a list in the form <seperator>, <dt value>, <dd value>
        # so iterate over those 3-group pairs and extract out the dt nd dd
        # values, adding them into a dl.
        # I'm calling these triples rather than 3-tupels because they are
        # not actually grouped as tuples.
        if result:
          result.append('\n')
        num_triples = len(dl) / 3
        if num_triples == 1:
          result.append(partition)
          continue

        runoff = ''  # Extra stuff past end of dl that regex cannot detect.
        result.append('<dl>\n')
        for i in range(num_triples):
          dt_value = dl[3 * i + 1].strip()
          dd_value = dl[3 * i + 2].strip()
          result.append('<dt>%s\n' % dt_value)
          if i < (num_triples - 1) or len(dd_value) < MAX_DD_LEN:
            # Make sure that dd's end with periods
            # but dont require dt's to.
            if not dd_value.endswith('.'):
              dd_value += '.'
            result.append('<dd>%s\n' % dd_value)
          else:
            period = dd_value.find('.')
            if period < 0:
              period = len(dd_value) - 1
            result.append('<dd>%s\n' % dd_value[0:period + 1])
            runoff = dd_value[period + 1:]

        result.append('</dl>\n')
        result.append(runoff)
    return ''.join(result)

  def AnnotateDocumentation(self, code_obj):
    """Adds properties used to generate better documentation.

    Args:
      code_obj: (CodeObject) The entity to annotate
    """

    description = code_obj.values.get('description')
    if not description:
      return

    # Trailing EOLN should be stripped already.
    if description.endswith('\n'):
      description = description[0:len(description) - 1]

    # Make sure description ends with a period.
    if not description.endswith('.'):
      description += '.'

    # Check for mention about being deprecated.
    if re.match(r'(?:^|\W)deprecated(?:$|\W)', description, re.IGNORECASE):
      code_obj.SetTemplateValue('deprecated', True)

    description = self._DLifyDescription(description)
    code_obj.SetTemplateValue('description', description)

  def AnnotateApiForLanguage(self, the_api):
    super(CppGenerator, self).AnnotateApiForLanguage(the_api)
    unsorted_list = the_api.TopLevelModelClasses()
    have = set()
    sorted_list = []
    for m in unsorted_list:
      self._AddDependencies(the_api, m, have, sorted_list)
    the_api.SetTemplateValue('sortedTopLevelModels', sorted_list)

  def AnnotateApi(self, the_api):
    """Annotate a Api with C++ specific elements."""
    super(CppGenerator, self).AnnotateApi(the_api)
    for schema in the_api.TopLevelModelClasses():
      filename = utilities.UnCamelCase(schema.class_name)
      schema.SetTemplateValue('filename', filename)
      schema.SetTemplateValue(
          'include_path',
          self._HeaderFileName(schema.module.path, schema.values['filename']))
      include_guard = '%s_%s_H_' % (the_api.module.name.upper(),
                                    filename.upper())
      schema.SetTemplateValue('include_guard', include_guard)

    the_api.SetTemplateValue('filename',
                             utilities.UnCamelCase(the_api.class_name))
    the_api.SetTemplateValue(
        'include_path',
        self._HeaderFileName(the_api.module.path, the_api.values['filename']))

    monolithic_source_name = the_api.GetTemplateValue('monolithicSourceName')
    if monolithic_source_name:
      the_api.SetTemplateValue('kitchensink', monolithic_source_name)
    else:
      plain_api_filename = utilities.UnCamelCase(the_api.values['name'])
      the_api.SetTemplateValue('kitchensink', '%s_api' % plain_api_filename)

    authscopes = the_api.values.get('authscopes')
    if authscopes:
      for scope in authscopes:
        self.AnnotateDocumentation(scope)

    self.AnnotateDocumentation(the_api)

  def _AddDependencies(self, the_api, model, have, dep_list):
    if model not in have:
      have.add(model)
      import_manager = cpp_import_manager.CppImportManager.ForElement(model)
      for dependent in import_manager.type_dependencies:
        schema = the_api.SchemaByName(dependent.values['className'])
        self._AddDependencies(the_api, schema, have, dep_list)
      dep_list.append(model)

  def AnnotateMethod(self, the_api, method, unused_rsrc):
    """Override the default."""
    super(CppGenerator, self).AnnotateMethod(the_api, method, unused_rsrc)
    import_manager = cpp_import_manager.CppImportManager.ForElement(the_api)
    request_type = method.values.get('requestType')
    response_type = method.values.get('responseType')
    if request_type:
      self._HandleImports(request_type, import_manager)

    if method.values.get('mediaUpload'):
      media_upload_h = '"googleapis/client/service/media_uploader.h"'
      import_manager.AddImport(media_upload_h)

    if response_type != the_api.void_type:
      request_pager_h = '"googleapis/client/service/service_request_pager.h"'
      self._HandleImports(method.values['responseType'], import_manager)
      if method.values.get('isPageable'):
        import_manager.AddImport(request_pager_h)

    method.SetTemplateValue(
        'undecoratedClassName',
        '%sMethod' % utilities.CamelCase(method.values['wireName']))
    self.AnnotateDocumentation(method)

  def AnnotateParameter(self, unused_method, parameter):
    """Annotate a Parameter with C++ specific elements."""
    super(CppGenerator, self).AnnotateParameter(unused_method, parameter)
    parameter.SetTemplateValue('isPrimitive',
                               self._IsPrimitiveType(parameter.data_type))
    if parameter.data_type.code_type == 'string':
      parameter.SetTemplateValue('parameterCodeType', 'StringPiece')
    else:
      parameter.SetTemplateValue('parameterCodeType',
                                 parameter.data_type.code_type)
    self._HandleImports(parameter)
    self.AnnotateDocumentation(parameter)

  def AnnotateProperty(self, unused_api, prop, unused_schema):
    """Annotate a Property with C++ specific elements."""
    super(CppGenerator, self).AnnotateProperty(unused_api, prop, unused_schema)
    prop.SetTemplateValue('isPrimitive', self._IsPrimitiveType(prop.data_type))
    base_type = prop.data_type
    if base_type.GetTemplateValue('isContainer'):
      base_type = base_type.GetTemplateValue('baseType')

    try:
      has_parent = base_type.parent
    except AttributeError:
      has_parent = False

    if not base_type.GetTemplateValue('builtIn') and not has_parent:
      # Since the property's base type doesn't have a parent, the
      # base type may be safely used by a split accessor definition
      # at the top-level scope.
      #
      # Since the property's base type is not a built-in type, it
      # might be part of a set of mutually recursive types, which
      # can *only* be safely used by a split accessor definition at
      # the top-level scope, after all of the potentially recursive
      # class definitions have been emitted.
      #
      # So: we set the useSplitAccessor template value, causing C++
      # template expansion to declare the accessor methods for this
      # property as part of the object, but to define them separately
      # at the top-level scope.
      prop.SetTemplateValue('useSplitAccessor', True)

    self._HandleImports(prop)
    self.AnnotateDocumentation(prop)

  def AnnotateSchema(self, the_api, schema):
    """Annotate a Schema with C++ specific elements."""

    super(CppGenerator, self).AnnotateSchema(the_api, schema)
    # imports were already handled.

    self.AnnotateDocumentation(schema)

  def _IsPrimitiveType(self, data_type):
    """Determine if data type is representated as a C++ primitive type.

    Args:
      data_type: (DataType) The type to check.
    Returns:
      true if the data type is a primitive type (bool, float, double, int*)
      false otherwise (string, object, array, map).
    """
    return (data_type.json_type == 'integer'
            or data_type.json_type == 'number'
            or data_type.json_type == 'boolean'
            or (hasattr(data_type, 'json_format') and (
                data_type.json_format == 'int64'
                or data_type.json_format == 'uint64'
                or data_type.json_format == 'date'
                or data_type.json_format == 'date-time')))

  def _HandleImports(self, element, import_manager=None):
    """Handles imports for the specified element.

    Args:
      element: (Property|Parameter) The property we want to set the import for.
      import_manager: The import manager to import into if not the implied one.

    """
    # If this is a reference then resolve it so we can check the details.
    element = getattr(element, 'referenced_schema', element)

    # Get the parent of this Property/Parameter.
    if isinstance(element, data_types.ComplexDataType):
      parent = element
      data_type = element
    else:
      parent = element.schema
      data_type = element.data_type

    # If this is a reference then resolve it so we can check the details.
    data_type = getattr(data_type, 'referenced_schema', data_type)

    if not import_manager:
      if self._InnerModelClassesSupported():
        # If inner classes are supported find the top level parent to set
        # imports for.
        while parent.parent:
          parent = parent.parent
      import_manager = cpp_import_manager.CppImportManager.ForElement(parent)

    # For collections, we have to get the imports for the first non-collection
    # up the base_type chain.
    while isinstance(data_type, (data_types.ArrayDataType,
                                 data_types.MapDataType)):
      data_type = data_type._base_type  # pylint: disable=protected-access
      # TODO(user): This should be handled within the core.
      data_type = getattr(data_type, 'referenced_schema', data_type)

    # If we are a reference to a schema that does not resolve, do not fail.
    # Our kitchen sink test API does this. Well formed APIs should not.
    if not data_type:
      return

    json_type = data_type.json_type
    json_format = data_type.values.get('format')
    if json_type == 'object':
      if not data_type.parent:
        import_manager.AddDataType(data_type)
      return

    datatype_and_imports = (
        self.language_model.type_map.get((json_type, json_format)))
    if datatype_and_imports:
      import_definition = datatype_and_imports[1]
      # Import all required imports.
      for required_import in import_definition.imports:
        if required_import:
          import_manager.AddImport(required_import)
      # Set all template values, if specified.
      for template_value in import_definition.template_values:
        element.SetTemplateValue(template_value, True)
    elif data_type:
      if not data_type.parent:
        import_manager.AddDataType(data_type)
    return


class CppLanguageModel(language_model.LanguageModel):
  """A LanguageModel tuned for C++."""

  language = 'cpp'
  member_policy = language_model.NamingPolicy(
      language_model.LOWER_UNCAMEL_CASE, '{name}_', '_')
  getter_policy = language_model.NamingPolicy(
      language_model.LOWER_UNCAMEL_CASE, 'get_{name}', '_')
  setter_policy = language_model.NamingPolicy(
      language_model.LOWER_UNCAMEL_CASE, 'set_{name}', '_')
  has_policy = language_model.NamingPolicy(
      language_model.LOWER_UNCAMEL_CASE, 'has_{name}', '_')
  unset_policy = language_model.NamingPolicy(
      language_model.LOWER_UNCAMEL_CASE, 'clear_{name}', '_')

  parameter_name_policy = language_model.NamingPolicy(
      language_model.LOWER_UNCAMEL_CASE, '{name}', '_',
      conflict_policy=language_model.NamingPolicy(
          language_model.LOWER_UNCAMEL_CASE, '{name}__', '_'))

  # From http://en.cppreference.com/w/cpp/keyword
  _CPP_KEYWORDS = [
      'alignas', 'alignof', 'and', 'and_eq', 'asm', 'auto', 'bitand', 'bitor',
      'bool', 'break', 'case', 'catch', 'char', 'char16_t', 'char32_t',
      'class', 'compl', 'const', 'constexpr', 'const_cast', 'continue',
      'decltype', 'default', 'delete', 'do', 'double', 'dynamic_cast', 'else',
      'enum', 'explicit', 'export', 'extern', 'false', 'float', 'for',
      'friend', 'goto', 'if', 'inline', 'int', 'long', 'mutable', 'namespace',
      'new', 'noexcept', 'not', 'not_eq', 'nullptr', 'operator', 'or', 'or_eq',
      'private', 'protected', 'public', 'register', 'reinterpret_cast',
      'return', 'short', 'signed', 'sizeof', 'static', 'static_assert',
      'static_cast', 'struct', 'switch', 'template', 'this', 'thread_local',
      'throw', 'true', 'try', 'typedef', 'typeid', 'typename', 'union',
      'unsigned', 'using', 'virtual', 'void', 'volatile', 'wchar_t', 'while',
      'xor', 'xor_eq'
      ]

  _SPECIAL_CLASS_NAMES = [
      'JsonCppData', 'SerializableJson'
      ]

  # We can not create classes which match a C++ keyword or built in object
  # type or keyword. However since:
  #   * class names are case-sensitive
  #   * we'll always generate camel-case names (or least starting upper case)
  #   * no C++ keywords are uppercase
  # We only have to worry about classes built into the generator itself.
  # And really we do not need to even do that since they are in a different
  # namespace. But we will for convenience and since it's probably rare.
  RESERVED_CLASS_NAMES = _SPECIAL_CLASS_NAMES

  reserved_words = RESERVED_CLASS_NAMES + _CPP_KEYWORDS

  def __init__(self, options=None):
    super(CppLanguageModel, self).__init__(class_name_delimiter='::',
                                           module_name_delimiter='_')
    self.type_map = self._BuildTypeMap(options)

    self._SUPPORTED_TYPES['boolean'] = self._Boolean
    self._SUPPORTED_TYPES['integer'] = self._Int

  def _BuildTypeMap(self, options=None):
    """Builds the map of discovery document types to C++ types.

    Args:
      options: (dict) Code generator options.

    Returns:
      map of (discovery type, format) keys to (C++ type, import value)
      values where the import value is header file name to include.
    """
    self.global_namespace_ = ''
    self.client_namespace_ = 'client'
    builtin_type_h = None
    integral_type_h = '"googleapis/base/integral_types.h"'
    json_type_h = '"googleapis/client/data/jsoncpp_data.h"'
    # TODO(user): Implement open-source date.h
    date_time_h = '"googleapis/client/util/date_time.h"'
    date_h = date_time_h
    self.date_namespace_ = self.client_namespace_

    # Dictionary of json type and format to its corresponding data type and
    # import definition. The first import in the imports list is the primary
    # import.
    return {
        ('boolean', None): ('bool', ImportDefinition([builtin_type_h])),
        ('any', None): (self.client_namespace_ + '::JsonCppData',
                        ImportDefinition([json_type_h])),
        ('integer', None): ('int32', ImportDefinition([integral_type_h])),
        ('integer', 'int16'): ('int16', ImportDefinition([integral_type_h])),
        ('integer', 'uint16'): ('uint16', ImportDefinition([integral_type_h])),
        ('integer', 'int32'): ('int32', ImportDefinition([integral_type_h])),
        ('integer', 'uint32'): ('uint32', ImportDefinition([integral_type_h])),
        ('number', None): ('double', ImportDefinition([builtin_type_h])),
        ('number', 'double'): ('double', ImportDefinition([builtin_type_h])),
        ('number', 'float'): ('float', ImportDefinition([builtin_type_h])),
        ('object', None): (self.client_namespace_ + '::JsonCppData',
                           ImportDefinition([json_type_h])),
        ('string', None): ('string', ImportDefinition(['<string>'])),
        ('string', 'byte'): ('string', ImportDefinition(['<string>'])),
        ('string', 'date'): (self.date_namespace_ + '::Date',
                             ImportDefinition([date_h])),
        ('string', 'date-time'): (self.client_namespace_ + '::DateTime',
                                  ImportDefinition([date_time_h])),
        ('string', 'google-datetime'): ('string',
                                        ImportDefinition(['<string>'])),
        ('string', 'google-duration'): ('string',
                                        ImportDefinition(['<string>'])),
        ('string', 'int64'): ('int64', ImportDefinition([integral_type_h])),
        ('string', 'uint64'): ('uint64', ImportDefinition([integral_type_h])),
        }

  def _Boolean(self, data_value):
    """Convert provided boolean to language specific literal."""
    return unicode(bool(data_value.value)).lower()

  def _Int(self, data_value):
    """Convert provided int to language specific literal."""
    # Available types can be found in class variables
    code_types = {
        'int16': '%s',
        'uint16': '%s',
        'int32': '%s',
        'uint32': '%s',
        'int64': '%sL',
        'uint64': '%sL',
        }
    try:
      return code_types[data_value.code_type] % long(data_value.value)
    except KeyError:
      raise ValueError(
          ('Provided DataValue (%s) does not present an appropriate C++ '
           'annotated code type (%s).') %
          (data_value.value, data_value.code_type))

  def GetCodeTypeFromDictionary(self, def_dict):
    """Convert a json schema type to a suitable C++ type name.

    Overrides the default.

    Args:
      def_dict: (dict) A dictionary describing Json schema for this Property.
    Returns:
      A name suitable for use as a class in the generator's target language.
    """
    json_type = def_dict.get('type', 'string')
    json_format = def_dict.get('format')

    datatype_and_imports = self.type_map.get((json_type, json_format))
    if datatype_and_imports:
      # If there is an entry in the type format to datatype and imports
      # dictionary set it as the native format.
      native_format = datatype_and_imports[0]
    else:
      # Could not find it in the dictionary, set it to the json type.
      native_format = utilities.CamelCase(json_type)
    return native_format

  def ArrayOf(self, unused_variable, type_name):
    """Take a type name and return the syntax for an array of them.

    Overrides the default.

    Args:
      unused_variable: (DataType) the data we want an array of.
      type_name: (str) A type name.
    Returns:
      A language specific string meaning "an array of type_name".
    """
    # TODO(user): 20120817
    # Need to figure out whether the type is a primitive or not, then
    # return appropriate array type (data, string or primitive).
    return '%s::JsonCppArray<%s >' % (self.client_namespace_, type_name)

  def MapOf(self, unused_variable, type_name):
    """Take a type name and return the syntax for a map of String to them.

    Overrides the default.

    Args:
      unused_variable: (DataType) the data we want an array of.
      type_name: (str) A type name.
    Returns:
      A language specific string meaning "an array of type_name".
    """
    return '%s::JsonCppAssociativeArray<%s >' % (
        self.client_namespace_, type_name)

  def ToMemberName(self, s, the_api):
    """CamelCase a wire format name into a suitable C++ variable name."""
    camel_s = utilities.CamelCase(s)
    if s.lower() in CppLanguageModel.RESERVED_CLASS_NAMES:
      # Prepend the service name
      return '%s%s' % (the_api.values['name'], camel_s)
    return camel_s[0].lower() + camel_s[1:]

  # pylint: disable=unused-argument
  def ToSafeClassName(self, s, the_api, parent=None):
    """Convert a name to a suitable class name in C++.

    Subclasses should override as appropriate.

    Args:
      s: (str) A canonical name for data element. (Usually the API wire format)
      the_api: (Api) The API this element is part of. For use as a hint when the
        name cannot be used directly.
      parent: (schema) The parent we use to get a safe class name.
    Returns:
      A name suitable for use as an element in C++.
    """
    safe_class_name = utilities.CamelCase(s)
    if parent:
      for ancestor in parent.full_path:
        if ancestor.class_name == safe_class_name:
          safe_class_name = '%s%s' % (parent.class_name, safe_class_name)
    if safe_class_name.lower() in CppLanguageModel.RESERVED_CLASS_NAMES:
      # Prepend the service name
      safe_class_name = '%s%s' % (utilities.CamelCase(the_api.values['name']),
                                  utilities.CamelCase(s))
    return safe_class_name

  def DefaultContainerPathForOwner(self, module):
    """Overrides the default implementation."""
    result = ''
    if FLAGS.cpp_generator_add_owner_dir:
      result = module.owner_name.lower().replace(' ', '_')
    return result


class CppApi(api.Api):
  """An Api with C++ annotations."""

  def __init__(self, discovery_doc, **unused_kwargs):
    super(CppApi, self).__init__(discovery_doc)

    # Build the module name from the API name with a trailing '_api'.
    # This guards against empty package names (which would be anonymous)
    # and also avoids some name clashes with built-in names or keywords.
    # We emit only lower-case files to be more C++-like.
    base = self.values['name']
    self.module.SetPath(base.lower() + '_api')

    self.SetTemplateValue('base_include_path', 'googleapis/base')
    self.SetTemplateValue('strings_include_path', 'googleapis/strings')
    self.SetTemplateValue('client_include_path', 'googleapis/client')
    self.SetTemplateValue('global_namespace', 'googleapis')
    self.SetTemplateValue('client_namespace', 'client')
    self.SetTemplateValue('status_type', 'util::Status')

  def TopLevelModelClasses(self):
    """Return the models which are not children of another model.

    Adds an additional constraint on Api.TopLevelModelClasses to remove top
    level schemas which are arrays.

    Returns:
      list of Model.
    """
    return [m for m in self.ModelClasses()
            if not m.parent and not isinstance(m, data_types.ArrayDataType)]

  # pylint: disable=unused-argument
  def ToClassName(self, s, element, element_type=None):
    """Convert a discovery name to a suitable C++ class name.

    In C++, nested class names cannot share the same name as the outer class
    name.

    Overrides the default.

    Args:
      s: (str) A rosy name of data element.
      element: (object) The object we need a class name for.
      element_type: (str) The kind of object we need a class name for.
    Returns:
      A name suitable for use as a class in the generator's target language.
    """
    s = utilities.CamelCase(s)
    if s in CppLanguageModel.RESERVED_CLASS_NAMES:
      s = '%s%s' % (utilities.CamelCase(self.values['name']), s)

    decorator = ''
    if isinstance(element, api.Method):
      resource = element.parent
      while isinstance(resource, api.Resource):
        s = '%s_%s' % (resource.values['className'], s)
        resource = resource.parent
      decorator = 'Method'
    elif isinstance(element, api.Resource):
      decorator = 'Resource'
    elif isinstance(element, api.Api):
      if not s.endswith('Service'):
        decorator = 'Service'
    else:
      return s

    return '%s%s' % (s, decorator)
