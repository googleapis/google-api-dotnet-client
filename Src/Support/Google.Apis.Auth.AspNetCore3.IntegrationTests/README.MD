# Google.Apis.Auth.AspNetCore3 sample application

The [Google.Apis.Auth.AspNetCore3][package] contains a Google-specific
OpenIdConnect auth handler.
It supports incremental auth, and defines an injectable IGoogleAuthProvider
to supply Google credentials.

Google.Apis.Auth.AspNetCore3.IntegrationTests is a standard ASP.NET Core 3
application that shows how to configure and use the main features of
[Google.Apis.Auth.AspNetCore3][package].

## GCP setup prerequisites

### GCP project

First you need to create a Google Cloud project if you don't have one already.
Follow [these instructions][new-gcp-project] to do so. This will be the project
the app is identified with.

### Enabling APIs used by this app

The app uses the [Storage][storage-api] and [Translate][translate-api] APIs.
These need to be enabled in your GCP project. To enable the APIs, follow
[these instructions][enable-apis].

### Create authorization credentials

These credentials are the ones that identify your app to Google. Follow
[these instructions][oauth-creds] to create authorization credentials and download
the client_secrets.json file. Two highlights:

  - Notice that the credentials' type must be *Web application*.
  - For running this app, the only redirect URI you need to add is
  https://localhost:5001/signin-oidc

### Set up environment variables

- Set `TEST_WEB_CLIENT_SECRET_FILENAME` to the path of the client_secrets.json
  file you downloaded on the previous step.
- Set `GOOGLE_PROJECT_ID` to the GCP Project ID of the GCP project you are using.
  - As part of this app, we'll list the Storage buckets that the authenticated user
    has access to on the GCP project with ID in `GOOGLE_PROJECT_ID`. This project doesn't
    have to be the same as the project you created the credentials in. For instance,
    for a real world app, you may have a GCP project that only your organization can access,
    and that's were you'd create the credentials for the app. You then could have a second
    GCP project that users of your app can access, and there they would create their Storage
    buckets or other resources, either through your app or directly throught the Google Cloud Console.

## Run the app

You need ASP.NET Core 3.1 which you can download and install [here][net-core].
Alternatively you can use [Visual Studio 2019][visual-studio].

1. Use [Git][git] to clone this repo locally.
1. On the command line, go to the location where you cloned the repo.
1. An then go to google-api-dotnet-client/Src/Support/Google.Apis.Auth.AspNetCore3.IntegrationTests.
1. Run the app with `dotnet run`.
1. The local web server should start and a browser window should open showing this app's
   Index page.
1. There are several links on the Index page that will allow you to test Google.Apis.Auth.AspNetCore3
   features. All the links have an acompanying explanation of what they do.

## See the code

Google.Apis.Auth.AspNetCore3.IntegrationTests is a standard ASP.NET Core 3 app.

1. In [`Startup.cs`][startup] you can see how to configure Google.Apis.Auth.AspNetCore3.
1. In [`Controllers/HomeControllers.cs`][controller] you can see the code you need to write for each of the
   features showcased by the app.
1. In [`Views/Home/`][views] you'll find all the cshtml files that make up the app's UI. These are mostly
   HTML with a little code to help format the information they show.
1. [`ClientInfo.cs`][client-info] contains helper code to load the OAuth credential client ID and secret from
   the client_secrets.json file you downloaded from GCP. In your own app, you can use this approach
   or you can store your client ID and secret in any other secure manner of your choosing.


[package]: https://www.nuget.org/packages/Google.Apis.Auth.AspNetCore3/
[new-gcp-project]: https://cloud.google.com/resource-manager/docs/creating-managing-projects
[storage-api]: https://cloud.google.com/storage/docs/json_api
[translate-api]: https://cloud.google.com/translate/docs/reference/api-overview
[enable-apis]: https://developers.google.com/identity/protocols/oauth2/web-server#enable-apis
[git]: https://git-scm.com/
[net-core]: https://dotnet.microsoft.com/download/dotnet-core
[visual-studio]: https://visualstudio.microsoft.com/downloads/
[startup]: https://github.com/googleapis/google-api-dotnet-client/blob/master/Src/Support/Google.Apis.Auth.AspNetCore3.IntegrationTests/Startup.cs
[controller]: https://github.com/googleapis/google-api-dotnet-client/blob/master/Src/Support/Google.Apis.Auth.AspNetCore3.IntegrationTests/Controllers/HomeController.cs
[views]: https://github.com/googleapis/google-api-dotnet-client/tree/master/Src/Support/Google.Apis.Auth.AspNetCore3.IntegrationTests/Views/Home
[client-info]: https://github.com/googleapis/google-api-dotnet-client/blob/master/Src/Support/Google.Apis.Auth.AspNetCore3.IntegrationTests/ClientInfo.cs
