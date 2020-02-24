namespace E_Günce
{
    partial class egunce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(egunce));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sifrele = new System.Windows.Forms.Button();
            this.sifreleKaydet = new System.Windows.Forms.Button();
            this.sifreleKonum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sifreleAnahtar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sifreleMetin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sifrecoz = new System.Windows.Forms.Button();
            this.ac = new System.Windows.Forms.Button();
            this.sifrecozKonum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sifrecozAnahtar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sifrecozMetin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.temizle1 = new System.Windows.Forms.Button();
            this.temizle2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.temizle1);
            this.groupBox1.Controls.Add(this.sifrele);
            this.groupBox1.Controls.Add(this.sifreleKaydet);
            this.groupBox1.Controls.Add(this.sifreleKonum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sifreleAnahtar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sifreleMetin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(456, 482);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Günlük Şifrele";
            // 
            // sifrele
            // 
            this.sifrele.Image = ((System.Drawing.Image)(resources.GetObject("sifrele.Image")));
            this.sifrele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sifrele.Location = new System.Drawing.Point(7, 426);
            this.sifrele.Name = "sifrele";
            this.sifrele.Size = new System.Drawing.Size(109, 46);
            this.sifrele.TabIndex = 7;
            this.sifrele.Text = "Şifrele";
            this.sifrele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sifrele.UseVisualStyleBackColor = true;
            this.sifrele.Click += new System.EventHandler(this.sifrele_Click);
            // 
            // sifreleKaydet
            // 
            this.sifreleKaydet.Location = new System.Drawing.Point(385, 395);
            this.sifreleKaydet.Name = "sifreleKaydet";
            this.sifreleKaydet.Size = new System.Drawing.Size(64, 25);
            this.sifreleKaydet.TabIndex = 6;
            this.sifreleKaydet.Text = "Kaydet";
            this.sifreleKaydet.UseVisualStyleBackColor = true;
            this.sifreleKaydet.Click += new System.EventHandler(this.sifreleKaydet_Click);
            // 
            // sifreleKonum
            // 
            this.sifreleKonum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sifreleKonum.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreleKonum.Location = new System.Drawing.Point(7, 395);
            this.sifreleKonum.Name = "sifreleKonum";
            this.sifreleKonum.Size = new System.Drawing.Size(372, 25);
            this.sifreleKonum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kayıt Konumu:";
            // 
            // sifreleAnahtar
            // 
            this.sifreleAnahtar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sifreleAnahtar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreleAnahtar.Location = new System.Drawing.Point(7, 346);
            this.sifreleAnahtar.Name = "sifreleAnahtar";
            this.sifreleAnahtar.Size = new System.Drawing.Size(442, 25);
            this.sifreleAnahtar.TabIndex = 3;
            this.sifreleAnahtar.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anahtar:";
            // 
            // sifreleMetin
            // 
            this.sifreleMetin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sifreleMetin.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreleMetin.Location = new System.Drawing.Point(7, 43);
            this.sifreleMetin.Multiline = true;
            this.sifreleMetin.Name = "sifreleMetin";
            this.sifreleMetin.Size = new System.Drawing.Size(442, 279);
            this.sifreleMetin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifresiz Metin:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.temizle2);
            this.groupBox2.Controls.Add(this.sifrecoz);
            this.groupBox2.Controls.Add(this.ac);
            this.groupBox2.Controls.Add(this.sifrecozKonum);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.sifrecozAnahtar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.sifrecozMetin);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(480, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(456, 482);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Günlük Şifresi Çöz";
            // 
            // sifrecoz
            // 
            this.sifrecoz.Image = ((System.Drawing.Image)(resources.GetObject("sifrecoz.Image")));
            this.sifrecoz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sifrecoz.Location = new System.Drawing.Point(10, 426);
            this.sifrecoz.Name = "sifrecoz";
            this.sifrecoz.Size = new System.Drawing.Size(125, 46);
            this.sifrecoz.TabIndex = 15;
            this.sifrecoz.Text = "Şifre Çöz";
            this.sifrecoz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sifrecoz.UseVisualStyleBackColor = true;
            this.sifrecoz.Click += new System.EventHandler(this.sifrecoz_Click);
            // 
            // ac
            // 
            this.ac.Location = new System.Drawing.Point(388, 395);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(64, 25);
            this.ac.TabIndex = 14;
            this.ac.Text = "Aç";
            this.ac.UseVisualStyleBackColor = true;
            this.ac.Click += new System.EventHandler(this.ac_Click);
            // 
            // sifrecozKonum
            // 
            this.sifrecozKonum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sifrecozKonum.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrecozKonum.Location = new System.Drawing.Point(10, 395);
            this.sifrecozKonum.Name = "sifrecozKonum";
            this.sifrecozKonum.Size = new System.Drawing.Size(372, 25);
            this.sifrecozKonum.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Şifreli Dosya Konumu:";
            // 
            // sifrecozAnahtar
            // 
            this.sifrecozAnahtar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sifrecozAnahtar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrecozAnahtar.Location = new System.Drawing.Point(10, 346);
            this.sifrecozAnahtar.Name = "sifrecozAnahtar";
            this.sifrecozAnahtar.Size = new System.Drawing.Size(442, 25);
            this.sifrecozAnahtar.TabIndex = 11;
            this.sifrecozAnahtar.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Anahtar:";
            // 
            // sifrecozMetin
            // 
            this.sifrecozMetin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sifrecozMetin.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrecozMetin.Location = new System.Drawing.Point(10, 43);
            this.sifrecozMetin.Multiline = true;
            this.sifrecozMetin.Name = "sifrecozMetin";
            this.sifrecozMetin.Size = new System.Drawing.Size(442, 279);
            this.sifrecozMetin.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Çözülmüş Metin:";
            // 
            // temizle1
            // 
            this.temizle1.Image = ((System.Drawing.Image)(resources.GetObject("temizle1.Image")));
            this.temizle1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.temizle1.Location = new System.Drawing.Point(340, 426);
            this.temizle1.Name = "temizle1";
            this.temizle1.Size = new System.Drawing.Size(109, 46);
            this.temizle1.TabIndex = 8;
            this.temizle1.Text = "Temizle";
            this.temizle1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.temizle1.UseVisualStyleBackColor = true;
            this.temizle1.Click += new System.EventHandler(this.temizle1_Click);
            // 
            // temizle2
            // 
            this.temizle2.Image = ((System.Drawing.Image)(resources.GetObject("temizle2.Image")));
            this.temizle2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.temizle2.Location = new System.Drawing.Point(340, 426);
            this.temizle2.Name = "temizle2";
            this.temizle2.Size = new System.Drawing.Size(109, 46);
            this.temizle2.TabIndex = 8;
            this.temizle2.Text = "Temizle";
            this.temizle2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.temizle2.UseVisualStyleBackColor = true;
            this.temizle2.Click += new System.EventHandler(this.temizle2_Click);
            // 
            // egunce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(949, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "egunce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Günce";
            this.Load += new System.EventHandler(this.egunce_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox sifreleMetin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sifreleKaydet;
        private System.Windows.Forms.TextBox sifreleKonum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sifreleAnahtar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sifrele;
        private System.Windows.Forms.Button sifrecoz;
        private System.Windows.Forms.Button ac;
        private System.Windows.Forms.TextBox sifrecozKonum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sifrecozAnahtar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sifrecozMetin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button temizle1;
        private System.Windows.Forms.Button temizle2;
    }
}

