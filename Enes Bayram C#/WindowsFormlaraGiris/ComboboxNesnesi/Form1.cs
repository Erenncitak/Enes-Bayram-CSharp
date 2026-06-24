using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboboxNesnesi
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combo_gunler.Items.Add("Cuma");
            combo_gunler.Items.Add("Cumartesi");
            combo_gunler.Items.Add("Pazar");

            /*
            combo_gunler.Items.RemoveAt(6); // index numarasına göre kaldırma işlemi yapar
            combo_gunler.Items.Remove("Cumartesi"); // girilen string ifadeye göre kaldırma işlemi yapar
            */

            //MessageBox.Show("Eren Çıtak");

        }

        private void btn_gunSec_Click(object sender, EventArgs e)
        {
            // selecteditem - selectedindex     
            string secilenGun = combo_gunler.SelectedItem.ToString(); // SelectedItem kullanımı seçilen değeri atama işlemi
            int secilenIndex = combo_gunler.SelectedIndex; // SelectedIndex seçilen değerin index numarasını alır 
            MessageBox.Show("Seçtiğiniz Gün : " + secilenGun + " " + "İndex Değeri : " + secilenIndex);
        }
    }
}
