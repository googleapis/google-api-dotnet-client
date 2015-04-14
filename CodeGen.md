**From 1.5.0-beta release we don't support the CodeGen any more. Take a look in https://code.google.com/p/google-apis-client-generator/ for details on how we generate our APIs**

Using the code generator and strongly typed libraries:


# Strongly typed libraries for Google APIs #

The base API is a strong, robust API that allows you to interact with all the Google Services that support discovery.  This API is fine if you are happy not having a strongly typed API and working with dynamic interfaces.

We recognise that a lot of Developers want to access our API suite using a Strongly Typed interface, not only for the benefits that you receive via the IDE and code completion, but also because it provides a strict, compiler verified interface to the Google services.

For that reason there is a set of strongly typed libraries available for all Google services. You can find those libraries here:

> | [Generated libraries for Google services](APIs.md). |
|:----------------------------------------------------|

# Generating libraries for custom APIs #
If you wish to generate the newest version of a library yourself, you can either use the _Google.Apis.Tools.CodeGen.dll_ to write your own service generator, or you can use the default _ServiceGenerator_.

## Service Generator ([source](http://code.google.com/p/google-api-dotnet-client/source/browse?repo=samples#hg%2FServiceGenerator)) ##
Before using the ServiceGenerator, you have to download the core library. You can find the instructions to do so below:
  * [Downloading the Google APIs Client Library for .NET](Downloads.md)

Once you have downloaded and build the Samples solution, you should be able to execute the ServiceGenerator.

### Generating a Google API ###
  1. Run "ServiceGenerator.exe service 

&lt;name&gt;

:

&lt;version&gt;

"
  1. The generator should have generated the source file in "_Services\Discovery.v1.cs_", and the corresponding .dll and .xml file.

## Generating a custom service ##
If you wish to generate a custom, non-google service which provides a Discovery Document, you can do so by running the ServiceGenerator manually. Example:
```
  ServiceGenerator.exe url http://example.com/discovery
```  ServiceGenerator.exe url http://example.com/discovery
}}}```