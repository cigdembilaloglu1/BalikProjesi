namespace BalikProjesi.Panels.User
{
    partial class FiletoKaydiBitir
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
            this.FiletoKayitBitirTLP = new System.Windows.Forms.TableLayoutPanel();
            this.BackBtnTLP = new System.Windows.Forms.TableLayoutPanel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.messageTLP = new System.Windows.Forms.TableLayoutPanel();
            this.MessageLb = new System.Windows.Forms.Label();
            this.FiletoKayitBitirTLP.SuspendLayout();
            this.BackBtnTLP.SuspendLayout();
            this.messageTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiletoKayitBitirTLP
            // 
            this.FiletoKayitBitirTLP.ColumnCount = 1;
            this.FiletoKayitBitirTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FiletoKayitBitirTLP.Controls.Add(this.BackBtnTLP, 0, 0);
            this.FiletoKayitBitirTLP.Controls.Add(this.messageTLP, 0, 2);
            this.FiletoKayitBitirTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiletoKayitBitirTLP.Location = new System.Drawing.Point(0, 0);
            this.FiletoKayitBitirTLP.Name = "FiletoKayitBitirTLP";
            this.FiletoKayitBitirTLP.RowCount = 4;
            this.FiletoKayitBitirTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.FiletoKayitBitirTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.FiletoKayitBitirTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.FiletoKayitBitirTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.FiletoKayitBitirTLP.Size = new System.Drawing.Size(645, 425);
            this.FiletoKayitBitirTLP.TabIndex = 2;
            // 
            // BackBtnTLP
            // 
            this.BackBtnTLP.ColumnCount = 3;
            this.BackBtnTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BackBtnTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.BackBtnTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BackBtnTLP.Controls.Add(this.BackBtn, 0, 0);
            this.BackBtnTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackBtnTLP.Location = new System.Drawing.Point(3, 3);
            this.BackBtnTLP.Name = "BackBtnTLP";
            this.BackBtnTLP.RowCount = 1;
            this.BackBtnTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BackBtnTLP.Size = new System.Drawing.Size(639, 44);
            this.BackBtnTLP.TabIndex = 2;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.IndianRed;
            this.BackBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.BackBtn.Location = new System.Drawing.Point(3, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(288, 38);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "<< GERİ";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // messageTLP
            // 
            this.messageTLP.ColumnCount = 3;
            this.messageTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.messageTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messageTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.messageTLP.Controls.Add(this.MessageLb, 1, 0);
            this.messageTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTLP.Location = new System.Drawing.Point(3, 85);
            this.messageTLP.Name = "messageTLP";
            this.messageTLP.RowCount = 1;
            this.messageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messageTLP.Size = new System.Drawing.Size(639, 286);
            this.messageTLP.TabIndex = 3;
            // 
            // MessageLb
            // 
            this.MessageLb.AutoSize = true;
            this.MessageLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MessageLb.Location = new System.Drawing.Point(53, 0);
            this.MessageLb.Name = "MessageLb";
            this.MessageLb.Size = new System.Drawing.Size(463, 37);
            this.MessageLb.TabIndex = 0;
            this.MessageLb.Text = "Lütfen Kasa Kartını Okutunuz";
            // 
            // FiletoKaydiBitir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FiletoKayitBitirTLP);
            this.Name = "FiletoKaydiBitir";
            this.Size = new System.Drawing.Size(645, 425);
            this.FiletoKayitBitirTLP.ResumeLayout(false);
            this.BackBtnTLP.ResumeLayout(false);
            this.messageTLP.ResumeLayout(false);
            this.messageTLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FiletoKayitBitirTLP;
        private System.Windows.Forms.TableLayoutPanel BackBtnTLP;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TableLayoutPanel messageTLP;
        private System.Windows.Forms.Label MessageLb;
    }
}
