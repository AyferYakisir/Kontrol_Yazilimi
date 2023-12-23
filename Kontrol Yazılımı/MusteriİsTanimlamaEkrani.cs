using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kontrol_Yazılımı
{
    public partial class MusteriİsTanimlamaEkrani : Form
    {
        private string connectionString = "Server=localhost;Database=kontrolyazılımı;User ID=root;Password=1234;";

        public MusteriİsTanimlamaEkrani()
        {
            InitializeComponent();

            // Proje listesini güncelle
            ProjeListesiniGuncelle();
        }

        private void isEklePB_Click(object sender, EventArgs e)
        {
            isTanimlamaEkrani isEkleForm = new isTanimlamaEkrani();
            isEkleForm.ProjeEklendi += IsEkleForm_ProjeEklendi;
            isEkleForm.Show();
        }

        private void IsEkleForm_ProjeEklendi(object sender, EventArgs e)
        {
            // Proje eklendiğinde burası çalışacak
            ProjeListesiniGuncelle();
        }

        private void ProjeListesiniGuncelle()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT proje_id, baslik, butce, aciklama, tarih FROM projeler";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            listBoxProjeler.Items.Clear();

                            while (reader.Read())
                            {
                                string projeBilgisi = $"{reader["proje_id"]}) Başlık: {reader["baslik"]}, Bütçe: {reader["butce"]}, Açıklama: {reader["aciklama"]}, Tarih: {reader["tarih"]}";
                                listBoxProjeler.Items.Add(projeBilgisi);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Proje listeleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            if (listBoxProjeler.SelectedItem != null)
            {
                string selectedItem = listBoxProjeler.SelectedItem.ToString();
                int index = selectedItem.IndexOf(')');

                if (index != -1)
                {
                    try
                    {
                        int projectId = int.Parse(selectedItem.Substring(0, index));
                        DialogResult result = MessageBox.Show("Seçili projeyi silmek istediğinize emin misiniz?", "Proje Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Proje silme işlemini gerçekleştir
                            ProjeSil(projectId);
                            // Liste güncelle
                            ProjeListesiniGuncelle();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir proje seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
    }

    private void ProjeSil(int projectId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Projeyi veritabanından sil
                    string sqlDelete = "DELETE FROM projeler WHERE proje_id = @proje_id";
                    using (MySqlCommand cmdDelete = new MySqlCommand(sqlDelete, connection))
                    {
                        cmdDelete.Parameters.AddWithValue("@proje_id", projectId);
                        cmdDelete.ExecuteNonQuery();
                    }

                    // Projeyi ListBox'tan da sil
                    listBoxProjeler.Items.Remove(listBoxProjeler.SelectedItem);

                    MessageBox.Show("Proje başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Proje silme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}