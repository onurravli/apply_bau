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

namespace nihani
{
    public partial class idmetin : Form
    {
        public idmetin()
        {
            InitializeComponent();
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
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

        private void sifrele2_Click(object sender, EventArgs e)
        {
            try
            {
                if (sifresizMetin2.Text != "") {
                    string metin = Base64Encode(sifresizMetin2.Text);
                    string anahtar = anahtarlisifre(getMotherBoardID(), anahtar1.Text);
                    string sifreli_metin = "";
                    int j = 0;
                    for (int k = 0; k <= metin.Length - 1; k++)
                    {
                        sifreli_metin = sifreli_metin + Convert.ToChar((Convert.ToInt32(metin[k]) + Convert.ToInt32(anahtar[j])) % 255);
                        j = j + 1;
                        if (j == anahtar.Length)
                            j = 0;
                    }
                    sifreliMetin2.Text = Base64Encode(sifreli_metin);
                    MessageBox.Show("ŞİFRELEME TAMAMLANDI");
                }
            }
            catch
            {
                MessageBox.Show("BİR HATA OLUŞTU");
            }
        }

        private void sifrecoz2_Click(object sender, EventArgs e)
        {
            try
            {
                if (sifreliMetin2.Text != "")
                {
                    string sifreli_metin = Base64Decode(sifreliMetin2.Text);
                    string anahtar = anahtarlisifre(getMotherBoardID(), anahtar2.Text);
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
                    sifresizMetin2.Text = Base64Decode(metin);
                    MessageBox.Show("ŞİFRE ÇÖZME TAMAMLANDI");
                }
            }
            catch
            {
                MessageBox.Show("BİR HATA OLUŞTU");
            }
        }

        private void idmetin_Load(object sender, EventArgs e)
        {

        }

        private void metkop3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(sifresizMetin2.Text);
        }

        private void metkop4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(sifreliMetin2.Text);
        }

        private void metyap3_Click(object sender, EventArgs e)
        {
            sifresizMetin2.Text =  Clipboard.GetText();
        }

        private void metyap4_Click(object sender, EventArgs e)
        {
            sifreliMetin2.Text = Clipboard.GetText();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void sifrecoz2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (sifreliMetin2.Text != "")
                {
                    string sifreli_metin = Base64Decode(sifreliMetin2.Text);
                    string anahtar = anahtarlisifre(getMotherBoardID(), anahtar2.Text);
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
                    sifresizMetin2.Text = Base64Decode(metin);
                    MessageBox.Show("ŞİFRE ÇÖZME TAMAMLANDI");
                }
            }
            catch
            {
                MessageBox.Show("BİR HATA OLUŞTU");
            }
        }
    }
}
