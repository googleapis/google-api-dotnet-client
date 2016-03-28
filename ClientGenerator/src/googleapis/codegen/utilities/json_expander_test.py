#!/usr/bin/python2.7
# Copyright 2012 Google Inc. All Rights Reserved.


__author__ = "smulloni@google.com (Jacob Smullyan)"

from google.apputils import basetest
from googleapis.codegen.utilities import json_expander


class JsonExpanderTest(basetest.TestCase):

  def testExpand(self):
    x_val = "foo"
    y_val = "bar"
    d = dict(x=x_val, y=y_val, t1="$x", t2="${y}",
             r={"t": "$x$y", "l": [3, "$x"]})
    expanded = json_expander.ExpandJsonTemplate(d)
    self.assertEquals(x_val, expanded["t1"])
    self.assertEquals(y_val, expanded["t2"])
    self.assertEquals(x_val + y_val, expanded["r"]["t"])
    self.assertEquals(x_val, expanded["r"]["l"][1])

  def testExpandWithAdditionalContext(self):
    y_val = "bar"
    extra = dict(y=y_val)
    d = dict(t="${y}")
    expanded = json_expander.ExpandJsonTemplate(d)
    self.assertNotEquals(y_val, expanded["t"])

    expanded = json_expander.ExpandJsonTemplate(d, extra)
    self.assertEquals(y_val, expanded["t"])

  def testExpandNoSelf(self):
    d = dict(x="aha", t1="$x")
    extra = dict(x="no-no")
    expanded = json_expander.ExpandJsonTemplate(d, extra, use_self=False)
    self.assertEquals("no-no", expanded["t1"])


if __name__ == "__main__":
  basetest.main()
