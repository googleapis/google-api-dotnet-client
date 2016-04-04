#!/usr/bin/python2.7
"""Tests for json_with_comments.py."""

from google.apputils import basetest

from googleapis.codegen.utilities import json_with_comments


class JsonWithCommentsTest(basetest.TestCase):

  SOME_JSON_WITH_COMMENTS = """
    # Garlic and sapphires in the mud
    # Clot the bedded axle-tree.
    {"author": "Timmy",
     "books": [
       # Diet classic
       "The Waist Band"
     ]
    }
    # The End
    """

  JSON_CONTENT = {'author': 'Timmy',
                  'books': ['The Waist Band']}

  def testLineNumbering(self):
    stripped = json_with_comments._StripComments(self.SOME_JSON_WITH_COMMENTS)
    # The stripped version should have the same number of line breaks as the
    # original.
    num_lines = self.SOME_JSON_WITH_COMMENTS.count('\n')
    self.assertEquals(num_lines, stripped.count('\n'))

  def testLoads(self):
    data = json_with_comments.Loads(self.SOME_JSON_WITH_COMMENTS)
    self.assertEquals(self.JSON_CONTENT, data)


if __name__ == '__main__':
  basetest.main()
