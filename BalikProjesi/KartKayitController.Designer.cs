namespace BalikProjesi
{
    partial class KartKayitController
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KartNameTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KartKoduTb = new System.Windows.Forms.TextBox();
            this.KartTipiTb = new System.Windows.Forms.TextBox();
            this.KartUUDTb = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.KartAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KartKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KartTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KartUUID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kart Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kart Kodu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kart Tipi";
            // 
            // KartNameTxt
            // 
            this.KartNameTxt.Location = new System.Drawing.Point(135, 54);
            this.KartNameTxt.Name = "KartNameTxt";
            this.KartNameTxt.Size = new System.Drawing.Size(100, 20);
            this.KartNameTxt.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(84, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(45, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "KARTINIZI OKUTUNUZ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "KART UUID";
            // 
            // KartKoduTb
            // 
            this.KartKoduTb.Location = new System.Drawing.Point(135, 82);
            this.KartKoduTb.Name = "KartKoduTb";
            this.KartKoduTb.Size = new System.Drawing.Size(100, 20);
            this.KartKoduTb.TabIndex = 9;
            // 
            // KartTipiTb
            // 
            this.KartTipiTb.Location = new System.Drawing.Point(135, 115);
            this.KartTipiTb.Name = "KartTipiTb";
            this.KartTipiTb.Size = new System.Drawing.Size(100, 20);
            this.KartTipiTb.TabIndex = 10;
            // 
            // KartUUDTb
            // 
            this.KartUUDTb.Location = new System.Drawing.Point(135, 148);
            this.KartUUDTb.Name = "KartUUDTb";
            this.KartUUDTb.Size = new System.Drawing.Size(100, 20);
            this.KartUUDTb.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KartAd,
            this.KartKod,
            this.KartTip,
            this.KartUUID});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(298, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(431, 221);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // KartAd
            // 
            this.KartAd.Text = "Kart Ad";
            this.KartAd.Width = 90;
            // 
            // KartKod
            // 
            this.KartKod.Text = "Kart Kod";
            this.KartKod.Width = 92;
            // 
            // KartTip
            // 
            this.KartTip.Text = "Kart Tip";
            this.KartTip.Width = 95;
            // 
            // KartUUID
            // 
            this.KartUUID.Text = "KartUUID";
            this.KartUUID.Width = 150;
            // 
            // KartKayitController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.KartUUDTb);
            this.Controls.Add(this.KartTipiTb);
            this.Controls.Add(this.KartKoduTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KartNameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "KartKayitController";
            this.Size = new System.Drawing.Size(748, 282);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox KartNameTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KartKoduTb;
        private System.Windows.Forms.TextBox KartTipiTb;
        private System.Windows.Forms.TextBox KartUUDTb;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader KartAd;
        private System.Windows.Forms.ColumnHeader KartKod;
        private System.Windows.Forms.ColumnHeader KartTip;
        private System.Windows.Forms.ColumnHeader KartUUID;
    }
}
