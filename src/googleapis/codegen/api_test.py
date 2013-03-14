#!/usr/bin/python2.6
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

"""Tests for api.py."""

__author__ = 'aiuto@google.com (Tony Aiuto)'

import json
import os


import gflags as flags
from google.apputils import basetest

from googleapis.codegen import data_types
from googleapis.codegen import language_model
from googleapis.codegen.api import Api
from googleapis.codegen.api import ApiException
from googleapis.codegen.api import Method
from googleapis.codegen.api import Resource
from googleapis.codegen.api import Schema

FLAGS = flags.FLAGS



class ApiTest(basetest.TestCase):

  # The base discovery doc for most tests.
  _TEST_DISCOVERY_DOC = 'sample_discovery.json'
  _TEST_DISCOVERY_RPC_DOC = 'sample_discovery.rpc.json'
  _TEST_SHARED_TYPES_DOC = 'sample_shared.json'

  def ApiFromDiscoveryDoc(self, path):
    """Load a discovery doc from a file and creates a library Api.

    Args:
      path: (str) The path to the document.

    Returns:
      An Api for that document.
    """

    f = open(os.path.join(os.path.dirname(__file__), 'testdata', path))
    discovery_doc = json.loads(f.read())
    f.close()
    return Api(discovery_doc)

  def testLazySchemaForCreation(self):
    """Check loading schemas which are known to have a forward reference.

    In the test data, "Activity" refers to "Commment", and the nature
    (sorted) of the loading code causes "Activity" to be processed
    before "Commment".  We want to make sure that SchemaFor does the right
    thing with the lazy creation of activity.
    """
    api = self.ApiFromDiscoveryDoc(self._TEST_DISCOVERY_DOC)
    for schema in ['Activity', 'Comment', 'Activity.object']:
      self.assertTrue(isinstance(api._schemas[schema], Schema))

  def SchemaRefInProperties(self):
    """Make sure that an object ref works in a schema properties list."""
    api = self.ApiFromDiscoveryDoc(self._TEST_DISCOVERY_DOC)
    activity_schema = api._schemas['Activity']
    for prop in activity_schema.values['properties']:
      if prop.values['wireName'] == 'object':
        self.assertEquals('ActivityObject',
                          prop.object_type.values['className'])

  def testMakeDefaultSchemaNameFromTheDictTag(self):
    """Use the outer tag as id for schemas which have no id in their dict."""
    discovery_doc = json.loads(
        """
        {
         "name": "fake",
         "version": "v1",
         "schemas": {
           "should_use_id": {
             "id": "named",
             "type": "object",
             "properties": { "dummy": { "type": "string" } }
           },
           "unnamed": {
             "type": "object",
             "properties": { "dummy": { "type": "string" } }
           }
         },
         "resources": {}
        }
        """)
    gen = Api(discovery_doc)
    self.assertTrue('named' in gen._schemas)
    self.assertTrue('unnamed' in gen._schemas)

  def testUnknownHttpMethod(self):
    """Make sure we get an exception on unknown HTTP types."""
    api = Api({'name': 'dummy', 'version': 'v1', 'resources': {}})
    unused_resource = Resource(api, 'temp', {'methods': {}})
    self.assertRaises(ApiException,
                      Method, api, 'bad', {
                          'rpcMethod': 'rpc',
                          'httpMethod': 'Not GET/POST/PUT/DELETE',
                          'parameters': {}
                          })

  def testRequiredParameterList(self):
    """Make sure we are computing required parameters correctly."""
    api = self.ApiFromDiscoveryDoc(self._TEST_DISCOVERY_DOC)

    tests_executed = 0

    for resource in api.values['resources']:
      if resource.values['wireName'] == 'activities':
        for method in resource.values['methods']:
          if method.required_parameters:
            required_names = [p.values['wireName']
                              for p in method.required_parameters]
            self.assertEquals(method.values['parameterOrder'], required_names)
            tests_executed += 1

          if method.values['wireName'] == 'get':
            optional_names = set(p.values['wireName']
                                 for p in method.optional_parameters)
            self.assertEquals(set(['truncateAtom', 'max-comments', 'hl',
                                   'max-liked']),
                              optional_names)
            tests_executed += 1
    self.assertEquals(7, tests_executed)

  def testSchemaLoadingAsString(self):
    """Test for the "schema as strings" representation."""
    api = self.ApiFromDiscoveryDoc('latitude.v1.json')
    self.assertEquals(4, len(api._schemas))

  def testSubResources(self):
    """Test for the APIs with subresources."""

    def CountResourceTree(resource):
      ret = 0
      for r in resource._resources:
        ret += 1 + CountResourceTree(r)
      return ret

    api = self.ApiFromDiscoveryDoc('moderator.v1.json')
    top_level_resources = 0
    total_resources = 0
    non_method_resources = 0
    have_sub_resources = 0
    have_sub_resources_and_methods = 0
    for r in api._resources:
      top_level_resources += 1
      total_resources += 1 + CountResourceTree(r)
      if not r._methods:
        non_method_resources += 1
      if r._resources:
        have_sub_resources += 1
      if r._resources and r._methods:
        have_sub_resources_and_methods += 1
    # Hand counted 18 resources in the file.
    self.assertEquals(18, total_resources)
    self.assertEquals(11, top_level_resources)
    # 4 of them have no methods, only sub resources
    self.assertEquals(4, non_method_resources)
    # 6 of them have sub resources.
    self.assertEquals(6, have_sub_resources)
    # And, of course, 2 should have both sub resources and methods
    self.assertEquals(2, have_sub_resources_and_methods)

  def testArrayOfArray(self):

    class FakeLanguageModel(language_model.LanguageModel):
      def GetCodeTypeFromDictionary(self, def_dict):
        return def_dict.get('type')

      def CodeTypeForArrayOf(self, s):
        return 'Array[%s]' % s

    discovery_doc = {
        'name': 'fake',
        'version': 'v1',
        'schemas': {
            'AdsenseReportsGenerateResponse': {
                'id': 'AdsenseReportsGenerateResponse',
                'type': 'object',
                'properties': {
                    'basic': {
                        'type': 'string'
                        },
                    'simple_array': {
                        'type': 'array',
                        'items': {'type': 'string'}
                        },
                    'array_of_arrays': {
                        'type': 'array',
                        'items': {'type': 'array', 'items': {'type': 'string'}}
                        }
                    }
                }
            },
        'resources': {}
        }
    api = Api(discovery_doc)
    self.language_model = FakeLanguageModel()
    api.VisitAll(lambda o: o.SetLanguageModel(self.language_model))
    response_schema = api._schemas.get('AdsenseReportsGenerateResponse')
    self.assertTrue(response_schema)
    prop = [prop for prop in response_schema.values['properties']
            if prop.values['wireName'] == 'array_of_arrays']
    self.assertTrue(len(prop) == 1)
    prop = prop[0]
    self.assertEquals('Array[Array[string]]', prop.codeType)

  def testDetectInvalidSchema(self):
    bad_discovery = {
        'name': 'fake',
        'version': 'v1',
        'resources': {},
        'schemas': {
            'NoItemsInArray': {'id': 'noitems', 'type': 'array'}
            }
        }
    self.assertRaises(ApiException, Api, bad_discovery)

  def testSchemaWithoutProperties(self):
    fake_discovery = {
        'name': 'fake',
        'version': 'v1',
        'resources': {},
        'schemas': {
            'NoProperties': {'id': 'NoProperties', 'type': 'object'}
            }
        }
    api = Api(fake_discovery)
    for name, schema in api._schemas.items():
      if name == 'NoProperties':
        self.assertEquals(0, len(schema.values.get('properties')))
        return
    self.fail('Did not find NoProperties')

  def testUndefinedSchema(self):
    # This should generated an empty "Bar" class.
    discovery_doc = {
        'name': 'fake',
        'version': 'v1',
        'schemas': {
            'foo': {
                'id': 'foo',
                'type': 'object',
                'properties': {'basic': {'$ref': 'bar'}}
                }
            },
        'resources': {}
        }
    gen = Api(discovery_doc)
    # We expect foo to be in the list because the id is 'foo'
    self.assertTrue('foo' in gen._schemas.keys())
    # We expect 'Foo' to be in the list because that is the class name we would
    # create for foo
    self.assertTrue('foo' in gen._schemas.keys())
    # We do not expect Bar to be in the list because we only have a ref to it
    # but no definition.
    self.assertFalse('Bar' in gen._schemas.keys())

  def testParameters(self):
    api = self.ApiFromDiscoveryDoc(self._TEST_DISCOVERY_DOC)
    activities = FindByWireName(api.values['resources'], 'activities')
    delete = FindByWireName(activities.values['methods'], 'delete')
    self.assertEquals(1, len(delete.query_parameters))
    self.assertEquals(3, len(delete.path_parameters))
    hl = FindByWireName(delete.values['parameters'], 'hl')
    self.assertEquals('query', hl.location)
    post_id = FindByWireName(delete.values['parameters'], 'postId')
    self.assertEquals('path', post_id.location)

  def testEnums(self):
    gen = self.ApiFromDiscoveryDoc('enums.json')
    # Find the method with the enums
    r1 = FindByWireName(gen.values['resources'], 'r1')
    methods = r1.values['methods']
    m1 = FindByWireName(methods, 'm1')
    language = [p for p in m1.values['parameters']
                if p.values['wireName'] == 'language'][0]
    e = language.values['enumType']
    self.assertEquals(m1, e.parent)
    for name, value, desc in e.values['pairs']:
      self.assertTrue(name in ['ENGLISH', 'ITALIAN', 'LANG_ZH_CN',
                               'LANG_ZH_TW'])
      self.assertTrue(value in ['english', 'italian', 'lang_zh-CN',
                                'lang_zh-TW'])
      self.assertTrue(desc in ['English (US)', 'Italian',
                               'Chinese (Simplified)', 'Chinese (Traditional)'])

  def testScopes(self):
    gen = self.ApiFromDiscoveryDoc(self._TEST_DISCOVERY_DOC)
    scopes = gen.GetTemplateValue('authscopes')
    self.assertEquals(2, len(scopes))
    self.assertEquals('https://www.googleapis.com/auth/buzz',
                      scopes[0].GetTemplateValue('value'))
    self.assertEquals('BUZZ',
                      scopes[0].GetTemplateValue('name'))
    self.assertEquals('https://www.googleapis.com/auth/buzz.read-only',
                      scopes[1].GetTemplateValue('value'))
    self.assertEquals('BUZZ_READ_ONLY',
                      scopes[1].GetTemplateValue('name'))

  def testPostVariations(self):
    gen = self.ApiFromDiscoveryDoc('post_variations.json')
    # Check a normal GET method to make sure it has no request and does have
    # a response
    r1 = FindByWireName(gen.values['resources'], 'r1')
    methods = r1.values['methods']
    m = FindByWireName(methods, 'get')
    self.assertIsNone(m.values['requestType'])
    self.assertEquals('Task', m.values['responseType'].class_name)
    # A normal POST with both a request and response
    m = FindByWireName(methods, 'insert')
    self.assertEquals('Task', m.values['requestType'].class_name)
    self.assertEquals('Task', m.values['responseType'].class_name)
    # A POST with neither request nor response
    m = FindByWireName(methods, 'no_request_no_response')
    self.assertIsNone(m.values.get('requestType'))
    self.assertTrue(isinstance(m.values.get('responseType'), data_types.Void))
    # A POST with no request
    m = FindByWireName(methods, 'no_request')
    self.assertIsNone(m.values.get('requestType'))
    self.assertEquals('Task', m.values['responseType'].class_name)
    # A PUT with no response
    m = FindByWireName(methods, 'no_response')
    self.assertEquals('TaskList', m.values['requestType'].class_name)
    self.assertTrue(isinstance(m.values.get('responseType'), data_types.Void))

  def testSchemaParenting(self):
    api = self.ApiFromDiscoveryDoc(self._TEST_DISCOVERY_DOC)
    # Check that top level schemas have no parent
    for schema in ['Activity', 'Comment']:
      self.assertIsNone(api._schemas[schema].parent)
    for schema in ['Person.urls', 'Activity.object',
                   'Activity.object.attachments']:
      self.assertTrue(api._schemas[schema].parent)
    # verify the values in the name to schema map
    for name, schema in api._schemas.items():
      if schema.parent and schema.parent != api:
        wire_name = schema.values['wireName']
        parent_wire_name = schema.parent.values['wireName']
        # Our entry key should never match the wirename of our parent
        self.assertNotEquals(name, parent_wire_name)
        # our key must look like 'p1.p2....parent.me'. We verify that we at
        # least end with 'parent.me'
        self.assertTrue(name.endswith('.'.join([parent_wire_name, wire_name])))

  def testReadingRpcDiscovery(self):
    gen = self.ApiFromDiscoveryDoc(self._TEST_DISCOVERY_RPC_DOC)
    # no resources in RPC
    self.assertEquals(0, len(gen.values['resources']))
    # but we do expect a few methods
    self.assertLess(5, len(gen.values['methods']))
    self.assertGreater(100, len(gen.values['methods']))
    # RPC methods all have an id, httpMethod should be POST and have no path
    for method in gen.values['methods']:
      self.assertIsNotNone(method.values['id'])
      self.assertEquals('POST', method.values['httpMethod'])
      self.assertIsNone(method.values['restPath'])


  def testNormalizeUrlComponents(self):

    googleapis_base = 'https://www.googleapis.com/'
    googleapis_base_old = 'https://www.googleapis.com'

    def LoadApi(discovery_dict):
      d = {'name': 'fake', 'version': 'v1'}
      d.update(discovery_dict)
      api = Api(d)
      self.assertEquals(
          api.values['rootUrl'] + api.values['servicePath'],
          api.values['serviceHost'] + api.values['basePath'])
      return api

    api = LoadApi({})
    self.assertEquals(googleapis_base, api.values['rootUrl'])
    self.assertEquals('fake/v1/', api.values['servicePath'])
    self.assertEquals(googleapis_base_old, api.values['serviceHost'])
    self.assertEquals('/fake/v1/', api.values['basePath'])

    custom_path = '/testing/fake/v1/'
    api = LoadApi({'basePath': custom_path})
    self.assertEquals(googleapis_base, api.values['rootUrl'])
    self.assertEquals('testing/fake/v1/', api.values['servicePath'])
    self.assertEquals(googleapis_base_old, api.values['serviceHost'])
    self.assertEquals(custom_path, api.values['basePath'])

    custom_url = 'https://foo.com/bar/baz/'
    api = LoadApi({'basePath': custom_url})
    self.assertEquals('https://foo.com/', api.values['rootUrl'])
    self.assertEquals('bar/baz/', api.values['servicePath'])
    self.assertEquals('https://foo.com', api.values['serviceHost'])
    self.assertEquals('/bar/baz/', api.values['basePath'])

    # Make sure baseUrl wins over basePath
    api = LoadApi({
        'basePath': '/will/not/be/used/',
        'baseUrl': custom_url
        })
    self.assertEquals('https://foo.com/', api.values['rootUrl'])
    self.assertEquals('bar/baz/', api.values['servicePath'])
    self.assertEquals('https://foo.com', api.values['serviceHost'])
    self.assertEquals('/bar/baz/', api.values['basePath'])

    # Make sure rootUrl wins over all
    api = LoadApi({
        'basePath': '/will/not/be/used/',
        'baseUrl': 'https://bar.com/not/used/',
        'rootUrl': 'https://foo.com/',
        'servicePath': 'bar/baz/',
        })
    self.assertEquals('https://foo.com/', api.values['rootUrl'])
    self.assertEquals('bar/baz/', api.values['servicePath'])
    self.assertEquals('https://foo.com', api.values['serviceHost'])
    self.assertEquals('/bar/baz/', api.values['basePath'])

    # Test Swarm APIs
    api = LoadApi({
        'baseUrl': 'https://localhost.appspot.com/_ah/api/fake/v1/',
        'basePath': '/_ah/api/fake/v1/',
        'rootUrl': 'https://localhost.appspot.com/_ah/api/',
        'servicePath': 'fake/v1/',
        })
    self.assertEquals('https://localhost.appspot.com/_ah/api/',
                      api.values['rootUrl'])
    self.assertEquals('fake/v1/', api.values['servicePath'])
    self.assertEquals('https://localhost.appspot.com',
                      api.values['serviceHost'])
    self.assertEquals('/_ah/api/fake/v1/', api.values['basePath'])

    # .. in path
    self.assertRaises(ValueError, LoadApi, {'basePath': '/do/not/../go/up'})

    # no servicePath
    self.assertRaises(ValueError, LoadApi, {'rootUrl': 'https://foo.com/'})

  def testCanonicalName(self):
    d = {'name': 'fake', 'version': 'v1', 'canonicalName': 'My API'}
    api = Api(d)
    self.assertEquals('fake', api.values['name'])
    self.assertEquals('MyAPI', api._class_name)

  def testNormalizeOwnerInformation(self):
    d = {'name': 'fake', 'version': 'v1'}
    api = Api(d)
    self.assertEquals('Google', api.values['owner'])
    self.assertEquals('google.com', api.values['ownerDomain'])

    d = {'name': 'fake', 'version': 'v1', 'ownerDomain': 'youtube.com'}
    api = Api(d)
    self.assertEquals('Google', api.values['owner'])
    self.assertEquals('youtube.com', api.values['ownerDomain'])

    d = {'name': 'fake', 'version': 'v1',
         'owner': 'You Tube', 'ownerDomain': 'youtube.com'}
    api = Api(d)
    self.assertEquals('You Tube', api.values['owner'])
    self.assertEquals('youtube.com', api.values['ownerDomain'])

  def testSharedTypes(self):
    api = self.ApiFromDiscoveryDoc(self._TEST_SHARED_TYPES_DOC)
    api.VisitAll(lambda o: o.SetLanguageModel(language_model.LanguageModel()))
    # class defined by the API
    photos_feed_schema = api._schemas['PhotosFeed']
    # type defined from a shared type repo
    photo_schema = api._schemas[
        'http://www.googleapis.com/types/v1/com.google/plus/v2/photo']
    self.assertEquals('PhotosFeed', photos_feed_schema.values['wireName'])
    self.assertEquals('com.google.myservice', photos_feed_schema.module.name)
    self.assertEquals('Photo', photo_schema.values['wireName'])
    self.assertEquals('com.google.plus.pictures', photo_schema.module.name)
    self.assertEquals('com/google/plus/pictures', photo_schema.module.path)


class ApiExceptionTest(basetest.TestCase):

  def testExceptionStr(self):
    e = ApiException('foo')
    self.assertEquals('foo', str(e))
    e = ApiException('foo', {'bar': 1})
    self.assertEquals("""foo: {'bar': 1}""", str(e))


def FindByWireName(list_of_resource_or_method, wire_name):
  """Find an element in a list by its "wireName".

  The "wireName" is the name of the method "on the wire", which is the raw name
  as it appears in the JSON.

  Args:
    list_of_resource_or_method: A list of resource or methods as annotated by
      the Api.
    wire_name: (str): the name to fine.

  Returns:
    dict or None
  """
  for x in list_of_resource_or_method:
    if x.values['wireName'] == wire_name:
      return x
  return None


class UnitConvertionTest(basetest.TestCase):
  """Test for unit conversion."""

  def testConvertUploadSize(self):
    m = Method._ConvertUploadSize
    self.assertEquals(None, m(None))
    self.assertEquals(None, m('4'))
    self.assertEquals(None, m('4C'))
    self.assertEquals(4, m('4B'))
    self.assertEquals(4 * 2 ** 10, m('4KB'))
    self.assertEquals(12 * 2 ** 20, m('12MB'))
    self.assertEquals(10 * 2 ** 30, m('10GB'))


if __name__ == '__main__':
  basetest.main()
