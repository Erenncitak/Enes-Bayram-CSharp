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
    public partial class Form1 : Form
    {

        List<Kisi> kisilerim = new List<Kisi>();
        List<Kitap> kitaplarim = new List<Kitap>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullaniciAdi.Text = string.Empty;
            txt_sifre.Text = string.Empty;


        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre = "";

            kullaniciAdi = txt_kullaniciAdi.Text;
            sifre= txt_sifre.Text;
            bool kontrol = false;

            foreach (Kisi kisi in kisilerim)
            {
                if(kullaniciAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki()=="admin")
                {
                    // admin sayfasına yönlendir
                    AdminSayfasi adminSayfasi = new AdminSayfasi(kisilerim,kitaplarim);
                    adminSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                else if(kullaniciAdi.ToLower() == kisi.getKullaniciAdi() && sifre.ToLower() == kisi.getSifre() && kisi.getYetki() == "uye")
                {
                    UyeSayfasi uyeSayfasi = new UyeSayfasi(kitaplarim);
                    uyeSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
            }
            if (!kontrol)
            {
                MessageBox.Show("Hatalı Giriş" , "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new Kisi(1, "Eren", "ÇITAK", DateTime.Now, "erenncitak", "12345", "admin"));
            kisilerim.Add(new Kisi(2, "Serhat", "ÇELEBİ", DateTime.Now, "eren", "1", "uye"));
            kisilerim.Add(new Kisi(3, "Yusuf", "ÖZCAN", DateTime.Now, "özcanali", "12321", "uye"));
            kisilerim.Add(new Kisi(4, "Muhammet", "KAYIŞ", DateTime.Now, "muhammetkys", "3333", "uye"));

            kitaplarim.Add(new Kitap(1, "İçimizdeki Şeytan", "Sebahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "roman", 100, 250, 2016));
            kitaplarim.Add(new Kitap(2, "Tutunamayanlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "roman", 350, 760, 2015));
            kitaplarim.Add(new Kitap(3, "Uçurtma Avcısı", "Khaled Hosseini", "İngilizce", "Everest Yayıncılık", "roman", 100, 350, 2010));
            kitaplarim.Add(new Kitap(4, "Küçük Prens", "Antoine de Saint-Exupery", "İngilizce", "Can Çocuk Yayınları", "roman", 50, 60, 2018));
            kitaplarim.Add(new Kitap(5, "Kürk Mantolu Madonna", "Sebahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "roman", 650, 220, 2015));
            kitaplarim.Add(new Kitap(6, "Tehlikeli Oyunlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "roman", 420, 500, 2018));
            kitaplarim.Add(new Kitap(6, "Ev Oyunlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "roman", 420, 500, 2018));
            kitaplarim.Add(new Kitap(6, "Araba Oyunlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "roman", 420, 500, 2018));
            kitaplarim.Add(new Kitap(6, "Spor Oyunlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "roman", 420, 500, 2018));
            kitaplarim.Add(new Kitap(6, "Git Oyunlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "roman", 420, 500, 2018));
            kitaplarim.Add(new Kitap(6, "Gitme Oyunlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "roman", 420, 500, 2018));
        }
    }
}
