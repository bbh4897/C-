using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karenin_Alanı_ve_Çevresi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kenar, alan, cevre;

            kenar = Convert.ToInt32(textBox1.Text);
            alan = kenar * kenar;
            cevre = 4 * kenar;

            label4.Text = Convert.ToString(alan);
            label5.Text = Convert.ToString(cevre);
        }
    }
}
