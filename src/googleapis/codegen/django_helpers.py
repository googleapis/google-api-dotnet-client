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

"""Wrapper methods to insulate us from Django nuances.

Provide Django setup and some utility methods.
"""

__author__ = 'aiuto@google.com (Tony Aiuto)'

import os



from django import template as django_template
from django import utils as django_utils
from django.conf import settings
# COV_NF_START
try:
  # In AppEngine, we have to call use_library() in our main. Doing that causes
  # an error, which we can safely ignore because use_library did it
  settings.configure()
  os.environ['DJANGO_SETTINGS_MODULE'] = 'settings'
except RuntimeError:
  pass

from googleapis.codegen import files

# COV_NF_END

# This is Django magic to add builtin tags and filters.  They don't really
# support that use case.  Instead you are supposed to put a package of filters
# in a specific place and the Django web server finds them for you. We are a
# standalone app, not running in their context, so we have to go under the hood
# a little.
django_template.add_to_builtins(
    'googleapis.codegen.template_helpers')


def DjangoRenderTemplate(template_path, context_dict):
  """Renders a template specified by a file path with a give values dict.

  Args:
    template_path: (str) Path to file.
    context_dict: (dict) The dictionary to use for template evalutaion.
  Returns:
    (str) The expanded template.
  """
  source = files.GetFileContents(template_path).decode('utf-8')
  t = django_template.Template(source)
  return t.render(django_template.Context(context_dict))


def MarkSafe(s):
  return django_utils.safestring.mark_safe(s)
