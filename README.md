[![Build Status](https://travis-ci.org/google/google-api-dotnet-client.svg?branch=master)](https://travis-ci.org/google/google-api-dotnet-client)

# Google APIs client Library for .NET

---------
# _Google Cloud Platform APIs_

_If you're working with **Google Cloud Platform** APIs such as Datastore or Pub/Sub, consider using the [Cloud Client Libraries for .NET instead](https://github.com/GoogleCloudPlatform/google-cloud-dotnet). These are the new and idiomatic .NET libraries targeted specifically at Google Cloud Platform Services._

# Library Maintenance

This client library is supported but in maintenance mode only. We are fixing necessary bugs and adding essential features to ensure this library continues to meet your needs for accessing Google APIs. Non-critical issues will be closed. Any issue may be reopened if it is causing ongoing problems.

Please see the [FAQ](FAQ.md) for more details on what this means.

----------

## Description ##
The Google API client library for .NET enables access to Google APIs such as Drive, YouTube, Calendar, Storage and Analytics. The library supports OAuth2.0 authentication. Strongly-typed per-API libraries are generated using Google's [Discovery API](https://developers.google.com/discovery/).

Please see the [FAQ](FAQ.md) for answers to common questions.

## Supported Frameworks

* .NET Framework 4.5+
* netstandard1.3, providing .NET Core support

### ASP.NET Core

ASP.NET Core is supported through the `netstandard1.3` framework target. However there are currently no authentication helpers or examples specific to ASP.NET Core, making authentication more difficult to use than on other platforms. This is being tracked in issue [#933](https://github.com/google/google-api-dotnet-client/issues/933).

## Legacy Supported Frameworks

We provide best-effort support for these platforms, but new features may not be available.

* .NET Framework 4.0
* Windows 8.0 (Windows app)
* Windows Phone 8.1
* Windows Phone Silverlight 8.0

## Unsupported Frameworks

* Silverlight
* UWP

For more details on framework support see [Frameworks.md](Frameworks.md)

# Developer Documentation

* [Google API client Library for .NET - Get Started](https://developers.google.com/api-client-library/dotnet/get_started)
* [Supported APIs](https://developers.google.com/api-client-library/dotnet/apis/)


# NuGet Packages

To make it easier for you to develop with the Google APIs using the Google API client Library for .NET we have released a number of NuGet packages. The libraries published by Google are owned by [google-apis-packages](https://www.nuget.org/profiles/google-apis-packages).

# API-specific Libraries

The generator that produces the source code for API-specific libraries is in `ClientGenerator/`. The most recently generated code is available in `Src/Generated/`, and the discovery documents from which that code was generated are in `DiscoveryJson/`.

# Support Forums

If you find an issue with in the client library we would appreciate you adding an issue in the [issue tracker](https://github.com/google/google-api-dotnet-client/issues).
Questions regarding usage of the client library should be posted to [stackoverflow.com](http://stackoverflow.com/)  using the tag [#google-api-dotnet-client](http://stackoverflow.com/questions/tagged/google-api-dotnet-client)
