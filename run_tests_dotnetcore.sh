#! /usr/bin/env bash
# Runs the tests for the .NET Core version of the support libraries.

# Exit on error or undefined.
set -eu

# Get the environment.
readonly workspace=$(dirname $0)
readonly fallback="${HOME}/nuget"
readonly packages="${workspace}/packages"

# Restore the packages.
dotnet restore \
    "Src/Support/GoogleApis.Tests_dotnetcore" \
    "Src/Support/GoogleApis.Auth.Tests_dotnetcore" \
    -f "${fallback}" \
    --no-cache

# Run the tests.
dotnet test "Src/Support/GoogleApis.Tests_dotnetcore"
dotnet test "Src/Support/GoogleApis.Auth.Tests_dotnetcore"
