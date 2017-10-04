/*
Copyright 2017 Google Inc

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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Translate.v2;
using Google.Apis.Translate.v2.Data;
using IntegrationTests.Utils;
using System.Collections.Generic;
using Xunit;

namespace IntegrationTests
{
    public class DataWrapperTests
    {
        [Fact]
        public void Translate()
        {
            GoogleCredential credential = Helper.GetServiceCredential().CreateScoped(TranslateService.Scope.CloudTranslation);
            TranslateService client = new TranslateService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "IntegrationTest"
            });

            var translateRequest = client.Translations.Translate(new TranslateTextRequest
            {
                Format = "text",
                Q = new List<string> { "The cold weather will soon be over" },
                Source = "en",
                Target = "fr",
            });
            var response = translateRequest.Execute();

            Assert.Single(response.Translations);
            Assert.Equal("Le temps froid sera bientôt terminé", response.Translations[0].TranslatedText);
        }

        [Fact]
        public void TranslateList()
        {
            GoogleCredential credential = Helper.GetServiceCredential().CreateScoped(TranslateService.Scope.CloudTranslation);
            TranslateService client = new TranslateService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "IntegrationTest"
            });

            var listRequest = client.Translations.List("The cold weather will soon be over", "fr");
            var response = listRequest.Execute();

            Assert.Single(response.Translations);
            Assert.Equal("Le temps froid sera bientôt terminé", response.Translations[0].TranslatedText);
        }

        [Fact]
        public void Detect()
        {
            GoogleCredential credential = Helper.GetServiceCredential().CreateScoped(TranslateService.Scope.CloudTranslation);
            TranslateService client = new TranslateService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "IntegrationTest"
            });

            var listRequest = client.Detections.Detect(new DetectLanguageRequest
            {
                Q = new List<string> { "The cold weather will soon be over" },
            });
            var response = listRequest.Execute();

            Assert.Single(response.Detections);
            Assert.Single(response.Detections[0]);
            Assert.Equal("en", response.Detections[0][0].Language);
        }

        [Fact]
        public void DetectList()
        {
            GoogleCredential credential = Helper.GetServiceCredential().CreateScoped(TranslateService.Scope.CloudTranslation);
            TranslateService client = new TranslateService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "IntegrationTest"
            });

            var listRequest = client.Detections.List("The cold weather will soon be over");
            var response = listRequest.Execute();

            Assert.Single(response.Detections);
            Assert.Single(response.Detections[0]);
            Assert.Equal("en", response.Detections[0][0].Language);
        }
    }
}
