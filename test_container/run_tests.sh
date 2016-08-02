#! /usr/bin/env bash
# Runs the tests inside of the container.

set -eu

# Clone the repo.
git clone /var/repo /repo
cd /repo

# Restore the packages for the tests.
pushd ./Src/Support
nuget restore
dotnet restore \
    "Src/Support/GoogleApis.Tests_dotnetcore" \
    "Src/Support/GoogleApis.Auth.Tests_dotnetcore" \
    -f /var/nuget \
    --no-cache
popd

echo "Running tests for .NET 4.5 targets."
./travis.sh
