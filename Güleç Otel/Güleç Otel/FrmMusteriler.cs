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
    public partial class FrmMusteriler : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server = localhost; Database=gulec_otel;Uid=root;Pwd=;");
        private void verilerigoster() {
            listView1.Items.Clear();
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select*from Musteri_Ekle1",baglanti);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read()) {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Müsteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["OdaNO"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            oku.Close();
            baglanti.Close();
        }
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text=listView1.SelectedItems[0].SubItems[1].Text;
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[3].Text;
            TxtTcno.Text = listView1.SelectedItems[0].SubItems[4].Text;
            Txtmail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[7].Text;
            DtpGiris.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpCikis.Text = listView1.SelectedItems[0].SubItems[9].Text;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtOdaNo.Text == "101")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from Oda101 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "102")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from Oda102 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "103")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from Oda103 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "104")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from Oda104 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "105")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from Oda105 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "106")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from Oda106 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "107")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from Oda107 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "108")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from Oda108 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (TxtOdaNo.Text == "109")
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from Oda109 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            MskTxtTelefon.Clear();
            TxtTcno.Clear();
            Txtmail.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGiris.Text = "";
            DtpCikis.Text = "";
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("update Musteri_Ekle1 set Adi='" + TxtAdi.Text + "',Soyadi='" + TxtSoyadi.Text + "',Telefon='" + MskTxtTelefon.Text + "" + "',TC='" + TxtTcno.Text + "',Mail='" + Txtmail.Text + "',OdaNo='" + TxtOdaNo.Text + "',Ucret='" + TxtUcret.Text + "',GirisTarihi='" + DtpGiris.Text + "',CikisTarihi='" + DtpCikis.Text + "'where Müsteriid=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {

            MySqlConnection baglanti = new MySqlConnection("Server = localhost; Database=gulec_otel;Uid=root;Pwd=;");

            listView1.Items.Clear();
                baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select*from Musteri_Ekle1 where Adi like'%" + textBox1.Text + "%'", baglanti);
                MySqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["Müsteriid"].ToString();
                    ekle.SubItems.Add(oku["Adi"].ToString());
                    ekle.SubItems.Add(oku["Soyadi"].ToString());
                    ekle.SubItems.Add(oku["Telefon"].ToString());
                    ekle.SubItems.Add(oku["TC"].ToString());
                    ekle.SubItems.Add(oku["Mail"].ToString());
                    ekle.SubItems.Add(oku["OdaNO"].ToString());
                    ekle.SubItems.Add(oku["Ucret"].ToString());
                    ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                    ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                    listView1.Items.Add(ekle);
                }
                baglanti.Close();
            
        }
    }
}

//            SqlCommand komut = new SqlCommand("delete from Musteri_Ekle1 where Müsteriid=("+id+")",baglanti);

