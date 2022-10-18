# This is intended to be imported using the "source" function
# from any script that wants to invoke the C#-based generator.

declare -r GAPIC_GENERATOR_VERSION=1.4.8

TMP_CSHARP_GENERATOR_DIR=tmp-gapic-generator-csharp
if [[ $CSHARP_GENERATOR_DIR == "" ]]
then
  CSHARP_GENERATOR_DIR=$TMP_CSHARP_GENERATOR_DIR
fi

# Installs the C# generator in a tmp-gapic-generator-csharp directory,
# unless an existing generator directory is specified via the
# CSHARP_GENERATOR_DIR environment variable.
# When installing, if the directory already exists, it is deleted first.
# The tag for GAPIC_GENERATOR_VERSION (declared at the top of this file)
# is checked out.
install_csharp_generator() {
  if [[ $CSHARP_GENERATOR_DIR == $TMP_CSHARP_GENERATOR_DIR ]]
  then
    echo "Installing C# generator in $CSHARP_GENERATOR_DIR"
    rm -rf $CSHARP_GENERATOR_DIR

    git clone --quiet --recursive \
      https://github.com/googleapis/gapic-generator-csharp.git \
      $CSHARP_GENERATOR_DIR
    git -C $CSHARP_GENERATOR_DIR checkout -q v$GAPIC_GENERATOR_VERSION
  else
    echo "Using C# generator in $CSHARP_GENERATOR_DIR"
  fi
  echo 'Building C# generator'
  (cd $CSHARP_GENERATOR_DIR && \
   dotnet build -c Release -nologo -clp:NoSummary -v quiet Google.Api.Generator.Rest)
  echo 'Generator build complete'
}

# Runs the C# generator, which is expected to be installed in
# tmp-gapic-generator-csharp as per install_csharp_generator()
# Expected arguments:
# - Discovery doc
# - Output directory (a subdirectory will be created under this)
# - Features file
# - Enum storage file
run_csharp_generator() {
  dotnet run --no-build -c Release \
    -p $CSHARP_GENERATOR_DIR/Google.Api.Generator.Rest \
    -- "$1" "$2" "$3" "$4"
}
