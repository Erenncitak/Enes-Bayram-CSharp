namespace WindowsFormlaraGiris
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_not1 = new System.Windows.Forms.Label();
            this.lbl_not2 = new System.Windows.Forms.Label();
            this.txt_not1 = new System.Windows.Forms.TextBox();
            this.txt_not2 = new System.Windows.Forms.TextBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.lbl_ortalama = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_not1
            // 
            this.lbl_not1.AutoSize = true;
            this.lbl_not1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_not1.Location = new System.Drawing.Point(45, 50);
            this.lbl_not1.Name = "lbl_not1";
            this.lbl_not1.Size = new System.Drawing.Size(235, 29);
            this.lbl_not1.TabIndex = 0;
            this.lbl_not1.Text = "1. Notunuzu giriniz:";
            // 
            // lbl_not2
            // 
            this.lbl_not2.AutoSize = true;
            this.lbl_not2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_not2.Location = new System.Drawing.Point(45, 109);
            this.lbl_not2.Name = "lbl_not2";
            this.lbl_not2.Size = new System.Drawing.Size(235, 29);
            this.lbl_not2.TabIndex = 0;
            this.lbl_not2.Text = "2. Notunuzu giriniz:";
            // 
            // txt_not1
            // 
            this.txt_not1.Location = new System.Drawing.Point(286, 50);
            this.txt_not1.Multiline = true;
            this.txt_not1.Name = "txt_not1";
            this.txt_not1.Size = new System.Drawing.Size(115, 32);
            this.txt_not1.TabIndex = 1;
            this.txt_not1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_not2
            // 
            this.txt_not2.Location = new System.Drawing.Point(286, 109);
            this.txt_not2.Multiline = true;
            this.txt_not2.Name = "txt_not2";
            this.txt_not2.Size = new System.Drawing.Size(115, 32);
            this.txt_not2.TabIndex = 1;
            this.txt_not2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapla.Location = new System.Drawing.Point(50, 168);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(139, 45);
            this.btn_hesapla.TabIndex = 2;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // lbl_ortalama
            // 
            this.lbl_ortalama.AutoSize = true;
            this.lbl_ortalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ortalama.Location = new System.Drawing.Point(195, 176);
            this.lbl_ortalama.Name = "lbl_ortalama";
            this.lbl_ortalama.Size = new System.Drawing.Size(126, 29);
            this.lbl_ortalama.TabIndex = 0;
            this.lbl_ortalama.Text = "Ortalama:";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sonuc.Location = new System.Drawing.Point(327, 176);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(27, 29);
            this.lbl_sonuc.TabIndex = 0;
            this.lbl_sonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 480);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.txt_not2);
            this.Controls.Add(this.txt_not1);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.lbl_ortalama);
            this.Controls.Add(this.lbl_not2);
            this.Controls.Add(this.lbl_not1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_not1;
        private System.Windows.Forms.Label lbl_not2;
        private System.Windows.Forms.TextBox txt_not1;
        private System.Windows.Forms.TextBox txt_not2;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label lbl_ortalama;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

