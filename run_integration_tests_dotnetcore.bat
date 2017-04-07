@echo off
rem Runs the integration .NET Core tests locally (Windows).

setlocal

set workspace=%~dp0
set nugetconfig=%workspace%\NuGet.Core.Config

REM Restore support libraries and tests.
dotnet restore "Src\Support\GoogleApis.Core_dotnetcore\project.json" --configfile "%nugetconfig%"
dotnet restore "Src\Support\GoogleApis_dotnetcore\project.json" --configfile "%nugetconfig%"
dotnet restore "Src\Support\GoogleApis.Auth_dotnetcore\project.json" --configfile "%nugetconfig%"
dotnet restore "Src\Support\GoogleApis.Tests_dotnetcore\project.json" --configfile "%nugetconfig%"
dotnet restore "Src\Support\IntegrationTests_NetCore\project.json" --configfile "%nugetconfig%"

REM Test support libraries.
dotnet test "Src\Support\IntegrationTests_NetCore\project.json"
