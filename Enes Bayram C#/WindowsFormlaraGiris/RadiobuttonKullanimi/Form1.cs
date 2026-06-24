using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiobuttonKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            string ad, soyad, cinsiyet = "";
            ad = txt_ad.Text;
            soyad=txt_soyad.Text;
            if(radio_erkek.Checked)
            {
                cinsiyet = "Erkek";
            }
            else
            {
                cinsiyet = "Kadın";
            }

            MessageBox.Show("Adınız: " + ad + "\n" + "Soyadınız: " + soyad + "\n" + "Cinsiyet: " + cinsiyet);

        }
    }
}
