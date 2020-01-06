#!/bin/bash

set -e

# "nuget restore" fails if local package source directories don't exist.
mkdir -p NuPkgs/Support

# Final output directory of NuPkgs.
NUPKG_DIR=`pwd`/NuPkgs/Support
# Build configuration to build/pack.
BUILD_CONFIGURATION=Release

# Forces sourcelink to work during the build.
export CI=true

dotnet restore Src/Support/GoogleApisClient.sln
dotnet build Src/Support/GoogleApisClient.sln --configuration $BUILD_CONFIGURATION --no-restore
dotnet pack Src/Support/GoogleApisClient.sln --configuration $BUILD_CONFIGURATION --no-restore --output $NUPKG_DIR
