#!/usr/bin/python2.6
# Copyright 2012 Google Inc. All Rights Reserved.

"""Support for simple JSON templates.

A JSON template is a dictionary of JSON data in which string values
may be simple templates in string.Template format (i.e.,
$dollarSignEscaping).  The templates is expanded against its own data,
optionally updated with additional context.
"""

from string import Template

__author__ = 'smulloni@google.com (Jacob Smullyan)'


def ExpandJsonTemplate(json_data, extra_context=None):
  """Recursively template-expand a json dict against itself.

  The context for string expansion is the json dict itself, updated
  by extra_context, if supplied.

  Args:
    json_data: (dict) A JSON object where string values may be templates.
    extra_context: (dict) Additional context for template expansion.

  Returns:
    A dict where string template values have been expanded against
    the context.
  """
  if extra_context:
    context = dict(json_data)
    context.update(extra_context)
  else:
    context = json_data

  def RecursiveExpand(obj):
    if isinstance(obj, list):
      return [RecursiveExpand(x) for x in obj]
    elif isinstance(obj, dict):
      return dict((k, RecursiveExpand(v)) for k, v in obj.iteritems())
    elif isinstance(obj, (str, unicode)):
      return Template(obj).safe_substitute(context)
    else:
      return obj

  return RecursiveExpand(json_data)
