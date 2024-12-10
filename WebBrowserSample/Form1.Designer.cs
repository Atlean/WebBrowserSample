namespace WebBrowserSample
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Back = new System.Windows.Forms.ToolStripButton();
            this.Forward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cboLocation = new System.Windows.Forms.ToolStripComboBox();
            this.ButtonGo = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Back,
            this.Forward,
            this.toolStripSeparator1,
            this.cboLocation,
            this.ButtonGo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Back
            // 
            this.Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(36, 22);
            this.Back.Text = "Back";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Forward
            // 
            this.Forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Forward.Image = ((System.Drawing.Image)(resources.GetObject("Forward.Image")));
            this.Forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(54, 22);
            this.Forward.Text = "Forward";
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cboLocation
            // 
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(121, 25);
            this.cboLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboLocation_KeyDown);
            this.cboLocation.Click += new System.EventHandler(this.cboLocation_Click);
            // 
            // ButtonGo
            // 
            this.ButtonGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonGo.Image = ((System.Drawing.Image)(resources.GetObject("ButtonGo.Image")));
            this.ButtonGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonGo.Name = "ButtonGo";
            this.ButtonGo.Size = new System.Drawing.Size(26, 22);
            this.ButtonGo.Text = "Go";
            this.ButtonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 425);
            this.webBrowser1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMain";
            this.Text = "BrowserMain";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Back;
        private System.Windows.Forms.ToolStripButton Forward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cboLocation;
        private System.Windows.Forms.ToolStripButton ButtonGo;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

