﻿namespace BalikProjesi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKasakod = new System.Windows.Forms.TextBox();
            this.txtKasatip = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.KasaUUID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KasaKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KasaTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txtKartid = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCardRead = new System.Windows.Forms.Button();
            this.KasaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasa Kod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kasa Tip:";
            // 
            // txtKasakod
            // 
            this.txtKasakod.Location = new System.Drawing.Point(108, 87);
            this.txtKasakod.Name = "txtKasakod";
            this.txtKasakod.Size = new System.Drawing.Size(100, 20);
            this.txtKasakod.TabIndex = 8;
            // 
            // txtKasatip
            // 
            this.txtKasatip.Location = new System.Drawing.Point(108, 113);
            this.txtKasatip.Name = "txtKasatip";
            this.txtKasatip.Size = new System.Drawing.Size(100, 20);
            this.txtKasatip.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KasaKod,
            this.KasaTip,
            this.KasaUUID,
            this.KasaID});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(55, 194);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(596, 327);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // KasaUUID
            // 
            this.KasaUUID.Text = "KASA KARTI KODU";
            this.KasaUUID.Width = 120;
            // 
            // KasaKod
            // 
            this.KasaKod.Text = "KASA KODU";
            this.KasaKod.Width = 90;
            // 
            // KasaTip
            // 
            this.KasaTip.Text = "KASA TİPİ";
            this.KasaTip.Width = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kart Kodu";
            // 
            // txtKartid
            // 
            this.txtKartid.Location = new System.Drawing.Point(108, 61);
            this.txtKartid.Name = "txtKartid";
            this.txtKartid.Size = new System.Drawing.Size(100, 20);
            this.txtKartid.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(55, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "KAYDET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCardRead
            // 
            this.btnCardRead.Location = new System.Drawing.Point(225, 59);
            this.btnCardRead.Name = "btnCardRead";
            this.btnCardRead.Size = new System.Drawing.Size(75, 23);
            this.btnCardRead.TabIndex = 13;
            this.btnCardRead.Text = "Kart Oku";
            this.btnCardRead.UseVisualStyleBackColor = true;
            this.btnCardRead.Click += new System.EventHandler(this.btnCardRead_Click);
            // 
            // KasaID
            // 
            this.KasaID.Text = "KasaID";
            this.KasaID.Width = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "GÜNCELLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(90, 26);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(180, 22);
            this.Delete.Text = "SİL";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // KasaKayitController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCardRead);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtKasatip);
            this.Controls.Add(this.txtKartid);
            this.Controls.Add(this.txtKasakod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KasaKayitController";
            this.Size = new System.Drawing.Size(1133, 579);
            this.Load += new System.EventHandler(this.KasaKayitController_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKasakod;
        private System.Windows.Forms.TextBox txtKasatip;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKartid;
        private System.Windows.Forms.ColumnHeader KasaUUID;
        private System.Windows.Forms.ColumnHeader KasaKod;
        private System.Windows.Forms.ColumnHeader KasaTip;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCardRead;
        private System.Windows.Forms.ColumnHeader KasaID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Delete;
    }
}
