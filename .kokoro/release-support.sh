#!/bin/bash

set -ex

# Make sure secrets are loaded in a well known location before running the release
source ./populatesecrets.sh
populate_all_secrets
# Restore tools, in particular the SBOM generator
mkdir -p ../NuPkgs/Support
dotnet tool restore

declare -r nuget_token="$(cat "$SECRETS_LOCATION"/google-apis-nuget-api-key)"

now="$(date +%Y-%m-%d.%H-%M-%S)"
branchname="release-$now"
cd ..

# Create a new branch to push the changes to.
git branch --no-track $branchname
git checkout $branchname
# So that chmod changes are ignored.
git config core.fileMode false

./BuildSupport.sh

# Push support packages to nuget
shopt -s nullglob
for pkg in ./NuPkgs/Support/*.nupkg; do
  if [[ $pkg != *.symbols.* ]]; then
    dotnet generate-sbom $pkg
    nuget push $pkg $nuget_token -Source nuget.org
  fi
done

# All done :)
echo "Success - Discovery libraries support release completed."
