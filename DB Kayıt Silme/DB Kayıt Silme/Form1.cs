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

namespace DB_Kayıt_Silme
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=BAGBRC;Initial Catalog=ogrenciler;Integrated Security=True");
        int id = 0;

        private void veriGoster()
        {
            listView1.Items.Clear();
            con.Open();
            SqlCommand komut = new SqlCommand("select * from bilgiler", con);
            SqlDataReader rd = komut.ExecuteReader();

            while (rd.Read())
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = rd["id"].ToString();
                lv.SubItems.Add(rd["adsoyad"].ToString());
                lv.SubItems.Add(rd["sehir"].ToString());
                listView1.Items.Add(lv);
            }
            con.Close();
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            veriGoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("delete from bilgiler where id=("+id+")",con);
            komut.ExecuteNonQuery();
            con.Close();
            veriGoster();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            
        }
    }
}
