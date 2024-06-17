#!/bin/bash

set -e

# Forces sourcelink to work during the build.
export CI=true
export DeterministicSourcePaths=true

dotnet build Src/Support/GoogleApisClient.sln -c Release
dotnet pack Src/Support/GoogleApisClient.sln -c Release -o NuPkgs/Support
