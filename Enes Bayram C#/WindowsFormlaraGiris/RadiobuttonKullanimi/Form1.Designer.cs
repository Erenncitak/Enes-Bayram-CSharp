namespace RadiobuttonKullanimi
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
            this.lbl_ad = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.radio_kadin = new System.Windows.Forms.RadioButton();
            this.radio_erkek = new System.Windows.Forms.RadioButton();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(12, 9);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(38, 13);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "Adınız:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(73, 9);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(111, 20);
            this.txt_ad.TabIndex = 0;
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(12, 35);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(55, 13);
            this.lbl_soyad.TabIndex = 0;
            this.lbl_soyad.Text = "Soyadınız:";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(73, 32);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(111, 20);
            this.txt_soyad.TabIndex = 1;
            // 
            // radio_kadin
            // 
            this.radio_kadin.AutoSize = true;
            this.radio_kadin.Location = new System.Drawing.Point(132, 70);
            this.radio_kadin.Name = "radio_kadin";
            this.radio_kadin.Size = new System.Drawing.Size(52, 17);
            this.radio_kadin.TabIndex = 3;
            this.radio_kadin.TabStop = true;
            this.radio_kadin.Text = "Kadın";
            this.radio_kadin.UseVisualStyleBackColor = true;
            this.radio_kadin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radio_erkek
            // 
            this.radio_erkek.AutoSize = true;
            this.radio_erkek.Location = new System.Drawing.Point(73, 70);
            this.radio_erkek.Name = "radio_erkek";
            this.radio_erkek.Size = new System.Drawing.Size(53, 17);
            this.radio_erkek.TabIndex = 2;
            this.radio_erkek.TabStop = true;
            this.radio_erkek.Text = "Erkek";
            this.radio_erkek.UseVisualStyleBackColor = true;
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.Location = new System.Drawing.Point(73, 93);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(111, 34);
            this.btn_yazdir.TabIndex = 4;
            this.btn_yazdir.Text = "Yazdır";
            this.btn_yazdir.UseVisualStyleBackColor = true;
            this.btn_yazdir.Click += new System.EventHandler(this.btn_yazdir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 169);
            this.Controls.Add(this.btn_yazdir);
            this.Controls.Add(this.radio_erkek);
            this.Controls.Add(this.radio_kadin);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.lbl_ad);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.RadioButton radio_kadin;
        private System.Windows.Forms.RadioButton radio_erkek;
        private System.Windows.Forms.Button btn_yazdir;
    }
}

