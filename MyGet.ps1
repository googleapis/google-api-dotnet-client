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
& $msbuild14 /m GeneratedLibraries.proj
