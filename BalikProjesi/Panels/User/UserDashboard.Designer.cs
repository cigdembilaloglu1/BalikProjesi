namespace BalikProjesi.Panels.User
{
    partial class UserDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DashboardPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FletoPanelBtn = new System.Windows.Forms.Button();
            this.KontrolBtn = new System.Windows.Forms.Button();
            this.DashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.ColumnCount = 3;
            this.DashboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DashboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.DashboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DashboardPanel.Controls.Add(this.FletoPanelBtn, 0, 0);
            this.DashboardPanel.Controls.Add(this.KontrolBtn, 2, 0);
            this.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.RowCount = 1;
            this.DashboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DashboardPanel.Size = new System.Drawing.Size(1254, 603);
            this.DashboardPanel.TabIndex = 0;
            // 
            // FletoPanelBtn
            // 
            this.FletoPanelBtn.AutoSize = true;
            this.FletoPanelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FletoPanelBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FletoPanelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FletoPanelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FletoPanelBtn.ForeColor = System.Drawing.Color.White;
            this.FletoPanelBtn.Location = new System.Drawing.Point(3, 3);
            this.FletoPanelBtn.Name = "FletoPanelBtn";
            this.FletoPanelBtn.Size = new System.Drawing.Size(596, 597);
            this.FletoPanelBtn.TabIndex = 0;
            this.FletoPanelBtn.Text = "FİLETO";
            this.FletoPanelBtn.UseVisualStyleBackColor = false;
            this.FletoPanelBtn.Click += new System.EventHandler(this.FletoPanelBtn_Click);
            // 
            // KontrolBtn
            // 
            this.KontrolBtn.AutoSize = true;
            this.KontrolBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.KontrolBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.KontrolBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KontrolBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.KontrolBtn.ForeColor = System.Drawing.Color.White;
            this.KontrolBtn.Location = new System.Drawing.Point(655, 3);
            this.KontrolBtn.Name = "KontrolBtn";
            this.KontrolBtn.Size = new System.Drawing.Size(596, 597);
            this.KontrolBtn.TabIndex = 1;
            this.KontrolBtn.Text = "KONTROL";
            this.KontrolBtn.UseVisualStyleBackColor = false;
            this.KontrolBtn.Click += new System.EventHandler(this.KontrolBtn_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DashboardPanel);
            this.Name = "UserDashboard";
            this.Size = new System.Drawing.Size(1254, 603);
            this.DashboardPanel.ResumeLayout(false);
            this.DashboardPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel DashboardPanel;
        private System.Windows.Forms.Button FletoPanelBtn;
        private System.Windows.Forms.Button KontrolBtn;
    }
}
