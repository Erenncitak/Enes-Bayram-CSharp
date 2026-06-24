using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cikisYap_Click(object sender, EventArgs e)
        {
           DialogResult sonuc =  MessageBox.Show("Çıkış yapmak istiyormusunuz ?","Bilgilendirme",MessageBoxButtons.YesNo,MessageBoxIcon.Question); // ilk parametre messageBox ta bulunan text kısmı, ikinci parametre messageBox ın sekmesinde yazan başlığı, üçüncü parametresi messageBox ta tıklayabileceğimiz evet hayır butonları, dördüncü parametre ise messageBox ta bulunan sorunun yanındaki resim
            
            if(sonuc == DialogResult.Yes)
            {
                lbl_sonuc.Text = "Çıkış yapılıyor.";
            }
            else
            {
                lbl_sonuc.Text = "Çıkış yapılamadı";
            }
        }
    }
}
