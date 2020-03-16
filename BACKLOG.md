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

## unable to assign a file name when uploading data by Analytics API

- Issue: [#1087](https://github.com/googleapis/google-api-dotnet-client/issues/1087)
- Status: Investigation required.
- Action: Unlikely, this repo is in maintenance mode.

# Support / Documentation for limited device authorisation flow

- Issue [#1105](https://github.com/googleapis/google-api-dotnet-client/issues/1105)
- Status: Slightly unclear at the moment whether this is about
  documenting existing features, or implementing a new flow
- Action: Unlikely, this repo is in maintenance mode.

# Polly integration for HttpClient

- Issue [#1414](https://github.com/googleapis/google-api-dotnet-client/issues/1414)
- Status: workaround feasible with small amounts of customer code
- Action: Unlikely, this repo is in maintenance mode. We wouldn't
  want to add a Polly dependency just for this, and it doesn't seem
  worth creating a new library.

# Server-Side Blazor and Google OAuth2

- Issue [#1427](https://github.com/googleapis/google-api-dotnet-client/issues/1427)
- Status: unclear right now, but we don't test on Blazor
- Action: keep an eye; if Blazor becomes very popular or we get multiple requests, we may revisit.
