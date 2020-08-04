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
    public partial class geri : Form
    {
        public geri()
        {
            InitializeComponent();
        }

        private void btuniler_Click(object sender, EventArgs e)
        {
            universite uni = new universite();
            uni.Show();
            this.Hide();
        }

        private void btakad_Click(object sender, EventArgs e)
        {
            akademisyen ak = new akademisyen();
            ak.Show();
            this.Hide();
        }

        private void btders_Click(object sender, EventArgs e)
        {
            dersler ders = new dersler();
            ders.Show();
            this.Hide();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ilksayfa ilk = new ilksayfa();
            ilk.Show();
            this.Close();
        }
    }
}
