namespace Win_Form_At_Yarışı
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnbaslat = new System.Windows.Forms.Button();
            this.btnsifirla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbAt1 = new System.Windows.Forms.PictureBox();
            this.pbAt2 = new System.Windows.Forms.PictureBox();
            this.pbAt3 = new System.Windows.Forms.PictureBox();
            this.lblCanliDurum = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbaslat
            // 
            this.btnbaslat.BackColor = System.Drawing.Color.Black;
            this.btnbaslat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbaslat.Location = new System.Drawing.Point(393, 49);
            this.btnbaslat.Name = "btnbaslat";
            this.btnbaslat.Size = new System.Drawing.Size(123, 31);
            this.btnbaslat.TabIndex = 0;
            this.btnbaslat.Tag = "Baslat";
            this.btnbaslat.Text = "Yarışı Başlat";
            this.btnbaslat.UseVisualStyleBackColor = false;
            // 
            // btnsifirla
            // 
            this.btnsifirla.BackColor = System.Drawing.Color.Black;
            this.btnsifirla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsifirla.Location = new System.Drawing.Point(561, 49);
            this.btnsifirla.Name = "btnsifirla";
            this.btnsifirla.Size = new System.Drawing.Size(119, 31);
            this.btnsifirla.TabIndex = 1;
            this.btnsifirla.Tag = "Sifirla";
            this.btnsifirla.Text = "Yarışı Sıfırla";
            this.btnsifirla.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 18);
            this.label1.TabIndex = 2;
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.Black;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinish.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFinish.Location = new System.Drawing.Point(704, 93);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(43, 359);
            this.lblFinish.TabIndex = 4;
            this.lblFinish.Text = "FINISH";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(43, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(655, 19);
            this.label4.TabIndex = 5;
            // 
            // pbAt1
            // 
            this.pbAt1.Image = ((System.Drawing.Image)(resources.GetObject("pbAt1.Image")));
            this.pbAt1.Location = new System.Drawing.Point(12, 103);
            this.pbAt1.Name = "pbAt1";
            this.pbAt1.Size = new System.Drawing.Size(100, 50);
            this.pbAt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAt1.TabIndex = 6;
            this.pbAt1.TabStop = false;
            // 
            // pbAt2
            // 
            this.pbAt2.Image = ((System.Drawing.Image)(resources.GetObject("pbAt2.Image")));
            this.pbAt2.Location = new System.Drawing.Point(12, 218);
            this.pbAt2.Name = "pbAt2";
            this.pbAt2.Size = new System.Drawing.Size(100, 50);
            this.pbAt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAt2.TabIndex = 7;
            this.pbAt2.TabStop = false;
            // 
            // pbAt3
            // 
            this.pbAt3.Image = ((System.Drawing.Image)(resources.GetObject("pbAt3.Image")));
            this.pbAt3.Location = new System.Drawing.Point(12, 330);
            this.pbAt3.Name = "pbAt3";
            this.pbAt3.Size = new System.Drawing.Size(100, 50);
            this.pbAt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAt3.TabIndex = 8;
            this.pbAt3.TabStop = false;
            // 
            // lblCanliDurum
            // 
            this.lblCanliDurum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCanliDurum.Location = new System.Drawing.Point(43, 28);
            this.lblCanliDurum.Name = "lblCanliDurum";
            this.lblCanliDurum.Size = new System.Drawing.Size(313, 23);
            this.lblCanliDurum.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.lblCanliDurum);
            this.Controls.Add(this.pbAt3);
            this.Controls.Add(this.pbAt2);
            this.Controls.Add(this.pbAt1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsifirla);
            this.Controls.Add(this.btnbaslat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbaslat;
        private System.Windows.Forms.Button btnsifirla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbAt1;
        private System.Windows.Forms.PictureBox pbAt2;
        private System.Windows.Forms.PictureBox pbAt3;
        private System.Windows.Forms.Label lblCanliDurum;
        private System.Windows.Forms.Timer timer1;
    }
}

