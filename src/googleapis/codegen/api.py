#!/usr/bin/python2.7
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

"""Create an API definition by interpreting a discovery document.

This module interprets a discovery document to create a tree of classes which
represent the API structure in a way that is useful for generating a library.
For each discovery element (e.g. schemas, resources, methods, ...) there is
a class to represent it which is directly usable in the templates. The
instances of those classes are annotated with extra variables for use
in the template which are language specific.

The current way to make use of this class is to create a programming language
specific subclass of Api, which adds annotations and template variables
appropriate for that language.
TODO(user): Refactor this so that the API can be loaded first, then annotated.
"""

__author__ = 'aiuto@google.com (Tony Aiuto)'

import json
import logging
import operator
import urlparse


from googleapis.codegen import data_types
from googleapis.codegen import template_objects
from googleapis.codegen import utilities

_ADDITIONAL_PROPERTIES = 'additionalProperties'
_DEFAULT_SERVICE_HOST = 'www.googleapis.com'
_DEFAULT_OWNER_DOMAIN = 'google.com'
_DEFAULT_OWNER_NAME = 'Google'


_LOGGER = logging.getLogger('codegen')


class ApiException(Exception):
  """The base class for all API parsing exceptions."""

  def __init__(self, reason, def_dict=None):
    """Create an exception.

    Args:
      reason: (str) The human readable explanation of this exception.
      def_dict: (dict) The discovery dictionary we failed on.
    """
    super(ApiException, self).__init__()
    self._reason = reason
    self._def_dict = def_dict

  def __str__(self):
    if self._def_dict:
      return '%s: %s' % (self._reason, self._def_dict)
    return self._reason


class Api(template_objects.CodeObject):
  """An API definition.

  This class holds a discovery centric definition of an API. It contains
  members such as "resources" and "schemas" which relate directly to discovery
  concepts. It defines several properties that can be used in code generation
  templates:
    name: The API name.
    version: The API version.
    versionNoDots: The API version with all '.' characters replaced with '_'.
        This is typically used in class names.
    versionNoDash: The API version with all '-' characters replaced with '_'.
        This is typically used in file names where '-' has meaning.

    authScopes: The list of the OAuth scopes used by this API.
    dataWrapper: True if the API definition contains the 'dataWrapper' feature.
    methods: The list of top level API methods.
    models: The list of API data models, both from the schema section of
      discovery and from anonymous objects defined in method definitions.
    parameters: The list of global method parameters (applicable to all methods)
    resources: The list of API resources
  """

  def __init__(self, discovery_doc, language=None):
    super(Api, self).__init__(discovery_doc, self,
                              wire_name=discovery_doc['name'])
    name = self.values['name']
    self._validator.ValidateApiName(name)
    if name != 'freebase':
      self._validator.ValidateApiVersion(self.values['version'])
    canonical_name = self.values.get('canonicalName', name)
    self._class_name = self.ToClassName(canonical_name, self)
    # Guard against language implementor not taking care of spaces
    self._class_name = self._class_name.replace(' ', '')
    self._NormalizeOwnerInformation()
    self._language = language
    self._template_dir = None
    self._surface_features = {}
    self._schemas = {}
    self._methods_by_name = {}
    self._all_methods = []

    self.SetTemplateValue('className', self._class_name)
    self.SetTemplateValue('versionNoDots',
                          self.values['version'].replace('.', '_'))
    self.SetTemplateValue('versionNoDash',
                          self.values['version'].replace('-', '_'))
    self.SetTemplateValue('dataWrapper',
                          'dataWrapper' in discovery_doc.get('features', []))
    if not self.values.get('revision'):
      self.values['revision'] = 'snapshot'

    self._NormalizeUrlComponents()

    # Build data types and methods
    self._SetupModules()
    self.void_type = data_types.Void(self)
    self._BuildSchemaDefinitions()
    self._BuildResourceDefinitions()
    self.SetTemplateValue('resources', self._resources)

    # Make data models part of the api dictionary
    self.SetTemplateValue('models', self.ModelClasses())

    # Replace methods dict with Methods
    self._top_level_methods = []
    method_dict = self.values.get('methods') or {}
    for name in sorted(method_dict):
      self._top_level_methods.append(Method(self, name, method_dict[name]))
    self.SetTemplateValue('methods', self._top_level_methods)

    # Global parameters
    self._parameters = []
    param_dict = self.values.get('parameters') or {}
    for name in sorted(param_dict):
      parameter = Parameter(self, name, param_dict[name], self)
      self._parameters.append(parameter)
      if name == 'alt':
        self.SetTemplateValue('alt', parameter)
    self.SetTemplateValue('parameters', self._parameters)

    # Auth scopes
    self._authscopes = []
    if (self.values.get('auth') and
        self.values['auth'].get('oauth2') and
        self.values['auth']['oauth2'].get('scopes')):
      for value, auth_dict in sorted(
          self.values['auth']['oauth2']['scopes'].iteritems()):
        self._authscopes.append(AuthScope(self, value, auth_dict))
      self.SetTemplateValue('authscopes', self._authscopes)

  @property
  def all_schemas(self):
    """The dictionary of all the schema objects found in the API."""
    return self._schemas

  def _SetupModules(self):
    """Compute and set the module(s) which this API belongs under."""
    # The containing module is based on the owner information.
    path = self.values.get('modulePath') or self.values.get('packagePath')
    self._containing_module = template_objects.Module(
        package_path=path,
        owner_name=self.values.get('owner'),
        owner_domain=self.values.get('ownerDomain'))
    self.SetTemplateValue('containingModule', self._containing_module)

    # The API is a child of the containing_module
    base = self.values['name']
    # TODO(user): Introduce a breaking change where we always prefer
    # canonicalName.
    if self.values.get('packagePath'):
      base = self.values.get('canonicalName') or base
    if self.values.get('version_module'):
      base = '%s/%s' % (base, self.values['versionNoDots'])
    self._module = template_objects.Module(package_path=base,
                                           parent=self._containing_module)
    self.SetTemplateValue('module', self._module)

    # The default module for data models defined by this API.
    self._model_module = template_objects.Module(package_path=None,
                                                 parent=self._module)

  def _BuildResourceDefinitions(self):
    """Loop over the resources in the discovery doc and build definitions."""
    self._resources = []
    def_dict = self.values.get('resources') or {}
    for name in sorted(def_dict):
      resource = Resource(self, name, def_dict[name], parent=self)
      self._resources.append(resource)

  def _BuildSchemaDefinitions(self):
    """Loop over the schemas in the discovery doc and build definitions."""
    schemas = self.values.get('schemas')
    if schemas:
      for name, def_dict in schemas.iteritems():
        # Upgrade the string format schema to a dict.
        if isinstance(def_dict, unicode):
          def_dict = json.loads(def_dict)
        self._schemas[name] = self.DataTypeFromJson(def_dict, name)

  def _NormalizeOwnerInformation(self):
    """Ensure that owner and ownerDomain are set to sane values."""
    self.SetTemplateValue('owner',
                          self.values.get('owner') or _DEFAULT_OWNER_NAME)
    domain = self.values.get('ownerDomain', _DEFAULT_OWNER_DOMAIN)
    self.SetTemplateValue('ownerDomain', utilities.SanitizeDomain(domain))

  def _NormalizeUrlComponents(self):
    """Sets template values concerning the path to the service.

    Sets baseUrl, basePath and serviceHost from the values given or defaults
    based on what is available. Verifies them for safeness.  The hierarchy of
    the possible inputs is:
      use rootUrl + servicePath as the best choice if it exists (v1new)
      or use baseUrl (v1)
      or use basePath (v1)
      or restBasePath (v0.3)
      or default to 'api/version'

    Raises:
      ValueError: if the values available are inconsistent or disallowed.
    """
    # If both rootUrl and servicePath exist, they equal what is in baseUrl.
    root_url = self.values.get('rootUrl')
    service_path = self.values.get('servicePath')
    if root_url:
       # TODO(user): Revert to 'if not service_path' once oauth2 is fixed.
      if service_path is None:
        raise ValueError('servicePath is not defined')
      base_url = root_url + service_path
    else:
      base_url = self.values.get('baseUrl')

    # If we have a full path ('https://superman.appspot.com/kryptonite/hurts'),
    # then go with that, otherwise just use the various things which might
    # hint at the servicePath.
    best_path = (base_url
                 or self.values.get('basePath')
                 or self.values.get('restBasePath')
                 or '/%s/%s/' % (self.values['name'], self.values['version']))
    if best_path.find('..') >= 0:
      raise ValueError('api path must not contain ".." (%s)' % best_path)
    # And let urlparse to the grunt work of normalizing and parsing.
    url_parts = urlparse.urlparse(best_path)

    scheme = url_parts.scheme or 'https'
    service_host = url_parts.netloc or _DEFAULT_SERVICE_HOST
    base_path = url_parts.path
    # TODO(user): Replace use of basePath & serviceHost in templates with
    # rootUrl and servicePath
    self._api.SetTemplateValue('basePath', base_path)
    self._api.SetTemplateValue('serviceHost',
                               '%s://%s' % (scheme, service_host))
    if not root_url:
      self._api.SetTemplateValue('rootUrl', '%s://%s/' % (scheme, service_host))
    # TODO(user): Revert to 'if not service_path' once oauth2 is fixed.
    if service_path is None:
      self._api.SetTemplateValue('servicePath', base_path[1:])

    # Make sure template writers do not revert
    self._api.DeleteTemplateValue('baseUrl')

  def ModelClasses(self):
    """Return all the model classes."""
    ret = set(s for s in self._schemas.itervalues() if isinstance(s, Schema))
    return sorted(ret, key=operator.attrgetter('class_name'))

  def TopLevelModelClasses(self):
    """Return the models which are not children of another model."""
    return [m for m in self.ModelClasses() if not m.parent]

  def DataTypeFromJson(self, type_dict, default_name, parent=None,
                       wire_name=None):
    """Returns a schema object represented by a JSON Schema dictionary.

    Evaluate a JSON schema dictionary and return an appropriate schema object.
    If a data type is defined in-line, then create the schema dynamically. If
    the schema is a $ref to another, return the previously created schema or
    a lazy reference.

    If the type_dict is None, a blank schema will be created.

    Args:
      type_dict: A dict of the form expected of a request or response member
        of a method description.   See the Discovery specification for more.
      default_name: The unique name to give the schema if we have to create it.
      parent: The schema where I was referenced. If we cannot determine that
        this is a top level schema, set the parent to this.
      wire_name: The name which will identify objects of this type in data on
        the wire.
    Returns:
      A Schema object.
    """

    # new or not initialized, create a fresh one
    schema = Schema.Create(self, default_name, type_dict or {}, wire_name,
                           parent)
    # Only put it in our by-name list if it is a real object
    if isinstance(schema, Schema):
      # Use the path to the schema as a key. This means that an anonymous class
      # for the 'person' property under the schema 'Activity' will have the
      # unique name 'Activity.person', rather than 'ActivityPerson'.
      path = '.'.join(
          [a.values.get('wireName', '<anon>') for a in schema.full_path])
      _LOGGER.debug('DataTypeFromJson: add %s to cache', path)
      self._schemas[path] = schema
    return schema

  def AddMethod(self, method):
    """Add a new method to the set of all methods."""
    self._all_methods.append(method)
    self._methods_by_name[method.values['id']] = method

  def MethodByName(self, method_name):
    """Find a method by name.

    Args:
      method_name: (str) the full RPC name of a method defined by this API.

    Returns:
      Method object or None if not found.
    """
    return self._methods_by_name.get(method_name)

  def SchemaByName(self, schema_name):
    """Find a schema by name.

    Args:
      schema_name: (str) name of a schema defined by this API.

    Returns:
      Schema object or None if not found.
    """
    return self._schemas.get(schema_name, None)

  def VisitAll(self, func):
    """Visit all nodes of an API tree and apply a function to each.

    Walks a tree and calls a function on each element of it. This should be
    called after the API is fully loaded.

    Args:
      func: (function) Method to call on each object.
    """
    _LOGGER.debug('Applying function to all nodes')
    func(self._containing_module)
    func(self._module)
    func(self._model_module)
    for resource in self.values['resources']:
      self._VisitResource(resource, func)
    # Top level methods
    for method in self.values['methods']:
      self._VisitMethod(method, func)
    for parameter in self.values['parameters']:
      func(parameter)
    for schema in self._schemas.values():
      self._VisitSchema(schema, func)

  def _VisitMethod(self, method, func):
    """Visit a method, calling a function on every child.

    Args:
      method: (Method) The Method to visit.
      func: (function) Method to call on each object.
    """
    func(method)
    for parameter in method.parameters:
      func(parameter)

  def _VisitResource(self, resource, func):
    """Visit a resource tree, calling a function on every child.

    Calls down recursively to sub resources.

    Args:
      resource: (Resource) The Resource to visit.
      func: (function) Method to call on each object.
    """
    func(resource)
    for method in resource.values['methods']:
      self._VisitMethod(method, func)
    for r in resource.values['resources']:
      self._VisitResource(r, func)

  def _VisitSchema(self, schema, func):
    """Visit a schema tree, calling a function on every child.

    Args:
      schema: (Schema) The Schema to visit.
      func: (function) Method to call on each object.
    """
    func(schema)
    func(schema.module)
    for prop in schema.values.get('properties', []):
      func(prop)
    for child in self.children:
      func(child)

  # Do not warn about unused arguments, pylint: disable=unused-argument
  def ToClassName(self, s, element, element_type=None):
    """Convert a name to a suitable class name in the target language.

    This default implementation camel cases the string, which is appropriate
    for some languages.  Subclasses are encouraged to override this.

    Args:
      s: (str) A rosy name of data element.
      element: (object) The object we are making a class name for.
      element_type: (str) Deprecated. The kind of object we are making a class
        name for.  E.g. resource, method, schema.
        TODO(user): replace type in favor of class of element, but that will
        require changing the place where we call ToClassName with no element.
    Returns:
      A name suitable for use as a class in the generator's target language.
    """
    return utilities.CamelCase(s).replace(' ', '')

  @property
  def class_name(self):
    return self.values['className']

  @property
  def model_module(self):
    return self._model_module

  @property
  def containing_module(self):
    return self._containing_module

  @property
  def all_methods(self):
    """All the methods in the entire API."""
    return self._all_methods

  @property
  def top_level_methods(self):
    """All the methods at the API top level (not in a resource)."""
    return self._top_level_methods


class Schema(data_types.ComplexDataType):
  """The definition of a schema."""

  def __init__(self, api, default_name, def_dict, parent=None):
    """Construct a Schema object from a discovery dictionary.

    Schemas represent data models in the API.

    Args:
      api: (Api) the Api instance owning the Schema
      default_name: (str) the default name of the Schema. If there is an 'id'
        member in the definition, that is used for the name instead.
      def_dict: (dict) a discovery dictionary
      parent: (Schema) The containing schema. To be used to establish unique
        names for anonymous sub-schemas.
    """
    super(Schema, self).__init__(default_name, def_dict, api, parent=parent)

    name = def_dict.get('id', default_name)
    _LOGGER.debug('Schema(%s)', name)

    # Protect against malicious discovery
    template_objects.CodeObject.ValidateName(name)
    self.SetTemplateValue('wireName', name)
    class_name = api.ToClassName(name, self, element_type='schema')
    self.SetTemplateValue('className', class_name)
    self.SetTemplateValue('isSchema', True)
    self.SetTemplateValue('properties', [])
    self._module = (template_objects.Module.ModuleFromDictionary(self.values)
                    or api.model_module)

  @classmethod
  def Create(cls, api, default_name, def_dict, wire_name, parent=None):
    """Construct a Schema or DataType from a discovery dictionary.

    Schemas contain either object declarations, simple type declarations, or
    references to other Schemas.  Object declarations conceptually map to real
    classes.  Simple types will map to a target language built-in type.
    References should effectively be replaced by the referenced Schema.

    Args:
      api: (Api) the Api instance owning the Schema
      default_name: (str) the default name of the Schema. If there is an 'id'
        member in the definition, that is used for the name instead.
      def_dict: (dict) a discovery dictionary
      wire_name: The name which will identify objects of this type in data on
        the wire. The path of wire_names can trace an item back through
        discovery.
      parent: (Schema) The containing schema. To be used to establish nesting
        for anonymous sub-schemas.

    Returns:
      A Schema or DataType.

    Raises:
      ApiException: If the definition dict is not correct.
    """

    schema_id = def_dict.get('id')
    if schema_id:
      name = schema_id
    else:
      name = default_name
    class_name = api.ToClassName(name, None, element_type='schema')

    _LOGGER.debug('Create: %s, parent=%s', name,
                  parent.values.get('wireName', '<anon>') if parent else 'None')

    # Schema objects come in several patterns.
    #
    # 1. Simple objects
    #    { type: object, properties: { "foo": {schema} ... }}
    #
    # 2. Maps of objects
    #    { type: object, additionalProperties: { "foo": {inner_schema} ... }}
    #
    #    What we want is a data type which is Map<string, {inner_schema}>
    #    The schema we create here is essentially a built in type which we
    #    don't want to generate a class for.
    #
    # 3. Arrays of objects
    #    { type: array, items: { inner_schema }}
    #
    #    Same kind of issue as the map, but with List<{inner_schema}>
    #
    # 4. Primitive data types, described by type and format.
    #    { type: string, format: int32 }
    #
    # 5. Refs to another schema.
    #    { $ref: name }

    if 'type' in def_dict:
      # The 'type' field of the schema can either be 'array', 'object', or a
      # base json type.
      json_type = def_dict['type']
      if json_type == 'object':
        # Look for full object definition.  You can have properties or
        # additionalProperties, but it does not  do anything useful to have
        # both.

        # Replace properties dict with Property's
        props = def_dict.get('properties')
        if props:
          # This case 1 from above
          return cls._CreateObjectWithProperties(props, api, name,
                                                 def_dict, wire_name, parent)

        # Look for case 2
        additional_props = def_dict.get(_ADDITIONAL_PROPERTIES)
        if additional_props:
          return cls._CreateMapType(additional_props, api, name, wire_name,
                                    class_name, parent)

        # no properties
        return cls._CreateSchemaWithoutProperties(api, name, def_dict,
                                                  wire_name, parent)

      elif json_type == 'array':
        # Case 3: Look for array definition
        return cls._CreateArrayType(api, def_dict, wire_name, class_name,
                                    schema_id, parent)
      else:
        # Case 4: This must be a basic type.  Create a DataType for it.
        return data_types.PrimitiveDataType(def_dict, api, parent=parent)

    referenced_schema = def_dict.get('$ref')
    if referenced_schema:
      # Case 5: Reference to another Schema.
      #
      # There are 4 ways you can see '$ref' in discovery.
      # 1. In a property of a schema or a method request/response, pointing
      #    back to a previously defined schema
      # 2. As above, pointing to something not defined yet.
      # 3. In a method request or response or property of a schema pointing to
      #    something undefined.
      #
      # For case 1, the schema will be in the API name to schema map.
      #
      # For case 2, just creating this placeholder here is fine.  When the
      # actual schema is hit in the loop in _BuildSchemaDefinitions, we will
      # replace the entry and DataTypeFromJson will resolve the to the new def.
      #
      # For case 3, we will end up with a dangling reference and fail later.
      schema = api.SchemaByName(referenced_schema)
      # The stored "schema" may not be an instance of Schema, but rather a
      # data_types.PrimitiveDataType, which has no 'wireName' value.
      if schema:
        _LOGGER.debug('Schema.Create: %s => %s',
                      default_name, schema.values.get('wireName', '<unknown>'))
        return schema
      return data_types.SchemaReference(referenced_schema, api)

    raise ApiException('Cannot decode JSON Schema for: %s' % def_dict)

  @classmethod
  def _CreateObjectWithProperties(cls, props, api, name, def_dict,
                                  wire_name, parent):

    properties = []
    schema = cls(api, name, def_dict, parent=parent)
    if wire_name:
      schema.SetTemplateValue('wireName', wire_name)
    for prop_name in sorted(props):
      prop_dict = props[prop_name]
      _LOGGER.debug('  adding prop: %s to %s', prop_name, name)
      properties.append(Property(api, schema, prop_name, prop_dict))
      # Some APIs express etag directly in the response, others don't.
      # Knowing that we have it explicitly makes special case code generation
      # easier
      if prop_name == 'etag':
        schema.SetTemplateValue('hasEtagProperty', True)
    schema.SetTemplateValue('properties', properties)
    return schema

  @classmethod
  def _CreateMapType(cls, additional_props, api, name, wire_name,
                     class_name, parent):
    _LOGGER.debug('Have only additionalProps for %s, dict=%s',
                  name, additional_props)
    # TODO(user): Remove this hack at the next large breaking change
    # The "Items" added to the end is unneeded and ugly. This is for
    # temporary backwards compatibility.  Same for _CreateArrayType().
    if additional_props.get('type') == 'array':
      name = '%sItem' % name
    subtype_name = additional_props.get('id', name + 'Element')
    # Note, since this is an interim, non class just to hold the map
    # make the parent schema the parent passed in, not myself.
    _LOGGER.debug('name:%s, wire_name:%s, subtype name %s', name, wire_name,
                  subtype_name)
    # When there is a parent, we synthesize a wirename when none exists.
    # Purpose is to avoid generating an extremely long class name, since we
    # don't do so for other nested classes.
    if parent and wire_name:
      base_wire_name = wire_name + 'Element'
    else:
      base_wire_name = None

    base_type = api.DataTypeFromJson(
        additional_props, subtype_name, parent=parent,
        wire_name=base_wire_name)
    map_type = data_types.MapDataType(name, base_type, parent=parent,
                                      wire_name=wire_name)
    _LOGGER.debug('  %s is MapOf<string, %s>',
                  class_name, base_type.class_name)
    return map_type

  @classmethod
  def _CreateSchemaWithoutProperties(cls, api, name, def_dict, wire_name,
                                     parent):
    if parent:
      # code objects have __getitem__(), but not .get()
      try:
        pname = parent['id']
      except KeyError:
        pname = '<unknown>'
      name_to_log = '%s.%s' % (pname, name)
    else:
      name_to_log = name
    logging.warning('object without properties %s: %s',
                    name_to_log, def_dict)
    schema = cls(api, name, def_dict, parent=parent)
    if wire_name:
      schema.SetTemplateValue('wireName', wire_name)
    return schema

  @classmethod
  def _CreateArrayType(cls, api, def_dict, wire_name,
                       class_name, schema_id, parent):
    items = def_dict.get('items')
    if not items:
      raise ApiException('array without items in: %s' % def_dict)
    tentative_class_name = class_name
    # TODO(user): THIS IS STUPID. We should not rename things items.
    # if we have an anonymous type within a map or array, it should be
    # called 'Item', and let the namespacing sort it out.
    if schema_id:
      _LOGGER.debug('Top level schema %s is an array', class_name)
      tentative_class_name += 'Items'
    base_type = api.DataTypeFromJson(items, tentative_class_name,
                                     parent=parent, wire_name=wire_name)
    _LOGGER.debug('  %s is ArrayOf<%s>', class_name, base_type.class_name)
    array_type = data_types.ArrayDataType(tentative_class_name, base_type,
                                          wire_name=wire_name,
                                          parent=parent)
    if schema_id:
      array_type.SetTemplateValue('className', schema_id)
    return array_type

  @property
  def class_name(self):
    return self.values['className']


class Property(template_objects.CodeObject):
  """The definition of a schema property.

  Example property in the discovery schema:
      "id": {"type": "string"}
  """

  def __init__(self, api, schema, name, def_dict):
    """Construct a Property.

    A Property requires several elements in its template value dictionary which
    are set here:
      wireName: the string which labels this Property in the JSON serialization.
      dataType: the DataType of this property.

    Args:
      api: (Api) The Api which owns this Property
      schema: (Schema) the schema this Property is part of
      name: (string) the name for this Property
      def_dict: (dict) the JSON schema dictionary

    Raises:
      ApiException: If we have an array type without object definitions.
    """
    super(Property, self).__init__(def_dict, api, wire_name=name)
    self.ValidateName(name)
    self.schema = schema
    # If the schema value for this property defines a new object directly,
    # rather than refering to another schema, we will have to create a class
    # name for it.   We create a unique name by prepending the schema we are
    # in to the object name.
    tentative_class_name = '%s%s' % (schema.class_name,
                                     utilities.CamelCase(name))
    self._data_type = api.DataTypeFromJson(def_dict, tentative_class_name,
                                           parent=schema, wire_name=name)

  @property
  def code_type(self):
    if self._language_model:
      self._data_type.SetLanguageModel(self._language_model)
    return self._data_type.code_type

  @property
  def safe_code_type(self):
    if self._language_model:
      self._data_type.SetLanguageModel(self._language_model)
    return self._data_type.safe_code_type

  @property
  def data_type(self):
    return self._data_type


class Resource(template_objects.CodeObject):

  def __init__(self, api, name, def_dict, parent=None):
    """Creates a Resource.

    Args:
      api: (Api) The Api which owns this Resource.
      name: (string) The discovery name of the Resource.
      def_dict: (dict) The discovery dictionary for this Resource.
      parent: (CodeObject) The resource containing this method, if any. Top
         level resources have the API as a parent.
    """
    super(Resource, self).__init__(def_dict, api, parent=parent, wire_name=name)
    self.ValidateName(name)
    class_name = api.ToClassName(name, self, element_type='resource')
    self.SetTemplateValue('className', class_name)
    # Replace methods dict with Methods
    self._methods = []
    method_dict = self.values.get('methods') or {}
    for name in sorted(method_dict):
      self._methods.append(Method(api, name, method_dict[name], parent=self))
    self.SetTemplateValue('methods', self._methods)
    # Get sub resources
    self._resources = []
    r_def_dict = self.values.get('resources') or {}
    for name in sorted(r_def_dict):
      r = Resource(api, name, r_def_dict[name], parent=self)
      self._resources.append(r)
    self.SetTemplateValue('resources', self._resources)

  @property
  def methods(self):
    return self._methods


class AuthScope(template_objects.CodeObject):
  """The definition of an auth scope."""

  def __init__(self, api, value, def_dict):
    """Construct an auth scope.

    Args:
      api: (Api) The Api which owns this Property
      value: (string) The unique identifier of this scope, often a URL
      def_dict: (dict) The discovery dictionary for this auth scope.
    """
    super(AuthScope, self).__init__(def_dict, api)
    # Strip the common prefix to get a unique identifying name
    prefix_len = len('https://www.googleapis.com/auth/')
    self.SetTemplateValue('name', value[prefix_len:].upper()
                          .replace('.', '_')
                          .replace('-', '_'))
    self.SetTemplateValue('value', value)


class Method(template_objects.CodeObject):
  """The definition of a method."""

  def __init__(self, api, name, def_dict, parent=None):
    """Construct a method.

    Methods in REST discovery are inside of a resource. Note that the method
    name and id are calculable from each other. id will always be equal to
    api_name.resource_name[.sub_resource...].method_name.  At least it should
    be, as that is the transformation Discovery makes from the API definition,
    which is essentially a flat list of methods, into a hierarchy of resources.

    Args:
      api: (Api) The Api which owns this Method.
      name: (string) The discovery name of the Method.
      def_dict: (dict) The discovery dictionary for this Method.
      parent: (CodeObject) The resource containing this Method, if any.

    Raises:
      ApiException: If the httpMethod type is not one we know how to
          handle.
    """
    super(Method, self).__init__(def_dict, api, parent=parent)
    # TODO(user): Fix java templates to name vs. wireName correctly. Then
    # change the __init__ to have wire_name=def_dict.get('id') or name
    # then eliminate this line.
    self.SetTemplateValue('wireName', name)
    self.ValidateName(name)
    class_name = api.ToClassName(name, self, element_type='method')
    if parent and class_name == parent.values['className']:
      # Some languages complain when the collection name is the same as the
      # method name.
      class_name = '%sRequest' % class_name
    # The name is the key of the dict defining use. The id field is what you
    # have to use to call the method via RPC. That is unique, name might not be.
    self.SetTemplateValue('name', name)
    # Fix up very old discovery, which does not have an id.
    if 'id' not in self.values:
      self.values['id'] = name
    self.SetTemplateValue('className', class_name)
    http_method = def_dict.get('httpMethod', 'POST').upper()
    self.SetTemplateValue('httpMethod', http_method)
    self.SetTemplateValue('rpcMethod',
                          def_dict.get('rpcMethod') or def_dict['id'])
    rest_path = def_dict.get('path') or def_dict.get('restPath')
    # TODO(user): if rest_path is not set, raise a good error and fail fast.
    self.SetTemplateValue('restPath', rest_path)

    # Figure out the input and output types and schemas for this method.
    expected_request = self.values.get('request')
    if expected_request:
      # TODO(user): RequestBody is only used if the schema is anonymous.
      # When we go to nested models, this could be a nested class off the
      # Method, making it unique without the silly name.  Same for ResponseBody.
      request_schema = api.DataTypeFromJson(expected_request,
                                            '%sRequestContent' % name,
                                            parent=self)
      self.SetTemplateValue('requestType', request_schema)

    expected_response = def_dict.get('response') or def_dict.get('returns')
    if expected_response:
      response_schema = api.DataTypeFromJson(expected_response,
                                             '%sResponse' % name,
                                             parent=self)
      self.SetTemplateValue('responseType', response_schema)
    else:
      self.SetTemplateValue('responseType', api.void_type)
    # Make sure we can handle this method type and do any fixups.
    if http_method not in ['DELETE', 'GET', 'OPTIONS', 'PATCH', 'POST', 'PUT',
                           'PROPFIND', 'PROPPATCH', 'REPORT']:
      raise ApiException('Unknown HTTP method: %s' % http_method, def_dict)
    if http_method == 'GET':
      self.SetTemplateValue('requestType', None)

    # Replace parameters dict with Parameters.  We try to order them by their
    # position in the request path so that the generated code can track the
    # more human readable definition, rather than the order of the parameters
    # in the discovery doc.
    order = self.values.get('parameterOrder', [])
    req_parameters = []
    opt_parameters = []
    for name, def_dict in self.values.get('parameters', {}).iteritems():
      param = Parameter(api, name, def_dict, self)
      if name == 'alt':
        # Treat the alt parameter differently
        self.SetTemplateValue('alt', param)
        continue

      # Standard params are part of the generic request class
      # We want to push all parameters that aren't declared inside
      # parameterOrder after those that are.
      if param.values['wireName'] in order:
        req_parameters.append(param)
      else:
        # optional parameters are appended in the order they're declared.
        opt_parameters.append(param)
    # pylint: disable=g-long-lambda
    req_parameters.sort(lambda x, y: cmp(order.index(x.values['wireName']),
                                         order.index(y.values['wireName'])))
    req_parameters.extend(opt_parameters)
    self.SetTemplateValue('parameters', req_parameters)

    self._InitMediaUpload(parent)
    self._InitPageable(api)
    api.AddMethod(self)

  def _InitMediaUpload(self, parent):
    media_upload = self.values.get('mediaUpload')
    if media_upload:
      if parent:
        parent.SetTemplateValue('isMedia', True)
      # Get which MIME Media Ranges are accepted for media uploads to this
      # method.
      accepted_mime_ranges = media_upload.get('accept')
      self.SetTemplateValue('accepted_mime_ranges', accepted_mime_ranges)
      max_size = media_upload.get('maxSize')
      self.SetTemplateValue('max_size', max_size)
      self.SetTemplateValue('max_size_bytes',
                            self._ConvertUploadSize(max_size))
      # Find which upload protocols are supported.
      upload_protocols = media_upload['protocols']
      for upload_protocol in upload_protocols:
        self._SetUploadTemplateValues(
            upload_protocol, upload_protocols[upload_protocol])

  def _InitPageable(self, api):
    response_type = self.values.get('responseType')
    if (response_type != api.void_type
        and self.FindCodeObjectWithWireName(
            response_type.values.get('properties'), 'nextPageToken')
        and self.FindCodeObjectWithWireName(
            self.optional_parameters, 'pageToken')):
      self.SetTemplateValue('isPageable', True)

  @staticmethod
  def _ConvertUploadSize(size):
    """Convert a size like 10G/K/M/B to a number."""
    # See Java implementation at:
    if not size:
      return None
    units = [('GB', 2 ** 30),
             ('MB', 2 ** 20),
             ('KB', 2 ** 10),
             ('B', 1)]
    size = size.upper()
    for suffix, multiplier in units:
      if size.endswith(suffix):
        num_units = size[:-len(suffix)]
        try:
          return int(num_units) * multiplier
        except (ValueError, KeyError):
          break
    return None

  def _SetUploadTemplateValues(self, upload_protocol, protocol_dict):
    """Sets upload specific template values.

    Args:
      upload_protocol: (str) The name of the upload protocol. Eg: 'simple' or
        'resumable'.
      protocol_dict: (dict) The dictionary that corresponds to this upload
        protocol. It typically contains keys like 'path', 'multipart' etc.
    """
    self.SetTemplateValue('%s_upload_supported' % upload_protocol, True)
    upload_path = protocol_dict.get('path')
    if upload_path:
      self.SetTemplateValue('%s_upload_path' % upload_protocol, upload_path)
      self.SetTemplateValue('%s_upload_multipart' % upload_protocol,
                            protocol_dict.get('multipart', False))

  @property
  def media_upload_parameters(self):
    return self.values.get('mediaUpload')

  @property
  def parameters(self):
    return self.values['parameters']

  @property
  def optional_parameters(self):
    return [p for p in self.values['parameters'] if not p.required]

  @property
  def required_parameters(self):
    return [p for p in self.values['parameters'] if p.required]

  @property
  def path_parameters(self):
    return [p for p in self.values['parameters'] if p.location == 'path']

  @property
  def query_parameters(self):
    return [p for p in self.values['parameters'] if p.location == 'query']

  @staticmethod
  def FindCodeObjectWithWireName(things, wire_name):
    """Looks for an element having the given wire_name.

    Args:
      things: (array of DataType) List of parameters or properties to search.
      wire_name: (str) The wireName we are looking to find.

    Returns:
      None or element with the given wire_name.
    """
    if not things: return None
    for e in things:
      if e.values['wireName'] == wire_name: return e
    return None

  #
  # Expose some properties with the naming convention we use in templates
  #
  def optionalParameters(self):  # pylint: disable=g-bad-name
    return self.optional_parameters

  def requiredParameters(self):  # pylint: disable=g-bad-name
    return self.required_parameters

  def pathParameters(self):  # pylint: disable=g-bad-name
    return self.path_parameters

  def queryParameters(self):  # pylint: disable=g-bad-name
    return self.query_parameters


class Parameter(template_objects.CodeObject):
  """The definition of a method parameter."""

  def __init__(self, api, name, def_dict, method):
    super(Parameter, self).__init__(def_dict, api, parent=method,
                                    wire_name=name)
    self.ValidateName(name)
    self.schema = api

    # TODO(user): Deal with dots in names better. What we should do is:
    # For x.y, x.z create a little class X, with members y and z. Then
    # have the constructor method take an X.

    self._repeated = self.values.get('repeated', False)
    self._required = self.values.get('required', False)
    self._location = (self.values.get('location')
                      or self.values.get('restParameterType')
                      or 'query')
    self._data_type = data_types.PrimitiveDataType(def_dict, api, parent=self)
    if self._repeated:
      self._data_type = data_types.ArrayDataType(name, self._data_type,
                                                 parent=self)

    if self.values.get('enum'):
      enum = data_types.Enum(api,
                             name,
                             self._data_type,
                             self.values.get('enum'),
                             self.values.get('enumDescriptions'),
                             parent=method)
      self.SetTemplateValue('enumType', enum)

  @property
  def repeated(self):
    return self._repeated

  @property
  def required(self):
    return self._required

  @property
  def location(self):
    return self._location

  @property
  def code_type(self):
    return self._data_type.code_type

  @property
  def data_type(self):
    return self._data_type
