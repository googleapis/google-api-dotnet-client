#!/bin/sh

# Generates a set of APIs specified by arguments. The APIs can be
# specified as JSON files, or as a single file containing a list of
# JSON files, using the "@" prefix.
#
# Common examples:
#
#   In autorelease.sh:
#   ./GenerateApis.sh @tmp/ApisToGenerate.txt
#
#   When testing a generator:
#   ./GenerateApis.sh DiscoveryJson/*.json

set -e

if [[ $1 == "" ]]
then
  echo "Usage options:"
  echo "  GenerateApis.sh <path/to/discovery.json> [...]"
  echo "  GenerateApis.sh @file-with-paths"
  exit 1
fi

if [[ $1 == @* ]]
then
  file=${1:1}
  if [[ ! -f $file ]]
  then
    echo "Error: $file does not exist"
    exit 1
  fi

  if [[ ! -s $file ]]
  then
    echo "$file is empty; assuming nothing needs generating."
    exit 0
  fi
fi

source ./CSharpGeneratorFunctions.sh
install_csharp_generator

CODE_GENERATION_DIR=Src/Generated

if [[ "$2" == "" && $1 == @* ]]
then
  # For simplicity, allow CRLF line endings in the file
  FILES=$(cat $(echo $1 | sed s/@//g) | sed 's/\r//g')
else
  FILES=$*
fi

for file in $FILES
do
  service=$(basename $file | sed 's/.json//g')
  echo "Generating $service from $file"
  run_csharp_generator "$file" "$CODE_GENERATION_DIR" features.json "EnumStorage/$service.json"

  if [[ -f PostGeneration/$service.sh ]]
  then
    echo "Running post-generation step for $service"
    PostGeneration/$service.sh "$CODE_GENERATION_DIR"
  fi
done

echo "Generation complete"
