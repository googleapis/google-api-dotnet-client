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

__author__ = 'akesling@google.com (Alex Kesling)'


from django import v1_3  # pylint: disable-msg=W0611

from google.apputils import basetest

from googleapis.codegen import data_types
from googleapis.codegen import language_model
from googleapis.codegen import template_objects


class LanguageModelTest(basetest.TestCase):
  def setUp(self):
    self.language_model = language_model.LanguageModel()

  def _CreateDataValue(self, value, val_type):
    def_dict = {
        'className': 'Foo',
        'type': val_type,
        }
    prototype = data_types.DataType(
        def_dict, None, language_model=self.language_model)
    dv = template_objects.DataValue(value, prototype)
    return dv

  def testConstructor(self):
    foo = self.language_model
    bar = language_model.LanguageModel()

    self.assertEqual(
        foo._SUPPORTED_TYPES.keys(), bar._SUPPORTED_TYPES.keys())

    # Assure that if someone screws up overriding SUPPORTED_TYPES mappings
    # in subclasses we complain in the testing layer.
    foo._SUPPORTED_TYPES['bar'] = 'foo'
    self.assertNotEqual(
        foo._SUPPORTED_TYPES.keys(), bar._SUPPORTED_TYPES.keys())

  def testRenderInteger(self):
    dv = self._CreateDataValue(42, 'integer')
    render_method = self.language_model._SUPPORTED_TYPES['integer']
    self.assertEqual('42', render_method(dv))
    dv.SetValue('forty-two')
    self.assertRaises(ValueError, render_method, dv)

  def testRenderFloat(self):
    dv = self._CreateDataValue(4.2, 'number')
    render_method = self.language_model._SUPPORTED_TYPES['number']
    self.assertEqual('4.2', render_method(dv))

    dv.SetValue(4)
    self.assertEqual('4.0', render_method(dv))

    dv.SetValue('four point two')
    self.assertRaises(ValueError, render_method, dv)

    dv.SetValue(float('inf'))
    self.assertRaises(ValueError, render_method, dv)

  def testRenderString(self):
    dv = self._CreateDataValue('foo', 'string')
    render_method = self.language_model._SUPPORTED_TYPES['string']
    self.assertEqual('"foo"', render_method(dv))

    dv.SetValue('foo "bar"')
    self.assertEqual('"foo \\"bar\\""', render_method(dv))

  def testRenderDataValue(self):
    render_method = self.language_model.RenderDataValue

    string_dv = self._CreateDataValue('foo "bar"', 'string')
    self.assertEqual('"foo \\"bar\\""', render_method(string_dv))

    integer_dv = self._CreateDataValue(42, 'integer')
    self.assertEqual('42', render_method(integer_dv))

    float_dv = self._CreateDataValue(4.2, 'number')
    self.assertEqual('4.2', render_method(float_dv))

    float_dv = self._CreateDataValue(4.2, 'I\'m a valid type!')
    self.assertRaises(ValueError, render_method, float_dv)

if __name__ == '__main__':
  basetest.main()
