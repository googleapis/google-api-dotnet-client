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


class FeaturesTest(BaseTargetsTest):

  # short names for the various names in the test data
  base_path = 'libs/base.jar'
  base_source_path = 'libs-sources/base-sources.jar'
  base_docs_path = 'libs-sources/base-docs.jar'
  gae_path = 'libs/client-appengine.jar'
  gae_sources_path = 'libs-sources/client-appengine-sources.jar'
  logging_path = 'libs/logging.jar'
  servlet_path = 'libs/servlet.jar'
  servlet_source_path = 'libs-sources/servlet-sources.jar'

  def testDependenciesForEnvironment(self):
    variations = self.targets.VariationsForLanguage('java')
    features = variations.GetFeatures('preview')
    # short names for the various names in the test data
    nr = 'never required'
    base = 'base is always required'
    gae = 'required on gae'
    gae_generic = 'required on gae, but useful to all'
    gae_or_servlet = 'required on servlet or gae'

    def CheckResults(environment, expected_req, expected_opt, expected_exclude):
      req, opt, exclude = features.DependenciesForEnvironment(environment)
      self.assertSameElements(expected_req, [r['name'] for r in req])
      self.assertSameElements(expected_opt, [r['name'] for r in opt])
      self.assertSameElements(expected_exclude, [r['name'] for r in exclude])

    CheckResults(None,
                 [base], [gae, gae_generic, gae_or_servlet, nr], [])
    CheckResults('command_line',
                 [base], [gae_generic], [gae, gae_or_servlet, nr])
    CheckResults('appengine',
                 [base, gae, gae_generic, gae_or_servlet], [], [nr])
    CheckResults('servlet',
                 [base, gae_or_servlet], [gae_generic], [gae, nr])
    CheckResults('manual',
                 [base, nr], [gae_generic], [gae, gae_or_servlet])

  def testAllDependencyPaths(self):
    variations = self.targets.VariationsForLanguage('java')
    features = variations.GetFeatures('preview')
    all_paths = features.AllDependencyPaths()
    self.assertSameElements(
        [self.base_path, self.base_source_path, self.base_docs_path,
         self.logging_path, self.gae_path, self.gae_sources_path,
         self.servlet_path, self.servlet_source_path],
        all_paths)

  def testExtractPathsFromDependencies(self):
    variations = self.targets.VariationsForLanguage('java')
    features = variations.GetFeatures('preview')

    def CheckResults(environment, expected_req, expected_opt, expected_exclude):
      req, opt, exclude = features.DependenciesForEnvironment(environment)
      req_paths = features.ExtractPathsFromDependencies(req)
      opt_paths = features.ExtractPathsFromDependencies(opt)
      exclude_paths = features.ExtractPathsFromDependencies(exclude)
      self.assertSameElements(expected_req, req_paths)
      self.assertSameElements(expected_opt, opt_paths)
      self.assertSameElements(expected_exclude, exclude_paths)
      self.assertEquals(8, len(req_paths) + len(opt_paths) + len(exclude_paths))

    # Each test will account for all 8 file paths
    CheckResults(
        'command_line',
        [self.base_path, self.base_source_path, self.base_docs_path],
        [self.logging_path],
        [self.gae_path, self.gae_sources_path, self.servlet_path,
         self.servlet_source_path])
    CheckResults(
        'servlet',
        [self.base_path, self.base_source_path, self.base_docs_path,
         self.servlet_path, self.servlet_source_path],
        [self.logging_path],
        [self.gae_path, self.gae_sources_path])

    # Check the filtering
    req, _, _ = features.DependenciesForEnvironment('foo')
    bin_files = features.ExtractPathsFromDependencies(req, file_type='binary')
    self.assertSameElements([self.base_path], bin_files)

    req, _, _ = features.DependenciesForEnvironment('servlet')
    bin_files = features.ExtractPathsFromDependencies(req, file_type='binary')
    self.assertSameElements([self.base_path, self.servlet_path], bin_files)

  def testFilePathsWeDoNotDependOn(self):
    variations = self.targets.VariationsForLanguage('java')
    features = variations.GetFeatures('preview')

    all_paths = set([self.base_path, self.base_source_path, self.base_docs_path,
                     self.logging_path, self.gae_path, self.gae_sources_path,
                     self.servlet_path, self.servlet_source_path])

    exclude = features.FilePathsWeDoNotDependOn()
    self.assertSameElements([], exclude)

    exclude = features.FilePathsWeDoNotDependOn('foo')
    self.assertSameElements(
        all_paths - set([self.base_path, self.base_source_path,
                         self.base_docs_path]),
        exclude)

    exclude = features.FilePathsWeDoNotDependOn(file_type='binary')
    self.assertSameElements(all_paths - set([self.base_path]), exclude)

    exclude = features.FilePathsWeDoNotDependOn('foo', file_type='binary')
    self.assertSameElements(all_paths - set([self.base_path]), exclude)

    exclude = features.FilePathsWeDoNotDependOn('appengine', file_type='binary')
    self.assertSameElements(
        all_paths - set([self.base_path, self.gae_path, self.servlet_path,
                         self.logging_path]),
        exclude)


if __name__ == '__main__':
  basetest.main()
