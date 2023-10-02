namespace Dikdörtgen_alan_ve_çevre_hesaplama
{
    partial class Form1
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
            this.lblKisakenar = new System.Windows.Forms.Label();
            this.lblUzunkenar = new System.Windows.Forms.Label();
            this.lblAlan = new System.Windows.Forms.Label();
            this.lblCevre = new System.Windows.Forms.Label();
            this.txtKisakenar = new System.Windows.Forms.TextBox();
            this.txtUzunkenar = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKisakenar
            // 
            this.lblKisakenar.AutoSize = true;
            this.lblKisakenar.Location = new System.Drawing.Point(34, 49);
            this.lblKisakenar.Name = "lblKisakenar";
            this.lblKisakenar.Size = new System.Drawing.Size(58, 13);
            this.lblKisakenar.TabIndex = 0;
            this.lblKisakenar.Text = "Kısa Kenar";
            // 
            // lblUzunkenar
            // 
            this.lblUzunkenar.AutoSize = true;
            this.lblUzunkenar.Location = new System.Drawing.Point(34, 92);
            this.lblUzunkenar.Name = "lblUzunkenar";
            this.lblUzunkenar.Size = new System.Drawing.Size(62, 13);
            this.lblUzunkenar.TabIndex = 1;
            this.lblUzunkenar.Text = "Uzun kenar";
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Location = new System.Drawing.Point(34, 204);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(28, 13);
            this.lblAlan.TabIndex = 2;
            this.lblAlan.Text = "Alan";
            // 
            // lblCevre
            // 
            this.lblCevre.AutoSize = true;
            this.lblCevre.Location = new System.Drawing.Point(34, 241);
            this.lblCevre.Name = "lblCevre";
            this.lblCevre.Size = new System.Drawing.Size(35, 13);
            this.lblCevre.TabIndex = 3;
            this.lblCevre.Text = "Çevre";
            // 
            // txtKisakenar
            // 
            this.txtKisakenar.Location = new System.Drawing.Point(98, 46);
            this.txtKisakenar.Name = "txtKisakenar";
            this.txtKisakenar.Size = new System.Drawing.Size(100, 20);
            this.txtKisakenar.TabIndex = 4;
            // 
            // txtUzunkenar
            // 
            this.txtUzunkenar.Location = new System.Drawing.Point(98, 85);
            this.txtUzunkenar.Name = "txtUzunkenar";
            this.txtUzunkenar.Size = new System.Drawing.Size(100, 20);
            this.txtUzunkenar.TabIndex = 5;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(98, 127);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 40);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtUzunkenar);
            this.Controls.Add(this.txtKisakenar);
            this.Controls.Add(this.lblCevre);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.lblUzunkenar);
            this.Controls.Add(this.lblKisakenar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKisakenar;
        private System.Windows.Forms.Label lblUzunkenar;
        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.Label lblCevre;
        private System.Windows.Forms.TextBox txtKisakenar;
        private System.Windows.Forms.TextBox txtUzunkenar;
        private System.Windows.Forms.Button btnHesapla;
    }
}

