namespace BalikProjesi
{
    partial class PersonlKayitController
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
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.txtPersonelKod = new System.Windows.Forms.TextBox();
            this.cbPersonelGrup = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.PersonelAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersGrup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersTur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PersKartId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKartID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPersonelTur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(275, 40);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personel Kod:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Personel Grup:";
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Location = new System.Drawing.Point(275, 76);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelSoyad.TabIndex = 0;
            // 
            // txtPersonelKod
            // 
            this.txtPersonelKod.Location = new System.Drawing.Point(275, 110);
            this.txtPersonelKod.Name = "txtPersonelKod";
            this.txtPersonelKod.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelKod.TabIndex = 0;
            // 
            // cbPersonelGrup
            // 
            this.cbPersonelGrup.FormattingEnabled = true;
            this.cbPersonelGrup.Location = new System.Drawing.Point(275, 146);
            this.cbPersonelGrup.Name = "cbPersonelGrup";
            this.cbPersonelGrup.Size = new System.Drawing.Size(100, 21);
            this.cbPersonelGrup.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PersonelAd,
            this.PersSoyad,
            this.PersKod,
            this.PersGrup,
            this.PersTur,
            this.PersKartId});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(55, 259);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(531, 217);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // PersonelAd
            // 
            this.PersonelAd.Text = "Personel Ad";
            this.PersonelAd.Width = 71;
            // 
            // PersSoyad
            // 
            this.PersSoyad.Text = "Personel Soyad";
            this.PersSoyad.Width = 90;
            // 
            // PersKod
            // 
            this.PersKod.Text = "PersonelKod";
            this.PersKod.Width = 80;
            // 
            // PersGrup
            // 
            this.PersGrup.Text = "Personel Grup";
            this.PersGrup.Width = 95;
            // 
            // PersTur
            // 
            this.PersTur.Text = "Personel Tur";
            this.PersTur.Width = 98;
            // 
            // PersKartId
            // 
            this.PersKartId.Text = "Kart Id";
            this.PersKartId.Width = 92;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(431, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kart id";
            // 
            // txtKartID
            // 
            this.txtKartID.Location = new System.Drawing.Point(275, 211);
            this.txtKartID.Name = "txtKartID";
            this.txtKartID.Size = new System.Drawing.Size(100, 20);
            this.txtKartID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Personel Türü:";
            // 
            // cbPersonelTur
            // 
            this.cbPersonelTur.FormattingEnabled = true;
            this.cbPersonelTur.Location = new System.Drawing.Point(275, 179);
            this.cbPersonelTur.Name = "cbPersonelTur";
            this.cbPersonelTur.Size = new System.Drawing.Size(100, 21);
            this.cbPersonelTur.TabIndex = 3;
            // 
            // PersonlKayitController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtKartID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cbPersonelTur);
            this.Controls.Add(this.cbPersonelGrup);
            this.Controls.Add(this.txtPersonelKod);
            this.Controls.Add(this.txtPersonelSoyad);
            this.Controls.Add(this.txtPersonelAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonlKayitController";
            this.Size = new System.Drawing.Size(620, 479);
            this.Load += new System.EventHandler(this.PersonlKayitController_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.TextBox txtPersonelKod;
        private System.Windows.Forms.ComboBox cbPersonelGrup;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKartID;
        public System.Windows.Forms.ColumnHeader PersonelAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPersonelTur;
        private System.Windows.Forms.ColumnHeader PersSoyad;
        private System.Windows.Forms.ColumnHeader PersKod;
        private System.Windows.Forms.ColumnHeader PersGrup;
        private System.Windows.Forms.ColumnHeader PersTur;
        private System.Windows.Forms.ColumnHeader PersKartId;
    }
}
