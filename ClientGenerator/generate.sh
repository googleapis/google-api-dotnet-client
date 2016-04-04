#!/bin/sh
#
# Run the Google APIs client generator
#

case $0 in
  /* )
   TOP=$(dirname "$0")
   ;;
  * )
   TOP=$(dirname "$(/bin/pwd)/$0")
   ;;
esac

export PYTHONPATH=$TOP/src:$PYTHONPATH
python $TOP/src/googleapis/codegen/generate_library.py $*
