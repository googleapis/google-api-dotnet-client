#!/usr/bin/env bash
# Script run by Travis CI

set -e

# Run the .NET Core tests.
dotnet test "Src/Support/GoogleApis.Tests_dotnetcore"
dotnet test "Src/Support/GoogleApis.Auth.Tests_dotnetcore"

# grab nunit runners
nuget install NUnit.ConsoleRunner -Version 3.2.1 -OutputDirectory testrunner
NUNIT="${PWD}/testrunner/NUnit.ConsoleRunner.3.2.1/tools/nunit3-console.exe"

cd Src/Support

# Build ReleaseTravis configuration that skips all Windows projects
# as they are tricky to build under Mono.
xbuild /p:Configuration=ReleaseTravis GoogleApisClient.sln

OUTDIR=bin/ReleaseSigned

mono "${NUNIT}" "--where" "cat != IgnoreOnTravis" \
    "GoogleApis.Tests/${OUTDIR}/Google.Apis.Tests.exe" \
    "GoogleApis.Auth.Tests/${OUTDIR}/Google.Apis.Auth.Tests.exe" \
    "GoogleApis.Auth.DotNet4.Tests/${OUTDIR}/Google.Apis.Auth.DotNet4.Tests.exe"
