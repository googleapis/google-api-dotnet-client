# Requested enhancements and bug backlog

This file is used to keep track of feature requests that we *may*
want to come back to at some point, but aren't on our immediate
radar. Using this single document is simpler than keeping all the
corresponding issues open, but we'll reopen the issue if we revisit
the request and want to put work into it.

## Links in xml comments are stale sometimes.

- Issue: [#573](https://github.com/googleapis/google-api-dotnet-client/issues/573)
- Status: Automation required to scan all links and check liveness.
- Action: Unlikely, this repo is in maintenance mode.

## Enable multiple values for GeneratetagsRequest.TagFormats to retrieve INS tags

- Issue: [#663](https://github.com/googleapis/google-api-dotnet-client/issues/663)
- Status: Design work required to implement in a backwards compatible way.
- Action: Will be fixed only if a problem is found for which there is no work-around.

## Reference documentation should be automatically updated

- Issue: [#903](https://github.com/googleapis/google-api-dotnet-client/issues/903)
- Status: Investigation required to determine best way to automate.
- Action: Nice to have, as there are currently no up to date docs, except the source code.

## Update dotnet contributing guidelines on developers.google.com

- Issue: [#1059](https://github.com/googleapis/google-api-dotnet-client/issues/1059)
- Status: Update not started.
- Action: Nice to have, as they are currently a little incorrect.

## Support uploading in chunks - maybe with ResumableUpload

- Issue: [#1076](https://github.com/googleapis/google-api-dotnet-client/issues/1076)
- Status: Investigation required.
- Action: Unlikely, this repo is in maintenance mode.

## Unable to assign a file name when uploading data by Analytics API

- Issue: [#1087](https://github.com/googleapis/google-api-dotnet-client/issues/1087)
- Status: Investigation required.
- Action: Unlikely, this repo is in maintenance mode.

## Support / Documentation for limited device authorisation flow

- Issue [#1105](https://github.com/googleapis/google-api-dotnet-client/issues/1105)
- Status: Slightly unclear at the moment whether this is about
  documenting existing features, or implementing a new flow
- Action: Unlikely, this repo is in maintenance mode.

## Polly integration for HttpClient

- Issue [#1414](https://github.com/googleapis/google-api-dotnet-client/issues/1414)
- Status: workaround feasible with small amounts of customer code
- Action: Unlikely, this repo is in maintenance mode. We wouldn't
  want to add a Polly dependency just for this, and it doesn't seem
  worth creating a new library.

## Blazor support

- Issue [#1427 Server side Blazor and OAuth](https://github.com/googleapis/google-api-dotnet-client/issues/1427)
- Issue [#1830 Blazor WebAssembly and OAuth](https://github.com/googleapis/google-api-dotnet-client/issues/1830)
- Status: unclear right now, but we don't test on Blazor
- Action: keep an eye; if Blazor becomes very popular or we get multiple requests, we may revisit.

## Multiple Auth related FRs

- Issue [#1548 OIDC support for gRPC credentilas](https://github.com/googleapis/google-api-dotnet-client/issues/1548)
- Issue [#1447 Support for key rotation](https://github.com/googleapis/google-api-dotnet-client/issues/1447)
- Issue [#1326 Support for "server-side" OAuth flow](https://github.com/googleapis/google-api-dotnet-client/issues/1326)
- Issue [#1803 OIDC support for user credentials](https://github.com/googleapis/google-api-dotnet-client/issues/1803)
- Issue [#1812 Support for limited input device flow](https://github.com/googleapis/google-api-dotnet-client/issues/1812)
- Issue [#1827 PCKE flow should no require client_secret](https://github.com/googleapis/google-api-dotnet-client/issues/1827)
- Issue [#1857 Retrieve default Compute credential email](https://github.com/googleapis/google-api-dotnet-client/issues/1857)
- Status: ongoing internal effort to consolidate and standardize OAuth features across language libraries.
- Action: bring these issues up for consideration as part of consolidation work.
