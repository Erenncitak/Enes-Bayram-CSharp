using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(1, "Eren", "ÇITAK");
            dataGridView1.Rows.Add(2, "Yakup", "REÇBER");
            dataGridView1.Rows.Add(3, "Bilal", "BAYRAM");
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            string isim = txt_isim.Text;
            string soyisim= txt_soyisim.Text;

            dataGridView1.Rows.Add(id, isim, soyisim);

            MessageBox.Show("Kayıt eklendi.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string isim = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string soysisim= dataGridView1.CurrentRow.Cells[2].Value.ToString();

            txt_id.Text = id;
            txt_isim.Text = isim;
            txt_soyisim.Text = soysisim;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            MessageBox.Show("Kayıt Silindi.");
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id,isim, soyisim);

            MessageBox.Show("Kayıt güncellendi.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Add(1, "Eren", "ÇITAK");
            //dataGridView1.Rows.Add(2, "Yakup", "REÇBER");
            //dataGridView1.Rows.Add(3, "Bilal", "BAYRAM");
        }
    }
}
