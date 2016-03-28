#!/usr/bin/python2.7
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

"""Tests for cpp_import_manager."""

__author__ = 'ewiseblatt@google.com (Eric Wiseblatt)'

from google.apputils import basetest
from googleapis.codegen.cpp_import_manager import CppImportManager


class MockSchema(object):
  """Mock schema used in place of real schema objects."""

  def __init__(self):
    self._template_values_dict = {}

  def SetTemplateValue(self, template_name, template_value):
    self._template_values_dict[template_name] = template_value

  def GetTemplateValue(self, template_name):
    return self._template_values_dict.get(template_name)


class CppImportManagerTest(basetest.TestCase):

  def setUp(self):
    super(CppImportManagerTest, self).setUp()
    self.mock_schema = MockSchema()
    self.import_manager = CppImportManager(self.mock_schema)

  def testAddImportAndCommit(self):
    # Add a com.google import.
    com_google_import = '"base/integral_types.h"'
    self.assertTrue(self.import_manager.AddImport(com_google_import))
    self.assertFalse(self.import_manager.platform_imports)
    self.assertFalse(self.import_manager.other_imports)
    self.assertTrue(self.import_manager.google_imports)

    # There are no platform imports for C++
    platform_import = '<string>'
    self.assertTrue(self.import_manager.AddImport(platform_import))
    self.assertTrue(self.import_manager.platform_imports)

    # Add a random thing
    other_import = '"Module.h"'
    self.import_manager.AddImport(other_import)

    # Assert the contents of google, other and java imports.
    expected_google_import_set = set()
    expected_google_import_set.add(com_google_import)
    sorted_expected_google_import_set = sorted(expected_google_import_set)
    self.assertEquals(sorted_expected_google_import_set,
                      list(self.import_manager.google_imports))
    self.assertEquals([other_import],
                      list(self.import_manager.other_imports))
    self.assertEquals([platform_import],
                      list(self.import_manager.platform_imports))

    # Assert the contents of class_name_to_qualified_name map.
    self.assertEquals(
        com_google_import,
        self.import_manager._class_name_to_qualified_name[com_google_import])

    # Assert that commit import works.
    # The import_manager combines the platform and google imports together
    # but each segment is first sorted.
    expected_import_list = [
        sorted([platform_import]) + sorted_expected_google_import_set,
        [other_import]]
    self.assertEquals(
        expected_import_list,
        self.mock_schema.GetTemplateValue('importManager').ImportLists())

if __name__ == '__main__':
  basetest.main()
