using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.YouTube.v3.Data;
using Google.Apis.YouTube.v3;
using MySql.Data.MySqlClient;

namespace Kontrol_Yazılımı
{
    public partial class basvuruDurumGoruntulemeEkrani : Form

    {
        private List<BasvuruDurumu> basvuruDurumlari = new List<BasvuruDurumu>();
        private string connectionString = "Server=localhost;Database=kontrolYazilimiVeriTabani;User ID=root;Password=1234;";
        public basvuruDurumGoruntulemeEkrani()
        {
            InitializeComponent();
            BasvuruDurumlariniListele();
        }

        // Geri butonu click olayı
        private void geriPB_Click(object sender, EventArgs e)
        {
            IsArayanEkrani isArama = new IsArayanEkrani();
            isArama.Show();
            this.Close();
        }

        private void BasvuruDurumlariniListele()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // İş arayanın başvurduğu projelerin başlıklarını ve durumlarını al
                    string sql = "SELECT projeler.baslik AS proje_baslik, basvurular.durum, projeler.mikroIs " +
                                 "FROM basvurular " +
                                 "LEFT JOIN projeler ON basvurular.proje_id = projeler.proje_id " +
                                 "WHERE basvurular.is_arayan_id = @is_arayan_id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        int oturumAcilanKullaniciId = GetOturumAcilanKullaniciId();
                        cmd.Parameters.AddWithValue("@is_arayan_id", oturumAcilanKullaniciId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            basvuruDurumlari.Clear();
                            while (reader.Read())
                            {
                                string projeBasligi = reader["proje_baslik"].ToString();
                                string durum = reader["durum"].ToString();
                                bool mikroIs = reader["mikroIs"] is DBNull ? false : Convert.ToBoolean(reader["mikroIs"]);

                                basvuruDurumlari.Add(new BasvuruDurumu { ProjeBasligi = projeBasligi, Durum = durum, MikroIs = mikroIs });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Başvuru durumu listeleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Listbox'ı güncelle
            BasvuruDurumlariniGuncelle(basvuruDurumlari);
        }
        // Başvuru durumlarını güncelleme
        public void BasvuruDurumlariniGuncelle(List<BasvuruDurumu> durumlar)
        {
            basvuruDurumlari = durumlar;

            // Listbox'ı güncelle
            basvuruLB.Items.Clear();
            basvuruLB.Items.AddRange(basvuruDurumlari.ToArray());
        }

        private int GetIsArayanId()
        {
            int isArayanId = -1; // Varsayılan değer

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Rastgele bir iş arayan ID'si al
                    string sqlSelect = "SELECT kullanici_id FROM kullanicilar WHERE kullanici_tipi = 'IsArayan' ORDER BY RAND() LIMIT 1";
                    using (MySqlCommand cmdSelect = new MySqlCommand(sqlSelect, connection))
                    {
                        object result = cmdSelect.ExecuteScalar();

                        if (result != null)
                        {
                            isArayanId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Hatası: {ex.Number} - {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bilinmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isArayanId;
        }

        private void geriPB_Click_1(object sender, EventArgs e)
        {
            IsArayanEkrani isArama = new IsArayanEkrani();
            isArama.Show();
            this.Close();
        }
        // İş yapma butonu click olayı
        private async void isiYapBT_Click(object sender, EventArgs e)
        {
            if (basvuruLB.SelectedItem is BasvuruDurumu selectedDurum)
            {
                if (selectedDurum.MikroIs)
                {
                    // Mikro iş durumu kontrolü
                    try
                    {
                        // YouTube kanalına abone olma işlemi
                        await AboneOlAsync();
                        isBitimi isBitimiForm = new isBitimi();
                        isBitimiForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("YouTube kanalına abone olma hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Eğer seçilen iş mikroiş değilse, "İş Bitimi" sayfasına geçiş yap
                    isBitimi isBitimiForm = new isBitimi();
                    isBitimiForm.Show();
                }
            }
        }

        private async Task AboneOlAsync()
        {
            string channelId = "UC5gTfq0KS1zkhR9INgoGbug"; // Gerçek kanal kimliğinizle değiştirin

            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string clientSecretFilePath = Path.Combine(desktopPath, "client_secret_662883917909-r78gs5mg6mad8l3njfic4e98lf64ccca.apps.googleusercontent.com.json");

                UserCredential credential;
                using (var stream = new FileStream(clientSecretFilePath, FileMode.Open, FileAccess.Read))
                {
                    credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        new[] { YouTubeService.Scope.Youtube },
                        "user",
                        System.Threading.CancellationToken.None
                    );
                }

                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "YouTube/1.64" // Uygulama adınız ve sürümünüzle değiştirin
                });

                var subscription = new Subscription();
                subscription.Snippet = new SubscriptionSnippet();
                subscription.Snippet.ResourceId = new ResourceId();
                subscription.Snippet.ResourceId.ChannelId = channelId;
                subscription.Snippet.ResourceId.Kind = "youtube#channel";

                await youtubeService.Subscriptions.Insert(subscription, "snippet").ExecuteAsync();

                MessageBox.Show("YouTube kanalına başarıyla abone oldunuz!", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("YouTube kanalına abone olma hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void basvuruLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen başvuru durumunu getir
            if (basvuruLB.SelectedItem is BasvuruDurumu selectedDurum)
            {
                // İş yapma butonunu sadece kabul edilen başvurular için aktif yap
                isiYapBT.Enabled = string.Equals(selectedDurum.Durum, "kabul_edildi", StringComparison.OrdinalIgnoreCase);

                // Eğer durum "kabul_edildi" değilse, iş yapma butonunu devre dışı bırak
                if (!isiYapBT.Enabled)
                {
                    MessageBox.Show("İş yapma butonu sadece 'kabul edildi' durumunda aktiftir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // İş durumunu ve proje başlığını göster
                MessageBox.Show($"Proje Başlığı: {selectedDurum.ProjeBasligi}\nDurumu: {selectedDurum.Durum}", "Başvuru Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int GetOturumAcilanKullaniciId()
        {
            int oturumAcilanKullaniciId = -1;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    // Bu örnek kodda GetIsArayanId() metodu kullanılmıştır. Bu metot, rastgele bir iş arayan ID'si döner.
                    if (KullaniciGirisiYapildiMi())
                    {
                        oturumAcilanKullaniciId = GetIsArayanId();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Hatası: {ex.Number} - {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bilinmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return oturumAcilanKullaniciId;
        }

        private bool KullaniciGirisiYapildiMi()
        {
            return true;
        }

    }
}
// Başvuru durumu sınıfı
public class BasvuruDurumu
{
    public int IsArayanId { get; set; }
    public string ProjeBasligi { get; set; }
    public string Durum { get; set; }
    public bool MikroIs { get; set; } // Yeni eklenen mikroİş durumu

    public override string ToString()
    {
        string mikroIsDurumu = MikroIs ? " (Mikroiş)" : "";// Mikroiş durumu kontrolü
        // ListBox'ta görüntülenecek metni oluştur
        return $"{ProjeBasligi} - {Durum}-{mikroIsDurumu}";
    }

}