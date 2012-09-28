#!/usr/bin/python2.6
#
# Copyright 2010 Google Inc. All Rights Reserved.
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

"""Generator for an API library.

This module specializes TemplateGenerator for building API libraries.
"""

__author__ = 'aiuto@google.com (Tony Aiuto)'

from googleapis.codegen import template_objects
from googleapis.codegen.generator import TemplateGenerator

_DEFAULT_SERVICE_HOST = 'https://www.googleapis.com'


class ApiLibraryGenerator(TemplateGenerator):
  """TemplateGenerator specialization which produces an API library."""

  def __init__(self, api_loader, discovery, language, language_model=None,
               options=None):
    """Construct an ApiLibraryGenerator.

    Args:
      api_loader: (Api) Method which can construct an Api from discovery.
      discovery: (dict) A discovery definition.
      language: (str) The target language name. This has no semantic meaning
          other than to specify the template set to use.
      language_model: (LanguageModel) The target language data model.
      options: (dict) Code generator options.
    """
    super(ApiLibraryGenerator, self).__init__(language_model=language_model,
                                              options=options)
    # Load the API definition and an prepare it for generating code.
    self._api = api_loader(discovery)
    self._language = language

    # top level package for the generated code. The 'path' of the package is
    # used to expand '___package___' instances in file names found in the
    # template tree.
    self._package = None
    # package for generated models, defaults to top level package
    self._model_package = None

  @property
  def api(self):
    return self._api

  @property
  def package(self):
    return self._package

  @property
  def model_package(self):
    return self._model_package or self._package

  def SetPackage(self, package):
    """Sets the package this code tree should be generated into.

    Args:
      package: (template_objects.Package) The package this code belongs in.
    """
    self._package = package
    self._api.SetTemplateValue('package', self._package)

  def GeneratePackage(self, package_writer):
    """Generate the entire package of an API library.

    Overrides superclass.

    Args:
      package_writer: (LibraryPackage) output package
    """
    api = self._api
    self.AnnotateApiForLanguage(api)
    self.GenerateLibrarySource(api, package_writer)
    if self._options.get('include_dependencies'):
      self.WalkTemplateTree('dependencies', {}, {}, {'api': api.values},
                            package_writer)

  def GenerateLibrarySource(self, api, source_package_writer):
    """Default operations to generate the package.

    Do all the default operations for generating a package.
    1. Walk the template tree to generate the source.
    2. Add in per-language additions to the source
    3. Optionally copy in dependencies
    4. (Side effect) Closes the source_package_writer.

    Args:
      api: (Api) The Api instance we are writing a libary for.
      source_package_writer: (LibraryPackage) source output package.
    """
    if self._package:
      package_path = self._package.path
    else:
      package_path = '.'
    path_replacements = {
        '___package___': package_path,
        '___api_className___': api.values['className'],
        '___api_name___': api.values['name'],
        '___api_version___': api.values['version'],
        }
    list_replacements = {
        '___models_': ['model', api.ModelClasses()],
        '___topLevelModels_': ['model', api.TopLevelModelClasses()],
        }
    self.WalkTemplateTree('templates', path_replacements, list_replacements,
                          {'api': api.values}, source_package_writer)
    # Call back to the language specific generator to give it a chance to emit
    # special case elements.
    self.GenerateExtraSourceOutput(source_package_writer)

  def GenerateExtraSourceOutput(self, source_package_writer):
    """Extension point for subclasses to add extra data to the output.

    A language generator may provide an implementation of this to emit elements
    which cannot be handled by GenerateLibraryPackage.

    Args:
      source_package_writer: (LibraryPackage) An output package writer.
    """
    pass

  def AnnotateApiForLanguage(self, the_api):
    """Add the language specific annotations to an api.

    Performs all the language specific annotations on an API so it is ready to
    use for generating a library surface. This is essentially an impedance match
    between what is expressed in the API definition and how a language specific
    binding can be expressed using only templates.

    Args:
      the_api: (Api) The API to annotate.
    """
    the_api.VisitAll(lambda o: o.SetLanguageModel(self.language_model))
    the_api.void_type.SetLanguageModel(self.language_model)
    the_api.SetTemplateValue(
        'libraryNameBase',
        'google-api-%s-%s' % (the_api.values['name'],
                              the_api.values['version']))
    self._SetUpPackages(the_api)
    self._AnnotateTree(the_api)

  def _AnnotateTree(self, api):
    """Decorate the API tree with language model specific elements.

    Walks the tree and calls annotators on the Methods and Properties.  This
    may be used to supply language specific transforms to an API between the
    time the API is loaded and before we generate code through the templates.

    Should be called after the API is constructed and before we generate
    any code.

    Args:
      api: (Api) The Api.
    """
    self.AnnotateApi(api)
    for schema in api.all_schemas.values():
      schema.SetTemplateValue('package', self.model_package)
      self.AnnotateSchema(api, schema)
      for prop in schema.values.get('properties', []):
        self.AnnotateProperty(api, prop, schema)
    for resource in api.values['resources']:
      self.AnnotateResource(api, resource)
    for method in api.values['methods']:
      self.AnnotateMethod(api, method, None)

  def AnnotateApi(self, api):
    """Extension point for subclasses to annotate the API node itself.

    A language generator may provide an implementation for this.

    Args:
      api: (Api) The Api.
    """
    pass

  def AnnotateMethod(self, unused_api, method, unused_resource):
    """Extension point for subclasses to annotate Resources.

    A language generator may provide an implementation for this.

    Args:
      unused_api: (Api) The Api.
      method: (Method) The Method to annotate.
      unused_resource: (Resource) The Resource which owns this Method.
    """
    for parameter in method.parameters:
      self.AnnotateParameter(method, parameter)

  def AnnotateParameter(self, method, parameter):
    """Extension point for subclasses to annotate method Parameters.

    A language generator may provide an implementation for this.

    Args:
      method: (Method) The Method this parameter belongs to.
      parameter: (Parameter) The Parameter to annotate.
    """
    pass

  def AnnotateProperty(self, api, prop, schema=None):
    """Extension point for subclasses to annotate Properties.

    A language generator may provide an implementation for this.

    Args:
      api: (Api) The Api.
      prop: (Property) The Property to annotate.
      schema: (Schema) The Schema this Property belongs to.
    """
    pass

  def AnnotateResource(self, api, resource):
    """Extension point for subclasses to annotate Resources.

    A language generator may provide an implementation for this. The default
    walks the Resources methods and sub-resources to annotate those.

    Args:
      api: (Api) The Api which owns this resource.
      resource: (Resource) The Resource to annotate.
    """
    for method in resource.values['methods']:
      self.AnnotateMethod(api, method, resource)
    for r in resource.values['resources']:
      self.AnnotateResource(api, r)

  def AnnotateSchema(self, api, schema):
    """Extension point for subclasses to annotate Schemas.

    A language generator may provide an implementation for this.

    Args:
      api: (Api) The Api.
      schema: (Schema) The Schema to annotate
    """
    pass

  def DefaultPackagePath(self, the_api):
    """Returns the default package path for this API.

    Individual languages generators should probably override this.

    Args:
      the_api: (Api) and API to pick a path for

    Returns:
      (str) a package path.
    """
    return 'com/google/%s' % the_api.values['name']

  def _SetUpPackages(self, the_api):
    """Do the default setup for the packages associated with an API.

    Priority of ways to set the package path.
    1. package_path from options
    2. package_path from api definition
    3. DefaultPackagePath() from (language specific) generator

    Once we get that, we add the version if the version_package option is set.

    Args:
      the_api: (Api) and API to pick the api information from.
    """
    package_path = self._options.get('package_path')
    if package_path is None:
      package_path = the_api.GetTemplateValue('packagePath')
    if package_path is None:
      package_path = self.DefaultPackagePath(the_api)
    if self._options.get('version_package'):
      package_path = '%s/%s' % (package_path, the_api.values['versionNoDots'])
    self.SetPackage(template_objects.Package(
        package_path, language_model=self.language_model))
    self._model_package = template_objects.Package('model',
                                                   parent=self._package)


class NullLibraryGenerator(ApiLibraryGenerator):
  """Used to flag a language that doesn't do library generation."""
  pass
