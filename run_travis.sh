#! /usr/bin/env bash
# Runs the travis tests on the test container.
#   $1, the path to the directory with the packages.

set -eu

readonly test_runner=test_runner:latest
readonly workspace=$(dirname $0)

docker run \
    -it \
    -v "${PWD}/":/var/repo:ro \
    -v "$1":/var/nuget:ro \
    ${test_runner}
