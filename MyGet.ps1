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
Write-Host "Installing via py"
py -V
py -m ensurepip --upgrade
py -m pip list
py -m pip install django==1.7
py -m pip install httplib2
py -m pip install google-apputils
py -m pip install google-api-python-client
py -m pip list

Write-Host "Trying to call pip3 directly."
C:\Python34\Scripts\pip3.exe install django==1.7
C:\Python34\Scripts\pip3.exe install httplib2
C:\Python34\Scripts\pip3.exe install google-apputils
C:\Python34\Scripts\pip3.exe install google-api-python-client
C:\Python34\Scripts\pip3.exe list

Write-Host "Installing via python"
python -V
python -m ensurepip --upgrade
python -m pip list
python -m pip install django==1.7
python -m pip install httplib2
python -m pip install google-apputils
python -m pip install google-api-python-client

& $msbuild14 /m /nr:false GeneratedLibraries.proj
