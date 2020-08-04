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
    public partial class akademisyen : Form
    {
        public akademisyen()
        {
            InitializeComponent();
        }


        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"bote_diyari.accdb\";Persist Security Info=True");
        private void btgeriak_Click_1(object sender, EventArgs e)
        {
            geri ana = new geri();
            ana.Show();
            this.Close();
        }

        private void akademisyen_Load(object sender, EventArgs e)
        {
           
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void btakademisyen_Click(object sender, EventArgs e)
        {
            string seciliak = textBox1.Text;
            string kod2 = "SELECT akademisyen.unvan,akademisyen.adsoyad,akademisyen.mail,universite.uniadi FROM akademisyen,universite  WHERE universite.unino=akademisyen.unino AND akademisyen.adsoyad LIKE '%"+seciliak+"%'";

            OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
            DataTable dt2 = new DataTable();
            adapt2.Fill(dt2);
            con.Open();
            dataGridView1.DataSource = dt2;
            con.Close();
            btdersler.Enabled = true;
        }

        private void btdersler_Click(object sender, EventArgs e)
        {

            string seciliakademisyen = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label4.Text = seciliakademisyen;
            label4.Visible = true;
            label5.Text =dataGridView1.CurrentRow.Cells[3].Value.ToString();
            label5.Visible = true;
            
            string kod3 = "SELECT dersler.dersadi FROM dersler,universite,akademisyen,verilenders WHERE universite.uniadi='"+label5.Text+"' AND universite.unino=verilenders.unino AND universite.unino=akademisyen.unino AND verilenders.unino=akademisyen.unino AND verilenders.akno=akademisyen.akno AND verilenders.dersid=dersler.dersid AND akademisyen.adsoyad='"+label4.Text+"';";

            OleDbDataAdapter adapt3= new OleDbDataAdapter(kod3, con);
            DataTable dt3 = new DataTable();
            adapt3.Fill(dt3);
            con.Open();
            listBox1.DisplayMember = "dersadi";
            listBox1.ValueMember = "dersid";
            listBox1.DataSource = dt3;
            con.Close();
             
        }

        

       


    }
}
