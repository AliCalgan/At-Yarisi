namespace SifreÜretme
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
            this.chkbuyukHarf = new System.Windows.Forms.CheckBox();
            this.chkrakam = new System.Windows.Forms.CheckBox();
            this.chkkucukHarf = new System.Windows.Forms.CheckBox();
            this.chkOzelKarakter = new System.Windows.Forms.CheckBox();
            this.nudSifreSayisi = new System.Windows.Forms.NumericUpDown();
            this.nudSifreUzunlugu = new System.Windows.Forms.NumericUpDown();
            this.lbkSifreSayisi = new System.Windows.Forms.Label();
            this.lbluSifrezunluk = new System.Windows.Forms.Label();
            this.btnSifreUret = new System.Windows.Forms.Button();
            this.lbSifre = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).BeginInit();
            this.SuspendLayout();
            // 
            // chkbuyukHarf
            // 
            this.chkbuyukHarf.AutoSize = true;
            this.chkbuyukHarf.Location = new System.Drawing.Point(21, 31);
            this.chkbuyukHarf.Name = "chkbuyukHarf";
            this.chkbuyukHarf.Size = new System.Drawing.Size(79, 17);
            this.chkbuyukHarf.TabIndex = 0;
            this.chkbuyukHarf.Text = "Büyük Harf";
            this.chkbuyukHarf.UseVisualStyleBackColor = true;
            // 
            // chkrakam
            // 
            this.chkrakam.AutoSize = true;
            this.chkrakam.Location = new System.Drawing.Point(130, 31);
            this.chkrakam.Name = "chkrakam";
            this.chkrakam.Size = new System.Drawing.Size(60, 17);
            this.chkrakam.TabIndex = 1;
            this.chkrakam.Text = "Rakam";
            this.chkrakam.UseVisualStyleBackColor = true;
            // 
            // chkkucukHarf
            // 
            this.chkkucukHarf.AutoSize = true;
            this.chkkucukHarf.Location = new System.Drawing.Point(21, 65);
            this.chkkucukHarf.Name = "chkkucukHarf";
            this.chkkucukHarf.Size = new System.Drawing.Size(79, 17);
            this.chkkucukHarf.TabIndex = 2;
            this.chkkucukHarf.Text = "Küyük Harf";
            this.chkkucukHarf.UseVisualStyleBackColor = true;
            // 
            // chkOzelKarakter
            // 
            this.chkOzelKarakter.AutoSize = true;
            this.chkOzelKarakter.Location = new System.Drawing.Point(130, 65);
            this.chkOzelKarakter.Name = "chkOzelKarakter";
            this.chkOzelKarakter.Size = new System.Drawing.Size(101, 17);
            this.chkOzelKarakter.TabIndex = 3;
            this.chkOzelKarakter.Text = "Özel Karakterler";
            this.chkOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // nudSifreSayisi
            // 
            this.nudSifreSayisi.Location = new System.Drawing.Point(130, 102);
            this.nudSifreSayisi.Name = "nudSifreSayisi";
            this.nudSifreSayisi.Size = new System.Drawing.Size(120, 20);
            this.nudSifreSayisi.TabIndex = 4;
            // 
            // nudSifreUzunlugu
            // 
            this.nudSifreUzunlugu.Location = new System.Drawing.Point(130, 141);
            this.nudSifreUzunlugu.Name = "nudSifreUzunlugu";
            this.nudSifreUzunlugu.Size = new System.Drawing.Size(120, 20);
            this.nudSifreUzunlugu.TabIndex = 5;
            // 
            // lbkSifreSayisi
            // 
            this.lbkSifreSayisi.AutoSize = true;
            this.lbkSifreSayisi.Location = new System.Drawing.Point(21, 102);
            this.lbkSifreSayisi.Name = "lbkSifreSayisi";
            this.lbkSifreSayisi.Size = new System.Drawing.Size(58, 13);
            this.lbkSifreSayisi.TabIndex = 6;
            this.lbkSifreSayisi.Text = "Şifre Sayısı";
            // 
            // lbluSifrezunluk
            // 
            this.lbluSifrezunluk.AutoSize = true;
            this.lbluSifrezunluk.Location = new System.Drawing.Point(24, 147);
            this.lbluSifrezunluk.Name = "lbluSifrezunluk";
            this.lbluSifrezunluk.Size = new System.Drawing.Size(76, 13);
            this.lbluSifrezunluk.TabIndex = 7;
            this.lbluSifrezunluk.Text = "Şifre Uzunluğu";
            // 
            // btnSifreUret
            // 
            this.btnSifreUret.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSifreUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreUret.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSifreUret.Location = new System.Drawing.Point(27, 200);
            this.btnSifreUret.Name = "btnSifreUret";
            this.btnSifreUret.Size = new System.Drawing.Size(223, 52);
            this.btnSifreUret.TabIndex = 8;
            this.btnSifreUret.Text = "Şifre Üret";
            this.btnSifreUret.UseVisualStyleBackColor = false;
            this.btnSifreUret.Click += new System.EventHandler(this.btnSifreUret_Click);
            // 
            // lbSifre
            // 
            this.lbSifre.FormattingEnabled = true;
            this.lbSifre.Location = new System.Drawing.Point(305, 27);
            this.lbSifre.Name = "lbSifre";
            this.lbSifre.Size = new System.Drawing.Size(165, 225);
            this.lbSifre.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 283);
            this.Controls.Add(this.lbSifre);
            this.Controls.Add(this.btnSifreUret);
            this.Controls.Add(this.lbluSifrezunluk);
            this.Controls.Add(this.lbkSifreSayisi);
            this.Controls.Add(this.nudSifreUzunlugu);
            this.Controls.Add(this.nudSifreSayisi);
            this.Controls.Add(this.chkOzelKarakter);
            this.Controls.Add(this.chkkucukHarf);
            this.Controls.Add(this.chkrakam);
            this.Controls.Add(this.chkbuyukHarf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbuyukHarf;
        private System.Windows.Forms.CheckBox chkrakam;
        private System.Windows.Forms.CheckBox chkkucukHarf;
        private System.Windows.Forms.CheckBox chkOzelKarakter;
        private System.Windows.Forms.NumericUpDown nudSifreSayisi;
        private System.Windows.Forms.NumericUpDown nudSifreUzunlugu;
        private System.Windows.Forms.Label lbkSifreSayisi;
        private System.Windows.Forms.Label lbluSifrezunluk;
        private System.Windows.Forms.Button btnSifreUret;
        private System.Windows.Forms.ListBox lbSifre;
    }
}

