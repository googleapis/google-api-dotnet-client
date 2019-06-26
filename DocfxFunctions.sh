# This is intended to be imported using the "source" function from
# any scripts that use docfx.

declare -r REPO_ROOT=$(readlink -f $(dirname ${BASH_SOURCE}))
declare -r TOOL_PACKAGES=$REPO_ROOT/packages
declare -r DOCFX_VERSION=2.39.1
declare -r DOCFX=$TOOL_PACKAGES/docfx.$DOCFX_VERSION/docfx.exe

install_docfx() {
  if [[ ! -f $DOCFX ]]
  then
    (echo "Fetching docfx v${DOCFX_VERSION}";
     mkdir -p $TOOL_PACKAGES;
     cd $TOOL_PACKAGES;
     mkdir docfx.$DOCFX_VERSION;
     cd docfx.$DOCFX_VERSION;
     curl -sSL https://github.com/dotnet/docfx/releases/download/v${DOCFX_VERSION}/docfx.zip -o tmp.zip;
     unzip -q tmp.zip;
     rm tmp.zip;
     )
  fi  
}
