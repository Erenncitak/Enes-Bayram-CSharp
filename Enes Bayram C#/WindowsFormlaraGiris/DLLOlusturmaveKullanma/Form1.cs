using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matematik; // yazdığım kütüphane

namespace DLLOlusturmaveKullanma
{
    public partial class Form1: Form
    {
        MatematikIslemleri matematik  = new MatematikIslemleri();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            lbl_sonuc.Text= matematik.topla(Convert.ToInt32(txt_sayi1.Text), Convert.ToInt32(txt_sayi2.Text)).ToString();
        }

        private void btn_cikarma_Click(object sender, EventArgs e)
        {
            lbl_sonuc.Text = matematik.cikarma(Convert.ToInt32(txt_sayi1.Text), Convert.ToInt32(txt_sayi2.Text)).ToString();
        }

        private void btn_carpma_Click(object sender, EventArgs e)
        {
            lbl_sonuc.Text = matematik.carpma(Convert.ToInt32(txt_sayi1.Text), Convert.ToInt32(txt_sayi2.Text)).ToString();
        }

        private void btn_bolme_Click(object sender, EventArgs e)
        {
            lbl_sonuc.Text = matematik.bolme(Convert.ToDouble(txt_sayi1.Text), Convert.ToDouble(txt_sayi2.Text)).ToString();
        }
    }
}
