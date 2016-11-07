#!/usr/bin/env bash
# Script run by Travis CI

set -ev

# Install dotnet cli
sudo apt-get install libunwind8-dev
curl -O https://download.microsoft.com/download/1/5/2/1523EBE1-3764-4328-8961-D1BD8ECA9295/dotnet-dev-ubuntu-x64.1.0.0-preview2-003131.tar.gz
tar -xf dotnet-dev-ubuntu-x64.1.0.0-preview2-003131.tar.gz

# Add dotnet to path
PATH=$PATH:`pwd`
export PATH

# Restore, build and test using dotnet cli
. ./run_tests_dotnetcore.sh
