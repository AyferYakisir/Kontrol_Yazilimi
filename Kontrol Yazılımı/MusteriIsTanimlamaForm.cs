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
        private string connectionString = "Server=localhost;Database=kontrolyazılımı;User ID=root;Password=sgaftabs;";
        public MusteriIsTanimlamaForm()
        {
            InitializeComponent();
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

        }

    }
}
