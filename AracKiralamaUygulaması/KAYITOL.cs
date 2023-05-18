using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaUygulaması
{
    public partial class KAYITOL : Form
    {
        public KAYITOL()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost; port=3306; database=arackiralamauygulamasi; password=akin123; user=root");
        Form1 amenu = new Form1();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                { 
                    MessageBox.Show("Lütfen boş yer bırakmayınız");
                }
                else
                { 
                    MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(*) FROM giris WHERE kullaniciadi=@kullaniciadi", con);
                cmd2.Parameters.AddWithValue("@kullaniciadi", textBox1.Text);
                con.Open();
                int count = Convert.ToInt32(cmd2.ExecuteScalar());
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor!");
                    return;
                }

                MySqlCommand cmd3 = new MySqlCommand();
                cmd3.Connection = con;
                con.Open();
                cmd3.CommandText = "INSERT INTO giris(kullaniciadi,sifre) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')";
                cmd3.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Kayıt Başarılı");
                amenu.Show();
                this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
            }
        }


        private void KAYITOL_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            amenu.Show();
            this.Hide();
        }
    }
}
