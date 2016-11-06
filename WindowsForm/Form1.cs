using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)

        {

            string kdv;

            //Domates Fiyat Hesaplama
            decimal domatesFiyat = domatesBirimFiyat.Value * domatesKilo.Value;

            //Armut Fiyat Hesaplama
            decimal armutFiyat = domatesBirimFiyat.Value * domatesKilo.Value;

            //Salatalık Fiyat Hesaplama
            decimal salatalikFiyat = salatalıkBirimFiyat.Value * salatalikKilo.Value;

            //Biber Fiyat Hesaplama
            decimal biberFiyat = salatalıkBirimFiyat.Value * salatalikKilo.Value;

            tutarNm.Value = domatesFiyat;

        }
    }
}
