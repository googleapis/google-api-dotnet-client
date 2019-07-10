#!/bin/bash

set -e

declare -r repo_root=$(git rev-parse --show-toplevel)

cd $repo_root

# Avoid dotnet restore failing if the directory isn't present
mkdir -p NuPkgs/Support

source DocfxFunctions.sh
install_docfx

rm -rf Src/Support/*/obj
rm -rf Src/Support/*/bin
dotnet build Src/Support/GoogleApisClient.sln

# Some versions of docfx fail if VSINSTALLDIR is set (and isn't a version they expect)
export VSINSTALLDIR=

# Extract the support libraries version number from the XML.
# This is pretty horrible, but it works...
declare -r version=$(grep \<Version\> Src/Support/CommonProjectProperties.xml | sed 's/</>/g' | cut -d\> -f 3)

build_site() {
  declare -r package=$1
  declare -r directory=Src/Support/$1
  declare -r dependencies="$2"
  declare -r target_framework="$3"
  declare -r entry_namespace=$4
  declare -r json=$directory/docfx.json

  cp Docs/docfx-1.json $json
  cp Docs/index.md $directory
  for dep in $dependencies
  do
    echo "      \"../$dep/obj/site/xrefmap.yml\"," >> $json
  done
  cat Docs/docfx-2.json >> $json
  sed -i "s/\\\$package/$package/g" $json
  sed -i "s/\\\$target/$target_framework/g" $json
  sed -i "s/\\\$title/Google API support libraries/g" $json

  sed -i "s/\\\$title/Google API support libraries/g" $directory/index.md
  sed -i "s/\\\$entry_namespace/$entry_namespace/g" $directory/index.md  
  
  $DOCFX metadata -f --disableGitFeatures $json
  $DOCFX build --disableGitFeatures $json

  sed -i "1s/^/baseUrl: https:\/\/googleapis.dev\/dotnet\/$package\/$version\/\n/" $directory/obj/site/xrefmap.yml
}

build_site Google.Apis.Core "" netstandard2.0 Google.Apis
build_site Google.Apis Google.Apis.Core netstandard2.0 Google.Apis
build_site Google.Apis.Auth "Google.Apis.Core Google.Apis" netstandard2.0 Google.Apis.Auth
build_site Google.Apis.Auth.Mvc "Google.Apis.Core Google.Apis Google.Apis.Auth" net45 Google.Apis.Auth.Mvc
build_site Google.Apis.Auth.AspNetCore "Google.Apis.Core Google.Apis Google.Apis.Auth" netstandard2.0 Google.Apis.Auth.AspNetCore
