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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbBankTest;Integrated Security=True");

        public string hesap;
        private void Form2_Load(object sender, EventArgs e)
        {
            LblHesap.Text = hesap;
            connection.Open();

            SqlCommand komut = new SqlCommand("Select*from TBLKISILER where hesapno=@p1", connection);
            komut.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAd.Text = dr[1] + " " + dr[2];
                LblTc.Text = dr[3].ToString();
                LblTelefon.Text = dr[4].ToString();


            }
            connection.Close();
        }
        private void BtnGonder_Click(object sender, EventArgs e)
        {
            //Gönderilen hesabın para artışı
            connection.Open();
            SqlCommand komut = new SqlCommand("update TBLHESAP set bakiye=bakiye+@p1 where hesapno=@p2", connection);
            komut.Parameters.AddWithValue("@p1", decimal.Parse(TxtTutar.Text));
            komut.Parameters.AddWithValue("@p2", MskHesapNo.Text);
            komut.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("İşlem Gerçekleşti");

            //Gönderen hesabın Para azalışı

            connection.Open();
            SqlCommand komut2 = new SqlCommand("update TBLHESAP set bakiye=bakiye-@k1 where hesapno=@k2", connection);
            komut2.Parameters.AddWithValue("@k1", decimal.Parse(TxtTutar.Text));
            komut2.Parameters.AddWithValue("@k2", hesap);
            komut2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("İşlem Gerçekleşti");



        }
    }
}