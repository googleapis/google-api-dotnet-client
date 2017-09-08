using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
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

        static string s_clientSecret = "{\"installed\":{\"client_id\":\"233772281425-ab2mcbiqmv8kh0mdnqsrkrod97qk37h0.apps.googleusercontent.com\",\"project_id\":\"chrisbacon-testing\",\"auth_uri\":\"https://accounts.google.com/o/oauth2/auth\",\"token_uri\":\"https://accounts.google.com/o/oauth2/token\",\"auth_provider_x509_cert_url\":\"https://www.googleapis.com/oauth2/v1/certs\",\"client_secret\":\"7s1Gc2n2Zr6FZmMvR3OeyWdp\",\"redirect_uris\":[\"urn:ietf:wg:oauth:2.0:oob\",\"http://localhost\"]}}";
        public static MemoryStream GetClientSecretStream() => new MemoryStream(Encoding.ASCII.GetBytes(s_clientSecret));

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var secret = GoogleClientSecrets.Load(GetClientSecretStream());
            var response = await GoogleWebAuthorizationBroker.AuthorizeAsync(secret.Secrets,
                new[] { Google.Apis.Storage.v1.StorageService.Scope.DevstorageReadOnly }, "me", CancellationToken.None, new NullDataStore());
            this.textblock1.Text = response.Token.AccessToken;
            var storage = new Google.Apis.Storage.v1.StorageService(new Services.BaseClientService.Initializer
            {
                HttpClientInitializer = response,
                ApplicationName = "mytest",
            });
            var buckets = await storage.Buckets.List("chrisbacon-testing").ExecuteAsync();
            var bucketNames = string.Join(", ", buckets.Items.Select(x => x.Name));
            textblock1.Text = bucketNames;
        }
    }
}
