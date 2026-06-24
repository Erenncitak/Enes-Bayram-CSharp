using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxNesnesiKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile("C://Users//erenn//OneDrive//Desktop//klipartz.com");
            if(txt_kullaniciAdi.Text.ToLower() =="eren" && txt_sifre.Text.ToLower() == "123")
            {
                MessageBox.Show("Başarılı bir şekilde giriş yaptınız.!!", "Bilgilendirme");
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre !!", "Bilgilendirme");
            }
        }
    }
}
