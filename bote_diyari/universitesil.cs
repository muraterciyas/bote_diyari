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
    public partial class universitesil : Form
    {

        void girisekran()
        {
            textBox1.Text = "";
            dataGridView1.DataSource = "";
        }
        public universitesil()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"bote_diyari.accdb\";Persist Security Info=True");
        private void universitesil_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            girisekran();
        }
        
        private void btgeriuni_Click(object sender, EventArgs e)
        {
            adminanasayfa admin = new adminanasayfa();
            admin.Show();
            this.Close();
        }

        private void btara_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text;
            string kod = "SELECT uniadi FROM universite WHERE uniadi LIKE '%"+aranan+"%'";
            OleDbDataAdapter adapt = new OleDbDataAdapter(kod,con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Open();
            dataGridView1.DataSource = dt;
            con.Close();
            btsil.Enabled = true;
        }

        private void btsil_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand command = new OleDbCommand("delete from universite where uniadi='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarıyla Silindi");

            string aranan = textBox1.Text;
            string kod = "SELECT uniadi FROM universite WHERE uniadi LIKE '%" + aranan + "%'";
            OleDbDataAdapter adapt = new OleDbDataAdapter(kod, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Open();
            dataGridView1.DataSource = dt;
            con.Close();

        }
    }
}
