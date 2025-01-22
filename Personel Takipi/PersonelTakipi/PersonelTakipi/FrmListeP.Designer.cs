namespace PersonelTakipi
{
    partial class FrmListeP
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
            this.DgvPersonel = new System.Windows.Forms.DataGridView();
            this.Txtarama = new System.Windows.Forms.TextBox();
            this.DtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.LblBirim = new System.Windows.Forms.Label();
            this.LblDogumTarihi = new System.Windows.Forms.Label();
            this.LblDogumYeri = new System.Windows.Forms.Label();
            this.LblCinsiyet = new System.Windows.Forms.Label();
            this.LblSoyad = new System.Windows.Forms.Label();
            this.LblUnvan = new System.Windows.Forms.Label();
            this.LblAd = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.Label();
            this.cinsiyet = new System.Windows.Forms.Label();
            this.dogumyeri = new System.Windows.Forms.Label();
            this.birim = new System.Windows.Forms.Label();
            this.ünvan = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPersonel
            // 
            this.DgvPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPersonel.Location = new System.Drawing.Point(263, 12);
            this.DgvPersonel.Name = "DgvPersonel";
            this.DgvPersonel.RowHeadersWidth = 51;
            this.DgvPersonel.RowTemplate.Height = 24;
            this.DgvPersonel.Size = new System.Drawing.Size(925, 715);
            this.DgvPersonel.TabIndex = 0;
            // 
            // Txtarama
            // 
            this.Txtarama.Location = new System.Drawing.Point(37, 24);
            this.Txtarama.Name = "Txtarama";
            this.Txtarama.Size = new System.Drawing.Size(156, 22);
            this.Txtarama.TabIndex = 9;

            // 
            // DtpDogumTarihi
            // 
            this.DtpDogumTarihi.Location = new System.Drawing.Point(14, 326);
            this.DtpDogumTarihi.Name = "DtpDogumTarihi";
            this.DtpDogumTarihi.Size = new System.Drawing.Size(224, 22);
            this.DtpDogumTarihi.TabIndex = 41;
            // 
            // LblBirim
            // 
            this.LblBirim.AutoSize = true;
            this.LblBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBirim.Location = new System.Drawing.Point(15, 235);
            this.LblBirim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBirim.Name = "LblBirim";
            this.LblBirim.Size = new System.Drawing.Size(42, 16);
            this.LblBirim.TabIndex = 34;
            this.LblBirim.Text = "Birim";
            // 
            // LblDogumTarihi
            // 
            this.LblDogumTarihi.AutoSize = true;
            this.LblDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDogumTarihi.Location = new System.Drawing.Point(15, 307);
            this.LblDogumTarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDogumTarihi.Name = "LblDogumTarihi";
            this.LblDogumTarihi.Size = new System.Drawing.Size(98, 16);
            this.LblDogumTarihi.TabIndex = 33;
            this.LblDogumTarihi.Text = "Dogum tarihi:";
            // 
            // LblDogumYeri
            // 
            this.LblDogumYeri.AutoSize = true;
            this.LblDogumYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDogumYeri.Location = new System.Drawing.Point(12, 201);
            this.LblDogumYeri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDogumYeri.Name = "LblDogumYeri";
            this.LblDogumYeri.Size = new System.Drawing.Size(90, 16);
            this.LblDogumYeri.TabIndex = 32;
            this.LblDogumYeri.Text = "Dogum yeri:";
            // 
            // LblCinsiyet
            // 
            this.LblCinsiyet.AutoSize = true;
            this.LblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCinsiyet.Location = new System.Drawing.Point(14, 156);
            this.LblCinsiyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCinsiyet.Name = "LblCinsiyet";
            this.LblCinsiyet.Size = new System.Drawing.Size(66, 16);
            this.LblCinsiyet.TabIndex = 31;
            this.LblCinsiyet.Text = "Cinsiyet:";
            // 
            // LblSoyad
            // 
            this.LblSoyad.AutoSize = true;
            this.LblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSoyad.Location = new System.Drawing.Point(14, 110);
            this.LblSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(56, 16);
            this.LblSoyad.TabIndex = 30;
            this.LblSoyad.Text = "Soyad:";
            // 
            // LblUnvan
            // 
            this.LblUnvan.AutoSize = true;
            this.LblUnvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUnvan.Location = new System.Drawing.Point(14, 274);
            this.LblUnvan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUnvan.Name = "LblUnvan";
            this.LblUnvan.Size = new System.Drawing.Size(51, 16);
            this.LblUnvan.TabIndex = 28;
            this.LblUnvan.Text = "Ünvan";
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAd.Location = new System.Drawing.Point(15, 66);
            this.LblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(30, 16);
            this.LblAd.TabIndex = 42;
            this.LblAd.Text = "Ad:";
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(96, 66);
            this.ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(0, 16);
            this.ad.TabIndex = 43;
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.Location = new System.Drawing.Point(104, 110);
            this.soyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(0, 16);
            this.soyad.TabIndex = 44;
            // 
            // cinsiyet
            // 
            this.cinsiyet.AutoSize = true;
            this.cinsiyet.Location = new System.Drawing.Point(112, 156);
            this.cinsiyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(0, 16);
            this.cinsiyet.TabIndex = 45;
            // 
            // dogumyeri
            // 
            this.dogumyeri.AutoSize = true;
            this.dogumyeri.Location = new System.Drawing.Point(112, 201);
            this.dogumyeri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dogumyeri.Name = "dogumyeri";
            this.dogumyeri.Size = new System.Drawing.Size(0, 16);
            this.dogumyeri.TabIndex = 46;
            // 
            // birim
            // 
            this.birim.AutoSize = true;
            this.birim.Location = new System.Drawing.Point(112, 235);
            this.birim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birim.Name = "birim";
            this.birim.Size = new System.Drawing.Size(0, 16);
            this.birim.TabIndex = 47;
            // 
            // ünvan
            // 
            this.ünvan.AutoSize = true;
            this.ünvan.Location = new System.Drawing.Point(112, 274);
            this.ünvan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ünvan.Name = "ünvan";
            this.ünvan.Size = new System.Drawing.Size(0, 16);
            this.ünvan.TabIndex = 48;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(51, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 42);
            this.button2.TabIndex = 50;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmListeP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1200, 739);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ünvan);
            this.Controls.Add(this.birim);
            this.Controls.Add(this.dogumyeri);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.LblAd);
            this.Controls.Add(this.DtpDogumTarihi);
            this.Controls.Add(this.LblBirim);
            this.Controls.Add(this.LblDogumTarihi);
            this.Controls.Add(this.LblDogumYeri);
            this.Controls.Add(this.LblCinsiyet);
            this.Controls.Add(this.LblSoyad);
            this.Controls.Add(this.LblUnvan);
            this.Controls.Add(this.Txtarama);
            this.Controls.Add(this.DgvPersonel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListeP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListeP";
            this.Load += new System.EventHandler(this.FrmListeP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPersonel;
        private System.Windows.Forms.TextBox Txtarama;
        private System.Windows.Forms.DateTimePicker DtpDogumTarihi;
        private System.Windows.Forms.Label LblBirim;
        private System.Windows.Forms.Label LblDogumTarihi;
        private System.Windows.Forms.Label LblDogumYeri;
        private System.Windows.Forms.Label LblCinsiyet;
        private System.Windows.Forms.Label LblSoyad;
        private System.Windows.Forms.Label LblUnvan;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.Label cinsiyet;
        private System.Windows.Forms.Label dogumyeri;
        private System.Windows.Forms.Label birim;
        private System.Windows.Forms.Label ünvan;
        private System.Windows.Forms.Button button2;
    }
}