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
            this.cbListGroup = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(266, 26);
            this.txtPersonelAd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(116, 20);
            this.txtPersonelAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personel Kod:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Personel Grup:";
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Location = new System.Drawing.Point(266, 62);
            this.txtPersonelSoyad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(116, 20);
            this.txtPersonelSoyad.TabIndex = 0;
            // 
            // txtPersonelKod
            // 
            this.txtPersonelKod.Location = new System.Drawing.Point(266, 96);
            this.txtPersonelKod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPersonelKod.Name = "txtPersonelKod";
            this.txtPersonelKod.Size = new System.Drawing.Size(116, 20);
            this.txtPersonelKod.TabIndex = 0;
            // 
            // cbPersonelGrup
            // 
            this.cbPersonelGrup.FormattingEnabled = true;
            this.cbPersonelGrup.Location = new System.Drawing.Point(266, 132);
            this.cbPersonelGrup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPersonelGrup.Name = "cbPersonelGrup";
            this.cbPersonelGrup.Size = new System.Drawing.Size(116, 21);
            this.cbPersonelGrup.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PersonelAd,
            this.PersSoyad,
            this.PersKod,
            this.PersGrup,
            this.PersTur,
            this.PersKartId});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(64, 259);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(627, 217);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // PersonelAd
            // 
            this.PersonelAd.Text = "Personel Ad";
            this.PersonelAd.Width = 120;
            // 
            // PersSoyad
            // 
            this.PersSoyad.Text = "Personel Soyad";
            this.PersSoyad.Width = 130;
            // 
            // PersKod
            // 
            this.PersKod.Text = "Personel Kod";
            this.PersKod.Width = 98;
            // 
            // PersGrup
            // 
            this.PersGrup.Text = "Personel Grup";
            this.PersGrup.Width = 105;
            // 
            // PersTur
            // 
            this.PersTur.Text = "Personel Tur";
            this.PersTur.Width = 98;
            // 
            // PersKartId
            // 
            this.PersKartId.Text = "Kart Id";
            this.PersKartId.Width = 100;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(401, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Location = new System.Drawing.Point(507, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Location = new System.Drawing.Point(630, 32);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kart id";
            // 
            // txtKartID
            // 
            this.txtKartID.Location = new System.Drawing.Point(266, 197);
            this.txtKartID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtKartID.Name = "txtKartID";
            this.txtKartID.Size = new System.Drawing.Size(116, 20);
            this.txtKartID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Personel Türü:";
            // 
            // cbPersonelTur
            // 
            this.cbPersonelTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPersonelTur.FormattingEnabled = true;
            this.cbPersonelTur.Location = new System.Drawing.Point(266, 165);
            this.cbPersonelTur.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPersonelTur.Name = "cbPersonelTur";
            this.cbPersonelTur.Size = new System.Drawing.Size(116, 21);
            this.cbPersonelTur.TabIndex = 3;
            // 
            // cbListGroup
            // 
            this.cbListGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListGroup.FormattingEnabled = true;
            this.cbListGroup.Location = new System.Drawing.Point(476, 177);
            this.cbListGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbListGroup.Name = "cbListGroup";
            this.cbListGroup.Size = new System.Drawing.Size(140, 21);
            this.cbListGroup.TabIndex = 8;
            this.cbListGroup.SelectedIndexChanged += new System.EventHandler(this.cbListGroup_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(448, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "PERSONEL GRUBUNU SEÇİNİZ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(512, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "LİSTELEMEK İÇİN ";
            // 
            // PersonlKayitController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbListGroup);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PersonlKayitController";
            this.Size = new System.Drawing.Size(756, 495);
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
        private System.Windows.Forms.ComboBox cbListGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
