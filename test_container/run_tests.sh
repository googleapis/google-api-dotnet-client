#! /usr/bin/env bash
# Runs the tests inside of the container.

set -eu

# Clone the repo.
git clone /var/repo /repo
cd /repo

# Restore the packages for the tests.
pushd ./Src/Support
nuget restore
popd

# Set the nuget fallback source to use.
export NUGET_FALLBACK_SOURCE=/var/nuget

# Run the tests.
./travis.sh
./run_tests_dotnetcore.sh
