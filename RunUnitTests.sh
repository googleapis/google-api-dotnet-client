#!/bin/bash

set -e

dotnet build Src/Support/GoogleApisClient.sln
dotnet test --no-restore Src/Support/Google.Apis.Auth.Tests/Google.Apis.Auth.Tests.csproj
dotnet test --no-restore Src/Support/Google.Apis.Tests/Google.Apis.Tests.csproj
