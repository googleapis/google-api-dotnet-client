#!/bin/bash

set -e

declare -r docs_credentials="$KOKORO_KEYSTORE_DIR/73713_docuploader_service_account"

./BuildGeneratedDocs.sh

# Push documentation, if we've got the keystore key
if [ -f $docs_credentials ]
then
  echo "Uploading documentation to googleapis.dev"
  ./UploadGeneratedDocs.sh $docs_credentials docs-staging
else
  echo "No credentials for googleapis.dev; skipping"
fi
