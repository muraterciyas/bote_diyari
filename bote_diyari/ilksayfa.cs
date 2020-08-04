using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bote_diyari
{
    public partial class ilksayfa : Form
    {
        public ilksayfa()
        {
            InitializeComponent();
        }

        private void genel_Click(object sender, EventArgs e)
        {
            geri ana = new geri();
            ana.Show();
            this.Hide();
        }

        private void ilksayfa_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris giris = new giris();
            giris.Show();
            this.Hide();
        }
    }
}
