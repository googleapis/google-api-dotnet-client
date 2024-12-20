#!/bin/bash

# This script:
# - Builds generated packages
# - Builds support packages
# - Runs unit tests for support packages

set -ex

cd ..

# To avoid printing the dotnet CLI welcome message
export DOTNET_NOLOGO=true

echo "Creating solution for generated packages"

cd Src/Generated

rm -rf Generated.sln
dotnet new sln --name Generated

PROJECTS=$(dir)
echo $PROJECTS | xargs dotnet sln Generated.sln add

echo "Building generated packages"
dotnet build Generated.sln -c Release

echo "Building and unit testing support packages"
cd ../..
./RunUnitTests.sh

echo "Build and unit testing completed"
