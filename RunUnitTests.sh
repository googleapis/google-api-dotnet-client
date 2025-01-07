#!/bin/bash

# This script:
# - Builds generated packages
# - Builds support packages
# - Runs unit tests for support packages

set -ex

# To avoid printing the dotnet CLI welcome message
export DOTNET_NOLOGO=true

cd Src/Generated

PROJECTS=$(dir)
echo "Building generated packages"
for project in $PROJECTS
do
    dotnet build $project
done

cd ../Support

echo "Building support packages"
dotnet build GoogleApisClient.sln

echo "Unit testing support packages"
dotnet test --no-restore Google.Apis.Auth.Tests
dotnet test --no-restore Google.Apis.Tests

echo "Build and unit testing completed"
