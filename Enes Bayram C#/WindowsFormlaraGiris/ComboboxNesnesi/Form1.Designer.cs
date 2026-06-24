namespace ComboboxNesnesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.combo_gunler = new System.Windows.Forms.ComboBox();
            this.btn_gunSec = new System.Windows.Forms.Button();
            this.lbl_gun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo_gunler
            // 
            this.combo_gunler.FormattingEnabled = true;
            this.combo_gunler.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe"});
            this.combo_gunler.Location = new System.Drawing.Point(101, 28);
            this.combo_gunler.Name = "combo_gunler";
            this.combo_gunler.Size = new System.Drawing.Size(241, 21);
            this.combo_gunler.TabIndex = 0;
            // 
            // btn_gunSec
            // 
            this.btn_gunSec.Location = new System.Drawing.Point(34, 55);
            this.btn_gunSec.Name = "btn_gunSec";
            this.btn_gunSec.Size = new System.Drawing.Size(308, 32);
            this.btn_gunSec.TabIndex = 1;
            this.btn_gunSec.Text = "Gün Seç";
            this.btn_gunSec.UseVisualStyleBackColor = true;
            this.btn_gunSec.Click += new System.EventHandler(this.btn_gunSec_Click);
            // 
            // lbl_gun
            // 
            this.lbl_gun.AutoSize = true;
            this.lbl_gun.Location = new System.Drawing.Point(31, 31);
            this.lbl_gun.Name = "lbl_gun";
            this.lbl_gun.Size = new System.Drawing.Size(64, 13);
            this.lbl_gun.TabIndex = 2;
            this.lbl_gun.Text = "Gün Seçiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 187);
            this.Controls.Add(this.lbl_gun);
            this.Controls.Add(this.btn_gunSec);
            this.Controls.Add(this.combo_gunler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_gunler;
        private System.Windows.Forms.Button btn_gunSec;
        private System.Windows.Forms.Label lbl_gun;
    }
}

