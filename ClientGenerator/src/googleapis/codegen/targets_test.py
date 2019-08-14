#!/usr/bin/python2.7


__author__ = 'jcgregorio@google.com (Joe Gregorio)'

import os

from google.apputils import basetest
from googleapis.codegen import targets


class BaseTargetsTest(basetest.TestCase):

  def setUp(self):
    testdata_dir = os.path.join(os.path.dirname(__file__), 'testdata')

    self.targets = targets.Targets(
        os.path.join(testdata_dir, 'targets_test.json'),
        os.path.join(testdata_dir, 'languages'))


class TargetsTest(BaseTargetsTest):

  def testTargetsAccessors(self):
    rawdata = self.targets.Dict()
    self.assertTrue('languages' in rawdata)

    self.assertTrue(
        self.targets.VariationsForLanguage('java').IsValid('preview'))
    self.assertTrue(
        self.targets.VariationsForLanguage('python').IsValid('stable'))
    self.assertTrue('displayName' in self.targets.GetLanguage('java'))
    self.assertTrue('python' in self.targets.Languages())
    self.assertTrue('cmd-line' in self.targets.Platforms())


class FeaturesLoadingTest(BaseTargetsTest):

  def testGetFeatures(self):
    variations = self.targets.VariationsForLanguage('java')
    features = variations.GetFeatures('preview')
    # Something from the top level
    self.assertEquals(True, features.get('library'))
    # Something overridden in the variation specific file
    self.assertEquals('base-client-library', features.get('baseClientLibrary'))
    self.assertEquals('release-version', features.get('releaseVersion'))

  def testGetFeaturesWithoutOverride(self):
    """Ask for features of a service without a local override."""
    variations = self.targets.VariationsForLanguage('java')
    features = variations.GetFeatures('not_built_in')
    self.assertEquals('this-is-from-top-level', features.get('releaseVersion'))
    self.assertIsNone(features.get('baseClientLibrary'))


if __name__ == '__main__':
  basetest.main()
