namespace nihani
{
    partial class acilis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acilis));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simbas1 = new System.Windows.Forms.Button();
            this.iddosya1 = new System.Windows.Forms.Button();
            this.idmetin1 = new System.Windows.Forms.Button();
            this.degisken1 = new System.Windows.Forms.Button();
            this.analog1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkinda,
            this.çIKIŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(257, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hakkinda
            // 
            this.hakkinda.Name = "hakkinda";
            this.hakkinda.Size = new System.Drawing.Size(78, 20);
            this.hakkinda.Text = "HAKKINDA";
            this.hakkinda.Click += new System.EventHandler(this.hakkinda_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // simbas1
            // 
            this.simbas1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.simbas1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.simbas1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simbas1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.simbas1.Location = new System.Drawing.Point(12, 32);
            this.simbas1.Name = "simbas1";
            this.simbas1.Size = new System.Drawing.Size(234, 54);
            this.simbas1.TabIndex = 38;
            this.simbas1.Text = "SIMETRIK BASE64 ŞIFRELEME";
            this.simbas1.UseVisualStyleBackColor = false;
            this.simbas1.Click += new System.EventHandler(this.simbas1_Click);
            // 
            // iddosya1
            // 
            this.iddosya1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iddosya1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iddosya1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iddosya1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iddosya1.Location = new System.Drawing.Point(12, 92);
            this.iddosya1.Name = "iddosya1";
            this.iddosya1.Size = new System.Drawing.Size(234, 54);
            this.iddosya1.TabIndex = 39;
            this.iddosya1.Text = "ANAKART ID\'SINE GÖRE DOSYA ŞIFRELEME";
            this.iddosya1.UseVisualStyleBackColor = false;
            this.iddosya1.Click += new System.EventHandler(this.iddosya1_Click);
            // 
            // idmetin1
            // 
            this.idmetin1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.idmetin1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.idmetin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idmetin1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.idmetin1.Location = new System.Drawing.Point(11, 152);
            this.idmetin1.Name = "idmetin1";
            this.idmetin1.Size = new System.Drawing.Size(234, 54);
            this.idmetin1.TabIndex = 40;
            this.idmetin1.Text = "ANAKART ID\'SINE GÖRE METIN ŞIFRELEME";
            this.idmetin1.UseVisualStyleBackColor = false;
            this.idmetin1.Click += new System.EventHandler(this.idmetin1_Click);
            // 
            // degisken1
            // 
            this.degisken1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.degisken1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.degisken1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.degisken1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.degisken1.Location = new System.Drawing.Point(12, 212);
            this.degisken1.Name = "degisken1";
            this.degisken1.Size = new System.Drawing.Size(234, 54);
            this.degisken1.TabIndex = 41;
            this.degisken1.Text = "DEĞIŞKEN GÜVENLIKLI DOSYA ŞIFRELEME";
            this.degisken1.UseVisualStyleBackColor = false;
            this.degisken1.Click += new System.EventHandler(this.degisken1_Click);
            // 
            // analog1
            // 
            this.analog1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.analog1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.analog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.analog1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.analog1.Location = new System.Drawing.Point(12, 272);
            this.analog1.Name = "analog1";
            this.analog1.Size = new System.Drawing.Size(234, 54);
            this.analog1.TabIndex = 43;
            this.analog1.Text = "ANALOG SINYALLERLE ŞIFRELEME";
            this.analog1.UseVisualStyleBackColor = false;
            this.analog1.Click += new System.EventHandler(this.analog1_Click);
            // 
            // acilis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(257, 337);
            this.Controls.Add(this.analog1);
            this.Controls.Add(this.degisken1);
            this.Controls.Add(this.idmetin1);
            this.Controls.Add(this.iddosya1);
            this.Controls.Add(this.simbas1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(273, 376);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(273, 376);
            this.Name = "acilis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.acilis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hakkinda;
        private System.Windows.Forms.Button simbas1;
        private System.Windows.Forms.Button iddosya1;
        private System.Windows.Forms.Button idmetin1;
        private System.Windows.Forms.Button degisken1;
        private System.Windows.Forms.Button analog1;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
    }
}

