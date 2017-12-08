The original code in DecompressionHandler.cs is the MIT-licensed code from
https://github.com/dotnet/corefx. This file is not built within this
repository.

Instead, the derived works in the Apache-licensed
StreamReplacingHttpContent.cs and GzipDeflateHandler.cs are used. (This
separation allows the reuse of stream replacement in other scenarios.)
These source files are present in this directory to indicate that they are
derived from DecompressionHandler. These derived works are included in the
Google.Apis.Core assembly when built.
