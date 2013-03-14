#!/bin/sh
#
# Run the Google APIs client generator tests
#

case $0 in
  /* )
   TOP=$(dirname "$0")
   ;;
  * )
   TOP=$(dirname "$(/bin/pwd)/$0")
   ;;
esac

export PYTHONPATH=$TOP/src

cd $TOP/src/googleapis/codegen
for test in *_test.py ; do
  python $test
done
