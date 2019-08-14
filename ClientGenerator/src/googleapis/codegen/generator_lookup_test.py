#!/usr/bin/python2.7
# Copyright 2012 Google Inc. All Rights Reserved.

"""Tests for generator_lookup."""

__author__ = 'akesling@google.com (Alex Kesling)'

import json
import os


from google.apputils import basetest

from googleapis.codegen import generator_lookup
from googleapis.codegen import csharp_generator
from googleapis.codegen import targets


class GeneratorLookupTest(basetest.TestCase):

  def testDetermineGenerator(self):
    test_gen = generator_lookup.GetGeneratorByLanguage('csharp')
    self.assertEqual(csharp_generator.CSharpGenerator, test_gen)
    self.assertRaises(
        ValueError, generator_lookup.GetGeneratorByLanguage,
        'I\'m an invalid language!')

  def testSupportedLanguage(self):
    languages = generator_lookup.SupportedLanguages()
    self.assertContainsSubset(['csharp'], languages)
    self.assertNotIn('java-head', languages)


if __name__ == '__main__':
  basetest.main()
