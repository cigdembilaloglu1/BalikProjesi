namespace BalikProjesi.Panels.User
{
    partial class FiletoDashboard
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
            this.FiletoDashboardTLP = new System.Windows.Forms.TableLayoutPanel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.FiletoKaydiBasla = new System.Windows.Forms.Button();
            this.FiletoKayitBitir = new System.Windows.Forms.Button();
            this.FiletoDashboardTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiletoDashboardTLP
            // 
            this.FiletoDashboardTLP.ColumnCount = 3;
            this.FiletoDashboardTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FiletoDashboardTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.FiletoDashboardTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FiletoDashboardTLP.Controls.Add(this.BackBtn, 0, 0);
            this.FiletoDashboardTLP.Controls.Add(this.FiletoKaydiBasla, 0, 1);
            this.FiletoDashboardTLP.Controls.Add(this.FiletoKayitBitir, 2, 1);
            this.FiletoDashboardTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiletoDashboardTLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FiletoDashboardTLP.Location = new System.Drawing.Point(0, 0);
            this.FiletoDashboardTLP.Name = "FiletoDashboardTLP";
            this.FiletoDashboardTLP.RowCount = 3;
            this.FiletoDashboardTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.FiletoDashboardTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FiletoDashboardTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.FiletoDashboardTLP.Size = new System.Drawing.Size(1013, 586);
            this.FiletoDashboardTLP.TabIndex = 0;
            this.FiletoDashboardTLP.Paint += new System.Windows.Forms.PaintEventHandler(this.FiletoDashboardTLP_Paint);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.IndianRed;
            this.BackBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackBtn.Location = new System.Drawing.Point(3, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(475, 44);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "<< GERİ";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // FiletoKaydiBasla
            // 
            this.FiletoKaydiBasla.AutoSize = true;
            this.FiletoKaydiBasla.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FiletoKaydiBasla.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FiletoKaydiBasla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiletoKaydiBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.FiletoKaydiBasla.ForeColor = System.Drawing.Color.White;
            this.FiletoKaydiBasla.Location = new System.Drawing.Point(30, 80);
            this.FiletoKaydiBasla.Margin = new System.Windows.Forms.Padding(30);
            this.FiletoKaydiBasla.Name = "FiletoKaydiBasla";
            this.FiletoKaydiBasla.Size = new System.Drawing.Size(421, 426);
            this.FiletoKaydiBasla.TabIndex = 1;
            this.FiletoKaydiBasla.Text = "Fileto Kaydı Başlat";
            this.FiletoKaydiBasla.UseVisualStyleBackColor = false;
            this.FiletoKaydiBasla.Click += new System.EventHandler(this.FiletoKaydiBasla_Click);
            // 
            // FiletoKayitBitir
            // 
            this.FiletoKayitBitir.AutoSize = true;
            this.FiletoKayitBitir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FiletoKayitBitir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FiletoKayitBitir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiletoKayitBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.FiletoKayitBitir.ForeColor = System.Drawing.Color.White;
            this.FiletoKayitBitir.Location = new System.Drawing.Point(561, 80);
            this.FiletoKayitBitir.Margin = new System.Windows.Forms.Padding(30);
            this.FiletoKayitBitir.Name = "FiletoKayitBitir";
            this.FiletoKayitBitir.Size = new System.Drawing.Size(422, 426);
            this.FiletoKayitBitir.TabIndex = 2;
            this.FiletoKayitBitir.Text = "Fileto Kaydı Bitir";
            this.FiletoKayitBitir.UseVisualStyleBackColor = false;
            this.FiletoKayitBitir.Click += new System.EventHandler(this.FiletoKayitBitir_Click);
            // 
            // FiletoDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FiletoDashboardTLP);
            this.Name = "FiletoDashboard";
            this.Size = new System.Drawing.Size(1013, 586);
            this.FiletoDashboardTLP.ResumeLayout(false);
            this.FiletoDashboardTLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel FiletoDashboardTLP;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button FiletoKaydiBasla;
        private System.Windows.Forms.Button FiletoKayitBitir;
    }
}
