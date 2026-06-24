namespace KütüphaneOtomasyon
{
    partial class UyeSayfasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.txt_kitapBilgi = new System.Windows.Forms.TextBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapIsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapDili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinEvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfaSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basimYili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_aramaSecim = new System.Windows.Forms.ComboBox();
            this.lbl_aramaSec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ara
            // 
            this.btn_ara.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.Location = new System.Drawing.Point(12, 12);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(110, 38);
            this.btn_ara.TabIndex = 0;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yenile.Location = new System.Drawing.Point(278, 12);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(110, 38);
            this.btn_yenile.TabIndex = 0;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // txt_kitapBilgi
            // 
            this.txt_kitapBilgi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kitapBilgi.Location = new System.Drawing.Point(128, 12);
            this.txt_kitapBilgi.Multiline = true;
            this.txt_kitapBilgi.Name = "txt_kitapBilgi";
            this.txt_kitapBilgi.Size = new System.Drawing.Size(144, 38);
            this.txt_kitapBilgi.TabIndex = 1;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(12, 316);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(110, 38);
            this.btn_cikis.TabIndex = 0;
            this.btn_cikis.Text = "Çıkış Yap";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapid,
            this.kitapIsim,
            this.kitapYazar,
            this.kitapDili,
            this.yayinEvi,
            this.tur,
            this.adet,
            this.sayfaSayisi,
            this.basimYili});
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(721, 242);
            this.dataGridView1.TabIndex = 12;
            // 
            // kitapid
            // 
            this.kitapid.HeaderText = "KİTAPID";
            this.kitapid.Name = "kitapid";
            this.kitapid.Width = 75;
            // 
            // kitapIsim
            // 
            this.kitapIsim.HeaderText = "İSMİ";
            this.kitapIsim.Name = "kitapIsim";
            this.kitapIsim.Width = 75;
            // 
            // kitapYazar
            // 
            this.kitapYazar.HeaderText = "YAZARI";
            this.kitapYazar.Name = "kitapYazar";
            this.kitapYazar.Width = 75;
            // 
            // kitapDili
            // 
            this.kitapDili.HeaderText = "DİLİ";
            this.kitapDili.Name = "kitapDili";
            this.kitapDili.Width = 75;
            // 
            // yayinEvi
            // 
            this.yayinEvi.HeaderText = "YAYIN EVİ";
            this.yayinEvi.Name = "yayinEvi";
            this.yayinEvi.Width = 75;
            // 
            // tur
            // 
            this.tur.HeaderText = "TÜR";
            this.tur.Name = "tur";
            this.tur.Width = 75;
            // 
            // adet
            // 
            this.adet.HeaderText = "ADET";
            this.adet.Name = "adet";
            this.adet.Width = 75;
            // 
            // sayfaSayisi
            // 
            this.sayfaSayisi.HeaderText = "SAYFA SAYISI";
            this.sayfaSayisi.Name = "sayfaSayisi";
            this.sayfaSayisi.Width = 75;
            // 
            // basimYili
            // 
            this.basimYili.HeaderText = "BASIM YILI";
            this.basimYili.Name = "basimYili";
            this.basimYili.Width = 75;
            // 
            // comboBox_aramaSecim
            // 
            this.comboBox_aramaSecim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_aramaSecim.FormattingEnabled = true;
            this.comboBox_aramaSecim.Items.AddRange(new object[] {
            "Kitap İsmi",
            "Yazarı",
            "Dili",
            "Yayın Evi",
            "Tür"});
            this.comboBox_aramaSecim.Location = new System.Drawing.Point(487, 20);
            this.comboBox_aramaSecim.Name = "comboBox_aramaSecim";
            this.comboBox_aramaSecim.Size = new System.Drawing.Size(121, 24);
            this.comboBox_aramaSecim.TabIndex = 13;
            // 
            // lbl_aramaSec
            // 
            this.lbl_aramaSec.AutoSize = true;
            this.lbl_aramaSec.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aramaSec.Location = new System.Drawing.Point(614, 23);
            this.lbl_aramaSec.Name = "lbl_aramaSec";
            this.lbl_aramaSec.Size = new System.Drawing.Size(119, 16);
            this.lbl_aramaSec.TabIndex = 16;
            this.lbl_aramaSec.Text = "<== Filtreyi Seçin";
            // 
            // UyeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 378);
            this.Controls.Add(this.lbl_aramaSec);
            this.Controls.Add(this.comboBox_aramaSecim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_kitapBilgi);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_ara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UyeSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Sayfası";
            this.Load += new System.EventHandler(this.UyeSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.TextBox txt_kitapBilgi;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapid;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapIsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapDili;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinEvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfaSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn basimYili;
        private System.Windows.Forms.ComboBox comboBox_aramaSecim;
        private System.Windows.Forms.Label lbl_aramaSec;
    }
}