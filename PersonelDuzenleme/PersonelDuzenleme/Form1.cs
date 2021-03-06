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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source =DESKTOP-7T6V6AG\SQLEXPRESS;
        Initial Catalog=Db1;Integrated Security=True");

        void bolumListesi()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from bolumlerTablosu", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbBolum.ValueMember = "bolumID";
            cmbBolum.DisplayMember = "bolumID";
            cmbBolum.DataSource = dt;
        }

        void toplantilistesi()
        {
            SqlDataAdapter sda3 = new SqlDataAdapter("execute toplantim",connection);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bolumListesi();
            toplantilistesi();
        }

        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda2 = new SqlDataAdapter("select * from yoneticiTablosu where bolumID=" + cmbBolum.SelectedValue, connection);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            cmbBolumSorumlusu.ValueMember = "yoneticiID";
            cmbBolumSorumlusu.DisplayMember = "ad";
            cmbBolumSorumlusu.DataSource = dt2;
        }

        private void btnToplantiOlustur_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into toplantiTablosu (bolumID,yoneticiID,tarih,saat) values (@p1,@p2,@p3,@p4)", connection);

            command.Parameters.AddWithValue("@p1", cmbBolum.SelectedValue);
            command.Parameters.AddWithValue("@p2", cmbBolumSorumlusu.SelectedValue);
            command.Parameters.AddWithValue("@p3", mskTarih.Text);
            command.Parameters.AddWithValue("@p4", mskSaat.Text);

            command.ExecuteNonQuery(); //sorguyu çalıştırıp değişiklikleri gerçekleştirir.

            connection.Close();
            MessageBox.Show("yeni toplantı oluşturuldu","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;

            textBox2.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();

        }

        private void btnToplantiVer_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command2 = new SqlCommand
                ("update toplantiTablosu set yoneticiID=@p1 where toplantiID=@p2", connection);
            command2.Parameters.AddWithValue("@p1", textBox2.Text);
            command2.Parameters.AddWithValue("@p2", textBox1.Text);
            command2.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Toplantının yöneticisi değiştirildi", "BİLGİ", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            Personel_Ekle fr2 = new Personel_Ekle();
            fr2.Show();
            
        }

        private void btnYoneticiEkle_Click(object sender, EventArgs e)
        {
            yonetici_ekle fr3 = new yonetici_ekle();
            fr3.Show();
        }
    }
}
