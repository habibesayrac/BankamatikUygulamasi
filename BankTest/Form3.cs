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

namespace BankTest
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbBankTest;Integrated Security=True");

        void temizle()
        {
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MskTc.Text = "";
            MskTelefon.Text = "";
            MskHesapNo.Text = "";
            TxtSifre.Text = "";
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKISILER (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)",connection);

            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTc.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", MskHesapNo.Text);
            komut.Parameters.AddWithValue("@p6", TxtSifre.Text);

            komut.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Hesap Eklendi");
            temizle();
        }

        private void BtnHesap_Click(object sender, EventArgs e)
        {
            Random random= new Random();
            int randomHesapNo = random.Next(100000, 1000000);
            MskHesapNo.Text = randomHesapNo.ToString();
        }
    }
}
