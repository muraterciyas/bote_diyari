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
    public partial class dersler : Form
    {
        public dersler()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"bote_diyari.accdb\";Persist Security Info=True");
        private void btgeriders_Click(object sender, EventArgs e)
        {
            geri ana = new geri();
            ana.Show();
            this.Close();
        }

        private void dersler_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            string kod2 = "SELECT * FROM dersler ORDER BY dersadi";
            OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
            DataTable dt2 = new DataTable();
            adapt2.Fill(dt2);
            con.Open();
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "dersadi";
            comboBox1.ValueMember = "dersid";
            con.Close();

        }

        private void btliste_Click(object sender, EventArgs e)
        {
            int seciliders = Convert.ToInt32(comboBox1.SelectedValue);
            string kod3 = "SELECT akademisyen.adsoyad,universite.uniadi FROM akademisyen,universite,verilenders,dersler WHERE dersler.dersid="+seciliders+" AND verilenders.dersid=dersler.dersid AND verilenders.unino=universite.unino AND akademisyen.unino=universite.unino AND akademisyen.akno=verilenders.akno";
            OleDbDataAdapter adapt3 = new OleDbDataAdapter(kod3, con);
            DataTable dt3 = new DataTable();
            adapt3.Fill(dt3);
            con.Open();
            dataGridView1.DataSource = dt3;
            con.Close();
        }

       
    }
}
