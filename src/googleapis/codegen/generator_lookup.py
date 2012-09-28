#!/usr/bin/python2.6
# Copyright 2012 Google Inc. All Rights Reserved.
#

"""Common generator index utilities."""

__author__ = 'akesling@google.com (Alex Kesling)'


from googleapis.codegen import dart_generator
from googleapis.codegen import gwt_generator
from googleapis.codegen import java_generator
from googleapis.codegen import php_generator
from googleapis.codegen import python_generator


_GENERATORS = {
    'dart': dart_generator.DartGenerator,
    'gwt': gwt_generator.GwtGenerator,
    'java': java_generator.JavaGenerator,
    'php': php_generator.PHPGenerator,
    'python': python_generator.PythonGenerator,
    }


def GetGeneratorByLanguage(language):
  """Return the appropriate generator for this language.

  Args:
    language: (str) the language for which to return a generator.

  Raises:
    ValueError: If provided language isn't supported.

  Returns:
    The appropriate code generator object.
  """
  generator = _GENERATORS.get(language)
  if generator:
    return generator
  else:
    raise ValueError('Unsupported language: %s' % language)


def SupportedLanguages():
  """Return the list of languages we support.

  Returns:
    list(str)
  """
  return sorted(_GENERATORS.keys())
