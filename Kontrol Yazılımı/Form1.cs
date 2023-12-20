namespace Kontrol_Yazılımı
{
    public partial class AnaGiris : Form
    {
        public AnaGiris()
        {
            InitializeComponent();
        }

        private void musteriCB_CheckedChanged(object sender, EventArgs e)
        {
            if (musteriCB.Checked)
            {
                isArayanCB.Checked = false; // İş Arayan checkbox'ını işaretsiz yap
            }
        }

        private void isArayanCB_CheckedChanged(object sender, EventArgs e)
        {
            // İş Arayan checkbox'u seçildiyse
            if (isArayanCB.Checked)
            {
                musteriCB.Checked = false; // Müşteri checkbox'ını işaretsiz yap
            }
        }

        private void kayitBT_Click(object sender, EventArgs e)
        {
            // Kullanıcı tipini al
            string userType = ""; // Kullanıcı tipini uygun bir şekilde almanız gerekiyor


            if (musteriCB.Checked)
            {
                userType = "Musteri";
            }
            else if (isArayanCB.Checked)
            {
                userType = "IsArayan";
            }
            else
            {
                // Hiçbiri seçili değilse uyarı ver
                MessageBox.Show("Lütfen bir kullanıcı tipi seçin!");
                return;
            }

            if (userType == "Musteri")
            {
                MusteriKayitForm musteriKayitForm = new MusteriKayitForm(userType);
                musteriKayitForm.Show();
                this.Hide();
            }
            else if (userType == "IsArayan")
            {
                IsArayanKayitForm isArayanKayitForm = new IsArayanKayitForm(userType);
                isArayanKayitForm.Show();
                this.Hide();
            }
            else
            {
                // Hiçbiri seçili değilse uyarı ver
                MessageBox.Show("Lütfen bir kullanıcı tipi seçin!");
            }
        }

        private void AnaGirisLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Giriş sayfasına yönlendirme
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
            this.Hide();
        }
    }
}