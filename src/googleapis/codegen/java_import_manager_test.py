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

"""Tests for java_import_manager."""

__author__ = 'rmistry@google.com (Ravi Mistry)'

from google.apputils import basetest
from googleapis.codegen.java_import_manager import JavaImportManager


class MockSchema(object):
  """Mock schema used in place of real schema objects."""

  def __init__(self):
    self._template_values_dict = {}

  def SetTemplateValue(self, template_name, template_value):
    self._template_values_dict[template_name] = template_value

  def GetTemplateValue(self, template_name):
    return self._template_values_dict.get(template_name)


class JavaImportManagerTest(basetest.TestCase):

  def setUp(self):
    super(JavaImportManagerTest, self).setUp()
    self.mock_schema = MockSchema()
    self.import_manager = JavaImportManager(self.mock_schema)

  def testAddImportAndCommit(self):
    # Try to add a java.lang import. It should not add an import but still
    # return True since it is added by default.
    self.assertTrue(self.import_manager.AddImport('java.lang.String'))
    self.assertFalse(self.import_manager.google_imports)
    self.assertFalse(self.import_manager.other_imports)
    self.assertFalse(self.import_manager.java_imports)

    # Add a com.google import.
    com_google_import = 'com.google.api.client.util.DateTime'
    self.assertTrue(self.import_manager.AddImport(com_google_import))

    # Add a java.util import.
    java_util_import = 'java.util.Map'
    self.assertTrue(self.import_manager.AddImport(java_util_import))

    # Add a random thing
    other_namespace_import = 'org.foo.bar'
    self.import_manager.AddImport(other_namespace_import)

    # Assert the contents of google, other and java imports.
    self.assertEquals([com_google_import], self.import_manager.google_imports)
    self.assertEquals([other_namespace_import],
                      self.import_manager.other_imports)
    self.assertEquals([java_util_import], self.import_manager.java_imports)

    # Assert the contents of class_name_to_qualified_name map.
    self.assertEquals(java_util_import,
                      self.import_manager._class_name_to_qualified_name['Map'])
    self.assertEquals(
        com_google_import,
        self.import_manager._class_name_to_qualified_name['DateTime'])

    # Assert that commit import works.
    expected_import_list = [
        [com_google_import],
        [java_util_import],
        [other_namespace_import]]
    self.assertEquals(
        expected_import_list,
        self.mock_schema.GetTemplateValue('importManager').ImportLists())

  def testAddImportConflictingNames(self):
    datetime1_import = 'com.google.api.client.util.DateTime'
    datetime2_import = 'com.test.testing.util.DateTime'
    self.assertTrue(self.import_manager.AddImport(datetime1_import))
    # Adding the 2nd datetime import should return a false since the name
    # is already imported.
    self.assertFalse(self.import_manager.AddImport(datetime2_import))
    self.assertEquals(
        datetime1_import,
        self.import_manager._class_name_to_qualified_name['DateTime'])

  def testGetClassName(self):
    self.assertEqual('Boolean',
                     self.import_manager.GetClassName('java.lang.Boolean'))


if __name__ == '__main__':
  basetest.main()
