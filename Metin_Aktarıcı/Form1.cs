using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metin_Aktarıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAktar_TextChanged(object sender, EventArgs e)
        {
            //lblYazi.Text = txtAktar.Text;
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            lblYazi.Text = txtAktar.Text;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = checkBox1.Checked;
            txtAktar2.Text = lblYazi.Text;
            //checkBox1.Enabled = !checkBox1.Checked;
            //txtAktar2.Text = " ";

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = checkBox2.Checked;
            txtAktar2.Text = " ";
                

        }
    }
}
