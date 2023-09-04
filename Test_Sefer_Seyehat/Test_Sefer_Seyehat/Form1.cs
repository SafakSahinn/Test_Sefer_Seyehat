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

namespace Test_Sefer_Seyehat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-S866UD2;Initial Catalog=TestYolcuBilet;Integrated Security=True");

        void seferListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLSEFERBILGI", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLYOLCUBILGI (AD,SOYAD,TELEFON,TC,CINSIYET,MAIL) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", MskTelefon.Text);
            komut.Parameters.AddWithValue("@P4", MskTc.Text);
            komut.Parameters.AddWithValue("@P5", CmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@P6", TxtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yolcu Bilgileri Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnKaptan_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLKAPTAN (KAPTANNO,ADSOYAD,TELEFON) VALUES (@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtKaptanNo.Text);
            komut.Parameters.AddWithValue("@P2", TxtKaptanAdSoyad.Text);
            komut.Parameters.AddWithValue("@P3", MskKaptanTelefon.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaptan Sisteme Eklendi!");
        }

        private void BtnSeferOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLSEFERBILGI (KALKIS,VARIS,TARIH,SAAT,KAPTAN,FIYAT) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtKalkis.Text);
            komut.Parameters.AddWithValue("@P2", TxtVaris.Text);
            komut.Parameters.AddWithValue("@P3", MskTarih.Text);
            komut.Parameters.AddWithValue("@P4", MskSaat.Text);
            komut.Parameters.AddWithValue("@P5", MskKaptan.Text);
            komut.Parameters.AddWithValue("@P6", TxtFiyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sefer Sisteme Eklendi!");
            seferListesi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seferListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtSeferNumara.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "9";
        }
    }
}
