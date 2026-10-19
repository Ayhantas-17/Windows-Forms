namespace Ornek1
{
    partial class Surec
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnArttir10 = new System.Windows.Forms.Button();
            this.btnAzalt10 = new System.Windows.Forms.Button();
            this.btnArttir20 = new System.Windows.Forms.Button();
            this.btnAzalt20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(120, 81);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(181, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // btnArttir10
            // 
            this.btnArttir10.Location = new System.Drawing.Point(120, 138);
            this.btnArttir10.Name = "btnArttir10";
            this.btnArttir10.Size = new System.Drawing.Size(75, 23);
            this.btnArttir10.TabIndex = 1;
            this.btnArttir10.Text = "Arttır (10)";
            this.btnArttir10.UseVisualStyleBackColor = true;
            this.btnArttir10.Click += new System.EventHandler(this.btnArttir10_Click);
            // 
            // btnAzalt10
            // 
            this.btnAzalt10.Location = new System.Drawing.Point(226, 138);
            this.btnAzalt10.Name = "btnAzalt10";
            this.btnAzalt10.Size = new System.Drawing.Size(75, 23);
            this.btnAzalt10.TabIndex = 2;
            this.btnAzalt10.Text = "Azalt (10)";
            this.btnAzalt10.UseVisualStyleBackColor = true;
            this.btnAzalt10.Click += new System.EventHandler(this.btnAzalt10_Click);
            // 
            // btnArttir20
            // 
            this.btnArttir20.Location = new System.Drawing.Point(120, 190);
            this.btnArttir20.Name = "btnArttir20";
            this.btnArttir20.Size = new System.Drawing.Size(75, 23);
            this.btnArttir20.TabIndex = 3;
            this.btnArttir20.Text = "Arttır (20)";
            this.btnArttir20.UseVisualStyleBackColor = true;
            // 
            // btnAzalt20
            // 
            this.btnAzalt20.Location = new System.Drawing.Point(226, 190);
            this.btnAzalt20.Name = "btnAzalt20";
            this.btnAzalt20.Size = new System.Drawing.Size(75, 23);
            this.btnAzalt20.TabIndex = 4;
            this.btnAzalt20.Text = "Azalt (20)";
            this.btnAzalt20.UseVisualStyleBackColor = true;
            // 
            // Surec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnAzalt20);
            this.Controls.Add(this.btnArttir20);
            this.Controls.Add(this.btnAzalt10);
            this.Controls.Add(this.btnArttir10);
            this.Controls.Add(this.progressBar1);
            this.Name = "Surec";
            this.Text = "Surec";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnArttir10;
        private System.Windows.Forms.Button btnAzalt10;
        private System.Windows.Forms.Button btnArttir20;
        private System.Windows.Forms.Button btnAzalt20;
    }
}