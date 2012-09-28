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

"""Tests for template_objects.py."""

__author__ = 'aiuto@google.com (Tony Aiuto)'


from django import v1_3  # pylint: disable-msg=W0611

from google.apputils import basetest

from googleapis.codegen import api
from googleapis.codegen import data_types
from googleapis.codegen import template_objects
from googleapis.codegen.language_model import LanguageModel


class TemplateObjectsTest(basetest.TestCase):

  def setUp(self):
    super(TemplateObjectsTest, self).setUp()
    self.language_model = LanguageModel(class_name_delimiter='|')

  def testFullyQualifiedClassName(self):
    foo = template_objects.CodeObject({'className': 'Foo'}, None,
                                      language_model=self.language_model)
    bar = template_objects.CodeObject({'className': 'Bar'}, None, parent=foo)
    baz = template_objects.CodeObject({'className': 'Baz'}, None, parent=bar)

    self.assertEquals('Foo|Bar|Baz', baz.fullClassName)
    self.assertEquals('', baz.RelativeClassName(baz))
    self.assertEquals('Baz', baz.RelativeClassName(bar))
    self.assertEquals('Bar|Baz', baz.RelativeClassName(foo))

  def testPackage(self):
    p = template_objects.Package('hello/world',
                                 language_model=self.language_model)
    self.assertEquals('hello|world', p.name)
    self.assertEquals('hello/world', p.path)

  def testPackageParenting(self):
    p = template_objects.Package('hello/world',
                                 language_model=self.language_model)
    child = template_objects.Package('everyone', parent=p)
    self.assertEquals('hello|world|everyone', child.name)
    self.assertEquals('hello/world/everyone', child.path)

  def testPackageNaming(self):
    p = template_objects.Package('hello/world',
                                 language_model=self.language_model)
    foo = template_objects.CodeObject({'className': 'Foo'}, None,
                                      language_model=self.language_model)
    foo.SetTemplateValue('package', p)
    bar = template_objects.CodeObject({'className': 'Bar'}, None, parent=foo)
    baz = template_objects.CodeObject({'className': 'Baz'}, None, parent=bar)

    self.assertEquals('Foo|Bar|Baz', baz.packageRelativeClassName)
    self.assertEquals('hello|world|Foo|Bar|Baz', baz.fullClassName)

  def testParentPath(self):
    foo = template_objects.CodeObject({'className': 'Foo'}, None,
                                      language_model=self.language_model)
    bar = template_objects.CodeObject({'className': 'Bar'}, None, parent=foo)
    baz = template_objects.CodeObject({'className': 'Baz'}, None, parent=bar)
    self.assertEquals(['Foo', 'Bar'], baz.parentPath)

  def testDataValue(self):
    foo_def_dict = {
        'className': 'Foo',
        'type': 'string',
        }
    prototype = data_types.DataType(
        foo_def_dict, None, language_model=self.language_model)
    dv = template_objects.DataValue(3, prototype)

    # Basic Checks
    self.assertEqual(3, dv.value)
    self.assertEqual(prototype, dv.data_type)
    self.assertEqual({}, dv.metadata)
    self.assertEqual('Foo', dv.code_type)

    dv.metadata['foo'] = 'bar'
    self.assertEqual({'foo': 'bar'}, dv.metadata)

    dv.SetValue('four')
    self.assertEqual(dv.value, 'four')

    self.assertEqual(self.language_model, dv.GetLanguageModel())
    other_language_model = LanguageModel(class_name_delimiter='+')
    dv.SetLanguageModel(other_language_model)
    self.assertEqual(other_language_model, dv.GetLanguageModel())

    # Now that we've set a local language model... make sure the codepath
    # for setting the data_type's language model gets exercised.
    self.assertEqual('Foo', dv.code_type)

    # Check that the constructor doesn't freak if an odd object is passed in
    dv = template_objects.DataValue(object, prototype)
    self.assertEqual(dv.value, object)

    # A standard case is the prototype being a Property object.  It is not
    # uncommon that the Property's data_type is a SchemaReference. To verify
    # this case is handled correctly we must fake an API.
    bar_def_dict = {
        'className': 'Foo',
        'type': 'string',
        }

    class MockApi(object):
      def SetSchema(self, schema):
        self.schema = schema

      def SetSchemaRef(self, schema_ref):
        self.schema_ref = schema_ref

      # pylint: disable-msg=W0613
      def ToClassName(self, name, element_type):
        return name

      # pylint: disable-msg=W0613
      def SchemaByName(self, schema_name):
        return self.schema

      # pylint: disable-msg=W0613
      def DataTypeFromJson(self, unused_def_dict, tentative_class_name,
                           parent=None, wire_name=None):
        return self.schema_ref
    mock_api = MockApi()
    schema = api.Schema(mock_api, 'Bar', bar_def_dict)
    mock_api.SetSchema(schema)
    schema_ref = data_types.SchemaReference('Bar', mock_api)
    mock_api.SetSchemaRef(schema_ref)

    prototype = api.Property(mock_api, schema_ref, 'baz', foo_def_dict)
    dv = template_objects.DataValue('3', prototype)
    # Assure all the unwrapping gymnastics in the DataValue constructor did
    # their job correctly.
    self.assertEqual(mock_api.schema, dv.data_type)

if __name__ == '__main__':
  basetest.main()
