#!/bin/bash

# Builds an already-generated set of API libraries, as specified
# by command-line arguments. The libraries to build can be
# specified as multiple arguments (one per library), or as a single
# file containing a list of files/directories, using the "@" prefix.
# Each file/directory should be one of:
# - A project file
# - A directory containing a project
# - A JSON file - the Discovery doc for the service to be built
#
# Common examples:
#
#   In autorelease.sh:
#   ./BuildGenerated @tmp/ApisToGenerate.sh
#
#   After regenerating everything:
#   ./BuildGenerated.sh DiscoveryJson/*.json
#
#   Just to build all projects that currently exist:
#   ./BuildGenerate.sh Src/Generated/*

set -e

# Final output directory of NuPkgs.
NUPKG_DIR=$(pwd)/NuPkgs/Generated
rm -rf $NUPKG_DIR

if [[ $1 == "" ]]
then
  echo "Usage options:"
  echo "  BuildGenerated.sh <file1> [file2]"
  echo "  BuildGenerated.sh @file-with-paths"
  echo "Each file (either in file-with-paths or specified directly)"
  echo "should be a directory containing a project file, or a Discovery doc"
  exit 1
fi

echo "Creating solution"

# First argument is the generation directory, used for when Discovery docs have been specified.
PROJECTS=$(dotnet run --project Src/Tools/BuildGeneratedArgumentTranslator -- Src/Generated $*)
rm -rf Generated.sln
dotnet new sln --name Generated
echo $PROJECTS | xargs dotnet sln Generated.sln add

echo "Building/packing"
export CI=true
export DeterministicSourcePaths=true
dotnet pack Generated.sln -c Release -o $NUPKG_DIR

echo "Build complete"
