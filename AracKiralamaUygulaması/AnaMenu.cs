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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost; port=3306; database=AracKiralamaUygulamasi; password=akin123; user=root");
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        DataSet ds;

        private void button1_Click(object sender, EventArgs e)
        {



            MySqlCommand cmd2 = new MySqlCommand();
            con.Open();
            cmd2.Connection = con;

            string tc = textBox3.Text;

            // Aynı TC numarasına sahip kayıt var mı kontrolü
            MySqlCommand checkCommand = new MySqlCommand("SELECT COUNT(*) FROM musteriBilgisi WHERE tc = @tc", con);
            checkCommand.Parameters.AddWithValue("@tc", tc);
            int count = Convert.ToInt32(checkCommand.ExecuteScalar());

            if (count > 0)
            {
                // Hata mesajı ver
                MessageBox.Show("Bu TC numarası zaten kayıtlıdır.");
            }
            else
            {
                // Yeni müşteri kaydını gerçekleştir
                cmd2.CommandText = "INSERT INTO musteriBilgisi(ad,soyad,cinsiyet,tc,telefon,araclistele,vitestipi,baslangicgunu,bitisgunu) " +
                    "VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "' ,'" + textBox3.Text + "'," + textBox4.Text + ",'" + comboBox2.Text + "','" + comboBox3.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')";

                cmd2.ExecuteNonQuery();
                MessageBox.Show("Müşteri başarıyla kaydedildi.");
            }

            con.Close();



        }

        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new MySqlDataAdapter("Select * From musteribilgisi WHERE tc = " + textBox5.Text + " ", con);
            ds = new DataSet();

            da.Fill(ds, "musteribilgisi");
            dataGridView1.DataSource = ds.Tables["musteribilgisi"];
            con.Close();
        }

        private void araçSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox4.Visible = true;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
