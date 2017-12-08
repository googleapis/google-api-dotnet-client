# FAQ

Please [file an issue](https://github.com/google/google-api-dotnet-client/issues/new) if there are more questions you'd like to see addressed here.

### What does this library being in "maintenance mode" mean?

It means that the libraries in this repository are considered mature and complete; so we do not expect to add any more major features.

We will continue to support these libraries, fix bugs, and add minor features as required to support ongoing changes to the .NET platform.

We will continue to release new versions of all API libraries as they are available; and release new API libraries as new services become available.

### What happened to the [`FileDataStore`](https://github.com/google/google-api-dotnet-client/blob/master/Src/Support/Google.Apis/Util/Store/FileDataStore.cs) default directory on some platforms between v1.25 and v1.26?

On some Windows desktop/server platforms between v1.25 and v1.26, the default `FileDataStore` directory location changed. This was an unindended consequence of a code refactor.

This affects code that uses the `FileDataStore` without a full path:

```C#
var fileDataStore = new FileDataStore("MyRelativeFolder");
```

The workaround is to use an absolute path:
```C#
var absolutePath = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
    "MyRelativeFolder")
var fileDataStore = new FileDataStore(absolutePath, fullPath: true);
```

Release [v1.26](https://github.com/google/google-api-dotnet-client/releases/tag/v1.26.2) was a major refactor of the project structure. Part of this work was to converge source code between desktop and .NET Core platforms, which involved changes to [FileDataStore.cs](https://github.com/google/google-api-dotnet-client/blob/master/Src/Support/Google.Apis/Util/Store/FileDataStore.cs). These changes allowed `FileDataStore` to build for .NET Core applications, but did involve changes to the logic to determine the default base directory of the file-store, because `Environment.SpecialFolder.ApplicationData` is not available on .NET Core.

We did consider reverting this back to the v1.25 behaviour in v1.28+, but would rather not cause an additional backward-incompatible change; especially as there is a simple work-around available. 

### Can I use [GoogleWebAuthorizationBroker](https://github.com/google/google-api-dotnet-client/blob/master/Src/Support/Google.Apis.Auth/OAuth2/GoogleWebAuthorizationBroker.cs) on a server?

In a word: No.

[GoogleWebAuthorizationBroker](https://github.com/google/google-api-dotnet-client/blob/master/Src/Support/Google.Apis.Auth/OAuth2/GoogleWebAuthorizationBroker.cs) requires interaction with the end-user, so can only be used in client-side code.

OAuth authentication requires the end-user to interact with a web browser, which can only be done client-side.

It is possible to user OAuth authentication in a web application, but not using this `GoogleWebAuthorizationBroker` class.

### Should I create a new client instance for every request?

Generally: No.

Every instantiation of a service client class creates a new instance of
[HttpClient](https://msdn.microsoft.com/en-us/library/system.net.http.httpclient(v=vs.118).aspx),
and creating many of these is, in general, a bad idea. See, for example,
[this post](https://aspnetmonsters.com/2016/08/2016-08-27-httpclientwrong/) for why.

Every instantiation of a client class also uses more CPU time and requires more memory allocation,
which are generally best avoided if possible.

Sometimes it *is* required to create an instance per request; for example, if different
credentials are required for each request.
In this case make sure to Dispose of each instance when finished with it.

### How do I create a nuget package from a discovery doc?

See [HowToGenerateAPackage.md](HowToGenerateAPackage.md).