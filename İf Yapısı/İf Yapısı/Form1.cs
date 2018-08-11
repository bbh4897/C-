using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İf_Yapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;

            sayi = Convert.ToInt32(textBox1.Text);
            if(sayi < 10)
            {
                label2.Text = "Sayı 10'dan küçüktür";
                label2.ForeColor = Color.Yellow;
            }
            else
            {
                label2.Text = "Sayı 10'dan büyüktür";
            }
        }
    }
}
