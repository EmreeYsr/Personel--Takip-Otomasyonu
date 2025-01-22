namespace PersonelTakipi
{
    partial class AdminPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblSoyad = new System.Windows.Forms.Label();
            this.LblAd = new System.Windows.Forms.Label();
            this.LblUnvan = new System.Windows.Forms.Label();
            this.LblDogumTarihi = new System.Windows.Forms.Label();
            this.LblDogumYeri = new System.Windows.Forms.Label();
            this.LblCinsiyet = new System.Windows.Forms.Label();
            this.LblBirim = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtDogumYeri = new System.Windows.Forms.TextBox();
            this.TxtBirim = new System.Windows.Forms.TextBox();
            this.TxtUnvan = new System.Windows.Forms.TextBox();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.DtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.BtnPersonelEkle = new System.Windows.Forms.Button();
            this.BtnPersonelSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.DgvPersonel = new System.Windows.Forms.DataGridView();
            this.DgvGirisCikis = new System.Windows.Forms.DataGridView();
            this.BtnGirisKaydet = new System.Windows.Forms.Button();
            this.BtnCikisKaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtArama = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.pDFYAZDIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfİndirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişÇıkışListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGirisCikis)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblSoyad
            // 
            this.LblSoyad.AutoSize = true;
            this.LblSoyad.Location = new System.Drawing.Point(16, 63);
            this.LblSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(50, 16);
            this.LblSoyad.TabIndex = 5;
            this.LblSoyad.Text = "Soyad:";
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Location = new System.Drawing.Point(17, 14);
            this.LblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(27, 16);
            this.LblAd.TabIndex = 4;
            this.LblAd.Text = "Ad:";
            // 
            // LblUnvan
            // 
            this.LblUnvan.AutoSize = true;
            this.LblUnvan.Location = new System.Drawing.Point(17, 224);
            this.LblUnvan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUnvan.Name = "LblUnvan";
            this.LblUnvan.Size = new System.Drawing.Size(46, 16);
            this.LblUnvan.TabIndex = 3;
            this.LblUnvan.Text = "Ünvan";
            // 
            // LblDogumTarihi
            // 
            this.LblDogumTarihi.AutoSize = true;
            this.LblDogumTarihi.Location = new System.Drawing.Point(12, 261);
            this.LblDogumTarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDogumTarihi.Name = "LblDogumTarihi";
            this.LblDogumTarihi.Size = new System.Drawing.Size(85, 16);
            this.LblDogumTarihi.TabIndex = 8;
            this.LblDogumTarihi.Text = "Dogum tarihi:";
            // 
            // LblDogumYeri
            // 
            this.LblDogumYeri.AutoSize = true;
            this.LblDogumYeri.Location = new System.Drawing.Point(18, 152);
            this.LblDogumYeri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDogumYeri.Name = "LblDogumYeri";
            this.LblDogumYeri.Size = new System.Drawing.Size(79, 16);
            this.LblDogumYeri.TabIndex = 7;
            this.LblDogumYeri.Text = "Dogum yeri:";
            // 
            // LblCinsiyet
            // 
            this.LblCinsiyet.AutoSize = true;
            this.LblCinsiyet.Location = new System.Drawing.Point(17, 106);
            this.LblCinsiyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCinsiyet.Name = "LblCinsiyet";
            this.LblCinsiyet.Size = new System.Drawing.Size(57, 16);
            this.LblCinsiyet.TabIndex = 6;
            this.LblCinsiyet.Text = "Cinsiyet:";
            // 
            // LblBirim
            // 
            this.LblBirim.AutoSize = true;
            this.LblBirim.Location = new System.Drawing.Point(18, 194);
            this.LblBirim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBirim.Name = "LblBirim";
            this.LblBirim.Size = new System.Drawing.Size(36, 16);
            this.LblBirim.TabIndex = 9;
            this.LblBirim.Text = "birim";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(101, 14);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(100, 22);
            this.TxtAd.TabIndex = 10;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(101, 60);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(100, 22);
            this.TxtSoyad.TabIndex = 11;
            // 
            // TxtDogumYeri
            // 
            this.TxtDogumYeri.Location = new System.Drawing.Point(103, 146);
            this.TxtDogumYeri.Name = "TxtDogumYeri";
            this.TxtDogumYeri.Size = new System.Drawing.Size(100, 22);
            this.TxtDogumYeri.TabIndex = 12;
            // 
            // TxtBirim
            // 
            this.TxtBirim.Location = new System.Drawing.Point(101, 188);
            this.TxtBirim.Name = "TxtBirim";
            this.TxtBirim.Size = new System.Drawing.Size(100, 22);
            this.TxtBirim.TabIndex = 13;
            // 
            // TxtUnvan
            // 
            this.TxtUnvan.Location = new System.Drawing.Point(101, 221);
            this.TxtUnvan.Name = "TxtUnvan";
            this.TxtUnvan.Size = new System.Drawing.Size(100, 22);
            this.TxtUnvan.TabIndex = 14;
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(101, 106);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(121, 24);
            this.CmbCinsiyet.TabIndex = 15;
            // 
            // DtpDogumTarihi
            // 
            this.DtpDogumTarihi.Location = new System.Drawing.Point(9, 280);
            this.DtpDogumTarihi.Name = "DtpDogumTarihi";
            this.DtpDogumTarihi.Size = new System.Drawing.Size(205, 22);
            this.DtpDogumTarihi.TabIndex = 16;
            // 
            // BtnPersonelEkle
            // 
            this.BtnPersonelEkle.Location = new System.Drawing.Point(15, 320);
            this.BtnPersonelEkle.Name = "BtnPersonelEkle";
            this.BtnPersonelEkle.Size = new System.Drawing.Size(107, 23);
            this.BtnPersonelEkle.TabIndex = 17;
            this.BtnPersonelEkle.Text = "Personel Ekle";
            this.BtnPersonelEkle.UseVisualStyleBackColor = true;
            this.BtnPersonelEkle.Click += new System.EventHandler(this.BtnPersonelEkle_Click_1);
            // 
            // BtnPersonelSil
            // 
            this.BtnPersonelSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPersonelSil.Location = new System.Drawing.Point(141, 320);
            this.BtnPersonelSil.Name = "BtnPersonelSil";
            this.BtnPersonelSil.Size = new System.Drawing.Size(132, 33);
            this.BtnPersonelSil.TabIndex = 18;
            this.BtnPersonelSil.Text = "Personel Sil";
            this.BtnPersonelSil.UseVisualStyleBackColor = true;
            this.BtnPersonelSil.Click += new System.EventHandler(this.BtnPersonelSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Location = new System.Drawing.Point(83, 359);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(101, 53);
            this.BtnGuncelle.TabIndex = 19;
            this.BtnGuncelle.Text = "Personel Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // DgvPersonel
            // 
            this.DgvPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPersonel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPersonel.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvPersonel.Location = new System.Drawing.Point(279, 40);
            this.DgvPersonel.Name = "DgvPersonel";
            this.DgvPersonel.RowHeadersWidth = 51;
            this.DgvPersonel.RowTemplate.Height = 24;
            this.DgvPersonel.Size = new System.Drawing.Size(929, 239);
            this.DgvPersonel.TabIndex = 20;
            // 
            // DgvGirisCikis
            // 
            this.DgvGirisCikis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvGirisCikis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvGirisCikis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGirisCikis.Location = new System.Drawing.Point(279, 285);
            this.DgvGirisCikis.Name = "DgvGirisCikis";
            this.DgvGirisCikis.RowHeadersWidth = 51;
            this.DgvGirisCikis.RowTemplate.Height = 24;
            this.DgvGirisCikis.Size = new System.Drawing.Size(929, 250);
            this.DgvGirisCikis.TabIndex = 21;
            // 
            // BtnGirisKaydet
            // 
            this.BtnGirisKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGirisKaydet.Location = new System.Drawing.Point(9, 428);
            this.BtnGirisKaydet.Name = "BtnGirisKaydet";
            this.BtnGirisKaydet.Size = new System.Drawing.Size(113, 36);
            this.BtnGirisKaydet.TabIndex = 22;
            this.BtnGirisKaydet.Text = "Giriş Kaydet";
            this.BtnGirisKaydet.UseVisualStyleBackColor = true;
            this.BtnGirisKaydet.Click += new System.EventHandler(this.BtnGirisKaydet_Click);
            // 
            // BtnCikisKaydet
            // 
            this.BtnCikisKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikisKaydet.Location = new System.Drawing.Point(141, 428);
            this.BtnCikisKaydet.Name = "BtnCikisKaydet";
            this.BtnCikisKaydet.Size = new System.Drawing.Size(117, 36);
            this.BtnCikisKaydet.TabIndex = 23;
            this.BtnCikisKaydet.Text = "Çıkış Kaydet";
            this.BtnCikisKaydet.UseVisualStyleBackColor = true;
            this.BtnCikisKaydet.Click += new System.EventHandler(this.BtnCikisKaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtArama);
            this.groupBox1.Controls.Add(this.BtnCikisKaydet);
            this.groupBox1.Controls.Add(this.DgvGirisCikis);
            this.groupBox1.Controls.Add(this.DgvPersonel);
            this.groupBox1.Controls.Add(this.BtnGirisKaydet);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.BtnPersonelSil);
            this.groupBox1.Controls.Add(this.BtnPersonelEkle);
            this.groupBox1.Controls.Add(this.DtpDogumTarihi);
            this.groupBox1.Controls.Add(this.CmbCinsiyet);
            this.groupBox1.Controls.Add(this.TxtUnvan);
            this.groupBox1.Controls.Add(this.TxtBirim);
            this.groupBox1.Controls.Add(this.TxtDogumYeri);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LblBirim);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LblDogumTarihi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LblDogumYeri);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LblCinsiyet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblAd);
            this.groupBox1.Controls.Add(this.LblUnvan);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1238, 562);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(83, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 36);
            this.button3.TabIndex = 28;
            this.button3.Text = "ÇIKIŞ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(276, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Personel Arama:";
            // 
            // TxtArama
            // 
            this.TxtArama.Location = new System.Drawing.Point(436, 8);
            this.TxtArama.Name = "TxtArama";
            this.TxtArama.Size = new System.Drawing.Size(223, 22);
            this.TxtArama.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(6, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Personel Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnPersonelEkle_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Birim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 261);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Dogum tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Dogum yeri:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ünvan";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFYAZDIRToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1262, 28);
            this.menuStrip2.TabIndex = 27;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // pDFYAZDIRToolStripMenuItem
            // 
            this.pDFYAZDIRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazdırToolStripMenuItem,
            this.pdfİndirToolStripMenuItem,
            this.girişÇıkışListesiToolStripMenuItem});
            this.pDFYAZDIRToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pDFYAZDIRToolStripMenuItem.Name = "pDFYAZDIRToolStripMenuItem";
            this.pDFYAZDIRToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.pDFYAZDIRToolStripMenuItem.Text = "MENÜ";
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.yazdırToolStripMenuItem.Text = "Personel Listesi ";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click);
            // 
            // pdfİndirToolStripMenuItem
            // 
            this.pdfİndirToolStripMenuItem.Name = "pdfİndirToolStripMenuItem";
            this.pdfİndirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.pdfİndirToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.pdfİndirToolStripMenuItem.Text = "Pdf indir";
            this.pdfİndirToolStripMenuItem.Click += new System.EventHandler(this.pdfİndirToolStripMenuItem_Click);
            // 
            // girişÇıkışListesiToolStripMenuItem
            // 
            this.girişÇıkışListesiToolStripMenuItem.Name = "girişÇıkışListesiToolStripMenuItem";
            this.girişÇıkışListesiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.girişÇıkışListesiToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.girişÇıkışListesiToolStripMenuItem.Text = "Giriş Çıkış Listesi ";
            this.girişÇıkışListesiToolStripMenuItem.Click += new System.EventHandler(this.girişÇıkışListesiToolStripMenuItem_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1262, 618);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGirisCikis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSoyad;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Label LblUnvan;
        private System.Windows.Forms.Label LblDogumTarihi;
        private System.Windows.Forms.Label LblDogumYeri;
        private System.Windows.Forms.Label LblCinsiyet;
        private System.Windows.Forms.Label LblBirim;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtDogumYeri;
        private System.Windows.Forms.TextBox TxtBirim;
        private System.Windows.Forms.TextBox TxtUnvan;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.DateTimePicker DtpDogumTarihi;
        private System.Windows.Forms.Button BtnPersonelEkle;
        private System.Windows.Forms.Button BtnPersonelSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.DataGridView DgvPersonel;
        private System.Windows.Forms.DataGridView DgvGirisCikis;
        private System.Windows.Forms.Button BtnGirisKaydet;
        private System.Windows.Forms.Button BtnCikisKaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtArama;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem pDFYAZDIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfİndirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişÇıkışListesiToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}