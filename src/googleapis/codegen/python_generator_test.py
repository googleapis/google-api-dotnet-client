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

"""Tests for template_objects.py."""

__author__ = 'akesling@google.com (Alex Kesling)'

import json

from google.apputils import basetest

from googleapis.codegen import data_types
from googleapis.codegen import data_value
from googleapis.codegen import python_generator


class PythonLanguageModelDataValueTest(basetest.TestCase):

  def setUp(self):
    self.language_model = python_generator.PythonLanguageModel()

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
    self.assertEqual('True', render_method(dv))

    dv.SetValue(False)
    self.assertEqual('False', render_method(dv))

  def testRenderDictionary(self):
    bar_dv = self._CreateDataValue('bar"', 'string')
    qux_dv = self._CreateDataValue('\\"qux', 'string')
    dv = self._CreateDataValue({'foo': bar_dv, 'baz': qux_dv}, 'object')
    render_method = self.language_model._SUPPORTED_TYPES['object']
    expected = {'foo': 'bar"', 'baz': '\\"qux'}
    got = json.loads(render_method(dv))
    self.assertEqual(expected, got)

  def testRenderList(self):
    bar_dv = self._CreateDataValue('bar"', 'string')
    qux_dv = self._CreateDataValue('\\"qux', 'string')
    dv = self._CreateDataValue([bar_dv, qux_dv], 'array')
    render_method = self.language_model._SUPPORTED_TYPES['array']
    self.assertEqual(
        '["bar\\"", "\\\\\\"qux"]', render_method(dv))

if __name__ == '__main__':
  basetest.main()
