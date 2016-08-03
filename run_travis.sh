#! /usr/bin/env bash
# Runs the travis tests on the test container.

set -e

docker run \
    -it \
    -v "${PWD}/":/var/repo:ro \
    test_runner:latest
