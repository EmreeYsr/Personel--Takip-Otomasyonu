using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipi
{
    public partial class FrmListeGÇ : Form
    {
        //Initial Catalog: Kullanılacak veritabanı tablosu.
        string connectionString = $"Data Source=(local);Initial Catalog=Personel;User ID=sa;Password=1;";
        //string connectionString = "Data Source=(local);Initial Catalog=Personel;User ID=sa;Password=1;Integrated Security=True;";
        public FrmListeGÇ()
        {
            InitializeComponent();
            BtnGetir.Click += BtnGetir_Click;
        }
        private void FrmListeGÇ_Load(object sender, EventArgs e)
        {
            GirisCikisListesiGetir();
        }
        private void GirisCikisListesiGetir()
        {
            string sqlGirisCikis = "SELECT kayit_no AS [Kayıt No], p_no AS [Personel No], giris_saati AS [Giriş Saati], " +
                                   "cikis_saati AS [Çıkış Saati], durum AS [Durum] FROM GirisCikisKayit";
            DgvGirisCikis.DataSource = GetDataTable(sqlGirisCikis); // DataGridView'e veri atıyoruz
        }
        private void BtnGetir_Click(object sender, EventArgs e)
        {
            DateTime startDate = DtpStartDate.Value;  // Başlangıç tarihi
            DateTime endDate = DtpEndDate.Value;      // Bitiş tarihi

            string sql = "SELECT kayit_no AS [Kayıt No], p_no AS [Personel No], giris_saati AS [Giriş Saati], " +
                         "cikis_saati AS [Çıkış Saati], durum AS [Durum] " +
                         "FROM GirisCikisKayit " +
                         "WHERE giris_saati BETWEEN @startDate AND @endDate";

            // Sorgunun çalıştırılması için kullanılacak parametreler
            SqlParameter[] param = {new SqlParameter("@startDate", startDate), // Kullanıcının seçtiği başlangıç tarihi
            new SqlParameter("@endDate", endDate)     // Kullanıcının seçtiği bitiş tarihi
   
            };

            // Tarih filtresine uygun kayıtları DataGridView'e aktarıyoruz
            DgvGirisCikis.DataSource = GetDataTable(sql, param);  // DataGridView'i güncelle
        }

        // SQL sorgusu çalıştırarak bir DataTable döndüren metot
        private DataTable GetDataTable(string sql, SqlParameter[] param = null)

        {
            DataTable table = new DataTable();

            try
            {
                // Veritabanı bağlantısını açıyoruz
                using (SqlConnection connection = new SqlConnection(connectionString))
                {                   
                    // SQL sorgusunu oluşturuyoruz
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Eğer parametreler varsa, komuta ekliyoruz
                        if (param != null)
                        {
                            command.Parameters.AddRange(param);
                        }

                        // Veriyi almak için SqlDataAdapter kullanıyoruz
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(table); // Sorgu sonucunu DataTable'a doldur
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message);
            }

            return table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGetir_Click_1(object sender, EventArgs e)
        {

        }
    }
}
