namespace nihani
{
    partial class analog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(analog));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerSerialPort = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anamenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.baglantidurumu = new System.Windows.Forms.Label();
            this.baglan = new System.Windows.Forms.Button();
            this.kes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metsifrele = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metcoz = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idsif = new System.Windows.Forms.Button();
            this.analog_e1 = new System.Windows.Forms.TextBox();
            this.iddosya_kaydet1 = new System.Windows.Forms.Button();
            this.analog_y1 = new System.Windows.Forms.TextBox();
            this.iddosya_ac1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.idcoz = new System.Windows.Forms.Button();
            this.analog_e2 = new System.Windows.Forms.TextBox();
            this.iddosya_kaydet2 = new System.Windows.Forms.Button();
            this.analog_y2 = new System.Windows.Forms.TextBox();
            this.iddosya_ac2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anamenüToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anamenüToolStripMenuItem
            // 
            this.anamenüToolStripMenuItem.Name = "anamenüToolStripMenuItem";
            this.anamenüToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.anamenüToolStripMenuItem.Text = "↩ ANAMENÜ";
            this.anamenüToolStripMenuItem.Click += new System.EventHandler(this.anamenüToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.baglantidurumu);
            this.groupBox1.Controls.Add(this.baglan);
            this.groupBox1.Controls.Add(this.kes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 78);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PORT AYARLARI";
            // 
            // baglantidurumu
            // 
            this.baglantidurumu.AutoSize = true;
            this.baglantidurumu.Location = new System.Drawing.Point(200, 36);
            this.baglantidurumu.Name = "baglantidurumu";
            this.baglantidurumu.Size = new System.Drawing.Size(84, 13);
            this.baglantidurumu.TabIndex = 64;
            this.baglantidurumu.Text = "BAĞLI DEĞİL";
            // 
            // baglan
            // 
            this.baglan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.baglan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.baglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baglan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.baglan.Location = new System.Drawing.Point(10, 46);
            this.baglan.Name = "baglan";
            this.baglan.Size = new System.Drawing.Size(89, 20);
            this.baglan.TabIndex = 62;
            this.baglan.Text = "BAĞLAN";
            this.baglan.UseVisualStyleBackColor = false;
            this.baglan.Click += new System.EventHandler(this.button1_Click);
            // 
            // kes
            // 
            this.kes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.kes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kes.Location = new System.Drawing.Point(105, 46);
            this.kes.Name = "kes";
            this.kes.Size = new System.Drawing.Size(89, 20);
            this.kes.TabIndex = 61;
            this.kes.Text = "KES";
            this.kes.UseVisualStyleBackColor = false;
            this.kes.Click += new System.EventHandler(this.metkop1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PORT:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 153);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VERİ MONİTÖRÜ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(278, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SON ALINAN:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metsifrele);
            this.groupBox3.Controls.Add(this.richTextBox2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(308, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 237);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "METİN ŞİFRELEME";
            // 
            // metsifrele
            // 
            this.metsifrele.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.metsifrele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.metsifrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metsifrele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metsifrele.Location = new System.Drawing.Point(134, 185);
            this.metsifrele.Name = "metsifrele";
            this.metsifrele.Size = new System.Drawing.Size(89, 20);
            this.metsifrele.TabIndex = 63;
            this.metsifrele.Text = "ŞİFRELE";
            this.metsifrele.UseVisualStyleBackColor = false;
            this.metsifrele.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(9, 32);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(214, 147);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "METİN:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.metcoz);
            this.groupBox4.Controls.Add(this.richTextBox3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(543, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 237);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ŞİFRE ÇÖZME";
            // 
            // metcoz
            // 
            this.metcoz.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.metcoz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.metcoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metcoz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metcoz.Location = new System.Drawing.Point(134, 185);
            this.metcoz.Name = "metcoz";
            this.metcoz.Size = new System.Drawing.Size(89, 20);
            this.metcoz.TabIndex = 66;
            this.metcoz.Text = "ŞİFRE ÇÖZ";
            this.metcoz.UseVisualStyleBackColor = false;
            this.metcoz.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(9, 32);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(214, 147);
            this.richTextBox3.TabIndex = 65;
            this.richTextBox3.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "ŞİFRELİ METİN:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.idsif);
            this.groupBox5.Controls.Add(this.analog_e1);
            this.groupBox5.Controls.Add(this.iddosya_kaydet1);
            this.groupBox5.Controls.Add(this.analog_y1);
            this.groupBox5.Controls.Add(this.iddosya_ac1);
            this.groupBox5.Location = new System.Drawing.Point(12, 270);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(760, 149);
            this.groupBox5.TabIndex = 64;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DOSYA ŞİFRELEME";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(226, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "label11";
            this.label11.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "YENİ YOL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "DOSYA YOLU:";
            // 
            // idsif
            // 
            this.idsif.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.idsif.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.idsif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idsif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.idsif.Location = new System.Drawing.Point(665, 112);
            this.idsif.Name = "idsif";
            this.idsif.Size = new System.Drawing.Size(89, 20);
            this.idsif.TabIndex = 67;
            this.idsif.Text = "ŞİFRELE";
            this.idsif.UseVisualStyleBackColor = false;
            this.idsif.Click += new System.EventHandler(this.button4_Click);
            // 
            // analog_e1
            // 
            this.analog_e1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.analog_e1.Location = new System.Drawing.Point(9, 37);
            this.analog_e1.Name = "analog_e1";
            this.analog_e1.Size = new System.Drawing.Size(650, 20);
            this.analog_e1.TabIndex = 62;
            // 
            // iddosya_kaydet1
            // 
            this.iddosya_kaydet1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iddosya_kaydet1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iddosya_kaydet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iddosya_kaydet1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iddosya_kaydet1.Location = new System.Drawing.Point(665, 76);
            this.iddosya_kaydet1.Name = "iddosya_kaydet1";
            this.iddosya_kaydet1.Size = new System.Drawing.Size(89, 20);
            this.iddosya_kaydet1.TabIndex = 66;
            this.iddosya_kaydet1.Text = "KAYDET";
            this.iddosya_kaydet1.UseVisualStyleBackColor = false;
            this.iddosya_kaydet1.Click += new System.EventHandler(this.iddosya_kaydet1_Click);
            // 
            // analog_y1
            // 
            this.analog_y1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.analog_y1.Location = new System.Drawing.Point(9, 76);
            this.analog_y1.Name = "analog_y1";
            this.analog_y1.Size = new System.Drawing.Size(650, 20);
            this.analog_y1.TabIndex = 63;
            // 
            // iddosya_ac1
            // 
            this.iddosya_ac1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iddosya_ac1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iddosya_ac1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iddosya_ac1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iddosya_ac1.Location = new System.Drawing.Point(665, 37);
            this.iddosya_ac1.Name = "iddosya_ac1";
            this.iddosya_ac1.Size = new System.Drawing.Size(89, 20);
            this.iddosya_ac1.TabIndex = 65;
            this.iddosya_ac1.Text = "AÇ";
            this.iddosya_ac1.UseVisualStyleBackColor = false;
            this.iddosya_ac1.Click += new System.EventHandler(this.iddosya_ac1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.idcoz);
            this.groupBox6.Controls.Add(this.analog_e2);
            this.groupBox6.Controls.Add(this.iddosya_kaydet2);
            this.groupBox6.Controls.Add(this.analog_y2);
            this.groupBox6.Controls.Add(this.iddosya_ac2);
            this.groupBox6.Location = new System.Drawing.Point(12, 425);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(760, 149);
            this.groupBox6.TabIndex = 65;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "DOSYA ŞİFRE ÇÖZME";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "YENİ YOL:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "DOSYA YOLU:";
            // 
            // idcoz
            // 
            this.idcoz.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.idcoz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.idcoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idcoz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.idcoz.Location = new System.Drawing.Point(666, 112);
            this.idcoz.Name = "idcoz";
            this.idcoz.Size = new System.Drawing.Size(89, 20);
            this.idcoz.TabIndex = 74;
            this.idcoz.Text = "ŞİFRE ÇÖZ";
            this.idcoz.UseVisualStyleBackColor = false;
            this.idcoz.Click += new System.EventHandler(this.button5_Click);
            // 
            // analog_e2
            // 
            this.analog_e2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.analog_e2.Location = new System.Drawing.Point(10, 37);
            this.analog_e2.Name = "analog_e2";
            this.analog_e2.Size = new System.Drawing.Size(650, 20);
            this.analog_e2.TabIndex = 69;
            // 
            // iddosya_kaydet2
            // 
            this.iddosya_kaydet2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iddosya_kaydet2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iddosya_kaydet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iddosya_kaydet2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iddosya_kaydet2.Location = new System.Drawing.Point(666, 76);
            this.iddosya_kaydet2.Name = "iddosya_kaydet2";
            this.iddosya_kaydet2.Size = new System.Drawing.Size(89, 20);
            this.iddosya_kaydet2.TabIndex = 73;
            this.iddosya_kaydet2.Text = "KAYDET";
            this.iddosya_kaydet2.UseVisualStyleBackColor = false;
            this.iddosya_kaydet2.Click += new System.EventHandler(this.button6_Click);
            // 
            // analog_y2
            // 
            this.analog_y2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.analog_y2.Location = new System.Drawing.Point(10, 76);
            this.analog_y2.Name = "analog_y2";
            this.analog_y2.Size = new System.Drawing.Size(650, 20);
            this.analog_y2.TabIndex = 70;
            // 
            // iddosya_ac2
            // 
            this.iddosya_ac2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iddosya_ac2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iddosya_ac2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iddosya_ac2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iddosya_ac2.Location = new System.Drawing.Point(666, 37);
            this.iddosya_ac2.Name = "iddosya_ac2";
            this.iddosya_ac2.Size = new System.Drawing.Size(89, 20);
            this.iddosya_ac2.TabIndex = 72;
            this.iddosya_ac2.Text = "AÇ";
            this.iddosya_ac2.UseVisualStyleBackColor = false;
            this.iddosya_ac2.Click += new System.EventHandler(this.button7_Click);
            // 
            // analog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(783, 580);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(799, 619);
            this.MinimumSize = new System.Drawing.Size(799, 619);
            this.Name = "analog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANALOG SINYALLERLE ŞIFRELEME";
            this.Load += new System.EventHandler(this.analog_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerSerialPort;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anamenüToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button kes;
        private System.Windows.Forms.Button baglan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label baglantidurumu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button metsifrele;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button metcoz;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button idsif;
        private System.Windows.Forms.TextBox analog_e1;
        private System.Windows.Forms.Button iddosya_kaydet1;
        private System.Windows.Forms.TextBox analog_y1;
        private System.Windows.Forms.Button iddosya_ac1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button idcoz;
        private System.Windows.Forms.TextBox analog_e2;
        private System.Windows.Forms.Button iddosya_kaydet2;
        private System.Windows.Forms.TextBox analog_y2;
        private System.Windows.Forms.Button iddosya_ac2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label11;
    }
}