﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Sınıfı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            label1.Text = Convert.ToString(r.Next(895645));
            /*
             * 
             * label1.Text = Convert.ToString(r.Next(11,15));
             * 
             * /
        }
    }
}
