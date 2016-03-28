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

"""Tests for cpp_generator."""

__author__ = 'ewiseblatt@google.com (Eric Wiseblatt)'

from google.apputils import basetest
from googleapis.codegen import cpp_generator
from googleapis.codegen import data_types
from googleapis.codegen import data_value


class CppApiTest(basetest.TestCase):

  def testToClassName(self):
    """Test creating safe class names from object names."""
    api = cpp_generator.CppApi({
        'name': 'dummy',
        'version': 'v1',
        'resources': {
            'foo': {
                'methods': {
                    'bar': {
                        'id': 'bar',
                    }
                },
                'resources': {
                    'baz': {
                        'methods': {
                            'qux': {
                                'id': 'qux'
                            }
                        }
                    }
                }
            }
        }
    })
    self.assertEquals('DummyService', api._class_name)
    self.assertEquals('dummy', api.values['name'])

    # We'll capitalize class names. Keywords conflicts arent an
    # issue because keywords are all lowercase.
    self.assertEquals('Foo', api.ToClassName('foo', None))
    self.assertEquals('Class', api.ToClassName('class', None))
    self.assertEquals('Default', api.ToClassName('default', None))
    self.assertEquals('Import', api.ToClassName('import', None))
    self.assertEquals('Object', api.ToClassName('object', None))
    self.assertEquals('String', api.ToClassName('string', None))
    self.assertEquals('True', api.ToClassName('true', None))

    self.assertEquals('DummySerializableJson',
                      api.ToClassName('serializableJson', None))

    # Method and Resource decorate the class name accordingly
    self.assertEquals('Service', api.ToClassName('service', api))
    self.assertEquals('DummyService', api.ToClassName('dummy', api))
    self.assertEquals('DummyserviceService',
                      api.ToClassName('dummyservice', api))
    self.assertEquals('DummyService', api.ToClassName('dummyService', api))

    foo = api._resources[0]
    self.assertEquals('DummyResource', api.ToClassName('dummy', foo))
    self.assertEquals('ResourceResource',
                      api.ToClassName('resource', foo))
    self.assertEquals('AresourceResource',
                      api.ToClassName('Aresource', foo))
    self.assertEquals('AResourceResource',
                      api.ToClassName('AResource', foo))

    bar = foo._methods[0]
    self.assertEquals('FooResource_DummyMethod',
                      api.ToClassName('dummy', bar))
    self.assertEquals('FooResource_MethodMethod',
                      api.ToClassName('method', bar))
    self.assertEquals('FooResource_AmethodMethod',
                      api.ToClassName('amethod', bar))
    self.assertEquals('FooResource_AMethodMethod',
                      api.ToClassName('aMethod', bar))

    baz = foo._resources[0]
    self.assertEquals('DummyResource', api.ToClassName('dummy', baz))

    qux = baz._methods[0]
    self.assertEquals('FooResource_BazResource_DummyMethod',
                      api.ToClassName('dummy', qux))



class CppGeneratorTest(basetest.TestCase):
  def testImportsForArray(self):
    """Test if we get the right imports for an array.

    The goal is to see that an array of a primative type which requires an
    import really works.
    """
    gen = cpp_generator.CppGenerator({
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
    gen.AnnotateApiForLanguage(gen.api)
# TODO(user): 20121010
# This functionality is not yet imported, but keeping this test copied from
# the Java test as a placeholder
#    found_big_integer = False
#    found_date_time = False
#    for schema in gen.api._schemas.values():
#      import_manager = schema.values.get('importManager')
#      for import_list in import_manager.ImportLists():
#        for import_def in import_list:
#          print import_def
#          if import_def.find('BigInteger'):
#            found_big_integer = True
#          if import_def.find('DateTime'):
#            found_date_time = True
#    self.assertTrue(found_big_integer)
#    self.assertTrue(found_date_time)

  def testDefaultPath(self):
    def MakeGen(owner, the_name='fake', package_path=None):
      api_def = {
          'name': the_name,
          'version': 'v1',
          'rootUrl': 'https://test.domain/X%sY' % owner,
          'servicePath': 'fake/v1',
          'domain': 'domain.com',
          'owner': owner,
          }
      if package_path:
        api_def['packagePath'] = package_path
      gen = cpp_generator.CppGenerator(api_def)
      gen.AnnotateApiForLanguage(gen.api)
      return gen

    gen = MakeGen('company')
    self.assertEquals('company/fake_api', gen.api.module.path)

    gen = MakeGen('My Custom App')
    self.assertEquals('mycustomapp/fake_api', gen.api.module.path)

    gen = MakeGen('company', package_path='My/Custom Path')
    self.assertEquals('company/My/CustomPath/fake_api', gen.api.module.path)

    gen = MakeGen('CamelCase')
    self.assertEquals('camelcase/fake_api', gen.api.module.path)

    gen = MakeGen(owner='owner', the_name='mixedCase')
    self.assertEquals('owner/mixedcase_api', gen.api.module.path)


class CppLanguageModelDataValueTest(basetest.TestCase):

  def setUp(self):
    self.language_model = cpp_generator.CppLanguageModel()

  def _CreateDataValue(self, value, val_type):
    def_dict = {
        'className': 'Foo',
        'type': val_type,
        }
    prototype = data_types.DataType(
        def_dict, None, language_model=self.language_model)
    dv = data_value.DataValue(value, prototype)
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

    dv.SetTemplateValue('codeType', 'int16')
    self.assertEqual('42', render_method(dv))
    dv.SetTemplateValue('codeType', 'int32')
    self.assertEqual('42', render_method(dv))
    dv.SetTemplateValue('codeType', 'int64')
    self.assertEqual('42L', render_method(dv))

    dv.SetTemplateValue('codeType', 'uint32')
    self.assertEqual('42', render_method(dv))

    dv = self._CreateDataValue(-1, 'integer')

    # TODO(user): 20121012
    # These are bugs. We're writing the test to document the wrong behavior
    # for now.
    dv.SetTemplateValue('codeType', 'uint32')
    self.assertEqual('-1', render_method(dv))     # -1 isnt unsigned
    dv = self._CreateDataValue(65536, 'integer')
    dv.SetTemplateValue('codeType', 'int16')
    self.assertEqual('65536', render_method(dv))  # 2^16 doesnt fit in an int16


class CppLanguageModelTest(basetest.TestCase):

  def testImports(self):
    gen = cpp_generator.CppGenerator({
        'name': 'dummy',
        'version': 'v1',
        'resources': {},
        'schemas': {
            'Foo': {
                'id': 'Foo',
                'type': 'object',
                'properties': {
                    's': {
                        'type': 'string',
                    }
                }
            },
            'Bar': {
                'id': 'Bar',
                'type': 'object',
                'properties': {
                    'n32': {
                        'type': 'integer',
                        'format': 'int32',
                    },
                    'un64': {
                        'type': 'integer',
                        'format': 'uint64',
                    },
                    'foo': {
                        'type': 'array',
                        'items': {
                            '$ref': 'Foo'
                        }
                    },
                }
            }
        }
    })
    gen.AnnotateApiForLanguage(gen.api)
    foo_schema = gen.api._schemas['Foo']
    self.assertEqual('Foo', foo_schema.values.get('id'))
    foo_import_manager = foo_schema.values.get('importManager')
    self.assertTrue('<string>' in foo_import_manager.platform_imports)

    bar_schema = gen.api._schemas['Bar']
    self.assertEqual('Bar', bar_schema.values.get('id'))

    bar_import_manager = bar_schema.values.get('importManager')
    self.assertTrue('"googleapis/base/integral_types.h"'
                    in bar_import_manager.google_imports)

  def testDocumentation(self):
    """Test if we get the right documentation annotations.
    """
    gen = cpp_generator.CppGenerator(
        discovery={
            'name': 'dummy',
            'version': 'v1',
            'resources': {},
            'schemas': {}
            })

    # No DL case
    self.assertEqual(gen._DLifyDescription('simple text'), 'simple text')

    # No leading text before the <dl>.
    self.assertEqual(
        gen._DLifyDescription(
            'A - description A\nB - description B'),
        '<dl>\n<dt>A\n<dd>description A.\n<dt>B\n<dd>description B.\n</dl>\n')

    # Leading text before the <dl>.
    self.assertEqual(
        gen._DLifyDescription('Text before:'
                              '\nA - description A\nB - description B\n'
                              'Text after.'),
        'Text before:\n<dl>\n<dt>A\n<dd>description A.\n'
        '<dt>B\n<dd>description B.\n</dl>\n'
        'Text after.')

    # No line breaks after last element (short)
    self.assertEqual(
        gen._DLifyDescription('Text before:'
                              '\nA - description A\n- B - description B. '
                              'Text after.'),
        'Text before:\n<dl>\n<dt>A\n<dd>description A.\n'
        '<dt>B\n<dd>description B. Text after.\n</dl>\n')

    # No line breaks after last element (long)
    blurb = (
        'This text is a bit long. At some point it will cross the threshold '
        'where we consider it runoff. That means we will step back and '
        'truncate the last element in the dl list so that it just includes '
        'the first sentence. All the rest of the sentences, such as these, '
        'will appear after we close the dl.')
    self.assertEqual(
        gen._DLifyDescription(
            'Text before:'
            '\nA - description A\n- B - description B. %s' % blurb),
        'Text before:\n<dl>\n<dt>A\n<dd>description A.\n'
        '<dt>B\n<dd>description B.\n</dl>\n %s' % blurb)


  def testReservedWords(self):
    gen = cpp_generator.CppGenerator({
        'name': 'dummy',
        'version': 'v1',
        'schemas': {
            'Bar': {
                'id': 'Bar',
                'type': 'object',
                'properties': {
                    'n32': {
                        'type': 'integer',
                        'format': 'int32',
                        },
                    'class': {
                        'type': 'string',
                        },
                    }
                }
            },
        'resources': {
            'foo': {
                'methods': {
                    'bar': {
                        'id': 'foo.bar',
                        'parameters': {
                            'aJavaStyleName': {
                                'location': 'path',
                                'required': True,
                                'type': 'int',
                                },
                            'namespace': {
                                'location': 'path',
                                'required': True,
                                'type': 'int',
                                },
                            }
                        }
                    }
                }
            }
        })
    gen.AnnotateApiForLanguage(gen.api)
    bar_schema = gen.api.SchemaByName('Bar')
    for p in bar_schema.values['properties']:
      wire_name = p.GetTemplateValue('wireName')
      if wire_name == 'class':
        self.assertEquals('class_', p.memberName)
        self.assertEquals('class__', p.parameterName)

    bar_method = gen.api.MethodByName('foo.bar')
    self.assertEquals(2, len(bar_method.required_parameters))
    for p in bar_method.required_parameters:
      wire_name = p.GetTemplateValue('wireName')
      if wire_name == 'aJavaStyleName':
        self.assertEquals('a_java_style_name_', p.memberName)
        self.assertEquals('a_java_style_name', p.parameterName)
      if wire_name == 'namespace':
        self.assertEquals('namespace_', p.memberName)
        self.assertEquals('namespace__', p.parameterName)


if __name__ == '__main__':
  basetest.main()
