using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kontrol_Yazılımı
{
    public partial class isTanimlamaEkrani : Form
    {
        private string connectionString = "Server=localhost;Database=kontrolyazılımı;User ID=root;Password=1234;";

        // Proje eklendiğinde tetiklenecek olay (event)
        public event EventHandler ProjeEklendi;

        public isTanimlamaEkrani()
        {
            InitializeComponent();
            pButceTB.KeyPress += pButceTB_KeyPress;
        }

        private void pTanimlaBT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pBaslikTB.Text) ||
                string.IsNullOrWhiteSpace(pButceTB.Text) ||
                string.IsNullOrWhiteSpace(pAciklamaRB.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

                        // Proje eklendiğinde olayı tetikle
                        OnProjeEklendi(EventArgs.Empty);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Proje tanımlama sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
        protected virtual void OnProjeEklendi(EventArgs e)
        {
            // Olayı tetikleme metodunun içeriği burada
            ProjeEklendi?.Invoke(this, e);
        }
        private void pButceTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kullanıcının girdiği karakterin sayı olup olmadığını kontrol et
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Sayı değilse, karakteri işleme alma, olayı iptal et ve uyarı göster
                e.Handled = true;
                MessageBox.Show("Bütçe değeri sadece sayı olarak girilmelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        }
 }
