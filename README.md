[![Build Status](https://travis-ci.org/google/google-api-dotnet-client.svg?branch=master)](https://travis-ci.org/google/google-api-dotnet-client)

## Google APIs client Library for .NET  ##

## Description ##
The Google API client library for .NET enables access to Google APIs such as Drive, YouTube, Calendar, Storage and Analytics. The library supports OAuth2.0 authentication. Strongly-typed per-API libraries are generated using Google's [Discovery API](https://developers.google.com/discovery/).

Supported Platforms
=================================

* .NET Framework 4.5 and 4.6
* .NET Core (via netstandard1.3 support)
* Windows 8 Apps
* Windows Phone 8 and 8.1
* Portable Class Libraries

## Legacy Support

We provide best-effort support for these platforms, but new features may not be available.

* .NET Framework 4.0
* Silverlight 5.0

Developer Documentation
=================================

* [Google API client Library for .NET - Get Started](https://developers.google.com/api-client-library/dotnet/get_started)
* [Supported APIs](https://developers.google.com/api-client-library/dotnet/apis/)


NuGet Packages
=================================

To make it easer for you to develop with the Google APIs using the Google API client Library for .NET we have released a number of NuGet packages. The libraries published by Google are owned by [google-apis-packages](https://www.nuget.org/profiles/google-apis-packages).

API-specific Libraries
=================================

The generator that produces the source code for API-specific libraries is in `ClientGenerator/`. The most recently generated code is available in `Src/Generated/`, and the discovery documents from which that code was generated are in `DiscoveryJson/`.

Support Forums
=================================
If you find an issue with in the client library we would appricate you adding an issue in the [issue tracker](https://github.com/google/google-api-dotnet-client/issues).
Questions regarding usage of the client library should be posted to [stackoverflow.com](http://stackoverflow.com/)  using the tag [#google-api-dotnet-client](http://stackoverflow.com/questions/tagged/google-api-dotnet-client)
