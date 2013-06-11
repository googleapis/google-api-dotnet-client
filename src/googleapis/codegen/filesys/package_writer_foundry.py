#!/usr/bin/python2.7
"""Foundary for getting a package writer."""

from googleapis.codegen.filesys import filesystem_library_package
from googleapis.codegen.filesys import tar_library_package
from googleapis.codegen.filesys import zip_library_package


def GetPackageWriter(output_dir=None, output_file=None, output_format='zip'):
  """Get an output writer for a package."""

  if not (output_dir or output_file):
    raise ValueError(
        'GetPackageWriter requires either output_dir or output_file')
  if output_dir and output_file:
    raise ValueError(
        'GetPackageWriter requires only one of output_dir or output_file')

  if output_dir:
    package_writer = filesystem_library_package.FilesystemLibraryPackage(
        output_dir)
  else:
    out = open(output_file, 'w')
    if output_format == 'tgz':
      package_writer = tar_library_package.TarLibraryPackage(out)
    elif output_format == 'tar':
      package_writer = tar_library_package.TarLibraryPackage(out,
                                                             compress=False)
    else:
      package_writer = zip_library_package.ZipLibraryPackage(out)
  return package_writer
