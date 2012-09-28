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

"""Validation routines for discovery elements.

This is a singleton class which provides validation for names which can
appear in discovery documents
"""

__author__ = 'wclarkso@google.com (Will Clarkson)'

import re


# The first character must alpha (a-zA-Z) or an underscore (no single digits)
# Subsequent characters can be alpha numeric. We also permit them to have an
# underscore (_), dot (.) or dash (-). But, we require that there be an
# alpha_numeric or underscore character at the end.
# This prevents against 'abcd123_.' which is not a valid name.
# NOTE: the '$' character is to get around $ref variable name in some APIs
_VARNAME_REGEX = re.compile(
    r'([a-zA-Z]$)|([a-zA-Z_$]{1}[a-zA-Z0-9_.-]*[a-zA-Z0-9_]{1})$')

# Valid comments may only contain dash ('-'), a-z, A-Z, 0-9, comma (','),
# apostrophe forward slash bracket opening/closing '[' or ']', colons (':')
# or whitespace.
# We also do not permit comment terminators terminators (e.g. */)
# TODO(user): Make a per-language validator. Allow non-dangerous symbols
#                 depending on language. e.g. */ is OK for Python but not PHP
_COMMENT_REGEX = re.compile(
    r'[-\s!"#$%&\'`()*+,./0-9:;<=>?@A-Z\[\\\]^_`a-z{|}~]*$')

_API_NAME_REGEX = re.compile(r'[a-z][a-zA-Z0-9_]*$')
_API_VERSION_REGEX = re.compile(r'[a-z0-9][a-zA-Z0-9._]*$')


def Validate(name):
  """Validates the name against a regular expression object.

  If the name matches the regular expression, we return nothing.
  If the name fails to match, we generate an exception.

  Args:
    name: (str) name of variable or method

  Raises:
    ValueError: An Error if name does not conform to style
  """
  if _VARNAME_REGEX.match(name) is None:
    raise ValueError(
        'Variable %s does not conform to style guide' % name)


def ValidateApiName(api_name):
  """Validates a potential API name.

  An API name must match the regular expression[a-z0-9][a-zA-Z0-9_]*

  Args:
    api_name: (str) The API name to check.

  Raises:
    ValueError: An Error if name does not conform to style
  """
  if _API_NAME_REGEX.match(api_name) is None:
    raise ValueError(
        'API name %s does not conform to style guide' % api_name)


def ValidateApiVersion(api_version):
  """Validates a potential API version.

  An API vesrion must match the regular expression[a-z0-9][a-zA-Z0-9.]*

  Args:
    api_version: (str) The API version to check.

  Raises:
    ValueError: An Error if version does not conform to style
  """
  if _API_VERSION_REGEX.match(api_version) is None:
    raise ValueError(
        'API version %s does not conform to style guide' % api_version)


def ValidateAndSanitizeComment(comment_string):
  """Validates a comment string.

  We do not allow non-ascii characters, raising an error if one is present.
  Args:
    comment_string: (str) input comment string
  Returns:
    (str) ASCII-Only string with invalid characters removed

  Raises:
    ValueError: An Error if vomment does not conform to style
  """
  # Disallow non-ASCII (Error if present)
  if _COMMENT_REGEX.match(comment_string) is None:
    raise ValueError(
        'Comment %s does not conform to style guide' % comment_string)
  else:
    # Strip anything which is known to be a comment terminator in any
    # supported language.
    invalid_strings = ['/*',    # C-style Multi-line start
                       '*/',    # C-style Multi-line end
                       '\"""',  # Python Multiline string
                       '///',   # Escaped comment begin
                       '\\*',   # Escaped Multiline begin
                      ]
    change_made = True
    while change_made:
      change_made = False
      # Save original length for easy comparision later
      beginning_length = len(comment_string)

      for substring in invalid_strings:
        # Replace all intances of substring with empty string
        comment_string = comment_string.replace(substring, '')

      # If the length of the string changed, then a replacement occured.
      # We need to repeat the process until no changes occur
      if len(comment_string) != beginning_length:
        change_made = True

  return comment_string
