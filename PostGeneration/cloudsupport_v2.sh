#!/bin/bash

CODE_GENERATION_DIR="$1"

# docfx fails completely (throws an exception) with the
# triple-backticks in Dialogflow. The Discovery Doc comments
# aren't formatted anyway, making Markdown basically broken.
# (That needs investigating separately.)
sed -i 's/```//g' "$CODE_GENERATION_DIR"/Google.Apis.CloudSupport.v2/Google.Apis.CloudSupport.v2.cs
