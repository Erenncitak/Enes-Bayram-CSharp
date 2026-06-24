using KütüphaneOtomasyon.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyon
{
    public partial class UyeSayfasi : Form
    {
        List<Kitap> kitaplarim;

        public UyeSayfasi(List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarim;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 loginSayfasi = new Form1();
            loginSayfasi.Show();
            this.Hide();
        }

        private void UyeSayfasi_Load(object sender, EventArgs e)
        {
            comboBox_aramaSecim.SelectedIndex = 0;
            foreach(Kitap kitap in kitaplarim)
            {
                dataGridView1.Rows.Add(kitap.getKitapId(), kitap.getKitapIsim(), kitap.getKitapYazar(), kitap.getKitapDili(), kitap.getYayinEvi(), kitap.getTur(), kitap.getAdet(), kitap.getSayfaSayisi(), kitap.getBasimYili());
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            // DataGridView'i temizle
            dataGridView1.Rows.Clear();

            string arananDeger = txt_kitapBilgi.Text.Trim();
            string seciliKriter = comboBox_aramaSecim.SelectedItem.ToString();

            if (string.IsNullOrEmpty(arananDeger))
            {
                MessageBox.Show("Lütfen arama yapmak için bir değer girin!");
                return;
            }

            // Bulunan kitapları tutacak liste
            List<Kitap> bulunanKitaplar = new List<Kitap>();

            // Arama kriterine göre filtreleme
            foreach (Kitap kitap in kitaplarim)
            {
                bool eslesmeVar = false;

                switch (seciliKriter)
                {
                    case "Kitap İsmi":
                        if (kitap.getKitapIsim().ToLower().Contains(arananDeger.ToLower()))
                            eslesmeVar = true;
                        break;

                    case "Yazarı":
                        if (kitap.getKitapYazar().ToLower().Contains(arananDeger.ToLower()))
                            eslesmeVar = true;
                        break;

                    case "Dili":
                        if (kitap.getKitapDili().ToLower().Contains(arananDeger.ToLower()))
                            eslesmeVar = true;
                        break;

                    case "Yayın Evi":
                        if (kitap.getYayinEvi().ToLower().Contains(arananDeger.ToLower()))
                            eslesmeVar = true;
                        break;

                    case "Tür":
                        if (kitap.getTur().ToLower().Contains(arananDeger.ToLower()))
                            eslesmeVar = true;
                        break;
                }

                if (eslesmeVar)
                {
                    bulunanKitaplar.Add(kitap);
                }
            }

            // Bulunan kitapları DataGridView'e ekle
            if (bulunanKitaplar.Count > 0)
            {
                foreach (Kitap kitap in bulunanKitaplar)
                {
                    dataGridView1.Rows.Add(
                        kitap.getKitapId(),
                        kitap.getKitapIsim(),
                        kitap.getKitapYazar(),
                        kitap.getKitapDili(),
                        kitap.getYayinEvi(),
                        kitap.getTur(),
                        kitap.getAdet(),
                        kitap.getSayfaSayisi(),
                        kitap.getBasimYili()
                    );
                }

                MessageBox.Show($"{bulunanKitaplar.Count} kitap bulundu.");
            }
            else
            {
                MessageBox.Show("Aradığınız kriterlere uygun kitap bulunamadı.");
            }
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            foreach(Kitap hedefKitap in kitaplarim)
            {
                dataGridView1.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapIsim(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDili(), hedefKitap.getYayinEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYili());
            }
        }
    }
}
