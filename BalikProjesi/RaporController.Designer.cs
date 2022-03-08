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
            this.AraTLP = new System.Windows.Forms.TableLayoutPanel();
            this.PersKasaTLP = new System.Windows.Forms.TableLayoutPanel();
            this.BaslaTarLb = new System.Windows.Forms.Label();
            this.BitisTarBtn = new System.Windows.Forms.Label();
            this.PersLb = new System.Windows.Forms.Label();
            this.KasaLb = new System.Windows.Forms.Label();
            this.PersCb = new System.Windows.Forms.ComboBox();
            this.KasaCb = new System.Windows.Forms.ComboBox();
            this.BaslangicDtP = new System.Windows.Forms.DateTimePicker();
            this.BitisDtP = new System.Windows.Forms.DateTimePicker();
            this.AraBtn = new System.Windows.Forms.Button();
            this.AramaTLP = new System.Windows.Forms.TableLayoutPanel();
            this.RBGun = new System.Windows.Forms.RadioButton();
            this.RBPersonel = new System.Windows.Forms.RadioButton();
            this.RBKasa = new System.Windows.Forms.RadioButton();
            this.LbArama = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnExcel = new System.Windows.Forms.Button();
            this.AnaPanel.SuspendLayout();
            this.AraTLP.SuspendLayout();
            this.PersKasaTLP.SuspendLayout();
            this.AramaTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnaPanel
            // 
            this.AnaPanel.ColumnCount = 1;
            this.AnaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AnaPanel.Controls.Add(this.AraTLP, 0, 4);
            this.AnaPanel.Controls.Add(this.AramaTLP, 0, 2);
            this.AnaPanel.Controls.Add(this.LbArama, 0, 0);
            this.AnaPanel.Controls.Add(this.listView1, 0, 6);
            this.AnaPanel.Controls.Add(this.BtnExcel, 0, 8);
            this.AnaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnaPanel.Location = new System.Drawing.Point(0, 0);
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
            this.AnaPanel.Size = new System.Drawing.Size(732, 495);
            this.AnaPanel.TabIndex = 0;
            this.AnaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // AraTLP
            // 
            this.AraTLP.ColumnCount = 2;
            this.AraTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AraTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.AraTLP.Controls.Add(this.PersKasaTLP, 1, 0);
            this.AraTLP.Controls.Add(this.AraBtn, 0, 0);
            this.AraTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AraTLP.Location = new System.Drawing.Point(3, 131);
            this.AraTLP.Name = "AraTLP";
            this.AraTLP.RowCount = 1;
            this.AraTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AraTLP.Size = new System.Drawing.Size(726, 98);
            this.AraTLP.TabIndex = 2;
            // 
            // PersKasaTLP
            // 
            this.PersKasaTLP.ColumnCount = 8;
            this.PersKasaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PersKasaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PersKasaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.PersKasaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PersKasaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.PersKasaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PersKasaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.PersKasaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.PersKasaTLP.Controls.Add(this.BaslaTarLb, 1, 0);
            this.PersKasaTLP.Controls.Add(this.BitisTarBtn, 1, 1);
            this.PersKasaTLP.Controls.Add(this.PersLb, 5, 0);
            this.PersKasaTLP.Controls.Add(this.KasaLb, 5, 1);
            this.PersKasaTLP.Controls.Add(this.PersCb, 7, 0);
            this.PersKasaTLP.Controls.Add(this.KasaCb, 7, 1);
            this.PersKasaTLP.Controls.Add(this.BaslangicDtP, 3, 0);
            this.PersKasaTLP.Controls.Add(this.BitisDtP, 3, 1);
            this.PersKasaTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersKasaTLP.Location = new System.Drawing.Point(148, 3);
            this.PersKasaTLP.Name = "PersKasaTLP";
            this.PersKasaTLP.RowCount = 2;
            this.PersKasaTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PersKasaTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PersKasaTLP.Size = new System.Drawing.Size(575, 92);
            this.PersKasaTLP.TabIndex = 1;
            this.PersKasaTLP.VisibleChanged += new System.EventHandler(this.RBGun_CheckedChanged);
            this.PersKasaTLP.Paint += new System.Windows.Forms.PaintEventHandler(this.KontrollerTLP_Paint);
            // 
            // BaslaTarLb
            // 
            this.BaslaTarLb.AutoSize = true;
            this.BaslaTarLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaslaTarLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BaslaTarLb.Location = new System.Drawing.Point(23, 0);
            this.BaslaTarLb.Name = "BaslaTarLb";
            this.BaslaTarLb.Size = new System.Drawing.Size(117, 46);
            this.BaslaTarLb.TabIndex = 0;
            this.BaslaTarLb.Text = "Başlangıç Tarihi";
            // 
            // BitisTarBtn
            // 
            this.BitisTarBtn.AutoSize = true;
            this.BitisTarBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BitisTarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BitisTarBtn.Location = new System.Drawing.Point(23, 46);
            this.BitisTarBtn.Name = "BitisTarBtn";
            this.BitisTarBtn.Size = new System.Drawing.Size(117, 46);
            this.BitisTarBtn.TabIndex = 1;
            this.BitisTarBtn.Text = "Bitiş Tarihi";
            // 
            // PersLb
            // 
            this.PersLb.AutoSize = true;
            this.PersLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.PersLb.Location = new System.Drawing.Point(319, 0);
            this.PersLb.Name = "PersLb";
            this.PersLb.Size = new System.Drawing.Size(68, 46);
            this.PersLb.TabIndex = 2;
            this.PersLb.Text = "Personel";
            this.PersLb.Click += new System.EventHandler(this.PersLb_Click);
            // 
            // KasaLb
            // 
            this.KasaLb.AutoSize = true;
            this.KasaLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KasaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.KasaLb.Location = new System.Drawing.Point(319, 46);
            this.KasaLb.Name = "KasaLb";
            this.KasaLb.Size = new System.Drawing.Size(68, 46);
            this.KasaLb.TabIndex = 3;
            this.KasaLb.Text = "Kasa";
            // 
            // PersCb
            // 
            this.PersCb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersCb.FormattingEnabled = true;
            this.PersCb.Location = new System.Drawing.Point(403, 3);
            this.PersCb.Name = "PersCb";
            this.PersCb.Size = new System.Drawing.Size(169, 23);
            this.PersCb.TabIndex = 4;
            this.PersCb.Text = "Personel Seçiniz";
            // 
            // KasaCb
            // 
            this.KasaCb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KasaCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.KasaCb.FormattingEnabled = true;
            this.KasaCb.Location = new System.Drawing.Point(403, 49);
            this.KasaCb.Name = "KasaCb";
            this.KasaCb.Size = new System.Drawing.Size(169, 23);
            this.KasaCb.TabIndex = 5;
            this.KasaCb.Text = "Kasa Seçiniz";
            // 
            // BaslangicDtP
            // 
            this.BaslangicDtP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaslangicDtP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BaslangicDtP.Location = new System.Drawing.Point(156, 3);
            this.BaslangicDtP.Name = "BaslangicDtP";
            this.BaslangicDtP.Size = new System.Drawing.Size(117, 20);
            this.BaslangicDtP.TabIndex = 6;
            this.BaslangicDtP.ValueChanged += new System.EventHandler(this.BaslangicDtP_ValueChanged);
            // 
            // BitisDtP
            // 
            this.BitisDtP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BitisDtP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BitisDtP.Location = new System.Drawing.Point(156, 49);
            this.BitisDtP.Name = "BitisDtP";
            this.BitisDtP.Size = new System.Drawing.Size(117, 20);
            this.BitisDtP.TabIndex = 7;
            // 
            // AraBtn
            // 
            this.AraBtn.BackColor = System.Drawing.Color.Black;
            this.AraBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AraBtn.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AraBtn.ForeColor = System.Drawing.Color.White;
            this.AraBtn.Location = new System.Drawing.Point(3, 3);
            this.AraBtn.Name = "AraBtn";
            this.AraBtn.Size = new System.Drawing.Size(139, 92);
            this.AraBtn.TabIndex = 2;
            this.AraBtn.Text = "ARA";
            this.AraBtn.UseVisualStyleBackColor = false;
            this.AraBtn.Click += new System.EventHandler(this.AraBtn_Click);
            // 
            // AramaTLP
            // 
            this.AramaTLP.ColumnCount = 5;
            this.AramaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AramaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AramaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AramaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AramaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AramaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AramaTLP.Controls.Add(this.RBGun, 0, 0);
            this.AramaTLP.Controls.Add(this.RBPersonel, 2, 0);
            this.AramaTLP.Controls.Add(this.RBKasa, 4, 0);
            this.AramaTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AramaTLP.Location = new System.Drawing.Point(3, 45);
            this.AramaTLP.Name = "AramaTLP";
            this.AramaTLP.RowCount = 1;
            this.AramaTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AramaTLP.Size = new System.Drawing.Size(726, 72);
            this.AramaTLP.TabIndex = 1;
            // 
            // RBGun
            // 
            this.RBGun.AutoSize = true;
            this.RBGun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RBGun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBGun.Location = new System.Drawing.Point(3, 3);
            this.RBGun.Name = "RBGun";
            this.RBGun.Size = new System.Drawing.Size(222, 66);
            this.RBGun.TabIndex = 0;
            this.RBGun.TabStop = true;
            this.RBGun.Text = "GÜN";
            this.RBGun.UseVisualStyleBackColor = false;
            this.RBGun.CheckedChanged += new System.EventHandler(this.RBGun_CheckedChanged);
            // 
            // RBPersonel
            // 
            this.RBPersonel.AutoSize = true;
            this.RBPersonel.BackColor = System.Drawing.Color.BurlyWood;
            this.RBPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBPersonel.Location = new System.Drawing.Point(251, 3);
            this.RBPersonel.Name = "RBPersonel";
            this.RBPersonel.Size = new System.Drawing.Size(222, 66);
            this.RBPersonel.TabIndex = 1;
            this.RBPersonel.TabStop = true;
            this.RBPersonel.Text = "PERSONEL";
            this.RBPersonel.UseVisualStyleBackColor = false;
            this.RBPersonel.CheckedChanged += new System.EventHandler(this.RBPersonel_CheckedChanged);
            // 
            // RBKasa
            // 
            this.RBKasa.AutoSize = true;
            this.RBKasa.BackColor = System.Drawing.Color.IndianRed;
            this.RBKasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBKasa.Location = new System.Drawing.Point(499, 3);
            this.RBKasa.Name = "RBKasa";
            this.RBKasa.Size = new System.Drawing.Size(224, 66);
            this.RBKasa.TabIndex = 2;
            this.RBKasa.TabStop = true;
            this.RBKasa.Text = "KASA";
            this.RBKasa.UseVisualStyleBackColor = false;
            this.RBKasa.CheckedChanged += new System.EventHandler(this.RBKasa_CheckedChanged);
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
            this.LbArama.Size = new System.Drawing.Size(726, 34);
            this.LbArama.TabIndex = 0;
            this.LbArama.Text = "ARAMA";
            this.LbArama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbArama.Click += new System.EventHandler(this.LbArama_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 243);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(726, 181);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // BtnExcel
            // 
            this.BtnExcel.BackColor = System.Drawing.Color.Black;
            this.BtnExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BtnExcel.ForeColor = System.Drawing.Color.White;
            this.BtnExcel.Location = new System.Drawing.Point(3, 438);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(726, 54);
            this.BtnExcel.TabIndex = 3;
            this.BtnExcel.Text = "EXCEL\'E AKTAR";
            this.BtnExcel.UseVisualStyleBackColor = false;
            // 
            // RaporController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AnaPanel);
            this.Name = "RaporController";
            this.Size = new System.Drawing.Size(732, 495);
            this.Load += new System.EventHandler(this.RaporController_Load);
            this.AnaPanel.ResumeLayout(false);
            this.AnaPanel.PerformLayout();
            this.AraTLP.ResumeLayout(false);
            this.PersKasaTLP.ResumeLayout(false);
            this.PersKasaTLP.PerformLayout();
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
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.TableLayoutPanel PersKasaTLP;
        private System.Windows.Forms.TableLayoutPanel AraTLP;
        private System.Windows.Forms.Button AraBtn;
        private System.Windows.Forms.Label BaslaTarLb;
        private System.Windows.Forms.Label BitisTarBtn;
        private System.Windows.Forms.Label PersLb;
        private System.Windows.Forms.Label KasaLb;
        private System.Windows.Forms.ComboBox PersCb;
        private System.Windows.Forms.ComboBox KasaCb;
        private System.Windows.Forms.DateTimePicker BaslangicDtP;
        private System.Windows.Forms.DateTimePicker BitisDtP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
    }
}
