[![GitHub Actions status](https://img.shields.io/github/actions/workflow/status/googleapis/google-api-dotnet-client/build.yml)](https://github.com/googleapis/google-api-dotnet-client/actions/workflows/build.yml))

# Google APIs client Library for .NET

---------
# _Google Cloud Platform APIs_

_If you're working with **Google Cloud Platform** APIs such as Datastore or Pub/Sub, consider using the [Cloud Client Libraries for .NET instead](https://github.com/googleapis/google-cloud-dotnet). These are the new and idiomatic .NET libraries targeted specifically at Google Cloud Platform Services._

# Announcement: plan for changing library targets

We are planning to change the set of target frameworks supported
by the packages generated from this repository. Please see the
[announcement
issue](https://github.com/googleapis/google-api-dotnet-client/issues/2561)
for more details and to provide feedback.

# Library Maintenance

This client library is supported but in maintenance mode only. We are fixing necessary bugs and adding essential features to ensure this library continues to meet your needs for accessing Google APIs. Non-critical issues will be closed. Any issue may be reopened if it is causing ongoing problems.

Please see the [FAQ](FAQ.md) for more details on what this means.

----------

## Description
The Google API client library for .NET enables access to Google APIs such as Drive, YouTube, Calendar, Storage and Analytics. The library supports OAuth2.0 authentication. Strongly-typed per-API libraries are generated using Google's [Discovery API](https://developers.google.com/discovery/).

Please see the [help page](https://cloud.google.com/dotnet/docs/reference/help/rest-libraries) for answers to common questions.

## Supported Frameworks

(Note: this set may change in early 2024, as per
[this announcement
issue](https://github.com/googleapis/google-api-dotnet-client/issues/2561).

* .NET Framework 4.5+
* netstandard1.3, providing .NET Core support
* netstandard2.0, providing [ASP.NET Core Support](https://www.nuget.org/packages/Google.Apis.Auth.AspNetCore)

## Unsupported Frameworks

* Silverlight
* UWP
* Xamarin
* Unity

For more details on framework support see [Frameworks.md](Frameworks.md).

See the [FAQ](FAQ.md#why-arent-unity-xamarin-or-uwp-supported) for details regarding the lack of UWP, Xamarin, and Unity support.

Note that [Firebase](https://firebase.google.com/) is available on Unity, and focuses on the need of this platform.

# Developer Documentation

* [Google API client Library for .NET - Get Started](https://developers.google.com/api-client-library/dotnet/get_started)
* [Supported APIs](https://developers.google.com/api-client-library/dotnet/apis/)


# NuGet Packages

To make it easier for you to develop with the Google APIs using the Google API client Library for .NET we have released a number of NuGet packages. The libraries published by Google are owned by [google-apis-packages](https://www.nuget.org/profiles/google-apis-packages).

# API-specific Libraries

The generator that produces the source code for API-specific libraries is in https://github.com/googleapis/gapic-generator-csharp. The most recently generated code is available in `Src/Generated/`, and the discovery documents from which that code was generated are in `DiscoveryJson/`.

# Support Forums

If you find an issue with in the client library we would appreciate you adding an issue in the [issue tracker](https://github.com/googleapis/google-api-dotnet-client/issues).
Questions regarding usage of the client library should be posted to [stackoverflow.com](http://stackoverflow.com/)  using the tag [#google-api-dotnet-client](http://stackoverflow.com/questions/tagged/google-api-dotnet-client)
