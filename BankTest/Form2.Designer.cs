namespace BankTest
{
    partial class Form2
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
            this.BtnGonder = new System.Windows.Forms.Button();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.MskHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblAd = new System.Windows.Forms.Label();
            this.LblHesap = new System.Windows.Forms.Label();
            this.LblTelefon = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGonder
            // 
            this.BtnGonder.Location = new System.Drawing.Point(158, 131);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(123, 37);
            this.BtnGonder.TabIndex = 8;
            this.BtnGonder.Text = "Gönder";
            this.BtnGonder.UseVisualStyleBackColor = true;
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(140, 93);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(170, 32);
            this.TxtTutar.TabIndex = 6;
            // 
            // MskHesapNo
            // 
            this.MskHesapNo.Location = new System.Drawing.Point(140, 49);
            this.MskHesapNo.Mask = "000000";
            this.MskHesapNo.Name = "MskHesapNo";
            this.MskHesapNo.Size = new System.Drawing.Size(170, 32);
            this.MskHesapNo.TabIndex = 5;
            this.MskHesapNo.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tutar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hesap No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ad Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hesap No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "TC Kimlik:";
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Location = new System.Drawing.Point(198, 18);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(50, 27);
            this.LblAd.TabIndex = 13;
            this.LblAd.Text = "null";
            // 
            // LblHesap
            // 
            this.LblHesap.AutoSize = true;
            this.LblHesap.Location = new System.Drawing.Point(198, 61);
            this.LblHesap.Name = "LblHesap";
            this.LblHesap.Size = new System.Drawing.Size(50, 27);
            this.LblHesap.TabIndex = 14;
            this.LblHesap.Text = "null";
            // 
            // LblTelefon
            // 
            this.LblTelefon.AutoSize = true;
            this.LblTelefon.Location = new System.Drawing.Point(198, 103);
            this.LblTelefon.Name = "LblTelefon";
            this.LblTelefon.Size = new System.Drawing.Size(50, 27);
            this.LblTelefon.TabIndex = 15;
            this.LblTelefon.Text = "null";
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Location = new System.Drawing.Point(198, 147);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(50, 27);
            this.LblTc.TabIndex = 16;
            this.LblTc.Text = "null";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGonder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MskHesapNo);
            this.groupBox1.Controls.Add(this.TxtTutar);
            this.groupBox1.Location = new System.Drawing.Point(12, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 202);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Havale";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(552, 423);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblTc);
            this.Controls.Add(this.LblTelefon);
            this.Controls.Add(this.LblHesap);
            this.Controls.Add(this.LblAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGonder;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.MaskedTextBox MskHesapNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Label LblHesap;
        private System.Windows.Forms.Label LblTelefon;
        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}