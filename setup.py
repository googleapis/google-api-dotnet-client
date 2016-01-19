#!/usr/bin/python2.7
"""Setup script for Google APIs Client Generator."""

from ez_setup import use_setuptools
use_setuptools()

from setuptools import find_packages  # pylint:disable=g-import-not-at-top
from setuptools import setup


setup(
    name='google-apis-client-generator',
    version='1.4.2',
    description='Google Apis Client Generator',
    long_description=open('README').read(),
    author='Tony Aiuto',
    author_email='aiuto@google.com',
    maintainer='Jacob Smullyan',
    maintainer_email='smulloni@google.com',
    url='https://github.com/google/apis-client-generator/',
    packages=find_packages('src'),
    package_dir={'': 'src'},
    entry_points={
        'console_scripts': [
            ('generate_library = '
             'googleapis.codegen.script_stubs:RunGenerateLibrary'),
            ('expand_templates = '
             'googleapis.codegen.script_stubs:RunExpandTemplates')
            ]},
    include_package_data=True,
    install_requires=['django<1.9',
                      'httplib2',
                      'google-apputils',
                      'python-gflags',
                      'google-api-python-client'],
    zip_safe=False)
