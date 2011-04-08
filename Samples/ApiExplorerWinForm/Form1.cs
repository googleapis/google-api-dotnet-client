/*
Copyright 2011 Google Inc

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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DotNetOpenAuth.OAuth2;
using DotNetOpenAuth.OAuth2.Messages;
using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OAuth2.ChannelElements;

using Google.Apis.Authentication;
using Google.Apis.Discovery;
using GoogleRequests = Google.Apis.Requests;

namespace Google.Apis.Samples.ApiExplorer.WinForm
{
    public partial class Form1 : Form
    {
        private MethodCallContext _currentCallContext = null;

        private IAuthorizationState _authState;

        private UserAgentClient _client;

        private ApiUtility _api = new ApiUtility();

        /// <summary>
        /// Map between service name and access tokens
        /// </summary>
        private Dictionary<string, string> _accessTokens = new Dictionary<string,string>();

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
            string[] services = _api.getServiceNames();

            foreach (string service in services)
            {
                TreeNode node = new TreeNode(service);
                this.apiTreeView.Nodes.Add(node);
            }
        }

        private void apiTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
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

        private void ExpandServiceNode(TreeNode node)
        {
            string serviceName = node.Text;
            string[] versions = _api.GetVersions(serviceName);
            node.Nodes.Clear();
            foreach (string version in versions)
            {
                TreeNode childNode = new TreeNode(version);
                node.Nodes.Add(childNode);
            }
            node.Expand();
        }

        private void ExpandVersionNode(TreeNode node)
        {
            string serviceName = node.Parent.Text;
            string version = node.Text;
            IDictionary<string, IResource> resources = _api.GetResources(serviceName, version);
            node.Nodes.Clear();
            foreach (KeyValuePair<string, IResource> pair in resources)
            {
                TreeNode childNode = new TreeNode(pair.Key);
                node.Nodes.Add(childNode);
            }
            node.Expand();
        }

        private void ExpandResourceNode(TreeNode node)
        {
            string resourceName = node.Text;
            string version = node.Parent.Text;
            string serviceName = node.Parent.Parent.Text;
            IDictionary<string, IMethod> methods = _api.GetMethods(serviceName, resourceName, version);
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
            IMethod method = _api.GetMethod(serviceName, resourceName, methodName, version);
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
            this.clearBrowserDisplay();
        }

        private void clearBrowserDisplay()
        {
            this.locationTextBox.Text = string.Empty;
            if (this.authWebBrowser.Document != null)
            {
                this.authWebBrowser.Document.OpenNew(false);
            }
        }

        protected void executeButton_Click(object sender, EventArgs e)
        {
            this.clearBrowserDisplay();

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

            this._currentCallContext = new MethodCallContext(serviceName, version, resourceName, methodName, paramDictionary);

            this.ExecuteMethod();
        }

        /// <summary>
        /// Attempt to execute selected API method
        /// </summary>
        private void ExecuteMethod()
        {
            if (!this._accessTokens.ContainsKey(_currentCallContext.Service))
            {
                string clientId = Properties.Settings.Default.clientId;
                string clientSecret = Properties.Settings.Default.clientSecret;
                string apiKey = Properties.Settings.Default.apiKey;

                AuthorizationServerDescription serviceDescription = this.GetAuthorizationServerDescription();
                _client = new UserAgentClient(serviceDescription, clientId, clientSecret);
                string scope = Scopes.GetScope(_currentCallContext.Service);
                _authState = new AuthorizationState(new string[] { scope });
                _authState.Callback = new Uri(Properties.Settings.Default.redirectUrl);
                Uri authorizationUrl = _client.RequestUserAuthorization(_authState);
                // hack: UserAgentClient is still using response_type=code. needs response_type=token
                // for google apis.
                string url = authorizationUrl.AbsoluteUri.Replace("response_type=code", "response_type=token");
                this.authWebBrowser.Navigate(url);

                this.Cursor = Cursors.WaitCursor;
            }
            else
            {
                string token = this._accessTokens[_currentCallContext.Service];
                this.ExecuteRequest(token);
            }
        }

        /// <summary>
        /// Construct and send method request assuming token is already obtained.
        /// </summary>
        private void ExecuteRequest(string token)
        {
            string clientId = Properties.Settings.Default.clientId;
            string clientSecret = Properties.Settings.Default.clientSecret;
            string apiKey = Properties.Settings.Default.apiKey;

            IAuthenticator authenticator = new OAuth2Authenticator(apiKey, clientId, clientSecret, token);
            IService service = _api.GetService(_currentCallContext.Service, _currentCallContext.Version);
            IMethod method = _api.GetMethod(_currentCallContext.Service, _currentCallContext.Resource, _currentCallContext.Method, _currentCallContext.Version);
            GoogleRequests.IRequest request = GoogleRequests.Request.CreateRequest(service, method)
                .WithAuthentication(authenticator)
                .WithParameters(_currentCallContext.Parameters)
                .WithDeveloperKey(apiKey);

            using (Stream stream = request.ExecuteRequest())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    this.authWebBrowser.Document.OpenNew(false);
                    this.authWebBrowser.Document.Write(reader.ReadToEnd());
                }
            }

            this.Cursor = Cursors.Default;
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

        private void authWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void authWebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.locationTextBox.Text = e.Url.AbsoluteUri;

            if (e.Url.AbsoluteUri.StartsWith(Properties.Settings.Default.redirectUrl))
            {
                this._client.ProcessUserAuthorization(e.Url, this._authState);

                if (!string.IsNullOrEmpty(this._authState.AccessToken))
                {
                    if (!this._accessTokens.ContainsKey(_currentCallContext.Service))
                    {
                        this._accessTokens.Add(_currentCallContext.Service, _authState.AccessToken);
                    }
                    else
                    {
                        this._accessTokens[_currentCallContext.Service] = _authState.AccessToken;
                    }

                    this.ExecuteRequest(_authState.AccessToken);
                }
            }

        }
    }
}