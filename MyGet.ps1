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
& $msbuild14 /m /nr:false SupportLibraries.proj

# Build the Generated code (i.e. the specific API clients).
PrintHeader("Building GeneratedLibraries.proj")

# Install dependent Python libraries.
pip3 install django==1.7
pip3 install httplib2
pip3 install google-apputils
pip3 install google-api-python-client

& $msbuild14 /m /nr:false GeneratedLibraries.proj
