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

# Download, generate, build and pack all generated libraries
# Build support libraries in case the latest support library version isn't yet on nuget.

./BuildSupport.sh

./BuildGenerated.sh --onlydownload

# Delete broken discovery docs here.
# E.g. rm -f DiscoveryJson/streetviewpublish_v1.json

# For more details go/dotnet-apiary-blocked-generation

# b/299933892 because of hierarchical resources
# "nodes/{node}/nodes/{node}"
rm -f DiscoveryJson/sasportal_v1alpha1.json
rm -f DiscoveryJson/prod_tt_sasportal_v1alpha1.json
# Known exception for library generation
rm -f DiscoveryJson/apigee_v1.json
# Name clashes because of some request's service parameter.
rm -f DiscoveryJson/metastore_v1alpha.json
rm -f DiscoveryJson/metastore_v1beta.json
rm -f DiscoveryJson/metastore_v1.json
# Investigating with Auth team
rm -f DiscoveryJson/identitytoolkit_v1.json
rm -f DiscoveryJson/identitytoolkit_v2.json
rm -f DiscoveryJson/identitytoolkit_v3.json
# Name clashes because of some response ETag field.
rm -f DiscoveryJson/contentwarehouse_v1.json
# b/299569133 method.request.type instead of method.request.$ref
# type is not a supported field in method.request.
rm -f DiscoveryJson/integrations_v1alpha.json
# b/299567447 method.request.type instead of method.request.$ref
# type is not a supported field in method.request.
rm -f DiscoveryJson/datalineage_v1.json
# b/299985033 Because on non-AIP compliant RPC.
rm -f DiscoveryJson/policysimulator_v1alpha.json
rm -f DiscoveryJson/policysimulator_v1beta.json

if [ "$FORCE_ALL" == "true" ]; then
  ./BuildGenerated.sh --skipdownload --forcegenerateall
else
  ./BuildGenerated.sh --skipdownload
fi

# Push support and generated packages to nuget
shopt -s nullglob
for pkg in ./NuPkgs/Support/*.nupkg; do
  if [[ $pkg != *.symbols.* ]]; then
    dotnet generate-sbom $pkg
    # During autorelease, pushing support packages is expected to fail often,
    # as support packages are updated with a lot less frequency than generated
    # packages, and when they are we usually release them manually anyway.
    nuget push $pkg $nuget_token -Source nuget.org || true
    sleep 10
  fi
done
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
