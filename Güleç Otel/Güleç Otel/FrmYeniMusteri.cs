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
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server = localhost; Database=gulec_otel;Uid=root;Pwd=;");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into Oda101 (Adi,Soyadi) values ( '" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into Oda102 (Adi,Soyadi) values ( '" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into Oda103 (Adi,Soyadi) values ( '" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into Oda104 (Adi,Soyadi) values ( '" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into Oda105 (Adi,Soyadi) values ( '" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into Oda106 (Adi,Soyadi) values ( '" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into Oda107 (Adi,Soyadi) values ( '" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into Oda108 (Adi,Soyadi) values ( '" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into Oda109 (Adi,Soyadi) values ( '" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOdaDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dolu Odaları Gösterir");
        }

        private void BtnOdaBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boş Odaları Gösterir");
        }

        private void DtpCikis_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGiris.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikis.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            label10.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(label10.Text) * 50;
            TxtUcret.Text = Ucret.ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("insert into Musteri_Ekle1 (Adi,Soyadi,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + MskTxtTelefon.Text + "','" + Txtmail.Text + "','" + TxtTcno.Text + "','" + TxtOdaNo.Text + "' ,'" + TxtUcret.Text + "','" + Convert.ToDateTime(DtpGiris.Text) + "','" + Convert.ToDateTime(DtpCikis.Text) + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydedildi!");
            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message);
            }

            baglanti.Close();
            

        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut1 = new MySqlCommand("select * from Oda101", baglanti);
            MySqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                BtnOda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
                BtnOda101.Enabled = false;
            }
            baglanti.Open();
            MySqlCommand komut2 = new MySqlCommand("select * from Oda102", baglanti);
            MySqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BtnOda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
                BtnOda103.Enabled = false;
            }
            baglanti.Open();
            MySqlCommand komut3 = new MySqlCommand("select * from Oda103", baglanti);
            MySqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BtnOda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
                BtnOda103.Enabled = false;
            }
            baglanti.Open();
            MySqlCommand komut4 = new MySqlCommand("select * from Oda104", baglanti);
            MySqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BtnOda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
                BtnOda104.Enabled = false;
            }
            baglanti.Open();
            MySqlCommand komut5 = new MySqlCommand("select * from Oda105", baglanti);
            MySqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BtnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
                BtnOda105.Enabled = false;
            }
            baglanti.Open();
            MySqlCommand komut6 = new MySqlCommand("select * from Oda106", baglanti);
            MySqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BtnOda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.Red;
                BtnOda106.Enabled = false;
            }
            baglanti.Open();
            MySqlCommand komut7 = new MySqlCommand("select * from Oda107", baglanti);
            MySqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BtnOda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda107.Text != "107")
            {
                BtnOda107.BackColor = Color.Red;
                BtnOda107.Enabled = false;
            }
            baglanti.Open();
            MySqlCommand komut8 = new MySqlCommand("select * from Oda108", baglanti);
            MySqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                BtnOda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda108.Text != "108")
            {
                BtnOda108.BackColor = Color.Red;
                BtnOda108.Enabled = false;
            }
            baglanti.Open();
            MySqlCommand komut9 = new MySqlCommand("select * from Oda109", baglanti);
            MySqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                BtnOda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda109.Text != "109")
            {
                BtnOda109.BackColor = Color.Red;
                BtnOda109.Enabled = false;
            }
        }
    }
    
}


//Data Source=DESKTOP-7ODA2GB\SQLEXPRESS01;Initial Catalog="Gulec Otel";//Integrated Security=True