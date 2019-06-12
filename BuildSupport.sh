#!/bin/bash

set -e

source DocfxFunctions.sh

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
dotnet pack Src/Support/GoogleApisClient.sln --configuration $BUILD_CONFIGURATION --no-restore --no-build --output $NUPKG_DIR

# Generate documentation
install_docfx
$DOCFX metadata -f Src/Support/docfx.json
$DOCFX build Src/Support/docfx.json
