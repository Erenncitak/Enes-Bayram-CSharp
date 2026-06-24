namespace GroupBoxNesnesiKullanimi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_telefonNo = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_kaydol = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox_ucurtma = new System.Windows.Forms.CheckBox();
            this.checkBox_kitap = new System.Windows.Forms.CheckBox();
            this.checkBox_yuzmek = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_yuzmek);
            this.groupBox1.Controls.Add(this.checkBox_ucurtma);
            this.groupBox1.Controls.Add(this.checkBox_kitap);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btn_kaydol);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.txt_telefonNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_soyisim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_isim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 482);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YENİ KAYIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim:";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(139, 56);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(171, 26);
            this.txt_isim.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim:";
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(139, 105);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(171, 26);
            this.txt_soyisim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email Adres:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(139, 146);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(171, 26);
            this.txt_email.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon No:";
            // 
            // txt_telefonNo
            // 
            this.txt_telefonNo.Location = new System.Drawing.Point(139, 196);
            this.txt_telefonNo.Name = "txt_telefonNo";
            this.txt_telefonNo.Size = new System.Drawing.Size(171, 26);
            this.txt_telefonNo.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(245, 257);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kadın";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(139, 257);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 24);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Erkek";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hobiler:";
            // 
            // btn_kaydol
            // 
            this.btn_kaydol.Location = new System.Drawing.Point(19, 425);
            this.btn_kaydol.Name = "btn_kaydol";
            this.btn_kaydol.Size = new System.Drawing.Size(298, 36);
            this.btn_kaydol.TabIndex = 9;
            this.btn_kaydol.Text = "KAYDOL";
            this.btn_kaydol.UseVisualStyleBackColor = true;
            this.btn_kaydol.Click += new System.EventHandler(this.btn_kaydol_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(139, 309);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox_ucurtma
            // 
            this.checkBox_ucurtma.AutoSize = true;
            this.checkBox_ucurtma.Location = new System.Drawing.Point(139, 366);
            this.checkBox_ucurtma.Name = "checkBox_ucurtma";
            this.checkBox_ucurtma.Size = new System.Drawing.Size(172, 24);
            this.checkBox_ucurtma.TabIndex = 8;
            this.checkBox_ucurtma.Text = "Uçurtma Uçurmak";
            this.checkBox_ucurtma.UseVisualStyleBackColor = true;
            // 
            // checkBox_kitap
            // 
            this.checkBox_kitap.AutoSize = true;
            this.checkBox_kitap.Location = new System.Drawing.Point(139, 309);
            this.checkBox_kitap.Name = "checkBox_kitap";
            this.checkBox_kitap.Size = new System.Drawing.Size(139, 24);
            this.checkBox_kitap.TabIndex = 6;
            this.checkBox_kitap.Text = "Kitap Okumak";
            this.checkBox_kitap.UseVisualStyleBackColor = true;
            // 
            // checkBox_yuzmek
            // 
            this.checkBox_yuzmek.AutoSize = true;
            this.checkBox_yuzmek.Location = new System.Drawing.Point(139, 336);
            this.checkBox_yuzmek.Name = "checkBox_yuzmek";
            this.checkBox_yuzmek.Size = new System.Drawing.Size(92, 24);
            this.checkBox_yuzmek.TabIndex = 7;
            this.checkBox_yuzmek.Text = "Yüzmek";
            this.checkBox_yuzmek.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 530);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_telefonNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_yuzmek;
        private System.Windows.Forms.CheckBox checkBox_ucurtma;
        private System.Windows.Forms.CheckBox checkBox_kitap;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_kaydol;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
    }
}

