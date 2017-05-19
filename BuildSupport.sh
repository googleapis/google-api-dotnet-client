#!/bin/bash

set -e

# "nuget restore" fails if local package source directories don't exist.
mkdir -p NuPkgs/Support

# Final output directory of NuPkgs.
NUPKG_DIR=`pwd`/NuPkgs/Support
# Build configuration to build/pack.
BUILD_CONFIGURATION=Release

dotnet restore Src/Support/GoogleApisClient.sln
dotnet build Src/Support/GoogleApisClient.sln --configuration $BUILD_CONFIGURATION
dotnet pack Src/Support/GoogleApisClient.sln --configuration $BUILD_CONFIGURATION --no-build --output $NUPKG_DIR
