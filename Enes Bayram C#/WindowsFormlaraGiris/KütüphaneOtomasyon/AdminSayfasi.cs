using KütüphaneOtomasyon.Model;
using System;
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
    public partial class AdminSayfasi : Form
    {
        List<Kisi> kisilerim;
        List<Kitap> kitaplarim;
        public AdminSayfasi(List<Kisi> kisilerim, List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;
        }

        private void AdminSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getId(), kisi.getIsim(), kisi.getSoyisim(), kisi.getOlusturmaTarih(), kisi.getKullaniciAdi(), kisi.getSifre(), kisi.getYetki());
            }

            foreach(Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getKitapId(), kitap.getKitapIsim(), kitap.getKitapYazar(), kitap.getKitapDili(), kitap.getYayinEvi(), kitap.getTur(), kitap.getAdet(), kitap.getSayfaSayisi(), kitap.getBasimYili());
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txt_id.Text,txt_isim.Text,txt_soyisim.Text,maskedTextBox1.Text,txt_kullaniciAdi.Text,txt_sifre.Text,txt_yetki.Text);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow); // current row => seçili satır 
        }

        public void textleriDoldur()
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kullaniciAdi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleriDoldur();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string id = txt_id.Text;
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string tarih = maskedTextBox1.Text;
            string kullaniciAdi = txt_kullaniciAdi.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id,isim,soyisim,tarih,kullaniciAdi,sifre,yetki);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_uyeIslemleri.Controls.Count; i++)
            {
                if (groupBox_uyeIslemleri.Controls[i] is TextBox || groupBox_uyeIslemleri.Controls[i] is MaskedTextBox)
                {
                    groupBox_uyeIslemleri.Controls[i].Text = string.Empty;
                }
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txt_kitapid.Text,txt_kitapisim.Text, txt_kitapyazar.Text, txt_dil.Text,txt_yayinevi.Text, txt_tur.Text,txt_adet.Text,txt_sayfa.Text,txt_basimyil.Text);
        }

        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_kitapguncelle_Click(object sender, EventArgs e)
        {
            string kitapid= txt_kitapid.Text;
            string kitapIsim = txt_kitapisim.Text;
            string kitapYazar = txt_kitapyazar.Text;
            string dil = txt_dil.Text;
            string yayinEvi = txt_yayinevi.Text;
            string tur = txt_tur.Text;
            string adet = txt_adet.Text;
            string sayfa = txt_sayfa.Text;
            string basimYili = txt_basimyil.Text;

            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kitapid,kitapIsim,kitapYazar,dil,yayinEvi,tur,adet,sayfa, basimYili);
            
        }

        private void btn_kitaptemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_kitapislemleri.Controls.Count; i++)
            {
                if (groupBox_kitapislemleri.Controls[i] is TextBox)
                {
                    groupBox_kitapislemleri.Controls[i].Text = string.Empty;
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_kitapisim.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_kitapyazar.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_dil.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_yayinevi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_tur.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_adet.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_sayfa.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_basimyil.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_kisiAra_Click(object sender, EventArgs e)
        {
            Kisi hedefKisi = null;
            int secilenKisiID =Convert.ToInt32(textBox1.Text);

            foreach (Kisi kisi  in kisilerim)
            {
                if(kisi.getId() == secilenKisiID)
                {
                    hedefKisi = kisi;
                    break;
                }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefKisi.getId(), hedefKisi.getIsim(), hedefKisi.getSoyisim(), hedefKisi.getOlusturmaTarih(), hedefKisi.getKullaniciAdi(), hedefKisi.getSifre(), hedefKisi.getYetki());
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            //dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach (Kisi hedefKisi in kisilerim)
            {
                dataGridView1.Rows.Add(hedefKisi.getId(), hedefKisi.getIsim(), hedefKisi.getSoyisim(), hedefKisi.getOlusturmaTarih(), hedefKisi.getKullaniciAdi(), hedefKisi.getSifre(), hedefKisi.getYetki());
            }
            textBox1.Text = string.Empty;
        }

        private void btn_kitapAra_Click(object sender, EventArgs e)
        {
            Kitap hedefKitap = null;
            int secilenKitapID = Convert.ToInt32(textBox2.Text);

            foreach (Kitap kitap in kitaplarim)
            {
                if(kitap.getKitapId() == secilenKitapID)
                {
                    hedefKitap = kitap;
                    break;
                }
            }

            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapIsim(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDili(), hedefKitap.getYayinEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYili());
        }

        private void btn_kitapYenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            foreach (Kitap hedefKitap in kitaplarim)
            {
                dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapIsim(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDili(), hedefKitap.getYayinEvi(), hedefKitap.getTur(), hedefKitap.getAdet(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYili());
            }
            textBox2.Text = string.Empty;
        }

        private void btn_cikisYap_Click(object sender, EventArgs e)
        {
            Form1 loginSayfasi = new Form1();
            loginSayfasi.Show();
            this.Hide();
        }
    }
}
