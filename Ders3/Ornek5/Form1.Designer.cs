namespace Ornek5
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
            this.txbAd = new System.Windows.Forms.TextBox();
            this.txbsoyad = new System.Windows.Forms.TextBox();
            this.cbxPizza = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMantar = new System.Windows.Forms.CheckBox();
            this.cbSucuk = new System.Windows.Forms.CheckBox();
            this.cbKenar = new System.Windows.Forms.CheckBox();
            this.cbKasar = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pizza Seçimi:";
            // 
            // txbAd
            // 
            this.txbAd.Location = new System.Drawing.Point(98, 53);
            this.txbAd.Name = "txbAd";
            this.txbAd.Size = new System.Drawing.Size(100, 20);
            this.txbAd.TabIndex = 3;
            // 
            // txbsoyad
            // 
            this.txbsoyad.Location = new System.Drawing.Point(97, 82);
            this.txbsoyad.Name = "txbsoyad";
            this.txbsoyad.Size = new System.Drawing.Size(100, 20);
            this.txbsoyad.TabIndex = 4;
            // 
            // cbxPizza
            // 
            this.cbxPizza.FormattingEnabled = true;
            this.cbxPizza.Items.AddRange(new object[] {
            "Napoliten",
            "Karışık",
            "Margarita"});
            this.cbxPizza.Location = new System.Drawing.Point(97, 115);
            this.cbxPizza.Name = "cbxPizza";
            this.cbxPizza.Size = new System.Drawing.Size(121, 21);
            this.cbxPizza.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMantar);
            this.groupBox1.Controls.Add(this.cbSucuk);
            this.groupBox1.Controls.Add(this.cbKenar);
            this.groupBox1.Controls.Add(this.cbKasar);
            this.groupBox1.Location = new System.Drawing.Point(253, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 83);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlave Ürünler";
            // 
            // cbMantar
            // 
            this.cbMantar.AutoSize = true;
            this.cbMantar.Location = new System.Drawing.Point(92, 48);
            this.cbMantar.Name = "cbMantar";
            this.cbMantar.Size = new System.Drawing.Size(59, 17);
            this.cbMantar.TabIndex = 3;
            this.cbMantar.Text = "Mantar";
            this.cbMantar.UseVisualStyleBackColor = true;
            // 
            // cbSucuk
            // 
            this.cbSucuk.AutoSize = true;
            this.cbSucuk.Location = new System.Drawing.Point(92, 24);
            this.cbSucuk.Name = "cbSucuk";
            this.cbSucuk.Size = new System.Drawing.Size(57, 17);
            this.cbSucuk.TabIndex = 2;
            this.cbSucuk.Text = "Sucuk";
            this.cbSucuk.UseVisualStyleBackColor = true;
            // 
            // cbKenar
            // 
            this.cbKenar.AutoSize = true;
            this.cbKenar.Location = new System.Drawing.Point(7, 49);
            this.cbKenar.Name = "cbKenar";
            this.cbKenar.Size = new System.Drawing.Size(79, 17);
            this.cbKenar.TabIndex = 1;
            this.cbKenar.Text = "Simir Kenar";
            this.cbKenar.UseVisualStyleBackColor = true;
            // 
            // cbKasar
            // 
            this.cbKasar.AutoSize = true;
            this.cbKasar.Location = new System.Drawing.Point(7, 25);
            this.cbKasar.Name = "cbKasar";
            this.cbKasar.Size = new System.Drawing.Size(53, 17);
            this.cbKasar.TabIndex = 0;
            this.cbKasar.Text = "Kaşar";
            this.cbKasar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 202);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(390, 95);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(25, 154);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(75, 23);
            this.btnYazdir.TabIndex = 8;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(122, 154);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(96, 23);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "Listeyi Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 352);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxPizza);
            this.Controls.Add(this.txbsoyad);
            this.Controls.Add(this.txbAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza Sipaiş Ekranı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbAd;
        private System.Windows.Forms.TextBox txbsoyad;
        private System.Windows.Forms.ComboBox cbxPizza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbMantar;
        private System.Windows.Forms.CheckBox cbSucuk;
        private System.Windows.Forms.CheckBox cbKenar;
        private System.Windows.Forms.CheckBox cbKasar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnTemizle;
    }
}

