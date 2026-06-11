#!/bin/bash

# This script:
# - Builds generated packages
# - Builds support packages
# - Runs integration tests for support packages

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

echo "Integration testing support packages"
dotnet test --no-restore Google.Apis.IntegrationTests

echo "Build and integration testing completed"
