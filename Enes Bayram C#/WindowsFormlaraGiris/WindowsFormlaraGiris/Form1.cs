using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormlaraGiris
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int ortalama = (Convert.ToInt16(txt_not1.Text) + Convert.ToInt16(txt_not2.Text))/2;
            lbl_sonuc.Text = ortalama.ToString();
        }
    }
}
