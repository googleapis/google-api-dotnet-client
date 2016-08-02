#! /usr/bin/env bash
# Runs the travis tests on the test container.
set -eu

readonly test_runner=test_runner:latest
readonly workspace=$(dirname $0)

docker run \
    -it \
    -v "${PWD}/":/var/repo:ro \
    ${test_runner}

