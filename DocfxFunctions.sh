# This is intended to be imported using the "source" function from
# any scripts that use docfx.

declare -r REPO_ROOT=$(readlink -f $(dirname ${BASH_SOURCE}))
declare -r TOOL_PACKAGES=$REPO_ROOT/packages
declare -r DOCFX_VERSION=2.59.2
declare -r DOCFX=$TOOL_PACKAGES/docfx.$DOCFX_VERSION/docfx.exe

# Appears to fix some issues in docfx.
# Unfortunately docfx is a bit "magical" in that respect :(
export VSINSTALLDIR=

install_docfx() {
  dotnet tool install docfx > /dev/null
}
