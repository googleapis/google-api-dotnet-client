# Performs the build for MyGet and uploads the generated NuGet packages to
# the "google-dotnet" feed.
#
# TODO(chrsmith): Confirm MyGet brings in the necessary submodules. Otherwise:
# git submodule update --init ClientGenerator
$msbuild14 = "${Env:ProgramFiles(x86)}\MSBuild\14.0\Bin\MSBuild.exe"

function PrintHeader($message) {
    Write-Host "****************************************"
    Write-Host $message
    Write-Host "****************************************"
}

# TODO(chrsmith): Explicitly set VisualStudioVersion here.

# Build the Support libraries.
# TODO(chrsmith): Run unit tests as applicable.
PrintHeader("Building SupportLibraries.proj")
& $msbuild14 /m SupportLibraries.proj

# Build the Generated code (i.e. the specific API clients).
PrintHeader("Building GeneratedLibraries.proj")
& $msbuild14 /m GeneratedLibraries.proj

# Build the Generated code (i.e. the specific API clients).
PrintHeader("Building GeneratedLibraries.proj")
# Note: When running multiple times on the same machine this may fail with:
#   error MSB3231: Unable to remove directory "Src/Generated". Access to the
#   path 'Microsoft.Bcl.Build.Tasks.dll' is denied.
# This is because the Clean target tries to delete a file locked by and
# msbuild process still in memory (but waiting for work). To fix:
#   taskkill /im msbuild.exe /f

# Install dependent Python libraries.
pip install django==1.7
pip install httplib2
pip install google-apputils
pip install google-api-python-client

& $msbuild14 /m GeneratedLibraries.proj
