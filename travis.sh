#!/usr/bin/env bash
# Script run by Travis CI

set -e

# grab nunit runners
nuget install NUnit.ConsoleRunner -Version 3.2.1 -OutputDirectory testrunner
NUNIT="${PWD}/testrunner/NUnit.ConsoleRunner.3.2.1/tools/nunit3-console.exe"

cd Src/Support

# Build ReleaseTravis configuration that skips all Windows projects
# as they are tricky to build under Mono.
xbuild /p:Configuration=ReleaseTravis GoogleApisClient.sln

OUTDIR=bin/ReleaseSigned

mono "${NUNIT}" \
    "GoogleApis.Tests/${OUTDIR}/Google.Apis.Tests.dll" \
    "GoogleApis.Auth.Tests/${OUTDIR}/Google.Apis.Auth.Tests.dll" \
    "GoogleApis.Auth.DotNet4.Tests/${OUTDIR}/Google.Apis.Auth.DotNet4.Tests.dll"
