using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Security.Policy;
using System.Numerics;
using Nethereum.Web3;
using Nethereum.Hex.HexTypes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3.Accounts;
using Nethereum.HdWallet;
using static System.Net.WebRequestMethods;
using Google.Apis.YouTube.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Nethereum.BlockchainProcessing.BlockStorage.Entities;

namespace Kontrol_Yazılımı
{
    public partial class TamamlananIsler : Form
    {
        // OAuth 2.0 bilgileri
        private const string ClientId = "662883917909-r78gs5mg6mad8l3njfic4e98lf64ccca.apps.googleusercontent.com";
        private const string ClientSecret = "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";
        private const string KanalId = "UC5gTfq0KS1zkhR9INgoGbug";

        private YouTubeService _youTubeServisi;

        string connectionString = "Server=localhost;Database=kontrolYazilimiVeriTabani;User ID=root;Password=1234;";
        private StringWriter consoleWriter;

        public TamamlananIsler()
        {
            InitializeComponent();
            TamamlananIsleriListele();
            YouTubeServisiniBaslat();
            consoleWriter = new StringWriter();
            Console.SetOut(consoleWriter);
        }

        private void TamamlananIsleriListele()
        {
            // Veritabanından tamamlanan işleri çek
            List<TamamlananIs> tamamlananIsler = GetTamamlananIsler();

            // Listbox'ı güncelle
            listBoxTamamlananIsler.Items.Clear();
            listBoxTamamlananIsler.Items.AddRange(tamamlananIsler.ToArray());
        }

        private List<TamamlananIs> GetTamamlananIsler()
        {
            List<TamamlananIs> tamamlananIsler = new List<TamamlananIs>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Veritabanından tamamlanan işleri çek
                    string sql = "SELECT tamamlananprojeler.*, projeler.mikroIs " +
                                 "FROM tamamlananprojeler " +
                                 "LEFT JOIN projeler ON tamamlananprojeler.proje_id = projeler.proje_id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int tamamlananId = Convert.ToInt32(reader["tamamlanan_id"]);
                                string projeAdi = reader["proje_adi"].ToString();
                                string projeSureci = reader["projeSureci"].ToString();
                                DateTime bitisTarihi = Convert.ToDateTime(reader["bitisTarihi"]);
                                bool mikroIs = reader["mikroIs"] is DBNull ? false : Convert.ToBoolean(reader["mikroIs"]);

                                tamamlananIsler.Add(new TamamlananIs
                                {
                                    TamamlananId = tamamlananId,
                                    ProjeAdi = projeAdi,
                                    ProjeSureci = projeSureci,
                                    BitisTarihi = bitisTarihi,
                                    MikroIs = mikroIs
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tamamlanan işleri çekerken bir hata oluştu: " + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tamamlananIsler;
        }
        private decimal GetTeklifFiyatiFromBasvurular(int projeId, int isArayanId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT teklif_fiyati FROM basvurular WHERE proje_id = @projeId AND is_arayan_id = @isArayanId";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@projeId", projeId);
                        cmd.Parameters.AddWithValue("@isArayanId", isArayanId);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            return Convert.ToDecimal(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }

            return 0; // Hata durumunda varsayılan değeri döndür
        }
        public class TamamlananIs
        {
            public int TamamlananId { get; set; }
            public string ProjeAdi { get; set; }
            public string ProjeSureci { get; set; }
            public DateTime BitisTarihi { get; set; }
            public int ProjeId { get; set; }
            public string Baslik { get; set; }
            public int IsArayanId { get; set; }
            public decimal TeklifFiyati { get; set; }

            public int IsYapanKullaniciId { get; set; }

            public bool MikroIs { get; set; } // Yeni eklenen mikroİş durumu
            public override string ToString()
            {
                string mikroIsDurumu = MikroIs ? " (Mikroiş)" : "";// Mikroiş durumu kontrolü
                return $"{Baslik} - {ProjeSureci} - {BitisTarihi.ToString("yyyy-MM-dd")}-{mikroIsDurumu}";
            }
        }

        private void onaylaLB_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxTamamlananIsler.SelectedItem is TamamlananIs selectedIs)
                {
                    // Geçerli bir proje_id al
                    int projeId = GetValidProjectIdFromBasvurular();
                    int isArayanId = GetValidUserIdFromKullanicilar();
                    decimal teklifFiyati = GetTeklifFiyatiFromBasvurular(projeId, isArayanId);
                    if (projeId != -1)
                    {
                        // is_arayan_id değerini al


                        if (isArayanId != -1)
                        {
                            // Ödeme işlemini gerçekleştir
                            PerformPayment(projeId, isArayanId, teklifFiyati);
                            // Ödeme işlemini gerçekleştirdikten sonra odemeTransfer metodunu çağır
                            odemeTransfer(selectedIs.IsYapanKullaniciId, isArayanId, teklifFiyati);
                            TamamlananIsleriListele();
                        }
                        else
                        {
                            Console.WriteLine("İş arayan kullanıcı bulunamadı.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir iş seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödeme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetValidProjectIdFromBasvurular()
        {
            try
            {
                // "basvurular" tablosundan geçerli proje_id değerlerini al
                List<int> validProjectIds = GetValidProjectIdsFromBasvurular();

                if (validProjectIds.Count > 0)
                {
                    // Rastgele bir proje_id seç
                    Random random = new Random();
                    int randomIndex = random.Next(0, validProjectIds.Count);
                    int selectedProjectId = validProjectIds[randomIndex];

                    // Seçilen proje_id'yi döndür
                    return selectedProjectId;
                }
                else
                {
                    Console.WriteLine("Geçerli proje_id bulunamadı.");
                    return -1; // Hata durumunda -1 döndürmek veya başka bir strateji belirlemek uygun olabilir
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                return -1; // Hata durumunda -1 döndürmek veya başka bir strateji belirlemek uygun olabilir
            }
        }

        private List<int> GetValidProjectIdsFromBasvurular()
        {
            List<int> validProjectIds = new List<int>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT proje_id FROM basvurular";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int projectId = Convert.ToInt32(reader["proje_id"]);
                                validProjectIds.Add(projectId);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }

            return validProjectIds;
        }

        private void PerformPayment(int projeId, int isYapanId, decimal teklifFiyati)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO odemeler (proje_id, is_arayan_id, teklif_fiyati) VALUES (@projeId, @isYapanId, @teklifFiyati)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@projeId", projeId);
                        cmd.Parameters.AddWithValue("@isYapanId", isYapanId);
                        cmd.Parameters.AddWithValue("@teklifFiyati", teklifFiyati);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Ödeme başarıyla gerçekleştirildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödeme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetValidUserIdFromKullanicilar()
        {
            try
            {
                // "iş arayan" kullanıcıların kullanici_id değerlerini al
                List<int> isArayanKullaniciIdList = GetIsArayanKullaniciIdList();

                if (isArayanKullaniciIdList.Count > 0)
                {
                    // Rastgele bir "iş arayan" kullanıcı id seç
                    Random random = new Random();
                    int randomIndex = random.Next(0, isArayanKullaniciIdList.Count);
                    int selectedIsArayanId = isArayanKullaniciIdList[randomIndex];

                    // Seçilen "iş arayan" kullanıcı id'sini döndür
                    return selectedIsArayanId;
                }
                else
                {
                    Console.WriteLine("İş arayan kullanıcı bulunamadı.");
                    return -1; // Hata durumunda -1 döndürmek veya başka bir strateji belirlemek uygun olabilir
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                return -1; // Hata durumunda -1 döndürmek veya başka bir strateji belirlemek uygun olabilir
            }
        }

        private List<int> GetIsArayanKullaniciIdList()
        {
            List<int> isArayanKullaniciIdList = new List<int>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT kullanici_id FROM kullanicilar WHERE kullanici_tipi = 'IsArayan'";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int kullaniciId = Convert.ToInt32(reader["kullanici_id"]);
                                isArayanKullaniciIdList.Add(kullaniciId);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }

            return isArayanKullaniciIdList;
        }

        private void YouTubeServisiniBaslat()
        {
            try
            {
                var kimlik = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    new ClientSecrets
                    {
                        ClientId = ClientId,
                        ClientSecret = ClientSecret
                    },
                    new[] { YouTubeService.Scope.YoutubeReadonly },
                    "user",
                    System.Threading.CancellationToken.None).Result;

                _youTubeServisi = new YouTubeService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = kimlik,
                    ApplicationName = "YouTube/1.64"
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void kontrolEtBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxTamamlananIsler.SelectedItem is TamamlananIs selectedIs)
                {
                    // Sadece mikro işler için kontrol ekleyin
                    if (selectedIs.MikroIs)
                    {
                        // Belirtilen kanalın abonelik durumunu kontrol et
                        var abonelikListeIstegi = _youTubeServisi.Subscriptions.List("snippet");
                        abonelikListeIstegi.Mine = true;
                        abonelikListeIstegi.ForChannelId = KanalId;

                        var abonelikler = abonelikListeIstegi.Execute();

                        if (abonelikler.Items.Count > 0)
                        {
                            MessageBox.Show("Abonelik işlemi tamamlanmış.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            onaylaLB.Enabled = true;
                            odemeBT.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Abonelik işlemi bulunmuyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            onaylaLB.Enabled = false;
                            odemeBT.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu özelliği sadece mikro işler için kullanabilirsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir iş seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void odemeTransfer(int isYapanKullaniciId, int musteriId, decimal odemeMiktari)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string deductQuery = "UPDATE kullanicilar SET bakiye = bakiye - @odemeMiktari WHERE kullanici_id = @isYapanKullaniciId";
                    using (MySqlCommand deductCmd = new MySqlCommand(deductQuery, connection))
                    {
                        deductCmd.Parameters.AddWithValue("@isYapanKullaniciId", isYapanKullaniciId);
                        deductCmd.Parameters.AddWithValue("@odemeMiktari", odemeMiktari);
                        deductCmd.ExecuteNonQuery();
                    }

                    string depositQuery = "UPDATE kullanicilar SET bakiye = bakiye + @odemeMiktari WHERE kullanici_id = @musteriId";
                    using (MySqlCommand depositCmd = new MySqlCommand(depositQuery, connection))
                    {
                        depositCmd.Parameters.AddWithValue("@musteriId", musteriId);
                        depositCmd.Parameters.AddWithValue("@odemeMiktari", odemeMiktari);
                        depositCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(odemeMiktari / 1000 + " MATİC hesaba aktarıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödeme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void odemeBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxTamamlananIsler.SelectedItem is TamamlananIs selectedIs)
                {
                    // Ethereum düğümüne bağlanmak için RPC URL'sini belirtin
                    string rpcUrl = "https://polygon-mumbai.infura.io/v3/233594a8466b48c9bde2b5327d6b09f0"; // Infura proje kimliğinizle değiştirin

                    // Web3 nesnesini oluşturun
                    var web3 = new Web3(rpcUrl);

                    // İş arayanın Ethereum adresini ve proje ID'sini belirtin
                    string aliciAdres = "0x5c11d0293DAFA492893bD2f90170f5feE304fDAA";
                    string gonderenAdres = "0x56579b91Cb07cdE97dbe34D57E4f0b2Bd6a9397B";
                    int projeId = GetValidProjectIdFromBasvurular();
                    int isArayanId = GetValidUserIdFromKullanicilar();

                    // Veritabanından teklif fiyatını al
                    BigInteger teklifFiyatiWei = GetTeklifFiyatiFromDatabase(projeId, isArayanId);

                    // Mumbai ağında Ether'in Wei cinsine dönüş oranını belirtin
                    decimal etherToWeiRatioMumbai = 1e18m;

                    // Transfer işlemini gerçekleştirin
                    await TransferOdeme(web3, gonderenAdres, aliciAdres, teklifFiyatiWei);

                    // Transfer işlemini gerçekleştirin
                    await TransferOdeme(web3, gonderenAdres, aliciAdres, teklifFiyatiWei);
                }
                else
                {
                    MessageBox.Show("Lütfen bir iş seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Ödeme transferini gerçekleştiren metod
        private async Task TransferOdeme(Web3 web3, string gonderenAdres, string aliciAdres, BigInteger transferMiktariWei)
        {
            var gonderenBakiye = await web3.Eth.GetBalance.SendRequestAsync(gonderenAdres);
            try
            {
                // Gönderenin bakiyesi yeterli mi kontrol et
                if (gonderenBakiye >= transferMiktariWei)
                {

                    // Transfer işlemini oluşturun
                    var transferInput = new TransactionInput
                    {
                        From = gonderenAdres,
                        To = aliciAdres,
                        Gas = new HexBigInteger(21000), // Gas limit değeri
                        GasPrice = new HexBigInteger(5000000000), // Gas price değeri Gwei cinsinden
                        Value = new HexBigInteger(transferMiktariWei),
                    };

                    // Transfer işlemini gönderin
                    var transactionHash = await web3.Eth.Transactions.SendTransaction.SendRequestAsync(transferInput);

                    // İşlem başarılı mesajını göster
                    MessageBox.Show("Ödeme transferi başarıyla gerçekleştirildi! TxHash: " + transactionHash, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Ethereum ağında işlemin onaylanmasını bekleyin (20 saniye boyunca)
                    var receipt = await web3.Eth.Transactions.GetTransactionReceipt.SendRequestAsync(transactionHash);
                    var maxWaitTimeInSeconds = 20;
                    var waitTimeInSeconds = 0;

                    // İşlemin onaylanıp onaylanmadığını kontrol et
                    while (receipt == null && waitTimeInSeconds < maxWaitTimeInSeconds)
                    {
                        await Task.Delay(1000); // 1 saniye bekle
                        receipt = await web3.Eth.Transactions.GetTransactionReceipt.SendRequestAsync(transactionHash);
                        waitTimeInSeconds++;
                    }

                    if (receipt != null)
                    {
                        // İşlem onaylandı
                        MessageBox.Show("Ödeme transferi onaylandı!", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // İşlem onaylanmadı
                        MessageBox.Show("Ödeme transferi onaylanamadı. Belirtilen süre içinde onay alınamadı.", "Onay Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Yetersiz bakiye hatası
                    MessageBox.Show("Yetersiz bakiye!", "Yetersiz Bakiye", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Ödeme transferi bağlantısı sağlanamadı! Cüzdan bakiyesi:" +gonderenBakiye , "Bağlantı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
        // İş arayanın teklif fiyatını veritabanından çek
        private BigInteger GetTeklifFiyatiFromDatabase(int projeId, int isArayanId)
        {
            BigInteger teklifFiyati = 0;


            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT teklif_fiyati FROM basvurular WHERE proje_id = @proje_id AND is_arayan_id = @is_arayan_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@proje_id", projeId);
                        cmd.Parameters.AddWithValue("@is_arayan_id", isArayanId);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            teklifFiyati = Convert.ToUInt64(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Teklif fiyatını alırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return teklifFiyati;
        }

        private void geriBT_Click_1(object sender, EventArgs e)
        {
            MusteriİsTanimlamaEkrani geri = new MusteriİsTanimlamaEkrani();
            geri.Show();
            this.Close();
        }
    }
    public class EthereumTransferContext
    {
        public string AliciAdres { get; set; }
        public string GonderenAdres { get; set; }
        public BigInteger TransferMiktari { get; set; }
        public string TransactionHash { get; set; }
    }
}


