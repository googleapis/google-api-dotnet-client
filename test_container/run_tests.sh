#! /usr/bin/env bash
# Runs the tests inside of the container.

set -eu

# Clone the repo.
git clone /var/repo /repo

# Restore and run the tests.
cd /repo

pushd ./Src/Support
mono /tools/nuget.exe restore
popd

# Run the tests.
exec ./travis.sh
