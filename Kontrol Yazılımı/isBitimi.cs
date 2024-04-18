using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrol_Yazılımı
{
    public partial class isBitimi : Form
    {
        string connectionString = "Server=localhost;Database=kontrolYazilimiVeriTabani;User ID=root;Password=1234;";
        public isBitimi()
        {
            InitializeComponent();
            ProjeleriDoldur();
        }
        private void gonderBT_Click(object sender, EventArgs e)
        {
            int secilenProjeId = ((ProjeItem)comboBoxProjeler.SelectedItem)?.ProjeId ?? 0;
            int isYapanid = ((ProjeItem)comboBoxProjeler.SelectedItem)?.ProjeId ?? 0;

            if (secilenProjeId != 0)
            {
                // Proje_id'yi kullanarak diğer işlemleri gerçekleştir
                string projeSureci = projeSureciRB.Text;
                DateTime bitisTarihi = dateTimePicker1.Value;
                Kaydet(projeSureci, bitisTarihi, secilenProjeId, isYapanid);

                MessageBox.Show("Proje bilgileri kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir proje seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Kaydet(string projeSureci, DateTime bitisTarihi, int proje_id, int isYapanId)
        {
            try
            {
                // MySQL bağlantı bilgileri
                string connectionString = "Server=localhost;Database=kontrolYazilimiVeriTabani;User ID=root;Password=1234;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL sorgusu
                    string sql = "INSERT INTO tamamlananprojeler (projeSureci, bitisTarihi,proje_id,is_yapan_id) VALUES (@projeSureci, @bitisTarihi,@proje_id,@isYapanId)";

                    // MySQL komut oluştur
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        // Parametreleri ekleyerek SQL sorgusunu hazırla
                        cmd.Parameters.AddWithValue("@projeSureci", projeSureci);
                        cmd.Parameters.AddWithValue("@bitisTarihi", bitisTarihi);
                        cmd.Parameters.AddWithValue("@proje_id", proje_id);
                        cmd.Parameters.AddWithValue("@isYapanId", isYapanId);


                        // Komutu çalıştır
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına kaydetme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ProjeleriDoldur()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT proje_id, baslik FROM projeler";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int projeId = Convert.ToInt32(reader["proje_id"]);
                                string baslik = reader["baslik"].ToString();
                                comboBoxProjeler.Items.Add(new ProjeItem(projeId, baslik));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Projeleri alma sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public class ProjeItem
    {
        public int ProjeId { get; set; }
        public string Baslik { get; set; }
        public int IsArayanId { get; set; }

        public ProjeItem(int projeId, string baslik)
        {
            ProjeId = projeId;
            Baslik = baslik;
        }

        public override string ToString()
        {
            return Baslik;
        }
    }
    public class TamamlananIs
    {
        public int TamamlananId { get; set; }
        public int ProjeId { get; set; }
        public string ProjeSureci { get; set; }
        public DateTime BitisTarihi { get; set; }

        public override string ToString()
        {
            // ListBox'ta görüntülenecek metni oluştur
            return $"{ProjeSureci} - {BitisTarihi}";
        }
    }
}