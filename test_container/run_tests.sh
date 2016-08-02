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

# Run the tests.
exec ./travis.sh
