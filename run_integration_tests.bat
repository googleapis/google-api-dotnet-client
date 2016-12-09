@echo off
rem Runs integration tests the tests locally (Net45).

setlocal

set runner_root=%USERPROFILE%\testrunner
set nunit="%runner_root%\NUnit.ConsoleRunner.3.2.1\tools\nunit3-console.exe"

if not exist %nunit% (
  rem Grabs the nunit test runner.
  echo Installing nunit runner.
  nuget install NUnit.ConsoleRunner -Version 3.2.1 -OutputDirectory "%runner_root%"
) else (
  echo Nunit runner already installed.
)

rem Build the code with the travis configuration.
pushd Src\Support
msbuild /p:Configuration=ReleaseTravis GoogleApisClient.sln

set output=bin\ReleaseSigned

%nunit% ^
  "IntegrationTests_Net45\%output%\IntegrationTests_Net45.exe"

popd

echo Done.
