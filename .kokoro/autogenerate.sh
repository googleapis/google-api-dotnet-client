#!/bin/bash

# This script:
# - Updates Discovery docs
# - Runs the generator on new/changed APIs
# - Builds any generated APIs
# - Creates a PR with changes
#
# It does not release any NuGet packages; that's handled by autorelease.sh
# (The reason for the split is so that we only ever release
# code that's already in GitHub - which means SourceLink should be accurate.)

set -ex

# Make sure secrets are loaded in a well known location before running the release
source ./populatesecrets.sh
populate_all_secrets
# Restore tools, in particular the SBOM generator.
mkdir -p ../NuPkgs/Support
dotnet tool restore

declare -r github_user="$(cat "$SECRETS_LOCATION"/google-api-dotnet-client-github-user-name)"
declare -r github_email="$(cat "$SECRETS_LOCATION"/google-api-dotnet-client-github-user-email)"
declare -r github_token="$(cat "$SECRETS_LOCATION"/google-api-dotnet-client-github-token)"

now="$(date +%Y-%m-%d.%H-%M-%S)"
branchname="release-$now"
cd ..

# Create a new branch to push the changes to.
git branch --no-track $branchname
git checkout $branchname
# So that chmod changes are ignored.
git config core.fileMode false
# Even though we use the token to authenticate, we need the email for the CLA.
git config user.name "$github_user"
git config user.email "$github_email"

# Fetch all discovery docs into tmp/DiscoveryJson, copying new/updated ones
# into DiscoveryJson. The tmp/ApisToGenerate.txt file lists the Discovery
# docs that are updated.
./UpdateDiscovery.sh tmp/ApisToGenerate.txt

# If we actually want to generate everything, just list all the Discovery docs.
if [ "$FORCE_ALL" == "true" ]
then
  # Note that this form of ls ends up with the file containing
  # DiscoveryJson/xyz.json rather than just xyz.json.
  ls DiscoveryJson/*.json > tmp/ApisToGenerate.txt
fi

if [[ ! -s tmp/ApisToGenerate.txt ]]
then
  echo "No APIs to generate; exiting build"
  exit 0
fi

# Generate all APIs listed in tmp/ApisToGenerate.txt
./GenerateApis.sh @tmp/ApisToGenerate.txt

# Build and pack all APIs listed in tmp/ApisToGenerate.txt
# (We don't actually need to pack here, but it's simplest to always do so.)
./BuildGenerated.sh @tmp/ApisToGenerate.txt

# Push changes to git, not to the main branch but to branchname
git add -A
git commit -m "Update discovery documents and generated code" -m "automatically_generated_update"
# We change the origin URL so that we can push with SSH
git remote set-url origin git@github.com:googleapis/google-api-dotnet-client.git
git push --set-upstream origin $branchname

# Create a PR for the changes in branchname.
prRequestBody='{"title":"feat: API regeneration: '"$branchname"'", "body": "Changes in this PR will be published to Nuget on the next release cycle.", "head": "'"$branchname"'", "base": "main"}'
curl -v -i -X POST https://api.github.com/repos/googleapis/google-api-dotnet-client/pulls -H 'Authorization: token '"$github_token" -H "Content-Type:application/json" -H "accept: */*" -d "$prRequestBody"

# All done :)
echo "Success - Discovery libraries generation completed."
