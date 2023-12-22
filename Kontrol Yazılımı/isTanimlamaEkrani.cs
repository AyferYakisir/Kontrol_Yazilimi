using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kontrol_Yazılımı
{
    public class ProjeBilgisi
    {
        public string Baslik { get; set; }
        public string Butce { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
    }
    public partial class isTanimlamaEkrani : Form
    {
        private ProjeBilgisi projeBilgisi;
        // MySQL veritabanı bağlantı dizesi
        private string connectionString = "Server=localhost;Database=kontrolyazılımı;User ID=root;Password=1234;";

        public isTanimlamaEkrani()
        {
            InitializeComponent();
            projeBilgisi = new ProjeBilgisi();
        }
        private void pTanimlaBT_Click(object sender, EventArgs e)
        {
            // TextBox'ların boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(pBaslikTB.Text) ||
                string.IsNullOrWhiteSpace(pButceTB.Text) ||
                string.IsNullOrWhiteSpace(pAciklamaRB.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanına proje ekleme işlemi
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO projeler (baslik, butce, aciklama, tarih) VALUES (@baslik, @butce, @aciklama, @tarih)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@baslik", pBaslikTB.Text);
                        cmd.Parameters.AddWithValue("@butce", pButceTB.Text);
                        cmd.Parameters.AddWithValue("@aciklama", pAciklamaRB.Text);
                        cmd.Parameters.AddWithValue("@tarih", pTarihDTP.Value);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Proje başarıyla tanımlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Proje tanımlama sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Proje bilgilerini kaydet
            projeBilgisi.Baslik = pBaslikTB.Text;
            projeBilgisi.Butce = pButceTB.Text;
            projeBilgisi.Aciklama = pAciklamaRB.Text;
            projeBilgisi.Tarih = pTarihDTP.Value;

            // Olayı tetikle
            this.Hide();

        }

    }
}