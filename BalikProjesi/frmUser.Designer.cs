namespace BalikProjesi
{
    partial class frmUser
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fİLETOPERSONELİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kONTROLPERSONELİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fİLETOPERSONELİToolStripMenuItem,
            this.kONTROLPERSONELİToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fİLETOPERSONELİToolStripMenuItem
            // 
            this.fİLETOPERSONELİToolStripMenuItem.Name = "fİLETOPERSONELİToolStripMenuItem";
            this.fİLETOPERSONELİToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.fİLETOPERSONELİToolStripMenuItem.Text = "FİLETO PERSONELİ";
            this.fİLETOPERSONELİToolStripMenuItem.Click += new System.EventHandler(this.fİLETOPERSONELİToolStripMenuItem_Click);
            // 
            // kONTROLPERSONELİToolStripMenuItem
            // 
            this.kONTROLPERSONELİToolStripMenuItem.Name = "kONTROLPERSONELİToolStripMenuItem";
            this.kONTROLPERSONELİToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.kONTROLPERSONELİToolStripMenuItem.Text = "KONTROL PERSONELİ";
            this.kONTROLPERSONELİToolStripMenuItem.Click += new System.EventHandler(this.kONTROLPERSONELİToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 426);
            this.MainPanel.TabIndex = 2;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fİLETOPERSONELİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kONTROLPERSONELİToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
    }
}