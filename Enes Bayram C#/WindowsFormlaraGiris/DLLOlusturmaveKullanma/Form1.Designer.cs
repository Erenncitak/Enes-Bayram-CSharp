namespace DLLOlusturmaveKullanma
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
            this.lbl_sayi1 = new System.Windows.Forms.Label();
            this.txt_sayi1 = new System.Windows.Forms.TextBox();
            this.lbl_sayi2 = new System.Windows.Forms.Label();
            this.txt_sayi2 = new System.Windows.Forms.TextBox();
            this.btn_topla = new System.Windows.Forms.Button();
            this.btn_cikarma = new System.Windows.Forms.Button();
            this.btn_carpma = new System.Windows.Forms.Button();
            this.btn_bolme = new System.Windows.Forms.Button();
            this.lbl_sonuc1 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_sayi1
            // 
            this.lbl_sayi1.AutoSize = true;
            this.lbl_sayi1.Location = new System.Drawing.Point(32, 27);
            this.lbl_sayi1.Name = "lbl_sayi1";
            this.lbl_sayi1.Size = new System.Drawing.Size(73, 13);
            this.lbl_sayi1.TabIndex = 0;
            this.lbl_sayi1.Text = "1. sayıyı giriniz";
            // 
            // txt_sayi1
            // 
            this.txt_sayi1.Location = new System.Drawing.Point(150, 27);
            this.txt_sayi1.Name = "txt_sayi1";
            this.txt_sayi1.Size = new System.Drawing.Size(100, 20);
            this.txt_sayi1.TabIndex = 1;
            // 
            // lbl_sayi2
            // 
            this.lbl_sayi2.AutoSize = true;
            this.lbl_sayi2.Location = new System.Drawing.Point(32, 61);
            this.lbl_sayi2.Name = "lbl_sayi2";
            this.lbl_sayi2.Size = new System.Drawing.Size(73, 13);
            this.lbl_sayi2.TabIndex = 0;
            this.lbl_sayi2.Text = "2. sayıyı giriniz";
            // 
            // txt_sayi2
            // 
            this.txt_sayi2.Location = new System.Drawing.Point(150, 61);
            this.txt_sayi2.Name = "txt_sayi2";
            this.txt_sayi2.Size = new System.Drawing.Size(100, 20);
            this.txt_sayi2.TabIndex = 1;
            // 
            // btn_topla
            // 
            this.btn_topla.Location = new System.Drawing.Point(68, 150);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(37, 30);
            this.btn_topla.TabIndex = 2;
            this.btn_topla.Text = "+";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // btn_cikarma
            // 
            this.btn_cikarma.Location = new System.Drawing.Point(111, 150);
            this.btn_cikarma.Name = "btn_cikarma";
            this.btn_cikarma.Size = new System.Drawing.Size(37, 30);
            this.btn_cikarma.TabIndex = 2;
            this.btn_cikarma.Text = "-";
            this.btn_cikarma.UseVisualStyleBackColor = true;
            this.btn_cikarma.Click += new System.EventHandler(this.btn_cikarma_Click);
            // 
            // btn_carpma
            // 
            this.btn_carpma.Location = new System.Drawing.Point(154, 150);
            this.btn_carpma.Name = "btn_carpma";
            this.btn_carpma.Size = new System.Drawing.Size(37, 30);
            this.btn_carpma.TabIndex = 2;
            this.btn_carpma.Text = "x";
            this.btn_carpma.UseVisualStyleBackColor = true;
            this.btn_carpma.Click += new System.EventHandler(this.btn_carpma_Click);
            // 
            // btn_bolme
            // 
            this.btn_bolme.Location = new System.Drawing.Point(197, 150);
            this.btn_bolme.Name = "btn_bolme";
            this.btn_bolme.Size = new System.Drawing.Size(37, 30);
            this.btn_bolme.TabIndex = 2;
            this.btn_bolme.Text = "/";
            this.btn_bolme.UseVisualStyleBackColor = true;
            this.btn_bolme.Click += new System.EventHandler(this.btn_bolme_Click);
            // 
            // lbl_sonuc1
            // 
            this.lbl_sonuc1.AutoSize = true;
            this.lbl_sonuc1.Location = new System.Drawing.Point(32, 106);
            this.lbl_sonuc1.Name = "lbl_sonuc1";
            this.lbl_sonuc1.Size = new System.Drawing.Size(41, 13);
            this.lbl_sonuc1.TabIndex = 0;
            this.lbl_sonuc1.Text = "Sonuc:";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(79, 106);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(13, 13);
            this.lbl_sonuc.TabIndex = 0;
            this.lbl_sonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 266);
            this.Controls.Add(this.btn_bolme);
            this.Controls.Add(this.btn_carpma);
            this.Controls.Add(this.btn_cikarma);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.txt_sayi2);
            this.Controls.Add(this.txt_sayi1);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.lbl_sonuc1);
            this.Controls.Add(this.lbl_sayi2);
            this.Controls.Add(this.lbl_sayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sayi1;
        private System.Windows.Forms.TextBox txt_sayi1;
        private System.Windows.Forms.Label lbl_sayi2;
        private System.Windows.Forms.TextBox txt_sayi2;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Button btn_cikarma;
        private System.Windows.Forms.Button btn_carpma;
        private System.Windows.Forms.Button btn_bolme;
        private System.Windows.Forms.Label lbl_sonuc1;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

