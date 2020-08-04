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
    public partial class adminanasayfa : Form
    {
        public adminanasayfa()
        {
            InitializeComponent();
        }

        private void uniekle_Click(object sender, EventArgs e)
        {
            universiteekle uniekle = new universiteekle();
            uniekle.Show();
            this.Hide();
        }

        private void btgeri_Click(object sender, EventArgs e)
        {
            giris gir = new giris();
            gir.Show();
            this.Close();
        }

        private void adminanasayfa_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void unisil_Click(object sender, EventArgs e)
        {
            universitesil unisil = new universitesil();
            unisil.Show();
            this.Hide();
        }

        private void uniduzenle_Click(object sender, EventArgs e)
        {
            universiteguncelle uniguncelle = new universiteguncelle();
            uniguncelle.Show();
            this.Hide();
        }

        private void akademisyenekle_Click(object sender, EventArgs e)
        {
            akademisyenekle akekle = new akademisyenekle();
            akekle.Show();
            this.Hide();
        }

        private void akademisyensil_Click(object sender, EventArgs e)
        {
            akademisyensil aksil =new akademisyensil();
            aksil.Show();
            this.Hide();
        }

        private void akademisyenduzenle_Click(object sender, EventArgs e)
        {
            akademisyenguncelle akguncel = new akademisyenguncelle();
            akguncel.Show();
            this.Hide();
        }

        private void dersekle_Click(object sender, EventArgs e)
        {
            ders de = new ders();
            de.Show();
            this.Hide();
        }

        private void dersleridegistir_Click(object sender, EventArgs e)
        {
            verilendersduzenle duzenle = new verilendersduzenle();
            duzenle.Show();
            this.Hide();
        }
    }
}
