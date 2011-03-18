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

        protected void apiTreeView_SelectedNodeChanged(object sender, EventArgs e)
        {
            TreeNode node = this.apiTreeView.SelectedNode;
            this.methodParametersPanel.Visible = false;
            if (node.Depth == 0) // service
            {
                string serviceName = node.Value;
                IDictionary<string, IResource> resources = ApiUtility.GetResources(serviceName);
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
                IDictionary<string, IMethod> methods = ApiUtility.GetMethods(serviceName, resourceName);
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
                IMethod method = ApiUtility.GetMethod(serviceName, resourceName, methodName);
                Dictionary<string, IParameter> parameters = method.Parameters;
                this.methodParametersRepeater.DataSource = parameters.Keys;
                this.methodParametersRepeater.DataBind();
                this.methodParametersPanel.Visible = true;
            }
        }

        protected void executeMethodButton_Click(object sender, EventArgs e)
        {
            TreeNode node = this.apiTreeView.SelectedNode;
            string methodName = node.Value;
            string resourceName = node.Parent.Value;
            string serviceName = node.Parent.Parent.Value;
            string queryString = string.Format("service={0}&resource={1}&method={2}", serviceName, resourceName, methodName);

            Dictionary<string, string> paramDictionary = new Dictionary<string, string>();
            foreach (RepeaterItem item in this.methodParametersRepeater.Items)
            {
                string paramName = (item.FindControl("parameterNameLabel") as Label).Text;
                string paramValue = (item.FindControl("parameterValueTextBox") as TextBox).Text;
                paramDictionary.Add(paramName, paramValue);
                queryString += string.Format("&param_{0}={1}", paramName, paramValue);
            }

            string url = string.Format("{0}://{1}:{2}{3}?{4}", Request.IsSecureConnection ? "https" : "http", 
                Request.Url.Host, Request.Url.Port, Page.ResolveUrl("~/Result.aspx"), queryString);
            string script = string.Format("<script type=\"text/javascript\">window.open('{0}', '_result', 'width=400;height=600;', true);</script>", url);
            this.ClientScript.RegisterStartupScript(this.GetType(), "Popup", script);
        }
    }
}
