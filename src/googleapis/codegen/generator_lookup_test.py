#!/usr/bin/python2.6
# Copyright 2012 Google Inc. All Rights Reserved.

"""Tests for generator_lookup."""

__author__ = 'akesling@google.com (Alex Kesling)'


from google.apputils import basetest

from googleapis.codegen import generator_lookup
from googleapis.codegen import java_generator


class GeneratorLookupTest(basetest.TestCase):

  def testDetermineGenerator(self):
    test_gen = generator_lookup.GetGeneratorByLanguage('java')
    self.assertEqual(java_generator.JavaGenerator, test_gen)
    self.assertRaises(
        ValueError, generator_lookup.GetGeneratorByLanguage,
        'I\'m an invalid language!')

  def testSupportedLanguage(self):
    languages = generator_lookup.SupportedLanguages()
    self.assertContainsSubset(['dart', 'gwt', 'java', 'php'], languages)


if __name__ == '__main__':
  basetest.main()
