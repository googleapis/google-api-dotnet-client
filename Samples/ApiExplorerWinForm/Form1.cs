using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using Google.Apis.Discovery;
using DotNetOpenAuth.OAuth2;
using DotNetOpenAuth.OAuth2.Messages;
using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OAuth2.ChannelElements;
using Google.Apis.Authentication;
using GoogleRequests = Google.Apis.Requests;

namespace Google.Apis.Samples.ApiExplorerWinForm
{
    public partial class Form1 : Form
    {
        private MethodCallContext callContext = null;

        private IAuthorizationState authState;

        private UserAgentClient client;

        public Form1()
        {
            InitializeComponent();

            this.InitializeTreeView();
        }

        /// <summary>
        /// Load apiTreeView top-level nodes with services
        /// </summary>
        private void InitializeTreeView()
        {
            string[] services = Scopes.scopes.Keys.ToArray();

            foreach (string service in services)
            {
                TreeNode node = new TreeNode(service);
                this.apiTreeView.Nodes.Add(node);
            }
        }

        private void apiTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = this.apiTreeView.SelectedNode;
            this.splitContainer1.Panel2.Visible = false;
            if (node.Level == 0)
            {
                ExpandServiceNode(node);
            } 
            else if (node.Level == 1)
            {
                ExpandVersionNode(node);
            }
            else if (node.Level == 2)
            {
                ExpandResourceNode(node);
            }
            else if (node.Level == 3)
            {
                LoadMethodParameters(node);
            }
        }

        private static void ExpandServiceNode(TreeNode node)
        {
            string serviceName = node.Text;
            string[] versions = ApiUtility.GetVersions(serviceName);
            node.Nodes.Clear();
            foreach (string version in versions)
            {
                TreeNode childNode = new TreeNode(version);
                node.Nodes.Add(childNode);
            }
            node.Expand();
        }

        private static void ExpandVersionNode(TreeNode node)
        {
            string serviceName = node.Parent.Text;
            string version = node.Text;
            IDictionary<string, IResource> resources = ApiUtility.GetResources(serviceName, version);
            node.Nodes.Clear();
            foreach (KeyValuePair<string, IResource> pair in resources)
            {
                TreeNode childNode = new TreeNode(pair.Key);
                node.Nodes.Add(childNode);
            }
            node.Expand();
        }

        private static void ExpandResourceNode(TreeNode node)
        {
            string resourceName = node.Text;
            string version = node.Parent.Text;
            string serviceName = node.Parent.Parent.Text;
            IDictionary<string, IMethod> methods = ApiUtility.GetMethods(serviceName, resourceName, version);
            node.Nodes.Clear();
            foreach (KeyValuePair<string, IMethod> pair in methods)
            {
                TreeNode childNode = new TreeNode(pair.Key);
                node.Nodes.Add(childNode);
            }
            node.Expand();
        }

        private void LoadMethodParameters(TreeNode node)
        {
            string methodName = node.Text;
            string resourceName = node.Parent.Text;
            string version = node.Parent.Parent.Text;
            string serviceName = node.Parent.Parent.Parent.Text;
            IMethod method = ApiUtility.GetMethod(serviceName, resourceName, methodName, version);
            Dictionary<string, IParameter> parameters = method.Parameters;

            this.parameterLayoutPanel.Controls.Clear();
            this.parameterLayoutPanel.RowCount = parameters.Count;
            foreach (KeyValuePair<string, IParameter> pair in parameters)
            {
                Label nameLabel = new Label();
                nameLabel.Text = pair.Key;
                this.parameterLayoutPanel.Controls.Add(nameLabel);
                TextBox valueTextBox = new TextBox();
                this.parameterLayoutPanel.Controls.Add(valueTextBox);
            }
            this.parameterLayoutPanel.Controls.Add(this.executeButton);
            this.splitContainer1.Panel2.Visible = true;
        }

        protected void executeButton_Click(object sender, EventArgs e)
        {
            TreeNode node = this.apiTreeView.SelectedNode;
            string methodName = node.Text;
            string resourceName = node.Parent.Text;
            string version = node.Parent.Parent.Text;
            string serviceName = node.Parent.Parent.Parent.Text;

            Dictionary<string, string> paramDictionary = new Dictionary<string, string>();
            for (int i = 0; i < this.parameterLayoutPanel.Controls.Count - 1; i += 2)
            {
                Label nameLabel = this.parameterLayoutPanel.Controls[i] as Label;
                TextBox valueTextBox = this.parameterLayoutPanel.Controls[i + 1] as TextBox;
                string paramName = nameLabel.Text;
                string paramValue = valueTextBox.Text;
                paramDictionary.Add(paramName, paramValue);
            }

            this.callContext = new MethodCallContext
            {
                Service = serviceName,
                Version = version,
                Resource = resourceName,
                Method = methodName,
                Parameters = paramDictionary
            };

            this.ExecuteMethod();
        }

        /// <summary>
        /// Execute selected API method
        /// </summary>
        private void ExecuteMethod()
        {
            string clientId = Properties.Settings.Default.clientId;
            string clientSecret = Properties.Settings.Default.clientSecret;
            string apiKey = Properties.Settings.Default.apiKey;

            if (!this.AccessTokens.ContainsKey(callContext.Service))
            {
                AuthorizationServerDescription serviceDescription = this.GetAuthorizationServerDescription();
                client = new UserAgentClient(serviceDescription, clientId, clientSecret);
                authState = new AuthorizationState(new string[] { Scopes.scopes[callContext.Service].Name });
                authState.Callback = new Uri(Properties.Settings.Default.redirectUrl);
                Uri authorizationUrl = client.RequestUserAuthorization(authState);
                this.authWebBrowser.Navigate(authorizationUrl.AbsoluteUri);
            }
            else
            {
                string token = this.AccessTokens[callContext.Service];
                this.ExecuteMethodWithToken(token);
            }
        }

        private void ExecuteMethodWithToken(string token)
        {
            string clientId = Properties.Settings.Default.clientId;
            string clientSecret = Properties.Settings.Default.clientSecret;
            string apiKey = Properties.Settings.Default.apiKey;

            IAuthenticator authenticator = new OAuth2Authenticator(apiKey, clientId, clientSecret, token);
            IService service = ApiUtility.GetService(callContext.Service, callContext.Version);
            IMethod method = ApiUtility.GetMethod(callContext.Service, callContext.Resource, callContext.Method, callContext.Version);
            GoogleRequests.IRequest request = GoogleRequests.Request.CreateRequest(service, method)
                .WithAuthentication(authenticator)
                .WithParameters(callContext.Parameters)
                .WithDeveloperKey(apiKey);

            using (Stream stream = request.ExecuteRequest())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    this.resultTextBox.Text = reader.ReadToEnd();
                }
            }
        }

        private void RequestAuthorization(WebServerClient client, string serviceName)
        {
            Dictionary<string, string> extraParameters = new Dictionary<string, string> { { "scope", Scopes.scopes[serviceName].Name } };
            string scope = Scopes.scopes[serviceName].Name;
            Uri callback = MessagingUtilities.GetRequestUrlFromContext().StripQueryArgumentsWithPrefix("oauth_");
            OutgoingWebResponse response = client.PrepareRequestUserAuthorization(new string[] { scope }, null);
            response.Send();
        }

        private AuthorizationServerDescription GetAuthorizationServerDescription()
        {
            AuthorizationServerDescription serviceDescription = new AuthorizationServerDescription
            {
                AuthorizationEndpoint = new Uri(Properties.Settings.Default.authorizationEndPoint),
                ProtocolVersion = ProtocolVersion.V20,
                TokenEndpoint = new Uri(Properties.Settings.Default.tokenEndPoint)
            };

            return serviceDescription;
        }

        /// <summary>
        /// Map between service name and access tokens
        /// </summary>
        private Dictionary<string, string> AccessTokens = new Dictionary<string,string>();

        private void authWebBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.client.ProcessUserAuthorization(e.Url, this.authState);

            if (!string.IsNullOrEmpty(this.authState.AccessToken))
            {
                if (!this.AccessTokens.ContainsKey(callContext.Service))
                {
                    this.AccessTokens.Add(callContext.Service, authState.AccessToken);
                }
                else
                {
                    this.AccessTokens[callContext.Service] = authState.AccessToken;
                }

                this.ExecuteMethodWithToken(this.AccessTokens[callContext.Service]);
            }
        }
    }
}
