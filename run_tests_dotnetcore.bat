@echo off
rem Runs the .NET Core tests locally.

setlocal

REM Build the support libraries.
msbuild SupportLibraries.proj

REM Clean slate after the build.
set workspace=%~dp0
set fallback=%workspace%\NuPkgs
set packages=%workspace%\packages

REM Restore the test projects.
dotnet restore ^
  "Src\Support\GoogleApis.Tests_dotnetcore" ^
  "Src\Support\GoogleApis.Auth.Tests_dotnetcore" ^
  --packages "%packages%" ^
  -f "%fallback%" ^
  --no-cache

REM Run the tests.
dotnet test "Src\Support\GoogleApis.Tests_dotnetcore"
dotnet test "Src\Support\GoogleApis.Auth.Tests_dotnetcore"

echo Done.
