using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kontrol_Yazılımı
{
    public partial class GirisForm : Form
    {
        // MySQL veritabanı bağlantı dizesi
        private string connectionString = "Server=localhost;Database=kontrolyazılımı;User ID=root;Password=1234;";

        public GirisForm()
        {
            InitializeComponent();
            // Şifre alanını gizli yap
            gSifreTB.PasswordChar = '*';

        }
        private void girisBT_Click(object sender, EventArgs e)
        {
            // E-posta ve şifre alanlarından değerleri al
            string eposta = gEpostaTB.Text;
            string sifre = gSifreTB.Text;

            // Veritabanında kullanıcı kontrolü
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM kullanicilar WHERE eposta = @eposta AND sifre = @sifre";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@eposta", eposta);
                        cmd.Parameters.AddWithValue("@sifre", sifre);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Kullanıcı var, giriş yap
                                string userType = reader["kullanici_tipi"].ToString();
                                if (userType == "Musteri")
                                {
                                    MusteriIsTanimlamaForm musteriAnaForm = new MusteriIsTanimlamaForm();
                                    musteriAnaForm.Show();
                                }
                                else if (userType == "IsArayan")
                                {
                                    IsArayanIsAramaForm isArayanAnaForm = new IsArayanIsAramaForm();
                                    isArayanAnaForm.Show();
                                }

                                this.Hide();
                            }
                            else
                            {
                                // Kullanıcı yok veya şifre/eposta hatalı
                                MessageBox.Show("Yanlış e-posta veya şifre!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void girisLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Giriş sayfasına yönlendirme
            AnaGiris form1 = new AnaGiris();
            form1.Show();
            this.Hide();
        }
    }

}