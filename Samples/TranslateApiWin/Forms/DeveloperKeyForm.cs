using System;
using System.Windows.Forms;

using Google.Apis.Samples.TranslateApiWin.Services;

namespace Google.Apis.Samples.TranslateApiWin.Forms
{
    /// <summary>
    /// A form which handles the request for a developer key
    /// </summary>
    public partial class DeveloperKeyForm : Form, IDeveloperKeyRequest
    {
        public DeveloperKeyForm()
        {
            InitializeComponent();
            UpdateContinueButton();
        }

        #region IDeveloperKeyRequest implementation

        public string RequestDeveloperKey(string applicationName)
        {
            // Fill in the place holders
            applicationNameLabel.Text = applicationName;

            // Wait for the user input
            ShowDialog();

            // Return the key
            return DeveloperKey;
        }

        #endregion

        /// <summary>
        /// The developer key entered into the form
        /// </summary>
        public string DeveloperKey { get; private set; }

        private void developerKeyTextbox_TextChanged(object sender, EventArgs e)
        {
            UpdateContinueButton();
        }

        private void UpdateContinueButton()
        {
            // Adjust the button to represent the current action
            continueButton.Text = string.IsNullOrEmpty(developerKeyTextbox.Text)
                                      ? "Continue (without key)"
                                      : "Continue";
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            // Set the result of this form
            if (string.IsNullOrEmpty(developerKeyTextbox.Text) == false)
            {
                DeveloperKey = developerKeyTextbox.Text;
            }
            Close();
        }
    }
}