# Performs the build for MyGet and uploads the generated NuGet packages to
# the "google-dotnet" feed.
#
# MyGet's build syncs the repo and subrepos, to build manually be sure to:
# git submodule update --init ClientGenerator

function PrintHeader($message) {
    Write-Host "****************************************"
    Write-Host $message
    Write-Host "****************************************"
}

Write-Host ".NET Client Libraries, build shard $Env:BuildShard"

# Just needs to be a version installed on the system.
[Environment]::SetEnvironmentVariable(
    "VisualStudioVersion",
    "14.0",
    "User")

$msbuild14 = "${Env:ProgramFiles(x86)}\MSBuild\14.0\Bin\MSBuild.exe"

# Build the Support libraries.
PrintHeader "Building SupportLibraries.proj"
& $msbuild14 /m /nr:false SupportLibraries.proj

# TODO(chrsmith): Run unit tests as applicable.
# At HEAD we have some test failures due to portable libraries and the
# venerable System.Net.Http.Primitives assembly.

# Install dependent Python libraries.
PrintHeader "Installing Python dependencies"
python -V
python -m ensurepip --upgrade
python -m pip list
python -m pip install django==1.7
python -m pip install httplib2
python -m pip install google-apputils
python -m pip install google-api-python-client

# Build the Generated code (i.e. the specific API clients).
PrintHeader "Building GeneratedLibraries.proj"
& $msbuild14 /m /nr:false GeneratedLibraries.proj
