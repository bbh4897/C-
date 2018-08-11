using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kare_Dikdörtgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kenar = Convert.ToInt32(textBox1.Text);
            int alan = kenar * kenar;
            int cevre = 4 * kenar;

            label6.Text = Convert.ToString(alan);
            label7.Text = Convert.ToString(cevre);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;

           

        }

      

        private void button4_Click_1(object sender, EventArgs e)
        {
            int kisa_kenar = Convert.ToInt32(textBox2.Text);
            int uzun_kenar = Convert.ToInt32(textBox3.Text);

            int alan2 = kisa_kenar * uzun_kenar;
            int cevre2 = 2 * (kisa_kenar + uzun_kenar);
            label10.Text = Convert.ToString(alan2);
            label11.Text = Convert.ToString(cevre2);
        }
    }
}
