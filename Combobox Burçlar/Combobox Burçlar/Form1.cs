using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox_Burçlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
            pictureBox1.ImageLocation = "D:/PROJELER/C#/Combobox Burçlar/Combobox Burçlar/bin/balik.jpg";
        }
    }
}
