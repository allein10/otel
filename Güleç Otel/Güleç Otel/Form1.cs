using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Güleç_Otel
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server = localhost; Database=gulec_otel;Uid=root;Pwd=;");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where KullaniciAdi=@kullaniciadi AND Sifre=@Sifresi";
                MySqlParameter prm1 = new MySqlParameter("kullaniciadi",TxtKullaniciadi.Text);
                MySqlParameter prm2 = new MySqlParameter("Sifresi", TxtKullaniciSifre.Text);

                MySqlCommand komut = new MySqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2)
;
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(komut);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş !");
               
            }
            
        }
    }
}
