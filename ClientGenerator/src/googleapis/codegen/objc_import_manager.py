#!/usr/bin/python2.7
# Copyright 2014 Google Inc. All Rights Reserved.
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

"""Objective-C library generator's import manager."""

__author__ = 'qwandor@google.com (Andrew Walbran)'


class ObjCImportManager(object):
  """The import manager for the Objective-C code generator."""

  def __init__(self, element):
    """Construct an import manager for the specified element.

    Args:
      element: (Schema) or (Api). The element we want to create an import
        manager for.
    """
    self._element = element
    self._element.SetTemplateValue('importManager', self)
    self._type_dependencies = set()
    self._imports = set()

  @classmethod
  def ForElement(cls, element):
    manager = element.get('importManager')
    if manager:
      return manager
    # instantiation installs manager inside element.
    return cls(element)

  def ImportLists(self):
    """Returns the set of import lists."""
    return [sorted(self._imports)]

  def AddDataType(self, data_type):
    self._type_dependencies.add(data_type.code_type)
    return self.AddImport('"%s.h"' % data_type.code_type)

  def AddImport(self, filename):
    """Adds the specified import to the import manager.

    Args:
      filename: (str) The filename we want to add to this instance of import
        manager.

    Returns:
      True- If adding the import is successful.
      False- If adding the import fails.
    """
    self._imports.add(filename)
    return True

  @property
  def type_dependencies(self):
    return sorted(self._type_dependencies)
