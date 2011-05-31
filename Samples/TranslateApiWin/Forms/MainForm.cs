using System;
using System.Globalization;
using System.Windows.Forms;

using Google.Apis.Samples.TranslateApiWin.Controllers;

namespace Google.Apis.Samples.TranslateApiWin.Forms
{
    /// <summary>
    /// The main form of this example
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Time the user has to be idle until a request is sent
        /// </summary>
        private const int RequiredIdleTime = 300;

        private readonly TranslateController controller;
        private readonly Timer requestTimer;

        public MainForm(TranslateController owner) : this()
        {
            controller = owner;

            // Create the request timer
            requestTimer = new Timer();
            requestTimer.Interval = RequiredIdleTime;
            requestTimer.Tick += (sender, eventArgs) =>
                                     {
                                         StopIdleTimer();
                                         controller.BeginRequest(inputBox.Text, outputLanguage.Text);
                                     };

            // Hook the translation finished event
            controller.OnTranslationFinished +=
                (request) => Invoke(new EventHandler((sender, eventArgs)
                                                     => ApplyResult(request)));

            // Set the language list
            outputLanguage.Items.AddRange(owner.Languages);
            outputLanguage.Text = controller.GetLanguageByCode("en");

            // Set default text
            var startTextRequest = new TranslateController.TranslationRequest()
                              {
                                  Input = "Please enter any text to start the translation.",
                                  OutputLanguage = controller.UserLanguageCode
                              };
            controller.ExecuteRequestBlocking(startTextRequest);
            inputBox.Text = startTextRequest.Output;
        }

        private MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to update/recheck all outputs
        /// </summary>
        private void UpdateTranslateControls()
        {
            // If no text has been entered, clear all outputs
            if (string.IsNullOrEmpty(inputBox.Text))
            {
                inputLanguage.Text = "(waiting for input)";
                outputBox.Text = "";
                StopIdleTimer();
            }

            // Translation is only done on a timer basis
            RestartIdleTimer();
        }

        private void ApplyResult(TranslateController.TranslationRequest request)
        {
            // Only update the information we didn't know
            outputBox.Text = request.Output;
            inputLanguage.Text = request.InputLanguage;
        }

        /// <summary>
        /// Stops the idle timer
        /// </summary>
        private void StopIdleTimer()
        {
            requestTimer.Stop();
        }

        /// <summary>
        /// (Re-)Starts the idle timer
        /// </summary>
        private void RestartIdleTimer()
        {
            // Restart the timer
            requestTimer.Stop();
            requestTimer.Start();
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTranslateControls();
        }

        private void outputLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTranslateControls();
        }
    }
}