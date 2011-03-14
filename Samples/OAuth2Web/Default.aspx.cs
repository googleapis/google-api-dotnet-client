using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Google.Apis.Discovery;

namespace Google.Apis.Samples.OAuth2Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.InitializeTreeView();
            }
        }

        /// <summary>
        /// Load apiTreeView top-level nodes with services
        /// </summary>
        private void InitializeTreeView()
        {
            Dictionary<string, string> services = new Dictionary<string,string>
            {
                { "buzz", "Buzz" },
                { "chromewebstore", "Chrome Web Store" },
            };

            foreach (KeyValuePair<string, string> pair in services)
            {
                TreeNode node = new TreeNode(pair.Value, pair.Key);
                this.apiTreeView.Nodes.Add(node);
            }
        }

        private IDictionary<string, IResource> GetResources(string serviceName)
        {
            WebDiscoveryDevice discoveryDevice = new WebDiscoveryDevice
            {
                DiscoveryUri = new Uri("https://www.googleapis.com/discovery/0.1/describe?api=" + serviceName)
            };

            DiscoveryService discovery = new DiscoveryService(discoveryDevice);
            IService service = discovery.GetService("v1", DiscoveryVersion.Version_0_1, null);
            IDictionary<string, IResource> resources = service.Resources;
            return resources;
        }

        private Dictionary<string, IMethod> GetMethods(string serviceName, string resourceName)
        {
            IDictionary<string, IResource> resources = this.GetResources(serviceName);
            return resources[resourceName].Methods;
        }

        private IMethod GetMethod(string serviceName, string resourceName, string methodName)
        {
            return this.GetMethods(serviceName, resourceName)[methodName];
        }

        private Dictionary<string, IMethod> CurrentMethods
        {
            get
            {
                return Session["CurrentMethods"] as Dictionary<string, IMethod>;
            }
            set
            {
                Session["CurrentMethods"] = value;
            }
        }

        private IDictionary<string, IResource> CurrentResources
        {
            get
            {
                return Session["CurrentResources"] as IDictionary<string, IResource>;
            }
            set
            {
                Session["CurrentResources"] = value;
            }
        }

        protected void apiTreeView_SelectedNodeChanged(object sender, EventArgs e)
        {
            TreeNode node = this.apiTreeView.SelectedNode;
            this.methodParametersPanel.Visible = false;
            if (node.Depth == 0) // service
            {
                string serviceName = node.Value;
                IDictionary<string, IResource> resources = GetResources(serviceName);
                node.ChildNodes.Clear();
                foreach (KeyValuePair<string, IResource> pair in resources)
                {
                    TreeNode childNode = new TreeNode(pair.Key, pair.Key);
                    node.ChildNodes.Add(childNode);
                }
                node.Expand();
            }
            else if (node.Depth == 1) // resource
            {
                string resourceName = node.Value;
                string serviceName = node.Parent.Value;
                Dictionary<string, IMethod> methods = this.GetMethods(serviceName, resourceName);
                node.ChildNodes.Clear();
                foreach (KeyValuePair<string, IMethod> pair in methods)
                {
                    TreeNode childNode = new TreeNode(pair.Key, pair.Key);
                    node.ChildNodes.Add(childNode);
                }
                node.Expand();
            }
            else if (node.Depth == 2) // method
            {
                string methodName = node.Value;
                string resourceName = node.Parent.Value;
                string serviceName = node.Parent.Parent.Value;
                IMethod method = this.GetMethod(serviceName, resourceName, methodName);
                Dictionary<string, IParameter> parameters = method.Parameters;
                this.methodParametersRepeater.DataSource = parameters.Keys;
                this.methodParametersRepeater.DataBind();
                this.methodParametersPanel.Visible = true;
            }
        }

        protected void executeMethodButton_Click(object sender, EventArgs e)
        {
            string url = string.Format("{0}://{1}:{2}{3}", Request.IsSecureConnection ? "https" : "http", 
                Request.Url.Host, Request.Url.Port, Page.ResolveUrl("~/Result.aspx"));
            string script = string.Format("<script type=\"text/javascript\">window.open('{0}', '_result', 'width=400;height=600;', true);</script>", url);
            this.ClientScript.RegisterStartupScript(this.GetType(), "Popup", script);
        }
    }
}
