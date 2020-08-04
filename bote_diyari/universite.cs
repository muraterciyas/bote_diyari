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
    public partial class universite : Form
    {
        public universite()
        {
            InitializeComponent();
        }




        private void btgeriuni_Click_1(object sender, EventArgs e)
        {
            geri ana = new geri();
            ana.Show();
            this.Close();
        }



        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"bote_diyari.accdb\";Persist Security Info=True");
        private void universite_Load(object sender, EventArgs e)
        {
            cbyuksek.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            cbbote.Checked = false;
            string kod = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite";
            con.Open();
            OleDbDataAdapter adapt = new OleDbDataAdapter(kod, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            
        }

        private void cbbote_Click(object sender, EventArgs e)
        {
            if (cbbote.Checked == true)
            {
                cbyuksek.Enabled = true;
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite WHERE botedurumu=Yes";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close(); 
            }
            else if (cbbote.Checked == false)
            {
                cbyuksek.Enabled = false;
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();

               
            }
        }



        private void cbtaban_Click(object sender, EventArgs e)
        {
            //enable özellikleri
            if (cbtaban.Checked) cbtavan.Enabled = false;
            else if (cbtaban.Checked == false) cbtavan.Enabled = true;

            //olasılıklar
            if (cbbote.Checked && cbtaban.Checked == false && cbtavan.Checked == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite WHERE botedurumu=Yes";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }

            else   if (cbbote.Checked && cbtaban.Enabled == false )
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite WHERE botedurumu=Yes  ORDER BY tavanpuan DESC";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }

            else if (cbbote.Checked && cbtavan.Enabled == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite WHERE botedurumu=Yes  ORDER BY tabanpuan DESC";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }

            else if (cbyuksek.Checked && cbtaban.Checked == false && cbtavan.Checked == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite WHERE botedurumu=Yes AND yukseklisans=Yes";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }


            else if (cbyuksek.Enabled == false && cbtavan.Checked == false && cbtaban.Checked == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }
            else if (cbyuksek.Checked  && cbtavan.Enabled == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite WHERE botedurumu=Yes AND yukseklisans=Yes  ORDER BY tabanpuan DESC";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }

            else if (cbyuksek.Checked && cbtaban.Enabled == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite WHERE botedurumu=Yes AND yukseklisans=Yes ORDER BY tavanpuan DESC";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }
            else if (cbbote.Checked == false && cbtaban.Enabled == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite ORDER BY tavanpuan DESC";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }
            else if (cbbote.Checked == false && cbtavan.Enabled == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite ORDER BY tabanpuan DESC";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }
        }



        private void cbtavan_Click(object sender, EventArgs e)
        {
            //enable özellikleri
            if (cbtavan.Checked) cbtaban.Enabled = false;
            else if (cbtavan.Checked == false) cbtaban.Enabled = true;
            //olasılıklar
            if (cbbote.Checked && cbtaban.Checked == false && cbtavan.Checked == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite WHERE botedurumu=Yes";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }

            else if (cbbote.Checked && cbtaban.Enabled == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite WHERE botedurumu=Yes  ORDER BY tavanpuan DESC";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }

            else if (cbbote.Checked && cbtavan.Enabled == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite WHERE botedurumu=Yes AND ORDER BY tabanpuan DESC";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }

            else if (cbyuksek.Checked && cbtaban.Checked == false && cbtavan.Checked == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite WHERE botedurumu=Yes AND yukseklisans=Yes";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }


            else if (cbyuksek.Enabled == false && cbtavan.Checked == false && cbtaban.Checked == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }
            else if (cbyuksek.Checked && cbtavan.Enabled == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite WHERE botedurumu=Yes AND yukseklisans=Yes  ORDER BY tabanpuan DESC";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }

            else if (cbyuksek.Checked && cbtaban.Enabled == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite WHERE botedurumu=Yes AND yukseklisans=Yes ORDER BY tavanpuan DESC";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }
            else if (cbbote.Checked==false && cbtaban.Enabled == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite ORDER BY tavanpuan DESC";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }
            else if (cbbote.Checked == false && cbtavan.Enabled == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite ORDER BY tabanpuan DESC";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }
        }

        private void cbyuksek_Click(object sender, EventArgs e)
        {
            //olasılıklar
            if (cbyuksek.Checked && cbtaban.Checked == false && cbtavan.Checked == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite WHERE botedurumu=Yes AND yukseklisans=Yes";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }


            else if (cbyuksek.Checked == false && cbtavan.Checked == false && cbtaban.Checked == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite WHERE botedurumu=Yes ";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }
            else if (cbyuksek.Checked == true && cbtavan.Enabled == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite WHERE botedurumu=Yes AND yukseklisans=Yes  ORDER BY tabanpuan DESC";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }

            else if (cbyuksek.Checked == true && cbtavan.Enabled == false)
            {
                string kod2 = "SELECT uniadi,kurulustarih,tabanpuan,tavanpuan FROM universite WHERE botedurumu=Yes AND yukseklisans=Yes ORDER BY tabanpuan DESC";
                con.Open();
                OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
                DataTable dt2 = new DataTable();
                adapt2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.Close();
            }
        }


    }
}
