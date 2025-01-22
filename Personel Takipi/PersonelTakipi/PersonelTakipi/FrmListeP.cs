using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PersonelTakipi
{
    public partial class FrmListeP : Form
    {
        //Initial Catalog: Kullanılacak veritabanı tablosu.
        string connectionString = $"Data Source=(local);Initial Catalog=Personel;User ID=sa;Password=1;";
        //string connectionString = "Data Source=LAPTOP-HDVV2N4C\\SQLEXPRESS;Initial Catalog=GorselProg;Integrated Security=True;";
        private void FrmListeP_Load(object sender, EventArgs e)
        {
            PersonelListesiGetir();
        }

        public FrmListeP()
        {
            InitializeComponent();
            Txtarama.TextChanged += Txtarama_TextChanged;        
            DgvPersonel.CellClick += DgvPersonel_CellClick;
           
            
            // TextBox'a Enter ve Leave olaylarını bağlıyoruz
            Txtarama.Enter += Txtarama_Enter;
            Txtarama.Leave += Txtarama_Leave;
            // Başlangıçta TextBox'a placeholder metnini koyuyoruz
            Txtarama.Text = "Personel Ara";
            Txtarama.ForeColor = Color.Gray;  // Rengi gri yapıyoruz
        }

        private void Txtarama_TextChanged(object sender, EventArgs e)
        {

            // Eğer TextBox varsayılan metni içeriyorsa arama yapma
            if (Txtarama.Text == "Personel Ara")
                return;

            // Arama işlemi
            String sql = "SELECT p_no AS [Personel No], p_ad AS [Ad], p_soyad AS [Soyad], cinsiyet AS [Cinsiyet], dogum_tarihi AS [Doğum Tarihi]," +
                         " dogum_yeri AS [Doğum Yeri], birim AS [Birim], unvan AS [Ünvan] FROM Personel WHERE p_ad LIKE @arama OR p_soyad LIKE @arama";
            SqlParameter[] param = { new SqlParameter("@arama", "%" + Txtarama.Text + "%") };
            DgvPersonel.DataSource = GetDataTable(sql, param);
        }
        #region TEXTBOX YAZISI SİLME
        private void Txtarama_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txtarama.Text))  // Eğer TextBox boşsa
            {
                Txtarama.Text = "Personel Ara";  // Varsayılan metni geri koy
                Txtarama.ForeColor = Color.Gray;  // Yazı rengini gri yap
            }
        }

        private void Txtarama_Enter(object sender, EventArgs e)
        {
            if (Txtarama.Text == "Personel Ara")  // Varsayılan metni kontrol et
            {
                Txtarama.Text = "";  // Eğer varsayılan metinse, sil
                Txtarama.ForeColor = Color.Black;  // Yazı rengini siyah yap
                Txtarama.Clear();
            }
        }
        #endregion
        #region PERSONELLERİ LBL YE YAZMA 
        private void DgvPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Geçersiz satır tıklamalarını yoksay
            if (e.RowIndex < 0) return;

            DataGridViewRow row = DgvPersonel.Rows[e.RowIndex];

            // Textboxlara bilgileri aktar
            ad.Text = row.Cells["Ad"].Value?.ToString();
            soyad.Text = row.Cells["Soyad"].Value?.ToString();
            dogumyeri.Text = row.Cells["Doğum Yeri"].Value?.ToString();
            birim.Text = row.Cells["Birim"].Value?.ToString();
            ünvan.Text = row.Cells["Ünvan"].Value?.ToString();
            cinsiyet.Text = row.Cells["Cinsiyet"].Value?.ToString();

            // Doğum tarihini DateTimePicker'a yazdır
            if (DateTime.TryParse(row.Cells["Doğum Tarihi"].Value?.ToString(), out DateTime dogumTarihi))
            {
                DtpDogumTarihi.Value = dogumTarihi;
            }
        }     
        #endregion   
        
        #region PERSONEL LİSTESİ 
        private void PersonelListesiGetir()
        {
            string sql = "SELECT p_no AS [Personel No], p_ad AS [Ad], p_soyad AS [Soyad], cinsiyet AS [Cinsiyet], " +
                         "dogum_tarihi AS [Doğum Tarihi], dogum_yeri AS [Doğum Yeri], birim AS [Birim], unvan AS [Ünvan] " +
                         "FROM Personel";
            DgvPersonel.DataSource = GetDataTable(sql);
        }
        private DataTable GetDataTable(string sql, SqlParameter[] param = null)
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
                        adapter.Fill(table);  // Veriyi al
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
            ad.Text = string.Empty;
            soyad.Text = string.Empty;
            dogumyeri.Text = string.Empty;
            birim.Text = string.Empty;
            ünvan.Text = string.Empty;
            cinsiyet.Text = string.Empty;
            DtpDogumTarihi.Value = DateTime.Now;

        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
