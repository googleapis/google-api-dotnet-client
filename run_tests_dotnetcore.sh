#!/bin/bash
# Runs the .NET Core tests locally (Linux).

set -e

# Restore support libraries and tests.
dotnet restore Src/Support/GoogleApis.Core_dotnetcore --configfile NuGet.Core.Config
dotnet restore Src/Support/GoogleApis_dotnetcore --configfile NuGet.Core.Config
dotnet restore Src/Support/GoogleApis.Auth_dotnetcore --configfile NuGet.Core.Config
dotnet restore Src/Support/GoogleApis.Tests_dotnetcore --configfile NuGet.Core.Config
dotnet restore Src/Support/GoogleApis.Auth.Tests_dotnetcore --configfile NuGet.Core.Config

# Restore generated libraries and tests.
dotnet restore Src/Generated/Google.Apis.Discovery.v1 --configfile NuGet.Core.Config
dotnet restore Src/GeneratedTests/Discovery.Tests --configfile NuGet.Core.Config

# Test support libraries.
dotnet test Src/Support/GoogleApis.Tests_dotnetcore
dotnet test Src/Support/GoogleApis.Auth.Tests_dotnetcore

# Test generated libraries.
dotnet test Src/GeneratedTests/Discovery.Tests
