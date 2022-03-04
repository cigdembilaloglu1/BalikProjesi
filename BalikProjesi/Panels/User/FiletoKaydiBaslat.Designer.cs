namespace BalikProjesi.Panels.User
{
    partial class FiletoKaydiBaslat
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
            this.FiletoKayitTLP = new System.Windows.Forms.TableLayoutPanel();
            this.BackBtnTLP = new System.Windows.Forms.TableLayoutPanel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.messageTLP = new System.Windows.Forms.TableLayoutPanel();
            this.FiletoKayitTLP.SuspendLayout();
            this.BackBtnTLP.SuspendLayout();
            this.messageTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen Kasa Kartını Okutunuz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FiletoKayitTLP
            // 
            this.FiletoKayitTLP.ColumnCount = 1;
            this.FiletoKayitTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FiletoKayitTLP.Controls.Add(this.BackBtnTLP, 0, 0);
            this.FiletoKayitTLP.Controls.Add(this.messageTLP, 0, 2);
            this.FiletoKayitTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiletoKayitTLP.Location = new System.Drawing.Point(0, 0);
            this.FiletoKayitTLP.Name = "FiletoKayitTLP";
            this.FiletoKayitTLP.RowCount = 4;
            this.FiletoKayitTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.FiletoKayitTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.FiletoKayitTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.FiletoKayitTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.FiletoKayitTLP.Size = new System.Drawing.Size(650, 344);
            this.FiletoKayitTLP.TabIndex = 1;
            this.FiletoKayitTLP.Paint += new System.Windows.Forms.PaintEventHandler(this.FiletoKayitTLP_Paint);
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
            this.BackBtnTLP.Size = new System.Drawing.Size(644, 44);
            this.BackBtnTLP.TabIndex = 2;
            this.BackBtnTLP.Paint += new System.Windows.Forms.PaintEventHandler(this.BackBtnTLP_Paint);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.IndianRed;
            this.BackBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.BackBtn.Location = new System.Drawing.Point(3, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(291, 38);
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
            this.messageTLP.Controls.Add(this.label1, 1, 0);
            this.messageTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageTLP.Location = new System.Drawing.Point(3, 77);
            this.messageTLP.Name = "messageTLP";
            this.messageTLP.RowCount = 1;
            this.messageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.messageTLP.Size = new System.Drawing.Size(644, 213);
            this.messageTLP.TabIndex = 3;
            this.messageTLP.Paint += new System.Windows.Forms.PaintEventHandler(this.messageTLP_Paint);
            // 
            // FiletoKaydiBaslat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FiletoKayitTLP);
            this.Name = "FiletoKaydiBaslat";
            this.Size = new System.Drawing.Size(650, 344);
            this.Load += new System.EventHandler(this.FletoKaydiBaslat_Load);
            this.FiletoKayitTLP.ResumeLayout(false);
            this.BackBtnTLP.ResumeLayout(false);
            this.messageTLP.ResumeLayout(false);
            this.messageTLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel FiletoKayitTLP;
        private System.Windows.Forms.TableLayoutPanel BackBtnTLP;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TableLayoutPanel messageTLP;
    }
}
