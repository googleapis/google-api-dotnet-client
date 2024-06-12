#!/bin/bash

set -e

# Assumption: documentation has already been built

if [[ -z "$1" || -z "$2" ]]
then
  echo "Usage: UploadGeneratedDocs.sh <service account json> <staging bucket>"
  exit 1
fi

dotnet tool restore > /dev/null

declare -r service_account_json=$(realpath $1)
declare -r staging_bucket=$2
declare -r repo_root=$(git rev-parse --show-toplevel)
cd $repo_root

for pkgdir in Src/Generated/Google.*
do
  pkg=$(basename $pkgdir)

  # We don't generate sites if the documentation already exists, so only
  # do any work if we find we *have* generated the site
  if [[ -d Src/Generated/$pkg/obj/site ]]
  then
    version=$(grep \<Version\> Src/Generated/$pkg/$pkg.csproj | sed 's/</>/g' | cut -d\> -f 3)
    pushd Src/Generated/$pkg/obj/site > /dev/null
    echo "Uploading $pkg version $version"
    dotnet docuploader create-metadata --name $pkg --version $version --language dotnet --github-repository googleapis/google-api-dotnet-client
    dotnet docuploader upload --documentation-path . --credentials $service_account_json --staging-bucket $staging_bucket
    popd > /dev/null
  fi
done
