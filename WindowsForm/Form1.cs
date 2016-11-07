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
        //Domates Fiyat Hesaplama
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal domatesFiyat = domatesBirimFiyat.Value * domatesKilo.Value;
            nmDomates.Value += nmDomates.Value;
            tutarNm.Value = domatesFiyat;
        }
        
        //Salatalık Fiyat Hesaplama
        private void btnSalatalik_Click(object sender, EventArgs e)
        {
            decimal salatalikFiyat = salatalıkBirimFiyat.Value * salatalikKilo.Value;
            nmSalatalik.Value = salatalikFiyat + nmSalatalik.Value;
            tutarNm.Value = nmSalatalik.Value;
        }
        //Biber Fiyat Hesaplama
        private void btnBiber_Click(object sender, EventArgs e)
        {
            decimal biberFiyat = biberBirimFiyat.Value * biberKilo.Value;
            nmBiber.Value = biberFiyat + nmBiber.Value;
        }

        //Armut Fiyat Hesaplama
        private void btnArmut_Click_1(object sender, EventArgs e)
        {   
            decimal armutFiyat = armutBirimFiyat.Value * armutKilo.Value;
            nmArmut.Value = armutFiyat + tutarNm.Value;
        }
    }
}
