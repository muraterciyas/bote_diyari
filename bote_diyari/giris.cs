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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void giris_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void geri_Click(object sender, EventArgs e)
        {
            ilksayfa ilk = new ilksayfa();
            ilk.Show();
            this.Close();
        }

        private void gir_Click(object sender, EventArgs e)
        {
            if (kadi.Text == "admin" && parola.Text == "admin")
            {
                adminanasayfa admin=new adminanasayfa();
                admin.Show();
                this.Hide();
            }
            else { kadi.Text = ""; parola.Text = ""; MessageBox.Show("Hatalı Giriş"); }
        }
    }
}
