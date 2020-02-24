using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nihani
{
    public partial class simbas : Form
    {
        public simbas()
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

        private void anamenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            acilis acilis = new acilis();
            acilis.Show();
        }

        private void sifrele1_Click(object sender, EventArgs e)
        {
            try
            {
                if(simbas_a.Text != "")
                {
                    if(simbas_0.Text != "")
                    {
                        string base64 = Base64Encode(simbas_0.Text);
                        string metin = base64;
                        string anahtar = this.simbas_a.Text;
                        string sifreli_metin1 = "";
                        int j = 0;
                        for (int k = 0; k <= metin.Length - 1; k++)
                        {
                            sifreli_metin1 = sifreli_metin1 + Convert.ToChar((Convert.ToInt32(metin[k]) + Convert.ToInt32(anahtar[j])) % 255);
                            j = j + 1;
                            if (j == anahtar.Length)
                                j = 0;
                        }
                        string base64_2 = Base64Encode(sifreli_metin1);
                        string ters_1 = Reverse(base64_2);
                        simbas_1.Text = ters_1;
                        MessageBox.Show("ŞİFRELEME BAŞARILI");
                    }
                    else
                    {
                        MessageBox.Show("ŞİFRESİZ METNİ GİRİNİZ");
                    }
                }
                else
                {
                    MessageBox.Show("ANAHTARI GİRİNİZ");
                }

            }
            catch
            {
                MessageBox.Show("BİR HATA OLUŞTU");
            }

        }

        private void sifrecoz1_Click(object sender, EventArgs e)
        {
            try
            {
                if(simbas_1.Text!="")
                {
                    if(simbas_a.Text != "")
                    {
                        string duz = Reverse(simbas_1.Text);
                        string base64_2_cozulu = Base64Decode(duz);
                        string sifreli_metin = base64_2_cozulu;
                        string anahtar = this.simbas_a.Text;
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
                        simbas_0.Text = Base64Decode(metin);
                        MessageBox.Show("ŞİFRE ÇÖZME BAŞARILI!");
                    }
                    else
                    {
                        MessageBox.Show("ANAHTARI GİRİNİZ");
                    }
                }
                else
                {
                    MessageBox.Show("ŞİFRELİ METNİ GİRİNİZ");
                }
            }
            catch
            {
                MessageBox.Show("BİR HATA OLUŞTU");
            }
        }

        private void metkop1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(simbas_0.Text);
        }

        private void metkop2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(simbas_1.Text);
        }

        private void metyap1_Click(object sender, EventArgs e)
        {
            simbas_0.Text = Clipboard.GetText();
        }

        private void metyap2_Click(object sender, EventArgs e)
        {
            simbas_1.Text = Clipboard.GetText();
        }

        private void uret1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            string harfler = "abcdefghijklmnoprstuvyzABCDEFGHIJKLMNOPRSTUVYZ0123456789";
            string uret = "";
            for (int i = 0; i < 6; i++)
            {
                uret += harfler[rastgele.Next(harfler.Length)];
            }
            simbas_a.Text = uret;
        }

        private void simbas_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
