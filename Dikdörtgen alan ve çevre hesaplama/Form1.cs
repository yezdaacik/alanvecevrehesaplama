using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dikdörtgen_alan_ve_çevre_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int kisakenar = Convert.ToInt32(txtKisakenar.Text);
            int uzunkenar = Convert.ToInt32(txtUzunkenar.Text);
            int cevre = 2 * (kisakenar + uzunkenar);
            int alan = kisakenar * uzunkenar;

            lblAlan.Text = "Alan: " + alan;
            lblCevre.Text = "Çevre: " +cevre;
        }
    }
}
