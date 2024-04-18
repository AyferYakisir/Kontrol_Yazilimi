using Kontrol_Yazılımı;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WhiteBoxTests
{
    [TestClass]
    public class GirisFormTests
    {
        [TestMethod]
        public void Giris_Basarili()
        {
            // Arrange
            var form = new GirisForm();
            var eposta = "ayfer@gmail.com";
            var sifre = "1234";

            // Act
            form.gEpostaTB.Text = eposta;
            form.gSifreTB.Text = sifre;
            form.girisBT_Click_1(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(form.Visible == false);
        }

        [TestMethod]
        public void Giris_Basarisiz()
        {
            // Arrange
            var form = new GirisForm();
            var eposta = "gecersizEposta";
            var sifre = "gecersizSifre";

            // Act
            form.gEpostaTB.Text = eposta;
            form.gSifreTB.Text = sifre;
            form.girisBT_Click_1(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(form.Visible == false);
            Assert.IsTrue(form.gEpostaTB.Text == "gecersizEposta");
            Assert.IsTrue(form.gSifreTB.Text == "gecersizSifre");
            // Ayrıca, uygun bir hata mesajı kontrolü de ekleyebilirsiniz.
        }

        [TestMethod]
        public void Giris_Hata()
        {
            // Arrange
            var form = new GirisForm();
            var eposta = "";
            var sifre = "";

            form.connectionString = "Server=localhost;Database=kontrolYazilimiVeriTabani;User ID=root;Password=1234;";

            // Act
            form.gEpostaTB.Text = eposta;
            form.gSifreTB.Text = sifre;
            form.girisBT_Click_1(null, EventArgs.Empty);

            // Assert
            Assert.IsTrue(form.Visible == false); // Giriş başarısız olduğu için form hala görünür olmalıdır.
          
        }
    }
}