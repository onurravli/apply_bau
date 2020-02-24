using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace nihani
{
    public partial class degisken : Form
    {
        public degisken()
        {
            InitializeComponent();
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string sif(string metin, string anahtar)
        {            
           string sifreli_metin = "";
            int j = 0;
            for (int k = 0; k <= metin.Length - 1; k++)
            {
                sifreli_metin = sifreli_metin + Convert.ToChar((Convert.ToInt32(metin[k]) + Convert.ToInt32(anahtar[j])) % 255);
                j = j + 1;
                if (j == anahtar.Length)
                    j = 0;
            }
            return sifreli_metin;
        }

        public static string coz(string metin, string anahtar)
        {
            string cozulu_metin = "";
            int kod = 0;
            int j = 0;
            for (int k = 0; k <= metin.Length - 1; k++)
            {
                kod = Convert.ToInt32(metin[k]) - Convert.ToInt32(anahtar[j]);
                if (kod <= 0)
                    kod = kod + 255;
                else
                    kod = kod % 255;
                cozulu_metin = cozulu_metin + Convert.ToChar(kod);
                j = j + 1;
                if (j == anahtar.Length)
                    j = 0;
            }
            return cozulu_metin;
        }
        private void EncryptFile(string sourceFile, string targetFile, string key)
        {

            AesManaged AES = new AesManaged();
            using (MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider())
            {
                AES.KeySize = MD5.HashSize; 
                AES.BlockSize = MD5.HashSize;
                AES.IV = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Reverse(key)));
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

        private void DecryptFile(string sourceFile, string targetFile, string key)
        {
            AesManaged AES = new AesManaged();
            using (MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider())
            {
                AES.KeySize = MD5.HashSize; // they are 128 bit compatible
                AES.BlockSize = MD5.HashSize; // they are 128 bit compatible
                AES.IV = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Reverse(key)));
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

        private void anamenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            acilis acilis = new acilis();
            acilis.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            a1.Enabled = true;a11.Enabled = true;
            a2.Enabled = true;a21.Enabled = true;
            a3.Enabled = false;a31.Enabled = false;
            a4.Enabled = false;a41.Enabled = false;          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            a1.Enabled = true; a11.Enabled = true;
            a2.Enabled = false; a21.Enabled = false;
            a3.Enabled = false; a31.Enabled = false;
            a4.Enabled = false; a41.Enabled = false;
        }

        private void degisken_Load(object sender, EventArgs e)
        {
        
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            a1.Enabled = true;
            a2.Enabled = true;
            a3.Enabled = true;
            a4.Enabled = false;
            a11.Enabled = true;
            a21.Enabled = true;
            a31.Enabled = true;
            a41.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            a1.Enabled = true;
            a2.Enabled = true;
            a3.Enabled = true;
            a4.Enabled = true;
            a11.Enabled = true;
            a21.Enabled = true;
            a31.Enabled = true;
            a41.Enabled = true;
        }

        private void ac1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaac = new OpenFileDialog();
            if (dosyaac.ShowDialog() == DialogResult.OK)
            {
                e1.Text = dosyaac.FileName;
            }
        }

        private void kaydet1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dosyakaydet = new SaveFileDialog();
            if(dosyakaydet.ShowDialog() == DialogResult.OK)
            {
                y1.Text = dosyakaydet.FileName;
            }
        }

        private void ac2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaac = new OpenFileDialog();
            if (dosyaac.ShowDialog() == DialogResult.OK)
            {
                e2.Text = dosyaac.FileName;
            }
        }

        private void kaydet2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dosyakaydet = new SaveFileDialog();
            if (dosyakaydet.ShowDialog() == DialogResult.OK)
            {
                y2.Text = dosyakaydet.FileName;
            }
        }

        private void sifrele_Click(object sender, EventArgs e)
        {
            try
            {
                //1 anahtar:
                if (a2.Enabled == false && 
                    a3.Enabled == false && 
                    a4.Enabled == false && 
                    a1.Enabled == true && 
                    a1.Text != "" && 
                    e1.Text != "" && 
                    y1.Text != "")
                {                    
                    string tekanahtar = sif(a1.Text, Reverse(a1.Text));
                    EncryptFile(e1.Text, y1.Text, Base64Encode(tekanahtar));
                    MessageBox.Show("ŞİFRELEME TAMAMLANDI");
                }


                //2 anahtar:
                else if (a2.Enabled == true && 
                    a1.Enabled == true && 
                    a3.Enabled == false && 
                    a4.Enabled == false && 
                    a1.Text != "" &&
                    a2.Text !="")
                {
                    string tekanahtar = sif(a1.Text, a2.Text);
                    EncryptFile(e1.Text, y1.Text, Base64Encode(tekanahtar));
                    MessageBox.Show("ŞİFRELEME TAMAMLANDI");
                }


                //3 anahtar:
                else if (a2.Enabled == true && 
                    a3.Enabled == true && 
                    a4.Enabled == false && 
                    a1.Enabled == true && 
                    a1.Text != "" && 
                    a2.Text != "" && 
                    a3.Text != "" && 
                    e1.Text != "" && 
                    y1.Text != "")
                {
                    string tekanahtar = sif(sif(a1.Text, a3.Text), a2.Text);
                    EncryptFile(e1.Text, y1.Text, Base64Encode(tekanahtar));
                    MessageBox.Show("ŞİFRELEME TAMAMLANDI");
                }

                //4 anahtar:
                else if (a2.Enabled == true && 
                    a3.Enabled == true && 
                    a4.Enabled == true && 
                    a1.Enabled == true && 
                    a1.Text != "" && 
                    a2.Text != "" && 
                    a3.Text != "" && 
                    a4.Text != "" && 
                    e1.Text != "" && 
                    y1.Text != "")
                {
                    string tekanahtar = sif(sif(a1.Text, a3.Text), sif(a2.Text, a4.Text));
                    EncryptFile(e1.Text, y1.Text, Base64Encode(tekanahtar));
                    MessageBox.Show("ŞİFRELEME TAMAMLANDI");
                }
                else
                {
                    MessageBox.Show("TÜM ALANLARI DOLDURUN");
                }
               
            }
            catch
            {
                MessageBox.Show("BİR HATA OLUŞTU");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //1 anahtar:
                if (a21.Enabled == false && 
                    a31.Enabled == false && 
                    a41.Enabled == false && 
                    a11.Enabled == true && 
                    a11.Text != "" && 
                    e2.Text != "" && 
                    y2.Text != "")
                {
                    string tekanahtar = sif(a11.Text, Reverse(a11.Text));
                    DecryptFile(e2.Text, y2.Text, Base64Encode(tekanahtar));
                    MessageBox.Show("ŞİFRE ÇÖZME TAMAMLANDI");
                }
                //2 anahtar:
                else if (a21.Enabled == true && 
                    a11.Enabled == true && 
                    a31.Enabled == false && 
                    a41.Enabled == false && 
                    a11.Text != "" && 
                    a21.Text != "" && 
                    e2.Text != "" && 
                    y2.Text != "")
                {
                    string tekanahtar = sif(a11.Text, a21.Text);
                    DecryptFile(e2.Text, y2.Text, Base64Encode(tekanahtar));
                    MessageBox.Show("ŞİFRE ÇÖZME TAMAMLANDI");
                }
                //3 anahtar:
                else if (a21.Enabled == true && 
                    a31.Enabled == true && 
                    a41.Enabled == false &&
                    a11.Enabled == true && 
                    a11.Text != "" && 
                    a21.Text != "" &&
                    a31.Text != "" && 
                    e2.Text != "" && 
                    y2.Text != "")
                {
                    string tekanahtar = sif(sif(a11.Text, a31.Text), a21.Text);
                    DecryptFile(e2.Text, y2.Text, Base64Encode(tekanahtar));
                    MessageBox.Show("ŞİFRE ÇÖZME TAMAMLANDI");
                }
                //4 anahtar:
                else if (a21.Enabled == true && 
                    a31.Enabled == true && 
                    a41.Enabled == true &&
                    a11.Enabled == true && 
                    a11.Text != "" && 
                    a21.Text != "" && 
                    a31.Text != "" && 
                    a41.Text != "" && 
                    e2.Text != "" &&
                    y2.Text != "")
                {
                    string tekanahtar = sif(sif(a11.Text, a31.Text), sif(a21.Text, a41.Text));
                    DecryptFile(e2.Text, y2.Text, Base64Encode(tekanahtar));
                    MessageBox.Show("ŞİFRE ÇÖZME TAMAMLANDI");
                }
                else
                {
                    MessageBox.Show("TÜM ALANLARI DOLDURUN");
                }
            }
            catch
            {
                MessageBox.Show("BİR HATA OLUŞTU");
            }
        }
    }
}
