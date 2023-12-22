using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrol_Yazılımı
{
    public partial class MusteriIsTanimlamaForm : Form
    {
        private ProjeBilgisi projeBilgisi;
        private string connectionString = "Server=localhost;Database=kontrolyazılımı;User ID=root;Password=1234;";
        public MusteriIsTanimlamaForm()
        {
            InitializeComponent();
            projeBilgisi = new ProjeBilgisi();
            GB1.Visible = false;
            GB2.Visible = false;
            GB3.Visible = false;
            projeBilgisi = new ProjeBilgisi();

            // PictureBox olaylarını ayarla
            PictureBoxOlaylariniAyarla(this);
        }


        private void isTanimlamaPB_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Yeni iş Tanimlama", isTanimlamaPB);
        }

        private void isTanimlamaPB_Click(object sender, EventArgs e)
        {
            isTanimlamaEkrani isTanimla = new isTanimlamaEkrani();
            isTanimla.Show();
            // isTanimlamaEkrani'nden alınan bilgileri kullan
            GB1.Visible = true; GB2.Visible = true; GB3.Visible = true;

        }

        public void ProjeBilgisiGuncelle(ProjeBilgisi yeniBilgi)
        {
            projeBilgisi = yeniBilgi;

            // GroupBox'ları göster ve bilgileri yerleştir
            GB1.Visible = true;
            // Diğer GroupBox'ları da göster...

            baslikTB1.Text = projeBilgisi.Baslik;
            butceTB1.Text = projeBilgisi.Butce;
            aciklamaRB1.Text = projeBilgisi.Aciklama;
            tarihTB1.Text = projeBilgisi.Tarih.ToString();
        }
        private void PictureBoxTiklandi(object sender, EventArgs e)
        {
           PictureBox pictureBox = sender as PictureBox;
    if (pictureBox != null)
    {
        // PictureBox'ın Tag özelliğinden projeId'yi al
        if (pictureBox.Tag != null && int.TryParse(pictureBox.Tag.ToString(), out int projeId))
        {
            // Proje bilgilerini veritabanından sil
            ProjeBilgileriniSil(projeId);

            // PictureBox'ın bulunduğu GroupBox'ı kaldır
            KullanilanGroupBoxGizle(pictureBox.Parent as GroupBox);
        }
        else
        {
            MessageBox.Show("Hata: Proje ID değeri alınamadı veya geçersiz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
        }
        private void ProjeBilgileriniSil(int projeId)
        {
           
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM projeler WHERE proje_id = @proje_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@proje_id", projeId);

                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Proje bilgileri başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Hata: Belirtilen proje bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Proje bilgilerini silme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void KullanilanGroupBoxGizle(GroupBox groupBox)
        {
            // İlgili GroupBox'ı gizle
            if (groupBox != null)
            {
                groupBox.Visible = false;
            }
        }

        // PictureBox'ların tıklanma olaylarına bu metodun atanması
        private void PictureBoxOlaylariniAyarla(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is PictureBox)
                {
                    // PictureBox'a tıklanıldığında çalışacak olayı belirt
                    (control as PictureBox).Click += PictureBoxTiklandi;
                }
                else if (control is GroupBox)
                {
                    // GroupBox içindeki PictureBox'ları ele almak için
                    PictureBoxOlaylariniAyarla(control);
                }
            }
        }

    }
}