#!/bin/bash

declare -r SECRETS_LOCATION="${KOKORO_GFILE_DIR}/secret_manager"

# Populates secrets from Secret Manager according
# to what's specified on env variables.
populate_all_secrets(){
    echo "Creating folder on disk for secrets: ${SECRETS_LOCATION}"
    mkdir -p ${SECRETS_LOCATION}

    populate_secrets "${COMMON_SECRETS}" "cloud-sharp-jenkins"
    populate_secrets "${JOB_SECRETS}" "cloud-sharp-jenkins"
    populate_secrets "${EXTERNAL_SECRETS}" "cloud-devrel-kokoro-resources"

    # docuploader expects credentials on the Keystore path, so let's copy them there as well.
    if [ -f "${SECRETS_LOCATION}/docuploader_service_account" ];
    then
        mkdir -p ${KOKORO_KEYSTORE_DIR}
        cp "${SECRETS_LOCATION}/docuploader_service_account" "$KOKORO_KEYSTORE_DIR/73713_docuploader_service_account"
    fi
}

populate_secrets(){
    local env_var=$1
    local project=$2
    for key in $(echo ${env_var} | sed "s/,/ /g")
    do
      echo "Retrieving secret ${key}"
      gcloud secrets versions access latest \
        --project $project \
        --secret $key > \
        "${SECRETS_LOCATION}/$key"
      if [[ $? == 0 ]]; then
        echo "Secret written to ${SECRETS_LOCATION}/${key}"
      else
        echo "Error retrieving secret ${key}"
        exit 1
      fi
    done
}
