namespace Ornek2
{
    partial class s
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnToplama = new System.Windows.Forms.RadioButton();
            this.rbtnCarpma = new System.Windows.Forms.RadioButton();
            this.btnGoster = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayı Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İşlemi seçiniz:";
            // 
            // rbtnToplama
            // 
            this.rbtnToplama.AutoSize = true;
            this.rbtnToplama.Location = new System.Drawing.Point(100, 89);
            this.rbtnToplama.Name = "rbtnToplama";
            this.rbtnToplama.Size = new System.Drawing.Size(60, 17);
            this.rbtnToplama.TabIndex = 3;
            this.rbtnToplama.TabStop = true;
            this.rbtnToplama.Text = "Toplam";
            this.rbtnToplama.UseVisualStyleBackColor = true;
            // 
            // rbtnCarpma
            // 
            this.rbtnCarpma.AutoSize = true;
            this.rbtnCarpma.Location = new System.Drawing.Point(166, 89);
            this.rbtnCarpma.Name = "rbtnCarpma";
            this.rbtnCarpma.Size = new System.Drawing.Size(70, 17);
            this.rbtnCarpma.TabIndex = 4;
            this.rbtnCarpma.TabStop = true;
            this.rbtnCarpma.Text = "Faktoriyel";
            this.rbtnCarpma.UseVisualStyleBackColor = true;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(100, 126);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(119, 23);
            this.btnGoster.TabIndex = 5;
            this.btnGoster.Text = "Sonucu Goster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(99, 165);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bu program girilen sayıya kadar ki sayıların toplamını/çarpımını hesap eder.";
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 321);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.rbtnCarpma);
            this.Controls.Add(this.rbtnToplama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "s";
            this.Text = "N-toplam/Çarpım";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnToplama;
        private System.Windows.Forms.RadioButton rbtnCarpma;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
    }
}

