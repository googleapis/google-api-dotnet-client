#!/bin/bash

set -e

# NuGet package cache directory for restore/build.
NUGET_PACKAGE_DIR=`pwd`/Packages
# Final output directory of NuPkgs.
NUPKG_DIR=`pwd`/NuPkgs/Support
# Build configuration to build/pack.
BUILD_CONFIGURATION=Release

export NUGET_PACKAGES=$NUGET_PACKAGE_DIR

dotnet restore Src/Support/GoogleApisClient.sln
dotnet build Src/Support/GoogleApisClient.sln --configuration $BUILD_CONFIGURATION
dotnet pack Src/Support/GoogleApisClient.sln --configuration $BUILD_CONFIGURATION --no-build --output $NUPKG_DIR --include-symbols --include-source
