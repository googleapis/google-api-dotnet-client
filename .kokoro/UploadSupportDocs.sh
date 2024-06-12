#!/bin/bash

set -e

# Assumption: documentation has already been built

if [[ -z "$1" || -z "$2" ]]
then
  echo "Usage: UploadSupportDocs.sh <service account json> <staging bucket>"
  exit 1
fi

dotnet tool restore > /dev/null

declare -r service_account_json=$(realpath $1)
declare -r staging_bucket=$2
declare -r repo_root=$(git rev-parse --show-toplevel)
cd $repo_root

# Extract the support libraries version number from the XML.
# This is pretty horrible, but it works...
declare -r version=$(grep \<Version\> Src/Support/CommonProjectProperties.xml | sed 's/</>/g' | cut -d\> -f 3)
declare -r packages="Google.Apis.Core Google.Apis Google.Apis.Auth Google.Apis.Auth.AspNetCore3"

for pkg in $packages
do
  pushd Src/Support/$pkg/obj/site
  echo "Generating metadata for $pkg"
  dotnet docuploader create-metadata --name $pkg --version $version --language dotnet --github-repository googleapis/google-api-dotnet-client

  echo "Final upload stage"
  dotnet docuploader upload --documentation-path . --credentials $service_account_json --staging-bucket $staging_bucket
  popd > /dev/null
done
