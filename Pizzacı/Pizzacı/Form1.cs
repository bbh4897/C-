﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzacı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);

            if (checkBox1.Checked) { label13.Text = checkBox1.Text; }
            if (checkBox2.Checked) { label14.Text = checkBox2.Text; }
            if (checkBox3.Checked) { label15.Text = checkBox3.Text; }
            if (checkBox4.Checked) { label16.Text = checkBox4.Text; }
            if (checkBox5.Checked) { label17.Text = checkBox5.Text; }
            if (checkBox6.Checked) { label18.Text = checkBox6.Text; }
            
            listBox6.Items.Add(label13.Text + label14.Text + label15.Text + label16.Text + label17.Text + label18.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text="";
            comboBox2.Text = "";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
