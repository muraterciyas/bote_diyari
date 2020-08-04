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
    public partial class akademisyensil : Form
    {
        public akademisyensil()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"bote_diyari.accdb\";Persist Security Info=True");
        private void btgeri_Click(object sender, EventArgs e)
        {
            adminanasayfa admin = new adminanasayfa();
            admin.Show();
            this.Close();
        }

        private void akademisyensil_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            textBox1.Text = "";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text;
            string kod = "SELECT adsoyad FROM akademisyen WHERE adsoyad LIKE '%" + aranan + "%'";
            OleDbDataAdapter adapt = new OleDbDataAdapter(kod, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Open();
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void akasil_Click(object sender, EventArgs e)
        {

            con.Open();
            OleDbCommand command = new OleDbCommand("delete from akademisyen where adsoyad='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarıyla Silindi");



            string aranan = textBox1.Text;
            string kod = "SELECT adsoyad FROM akademisyen WHERE adsoyad LIKE '%" + aranan + "%'";
            OleDbDataAdapter adapt = new OleDbDataAdapter(kod, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Open();
            dataGridView1.DataSource = dt;
            con.Close();
        }

    }
}
