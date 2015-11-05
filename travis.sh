#!/usr/bin/env bash
# Script run by Travis CI

set -e

# grab nunit runners
nuget install NUnit.Runners -Version 2.6.4 -OutputDirectory testrunner
NUNIT="mono ./testrunner/NUnit.Runners.2.6.4/tools/nunit-console.exe"

OUTDIR=bin/Release

# Build ReleaseTravis configuration that skips all windows projects
# as they are tricky to build under Mono.
xbuild /p:Configuration=ReleaseTravis GoogleApisClient.sln

$NUNIT Src/GoogleApis.Tests/$OUTDIR/Google.Apis.Tests.dll Src/GoogleApis.Auth.Tests/$OUTDIR/Google.Apis.Auth.Tests.dll Src/GoogleApis.Auth.DotNet4.Tests/$OUTDIR/Google.Apis.Auth.DotNet4.Tests.dll
