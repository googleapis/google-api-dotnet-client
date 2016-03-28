#!/usr/bin/python2.7
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

"""C++ library generator's import manager."""

__author__ = 'ewiseblatt@google.com (Eric Wiseblatt)'

from googleapis.codegen.utilities import ordered_set


class CppImportManager(object):
  """The import manager for the C++ code generator."""

  def __init__(self, element):
    """Construct an import manager for the specified element.

    Args:
      element: (Schema) or (Api). The element we want to create an import
        manager for.
    """
    self._element = element
    self._element.SetTemplateValue('importManager', self)
    self._class_name_to_qualified_name = {}
    self._google_imports = ordered_set.MutableOrderedSet()
    self._platform_imports = ordered_set.MutableOrderedSet()
    self._other_imports = ordered_set.MutableOrderedSet()
    self._type_dependencies = ordered_set.MutableOrderedSet()

  @classmethod
  def ForElement(cls, element):
    manager = element.get('importManager')
    if manager:
      return manager
    # instantiation installs manager inside element.
    return cls(element)

  def ImportLists(self):
    """Returns the set of import lists."""
    # We're returning a set of two rather than three because we're considering
    # the google imports part of the platform when generating the headers.
    # We're avoiding the line breaks the import template forces between llists.
    return [sorted(self._platform_imports) + sorted(self._google_imports),
            sorted(self._other_imports)]

  def AddDataType(self, data_type):
    self._type_dependencies.add(data_type)
    return self.AddImport('"%s"' % data_type.values['include_path'])

  def AddImport(self, fully_qualified_class):
    """Adds the specified import to the import manager.

    Args:
      fully_qualified_class: (str) The fully qualified class we want to add to
        this instance of import manager.

    Returns:
      True- If adding the import is successful.
      False- If adding the import results in a name collision.
    """
    # check to see if it already exists
    class_name = self.GetClassName(fully_qualified_class)
    current_import = self._class_name_to_qualified_name.get(class_name)
    if current_import:
      return current_import == fully_qualified_class
    if fully_qualified_class.startswith('"googleapis/'):
      self._google_imports.add(fully_qualified_class)
    elif self.IsPlatformClass(fully_qualified_class):
      self._platform_imports.add(fully_qualified_class)
    else:
      self._other_imports.add(fully_qualified_class)
    # Now add it to the map
    self._class_name_to_qualified_name[class_name] = fully_qualified_class
    return True

  def IsPlatformClass(self, fully_qualified_class):
    return fully_qualified_class.startswith('<')

  def GetClassName(self, fully_qualified_class):
    return fully_qualified_class.split('::')[-1]

  @property
  def type_dependencies(self):
    return self._type_dependencies

  @property
  def google_imports(self):
    return self._google_imports

  @property
  def platform_imports(self):
    return self._platform_imports

  @property
  def other_imports(self):
    return self._other_imports
