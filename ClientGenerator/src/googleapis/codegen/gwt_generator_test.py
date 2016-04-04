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

"""Tests for gwt_generator."""

__author__ = 'yanivi@google.com (Yaniv Inbar)'



from google.apputils import basetest
from googleapis.codegen import gwt_generator


class GwtApiTest(basetest.TestCase):

  def testGetCodeTypeFromDictionary(self):
    """Test mapping of JSON schema types to GWT/Java class names."""
    language_model = gwt_generator.GwtLanguageModel()

    test_cases = [
        ['String', {'type': 'string', 'format': 'byte'}],
        ['String', {'type': 'string', 'format': 'date-time'}],
        ['Double', {'type': 'number', 'format': 'double'}],
        ['Float', {'type': 'number', 'format': 'float'}],
        ['Short', {'type': 'integer', 'format': 'int16'}],
        ['Integer', {'type': 'integer', 'format': 'int32'}],
        ['Long', {'type': 'string', 'format': 'int64'}],
        ['String', {'type': 'any'}],
        ['Boolean', {'type': 'boolean'}],
        ['String', {'type': 'string'}],
        ['Long', {'type': 'integer', 'format': 'uint32'}],
        ['BigInteger', {'type': 'string', 'format': 'uint64'}],
    ]

    for test_case in test_cases:
      self.assertEquals(
          test_case[0],
          language_model.GetCodeTypeFromDictionary(test_case[1]))
      # TODO(user) Create Property objects, make sure they have the right
      # langauge model and see that prop.codeType == test_case[0]

  # TODO(user): Add tests for import side effects on properties that
  # require extra handling.


if __name__ == '__main__':
  basetest.main()
