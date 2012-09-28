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

"""Tests for java_generator."""

__author__ = 'aiuto@google.com (Tony Aiuto)'


from django import v1_3  # pylint: disable-msg=W0611

from google.apputils import basetest
from googleapis.codegen import data_types
from googleapis.codegen import java_generator
from googleapis.codegen import template_objects


class JavaApiTest(basetest.TestCase):

  def testToClassName(self):
    """Test creating safe class names from object names."""
    api = java_generator.JavaApi({
        'name': 'dummy',
        'version': 'v1',
        'resources': {}
        })
    self.assertEquals('Foo', api.ToClassName('foo'))
    self.assertEquals('DummyClass', api.ToClassName('class'))
    self.assertEquals('DummyDefault', api.ToClassName('default'))
    self.assertEquals('DummyImport', api.ToClassName('import'))
    self.assertEquals('DummyObject', api.ToClassName('object'))
    self.assertEquals('DummyString', api.ToClassName('string'))
    self.assertEquals('DummyTrue', api.ToClassName('true'))

  def testGetCodeTypeFromDictionary(self):
    """Test mapping of JSON schema types to Java class names."""
    language_model = java_generator.JavaLanguageModel()
    test_cases = [
        ['String', {'type': 'string', 'format': 'byte'}],
        ['DateTime', {'type': 'string', 'format': 'date-time'}],
        ['Double', {'type': 'number', 'format': 'double'}],
        ['Float', {'type': 'number', 'format': 'float'}],
        ['Short', {'type': 'integer', 'format': 'int16'}],
        ['Integer', {'type': 'integer', 'format': 'int32'}],
        ['Long', {'type': 'string', 'format': 'int64'}],
        ['Object', {'type': 'any'}],
        ['Boolean', {'type': 'boolean'}],
        ['String', {'type': 'string'}],
        ['Long', {'type': 'integer', 'format': 'uint32'}],
        ['UnsignedLong', {'type': 'string', 'format': 'uint64'}],
    ]

    for test_case in test_cases:
      self.assertEquals(
          test_case[0],
          language_model.GetCodeTypeFromDictionary(test_case[1]))


class JavaGeneratorTest(basetest.TestCase):

  def testImportsForArray(self):
    """Test if we get the right imports for an array.

    The goal is to see that an array of a primative type which requires an
    import really works.
    """
    gen = java_generator.JavaGenerator({
        'name': 'dummy',
        'version': 'v1',
        'resources': {},
        'schemas': {
            'Bar': {
                'id': 'Bar',
                'type': 'object',
                'properties': {
                    'p1': {
                        'type': 'array',
                        'items': {
                            'type': 'string',
                            'format': 'uint64'
                            }
                        },
                    'p2': {
                        'type': 'array',
                        'items': {
                            'type': 'array',
                            'items': {
                                'type': 'string',
                                'format': 'date-time'
                                }
                            }
                        }
                    }
                }
            }
        })
    gen.AnnotateApiForLanguage(gen._api)
    found_big_integer = False
    found_date_time = False
    for schema in gen._api._schemas.values():
      import_manager = schema.values.get('importManager')
      for import_list in import_manager.ImportLists():
        for import_def in import_list:
          print import_def
          if import_def.find('BigInteger'):
            found_big_integer = True
          if import_def.find('DateTime'):
            found_date_time = True
    self.assertTrue(found_big_integer)
    self.assertTrue(found_date_time)

  def testDefaultPath(self):
    def MakeGen(host):
      gen = java_generator.JavaGenerator({
          'name': 'fake',
          'version': 'v1',
          'rootUrl': 'https://%s/' % host,
          'servicePath': 'fake/v1'
          })
      gen.api.SetTemplateValue('ownerDomain', host)
      return gen

    gen = MakeGen('google.com')
    self.assertEquals('com/google/api/services/fake',
                      gen.DefaultPackagePath(gen.api))

    gen = MakeGen('my-custom_app.appspot.com')
    self.assertEquals('com/appspot/mycustom_app/api/services/fake',
                      gen.DefaultPackagePath(gen.api))

    gen = MakeGen('localhost')
    self.assertEquals('localhost/api/services/fake',
                      gen.DefaultPackagePath(gen.api))


class JavaLanguageModelTest(basetest.TestCase):
  def setUp(self):
    self.language_model = java_generator.JavaLanguageModel()

  def _CreateDataValue(self, value, val_type):
    def_dict = {
        'className': 'Foo',
        'type': val_type,
        }
    prototype = data_types.DataType(
        def_dict, None, language_model=self.language_model)
    dv = template_objects.DataValue(value, prototype)
    return dv

  def testRenderBoolean(self):
    dv = self._CreateDataValue(True, 'boolean')
    render_method = self.language_model._SUPPORTED_TYPES['boolean']
    self.assertEqual('true', render_method(dv))

    dv.SetValue(False)
    self.assertEqual('false', render_method(dv))

  def testRenderInteger(self):
    dv = self._CreateDataValue(42, 'integer')
    render_method = self.language_model._SUPPORTED_TYPES['integer']
    self.assertRaises(ValueError, render_method, dv)

    dv.SetTemplateValue('codeType', 'Long')
    self.assertEqual('42L', render_method(dv))


if __name__ == '__main__':
  basetest.main()
