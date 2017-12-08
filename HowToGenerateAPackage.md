# How to generate a nuget package from a discovery doc

This isn't quite a simple as it could be, but it's fairly simple:

1. Use a Windows machine with `Visual Studio 2017 v15.4` or greater; and a recent version of `git`.
1. `git clone https://github.com/google/google-api-dotnet-client.git`
1. Delete all files from the `DiscoveryJson` directory. They are all `.json` files.
1. Copy the discovery-doc `json` file into the `DiscoveryJson` directory.
1. Execute `./BuildGenerated.sh --skipdownload` from within `git bash`.
1. The nuget package will be generated into `nupkgs/generated/` directory.