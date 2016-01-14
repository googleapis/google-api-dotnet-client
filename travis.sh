#!/usr/bin/env bash
# Script run by Travis CI

set -e

# grab nunit runners
nuget install NUnit.Runners -Version 2.6.4 -OutputDirectory testrunner
NUNIT="${PWD}/testrunner/NUnit.Runners.2.6.4/tools/nunit-console.exe"

cd Src/Support

# Build ReleaseTravis configuration that skips all Windows projects
# as they are tricky to build under Mono.
xbuild /p:Configuration=ReleaseTravis GoogleApisClient.sln

OUTDIR=bin/Release

mono "${NUNIT}" \
    "GoogleApis.Tests/${OUTDIR}/Google.Apis.Tests.dll" \
    "GoogleApis.Auth.Tests/${OUTDIR}/Google.Apis.Auth.Tests.dll" \
    "GoogleApis.Auth.DotNet4.Tests/${OUTDIR}/Google.Apis.Auth.DotNet4.Tests.dll"
