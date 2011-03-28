using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Google.Apis.Discovery;

namespace Google.Apis.Samples.ApiExplorerWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        private ApiUtility Api
        {
            get
            {
                ApiUtility ret = Application["ApiUtility"] as ApiUtility;
                if (ret == null)
                {
                    ret = new ApiUtility();
                    Application["ApiUtility"] = ret;
                }
                return ret;
            }
        }

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
            string[] services = Api.getServiceNames();

            foreach (string service in services)
            {
                TreeNode node = new TreeNode(service);
                this.apiTreeView.Nodes.Add(node);
            }
        }

        protected void apiTreeView_SelectedNodeChanged(object sender, EventArgs e)
        {
            TreeNode node = this.apiTreeView.SelectedNode;
            this.methodParametersPanel.Visible = false;
            if (node.Depth == 0)
            {
                ExpandServiceNode(node);
            } 
            else if (node.Depth == 1)
            {
                ExpandVersionNode(node);
            }
            else if (node.Depth == 2)
            {
                ExpandResourceNode(node);
            }
            else if (node.Depth == 3)
            {
                LoadMethodParameters(node);
            }
        }

        private void ExpandServiceNode(TreeNode node)
        {
            string serviceName = node.Value;
            string[] versions = Api.GetVersions(serviceName);
            node.ChildNodes.Clear();
            foreach (string version in versions)
            {
                TreeNode childNode = new TreeNode(version);
                node.ChildNodes.Add(childNode);
            }
            node.Expand();
        }

        private void ExpandVersionNode(TreeNode node)
        {
            string serviceName = node.Parent.Value;
            string version = node.Value;
            IDictionary<string, IResource> resources = Api.GetResources(serviceName, version);
            node.ChildNodes.Clear();
            foreach (KeyValuePair<string, IResource> pair in resources)
            {
                TreeNode childNode = new TreeNode(pair.Key);
                node.ChildNodes.Add(childNode);
            }
            node.Expand();
        }

        private void ExpandResourceNode(TreeNode node)
        {
            string resourceName = node.Value;
            string version = node.Parent.Value;
            string serviceName = node.Parent.Parent.Value;
            IDictionary<string, IMethod> methods = Api.GetMethods(serviceName, resourceName, version);
            node.ChildNodes.Clear();
            foreach (KeyValuePair<string, IMethod> pair in methods)
            {
                TreeNode childNode = new TreeNode(pair.Key);
                node.ChildNodes.Add(childNode);
            }
            node.Expand();
        }

        private void LoadMethodParameters(TreeNode node)
        {
            string methodName = node.Value;
            string resourceName = node.Parent.Value;
            string version = node.Parent.Parent.Value;
            string serviceName = node.Parent.Parent.Parent.Value;
            IMethod method = Api.GetMethod(serviceName, resourceName, methodName, version);
            Dictionary<string, IParameter> parameters = method.Parameters;
            this.methodParametersRepeater.DataSource = parameters.Keys;
            this.methodParametersRepeater.DataBind();
            this.methodParametersPanel.Visible = true;
        }

        protected void executeMethodButton_Click(object sender, EventArgs e)
        {
            TreeNode node = this.apiTreeView.SelectedNode;
            string methodName = node.Value;
            string resourceName = node.Parent.Value;
            string version = node.Parent.Parent.Value;
            string serviceName = node.Parent.Parent.Parent.Value;

            Dictionary<string, string> paramDictionary = new Dictionary<string, string>();
            foreach (RepeaterItem item in this.methodParametersRepeater.Items)
            {
                string paramName = (item.FindControl("parameterNameLabel") as Label).Text;
                string paramValue = (item.FindControl("parameterValueTextBox") as TextBox).Text;
                paramDictionary.Add(paramName, paramValue);
            }

            MethodCallContext callContext = new MethodCallContext
            {
                Service = serviceName,
                Version = version,
                Resource = resourceName,
                Method = methodName,
                Parameters = paramDictionary
            };

            Session["callContext"] = callContext;

            string url = string.Format("{0}://{1}:{2}{3}", Request.IsSecureConnection ? "https" : "http",
                Request.Url.Host, Request.Url.Port, Page.ResolveUrl("~/Result.aspx"));
            string script = string.Format("<script type=\"text/javascript\">"
                + "window.open('{0}', '_result', 'width=400;height=600;', true);</script>", url);
            this.ClientScript.RegisterStartupScript(this.GetType(), "Popup", script);
        }
    }
}
