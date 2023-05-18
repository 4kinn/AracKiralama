using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AracKiralamaUygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void YuklemeBaslat()
        {
            this.Show();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
        }
        public void Yukleniyor(int yuzde)
        {
            progressBar1.Value = yuzde;
            Application.DoEvents();
        }
        public void YuklemeTamamlandi()
        {
            Form1 giris = new Form1();
            progressBar1.Value = 100;
            giris.Show();
            this.Close();
        }
        

    }
}
