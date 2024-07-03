#!/bin/bash

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
declare -r nuget_token="$(cat "$SECRETS_LOCATION"/google-apis-nuget-api-key)"

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
./BuildGenerated.sh @tmp/ApisToGenerate.txt

# Release all the NuGet packages we've created.
for pkg in ./NuPkgs/Generated/*.nupkg; do
  if [[ $pkg != *.symbols.* ]]; then
    dotnet generate-sbom $pkg
    # We take care to only generate packages that have changed, except when FORCE_ALL == true.
    # Still we have encountered a couple of instances where line endings differences and similar
    # have been detected as changes which results in an attempt to push an already published
    # package. So to be safe, let's always return true here.
    nuget push $pkg $nuget_token -Source nuget.org || true
    sleep 10
  fi
done

# Push changes to git, not to the main branch but to branchname
git add -A
git commit -m "Update discovery documents and generated code" -m "automatically_generated_update"
# We change the origin URL so that we can push with SSH
git remote set-url origin git@github.com:googleapis/google-api-dotnet-client.git
git push --set-upstream origin $branchname

# Create a PR for the changes in branchname.
prRequestBody='{"title":"Release PR: '"$branchname"'", "body": "Changes in this PR have already been published to Nuget.", "head": "'"$branchname"'", "base": "main"}'
curl -v -i -X POST https://api.github.com/repos/googleapis/google-api-dotnet-client/pulls -H 'Authorization: token '"$github_token" -H "Content-Type:application/json" -H "accept: */*" -d "$prRequestBody"

# All done :)
echo "Success - Discovery libraries release completed."
