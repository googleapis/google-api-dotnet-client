#!/bin/bash

set -ex

doxygen doxygen_config.tmpl

cd Docs/documentation

sed -i -- 's/<script type="text\/javascript" src="jquery.js"><\/script>//g' ./*
sed -i -- 's/<script type="text\/javascript" src="dynsections.js"><\/script>//g' ./*

rm dynsections.js

echo "The documentation in Docs/documentation is now ready to be copied to g4 client to be added to the devsite"
