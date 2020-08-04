using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bote_diyari
{
    public partial class universiteekle : Form
    {
        public universiteekle()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"bote_diyari.accdb\";Persist Security Info=True");
        void girisekran()
        {
            cbyuksek.Enabled = false;
            uniadi.Text = "";
            kurulustarih.Text = "";
            cbbote.Checked = false;
            tabanpuan.Text = "";
            tavanpuan.Text = "";
            kontenjan.Text = "";

            string kod2 = "SELECT * FROM iller ORDER BY iladi";
            OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
            DataTable dt2 = new DataTable();
            adapt2.Fill(dt2);
            cbil.DataSource = dt2;
            con.Open();
            cbil.ValueMember = "plaka";
            cbil.DisplayMember = "iladi";
            con.Close();
        }

        private void universiteekle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            girisekran();
        }
        private void sıfırla_Click(object sender, EventArgs e)
        {
            girisekran();
        }

        private void cbbote_Click(object sender, EventArgs e)
        {
            if (cbbote.Checked) cbyuksek.Enabled = true;
            else if (cbbote.Checked == false) cbyuksek.Enabled = false;
        }

        private void btgeriuni_Click(object sender, EventArgs e)
        {
            adminanasayfa gir = new adminanasayfa();
            gir.Show();
            this.Close();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string adi=uniadi.Text ;
            int kurtarihi = 0;
            if (kurulustarih.Text != "") {  kurtarihi = Convert.ToInt32(kurulustarih.Text); }
            
            int kont=0;
            int taban=0;
            int tavan = 0;
           if(cbbote.Checked)
           { kont = Convert.ToInt32(kontenjan.Text);
             taban = Convert.ToInt32(tabanpuan.Text);
             tavan = Convert.ToInt32(tavanpuan.Text);}
            int yukseklisans=0;
            int botedurumu=0;
            int il =Convert.ToInt32 (cbil.SelectedValue);
            
            if (cbbote.Checked)
            {
                 botedurumu = 1;
                 if (cbyuksek.Checked) { yukseklisans = 1; if (cbbote.Checked == false) { yukseklisans = 0; } }
            }
            else if(cbbote.Checked==false)
            {
                taban = 0;
                tavan = 0;
                kont=0;
                yukseklisans = 0;
                botedurumu = 0;
            }
            if (tavan >= taban)
            {

                OleDbCommand com = new OleDbCommand("INSERT INTO universite (uniadi,plaka,botedurumu,kontenjan,kurulustarih,yukseklisans,tabanpuan,tavanpuan) VALUES ('"+adi+"','"+il+"','"+botedurumu+"','"+kont+"','"+kurtarihi+"','"+yukseklisans+"','"+taban+"','"+tavan+"')", con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("kayıt başarılı");
                girisekran();
            }
            else { MessageBox.Show("Tavan puan Taban puandan büyük olmalıdır..  Kayıt eklenmedi tekrar deneyiniz.."); girisekran(); }

        }

        private void kurulustarih_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else e.Handled = true; 
        }

        private void kontenjan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else e.Handled = true; 
        }

        private void tabanpuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else e.Handled = true; 
        }

        private void tavanpuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else e.Handled = true; 
        }
    }
}
