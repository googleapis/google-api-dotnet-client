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
# Copyright 2011 Google Inc. All Rights Reserved.

"""Utility methods.

Assorted utility methods for the code generator.
"""

__author__ = 'aiuto@google.com (Tony Aiuto)'


def CamelCase(s):
  """CamelCase a string so that it is more readable as a variable name.

  Camelcases a string, begining new words after any instances of '.', '_' or
      '-'.

  Args:
    s: (str) A string.
  Returns:
    s, with the first letter of each word capitalized.
  """
  ret = ''
  new_word = True
  for c in s:
    if c in '._-':
      new_word = True
      continue
    if new_word:
      c = c.upper()
      new_word = False
    ret += c
  return ret
