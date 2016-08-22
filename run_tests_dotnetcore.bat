@echo off
rem Runs the .NET Core tests locally (Windows).

setlocal

set workspace=%~dp0
set nugetconfig=%workspace%\NuGet.Core.Config

REM Restore support libraries and tests.
dotnet restore "Src\Support\GoogleApis.Core_dotnetcore\project.json" --configfile "%nugetconfig%"
dotnet restore "Src\Support\GoogleApis_dotnetcore\project.json" --configfile "%nugetconfig%"
dotnet restore "Src\Support\GoogleApis.Auth_dotnetcore\project.json" --configfile "%nugetconfig%"
dotnet restore "Src\Support\GoogleApis.Tests_dotnetcore\project.json" --configfile "%nugetconfig%"
dotnet restore "Src\Support\GoogleApis.Auth.Tests_dotnetcore\project.json" --configfile "%nugetconfig%"

REM Restore generated libraries and tests.
dotnet restore "Src\Generated\Google.Apis.Discovery.v1\project.json" --configfile "%nugetconfig%"
dotnet restore "Src\GeneratedTests\Discovery.Tests\project.json" --configfile "%nugetconfig%"

REM Test support libraries.
dotnet test "Src\Support\GoogleApis.Tests_dotnetcore\project.json"
dotnet test "Src\Support\GoogleApis.Auth.Tests_dotnetcore"

REM Test generated libraries.
dotnet test "Src\GeneratedTests\Discovery.Tests"
