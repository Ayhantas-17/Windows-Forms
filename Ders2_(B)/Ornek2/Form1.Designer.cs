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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbAd = new System.Windows.Forms.TextBox();
            this.txbSoyad = new System.Windows.Forms.TextBox();
            this.txbOgrNo = new System.Windows.Forms.TextBox();
            this.cbxBolum = new System.Windows.Forms.ComboBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.lblYazdir = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbBolumEkle = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lbYazdir = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mTxbCepNo = new System.Windows.Forms.MaskedTextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bölüm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbAd
            // 
            this.txbAd.Location = new System.Drawing.Point(87, 78);
            this.txbAd.Name = "txbAd";
            this.txbAd.Size = new System.Drawing.Size(100, 20);
            this.txbAd.TabIndex = 4;
            this.txbAd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbSoyad
            // 
            this.txbSoyad.Location = new System.Drawing.Point(87, 113);
            this.txbSoyad.Name = "txbSoyad";
            this.txbSoyad.Size = new System.Drawing.Size(100, 20);
            this.txbSoyad.TabIndex = 5;
            // 
            // txbOgrNo
            // 
            this.txbOgrNo.Location = new System.Drawing.Point(87, 175);
            this.txbOgrNo.Name = "txbOgrNo";
            this.txbOgrNo.Size = new System.Drawing.Size(100, 20);
            this.txbOgrNo.TabIndex = 7;
            // 
            // cbxBolum
            // 
            this.cbxBolum.FormattingEnabled = true;
            this.cbxBolum.Items.AddRange(new object[] {
            "Bilgisayar Teknoojileri",
            "Elektrik",
            "Makine",
            "Gıda İşleme"});
            this.cbxBolum.Location = new System.Drawing.Point(87, 205);
            this.cbxBolum.Name = "cbxBolum";
            this.cbxBolum.Size = new System.Drawing.Size(121, 21);
            this.cbxBolum.TabIndex = 8;
            this.cbxBolum.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(87, 232);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(75, 23);
            this.btnYazdir.TabIndex = 8;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // lblYazdir
            // 
            this.lblYazdir.AutoSize = true;
            this.lblYazdir.Location = new System.Drawing.Point(84, 271);
            this.lblYazdir.Name = "lblYazdir";
            this.lblYazdir.Size = new System.Drawing.Size(35, 13);
            this.lblYazdir.TabIndex = 10;
            this.lblYazdir.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "bölümünüz yoksa ekleyin";
            // 
            // txbBolumEkle
            // 
            this.txbBolumEkle.Location = new System.Drawing.Point(234, 206);
            this.txbBolumEkle.Name = "txbBolumEkle";
            this.txbBolumEkle.Size = new System.Drawing.Size(100, 20);
            this.txbBolumEkle.TabIndex = 12;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(234, 232);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lbYazdir
            // 
            this.lbYazdir.FormattingEnabled = true;
            this.lbYazdir.Location = new System.Drawing.Point(214, 78);
            this.lbYazdir.Name = "lbYazdir";
            this.lbYazdir.Size = new System.Drawing.Size(212, 95);
            this.lbYazdir.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cep No:";
            // 
            // mTxbCepNo
            // 
            this.mTxbCepNo.Location = new System.Drawing.Point(87, 145);
            this.mTxbCepNo.Mask = "(999) 000-0000";
            this.mTxbCepNo.Name = "mTxbCepNo";
            this.mTxbCepNo.Size = new System.Drawing.Size(100, 20);
            this.mTxbCepNo.TabIndex = 6;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(214, 49);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(113, 23);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.Text = "Listeyi Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 403);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.mTxbCepNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbYazdir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txbBolumEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblYazdir);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.cbxBolum);
            this.Controls.Add(this.txbOgrNo);
            this.Controls.Add(this.txbSoyad);
            this.Controls.Add(this.txbAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbAd;
        private System.Windows.Forms.TextBox txbSoyad;
        private System.Windows.Forms.TextBox txbOgrNo;
        private System.Windows.Forms.ComboBox cbxBolum;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Label lblYazdir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbBolumEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lbYazdir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mTxbCepNo;
        private System.Windows.Forms.Button btnTemizle;
    }
}

