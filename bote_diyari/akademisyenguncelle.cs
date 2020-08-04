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
    public partial class akademisyenguncelle : Form
    {
        public akademisyenguncelle()
        {
            InitializeComponent();
        }

        private void btgeri_Click(object sender, EventArgs e)
        {
            adminanasayfa admin = new adminanasayfa();
            admin.Show();
            this.Close();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"bote_diyari.accdb\";Persist Security Info=True");

        private void akademisyenguncelle_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            string kod2 = "SELECT * FROM universite ORDER BY uniadi";
            OleDbDataAdapter adapt2 = new OleDbDataAdapter(kod2, con);
            DataTable dt2 = new DataTable();
            adapt2.Fill(dt2);
            cbuni.DataSource = dt2;
            con.Open();
            cbuni.ValueMember = "unino";
            cbuni.DisplayMember = "uniadi";
            con.Close();
        }

        private void btara_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text;
            string kod = "SELECT akademisyen.adsoyad,universite.uniadi,akademisyen.unvan,akademisyen.mail,akademisyen.bastarih,akademisyen.akno  FROM universite ,akademisyen WHERE universite.unino=akademisyen.unino AND akademisyen.adsoyad LIKE '%" + aranan + "%' ORDER BY akademisyen.adsoyad";
            OleDbDataAdapter adapt = new OleDbDataAdapter(kod, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Open();
            dataGridView1.DataSource = dt;
            con.Close();
            btguncelle.Enabled = true;
            dataGridView1.Columns[0].Width = 200;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            if (this.Width != 710)
            {
                this.Width += 10;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Width != 430)
            {
                this.Width -= 10;
            }
        }

        private void btguncelle_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
           

            ad.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            unvan.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbuni.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adı = ad.Text;
            string unvani = unvan.Text;
            int unisi = Convert.ToInt32(cbuni.SelectedValue);
            string maili = mail.Text;
            string tarih = dateTimePicker1.Value.ToShortDateString();

            string kod = "UPDATE akademisyen SET adsoyad='" + adı + "', unvan='" + unvani + "',  unino='" + unisi + "',  mail='" + maili + "',  bastarih='" + tarih + "' WHERE akno=" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value.ToString()) +" ;";
            OleDbCommand com = new OleDbCommand(kod,con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarıyla Güncellenmiştir.");
            timer1.Enabled = false;
            timer2.Enabled = true;

            btara_Click(sender,e);
        }
    }
}
