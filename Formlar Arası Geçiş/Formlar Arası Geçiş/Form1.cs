using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar_Arası_Geçiş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Alanlar Boş Geçilemez!");
                textBox1.Text = "";
                textBox2.Text = "";
            }

            if (textBox1.Text == "Admin" && textBox2.Text == "123456")
            {
                MessageBox.Show("Giriş Başarılı. İkinci Sayfaya Yönlendiriliyorsunuz.");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız. Bilgilerinizi Kontrol Ediniz.");
                textBox1.Text = "";
                textBox2.Text = "";
            }


            
            
        }
    }
}
