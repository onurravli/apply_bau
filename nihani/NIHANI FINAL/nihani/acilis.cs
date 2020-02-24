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
    public partial class acilis : Form
    {
        public acilis()
        {
            InitializeComponent();
        }

        private void acilis_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("YAZILIM AÇILIRKEN BİR HATA OLUŞTU!");
            }

        }

        private void simbas_Click(object sender, EventArgs e)
        {
            this.Hide();
            simbas simbas = new simbas();
            simbas.Show();
        }

        private void iddosya_Click(object sender, EventArgs e)
        {
            this.Hide();
            iddosya iddosya = new iddosya();
            iddosya.Show();
        }

        private void degisken_Click(object sender, EventArgs e)
        {
            this.Hide();
            degisken degisken = new degisken();
            degisken.Show();
        }

        private void analog_Click(object sender, EventArgs e)
        {
            this.Hide();
            analog analog = new analog();
            analog.Show();
        }

        private void simbas1_Click(object sender, EventArgs e)
        {
            this.Hide();
            simbas simbas = new simbas();
            simbas.Show();
        }

        private void iddosya1_Click(object sender, EventArgs e)
        {
            this.Hide();
            iddosya iddosya = new iddosya();
            iddosya.Show();
        }

        private void idmetin1_Click(object sender, EventArgs e)
        {
            this.Hide();
            idmetin idmetin = new idmetin();
            idmetin.Show();
        }

        private void degisken1_Click(object sender, EventArgs e)
        {
            this.Hide();
            degisken degisken = new degisken();
            degisken.Show();
        }

        private void analog1_Click(object sender, EventArgs e)
        {
            this.Hide();
            analog analog = new analog();
            analog.Show();
        }

        private void hakkinda_Click(object sender, EventArgs e)
        {
            this.Hide();
            hakkinda hakkinda = new hakkinda();
            hakkinda.Show();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gorsel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
