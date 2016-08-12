#!/bin/bash

set -e

dotnet restore Src/Support/GoogleApis.Core_dotnetcore --configfile NuGet.Linux.Config
dotnet restore Src/Support/GoogleApis_dotnetcore --configfile NuGet.Linux.Config
dotnet restore Src/Support/GoogleApis.Auth_dotnetcore --configfile NuGet.Linux.Config
dotnet restore Src/Support/GoogleApis.Tests_dotnetcore --configfile NuGet.Linux.Config
dotnet restore Src/Support/GoogleApis.Auth.Tests_dotnetcore --configfile NuGet.Linux.Config

dotnet test Src/Support/GoogleApis.Tests_dotnetcore
dotnet test Src/Support/GoogleApis.Auth.Tests_dotnetcore
