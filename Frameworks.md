# Framework support (generated libraries)

Framework support with generated API libraries. E.g. [Google.Apis.Storage.v1](https://www.nuget.org/packages/Google.Apis.Storage.v1). 

## Version >= 1.26.0
_Remove PCLs, move to NetStandard for legacy platform support_

_TODO: Add example nuget package when it's released_

Nuget packages target:

* .NETFramework 4.5 - _depends on same version of support libraries_
* .NETFramework 4.0 - _depends on v1.10.0 of support libraries_
* .NETStandard 1.3 - _depends on same version of support libraries_
* .NETStandard 1.0 - _depends on v1.25.0 of support libraries_
  * Provides legacy support for: Windows 8.0, Windows Phone 8.1, and Windows Phone Silverlight 8.0

Silverlight 5.0 is no longer supported. This is a breaking change. For Silverlight support, use v1.25.0.x of the relevant package(s).

## Version 1.17.0 - 1.25.0
_Explicit .NETFramework 4.5 support, for .NET4.6 projects_

E.g. [Google.Apis.Storage.v1 v1.17.0.631](https://www.nuget.org/packages/Google.Apis.Storage.v1/1.17.0.631)

Nuget packages target:

* .NETFramework 4.5 - _depends on same version of support libraries_
* .NETStandard 1.3 - _depends on same version of support libraries_
* PCL profile 259 (portable-net45+win8+wpa81+wp8) - _depends on same version of support libraries_
  * .NET Framework 4.5
  * Windows 8.0 (Windows app)
  * Windows Phone 8.1
  * Windows Phone Silverlight 8.0
* PCL profile  328 (portable-net4+sl50+win8+wpa81+wp8) - _depends on v1.10.0 of support libraries_
  * .NET Framework 4.0
  * Silverlight 5.0
  * Windows 8.0 (Windows app)
  * Windows Phone 8.1
  * Windows Phone Silverlight 8.0 

The explicit .NETFramework 4.5 target is required for .NET4.6+ projects, otherwise nuget selects the .NETStandard target over the PCL profile 259 target.

## Version 1.15.0 - 1.16.0
_.NETStandard support_

E.g. [Google.Apis.Storage.v1 v1.15.0.560](https://www.nuget.org/packages/Google.Apis.Storage.v1/1.15.0.560).

Nuget packages target:

* .NETStandard 1.3 - _depends on same version of support libraries_
* PCL profile 259 (portable-net45+win8+wpa81+wp8) - _depends on same version of support libraries_
  * .NET Framework 4.5
  * Windows 8.0 (Windows app)
  * Windows Phone 8.1
  * Windows Phone Silverlight 8.0
* PCL profile  328 (portable-net4+sl50+win8+wpa81+wp8) - _depends on v1.10.0 of support libraries_
  * .NET Framework 4.0
  * Silverlight 5.0
  * Windows 8.0 (Windows app)
  * Windows Phone 8.1
  * Windows Phone Silverlight 8.0 

## Version 1.12.0 - 1.14.1
_Initial multi-targeting_

E.g. [Google.Apis.Storage.v1 v1.12.0.448](https://www.nuget.org/packages/Google.Apis.Storage.v1/1.12.0.448).

Nuget packages target:

* PCL profile 259 (portable-net45+win8+wpa81+wp8) - _depends on same version of support libraries_
  * .NET Framework 4.5
  * Windows 8.0 (Windows app)
  * Windows Phone 8.1
  * Windows Phone Silverlight 8.0
* PCL profile  328 (portable-net4+sl50+win8+wpa81+wp8) - _depends on v1.10.0 of support libraries_
  * .NET Framework 4.0
  * Silverlight 5.0
  * Windows 8.0 (Windows app)
  * Windows Phone 8.1
  * Windows Phone Silverlight 8.0 

## Version <= 1.11.1

E.g. [Google.Apis.Storage.v1 v1.11.1.434](https://www.nuget.org/packages/Google.Apis.Storage.v1/1.11.1.434).

No specific framework targets in the nuget packages; depends on the same version of the support libraries. 