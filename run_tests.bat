@echo off
rem Runs the tests locally.

setlocal

set runner_root=%USERPROFILE%\testrunner

rem Grabs the nunit test runner.
nuget install NUnit.ConsoleRunner -Version 3.2.1 -OutputDirectory "%runner_root%"
set nunit="%runner_root%\NUnit.ConsoleRunner.3.2.1\tools\nunit3-console.exe"

rem Build the code with the travis configuration.
pushd Src\Support
msbuild /p:Configuration=ReleaseTravis GoogleApisClient.sln

set output=bin\ReleaseSigned

%nunit% --where "cat != IgnoreOnTravis" ^
  "GoogleApis.Tests\%output%\Google.Apis.Tests.exe" ^
  "GoogleApis.Auth.Tests\%output%\Google.Apis.Auth.Tests.exe" ^
  "GoogleApis.Auth.DotNet4.Tests\%output%\Google.Apis.Auth.DotNet4.Tests.exe"

popd
echo Done.
