namespace BalikProjesi
{
    partial class KasaKayitController
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKasakod = new System.Windows.Forms.TextBox();
            this.txtKasatip = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKartid = new System.Windows.Forms.TextBox();
            this.KasaUUID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KasaKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KasaTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasa Kod:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "KARTINIZI OKUTUNUZ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kasa Tip:";
            // 
            // txtKasakod
            // 
            this.txtKasakod.Location = new System.Drawing.Point(108, 69);
            this.txtKasakod.Name = "txtKasakod";
            this.txtKasakod.Size = new System.Drawing.Size(100, 20);
            this.txtKasakod.TabIndex = 8;
            // 
            // txtKasatip
            // 
            this.txtKasatip.Location = new System.Drawing.Point(108, 95);
            this.txtKasatip.Name = "txtKasatip";
            this.txtKasatip.Size = new System.Drawing.Size(100, 20);
            this.txtKasatip.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KasaUUID,
            this.KasaKod,
            this.KasaTip});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(238, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(313, 176);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kasa UUID";
            // 
            // txtKartid
            // 
            this.txtKartid.Location = new System.Drawing.Point(108, 43);
            this.txtKartid.Name = "txtKartid";
            this.txtKartid.Size = new System.Drawing.Size(100, 20);
            this.txtKartid.TabIndex = 8;
            // 
            // KasaUUID
            // 
            this.KasaUUID.Text = "KasaUUID";
            // 
            // KasaKod
            // 
            this.KasaKod.Text = "KasaKod";
            // 
            // KasaTip
            // 
            this.KasaTip.Text = "Kasatip";
            // 
            // KasaKayitController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKasatip);
            this.Controls.Add(this.txtKartid);
            this.Controls.Add(this.txtKasakod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KasaKayitController";
            this.Size = new System.Drawing.Size(809, 237);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKasakod;
        private System.Windows.Forms.TextBox txtKasatip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKartid;
        private System.Windows.Forms.ColumnHeader KasaUUID;
        private System.Windows.Forms.ColumnHeader KasaKod;
        private System.Windows.Forms.ColumnHeader KasaTip;
    }
}
