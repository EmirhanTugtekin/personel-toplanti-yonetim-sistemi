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
    public partial class Personel_Ekle : Form
    {
        public Personel_Ekle()
        {
            InitializeComponent();
        }

        SqlConnection connection3 = new SqlConnection(@"Data Source =DESKTOP-7T6V6AG\SQLEXPRESS;
        Initial Catalog=Db1;Integrated Security=True");

        private void Personel_Ekle_Load(object sender, EventArgs e)
        {

        }

        private void btnPersEkle_Click(object sender, EventArgs e)
        {
            connection3.Open();
            SqlCommand command3 = new SqlCommand
                ("insert into personelTablosu (ad,soyad,unvan,telefon,mail) values(@p1,@p2,@p3,@p4,@p5)", connection3);
            command3.Parameters.AddWithValue("@p1", txtyeniPersAD.Text);
            command3.Parameters.AddWithValue("@p2", txtyeniPersSOYAD.Text);
            command3.Parameters.AddWithValue("@p3", txtyeniPersUnvan.Text);
            command3.Parameters.AddWithValue("@p4", mskyeniPersTlfn.Text);
            command3.Parameters.AddWithValue("@p5", txtYeniPersMail.Text);

            command3.ExecuteNonQuery();
            connection3.Close();

            MessageBox.Show("personel eklendi","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
