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
    public partial class universiteguncelle : Form
    {
        public universiteguncelle()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"bote_diyari.accdb\";Persist Security Info=True");
            private void btgeriuni_Click(object sender, EventArgs e)
        {
            adminanasayfa ana = new adminanasayfa();
            ana.Show();
            this.Close();
        }

        private void universiteguncelle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            timer1.Enabled = false;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
                if (this.Width != 710)
                {
                    this.Width += 10;
                }
           

            groupBox1.Visible = true;
        }
        private void btara_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text;
            string kod = "SELECT universite.uniadi,iller.iladi,universite.botedurumu, universite.kontenjan,universite.kurulustarih,universite.yukseklisans,universite.tabanpuan,universite.tavanpuan,universite.unino FROM universite ,iller WHERE universite.plaka=iller.plaka  AND uniadi LIKE '%" + aranan + "%'";
            OleDbDataAdapter adapt = new OleDbDataAdapter(kod, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Open();
            dataGridView1.DataSource = dt;
            con.Close();
            btguncelle.Enabled = true;
            dataGridView1.Columns[0].Width = 200;
        }
        private void btguncelle_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            uniadi.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            kurulustarih.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cbil.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); ;
            kontenjan.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tabanpuan.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tavanpuan.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            string bote = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            label14.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            if (bote == "True") cbbote.Checked = true;
            else if (bote == "False") cbbote.Checked = false;
            string yuksek = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            if (yuksek == "True") cbyuksek.Checked = true;
            else if (yuksek == "False") cbyuksek.Checked = false; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adi = uniadi.Text;
            int kurulus =Convert.ToInt32 (kurulustarih.Text);
            int il = Convert.ToInt32(cbil.SelectedValue);
            int kont = Convert.ToInt32(kontenjan.Text);
            int taban = Convert.ToInt32(tabanpuan.Text);
            int tavan = Convert.ToInt32(tavanpuan.Text);
            int bote=0;
            int yuksek=0;
            if (cbbote.Checked) bote = 1;
            if (cbyuksek.Checked) yuksek = 1;
            int parametre = Convert.ToInt32(label14.Text);

            string kod = "update universite set uniadi='" + adi + "' , plaka='" +il+ "', botedurumu='" + bote + "' , kontenjan='" + kont + "' , kurulustarih='" + kurulus + "' , yukseklisans='" + yuksek + "' , tabanpuan='"+taban+"', tavanpuan='"+tavan+"'  where unino=" + parametre + "";


            con.Open();
            OleDbCommand command = new OleDbCommand(kod, con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarıyla Güncellendi");
            string aranan = textBox1.Text;
            string kod2 = "SELECT universite.uniadi,iller.iladi,universite.botedurumu, universite.kontenjan,universite.kurulustarih,universite.yukseklisans,universite.tabanpuan,universite.tavanpuan,universite.unino FROM universite ,iller WHERE universite.plaka=iller.plaka  AND uniadi LIKE '%" + aranan + "%'";
            OleDbDataAdapter adapt = new OleDbDataAdapter(kod2, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Open();
            dataGridView1.DataSource = dt;
            con.Close();
            btguncelle.Enabled = true;
            dataGridView1.Columns[0].Width = 200;
            timer1.Enabled = false;
            timer2.Enabled = true;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Width != 430)
            {
                this.Width -= 10;
            }
            groupBox1.Visible = false;
        }

        
    }
}
