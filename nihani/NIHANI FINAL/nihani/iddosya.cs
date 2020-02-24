using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Security.Cryptography;
using System.IO;

namespace nihani
{
    public partial class iddosya : Form
    {
        public iddosya()
        {
            InitializeComponent();
        }

        public static string anahtarlisifre(string text1, string text2)
        {
            string encry = "";
            int j = 0;
            for (int k = 0; k <= text1.Length - 1; k++)
            {
                encry = encry + Convert.ToChar((Convert.ToInt32(text1[k]) + Convert.ToInt32(text2[j])) % 255);
                j = j + 1;
                if (j == text2.Length)
                    j = 0;
            }
            return encry;
        }

        private void EncryptFile(string sourceFile, string targetFile, string key)
        {
            AesManaged AES = new AesManaged();
            using (MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider())
            {
                AES.KeySize = MD5.HashSize; // they are 128 bit compatible
                AES.BlockSize = MD5.HashSize; // they are 128 bit compatible
                AES.IV = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(getMotherBoardID()));
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
                AES.IV = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(getMotherBoardID()));
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

        public String getMotherBoardID()
        {
            String serial = "";
            try
            {
                ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
                ManagementObjectCollection moc = mos.Get();

                foreach (ManagementObject mo in moc)
                {
                    serial = mo["SerialNumber"].ToString();
                }
                return serial;
            }
            catch (Exception) { return serial; }
        }

        private void anamenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            acilis acilis = new acilis();
            acilis.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(iddosya_e1.Text != "")
                {
                    EncryptFile(iddosya_e1.Text, iddosya_y1.Text, anahtarlisifre(getMotherBoardID(), anahtar1.Text));
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (iddosya_e2.Text != "")
                {
                    DecryptFile(iddosya_e2.Text, iddosya_y2.Text, anahtarlisifre(getMotherBoardID(), anahtar2.Text));
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

        private void iddosya_ac1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaac1 = new OpenFileDialog();
            if (dosyaac1.ShowDialog() == DialogResult.OK)
            {
                iddosya_e1.Text = dosyaac1.FileName;
            }
        }

        private void iddosya_ac2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaac2 = new OpenFileDialog();
            if (dosyaac2.ShowDialog() == DialogResult.OK)
            {
                iddosya_e2.Text = dosyaac2.FileName;
            }
        }

        private void iddosya_kaydet1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dosyakaydet1 = new SaveFileDialog();
            if (dosyakaydet1.ShowDialog() == DialogResult.OK)
            {
                iddosya_y1.Text = dosyakaydet1.FileName;
            }
        }

        private void iddosya_kaydet2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dosyakaydet2 = new SaveFileDialog();
            if (dosyakaydet2.ShowDialog() == DialogResult.OK)
            {
                iddosya_y2.Text = dosyakaydet2.FileName;
            }
        }

        private void iddosya_Load(object sender, EventArgs e)
        {

        }
    }
}
