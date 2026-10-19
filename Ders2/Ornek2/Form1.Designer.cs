namespace Ornek2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbAd = new System.Windows.Forms.TextBox();
            this.txbSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbOgrNo = new System.Windows.Forms.TextBox();
            this.cbxBolum = new System.Windows.Forms.ComboBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.lblYazdir = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbBolumEkle = new System.Windows.Forms.TextBox();
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.lbMetin = new System.Windows.Forms.ListBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.mtxbCepNo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // txbAd
            // 
            this.txbAd.Location = new System.Drawing.Point(89, 69);
            this.txbAd.Name = "txbAd";
            this.txbAd.Size = new System.Drawing.Size(100, 20);
            this.txbAd.TabIndex = 2;
            this.txbAd.TextChanged += new System.EventHandler(this.txbAd_TextChanged);
            // 
            // txbSoyad
            // 
            this.txbSoyad.Location = new System.Drawing.Point(89, 95);
            this.txbSoyad.Name = "txbSoyad";
            this.txbSoyad.Size = new System.Drawing.Size(100, 20);
            this.txbSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Öğrenci No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bölüm:";
            // 
            // txbOgrNo
            // 
            this.txbOgrNo.Location = new System.Drawing.Point(89, 129);
            this.txbOgrNo.Name = "txbOgrNo";
            this.txbOgrNo.Size = new System.Drawing.Size(100, 20);
            this.txbOgrNo.TabIndex = 6;
            // 
            // cbxBolum
            // 
            this.cbxBolum.FormattingEnabled = true;
            this.cbxBolum.Items.AddRange(new object[] {
            "Bilgisayar Teknolojileri",
            "Elektrik",
            "Makine",
            "Gıda İşleme"});
            this.cbxBolum.Location = new System.Drawing.Point(89, 208);
            this.cbxBolum.Name = "cbxBolum";
            this.cbxBolum.Size = new System.Drawing.Size(121, 21);
            this.cbxBolum.TabIndex = 8;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(89, 248);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(75, 23);
            this.btnYazdir.TabIndex = 9;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // lblYazdir
            // 
            this.lblYazdir.AutoSize = true;
            this.lblYazdir.Location = new System.Drawing.Point(89, 296);
            this.lblYazdir.Name = "lblYazdir";
            this.lblYazdir.Size = new System.Drawing.Size(35, 13);
            this.lblYazdir.TabIndex = 9;
            this.lblYazdir.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Listede bölüm ismi yoksa aşağıdan ekle";
            // 
            // txbBolumEkle
            // 
            this.txbBolumEkle.Location = new System.Drawing.Point(243, 180);
            this.txbBolumEkle.Name = "txbBolumEkle";
            this.txbBolumEkle.Size = new System.Drawing.Size(100, 20);
            this.txbBolumEkle.TabIndex = 11;
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.Location = new System.Drawing.Point(243, 206);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(75, 23);
            this.btnBolumEkle.TabIndex = 12;
            this.btnBolumEkle.Text = "Bölüm Ekle";
            this.btnBolumEkle.UseVisualStyleBackColor = true;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // lbMetin
            // 
            this.lbMetin.FormattingEnabled = true;
            this.lbMetin.Location = new System.Drawing.Point(243, 56);
            this.lbMetin.Name = "lbMetin";
            this.lbMetin.Size = new System.Drawing.Size(120, 95);
            this.lbMetin.TabIndex = 13;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(243, 27);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(120, 23);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.Text = "Listeyi Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // mtxbCepNo
            // 
            this.mtxbCepNo.Location = new System.Drawing.Point(89, 164);
            this.mtxbCepNo.Mask = "(999) 000-0000";
            this.mtxbCepNo.Name = "mtxbCepNo";
            this.mtxbCepNo.Size = new System.Drawing.Size(100, 20);
            this.mtxbCepNo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cep No:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 426);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtxbCepNo);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lbMetin);
            this.Controls.Add(this.btnBolumEkle);
            this.Controls.Add(this.txbBolumEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblYazdir);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.cbxBolum);
            this.Controls.Add(this.txbOgrNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSoyad);
            this.Controls.Add(this.txbAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbAd;
        private System.Windows.Forms.TextBox txbSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbOgrNo;
        private System.Windows.Forms.ComboBox cbxBolum;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Label lblYazdir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbBolumEkle;
        private System.Windows.Forms.Button btnBolumEkle;
        private System.Windows.Forms.ListBox lbMetin;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.MaskedTextBox mtxbCepNo;
        private System.Windows.Forms.Label label6;
    }
}

