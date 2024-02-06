using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbBankTest;Integrated Security=True");

        private void LnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKISILER where hesapno=@p1 and sifre=@p2", connection);
            komut.Parameters.AddWithValue("@p1", MskHesapNo.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 frm2 = new Form2();
                frm2.hesap = MskHesapNo.Text;
                frm2.Show();

            }
            else
            {
                MessageBox.Show("Hatalı bilgi");

            }
            connection.Close();

        }
    }
}