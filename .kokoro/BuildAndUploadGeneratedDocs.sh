#!/bin/bash

set -e

# Make sure secrets are loaded in a well known localtion before running releasetool
source ./populatesecrets.sh
populate_all_secrets

declare -r docs_credentials="$SECRETS_LOCATION/docuploader_service_account"

./BuildGeneratedDocs.sh

# Push documentation, if we've got the keystore key
if [ -f $docs_credentials ]
then
  echo "Uploading documentation to googleapis.dev"
  ./UploadGeneratedDocs.sh $docs_credentials docs-staging
else
  echo "No credentials for googleapis.dev; skipping"
fi
