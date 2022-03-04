namespace BalikProjesi.Panels.User
{
    partial class ControlDashboard
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
            this.ControlDashboardTLP = new System.Windows.Forms.TableLayoutPanel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.KontrolKaydiBasla = new System.Windows.Forms.Button();
            this.KontrolKayitBitir = new System.Windows.Forms.Button();
            this.ControlDashboardTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlDashboardTLP
            // 
            this.ControlDashboardTLP.ColumnCount = 3;
            this.ControlDashboardTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ControlDashboardTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ControlDashboardTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ControlDashboardTLP.Controls.Add(this.BackBtn, 0, 0);
            this.ControlDashboardTLP.Controls.Add(this.KontrolKaydiBasla, 0, 1);
            this.ControlDashboardTLP.Controls.Add(this.KontrolKayitBitir, 2, 1);
            this.ControlDashboardTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlDashboardTLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ControlDashboardTLP.Location = new System.Drawing.Point(0, 0);
            this.ControlDashboardTLP.Name = "ControlDashboardTLP";
            this.ControlDashboardTLP.RowCount = 3;
            this.ControlDashboardTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ControlDashboardTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlDashboardTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ControlDashboardTLP.Size = new System.Drawing.Size(804, 502);
            this.ControlDashboardTLP.TabIndex = 1;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.IndianRed;
            this.BackBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackBtn.Location = new System.Drawing.Point(3, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(371, 44);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "<< GERİ";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // KontrolKaydiBasla
            // 
            this.KontrolKaydiBasla.AutoSize = true;
            this.KontrolKaydiBasla.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.KontrolKaydiBasla.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.KontrolKaydiBasla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KontrolKaydiBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KontrolKaydiBasla.Location = new System.Drawing.Point(30, 80);
            this.KontrolKaydiBasla.Margin = new System.Windows.Forms.Padding(30);
            this.KontrolKaydiBasla.Name = "KontrolKaydiBasla";
            this.KontrolKaydiBasla.Size = new System.Drawing.Size(317, 342);
            this.KontrolKaydiBasla.TabIndex = 1;
            this.KontrolKaydiBasla.Text = "Kontrol Kaydı Başlat";
            this.KontrolKaydiBasla.UseVisualStyleBackColor = false;
            this.KontrolKaydiBasla.Click += new System.EventHandler(this.KontrolKaydiBasla_Click);
            // 
            // KontrolKayitBitir
            // 
            this.KontrolKayitBitir.AutoSize = true;
            this.KontrolKayitBitir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.KontrolKayitBitir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.KontrolKayitBitir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KontrolKayitBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.KontrolKayitBitir.Location = new System.Drawing.Point(457, 80);
            this.KontrolKayitBitir.Margin = new System.Windows.Forms.Padding(30);
            this.KontrolKayitBitir.Name = "KontrolKayitBitir";
            this.KontrolKayitBitir.Size = new System.Drawing.Size(317, 342);
            this.KontrolKayitBitir.TabIndex = 2;
            this.KontrolKayitBitir.Text = "Kontrol Kaydı Bitir";
            this.KontrolKayitBitir.UseVisualStyleBackColor = false;
            this.KontrolKayitBitir.Click += new System.EventHandler(this.KontrolKayitBitir_Click);
            // 
            // ControlDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ControlDashboardTLP);
            this.Name = "ControlDashboard";
            this.Size = new System.Drawing.Size(804, 502);
            this.ControlDashboardTLP.ResumeLayout(false);
            this.ControlDashboardTLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel ControlDashboardTLP;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button KontrolKaydiBasla;
        private System.Windows.Forms.Button KontrolKayitBitir;
    }
}
