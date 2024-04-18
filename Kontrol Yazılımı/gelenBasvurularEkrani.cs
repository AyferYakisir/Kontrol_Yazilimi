using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kontrol_Yazılımı
{
    public partial class gelenBasvurularEkrani : Form
    {
        private string connectionString = "Server=localhost;Database=kontrolYazilimiVeriTabani;User ID=root;Password=1234;";

        public gelenBasvurularEkrani()
        {
            InitializeComponent();

            // Başvuruları listele
            BasvurulariListele();
        }

        private void BasvurulariListele()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT basvurular.basvuru_id, " +
                                 "projeler.baslik AS proje_baslik, " +
                                 "projeler.mikroIs, " +
                                 "basvurular.teklif_fiyati, " +
                                 "is_arayan_kullanicilar.ad AS is_arayan_ad, " +
                                 "is_arayan_kullanicilar.soyad AS is_arayan_soyad " +
                                 "FROM basvurular " +
                                 "LEFT JOIN projeler ON basvurular.proje_id = projeler.proje_id " +
                                 "LEFT JOIN kullanicilar AS is_arayan_kullanicilar ON basvurular.is_arayan_id = is_arayan_kullanicilar.kullanici_id " +
                                 "WHERE basvurular.durum = 'beklemede'";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            basvuruListBox.Items.Clear();

                            while (reader.Read())
                            {
                                string isArayanAd = reader["is_arayan_ad"].ToString();
                                string isArayanSoyad = reader["is_arayan_soyad"].ToString();

                                // Mikro iş durumunu kontrol et
                                string mikroIsDurumu = (reader["mikroIs"] != DBNull.Value && Convert.ToBoolean(reader["mikroIs"])) ? " (Mikroiş)" : "";

                                string basvuruBilgisi = $"Proje Başlığı: {reader["proje_baslik"]} - Teklif Fiyatı: {reader["teklif_fiyati"]} - Başvuran: {isArayanAd} {isArayanSoyad}{mikroIsDurumu}";

                                basvuruListBox.Items.Add(new BasvuruItem(Convert.ToInt32(reader["basvuru_id"]), basvuruBilgisi));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Başvuru listeleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void teklifBT_Click(object sender, EventArgs e)
        {
            TeklifVer();
        }

        private void TeklifVer()
        {
            if (basvuruListBox.SelectedItem is BasvuruItem selectedBasvuru)
            {
                DialogResult result = MessageBox.Show($"Proje Bilgisi:\n{selectedBasvuru.BasvuruBilgisi}\n\nTeklifi Kabul Ediyor musunuz?", "Teklif Değerlendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Kullanıcı "Evet" butonuna bastı
                    ProjeDurumuGuncelle(selectedBasvuru.BasvuruId, "Kabul_Edildi");

                    MessageBox.Show("Teklif başarıyla kabul edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Kullanıcı "Hayır" butonuna bastı
                    ProjeDurumuGuncelle(selectedBasvuru.BasvuruId, "Reddedildi");

                    MessageBox.Show("Teklif reddedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Başvuruları tekrar listele
                BasvurulariListele();
            }
            else
            {
                MessageBox.Show("Lütfen bir başvuru seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ProjeDurumuGuncelle(int basvuruId, string durum)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Başvuruyu güncelle
                    string sqlUpdate = "UPDATE basvurular SET durum = @durum WHERE basvuru_id = @basvuru_id";
                    using (MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, connection))
                    {
                        cmdUpdate.Parameters.AddWithValue("@basvuru_id", basvuruId);
                        cmdUpdate.Parameters.AddWithValue("@durum", durum);

                        cmdUpdate.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Başvuru {durum}.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                // MySQL hatası
                MessageBox.Show($"MySQL Hatası: {ex.Number} - {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Diğer hatalar
                MessageBox.Show($"Bilinmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void geriBT_Click(object sender, EventArgs e)
        {
            MusteriİsTanimlamaEkrani musteriEkrani = new MusteriİsTanimlamaEkrani();
            musteriEkrani.Show();
            this.Close();
        }

        private class BasvuruItem
        {
            public int BasvuruId { get; }
            public string BasvuruBilgisi { get; }

            public BasvuruItem(int basvuruId, string basvuruBilgisi)
            {
                BasvuruId = basvuruId;
                BasvuruBilgisi = basvuruBilgisi;
            }

            public override string ToString()
            {
                return BasvuruBilgisi;
            }
        }
    }
}
