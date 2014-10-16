#!/usr/bin/python2.7


from google.apputils import basetest
from googleapis.codegen.utilities import convert_size


class ConvertSizeTest(basetest.TestCase):
  """Test for unit conversion."""

  def testConvertSize(self):
    self.assertEquals(None, convert_size.ConvertSize(None))
    self.assertEquals(None, convert_size.ConvertSize('4'))
    self.assertEquals(None, convert_size.ConvertSize('4C'))
    self.assertEquals(4, convert_size.ConvertSize('4B'))
    self.assertEquals(4 * 2 ** 10, convert_size.ConvertSize('4KB'))
    self.assertEquals(12 * 2 ** 20, convert_size.ConvertSize('12MB'))
    self.assertEquals(10 * 2 ** 30, convert_size.ConvertSize('10GB'))


if __name__ == '__main__':
  basetest.main()
