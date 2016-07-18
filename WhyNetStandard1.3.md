# Why 1.3

## Targeting NetStandard1.3

We target `NetStandard1.3` because of the following are not available in < 1.3:

* **System.Diagnostics.Process**:
  This is used in `Google.Apis.Auth.OAuth2.PromptCodeReceiver` to launch a
  browser as part of the interactive oauth2 flow.
* **System.Security.Cryptography.Csp**:
  Provides various RSA cryptography functionality as required by `Google.Apis.Auth.OAuth2.ServiceAccountCredential`.
  E.g. `System.Security.Cryptography.RSACryptoServiceProvider`.
* **System.Reflection.TypeExtensions**:
  Provides compatibility extension methods for 'old reflection' source code,
  to 'new reflection' calls.
* **System.Net.Sockets**:
  Currently used in `MediaDownloaderTest.cs` to find an available port.

And the following are not available < 1.1:

* **System.Net.Http**:
  This used extensively throughout all three support libraries.

## Targeting NetStandard1.1

We could probably target `NetStandard1.1` without too much problem.

* **System.Diagnostics.Process**:
  Remove support for launching a browser, simply display the URL to visit using
  `Console.WriteLine()`.
* **System.Security.Cryptography.Csp**:
  It is probable that `Portable.BouncyCastle` provides all the RSA cryptographic
  functionally that we require.
* **System.Reflection.TypeExtensions**:
  Providing our own compatibility extension methods is fairly simple.
  It'll be 100 or so lines of code.
* **System.Net.Sockets**:
  The available-port finding in `MediaDownloaderTest.cs` should be easily
  refactorable.

These changes can be made post-release.
Moving from targeting 1.3 to targeting 1.1 will be a non-breaking change.

## Targeting NetStandard1.0

This is unrealistic due to the extensive use of `System.Net.Http` throughout
these support libraries.