namespace TabControlKullanimi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.anasayfa = new System.Windows.Forms.TabPage();
            this.uyelikIslemleri = new System.Windows.Forms.TabPage();
            this.Ayarlar = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.anasayfa.SuspendLayout();
            this.uyelikIslemleri.SuspendLayout();
            this.Ayarlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.anasayfa);
            this.tabControl1.Controls.Add(this.uyelikIslemleri);
            this.tabControl1.Controls.Add(this.Ayarlar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // anasayfa
            // 
            this.anasayfa.Controls.Add(this.label1);
            this.anasayfa.Location = new System.Drawing.Point(4, 22);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Padding = new System.Windows.Forms.Padding(3);
            this.anasayfa.Size = new System.Drawing.Size(792, 424);
            this.anasayfa.TabIndex = 0;
            this.anasayfa.Text = "Anasayfa";
            this.anasayfa.UseVisualStyleBackColor = true;
            // 
            // uyelikIslemleri
            // 
            this.uyelikIslemleri.Controls.Add(this.label3);
            this.uyelikIslemleri.Location = new System.Drawing.Point(4, 22);
            this.uyelikIslemleri.Name = "uyelikIslemleri";
            this.uyelikIslemleri.Padding = new System.Windows.Forms.Padding(3);
            this.uyelikIslemleri.Size = new System.Drawing.Size(792, 424);
            this.uyelikIslemleri.TabIndex = 1;
            this.uyelikIslemleri.Text = "Üyelik İşlemleri";
            this.uyelikIslemleri.UseVisualStyleBackColor = true;
            // 
            // Ayarlar
            // 
            this.Ayarlar.Controls.Add(this.label2);
            this.Ayarlar.Location = new System.Drawing.Point(4, 22);
            this.Ayarlar.Name = "Ayarlar";
            this.Ayarlar.Size = new System.Drawing.Size(792, 424);
            this.Ayarlar.TabIndex = 2;
            this.Ayarlar.Text = "Ayarlar";
            this.Ayarlar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Burası Anasayfadır.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Burası Ayarlar sayfasıdır.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Burası Üyelik Sayfasıdır";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.anasayfa.ResumeLayout(false);
            this.anasayfa.PerformLayout();
            this.uyelikIslemleri.ResumeLayout(false);
            this.uyelikIslemleri.PerformLayout();
            this.Ayarlar.ResumeLayout(false);
            this.Ayarlar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage anasayfa;
        private System.Windows.Forms.TabPage uyelikIslemleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage Ayarlar;
        private System.Windows.Forms.Label label2;
    }
}

