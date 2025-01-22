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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }


        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {
            Txtsifre.PasswordChar = '*';
        }     

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void Btngiris_Click(object sender, EventArgs e)
        {
            //Initial Catalog: Kullanılacak veritabanı tablosu.

            string connectionString = "Server=(local); Database=Personel;User ID=sa;Password=1;";
            //string connectionString = $"Data Source=(local);Initial Catalog=Personel;User ID=sa;Password=1;";
            //string connectionString = "Data Source=LAPTOP-HDVV2N4C\\SQLEXPRESS;Initial Catalog=GorselProg;Integrated Security=True;";


            // Kullanıcı adı ve şifre bilgilerini al
            string kullaniciAdi = Txtkulanciadi.Text.Trim();

            string sifre = Txtsifre.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Admins WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                    command.Parameters.AddWithValue("@Sifre", sifre);

                    int userCount = Convert.ToInt32(command.ExecuteScalar());

                    if (userCount > 0)
                    {
                        AdminPanel AdminPanel = new AdminPanel();
                        AdminPanel.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
