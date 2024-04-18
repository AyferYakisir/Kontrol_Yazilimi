using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Kontrol_Yazılımı;

namespace WhiteBoxTests
{
    [TestClass]
    public class MusteriKayitFormTests
    {
        [TestMethod]
        public void MusteriKayit_BasariliKayit()
        {
            // Hazırla (Arrange)
            MusteriKayitForm musteriKayitForm = new MusteriKayitForm("Musteri", 0); // Bakiyesiz kayıt

            // Kayıt için değerleri ayarla
            musteriKayitForm.mAdTB.Text = "Ayfer";
            musteriKayitForm.mSoyadTB.Text = "Yakışır";
            musteriKayitForm.mEpostaTB.Text = "ayfer@gmail.com";
            musteriKayitForm.mSifreTB.Text = "1234";
            musteriKayitForm.mUlkeCB.SelectedItem = "Türkiye";

            // Eylem (Act)
            musteriKayitForm.mKayitBT_Click(null, null);

            // Doğrula (Assert)
            // Aşağıdaki satır, kayıt işlemi sonrasında GirisForm ekranının görünüp görünmediğini kontrol eder.
            Assert.IsTrue(musteriKayitForm.Visible == false && System.Windows.Forms.Application.OpenForms["GirisForm"] != null);
        }

        [TestMethod]
        public void TestGecersizKayit()
        {
            // Hazırla (Arrange)
            MusteriKayitForm musteriKayitForm = new MusteriKayitForm("Musteri", 0); // Bakiyesiz kayıt
            // Geçersiz verilerle dolduruluyor (örneğin, boş alanlar)
            musteriKayitForm.mAdTB.Text = "";
            musteriKayitForm.mSoyadTB.Text = "";
            musteriKayitForm.mEpostaTB.Text = "";
            musteriKayitForm.mSifreTB.Text = "";
            musteriKayitForm.mUlkeCB.SelectedItem = "";

            // Eylem (Act)
            musteriKayitForm.mKayitBT_Click(null, null);

            // Doğrula (Assert)
            // Aşağıdaki satır, kayıt işlemi sonrasında GirisForm ekranının görünüp görünmediğini kontrol eder.
            Assert.IsTrue(musteriKayitForm.Visible == false && System.Windows.Forms.Application.OpenForms["GirisForm"] != null);
        }


    }
}