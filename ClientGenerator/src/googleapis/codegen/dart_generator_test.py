#!/usr/bin/python2.7
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

"""Tests for dart_generator."""

__author__ = 'sammccall@google.com (Sam McCall)'


from google.apputils import basetest
from googleapis.codegen import dart_generator


class DartGeneratorTest(basetest.TestCase):

  def testAnnotateParameter(self):
    """Test numeric enum names get turned into valid identifiers."""
    gen = dart_generator.DartGenerator({
        'name': 'dummy',
        'version': 'v1',
        'methods': {
            'frob': {
                'id': 'frob',
                'parameters': {
                    'normal': {
                        'type': 'string',
                        'enum': ['y', 'n'],
                        'enumDescriptions': ['Yes', 'No'],
                        'location': 'query',
                    },
                    'numeric': {
                        'type': 'string',
                        'enum': ['0', '1V'],
                        'enumDescriptions': ['Zero', 'One'],
                        'location': 'query',
                    },
                },
            },
        },
    })
    gen.AnnotateApiForLanguage(gen._api)

    frob = gen._api.GetTemplateValue('methods')[0]
    normal, numeric = frob.GetTemplateValue('parameters')
    # Might be the other order
    if normal.GetTemplateValue('wireName') == 'numeric':
      normal, numeric = numeric, normal

    normal_pairs = (normal.GetTemplateValue('enumType')
                    .GetTemplateValue('pairs'))
    self.assertEquals([('Y', 'y', 'Yes'), ('N', 'n', 'No')],
                      normal_pairs)

    numeric_pairs = (numeric.GetTemplateValue('enumType')
                     .GetTemplateValue('pairs'))
    self.assertEquals([('VALUE_0', '0', 'Zero'), ('VALUE_1V', '1V', 'One')],
                      numeric_pairs)

if __name__ == '__main__':
  basetest.main()
