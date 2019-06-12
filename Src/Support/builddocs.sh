#!/bin/sh
DOCFX=../../../google-cloud-dotnet/packages/docfx.2.39.1/docfx.exe
$DOCFX metadata -f docfx.json
$DOCFX build docfx.json

