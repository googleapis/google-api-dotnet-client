#  Copyright 2011 Google, Inc.
#
#  Licensed under the Apache License, Version 2.0 (the "License");
#  you may not use this file except in compliance with the License.
#  You may obtain a copy of the License at
#
#      http://www.apache.org/licenses/LICENSE-2.0
#
#  Unless required by applicable law or agreed to in writing, software
#  distributed under the License is distributed on an "AS IS" BASIS,
#  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
#  See the License for the specific language governing permissions and
#  limitations under the License.

Google APIs Code Generator
https://github.com/google/apis-client-generator/

August 20, 2013

Introduction

  This is a tool for generating client libraries from Google APIs Discovery
  documents. It builds a rich (but language neutral) model of the API and
  then invokes a language specific backend to emit the library. The language
  generators are template driven, so it is easy for a developer knowning
  language X to write templates for code in X, without having to learn much
  Python.

  The generator currently has templates for Java, C++, CSharp, GWT, PHP
  and Dart.  There may be multiple variations of each language. For each,
  the variant used by default (typically also named "default") matches the
  head of the respective base client libraries.


Installation

Python 2.7 is required.  Python3 is not supported.

Everything can be installed quickly with easy_install or pip. E.g.:

  pip install google-apis-client-generator

The following dependencies will be installed:

  * django - http://www.djangoproject.com/
    - version 1.8
    - we only use the templating package, not the web serving features.
  * google-apputils - http://github.com/google/google-apputils/
  * google-api-python-client - http://github.com/google/google-api-python-client
  * python-gflags - http://github.com/google/python-gflags/
  * httplib2 - https://github.com/jcgregorio/httplib2


Usage

To run the library generator, use the "generate_library" script.  This is
normally what you'd want to do.  E.g.:

  generate_library \
    --input=src/googleapis/codegen/testdata/moderator.v1.json \
    --language=java \
    --output_dir=/tmp/generated

To expand arbitrary templates, the "expand_templates" script is also available:

  expand_templates \
    --discovery=src/googleapis/codegen/testdata/moderator.v1.json \
    --language=any --templates=discovery_check \
    --output_dir=/tmp/generated


Contact

  Tony Aiuto (aiuto@google.com)
  Jacob Smullyan (smulloni@google.com)
