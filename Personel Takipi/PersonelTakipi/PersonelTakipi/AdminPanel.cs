using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace PersonelTakipi
{
    public partial class AdminPanel : Form
    {
        //Initial Catalog: Kullanılacak veritabanı tablosu.
        string connectionString = $"Data Source=(local);Initial Catalog=Personel;User ID=sa;Password=1;";
        //string connectionString = "Data Source=LAPTOP-HDVV2N4C\\SQLEXPRESS;Initial Catalog=GorselProg;Integrated Security=True;";
        public AdminPanel()
        {
            InitializeComponent();
            DgvPersonel.CellClick += DgvPersonel_CellClick;
            TxtArama.TextChanged += TxtArama_TextChanged;
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            PersonelListesiGetir();
            GirisCikisListesiGetir(); // Giriş/Çıkış listesini de yükleyin

        }
        #region   Perssoneli txtboxa aktarma
        private void DgvPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Geçersiz satır tıklamalarını yoksay

            DataGridViewRow row = DgvPersonel.Rows[e.RowIndex];

            // Textboxlara bilgileri aktar
            TxtAd.Text = row.Cells["Ad"].Value?.ToString();
            TxtSoyad.Text = row.Cells["Soyad"].Value?.ToString();
            TxtDogumYeri.Text = row.Cells["Doğum Yeri"].Value?.ToString();
            TxtBirim.Text = row.Cells["Birim"].Value?.ToString();
            TxtUnvan.Text = row.Cells["Ünvan"].Value?.ToString();
            CmbCinsiyet.SelectedItem = row.Cells["Cinsiyet"].Value?.ToString();

            // Doğum tarihini DateTimePicker'a yazdır
            if (DateTime.TryParse(row.Cells["Doğum Tarihi"].Value?.ToString(), out DateTime dogumTarihi))
            {
                DtpDogumTarihi.Value = dogumTarihi;
            }
        }
        #endregion

        #region Arama yapma,Personel Listesi ve Giriş cıkış DATAGRİDVİEW
        private void TxtArama_TextChanged(object sender, EventArgs e)
        {
            //ARAMA YAPMAK İÇİN KOD AYNI YOLU BURAYADA YAZDIK 

            string sql = "SELECT p_no AS [Personel No], p_ad AS [Ad], p_soyad AS [Soyad], cinsiyet AS [Cinsiyet], dogum_tarihi AS [Doğum Tarihi]," +
                " dogum_yeri AS [Doğum Yeri], birim AS [Birim], unvan AS [Ünvan] FROM Personel WHERE p_ad LIKE @arama OR p_soyad LIKE @arama";
            SqlParameter[] param = { new SqlParameter("@arama", "%" + TxtArama.Text + "%") };
            DgvPersonel.DataSource = GetDataTable(sql, param);  

        }

        private void PersonelListesiGetir()
        {
            //dataya aktarma
            string sql = "SELECT p_no AS [Personel No], p_ad AS [Ad], p_soyad AS [Soyad], cinsiyet AS [Cinsiyet], " +
                         "dogum_tarihi AS [Doğum Tarihi], dogum_yeri AS [Doğum Yeri], birim AS [Birim], unvan AS [Ünvan] " +
                         "FROM Personel";
            DgvPersonel.DataSource = GetDataTable(sql);
        }
        private void GirisCikisListesiGetir()
        {
            // SQL'den veriyi çekiyoruz
            string sqlGirisCikis = "SELECT kayit_no AS [Kayıt No], p_no AS [Personel No], giris_saati AS [Giriş Saati], " +
                                   "cikis_saati AS [Çıkış Saati], durum AS [Durum] FROM GirisCikisKayit";
            DgvGirisCikis.DataSource = GetDataTable(sqlGirisCikis); // DataGridView'e veri atıyoruz
        }


        private DataTable GetDataTable(string sql, SqlParameter[] param = null)//hatayı bildiiriyor bağlanmazsa 
        {
            DataTable table = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        if (param != null)
                        {
                            command.Parameters.AddRange(param);
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(table);  // Veriyi al DataTable ı doldur.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message);
            }

            return table;
        }

        private void Temizle()
        {
            TxtAd.Clear();
            TxtSoyad.Clear();
            TxtDogumYeri.Clear();
            TxtBirim.Clear();
            TxtUnvan.Clear();
            CmbCinsiyet.SelectedIndex = -1;
            DtpDogumTarihi.Value = DateTime.Now;

            //Eğer bugüne göre belirli bir süre eklemek istiyorsak                 
            //DtpDogumTarihi.Value = DateTime.Now.AddDays(7); // Bugünden 7 gün sonrasına ayarlar
            //DtpDogumTarihi.Value = DateTime.Now.AddMonths(1); // Bugünden 1 ay sonrasına ayarlar
            //DtpDogumTarihi.Value = DateTime.Now.AddYears(2); // Bugünden 2 yıl sonrasına ayarlar


        }
        #endregion

        #region Hataytı gösteriyor bağlanma
        private void ExecuteCommand(string sql, SqlParameter[] param)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (param != null)
                    {
                        command.Parameters.AddRange(param);
                    }
                    command.ExecuteNonQuery();
                }
            }
        }

        private object ExecuteScalar(string sql, SqlParameter[] param)
        {
            object result = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        if (param != null)
                        {
                            command.Parameters.AddRange(param);
                        }
                        result = command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
                throw; // Hatayı yeniden fırlatma
            }
            return result;
        }
        #endregion

        #region Personel ekle
        private void BtnPersonelEkle_Click_1(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Personel (p_ad, p_soyad, cinsiyet, dogum_tarihi, dogum_yeri, ise_baslama_tarihi, birim, unvan) " +
                        "VALUES (@p_ad, @p_soyad, @cinsiyet, @dogum_tarihi, @dogum_yeri, GETDATE(), @birim, @unvan)";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@p_ad", TxtAd.Text),
                new SqlParameter("@p_soyad", TxtSoyad.Text),
                new SqlParameter("@cinsiyet", CmbCinsiyet.SelectedItem?.ToString()),
                new SqlParameter("@dogum_tarihi", DtpDogumTarihi.Value),
                new SqlParameter("@dogum_yeri", TxtDogumYeri.Text),
                new SqlParameter("@birim", TxtBirim.Text),
                new SqlParameter("@unvan", TxtUnvan.Text)
            };
            
            ExecuteCommand(sql, param);
            MessageBox.Show("Personel başarıyla eklendi.");
            Temizle();
            PersonelListesiGetir();
        }
        #endregion

        #region Personel sil
        private void BtnPersonelSil_Click(object sender, EventArgs e)
        {
            // DataGridView'den herhangi bir satır seçilip seçilmediğini kontrol et
            if (DgvPersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz personeli seçin.");
                return;
            }

            // Seçilen satırdaki personel numarasını al
            int p_no = Convert.ToInt32(DgvPersonel.SelectedRows[0].Cells["Personel No"].Value);

            // Personel silme sorgusu
            string sql = "DELETE FROM Personel WHERE p_no = @p_no";
            SqlParameter[] param = new SqlParameter[]
            {
        new SqlParameter("@p_no", p_no)
            };

            // Sorguyu çalıştır
            ExecuteCommand(sql, param);

            // Silme işleminden sonra kullanıcıya bilgi ver
            MessageBox.Show("Personel silindi.");

            // ListView'i güncelle (yeniden veri çek)
            PersonelListesiGetir();
            
            // Formu temizle
            Temizle();
        }
        #endregion

        #region Personel kayıt GİRİŞ 



        DateTime giris_saati;//degişken
        private void BtnGirisKaydet_Click(object sender, EventArgs e)
        {
            if (DgvPersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir personel seçin.");
                return;
            }

            // Seçilen personelin p_no'sunu al
            int p_no = Convert.ToInt32(DgvPersonel.SelectedRows[0].Cells["Personel No"].Value);

            // Giriş kaydını kontrol et
            string kontrolSql = "SELECT COUNT(*) FROM GirisCikisKayit WHERE p_no = @p_no AND cikis_saati IS NULL";
            SqlParameter[] kontrolParam = { new SqlParameter("@p_no", p_no) };

            if (Convert.ToInt32(ExecuteScalar(kontrolSql, kontrolParam)) > 0)
            {
                MessageBox.Show("Bu personelin zaten açık bir giriş kaydı var!");
                return;
            }


            // İstediğiniz saati TimeSpan ile belirtin
            TimeSpan belirliSaat = new TimeSpan(9, 0, 0); // Saat 09:00 olarak belirlendi

            // Sistem saatini al ve referans saatle karşılaştır
            TimeSpan simdikiSaat = DateTime.Now.TimeOfDay;

            if (simdikiSaat > belirliSaat)
            {
                // Geç kalma kontrolü
                TimeSpan fark = simdikiSaat - belirliSaat;

                // Farkı saat ve dakika olarak al
                int saatFarki = fark.Hours;
                int dakikaFarki = fark.Minutes;

                MessageBox.Show($"Saat {belirliSaat.Hours:D2}:{belirliSaat.Minutes:D2}'yi {saatFarki} saat {dakikaFarki} dakika geç geldiniz.", "Geç Gelme Bilgisi");
            }
            else
            {
                MessageBox.Show("Zamanında geldiniz. Kolay gelsin :)", "Bilgi");
            }

            // Giriş kaydını ekle
            string sql = "INSERT INTO GirisCikisKayit (p_no, giris_saati, durum) VALUES (@p_no, GETDATE(), 'Giris')";
            SqlParameter[] param = {
    new SqlParameter("@p_no", p_no)
};

            ExecuteCommand(sql, param);
            MessageBox.Show("Giriş kaydedildi.");

            // Giriş/Çıkış listesini güncelle
            GirisCikisListesiGetir();


        }
        #endregion

        #region  Personel kayıt CIKIŞ   


        DateTime cikisSaati;
        private void BtnCikisKaydet_Click(object sender, EventArgs e)
        {
           

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT cikis_saati FROM GirisCikisKayit";// Veritabanından çıkış saati bilgisini alacak SQL sorgusu
                
                conn.Open();// Bağlantıyı açıyoruz
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader()) // Sorguyu çalıştırıp verileri okuyacak bir SqlDataReader kullanıyoruz
                    {
                        if (dr.Read())
                        {
                            cikisSaati = Convert.ToDateTime(dr["cikis_saati"]);// Çıkış saati verisini alıyoruz ve DateTime türüne dönüştürüyoruz
                        }
                    }
                }

            }
            // İstediğiniz saati TimeSpan ile belirtin
            TimeSpan belirliSaat = new TimeSpan(17, 0, 0); // Saat 17:00 olarak belirlendi

            // Sistem saatini al ve referans saatle karşılaştır
            TimeSpan simdikiSaat = DateTime.Now.TimeOfDay;

            if (simdikiSaat < belirliSaat)
            {
                // Geç kalma kontrolü
                TimeSpan fark = belirliSaat-simdikiSaat;

                // Farkı saat ve dakika olarak al
                int saatFarki = fark.Hours;
                int dakikaFarki = fark.Minutes;

                MessageBox.Show($"Saat {belirliSaat.Hours:D2}:{belirliSaat.Minutes:D2}'yi {saatFarki} saat {dakikaFarki} dakika erken cıktınız.", "Geç Gelme Bilgisi");
            }
            else
            {
                MessageBox.Show("iyi günler", "Bilgi");
            }

            // Giriş çıkışları yeniden yükle
            GirisCikisListesiGetir();




            if (DgvPersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir personel seçin.");
                return;
            }

            // Seçilen personelin p_no'sunu al
            int p_no = Convert.ToInt32(DgvPersonel.SelectedRows[0].Cells["Personel No"].Value);

            // Çıkış kaydını güncellemek
            string sql = "UPDATE GirisCikisKayit SET cikis_saati = GETDATE(), durum = 'Çikis' WHERE p_no = @p_no AND cikis_saati IS NULL";
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@p_no", p_no)
            };

            // Sorguyu çalıştır
            ExecuteCommand(sql, param);

            MessageBox.Show("Çıkış kaydedildi.");

            // Giriş çıkışları yeniden yükle
            GirisCikisListesiGetir();
        }
        #endregion

        #region Personel güncelle
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (DgvPersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz personeli seçin.");
                return;
            }

            int p_no = Convert.ToInt32(DgvPersonel.SelectedRows[0].Cells["Personel No"].Value);

            string sql = "UPDATE Personel SET p_ad = @p_ad, p_soyad = @p_soyad, cinsiyet = @cinsiyet, " +
                         "dogum_tarihi = @dogum_tarihi, dogum_yeri = @dogum_yeri, birim = @birim, unvan = @unvan " +
                         "WHERE p_no = @p_no";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@p_ad", TxtAd.Text),
                new SqlParameter("@p_soyad", TxtSoyad.Text),
                new SqlParameter("@cinsiyet", CmbCinsiyet.SelectedItem?.ToString()),
                new SqlParameter("@dogum_tarihi", DtpDogumTarihi.Value),
                new SqlParameter("@dogum_yeri", TxtDogumYeri.Text),
                new SqlParameter("@birim", TxtBirim.Text),
                new SqlParameter("@unvan", TxtUnvan.Text),
                new SqlParameter("@p_no", p_no)
            };

            ExecuteCommand(sql, param);
            MessageBox.Show("Personel bilgileri güncellendi.");
            PersonelListesiGetir();
            Temizle();
        }
        #endregion
         

        

        #region Menü bölümü
        private void pdfİndirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog  // PDF kaydedilecek dosya için kullanıcıdan yol seçmesi istenir
            {
                Filter = "PDF Dosyaları|*.pdf", // Sadece PDF dosyalarını kaydetmek için filtre
                Title = "PDF Dosyasını Kaydet", // Kaydet penceresi başlığı
                FileName = "PersonelVeGirisCikisListesi.pdf" // Varsayılan dosya adı
            };

          //  Eğer kullanıcı bir dosya yolu seçerse işlemi devam ettir
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Dosya akışı oluştur ve PDF dosyasını kaydetmek için aç
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        // PDF belgesi oluştur, sayfa boyutunu A4 olarak ayarla
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 20f);

                        // PdfWriter ile PDF belgesini dosya akışına yazdır
                        PdfWriter.GetInstance(pdfDoc, stream);

                        // PDF belgesini aç
                        pdfDoc.Open();

                        // "Personel Listesi" başlığı oluştur
                        Paragraph title1 = new Paragraph("Personel Listesi\n\n", FontFactory.GetFont(FontFactory.HELVETICA, 16, iTextSharp.text.Font.BOLD));
                        title1.Alignment = Element.ALIGN_CENTER; // Başlık ortalanır
                        pdfDoc.Add(title1); // Başlığı PDF'e ekle

                        // Personel listesi için tablo oluştur
                        PdfPTable personelTable = new PdfPTable(DgvPersonel.Columns.Count);
                        personelTable.WidthPercentage = 100; // Tablo genişliğini sayfaya göre ayarla

                        // Personel sütun başlıklarını ekle
                        foreach (DataGridViewColumn column in DgvPersonel.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD)))
                            {
                                HorizontalAlignment = Element.ALIGN_CENTER, // Sütun başlıklarını ortala
                                BackgroundColor = BaseColor.LIGHT_GRAY // Arka plan rengini gri yap
                            };
                            personelTable.AddCell(cell); // Hücreyi tabloya ekle
                        }

                        // Personel satır verilerini tabloya ekle
                        foreach (DataGridViewRow row in DgvPersonel.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                personelTable.AddCell(new Phrase(cell.Value?.ToString() ?? "", FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10))); // Hücre verisini ekle
                            }
                        }

                        pdfDoc.Add(personelTable); // Tabloyu PDF'e ekle

                        // "Giriş Çıkış Listesi" başlığı oluştur
                        Paragraph title2 = new Paragraph("\nGiriş Çıkış Listesi\n\n", FontFactory.GetFont(FontFactory.TIMES_BOLDITALIC, 16, iTextSharp.text.Font.BOLD));
                        title2.Alignment = Element.ALIGN_CENTER; // Başlık ortalanır
                        pdfDoc.Add(title2); // Başlığı PDF'e ekle

                        // Giriş Çıkış listesi için tablo oluştur
                        PdfPTable girisCikisTable = new PdfPTable(DgvGirisCikis.Columns.Count);
                        girisCikisTable.WidthPercentage = 100; // Tablo genişliğini sayfaya göre ayarla

                        // Giriş Çıkış sütun başlıklarını ekle
                        foreach (DataGridViewColumn column in DgvGirisCikis.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD)))
                            {
                                HorizontalAlignment = Element.ALIGN_CENTER, // Sütun başlıklarını ortala
                                BackgroundColor = BaseColor.LIGHT_GRAY // Arka plan rengini gri yap
                            };
                            girisCikisTable.AddCell(cell); // Hücreyi tabloya ekle
                        }

                        // Giriş Çıkış satır verilerini tabloya ekle
                        foreach (DataGridViewRow row in DgvGirisCikis.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                girisCikisTable.AddCell(new Phrase(cell.Value?.ToString() ?? "", FontFactory.GetFont(FontFactory.HELVETICA, 10))); // Hücre verisini ekle
                            }
                        }

                        pdfDoc.Add(girisCikisTable); // Tabloyu PDF'e ekle

                        // PDF dosyasını kapat
                        pdfDoc.Close();
                        stream.Close();
                    }

                    // İşlem başarılı olduğunda kullanıcıya bilgi mesajı göster
                    MessageBox.Show("PDF başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Hata oluşursa kullanıcıya hata mesajı göster
                    MessageBox.Show("PDF oluşturma sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeP ListeP = new FrmListeP();
            ListeP.ShowDialog();
            
        }       

        private void girişÇıkışListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeGÇ ListeGÇ = new FrmListeGÇ();
            ListeGÇ.ShowDialog();
            
        }
        #endregion


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        


    }
}




