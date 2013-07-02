#!/usr/bin/python2.7
# Copyright 2012 Google Inc. All Rights Reserved.

"""List of platforms we can target libraries for.

This module defines the canonical names of the platforms that we support for
each language. Those names are used to validate that
"""

__author__ = 'aiuto@google.com (Tony Aiuto)'

ALL = 'all'

# Runtime platforms (per language) that we know about. This list is used to
# validate parameters.
PLATFORMS = {
    ALL: ['*', 'manual'],
    'gwt': ['gwt'],
    # TODO(user): Remove android2 and android3 for 1.12 launch.
    'java': ['android', 'android2', 'android3', 'appengine', 'servlet',
             'generic'],
    'javaproto': ['android', 'appengine', 'servlet', 'generic'],
    }

# Definitions:
# *: required in all environments
# manual: not included by any tools. You must do a manual download to use it.

# Type of files applicable to that platform
FILE_TYPES = {
    ALL: ['binary', 'bundle', 'documentation', 'source', 'license',
          'android-properties', 'proguard-config', 'other']
    }
