#!/bin/bash

# UpdateDiscovery.sh [new-or-updated file]

# Downlaods all Discovery docs into tmp/DiscoveryJson, and
# updates DiscoveryJson with new/modified Discovery files,
# optionally writing a list of changes to a file (with one entry per line).

set -e
rm -rf tmp
mkdir tmp

# Directory in which to clone discovery-artifact-manager
TMP_DISCOVERY_ARTIFACT_MANAGER_DIR=tmp/discovery-artifact-manager

# Directory containing discovery docs
TMP_DISCOVERY_DOC_DIR=$TMP_DISCOVERY_ARTIFACT_MANAGER_DIR/discoveries

# Directory containing the final Discovery docs
DISCOVERY_DOC_DIR=DiscoveryJson

# Clone the discovery-artifact-manager repo
git clone https://github.com/googleapis/discovery-artifact-manager \
  --depth 1 $TMP_DISCOVERY_ARTIFACT_MANAGER_DIR

# Patch discovery docs
dotnet run --project Src/Tools/DiscoveryDocPatcher -- $TMP_DISCOVERY_DOC_DIR

# Update the destination directory, recording changes in tmp/NewOrUpdated.txt
dotnet run --project Src/Tools/DiscoveryDocUpdater -- \
  $TMP_DISCOVERY_DOC_DIR \
  $DISCOVERY_DOC_DIR \
  ExcludedServices.json \
  $1

echo "Discovery update complete"
