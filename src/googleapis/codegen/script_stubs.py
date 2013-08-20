#!/usr/bin/python2.7
"""A shim to surface codegen scripts as setuptools console scripts."""

from google.apputils import run_script_module


def RunGenerateLibrary():
  # pylint:disable=g-import-not-at-top
  from googleapis.codegen import generate_library
  run_script_module.RunScriptModule(generate_library)


def RunExpandTemplates():
  # pylint:disable=g-import-not-at-top
  from googleapis.codegen import expand_templates
  run_script_module.RunScriptModule(expand_templates)
