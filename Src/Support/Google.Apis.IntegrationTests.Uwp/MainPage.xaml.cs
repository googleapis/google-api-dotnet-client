using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Google.Apis.IntegrationTests.Uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private static GoogleClientSecrets _userSecrets = null;
        private static GoogleCredential _serviceCredential = null;

        private void SetTestButtonsState()
        {
            bool enabled = _userSecrets != null && _serviceCredential != null
                && !string.IsNullOrWhiteSpace(ProjectNameTextBox.Text);
            StartButton.IsEnabled = enabled;
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.FileTypeFilter.Add(".json");
            var file = await openPicker.PickSingleFileAsync();
            if (file != null)
            {
                using (var st = await file.OpenStreamForReadAsync())
                {
                    _userSecrets = GoogleClientSecrets.Load(st);
                }
            }
            else
            {
                _userSecrets = null;
            }
            SetTestButtonsState();
        }

        private async void SelectServiceCredentialsButton_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.FileTypeFilter.Add(".json");
            var file = await openPicker.PickSingleFileAsync();
            if (file != null)
            {
                using (var st = await file.OpenStreamForReadAsync())
                {
                    _serviceCredential = GoogleCredential.FromStream(st);
                }
            }
            else
            {
                _serviceCredential = null;
            }
            SetTestButtonsState();
        }

        private void ProjectNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SetTestButtonsState();
        }

        private async Task<IEnumerable<string>> GetBuckets(ICredential credential)
        {
            var storage = new Google.Apis.Storage.v1.StorageService(new Services.BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "UWPIntegrationTest",
            });
            var buckets = await storage.Buckets.List(ProjectNameTextBox.Text).ExecuteAsync();
            return buckets.Items.Select(x => x.Name).ToList();
        }

        private async void StartButton_Click(object sender, RoutedEventArgs e)
        {
            var storageScopes = new[] { Google.Apis.Storage.v1.StorageService.Scope.DevstorageReadOnly };
            void Report(string s) => TestAuthToStorageTextBox.Text += s + Environment.NewLine;
            TestAuthToStorageTextBox.Text = "";
            Report("Test starting...");
            // Test service credential to read storage
            Report("Testing service credentials to storage");
            var serviceCredential = _serviceCredential.CreateScoped(storageScopes);
            var buckets = await GetBuckets(serviceCredential);
            Report($"Buckets: {string.Join(", ", buckets)}");
            // Test user credential to read storage, with PasswordVaultStorage
            var datastore = new PasswordVaultDataStore();
            await datastore.ClearAsync();
            Report("Testing user credentials to storage. Will require login.");
            var userCredential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    _userSecrets.Secrets, storageScopes, "uwpintegrationtest", CancellationToken.None, datastore);
            buckets = await GetBuckets(userCredential);
            Report($"Buckets: {string.Join(", ", buckets)}");
            Report("Testing user credentials to storage again. Login not required.");
            userCredential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    _userSecrets.Secrets, storageScopes, "uwpintegrationtest", CancellationToken.None, datastore);
            buckets = await GetBuckets(userCredential);
            Report($"Buckets: {string.Join(", ", buckets)}");
            Report("Done OK");
        }
    }
}
