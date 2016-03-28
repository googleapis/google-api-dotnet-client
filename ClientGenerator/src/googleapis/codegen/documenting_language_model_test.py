#!/usr/bin/python2.7
# Copyright 2012 Google Inc. All Rights Reserved.

"""Tests for language_model.DocumentingLanguageModel."""

__author__ = 'aiuto@google.com (Tony Aiuto)'

from google.apputils import basetest
from googleapis.codegen import language_model


class DocumentingLanguageModelTest(basetest.TestCase):

  def testDocumentingLanguageModel(self):
    dlm = language_model.DocumentingLanguageModel()
    self.assertEquals('Array<foo>', dlm.ArrayOf(None, 'foo'))
    self.assertEquals('Map<string, foo>', dlm.MapOf(None, 'foo'))
    self.assertEquals('foo', dlm.GetCodeTypeFromDictionary({'type': 'foo'}))
    self.assertEquals('foo (int)', dlm.GetCodeTypeFromDictionary({
        'type': 'foo', 'format': 'int'}))


if __name__ == '__main__':
  basetest.main()
