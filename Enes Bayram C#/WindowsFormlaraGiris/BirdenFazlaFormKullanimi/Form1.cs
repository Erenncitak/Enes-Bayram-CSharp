using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdenFazlaFormKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_giris_Click_1(object sender, EventArgs e)
        {
            if (txt_kullaniciAdi.Text.ToLower() == "eren" && txt_sifre.Text == "123")
            {
                // farklı bir forma yönelndir
                anasayfa anasayfa = new anasayfa();
                anasayfa.lbl_deger.Text = txt_kullaniciAdi.Text.ToUpper();
                anasayfa.Show();

                // this: şuanda üzerinde bulunmuş olduğum form anlamına gelir.
                this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalı Giriş", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
