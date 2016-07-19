@echo off
rem Runs the .NET Core tests locally.

setlocal

REM Build the support libraries.
msbuild SupportLibraries.proj

REM Clean slate after the build.
del /s/q %USERPROFILE%\.nuget
set workspace=%~p0
set fallback=%workspace%\NuPkgs

REM Restore the test projects.
dotnet restore ^
  "Src\Support\GoogleApis.Tests" ^
  "Src\Support\GoogleApis.Auth.Tests" ^
  --no-cache -f "%fallback%"

REM Run the tests.
dotnet test "Src\Support\GoogleApis.Tests"
dotnet test "Src\Support\GoogleApis.Auth.Tests"

echo Done.
