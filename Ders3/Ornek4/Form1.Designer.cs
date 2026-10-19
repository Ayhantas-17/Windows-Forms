namespace Ornek4
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
            this.txbSayi1 = new System.Windows.Forms.TextBox();
            this.txbSayi2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnToplama = new System.Windows.Forms.RadioButton();
            this.rbtnCikarma = new System.Windows.Forms.RadioButton();
            this.rbtnCarpim = new System.Windows.Forms.RadioButton();
            this.rbtnBolme = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblHesapla = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı 2:";
            // 
            // txbSayi1
            // 
            this.txbSayi1.Location = new System.Drawing.Point(125, 68);
            this.txbSayi1.Name = "txbSayi1";
            this.txbSayi1.Size = new System.Drawing.Size(100, 20);
            this.txbSayi1.TabIndex = 2;
            // 
            // txbSayi2
            // 
            this.txbSayi2.Location = new System.Drawing.Point(125, 109);
            this.txbSayi2.Name = "txbSayi2";
            this.txbSayi2.Size = new System.Drawing.Size(100, 20);
            this.txbSayi2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnBolme);
            this.groupBox1.Controls.Add(this.rbtnCarpim);
            this.groupBox1.Controls.Add(this.rbtnCikarma);
            this.groupBox1.Controls.Add(this.rbtnToplama);
            this.groupBox1.Location = new System.Drawing.Point(83, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // rbtnToplama
            // 
            this.rbtnToplama.AutoSize = true;
            this.rbtnToplama.Location = new System.Drawing.Point(6, 19);
            this.rbtnToplama.Name = "rbtnToplama";
            this.rbtnToplama.Size = new System.Drawing.Size(66, 17);
            this.rbtnToplama.TabIndex = 0;
            this.rbtnToplama.TabStop = true;
            this.rbtnToplama.Text = "Toplama";
            this.rbtnToplama.UseVisualStyleBackColor = true;
            // 
            // rbtnCikarma
            // 
            this.rbtnCikarma.AutoSize = true;
            this.rbtnCikarma.Location = new System.Drawing.Point(105, 20);
            this.rbtnCikarma.Name = "rbtnCikarma";
            this.rbtnCikarma.Size = new System.Drawing.Size(63, 17);
            this.rbtnCikarma.TabIndex = 1;
            this.rbtnCikarma.TabStop = true;
            this.rbtnCikarma.Text = "Çıkarma";
            this.rbtnCikarma.UseVisualStyleBackColor = true;
            // 
            // rbtnCarpim
            // 
            this.rbtnCarpim.AutoSize = true;
            this.rbtnCarpim.Location = new System.Drawing.Point(6, 58);
            this.rbtnCarpim.Name = "rbtnCarpim";
            this.rbtnCarpim.Size = new System.Drawing.Size(61, 17);
            this.rbtnCarpim.TabIndex = 2;
            this.rbtnCarpim.TabStop = true;
            this.rbtnCarpim.Text = "Çarpma";
            this.rbtnCarpim.UseVisualStyleBackColor = true;
            // 
            // rbtnBolme
            // 
            this.rbtnBolme.AutoSize = true;
            this.rbtnBolme.Location = new System.Drawing.Point(105, 58);
            this.rbtnBolme.Name = "rbtnBolme";
            this.rbtnBolme.Size = new System.Drawing.Size(54, 17);
            this.rbtnBolme.TabIndex = 3;
            this.rbtnBolme.TabStop = true;
            this.rbtnBolme.Text = "Bölme";
            this.rbtnBolme.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(83, 269);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblHesapla
            // 
            this.lblHesapla.AutoSize = true;
            this.lblHesapla.Location = new System.Drawing.Point(190, 274);
            this.lblHesapla.Name = "lblHesapla";
            this.lblHesapla.Size = new System.Drawing.Size(35, 13);
            this.lblHesapla.TabIndex = 6;
            this.lblHesapla.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 361);
            this.Controls.Add(this.lblHesapla);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbSayi2);
            this.Controls.Add(this.txbSayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSayi1;
        private System.Windows.Forms.TextBox txbSayi2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnBolme;
        private System.Windows.Forms.RadioButton rbtnCarpim;
        private System.Windows.Forms.RadioButton rbtnCikarma;
        private System.Windows.Forms.RadioButton rbtnToplama;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblHesapla;
    }
}

