namespace BalikProjesi
{
    partial class RaporController
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
            this.AnaPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LbArama = new System.Windows.Forms.Label();
            this.AramaTLP = new System.Windows.Forms.TableLayoutPanel();
            this.RBGun = new System.Windows.Forms.RadioButton();
            this.RBPersonel = new System.Windows.Forms.RadioButton();
            this.RBKasa = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.PersAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersGorev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KasaKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BıcakDefo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KılcıkDefo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HasatDefo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnExcel = new System.Windows.Forms.Button();
            this.KontrollerTLP = new System.Windows.Forms.TableLayoutPanel();
            this.AnaPanel.SuspendLayout();
            this.AramaTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnaPanel
            // 
            this.AnaPanel.ColumnCount = 1;
            this.AnaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AnaPanel.Controls.Add(this.AramaTLP, 0, 2);
            this.AnaPanel.Controls.Add(this.LbArama, 0, 0);
            this.AnaPanel.Controls.Add(this.listView1, 0, 6);
            this.AnaPanel.Controls.Add(this.BtnExcel, 0, 8);
            this.AnaPanel.Controls.Add(this.KontrollerTLP, 0, 4);
            this.AnaPanel.Location = new System.Drawing.Point(27, 21);
            this.AnaPanel.Name = "AnaPanel";
            this.AnaPanel.RowCount = 9;
            this.AnaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.54717F));
            this.AnaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.AnaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.98113F));
            this.AnaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.AnaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.64151F));
            this.AnaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.AnaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.56604F));
            this.AnaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.AnaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.26415F));
            this.AnaPanel.Size = new System.Drawing.Size(485, 369);
            this.AnaPanel.TabIndex = 0;
            this.AnaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // LbArama
            // 
            this.LbArama.AutoSize = true;
            this.LbArama.BackColor = System.Drawing.Color.DimGray;
            this.LbArama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbArama.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold);
            this.LbArama.ForeColor = System.Drawing.Color.White;
            this.LbArama.Location = new System.Drawing.Point(3, 0);
            this.LbArama.Name = "LbArama";
            this.LbArama.Size = new System.Drawing.Size(479, 25);
            this.LbArama.TabIndex = 0;
            this.LbArama.Text = "ARAMA";
            this.LbArama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AramaTLP
            // 
            this.AramaTLP.ColumnCount = 6;
            this.AramaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AramaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AramaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AramaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AramaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AramaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AramaTLP.Controls.Add(this.RBGun, 1, 0);
            this.AramaTLP.Controls.Add(this.RBPersonel, 3, 0);
            this.AramaTLP.Controls.Add(this.RBKasa, 5, 0);
            this.AramaTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AramaTLP.Location = new System.Drawing.Point(3, 36);
            this.AramaTLP.Name = "AramaTLP";
            this.AramaTLP.RowCount = 1;
            this.AramaTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AramaTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AramaTLP.Size = new System.Drawing.Size(479, 51);
            this.AramaTLP.TabIndex = 1;
            // 
            // RBGun
            // 
            this.RBGun.AutoSize = true;
            this.RBGun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RBGun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBGun.Location = new System.Drawing.Point(23, 3);
            this.RBGun.Name = "RBGun";
            this.RBGun.Size = new System.Drawing.Size(133, 45);
            this.RBGun.TabIndex = 0;
            this.RBGun.TabStop = true;
            this.RBGun.Text = "GÜN";
            this.RBGun.UseVisualStyleBackColor = false;
            // 
            // RBPersonel
            // 
            this.RBPersonel.AutoSize = true;
            this.RBPersonel.BackColor = System.Drawing.Color.BurlyWood;
            this.RBPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBPersonel.Location = new System.Drawing.Point(182, 3);
            this.RBPersonel.Name = "RBPersonel";
            this.RBPersonel.Size = new System.Drawing.Size(133, 45);
            this.RBPersonel.TabIndex = 1;
            this.RBPersonel.TabStop = true;
            this.RBPersonel.Text = "PERSONEL";
            this.RBPersonel.UseVisualStyleBackColor = false;
            // 
            // RBKasa
            // 
            this.RBKasa.AutoSize = true;
            this.RBKasa.BackColor = System.Drawing.Color.IndianRed;
            this.RBKasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBKasa.Location = new System.Drawing.Point(341, 3);
            this.RBKasa.Name = "RBKasa";
            this.RBKasa.Size = new System.Drawing.Size(135, 45);
            this.RBKasa.TabIndex = 2;
            this.RBKasa.TabStop = true;
            this.RBKasa.Text = "KASA";
            this.RBKasa.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PersAd,
            this.PersSoyad,
            this.PersGorev,
            this.KasaKod,
            this.BıcakDefo,
            this.KılcıkDefo,
            this.HasatDefo,
            this.Diger});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 185);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(479, 130);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // PersAd
            // 
            this.PersAd.Text = "Personel Ad";
            this.PersAd.Width = 90;
            // 
            // PersSoyad
            // 
            this.PersSoyad.Text = "Personel Soyad";
            this.PersSoyad.Width = 110;
            // 
            // PersGorev
            // 
            this.PersGorev.Text = "GÖREV";
            this.PersGorev.Width = 80;
            // 
            // KasaKod
            // 
            this.KasaKod.Text = "Kasa Kod";
            // 
            // BıcakDefo
            // 
            this.BıcakDefo.Text = "Bıçak Defo";
            this.BıcakDefo.Width = 70;
            // 
            // KılcıkDefo
            // 
            this.KılcıkDefo.Text = "Kılçık Defo";
            this.KılcıkDefo.Width = 71;
            // 
            // HasatDefo
            // 
            this.HasatDefo.Text = "Hasat Defo";
            this.HasatDefo.Width = 72;
            // 
            // Diger
            // 
            this.Diger.Text = "Diğer";
            this.Diger.Width = 73;
            // 
            // BtnExcel
            // 
            this.BtnExcel.BackColor = System.Drawing.Color.Black;
            this.BtnExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BtnExcel.ForeColor = System.Drawing.Color.White;
            this.BtnExcel.Location = new System.Drawing.Point(3, 329);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(479, 37);
            this.BtnExcel.TabIndex = 3;
            this.BtnExcel.Text = "EXCEL\'E AKTAR";
            this.BtnExcel.UseVisualStyleBackColor = false;
            // 
            // KontrollerTLP
            // 
            this.KontrollerTLP.ColumnCount = 1;
            this.KontrollerTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.KontrollerTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KontrollerTLP.Location = new System.Drawing.Point(3, 101);
            this.KontrollerTLP.Name = "KontrollerTLP";
            this.KontrollerTLP.RowCount = 1;
            this.KontrollerTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.KontrollerTLP.Size = new System.Drawing.Size(479, 70);
            this.KontrollerTLP.TabIndex = 1;
            // 
            // RaporController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AnaPanel);
            this.Name = "RaporController";
            this.Size = new System.Drawing.Size(732, 495);
            this.AnaPanel.ResumeLayout(false);
            this.AnaPanel.PerformLayout();
            this.AramaTLP.ResumeLayout(false);
            this.AramaTLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AnaPanel;
        private System.Windows.Forms.Label LbArama;
        private System.Windows.Forms.TableLayoutPanel AramaTLP;
        private System.Windows.Forms.RadioButton RBGun;
        private System.Windows.Forms.RadioButton RBPersonel;
        private System.Windows.Forms.RadioButton RBKasa;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PersAd;
        private System.Windows.Forms.ColumnHeader PersSoyad;
        private System.Windows.Forms.ColumnHeader PersGorev;
        private System.Windows.Forms.ColumnHeader KasaKod;
        private System.Windows.Forms.ColumnHeader BıcakDefo;
        private System.Windows.Forms.ColumnHeader KılcıkDefo;
        private System.Windows.Forms.ColumnHeader HasatDefo;
        private System.Windows.Forms.ColumnHeader Diger;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.TableLayoutPanel KontrollerTLP;
    }
}
