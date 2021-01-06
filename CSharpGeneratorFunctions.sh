# This is intended to be imported using the "source" function
# from any script that wants to invoke the C#-based generator.

CSHARP_GENERATOR_DIR=tmp-gapic-generator-csharp

# Installs the C# generator in a tmp-gapic-generator-csharp directory.
# If the directory already exists, it is deleted first.
install_csharp_generator() {
  echo "Installing C# generator in $CSHARP_GENERATOR_DIR"
  rm -rf $CSHARP_GENERATOR_DIR
  
  git clone --quiet --recursive --depth=1 \
    https://github.com/googleapis/gapic-generator-csharp.git \
    $CSHARP_GENERATOR_DIR
    
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
run_csharp_generator() {
  dotnet run --no-build -c Release \
    -p $CSHARP_GENERATOR_DIR/Google.Api.Generator.Rest \
    -- "$1" "$2"
}
