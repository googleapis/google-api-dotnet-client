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

"""Java library generator's import manager."""

__author__ = 'rmistry@google.com (Ravi Mistry)'


# Used to cache import managers to the class name of the schema they
# correspond to.
_CLASS_NAME_TO_IMPORT_MANAGER = {}


class JavaImportManager(object):
  """The import manager for the Java code generator."""

  _JAVA_LANG_IMPORT = 'java.lang'

  def __init__(self, element):
    """Construct an import manager for the specified element.

    Args:
      element: (Schema) or (Api). The element we want to create an import
        manager for.
    """
    self._element = element
    self._element.SetTemplateValue('importManager', self)
    self._class_name_to_qualified_name = {}
    self._google_imports = set()
    self._other_imports = set()
    self._java_imports = set()

  @classmethod
  def GetCachedImportManager(cls, element):
    """Gets an import manager instance that corresponds to the class name.

    If the schema does not have a cached import manager, one is created
    and added to the cache.

    Args:
      element: (Schema) or (Api). The element we want to create an import
        manager for.
    Returns:
      The import manager instance for this schema.
    """
    import_mngr = _CLASS_NAME_TO_IMPORT_MANAGER.get(element)
    if not import_mngr:
      # This class does not have an import manager yet. Instantiate it.
      import_mngr = cls(element)
      _CLASS_NAME_TO_IMPORT_MANAGER[element] = import_mngr
    return import_mngr

  def ImportLists(self):
    """Returns the set of import lists."""
    return [sorted(self._google_imports),
            sorted(self._java_imports),
            sorted(self._other_imports)]

  def AddImport(self, fully_qualified_class):
    """Adds the specified import to the import manager.

    Args:
      fully_qualified_class: (str) The fully qualified class we want to add to
        this instance of import manager.

    Returns:
      True- If adding the import is successful.
      False- If adding the import results in a name collision.
    """
    if fully_qualified_class.startswith(self._JAVA_LANG_IMPORT):
      # Returning True because it is imported by default.
      return True

    # check to see if it already exists
    class_name = self.GetClassName(fully_qualified_class)
    current_import = self._class_name_to_qualified_name.get(
        class_name)
    if current_import:
      return current_import == fully_qualified_class

    if fully_qualified_class.startswith('com.google.'):
      self._google_imports.add(fully_qualified_class)
    elif fully_qualified_class.startswith('java.'):
      self._java_imports.add(fully_qualified_class)
    else:
      self._other_imports.add(fully_qualified_class)
    # Now add it to the map
    self._class_name_to_qualified_name[class_name] = fully_qualified_class
    return True

  def GetClassName(self, fully_qualified_class):
    return fully_qualified_class.split('.')[-1]

  @property
  def google_imports(self):
    return sorted(self._google_imports)

  @property
  def other_imports(self):
    return sorted(self._other_imports)

  @property
  def java_imports(self):
    return sorted(self._java_imports)
