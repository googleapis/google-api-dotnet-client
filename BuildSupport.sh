#!/bin/bash

# Stop if anything errors
set -e

# "nuget restore" fails if local package source directories don't exist.
mkdir -p NuPkgs/Support

MSBUILD="C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin\MSBuild.exe"
NUPKG_DIR=`pwd`/NuPkgs/Support

GOOGLE_APIS_CORE="Src/Support/Google.Apis.Core"
GOOGLE_APIS="Src/Support/Google.Apis"
GOOGLE_APIS_AUTH="Src/Support/Google.Apis.Auth"
GOOGLE_APIS_AUTH_MVC="Src/Support/Google.Apis.Auth.Mvc"

rm -r {$GOOGLE_APIS_CORE,$GOOGLE_APIS,$GOOGLE_APIS_AUTH,$GOOGLE_APIS_AUTH_MVC}/{bin,obj} || true

"$MSBUILD" -t:restore $GOOGLE_APIS_CORE
"$MSBUILD" -t:restore $GOOGLE_APIS
"$MSBUILD" -t:restore $GOOGLE_APIS_AUTH
"$MSBUILD" -t:restore $GOOGLE_APIS_AUTH_MVC
"$MSBUILD" -t:restore Src/Support/Google.Apis.PlatformServices
"$MSBUILD" -t:restore Src/Support/Google.Apis.Auth.PlatformServices

"$MSBUILD" -t:build -p:Configuration=Release $GOOGLE_APIS_CORE
"$MSBUILD" -t:build -p:Configuration=Release $GOOGLE_APIS
"$MSBUILD" -t:build -p:Configuration=Release $GOOGLE_APIS_AUTH
"$MSBUILD" -t:build -p:Configuration=Release $GOOGLE_APIS_AUTH_MVC

"$MSBUILD" -t:pack -p:Configuration=Release $GOOGLE_APIS_CORE
"$MSBUILD" -t:pack -p:Configuration=Release $GOOGLE_APIS
"$MSBUILD" -t:pack -p:Configuration=Release $GOOGLE_APIS_AUTH
"$MSBUILD" -t:pack -p:Configuration=Release $GOOGLE_APIS_AUTH_MVC

cp $GOOGLE_APIS_CORE/bin/Release/*.nupkg $NUPKG_DIR
cp $GOOGLE_APIS/bin/Release/*.nupkg $NUPKG_DIR
cp $GOOGLE_APIS_AUTH/bin/Release/*.nupkg $NUPKG_DIR
cp $GOOGLE_APIS_AUTH_MVC/bin/Release/*.nupkg $NUPKG_DIR
