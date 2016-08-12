#!/usr/bin/env bash
# Script run by Travis CI

set -ev

# Install dotnet cli
sudo apt-get install libunwind8-dev
curl -O https://dotnetcli.blob.core.windows.net/dotnet/Sdk/rel-1.0.0/dotnet-dev-ubuntu-x64.latest.tar.gz
tar -xf dotnet-dev-ubuntu-x64.latest.tar.gz

# Add dotnet to path
PATH=$PATH:`pwd`
export PATH

# Restore, build and test using dotnet cli
. ./run_tests_dotnetcore.sh
