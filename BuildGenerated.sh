#!/bin/bash

set -e

# Try to detect Python 2. It's quite different between Windows and Linux.
if which python > /dev/null && python --version 2>&1 | grep -q "Python 2"; then declare -r PYTHON2=python
elif which py > /dev/null && py -2 --version 2>&1 | grep -q "Python 2"; then declare -r PYTHON2="py -2"
elif which python2 > /dev/null && python2 --version 2>&1 | grep -q "Python 2"; then declare -r PYTHON2=python2
else
  echo "Unable to detect Python 2 installation."
  exit 1
fi

source CSharpGeneratorFunctions.sh

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

# Which generator to use - "python" (in this repo) or "csharp"
# (from https://github.com/googleapis/gapic-generator-csharp).
# This can be forced using --use_csharp_generator or --use_python_generator
GENERATOR_TYPE=csharp

# Forces sourcelink to work during the build.
export CI=true

while [[ $# -gt 0 ]]; do
  key="$1"
  case $key in
    --skipdownload)
      SKIPDOWNLOAD=TRUE
      ;;
    --skiprevert)
      SKIPREVERT=TRUE
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
    --use_csharp_generator)
      GENERATOR_TYPE=csharp
      ;;
    --use_python_generator)
      GENERATOR_TYPE=python
      ;;
    *)
      echo ERROR: Invalid argument to BuildGenerated.sh: \'$key\'
      exit 1
  esac
  shift
done

if [[ $GENERATOR_TYPE == "csharp" ]]
then
  install_csharp_generator
fi

if [ -z ${SKIPDOWNLOAD+x} ]; then
  # Delete all discovery docs
  echo Deleting existing \'$DISCOVERY_DOC_DIR\' directory...
  rm -rf $DISCOVERY_DOC_DIR
  # Download all discovery docs
  $PYTHON2 -u get_discovery_documents.py --destination_dir $DISCOVERY_DOC_DIR
  # Patch discovery docs
  dotnet run --project $TOOLS_DIR/DiscoveryDocPatcher/DiscoveryDocPatcher.csproj -- $DISCOVERY_DOC_DIR
  
  if [[ $SKIPREVERT == "TRUE" ]]
  then
    echo "Skipping revision/etag-only check of discovery docs"
  else
    # Revert changes that only affect the revision
    for discovery in $(git status -s -- DiscoveryJson | grep -E '^ M' | cut "-d " -f3)
    do
      # All but the last lines of grep here are removing extraneous output from git diff.
      # The last lines identify lines that are just changes to "revision" or "etag".
      if [[ ! $(git diff --unified=0 -- $discovery 2>&1 | \
                grep -v "warning: LF" | \
                grep -v "original line endings" |
                grep -v '\-\-\-' | \
                grep -v '+++' | \
                grep -v @@ | \
                grep -v "diff --git" | \
                grep -v -E '^index' | \
                grep -v -E '[-+] "revision":' | \
                grep -v -E '[-+] "etag":' ) ]]
      then
        echo "$discovery has only changed revision; reverting"
        git checkout -q -- $discovery
      fi   
    done
  fi
fi

if [ -z ${SKIPGENERATE+x} ]; then
  # Delete all generated code
  echo Deleting existing \'$CODE_GENERATION_DIR\' directory...
  rm -rf $CODE_GENERATION_DIR
  # Generate API projects from discovery docs
  export PYTHONPATH=$(pwd)/ClientGenerator/src
  for jsonfile in $DISCOVERY_DOC_DIR/*.json; do
    IFS='/'; names=($jsonfile); unset IFS
    name=$(echo ${names[-1]} | sed 's/.json//g')
    case $name in
      identitytoolkit_v3|oauth2_v1)
        echo Ignoring: \'$name\'
        ;;
      *)
        echo Generating: \'$name\'
        if [[ $GENERATOR_TYPE == "python" ]]
        then
          $PYTHON2 -uR $(pwd)/ClientGenerator/src/googleapis/codegen/generate_library.py --input="$jsonfile" --language=csharp --output_dir="$CODE_GENERATION_DIR"
        elif [[ $GENERATOR_TYPE == "csharp" ]]
        then
          run_csharp_generator "$jsonfile" "$CODE_GENERATION_DIR"
        else
          echo "Unknown generator type $GENERATOR_TYPE"
        fi
        if [[ -f $(pwd)/PostGeneration/$name.sh ]]
        then
          echo "Running post-generation step for $name"
          $(pwd)/PostGeneration/$name.sh
        fi
        ;;
    esac
  done
fi

if [ -z ${SKIPBUILD+x} ]; then
  rm -f Generated.sln
  dotnet new sln --name Generated
  echo $CODE_GENERATION_DIR/*/*.csproj | xargs dotnet sln Generated.sln add
  dotnet restore Generated.sln
  dotnet build Generated.sln --configuration $BUILD_CONFIGURATION --no-restore
fi

if [ -z ${SKIPPACK+x} ]; then
  # Delete all generated nupkgs
  echo Deleting existing \'$NUPKG_DIR\' directory...
  rm -rf $NUPKG_DIR
  dotnet pack Generated.sln --configuration $BUILD_CONFIGURATION --no-restore --no-build --output $NUPKG_DIR
fi
