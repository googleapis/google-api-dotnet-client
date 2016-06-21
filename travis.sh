#!/usr/bin/env bash
# Script run by Travis CI

# grab nunit runners
nuget install NUnit.ConsoleRunner -Version 3.2.1 -OutputDirectory testrunner
NUNIT="${PWD}/testrunner/NUnit.ConsoleRunner.3.2.1/tools/nunit3-console.exe"

cd Src/Support

# Build ReleaseTravis configuration that skips all Windows projects
# as they are tricky to build under Mono.
xbuild /p:Configuration=ReleaseTravis GoogleApisClient.sln

OUTDIR=bin/ReleaseSigned

mono "${NUNIT}" "--where=test=~ImprovedResumableUploadTest" \
    "GoogleApis.Tests/${OUTDIR}/Google.Apis.Tests.exe" \
    "GoogleApis.Auth.Tests/${OUTDIR}/Google.Apis.Auth.Tests.exe" \
    "GoogleApis.Auth.DotNet4.Tests/${OUTDIR}/Google.Apis.Auth.DotNet4.Tests.exe"

for i in /home/travis/build/google/google-api-dotnet-client/serverlog*; do
  echo Log $i
  cat $i
  echo ---------------
done


