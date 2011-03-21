namespace Google.Apis.Samples.ApiExplorerWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.apiTreeView = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.authTabPage = new System.Windows.Forms.TabPage();
            this.resultTabPage = new System.Windows.Forms.TabPage();
            this.parameterLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.executeButton = new System.Windows.Forms.Button();
            this.authWebBrowser = new System.Windows.Forms.WebBrowser();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.authTabPage.SuspendLayout();
            this.resultTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.apiTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(512, 435);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 0;
            // 
            // apiTreeView
            // 
            this.apiTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.apiTreeView.Location = new System.Drawing.Point(3, 29);
            this.apiTreeView.Name = "apiTreeView";
            this.apiTreeView.Size = new System.Drawing.Size(164, 403);
            this.apiTreeView.TabIndex = 0;
            this.apiTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.apiTreeView_AfterSelect);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.executeButton);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.parameterLayoutPanel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(332, 429);
            this.splitContainer2.SplitterDistance = 153;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.authTabPage);
            this.tabControl1.Controls.Add(this.resultTabPage);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(326, 266);
            this.tabControl1.TabIndex = 0;
            // 
            // authTabPage
            // 
            this.authTabPage.Controls.Add(this.authWebBrowser);
            this.authTabPage.Location = new System.Drawing.Point(4, 22);
            this.authTabPage.Name = "authTabPage";
            this.authTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.authTabPage.Size = new System.Drawing.Size(318, 240);
            this.authTabPage.TabIndex = 0;
            this.authTabPage.Text = "Authorization";
            this.authTabPage.UseVisualStyleBackColor = true;
            // 
            // resultTabPage
            // 
            this.resultTabPage.Controls.Add(this.resultTextBox);
            this.resultTabPage.Location = new System.Drawing.Point(4, 22);
            this.resultTabPage.Name = "resultTabPage";
            this.resultTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.resultTabPage.Size = new System.Drawing.Size(318, 240);
            this.resultTabPage.TabIndex = 1;
            this.resultTabPage.Text = "Result";
            this.resultTabPage.UseVisualStyleBackColor = true;
            // 
            // parameterLayoutPanel
            // 
            this.parameterLayoutPanel.AutoSize = true;
            this.parameterLayoutPanel.ColumnCount = 2;
            this.parameterLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.parameterLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.parameterLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.parameterLayoutPanel.Location = new System.Drawing.Point(7, 26);
            this.parameterLayoutPanel.Name = "parameterLayoutPanel";
            this.parameterLayoutPanel.RowCount = 1;
            this.parameterLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.parameterLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.parameterLayoutPanel.Size = new System.Drawing.Size(200, 20);
            this.parameterLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Services";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Method Parameters";
            // 
            // executeButton
            // 
            this.executeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.executeButton.Location = new System.Drawing.Point(7, 127);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 2;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // authWebBrowser
            // 
            this.authWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.authWebBrowser.Location = new System.Drawing.Point(6, 6);
            this.authWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.authWebBrowser.Name = "authWebBrowser";
            this.authWebBrowser.Size = new System.Drawing.Size(306, 228);
            this.authWebBrowser.TabIndex = 0;
            this.authWebBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.authWebBrowser_Navigating);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTextBox.Location = new System.Drawing.Point(6, 6);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(306, 228);
            this.resultTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 435);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Google API Explorer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.authTabPage.ResumeLayout(false);
            this.resultTabPage.ResumeLayout(false);
            this.resultTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView apiTreeView;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel parameterLayoutPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage authTabPage;
        private System.Windows.Forms.TabPage resultTabPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.WebBrowser authWebBrowser;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

