#!/bin/bash

set -ex

# Make sure secrets are loaded in a well known localtion before running releasetool
source ./populatesecrets.sh
populate_all_secrets

declare -r github_token="$SECRETS_LOCATION/google-api-dotnet-client-github-token"
declare -r nuget_token="$SECRETS_LOCATION/google-apis-nuget-api-key"

now="$(date +%Y-%m-%d.%H-%M-%S)"
branchname="release-$now"
cd ..

# Create a new branch to push the changes to.
git branch --no-track $branchname
git checkout $branchname

# Download, generate, build and pack all generated libraries
# Build support libraries in case the latest support library version isn't yet on nuget.

./BuildSupport.sh

./BuildGenerated.sh --onlydownload

# Delete broken discovery docs here.
# E.g. rm -f DiscoveryJson/streetviewpublish_v1.json

# These have nested resources with the same type as the parent
rm -f DiscoveryJson/sasportal_v1alpha1.json
rm -f DiscoveryJson/prod_tt_sasportal_v1alpha1.json
rm -f DiscoveryJson/apigee_v1.json
# The following 3 have a Service named parameter in a request
# that clashes with our own IClientService Service property
# that we have in BaseServiceRequest
rm -f DiscoveryJson/metastore_v1alpha.json
rm -f DiscoveryJson/metastore_v1beta.json
rm -f DiscoveryJson/metastore_v1.json
# b/238627322
rm -f DiscoveryJson/monitoring_v1.json
# We've only generated identitytoolkit_v3 during 2013 and 2014.
# After that it was skipped for generation and the package delisted.
# v1 and v2 were introduced in August 2022 and v1 was broken.
# As of 20221018, v1 has nested resources or methods with the same name
# but v2 and v3 generate and build fine.
# That Auth team is looking into whether we should generate v2 and v3.
rm -f DiscoveryJson/identitytoolkit_v1.json
rm -f DiscoveryJson/identitytoolkit_v2.json
rm -f DiscoveryJson/identitytoolkit_v3.json
# There's a response type that itself represents and HTTP response
# and includes an ETag property whose value is the Etag for the
# response that it represents and not its own. The type ends having
# two ETag properties.
rm -f DiscoveryJson/contentwarehouse_v1.json
# TODO[atarafamas] find out why
rm -f DiscoveryJson/integrations_v1alpha.json


./BuildGenerated.sh --skipdownload

# Push support and generated packages to nuget
shopt -s nullglob
for pkg in ./NuPkgs/Support/*.nupkg; do
  if [[ $pkg != *.symbols.* ]]; then
    # Push is expected to fail often; when a package hasn't been updated.
    # TODO: uncomment this once everything else is working.
    # nuget push $pkg $nuget_token -Source nuget.org || true
    echo "Would have pushed to nuget ""$pkg"
  fi
done
for pkg in ./NuPkgs/Generated/*.nupkg; do
  if [[ $pkg != *.symbols.* ]]; then
    # Push is expected to fail often; when a package hasn't been updated.
    # TODO: uncomment this once everything else is working.
    # nuget push $pkg $nuget_token -Source nuget.org || true
    echo "Would have pushed to nuget ""$pkg"
  fi
done

# Push changes to git, not to the main branch but to branchname
git add -v -A
git commit -v -m "Update discovery documents and generated code" -m "automatically_generated_update"
# We change the origin URL so that we can push with SSH
git remote set-url origin git@github.com:googleapis/google-api-dotnet-client.git
git push -v --set-upstream origin $branchname

# Create a PR for the changes in branchname.
# TODO: Remove the draft flag once everything else is working.
prRequestBody='{"title":"Release PR: '"$branchname"'", "body": "Changes in this PR have already been published to Nuget.", "head": "'"$branchname"'", "base": "main", "draft": true}'
curl -v -i -X POST https://api.github.com/repos/googleapis/google-api-dotnet-client/pulls -H 'Authorization: token '"$github_token" -H "Content-Type:application/json" -H "accept: */*" -d "$prRequestBody"

# All done :)
echo "Success - Apiary release completed."
