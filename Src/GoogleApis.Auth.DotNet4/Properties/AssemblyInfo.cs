/*
Copyright 2013 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System.Reflection;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Google.Apis.Auth.PlatformServices")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Google Inc")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright("Copyright © Google Inc 2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

#if SIGNED
[assembly: InternalsVisibleTo("Google.Apis.Auth.DotNet4.Tests,PublicKey=" +
    "00240000048000009400000006020000002400005253413100040000010001002f5797a92c6fcde81bd4098f43" +
    "0442bb8e12768722de0b0cb1b15e955b32a11352740ee59f2c94c48edc8e177d1052536b8ac651bce11ce5da3a" +
    "27fc95aff3dc604a6971417453f9483c7b5e836756d5b271bf8f2403fe186e31956148c03d804487cf642f8cc0" +
    "71394ee9672dfe5b55ea0f95dfd5a7f77d22c962ccf51320d3")]
#else
[assembly: InternalsVisibleTo("Google.Apis.Auth.DotNet4.Tests")]
#endif

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.
[assembly: AssemblyVersion("1.9.3.*")]

// The following attributes are used to specify the signing key for the assembly, 
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]
