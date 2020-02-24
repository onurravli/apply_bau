using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;
using System.Security.Cryptography;

namespace nihani
{
    public partial class analog : Form
    {
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void EncryptFile(string sourceFile, string targetFile, string key, string key2)
        {
            AesManaged AES = new AesManaged();
            using (MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider())
            {
                AES.KeySize = MD5.HashSize;
                AES.BlockSize = MD5.HashSize;
                AES.IV = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(key2));
                AES.Key = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(key));
            }
            using (FileStream reader = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            {
                using (FileStream writer = new FileStream(targetFile, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (CryptoStream cs = new CryptoStream(writer, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        int bufferSize = 4096;
                        byte[] buffer = new byte[bufferSize];
                        int bytesRead;
                        do
                        {
                            bytesRead = reader.Read(buffer, 0, bufferSize);
                            if (bytesRead != 0)
                            {
                                cs.Write(buffer, 0, bytesRead);
                            }
                        }
                        while (bytesRead != 0);
                        cs.FlushFinalBlock();
                    }
                }
            }
        }

        private void DecryptFile(string sourceFile, string targetFile, string key, string key2)
        {
            AesManaged AES = new AesManaged();
            using (MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider())
            {
                AES.KeySize = MD5.HashSize;
                AES.BlockSize = MD5.HashSize;
                AES.IV = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(key2));
                AES.Key = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(key));
            }
            using (FileStream reader = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            {
                using (FileStream writer = new FileStream(targetFile, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (CryptoStream cs = new CryptoStream(reader, AES.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        int bufferSize = 4096;
                        byte[] buffer = new byte[bufferSize];
                        int bytesRead;
                        do
                        {
                            bytesRead = cs.Read(buffer, 0, bufferSize);
                            if (bytesRead != 0)
                            {
                                writer.Write(buffer, 0, bytesRead);
                            }
                        }
                        while (bytesRead != 0);
                    }
                }
            }
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public analog()
        {
            InitializeComponent();
        }

        private void anamenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            acilis acilis = new acilis();
            acilis.Show();
        }

        private void analog_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            baglantidurumu.ForeColor = Color.Red;
            for (int i = 0; i < System.IO.Ports.SerialPort.GetPortNames().Length; i++)
            {
                comboBox1.Items.Add(System.IO.Ports.SerialPort.GetPortNames()[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("1");
                int receiveddata = Convert.ToInt16(serialPort1.ReadExisting());
                string receiveddata_b64 = Base64Encode(receiveddata.ToString());
                //receiveddata = ((receiveddata * 5000) / 1023) / 10;
                label4.Text = receiveddata.ToString();
                label11.Text = Base64Encode(receiveddata_b64);
                System.Threading.Thread.Sleep(100);
            }
            catch (Exception ex) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                timer1.Start();
                try
                {
                    serialPort1.PortName = comboBox1.Text;
                    if (!serialPort1.IsOpen)
                        serialPort1.Open();
                    baglantidurumu.ForeColor = Color.Green;
                    baglantidurumu.Text = "BAĞLI";
                }
                catch
                {
                    MessageBox.Show("ZATEN BAĞLI!");
                }
            }
            else
            {
                MessageBox.Show("PORT SEÇİNİZ");
            }
        }

        private void metkop1_Click(object sender, EventArgs e)
        {
            try
            {

                if (serialPort1.IsOpen)
                    serialPort1.Close();
                baglantidurumu.ForeColor = Color.Red;
                baglantidurumu.Text = "BAĞLI DEĞİL";
            }
            catch
            {
                MessageBox.Show("ZATEN BAĞLI DEĞİL!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string metin = Base64Encode(richTextBox2.Text);
                string anahtar = Base64Encode(label11.Text);
                string sifreli_metin = "";
                int j = 0;
                for (int k = 0; k <= metin.Length - 1; k++)
                {
                    sifreli_metin = sifreli_metin + Convert.ToChar((Convert.ToInt32(metin[k]) + Convert.ToInt32(anahtar[j])) % 255);
                    j = j + 1;
                    if (j == anahtar.Length)
                        j = 0;
                }
                richTextBox3.Text = Base64Encode(sifreli_metin);
                MessageBox.Show("ŞİFRELEME TAMAMLANDI");
            }
            catch
            {
                MessageBox.Show("BİR HATA OLUŞTU");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox3.Text != "")
                {
                    string sifreli_metin = Base64Decode(richTextBox3.Text);
                    string anahtar = Base64Encode(label11.Text);
                    string metin = "";
                    int kod = 0;
                    int j = 0;
                    for (int k = 0; k <= sifreli_metin.Length - 1; k++)
                    {
                        kod = Convert.ToInt32(sifreli_metin[k]) - Convert.ToInt32(anahtar[j]);
                        if (kod <= 0)
                            kod = kod + 255;
                        else
                            kod = kod % 255;
                        metin = metin + Convert.ToChar(kod);
                        j = j + 1;
                        if (j == anahtar.Length)
                            j = 0;
                    }
                    richTextBox2.Text = Base64Decode(metin);
                    MessageBox.Show("ŞİFRE ÇÖZME TAMAMLANDI");
                }
            }
            catch
            {
                MessageBox.Show("BİR HATA OLUŞTU");
            }
        }

        private void iddosya_ac1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaac1 = new OpenFileDialog();
            if (dosyaac1.ShowDialog() == DialogResult.OK)
            {
                analog_e1.Text = dosyaac1.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                EncryptFile(analog_e1.Text, analog_y1.Text, Base64Encode(label11.Text), label11.Text);
                MessageBox.Show("ŞİFRELEME TAMAMLANDI");
            }
            catch
            {
                MessageBox.Show("ŞİFRELEME TAMAMLANAMADI");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DecryptFile(analog_e2.Text, analog_y2.Text, Base64Encode(label11.Text), label11.Text);
                MessageBox.Show("ŞİFRE ÇÖZME TAMAMLANDI");
            }
            catch
            {
                MessageBox.Show("ŞİFRE ÇÖZME TAMAMLANAMADI");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaac1 = new OpenFileDialog();
            if (dosyaac1.ShowDialog() == DialogResult.OK)
            {
                analog_e2.Text = dosyaac1.FileName;
            }
        }

        private void iddosya_kaydet1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dosyakaydet1 = new SaveFileDialog();
            if (dosyakaydet1.ShowDialog() == DialogResult.OK)
            {
                analog_y1.Text = dosyakaydet1.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog dosyakaydet1 = new SaveFileDialog();
            if (dosyakaydet1.ShowDialog() == DialogResult.OK)
            {
                analog_y2.Text = dosyakaydet1.FileName;
            }
        }
    }
}
