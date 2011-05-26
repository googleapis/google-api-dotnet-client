namespace JSONExplorer {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.OpenJS = new System.Windows.Forms.Button();
      this.jsonview = new System.Windows.Forms.TreeView();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.ShowJSON = new System.Windows.Forms.CheckBox();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // OpenJS
      // 
      this.OpenJS.AutoSize = true;
      this.OpenJS.Location = new System.Drawing.Point(23, 21);
      this.OpenJS.Name = "OpenJS";
      this.OpenJS.Size = new System.Drawing.Size(101, 31);
      this.OpenJS.TabIndex = 1;
      this.OpenJS.Text = "Open JS file";
      this.OpenJS.UseVisualStyleBackColor = true;
      this.OpenJS.Click += new System.EventHandler(this.OpenJS_Click);
      // 
      // jsonview
      // 
      this.jsonview.Dock = System.Windows.Forms.DockStyle.Fill;
      this.jsonview.Location = new System.Drawing.Point(0, 0);
      this.jsonview.Name = "jsonview";
      this.jsonview.Size = new System.Drawing.Size(332, 255);
      this.jsonview.TabIndex = 2;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.ShowJSON);
      this.splitContainer1.Panel1.Controls.Add(this.OpenJS);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.jsonview);
      this.splitContainer1.Size = new System.Drawing.Size(504, 255);
      this.splitContainer1.SplitterDistance = 168;
      this.splitContainer1.TabIndex = 3;
      // 
      // ShowJSON
      // 
      this.ShowJSON.AutoSize = true;
      this.ShowJSON.Location = new System.Drawing.Point(23, 86);
      this.ShowJSON.Name = "ShowJSON";
      this.ShowJSON.Size = new System.Drawing.Size(105, 21);
      this.ShowJSON.TabIndex = 2;
      this.ShowJSON.Text = "Show JSON";
      this.ShowJSON.UseVisualStyleBackColor = true;
      this.ShowJSON.CheckedChanged += new System.EventHandler(this.ShowJSON_CheckedChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(504, 255);
      this.Controls.Add(this.splitContainer1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Button OpenJS;
    private System.Windows.Forms.TreeView jsonview;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.CheckBox ShowJSON;
  }
}

