using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_Veri_Ekleme
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=BAGBRC;Initial Catalog=ogrenciler;Integrated Security=True");

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sc = new SqlCommand("insert into bilgiler(adsoyad, sehir) values('"+textBox1.Text.ToString()+ "','"+textBox2.Text.ToString()+"')",con);
            sc.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarıyla Gerçekleşti");
            this.Hide();
        }
    }
}
