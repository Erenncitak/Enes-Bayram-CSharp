using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDialogKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();

            pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                if (groupBox1.Controls[i] is TextBox || groupBox1.Controls[i] is RichTextBox)
                {
                    groupBox1.Controls[i].Text = string.Empty;
                }
            }
        }
    }
}
