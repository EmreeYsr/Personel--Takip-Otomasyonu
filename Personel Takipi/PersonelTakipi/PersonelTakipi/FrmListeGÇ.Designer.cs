namespace PersonelTakipi
{
    partial class FrmListeGÇ
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.DtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.DgvGirisCikis = new System.Windows.Forms.DataGridView();
            this.BtnGetir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGirisCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Giriş Cıkış Listesi \r\nİçin Tarih Aralıgı Girin\r\n";
            // 
            // DtpStartDate
            // 
            this.DtpStartDate.Location = new System.Drawing.Point(27, 100);
            this.DtpStartDate.Name = "DtpStartDate";
            this.DtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.DtpStartDate.TabIndex = 1;
            // 
            // DtpEndDate
            // 
            this.DtpEndDate.Location = new System.Drawing.Point(27, 157);
            this.DtpEndDate.Name = "DtpEndDate";
            this.DtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.DtpEndDate.TabIndex = 2;
            // 
            // DgvGirisCikis
            // 
            this.DgvGirisCikis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvGirisCikis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGirisCikis.Location = new System.Drawing.Point(272, 12);
            this.DgvGirisCikis.Name = "DgvGirisCikis";
            this.DgvGirisCikis.RowHeadersWidth = 51;
            this.DgvGirisCikis.RowTemplate.Height = 24;
            this.DgvGirisCikis.Size = new System.Drawing.Size(1016, 715);
            this.DgvGirisCikis.TabIndex = 3;
            // 
            // BtnGetir
            // 
            this.BtnGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGetir.Location = new System.Drawing.Point(67, 201);
            this.BtnGetir.Name = "BtnGetir";
            this.BtnGetir.Size = new System.Drawing.Size(116, 45);
            this.BtnGetir.TabIndex = 4;
            this.BtnGetir.Text = "Liste Getir";
            this.BtnGetir.UseVisualStyleBackColor = true;
            this.BtnGetir.Click += new System.EventHandler(this.BtnGetir_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(67, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmListeGÇ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1300, 739);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnGetir);
            this.Controls.Add(this.DgvGirisCikis);
            this.Controls.Add(this.DtpEndDate);
            this.Controls.Add(this.DtpStartDate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListeGÇ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListeGÇ";
            this.Load += new System.EventHandler(this.FrmListeGÇ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGirisCikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpStartDate;
        private System.Windows.Forms.DateTimePicker DtpEndDate;
        private System.Windows.Forms.DataGridView DgvGirisCikis;
        private System.Windows.Forms.Button BtnGetir;
        private System.Windows.Forms.Button button1;
    }
}