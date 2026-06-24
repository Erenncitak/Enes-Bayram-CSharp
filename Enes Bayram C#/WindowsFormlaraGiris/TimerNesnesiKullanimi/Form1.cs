using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerNesnesiKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi = 20;

        private void btn_basla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; // zamanlamayı aktif yap
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 1 saniyede bir çalışacak
            //label2.Text = timer1.ToString();
            
            if(sayi >=0)
            {
                label2.Text = sayi.ToString();
                sayi--;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.Hour.ToString();
            lbl_dakika.Text = DateTime.Now.Minute.ToString();
            lbl_saniye.Text = DateTime.Now.Second.ToString();
        }
    }
}
