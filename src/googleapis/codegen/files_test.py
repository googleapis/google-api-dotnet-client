#!/usr/bin/python2.6

import os
import shutil
import tempfile

from google.apputils import basetest
from googleapis.codegen import files


class FilesTest(basetest.TestCase):

  def setUp(self):
    self.tempdir = tempfile.mkdtemp()
    for name in 'abc':
      open(os.path.join(self.tempdir, name), 'w').write(name)

  def tearDown(self):
    shutil.rmtree(self.tempdir)

  def testGetFileContentsLocal(self):
    filename = os.path.join(self.tempdir, 'a')
    contents = files.GetFileContents(filename)
    self.assertEquals('a', contents)

  def testIterFilesLocal(self):
    listing = sorted(files.IterFiles(self.tempdir))
    expected = [os.path.join(self.tempdir, x) for x in 'abc']
    self.assertEquals(expected, listing)

  def testIsFileLocal(self):
    self.assertTrue(files.IsFile(os.path.join(self.tempdir, 'a')))
    self.assertFalse(files.IsFile(self.tempdir))

if __name__ == '__main__':
  basetest.main()
