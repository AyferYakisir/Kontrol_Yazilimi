using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kontrol_Yazılımı
{
    public partial class IsArayanKayitForm : Form
    {
        private string userType;

        // MySQL veritabanı bağlantı dizesi
        private string connectionString = "Server=localhost;Database=kontrolyazılımı;User ID=root;Password=sgaftabs;";

        public IsArayanKayitForm(string userType)
        {
            InitializeComponent();
            this.userType = userType;
        }

        private void iKayitBT_Click(object sender, EventArgs e)
        {
            // TextBox'ların boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(iAdTB.Text) ||
                string.IsNullOrWhiteSpace(iSoyadTB.Text) ||
                string.IsNullOrWhiteSpace(iEpostaTB.Text) ||
                string.IsNullOrWhiteSpace(iSifreTB.Text) ||
                string.IsNullOrWhiteSpace(iUlkeTB.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Şifre kontrolü: Şifre sadece sayı içermelidir
            if (!System.Text.RegularExpressions.Regex.IsMatch(iSifreTB.Text, @"^\d+$"))
            {
                MessageBox.Show("Şifre sadece sayı içermelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // E-posta kontrolü: E-posta adresi geçerli bir formata sahip olmalıdır
            if (!IsValidEmail(iEpostaTB.Text))
            {
                MessageBox.Show("Geçerli bir e-posta adresi girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanına kayıt ekleme işlemi
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO kullanicilar (ad, soyad, eposta, sifre, ulke, kullanici_tipi) VALUES (@ad, @soyad, @eposta, @sifre, @ulke, @kullanici_tipi)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@ad", iAdTB.Text);
                        cmd.Parameters.AddWithValue("@soyad", iSoyadTB.Text);
                        cmd.Parameters.AddWithValue("@eposta", iEpostaTB.Text);
                        cmd.Parameters.AddWithValue("@sifre", iSifreTB.Text);
                        cmd.Parameters.AddWithValue("@ulke", iUlkeTB.Text);
                        cmd.Parameters.AddWithValue("@kullanici_tipi", userType);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Giriş sayfasına yönlendirme
                        GirisForm girisForm = new GirisForm();
                        girisForm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void isArayanLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Giriş sayfasına yönlendirme
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
            this.Hide();
        }
        // E-posta kontrolü için yardımcı metot
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void igeriPB_Click(object sender, EventArgs e)
        {
            // Giriş sayfasına yönlendirme
            AnaGiris form1 = new AnaGiris();
            form1.Show();
            this.Close();
        }
    }
}