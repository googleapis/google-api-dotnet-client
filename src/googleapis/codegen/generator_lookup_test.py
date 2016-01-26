#!/usr/bin/python2.7
# Copyright 2012 Google Inc. All Rights Reserved.

"""Tests for generator_lookup."""

__author__ = 'akesling@google.com (Alex Kesling)'

import json
import os


from google.apputils import basetest

from googleapis.codegen import generator_lookup
from googleapis.codegen import java_generator
from googleapis.codegen import targets


class GeneratorLookupTest(basetest.TestCase):

  def testDetermineGenerator(self):
    test_gen = generator_lookup.GetGeneratorByLanguage('java')
    self.assertEqual(java_generator.Java14Generator, test_gen)
    self.assertRaises(
        ValueError, generator_lookup.GetGeneratorByLanguage,
        'I\'m an invalid language!')

  def testSupportedLanguage(self):
    languages = generator_lookup.SupportedLanguages()
    self.assertContainsSubset(['dart', 'gwt', 'java', 'php'], languages)
    self.assertNotIn('java-head', languages)

  def testVersion(self):
    gen = generator_lookup.GetGeneratorByLanguage('java1_12')
    self.assertEquals(java_generator.Java12Generator, gen)
    gen = generator_lookup.GetGeneratorByLanguage('java1_13')
    self.assertEquals(java_generator.Java12Generator, gen)
    gen = generator_lookup.GetGeneratorByLanguage('java1_14')
    self.assertEquals(java_generator.Java14Generator, gen)

  def testVersionFromFeature(self):
    template_root = os.path.join(os.path.dirname(__file__),
                                 'testdata/languages')
    targets.Targets.SetDefaultTemplateRoot(template_root)
    features_path = os.path.join(template_root,
                                 'java/generator_test/features.json')
    raw_features = json.load(open(features_path))
    generator_name = raw_features['generator']
    gen = generator_lookup.GetGeneratorByLanguage(generator_name)
    self.assertEquals(java_generator.Java12Generator, gen)


if __name__ == '__main__':
  basetest.main()
