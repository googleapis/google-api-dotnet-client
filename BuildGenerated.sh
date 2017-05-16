#!/bin/bash

set -e

# NuGet package cache directory for restore/build.
NUGET_PACKAGE_DIR=$(pwd)/Packages
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

export NUGET_PACKAGES=$NUGET_PACKAGE_DIR

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
  # Delete all discovery docs. Ignore failure if this dir doesn't exist.
  if [ -d $DISCOVERY_DOC_DIR ]; then
    echo Deleting existing \'$DISCOVERY_DOC_DIR\' directory...
    rm -r $DISCOVERY_DOC_DIR
  fi
  # Download all discovery docs
  python -u get_discovery_documents.py --destination_dir $DISCOVERY_DOC_DIR
  # Patch discovery docs
  dotnet restore $TOOLS_DIR/DiscoveryDocPatcher/DiscoveryDocPatcher.csproj
  dotnet run --project $TOOLS_DIR/DiscoveryDocPatcher/DiscoveryDocPatcher.csproj -- $DISCOVERY_DOC_DIR
fi

if [ -z ${SKIPGENERATE+x} ]; then
  # Delete all generated code. Ignore failure if this dir doesn't exist.
  if [ -d $CODE_GENERATION_DIR ]; then
    echo Deleting existing \'$CODE_GENERATION_DIR\' directory...
    rm -r $CODE_GENERATION_DIR
  fi
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
  # dotnet restore then build over all generated projects
  # Don't restore in parallel, 'dotnet restore' doesn't support concurrent restores.
  for csproj in $CODE_GENERATION_DIR/*/*.csproj; do
    dotnet restore $csproj
  done
  # Build in batches. This isn't the most efficient way of building concurrently, but it's fairly simple.
  # Each pid must be waited for individually to ensure errors stop this script.
  declare -r -i CONCURRENCY=4
  declare -a pids
  for csproj in $CODE_GENERATION_DIR/*/*.csproj; do
    if (( ${#pids[@]} >= $CONCURRENCY )); then
      wait ${pids[0]}
      unset pids[0]
      pids=( "${pids[@]}" )
    fi
    echo Building: $csproj
    dotnet build $csproj --configuration $BUILD_CONFIGURATION &
    pid=$!
    pids+=($pid)
  done
  for pid in "${pids[@]}"; do
    echo Waiting for pid: $pid
    wait $pid
  done
fi

if [ -z ${SKIPPACK+x} ]; then
  # dotnet restore then build over all generated projects
  for csproj in $CODE_GENERATION_DIR/*/*.csproj; do
    dotnet pack $csproj --configuration $BUILD_CONFIGURATION --no-build --output $NUPKG_DIR --include-symbols --include-source
  done
fi
