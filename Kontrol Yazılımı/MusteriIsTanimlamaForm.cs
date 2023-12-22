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
        private string connectionString = "Server=localhost;Database=kontrolyazılımı;User ID=root;Password=1234;";
        public MusteriIsTanimlamaForm()
        {
            InitializeComponent();
            GB1.Visible = false;
            GB2.Visible = false;
            GB3.Visible = false;
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
            GB1.Visible = true; GB2.Visible=true; GB3.Visible=true;

        }

        private void baslikTB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void butceTB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tarihTB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aciklamaRB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PB1_Click(object sender, EventArgs e)
        {

        }

        private void GB1_Enter(object sender, EventArgs e)
        {

        }

        private void GB2_Enter(object sender, EventArgs e)
        {

        }

        private void GB3_Enter(object sender, EventArgs e)
        {

        }
    }
}
