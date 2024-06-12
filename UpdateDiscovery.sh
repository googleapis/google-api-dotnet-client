#!/bin/bash

# UpdateDiscovery.sh [new-or-updated file]

# Downlaods all Discovery docs into tmp/DiscoveryJson, and
# updates DiscoveryJson with new/modified Discovery files,
# optionally writing a list of changes to a file (with one entry per line).

set -e
rm -rf tmp

# Directory in which to initially download Discovery docs.
TMP_DISCOVERY_DOC_DIR=tmp/DiscoveryJson

# Directory containing the final Discovery docs
DISCOVERY_DOC_DIR=DiscoveryJson

# Download all discovery docs
dotnet run --project Src/Tools/DiscoveryDocDownloader -- $TMP_DISCOVERY_DOC_DIR
# Patch discovery docs
dotnet run --project Src/Tools/DiscoveryDocPatcher -- $TMP_DISCOVERY_DOC_DIR
# Update the destination directory, recording changes in tmp/NewOrUpdated.txt
dotnet run --project Src/Tools/DiscoveryDocUpdater -- \
  $TMP_DISCOVERY_DOC_DIR \
  $DISCOVERY_DOC_DIR \
  ExcludedServices.json \
  $1

echo "Discovery update complete"
