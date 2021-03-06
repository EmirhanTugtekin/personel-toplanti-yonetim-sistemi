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

namespace PersonelDuzenleme
{
    public partial class yonetici_ekle : Form
    {
        public yonetici_ekle()
        {
            InitializeComponent();
        }

        SqlConnection connection2 = new SqlConnection(@"Data Source =DESKTOP-7T6V6AG\SQLEXPRESS;
        Initial Catalog=Db1;Integrated Security=True");

        private void yonetici_ekle_Load(object sender, EventArgs e)
        {

        }

        private void btnYoneticiEkle_Click(object sender, EventArgs e)
        {
            connection2.Open();
            SqlCommand command4 = new SqlCommand
                ("insert into yoneticiTablosu (ad,soyad,bolumID) values (@p1,@p2,@p3)", connection2);
            command4.Parameters.AddWithValue("@p1", txtYeniYonAD.Text);
            command4.Parameters.AddWithValue("@p2", txtYeniYonSoyad.Text);
            command4.Parameters.AddWithValue("@p3", txtYeniYonBolumID.Text);
            command4.ExecuteNonQuery();
            connection2.Close();

            MessageBox.Show("yönetici eklendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
