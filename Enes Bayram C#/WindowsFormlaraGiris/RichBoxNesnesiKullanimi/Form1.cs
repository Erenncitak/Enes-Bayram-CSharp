using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichBoxNesnesiKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt Eklendi" , "Bilgilendirme" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
