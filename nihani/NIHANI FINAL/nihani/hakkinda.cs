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
    public partial class hakkinda : Form
    {
        public hakkinda()
        {
            InitializeComponent();
        }

        private void tamam_Click(object sender, EventArgs e)
        {
            this.Close();
            acilis acilis = new acilis();
            acilis.Show();
        }

        private void hakkinda_Load(object sender, EventArgs e)
        {

        }

        private void hakkinda_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {            
            acilis acilis = new acilis();
            acilis.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            acilis acilis = new acilis();
            acilis.Show();
        }
    }
}
