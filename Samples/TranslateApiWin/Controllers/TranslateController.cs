using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Threading;
using System.Windows.Forms;

using Google.Apis.Authentication;
using Google.Apis.Samples.Services;
using Google.Apis.Samples.TranslateApiWin.Forms;
using Google.Apis.Samples.TranslateApiWin.Services.Data;

namespace Google.Apis.Samples.TranslateApiWin.Controllers
{
    /// <summary>
    /// Controller defining the control flow of the translate example
    /// </summary>
    public class TranslateController
    {
        #region Nested types

        #region Delegates

        /// <summary>
        /// Delegate used by the TranslationRequestFinished event
        /// </summary>
        /// <param name="request"></param>
        public delegate void EndTranslationRequest(TranslationRequest request);

        #endregion

        /// <summary>
        /// Represents a request container class
        /// </summary>
        public class TranslationRequest
        {
            public string Input { get; internal set; }
            public string InputLanguage { get; internal set; }
            public string Output { get; internal set; }
            public string OutputLanguage { get; internal set; }
        }

        #endregion

        private readonly MainForm form;
        private readonly TranslateService service;
        private TranslationRequest currentRequest;

        /// <summary>
        /// Contains all languages available
        /// The dictionary assigns Language Name -> Language Code
        /// </summary>
        private readonly Dictionary<string, string> LanguagesByName = new Dictionary<string, string>();

        /// <summary>
        /// Creates and initializes the translate example
        /// - Allocates subclasses
        /// - Requests an API key
        /// </summary>
        public TranslateController()
        {
            // We don't require authentification in this example
            AuthenticatorFactory.GetInstance().RegisterAuthenticator(() => new NullAuthenticator());

            // Request a developer key
            string apiKey = new DeveloperKeyForm().RequestDeveloperKey("Translate API Example");

            // Create the service
            service = new TranslateService {DeveloperKey = apiKey};

            // Get UserLanguage
            UserLanguageCode = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

            // Retrieve all languages known by the service
            UpdateLanguageDictionaryBlocking(LanguagesByName);

            // Create the mainform
            form = new MainForm(this);
        }

        /// <summary>
        /// List of available languages
        /// </summary>
        public string[] Languages
        {
            get
            {
                var languages = new string[LanguagesByName.Keys.Count];
                LanguagesByName.Keys.CopyTo(languages, 0);
                return languages;
            }
        }

        /// <summary>
        /// Returns the language code of the language the system uses
        /// </summary>
        public string UserLanguageCode { get; private set; }

        /// <summary>
        /// This event will be called once a translation request has been finished
        /// </summary>
        public event EndTranslationRequest OnTranslationFinished;

        /// <summary>
        /// Runs the example
        /// </summary>
        public void ExecuteExample()
        {
            Application.Run(form);
        }

        /// <summary>
        /// Retrieves the language name by the language code
        /// </summary>
        /// <param name="langCode"></param>
        /// <returns></returns>
        public string GetLanguageByCode(string langCode)
        {
            foreach (var pair in LanguagesByName)
            {
                if (pair.Value == langCode)
                {
                    return pair.Key;
                }
            }
            throw new ArgumentOutOfRangeException(
                "langCode",
                "The language code was not found within the list of available languages");
        }

        /// <summary>
        /// Begins a new input request
        /// </summary>
        /// <param name="input"></param>
        /// <param name="targetLanguage"></param>
        public void BeginRequest(string input, string targetLanguage)
        {
            if (currentRequest != null)
            {
                return; // Don't start a second request
            }

            // Validate the information provided
            if (string.IsNullOrEmpty(input))
                return; // not valid
            if (LanguagesByName.ContainsKey(targetLanguage))
                targetLanguage = LanguagesByName[targetLanguage]; // Transform into language code
            else if (LanguagesByName.ContainsValue(targetLanguage) == false)
                return; // invalid language

            // Create the request
            currentRequest = new TranslationRequest {Input = input, OutputLanguage = targetLanguage};

            // ... and execute it
            ThreadPool.QueueUserWorkItem(
                o =>
                    {
                        // Call the blocking method
                        ExecuteRequestBlocking(currentRequest);

                        // Call the event
                        if (OnTranslationFinished != null)
                        {
                            OnTranslationFinished(currentRequest);
                        }

                        // Clear the active request
                        currentRequest = null;
                    }, null);
        }

        public void ExecuteRequestBlocking(TranslationRequest request)
        {
            TranslationsListResponse response;

            // Try catching network exceptions
            try
            {
                response = service.Translations.ListAsObject(request.Input,
                                                             request.OutputLanguage,
                                                             "text",
                                                             null);
            }
            catch (WebException e)
            {
                MessageBox.Show(e.ToString(),
                                "An error occured while executing a translation request",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (response.Translations.Count < 1)
            {
                return; //Invalid result
            }

            // Get the inner result
            TranslationsResource resource = response.Translations[0];
            request.InputLanguage = GetLanguageByCode(resource.DetectedSourceLanguage);
            request.Output = resource.TranslatedText;
        }

        private void UpdateLanguageDictionaryBlocking(Dictionary<string, string> dictionary)
        {
            LanguagesListResponse response;

            // Try catching network exceptions
            try
            {
                response = service.Languages.ListAsObject(UserLanguageCode);
            }
            catch (WebException e)
            {
                MessageBox.Show(e.ToString(),
                                "An error occured while retrieving the list of available languages",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Clear the old dictionary
            dictionary.Clear();

            // Add new languages
            foreach (LanguagesResource resource in response.Languages)
            {
                dictionary.Add(resource.Name, resource.Language);
            }
        }
    }
}