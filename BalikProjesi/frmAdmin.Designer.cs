namespace BalikProjesi
{
    partial class frmAdmin
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
            this.kAYITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kARTKAYDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERSONELKAYDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kASAKAYDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAPORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kAYITToolStripMenuItem,
            this.rAPORToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "adminMenu";
            // 
            // kAYITToolStripMenuItem
            // 
            this.kAYITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kARTKAYDIToolStripMenuItem,
            this.pERSONELKAYDIToolStripMenuItem,
            this.kASAKAYDIToolStripMenuItem});
            this.kAYITToolStripMenuItem.Name = "kAYITToolStripMenuItem";
            this.kAYITToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.kAYITToolStripMenuItem.Text = "KAYIT";
            // 
            // kARTKAYDIToolStripMenuItem
            // 
            this.kARTKAYDIToolStripMenuItem.Name = "kARTKAYDIToolStripMenuItem";
            this.kARTKAYDIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kARTKAYDIToolStripMenuItem.Text = "KART KAYDI";
            this.kARTKAYDIToolStripMenuItem.Click += new System.EventHandler(this.kARTKAYDIToolStripMenuItem_Click);
            // 
            // pERSONELKAYDIToolStripMenuItem
            // 
            this.pERSONELKAYDIToolStripMenuItem.Name = "pERSONELKAYDIToolStripMenuItem";
            this.pERSONELKAYDIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pERSONELKAYDIToolStripMenuItem.Text = "PERSONEL KAYDI";
            this.pERSONELKAYDIToolStripMenuItem.Click += new System.EventHandler(this.pERSONELKAYDIToolStripMenuItem_Click);
            // 
            // kASAKAYDIToolStripMenuItem
            // 
            this.kASAKAYDIToolStripMenuItem.Name = "kASAKAYDIToolStripMenuItem";
            this.kASAKAYDIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kASAKAYDIToolStripMenuItem.Text = "KASA KAYDI";
            this.kASAKAYDIToolStripMenuItem.Click += new System.EventHandler(this.kASAKAYDIToolStripMenuItem_Click);
            // 
            // rAPORToolStripMenuItem
            // 
            this.rAPORToolStripMenuItem.Name = "rAPORToolStripMenuItem";
            this.rAPORToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.rAPORToolStripMenuItem.Text = "RAPOR";
            this.rAPORToolStripMenuItem.Click += new System.EventHandler(this.rAPORToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 426);
            this.MainPanel.TabIndex = 1;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmAdmin";
            this.Text = "ADMİN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kapat);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kAYITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kARTKAYDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERSONELKAYDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kASAKAYDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAPORToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
    }
}