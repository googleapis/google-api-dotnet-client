#!/bin/bash

set -e

# "nuget restore" fails if local package source directories don't exist.
mkdir -p NuPkgs/Support

# Final output directory of NuPkgs.
NUPKG_DIR=$(pwd)/NuPkgs/Generated
# Build configuration to build/pack.
BUILD_CONFIGURATION=Release
# Directory in which to download discovery docs.
DISCOVERY_DOC_DIR=$(pwd)/DiscoveryJson
# Code generation directory
CODE_GENERATION_DIR=$(pwd)/Src/Generated
# Directory containing tools used during the build.
TOOLS_DIR=$(pwd)/Src/Tools

while [[ $# -gt 0 ]]; do
  key="$1"
  case $key in
    --skipdownload)
      SKIPDOWNLOAD=TRUE
      ;;
    --skipgenerate)
      SKIPDOWNLOAD=TRUE
      SKIPGENERATE=TRUE
      ;;
    --skipbuild)
      SKIPDOWNLOAD=TRUE
      SKIPGENERATE=TRUE
      SKIPBUILD=TRUE
      ;;
    --skippack)
      SKIPDOWNLOAD=TRUE
      SKIPGENERATE=TRUE
      SKIPBUILD=TRUE
      SKIPPACK=TRUE
      ;;
    --onlydownload)
      SKIPGENERATE=TRUE
      SKIPBUILD=TRUE
      SKIPPACK=TRUE
      ;;
    --onlygenerate)
      SKIPDOWNLOAD=TRUE
      SKIPBUILD=TRUE
      SKIPPACK=TRUE
      ;;
    --onlybuild)
      SKIPDOWNLOAD=TRUE
      SKIPGENERATE=TRUE
      SKIPPACK=TRUE
      ;;
    --onlypack)
      SKIPDOWNLOAD=TRUE
      SKIPGENERATE=TRUE
      SKIPBUILD=TRUE
      ;;
    *)
      echo ERROR: Invalid argument to BuildGenerated.sh: \'$key\'
      exit 1
  esac
  shift
done

if [ -z ${SKIPDOWNLOAD+x} ]; then
  # Delete all discovery docs
  echo Deleting existing \'$DISCOVERY_DOC_DIR\' directory...
  rm -rf $DISCOVERY_DOC_DIR
  # Download all discovery docs
  python -u get_discovery_documents.py --destination_dir $DISCOVERY_DOC_DIR
  # Patch discovery docs
  dotnet restore $TOOLS_DIR/DiscoveryDocPatcher/DiscoveryDocPatcher.csproj
  dotnet run --project $TOOLS_DIR/DiscoveryDocPatcher/DiscoveryDocPatcher.csproj -- $DISCOVERY_DOC_DIR
fi

if [ -z ${SKIPGENERATE+x} ]; then
  # Delete all generated code
  echo Deleting existing \'$CODE_GENERATION_DIR\' directory...
  rm -rf $CODE_GENERATION_DIR
  # Generate API projects from discovery docs
  export PYTHONPATH=$(pwd)/ClientGenerator/src
  for jsonfile in $DISCOVERY_DOC_DIR/*.json; do
    IFS='/'; names=($jsonfile); unset IFS
    name=${names[-1]}
    case $name in
      identitytoolkit_v3.json|oauth2_v1.json)
        echo Ignoring: \'$name\'
        ;;
      *)
        echo Generating: \'$name\'
        python -uR $(pwd)/ClientGenerator/src/googleapis/codegen/generate_library.py --input="$jsonfile" --language=csharp --output_dir="$CODE_GENERATION_DIR"
        ;;
    esac
  done
fi

if [ -z ${SKIPBUILD+x} ]; then
  rm -f Generated.sln
  dotnet new sln --name Generated
  dotnet sln Generated.sln add $CODE_GENERATION_DIR/*/*.csproj
  dotnet restore Generated.sln
  dotnet build Generated.sln --configuration $BUILD_CONFIGURATION
fi

if [ -z ${SKIPPACK+x} ]; then
  # Delete all generated nupkgs
  echo Deleting existing \'$NUPKG_DIR\' directory...
  rm -rf $NUPKG_DIR
  dotnet pack Generated.sln --configuration $BUILD_CONFIGURATION --no-build --output $NUPKG_DIR
fi
