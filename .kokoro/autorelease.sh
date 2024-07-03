#!/bin/bash

# This script:
# - Checks which generated APIs do not have up-to-date NuGet packages yet
# - Generates them
# - Pushes the NuGet packages
#
# It does not update Discovery docs or run the generator;
# that's handled by autogenerate.sh.
# (The reason for the split is so that we only ever release
# code that's already in GitHub - which means SourceLink should be accurate.)

set -ex

# Make sure secrets are loaded in a well known location before running the release
source ./populatesecrets.sh
populate_all_secrets
# Restore tools, in particular the SBOM generator.
mkdir -p ../NuPkgs/Support
dotnet tool restore

declare -r nuget_token="$(cat "$SECRETS_LOCATION"/google-apis-nuget-api-key)"

cd ..

rm -rf tmp
mkdir tmp
dotnet run --project=Src/Tools/PackageChecker -- Src/Generated > tmp/ApisToBuild.txt

if [[ ! -s tmp/ApisToBuild.txt ]]
then
  echo "All APIs have already been released; exiting build"
  exit 0
fi


# Build and pack all APIs listed in tmp/ApisToBuild.txt
./BuildGenerated.sh @tmp/ApisToBuild.txt

# Release all the NuGet packages we've created.
for pkg in ./NuPkgs/Generated/*.nupkg; do
  if [[ $pkg != *.symbols.* ]]; then
    dotnet generate-sbom $pkg
    # We take care not to generate packages which have already been
    # released (via the PackageChecker tool) so if nuget push fails,
    # it's reasonable to fail the build.
    nuget push $pkg $nuget_token -Source nuget.org
    sleep 10
  fi
done

# All done :)
echo "Success - Discovery libraries release completed."
