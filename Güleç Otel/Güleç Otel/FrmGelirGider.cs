using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using MySql.Data.MySqlClient;
namespace Güleç_Otel
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server = localhost; Database=gulec_otel;Uid=root;Pwd=;");
        private void FrmGelirGider_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kasadaki Toplam Tutar
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select sum(Ucret) as toplam from Musteri_Ekle1",baglanti);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            //Stok Gider (Gıda)
            baglanti.Open();
            MySqlCommand komut1 = new MySqlCommand("select sum(Gida) as toplam1 from Stok", baglanti);
            MySqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                LblAlınanUrun1.Text = oku1["toplam1"].ToString();
            }
            baglanti.Close();

            //Stok Gider (İçecek)
            baglanti.Open();
            MySqlCommand komut2 = new MySqlCommand("select sum(Icecek) as toplam2 from Stok", baglanti);
            MySqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                LblAlınanUrun2.Text = oku2["toplam2"].ToString();
            }
            baglanti.Close();

            //Stok Gider (Atıştırmalık)
            baglanti.Open();
            MySqlCommand komut3 = new MySqlCommand("select sum(Atistirmalık) as toplam3 from Stok", baglanti);
            MySqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                LblAlınanUrun3.Text = oku3["toplam3"].ToString();
            }
            baglanti.Close();

            //Faturalar (Elektrik)
            baglanti.Open();
            MySqlCommand komut4 = new MySqlCommand("select sum(Elektrik) as toplam4 from Faturalar", baglanti);
            MySqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                LblElektrik.Text = oku4["toplam4"].ToString();
            }
            baglanti.Close();

            //Faturalar (Su)
            baglanti.Open();
            MySqlCommand komut5 = new MySqlCommand("select sum(Su) as toplam5 from Faturalar", baglanti);
            MySqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                LblSu.Text = oku5["toplam5"].ToString();
            }
            baglanti.Close();

            //Faturalar (Elektrik)
            baglanti.Open();
            MySqlCommand komut6 = new MySqlCommand("select sum(Internet) as toplam6 from Faturalar", baglanti);
            MySqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                Lblinternet.Text = oku6["toplam6"].ToString();
            }
            baglanti.Close();


            int personel;
            personel = Convert.ToInt32(textBox1.Text);
            LblPersonelMaas.Text = (personel * 1000).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(LblKasaToplam.Text) - (Convert.ToInt32(LblPersonelMaas.Text)+ Convert.ToInt32(LblAlınanUrun1.Text)+ Convert.ToInt32(LblAlınanUrun2.Text)+ Convert.ToInt32(LblAlınanUrun3.Text)+ Convert.ToInt32(LblElektrik.Text)+ Convert.ToInt32(LblSu.Text)+ Convert.ToInt32(Lblinternet.Text));
            LblSonuc.Text = Convert.ToString(sonuc);
        }
    }
}
