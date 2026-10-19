namespace Ornek1
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
            this.btnSurec = new System.Windows.Forms.Button();
            this.btnMatematik = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSurec
            // 
            this.btnSurec.Location = new System.Drawing.Point(92, 58);
            this.btnSurec.Name = "btnSurec";
            this.btnSurec.Size = new System.Drawing.Size(115, 31);
            this.btnSurec.TabIndex = 0;
            this.btnSurec.Text = "Süreç Çubuğu";
            this.btnSurec.UseVisualStyleBackColor = true;
            this.btnSurec.Click += new System.EventHandler(this.btnSurec_Click);
            // 
            // btnMatematik
            // 
            this.btnMatematik.Location = new System.Drawing.Point(92, 95);
            this.btnMatematik.Name = "btnMatematik";
            this.btnMatematik.Size = new System.Drawing.Size(115, 34);
            this.btnMatematik.TabIndex = 1;
            this.btnMatematik.Text = "Matematiksel Fonksiyonlar";
            this.btnMatematik.UseVisualStyleBackColor = true;
            this.btnMatematik.Click += new System.EventHandler(this.btnMatematik_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "String Fonksiyonlar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Zaman-Tarih Metodu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 303);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMatematik);
            this.Controls.Add(this.btnSurec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSurec;
        private System.Windows.Forms.Button btnMatematik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

