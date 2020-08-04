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
    public partial class ders : Form
    {
        public ders()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"bote_diyari.accdb\";Persist Security Info=True");

        private void ders_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            string kod = "SELECT * FROM dersler ORDER BY dersadi";
            OleDbDataAdapter adapt = new OleDbDataAdapter(kod,con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Open();
            listBox1.DataSource = dt;
            listBox1.ValueMember = "dersid";
            listBox1.DisplayMember = "dersadi";
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int secili = Convert.ToInt32(listBox1.SelectedValue);
            string kod = "DELETE FROM dersler WHERE dersid="+secili+"";
            OleDbCommand com = new OleDbCommand(kod,con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(listBox1.Text+" adlı ders silinmiştir.");
            ders_Load(sender,e);

        }

        private void dersekle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string ders = textBox1.Text;
                string kod = "INSERT INTO dersler (dersadi) VALUES ('" + ders + "')";
                OleDbCommand com = new OleDbCommand(kod, con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(ders+" adlı ders eklenmiştir.");
                ders_Load(sender,e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            
            textBox1.Text = listBox1.Text;;
            label2.Text = listBox1.Text ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secili = Convert.ToInt32(listBox1.SelectedValue);
            string ders = textBox1.Text;
            string kod = "UPDATE dersler SET dersadi='"+ders+"' WHERE dersid ="+secili+"";
            OleDbCommand com = new OleDbCommand(kod, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" '"+label2.Text+ "'  '"+ders+" 'Olarak Güncellenmiştir.");
            ders_Load(sender, e);
        }

        private void btgeriak_Click(object sender, EventArgs e)
        {
            adminanasayfa admin = new adminanasayfa();
            admin.Show();
            this.Close();
        }
    }
}
