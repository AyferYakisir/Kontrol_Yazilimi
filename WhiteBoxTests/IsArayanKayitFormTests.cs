using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kontrol_Yazılımı;
namespace WhiteBoxTests
{
    [TestClass]
    public class IsArayanKayitFormTests
    {
        [TestMethod]
        public void TestBasariliKayit()
        {
            // Hazırla (Arrange)
            var kayitForm = new IsArayanKayitForm("IsArayan", 0);
            kayitForm.iAdTB.Text = "Gamze";
            kayitForm.iSoyadTB.Text = "Anamas";
            kayitForm.iEpostaTB.Text = "gamze@gmail.com";
            kayitForm.iSifreTB.Text = "7890";
            kayitForm.iUlkeCB.SelectedItem = "Türkiye";   // test senaryosuna göre girdi alır!

            // Eylem (Act)
            kayitForm.iKayitBT_Click(null, null);

            // Doğrula (Assert)
            // Örneğin, kayıt sonrası GirişForm'un görünüp görünmediğini kontrol edebiliyor.
            Assert.IsTrue(!kayitForm.Visible && System.Windows.Forms.Application.OpenForms["GirisForm"] != null);
        }

        [TestMethod]
        public void TestGecersizKayit()
        {
            // Hazırla (Arrange)
            var kayitForm = new IsArayanKayitForm("IsArayan", 0);
            // Geçersiz verilerle dolduruluyor (örneğin, boş alanlar)
            kayitForm.iAdTB.Text = "";
            kayitForm.iSoyadTB.Text = "";
            kayitForm.iEpostaTB.Text = "";
            kayitForm.iSifreTB.Text = "";
            kayitForm.iUlkeCB.SelectedItem = "";

            // Eylem (Act)
            kayitForm.iKayitBT_Click(null, null);

            // Doğrula (Assert)
            // Aşağıdaki satır, kayıt işlemi sonrasında GirisForm ekranının görünüp görünmediğini kontrol eder.
            Assert.IsTrue(kayitForm.Visible == false && System.Windows.Forms.Application.OpenForms["GirisForm"] != null);
        }
    }
}