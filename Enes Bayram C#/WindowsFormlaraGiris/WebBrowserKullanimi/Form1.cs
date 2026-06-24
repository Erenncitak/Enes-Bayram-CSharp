using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_git_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.tr");
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
    }
}
