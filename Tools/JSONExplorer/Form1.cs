using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Google.Apis.JSON;
using Google.Apis.Discovery;

namespace JSONExplorer {
  public partial class Form1 : Form {
    private Stream inputstream;
    private Object jsonObject;
    private ServiceFactory factory;

    public Form1() {
      InitializeComponent();
    }

    private void OpenJS_Click(object sender, EventArgs e) {
      if (openFileDialog1.ShowDialog() == DialogResult.OK) {
        this.inputstream = openFileDialog1.OpenFile();
        ShowJSON_CheckedChanged(null, null);
      }
    }

    private void PopulateTreeView(TreeNodeCollection c,JSONDictionary js) {
      foreach (KeyValuePair<string, object> kvp in js) {
        TreeNode n = new TreeNode(kvp.Key);
        if (kvp.Value is JSONDictionary) {
          PopulateTreeView(n.Nodes, kvp.Value as JSONDictionary);
        }
        else if (kvp.Value is ArrayList) {
          PopulateTreeView(n.Nodes, kvp.Value as ArrayList);
        }
        else {
          n.Text = n.Text + ": " + kvp.Value;
        }
        c.Add(n);
      }
    }

    private void PopulateTreeWithService(TreeNodeCollection c, Service s) {
      TreeNode n = new TreeNode(s.Name);
      c.Add(n);
      c = n.Nodes;
      n = new TreeNode(s.BaseUri.AbsoluteUri);
      c.Add(n);
      n = new TreeNode(s.RpcUri.AbsoluteUri);
      c.Add(n);

      n = new TreeNode("Resources");
      c.Add(n);
      c = n.Nodes;

      foreach (KeyValuePair<string, Resource> kvp in s.Resources) {
        n = new TreeNode(kvp.Key);
        PopulateMethods(n.Nodes, kvp.Value);
        c.Add(n);
      }


    }

    private void PopulateMethods(TreeNodeCollection c, Resource r) {
      foreach (KeyValuePair<string, Method> kvp in r.Methods) {
        TreeNode m = new TreeNode(kvp.Key);
        PopulateMethod(m.Nodes, kvp.Value);
        c.Add(m);
      }
    }

    private void PopulateMethod(TreeNodeCollection c, Method m) {
      c.Add(new TreeNode(m.RestPath));
      c.Add(new TreeNode(m.RpcName));
      c.Add(new TreeNode(m.HttpMethod));
      TreeNode n = new TreeNode("Parameters");
      c.Add(n);
      c = n.Nodes;
      if (m.Parameters != null) {
        foreach (KeyValuePair<string, Parameter> p in m.Parameters) {
          PopulateParameter(c, p.Value);
        }
      }
    }

    private void PopulateParameter(TreeNodeCollection c, Parameter p) {
      TreeNode n = new TreeNode(p.Name);
      c.Add(n);

      n.Nodes.Add(new TreeNode(p.ParameterType));
      n.Nodes.Add(new TreeNode(p.Pattern));
      n.Nodes.Add(new TreeNode(p.Required.ToString()));
      n.Nodes.Add(new TreeNode(p.DefaultValue));
      n.Nodes.Add(new TreeNode(p.ValueType));

    }

    private void PopulateTreeView(TreeNodeCollection c, ArrayList list) {
      foreach (object o in list) {
        if (o is JSONDictionary) {
          PopulateTreeView(c, o as JSONDictionary);
        }
        else if (o is ArrayList) {
          PopulateTreeView(c, o as ArrayList);
        }
        else {
          TreeNode n = new TreeNode(o.ToString());
          c.Add(n);
        }
      }
    }

    private void ShowJSON_CheckedChanged(object sender, EventArgs e) {
      if (this.ShowJSON.Checked == true) {
        DisplayJSON();
      } else {
        DisplayService();
      }
    }

    private void DisplayService() {
      this.jsonview.Nodes.Clear();
      if (this.factory == null) {
        this.inputstream.Seek(0, SeekOrigin.Begin);
        this.factory = new ServiceFactory(this.inputstream);
      }
      Service service = this.factory.GetService("v1");
      PopulateTreeWithService(this.jsonview.Nodes, service);
      this.jsonview.ExpandAll();
    }

    private void DisplayJSON() {
      this.jsonview.Nodes.Clear();
      if (this.jsonObject == null) {
        this.inputstream.Seek(0, SeekOrigin.Begin);
        this.jsonObject = JSONReader.Parse(this.inputstream);
      }
      if (this.jsonObject is JSONDictionary) {
        PopulateTreeView(this.jsonview.Nodes, this.jsonObject as JSONDictionary);
      }
      this.jsonview.ExpandAll();
    }
    

  }
}
