#!/usr/bin/python2.7
# Copyright 2011 Google Inc. All Rights Reserved.

"""ObjC library generator.

This module generates a an Objective-C client library for a Discovery based API.
"""

__author__ = 'aiuto@google.com (Tony Aiuto)'

import re
from googleapis.codegen import api
from googleapis.codegen import api_library_generator
from googleapis.codegen import data_types
from googleapis.codegen import language_model
from googleapis.codegen import objc_import_manager
from googleapis.codegen import utilities


class ObjCGenerator(api_library_generator.ApiLibraryGenerator):
  """The ObjC code generator."""

  _FORMAT_TO_TYPE_COMMENT = {
      'int16': 'shortValue',
      'int32': 'intValue',
      'int64': 'longLongValue',
      'uint16': 'unsignedShortValue',
      'uint32': 'unsignedIntValue',
      'uint64': 'unsignedLongLongValue',
      'float': 'floatValue',
      'double': 'doubleValue',
      'byte': 'GTLBase64 can encode/decode (probably web-safe format)'
      }

  # Common parameters are listed at the service level; they apply to all
  # methods. However, there are some that come back from discovery that don't
  # make sense at the method level for the GTL library, so we filter those out.
  _COMMON_PARAMS_TO_SKIP = [
      'alt',  # GTL only supports JSON
      'key',  # GTL handles the API key on the service, per method is need in
              # the ObjectiveC use case.
      'oauth_token',  # GTL handles this on the service.
      'prettyPrint',  # No needed, GTL Logging pretty prints for the developer.
      'userIp',  # Not needed for client software, only needed for servers
                 # making request on behalf of lots of users.
      'quotaUser',  # Another form of userIp.
      ]

  # Regex to match properties needing the NS_RETURNS_NOT_RETAINED directive.
  _NOT_RETAINED = re.compile('^(new|copy|mutableCopy)')

  def __init__(self, discovery, options=None):
    super(ObjCGenerator, self).__init__(
        ObjCApi,
        discovery,
        language='objc',
        language_model=ObjCLanguageModel(options),
        options=options)

  def AnnotateSchema(self, unused_api, schema):
    schema.SetTemplateValue('superClass', 'GTLObject')

  def AnnotateApi(self, api_object):
    api_object.SetTemplateValue('enums', [])
    name = api_object.values['canonicalName']
    api_name_policy = language_model.NamingPolicy(
        language_model.UPPER_CAMEL_CASE)
    camel_case_name = self._language_model.TransformString(
        api_object, name, api_name_policy)
    api_object.SetTemplateValue('serviceName',
                                'GTLService%s' % (camel_case_name))
    rpc_url = api_object.GetTemplateValue('rpcUrl')
    if rpc_url:
      rpc_url += '?prettyPrint=false'
      api_object.SetTemplateValue('rpcUrl', rpc_url)
      # Only generate query class for RPC discovery documents, not REST.
      api_object.SetTemplateValue('query', 'GTLQuery%s' % (camel_case_name))

    api_object.SetTemplateValue(
        'parameters',
        [param for param in api_object.GetTemplateValue('parameters')
         if param.GetTemplateValue('wireName') not in
         self._COMMON_PARAMS_TO_SKIP])

    super(ObjCGenerator, self).AnnotateApi(api_object)

    # Collect all method parameters for combined query class.
    # The query class has properties for all method parameters on the API, with
    # a static method for each API method to generate the appropriate query
    # object. There are likely to be naming clashes where two or more API
    # methods have parameters of the same name but different types. When this
    # happens, we use the 'id' type instead.
    method_parameters = {}
    for method in api_object.GetTemplateValue('methods'):
      for parameter in method.parameters:
        # Check for duplicate
        existing_parameter = method_parameters.get(parameter.codeName)
        if not existing_parameter:
          method_parameters[parameter.codeName] = parameter
        elif existing_parameter.codeType != parameter.codeType:
          # Duplicate exists with mismatched type; synthesise new parameter
          # using 'id' type instead.
          merged_param = api.Parameter(
              api_object,
              parameter.GetTemplateValue('wireName'),
              {
                  'description':
                  '"%s" has different types for some query methods; see the '
                  'documentation for the right type for each query method.'
                  % (parameter.codeName),
                  'wireName': parameter['wireName'],
                  'codeName': parameter.codeName,
              },
              existing_parameter.parent)
          merged_param.SetTemplateValue('codeType', 'id')
          merged_param.SetTemplateValue('attributes', 'nonatomic, retain')
          merged_param.SetTemplateValue('noPointer', True)
          method_parameters[parameter.codeName] = merged_param
    api_object.SetTemplateValue(
        'methodParameters',
        [method_parameters[key] for key in sorted(method_parameters)])

    # Also build a sorted list of all parameters, both common and per-method
    all_parameters = method_parameters.copy()
    for parameter in api_object.GetTemplateValue('parameters'):
      all_parameters[parameter.codeName] = parameter
    api_object.SetTemplateValue(
        'allParameters',
        [all_parameters[key] for key in sorted(all_parameters)])

  def AnnotateProperty(self, api_object, prop, schema):
    """Annotate a Property with ObjC specific elements."""
    if (prop.codeName == 'items' and
        isinstance(prop.data_type, data_types.ArrayDataType)):
      # Set superclass if schema has an items array.
      schema.SetTemplateValue('superClass', 'GTLCollectionObject')

    self.AnnotateParameterOrProperty(prop, schema, api_object)

    # It appears that data_types.Enum is not actually used
    # TODO(user): Once enum properties are handled properly with
    # data_types.Enum, fix this workaround.
    enum_values = prop.data_type.values.get('enum')
    if enum_values and not isinstance(schema, data_types.SchemaReference):
      self.AnnotateEnum(api_object, prop, schema, enum_values)

  def AnnotateEnum(self, api_object, prop, schema, enum_values):
    descriptions = prop.data_type.values.get('enumDescriptions')
    class_name = schema.GetTemplateValue('className')
    property_name = prop.codeName[0].upper() + prop.codeName[1:]
    enum_elements = [
        {
            'value': enum_values[i],
            'description': descriptions and descriptions[i],
            'constantName': self.language_model.TransformString(
                prop,
                enum_values[i].lower(),
                self.language_model.constant_policy)
        }
        for i in range(len(enum_values))]
    enum = {
        'comment': '%s - %s' % (class_name, property_name),
        'className': class_name,
        'propertyName': property_name,
        'elements': enum_elements,
    }
    enums = api_object.GetTemplateValue('enums')
    enums.append(enum)
    api_object.SetTemplateValue('enums', sorted(enums))

  def AnnotateParameter(self, method, parameter):
    self.AnnotateParameterOrProperty(parameter, method.api, method.api)

  def AnnotateParameterOrProperty(self, prop, schema, api_object):
    """Common annotations that apply to both parameters and properties."""
    # Property attributes depend on type
    if prop.data_type.code_type == 'NSString':
      prop.SetTemplateValue('attributes', 'nonatomic, copy')
    else:
      prop.SetTemplateValue('attributes', 'nonatomic, retain')

    # Properties starting with certain strings will cause a clang warning about
    # naming conventions unless we add a directive to stop it.
    if self._NOT_RETAINED.match(prop.codeName):
      prop.SetTemplateValue('clangDirective', ' NS_RETURNS_NOT_RETAINED')

    if isinstance(prop.data_type, data_types.ArrayDataType):
      # Add comment showing type of array elements
      prop.SetTemplateValue('typeComment',
                            'of %s' % (prop.data_type['baseType'].code_type))
      prop.SetTemplateValue('elementCodeType',
                            prop.data_type['baseType'].code_type)
      # If there are any array properties then we need to generate an
      # arrayPropertyToClassMap method.
      schema.SetTemplateValue('arrayPropertyToClassMap', True)
      # If it is an array of enum values then we need to handle the enum type.
      enum_values = prop.data_type['baseType'].values.get('enum')
      if enum_values:
        self.AnnotateEnum(api_object, prop, schema, enum_values)
    elif prop.data_type.code_type in ['NSNumber', 'NSString']:
      if prop.data_type.json_format:
        prop.SetTemplateValue(
            'typeComment',
            self._FORMAT_TO_TYPE_COMMENT.get(prop.data_type.json_format))
    elif prop.GetTemplateValue('type'):
      prop.SetTemplateValue('typeComment', prop.GetTemplateValue('type'))

    # We need to generate a propertyToJSONKeyMap if at least one property has a
    # different code name to wire name.
    if prop.codeName != prop.GetTemplateValue('wireName'):
      schema.SetTemplateValue('propertyToJSONKeyMap', True)

    self.AnnotateType(prop.data_type, schema)

  def AnnotateMethod(self, api_object, method, resource):
    super(ObjCGenerator, self).AnnotateMethod(api_object, method, resource)
    name = method['wireName']
    method.SetTemplateValue(
        'queryCodeName',
        self.language_model.TransformString(
            method,
            name[name.find('.'):],
            self.language_model.query_method_policy))

  def AnnotateType(self, data_type, schema):
    # Import type of property if it is a class
    if (isinstance(data_type, data_types.SchemaReference) or
        isinstance(data_type, api.Schema)):
      import_manager = objc_import_manager.ObjCImportManager.ForElement(schema)
      import_manager.AddDataType(data_type)
    elif isinstance(data_type, data_types.ArrayDataType):
      self.AnnotateType(data_type.GetTemplateValue('baseType'), schema)


class ObjCLanguageModel(language_model.LanguageModel):
  """A LanguageModel for Objective-C."""

  array_of_policy = language_model.NamingPolicy(format_string='NSArray')
  map_of_policy = language_model.NamingPolicy(format_string='NSDictionary')
  constant_policy = language_model.NamingPolicy(
      case_transform=language_model.UPPER_CAMEL_CASE,
      format_string='k{schema.className}_{variable_name}_{name}')
  query_method_policy = language_model.NamingPolicy(
      case_transform=language_model.UPPER_CAMEL_CASE,
      format_string='queryFor{name}')

  _SCHEMA_TYPE_TO_OBJC_TYPE = {
      ('any', None): 'String',
      ('boolean', None): 'NSNumber',
      ('integer', None): 'NSNumber',
      ('integer', 'int16'): 'NSNumber',
      ('integer', 'uint16'): 'NSNumber',
      ('integer', 'int32'): 'NSNumber',
      ('integer', 'uint32'): 'NSNumber',
      ('number', None): 'NSNumber',
      ('number', 'double'): 'NSNumber',
      ('number', 'float'): 'NSNumber',
      ('object', None): 'GTLObject',
      ('string', None): 'NSString',
      ('string', 'byte'): 'NSString',
      ('string', 'date'): 'NSString',
      ('string', 'date-time'): 'GTLDateTime',
      ('string', 'int64'): 'NSNumber',
      ('string', 'uint64'): 'NSNumber',
      }

  # http://www.binpress.com/tutorial/objective-c-reserved-keywords/43
  _OBJC_KEYWORDS = [
      'asm', 'auto', 'break', 'case', 'char', 'const', 'continue', 'default',
      'do', 'double', 'else', 'enum', 'extern', 'float', 'for', 'goto',
      'if', 'inline', 'int', 'long', 'register', 'restrict', 'return', 'short',
      'signed', 'sizeof', 'static', 'struct', 'switch', 'typedef', 'union',
      'unsigned', 'void', 'volatile', 'while', '_Bool', '_Complex',
      '_Imaginary',
      ]
  # C/C++ keywords (including C99 and C++ 0x11)
  _CPP_KEYWORDS = [
      'and', 'alignas', 'alignof', 'bitand', 'bitor', 'bool', 'catch', 'compl',
      'constexpr', 'decltype', 'default', 'delete', 'explicit', 'export',
      'false', 'friend', 'mutable', 'namespace', 'new', 'noexcept', 'not',
      'nullptr', 'operator', 'or', 'private', 'protected', 'public', 'template',
      'this', 'throw', 'true', 'try', 'typeid', 'typename', 'using', 'virtual',
      'xor', 'restrict',
      ]
  _NAMES_TO_AVOID = [
      'bool', 'bycopy', 'byref', 'class', 'id', 'imp', 'in', 'inout', 'nil',
      'no', 'null', 'object', 'oneway', 'out', 'protocol', 'sel', 'self',
      'string', 'super', 'yes', 'atomic', 'nonatomic', 'retain',
      ]

  # We can not create classes which match a ObjC keyword or built in object
  # type.
  RESERVED_CLASS_NAMES = _OBJC_KEYWORDS + _CPP_KEYWORDS + _NAMES_TO_AVOID

  # We can not create data members which are in NSObject or GTLObject.
  RESERVED_MEMBER_NAMES = RESERVED_CLASS_NAMES + [
      # NSObject methods
      'description', 'debugDescription', 'finalize', 'hash', 'dealloc', 'init',
      'superclass', 'retain', 'release', 'autorelease', 'retainCount', 'zone',
      'isProxy', 'classForCoder',
      # Foundation protocol methods
      'copy', 'copyWithZone', 'mutableCopy', 'mutableCopyWithZone',
      # GTLObject methods
      'JSON', 'JSONString', 'surrogates', 'userProperties',
      'additionalJSONKeys', 'additionalProperties', 'userData',
      'fieldsDescription',
      ]
  reserved_words = RESERVED_MEMBER_NAMES

  def __init__(self, options=None):
    super(ObjCLanguageModel, self).__init__()
    self._options = options

  def GetCodeTypeFromDictionary(self, def_dict):
    """Convert a json primitive type to a suitable ObjC type name.

    Overrides the default.

    Args:
      def_dict: (dict) A dictionary describing Json schema for this Property.
    Returns:
      A name suitable for use as a class in the generator's target language.
    """
    json_type = def_dict.get('type', 'string')
    json_format = def_dict.get('format')
    native_format = self._SCHEMA_TYPE_TO_OBJC_TYPE.get((json_type, json_format),
                                                       json_type)
    return native_format

  def ToMemberName(self, s, unused_api):
    """Convert a wire format name into a suitable ObjC variable name."""
    if s.lower() == 'id':  # Special case for id
      return 'identifier'
    camel_s = utilities.CamelCase(s)
    ret = camel_s[0].lower() + camel_s[1:]
    if s.lower() in ObjCLanguageModel.RESERVED_MEMBER_NAMES:
      ret = '%sProperty' % ret
    return ret

  def DefaultContainerPathForOwner(self, module):
    return '/'.join(utilities.ReversedDomainComponents(module.owner_domain))


class ObjCApi(api.Api):
  """An Api with Objective-C annotations."""

  def __init__(self, discovery_doc, **unused_kwargs):
    super(ObjCApi, self).__init__(discovery_doc)

  # pylint: disable=unused-argument
  def ToClassName(self, s, element, element_type=None):
    """Convert a discovery name to a suitable ObjC class name.

    Overrides the default.

    Args:
      s: (str) A rosy name of data element.
      element: (object) The object we need a class name for.
      element_type: (str) The kind of element to name.
    Returns:
      A name suitable for use as a class in the generator's target language.
    """
    if ((s.lower() in ObjCLanguageModel.RESERVED_CLASS_NAMES)
        or isinstance(element, api.Schema)):
      # Prepend the service name
      name = self.values['canonicalName']
      s = '%s%s' % (
          utilities.CamelCase(name).replace(' ', ''),
          utilities.CamelCase(s))
    else:
      s = utilities.CamelCase(s).replace(' ', '')
    if not s.startswith('GTL'):
      return 'GTL' + s
    return s
