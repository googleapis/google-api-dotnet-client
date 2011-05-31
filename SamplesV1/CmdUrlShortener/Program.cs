/*
Copyright 2011 Google Inc

Licensed under the Apache License, Version 2.0(the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Authentication;
using Google.Apis.Samples.Helper;

namespace Google.Apis.Samples.CmdUrlShortener
{
    class Program
    {
        internal static void Main(string[] args)
        {
            // todo: exceptionhandling

            CommandLine.DisplayGoogleSampleHeader("URL Shortener");

            // We don't require any sort of authenfication
            AuthenticatorFactory.GetInstance().RegisterAuthenticator(() => new NullAuthenticator());

            // Create the service
            var service = new UrlshortenerService();

            // Ask the user what he wants to do
            CommandLine.RequestUserChoice("What do you want to do?",
                new UserOption("Create a short URL", () => CreateShortURL(service)),
                new UserOption("Resolve a short URL", () => ResolveShortURL(service)));
        }

        private static void ResolveShortURL(UrlshortenerService service)
        {
            
        }

        private static void CreateShortURL(UrlshortenerService service)
        {
            
        }
    }
}
