# Easy Repro: Skeleton project for reproducing bugs

This project serves as a way to test integration-level changes to the Google
.NET client libraries, without needing to first publish binaries to NuGet.

This works through a `nuget.config` file that picks up the needed dependencies
from the local machine. (Instead of using the public NuGet packages.)

This project is not part of the regular build and not ran as part of the
release testing. It's only for debugging purposes. Read: this is not a
regression test suite. Rather, it is a debugging tool.

`TODO(chrsmith): Document how to build the Support libraries with DEBUG.`

Read this document top to bottom and be sure to follow along with each
and every step. Unfortunately there are a lot of subtle things you need
to get right.

## Getting Started

The first thing to do is to ensure you have a clean enlistment. Create a new
git branch as applicable and delete any untracked files. (e.g. previously
built NuGet packages.)

````
git clean -dxf
````

## How to Build

To build the .NET Client Libraries, run the following commands from PowerShell.
You will do this a few times while setting up your local issue repro.

````
$msbuild14 = "C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe"
& $msbuild14 /m /nr:false SupportLibraries.proj
& $msbuild14 /m /nr:false GeneratedLibraries.proj
````

## Getting Started

The first thing you need to do is make sure NuGet and the `nuget.config` are
correct. Edit `nuget.config` and add the file path where you build the client
libraies. This is dependent on where your repository is located on disk.

`TODO(chrsmith): Confirm this will work for multiple developers.`

````
notepad .\Src\Repro\nuget.config
````

Next you should probably delete the local NuGet package caches, since they
contain unknown versions of the NuGet packages.

````
Remove-Item -Force -Recurse C:\Users\$Env:UserName\AppData\Local\NuGet\Cache
Remove-Item -Force -Recurse C:\Users\$Env:UserName\.nuget\packages\
````

At this point you can begin creating a small program to reproduce any issues in
the .NET client libraries.

1. Build the libraries (both Suppport and Generated).
1. Open the `EasyRepo` project.
1. Click the gear in the _Package Manager Console_, and confirm that The
   two NuGet package sources "Private Support Libraries" and "Private Generated
   Libraries" are available. (These come from `nuget.config` next to the
   Solution file.)
1. Disable all other NuGet package sources.
1. Use the Visual Studio Package Manager Console to add any necessary
   dependencies. e.g. `Install-Package Google.Apis.Calendar.v3`.
   - If you run into errors with `Microsoft.Threading.Tasks` missing, enable
     the non-local NuGet sources and `Install-Package Microsoft.Bcl.Async`. I
     believe this has to do with the project template used, and not the client
     libraries.
   - @chrsmith got this to work without any problems. But if non-Google
     packages such as `Zlib.Portable` or `BouncyCastle.Crypto` cannot be found
     then consider checking them into the repo in `.nupkg` format.

At this point you have EasyRepo referencing locally built NuGet packages.
Update `Program.cs` to reproduce the failure you are investigating.

## Testing Fixes

By referencing the locally built NuGet packages, debugging should be much
easier since you have PDBs that match the source on disk.

Once you have figured out what needs to be tweaked, you need to run a few
steps so that the `EasyRepo` project can pick up your changes.

1. Rebuild the client libraries. (Perhaps only `SupportLibraries.proj` if the
   changes don't impact the generated libraries.)
1. From the PowerShell delete the previous NuGet packages:
   `Remove-Item .\Src\Repro\packages\Google* -Recurse`
1. Delete NuGet package caches too:
   `Remove-Item -Force -Recurse C:\Users\$Env:UserName\AppData\Local\NuGet\Cache`
   `Remove-Item -Force -Recurse C:\Users\$Env:UserName\.nuget\packages\`
1. Nuget restore the packages, which will pick up the newly built binaries:
   `nuget restore .\Src\Repro\EasyRepro.sln`

Now if you try to build `EasyRepo` you will get an error. This is expected.

````
Could not resolve this reference. Could not locate the assembly
"Google.Apis, Version=1.10.0.35122, Culture=neutral, PublicKeyToken=4b01fa6e34db77ab, processorArchitecture=MSIL". Check to make sure the assembly exists on disk. If this reference is required by your code, you may get compilation errors.			
````

It is because you built a new version of `Google.Apis`, but the project
references an older version. To fix this, select the relevante references in
the `EasyRepro` project and in the Property Window set the "Specific Version"
property from `True` to `False`. i.e. tell Visual Studio this is OK.

Clean the project and and then Rebuild. You should now get a warning message
suggesting you add an assembly redirect to the `app.config`. This is optional
and can be ignored.

At runtime you should see new behaviour from the client libraries, as they
should contain your recent changes.

NOTE: Every time you repeat this process, you must Clean the project before you
build. Otherwise the updated NuGet binaries won't be put into the bindir, and
you will get odd assembly load errors.
