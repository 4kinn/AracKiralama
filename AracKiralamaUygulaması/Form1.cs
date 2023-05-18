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
    public partial class Form1 : Form

    {

        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost; port=3306; database=AracKiralamaUygulamasi; password=akin123; user=root");
        MySqlCommand cmd;
        MySqlDataReader dr;

        AnaMenu amenu = new AnaMenu();
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
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM giris WHERE kullaniciAdi=@kullaniciAdi AND sifre=@sifre");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@kullaniciAdi", textBox1.Text);
                    cmd.Parameters.AddWithValue("@sifre", textBox2.Text);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Giriş başarılı.");
                        amenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz.");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KAYITOL ko = new KAYITOL();
            ko.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
